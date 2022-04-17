// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
// </once-generated>
//
// <copyright file="DeviceType.cs" company="无">
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
using OSharp.Mapping;

using G2CyHome.Systems.Entities;


namespace G2CyHome.Systems.Dtos
{
    /// <summary>
    /// 输入DTO：设备类型信息
    /// </summary>
    [MapTo(typeof(DeviceType))]
    [Description("设备类型信息")]
    public partial class DeviceTypeUpdateInput : IInputDto<int>
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }


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

    }
}
