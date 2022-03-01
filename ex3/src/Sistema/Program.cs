using Exercicio;

try
{
    Console.WriteLine("Entre com o valor da base!");    
    int valorbase = Int16.Parse(Console.ReadLine());
    Console.WriteLine("Entre com o valor da altura!");
    int valoraltura = Int16.Parse(Console.ReadLine());

    Objeto objeto1 = new();
    objeto1.Base = valorbase;
    objeto1.Altura = valoraltura;
    objeto1.Area = objeto1.Base * objeto1.Altura / 2;

    //objeto1.CalcularArea(valoraltura,valorbase);
    objeto1.RetornaPropriedades();
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}