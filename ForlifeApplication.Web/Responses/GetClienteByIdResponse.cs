using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetClienteByIdResponse([property: JsonPropertyName("cliente")] Cliente cliente);