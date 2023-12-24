using Microsoft.EntityFrameworkCore;
using Persona.Domain.Core.Events;
using Persona.Infra.Data.PostgreSQL.Mappings;

namespace Persona.Infra.Data.PostgreSQL.Context
{
    public class EventStoreSqlContext : DbContext
    {
        public EventStoreSqlContext(DbContextOptions<EventStoreSqlContext> options) : base(options) { }

        public DbSet<StoredEvent> StoredEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
