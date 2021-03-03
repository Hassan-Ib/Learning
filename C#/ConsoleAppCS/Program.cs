using System;

namespace ConsoleAppCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string zig = "you can get what you want out life " +
                " if you help enough other people get what they want.";
            string reversedZig = stringReverse(stringToReverseCharArray(zig));
            Console.WriteLine(reversedZig);
            Book book1 = new Book("Odeal", "pelumi", 24);

            string newMoon = "name mansmd  bsd ";
           
            Console.WriteLine(stringReverse(stringToReverseCharArray(newMoon)));

            Console.WriteLine(book1.author);

            int[] num = { 1, 2, 3, 4, 5, 6, };



            //Console.WriteLine(book1.name); // static properties cannot be accessed by instance of a class;
            //Console.WriteLine(Book.name);// private property of book

            //Console.ReadLine();

        }
        static char[] stringToReverseCharArray(string value) {
            char[] valueToCharArray = value.ToCharArray();
            Array.Reverse(valueToCharArray);
            return valueToCharArray;


        }
        private static string stringReverse(char[] arg)
        {
            //string reversedValue = "";

            /* foreach(char character in arg){
                 reversedValue += character;
             }*/

            //return reversedValue;
            return   String.Concat(arg);;
            }
        public  static void SayHi(string name, int age)
        {
            var answer = "Hi " + name + " "+ age;
            Console.WriteLine(answer);
        }
        static int GetPow(int @base,int power)
        {
            int answer = @base;
            for(int i = 1; i < power; i++)
            {
                answer *= @base; 
            }
            return answer;
        }
        static string CubeNumber(int number)
        {
            int result = number * number * number;
            if(result < 30)
            {
                return "Answer less than 30 " + result;
            }else
            {

                return "" + result;
            }

        }
        static string NumbersToDays(int number)
        {
            string answer;
            switch (number){
                case 0:
                case 1:
                        answer = "sunday";
                    break;
                case 2:
                    answer = "tuesday";
                    break;
                case 3:
                    answer = "wednesday";
                    break;
                case 4:
                    answer = "thursday";
                    break;
                case 5:
                    answer = "wednesday";
                    break;
                case 6:
                    answer = "firday";
                    break;
                case 7:
                    answer = "saturday";
                    break;
                default:
                    answer = "invalid day number";
                    break;
            }

            return answer;
        }
        static int LoopNumber(int index, int range)
        {
            int answer = 0;
            while (index <= range) {
                answer += index;
                index++;
            }
            return answer;
        }
    }
}
