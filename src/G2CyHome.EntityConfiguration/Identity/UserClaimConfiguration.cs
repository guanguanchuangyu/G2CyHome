﻿// -----------------------------------------------------------------------
//  <copyright file="UserClaimConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:48</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSharp.Entity;

namespace G2CyHome.EntityConfiguration.Identity
{
    public partial class UserClaimConfiguration : EntityTypeConfigurationBase<UserClaim, int>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.HasOne(uc => uc.User).WithMany(u => u.UserClaims).HasForeignKey(uc => uc.UserId).IsRequired().HasConstraintName("FK_UserClaim_UserId");
            builder.HasIndex(m => m.UserId).HasDatabaseName("IX_UserClaim_UserId");

            EntityConfigurationAppend(builder);
        }

        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void EntityConfigurationAppend(EntityTypeBuilder<UserClaim> builder);
    }
}