using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxMin
{
   
    class Program
    {
//        Create a method: FindMax
//It will have one parameter: an integer array
//It will return the largest number in the array
//You will call this method from your Main method.
//Create several integer arrays to test your code:
//for instance; 
//int[] array1 = {1, 4, 6, 1, 3, 9, 0 , -1, -6, 11};
     //   int[] array2 = { -9, -7 -, -11, -7, -88, -5, -10 };
      static void FindMax(int[] a)
        {
            // display array elements
          
            for (int i = 0; i <a.Length; i++)

            {
                    Console.WriteLine("Array element" +a[i]);

                
            }
        }
        static void ConvertTemp(string convert, float tempetarute)
        {

        }

       public static void Main(string[] args)
        {
            //New array to create....
            int[] arr = { 1, 43, 56, 33, 56, 78 };
          int[] array2 = {-9, -7, -11, -7, -88, -5, -10};
            int maxValue = arr.Max();
            int maxValue1 = arr.Max();
            //calling  the method
            FindMax(arr);
            Console.WriteLine("this is array 2:................");
            FindMax(array2);
            Console.WriteLine("the max value of array one is:  "+ maxValue + "the max value of array two is:  " + maxValue1 );
            

            Console.ReadLine();

        }
       
      

    }
}
