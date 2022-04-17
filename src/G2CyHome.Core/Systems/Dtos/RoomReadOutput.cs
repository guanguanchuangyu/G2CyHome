// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//</once-generated>
//
// <copyright file="Room.cs" company="无">
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
    /// 输入DTO：房间管理信息
    /// </summary>
    [MapFrom(typeof(Room))]
    [Description("房间管理信息")]
    public partial class RoomReadOutput : IOutputDto, ICreatedTime, ICreationAudited<int>, IUpdateAudited<int>
    {
        /// <summary>
        /// 初始化一个<see cref="RoomReadOutput"/>类型的新实例
        /// </summary>
        public RoomReadOutput()
        { }

        /// <summary>
        /// 初始化一个<see cref="RoomReadOutput"/>类型的新实例
        /// </summary>
        public RoomReadOutput(Room entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Floor = entity.Floor;
            Remark = entity.Remark;
            Logo = entity.Logo;
            PicPath = entity.PicPath;
            Order = entity.Order;
            CreatedTime = entity.CreatedTime;
            CreatorId = entity.CreatorId;
            LastUpdaterId = entity.LastUpdaterId;
            LastUpdatedTime = entity.LastUpdatedTime;
        }

        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }


        /// <summary>
        /// 获取或设置 房间名称
        /// </summary>
        [DisplayName("房间名称")]
        public string Name { get; set; }


        /// <summary>
        /// 获取或设置 所在楼层
        /// </summary>
        [DisplayName("所在楼层")]
        public int Floor { get; set; }


        /// <summary>
        /// 获取或设置 备注信息
        /// </summary>
        [DisplayName("备注信息")]
        public string Remark { get; set; }


        /// <summary>
        /// 获取或设置 房间logo
        /// </summary>
        [DisplayName("房间logo")]
        public string Logo { get; set; }


        /// <summary>
        /// 获取或设置 房间图片
        /// </summary>
        [DisplayName("房间图片")]
        public string PicPath { get; set; }


        /// <summary>
        /// 获取或设置 排序
        /// </summary>
        [DisplayName("排序")]
        public int Order { get; set; }


        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 获取或设置 创建者编号
        /// </summary>
        [DisplayName("创建者编号")]
        public int? CreatorId { get; set; }

        /// <summary>
        /// 获取或设置 更新者编号
        /// </summary>
        [DisplayName("更新者编号")]
        public int? LastUpdaterId { get; set; }

        /// <summary>
        /// 获取或设置 最后更新时间
        /// </summary>
        [DisplayName("更新时间")]
        public DateTime? LastUpdatedTime { get; set; }

    }
}
