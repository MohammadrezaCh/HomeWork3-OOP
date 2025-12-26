
using OnlineShop.Discount;
using System.Net.Http.Headers;

namespace OnlineShop.Product
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Electronic("Iphone 17", 350000000, 24));
            products.Add(new Clothing("T-shirt", 500000, "Cotton thread", "L"));

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n==== ONLINE SHOP MENU ====");
                Console.WriteLine("1. Add Electronic Product");
                Console.WriteLine("2. Add Clothing Product");
                Console.WriteLine("3. Show All Products");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddElectronic(products);
                        break;

                    case 2:
                        AddClothing(products);
                        break;

                    case 3:
                        ShowProducts(products);
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }


        static void AddElectronic(List<Product> products)
        {
            Console.Write("Product name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Invalid price!");
                return;
            }

            Console.Write("Warranty (months): ");
            if (!int.TryParse(Console.ReadLine(), out int warranty))
            {
                Console.WriteLine("Invalid warranty!");
                return;
            }

            Electronic electronic = new Electronic(name, price, warranty);

            Console.Write("Discount percent: ");
            if (double.TryParse(Console.ReadLine(), out double discount))
            {
                electronic.ApplyDiscount(discount);
            }

            products.Add(electronic);
            Console.WriteLine("Electronic product added successfully!");
        }

        static void AddClothing(List<Product> products)
        {
            Console.Write("Product name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Invalid price!");
                return;
            }

            Console.Write("Material: ");
            string material = Console.ReadLine();

            Console.Write("Size: ");
            string size = Console.ReadLine();

            products.Add(new Clothing(name, price, material, size));
            Console.WriteLine("Clothing product added successfully!");
        }

        static void ShowProducts(List<Product> products)
        {
            Console.WriteLine("\n--- PRODUCT LIST ---");

            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            foreach (Product p in products)
            {
                Console.WriteLine(p.GetProductDetails());
            }
        }
    }
}
