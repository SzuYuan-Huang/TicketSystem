using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Service.Tickets;

namespace TicketSystem.Modules.BL
{
    /// <summary>
    /// 商業邏輯層模組。
    /// </summary>
    public class BlModule : Autofac.Module
    {
        /// <summary>Override to add registrations to the container.</summary>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        protected override void Load(ContainerBuilder builder)
        {
            //// Register Repositories
            builder.RegisterType<TicketService>().As<ITicketService>();
        }
    }
}
