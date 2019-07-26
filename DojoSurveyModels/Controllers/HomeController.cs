using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModels.Models;

namespace DojoSurveyModels.Controllers
{    


    public class HomeController : Controller
    {
        List<string> location = new List<string>(){
            "Berkeley, CA",
            "Boise, ID",
            "Chicago, IL",
            "Dallas, TX",
            "Los Angeles, CA",
            "Orange County, CA",
            "Seattle, WA",
            "Silicon Valley, CA",
            "Tulsa, OK",
            "Tysons Corner, VA",
            "Online"
        };
        List<string> language = new List<string>(){
            "C",
            "C++",
            "C#",
            "Objective C",
            "Java",
            "Basic",
            "JavaScript",
            "Python",
            "Scala",
            "Go",
            "Swift",
            "Ruby"
        };
        public IActionResult Index()
        {            
            ViewBag.language = this.language;
            ViewBag.location = this.location;
            Console.WriteLine(ViewBag);
            return View();
        }

        [HttpPost("commentresult")]
        public IActionResult CommentResult(string name, string location, string language, string message)
        {
            DojoComment model = new DojoComment()
            {
                Name = name,
                DojoLocation = location,
                FavoriteLanguage = language,
                Comment = message
            };
            
            return View("CommentResult", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
