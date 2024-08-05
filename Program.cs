using Microsoft.EntityFrameworkCore;
using ToDo.RestApi.Database;
using ToDo.RestApi.Interfaces;
using ToDo.RestApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 0));
builder.Services.AddDbContext<ApiDbContext>(options =>
{
    options.UseMySql(connectionString, serverVersion);
});

builder.Services.AddScoped<IUserService, UserService>();

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
