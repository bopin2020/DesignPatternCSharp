using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.迭代器模式
{
    /// <summary>
    /// 抽象聚合类  获取抽象迭代器类
    /// </summary>
    public interface IListCollection
    {
        Iterator GetIterator();
    }
}
