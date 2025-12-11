using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // Classe abstrata não pode ser instanciada diretamente. Apenas ser herdada
    public abstract class Conta
    {
        /* 'Protected' é protegido de alterações externas a não ser que seja alterado por suas classes filhas */
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {saldo}");
        }
    }
}