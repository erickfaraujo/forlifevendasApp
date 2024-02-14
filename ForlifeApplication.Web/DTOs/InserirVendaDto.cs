using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class InserirVendaDto
{
    [Required(ErrorMessage = "Informar o valor da venda")]
    [RegularExpression("^\\d+(.\\d+)*(\\,\\d+)?$", ErrorMessage = "Informar um valor válido")]
    public string ValorTotal { get; set; }

    public string ValorPago { get; set; }

    public string Observacoes { get; set; }

    [Required(ErrorMessage = "Inserir códigos de produtos e quantidades")]
    public string CodProdutos { get; set; }
}