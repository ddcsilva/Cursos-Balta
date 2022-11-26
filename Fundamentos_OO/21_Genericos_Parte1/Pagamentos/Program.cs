var pessoa = new Pessoa();
var pagamento = new Pagamento();
var assinatura = new Assinatura();

// var context = new DataContext<Pessoa>();
var context = new DataContext<Pessoa, Pagamento, Assinatura>();
context.Salvar(pessoa);

public class DataContext<P, PA, A>
{
    public void Salvar(P entity) { }

    public void Alterar(P entity) { }

    public void Alterar(PA entity) { }

    public void Alterar(A entity) { }
}

public class Pessoa { }

public class Pagamento { }

public class Assinatura { }