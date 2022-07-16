using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式
{
    /// <summary>
    /// 装饰功能 通过 创建另一个抽象类，然后以原来的抽象类解耦  这样不会对原来类形成子类爆炸效果
    /// </summary>
    internal class Sticker : Decorator
    {
        public Sticker(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();

            // 添加装饰
            AddSticker();
        }

        public void AddSticker()
        {
            Console.WriteLine("苹果手机贴膜");
        }
    }
}
