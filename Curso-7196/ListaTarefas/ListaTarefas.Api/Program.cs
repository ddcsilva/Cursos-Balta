using ListaTarefas.Domain.Handlers;
using ListaTarefas.Domain.Repositories;
using ListaTarefas.Infrastructure.Contexts;
using ListaTarefas.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

// builder: Variável que representa a aplicação.
var builder = WebApplication.CreateBuilder(args);

// AddControllers: Adiciona os controllers na aplicação.
builder.Services.AddControllers();


// AddDbContext: Adiciona o contexto da aplicação.
builder.Services.AddDbContext<DataContext>(option => option.UseInMemoryDatabase("Database"));

// builder.Services.AddDbContext<DataContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// AddTransient: Adiciona uma instância temporária do tipo informado.
builder.Services.AddTransient<ITarefaRepository, TarefaRepository>();
builder.Services.AddTransient<TarefaHandler, TarefaHandler>();

// AddEndpointsApiExplorer e AddSwaggerGen: Adiciona o Swagger na aplicação.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// app: Variável que representa a aplicação.
var app = builder.Build();

// Conditional: Verifica se a aplicação está em modo de desenvolvimento.
if (app.Environment.IsDevelopment())
{
    // Se estiver em modo de desenvolvimento, adiciona o Swagger na aplicação.
    app.UseSwagger();
    app.UseSwaggerUI();
}

// UseHttpsRedirection: Redireciona as requisições HTTP para HTTPS.
app.UseHttpsRedirection();

// UseRouting: Habilita o roteamento.
app.UseRouting();

// UseCors: Habilita o CORS.
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

// UseAuthentication e UseAuthorization: Habilita a autenticação e autorização.
app.UseAuthentication();
app.UseAuthorization();

// MapControllers: Mapeia os controllers.
app.MapControllers();

// Run: Executa a aplicação.
app.Run();
