namespace CP01.Models
{
    public class Geladeira : Produtos
    {
        public Geladeira(long id, double preco, string marca, string descricao, string modelo, string cor, string capacidade, string eficienciaEnerfetica) : base(id, preco, marca, descricao, modelo)
        {
        }

        private string Cor {  get; set; }
        private string Capacidade { get; set; }
        private string EficienciaEnergetica { get; set; }
    }
}
