using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DjoDachiApp.Models;

namespace DjoDachiApp.Controllers
{
    public class HomeController : Controller
    {
        

        [HttpGet]
        public IActionResult Index()
        {
            DojoDachiPet dachiPet = new DojoDachiPet();
            HttpContext.Session.SetObjectAsJson("myDachiPet", dachiPet);
            return RedirectToAction("dojodachi", dachiPet);
        }

        [HttpGet("dojodachi")]
        public IActionResult DojoDachi(DojoDachiPet thisDachiPet){
            DojoDachiPet thisDachiPet = HttpContext.Session.GetObjectFromJson<DojoDachiPet>("myDachiPet");
            // ViewBag.Fullness = thisDachiPet.Fullness;
            // ViewBag.Happiness = thisDachiPet.Happiness;
            // ViewBag.Meals = thisDachiPet.Meals;
            // ViewBag.Energy = thisDachiPet.Energy;
            return View("dojodachi", thisDachiPet);
        }

        [HttpPost("processMove")]
        public IActionResult ProcessMove(string move){
            DojoDachiPet thisDachiPet = HttpContext.Session.GetObjectFromJson<DojoDachiPet>("myDachiPet");
            if(move == "play"){thisDachiPet.playWith();}
            if(move == "feed"){thisDachiPet.feed();}
            if(move == "sleep"){thisDachiPet.sleep();}
            if(move == "work"){thisDachiPet.work();}
            HttpContext.Session.SetObjectAsJson("myDachiPet", thisDachiPet);
            return RedirectToAction("dojodachi", thisDachiPet);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }    
}
