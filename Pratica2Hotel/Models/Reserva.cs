using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica2Hotel.Models
{
    public class Reserva
    {
        public Reserva()
        {
            
        }

        public Reserva(int diasReservados, Suite suite, List<Pessoa> hospedes)
        {
            DiasReservados = diasReservados;
            Suite = suite;
            Hospedes = hospedes;
        }

        public int DiasReservados { get; set; }
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarDiasReservados(int dias)
        {
            DiasReservados = dias;
        }

        public double CalcularValorTotal()
        {
            double valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valorTotal *= 0.9; // Aplica 10% de desconto
            }

            return valorTotal;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        
    }
}