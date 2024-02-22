using Flunt.Validations;

namespace Loja.Domain.Entities;

/// <summary>
/// Entidade que representa um item do pedido
/// </summary>
public class ItemPedido : BaseEntity
{
    /// <summary>
    /// Construtor que inicializa as propriedades Produto e Quantidade
    /// </summary>
    public ItemPedido(Produto produto, int quantidade)
    {
        AddNotifications(
            new Contract()
                .Requires()
                .IsNotNull(produto, "Produto", "Produto é obrigatório")
                .IsGreaterThan(quantidade, 0, "Quantidade", "Quantidade deve ser maior que zero")
        );

        Produto = produto;
        Quantidade = quantidade;
        Preco = Produto != null ? Produto.Preco : 0;
    }

    // É uma boa prática criar propriedades somente leitura para as entidades
    // Isso evita que as propriedades sejam alteradas após a criação da entidade
    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal Preco { get; private set; }

    /// <summary>
    /// Calcula o valor total do item
    /// </summary>
    /// <returns>Retorna o valor total do item</returns>
    public decimal ValorTotal()
    {
        return Preco * Quantidade;
    }
}
