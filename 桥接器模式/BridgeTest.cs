using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.桥接器模式
{
    /// <summary>
    /// http://static.kancloud.cn/wizardforcel/learning-hard-csharp/111565
    /// 抽象与功能分离
    /// </summary>
    internal class BridgeTest : ITest
    {
        public void execute()
        {
            RemoteControl remoteControl = new ConcreteRemote(new Samsung());
            // 也可以在调用属性前 初始化
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();
        }
    }
}
