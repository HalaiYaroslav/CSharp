using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Automobile
    {
        string brand;
        public string Brand { get { return brand; } }
        string model;       
        DateTime releaseYear;
        string color;

        public Automobile(string brand, string model, DateTime releaseYear, string color)
        {
            this.brand = brand;
            this.model = model;
            this.releaseYear = releaseYear;
            this.color = color;
        }

        public override string ToString()
        {
            return $"Brand: {brand}\tModel: {model}\tColor: {color}\tRelease Year: {releaseYear}";
        }
    }
}
