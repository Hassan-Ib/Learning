using System;
using System.Collections;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{5,4,3,5,0,6,1};
            // var sortedArr = InsertionSort(arr);

            // foreach(var ele in sortedArr){
            //     Console.WriteLine(ele);
            // }
            Manup main = new Manup();
            

            var sortedArr = main.SortWithForLoopReverse(arr);
            // Console.WriteLine("MUTATED");

            // foreach(var ele in sortedArr){
            //     Console.WriteLine(ele);
            // }
            System.Console.WriteLine("---------------------------------SORTED OUTPUT ---------------------------------------------");
            main.TakeOwnParam(sortedArr);

            // Console.WriteLine("real arr");
            // foreach(var ele in arr){
            //     Console.WriteLine( ele);
            // }

            System.Console.WriteLine("----------assessment---------------");
           System.Console.WriteLine(main.checkIntegerOfV(arr, 1));
            System.Console.WriteLine(main.checkIntegerOfV(arr, 9));

            
        }

        static int[] InsertionSort(int[] arry){
            for(int index = 1; index < arry.Length; index++){
                int key  = arry[index];
                int  previousKeyIndex= index - 1;
                while(previousKeyIndex > -1 && arry[previousKeyIndex] > key){
                    arry[previousKeyIndex + 1] = arry[previousKeyIndex];
                    previousKeyIndex -=1;
                }
                arry[previousKeyIndex + 1]  = key;
            }
            return arry;
        }
        

        
    }
    class Manup{
        public void TakeOwnParam(int[] arr){
            foreach(var ele in arr){
                Console.WriteLine(ele);
            }
        }
        public int[] SortWithForLoop(int[] arry){
            // array is 0 based index
            for(int start = 1; start < arry.Length; start++ ){
                int valueToInsert = arry[start];
                int currentIndex = start - 1;

                for(int previous = start - 1  ; previous >= 0 ; previous-- ){
                    if(arry[currentIndex] > valueToInsert){
                        arry[previous + 1] = arry[previous]; 
                    }
                    else{
                        System.Console.WriteLine(previous + " " + arry[previous]);
                        break;
                    }
                    currentIndex = previous - 1;
                }  
                arry[currentIndex + 1] = valueToInsert;
                
            }
            return arry;
        }
         public int[] SortWithForLoopReverse(int[] arry){
            // array is 0 based index
            for(int start = 1; start < arry.Length; start++ ){
                int valueToInsert = arry[start];
                int currentIndex = start - 1;

                for(int previous = start - 1  ; previous >= 0 ; previous-- ){
                    if(arry[currentIndex] < valueToInsert){
                        arry[previous + 1] = arry[previous]; 
                    }
                    else{
                        System.Console.WriteLine(previous + " " + arry[previous]);
                        break;
                    }
                    currentIndex = previous - 1;
                }  
                arry[currentIndex + 1] = valueToInsert;
                
            }
            return arry;
        }
        public int checkIntegerOfV(int[] arr, int V){
            int i = 0;
            for(int ele = 0 ; ele < arr.Length; ele++){
                if(arr[ele] == V){
                    i = ele;
                    break;
                }else{
                    continue;
                }
            }

            return i;
        }
    }

    
}
