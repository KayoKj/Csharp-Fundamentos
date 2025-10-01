Console.WriteLine("Atribuindo Valores para bool e char");

bool ativo = true;
bool inativo = false;

Console.WriteLine(ativo);
Console.WriteLine(inativo);

Console.WriteLine($"Comparando -> 10 == 15, Resultado -> { 10 == 15}"); // -> False
Console.WriteLine($"Comparando -> 10 == 10, Resultado -> { 10 == 10}"); // -> True

int x = 10;
int y = 15;

Console.WriteLine($"Comparando se 10 é maior que 15, Resultado -> {x > y}"); // Comparando se 10 e maior ( > ) que 15

char letra1 = 'A'; // -> Char São Declarados com aspas simples
char letra2 = '\u0041'; // -> Adicinar o \u para identificar como numero unicode

Console.WriteLine($"Imprimindo Char 'a', Resultado -> {letra1}");
Console.WriteLine($"Imprimindo Char '\u0041', Resultado -> {letra2}");

Console.ReadLine();