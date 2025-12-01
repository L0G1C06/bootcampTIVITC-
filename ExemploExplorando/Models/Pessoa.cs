using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome 
        {
            get
            {
                return _nome.ToUpper();
            } 
            
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
            get
            {
                return _idade;
            }
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