using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}