using System;
using System.Collections.Generic;

namespace neighbors2
{
    class Program
    {
        static List<Tuple<int, int>> Neighbors(int[][] arr, int i, int j)
        {
            // int[], int  -> int[]
            // neighbors are i and i-1 and i+1
            var result = new List<Tuple<int, int>>();
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
                Tuple<int, int> pair;
                // i is constant
                foreach (var jOffSet in offsets)
                {

                    if (isIndex(cLength, j + jOffSet))
                    {
                        pair = Tuple.Create(i, j + jOffSet);
                        result.Add(pair);
                    }
                }
                // j is constant
                foreach (var iOffSet in offsets)
                {

                    if (isIndex(rLength, i + iOffSet))
                    {
                        pair = Tuple.Create(i + iOffSet, j);
                        result.Add(pair);
                    }
                }
            }

            return result;
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
                    List<Tuple<int, int>> result = Neighbors(arr, i, j);
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
        static String ToString2(List<Tuple<int, int>> pairs)
        {
            var result = "[ ";
            foreach (var pair in pairs)
            {
                result += pair + " ";
                //Console.WriteLine(item);
            }
            return result + "]";


        }

    }

}
