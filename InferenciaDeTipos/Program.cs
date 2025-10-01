Console.WriteLine("Inferencia de Tipos");

var idade = 22;
var nome = "Kayo";
var salario = 3.000m;

// Var Limitações
/*Null, Não inicializar, acoplar mais de uma variavel, não pode mudar o tipo*/

var teste = new Teste();
teste.MetodoImprimir();

class Teste
{
    public void MetodoImprimir() // Metodo Sem parametros.
    {
        Console.WriteLine("Imprimindo Um Metodo");
    }
}
