using baitapltw.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitapltw.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListProduct()
        {
            BookManagerContext context = new BookManagerContext();  
            var listBook = context.Products.ToList();
            return View(listBook);
        }
        public ActionResult Create()
        {
            BookManagerContext context = new BookManagerContext();
            List<Product> products = context.Products.ToList();
            context.SaveChanges();
            return View();
        }
    }
}