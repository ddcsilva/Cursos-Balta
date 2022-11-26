IEnumerable<Pagamento> pagamentos = new List<Pagamento>();
// pagamentos.Add(new Pagamento(1));
// pagamentos.Add(new Pagamento(2));
// pagamentos.Add(new Pagamento(3));
// pagamentos.Add(new Pagamento(4));
// pagamentos.Add(new Pagamento(5));

// pagamentos.AsEnumerable();
pagamentos.ToList();
pagamentos.ToArray();

public class Pagamento
{
    public Pagamento(int id)
    {
        this.Id = id;
    }

    public int Id { get; set; }
}