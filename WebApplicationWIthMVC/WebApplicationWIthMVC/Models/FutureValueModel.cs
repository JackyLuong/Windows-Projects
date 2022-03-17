using System.ComponentModel.DataAnnotations;

namespace WebApplicationWIthMVC.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please enter monthly investment.")]
        [Range(1,1000, ErrorMessage = "Monthly investment must be between 1 and 1000")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter annual interest rate as a percentage.")]
        [Range(1, 20, ErrorMessage = "Annual interest rate must be between 1 and 20 percent")]
        public decimal? AnnualInterestRate { get; set; }// percent

        [Required(ErrorMessage = "Please enter the numbers of year(s) you wish to invest.")]
        [Range(1, 50, ErrorMessage = "Years must be between 1 and 50 years")]
        public int? Years { get; set; }

        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyInterestRate = AnnualInterestRate / 12 / 100; // decimal
            decimal? futureValue = 0;

            for(int m = 0; m < months; m++) // for each month
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
