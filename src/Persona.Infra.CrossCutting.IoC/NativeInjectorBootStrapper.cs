using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Persona.Application.Interfaces;
using Persona.Application.Services;
using Persona.Domain.Commands.Contacto.Commands;
using Persona.Domain.Commands.Contacto.Handlers;
using Persona.Domain.Commands.Persona.Commands;
using Persona.Domain.Commands.Persona.Handlers;
using Persona.Domain.Core.Events;
using Persona.Domain.Core.Mediator;
using Persona.Domain.Core.Messaging;
using Persona.Domain.Events.Contacto.Events;
using Persona.Domain.Events.Contacto.Handlers;
using Persona.Domain.Events.Persona.Events;
using Persona.Domain.Events.Persona.Handlers;
using Persona.Domain.Interfaces;
using Persona.Infra.CrossCutting.Bus;
using Persona.Infra.Data.PostgreSQL.Context;
using Persona.Infra.Data.PostgreSQL.EventSourcing;
using Persona.Infra.Data.PostgreSQL.Repository;
using Persona.Infra.Data.PostgreSQL.Repository.EventSourcing;

namespace Persona.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services) {

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Application
            services.AddScoped<IPersonaAppService, PersonaAppService>();
            services.AddScoped<IContactoAppService, ContactoAppService>();

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Domain Events
            services.AddScoped<INotificationHandler<PersonaCrearEvent>, PersonaCrearEventHandler>();
            services.AddScoped<INotificationHandler<PersonaModificarEvent>, PersonaModificarEventHandler>();
            services.AddScoped<INotificationHandler<PersonaEliminarEvent>, PersonaEliminarEventHandler>();

            services.AddScoped<INotificationHandler<ContactoCrearEvent>, ContactoCrearEventHandler>();
            services.AddScoped<INotificationHandler<ContactoModificarEvent>, ContactoModificarEventHandler>();
            services.AddScoped<INotificationHandler<ContactoEliminarEvent>, ContactoEliminarEventHandler>();


            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Domain Commands
            services.AddScoped<IRequestHandler<PersonaCrearCommand, CommandResponse>, PersonaCommandHandler>();
            services.AddScoped<IRequestHandler<PersonaModificarCommand, CommandResponse>, PersonaCommandHandler>();
            services.AddScoped<IRequestHandler<PersonaEliminarCommand, CommandResponse>, PersonaCommandHandler>();

            services.AddScoped<IRequestHandler<ContactoCrearCommand, CommandResponse>, ContactoCommandHandler>();
            services.AddScoped<IRequestHandler<ContactoModificarCommand, CommandResponse>, ContactoCommandHandler>();
            services.AddScoped<IRequestHandler<ContactoEliminarCommand, CommandResponse>, ContactoCommandHandler>();

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //InfraData
            services.AddScoped<IPersonaRepository, PersonaRepository>();
            services.AddScoped<IContactoRepository, ContactoRepository>();

            services.AddScoped<PersonaContext>();

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Infra Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSqlContext>();
        }
    }
}
