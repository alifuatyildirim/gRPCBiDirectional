using System;
using Grpc.Net.Client; 
using GrpcBiDirectionalClient; 
using System.Threading;
using System.Threading.Tasks;
namespace gRPCBiDirectionalClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var messageClient= new Message.MessageClient(channel);
            Console.WriteLine("Lütfen gönderilecek mesajı giriniz.");
            var getMessage = messageClient.GetMessage();

            Task request = Task.Run(async () =>
            {
                int count = 0;
                while (++count <= 10)
                {
                    await getMessage.RequestStream.WriteAsync(new MessageRequest { Message = $"Gönderilen mesaj {count}" });
                    await Task.Delay(1000);
                }
            });

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            Task response = Task.Run(async () =>
            {
                while (await getMessage.ResponseStream.MoveNext(cancellationTokenSource.Token))
                    Console.WriteLine(getMessage.ResponseStream.Current.Message);
            });
            await request;
            //RequestStream başarıyla sonlandırılıyor. Özellikle request'ten sonra olmasına özen gösteriyoruz.
            await getMessage.RequestStream.CompleteAsync();
            await response;
        }
    }
}
