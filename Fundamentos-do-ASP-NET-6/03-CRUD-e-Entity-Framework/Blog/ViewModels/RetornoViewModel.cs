namespace Blog.ViewModels;

public class RetornoViewModel<T>
{
    public RetornoViewModel(T dados, List<string> erros)
    {
        Dados = dados;
        Erros = erros;
    }

    public RetornoViewModel(T dados)
    {
        Dados = dados;
    }

    public RetornoViewModel(List<string> erros)
    {
        Erros = erros;
    }

    public RetornoViewModel(string erro)
    {
        Erros.Add(erro);
    }

    public T Dados { get; private set; }
    public List<string> Erros { get; private set; } = [];
}