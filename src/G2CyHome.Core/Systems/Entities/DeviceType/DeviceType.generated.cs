//------------------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“DeviceType.cs”的分部类“public partial class DeviceType”添加属性
// </auto-generated>
//
// <copyright file="DeviceType.generated.cs" company="无">
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


namespace G2CyHome.Systems.Entities
{
    /// <summary>
    /// 实体类：设备类型信息
    /// </summary>
    [Description("设备类型信息")]
    [TableNamePrefix("systems")]
    public partial class DeviceType : EntityBase<int>, ISoftDeletable, ICreatedTime
    {
        /// <summary>
        /// 获取或设置 类型名称
        /// </summary>
        [DisplayName("类型名称")]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 类型logo
        /// </summary>
        [DisplayName("类型logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 获取或设置 类型图片
        /// </summary>
        [DisplayName("类型图片")]
        public string PicPath { get; set; }

        /// <summary>
        /// 获取或设置 备注信息
        /// </summary>
        [DisplayName("备注信息")]
        public string Remark { get; set; }

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

