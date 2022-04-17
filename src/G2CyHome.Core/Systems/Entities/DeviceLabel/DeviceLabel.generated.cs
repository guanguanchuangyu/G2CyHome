//------------------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“DeviceLabel.cs”的分部类“public partial class DeviceLabel”添加属性
// </auto-generated>
//
// <copyright file="DeviceLabel.generated.cs" company="无">
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
    /// 实体类：设备标签关联信息
    /// </summary>
    [Description("设备标签关联信息")]
    [TableNamePrefix("systems")]
    public partial class DeviceLabel:EntityBase<int>
    {
        /// <summary>
        /// 获取或设置 设备id
        /// </summary>
        [DisplayName("设备id")]
        public Guid DeviceId { get; set; }

        /// <summary>
        /// 获取或设置 标签id
        /// </summary>
        [DisplayName("标签id")]
        public int LabelId { get; set; }

    }
}
