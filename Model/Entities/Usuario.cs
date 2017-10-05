using System;

namespace Model.Entities
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Observacoes { get; set; }
        public bool RecebePromocoes { get; set; }
        public Sexo Sexo { get; set; }
    }
}
