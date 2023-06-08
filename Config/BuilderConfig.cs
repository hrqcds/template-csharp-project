using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Database;
using Repositories;
using Interfaces;

namespace Config;

public class BuilderConfig
{
    public static WebApplication Build(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();

        builder.Services
            .AddSwaggerGen((options) =>
            {
                SwaggerConfig.SwaggerConfigAuthentication(options);
            });

        builder.Services.Configure<JsonOptions>((options) =>
        {
            options.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        });

        builder.Services.AddDbContext<DataContext>((options) =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("db"));
        });

        builder.Services.AddScoped<IUserRepository, UserEntityRepository>();

        AuthConfig.AuthenticationConfig(builder);
        AuthConfig.AuthorizationConfig(builder);

        return builder.Build();
    }
}