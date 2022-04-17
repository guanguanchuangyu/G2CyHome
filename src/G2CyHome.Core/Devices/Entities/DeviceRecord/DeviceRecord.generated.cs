//------------------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“DeviceRecord.cs”的分部类“public partial class DeviceRecord”添加属性
// </auto-generated>
//
// <copyright file="DeviceRecord.generated.cs" company="无">
//     
// </copyright>
// <site></site>
// <last-editor>ggcy</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using OSharp.Entity;

using G2CyHome.Systems.Entities;
namespace G2CyHome.Devices.Entities
{
    /// <summary>
    /// 实体类：设备记录信息
    /// </summary>
    [Description("设备记录信息")]
    [TableNamePrefix("devices")]
    public partial class DeviceRecord : EntityBase<Guid>, ISoftDeletable, ICreatedTime
    {
        /// <summary>
        /// 获取或设置 设备名称
        /// </summary>
        [DisplayName("设备名称")]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 设备标识
        /// </summary>
        [DisplayName("设备标识")]
        public string DeviceIdentity { get; set; }

        /// <summary>
        /// 获取或设置 设备状态
        /// </summary>
        [DisplayName("设备状态")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置 控制方式
        /// </summary>
        [DisplayName("控制方式")]
        public int ControlMode { get; set; }

        /// <summary>
        /// 获取或设置 设备描述
        /// </summary>
        [DisplayName("设备描述"), StringLength(200)]
        public string Descript { get; set; }

        /// <summary>
        /// 获取或设置 所属房间
        /// </summary>
        [DisplayName("所属房间")]
        public int RoomId { get; set; }

        /// <summary>
        /// 获取或设置 设备类型id
        /// </summary>
        [DisplayName("设备类型id")]
        public int DevicetypeId { get; set; }

        /// <summary>
        /// 获取或设置 数据逻辑删除时间，为null表示正常数据，有值表示已逻辑删除，同时删除时间每次不同也能保证索引唯一性
        /// </summary>
        [DisplayName("删除时间")]
        public DateTime? DeletedTime { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

    }
}

