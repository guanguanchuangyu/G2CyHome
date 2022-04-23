using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Devices.Entities
{
    /// <summary>
    /// 设备交互
    /// </summary>
    public interface IDeviceAction
    {
        /// <summary>
        /// 起始帧
        /// </summary>
        public StartBits StartBit { get; }
        /// <summary>
        /// 设备标识
        /// </summary>
        public IdentityBits IdentityBit { get; }
        /// <summary>
        /// 设备类型
        /// </summary>
        public Devicetype DeviceType { get; }
        /// <summary>
        /// 控制类型
        /// </summary>
        public byte CtlBit { get; set; }
        /// <summary>
        /// 数据Body
        /// </summary>
        public BodyBits BodyBit { get; }
        /// <summary>
        /// 通信完整数据
        /// </summary>
        /// <returns>完整通信集合</returns>
        byte[] GetAllBits();
        /// <summary>
        /// 校验字节位
        /// </summary>
        /// <param name="bits"></param>
        /// <returns>校验字节值</returns>
        public byte CheckBits(List<byte> bits);
    }
}
