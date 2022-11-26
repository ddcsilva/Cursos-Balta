var pessoa = new Pessoa();
var pagamento = new Pagamento();
var assinatura = new Assinatura();

var context = new DataContext<Pessoa, Pagamento, Assinatura>();
context.Salvar(pessoa);
context.Salvar(pagamento);
context.Salvar(assinatura);

public class DataContext<P, PA, A>
    where P : IPessoa
    where PA : Pagamento
    where A : Assinatura
{
    public void Salvar(P entity) { }

    public void Salvar(PA entity) { }

    public void Salvar(A entity) { }
}

public interface IPessoa { }

public class Pessoa : IPessoa { }

public class Pagamento { }

public class Assinatura { }