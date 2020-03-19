using FCamara.Domain.Core.Interfaces.Repositorys;
using FCamara.Domain.Entities;

namespace FCamara.Infra.Repositorys
{
    public class ContaCorrenteRepository : BaseRepository<ContaCorrente>, IRepositoryContaCorrente
    {
        private readonly MyDBContext context;
        public ContaCorrenteRepository(MyDBContext Context) : base(Context)
        {
            this.context = context;
        }
    }
}
