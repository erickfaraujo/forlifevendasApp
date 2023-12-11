using ForlifeApplication.Web.Requests;
using ForlifeApplication.Web.Responses;
using Refit;

namespace ForlifeApplication.Web.Services;

public interface IForlifeVendasApi
{
    [Get("/Clientes/{id}")]
    Task<ApiResponse<GetClienteByIdResponse>> GetClienteById(string id);

    [Get("/Clientes")]
    Task<ApiResponse<GetClientesResponse>> GetClientes(string nome, string telefone, string idLocal);

    [Get("/Clientes/clientesPorLoja/{idLocal}")]
    Task<ApiResponse<GetClientesResponse>> GetClientesByLocal(string idLocal);

    [Post("/Clientes")]
    Task<ApiResponse<PostClienteResponse>> PostCliente(PostClienteRequest request);

    [Put("/Clientes")]
    Task<ApiResponse<object>> PutCliente(PutClienteRequest request);

    [Get("/LocalVenda")]
    Task<ApiResponse<GetLocaisVendaResponse>> GetLocaisVenda(string descricao, string endereco);

    [Post("/LocalVenda")]
    Task<ApiResponse<PostLocalResponse>> PostLocal(PostLocalRequest request);

    [Get("/Pedidos")]
    Task<ApiResponse<GetPedidosClienteResponse>> GetPedidos(GetPedidosRequest request);

    [Get("/Pedidos/cliente/{idCliente}")]
    Task<ApiResponse<GetPedidosClienteResponse>> GetPedidosCliente(string idCliente, bool pagos);

    [Post("/Pedidos")]
    Task<ApiResponse<PostPedidoResponse>> PostPedido(PostPedidoRequest request);

    [Put("/Pedidos")]
    Task<ApiResponse<PutPagamentoPedidoResponse>> PutPagamentoPedido(PutPagamentoPedidoRequest request);
}
