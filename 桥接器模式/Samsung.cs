using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.桥接器模式
{
    internal class Samsung : TV
    {
        public override void Off()
        {
            Console.WriteLine("三星遥控器关闭");
        }

        public override void On()
        {
            Console.WriteLine("三星遥控器打开");
        }

        public override void SetChannel()
        {
            Console.WriteLine("三星遥控器换台");
        }
    }
}
