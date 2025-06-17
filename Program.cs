using LINQDemo2;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQDemo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var brands = DataSeeder.GetBrands();
            var products = DataSeeder.GetProducts();

            System.Console.WriteLine("Hello");
        }
    }
}