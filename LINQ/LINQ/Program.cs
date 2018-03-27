using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1. Automobile and Buyer
            List<Automobile> automobiles = new List<Automobile>();
            automobiles.Add(new Automobile("BMW", "M5", DateTime.Now, "Black"));
            automobiles.Add(new Automobile("Audi", "A8", DateTime.Parse("01/10/2009 7:34 PM"), "White"));
            automobiles.Add(new Automobile("Jaguar", "Classic", DateTime.Parse("10.01.2009 19:34"), "Black Gray"));

            List<Buyer> buyers = new List<Buyer>();
            buyers.Add(new Buyer(automobiles[0], "Vasya", 0930323));
            buyers.Add(new Buyer(automobiles[1], "Sonya", 0932334));
            buyers.Add(new Buyer(automobiles[2], "Gosha", 0985965));

            var query = from buyer in buyers
                        from automobile in automobiles
                        where buyer.Car == "BMW" && automobile.Brand == "BMW"
                        orderby buyer.Car
                        select new
                        {
                            BuyerInfo = buyer.ToString(),
                            AutomobileInfo = automobile.ToString()
                        };
            foreach (var item in query)
            {
                Console.WriteLine(item.BuyerInfo + " ||| " + item.AutomobileInfo);
            }
            
            Console.ReadKey();
        }
    }
}
