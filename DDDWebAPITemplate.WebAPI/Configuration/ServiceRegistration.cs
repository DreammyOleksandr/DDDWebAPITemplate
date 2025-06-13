using DDDWebAPITemplate.Application.Database.Initializer;
using DDDWebAPITemplate.Infrastructure.Database.Context;
using DDDWebAPITemplate.Infrastructure.Database.Initializer;

namespace DDDWebAPITemplate.WebAPI.Configuration;

public static class ServiceRegistration
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        const string connectionStringNotFound = "Connection string not found.";
        var connectionString = builder.Configuration.GetConnectionString("Default")
                               ?? throw new InvalidOperationException(connectionStringNotFound);
        
        //Uncomment when database connection must be established
        // builder.Services.AddDbContext<ApplicationDbContext>(options =>
        //     options.UseSQL_PROVIDER(connectionString));

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddScoped<IDbInitializer, DbInitializer>();
    }
}