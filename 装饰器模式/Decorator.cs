using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式
{
    /// <summary>
    /// 装饰抽象类  装饰抽象类要完全取代抽象类 
    /// </summary>
    internal abstract class Decorator : Phone
    {
        private Phone _phone;
        public Decorator(Phone phone)
        {
            _phone = phone;
        }

        public override void Print()
        {
            if(_phone != null)
            {
                _phone.Print();
            }
        }
    }
}
