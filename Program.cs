using System;
using System.Net;

namespace SimpleWebServer 
{
    class Program
    {
    static void Main(string[] args)
    {
        var port = Environment.GetEnvironmentVariable("HOST_PORT");
        WebServer ws = new WebServer(SendResponse, "http://+:" + port + "/");
        ws.Run();
        Console.WriteLine("A simple webserver. Press a key to quit.");
        Console.ReadKey();
        ws.Stop();
    }
 
    public static string SendResponse(HttpListenerRequest request)
    {
        return string.Format("<HTML><BODY>My web page.<br> Using, mono, docker, docker orchastration, Drone-CI {0}</BODY></HTML>", DateTime.Now);    
    }
    }
}
