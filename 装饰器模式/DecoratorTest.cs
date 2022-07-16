using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式
{
    internal class DecoratorTest : ITest
    {
        public void execute()
        {
            Phone phone = new ApplePhone();
            Decorator decorator = new Sticker(phone);
            decorator.Print();

        }
    }
}
