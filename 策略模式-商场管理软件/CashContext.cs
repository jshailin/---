using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式_商场管理软件
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/24 19:13:52 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// CashContext说明：本代码版权归海陵所有 
    /// 唯一标识：f67b8a33-ee84-4f21-954c-725df6d76074 
    /// </summary> 
    class CashContext
    {
        CashSuper cs = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打八折":
                    cs = new CashRebate("0.8");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
