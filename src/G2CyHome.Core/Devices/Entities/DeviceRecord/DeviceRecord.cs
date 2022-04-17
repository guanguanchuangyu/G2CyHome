using G2CyHome.Systems.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Devices.Entities
{
    public partial class DeviceRecord
    {
        /// <summary>
        /// 添加标签列表导航属性
        /// </summary>
        public virtual ICollection<Label> Labels { get; set; }
        /// <summary>
        /// 添加所属房间导航属性
        /// </summary>
        public virtual Room Room { get; set; }
    }
}
