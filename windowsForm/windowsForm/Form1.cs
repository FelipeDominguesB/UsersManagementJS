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

        private async void Form1_Load(object sender, EventArgs e)
        {
            await makeRequest();
            
        }
        
        private async Task makeRequest()
        {
           
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:3000");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                

                var dados = JsonSerializer.Deserialize<User>(responseBody);
                

                dataGridView1.DataSource = dados;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
