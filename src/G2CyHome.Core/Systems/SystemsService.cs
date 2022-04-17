// -----------------------------------------------------------------------
//  <copyright file="SystemsService.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2021 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2021-02-28 23:55</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Systems.Entities;
using Microsoft.Extensions.DependencyInjection;
using OSharp.Entity;
using System;


namespace G2CyHome.Systems
{
    /// <summary>
    /// 业务实现：系统模块
    /// </summary>
    public partial class SystemsService : SystemsServiceBase
    {
        /// <summary>
        /// 初始化一个<see cref="SystemsService"/>类型的新实例
        /// </summary>
        public SystemsService(IServiceProvider provider)
            :base(provider)
        {

        }
    }
}