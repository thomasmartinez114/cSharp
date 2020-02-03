using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarInfo("Red", "Toyota");

            Console.WriteLine("Car 1 is " + car.color);
        }
    }

    public class CarInfo
    {
        public CarInfo(string _color, string _manufacturer)
        {
            this.color = _color;
            this.manufacturer = _manufacturer;
        }

        public string color { set; get; }
        public string manufacturer { set; get; }
    }

    public class SaloonCar : CarInfo
    {
        public SaloonCar()
        {

        }

        public string numberOfSeats { get; set; }
    }
}
