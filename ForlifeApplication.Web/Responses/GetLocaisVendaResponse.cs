using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetLocaisVendaResponse(
    [property: JsonPropertyName("locaisVenda")] List<GetLocaisVendaBodyResponse> LocaisVenda);

public record GetLocaisVendaBodyResponse(
    [property: JsonPropertyName("idlocal")] Guid IdLocal,
    [property: JsonPropertyName("descricao")] string Descricao,
    [property: JsonPropertyName("endereco")] string Endereco,
    [property: JsonPropertyName("referencia")] string Referencia);
