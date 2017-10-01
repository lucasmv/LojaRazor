using LojaRazor.DAO;
using LojaRazor.Util;
using System.Web.Mvc;

namespace LojaRazor.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {          
            var produtosDAO = new ProdutosDAO();

            ViewBag.Produtos = produtosDAO.Ofertas();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }

        #region Gerenciar Idioma
        public ActionResult SetCulture(string culture)
        {
            culture = CultureHelper.GetImplementedCulture(culture);
            RouteData.Values["culture"] = culture;

            return RedirectToAction("Index");
        }
        #endregion
    }
}
