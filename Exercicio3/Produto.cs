namespace Exercicio3;

public class Produto
{
    public string Nome = "";
    public decimal Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome} | Preço: R$ {Preco:N2} | Quantidade: {Quantidade}");
    }

    public decimal CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}
