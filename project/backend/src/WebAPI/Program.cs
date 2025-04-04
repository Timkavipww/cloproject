using Scalar.AspNetCore;
using WebAPI.Configuration;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.AddData();
var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.MapGet("/", () => Results.Redirect("/scalar"));
app.Run();