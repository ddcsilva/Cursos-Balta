var builder = WebApplication.CreateBuilder(args);

// Configurações do Kestrel para ouvir em HTTP e HTTPS
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5273); // Porta HTTP
    options.ListenLocalhost(7232, listenOptions =>
    {
        listenOptions.UseHttps(); // Porta HTTPS
    });
});

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.Run();
