using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Devices.Entities
{
    public class BodyBits
    {
        /// <summary>
        /// 字节数组
        /// </summary>
        public byte[] Bits { get; set; }
        /// <summary>
        /// 数据长度
        /// </summary>
        public byte LengthBit
        {
            get
            {
                return (byte)Bits.Length;
            }
        }
    }
}
