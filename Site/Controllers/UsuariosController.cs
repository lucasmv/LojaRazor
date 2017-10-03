using Site.DAO;
using Site.Models;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class UsuariosController : BaseController
    {
        public ActionResult Form(string email)
        {
            var usuario = new Usuario()
            {
                Email = email
            };

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Cadastra(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var dao = new UsuariosDAO();

                dao.Adiciona(usuario);

                Session["usuarioLogado"] = usuario.Nome;

                return RedirectToAction("Index", "Home");
            }

            return View("Form", usuario);

        }

    }
}