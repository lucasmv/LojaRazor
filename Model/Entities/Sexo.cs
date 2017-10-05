using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public enum Sexo
    {
        [Display(Name = "MASCULINO")]
        Masculino,
        [Display(Name = "FEMININO")]
        Feminino
    }
}
