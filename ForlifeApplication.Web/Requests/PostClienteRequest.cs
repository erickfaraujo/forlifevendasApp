using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class PostClienteRequest
{
    [Required(ErrorMessage = "Informar o nome")]
    [StringLength(200, MinimumLength = 5, ErrorMessage = "Inserir pelo menos 5 letras no nome")]
    public string Nome { get; set; } = default!;

    [Required(ErrorMessage = "Informar o telefone")]
    [StringLength(11, MinimumLength = 8, ErrorMessage = "Inserir um telefone válido")]
    public string Telefone { get; set; } = default!;

    [Required(ErrorMessage = "Informar o email")]
    [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Informar um email válido")]
    public string Email { get; set; } = default!;

    [Required(ErrorMessage = "Informar a data de nascimento")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "Informar o local da venda")]
    public string IdlocalVenda { get; set; } = default!;

    public string Observacao { get; set; } = default!;
};
