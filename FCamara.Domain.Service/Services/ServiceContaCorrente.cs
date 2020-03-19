using System.Net.Http;
using System.Threading.Tasks;
using FCamara.Domain.Core.Interfaces.Repositorys;
using FCamara.Domain.Core.Interfaces.Services;
using FCamara.Domain.Entities;

namespace FCamara.Domain.Service.Services
{
    public class ServiceContaCorrente : BaseServices<ContaCorrente>, IServiceContaCorrente
    {
        public readonly IRepositoryContaCorrente repositoryContaCorrente;

        public ServiceContaCorrente(IRepositoryContaCorrente repositoryContaCorrente) : base(repositoryContaCorrente)
        {
            this.repositoryContaCorrente = repositoryContaCorrente;
        }

        
    }
}
