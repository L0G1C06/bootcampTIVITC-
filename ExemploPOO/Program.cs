using ExemploPOO.Models;

// p1 é uma Abstração da classe Pessoa
// Pessoa p1 = new Pessoa();
// p1.Nome = "Eduardo Maldaner";
// p1.Idade = 21;

// p1.Apresentar();

// Exemplo de encapsulamento. Onde o método 'Sacar' manipula o atributo 'saldo' que é privado.
ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();