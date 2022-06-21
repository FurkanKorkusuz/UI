
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        public UserController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public JsonResult GetList()
        //{
        //    QueryParameter qp = new QueryParameter(); 
        //    return Json(_userService.GetList(qp));
        //}

    }
}
