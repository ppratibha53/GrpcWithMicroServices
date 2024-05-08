using ProductOfferGrpcServices.Data;
using ProductOfferGrpcServices.Repositories;
using ProductOfferGrpcServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddGrpc();
builder.Services.AddScoped<IProductOfferService, ProductOfferService>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services
  .AddAutoMapper(typeof(Program).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<OfferService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
