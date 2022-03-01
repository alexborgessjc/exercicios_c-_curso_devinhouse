using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    public class Ingrediente
    {
        private int _idprato;
        private string _ingrediente;

        public int IdDoPrato
        { get => _idprato; set => _idprato = value; }
        public string NomeDoIngrediente
        { get => _ingrediente; set => _ingrediente = value; }
    }
}
