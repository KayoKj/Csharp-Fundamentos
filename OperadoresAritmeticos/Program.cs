Console.WriteLine("Operadores Aritméticos\n");

Console.WriteLine("Informe o valor de X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Soma de X + Y = {x + y}");
Console.WriteLine($"Subtração de X + Y = {x - y}");
Console.WriteLine($"Multiplicação de X + Y = {x * y}");

double divisao = (double) x / y;
Console.WriteLine($"Divisão de X + Y = {divisao}");
Console.WriteLine($"Modulo de X + Y = {x % y}\n");

Console.WriteLine("Metodos Math");
// Metodo Math
Console.WriteLine($"\nRaiz Quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotencia de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"\nValor minimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"\nValor maximo entre x e y = {Math.Max(x,y)}");
Console.WriteLine($"\nCoseno de x  = {Math.Cos(x)}");
Console.WriteLine($"\nSeno de x  = {Math.Sin(x)}");
Console.WriteLine($"\nExponencial de x  = {Math.Exp(x)}");

Console.ReadKey();