using ForlifeApplication.Web.Responses;
using System.Text.Json;

namespace ForlifeApplication.Web.Services;

public class ForlifeService : IForlifeService
{
    private readonly IForlifeVendasApi _forlifeVendasApi;

    public ForlifeService(IForlifeVendasApi forlifeVendasApi)
    {
        _forlifeVendasApi = forlifeVendasApi;
    }

    public async Task<IEnumerable<GetLocaisVendaBodyResponse>> BuscarLocais(string descricao, string endereco)
    {
        GetLocaisVendaResponse locaisResponse;

        var apiResult = await _forlifeVendasApi.GetLocaisVenda(null, null);
        locaisResponse = apiResult.Content;
        await SecureStorage.Default.SetAsync("locais", JsonSerializer.Serialize(locaisResponse));


        IEnumerable<GetLocaisVendaBodyResponse> result = locaisResponse.LocaisVenda;

        if (!string.IsNullOrEmpty(descricao))
            result = result.Where(x => x.Descricao.ToLower() == descricao.ToLower());
        if (!string.IsNullOrEmpty(endereco))
            result = result.Where(x => x.Endereco.ToLower() == endereco.ToLower());

        return result;
    }
}