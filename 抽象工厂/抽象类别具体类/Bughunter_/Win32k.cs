using DesignPattern.抽象工厂.抽象类别;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂.抽象类别具体类.Bughunter_
{
    public class Win32k : Bughunter
    {
        public override void BugGo()
        {
            Console.WriteLine("Bug win32k");
        }
    }
}
