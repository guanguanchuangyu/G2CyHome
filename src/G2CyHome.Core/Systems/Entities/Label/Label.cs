﻿using G2CyHome.Devices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Systems.Entities
{
    public partial class Label
    {
        /// <summary>
        /// 设备列表导航属性
        /// </summary>
        public virtual ICollection<DeviceRecord> Devices { get; set; }
        /// <summary>
        /// 设备标签关联列表导航属性
        /// </summary>
        public virtual ICollection<DeviceLabel> DeviceLabels { get; set; }
    }
}
