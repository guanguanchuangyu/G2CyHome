// -----------------------------------------------------------------------
//  <copyright file="AuditOperationController.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-08-02 14:47</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Systems;
using G2CyHome.Systems.Dtos;
using G2CyHome.Systems.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OSharp.AspNetCore.UI;
using OSharp.Authorization.Modules;
using OSharp.Entity;
using OSharp.Filter;
using System;
using System.ComponentModel;
using System.Linq.Expressions;


namespace G2CyHome.Server.Areas.Admin.Controllers
{
    /// <summary>
    /// 操作审计信息
    /// </summary>
    [ModuleInfo(Order = 2, Position = "Systems", PositionName = "系统管理模块")]
    [Description("管理-操作审计信息")]
    public class AuditOperationController : AdminApiControllerBase
    {
        private readonly IServiceProvider _provider;

        public AuditOperationController(IServiceProvider provider)
            : base(provider)
        {
            _provider = provider;
        }

        public IAuditContract AuditContract => _provider.GetRequiredService<IAuditContract>();

        /// <summary>
        /// 读取操作审计信息
        /// </summary>
        /// <param name="request">页数据请求</param>
        /// <returns>操作审计信息的页数据</returns>
        [HttpPost]
        [ModuleInfo]
        [Description("读取")]
        public AjaxResult Read(PageRequest request)
        {
            Expression<Func<AuditOperation, bool>> predicate = FilterService.GetExpression<AuditOperation>(request.FilterGroup);
            request.AddDefaultSortCondition(new SortCondition("CreatedTime", ListSortDirection.Descending));
            var page = AuditContract.AuditOperations.ToPage<AuditOperation, AuditOperationOutputDto>(predicate, request.PageCondition);
            return AjaxResult.Success(page.ToPageData());
        }
    }
}
