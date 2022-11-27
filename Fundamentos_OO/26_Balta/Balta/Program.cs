using Balta.ConteudoContext;

// https://github.com/andrebaltieri/Flunt/
// dotnet add package flunt

var artigos = new List<Artigo>();
artigos.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));
artigos.Add(new Artigo("Artigo sobre C#", "csharp"));
artigos.Add(new Artigo("Artigo sobre .NET", "dotnet"));

// foreach (var artigo in artigos)
// {
//     Console.WriteLine(artigo.Id);
//     Console.WriteLine(artigo.Titulo);
//     Console.WriteLine(artigo.Url);
// }

var cursos = new List<Curso>();
var cursoOOP = new Curso("Fundamentos OOP", "fundamentos-oop");
var cursoCSharp = new Curso("Fundamentos C#", "fundamentos-csharp");
var cursoAspNet = new Curso("Fundamentos ASP.NET", "fundamentos-aspnet");

cursos.Add(cursoOOP);
cursos.Add(cursoCSharp);
cursos.Add(cursoAspNet);

var carreiras = new List<Carreira>();
var carreiraDotNet = new Carreira("Especialista .NET", "especialista-dotnet");
var itemCarreira2 = new ItemCarreira(2, "Aprenda .NET", "", null);
var itemCarreira = new ItemCarreira(1, "Comece por aqui", "", cursoCSharp);
var itemCarreira3 = new ItemCarreira(3, "Aprenda OOP", "", cursoAspNet);
carreiraDotNet.Itens.Add(itemCarreira2);
carreiraDotNet.Itens.Add(itemCarreira);
carreiraDotNet.Itens.Add(itemCarreira3);

carreiras.Add(carreiraDotNet);

foreach (var carreira in carreiras)
{
    Console.WriteLine(carreira.Titulo);

    foreach (var item in carreira.Itens.OrderBy(x => x.Ordem))
    {
        Console.WriteLine($"{item.Ordem} - {item.Titulo}");
        Console.WriteLine(item.Curso?.Titulo);
        Console.WriteLine(item.Curso?.Nivel);

        foreach (var notificacao in item.Notificacoes)
        {
            Console.WriteLine($"{notificacao.Propriedade} - {notificacao.Mensagem}");
        }
    }
}