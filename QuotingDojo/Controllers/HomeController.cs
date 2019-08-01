using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("processQuote")]
        public IActionResult ProcessQuote(Quote thisQuote, string name)
        {
            if(name == "add")
            {
                String query = $"INSERT INTO 'the_quoting_dojo'.'quote' ('name', 'quote_statement') VALUES ('{thisQuote.Name}', '{thisQuote.QuoteStatement}')";
                DbConnector.Execute(query);
            }
            return RedirectToAction("quotes");
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            return View("Quotes");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
