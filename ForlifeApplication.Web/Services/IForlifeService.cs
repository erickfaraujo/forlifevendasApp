using ForlifeApplication.Web.Responses;

namespace ForlifeApplication.Web.Services;

public interface IForlifeService
{
    Task<IEnumerable<GetLocaisVendaBodyResponse>> BuscarLocais(string descricao, string endereco);
}
