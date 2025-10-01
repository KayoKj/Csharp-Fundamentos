Console.WriteLine("Operador Uniario é Ternario\n");


Console.WriteLine("Operador Uniario");
int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

Console.WriteLine("\nInforme um numero");
var valorUsuario = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O Negativo de {valorUsuario} é {-valorUsuario}\n");

Console.WriteLine("Operador Ternario\n");

decimal salario = 5000m;
decimal divida = 3500m;

string contas = salario >= divida ? "Sim o salario cobre as dividas" : "O Salario não paga as dividas";

Console.WriteLine($"Salario -> {salario.ToString("C")}\nDivida -> {divida.ToString("C")}\n" +
    $"{contas}\n");

Console.WriteLine("Aninhando Operadores Ternarios\n");

int numero1 = 15;
int numero2 = 15;

string compararNumeros = numero1 > numero2 ? $"{numero1} é maior que {numero2}" :
    numero1 < numero2 ? $"{numero1} é menor que {numero2}" :
    $"{numero1} é igual a {numero2}";

Console.WriteLine(compararNumeros);