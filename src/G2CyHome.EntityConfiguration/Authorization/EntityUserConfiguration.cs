// -----------------------------------------------------------------------
//  <copyright file="EntityUserConfiguration.cs" company="OSharp��Դ�Ŷ�">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>������</last-editor>
//  <last-date>2018-06-27 4:48</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Authorization.Entities;
using G2CyHome.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSharp.Authorization.EntityInfos;
using OSharp.Entity;
using System;


namespace G2CyHome.EntityConfiguration.Authorization
{
    public partial class EntityUserConfiguration : EntityTypeConfigurationBase<EntityUser, Guid>
    {
        /// <summary>
        /// ��д��ʵ��ʵ�����͸������Ե����ݿ�����
        /// </summary>
        /// <param name="builder">ʵ�����ʹ�����</param>
        public override void Configure(EntityTypeBuilder<EntityUser> builder)
        {
            builder.HasIndex(m => new { m.EntityId, m.UserId }).HasName("EntityUserIndex");
            builder.HasIndex(m => m.UserId).HasName("IX_EntityUser_UserId");

            builder.HasOne<EntityInfo>(eu => eu.EntityInfo).WithMany().HasForeignKey(m => m.EntityId).HasConstraintName("FK_EntityUser_EntityId");
            builder.HasOne<User>(eu => eu.User).WithMany().HasForeignKey(m => m.UserId).HasConstraintName("FK_EntityUser_UserId");

            EntityConfigurationAppend(builder);
        }

        /// <summary>
        /// ���������ӳ��
        /// </summary>
        partial void EntityConfigurationAppend(EntityTypeBuilder<EntityUser> builder);
    }
}