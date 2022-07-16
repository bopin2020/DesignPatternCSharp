using DesignPattern.适配器模式.类;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式
{
    // http://static.kancloud.cn/wizardforcel/learning-hard-csharp/111564
    internal class AdapterTest : ITest
    {
        public void execute()
        {
            IThreeHole threeHole = new PowerAdapter();
            threeHole.Request();
        }
    }
}
