using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiTestConsole
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await Req();
            Console.ReadKey();
        }

        static async Task Req()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:3000");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
