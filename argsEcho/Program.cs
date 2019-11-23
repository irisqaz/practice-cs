using System;

namespace args
{
    // echo the command line arguments
    // to standard output
    class Program
    {
        static void Main(string[] args)
        {
            // must convert to String before writing 
            // to standard output, for some types like arrays
            String str = String.Join(" ", args);
            Console.WriteLine("{0}", str);
        }
    }
}
