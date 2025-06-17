using LINQDemo2;

namespace LINQDemo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var brands = DataSeeder.GetBrands();
            var products = DataSeeder.GetProducts();
        }
    }
}