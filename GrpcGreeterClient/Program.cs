using Grpc.Net.Client;
using GrpcEmployee;
using GrpcGreeter;
using System;

namespace GrpcGreeterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = client.SayHello(new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting:" + reply.Message);
            string id = "0";
            while (id != "3")
            {

                id = Console.ReadLine();
                var empClient = new Employee.EmployeeClient(channel);
                var emp = empClient.getInfo(new EmpRequest { Id = id });

                Console.WriteLine(emp);
            }


            Console.ReadKey();
        }
    }
}
