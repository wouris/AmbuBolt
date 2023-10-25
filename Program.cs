using System.Diagnostics;
using Microsoft.Azure.Cosmos;
using AmbuBolt.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<PatientService>(provider =>
{
    var cosmosClient = new CosmosClient(builder.Configuration.GetConnectionString("CosmosDB"));
    return new PatientService(cosmosClient, "AmbuBolt", "Patients");
});

builder.Services.AddSingleton<GoogleMapsService>(provider =>
{
    var apiKey = builder.Configuration.GetValue("GoogleAPI", "");
    
    if(apiKey == "")
    {
        throw new Exception("GoogleAPI not found in configuration");
    }
    
    var httpClient = new HttpClient();
    Debug.Print("Registering GoogleMapsService");
    return new GoogleMapsService(httpClient, apiKey);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
