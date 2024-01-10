using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetDetalhesPedidoResponse([property: JsonPropertyName("pedido")] Pedido Pedido);
