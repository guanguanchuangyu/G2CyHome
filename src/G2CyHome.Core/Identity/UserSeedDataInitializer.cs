using G2CyHome.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OSharp.Entity;
using OSharp.Exceptions;
using OSharp.Extensions;
using OSharp.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Identity
{
    /// <summary>
    /// 用户种子数据创建类
    /// </summary>
    public class UserSeedDataInitializer : SeedDataInitializerBase<User, int>
    {
        private readonly IServiceProvider _rootProvider;
        /// <summary>
        /// 种子构造函数
        /// </summary>
        /// <param name="provider"></param>
        public UserSeedDataInitializer(IServiceProvider provider)
            : base(provider)
        {
            _rootProvider = provider;
        }
        /// <summary>
        /// 是否存在查询表达式
        /// </summary>
        /// <param name="entity">比对实体</param>
        /// <returns>比对结果</returns>
        protected override Expression<Func<User, bool>> ExistingExpression(User entity)
        {
            return m => m.UserName == entity.UserName && m.NickName == entity.NickName;
        }

        /// <summary>
        /// 重写以提供要初始化的种子数据
        /// </summary>
        /// <returns></returns>
        protected override User[] SeedData(IServiceProvider provider)
        {
            using (var scope = _rootProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetService<UserManager<User>>();
                IConfiguration config = _rootProvider.GetService<IConfiguration>();

                User user = new User() { UserName = "ynkadmin", IsSystem = true, NickName = "超级管理员" };
                user.PasswordHash = userManager.PasswordHasher.HashPassword(user, config.GetValue<string>("Hosting:Pwd:Default"));
                return new[]
                {
                user
                };
            }
        }

        /// <summary>
        /// 将种子数据初始化到数据库
        /// </summary>
        /// <param name="entities"></param>
        protected override void SyncToDatabase(User[] entities, IServiceProvider provider)
        {
            if (entities?.Length > 0)
            {
                _rootProvider.BeginUnitOfWorkTransaction(provider =>
                {
                    UserManager<User> userManager = provider.GetService<UserManager<User>>();
                    foreach (User user in entities)
                    {
                        if (userManager.Users.Any(ExistingExpression(user)))
                        {
                            continue;
                        }
                        IdentityResult result = userManager.CreateAsync(user).Result;
                        if (!result.Succeeded)
                        {
                            throw new OsharpException($"进行角色种子数据“{user.UserName}”同步时出错：{result.ErrorMessage()}");
                        }
                    }
                });
            }
        }
    }
}
