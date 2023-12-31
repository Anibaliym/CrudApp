using Microsoft.EntityFrameworkCore;
using Persona.Domain.Core.Data;
using Persona.Domain.Entities;
using Persona.Domain.Interfaces;
using Persona.Infra.Data.PostgreSQL.Context;

namespace Persona.Infra.Data.PostgreSQL.Repository
{
    public class ContactoRepository : IContactoRepository
    {
        protected readonly PersonaContext Db;
        protected readonly DbSet<Contacto> DbSet;

        public IUnitOfWork UnitOfWork => Db;

        public ContactoRepository(PersonaContext context) {
            Db = context;
            DbSet = Db.Set<Contacto>();
        }

        public async Task<Contacto> BuscaPorId(Guid id)
        {
            return await DbSet.AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Contacto> BuscaPorIdPersona(Guid idPersona)
        {
            return await DbSet.AsNoTracking().Where(c => c.IdPersona == idPersona).FirstOrDefaultAsync();
        }

        public void Crear(Contacto modelo)
        {
            DbSet.Add(modelo);
        }

        public void Modificar(Contacto modelo)
        {
            DbSet.Update(modelo);
        }

        public void Eliminar(Contacto modelo)
        {
            DbSet.Remove(modelo);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
