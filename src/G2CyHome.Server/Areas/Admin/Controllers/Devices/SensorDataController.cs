// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//     可以在此类进行继承重写来扩展基类 SensorDataControllerBase
// </once-generated>
//
// <copyright file="SensorData.cs" company="无">
//     
// </copyright>
// <site></site>
// <last-editor>ggcy</last-editor>
// -----------------------------------------------------------------------

using System;

using OSharp.Filter;

using G2CyHome.Devices;


namespace G2CyHome.Server.Areas.Admin.Controllers
{
    /// <summary>
    /// 管理控制器: 传感器数据信息
    /// </summary>
    public class SensorDataController : SensorDataControllerBase
    {
        /// <summary>
        /// 初始化一个<see cref="SensorDataController"/>类型的新实例
        /// </summary>
        public SensorDataController(IServiceProvider provider)
            : base(provider)
        { }
    }
}
