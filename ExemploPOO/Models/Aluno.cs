using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // Aluno herda da classe Pessoa usando ':'
    public class Aluno : Pessoa
    {
        // Construtor herda da classe base 'Pessoa' usando 'base' o valor do parâmetro 'nome', ou seja, repassa o valor para a classe base Pessoa
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}.");
        }
    }
}