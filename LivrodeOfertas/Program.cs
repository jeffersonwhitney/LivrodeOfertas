using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LivrodeOfertas
{
    internal class Program
    {
        public class Oferta
        {
            public int posicao { get; set; }
            public double valor { get; set; }
            public int quantidade { get; set; }
        }

        static List<Oferta> ofertas = new List<Oferta>();

        static void Main(string[] args)
        {   
            Console.Write("---Seja bem vindo ao Intelitrader Livro de Ofertas---\n");
            bool loop = true;
            do
            {
                Console.WriteLine("\nEscolha uma opção abaixo:\n 1-Cadastrar oferta\n 2-Mostrar historico de ofertas cadastradas\n 3-Mostrar livro de ofertas por posição\n 0-Sair");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Oferta oferta = new Oferta();
                        Console.WriteLine("Digite a posição do oferta:");
                        oferta.posicao = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o valor do oferta: ");
                        oferta.valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade da oferta: ");
                        oferta.quantidade = Convert.ToInt32(Console.ReadLine());
                        ofertas.Add(oferta);
                        break;
                    case 2:
                        Console.WriteLine("\n Ofertas cadastradas:");
                        foreach (var ofertaAtual in ofertas)
                        {
                            Console.WriteLine($"Posição: {ofertaAtual.posicao} | Valor: R${ofertaAtual.valor} | Quantidade: {ofertaAtual.quantidade}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Ofertas cadastradas por posição:");
                        var ofertasPorPosicao = ofertas.OrderBy(p => p.posicao);
                        foreach (var ofertaPorPosicao in ofertasPorPosicao)
                        {
                            Console.WriteLine($"Posição: {ofertaPorPosicao.posicao} | Valor: R${ofertaPorPosicao.valor} | Quantidade: {ofertaPorPosicao.quantidade}");
                        }
                        break;
                    case 0:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            while (loop);
        }
    }
}

