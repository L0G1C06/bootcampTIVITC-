using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pratica3PedraPapelTesoura.Models;

namespace Pratica3PedraPapelTesoura.Controller
{
    public class JogoController
    {
        public Resultado jogar(Mao jogador1, Mao jogador2)
        {
            if (jogador1.gesto.Ganha.Contains(jogador2.gesto.GestoJogada))
            {
                return Resultado.GANHA;
            }
            else if (jogador1.gesto.Perde.Contains(jogador2.gesto.GestoJogada))
            {
                return Resultado.PERDE;
            }
            else
            {
                return Resultado.EMPATA;
            }
        }
    }
}