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

        [HttpPost("addquote")]
        public IActionResult AddQuote(Quote thisQuote)
        {
            if(thisQuote != null)
            {
                String query = $"INSERT INTO quote (name, quote_statement) VALUES ('{thisQuote.UserName}', '{thisQuote.QuoteStatement}')";
                DbConnector.Execute(query);
            }
            return RedirectToAction("quotes");
        }

        [HttpPost("skipquotes")]
        public IActionResult SkipQuotes(Quote thisQuote)
        {
            return View("Index");
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quote");
            ViewBag.Quotes = AllQuotes;
            
            return View("Quotes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
