using Exercicio1C;

Console.WriteLine("--- Exercício 01 c): Salário por cargo ---");

Pessoa p1 = new Pessoa();
p1.Nome = "Carlos";
p1.Idade = 45;
p1.Cargo = "Gerente";

Pessoa p2 = new Pessoa();
p2.Nome = "Ana";
p2.Idade = 28;
p2.Cargo = "Desenvolvedor";

Pessoa p3 = new Pessoa();
p3.Nome = "Lucas";
p3.Idade = 19;
p3.Cargo = "Estagiário";

p1.ImprimirSalario();
p2.ImprimirSalario();
p3.ImprimirSalario();
