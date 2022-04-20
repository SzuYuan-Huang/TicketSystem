using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TicketSystem.Modules.DA;

namespace TicketSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureContainer<ContainerBuilder>(container =>
                {
                    RegisterModule(container);
                });

        /// <summary>
        /// µù¥UModule
        /// </summary>
        /// <param name="container">ContainerBuilder</param>
        private static void RegisterModule(ContainerBuilder container)
        {
            container.RegisterModule(new DaModule());
        }
    }
}
