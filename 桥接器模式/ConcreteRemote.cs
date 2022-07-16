using System;

namespace DesignPattern.桥接器模式
{
    internal class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("具体类 调用抽象类的Wrapper功能，实际调用的是功能类的方法");
            base.SetChannel();
        }

        public ConcreteRemote(TV tV) : base(tV)
        {
        }
    }
}