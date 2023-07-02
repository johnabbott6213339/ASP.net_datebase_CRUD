using Microsoft.AspNetCore.Mvc;

namespace OREILLY_databaseCRUD.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
