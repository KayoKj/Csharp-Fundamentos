Console.WriteLine("Declarando Variaveis numéricas");
Console.WriteLine();

// Declarando Variáveis

byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -2147483647;
uint valor4 = 2147483647;
long valor5 = -21474836489;

Console.WriteLine("byte " + valor1);
Console.WriteLine("sbyte " + valor2);
Console.WriteLine("int " + valor3);
Console.WriteLine("uint " + valor4);
Console.WriteLine("long " + valor5);

Console.WriteLine("-------------------------------");

const int valor6 = 999;
// valor6 = 1000; -> Gera erro constante não pode ser alterada
Console.WriteLine(valor6);

int var1 = 8, var2 = 10, var3 = 11; // Declarar variaveis do mesmo tipo 
Console.WriteLine("Valores no mesmo tipo de dado:");
Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);

Console.ReadLine();