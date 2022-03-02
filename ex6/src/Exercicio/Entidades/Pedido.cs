namespace Exercicio
{
    public class Pedido
    {
        private string _datadopedido;
        private List<Item> _items;

        public string DataDoPedido{ get => _datadopedido; set => _datadopedido = value; }
        public void AdicionarItem(IEnumerable<Item> item)
        {
            if (_items == null)
            {
                _items = new List<Item>();
            }
            _items.AddRange(item);
        }
        public void RetornaQuantidadeDeItens()
        {
            int quantidade = _items.Count;
            Console.WriteLine($"A quantidade é: {quantidade}");
        }
        public void RetornaValorTotalDoPedido()
        {
            double total = 0;
            for (int i = 0; i < _items.Count; i++)
            {
                total = _items[i].Valor;
            }
            Console.WriteLine($"O valor total é: {total}");
        }
    }
}