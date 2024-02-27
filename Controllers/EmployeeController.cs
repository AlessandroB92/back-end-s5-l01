using Microsoft.AspNetCore.Mvc;

namespace back_end_s5_l01.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
