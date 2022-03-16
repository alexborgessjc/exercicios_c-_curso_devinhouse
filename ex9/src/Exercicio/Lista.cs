using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Lista
    {        
        private List<Animal> _animais;
                
        public void AdicionarAnimal(IEnumerable<Animal> animal)
        {
            if (_animais == null)
            {
                _animais = new List<Animal>();
            }
            _animais.AddRange(animal);
            Console.WriteLine("--------Animais adicionados----");
        }
        public void RetornaCachorros()
        {
            int numerodecaes = 0;

            for (var i = 0; i < _animais.Count; i++)
            {                
                if (_animais[i].TipoDoAnimal == "cachorro")
                {
                    numerodecaes++;
                }
            }
            Console.WriteLine($"O número de cães é: {numerodecaes}");
        }
        public void RetornaGatos()
        {
            int numerodegatos = 0;

            for (var i = 0; i < _animais.Count; i++)
            {
                if (_animais[i].TipoDoAnimal == "gato")
                {
                    numerodegatos++;
                }
            }
            Console.WriteLine($"O número de gatos é: {numerodegatos}");
        }
    }
}
