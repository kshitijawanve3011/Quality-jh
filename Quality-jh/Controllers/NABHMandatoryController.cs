using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Quality_jh.Controllers
{
    public class NABHMandatoryTraning : Controller
    {
        
        public class InfectionControlController : Controller
        {
           public IActionResult InfectionControlAndPrevention()
           {

                return View();
           }
        }

        public IActionResult QualityAndPatientSafety()
        {
            return View();
        }

        public IActionResult SafetyTrainings()
        {
            return View();
        }

        public IActionResult BasicLifeSupportBLS()
        {
            return View();
        }
        public IActionResult ACC()
        {
            
            return View();
        }
    }
}
