using Microsoft.AspNetCore.Diagnostics;

namespace Config;

public class AppConfig
{
    public static void Run(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            // app.UseDeveloperExceptionPage();
        }
        app.UseHttpsRedirection();

        app.UseExceptionHandler(options =>
        {
            options.Run(async context =>
            {
                var ex = context.Features.Get<IExceptionHandlerFeature>();
                if (ex != null)
                {
                    await context.Response.WriteAsJsonAsync(new
                    {
                        error = ex.Error,
                    });
                }
                else
                {
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsJsonAsync(new
                    {
                        error = "Internal Server Error",
                    });
                }
            });
        });
    }
}