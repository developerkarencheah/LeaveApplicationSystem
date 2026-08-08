using LeaveApplicationSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveApplicationSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Karen Cheah from MVC Master Class ",
                DOB = new DateTime(1973, 2, 25)
            };
            return View(data);
        }
    }
}
