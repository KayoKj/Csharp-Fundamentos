Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe seu Peso: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Informe sua altura");
double altura = double.Parse(Console.ReadLine());

/*
IMC < 18.5 → “Abaixo do peso”
18.5 ≤ IMC < 25 → “Peso normal”
25 ≤ IMC < 30 → “Sobrepeso”
IMC ≥ 30 → “Obesidade”
*/

if (peso <= 0 || altura <= 0)
{
    Console.WriteLine("Altura ou Peso não podem ser igual a zero");
}
else
{
    double imcUsuario = peso / (altura * altura);
    string classificacao = "";

    if (imcUsuario < 18.5)
    {
        classificacao = "Abaixo do peso";
    }
    else if (imcUsuario <= 18.5 && imcUsuario < 25)
    {
        classificacao = "Peso normal";
    }
    else if (imcUsuario <= 25 && imcUsuario < 30)
    {
        classificacao = "Sobrepeso";
    }

    else
    {
        classificacao = "Obesidade";
    }

    Console.WriteLine($"Nome: {nome}\n" +
        $"IMC: {imcUsuario}\n" +
        $"Classificação{classificacao}");
}