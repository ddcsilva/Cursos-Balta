namespace Loja.Models;

public class Pedido
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public DateTime Data { get; set; }
    public int[] Produtos { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Desconto { get; set; }
    public decimal Frete { get; set; }
    public decimal Total { get; set; }
}