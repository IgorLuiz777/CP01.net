namespace CP01.Models
{
    public class Produtos
    {
        private static long contador = 1;

        public Produtos(long id, double preco, string marca, string descricao, string modelo)
        {
            ID = id + contador++;
            Preco = preco;
            Marca = marca;
            Descricao = descricao;
            Modelo = modelo;
        }

        private long ID { get; set; }
        private double Preco { get; set; }
        private string Marca { get; set; }
        private string Descricao { get; set; }
        private string Modelo { get; set; }


    }
}
