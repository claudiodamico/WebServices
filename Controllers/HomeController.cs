using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebServices.Data;

namespace WebServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebServicesDbContext _context;
        private List<SelectListItem> _empleadoItems;
        public HomeController(WebServicesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listaEmpleados = _context.Empleados.ToList();
            _empleadoItems = new List<SelectListItem>();

            foreach (var item in listaEmpleados)
            {
                _empleadoItems.Add(new SelectListItem
                {
                    Text = item.Nombre,
                    Value = item.RolId.ToString()
                });
            }

            ViewBag.empleadoItems = _empleadoItems;

            return View();
        }

        // AQUÍ EL DESPLEGABLE DE ROLES
        public JsonResult GetRolesList(int RolId)
        {
            var roles = _context.Roles.Where(x => x.RolId == RolId).ToList();

            return Json(roles);
        }
    }
}