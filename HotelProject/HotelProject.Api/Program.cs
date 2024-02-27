using HotelProject.Infra.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conexao = builder.Configuration.GetConnectionString("conexao");

builder.Services.AddDbContext<Context>(opt =>
{
    opt.UseSqlServer(conexao, x => x.MigrationsAssembly("HotelProject.Data"));
    opt.EnableDetailedErrors();
    opt.EnableSensitiveDataLogging();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
