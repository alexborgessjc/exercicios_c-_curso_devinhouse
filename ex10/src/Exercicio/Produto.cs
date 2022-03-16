namespace Exercicio
{
    public class Produto
    {
        private string _nomedoproduto;
        private double _valor;
        private double _valordodesconto;

        public string NomeDoProduto { get => _nomedoproduto; set => _nomedoproduto = value; }
        public double ValorDoProduto { get => _valor; set => _valor = value; }
        public double ValorDoDesconto { get => _valordodesconto; set => _valordodesconto = value; }
        public void RetornaValorDoDesconto()
        {         

            double valorfinal = ValorDoProduto * (ValorDoDesconto / 100);
                                  
            Console.WriteLine($"O valor de desconto é: {valorfinal}");
        }
        public void RetornaValorFinal()
        {

            double valordodesconto = ValorDoProduto * (ValorDoDesconto / 100);

            double valorfinal = ValorDoProduto - valordodesconto;

            Console.WriteLine($"O valor final do produto é: {valorfinal}");
        }
    }
}