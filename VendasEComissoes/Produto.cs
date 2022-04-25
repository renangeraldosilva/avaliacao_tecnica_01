using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEComissoes
{
    internal class Produto
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int qtdEstoqueAtual;

        public int QtdEstoqueAtual
        {
            get { return qtdEstoqueAtual; }
            set { qtdEstoqueAtual = value; }
        }

        private int qtdEstoqueMinimo;

        public int QtdEstoqueMinimo
        {
            get { return qtdEstoqueMinimo; }
            set { qtdEstoqueMinimo = value; }
        }

        private int qtdEstoqueMaximo;

        public int QtdEstoqueMaximo
        {
            get { return qtdEstoqueMaximo; }
            set { qtdEstoqueMaximo = value; }
        }

        private decimal valorProduto;

        public decimal ValorProduto
        {
            get { return valorProduto; }
            set { valorProduto = value; }
        }

        public void ReporEstoqueSimOuNao()
        {

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"O estoque Atual é {qtdEstoqueAtual}");
            Console.WriteLine($"O estoque Minimo é {qtdEstoqueMinimo}");
            Console.WriteLine($"O estoque Maximo é {qtdEstoqueMaximo}");
            Console.WriteLine("-------------------------------------------------");
        }

        public bool verificarEstoqueAntesDaVenda(int qtdPedido)
        {
            if (qtdEstoqueAtual >= qtdPedido)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
