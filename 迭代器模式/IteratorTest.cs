using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.迭代器模式
{
    /// <summary>
    /// Credits to http://static.kancloud.cn/wizardforcel/learning-hard-csharp/111573
    /// </summary>
    internal class IteratorTest : ITest
    {
        public void execute()
        {
            Iterator iterator;
            IListCollection listCollection = new ConcreteList();
            iterator = listCollection.GetIterator();
            while (iterator.MoveNext()) // 迭代器类 具体实现 集合类的遍历功能
            {
                Console.WriteLine(iterator.GetCurrentObject().ToString());
                iterator.Next();
            }
        }
    }
}
