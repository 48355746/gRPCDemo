using Grpc.Net.Client;
using GrpcGreeter;
using System;

namespace GrpcGreeterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel=GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = client.SayHello(new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting:" + reply.Message);
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
