using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record PostLocalResponse([property: JsonPropertyName("id")] string Id);
