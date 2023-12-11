using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetClientesByLocalResponse([property: JsonPropertyName("clientes")] List<Cliente> clientes);