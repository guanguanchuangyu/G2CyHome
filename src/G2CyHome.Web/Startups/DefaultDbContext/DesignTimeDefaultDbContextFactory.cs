// -----------------------------------------------------------------------
//  <copyright file="DesignTimeDefaultDbContextFactory.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2020 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2020-08-25 23:16</last-date>
// -----------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OSharp.Entity;
using System;


namespace G2CyHome.Web
{
    public class DesignTimeDefaultDbContextFactory : DesignTimeDbContextFactoryBase<DefaultDbContext>
    {
        public DesignTimeDefaultDbContextFactory()
            : base(null)
        { }

        protected IServiceProvider _serviceProvider;
        public DesignTimeDefaultDbContextFactory(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public override DefaultDbContext CreateDbContext(string[] args)
        {
            string migrationAssemblyName = "G2CyHome.Web";
            OSharp.Entity.ServiceExtensions.MigrationAssemblyName = migrationAssemblyName;
            Console.WriteLine($@"MigrationAssembly: {migrationAssemblyName}");

            _serviceProvider = _serviceProvider ?? CreateDesignTimeServiceProvider();

            IEntityManager entityManager = _serviceProvider.GetService<IEntityManager>();
            entityManager.Initialize();

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder<DefaultDbContext>();
            builder = _serviceProvider.BuildDbContextOptionsBuilder<DefaultDbContext>(builder);

            DefaultDbContext context = (DefaultDbContext)ActivatorUtilities.CreateInstance(_serviceProvider, typeof(DefaultDbContext), builder.Options);
            return context;
        }

        /// <summary>
        /// 创建设计时使用的ServiceProvider，主要用于执行 Add-Migration 功能
        /// </summary>
        /// <returns></returns>
        protected override IServiceProvider CreateDesignTimeServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider provider = services.BuildServiceProvider();
            return provider;
        }
    }
}
