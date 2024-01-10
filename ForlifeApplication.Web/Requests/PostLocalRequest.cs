using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class PostLocalRequest
{
    [Required(ErrorMessage = "Informar o nome do local")]
    [MinLength(5, ErrorMessage = "Inserir pelo menos 5 letras no nome")]
    public string Descricao { get; set; } = default!;

    [Required(ErrorMessage = "Informar o endereço do local")]
    [MinLength(8, ErrorMessage = "Informar o endereço corretamente")]
    public string Endereco { get; set; } = default!;

    public string Referencia { get; set; } = default!;
};