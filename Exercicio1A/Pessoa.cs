namespace Exercicio1A;

public class Pessoa
{
    public string Nome = "";
    public int Idade;
    public string Cargo = "";

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu cargo é {Cargo}.");
    }
}
