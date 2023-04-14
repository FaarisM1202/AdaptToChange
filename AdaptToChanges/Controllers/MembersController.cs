using Microsoft.AspNetCore.Mvc;

namespace AdaptToChanges.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
