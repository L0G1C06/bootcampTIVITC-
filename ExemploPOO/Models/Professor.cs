using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // Sealed significa que a classe não pode ser herdada por outras classes
    public class Professor : Pessoa
    {
        // Construtor herda da classe base 'Pessoa' usando 'base' o valor do parâmetro 'nome', ou seja, repassa o valor para a classe base Pessoa
        public Professor(string nome) : base(nome)
        {
            
        }
        public string Disciplina { get; set; }

        // 'Sealed' impede que o método seja sobrescrito por classes derivadas
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou professor de {Disciplina}.");
        }
    }
}