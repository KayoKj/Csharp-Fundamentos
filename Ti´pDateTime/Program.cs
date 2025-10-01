Console.WriteLine("Struct DateTime");

DateTime dataAtual =  DateTime.Now; // Imprimi a hora atual 
Console.WriteLine($"Exibindo data atual -> {dataAtual}");
Console.WriteLine();

// Criar data especifica usa formato aaaa,mm, dd
DateTime dataEspecifica = new DateTime(2025, 09, 15);
Console.WriteLine($"Exibindo data especifica -> {dataEspecifica}");
Console.WriteLine();

// Definir as horas
DateTime dataHora = new DateTime(2025, 09, 15, 12, 40, 50);
Console.WriteLine($"Definindo as horas manualmente -> {dataHora}");
Console.WriteLine();

// Extrair Informações da data atual
DateTime hoje = DateTime.Now;

Console.WriteLine($"Exibindo ano da variavel Hoje -> {hoje.Year}");
Console.WriteLine($"Exibindo mes da variavel Hoje -> {hoje.Month}");
Console.WriteLine($"Exibindo dia da variavel Hoje -> {hoje.Day}");
Console.WriteLine($"Exibindo hora da variavel Hoje -> {hoje.Hour}");
Console.WriteLine($"Exibindo minuto da variavel Hoje -> {hoje.Minute}");
Console.WriteLine($"Exibindo segundos da variavel Hoje -> {hoje.Second}");
Console.WriteLine($"Exibindo milisegundos da variavel Hoje -> {hoje.Millisecond}");
Console.WriteLine();

// Adicionando valores
Console.WriteLine($"adicionando 10 dias -> {hoje.AddDays(10)}");
Console.WriteLine($"adicionando 3 meses -> {hoje.AddMonths(3)}");
Console.WriteLine($"adicionando 2 anos -> {hoje.AddYears(2)}");

// Exibindo a data no formato longo
var diaStringLonga = hoje.ToLongDateString();
Console.WriteLine($"Exibindo a data formato longo em string {diaStringLonga}");

// Exibindo a data no formato curto
var diaStringCurta = hoje.ToShortDateString();
Console.WriteLine($"Exibindo a data formato curto em string {diaStringCurta}");
Console.WriteLine();

// Exibir o horario formato longo
var horarioLongo = hoje.ToLongTimeString();
Console.WriteLine($"Exibindo o horario em formato longo {horarioLongo}");

// Exibindo horario formato curto
var horarioCurto = hoje.ToShortTimeString();
Console.WriteLine($"Exibindo o horario em formato curto {horarioCurto}");
Console.WriteLine();

// Obter o dia da semana
Console.WriteLine($"Exibindo o dia da semana {hoje.DayOfWeek}");

Console.ReadKey();