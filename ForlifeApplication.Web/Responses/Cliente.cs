using System.Text.Json.Serialization;

namespace ForlifeApplication.Web.Responses;

public record GetClientesResponse(
    [property: JsonPropertyName("totalClientes")] int? TotalClientes,
    [property: JsonPropertyName("clientesRetornados")] int? ClientesRetornados,
    [property: JsonPropertyName("clientes")] List<Cliente> Clientes);

public record Cliente(
    [property: JsonPropertyName("pk")] string Pk,
    [property: JsonPropertyName("sk")] string Sk,
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("telefone")] string Telefone,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("dtnascimento")] string Dtnascimento,
    [property: JsonPropertyName("idlocal")] string Idlocal,
    [property: JsonPropertyName("nomeLocal")] string NomeLocal,
    [property: JsonPropertyName("observacao")] string Observacao);