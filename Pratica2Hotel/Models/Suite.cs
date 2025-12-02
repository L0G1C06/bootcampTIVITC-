using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica2Hotel.Models
{
    public class Suite
    {
        public Suite()
        {
            
        }

        public Suite(string tipoSuite, double valorDiaria, int capacidade)
        {
            TipoSuite = tipoSuite;
            ValorDiaria = valorDiaria;
            Capacidade = capacidade;
        }

        public string TipoSuite { get; set; }
        public double ValorDiaria { get; set; }
        public int Capacidade { get; set; }
    }
}