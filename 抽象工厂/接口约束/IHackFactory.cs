using DesignPattern.抽象工厂.抽象类别;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂.接口约束
{
    public interface IHackFactory
    {
        Debugger CreateDebugger();

        Code CreateCode();

        Bughunter CreateBughunter();
    }
}
