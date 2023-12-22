using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using week4.Entitites;
using week4.Interfaces;
using week4.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SanalHayvanDbContext>();
builder.Services.AddTransient<IEvcilHayvanService, EvcilHayvanService>();
builder.Services.AddTransient<IKullaniciService, KullaniciService>();

//builder.Services.AddDbContext<SanalHayvanDbContext>(options=> options.UseSqlServer(@"Server=KENOBI;Database=master;Trusted_Connection=True;TrustServerCertificate=True"));
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