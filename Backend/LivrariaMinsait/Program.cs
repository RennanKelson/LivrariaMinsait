using LivrariaMinsait.Context;
using LivrariaMinsait.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<LivroContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=livraria-minsait-db;User Id=postgres;Password=1234;"));

AppContext.SetSwitch("Npjsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddControllers();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("http://localhost:4200"));

app.UseAuthorization();

app.MapControllers();

app.Run();
