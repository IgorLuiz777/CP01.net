namespace CP01.Models
{
    public class Televisao : Produtos
    {
        public Televisao(long id, double preco, string marca, string descricao, string modelo, int polegadas, string resolucaoTela, string resolucao) : base(id, preco, marca, descricao, modelo)
        {
        }
        private int Polegadas;
        private string ResolucaoTela;
        private string Resolucao;

    }
}
