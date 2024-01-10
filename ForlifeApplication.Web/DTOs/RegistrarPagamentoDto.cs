using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class RegistrarPagamentoDto
{
    public string DataPagamento { get; set; } = DateTime.Now.ToShortDateString();

    [Required(ErrorMessage = "Informar um valor de pagamento")]
    [RegularExpression("^(?!0,00)\\s*(?:[1-9]\\d{0,2}(?:\\.\\d{3})*|0)(?:,\\d{1,2})?$", ErrorMessage = "Insira um valor válido")]
    public string ValorPagamento { get; set; }

}