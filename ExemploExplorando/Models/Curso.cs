using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public Curso()
        {
            
        }

        public Curso(List<Pessoa> alunos, string nome)
        {
            Alunos = alunos;
            Nome = nome;
        }
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        // Função será usada para adicionar alunos na lista de alunos do curso sem usar o construtor
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.Nome);
            }
        }
    }
}