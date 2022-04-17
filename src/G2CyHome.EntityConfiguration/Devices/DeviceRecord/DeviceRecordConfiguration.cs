//------------------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的映射，可新建文件“DeviceRecordConfiguration.cs”的分部类“public partial class DeviceRecordConfiguration”实现分部方法 EntityConfigurationAppend 进行扩展
// </auto-generated>
//
// <copyright file="DeviceRecordConfiguration.generated.cs" company="无">
//     
// </copyright>
// <site></site>
// <last-editor>ggcy</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using OSharp.Entity;

using G2CyHome.Devices.Entities;
using G2CyHome.Systems.Entities;

namespace G2CyHome.EntityConfiguration.Devices
{
    /// <summary>
    /// 实体配置类：设备记录信息
    /// </summary>
    public partial class DeviceRecordConfiguration
    {
        public override Type DbContextType => typeof(DeviceDbContext);
        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void EntityConfigurationAppend(EntityTypeBuilder<DeviceRecord> builder)
        {
            builder.HasOne(x => x.Room)
                .WithMany(x => x.Devices).HasForeignKey(x => x.RoomId).HasConstraintName($"FK_Device_Room");

            builder.HasOne(x => x.DeviceType)
                .WithMany()
                .HasForeignKey(x => x.DevicetypeId).HasConstraintName("FK_Device_Type");
        }
    }
}
