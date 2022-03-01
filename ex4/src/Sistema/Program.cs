using Exercicio4;

try
{
    Console.WriteLine("---------Exercício 4-----");
    Console.WriteLine("---------Pessoa 1-----");
    Console.WriteLine("Pessoa1 - Entre com um nome!");
    String nome = Console.ReadLine();
    Console.WriteLine("Pessoa 1 - Entre com uma idade!");
    int idade = Int16.Parse(Console.ReadLine());
    Usuario usuario1 = new Usuario();
    usuario1.Nome = nome;
    usuario1.Idade = idade;

    Console.WriteLine("---------Pessoa 2-----");
    Console.WriteLine("Pessoa2 - Entre com um nome!");
    String nome2 = Console.ReadLine();
    Console.WriteLine("Pessoa 2 - Entre com uma idade!");
    int idade2 = Int16.Parse(Console.ReadLine());
    Usuario usuario2 = new Usuario();
    usuario2.Nome = nome2;
    usuario2.Idade = idade2;

    Console.WriteLine("---------Pessoa 3-----");
    Console.WriteLine("Pessoa3 - Entre com um nome!");
    String nome3 = Console.ReadLine();
    Console.WriteLine("Pessoa 3 - Entre com uma idade!");
    int idade3 = Int16.Parse(Console.ReadLine());
    Usuario usuario3 = new Usuario();
    usuario3.Nome = nome3;
    usuario3.Idade = idade3;

    if(usuario3.Idade > usuario1.Idade && usuario3.Idade > usuario2.Idade)
    {
        usuario3.ExibirDados();
    }
    if (usuario2.Idade > usuario1.Idade && usuario2.Idade > usuario3.Idade)
    {
        usuario2.ExibirDados();
    }
    if (usuario1.Idade > usuario2.Idade && usuario1.Idade > usuario3.Idade)
    {
        usuario1.ExibirDados();
    }

}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}