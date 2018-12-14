using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers

{
    public class ClockController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
