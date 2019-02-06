using System;
using Microsoft.AspNetCore.Mvc;

// this file shows how to do arrtibute-based routing

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller
      {
         [Route("")] //handles the route '/books'
         [Route("index")] //handles route '/books/index'
        public IActionResult Index()
        {
            return View();
        }
         [Route("new")]
         public IActionResult New()
        {
           return View();
        }
         [Route("best-sellers")]
         public IActionResult Best()
        {
            return View();
        }
    }
}