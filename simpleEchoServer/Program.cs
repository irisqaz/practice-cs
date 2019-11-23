using System;

namespace simpleEchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = "";
            while (line != "exit")
            {
                line = Console.ReadLine();
                if (line.StartsWith("HTTP"))
                {
                    String body = GetBody(line);
                    String resp = GetResponse(body);
                    Console.WriteLine(body);
                }
            }
        }
        static String GetBody(String str)
        {
            int start = str.IndexOf(':');
            return str.Substring(start+1);
        }
        static String GetResponse(String body){
            return body;
        }
    }
}
