using DDDWebAPITemplate.Application.Database.Initializer;

namespace DDDWebAPITemplate.Infrastructure.Database.Initializer;

public class DbInitializer : IDbInitializer
{
    public Task TrySeedDbAsync(IServiceProvider serviceProvider)
    {
        //Implement when needed
        return Task.FromResult(true);
    }
}