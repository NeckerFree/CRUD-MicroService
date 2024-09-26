using CommonLibrary.Consumer;
using CommonLibrary.RabbitMQ;
using Inventory.AuthManagement;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using static CommonLibrary.RabbitMQ.StartupExtension;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCommonService(builder.Configuration);
builder.Services.AddSingleton<IConsumerService, ConsumerService>();
builder.Services.AddHostedService<ConsumerHostedService>();
builder.Services.AddDbContext<AuthContext>(options =>
{
    string connectionString = Environment.GetEnvironmentVariable("AuthDockerConnection") ??
                              builder.Configuration.GetConnectionString("AuthLocalConnection") ??
                              throw new InvalidOperationException("Connection string not found.");
    options.UseSqlServer(builder.Configuration["AuthConnection"],
    sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.MigrationsAssembly(
            typeof(Program).GetTypeInfo().Assembly.GetName().Name);

        //Configuring Connection Resiliency:
        sqlOptions.
            EnableRetryOnFailure(maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null);
    });
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => 
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
var app = builder.Build();

app.UseCors("AllowAllOrigins");
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
