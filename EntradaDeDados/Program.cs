Console.WriteLine("Entrada De Dados\n");

Console.WriteLine("Digite seu Nome");

string nome = Console.ReadLine();

Console.WriteLine("Agora informe seu CPF");

string cpf = Console.ReadLine();

if(string.IsNullOrEmpty(cpf))
{
    Console.WriteLine("Cpf não pode ficar vazio");
}
else
{
    Console.WriteLine($"Seu nome é {nome} é o seu CPF é o {cpf}");
}

Console.ReadKey();