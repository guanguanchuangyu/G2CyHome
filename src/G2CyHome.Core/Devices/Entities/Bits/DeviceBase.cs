using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2CyHome.Devices.Entities
{
    /// <summary>
    /// 设备基类
    /// </summary>
    public abstract class DeviceBase : IDeviceAction
    {
        /// <summary>
        /// 无参构造类型
        /// </summary>
        public DeviceBase()
        {
            StartBit = new StartBits {  Bits = new byte[] { 0xFF } };
            IdentityBit = new IdentityBits();
            BodyBit = new BodyBits();
        }
        /// <summary>
        /// 起始帧
        /// </summary>
        public virtual StartBits StartBit { get; }
        /// <summary>
        /// 设备标识
        /// </summary>
        public virtual IdentityBits IdentityBit { get;}
        /// <summary>
        /// 设备类型
        /// </summary>
        public abstract DeviceType DeviceType { get;}
        /// <summary>
        /// 控制类型
        /// </summary>
        public virtual byte CtlBit { get; set; }
        /// <summary>
        /// 数据Body
        /// </summary>
        public virtual BodyBits BodyBit { get; }
        /// <summary>
        /// 通信完整数据
        /// </summary>
        /// <returns>完整通信集合</returns>
        public virtual byte[] GetAllBits()
        { 
            List<byte> result = new List<byte>();
            // 添加头部帧
            result.AddRange(StartBit.Bits);
            // 缓存byte集合
            List<byte> bits = new List<byte>();
            // 设备类型帧
            bits.Add((byte)DeviceType);
            // 设备ID帧
            bits.AddRange(IdentityBit.Bits);
            // 控制类型帧
            bits.Add(CtlBit);
            //数据长度帧数
            bits.Add(BodyBit.LengthBit);
            // 数据帧
            bits.AddRange(BodyBit.Bits);
            // 校验帧
            bits.Add(CheckBits(bits));
            // 添加剩余数据帧
            result.AddRange(bits);
            return result.ToArray();
        }
        /// <summary>
        /// 校验字节位
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public virtual byte CheckBits(List<byte> bits)
        {
            byte sum = 0;
            foreach (byte bit in bits)
            {
                sum += bit;
            }
            return sum;
        }
    }
}
