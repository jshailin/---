using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式_商场管理软件
{
    /// <summary> 
    /// 现金收费工厂类
    /// 作者：jshailin 
    /// 建立时间：2018/6/24 18:36:23 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// CashFactory说明：本代码版权归海陵所有 
    /// 唯一标识：31b2904e-d555-47a2-b0cb-ad253d505339 
    /// </summary> 
    class CashFactory
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
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

            return cs;
        }
    }
}
