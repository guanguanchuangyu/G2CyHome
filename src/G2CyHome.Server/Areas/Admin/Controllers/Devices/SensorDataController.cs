using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OSharp.AspNetCore.Mvc.Filters;
using OSharp.Authorization.Modules;
using OSharp.Data;
using OSharp.Entity;
using OSharp.Filter;

using G2CyHome.Devices;
using G2CyHome.Devices.Dtos;
using G2CyHome.Devices.Entities;


namespace G2CyHome.Server.Areas.Admin.Controllers
{
    /// <summary>
    /// 传感器数据信息
    /// </summary>
    [ModuleInfo(Position = "Devices", PositionName = "设备管理模块")]
    [Description("管理-传感器数据信息")]
    public class SensorDataController : AdminApiControllerBase
    {
        private readonly IServiceProvider _provider;

        /// <summary>
        /// 初始化一个<see cref="SensorDataController"/>类型的新实例
        /// </summary>
        public SensorDataController(IServiceProvider provider)
            :base(provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// 获取或设置 设备管理模块业务契约对象
        /// </summary>
        protected IDevicesContract DevicesContract => _provider.GetRequiredService<IDevicesContract>();


        /// <summary>
        /// 读取传感器数据列表信息
        /// </summary>
        /// <param name="request">页请求信息</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [Description("读取")]
        public virtual OperationResult Read(PageRequest request)
        {
            Check.NotNull(request, nameof(request));

            Expression<Func<SensorData, bool>> predicate = FilterService.GetExpression<SensorData>(request.FilterGroup);
            var page = DevicesContract.SensorDatas.ToPage<SensorData, SensorDataReadOutput>(predicate, request.PageCondition);

            return new OperationResult(OperationResultType.Success, "查询成功", page.ToPageData());
        }

        /// <summary>
        /// 新增传感器数据信息
        /// </summary>
        /// <param name="dtos">传感器数据信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("新增")]
        public virtual async Task<OperationResult> Create(SensorDataCreateInput[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await DevicesContract.CreateSensorDatas(dtos);
            return result;
        }

        /// <summary>
        /// 删除传感器数据信息
        /// </summary>
        /// <param name="ids">传感器数据信息编号</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("删除")]
        public virtual async Task<OperationResult> Delete(int[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            OperationResult result = await DevicesContract.DeleteSensorDatas(ids);
            return result;
        }
    }
}
