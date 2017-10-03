using Site.Models;
using System.Collections.Generic;

namespace Site.DAO
{
    public class DepartamentosDAO
    {
        public IList<Departamento> Lista()
        {
            return new List<Departamento>()
            {
                NovoDepartamento("Informática", "Notebooks", "Monitores", "HDs"),
                NovoDepartamento("Eletrônicos", "TVs", "Rádios", "Video Cassete", "DVD Players"),
                NovoDepartamento("Entretenimento", "Filmes", "Músicas", "Brinquedos"),
                NovoDepartamento("Livros", "Aventura", "Ficção", "Universitários", "Romances", "Terror")
            };
        }

        private Departamento NovoDepartamento(string nome, params string[] categorias)
        {
            Departamento departamento = new Departamento
            {
                Nome = nome
            };

            foreach (string nomeCategoria in categorias)
                departamento.Categorias.Add(new Categoria(nomeCategoria));

            return departamento;
        }
    }
}