using Grpc.Net.Client;
using GrpcGreeterClient;


using var channel = GrpcChannel.ForAddress("https://localhost:7230");
for (int i = 0; i < 10; i++)
{
   var logClient = new Logger.LoggerClient(channel);
   await logClient.LogInfoAsync(new LogRequest { Message = "Sample log "+ i });
}