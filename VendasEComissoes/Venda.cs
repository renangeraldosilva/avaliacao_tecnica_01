using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEComissoes
{
    internal class Venda
    {
        private int idVendedor;

        public int IdVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }

        private string nomeProduto;

        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        private int qtdProduto;

        public int QtdProduto
        {
            get { return qtdProduto; }
            set { qtdProduto = value; }
        }

        private decimal totalVenda;

        public decimal TotalVenda
        {
            get { return totalVenda; }
            set { totalVenda = value; }
        }

        private decimal comissaoVendedor;

        public decimal ComissaoVendedor
        {
            get { return comissaoVendedor; }
            set { comissaoVendedor = value; }
        }

        public decimal ValorComissao()
        {
            decimal comissao = 0;

            if (qtdProduto <= 5)
            {
                comissao = (totalVenda /100) * 0.4M;
            }
            else if (qtdProduto <= 10)
            {
                comissao = (totalVenda / 100) * 1.3M;
            }
            else if (qtdProduto <= 15)
            {
                comissao = (totalVenda / 100) * 3.0M;
            }
            else if (qtdProduto >= 16)
            {
                comissao = (totalVenda / 100) * 5.0M;
            }
            return comissao;
        }

    }
}
