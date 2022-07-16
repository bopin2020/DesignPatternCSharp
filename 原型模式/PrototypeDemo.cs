using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.原型模式
{
    internal class PrototypeDemo : PrototypeBase,ICloneable
    {
        public PrototypeDemo(Guid guid_, string name_) : base(guid_,name_) // 在抽象类中实例化 抽象类的字段
        {

        }

        public override PrototypeBase Clone()
        {
            // create a shallow copy of the current object
            // Object本地方法  直接操作二进制内存流
            return this.MemberwiseClone() as PrototypeBase;
        }

        /// <summary>
        /// 显示接口实现
        /// </summary>
        /// <returns></returns>
        object ICloneable.Clone()
        {
            return MemberwiseClone() as ICloneable;
        }
    }
}
