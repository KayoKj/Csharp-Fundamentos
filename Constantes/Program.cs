Console.WriteLine("Constantes");

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const int IDADE = 21, PESO = 92;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;
Console.WriteLine(DIAS_POR_MES);
Console.WriteLine();

Console.WriteLine("Calculando área e perimetro de um circulo");

double raio, perimetro, area;
const double VALOR_PI = 3.14;

Console.WriteLine("Informe o raio do circulo");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio,2);

Console.WriteLine($"Valor do Perimetro {perimetro}");
Console.WriteLine($"Valor da Area {area}");

Console.ReadKey();