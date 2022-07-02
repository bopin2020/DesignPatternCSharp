using DesignPattern.抽象工厂.抽象类别;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂.接口约束
{


    /// <summary>
    /// 抽象工厂 抽象的是一种创建对象的规范
    /// </summary>
    public abstract class HackFactory
    {
        public abstract Debugger CreateDebugger();
        public abstract Code CreateCode();
        public abstract Bughunter CreateBughunter();
    }
}