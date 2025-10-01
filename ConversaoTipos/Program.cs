using System.Numerics;

Console.WriteLine("Conversão de tipos \n");

int varInt = 100; // int usa -> 4 bytes 
double varDouble = varInt; // double usa -> 8 bytes

Console.WriteLine($"Valor Double Recebendo valor int -> { varDouble}\n");
// byte -> 1 byte
// short -> 2 bytes
// int -> 4 bytes
// long -> 8 bytes
// float -> 4 bytes
// double -> 8 bytes
// decimal -> 16 bytes

Console.WriteLine("Conversão Implicita");
int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine($"Numero Int -> {numeroInt}");
Console.WriteLine($"Numero Long -> {numeroLong}");
Console.WriteLine($"Numero Float -> {numeroFloat}");
Console.WriteLine($"Numero Double -> {numeroDouble}");
Console.WriteLine($"Numero Decimal -> {numeroDecimal}\n");

Console.WriteLine("Conversão Explicita");
double varDoubleExplicito = 12.456; // 8 bytes
// int varIntExplicito = varDouble; // -> double e 8 bytes,int 4 erro
int varIntExplicito = (int)varDoubleExplicito; // -> Conversão explicita, compilador despreza casas decimais
Console.WriteLine($"Double virando um int -> {varIntExplicito}, Ignorou as casas decimais, numero original -> 12.456");

int numero = 10;
int numero2 = 3;

float resultado = (float) numero / numero2; // -> Fazendo a divisão ter numero flutuante
Console.WriteLine(resultado);

Console.ReadLine();