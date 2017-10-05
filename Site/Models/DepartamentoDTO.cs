using System.Collections.Generic;

namespace Site.Models
{
    public class DepartamentoDTO
    {
        public string Nome { get; set; }

        public IList<CategoriaDTO> Categorias { get; set; }

        public DepartamentoDTO()
        {
            Categorias = new List<CategoriaDTO>();
        }
    }
}