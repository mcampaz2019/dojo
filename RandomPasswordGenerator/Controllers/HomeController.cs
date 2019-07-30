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
        public char generateNext()
        {
            List<char> cipher = new List<char>(){ 
                                '0','1','2','3','4','5','6','7','8','9',
                                'a','b','c','d','e','f','g','h','i','j',
                                'l','m','n','o','p','q','r','s','t','u','v',
                                'w','x','y','z'
                                };
            Random random = new Random();  
            
            int index = random.Next(0, cipher.Count);
            int toUpper = random.Next(0,2);
            if(toUpper == 0)
            {
                return cipher[index];
            }
            else
            {
                return System.Char.ToUpper(cipher[index]);
            }
        }

        public string generatePass(int codeLength){
            string code = String.Empty;
            for(int i = 0; i < codeLength; i++)            
            {
                code += generateNext();
            }
            return code;                
        }
    
        [HttpGet("")]
        public IActionResult Index()
        {            
            if(HttpContext.Session.GetString("code") == null)
            {
                string code = generatePass(14);                
                HttpContext.Session.SetString("code", code);
            }
            if(HttpContext.Session.GetInt32("times") == null)
            {
                HttpContext.Session.SetInt32("times", 1);                
            }
            ViewBag.Code = HttpContext.Session.GetString("code");
            ViewBag.Count = HttpContext.Session.GetInt32("times");
            return View();
        }

        [HttpGet("Generate")]
        public IActionResult Generate()
        {
            string code = generatePass(14);
            
            int? counting = HttpContext.Session.GetInt32("times");
            counting++;
            HttpContext.Session.SetString("code", code);
            HttpContext.Session.SetInt32("times", (int)counting);
            return RedirectToAction("Index");
        }
    }
}
