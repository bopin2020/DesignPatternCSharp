using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式.类
{
    /// <summary>
    /// 适配器模式中的目标角色   
    /// https://www.youtube.com/watch?v=Ley8Y5zdicM    适配器模式  在适配器类中引入适配角色(对象) - 提供数据。  适配器类继承了 适配目标
    /// </summary>
    internal interface IThreeHole
    {
        void Request();
    }
}
