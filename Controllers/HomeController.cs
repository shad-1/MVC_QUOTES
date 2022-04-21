using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpencersQualityQuotes.Models;

namespace SpencersQualityQuotes.Controllers
{
    public class HomeController : Controller
    {
        private IQuoteRepository _repo;

        public HomeController(IQuoteRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var quotes = _repo.Quotes.OrderBy(q => q.Author).ToList();
            return View(quotes);
        }

        public IActionResult Details(int id)
        {
            var quote = _repo.Quotes.FirstOrDefault(q => q.Id == id);
            return View(quote);
        }

        //EDIT
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var quote = _repo.Quotes.FirstOrDefault(q => q.Id == id);
            return View(quote);
        }

        [HttpPost]
        public IActionResult Edit(Quotation q)
        {
            if (ModelState.IsValid)
                _repo.UpdateQuote(q);
            else
                return View(q);

            return RedirectToAction("Index");
        }

        //DELETE
        //Only needs get because of use of confirmation modal
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var toDelete = _repo.Quotes.FirstOrDefault(q => q.Id == id);
            _repo.DeleteQuote(toDelete);

            return RedirectToAction("Index");
        }

        //ADD
        //Add actions use the Edit form
        [HttpGet]
        public IActionResult Add()
        {
            return View("Edit");
        }

        [HttpPost]
        public IActionResult Add(Quotation q)
        {
            if (ModelState.IsValid)
                _repo.AddQuote(q);
            else
                return View("Edit", q);

            return RedirectToAction("Index");
        }

        //RANDOM
        //Generates a random number referencing an index of the array of quotes
        [HttpGet]
        public IActionResult Random()
        {
            Random rand = new Random();
            var quotes = _repo.Quotes.ToArray();
            var q = quotes[rand.Next(quotes.Count())];
            return View(q);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

