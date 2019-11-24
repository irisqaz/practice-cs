using System;

namespace htmlServer
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
                    String reqBody = GetBody(line);
                    String respBody = GetResponse(reqBody);
                    String resp = String.Format("HTTP OK body:{0}", respBody);
                    Console.WriteLine(resp);
                }
            }
        }
        static String GetBody(String str)
        {
            int start = str.IndexOf(':');
            return str.Substring(start+1);
        }
        static String GetResponse(String body){
            String resp = String.Format("<html><body>{0}</body></html>", body);
            return resp;
        }
    }
}
