namespace CP01.Models
{
    public class Geladeira : Produtos
    {
        public Geladeira(double preco, string marca, string descricao, string modelo, string cor, string capacidade, string eficienciaEnerfetica, long id = 0)
        : base(preco, marca, descricao, modelo, id)
        {
            Cor = cor;
            Capacidade = capacidade;
            EficienciaEnergetica = eficienciaEnerfetica;
        }

        public string Cor { get; set; }
        public string Capacidade { get; set; }
        public string EficienciaEnergetica { get; set; }

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.WriteLine($"Cor: {Cor}, Capacidade: {Capacidade}, Eficiência Energética: {EficienciaEnergetica}");
            Console.WriteLine("Geladeira cadastrada com sucesso!");
        }
    }
}
