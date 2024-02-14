using ForlifeApplication.Web.Requests;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record PutPagamentoPedidoResponse([property: JsonPropertyName("pedido")] Pedido Pedido);

public class Pedido
{
    [JsonPropertyName("pk")]
    public string Pk { get; init; } = default!;

    [JsonPropertyName("sk")]
    public string Sk => string.Concat("PEDIDO#", IdPedido.ToString());

    [JsonPropertyName("idpedido")]
    public Guid IdPedido { get; init; } = default!;

    [JsonPropertyName("datapedido")]
    public DateTime DataPedido { get; init; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; init; }

    [JsonPropertyName("itens")]
    public IEnumerable<Item> Itens { get; set; } = default!;

    [JsonPropertyName("pagamentos")]
    public List<Pagamento> Pagamentos { get; set; } = default!;

    [JsonPropertyName("totalpagamento")]
    public decimal TotalPagamento { get; set; }

    [JsonPropertyName("observacoes")]
    public string Observacoes { get; set; } = default!;

    [JsonPropertyName("statusPagamento")]
    public string Status { get; set; } = default!;

    [JsonPropertyName("InformacoesAdicionais")]
    public InfosAdicionais InfosAdicionais { get; set; } = default!;

    [JsonPropertyName("CodProdutos")]
    public string CodProdutos { get; set; } = default!;

    [JsonIgnore]
    public string SaldoDevedor { get; set; }
}

public record Pagamento(DateTime Data, decimal Valor);

public record InfosAdicionais(string NomeCliente, string NomeLocal);