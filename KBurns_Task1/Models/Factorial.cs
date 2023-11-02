using KBurns_Task1.Controllers;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KBurns_Task1.Models
{
    public class Factorial
    {
        [Required]
        [Display(Name = "Your Input:")]
        public int UserInput { get; set; }

        //long to store bigger whole numbers
        public long FactorialCalculation { get; set; }

        [Display(Name = "Factorial: ")]
        public string FactorialOutput { get; set; }

        //this method will calculate the factorial based on user input
        public void FactorialLogic()
        {
            long sum = 1;

            for (int i = 1; i <= UserInput; i++)
            {
                sum *= i;
            }

            FactorialCalculation = sum;
        }

        //increases readability
        //formats factorial answer with commas
        public void FormatLargeNumberWithCommas(long FactorialCalculation)
        {
            FactorialOutput = string.Format("{0:#,0}", FactorialCalculation);
        }
    }
}