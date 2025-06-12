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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            adicionarColunas();
            carregarCsv();
        }
    }
}
