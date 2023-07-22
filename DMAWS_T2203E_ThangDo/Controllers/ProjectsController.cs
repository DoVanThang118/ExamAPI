using Microsoft.AspNetCore.Mvc;

namespace DMAWS_T2203E_ThangDo.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
