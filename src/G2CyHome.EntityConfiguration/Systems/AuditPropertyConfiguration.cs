using G2CyHome.Systems.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSharp.Entity;
using System;

namespace G2CyHome.EntityConfiguration.Systems
{
    public partial class AuditPropertyConfiguration : EntityTypeConfigurationBase<AuditProperty, Guid>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<AuditProperty> builder)
        {
            builder.HasIndex(m => m.AuditEntityId).HasDatabaseName("IX_AuditP_AuditEntityId");
            builder.HasOne(m => m.AuditEntity).WithMany(n => n.Properties).HasForeignKey(m => m.AuditEntityId).HasConstraintName("FK_AuditProperty_Id");

            EntityConfigurationAppend(builder);
        }

        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void EntityConfigurationAppend(EntityTypeBuilder<AuditProperty> builder);
    }
}
