namespace Site.Models
{
    public class CategoriaDTO
    {
        public string Nome { get; set; }

        public CategoriaDTO(string nome)
        {
            Nome = nome;
        }
    }
}