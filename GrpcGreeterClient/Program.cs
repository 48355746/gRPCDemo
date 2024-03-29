﻿using Grpc.Net.Client;
using GrpcEmployee;
using GrpcGreeter;
using Microsoft.Extensions.DependencyInjection;
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
            string id ;
            while ((id = Console.ReadLine()) != "3")
            {
                var empClient = new Employee.EmployeeClient(channel);
                var emp = empClient.GetEmpInfo(new EmpRequest { Id =Convert.ToInt32(id) });

                Console.WriteLine(emp);
            }
         
            Console.ReadKey();
        }
    }
}
