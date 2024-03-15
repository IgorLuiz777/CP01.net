namespace CP01.Models
{
    public class Produtos : IProdutos
    {
        private static long contador = 1;
        private static List<Produtos> listaProdutos = new List<Produtos>();

        public Produtos(double preco, string marca, string descricao, string modelo, long id = 0)
        {
            ID = id + contador++;
            Preco = preco;
            Marca = marca;
            Descricao = descricao;
            Modelo = modelo;
        }

        protected long ID { get; set; }
        private double Preco { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public string Modelo { get; set; }

        public long ObterID()
        {
            return ID;
        }

        public double ObterPreco() 
        { 
            return Preco;
        }

        internal void TipoProduto()
        {
            // Verificar Qual 
        }

        public virtual void Cadastrar()
        {
            listaProdutos.Add(this);
            Console.WriteLine($"ID: {ID}, Marca: {Marca}, Preço: {Preco:C}");
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
    }
}
