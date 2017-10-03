﻿using System.Collections.Generic;

namespace Site.Models
{
    public class Departamento
    {
        public string Nome { get; set; }

        public IList<Categoria> Categorias { get; set; }

        public Departamento()
        {
            Categorias = new List<Categoria>();
        }
    }
}