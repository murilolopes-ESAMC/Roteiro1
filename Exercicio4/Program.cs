using Exercicio4;

Console.WriteLine("--- Exercício 04: Conta Bancária ---");

ContaBancaria conta1 = new ContaBancaria("Maria", 1001);
ContaBancaria conta2 = new ContaBancaria("José", 1002);

conta1.Depositar(500);
conta1.Sacar(200);
conta1.Sacar(1000); // Saldo insuficiente
conta1.ExibirSaldo();

Console.WriteLine();

conta2.Depositar(50);
conta2.Depositar(-10); // Valor inválido
conta2.Sacar(50);
conta2.Sacar(1); // Saldo insuficiente, saldo não fica negativo
conta2.ExibirSaldo();
