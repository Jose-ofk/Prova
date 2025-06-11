using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaGui
{
    public partial class Principal: Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes clt = new Clientes();
            clt.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Produtos prd = new Produtos();
            prd.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Pedidos ped = new Pedidos();
            ped.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            usr.ShowDialog();
        }
    }
}
