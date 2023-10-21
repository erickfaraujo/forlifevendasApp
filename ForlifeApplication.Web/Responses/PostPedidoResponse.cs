using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record PostPedidoResponse([property: JsonPropertyName("id")] string Id);
