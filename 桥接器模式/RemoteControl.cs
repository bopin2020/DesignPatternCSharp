using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.桥接器模式
{
    internal class RemoteControl
    {
        public TV Implementor { get; set; }

        protected RemoteControl(TV tV)
        {
            Implementor = tV;
        }

        public virtual void SetChannel()
        {
            Implementor.SetChannel();
        }

        public virtual void Off()
        {
            Implementor.Off();
        }
        /// <summary>
        /// 抽象类不在实现具体的功能
        /// 而是调用实际功能类
        /// 类似与之前见一层层包装调用，其本质就是将功能实现与当前抽象类解耦。
        /// </summary>
        public virtual void On()
        {
            Implementor.On();
        }
    }

}
