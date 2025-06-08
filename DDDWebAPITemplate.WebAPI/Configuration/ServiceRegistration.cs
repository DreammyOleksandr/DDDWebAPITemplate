namespace SRMGritLeader.Configuration;

public static class ServiceRegistration
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        const string connectionStringNotFound = "Connection string not found.";
        var connectionString = builder.Configuration.GetConnectionString("Default")
                               ?? throw new InvalidOperationException(connectionStringNotFound);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
    }
}