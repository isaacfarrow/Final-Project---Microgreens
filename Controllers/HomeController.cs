using System.Diagnostics;
using Microgreens.Models;
using Microgreens.Services;
using Microsoft.AspNetCore.Mvc;

namespace Microgreens.Controllers

{
    public class HomeController : Controller
    {
        private readonly ITextFileOperations _textFileOperations;

        public HomeController(ITextFileOperations textFileOperations)
        {
            _textFileOperations = textFileOperations;
        }



        public IActionResult Index()
        {
            ViewBag.Steve = "Welcome to Visitor Management";
            ViewData["Sam"] = "Another welcome";

            ViewBag.NewVisitor = new Visitors()
            {
                FirstName = "Howard",
                LastName = "Jones"
            };
            //   Environment myEnvironment = new Environment;
            //======= Conditions of Acceptance
            //Gets or sets the absolute path to the directory that contains the web-servable application content files.

            ViewData["Conditions"] = _textFileOperations.LoadConditionsForAcceptanceText();

            return View();
        }

        public IActionResult StaffNamesAPI()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
