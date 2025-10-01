Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe seu saldo");
decimal saldoInicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("1 - Déposito\n" +
    "2 - Saque\n" +
    "3 - Ver Saldo");

Console.WriteLine("Escolha a opção Desejada");
int opcaoUsuario = int.Parse(Console.ReadLine());

string operacao = "";

if (opcaoUsuario == 1)
{
    operacao = "Deposito";
    Console.WriteLine("Qual valor quer depositar?");
    decimal valorDepositoUsuario = decimal.Parse(Console.ReadLine());

    saldoInicial += valorDepositoUsuario;
}
else if (opcaoUsuario == 2)
{
    operacao = "Saque";
    Console.WriteLine("Informe o valor do saque? ");
    decimal valorSaqueUsuario = decimal.Parse(Console.ReadLine());

    if(valorSaqueUsuario > saldoInicial)
    {
        Console.WriteLine("Saldo Insuficiente");
    }
    else
    {
        
        saldoInicial -= valorSaqueUsuario;
    }
}
else
{
    operacao = "Ver saldo";
    Console.WriteLine(saldoInicial);
}

Console.WriteLine($"Cliente: {nome}\n" +
    $"Operação escolhida: {operacao}\n" +
    $"Saldo Final: {saldoInicial}");