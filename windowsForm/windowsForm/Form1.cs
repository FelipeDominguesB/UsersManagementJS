using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace windowsForm
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        
        private async Task makeRequest()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:3000");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                

                List<User> usuarios = JsonSerializer.Deserialize<List<User>>(responseBody);
                

                FormUsers.DataSource = usuarios;
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.Message, "Erro fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await makeRequest();
        }
    }
}
