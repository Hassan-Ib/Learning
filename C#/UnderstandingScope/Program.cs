using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            //global scope  // regular scoping;
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine(j);
            HelperMethod();
            Console.WriteLine(k);
          
        }
        static void HelperMethod()
        {
            k = "hand";
            Console.WriteLine(k);
        }
    }
}
