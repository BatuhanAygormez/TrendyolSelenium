using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolSelenium
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Giris = Auth.Login("testtest@gmail.com", "123456");
            Console.Read();

        }    
    }
}
