using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public static void ProductInformation()
        {
            Product product = new Product
            {
                ProductName = "Notebook",
                ProductPrice = 10
            };
            var json = JsonConvert.SerializeObject(product, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new KebabCaseNamingStrategy()
            }
        });

        Console.WriteLine(json);
        }
    }
}
