namespace ForlifeApplication.Web.Requests;

public class PutPagamentoPedidoRequest
{
    public string IdPedido { get; set; }

    public DateTime Data { get; set; }

    public decimal Valor { get; set; }
}