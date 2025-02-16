using Microsoft.EntityFrameworkCore;
using WebAPI_Productos.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionDB"));
});
//builder.Services.AddDbContext<DBContext>(OPCION => {
    //OPCION.UseSqlServer(builder.Configuration.GetConnectionString("ConexionDB"));
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
