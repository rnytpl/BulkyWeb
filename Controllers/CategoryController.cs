using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // Create a list of Category type
            // Retrieve categories in a list from database and assign it to objCategoryList 
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            //_db.Categories.Add(obj);
            //_db.SaveChanges();
            return View();
        }

        [HttpPost]

        public IActionResult Create(Category obj)
        {
            // Ensure all requirements are met defined in associated Model
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();


        }
    }
}
 