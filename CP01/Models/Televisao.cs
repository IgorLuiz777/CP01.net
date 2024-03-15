using System.Runtime.ConstrainedExecution;

namespace CP01.Models
{
    public class Televisao : Produtos
    {
        public Televisao(double preco, string marca, string descricao, string modelo, int polegadas, string resolucaoTela, string resolucao, long id = 0)
        : base(preco, marca, descricao, modelo, id)
        {
            Polegadas = polegadas;
            ResolucaoTela = resolucaoTela;
            Resolucao = resolucao;
        }
        public int Polegadas;
        public string ResolucaoTela;
        public string Resolucao;

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.WriteLine($"Polegadas: {Polegadas}, ResolucaoTela: {ResolucaoTela}, Resolução: {Resolucao}");
            Console.WriteLine("Geladeira cadastrada com sucesso!");
        }
    }
}
