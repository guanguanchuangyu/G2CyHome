// -----------------------------------------------------------------------
//  <copyright file="ModuleRoleConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:48</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Authorization.Entities;
using G2CyHome.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSharp.Entity;
using System;


namespace G2CyHome.EntityConfiguration.Authorization
{
    /// <summary>
    /// 模块角色信息映射配置类
    /// </summary>
    public partial class ModuleRoleConfiguration : EntityTypeConfigurationBase<ModuleRole, Guid>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<ModuleRole> builder)
        {
            builder.HasIndex(m => new { m.ModuleId, m.RoleId }).HasName("ModuleRoleIndex").IsUnique();
            builder.HasIndex(m => m.RoleId).HasName("IX_ModuleRole_RoleId");

            builder.HasOne<Module>(mr => mr.Module).WithMany().HasForeignKey(m => m.ModuleId).HasConstraintName("FK_ModuleRole_ModuleId");
            builder.HasOne<Role>(mr => mr.Role).WithMany().HasForeignKey(m => m.RoleId).HasConstraintName("FK_ModuleRole_RoleId");

            EntityConfigurationAppend(builder);
        }

        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void EntityConfigurationAppend(EntityTypeBuilder<ModuleRole> builder);
    }
}