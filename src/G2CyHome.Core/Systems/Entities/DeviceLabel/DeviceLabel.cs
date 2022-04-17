using G2CyHome.Devices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Systems.Entities
{
    public partial class DeviceLabel
    {
        /// <summary>
        /// 设置设备导航属性
        /// </summary>
        public virtual DeviceRecord  Device { get; set; }
        /// <summary>
        /// 设置标签导航属性
        /// </summary>
        public virtual Label Label { get; set; }
    }
}
