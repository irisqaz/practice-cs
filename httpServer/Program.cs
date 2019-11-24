using System;
using System.Net;
using System.IO;
using System.Text;

namespace HttpEchoServer
{
    public class HttpEchoServer
    {
        public static void Main()
        {
            string addressToListenOn = "http://localhost:8080/";
            Console.WriteLine("Starting echo server on " + addressToListenOn + "...");
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(addressToListenOn);
            listener.Start();
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                switch (request.Url.AbsolutePath)
                {
                    case "/hello":
                        HandleHello(request, response);
                        break;
                    case "/bye":
                        HandleBye(request, response);
                        break;
                    default:
                        HandleOther(request, response);
                        break;
                }
                //HttpListenerRequest request = context.Request;
                // string stringToEcho = new StreamReader(request.InputStream).ReadToEnd();
                // Console.WriteLine("Received: " + stringToEcho);
                // stringToEcho = String.Format("<html><body>echo:{0}</body></html>", "Hello World!");
                // HttpListenerResponse response = context.Response;
                // byte[] responseBuffer = Encoding.UTF8.GetBytes(stringToEcho);
                // response.ContentLength64 = responseBuffer.Length;
                // Stream output = response.OutputStream;
                // output.Write(responseBuffer, 0, responseBuffer.Length);
                // output.Close();
                // Console.WriteLine("Sent: " + stringToEcho);
            }
        }
        static void HandleHello(HttpListenerRequest request, HttpListenerResponse response)
        {
            String hello = "Hello World!";
            String.Format("<html><body>{0}</body></html>", hello);
            byte[] responseBuffer = Encoding.UTF8.GetBytes(hello);

            response.ContentType = "text/html";
            response.ContentLength64 = responseBuffer.Length;
            Stream output = response.OutputStream;
            output.Write(responseBuffer, 0, responseBuffer.Length);
            output.Close();
        }

        static void HandleBye(HttpListenerRequest request, HttpListenerResponse response)
        {
            String bye = "Bye and have a nice day!";
            String.Format("<html><body>{0}</body></html>", bye);
            byte[] responseBuffer = Encoding.UTF8.GetBytes(bye);

            response.ContentType = "text/html";
            response.ContentLength64 = responseBuffer.Length;
            Stream output = response.OutputStream;
            output.Write(responseBuffer, 0, responseBuffer.Length);
            output.Close();
        }

        static void HandleOther(HttpListenerRequest request, HttpListenerResponse response)
        {
            String other = "What?  I don't understand!";
            String.Format("<html><body>{0}</body></html>", other);
            byte[] responseBuffer = Encoding.UTF8.GetBytes(other);

            response.ContentType = "text/html";
            response.ContentLength64 = responseBuffer.Length;
            Stream output = response.OutputStream;
            output.Write(responseBuffer, 0, responseBuffer.Length);
            output.Close();
        }
    }
}