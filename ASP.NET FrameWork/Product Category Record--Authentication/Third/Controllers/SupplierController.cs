using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Third.Models;

namespace Third.Controllers
{
    public class SupplierController : Controller
    {
        private StoreContext _context;

        public SupplierController()
        {
            _context = new StoreContext();
        }
        
        // GET: Supplier
        public ActionResult Index()
        {
            var supplier = _context.Supplier.ToList();
            ViewBag.Supplier = supplier;
                  return View();
        }
    }
}