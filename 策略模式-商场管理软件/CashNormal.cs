using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式_商场管理软件
{
    /// <summary> 
    /// 正常收费子类
    /// 作者：jshailin 
    /// 建立时间：2018/6/24 17:09:02 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// CashNormal说明：本代码版权归海陵所有 
    /// 唯一标识：79eb4cfd-ae68-48fc-be24-776ce6a3a0ab 
    /// </summary> 
    class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
