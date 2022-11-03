var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var configuration = (IConfiguration)app.Services.GetService(typeof(IConfiguration))!;

app.MapGet("/", () => $"FAILING TEST. Hello World! Value: {configuration.GetSection("test").Value}");

app.Run();
