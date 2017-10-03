using Site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Site.DAO
{
    public class UsuariosDAO
    {
        public static IList<Usuario> Usuarios = new List<Usuario>();

        public void Adiciona(Usuario u)
        {
            Usuarios.Add(u);
        }

        public Usuario Busca(string email, string senha)
        {
            return Usuarios.Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();
        }
    }
}