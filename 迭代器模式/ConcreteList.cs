using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.迭代器模式
{
    internal class ConcreteList : IListCollection
    {
        string[] collection;

        public ConcreteList()
        {
            collection = new string[]  { "a","b","c" };
        }

        public Iterator GetIterator()
        {
            // 要获取迭代器抽象类   就实现具体迭代器类 集合类作为参数传递进去
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return collection.Length; }
        }

        public string GetElement(int index)
        {
            return collection[index];
        }
    }
}
