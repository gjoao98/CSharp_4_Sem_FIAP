﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    public class Pessoa
    {
        // Atributos
        private string _nome;
        private int _idade;

        // Propriedades (getters and setters)
        public string Nome 
        { 
            get { return _nome; } 
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public string Cpf { get; set; }
    }
}
