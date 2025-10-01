Console.WriteLine("Nullabe Types");
Console.WriteLine();

int valor = 100;
Console.WriteLine(valor);
Console.WriteLine();

// Executam a mesma coisa
Nullable<int> numero = null;
int? numeroSimplificado = null;

Nullable<double> salario = null;
double? salarioSimplificado = null;

Nullable<bool> trueOrFalse = null;
bool? trueOrFalseSimplificado = null;

Console.WriteLine(numeroSimplificado);
Console.WriteLine(salarioSimplificado);
Console.WriteLine(trueOrFalseSimplificado);
Console.WriteLine();

int? a = null;
// int b = a; --> Erro
int b = a ?? 0;

Console.WriteLine();

int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);
Console.WriteLine();

int? numeroComValor = null; // Null valor inexistente, 0 já e valor
if (numeroComValor.HasValue)
{
    Console.WriteLine("Numero tem valor");
}
else
{
    Console.WriteLine("Numero Não tem valor");
}

Console.ReadKey();