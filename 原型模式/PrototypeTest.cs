using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.原型模式
{
    internal class PrototypeTest : ITest
    {
        public void execute()
        {
            PrototypeBase prototypeBase = new PrototypeDemo(Guid.NewGuid(), "原型模式");
            var tmp1 = prototypeBase.Clone();
            Console.WriteLine(tmp1.guid);
            var tmp2 = prototypeBase.Clone();
            Console.WriteLine(tmp2.guid);

            if(Object.ReferenceEquals(tmp1,tmp2))
            {
                Console.WriteLine("true");
            }    

        }
    }
}
