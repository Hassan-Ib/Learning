using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "A2";


            Book book1 = new Book();
            book1.Author = "Robert Tabor";
            book1.Title = "Microsoft .Net XML WEB SERVICES";
            book1.ISBN = "0-000-00000-0";

            // ArrayList are dynamically sized,
            //sorting remove add
            ArrayList arrayList = new ArrayList();
            arrayList.Add(car1);
            arrayList.Add(car2);
            arrayList.Add(book1);
            arrayList.Remove(book1);

            foreach (Car car in arrayList)
            {
                Console.WriteLine(car.Make);
            }
            Console.WriteLine("type = {0}", car1.Make.GetType());
            // generec list List<T>

            List<Car> myList = new List<Car>(); // THIS WONT ALLOW DATA DIFFERENT DATA TYPE IN ON ARRAYLIST


            // dictionary 
            //Dictionary<Tkey, Tvalue>

            Dictionary<string, Car> myDict = new Dictionary<string, Car>();

            // OBJECT INTIALLIZER SYNTAX

            Car car3 = new Car() // NO NEED OF CONSTRUCTOR HERE
            {
                Make = "bmw",
                Model = "JHFD",
                VIN = "A3",
            };

            

            myDict.Add(car1.VIN, car1);
            myDict.Add(car2.VIN, car2);
            //myDict.Add(book1.Author, book1); // wont work cuz its generic;

            Console.WriteLine(myDict["A1"].Make);

            // GENERIC COLLECTION INTIALIZER;

            List<Car> carList = new List<Car>()
            {
                new Car {Make = "BWN", VIN= "NAD", Model= "MANDH"},
                new Car {Model = "KADJA", VIN = "NCMAD", Make = "MADNA"};
            };

            Console.WriteLine("Hello World!");
        }
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string VIN { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
