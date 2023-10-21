namespace ForlifeApplication.Web.Requests;

public class PutClienteRequest
{
    public string Id { get; set; } = default!;

    public string Nome { get; set; } = default!;

    public string Telefone { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string Dtnascimento { get; set; } = default!;

    public string IdlocalVenda { get; set; } = default!;
};
