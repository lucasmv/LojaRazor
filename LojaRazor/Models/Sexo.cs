using System.ComponentModel.DataAnnotations;

namespace LojaRazor.Models
{
    public enum Sexo
    {
        [Display(Name = "MASCULINO")]
        Masculino,
        [Display(Name = "FEMININO")]
        Feminino
    }
}