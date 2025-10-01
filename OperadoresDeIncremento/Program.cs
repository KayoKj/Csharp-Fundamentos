Console.WriteLine("Operadores de Incremento e Decremento\n");

int x = 0;

Console.WriteLine($"x = {x}");

// Pós incremento -> primeiro resolver depois incrementa
// Pré incremento -> se aplica a mesma logica mas diminuindo o valor
int resultado1 = x++ + 10; // não incrementa valor em X antes de somar ao + 10.
Console.WriteLine($"x pós-incremento --> {resultado1}");
Console.WriteLine($"valor de x --> {x}");

// Pós Decremento -> primeiro resolver depois incrementa
// Pré Decremento -> se aplica a mesma logica mas diminuindo o valor
int y = 0;
int resultado2 = ++y + 10; // Y --> incrementa 1 ja para somar ao + 10.
Console.WriteLine($"y pré-incremento --> {resultado2}");
Console.WriteLine($"valor de y --> {y}");

Console.ReadKey();