using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Devices.Entities.Bits
{
    /// <summary>
    /// 插座
    /// </summary>
    public class DeviceOutlet : DeviceBase
    {
        public DeviceOutlet()
            :base()
        {
            
        }
        /// <summary>
        /// 设备类型
        /// </summary>
        public override DeviceType DeviceType => DeviceType.Outlet;
    }
}
