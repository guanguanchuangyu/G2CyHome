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

using G2CyHome.Systems;
using G2CyHome.Systems.Dtos;
using G2CyHome.Systems.Entities;


namespace G2CyHome.Server.Areas.Admin.Controllers
{
    /// <summary>
    /// 房间管理信息
    /// </summary>
    [ModuleInfo(Position = "Systems", PositionName = "系统管理模块")]
    [Description("管理-房间管理信息")]
    public class RoomController : AdminApiControllerBase
    {
        private readonly IServiceProvider _provider;

        /// <summary>
        /// 初始化一个<see cref="RoomController"/>类型的新实例
        /// </summary>
        public RoomController(IServiceProvider provider)
            :base(provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// 获取或设置 系统管理模块业务契约对象
        /// </summary>
        protected ISystemsContract SystemsContract => _provider.GetRequiredService<ISystemsContract>();


        /// <summary>
        /// 读取房间管理列表信息
        /// </summary>
        /// <param name="request">页请求信息</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        [Description("读取")]
        public virtual OperationResult Read(PageRequest request)
        {
            Check.NotNull(request, nameof(request));

            Expression<Func<Room, bool>> predicate = FilterService.GetExpression<Room>(request.FilterGroup);
            var page = SystemsContract.Rooms.ToPage<Room, RoomReadOutput>(predicate, request.PageCondition);

            return new OperationResult(OperationResultType.Success, "查询成功", page.ToPageData());
        }

        /// <summary>
        /// 新增房间管理信息
        /// </summary>
        /// <param name="dtos">房间管理信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("新增")]
        public virtual async Task<OperationResult> Create(RoomCreateInput[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await SystemsContract.CreateRooms(dtos);
            return result;
        }

        /// <summary>
        /// 更新房间管理信息
        /// </summary>
        /// <param name="dtos">房间管理信息输入DTO</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("更新")]
        public virtual async Task<OperationResult> Update(RoomUpdateInput[] dtos)
        {
            Check.NotNull(dtos, nameof(dtos));
            OperationResult result = await SystemsContract.UpdateRooms(dtos);
            return result;
        }

        /// <summary>
        /// 删除房间管理信息
        /// </summary>
        /// <param name="ids">房间管理信息编号</param>
        /// <returns>JSON操作结果</returns>
        [HttpPost]
        [ModuleInfo]
        //[DependOnFunction(nameof(Read))]
        [UnitOfWork]
        [Description("删除")]
        public virtual async Task<OperationResult> Delete(int[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            OperationResult result = await SystemsContract.DeleteRooms(ids);
            return result;
        }
    }
}
