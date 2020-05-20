using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EAD_Project.Models;

namespace EAD_Project.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        public ActionResult Index()
        {
            var selection = dc.Books.Select(b => b.Category).Distinct();
            ViewBag.data = selection;
            Session["category"] = "all";

            return View();
        }

        public ActionResult Books()
        {
            List<Book> model;
            string cat;

            try
            {
                cat = Request["category"].ToString();
                Session["category"] = cat;
            }
            catch(Exception)
            {
                cat = Session["category"].ToString();
            }
            
            if (cat.Equals("all"))
                model = dc.Books.OrderBy(b => b.Category).ToList();
            else
                model = dc.Books.Where(b => b.Category.Equals(cat)).ToList();

            if (!model.Any())
            {
                model = dc.Books.OrderBy(b => b.Category).ToList();
            }

            ViewBag.result = model;

            return View();
        }

        [HttpPost]
        public ActionResult DeleteBook()
        {
            int id = Convert.ToInt32(Request["book_ID"]);
            Book book = dc.Books.First(b => b.Id == id);
            dc.Books.DeleteOnSubmit(book);
            dc.SubmitChanges();

            return RedirectToAction("Books");
        }

        public ActionResult AddBook()
        {
            var selection = dc.Books.Select(b => b.Category).Distinct();
            ViewBag.data = selection;
            return View();
        }

        [HttpPost]
        public ActionResult InsertBook()
        {
            Book book = new Book();

            book.Title = Request["title"].ToString();
            book.Author = Request["author"].ToString();
            book.Description = Request["desc"].ToString();
            string cat = Request["category"].ToString();

            if (cat.Equals("Other"))
                book.Category = Request["otherC"].ToString();
            else
                book.Category = cat;
            
            dc.Books.InsertOnSubmit(book);
            dc.SubmitChanges();

            Session["category"] = book.Category;

            return RedirectToAction("Books");
        }

        [HttpPost]
        public ActionResult EditBook()
        {
            var selection = dc.Books.Select(b => b.Category).Distinct();
            ViewBag.data = selection;

            Book book = dc.Books.First(b => b.Id == Convert.ToInt32(Request["book_ID"]));
            ViewBag.Id = book.Id;
            ViewBag.bTitle = book.Title;
            ViewBag.Author = book.Author;
            ViewBag.Description = book.Description;
            ViewBag.Category = book.Category;

            return View();
        }

        [HttpPost]
        public ActionResult UpdateBook()
        {
            Book book = dc.Books.First(b => b.Id == Convert.ToInt32(Request["book_ID"]));

            book.Title = Request["title"].ToString();
            book.Author = Request["author"].ToString();
            book.Description = Request["desc"].ToString();
            string cat = Request["category"].ToString();

            if (cat.Equals("Other"))
                book.Category = Request["otherC"].ToString();
            else
                book.Category = cat;

            dc.SubmitChanges();

            return RedirectToAction("Books");
        }

    }
}
