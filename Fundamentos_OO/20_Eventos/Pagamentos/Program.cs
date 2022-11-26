var sala = new Sala(3);
sala.SalaCheiaEvent += AoSalaFicarCheia;

sala.ReservarAssento();
sala.ReservarAssento();
sala.ReservarAssento();
sala.ReservarAssento();
sala.ReservarAssento();

static void AoSalaFicarCheia(object sender, EventArgs e)
{
    System.Console.WriteLine("Sala está cheia!");
}

public class Sala
{
    public Sala(int assentos)
    {
        this.Assentos = assentos;
        assentosEmUso = 0;
    }

    private int assentosEmUso = 0;
    public int Assentos { get; set; }

    public void ReservarAssento()
    {
        assentosEmUso++;

        if (assentosEmUso >= Assentos)
        {
            AoSalaFicarCheia(EventArgs.Empty);
        }
        else
        {
            System.Console.WriteLine("Assento Reservado!");
        }
    }

    public event EventHandler SalaCheiaEvent;

    protected virtual void AoSalaFicarCheia(EventArgs e)
    {
        EventHandler handler = SalaCheiaEvent;
        handler?.Invoke(this, e);
    }
}