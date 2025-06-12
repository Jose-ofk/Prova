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


namespace ProvaGui
{

    public partial class Clientes: Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Clientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCepAsync(txtCep.Text);
        }

        private async Task buscarCepAsync(string cep)
        {
            try
            {
                cep = cep.Trim().Replace("-", "").Replace(" ", "");
                string urlViaCep = $"https://viacep.com.br/ws/{cep}/json/";

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
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}

