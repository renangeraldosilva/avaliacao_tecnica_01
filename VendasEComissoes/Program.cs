using System;
using System.Collections.Generic;

namespace VendasEComissoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaDeProdutos = new List<Produto>();
            List<Venda> listaDeVendas = new List<Venda>();

            listaDeProdutos.Add(new Produto() { Nome = "FACA", QtdEstoqueAtual = 75, QtdEstoqueMaximo = 100, QtdEstoqueMinimo = 50, ValorProduto = 12.5M }) ;
            listaDeProdutos.Add(new Produto() { Nome = "GARFO", QtdEstoqueAtual = 52, QtdEstoqueMaximo = 135, QtdEstoqueMinimo = 20, ValorProduto = 7.5M });

            Console.WriteLine("Quantas vendas você vai fazer? ");
            int numeroVendas = int.Parse(Console.ReadLine());

            Vendedor vendedor = new Vendedor();

            Console.WriteLine("Venderdor qual é o seu ID?");
            vendedor.IdVendedor = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroVendas; i++)
            { 
                Venda venda = new Venda();

                venda.IdVendedor = vendedor.IdVendedor;

                Console.WriteLine($"Qual o nome do {i+1}° produto");
                string nomeProduto = Console.ReadLine().ToUpper();

                Console.WriteLine("Qual a quantidade ");
                int qtdProduto = int.Parse(Console.ReadLine());

                Produto produto = listaDeProdutos.Find(x => x.Nome == nomeProduto);
                produto.ReporEstoqueSimOuNao();
                if (produto.verificarEstoqueAntesDaVenda(qtdProduto))
                {
                    decimal totalVenda = produto.ValorProduto * qtdProduto;

                    venda.NomeProduto = nomeProduto;
                    venda.QtdProduto = qtdProduto;
                    venda.TotalVenda = totalVenda;
                    venda.ComissaoVendedor = venda.ValorComissao();

                    listaDeVendas.Add(venda);
                    produto.QtdEstoqueAtual = produto.QtdEstoqueAtual - qtdProduto;
                    Console.WriteLine($"Venda efetuada {totalVenda}R$");
                    Console.WriteLine($"A comissão foi de {venda.ComissaoVendedor}R$");
                    Console.WriteLine("-------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"não temos o total solicitado, no estoque há {produto.QtdEstoqueAtual} unidades");
                    Console.WriteLine("-------------------------------------------------");
                }
                
            }
        }
    }
}
