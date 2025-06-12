using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaGui
{
    public partial class UsuarioCadastro: Form
    {
        string UsuarioA;
        public UsuarioCadastro(string UsuarioA)
        {
            InitializeComponent();
            this.UsuarioA = UsuarioA;
        }
        
        string caminhoCsv = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\usuarios.csv";

        private void UsuarioCadastro_Load(object sender, EventArgs e)
        {
            if (UsuarioA != "ADMIN")
            {
                MessageBox.Show("Você pode alterar apenas a sua senha!");
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
                txtUsuario.Enabled = false;
                txtExcluirUsuario.Enabled = false;
                txtSenhaUsuario.Enabled = false;
                txtUsuarioEditar.Enabled = false;

                txtUsuarioEditar.Text = UsuarioA;

                string [] linhas = File.ReadAllLines(caminhoCsv);
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(';');

                    string usuario = dados[0].Trim();
                    string senhaUser = dados[1].Trim();

                    if (UsuarioA == usuario) 
                    {
                        txtSenhaEditar.Text = senhaUser;
                        break;
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
