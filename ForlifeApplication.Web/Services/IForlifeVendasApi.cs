using ForlifeApplication.Web.Requests;
using ForlifeApplication.Web.Responses;
using Refit;

namespace ForlifeApplication.Web.Services;

public interface IForlifeVendasApi
{
    [Get("/Clientes")]
    Task<ClienteResponse> GetClientes(string nome, string telefone, string idLocal);

    [Post("/Clientes")]
    Task<PostClienteResponse> PostCliente(PostClienteRequest request);

    [Get("/LocalVenda")]
    Task<GetAllLocaisVendaResponse> GetLocaisVenda();

    [Post("/LocalVenda")]
    Task<PostLocalResponse> PostLocal(PostLocalRequest request);
}
