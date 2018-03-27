using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace RegEx
{
    class Product
    {
        private string dateOfPurchase;
        private string name;
        private string currency;
        private int price;

        public Product(string date, string name, string currency, string price)
        {
            dateOfPurchase = date;
            this.name = name;
            this.currency = currency;
            this.price = Convert.ToInt32(price);
        }

        public override string ToString()
        {
            return $"{name}\nPrice: {price}{currency}\nDate of purchase: {dateOfPurchase}\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"Checks.txt");

            string[] checks = new string[0];
            Product[] products = new Product[0];

            int counter = 0;

            while (!reader.EndOfStream)
            {
                checks = ExtendArray(checks);
                checks[counter] = reader.ReadLine();
                counter++;
            }

            string namePattern = @"^[A-za-z0-9\. |A-za-z0-9\. -]+";
            string pricePattern = @"\s[0-9]{2,}\s";
            string currencyPattern = @"[0-9]\s[a-z]{3}\s";
            string datePattern = @"\d{2}\.\d{2}\.\d{4}";

            Regex nameMatcher = new Regex(namePattern);
            Regex priceMatcher = new Regex(pricePattern);
            Regex currencyMatcher = new Regex(currencyPattern);
            Regex dateMatcher = new Regex(datePattern);

            for (int i = 0; i < checks.Length; i++)
            {
                products = ExtendArray(products);
                products[i] = new Product(dateMatcher.Match(checks[i]).Value,
                                            nameMatcher.Match(checks[i]).Value.Trim(),
                                            currencyMatcher.Match(checks[i]).Value.Substring(1).Trim(),
                                            priceMatcher.Match(checks[i]).Value);
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();
        }

        private static T[] ExtendArray<T>(T[] arr)
        {
            T[] extendedArray = new T[arr.Length + 1];
            if (arr.Length != 0)
                arr.CopyTo(extendedArray, 0);
            return extendedArray;
        }
    }
}
