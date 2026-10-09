using JPLM_Estudos.DTOs;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JPLM_Estudos
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient cliente = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();

            cardImg.CellDoubleClick += CardImg_CellDoubleClick;
        }

        private void ConfigurarGrid()
        {
            cardImg.Columns.Clear();
            cardImg.Columns.Add("colIndice", "Índice");
            cardImg.Columns.Add("colUrl", "URL da Imagem");
            cardImg.Columns["colUrl"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQntImagem.Text, out int inputQtd) || inputQtd < 0)
            {
                MessageBox.Show("Digite um número válido maior que zero!");
                return;
            }

            if(inputQtd == 0)
            {
                cardImg.Rows.Clear();
                qtdText.Text = "0";
                return;
            }

            btnEnviar.Enabled = false;

            try
            {
                await requisicao(inputQtd);
                qtdText.Text = $"{inputQtd}";
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }
            finally
            {
                btnEnviar.Enabled = true;
                txtQntImagem.Text = "";
            }
        }

        private async Task requisicao(int inputQtd)
        {
            try
            {

                string url = $"https://dog.ceo/api/breeds/image/random/{inputQtd}";

                string resposta = await cliente.GetStringAsync(url);

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var dados = JsonSerializer.Deserialize<DTOimagem>(resposta, options);

                if (dados?.Message == null || dados.Message.Count == 0)
                {
                    MessageBox.Show("Nenhuma imagem retornada.");
                    return;
                }

                cardImg.Rows.Clear();
                var i = 1;
                foreach (string urlImagem in dados.Message)
                {
                    cardImg.Rows.Add(i, urlImagem);
                    i++;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }
        }

        private async void CardImg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string? urlImagem = cardImg.Rows[e.RowIndex].Cells["colUrl"].Value?.ToString();

                await ExibirImagemPopup(urlImagem);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }
        }

        private async Task ExibirImagemPopup(string urlImagem)
        {
            try
            {
                using var stream = await cliente.GetStreamAsync(urlImagem);
                using var imagem = new Bitmap(stream);

                using var popup = new Form()
                {
                    Text = "Homenagem: Resenha",
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(600, 500),
                    MinimizeBox = true,
                    MaximizeBox = true,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                var BoxImagem = new PictureBox()
                {
                    Dock = DockStyle.Fill,
                    Image = imagem,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };

                popup.Controls.Add(BoxImagem);
                popup.ShowDialog();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao carregar imagem: {erro.Message}");
            }
        }

        private void txtQntImagem_Click(object sender, EventArgs e)
        {
            txtQntImagem.Text = "";
        }
    }
}