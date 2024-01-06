
using Org.WebApp.Main;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region IOC Container for layers
builder.Services.AddMainEFCore(builder.Configuration);
builder.Services.AddMainInfrastructure(builder.Configuration);
builder.Services.AddMainDomain(builder.Configuration);
builder.Services.AddMainShared(builder.Configuration);
builder.Services.AddMainContract(builder.Configuration);
builder.Services.AddMainUseCases(builder.Configuration);
builder.Services.AddMainApi(builder.Configuration);
#endregion

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
