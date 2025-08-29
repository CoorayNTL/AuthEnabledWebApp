using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AuthEnabledWebApp.Controllers
{
    [Authorize]
    public class ProtectedController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = User.Identity?.Name ?? "User";
            return View();
        }
    }
}
