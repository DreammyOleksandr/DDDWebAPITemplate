using DDDWebAPITemplate.WebAPI.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.ConfigureServices();

var app = builder.Build();

//Uncomment when DbInitializer is implemented + change the logic based on a return type
// using var scope = app.Services.CreateScope();
// var services = scope.ServiceProvider;
// var dbInitializer = services.GetRequiredService<IDbInitializer>();
// await dbInitializer.TrySeedDbAsync(services);

app.ConfigureMiddleware();
app.Run();