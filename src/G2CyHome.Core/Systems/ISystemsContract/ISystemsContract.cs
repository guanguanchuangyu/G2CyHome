// -----------------------------------------------------------------------
//  <copyright file="ISystemsContract.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-01-08 13:38</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Systems.Dtos;
using G2CyHome.Systems.Entities;
using OSharp.Data;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace G2CyHome.Systems
{
    /// <summary>
    /// 业务契约：系统模块
    /// </summary>
    public interface ISystemsContract
    {
        #region 菜单信息业务

        /// <summary>
        /// 获取 菜单信息查询数据集
        /// </summary>
        IQueryable<Menu> MenuInfos { get; }

        /// <summary>
        /// 检查菜单信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的菜单信息编号</param>
        /// <returns>菜单信息是否存在</returns>
        Task<bool> CheckMenuInfoExists(Expression<Func<Menu, bool>> predicate, int id = default);

        /// <summary>
        /// 添加菜单信息信息
        /// </summary>
        /// <param name="dtos">要添加的菜单信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateMenuInfos(params MenuInputDto[] dtos);

        /// <summary>
        /// 更新菜单信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的菜单信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateMenuInfos(params MenuInputDto[] dtos);

        /// <summary>
        /// 删除菜单信息信息
        /// </summary>
        /// <param name="ids">要删除的菜单信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteMenuInfos(params int[] ids);

        #endregion

        #region 房间管理信息业务
        /// <summary>
        /// 获取 房间管理信息查询数据集
        /// </summary>
        IQueryable<Room> Rooms { get; }

        /// <summary>
        /// 检查房间管理信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的房间管理信息编号</param>
        /// <returns>房间管理信息是否存在</returns>
        Task<bool> CheckRoomExists(Expression<Func<Room, bool>> predicate, int id = default(int));

        /// <summary>
        /// 添加房间管理信息信息
        /// </summary>
        /// <param name="dtos">要添加的房间管理信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateRooms(params RoomCreateInput[] dtos);

        /// <summary>
        /// 更新房间管理信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的房间管理信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateRooms(params RoomUpdateInput[] dtos);

        /// <summary>
        /// 删除房间管理信息信息
        /// </summary>
        /// <param name="ids">要删除的房间管理信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteRooms(params int[] ids);

        #endregion


        #region 标签管理信息业务
        /// <summary>
        /// 获取 标签管理信息查询数据集
        /// </summary>
        IQueryable<Label> Labels { get; }

        /// <summary>
        /// 检查标签管理信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的标签管理信息编号</param>
        /// <returns>标签管理信息是否存在</returns>
        Task<bool> CheckLabelExists(Expression<Func<Label, bool>> predicate, int id = default(int));

        /// <summary>
        /// 添加标签管理信息信息
        /// </summary>
        /// <param name="dtos">要添加的标签管理信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateLabels(params LabelCreateInput[] dtos);

        /// <summary>
        /// 更新标签管理信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的标签管理信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateLabels(params LabelUpdateInput[] dtos);

        /// <summary>
        /// 删除标签管理信息信息
        /// </summary>
        /// <param name="ids">要删除的标签管理信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteLabels(params int[] ids);

        #endregion


        #region 设备类型信息业务
        /// <summary>
        /// 获取 设备类型信息查询数据集
        /// </summary>
        IQueryable<DeviceType> DeviceTypes { get; }

        /// <summary>
        /// 检查设备类型信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的设备类型信息编号</param>
        /// <returns>设备类型信息是否存在</returns>
        Task<bool> CheckDeviceTypeExists(Expression<Func<DeviceType, bool>> predicate, int id = default(int));

        /// <summary>
        /// 添加设备类型信息信息
        /// </summary>
        /// <param name="dtos">要添加的设备类型信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> CreateDeviceTypes(params DeviceTypeCreateInput[] dtos);

        /// <summary>
        /// 更新设备类型信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的设备类型信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateDeviceTypes(params DeviceTypeUpdateInput[] dtos);

        /// <summary>
        /// 删除设备类型信息信息
        /// </summary>
        /// <param name="ids">要删除的设备类型信息编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> DeleteDeviceTypes(params int[] ids);

        #endregion

    }
}