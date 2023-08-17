using ConsoleApp14;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Xml.Schema;
using System;

namespace ConsoleApp14 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product.ProductInformation();
        }

    }
}
//Cand am facut Downgrade the Newtonsoft.Json package version to 10.0.1 metoda nu a mai fost functionala
//Cand am facut update the Newtonsoft.Json package version to the latest stable metoda a devenit functionala