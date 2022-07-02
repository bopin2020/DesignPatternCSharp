using DesignPattern.抽象工厂.具体实例;
using DesignPattern.抽象工厂.抽象类别;
using DesignPattern.抽象工厂.接口约束;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂
{
    internal class AbstractTest
    {
        public static void execute()
        {
            // "ChineseHackFactory","UKRaineHackFactory"
            IHackFactory hackFactory = new ChineseHackFactory();
            Debugger debugger = hackFactory.CreateDebugger();
            Code code = hackFactory.CreateCode();
            Bughunter bughunter = hackFactory.CreateBughunter();
            debugger.DebugGo();
            code.CodeGo();
            bughunter.BugGo();


            IHackFactory uKRaineHackFactory = new UKRaineHackFactory();
            Debugger debugger2 = uKRaineHackFactory.CreateDebugger();
            Code code2 = uKRaineHackFactory.CreateCode();
            Bughunter bughunter2 = uKRaineHackFactory.CreateBughunter();
            debugger2.DebugGo();
            code2.CodeGo();
            bughunter2.BugGo();
        }
    }
}
