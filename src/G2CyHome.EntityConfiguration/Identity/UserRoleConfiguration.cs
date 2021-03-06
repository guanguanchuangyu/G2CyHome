// -----------------------------------------------------------------------
//  <copyright file="UserRoleConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-01-06 14:27</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSharp.Entity;
using System;


namespace G2CyHome.EntityConfiguration.Identity
{
    public partial class UserRoleConfiguration : EntityTypeConfigurationBase<UserRole, Guid>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasIndex(m => new { m.UserId, m.RoleId, m.DeletedTime }).HasName("UserRoleIndex").IsUnique();
            builder.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(m => m.RoleId).HasConstraintName("FK_UserRole_RoleId");
            builder.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(m => m.UserId).HasConstraintName("FK_UserRole_UserId");

            builder.HasIndex(m => m.RoleId).HasDatabaseName("IX_UserRole_RoleId");
            EntityConfigurationAppend(builder);
        }

        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void EntityConfigurationAppend(EntityTypeBuilder<UserRole> builder);
    }
}