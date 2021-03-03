 using System;

namespace SimpleClassess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car myCar = new Car("marley", "black", 1995, "mitstubishe"); // refrence type 

           // myCar.Color = "silver";
            //myCar.Make = "Toyotal";
            //myCar.Model = "2.34";
            //myCar.Year = 1972;



            Car newCar = new Car();
            newCar.Year = 2000;

            newCar = null; // cleaning up the refreence // the .net will erase the object from the memory
            // this is also done by going out of scope

            Console.WriteLine("{0:C}", newCar.DeterminMarketValue());
            Console.WriteLine("{0:C}",myCar.DeterminMarketValue());


        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car() // contructor below is know as contructor overload
        {
            Make = "Nizzan";
        }

        public Car(string model,string color, int year, string make) // we can have to constructor 
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }


        public decimal DeterminMarketValue() // this is a method  //methods names aew
        {
            decimal carValue;
            if (Year < 1999)
            {
                carValue = 20000m;
            }
            else
            {
                carValue = 2000m;
            }

            return carValue;
        }

    }
}
