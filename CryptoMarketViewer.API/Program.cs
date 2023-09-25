using CryptoMarketViewer.Application.Interfaces;
using CryptoMarketViewer.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Add services
builder.Services.AddHttpClient<ICryptoApiService, CryptoApiService>(client =>
{ 
    client.BaseAddress = new Uri("https://api.blockchain.com/v3/");
});

//builder.Services.AddScoped<CryptoMarketViewer.Application.Interfaces.ICryptoApiService, CryptoApiService>();
builder.Services.AddScoped<CryptoMarketViewer.Application.UseCases.GetUSDLastTradePricesUseCase>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Crypto Market Viewer API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
