using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ LANGUAGE INTEGRATED QUERY SYNTAX to query collection

            //ArrayList arrayList = new ArrayList();
            //Dictionary<string, List<int>> keyValuePairs = new Dictionary<string, List<int>>();
            List<Car> myCar = new List<Car>(){
                new Car {VIN = "A1", Make = "BMW", Model ="MODEL1", Year = 1995},
                new Car {VIN = "A2", Make = "TOYOTAL", Model ="MODEL2", Year = 1996},
                new Car {VIN = "A3", Make = "BENZ", Model ="MODEL3", Year = 1997},
                new Car {VIN = "A4", Make = "TESLA", Model ="MODEL4", Year = 1998},
                new Car {VIN = "A5", Make = "FERARI", Model ="MODEL5", Year = 1999},


            };
            // SEARC AND SORT , QUERY syntax vs method syntax
            // QUERY Syntax;
            /* var bmws = from car in myCar // query syntax returns enumirable
                       where car.Make == "BMW"
                       select car;
            
             foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
             */

            /*// Linq method syntax
            //var bmws = myCar.Where(p => p.Make == "BMW"); // higher order methods Where also known as lamda expression here


            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }*/

            var myOrderdCar = from car in myCar
                              orderby car.Year descending
                              select car;



            foreach (var car in myOrderdCar)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            // decending order
            var myLinqMethodOrderdCar = myCar.OrderByDescending(car => car.Year);
            //myLinqMethodOrderdCar.(car => car.Year > 1996);

            foreach (var car in myLinqMethodOrderdCar)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            Console.WriteLine(myOrderdCar);
            Console.WriteLine();
            Console.WriteLine(myLinqMethodOrderdCar);

            Console.WriteLine(myCar);
            //myCar.ForEach(car => )

            // looking for first match
            //var firtMatch = myCar.First() // returns the first item not enumerable// VALUE
            // myCar.TrueForAll() // return a value  not enumirable //BOOL

            //myCar.ForEach() // higher order // VOID
            // .Exist() // bool 


            Console.WriteLine("Hello World!");
        }
        class Car
        {
            public string VIN { get; set; }
            public string Make  { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

        }
    }
}
