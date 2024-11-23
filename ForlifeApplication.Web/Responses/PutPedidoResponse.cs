using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record PutPedidoResponse([property: JsonPropertyName("pedido")] Pedido Pedido);