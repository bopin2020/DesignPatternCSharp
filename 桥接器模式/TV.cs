using System;

namespace DesignPattern.桥接器模式
{
    public abstract class TV
    {
        public abstract void SetChannel();

        public abstract void Off();

        public abstract void On();
    }
}