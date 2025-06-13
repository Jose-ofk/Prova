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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string caminhoCsv = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\usuarios.csv";

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string admin = "ADMIN";
            string senha = "123";
            bool encontrado = false;

            if (txtUsuario.Text == admin && txtSenha.Text == senha)
            {
                encontrado = true;
                MessageBox.Show($"Seja bem-vindo, {admin}!");
                Principal princ = new Principal(admin);
                this.Hide();
                princ.Show();
            }
            else
            {
                string[] linhas = File.ReadAllLines(caminhoCsv);
                foreach(string linha in linhas)
                {
                    string[] dados = linha.Split(';');

                    string usuario = dados[0].Trim();
                    string senhaUser = dados[1].Trim();
                    if(txtUsuario.Text == usuario && txtSenha.Text == senhaUser)
                    {
                        encontrado = true;
                        MessageBox.Show($"Seja bem-vindo, {usuario}!");
                        Principal princ = new Principal(usuario);
                        this.Hide();
                        princ.Show();
                    }
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("O usuário não pode ser encontrado!", "Aviso!");
            }
        }
    }
}
