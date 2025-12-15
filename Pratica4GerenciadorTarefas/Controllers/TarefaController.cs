using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pratica4GerenciadorTarefas.Models;
using Pratica4GerenciadorTarefas.Context;

namespace Pratica4GerenciadorTarefas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context)
        {
            _context = context;
        }
        // Rota GET
        [HttpGet("listTarefas")]
        public IActionResult GetTarefas()
        {
            var tarefas = _context.Tarefas.ToList();
            return Ok(tarefas);
        }

        // Rota POST
        [HttpPost("createTarefa")]
        public IActionResult CreateTarefa(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }

        // Rota PUT
        [HttpPut("updateTarefa/{id}")]
        public IActionResult UpdateTarefa(int id, Tarefa tarefaAtualizada)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            tarefa.Nome = tarefaAtualizada.Nome;
            tarefa.DataInicio = tarefaAtualizada.DataInicio;
            tarefa.DataFim = tarefaAtualizada.DataFim;
            tarefa.Ativo = tarefaAtualizada.Ativo;
            _context.SaveChanges();
            return Ok(tarefa);
        }

        // Rota DELETE
        [HttpDelete("deleteTarefa/{id}")]
        public IActionResult DeleteTarefa(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
            return Ok();
        }
    }
}