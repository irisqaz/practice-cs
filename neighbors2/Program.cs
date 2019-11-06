using System;
using System.Collections.Generic;

namespace neighbors2
{
    class Program
    {
        static List<Tuple<int, int>> Neighbors(int[][] arr, int i, int j)
        {
            // list of neighbors
            List<Tuple<int,int>> result = new List<Tuple<int,int>>();

            int rows = arr.Length;
            int columns = 0;
            if (rows > 0){
                columns = arr[0].Length;
            }

            if (isIndex(rows, i) && isIndex(columns, j))
            { 
                int[] offsets = {1,-1};
                Tuple<int,int> neighbor;

                foreach (var jOffSet in offsets)
                {

                    if (isIndex(columns, j + jOffSet))
                    {
                        neighbor = Tuple.Create(i, j + jOffSet);
                        result.Add(neighbor);
                    }
                }
                
                foreach (var iOffSet in offsets)
                {

                    if (isIndex(rows, i + iOffSet))
                    {
                        neighbor = Tuple.Create(i + iOffSet, j);
                        result.Add(neighbor);
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
                            new int[]{ 22, 55, 3, 11},
                            new int[]{ 55, 99, 1, 22}
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
