using Site.Models;
using System.Collections.Generic;

namespace Site.DAO
{
    public class DepartamentosDAO
    {
        public IList<DepartamentoDTO> Lista()
        {
            return new List<DepartamentoDTO>()
            {
                NovoDepartamento("Informática", "Notebooks", "Monitores", "HDs"),
                NovoDepartamento("Eletrônicos", "TVs", "Rádios", "Video Cassete", "DVD Players"),
                NovoDepartamento("Entretenimento", "Filmes", "Músicas", "Brinquedos"),
                NovoDepartamento("Livros", "Aventura", "Ficção", "Universitários", "Romances", "Terror")
            };
        }

        private DepartamentoDTO NovoDepartamento(string nome, params string[] categorias)
        {
            DepartamentoDTO departamento = new DepartamentoDTO
            {
                Nome = nome
            };

            foreach (string nomeCategoria in categorias)
                departamento.Categorias.Add(new CategoriaDTO(nomeCategoria));

            return departamento;
        }
    }
}