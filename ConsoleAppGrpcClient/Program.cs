using ApiGrpc;
using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace ConsoleAppGrpcClient
{
    class Program
    {
        public static string GrpcUrl = "localhost:5000";

        static void Main(string[] args)
        {
            Thread.Sleep(5000);

            //AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            //var httpHandler = new HttpClientHandler();
            //httpHandler.ServerCertificateCustomValidationCallback =
            //    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            //CallInvoker callInvoker = new Channel(GrpcUrl, ChannelCredentials.Insecure)
            //    .CreateCallInvoker();

            //CallInvoker callInvoker = new Channel(GrpcUrl, 5001, ChannelCredentials.Insecure)
            //    .CreateCallInvoker();

            CallInvoker callInvoker = new Channel("localhost", 5000, ChannelCredentials.Insecure)
                .CreateCallInvoker();

            //var callInvoker = GrpcChannel.ForAddress(GrpcUrl);

            var client = new Greeter.GreeterClient(callInvoker);

            var response = client.SayHello(new HelloRequest { Name = "Teste" });

            Console.WriteLine(response.Message);
            Console.ReadLine();
        }
    }
}
