namespace Loja.Domain.Entities;

/// <summary>
/// Entidade que representa um produto
/// </summary>
public class CupomDesconto : BaseEntity
{
    /// <summary>
    /// Construtor que inicializa as propriedades Quantidade e Validade
    /// </summary>
    public CupomDesconto(decimal quantidade, DateTime validade)
    {
        Quantidade = quantidade;
        Validade = validade;
    }

    // É uma boa prática criar propriedades somente leitura para as entidades
    // Isso evita que as propriedades sejam alteradas após a criação da entidade
    public decimal Quantidade { get; private set; }
    public DateTime Validade { get; private set; }

    /// <summary>
    /// Verifica se o cupom está válido
    /// </summary>
    /// <returns>Retorna true se o cupom estiver válido, caso contrário, retorna false</returns>
    public bool EstaValido()
    {
        // Compara a data atual com a data de validade do cupom
        return DateTime.Compare(DateTime.Now, Validade) < 0;
    }

    /// <summary>
    /// Retorna o valor do cupom
    /// </summary>
    /// <returns>Retorna o valor do cupom se ele estiver válido, caso contrário, retorna 0</returns>
    public decimal Valor()
    {
        if (EstaValido())
            return Quantidade;
        else
            return 0;
    }
}