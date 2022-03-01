using exercicio;

Console.WriteLine("Exercício 5");
Console.WriteLine("-----------------------");
try
{
    Calculadora calculo1 = new Calculadora();
    Console.WriteLine("Digite o primeiro valor");
    int valor1 = Int16.Parse(Console.ReadLine());
    calculo1.Valor1 = valor1;
    Console.WriteLine("Digite o segundo valor");
    int valor2 = Int16.Parse(Console.ReadLine());
    calculo1.Valor2 = valor2;
    Console.WriteLine("Digite um operador");
    String operador = Console.ReadLine();
    calculo1.Operador = operador;

    calculo1.Calcular();
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}