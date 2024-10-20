
namespace Financeiro.Api.Repository.Models
{
    public class ServiceResponse<T>
    {
        public T? DadosRetorno { get; set; }
        public string? Mensagem { get; set; }
        public bool Sucesso { get; set; } = true;
        
    }
}