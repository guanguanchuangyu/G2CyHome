// -----------------------------------------------------------------------
//  <copyright file="LoginLogController.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2021 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2021-03-22 13:54</last-date>
// -----------------------------------------------------------------------

using G2CyHome.Identity;
using G2CyHome.Identity.Dtos;
using G2CyHome.Identity.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OSharp.AspNetCore.Mvc.Filters;
using OSharp.AspNetCore.UI;
using OSharp.Authorization.Modules;
using OSharp.Data;
using OSharp.Entity;
using OSharp.Filter;
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace G2CyHome.Server.Areas.Admin.Controllers
{
    /// <summary>
    /// 登录日志信息
    /// </summary>
    [ModuleInfo(Order = 4, Position = "Identity", PositionName = "身份认证模块")]
    [Description("管理-登录日志信息")]
    public class LoginLogController : AdminApiControllerBase
    {
        private readonly IServiceProvider _provider;

        public LoginLogController(IServiceProvider provider) : base(provider)
        {
            _provider = provider;
        }

        public IIdentityContract IdentityContract => _provider.GetRequiredService<IIdentityContract>();

        [HttpPost]
        [ModuleInfo]
        [Description("读取")]
        public AjaxResult Read(PageRequest request)
        {
            Check.NotNull(request, nameof(request));

            Expression<Func<LoginLog, bool>> exp = FilterService.GetExpression<LoginLog>(request.FilterGroup);
            var page = IdentityContract.LoginLogs.ToPage(exp,
                request.PageCondition,
                m => new
                {
                    D = m,
                    User = new { m.User.UserName, m.User.NickName }
                }).ToPageResult(data => data.Select(m => new LoginLogOutputDto(m.D)
                {
                    UserName = m.User.UserName,
                    NickName = m.User.NickName
                }).ToArray());

            return AjaxResult.Success(page.ToPageData());
        }
    }
}
