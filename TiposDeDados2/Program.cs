Console.WriteLine("Atribuindo valores a Double, Float e Decimal");
Console.WriteLine();

double n1 = 1.234;
float n2 = 1.234f; // -> Usar sufixo f Or F
decimal n3 = 1.234m; // -> Usar sufixo m Or M

Console.WriteLine("Numero Double " + n1);
Console.WriteLine("Numero Float " + n2);
Console.WriteLine("Numero Decimal " + n3);

Console.WriteLine();

Console.WriteLine("Comparando a precisão de double, float e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine($"float {x}");
Console.WriteLine($"double {y}");
Console.WriteLine($"decimal {z}");

Console.ReadLine();