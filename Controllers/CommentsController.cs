using Microsoft.AspNetCore.Mvc;

namespace The_Recipe_House.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
