Console.WriteLine("Informe seu nome");
string nome = Console.ReadLine();

Console.WriteLine("Informe Sua Idade:");
int idadeUsuario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da sua compra");
decimal valorCompra =  decimal.Parse(Console.ReadLine());

decimal valorFinalCompra = valorCompra;
int descontoAplicado = 0;

if(idadeUsuario >= 60)
{
    descontoAplicado = 15;
    valorFinalCompra = valorCompra * 0.85m;
}
else if(idadeUsuario < 60 && valorCompra >= 500)
{
    descontoAplicado = 10;
    valorFinalCompra = valorCompra * 0.90m;
}
else
{
    Console.WriteLine("Sem Desconto");
}

Console.WriteLine($"Cliente {nome}\n" +
    $"Valor da compra R${valorCompra}\n" +
    $"Desconto Aplicado de {descontoAplicado}%\n" +
    $"Valor Final da compra {valorFinalCompra}");