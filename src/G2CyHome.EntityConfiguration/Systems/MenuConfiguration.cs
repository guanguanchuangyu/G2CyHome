// -----------------------------------------------------------------------
//  <copyright file="MenuInfoConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2021 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2021-02-28 21:50</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Systems.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSharp.Entity;
using System;


namespace G2CyHome.EntityConfiguration.Systems
{
    public partial class MenuConfiguration : EntityTypeConfigurationBase<Menu, int>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasIndex(m => m.ParentId).HasDatabaseName("IX_Devicelabel_LabelId");
            builder.HasMany(m => m.Children).WithOne(m => m.Parent).HasForeignKey(m => m.ParentId).HasConstraintName("FK_Systems_Menu_ParentId");

            EntityConfigurationAppend(builder);
        }

        partial void EntityConfigurationAppend(EntityTypeBuilder<Menu> builder);
    }
}