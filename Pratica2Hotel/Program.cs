using Pratica2Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica2Hotel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criação de hóspedes
            Pessoa hospede1 = new Pessoa("Alice", 30);
            Pessoa hospede2 = new Pessoa("Bob", 25);

            List<Pessoa> hospedes = new List<Pessoa> { hospede1, hospede2 };

            // Criação da suíte
            Suite suite = new Suite("Luxo", 200.0, 2);

            // Criação da reserva
            Reserva reserva = new Reserva();
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);
            reserva.CadastrarDiasReservados(12);

            int quantidadeHospedes = reserva.ObterQuantidadeHospedes();
            Console.WriteLine($"Quantidade de hóspedes na reserva: {quantidadeHospedes}");

            // Cálculo do valor total da reserva
            double valorTotal = reserva.CalcularValorTotal();
            Console.WriteLine($"Valor total da reserva: R$ {valorTotal}");
        }
    }
}