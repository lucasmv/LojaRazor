using LojaRazor.DAO;
using LojaRazor.Models;
using System.Web.Mvc;

namespace LojaRazor.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult Form(string email)
        {
            Usuario usuario = new Usuario()
            {
                Email = email
            };

            return View(usuario);
        }

        public ActionResult Cadastra(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                UsuariosDAO dao = new UsuariosDAO();

                dao.Adiciona(usuario);

                Session["usuarioLogado"] = usuario.Nome;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Form", usuario);
            }
        }

    }
}
