using Exercicio3;

Console.WriteLine("--- Exercício 03: Classe Produto ---");

Produto p1 = new Produto();
p1.Nome = "Teclado";
p1.Preco = 150.00m;
p1.Quantidade = 3;

Produto p2 = new Produto();
p2.Nome = "Mouse";
p2.Preco = 80.50m;
p2.Quantidade = 5;

Produto p3 = new Produto();
p3.Nome = "Monitor";
p3.Preco = 899.90m;
p3.Quantidade = 2;

Produto[] produtos = { p1, p2, p3 };

foreach (Produto produto in produtos)
{
    produto.ExibirDados();
    Console.WriteLine($"Valor total: R$ {produto.CalcularValorTotal():N2}");
    Console.WriteLine();
}
