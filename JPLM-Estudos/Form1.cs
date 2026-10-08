namespace JPLM_Estudos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var inputQtd = txtQntImagem.Text;

            requisicao(inputQtd);
        }

        private async Task requisicao(string inputQnt)
        {
            const string url = $"https://dog.ceo/api/breeds/image/random/{inputQnt}";


        }
    }
}
