using FCamara.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FCamara.Infra
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        public DbSet<ContaCorrente> ContaCorrentes { get; set; }
        public DbSet<Lancamentos> Lancamentos { get; set; }
    }
}
