Console.WriteLine("Ordem de Precedencia\n");

Console.WriteLine("Procendencia Operadores Logicos -> !, &&, ||\n" +
    "[], () Da Maior Precedencia as Operações\n");
bool valor1 = !(10 != 8) && 11 > 10; // -> False o True foi negado !, True -> True
Console.WriteLine(valor1);

bool valor2 = (10 > 8 || 11 > 20 ) && 20 > 18; // True, False -> True
Console.WriteLine(valor2);