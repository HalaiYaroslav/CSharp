using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Buyer
    {
        Automobile car;
        public string Car { get { return car.Brand; } }

        string buyerName;
        public string BuyerName { get { return buyerName; } }

        int buyerPhoneNumber;

        public Buyer(Automobile automobile, string buyerName, int buyerPhoneNumber)
        {
            car = automobile;
            this.buyerName = buyerName;
            this.buyerPhoneNumber = buyerPhoneNumber;
        }

        public override string ToString()
        {
            return $"Car model: {Car} Buyer Name: {buyerName} Phone Number {buyerPhoneNumber}";
        }
    }
}
