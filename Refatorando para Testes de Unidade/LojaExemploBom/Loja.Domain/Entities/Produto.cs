namespace Loja.Domain.Entities;

/// <summary>
/// Entidade que representa um produto
/// </summary>
public class Produto : BaseEntity
{
    /// <summary>
    /// Construtor que inicializa as propriedades Nome, Preco e Ativo
    /// </summary>
    public Produto(string nome, decimal preco, bool ativo)
    {
        Nome = nome;
        Preco = preco;
        Ativo = ativo;
    }

    // É uma boa prática criar propriedades somente leitura para as entidades
    // Isso evita que as propriedades sejam alteradas após a criação da entidade
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public bool Ativo { get; private set; }
}