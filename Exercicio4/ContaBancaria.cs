namespace Exercicio4;

public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    private decimal saldo;

    public ContaBancaria(string titular, int numeroConta)
    {
        Titular = titular;
        NumeroConta = numeroConta;
        saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Depósito inválido: o valor deve ser maior que zero.");
            return;
        }

        saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor:N2} realizado na conta {NumeroConta}.");
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Saque inválido: o valor deve ser maior que zero.");
            return;
        }

        // Não permite que o saldo fique negativo
        if (valor > saldo)
        {
            Console.WriteLine($"Saldo insuficiente para sacar R$ {valor:N2} da conta {NumeroConta}.");
            return;
        }

        saldo -= valor;
        Console.WriteLine($"Saque de R$ {valor:N2} realizado na conta {NumeroConta}.");
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular} | Conta: {NumeroConta} | Saldo: R$ {saldo:N2}");
    }
}
