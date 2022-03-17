using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InlandMarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using InlandMarinaMVC.Validations;

namespace InlandMarinaMVC.Controllers
{
    public class AccountController : Controller
    {
        //Route: /Account/Login
        public IActionResult Login(string returnUrl = "")
        {
            if (returnUrl != null)
                TempData["Return Url"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(Customer customer)
        {
            Customer cust = CustomerManager.Authenticate(customer.Username, customer.Password);
            if (cust == null)//authentication failed
            {
                return View(); // return to login page
            }
            //Get owner id from user if the user is a owner and store it in session object
            //if (cust.Role == "Owner")
            HttpContext.Session.SetInt32("CurrentCustomer", (int)cust.ID);
            //else
            //    HttpContext.Session.SetInt32("CurrentOwner", 0);

            // authentication passed
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, cust.FirstName + " " + cust.LastName),
                new Claim("FirstName", cust.FirstName),
                new Claim("LastName", cust.LastName),
                new Claim("Phone", cust.Phone),
                new Claim("City", cust.City),
            };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies"); // cookie authentication
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync("Cookies", claimsPrincipal);

            if (String.IsNullOrEmpty(TempData["Return Url"].ToString())) // no url found
            {
                return RedirectToAction("Index", "Home"); // return to main page
            }
            else
            {
                return Redirect(TempData["Return Url"].ToString()); // return to url
            }
        }
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync("Cookies");
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home"); // return to main page
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                if (!IsStringUnique.IsValid(CustomerManager.GetAllUsernames(), customer.Username))
                    ModelState.AddModelError("Username", "Username already exists");
                if (ModelState.IsValid)
                {
                    CustomerManager.AddCustomer(customer);
                    return RedirectToAction("Index", "Home");
                } 
                else
                {
                    ModelState.AddModelError(string.Empty, "Please correct all errors");
                    return View(customer);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
