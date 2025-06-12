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
    public partial class Usuario: Login
    {
        string UsuarioA;
        string caminhoCsv = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\usuarios.csv";

        public Usuario(string UsuarioA)
        {
            InitializeComponent();
            this.UsuarioA = UsuarioA;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            if (UsuarioA != "ADMIN")
            {
                MessageBox.Show("Você pode alterar apenas a sua senha!");
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
    }
}
