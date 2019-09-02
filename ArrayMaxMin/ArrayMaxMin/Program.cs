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
            int max = Int32.MinValue;
            for (int i = 0; i <a.Length; i++)

            {
                if (a[i] > max)
                {
                    max = a[i];

                    Console.WriteLine("Array element" + max);

                }
            }
        }

       public static void Main(string[] args)
        {
            //New array to create....
            int[] arr = { 1, 43, 56, 33, 56, 78 };
            //calling  the method
            FindMax(arr);

            Console.ReadLine();

        }
       
      

    }
}
