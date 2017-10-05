using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public enum SexoDTO
    {
        [Display(Name = "MASCULINO")]
        Masculino,
        [Display(Name = "FEMININO")]
        Feminino
    }
}