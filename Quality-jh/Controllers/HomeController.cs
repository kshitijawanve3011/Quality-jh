using Microsoft.AspNetCore.Mvc;
using Quality_jh.Models;
using System.Diagnostics;

namespace Quality_jh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            

            ViewBag.NABHMandatoryTraning = new List<string>
            {
                "InfactionControlAndPrevantion", "QualityAndPatientSafety", "SafetyTrainings","BasicLifeSupport(BLS)","ACC"
            };

            ViewBag.SoftSkillOptions = new List<string>
            {
                "SST", 
            };
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
