namespace Loja.Models;

public class CodigoPromocional
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public decimal Desconto { get; set; }
    public DateTime DataValidade { get; set; }
}