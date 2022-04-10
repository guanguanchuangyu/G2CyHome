// -----------------------------------------------------------------------
//  <copyright file="DataAuthorizationManager.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2020 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2020-02-27 0:31</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Authorization.Dtos;
using G2CyHome.Authorization.Entities;
using G2CyHome.Identity.Entities;
using OSharp.Authorization.DataAuthorization;
using OSharp.Authorization.Dtos;
using OSharp.Authorization.EntityInfos;
using OSharp.Entity;
using OSharp.EventBuses;
using System;


namespace G2CyHome.Authorization
{
    /// <summary>
    /// 数据权限管理器
    /// </summary>
    //[Dependency(ServiceLifetime.Scoped, AddSelf = true)]
    public class DataAuthManager : DataAuthorizationManagerBase<EntityInfo, EntityInfoInputDto, EntityRole, EntityRoleInputDto, Role, int>
    {
        /// <summary>
        /// 初始化一个 SecurityManager 类型的新实例
        /// </summary>
        public DataAuthManager(IServiceProvider provider)
            : base(provider)
        { }
    }
}
