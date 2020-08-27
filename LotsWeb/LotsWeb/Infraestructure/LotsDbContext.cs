using LotsWebAPI.Infraestructure.Configuration;
using LotsWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LotsWebAPI.Infraestructure
{
    public class LotsDbContext : DbContext
    {
        public LotsDbContext(DbContextOptions<LotsDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<LotOcupation> LotsOcupations {get; set;}

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.ApplyConfiguration(new CarEntityTypeConfiguration());
        }

        private static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLoggerFactory(MyLoggerFactory)
                .EnableSensitiveDataLogging(true);
        }


    }
}
