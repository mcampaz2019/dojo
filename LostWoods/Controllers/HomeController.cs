using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LostWoods.Models;
using LostWoods.Factory;

namespace LostWoods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory _trailFactory;
        public HomeController(TrailFactory tFactory)
        {
            _trailFactory =  tFactory;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var  AllTrails = _trailFactory.FindAll();
            return View(AllTrails);
        }

        [HttpGet("NewTrail")]
        public IActionResult NewTrail()
        {
            return View();
        }

        [HttpPost("ProcessAdd")]
        public IActionResult ProcessAdd(LostWoods.Models.Trail newTrail)
        {
            if(ModelState.IsValid)
            {
                _trailFactory.Add(newTrail);
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewTrail");
            }
        }

        [HttpGet("/trails/{Id}")]
        public IActionResult Trails(int Id)
        {
            var trailToDisplay = _trailFactory.FindById(Id);
            return View(trailToDisplay);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
