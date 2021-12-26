// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcServiceDemo;

Console.WriteLine("Hello, World!");

var channel = GrpcChannel.ForAddress("https://localhost:7269");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest
{
    Name = ".NET Conf"
});

Console.WriteLine($"From server '{reply.Message}'");
