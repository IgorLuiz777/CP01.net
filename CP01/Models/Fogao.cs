namespace CP01.Models
{
    public class Fogao : Produtos
    {
        public Fogao(long id, double preco, string marca, string descricao, string modelo, int bocas, string cor, string capacidade) : base(id, preco, marca, descricao, modelo)
        {
        }

        private int Bocas { get; set; } 
        private String Cor { get; set; }
        private String Capacidade { get; set; }
        
    }
}
