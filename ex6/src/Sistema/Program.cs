using Exercicio;

Console.WriteLine("Exercício 6");
Console.WriteLine("-----------------------");
try
{
    Item item1 = new Item();
    item1.NomeDoItem = "A";
    item1.Valor = 10;

    Item item2 = new Item();
    item2.NomeDoItem = "B";
    item2.Valor = 20;

    Pedido pedido1 = new Pedido();
    pedido1.DataDoPedido="20/02";

    var itens = new List<Item> { item1, item2 };

    pedido1.AdicionarItem(itens);
    pedido1.RetornaQuantidadeDeItens();
    pedido1.RetornaValorTotalDoPedido();
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}