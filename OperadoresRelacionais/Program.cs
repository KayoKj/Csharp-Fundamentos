Console.WriteLine("Operadores Relacionais\n");

int x = 10;
int y = 20;

Console.WriteLine($"X Igual a Y {x == y}");
Console.WriteLine($"X Maior que Y {x >  y}");
Console.WriteLine($"X Menor que Y {x < y}");
Console.WriteLine($"X Maior ou igual a Y {x >= y}");
Console.WriteLine($"X Menor ou igual Y {x <= y}");
Console.WriteLine($"X Diferente de Y {x != y}\n");

Console.WriteLine("Relacionais com string");

string a = "curso";
string b = "Curso";

Console.WriteLine($"Valor A -> {a}, Valor B -> {b}");
Console.WriteLine($"String A é igual a String B --> {a == b}, C# -> Case Sensitivy"); // C# -> Case Sensitivy

bool resultadoStringEquals = a.Equals(b);
Console.WriteLine(resultadoStringEquals);   