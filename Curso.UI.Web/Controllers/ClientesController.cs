using Microsoft.AspNetCore.Mvc;

namespace Curso.UI.Web.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
