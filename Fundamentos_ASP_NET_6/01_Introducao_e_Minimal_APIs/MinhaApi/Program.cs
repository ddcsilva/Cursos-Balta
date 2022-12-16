var builder = WebApplication.CreateBuilder(args); // Vamos criar uma aplicação Web
var app = builder.Build(); // Vamos contruir a aplicação Web

app.MapGet("/", () => "Hello World!");

app.Run(); // Vamos colocar pra executar
