using Fundamentos.Models;

Pessoa pessoa = new Pessoa();
pessoa.Nome = "Eduardo";
pessoa.Idade = 21;
pessoa.DataNascimento = new DateTime(2004, 2, 6);
pessoa.Apresentar();

Calculadora calc = new Calculadora();
int resultado = calc.Somar(10, 20);
Console.WriteLine($"O resultado da soma é: {resultado}");