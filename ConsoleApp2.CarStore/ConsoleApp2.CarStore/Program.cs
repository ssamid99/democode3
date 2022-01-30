using System;
using System.Text;

namespace ConsoleApp2.CarStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            CarStore car1 = new CarStore();

            car1.brand = "Bentley";
            car1.model = "Flying Spur";
            car1.city = "Baki";
            car1.graduitionYear = 2021;
            car1.banType = "Sedan";
            car1.color = "Black";
            car1.engine = 4.0;
            car1.enginePower = 550;
            car1.fuelType = "Gasoline";
            car1.kmRate = 1770;
            car1.gearbox = "Automatic";
            car1.transmitter = "Full";
            car1.situation = "New";
            car1.price = 255.000;

            CarStore car2 = new CarStore();


            car1.brand = "Ford";
            car1.model = "Flying Spur";
            car1.city = "Baki";
            car1.graduitionYear = 2021;
            car1.banType = "Sedan";
            car1.color = "Black";
            car1.engine = 4.0;
            car1.enginePower = 550;
            car1.fuelType = "Gasoline";
            car1.kmRate = 1770;
            car1.gearbox = "Automatic";
            car1.transmitter = "Full";
            car1.situation = "New";
            car1.price = 255.000;

            CarStore[] cars = new CarStore[3];
            cars[0] = car1;
            cars[1] = car2;
           

            foreach (CarStore car in cars)
            {
                Console.WriteLine(car.GetInfo());

            }
        }
    }
}
