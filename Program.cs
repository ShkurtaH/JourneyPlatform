using Microsoft.EntityFrameworkCore;
using JourneyPlatform.Repositories;
using JourneyPlatform.Helpers;
using JourneyPlatform.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"));
});


builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<JwtService>();

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

app.UseCors(options =>
{
    options
    //.WithOrigins(new[] {"http://localhost:3000", "http://localhost:8080"})
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
    //.AllowCredentials();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
