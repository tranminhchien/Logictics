
using Logictics.Web.Auth;
using Logictics.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logictics.Web.Areas.Admin.Controllers
{
    [Area(Role.Admin)]
    [LogicticsAuthorize(Role.Admin)]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
