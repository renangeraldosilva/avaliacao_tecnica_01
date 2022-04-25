using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEComissoes
{
    internal class Vendedor
    {
        private int idVendedor;

        public int IdVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
