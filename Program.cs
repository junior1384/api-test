var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => new
{
    status = "OK",
    application = "DeployTestApi",
    version = "1.0.0",
    message = "API de teste do Deploy Lab"
});

app.MapGet("/health", () => new
{
    status = "Healthy V3"
});

app.Run();