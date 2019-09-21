using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YueyangSun_Lab5_Ex2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Console.WriteLine("Array intArray contains: ");
            //your version:
            Ex2.DisplayArray(intArray);
            Console.WriteLine("index 2 to 2:");
            //modified version:
            Ex2.DisplayArray(intArray,2,2);
            Console.WriteLine("Array doubleArray contains: ");
            Ex2.DisplayArray(doubleArray);
            Console.WriteLine("index 2 to 3:");
            Ex2.DisplayArray(doubleArray,2,3);
            Console.WriteLine("Array charArray contains: ");
            Ex2.DisplayArray(charArray);
            Console.WriteLine("index 2 to 4:");
            Ex2.DisplayArray(charArray,2,4);
            Console.WriteLine("press a key to test invalid range exception");
            Console.ReadLine();
            Ex2.DisplayArray(charArray, -1, 4);
        }
    }
    //the modified version
    class Ex2 :GenericMethod{
        public static void DisplayArray<T>(T[] inputArray,int low, int high)
        {
            try { 
            if (low>high||low<0||high>inputArray.Length) { throw new ArgumentException("invalid range"); }

            for (int i = low; i < inputArray.Length; i++)
            {
                
                if (i <= high)
                    {
                        Console.Write($"{inputArray[i]} ");
                    }
            }
            }catch (ArgumentException e) {
            Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        Console.WriteLine();
        }
    }
    //the one you give us
    class GenericMethod
    {
                          
        public static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
