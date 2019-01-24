using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
      {
        public IActionResult Index()
        {
            return Content("Books Controller Index");
        }
         public IActionResult New()
        {
            return Content("Books Controller New");
        }
         public IActionResult best_sellers()
        {
            return Content("Books Controller Best");
        }
    }
}