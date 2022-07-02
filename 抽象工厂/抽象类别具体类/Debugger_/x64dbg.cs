using DesignPattern.抽象工厂.抽象类别;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂.抽象类别具体类.Debugger_
{
    public class x64dbg : Debugger
    {
        public override void DebugGo()
        {
            Console.WriteLine("debugger x64dbg");
        }
    }
}
