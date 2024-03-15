namespace CP01.Models
{
    public class Fogao : Produtos
    {
        public Fogao(double preco, string marca, string descricao, string modelo, int bocas, string cor, string capacidade, long id = 0)
        : base(preco, marca, descricao, modelo)
        {
            Bocas = bocas;
            Cor = cor;
            Capacidade = capacidade;
        }

        public int Bocas { get; set; }
        public String Cor { get; set; }
        public String Capacidade { get; set; }

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.WriteLine($"Cor: {Cor}, Capacidade: {Capacidade}, Bocas: {Bocas}");
            Console.WriteLine("Fogão cadastrada com sucesso!");
        }

    }
}
