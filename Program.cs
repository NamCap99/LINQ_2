using LINQDemo2;

namespace LINQDemo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "AAA Company"},
                new Brand{ID = 2, Name = "BBB Company"},
                new Brand{ID = 3, Name = "CCC Company"},
                new Brand{ID = 4, Name = "ABCEDF Company"},};

            var products = new List<Product>(){
                new Product(1, "Tea table",      400, new string[] { "Gray", "Blue" },            2),
                new Product(2, "Wall painting",  400, new string[] { "Yellow", "Blue" },          1),
                new Product(3, "Chandelier",     500, new string[] { "White" },                   3),
                new Product(4, "Study desk",     200, new string[] { "White", "Blue" },           1),
                new Product(5, "Leather bag",    300, new string[] { "Red", "Black", "Yellow" },  2),
                new Product(6, "Bed",            500, new string[] { "White" },                   2),
                new Product(7, "Wardrobe",       600, new string[] { "White" },                   3),};
        }
    }
}