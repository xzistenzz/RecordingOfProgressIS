using Microsoft.EntityFrameworkCore;
using RecordingOfProgressIS.Application;
using RecordingOfProgressIS.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();
builder.Services.AddApplicationService();
builder.Services.AddDbContext<RopisDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString(nameof(RopisDbContext))));


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
