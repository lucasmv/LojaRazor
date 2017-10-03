using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public enum Sexo
    {
        [Display(Name = "MASCULINO")]
        Masculino,
        [Display(Name = "FEMININO")]
        Feminino
    }
}