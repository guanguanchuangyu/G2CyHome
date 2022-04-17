// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
// </once-generated>
//
// <copyright file="SensorData.cs" company="无">
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

using G2CyHome.Devices.Entities;


namespace G2CyHome.Devices.Dtos
{
    /// <summary>
    /// 输入DTO：传感器数据信息
    /// </summary>
    [MapTo(typeof(SensorData))]
    [Description("传感器数据信息")]
    public partial class SensorDataUpdateInput : IInputDto<int>
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }

    }
}
