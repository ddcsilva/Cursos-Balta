using Dapper;
using Loja.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Loja.Controllers;

public class PedidoController : Controller
{
    public class PedidosController : Controller
    {
        [Route("v1/pedidos")]
        [HttpPost]
        public async Task<string> CriarPedido(string clienteId, string cep, string codigoPromocional, int[] produtos)
        {
            // #1 - Recupera o cliente
            Cliente cliente = null;
            using (var conexao = new SqlConnection("CONN_STRING"))
            {
                cliente = conexao.Query<Cliente>("SELECT * FROM CLIENTE WHERE ID = " + clienteId).FirstOrDefault();
            }

            // #2 - Calcula o frete
            decimal frete = 0;
            var request = new HttpRequestMessage(HttpMethod.Get, "URL/" + cep);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            using (HttpClient client = new HttpClient())
            {
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    frete = await response.Content.ReadFromJsonAsync<decimal>();
                }
                else
                {
                    // Caso não consiga obter a taxa de entrega o valor padrão é 5
                    frete = 5;
                }
            }

            // #3 - Calcula o total dos produtos
            decimal subTotal = 0;
            for (int p = 0; p < produtos.Length; p++)
            {
                var produto = new Produto();

                using (var conn = new SqlConnection("CONN_STRING"))
                {
                    produto = conn.Query<Produto>("SELECT * FROM PRODUTO WHERE ID=" + produtos[p]).FirstOrDefault();
                }

                subTotal += produto.Preco;
            }

            // #4 - Aplica o cupom de desconto
            decimal desconto = 0;

            using (var conexao = new SqlConnection("CONN_STRING"))
            {

                var codigo = conexao.Query<CodigoPromocional>("SELECT * FROM CODIGO_PROMOCIONAL WHERE CODIGO=" + codigoPromocional).FirstOrDefault();
                
                if (codigo.DataValidade > DateTime.Now)
                {
                    desconto = codigo.Desconto;
                }
            }

            // #5 - Gera o pedido
            var pedido = new Pedido();
            pedido.Codigo = Guid.NewGuid().ToString().ToUpper().Substring(0, 8);
            pedido.Data = DateTime.Now;
            pedido.Frete = frete;
            pedido.Desconto = desconto;
            pedido.Produtos = produtos;
            pedido.Subtotal = subTotal;

            // #6 - Calcula o total
            pedido.Total = subTotal - desconto + frete;

            // #7 - Retorna
            return $"Pedido {pedido.Codigo} gerado com sucesso!";
        }
    }
}