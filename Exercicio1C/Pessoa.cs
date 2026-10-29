namespace Exercicio1C;

public class Pessoa
{
    public string Nome = "";
    public int Idade;
    public string Cargo = "";

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu cargo é {Cargo}.");
    }

    // O salário não é um atributo: ele é obtido a partir do cargo.
    public decimal InformarSalario()
    {
        switch (Cargo)
        {
            case "Gerente":
                return 10000.00m;
            case "Desenvolvedor":
                return 5000.00m;
            case "Estagiário":
                return 100.00m;
            default:
                return 0m;
        }
    }

    public void ImprimirSalario()
    {
        Console.WriteLine($"{Nome} ({Cargo}) recebe R$ {InformarSalario():N2}");
    }
}
