using DesafioProjetoHospedagem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
