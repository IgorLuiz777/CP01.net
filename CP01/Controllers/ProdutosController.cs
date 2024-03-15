using CP01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CP01.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            List<Produtos> produtos = ProdutosCadastrados();
            return View(produtos);
        }

        public IActionResult Geladeiras()
        {
            List<Geladeira> geladeiras = GeladeirasCadastradas();
            return View(geladeiras);
        }

        public IActionResult Tvs()
        {
            List<Televisao> tvs = TvsCadastradas();
            return View(tvs);
        }

        public IActionResult Fogoes()
        {
            List<Fogao> fogoes = FogoesCadastrados();
            return View(fogoes);
        }

        private List<Geladeira> GeladeirasCadastradas()
        {
            List<Geladeira> geladeiras = new List<Geladeira>
            {
                new Geladeira(2000.0, "Consul", "Geladeira Frost Free", "Modelo 123", "Branca", "300L", "A+"),
                new Geladeira(1800.0, "Electrolux", "Duplex", "Modelo 456", "Prata", "400L", "A++"),
                new Geladeira(2200.0, "Brastemp", "Side By Side", "Modelo 789", "Inox", "500L", "A+++"),
                new Geladeira(2500.0, "Electrolux", "Inverse", "Modelo 987", "Preto", "350L", "A+"),
                new Geladeira(1900.0, "Consul", "Geladeira Cycle Defrost", "Modelo 654", "Branca", "250L", "A")
            };
            return geladeiras;
        }

        private List<Fogao> FogoesCadastrados()
        {
            List<Fogao> fogoes = new List<Fogao>
            {
                new Fogao(2000.0, "Consul", "Fogão 5 Bocas", "Fogão de piso com 5 bocas", 5, "Preto", "60 litros"),
                new Fogao(1800.0, "Electrolux", "Fogão 4 Bocas", "Fogão de piso com 4 bocas", 4, "Prata", "50 litros"),
                new Fogao(2300.0, "Brastemp", "Fogão 6 Bocas", "Fogão de embutir com 6 bocas", 6, "Inox", "70 litros"),
                new Fogao(1600.0, "Consul", "Fogão 5 Bocas", "Fogão de piso com 5 bocas", 5, "Branco", "55 litros"),
                new Fogao(2100.0, "Electrolux", "Fogão 4 Bocas", "Fogão de embutir com 4 bocas", 4, "Inox", "65 litros")
            };
            return fogoes;
        }


        private List<Televisao> TvsCadastradas()
        {
            List<Televisao> tvs = new List<Televisao>
            {
                new Televisao(2000.0, "Samsung", "Smart TV 4K", "Modelo 123", 50, "3840x2160", "4K"),
                new Televisao(1800.0, "LG", "Full HD", "Modelo 456", 42, "1920x1080", "Full HD"),
                new Televisao(2500.0, "Sony", "Smart TV LED 8K", "Modelo 789", 65, "7680x4320", "8K"),
                new Televisao(1700.0, "Philips", "Ultra Slim", "Modelo 987", 32, "1366x768", "HD"),
                new Televisao(2200.0, "Samsung", "QLED", "Modelo 654", 55, "3840x2160", "4K")
            };
            return tvs;
        }

        private List<Produtos> ProdutosCadastrados()
        {
            List<Produtos> produtos = new List<Produtos>
            {
                new Geladeira(2000.0, "Consul", "Geladeira Frost Free", "Modelo 123", "Branca", "300L", "A+"),
                new Geladeira(1800.0, "Electrolux", "Duplex", "Modelo 456", "Prata", "400L", "A++"),
                new Geladeira(2200.0, "Brastemp", "Side By Side", "Modelo 789", "Inox", "500L", "A+++"),
                new Geladeira(2500.0, "Electrolux", "Inverse", "Modelo 987", "Preto", "350L", "A+"),
                new Geladeira(1900.0, "Consul", "Geladeira Cycle Defrost", "Modelo 654", "Branca", "250L", "A"),
                new Fogao(2000.0, "Consul", "Fogão 5 Bocas", "Fogão de piso com 5 bocas", 5, "Preto", "60 litros"),
                new Fogao(1800.0, "Electrolux", "Fogão 4 Bocas", "Fogão de piso com 4 bocas", 4, "Prata", "50 litros"),
                new Fogao(2300.0, "Brastemp", "Fogão 6 Bocas", "Fogão de embutir com 6 bocas", 6, "Inox", "70 litros"),
                new Fogao(1600.0, "Consul", "Fogão 5 Bocas", "Fogão de piso com 5 bocas", 5, "Branco", "55 litros"),
                new Fogao(2100.0, "Electrolux", "Fogão 4 Bocas", "Fogão de embutir com 4 bocas", 4, "Inox", "65 litros"),
                new Televisao(2000.0, "Samsung", "Smart TV 4K", "Modelo 123", 50, "3840x2160", "4K"),
                new Televisao(1800.0, "LG", "Full HD", "Modelo 456", 42, "1920x1080", "Full HD"),
                new Televisao(2500.0, "Sony", "Smart TV LED 8K", "Modelo 789", 65, "7680x4320", "8K"),
                new Televisao(1700.0, "Philips", "Ultra Slim", "Modelo 987", 32, "1366x768", "HD"),
                new Televisao(2200.0, "Samsung", "QLED", "Modelo 654", 55, "3840x2160", "4K"),
            };
            return produtos;
        }
    }
}
