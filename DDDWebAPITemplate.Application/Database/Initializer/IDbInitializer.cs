namespace DDDWebAPITemplate.Application.Database.Initializer;

public interface IDbInitializer
{
    Task TrySeedDbAsync(IServiceProvider serviceProvider);
}