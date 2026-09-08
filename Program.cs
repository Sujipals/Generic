using System;
using System.Collections.Generic;

namespace GenericCollection
{
    public class Program
    {
        public static void Main()
        {
            // ==========================================
            // Collection<string>
            // ==========================================

            Console.WriteLine("=== Collection<string> ===");

            Collection<string> names = new Collection<string>();

            names.Add("Anna");
            names.Add("Peter");
            names.Add("John");

            Console.WriteLine($"Count: {names.Count}");

            string foundName = names.Find(
                name => name == "Peter");

            Console.WriteLine($"Found: {foundName}");

            bool removedName = names.Remove("John");

            Console.WriteLine(
                $"John removed: {removedName}");

            bool removedMissingName = names.Remove("David");

            Console.WriteLine(
                $"David removed: {removedMissingName}");

            Console.WriteLine();


            // ==========================================
            // Collection<Product>
            // ==========================================

            Console.WriteLine("=== Collection<Product> ===");

            Collection<Product> products =
                new Collection<Product>();

            Product laptop =
                new Product("Laptop", 8000);

            Product mouse =
                new Product("Mouse", 300);

            Product keyboard =
                new Product("Keyboard", 700);

            products.Add(laptop);
            products.Add(mouse);
            products.Add(keyboard);

            Console.WriteLine(
                $"Count: {products.Count}");

            Product foundProduct =
                products.Find(
                    product => product.Price > 5000);

            Console.WriteLine(
                $"Found: {foundProduct}");

            bool removedProduct =
                products.Remove(mouse);

            Console.WriteLine(
                $"Mouse removed: {removedProduct}");

            Console.WriteLine();


            // ==========================================
            // Max<int> and Min<int>
            // ==========================================

            Console.WriteLine("=== Max<int> and Min<int> ===");

            List<int> numbers = new List<int>
            {
                10, 25, 7, 42, 18
            };

            int largest =
                GenericMethods.Max(numbers);

            int smallest =
                GenericMethods.Min(numbers);

            Console.WriteLine(
                $"Largest number: {largest}");

            Console.WriteLine(
                $"Smallest number: {smallest}");

            Console.WriteLine();


            // ==========================================
            // Max<Product> and Min<Product>
            // ==========================================

            Console.WriteLine("=== Max<Product> and Min<Product> ===");

            List<Product> productList =
                new List<Product>
                {
                    laptop,
                    mouse,
                    keyboard
                };

            Product mostExpensive =
                GenericMethods.Max(productList);

            Product cheapest =
                GenericMethods.Min(productList);

            Console.WriteLine(
                $"Most expensive: {mostExpensive}");

            Console.WriteLine(
                $"Cheapest: {cheapest}");

            Console.WriteLine();


            // ==========================================
            // Exception test
            // ==========================================

            Console.WriteLine("=== Exception test ===");

            try
            {
                List<int> emptyList =
                    new List<int>();

                GenericMethods.Max(emptyList);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(
                    $"Exception caught: {exception.Message}");
            }
        }
    }
}