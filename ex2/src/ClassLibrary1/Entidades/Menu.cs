using ClassLibrary1.Entidades;

namespace ClassLibrary1
{
    public class Menu
    {
        private string _nomedoprato;        
        private Double _preco;
        private int _idprato;

        public string NomeDoPrato
        { get => _nomedoprato; set => _nomedoprato = value; }
        public Double Preco
        { get => _preco; set => _preco = value; }
        public int IdDoPrato
        { get => _idprato; set => _idprato = value; }       
    }    
}