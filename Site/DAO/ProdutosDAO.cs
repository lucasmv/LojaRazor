using Site.Models;
using System.Collections.Generic;

namespace Site.DAO
{
    public class ProdutosDAO
    {
        public IList<ProdutoDTO> Ofertas()
        {
            return new List<ProdutoDTO>() {
                new ProdutoDTO("Monitor C123", "Monitor mais barato do mundo!!", 3m),
                new ProdutoDTO("Monitor C987", "Melhor monitor do mundo fabricado por uma empresa desconhecida", 1000m),
                new ProdutoDTO("HD 500TB", "HD de 500 TB, muito espaço para seus arquivos", 50000m)
            };
        }
    }
}