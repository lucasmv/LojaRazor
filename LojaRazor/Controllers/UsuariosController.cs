using LojaRazor.DAO;
using LojaRazor.Models;
using System.Web.Mvc;

namespace LojaRazor.Controllers
{
    public class UsuariosController : Controller
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
