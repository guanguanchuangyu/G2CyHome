// -----------------------------------------------------------------------
//  <copyright file="Startup.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2020 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2020-03-26 21:52</last-date>
// -----------------------------------------------------------------------

using G2Cy.Extensions;
using G2Cy.Swagger;
using G2CyHome.Authorization;
using G2CyHome.Identity;
using G2CyHome.Server.Controllers;
using G2CyHome.Systems;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OSharp.AspNetCore;
using OSharp.AspNetCore.Routing;
using OSharp.AutoMapper;
using OSharp.Log4Net;

namespace G2CyHome.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOSharp()
                .AddPack<Log4NetPack>()
                .AddPack<AutoMapperPack>()
                .AddPack<EndpointsPack>()
                .AddPack<SwaggerPack>()
                //.AddPack<RedisPack>()
                .AddPack<AuthenticationPack>()
                .AddPack<FunctionAuthorizationPack>()
                .AddPack<DataAuthorizationPack>()
                .AddPack<MySqlDefaultDbContextMigrationPack>()
                .AddPack<AuditPack>()
                ;
            //移除OsharpNs自带服务
            services.AddExtensionServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/#/500");
                app.UseHsts();
                //app.UseHttpsRedirection(); // 启用HTTPS
            }
            //app.UseMiddleware<HostHttpCryptoMiddleware>();
            //app.UseMiddleware<JsonNoFoundHandlerMiddleware>();
            app.UseMiddleware<JsonExceptionHandlerMiddleware>();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseOSharp();
        }
    }
}
