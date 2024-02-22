using Flunt.Validations;
using Loja.Domain.Enums;

namespace Loja.Domain.Entities;

/// <summary>
/// Entidade que representa um pedido
/// </summary>
public class Pedido : BaseEntity
{
    /// <summary>
    /// Construtor que inicializa as propriedades Cliente, Data, Numero, Status, Frete, CupomDesconto e Itens
    /// </summary>
    public Pedido(Cliente cliente, decimal frete, CupomDesconto cupomDesconto)
    {
        AddNotifications(
            new Contract()
                .Requires()
                .IsNotNull(cliente, "Cliente", "Cliente é obrigatório")
                .IsGreaterThan(frete, 0, "Frete", "Frete deve ser maior que zero")
        );

        Cliente = cliente;
        Data = DateTime.Now;
        Numero = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        Status = StatusPedidoEnum.AguardandoPagamento;
        Frete = frete;
        CupomDesconto = cupomDesconto;
        Itens = new List<ItemPedido>();
    }

    // É uma boa prática criar propriedades somente leitura para as entidades
    // Isso evita que as propriedades sejam alteradas após a criação da entidade
    public Cliente Cliente { get; private set; }
    public DateTime Data { get; private set; }
    public string Numero { get; private set; }
    public IList<ItemPedido> Itens { get; private set; }
    public decimal Frete { get; private set; }
    public CupomDesconto CupomDesconto { get; private set; }
    public StatusPedidoEnum Status { get; private set; }

    /// <summary>
    /// Adiciona um item ao pedido
    /// </summary>
    public void AdicionarItem(Produto produto, int quantidade)
    {
        var item = new ItemPedido(produto, quantidade);
        if (item.Valid)
            Itens.Add(item);
    }

    /// <summary>
    /// Calcula o valor total do pedido
    /// </summary>
    /// <returns></returns>
    public decimal Total()
    {
        decimal total = 0;

        foreach (var item in Itens)
        {
            total += item.ValorTotal();
        }

        total += Frete;
        total -= CupomDesconto != null ? CupomDesconto.Valor() : 0;

        return total;
    }

    /// <summary>
    /// Paga o pedido
    /// </summary>
    /// <param name="valor"></param>
    public void Pagar(decimal valor)
    {
        if (valor >= Total())
            Status = StatusPedidoEnum.AguardandoEntrega;
    }

    /// <summary>
    /// Cancela o pedido
    /// </summary>
    public void Cancelar()
    {
        Status = StatusPedidoEnum.Cancelado;
    }
}
