using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Devices.Entities
{
    public partial class SensorData
    {
        /// <summary>
        /// 添加设备导航属性
        /// </summary>
        public virtual DeviceRecord Device { get; set; }
    }
}
