using System.Text.Json;
using JPLM_Estudos.DTOs;

namespace JPLM_Estudos
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient cliente = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            cardImg.Columns.Clear();
            cardImg.Columns.Add("colUrl", "URL da Imagem");
            cardImg.Columns["colUrl"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtQntImagem.Text, out int inputQtd) || inputQtd <= 0)
            {
                MessageBox.Show("Digite um número válido maior que zero! OBS: Letras não são válidas!");
                return;
            }

            btnEnviar.Enabled = false;

            try
            {
                await requisicao(inputQtd);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }
            finally
            {
                btnEnviar.Enabled = true;
                txtQntImagem.Text = "";
            }
        }

        private async Task requisicao(int inputQtd)
        {
            string url = $"https://dog.ceo/api/breeds/image/random/{inputQtd}";
                        
            string resposta = await cliente.GetStringAsync(url);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var dados = JsonSerializer.Deserialize<DTOimagem>(resposta, options);

            if (dados?.Message == null)
            {
                MessageBox.Show("Nenhuma imagem retornada.");
                return;
            }

            cardImg.Rows.Clear();
            foreach (string urlImagem in dados.Message)
            {
                cardImg.Rows.Add(urlImagem);
            }
        }
    }
}