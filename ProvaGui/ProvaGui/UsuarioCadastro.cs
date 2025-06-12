using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaGui
{
    public partial class UsuarioCadastro : Form
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
            dgvUsuario.Columns.Clear();
            dgvUsuario.Columns.Add("Usuário", "Usuário");
            dgvUsuario.Columns.Add("Senha", "Senha");

            criarCsv();
            carregarCsv();

            if (UsuarioA != "ADMIN")
            {
                MessageBox.Show("Você pode alterar apenas a sua senha!");
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
                txtUsuario.Enabled = false;
                txtSenhaUsuario.Enabled = false;
                txtUsuarioEditar.Enabled = false;

                txtUsuarioEditar.Text = UsuarioA;

                string[] linhas = File.ReadAllLines(caminhoCsv);
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
            string usuario = txtUsuario.Text;
            string senha = txtSenhaUsuario.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            foreach (string linha in linhas.Skip(1))
            {

                if (linha.Split(';')[0] == usuario)
                {
                    MessageBox.Show("O usuário já existe", "Aviso!", MessageBoxButtons.OK);
                    return;
                }
            }
            linhas.Add($"{usuario};{senha}");

            File.WriteAllLines(caminhoCsv, linhas);

            txtSenhaUsuario.Clear();
            txtUsuario.Clear();
            carregarCsv();
        }

        private void btnEditarSenha_Click(object sender, EventArgs e)
        {
            string usuarioAtualizado = txtUsuarioEditar.Text.Trim();
            string senhaAtualizada = txtSenhaEditar.Text.Trim();
            bool senhaAlterada = false;

            if (string.IsNullOrEmpty(usuarioAtualizado) || string.IsNullOrEmpty(senhaAtualizada))
            {
                MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK);
                return;
            }

            string[] linhas = File.ReadAllLines(caminhoCsv);
            for(int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(';');

                string usuario = dados[0].Trim();
                string senhaUser = dados[1].Trim();

                if(usuario == txtUsuarioEditar.Text)
                {
                    linhas[i] = $"{usuario};{senhaAtualizada}";
                    senhaAlterada = true;
                }
            }
            if (senhaAlterada == true)
            {
                MessageBox.Show("Senha alterada com sucesso!", "Sucesso!");
                File.WriteAllLines(caminhoCsv, linhas);
            }
            else
            {
                MessageBox.Show("Erro! Não foi possivel encontrar o usuário!");
            }
            carregarCsv();
        }

        public void carregarCsv()
        {
            dgvUsuario.Rows.Clear();

            string[] linhas = File.ReadAllLines(caminhoCsv);

            foreach(string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if(dados.Length >= 1)
                {
                    string usuario = dados[0];
                    string senha = dados[1];
                    dgvUsuario.Rows.Add(usuario, senha);
                }
            }
        }

        public void criarCsv()
        {
            if (!File.Exists(caminhoCsv))
            {
                using (StreamWriter sw = new StreamWriter(caminhoCsv)) 
                {
                    sw.WriteLine("Usuário;Senha");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir!");
                return;
            }

            var dialogo = MessageBox.Show("Deseja excluir esse usuário?", "Aviso!", MessageBoxButtons.YesNo);
            if(dialogo == DialogResult.Yes)
            {
                int rowIndex = dgvUsuario.SelectedRows[0].Index;
                var linhas = File.ReadLines(caminhoCsv).ToList();

                linhas.RemoveAt(rowIndex);
                File.WriteAllLines(caminhoCsv, linhas);
                carregarCsv();
            } 
        }
    }
}
