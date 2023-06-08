using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

public class AuthConfig
{
    public static void AuthenticationConfig(WebApplicationBuilder builder)
    {
        builder.Services.AddAuthentication((options) =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer((options) =>
        {
            var key = builder.Configuration.GetConnectionString("key")!;
            options.RequireHttpsMetadata = true;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
    }

    public static void AuthorizationConfig(WebApplicationBuilder builder)
    {

        builder.Services.AddAuthorization((options) =>
        {
            options.AddPolicy("it", (policy) => policy.RequireRole("it"));
            
        });
    }
}