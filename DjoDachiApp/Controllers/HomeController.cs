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
        DojoDachiPet dachiPet = new DojoDachiPet();

        [HttpGet]
        public IActionResult Index()
        {
            
            HttpContext.Session.SetObjectAsJson("myDachiPet", dachiPet);
            return RedirectToAction("dojodachi");
        }

        [HttpGet("dojodachi")]
        public IActionResult DojoDachi(){
            DojoDachiPet thisDachiPet = HttpContext.Session.GetObjectFromJson<DojoDachiPet>("myDachiPet");
            ViewBag.Fullness = thisDachiPet.Fullness;
            ViewBag.Happiness = thisDachiPet.Happiness;
            ViewBag.Meals = thisDachiPet.Meals;
            ViewBag.Energy = thisDachiPet.Energy;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }    
}
