using Kutubxona.DataLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SetDbContext>(
    option => option.UseNpgsql(builder.Configuration.GetConnectionString("Dadahon")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*app.UseDefaultFiles();

app.UseStaticFiles();
*/
app.UseFileServer(); 


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
