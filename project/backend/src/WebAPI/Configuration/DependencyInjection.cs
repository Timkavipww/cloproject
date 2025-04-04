using Domain.Interfaces.Repositories;
using Infrasturcture.Persistence;
using Infrasturcture.Repostiories;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Configuration;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddData(this WebApplicationBuilder services)
    {
        services.Services.AddDbContext<ClothingDbContext>(options =>
            options.UseNpgsql(
                Environment.GetEnvironmentVariable("DB_CLOTHING"),
                npgsqlOptions => npgsqlOptions
                    .EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)));

        services.Services.AddScoped<IClothingRepository, ClothingRepository>();

        return services;
    }
}
