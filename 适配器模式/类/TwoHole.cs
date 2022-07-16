using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式.类
{
    /// <summary>
    /// 需要适配的类  源角色
    /// </summary>
    internal abstract class TwoHole
    {
        public void SpecialRequest()
        {
            Console.WriteLine("双孔插头");
        }
    }

    internal class TwoHole2
    {
        public void SpecialRequest()
        {
            Console.WriteLine("双孔插头");
        }
    }
}
