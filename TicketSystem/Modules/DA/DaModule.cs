using Autofac;
using Autofac.Features.AttributeFilters;
using DataAccess.DbContexts;
using DataAccess.DbContexts.TicketSystemDb;
using DataAccess.Repositories.Roles;
using DataAccess.Repositories.Tickets;

namespace TicketSystem.Modules.DA
{
    /// <summary>
    /// 資料存取層模組。
    /// </summary>
    public class DaModule : Autofac.Module
    {
        /// <summary>Override to add registrations to the container.</summary>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        protected override void Load(ContainerBuilder builder)
        {
            //// Register ReadWrite WebStoreDB。
            builder.RegisterType<TicketSystemDbContext>()
                .Keyed<IDbContext>("TicketSystemDB")
                .InstancePerLifetimeScope();

            //// Register Repositories
            builder.RegisterType<RoleRepository>().As<IRoleRepository>().WithAttributeFiltering();
            builder.RegisterType<TicketRepository>().As<ITicketRepository>().WithAttributeFiltering();
        }
    }
}
