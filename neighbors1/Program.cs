using System;
using System.Collections.Generic;

namespace neighbors1
{
    class Program
    {
        static int[] Neighbors(int[] arr, int i)
        {
            // int[], int  -> int[]
            // neighbors are i and i-1 and i+1
            var result = new List<int>();

            if (isIndex(arr.Length, i))
            { // i
                // neighbors are at offsets  -1 and + 1
                foreach (var offset in new int[]{-1,1} )
                {

                    if (isIndex(arr.Length, i + offset))
                    { 
                        result.Add(i + offset);
                    }
                }
            }

            return result.ToArray();
        }

        static bool isIndex(int length, int index)
        {
            return index >= 0 && index < length;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 5, 15 };
            Console.WriteLine(ToString(arr));
            for (int i = 0; i < arr.Length; i++)
            {
                int[] result = Neighbors(arr, i);
                Console.WriteLine("index {0}, neighbors: {1}", i, ToString(result));

            }
            foreach (var i in new int[] { -1, arr.Length })
            {
                int[] result = Neighbors(arr, i);
                Console.WriteLine("index {0}, neighbors: {1}", i, ToString(result));
            }

            arr = new int[] { };
            Console.WriteLine(ToString(arr));
            foreach (var i in new int[] { -1, 0, 4 })
            {
                int[] result = Neighbors(arr, i);
                Console.WriteLine("index {0}, neighbors: {1}", i, ToString(result));
            }

        }
        static String ToString(int[] arr)
        {
            var result = "[ ";
            foreach (var item in arr)
            {
                result += item + " ";
            }
            return result + "]";


        }
    }
}
