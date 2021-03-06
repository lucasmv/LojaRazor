﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class UsuarioDTO
    {
        [Required]
        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Required, EmailAddress]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Required, MinLength(3)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento:")]
        public string Complemento { get; set; }

        [Required, RegularExpression("\\d{5}-\\d{3}")]
        [Display(Name = "CEP:")]
        public string CEP { get; set; }

        [Display(Name = "Observações:")]
        public string Observacoes { get; set; }

        public bool RecebePromocoes { get; set; }

        public SexoDTO Sexo { get; set; }
    }
}