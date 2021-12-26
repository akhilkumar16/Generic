using System;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "boe");
            hash.Add("2", "co");
            hash.Add("3", "ho");
            hash.Add("4", "eo");
            hash.Add("5", "vh");

            static string hash(5) = hash.Get("5");
            Console.WriteLine("5th index value : ", +hash5);
        }
    }
}
