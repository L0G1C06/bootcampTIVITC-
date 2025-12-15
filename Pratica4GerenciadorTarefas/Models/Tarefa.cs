using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica4GerenciadorTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
    }
}