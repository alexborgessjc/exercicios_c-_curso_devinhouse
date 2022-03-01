namespace Exercicio4
{
    public class Usuario
    {
        private String _nome;
        private int _idade;

        public String Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }

        public void ExibirDados()
        {
            Console.WriteLine("------ A Maior idade E....------");
            Console.WriteLine($"O nome é: {Nome}");
            Console.WriteLine($"A idade é: {Idade}");
        }  
    }
}