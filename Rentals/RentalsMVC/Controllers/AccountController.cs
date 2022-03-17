using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentalsMVC.Controllers
{
    public class AccountController : Controller
    {
        //Route: /Account/Login
        public IActionResult Login(string returnUrl="")
        {
            if (returnUrl != null)
                TempData["Return Url"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(User user)
        {
            User usr = UserManager.Authenticate(user.Username, user.Password);
            if(usr == null)//authentication failed
            {
                return View(); // return to login page
            }
            //Get owner id from user if the user is a owner and store it in session object
            if(usr.Role == "Owner")
                HttpContext.Session.SetInt32("CurrentOwner", (int)usr.OwnerId);
            else
               HttpContext.Session.SetInt32("CurrentOwner", 0);
            // authentication passed
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usr.Username),
                new Claim("FullName", usr.FullName),
                new Claim(ClaimTypes.Role, usr.Role),
            };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies"); // cookie authentication
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync("Cookies", claimsPrincipal);

            if (String.IsNullOrEmpty(TempData["Return Url"].ToString())) // no url found
            {
                return RedirectToAction("Index", "Rentals"); // return to main page
            }
            else
            {
                return Redirect(TempData["Return Url"].ToString()); // return to url
            }
        }
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Index", "Rentals"); // return to main page
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
