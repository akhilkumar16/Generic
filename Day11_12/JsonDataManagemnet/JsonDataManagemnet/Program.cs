using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonDataManagemnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item() { product = " rice", Weight = " 1kg", Costperkg = " 50" };
            var jsonItem = JsonConvert.SerializeObject(item);
            File.WriteAllText(@"List.json", jsonItem);
            Console.WriteLine("Stored");
        }
    }
    public class Inventory
    {
        public string items { get; set; }
        public string Quantity { get; set; }

        public int PriceID { get; set; }
    }
}
