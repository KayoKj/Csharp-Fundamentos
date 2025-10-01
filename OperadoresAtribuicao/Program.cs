Console.WriteLine("Operadores Atribuição\n");

var x = 10;

Console.WriteLine($"Valor inicial de X = {x}");

Console.WriteLine($"x+=5 --> {x += 5}");
Console.WriteLine($"x-=5 --> {x -= 3}");
Console.WriteLine($"x*=5 --> {x *= 4}");
Console.WriteLine($"x/=5 --> {x /= 5}");
Console.WriteLine($"x%=5 --> {x %= 5}");

var y = "123";
Console.WriteLine($"Valor inicial de Y --> {y}");
Console.WriteLine($"Valor inicial de Y + \"456\" --> {y += "456"}");

Console.ReadKey();