using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAP.Mvc.Controllers
{
    public class LibraryController : Controller
    {
        private readonly Business.BookManager _bookManager;

        public LibraryController()
        {
            _bookManager = new Business.BookManager();
        }

        public ActionResult Index()
        {
            var books = _bookManager.GetAllBooksFromDataModel();
            return View(books);
        }
    }
}