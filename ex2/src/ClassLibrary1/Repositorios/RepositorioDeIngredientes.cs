using ClassLibrary1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositorio
{
    public class RepositorioDeIngredientes
    {
        private List<Ingrediente> _ingredientes;
        public void AdicionarIngrediente(IEnumerable<Ingrediente> ingrediente)
        {
            if (_ingredientes == null)
            {
                _ingredientes = new List<Ingrediente>();
            }
            _ingredientes.AddRange(ingrediente);
        }
        public void RetornarIngredientePorId(int IdDoPrato)
        { 
            List<Ingrediente> retorno = _ingredientes.FindAll(delegate (Ingrediente i) { return i.IdDoPrato == IdDoPrato; });

            Console.WriteLine("Lista de ingredientes : ");
            retorno.ForEach(delegate (Ingrediente i)
            {
                Console.WriteLine(String.Format("{0}", i.NomeDoIngrediente));
            });
        }
    }
}
