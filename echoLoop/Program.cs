using System;

namespace echoLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "";
            while (str != "exit")
            {
                //Console.WriteLine(Console.ReadLine());
                str = Console.ReadLine();
                Console.WriteLine(str);
            }
        }
    }
}
