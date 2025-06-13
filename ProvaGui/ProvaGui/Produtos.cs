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
    public partial class Produtos: Form
    {
        string caminhoCsv = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\produtos.csv";
        int indiceEdicao = -1;
        public Produtos()
        {
            InitializeComponent();
        }
        private void carregarCsv()
        {
            dgvProdutos.Rows.Clear();

            string[] linhas = File.ReadAllLines(caminhoCsv);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados.Length >= 2)
                {
                    string nome = dados[0];
                    string preco = dados[1];
                    string desc = dados[2];
                    string codigo = dados[3];

                    dgvProdutos.Rows.Add(nome, preco, desc, codigo);
                }
            }
        }
        public void adicionarColunas()
        {
            dgvProdutos.Columns.Clear();
            dgvProdutos.Columns.Add("Nome", "Nome");
            dgvProdutos.Columns.Add("Preço", "Preço");
            dgvProdutos.Columns.Add("Descrição", "Descrição");
            dgvProdutos.Columns.Add("Código", "Código");
        }
        public void cadastrarProdutos()
        {
            string nome = txtNome.Text;
            string preco = txtPreco.Text;
            string desc = txtDesc.Text;
            string codigo = txtCodigo.Text;


            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(preco) ||
                string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            if (indiceEdicao == -1)
            {
                foreach (string linha in linhas.Skip(1))
                {

                    if (linha.Split(';')[3] == codigo)
                    {
                        MessageBox.Show("O Produto já está cadastrado!", "Aviso!", MessageBoxButtons.OK);
                        return;
                    }
                }
                linhas.Add($"{nome};{preco};{desc};{codigo}");
            }
            else
            {
                linhas[indiceEdicao] = $"{nome};{preco};{desc};{codigo}";
                indiceEdicao = -1;
                btnCadastrar.Text = "Cadastrar";
            }

            File.WriteAllLines(caminhoCsv, linhas);

            txtNome.Clear();
            txtCodigo.Clear();
            txtDesc.Clear();
            txtPreco.Clear();
            carregarCsv();
        }
        private void excluirProduto()
        {
            string codigo = txtCodigoDeletar.Text;
            string linhaExcluir = "";
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');
                if (linha.Split(';')[3] == codigo)
                {
                    linhaExcluir = linha;
                }
            }

            if (linhaExcluir != "")
            {
                var dialogo = MessageBox.Show("Deseja mesmo excluir este cliente para sempre?", "Aviso!", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                {
                    linhas.Remove(linhaExcluir);
                    File.WriteAllLines(caminhoCsv, linhas);
                    carregarCsv();
                }
            }
        }
        private void editarProduto()
        {

            string codigo = txtCodigoEditar.Text;

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var dialogo = MessageBox.Show("Deseja atualizar esse produto?", "Aviso!", MessageBoxButtons.YesNo);
            if(dialogo == DialogResult.Yes)
            {
                var linhas = File.ReadAllLines(caminhoCsv).ToList();

                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(';');
                    if (linha.Split(';')[3] == codigo)
                    {
                        txtNome.Text = dados[0].ToString();
                        txtPreco.Text = dados[1].ToString(); ;
                        txtDesc.Text = dados[2].ToString(); ;
                        txtCodigo.Text = dados[3].ToString();

                        btnCadastrar.Text = "Editar";
                    }
                }
                indiceEdicao += 1;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarProdutos();
            carregarCsv();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            adicionarColunas();
            carregarCsv();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            excluirProduto();
            carregarCsv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarProduto();
            carregarCsv();
        }
    }
}
