using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pratica3PedraPapelTesoura.Models;
using Pratica3PedraPapelTesoura.Controller;

namespace Pratica3PedraPapelTesoura.View
{
    public class Jogo
    {
        Mao jogador1;
        Mao jogador2;
        JogoController jogoController;

        public Resultado jogar()
        {
            jogador1 = new Mao();
            jogador2 = new Mao();
            jogoController = new JogoController();

            jogador1.gesto = new Gesto()
            {
                GestoJogada = "Pedra",
                Ganha = new List<string>() { "Tesoura" },
                Perde = new List<string>() { "Papel" }
            };
            jogador2.gesto = new Gesto()
            {
                GestoJogada = "Tesoura",
                Ganha = new List<string>() { "Papel" },
                Perde = new List<string>() { "Pedra" }
            };
            Resultado resultado = jogoController.jogar(jogador1, jogador2);
            return resultado;
        }
        
    }
}