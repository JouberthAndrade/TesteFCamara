using FCamara.Domain.Entities;
using System.Net.Http;
using System.Threading.Tasks;

namespace FCamara.Domain.Core.Interfaces.Services
{
    public interface IServiceLancamento : IBaseService<Lancamentos>
    {
        Task<HttpResponseMessage> RealizarTransacao(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor);
    }
}
