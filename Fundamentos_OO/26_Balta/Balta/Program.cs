using Balta.ConteudoContext;

var artigos = new List<Artigo>();
artigos.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));
artigos.Add(new Artigo("Artigo sobre C#", "csharp"));
artigos.Add(new Artigo("Artigo sobre .NET", "dotnet"));

foreach (var artigo in artigos)
{
    Console.WriteLine(artigo.Id);
    Console.WriteLine(artigo.Titulo);
    Console.WriteLine(artigo.Url);
}