using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class PostLocalRequest
{
    [Required(ErrorMessage = "Informar o nome do local")]
    public string Descricao { get; set; } = default!;

    [Required(ErrorMessage = "Informar o endereço do local")]
    [MinLength(15, ErrorMessage = "Informar o endereço corretamente")]
    public string Endereco { get; set; } = default!;

    public string Referencia { get; set; } = default!;
};