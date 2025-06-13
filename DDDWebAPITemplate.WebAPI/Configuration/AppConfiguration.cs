using Scalar.AspNetCore;

namespace DDDWebAPITemplate.WebAPI.Configuration;

public static class AppConfiguration
{
    public static void ConfigureMiddleware(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            const string scalarTitle = "DDD WebAPI Template";
            
            app.MapOpenApi();
            app.MapScalarApiReference(options => options
                .WithTitle(scalarTitle)
                .WithTheme(ScalarTheme.DeepSpace)
                .WithDefaultHttpClient(ScalarTarget.Node, ScalarClient.Http));
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}