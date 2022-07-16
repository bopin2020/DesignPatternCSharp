using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.原型模式
{
    public abstract class PrototypeBase
    {
        public Guid guid { get; set; }

        public string name { get; set; }

        public PrototypeBase()
        {
        }

        public PrototypeBase(Guid guid_,string name_)
        {
            guid = guid_;
            name = name_;
        }

        public abstract PrototypeBase Clone();
    }
}
