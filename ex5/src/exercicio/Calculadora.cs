namespace exercicio
{
    public class Calculadora
    {
        private Double _valor1;
        private Double _valor2;
        private String _operador;

        public Double Valor1{ get => _valor1; set => _valor1 = value; }
        public Double Valor2 { get => _valor2; set => _valor2 = value; }
        public String Operador { get => _operador; set => _operador = value; }

        public void Calcular()
        {
            if(Operador == "soma")
            {
                Double resultado = Valor1+Valor2;
                Console.WriteLine("Resultado:");
                Console.WriteLine($"O Resultado é:{resultado}");
            }
            if (Operador == "divisao")
            {
                Double resultado = Valor1 / Valor2;
                Console.WriteLine("Resultado:");
                Console.WriteLine($"O Resultado é:{resultado}");
            }
            if (Operador == "multiplicacao")
            {
                Double resultado = Valor1 * Valor2;
                Console.WriteLine("Resultado:");
                Console.WriteLine($"O Resultado é:{resultado}");
            }
            if (Operador == "subtracao")
            {
                Double resultado = Valor1 - Valor2;
                Console.WriteLine("Resultado:");
                Console.WriteLine($"O Resultado é:{resultado}");
            }

        }
    }
}