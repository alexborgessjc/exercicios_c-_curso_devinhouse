using ClassLibrary1;
using ClassLibrary1.Entidades;
using ClassLibrary1.Repositorio;

Console.WriteLine("Exercício 2");
Console.WriteLine("-----------------------");
try
{
    Menu prato1 = new Menu();
    prato1.NomeDoPrato = "Prato1";
    prato1.Preco = 25.90;
    prato1.IdDoPrato = 55;

    Console.WriteLine($"O nome do prato é: {prato1.NomeDoPrato}");
    Console.WriteLine($"O preço é: {prato1.Preco}");
    Console.WriteLine($"O ID do prato é: {prato1.IdDoPrato}");
    Console.WriteLine("-----------------------");

    Ingrediente ingrediente1 = new ()
    {
        IdDoPrato = 55,
        NomeDoIngrediente = "Queijo"        
    };
    Ingrediente ingrediente2 = new ()
    {
        IdDoPrato = 55,
        NomeDoIngrediente = "Presunto"
    };

    Console.WriteLine($"O ID do prato de ingrediente1 é: {ingrediente1.IdDoPrato}");
    Console.WriteLine($"O ingrediente 1  é: {ingrediente1.NomeDoIngrediente}");

    var ingredientes = new List<Ingrediente> { ingrediente1, ingrediente2 };

    RepositorioDeIngredientes repositorioDeIngredientes = new RepositorioDeIngredientes();
    repositorioDeIngredientes.AdicionarIngrediente(ingredientes);
   
    repositorioDeIngredientes.RetornarIngredientePorId(55);  
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}