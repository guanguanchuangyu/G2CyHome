// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//</once-generated>
//
// <copyright file="DeviceRecord.cs" company="无">
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
    /// 输入DTO：设备记录信息
    /// </summary>
    [MapFrom(typeof(DeviceRecord))]
    [Description("设备记录信息")]
    public partial class DeviceRecordReadOutput : IOutputDto, ICreatedTime
    {
        /// <summary>
        /// 初始化一个<see cref="DeviceRecordReadOutput"/>类型的新实例
        /// </summary>
        public DeviceRecordReadOutput()
        { }

        /// <summary>
        /// 初始化一个<see cref="DeviceRecordReadOutput"/>类型的新实例
        /// </summary>
        public DeviceRecordReadOutput(DeviceRecord entity)
        {
            Id = entity.Id;
            CreatedTime = entity.CreatedTime;
        }

        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public Guid Id { get; set; }


        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

    }
}
