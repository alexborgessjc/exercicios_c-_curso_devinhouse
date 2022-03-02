using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Item
    {
        private string _nomedoitem;
        private Double _valor;
        
        public string NomeDoItem{ get => _nomedoitem; set => _nomedoitem = value; }
        public Double Valor { get => _valor; set => _valor = value; }
    }
}
