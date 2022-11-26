using System.Linq;

var pagamentos = new List<Pagamento>();
pagamentos.Add(new Pagamento(1));
pagamentos.Add(new Pagamento(2));
pagamentos.Add(new Pagamento(3));
pagamentos.Add(new Pagamento(4));
pagamentos.Add(new Pagamento(5));

foreach (var pagamento in pagamentos)
{
    Console.WriteLine(pagamento.Id);
}

// Where retorna uma Lista
var pagamento1 = pagamentos.Where(x => x.Id == 3);

// First retorna um item
var pagamento2 = pagamentos.First(x => x.Id == 3);
Console.WriteLine(pagamento2.Id);

pagamentos.Remove(pagamento2);

foreach (var pagamento in pagamentos)
{
    Console.WriteLine(pagamento.Id);
}

var existe = pagamentos.Any(x => x.Id == 1);
Console.WriteLine(existe);

// Adicionar uma lista dentro de outra sem precisar de foreach
var pagamentosPagos = new List<Pagamento>();
pagamentosPagos.AddRange(pagamentos);

var lista = new List<string>();

public class Pagamento
{
    public Pagamento(int id)
    {
        this.Id = id;
    }

    public int Id { get; set; }
}