Console.WriteLine("Operadores Lógicos\n");

Console.WriteLine("|| -> uma True retorna True\n && -> uma False retorna false\n ! -> Inverte a operação True Vira False e vice-versa");

bool valor1 = 10 > 15; // -> False
bool valor2 = 10 != 15; // -> True

bool resultado;

Console.WriteLine($"valo1 -> {valor1}");
Console.WriteLine($"valo2 -> {valor2}\n");

Console.WriteLine($"Operador AND -> &&\n" +
    $"{valor1 && valor2}\n");

Console.WriteLine($"Operador OR -> ||\n" +
    $"{valor1 || valor2}\n");

Console.WriteLine($"Operador NOT -> !\n" +
    $"{!valor1 && valor2}\n");

Console.ReadKey();