using DesafioProjetoHospedagem.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioProjetoHospedagem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<SuiteModel> Suites { get; set; }
        public DbSet<ReservaModel> Reservas { get; set; }
    }
}
