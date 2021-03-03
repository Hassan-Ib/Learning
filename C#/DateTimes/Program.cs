using System;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue =  DateTime.Now; // static method
                                              //Console.WriteLine(myValue);
                                              //Console.WriteLine(myValue.ToString());
                                              //Console.WriteLine(myValue.ToShortDateString());
                                              //Console.WriteLine(myValue.ToShortTimeString());
                                              //Console.WriteLine(myValue.ToLongDateString());
                                              //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //
            // Console.WriteLine(myValue.AddHours(3).ToShortDateString());// future hour
            //Console.WriteLine(myValue.AddHours(-3).ToShortDateString());//subtracting hours

            //Console.WriteLine(myValue.Month); // get curren time

            //DateTime myBirthday = new DateTime(1997, 05, 22);
            //Console.WriteLine(myBirthday.ToShortDateString());

           // DateTime myBirthday = DateTime.Parse("1997, 05, 22"); // another method to create a day from the past
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            //Console.WriteLine(myAge.ToString());







            Console.WriteLine("Hello World!");
        }
    }
}
