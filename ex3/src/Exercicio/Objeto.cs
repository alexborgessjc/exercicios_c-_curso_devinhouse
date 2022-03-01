namespace Exercicio
{
    public class Objeto
    {
        private int _altura;
        private int _base;
        private double _area;

        public int Altura { get => _altura; set => _altura = value; }
        public int Base { get => _base; set => _base = value; }
        public double Area { get => _area; set => _area = value; }
               
        public void RetornaPropriedades()
        {
            Console.WriteLine("------Propriedades------");
            Console.WriteLine($"O valor da altura é: {Altura}");
            Console.WriteLine($"O valor da base é: {Base}");
            Console.WriteLine($"O valor da área é: {Area}");
        }
    }
}