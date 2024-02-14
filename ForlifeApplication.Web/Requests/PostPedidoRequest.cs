using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class PostPedidoRequest
{
    public IEnumerable<Item> Itens { get; set; }

    [Required(ErrorMessage = "Informar o valor da venda")]
    public decimal ValorTotal { get; set; }

    public decimal ValorPago { get; set; } = 0;

    [Required(ErrorMessage = "Cliente não informado")]
    public string IdCliente { get; set; }

    public string Observacoes { get; set; }

    [Required(ErrorMessage = "Inserir códigos de produtos e quantidades")]
    public string CodProdutos { get; set; }
}

public class Item
{
    public int CodigoProduto { get; set; }

    public int Quantidade { get; set; }
}