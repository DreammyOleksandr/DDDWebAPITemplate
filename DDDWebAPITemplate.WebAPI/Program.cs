using SRMGritLeader.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.ConfigureServices();

var app = builder.Build();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

//Uncomment when DbInitializer is set up.
// if (!await DbInitializer.TrySeedDb(services)) return;

app.ConfigureMiddleware();
app.Run();