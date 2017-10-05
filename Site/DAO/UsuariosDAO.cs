using Site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Site.DAO
{
    public class UsuariosDAO
    {
        public static IList<UsuarioDTO> Usuarios = new List<UsuarioDTO>();

        public void Adiciona(UsuarioDTO u)
        {
            Usuarios.Add(u);
        }

        public UsuarioDTO Busca(string email, string senha)
        {
            return Usuarios.Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();
        }
    }
}