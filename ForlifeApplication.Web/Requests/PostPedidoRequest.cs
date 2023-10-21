namespace ForlifeApplication.Web.Requests;

public class PostPedidoRequest
{
    public IEnumerable<Item> Itens { get; set; }

    public decimal ValorTotal { get; set; }

    public decimal ValorPago { get; set; }
    
    public string IdCliente { get; set; }

    public string Observacoes { get; set; }
}


public class Item
{
    public int CodigoProduto { get; set; }

    public int Quantidade { get; set; }

}