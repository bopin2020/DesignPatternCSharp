using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.迭代器模式
{
    /// <summary>
    /// 具体迭代类   实现集合类的一个功能
    /// </summary>
    internal class ConcreteIterator : Iterator
    {
        // 引入集合对象
        private ConcreteList _list;
        private int _index;

        // 通过new 具体的迭代器类  将集合类作为参数传进去 (这就是上下文依赖关系)
        public ConcreteIterator(ConcreteList list)
        {
            _list = list;
            _index = 0;
        }

        public object GetCurrentObject()
        {
            return _list.GetElement(_index);
        }

        public bool MoveNext()
        {
            if(_index < _list.Count)
            {
                return true;
            }
            return false;
        }

        public void Next()
        {
            if(_index < _list.Count)
            {
                _index++;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
