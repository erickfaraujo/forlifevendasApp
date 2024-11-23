namespace ForlifeApplication.Web.Requests;

public class PutPedidoRequest
{
    public string IdPedido { get; set; }

    public decimal ValorTotal { get; set; }    

    public string Observacoes { get; set; }

    public string CodProdutos { get; set; }
}