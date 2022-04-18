using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using OSharp.AspNetCore.Mvc;
using OSharp.AspNetCore.Mvc.Filters;
using OSharp.AspNetCore.UI;
using OSharp.Caching;
using OSharp.Authorization.Functions;
using OSharp.Authorization.Modules;
using OSharp.Data;
using OSharp.Entity;
using OSharp.Filter;
using OSharp.Security;

using G2CyHome.Devices;
using G2CyHome.Devices.Dtos;
using G2CyHome.Devices.Entities;


namespace G2CyHome.Server.Areas.Admin.Controllers
{
    /// <summary>
    /// 设备记录信息
    /// </summary>
    [ModuleInfo(Position = "Devices", PositionName = "设备管理模块")]
    [Description("管理-设备记录信息")]
    public class DeviceRecordController : AdminApiControllerBase
    {
        private readonly IServiceProvider _provider;

        /// <summary>
        /// 初始化一个<see cref="DeviceRecordController"/>类型的新实例
        /// </summary>
        public DeviceRecordController(IServiceProvider provider)
            :base(provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// 获取或设置 设备管理模块业务契约对象
        /// </summary>
        protected IDevicesContract DevicesContract => _provider.GetRequiredService<IDevicesContract>();


        /// <summary>
        /// 读取设备记录列表信息
        /// </summary>
        /// <param name="request">页请求信息</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [Description("读取")]
        public virtual OperationResult Read(PageRequest request)
        {
            Check.NotNull(request, nameof(request));

            Expression<Func<DeviceRecord, bool>> predicate = FilterService.GetExpression<DeviceRecord>(request.FilterGroup);
            var page = DevicesContract.DeviceRecords.ToPage<DeviceRecord, DeviceRecordReadOutput>(predicate, request.PageCondition);

            return new OperationResult(OperationResultType.Success, "查询成功", page.ToPageData());
        }

        /// <summary>
        /// 新增设备记录信息
        /// </summary>
        /// <param name="dtos">设备记录信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("新增")]
        public virtual async Task<OperationResult> Create(DeviceRecordCreateInput[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await DevicesContract.CreateDeviceRecords(dtos);
            return result;
        }

        /// <summary>
        /// 更新设备记录信息
        /// </summary>
        /// <param name="dtos">设备记录信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("更新")]
        public virtual async Task<OperationResult> Update(DeviceRecordUpdateInput[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await DevicesContract.UpdateDeviceRecords(dtos);
            return result;
        }

        /// <summary>
        /// 删除设备记录信息
        /// </summary>
        /// <param name="ids">设备记录信息编号</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("删除")]
        public virtual async Task<OperationResult> Delete(Guid[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            OperationResult result = await DevicesContract.DeleteDeviceRecords(ids);
            return result;
        }
    }
}
