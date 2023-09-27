using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetAllLocaisVendaResponse(
    [property: JsonPropertyName("locaisVenda")] List<GetLocaisVendaResponse> LocaisVenda);

public record GetLocaisVendaResponse(
    [property: JsonPropertyName("idlocal")] Guid IdLocal,
    [property: JsonPropertyName("descricao")] string Descricao,
    [property: JsonPropertyName("endereco")] string Endereco,
    [property: JsonPropertyName("referencia")] string Referencia);
