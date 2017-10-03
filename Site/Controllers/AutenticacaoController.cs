using Site.DAO;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class AutenticacaoController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(string email, string senha)
        {
            var dao = new UsuariosDAO();

            var usuarioLogado = dao.Busca(email, senha);

            if (usuarioLogado != null)
            {
                Session["usuarioLogado"] = usuarioLogado.Nome;
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}