using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;


namespace ProvaGui
{

    public partial class Clientes: Form
    {
        private static readonly HttpClient client = new HttpClient();
        string caminhoCsv = "C:\\Users\\usuario\\source\\repos\\Prova\\Dados\\clientes.csv";

        public Clientes()
        {
            InitializeComponent();
        }
        private async Task buscarCepAsync(string cep)
        {
            try
            {
                cep = cep.Trim().Replace("-", "").Replace(" ", "");
                string urlViaCep = $"https://viacep.com.br/ws/{cep}/json/";

                if (cep.Length != 8)
                {
                    MessageBox.Show("O cep precisa ter 8 números", "Erro!");
                }

                using (HttpClient cliente = new HttpClient())
                {
                    var response = await client.GetAsync(urlViaCep);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();

                    JObject endereco = JObject.Parse(json);

                    if (endereco["error"] != null)
                    {
                        MessageBox.Show("Cep não encontrado!", "Erro!");
                        return;
                    }

                    txtLogradouro.Text = endereco["logradouro"]?.ToString();
                    txtBairro.Text = endereco["bairro"]?.ToString();
                    txtCidade.Text = endereco["localidade"]?.ToString();
                    txtEstado.Text = endereco["uf"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        public void cadastroUsuarios()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cpf = mskCpf.Text;
            string telefone = mskTelefone.Text;
            string whats = mskWhatsapp.Text;
            string cep = txtCep.Text;
            string logradouro = txtLogradouro.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(telefone) ||
                string.IsNullOrEmpty(whats) || string.IsNullOrEmpty(cep) ||
                string.IsNullOrEmpty(logradouro) || string.IsNullOrEmpty(numero) ||
                string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(cidade) ||
                string.IsNullOrEmpty(estado)
               )
            {
                MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            foreach (string linha in linhas.Skip(1))
            {

                if (linha.Split(';')[2] == cpf)
                {
                    MessageBox.Show("O CPF já está cadastrado!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }
            }
            linhas.Add($"{nome};{email};{cpf};{telefone};{whats};{cep};{logradouro};{numero};{bairro};{cidade};{estado}");
            File.WriteAllLines(caminhoCsv, linhas);

            txtNome.Clear();
            txtEmail.Clear();
            mskCpf.Clear();
            mskTelefone.Clear();
            mskWhatsapp.Clear();
            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            carregarCsv();
        }
        public void carregarCsv()
        {
            dgvClientes.Rows.Clear();

            string[] linhas = File.ReadAllLines(caminhoCsv);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                if (dados.Length >= 2)
                {
                    string nome = dados[0];
                    string email = dados[1];
                    string cpf = dados[2];
                    string telefone = dados[3];
                    string whats = dados[4];
                    string cep = dados[5];
                    string logradouro = dados[6];
                    string numero = dados[7];
                    string bairro = dados[8];
                    string cidade = dados[9];
                    string estado = dados[10];

                    dgvClientes.Rows.Add(nome, email, cpf, telefone, whats, cep, logradouro, numero, bairro, cidade, estado);
                }
            }
        }
        public void adicionarColunas()
        {
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("Nome", "Nome");
            dgvClientes.Columns.Add("Email", "Email");
            dgvClientes.Columns.Add("CPF", "CPF");
            dgvClientes.Columns.Add("Telefone", "Telefone");
            dgvClientes.Columns.Add("Whatsapp", "Whatsapp");
            dgvClientes.Columns.Add("CEP", "CEP");
            dgvClientes.Columns.Add("Logradouro", "Logradouro");
            dgvClientes.Columns.Add("Número", "Número");
            dgvClientes.Columns.Add("Bairro", "Bairro");
            dgvClientes.Columns.Add("Cidade", "Cidade");
            dgvClientes.Columns.Add("Estado", "Estado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCepAsync(txtCep.Text);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastroUsuarios();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            adicionarColunas();
            carregarCsv();
        }
    }
}

