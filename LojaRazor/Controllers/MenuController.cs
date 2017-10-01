using LojaRazor.DAO;
using System.Web.Mvc;

namespace LojaRazor.Controllers
{
    public class MenuController : BaseController
    {
        public ActionResult Index()
        {
            var departamentosDAO = new DepartamentosDAO();

            ViewBag.Departamentos = departamentosDAO.Lista();

            return View();
        }
    }
}