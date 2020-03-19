using System.Threading.Tasks;

namespace FCamara.Domain.Interfaces
{
    public interface ITransacaoRepository
    {
        Task Credito();
        Task Debito();
    }
}
