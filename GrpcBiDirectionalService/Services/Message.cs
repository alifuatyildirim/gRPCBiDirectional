using Grpc.Core;
using System;
using System.Threading.Tasks;
using static GrpcBiDirectionalService.Message;
namespace GrpcBiDirectionalService.Services
{
    public class MessageService:MessageBase
    {
        public async override Task GetMessage(IAsyncStreamReader<MessageRequest> requestStream, IServerStreamWriter<MessageResponse> responseStream, ServerCallContext context)
        {
            Task response = Task.Run(async () =>
            {
                int count = 0;
                while (++count <= 10)
                {
                    await responseStream.WriteAsync(new MessageResponse { Message = $"{count}. İstek alındı ve işlendi..." });
                    await Task.Delay(1000);
                }
            });

            Task request = Task.Run(async () =>
            {
                while (await requestStream.MoveNext())
                {
                    Console.WriteLine($"Mesaj alınmıştır.");
                    Console.WriteLine("Gelen mesaj : ");
                    Console.WriteLine(requestStream.Current.Message);
                }
            });

            await response;
            await request;
        }
    }
}
