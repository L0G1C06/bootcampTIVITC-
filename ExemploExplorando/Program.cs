using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Eduardo", 21);
// p1.Nome = "Eduardo";
// p1.Idade = 21;

Pessoa p2 = new Pessoa("Buta", 26);
// p2.Nome = "Buta";
// p2.Idade = 26;

Pessoa p3 = new Pessoa("Calero", 40);

Curso ingles = new Curso(new List<Pessoa> { p1, p2 }, "Inglês Básico");
ingles.AdicionarAluno(p3);
// ingles.Nome = "Inglês Básico";
// ingles.Alunos = new List<Pessoa>();

// ingles.AdicionarAluno(p1);
// ingles.AdicionarAluno(p2);

ingles.ListarAlunos();

ingles.QuantidadeAlunosMatriculados();

ingles.RemoverAluno(p1);
ingles.RemoverAluno(p2);
ingles.RemoverAluno(p3);

ingles.ListarAlunos();

ingles.QuantidadeAlunosMatriculados();
// p1.Apresentar();