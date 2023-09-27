using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record PostClienteResponse([property: JsonPropertyName("id")] string Id);
