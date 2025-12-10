using ExemploPOO.Models;

// p1 é uma Abstração da classe Pessoa
// Pessoa p1 = new Pessoa();
// p1.Nome = "Eduardo Maldaner";
// p1.Idade = 21;

// p1.Apresentar();

// Exemplo de encapsulamento. Onde o método 'Sacar' manipula o atributo 'saldo' que é privado.
// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();

// Exemplo de Herança - Aluno herda atributos e métodos da classe Pessoa
Aluno a1 = new Aluno();
a1.Nome = "Ana Silva";
a1.Idade = 19;
a1.Email = "ana.silva@gmail.com";
a1.Nota = 8.5;
a1.Apresentar();

Professor prof1 = new Professor();
prof1.Nome = "Carlos Souza";
prof1.Idade = 40;
prof1.Email = "carlos.souza@gmail.com";
prof1.Disciplina = "Matemática";
prof1.Apresentar();