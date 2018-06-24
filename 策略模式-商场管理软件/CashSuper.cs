using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式_商场管理软件
{
    /// <summary> 
    /// 现金收费抽象类
    /// 作者：jshailin 
    /// 建立时间：2018/6/24 17:03:14 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// CashSuper说明：本代码版权归海陵所有 
    /// 唯一标识：6f1321af-8350-4d53-bbaa-d3eb620e42b7 
    /// </summary> 
    abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}
