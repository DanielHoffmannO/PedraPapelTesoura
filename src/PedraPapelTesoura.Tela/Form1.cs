using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace PedraPapelTesoura.Tela
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        public string Url = "https://localhost:57230/api";
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Joganatela(0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Joganatela(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Joganatela(2);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private async void Joganatela(byte escolha)
        {
            var retorno = await client.GetAsync($"{Url}/PedraPapelTesoura/{escolha}");
            if (retorno.IsSuccessStatusCode)
            {
                var json = await retorno.Content.ReadAsStringAsync();
                label1.Text = json;
                Contador();
            }
        }

        private async void Contador()
        {
            var contVc = await client.GetAsync($"{Url}/PedraPapelTesoura/Contador/true");
            var contPc = await client.GetAsync($"{Url}/PedraPapelTesoura/Contador/false");

            label5.Text = await contPc.Content.ReadAsStringAsync();
            label4.Text = await contVc.Content.ReadAsStringAsync();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}