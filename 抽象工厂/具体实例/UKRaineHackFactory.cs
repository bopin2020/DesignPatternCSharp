using DesignPattern.抽象工厂.抽象类别;
using DesignPattern.抽象工厂.抽象类别具体类.Bughunter_;
using DesignPattern.抽象工厂.抽象类别具体类.Code_;
using DesignPattern.抽象工厂.抽象类别具体类.Debugger_;
using DesignPattern.抽象工厂.接口约束;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂.具体实例
{
    public class UKRaineHackFactory : HackFactory, IHackFactory
    {
        public override Bughunter CreateBughunter()
        {
            return new Win32k();
        }

        public override Code CreateCode()
        {
            return new C();
        }

        public override Debugger CreateDebugger()
        {
            return new x64dbg();
        }
    }

}
