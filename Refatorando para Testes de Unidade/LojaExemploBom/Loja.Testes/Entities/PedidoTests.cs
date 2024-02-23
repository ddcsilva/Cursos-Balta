using Loja.Domain.Entities;
using Loja.Domain.Enums;

namespace Loja.Testes.Entities;

[TestClass]
public class PedidoTests
{
    private readonly Cliente _cliente = new Cliente("Danilo Silva", "danilo@teste.com");
    private readonly Produto _produto = new Produto("Produto 1", 10, true);
    private readonly CupomDesconto _cupomDesconto = new CupomDesconto(10, DateTime.Now.AddDays(1));

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_oito_caracteres()
    {
        var pedido = new Pedido(_cliente, 0, _cupomDesconto);
        Assert.AreEqual(8, pedido.Numero.Length);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_novo_pagamento_seu_status_deve_ser_aguardando_pagamento()
    {
        var pedido = new Pedido(_cliente, 0, _cupomDesconto);
        Assert.AreEqual(StatusPedidoEnum.AguardandoPagamento, pedido.Status);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_pagamento_do_pedido_seu_status_deve_ser_aguardando_entrega()
    {
        var pedido = new Pedido(_cliente, 0, _cupomDesconto);
        pedido.AdicionarItem(_produto, 1); // Total deve ser 10
        pedido.Pagar(10);
        Assert.AreEqual(StatusPedidoEnum.AguardandoEntrega, pedido.Status);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_pedido_cancelado_seu_status_deve_ser_cancelado()
    {
        var pedido = new Pedido(_cliente, 0, _cupomDesconto);
        pedido.Cancelar();
        Assert.AreEqual(StatusPedidoEnum.Cancelado, pedido.Status);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_novo_item_sem_produto_o_mesmo_nao_deve_ser_adicionado()
    {
        var pedido = new Pedido(_cliente, 0, _cupomDesconto);
        pedido.AdicionarItem(null, 10);
        Assert.AreEqual(0, pedido.Itens.Count);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_novo_item_com_quantidade_zero_ou_menor_o_mesmo_nao_deve_ser_adicionado()
    {
        var pedido = new Pedido(_cliente, 0, _cupomDesconto);
        pedido.AdicionarItem(_produto, 0);
        Assert.AreEqual(0, pedido.Itens.Count);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_novo_pedido_valido_seu_total_deve_ser_50()
    {
        var pedido = new Pedido(_cliente, 10, _cupomDesconto);
        pedido.AdicionarItem(_produto, 5);
        Assert.AreEqual(pedido.Total(), 50);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_desconto_expirado_o_valor_do_pedido_deve_ser_60()
    {
        var cupomDesconto = new CupomDesconto(10, DateTime.Now.AddDays(-5));
        var pedido = new Pedido(_cliente, 10, cupomDesconto);
        pedido.AdicionarItem(_produto, 5);
        Assert.AreEqual(pedido.Total(), 60);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_desconto_invalido_o_valor_do_pedido_deve_ser_60()
    {
        var pedido = new Pedido(_cliente, 10, null);
        pedido.AdicionarItem(_produto, 5);
        Assert.AreEqual(pedido.Total(), 60);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_desconto_de_10_o_valor_do_pedido_deve_ser_50()
    {
        var pedido = new Pedido(_cliente, 10, _cupomDesconto);
        pedido.AdicionarItem(_produto, 5);
        Assert.AreEqual(pedido.Total(), 50);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_uma_taxa_de_entrega_de_10_o_valor_do_pedido_deve_ser_60()
    {
        var pedido = new Pedido(_cliente, 10, _cupomDesconto);
        pedido.AdicionarItem(_produto, 6);
        Assert.AreEqual(pedido.Total(), 60);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_pedido_sem_cliente_o_mesmo_deve_ser_invalido()
    {
        var pedido = new Pedido(null, 10, _cupomDesconto);
        Assert.AreEqual(pedido.Valid, false);
    }
}
