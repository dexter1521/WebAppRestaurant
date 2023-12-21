using DataBase.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("basededatos");
builder.Services.AddDbContext<_DBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<IDbConnection>(db=>new SqlConnection(connectionString));


// Add services to the container.

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

//Scaffold-DbContext 'Server=DESKTOP-OOGIDH8\\SQLEXPRESS;Database=C:\\MyBusinessDatabase\\JIUTEPEC.mdf;User Id=sa;Password=lxc8040;' Microsoft.EntityFrameworkCore.SqlServer -Project DataBase -OutputDir Tables -f

//Scaffold-DbContext 'Server=DESKTOP-OOGIDH8\SQLEXPRESS;Database=C:\MyBusinessDatabase\JIUTEPEC.mdf;User Id=sa;Password=lxc8040;Trusted_Connection=true;Encrypt=False;' Microsoft.EntityFrameworkCore.SqlServer -Project DataBase -OutputDir Tables -f -v

//Scaffold-DbContext 'Server=DESKTOP-OOGIDH8\SQLEXPRESS;Database=C:\MyBusinessDatabase\JIUTEPEC.mdf;User Id=sa;Password=lxc8040;Trusted_Connection=true;Encrypt=False;' Microsoft.EntityFrameworkCore.SqlServer -Project DataBase -OutputDir Tables -f -d
