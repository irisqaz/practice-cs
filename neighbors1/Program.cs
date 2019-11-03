using System;
using System.Collections.Generic;

namespace neighbors1
{
    class Program
    {
        static int[] Neighbors(int[] arr, int index)
        {
            

            return arr;
        }
        static bool isIndex(int[] arr, int index)
        {
            return index >= 0 && index < arr.Length;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 2, 4 };
            Console.WriteLine( ToString(arr));
            for (int i = 0; i < arr.Length; i++)
            {
                int[] result = Neighbors(arr, 0);
                Console.WriteLine("index {0} neighbors {1}", i, ToString(result));

            }
        }
        static String ToString(int[] arr)
        {
            var result = "[ ";
            foreach (var item in arr)
            {
                result =+ item + " ";
            }
            return result + "]";


        }
    }
}
