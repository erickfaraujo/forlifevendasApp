namespace ForlifeApplication.Web.Requests;

public record GetPedidosRequest(string? DataInicio, string? DataFim, string? StatusPagamento, string? IdLocal);
