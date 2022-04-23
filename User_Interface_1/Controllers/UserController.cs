using Microsoft.AspNetCore.Mvc;
using User_Interface_1.Data;
using User_Interface_1.Models;

namespace User_Interface_1.Controllers
{
    public class UserController : Controller
    {
        private readonly UIDbContext _db;

        public UserController(UIDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objUserList= _db.Users;
            return View(objUserList);

        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            
                _db.Users.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            

                      
           
        }
    }
}
