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
        public class Produto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Preco { get; set; }
        }

        List<Produto> produtos = new List<Produto>();
        static void Main(string[] args)
        {   
            Console.Write("---Seja bem vindo ao Intelitrader Livro de Ofertas---\n");
            bool loop = true;
            do
            {
                Console.WriteLine("\nEscolha uma opção abaixo:\n 1-Cadastrar produto\n 2-Mostrar livro de ofertas 0-Sair");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Digite o ID do produto:");
                        int id = Console.ReadLine();
                        produtos.Add(new Produto {Id=id});
                        break;
                    case 2:
                        Console.WriteLine(  
                    case 0:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
