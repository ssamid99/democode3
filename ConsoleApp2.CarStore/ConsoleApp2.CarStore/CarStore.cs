using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CarStore
{
    class CarStore
    {
        public string brand;
        public string model;
        public string city;
        public int graduitionYear;
        public string banType;
        public string color;
        public double engine;
        public int enginePower;
        public string fuelType;
        public int kmRate;
        public string gearbox;
        public string transmitter;
        public string situation;
        public double price;

        public string GetInfo()
        {
            string output = $"{brand}\n" +
                $"{model}\n" +
                $"{city}\n" +
                $"{graduitionYear}\n" +
                $"{banType}\n" +
                $"{color}\n" +
                $"{engine}l \n" +
                $"{enginePower} hp \n" +
                $"{fuelType}\n" +
                $"{kmRate} km \n" +
                $"{gearbox}\n" +
                $"{transmitter}\n" +
                $"{situation}\n" +
                $"{price}€";
            return output;
        }
    }
}
