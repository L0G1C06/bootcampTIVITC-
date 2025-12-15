using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Models;
using ModuloAPI.Context;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CriarContato(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
        [HttpGet]
        public IActionResult GetContatos()
        {
            var contatos = _context.Contatos.ToList();
            return Ok(contatos);
        }
        [HttpGet("{id}")]
        public IActionResult GetContatoPorId(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }
        [HttpPut]
        public IActionResult AtualizarContato(Contato contatoAtualizado)
        {
            var contato = _context.Contatos.Find(contatoAtualizado.Id);
            if (contato == null)
            {
                return NotFound();
            }
            contato.Nome = contatoAtualizado.Nome;
            contato.Telefone = contatoAtualizado.Telefone;
            _context.SaveChanges();
            return Ok(contato);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarContato(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            return NoContent();
        }
    }
}