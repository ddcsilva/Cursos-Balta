var builder = WebApplication.CreateBuilder(args); // Vamos criar uma aplicação Web
var app = builder.Build(); // Vamos contruir a aplicação Web

app.MapGet("/", () =>
{
    return Results.Ok("Hello World!");
});

app.MapGet("/name/{nome}", (string nome) =>
{
    return Results.Ok($"Hello {nome}");
});

app.MapGet("/banana", () => "Banana é muito bom!");

app.Run(); // Vamos colocar pra executar
