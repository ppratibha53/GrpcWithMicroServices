// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;

using ProductOfferGrpcServices.Protos;

var channel = GrpcChannel.ForAddress("http://localhost:5263");
var client = new UserOfferService.UserOfferServiceClient(channel);

var serverReply = client.GetUserOfferList(new EmptyRequestArg { });
Console.WriteLine(serverReply);

Console.ReadLine();