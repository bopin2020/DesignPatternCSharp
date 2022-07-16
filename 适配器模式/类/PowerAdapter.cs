using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式.类
{
    /// <summary>
    /// 适配器类   提供三孔插头行为 - 本质上还是调用 TwoHole两孔插头功能
    /// </summary>
    internal class PowerAdapter : TwoHole, IThreeHole
    {
        public void Request()
        {
            // this.SpecialRequest();     // 类的适配器模式
            twoHole2.SpecialRequest();   // 对象的适配器模式
        }

        private TwoHole2 twoHole2 = new TwoHole2();
    }
}
