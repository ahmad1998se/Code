using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Third.Models;

namespace Third.Controllers
{
    public class CategoryController : Controller
    {

        private StoreContext _context;

        public CategoryController()
        {
            _context = new StoreContext();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();

            base.Dispose(disposing);
        }

        // GET: Category
        public ActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        public ActionResult Create()
        {
            return View(new Category { Id = 0 });
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", category);

            }

            if (category.Id > 0)
            {

                _context.Entry(category).State = System.Data.Entity.EntityState.Modified;

            }
            else
            {
                _context.Categories.Add(category);

            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {


            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var category = _context.Categories.SingleOrDefault(m => m.Id == id);
            if (category == null)
                return HttpNotFound();
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult Edit(int id)
        {

            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var category = _context.Categories.SingleOrDefault(m => m.Id == id);
            if (category == null)
                return HttpNotFound();

            return View("Create", category);

        }
    }
}