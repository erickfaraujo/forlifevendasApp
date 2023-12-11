using System.ComponentModel.DataAnnotations;

namespace ForlifeApplication.Web.Requests;

public class PostClienteRequest
{
    [Required(ErrorMessage = "Informar o nome")]
    public string Nome { get; set; } = default!;

    [Required(ErrorMessage = "Informar o telefone")]
    public string Telefone { get; set; } = default!;

    [RegularExpression("/^[a-z0-9.]+@[a-z0-9]+\\.[a-z]+\\.([a - z]+)?$/i;", ErrorMessage = "Informar um email válido")]
    public string Email { get; set; } = default!;

    [Required(ErrorMessage = "Informar a data de nascimento")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "Informar o local da venda")]
    public string IdlocalVenda { get; set; } = default!;
};
