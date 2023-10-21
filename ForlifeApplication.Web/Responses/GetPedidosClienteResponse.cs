using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetPedidosClienteResponse([property: JsonPropertyName("pedidos")] List<Pedido> Pedidos);
