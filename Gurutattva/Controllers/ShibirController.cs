using Gurutattva.Data;
using Gurutattva.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gurutattva.Controllers
{
    public class ShibirController : Controller
    {
        private ApplicationDbContext _db { get; set; }

        public ShibirController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var shibirs = _db.Shibirs
               //.Include(m => m.Category)
               .OrderBy(m => m.FirstName)
               .ToList();
            return View(shibirs);
            
        }

        //[HttpPost]
        //public IActionResult Index(string id) 
        //{
        //    return RedirectToAction("Index", "Home");
        //}


        [HttpGet]
        public IActionResult Add()
        {
            Shibir shibir = new Shibir();
            ViewBag.Action = "Add";
            //ViewBag.Categories = _db.Shibirs.OrderBy(g => g.CategoryName).ToList();
            return View("Edit", shibir);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            //ViewBag.Categories = _db.Categories.OrderBy(g => g.CategoryName).ToList();
            var shibir = _db.Shibirs.Find(id);
            return View(shibir);
        }

        [HttpPost]
        public IActionResult Edit(Shibir shibir)
        {
            if (ModelState.IsValid)
            {
                //ShibirValidator validator = new ShibirValidator();
                //validator.Validate(shibir);
                if (shibir.Id == 0)
                    _db.Shibirs.Add(shibir);
                else
                    _db.Shibirs.Update(shibir);
                _db.SaveChanges();
                return RedirectToAction("Index", "Shibir");
            }
            else
            {
                ViewBag.Action = (shibir.Id == 0) ? "Add" : "Edit";
                //ViewBag.Categories = _db.Shibirs.OrderBy(g => g.CategoryName).ToList();
                return View(shibir);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var shibir = _db.Shibirs.Find(id);
            return View(shibir);
        }

        [HttpPost]
        public IActionResult Delete(Shibir shibir)
        {
            _db.Shibirs.Remove(shibir);
            _db.SaveChanges();
            return RedirectToAction("Index", "Shibir");
        }

        public IActionResult Details(int id)
        {
             Shibir shibir = _db.Shibirs
             .FirstOrDefault(p => p.Id == id);
               

            // bind product to view
            return View(shibir);
        }

    }
}
