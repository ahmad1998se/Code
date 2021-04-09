using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Third.Models;
using Third.ViewModels;
using System.Data.Entity;
using System.Net;

namespace Third.Controllers
{
    public class ProductController : Controller
    {
        private StoreContext _context;

        public ProductController()
        {
            _context = new StoreContext();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();

            base.Dispose(disposing);
        }

        public ActionResult Create()
        {
            var categories = _context.Categories.ToList();
           var viewModel=new ProductFromViewModel
           {
               Product = new Product(),
               Categories = categories

           };
           return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Content("Get Saved");
        }




        // GET: Product
        public ActionResult Index()
        {
            var products = _context.Products.Include(c=>c.Category).ToList();




            return View(products);
        }


        public ActionResult Edit(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);


            var product = _context.Products.SingleOrDefault(m => m.Id == id);
            if (product == null)
                return HttpNotFound();
            var viewModel = new ProductFromViewModel
            {
                Product = product,
                Categories = _context.Categories.ToList()


            };
            return View("Create", viewModel);

        }
    }
}