using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class CadastrarClienteDto
{
    [Required(ErrorMessage = "Informar o nome")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "Inserir pelo menos 3 letras no nome")]
    public string Nome { get; set; } = default!;

    [Required(ErrorMessage = "Informar o telefone")]
    [StringLength(11, MinimumLength = 8, ErrorMessage = "Inserir um telefone válido")]
    public string Telefone { get; set; } = default!;

    [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Informar um email válido")]
    public string Email { get; set; } = default!;

    [RegularExpression("^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[13-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$", ErrorMessage = "Informar uma data no formato dd/mm/aaaa")]
    public string DataNascimento { get; set; } = default!;

    [Required(ErrorMessage = "Informar o local da venda")]
    public string IdlocalVenda { get; set; } = default!;

    public string Observacao { get; set; } = default!;
};
