using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace TrendyolSelenium
{
    internal class Auth
    {
        public static async Task Login(string email, string parola) 
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("culture", "tr-TR");
            client.DefaultRequestHeaders.Add("storefront-id", "1");
            client.DefaultRequestHeaders.Add("application-id", "1");
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.0.0 Safari/537.36");
            StringContent LoginContent = new StringContent("{\"email\":\""+email+"\",\"password\":\""+parola+"\"}",Encoding.UTF8, "application/json");

            var PostLogin = await client.PostAsync(API.LoginURL,LoginContent);

        }

        public static async Task Register()
        {

        }
    }
}
