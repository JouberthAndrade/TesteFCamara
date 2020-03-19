using FCamara.Application.Command;
using System.Net.Http;
using System.Threading.Tasks;

namespace FCamara.Application.Interfaces
{
    public interface IApplicationOperacao
    {
        Task<HttpResponseMessage> RealizarTransacao(LancamentoCommand lancamento);
    }
}
