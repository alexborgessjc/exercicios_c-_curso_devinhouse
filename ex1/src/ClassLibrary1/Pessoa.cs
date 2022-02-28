namespace ClassLibrary1
{
    public class Pessoa
    {
        private string _nome;
        private DateTime _datanascimento;
        private Double _altura;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; } 
        }

        public DateTime DataNascimento
        {
            get { return _datanascimento; }
            set { _datanascimento = value; }
        }

        public Double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
    }
}