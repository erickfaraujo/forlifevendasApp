using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetDetalhesLocaVendaResponse(
    [property: JsonPropertyName("localVenda")] GetLocaisVendaBodyResponse LocalVenda);
