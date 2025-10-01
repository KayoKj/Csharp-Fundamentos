Console.WriteLine("Conversão de tipos \n");

int valorInt = 123;
double valorDouble = 12.41;
decimal valorDecimal = 12.45678m;

Console.WriteLine("Convertendo para string");
string string1 = valorInt.ToString();
string string2 = valorDouble.ToString();
string string3 = valorDecimal.ToString();

Console.WriteLine(string1.GetType());
Console.WriteLine(string2);
Console.WriteLine(string3);

Console.WriteLine();

Console.WriteLine("Convertendo para outros tipos");

int valorInt2 = 10;
double valorDouble2 = 200.00;

Console.WriteLine(Convert.ToDouble(valorInt2));
Console.WriteLine(Convert.ToBoolean(valorDouble2));

Console.WriteLine();

Console.WriteLine("Estourando uma OverFlowException");

int valorIntAlto = 100000;
Console.WriteLine(Convert.ToByte(valorIntAlto)); // Byte não suporta um valor Int -> Causando perda de dados