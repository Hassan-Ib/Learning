using System;
using System.Timers;

namespace TimerEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();
            Console.WriteLine("PRESS ENTER TO REMOVE THE RED EVENT");
            Console.ReadLine();
            myTimer.Elapsed -= MyTimer_Elapsed1;
            Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Elapsed :: {0:HH:mm:ss.fff}", e.SignalTime);
            //throw new NotImplementedException();
        }
        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed :: {0:HH:mm:ss.fff}", e.SignalTime);
            //throw new NotImplementedException();
        }
    }
}
