﻿using Microsoft.EntityFrameworkCore;
using Persona.Domain.Core.Data;
using Persona.Domain.Interfaces;
using Persona.Infra.Data.PostgreSQL.Context;

namespace Persona.Infra.Data.PostgreSQL.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        protected readonly PersonaContext Db;
        protected readonly DbSet<Domain.Entities.Persona> DbSet;

        public IUnitOfWork UnitOfWork => Db;

        public PersonaRepository(PersonaContext context)
        {
            Db = context;
            DbSet = Db.Set<Domain.Entities.Persona>();
        }

        public async Task<IEnumerable<Domain.Entities.Persona>> BuscaPorApellidoMaternoCoincidencias(string apellidoMaterno)
        {
            return DbSet.Where(p => EF.Functions.Like(p.ApellidoMaterno.ToUpper(), "%" + apellidoMaterno.ToUpper() + "%")).ToList();
        }

        public async Task<IEnumerable<Domain.Entities.Persona>> BuscaPorApellidoPaternoCoincidencias(string apellidoPaterno)
        {
            return DbSet.Where(p => EF.Functions.Like(p.ApellidoPaterno.ToUpper(), "%" + apellidoPaterno.ToUpper() + "%")).ToList();
        }

        public async Task<Domain.Entities.Persona> BuscaPorId(Guid id)
        {
            return await DbSet.AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Domain.Entities.Persona>> BuscaPorNombreCoincidencias(string nombre)
        {
            return DbSet.Where(p => EF.Functions.Like(p.Nombre.ToUpper(), "%" + nombre.ToUpper() + "%")).ToList();
        }

        public async Task<Domain.Entities.Persona> BuscaPorRut(string rut)
        {
            return await DbSet.AsNoTracking().Where(P => P.Rut == rut).FirstOrDefaultAsync();
        }

        public void Crear(Domain.Entities.Persona modelo)
        {
            DbSet.Add(modelo);
        }

        public void Eliminar(Domain.Entities.Persona modelo)
        {
            DbSet.Remove(modelo);
        }

        public void Modificar(Domain.Entities.Persona modelo)
        {
            DbSet.Update(modelo);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
