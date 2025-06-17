using LINQDemo2;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQDemo2
{
    public class Program
    {
        // 1. Filter products by price range
        // Show all products priced between $300 and $500.
        public static void ShowProuctInPriceRange(List<Product> products)
        {
            System.Console.WriteLine("Show all products priced between $300 and $500.");
            var productsFrom300to500 = products.Where(p => p.Price >= 300 && p.Price <= 500);
            foreach (var product in productsFrom300to500)
            {
                System.Console.WriteLine(product);
            }
        }

        // 2. Get products that come in the color "White"
        // Return product names that are available in white.
        public static void GetProductsWithColorWhite(List<Product> products)
        {
            System.Console.WriteLine("Get products that come in the color White");
            var GetProducts = products.Where(p => p.Colors.Contains("White"))
                .Select(p => new
                {
                    p.Name,
                    p.Price,
                    colorWhite = string.Join(",", p.Colors),
                });

            foreach (var product in GetProducts)
            {
                System.Console.WriteLine(product);
            }
        }
        // 3. Join products with their brand names
        // Return: ProductName, Price, BrandName.
        public static void JoinProductWithBrand(List<Product> products, List<Brand> brand)
        {
            System.Console.WriteLine("Products with their brand names");
            var productBrand = products.Join(brand,
                p => p.Brand,
                b => b.ID,
                (p, b) => new
                {
                    // p.Name, --> wrong
                    productName = p.Name,
                    productPrice = p.Price,
                    // b.Name, --> wrong 
                    brandName = b.Name,
                });

            foreach (var item in productBrand)
            {
                System.Console.WriteLine(item);
            }
        }

        // 4. Group products by brand
        // Show each brand and the list of product names under it.
        public static void groupProductByBrand(List<Product> product, List<Brand> brand)
        {
            System.Console.WriteLine("Group products by brand");
            var productByBrand = brand.Join(product,
                b => b.ID,
                p => p.Brand,
                (b, p) => new
                {
                    brandName = b.Name,
                    productName = p.Name,
                });
            foreach (var item in productByBrand)
            {
                System.Console.WriteLine(productByBrand);
            }
        }

        // 5. Count how many products each brand has
        // Return: BrandName, ProductCount.

        // 6. Find the most expensive product
        // Return full details of the product with the highest price.

        // 7. Sort products by price descending
        // Return: ProductName, Price, sorted highest to lowest.

        // 8. Find products with more than 2 color options
        // Return product names that have 3 or more color variants.

        // 9. Average price of all products
        // Return a single double value representing the average price.

        // 10. Get all products and their color list as CSV
        // Return: ProductName, Colors (comma separated).

        // 11. List brand names that don’t have any products
        // Use GroupJoin to find brands with 0 products.

        // 12. Group products by number of colors they have
        // E.g., 1 color → [ProductA, ProductB], 2 colors → [ProductC]

        // 13. Get top 3 most expensive products
        // Return top 3 items ordered by price descending.

        // 14. Check if any product has the color "Pink"
        // Return true/false.

        // 15. Get total inventory value
        // Assuming each product has a quantity (add a Quantity field), calculate total stock value: Price * Quantity.
        public static void Main(string[] args)
        {
            var brands = DataSeeder.GetBrands();
            var products = DataSeeder.GetProducts();

            ShowProuctInPriceRange(products);
            GetProductsWithColorWhite(products);
            JoinProductWithBrand(products, brands);
            groupProductByBrand(product, brand);


        }
    }
}