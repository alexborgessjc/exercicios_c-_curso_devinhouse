using Exercicio;

Console.WriteLine("Exercício 9");
Console.WriteLine("-----------------------");

try
{
    Animal animal1 = new Animal();
    animal1.NomeDoAnimal = "Wood";
    animal1.TipoDoAnimal = "cachorro";

    Animal animal2 = new Animal();
    animal2.NomeDoAnimal = "Leon";
    animal2.TipoDoAnimal = "gato";

    var animais = new List<Animal> { animal1,animal2 };

    Lista lista1 = new Lista();

    lista1.AdicionarAnimal(animais);
    lista1.RetornaCachorros();
    lista1.RetornaGatos();

}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}
