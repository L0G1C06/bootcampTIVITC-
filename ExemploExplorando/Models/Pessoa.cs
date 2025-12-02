using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // Construtores
        public Pessoa()
        {
            // Construtor padrão, caso não passemos nenhum parâmetro
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        private string _nome;
        private int _idade;

        public string Nome 
        {
            get => _nome.ToUpper(); // body expression de return simples
            
            set
            {
                // Validando se nome inserido é vazio
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        } // tendo get;set é automaticamente idenficado como Propriedade de uma classe
        
        public int Idade 
        { 
            get => _idade; // body expression de return simples
            set
            {
                // Validando se idade inserida é negativa
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}