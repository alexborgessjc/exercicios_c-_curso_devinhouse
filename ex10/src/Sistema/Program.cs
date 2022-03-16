using Exercicio;

Console.WriteLine("Exercício 9");
Console.WriteLine("-----------------------");

try
{
    Produto produto1 = new Produto();
    produto1.NomeDoProduto = "ProdutoA";
    produto1.ValorDoProduto = 100;
    produto1.ValorDoDesconto = 20;

    produto1.RetornaValorFinal();
    produto1.RetornaValorDoDesconto();  
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}
