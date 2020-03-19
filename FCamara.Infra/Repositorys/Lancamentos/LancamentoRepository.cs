using FCamara.Domain.Core.Interfaces.Repositorys;
using FCamara.Domain.Entities;

namespace FCamara.Infra.Repositorys
{
    public class LancamentoRepository : BaseRepository<Lancamentos>, IRepositoryLancamento
    {
        private readonly MyDBContext context;
        public LancamentoRepository(MyDBContext Context) : base(Context)
        {
            this.context = context;
        }
    }
}
