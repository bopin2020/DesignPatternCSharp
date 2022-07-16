using DesignPattern.原型模式;
using DesignPattern.抽象工厂;
using DesignPattern.桥接器模式;
using DesignPattern.装饰器模式;
using DesignPattern.迭代器模式;
using DesignPattern.适配器模式;
using System;
using System.Collections.Generic;

namespace DesignPattern
{

    class Program
    {
        IDictionary<string, Type> typeRegister;

        public Program()
        {
            typeRegister = new Dictionary<string, Type>()
            {
                {"AbstractTest",typeof(AbstractTest)},
                {"PrototypeTest",typeof(PrototypeTest) },
                {"IteratorTest",typeof(IteratorTest) },
                {"AdapterTest",typeof(AdapterTest) },
                {"BridgeTest",typeof(BridgeTest) },
                {"DecoratorTest",typeof(DecoratorTest) },
            };
        }


        static void Main(string[] args)
        {
            new Program().Create("DecoratorTest").execute();
        }

        ITest Create(string name)
        {
            return Activator.CreateInstance(typeRegister.TryGetValue(name,out Type type) ? type : null,true) as ITest;
        }
    }
}
