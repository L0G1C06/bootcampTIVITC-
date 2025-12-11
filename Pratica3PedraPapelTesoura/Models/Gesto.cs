using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica3PedraPapelTesoura.Models
{
    public class Gesto
    {
        public string GestoJogada { get; set; }
        public List<string> Ganha { get; set; }
        public List<string> Perde { get; set; }

    }
}