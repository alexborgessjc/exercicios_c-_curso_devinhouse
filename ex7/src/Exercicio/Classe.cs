using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Classe
    {
        private string _nomedaclasse;
        private List<Exame> _exames;

        public string NomeDaClasse { get => _nomedaclasse; set => _nomedaclasse = value; }
        public void AdicionarExame(IEnumerable<Exame> exame)
        {
            if (_exames == null)
            {
                _exames = new List<Exame>();
            }
            _exames.AddRange(exame);
            Console.WriteLine("--------Adicionado----");
        }
        public void RetornaMaiorNota()
        {
            Double maiorValor = 0;
            for (var i = 0; i < _exames.Count; i++)
            {
                // se o valor atual da lista for maior que o valor que já tenho
                if (_exames[i].NotaDoAluno > maiorValor)
                {
                    // atualiza o valor que ja tenho
                    maiorValor = _exames[i].NotaDoAluno;
                }
            }
            Console.WriteLine($"A Maior nota é: {maiorValor}");
        }
        public void RetornaMenorNota()
        {
            Console.WriteLine("--------Retona Menor-----");
            //int quantidade = _items.Count;
            //Console.WriteLine($"A quantidade é: {quantidade}");            
        }
        public void RetornaMediaNota()
        {
            Console.WriteLine("--------Retorna Média------");
            //int quantidade = _items.Count;
            //Console.WriteLine($"A quantidade é: {quantidade}");            
        }
        public void RetornaReprovados()
        {
            Console.WriteLine("-------Retorna Reprovados------");
            //int quantidade = _items.Count;
            //Console.WriteLine($"A quantidade é: {quantidade}");
        }
    }
}
