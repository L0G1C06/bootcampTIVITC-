using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica2Hotel.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}