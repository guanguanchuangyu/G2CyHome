// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//</once-generated>
//
// <copyright file="SensorData.cs" company="无">
//     
//</copyright>
// <site></site>
// <last-editor>ggcy</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using OSharp.Entity;
using OSharp.Mapping;

using G2CyHome.Devices.Entities;

namespace G2CyHome.Devices.Dtos
{
    /// <summary>
    /// 输入DTO：传感器数据信息
    /// </summary>
    [MapFrom(typeof(SensorData))]
    [Description("传感器数据信息")]
    public partial class SensorDataReadOutput : IOutputDto, ICreatedTime
    {
        /// <summary>
        /// 初始化一个<see cref="SensorDataReadOutput"/>类型的新实例
        /// </summary>
        public SensorDataReadOutput()
        { }

        /// <summary>
        /// 初始化一个<see cref="SensorDataReadOutput"/>类型的新实例
        /// </summary>
        public SensorDataReadOutput(SensorData entity)
        {
            Id = entity.Id;
            CreatedTime = entity.CreatedTime;
        }

        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }


        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

    }
}
