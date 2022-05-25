using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServerApi.Data;
using ServerApi.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ServerApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerApiContext") ?? throw new InvalidOperationException("Connection string 'ServerApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Allow All",
        builder =>
        {
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Allow All");

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.UseEndpoints(endpoints =>
    {
        endpoints.MapHub<MyHub>("/MyHub");
    });

app.MapControllers();

app.Run();
