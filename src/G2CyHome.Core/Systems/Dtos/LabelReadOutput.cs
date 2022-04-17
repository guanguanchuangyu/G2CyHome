// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//</once-generated>
//
// <copyright file="Label.cs" company="无">
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

using G2CyHome.Systems.Entities;

namespace G2CyHome.Systems.Dtos
{
    /// <summary>
    /// 输入DTO：标签管理信息
    /// </summary>
    [MapFrom(typeof(Label))]
    [Description("标签管理信息")]
    public partial class LabelReadOutput : IOutputDto, ICreatedTime
    {
        /// <summary>
        /// 初始化一个<see cref="LabelReadOutput"/>类型的新实例
        /// </summary>
        public LabelReadOutput()
        { }

        /// <summary>
        /// 初始化一个<see cref="LabelReadOutput"/>类型的新实例
        /// </summary>
        public LabelReadOutput(Label entity)
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
