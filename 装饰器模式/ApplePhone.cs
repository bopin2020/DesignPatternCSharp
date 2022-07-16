using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式
{
    internal class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("执行抽象组件的具体类 苹果手机");
        }
    }
}
