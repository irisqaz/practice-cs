using System;
using System.Collections.Generic;

namespace neighbors2
{
    class Program
    {
        static List<int>[] Neighbors(int[][] arr, int i, int j)
        {
            // int[], int  -> int[]
            // neighbors are i and i-1 and i+1
            var result = new List<List<int>>();
            int rLength = arr.Length;
            int cLength = 0;
            if (arr.Length > 0)
            {
                cLength = arr[0].Length;
            }
            if (isIndex(rLength, i) && isIndex(cLength, j))
            { // i
                // neighbors are at offsets  -1 and + 1
                var offsets = new int[] { -1, 1 };
                List<int> pair;
                // j is constant
                foreach (var iOffSet in offsets)
                {

                    if (isIndex(rLength, i + iOffSet))
                    {
                        pair = new List<int>();
                        pair.Add(i + iOffSet);
                        pair.Add(j);
                        result.Add(pair);
                    }
                }
                // i is constant
                foreach (var jOffSet in offsets)
                {

                    if (isIndex(cLength, j + jOffSet))
                    {
                        pair = new List<int>();
                        pair.Add(i);
                        pair.Add(j + jOffSet);
                        result.Add(pair);
                    }
                }
            }
            //Console.WriteLine(string.Join(",", result));
            return result.ToArray();
        }

        static bool isIndex(int length, int index)
        {
            return index >= 0 && index < length;
        }
        static void Main(string[] args)
        {
            int[][] arr = { new int[]{ 10, 22, 5, 15 },
                            new int[]{ 33, 11, 9, 44}, 
                            new int[]{ 22, 55, 3, 11} 
                          };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(ToString(arr[i]));
            }
            
            var rows = arr.Length;
            var columns = arr[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    List<int>[] result = Neighbors(arr, i, j);
                    Console.WriteLine("index {0},{1} neighbors: {2}", i, j, ToString2(result));
                }

            }
            /*
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
            */

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
        static String ToString2(List<int>[] arr)
        {
            var result = "[ ";
            foreach (var item in arr)
            {
                result += "(" + string.Join(",", item) + ") ";
                //Console.WriteLine(item);
            }
            return result + "]";


        }

    }

}
