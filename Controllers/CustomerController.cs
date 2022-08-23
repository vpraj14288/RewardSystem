using Microsoft.AspNetCore.Mvc;

namespace RewardSystem.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
