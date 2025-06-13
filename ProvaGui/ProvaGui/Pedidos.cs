using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaGui
{
    public partial class Pedidos: Form
    {
        string caminhoCsvCliente = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\clientes.csv";
        string caminhoCsvProdutos = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\produtos.csv";
        string caminhoCsvPedidos = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\pedidos.csv";

        public Pedidos()
        {
            InitializeComponent();
        }
        private void carregarCsv()
        {
            dgvPedidos.Rows.Clear();

            string[] linhas = File.ReadAllLines(caminhoCsvPedidos);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados.Length >= 2)
                {
                    string nome = dados[0];
                    string preco = dados[1];
                    string desc = dados[2];
                    string codigo = dados[3];

                    dgvPedidos.Rows.Add(nome, preco, desc, codigo);
                }
            }
        }
        public void adicionarColunas()
        {
            dgvPedidos.Columns.Clear();
            dgvPedidos.Columns.Add("Nome", "Nome");
            dgvPedidos.Columns.Add("Preço", "Preço");
            dgvPedidos.Columns.Add("Descrição", "Descrição");
            dgvPedidos.Columns.Add("Código", "Código");
            dgvPedidos.Columns.Add("Quantidade", "Quantidade");
        }
        public void buscarCliente()
        {
            var linhas = File.ReadAllLines(caminhoCsvCliente).ToList();
            string cpf = mskCpf.Text;

            foreach (string linha in linhas.Skip(1))
            {
                string[] dados = linha.Split(';');
                if (linha.Split(';')[2] == cpf)
                {
                    lblNome.Text = $"Nome: {dados[0]}";
                }
            }
        }
        public void cadastrarProduto()
        {
            string nome;
            string preco;
            string desc;
            string codigo;
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK);
                return;
            }
            var linhasProduto = File.ReadAllLines(caminhoCsvProdutos).ToList();
            string produto = txtId.Text;

            foreach (string linha in linhasProduto)
            {
                string[] dados = linha.Split(';');
                if (linha.Split(';')[3] == produto)
                {
                    nome = dados[0];
                    preco = dados[1];
                    desc = dados[2];
                    codigo = dados[3];
                    linhasProduto.Add($"{nome};{preco};{desc};{codigo};{txtQuantidade.Text}");
                    break;
                }
            }
            File.WriteAllLines(caminhoCsvPedidos, linhasProduto);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            adicionarColunas();
            carregarCsv();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadastrarProduto();
            carregarCsv();
        }
    }
}
