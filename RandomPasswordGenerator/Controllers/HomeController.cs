using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RandomPasswordGenerator.Models;

namespace RandomPasswordGenerator.Controllers
{
    
    public class HomeController : Controller
    {    
        List<char> cipher = new List<char>(){ 
                                '0','1','2','3','4','5','6','7','8','9',
                                'a','b','c','d','e','f','g','h','i','j',
                                'l','m','n','o','p','q','r','s','t','u','v',
                                'w','x','y','z'
                                };
        Random random = new Random();  
        string code = String.Empty;
        
        
        
        public char generateNext(){
            int index = this.random.Next(0, cipher.Count);
            int toUpper = this.random.Next(0,2);
            if(toUpper == 0)
            {
                return cipher[index];
            }
            else
            {
                return System.Char.ToUpper(cipher[index]);
            }
        }
    
        public IActionResult Index()
        {            
            if(HttpContext.Session.GetInt32("count") == null)
            {
                HttpContext.Session.SetInt32("count", 1);
                for(int i = 0; i < 14; i++)            
                {
                    code += generateNext();
                }
                HttpContext.Session.SetString("code", code.ToString());
            }
            else
            {
                int? counter = HttpContext.Session.GetInt32("count") + 1;
                HttpContext.Session.SetInt32("count", (int)counter);                
            }
            ViewBag.Count = HttpContext.Session.GetInt32("count");
            ViewBag.Code = HttpContext.Session.GetString("code");
            return View();
        }

        [HttpPost("Generate")]
        public IActionResult Generate()
        {
            for(int i = 0; i < 14; i++)            
            {
                code += generateNext();
            }
            ViewBag.Count = HttpContext.Session.GetInt32("count");
            HttpContext.Session.SetString("code", code.ToString());
            ViewBag.Code = HttpContext.Session.GetString("code");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
