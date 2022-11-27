using Balta.ConteudoContext;
using Balta.ConteudoContext.Enums;

var curso = new Curso();
curso.Nivel = ENivelConteudo.Iniciante;

var carreira = new Carreira();
carreira.Itens.Add(new ItemCarreira());
Console.WriteLine(carreira.TotalCursos);