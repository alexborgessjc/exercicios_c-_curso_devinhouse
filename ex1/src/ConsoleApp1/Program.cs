using ClassLibrary1;

Console.WriteLine("Exercício 1");
Console.WriteLine("-----------------------");
try
{
    Pessoa pessoa1 = new Pessoa();
    pessoa1.Nome = "Alex";
    pessoa1.DataNascimento = new DateTime(1990, 1, 20);
    pessoa1.Altura = 1.76;

    Console.WriteLine($"O nome da pessoa é: {pessoa1.Nome}");
    Console.WriteLine($"A data de nascimento é: {pessoa1.DataNascimento.ToString("d")}");
    Console.WriteLine($"A altura da pessoa é: {pessoa1.Altura}");    
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}