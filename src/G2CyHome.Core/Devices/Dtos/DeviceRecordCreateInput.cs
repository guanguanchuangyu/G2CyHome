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
    [MapTo(typeof(DeviceRecord))]
    [Description("设备记录信息")]
    public partial class DeviceRecordCreateInput : IInputDto<Guid>
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public Guid Id { get; set; }

    }
}
