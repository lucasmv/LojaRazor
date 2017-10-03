using Site.DAO;
using Site.Util;
using System.Web.Mvc;

namespace Site.Controllers
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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