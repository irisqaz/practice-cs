using System;
using System.Collections.Generic;

namespace neighbors1
{
    class Program
    {
        static int[] Neighbors(int[] arr, int i)
        {
            var result = new List<int>();
            // i - 1, i + 1
            // arr[i-1], arr[i+1]
            //if (i < 0 || i > arr.Length - 1)
            if (!isIndex(arr, i))
            {
                return result.ToArray();
            }
            //if (i - 1 >= 0 && i - 1 < arr.Length)
            if (isIndex(arr, i - 1))
            {
                result.Add(i - 1);
            }
            // if (i + 1 >= 0 && i + 1 < arr.Length)
            if (isIndex(arr, i + 1))
            {
                result.Add(i + 1);
            }

            return result.ToArray();
        }
        static bool isIndex(int[] arr, int index)
        {
            return index >= 0 && index < arr.Length;
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
            foreach (var i in new int[] { -1, 0, 4})
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
