using FlyByNight_3_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FlyByNight_3_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MortgageCalculatorInput()
        {
            ViewData["Title"] = "Mortgage Calculator";
            return View();
        }

        public IActionResult MortgageCalculatorResult(MortgageLoanEstimate mortgageLoanEstimate)
        {
            ViewData["Title"] = "Mortgage Calculator";
            return View(mortgageLoanEstimate);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
