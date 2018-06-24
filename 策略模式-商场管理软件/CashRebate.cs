using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式_商场管理软件
{
    /// <summary> 
    /// 打折收费子类
    /// 作者：jshailin 
    /// 建立时间：2018/6/24 17:11:04 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// CashRebate说明：本代码版权归海陵所有 
    /// 唯一标识：cfcd360a-4316-473d-b3d7-b1576c2101a3 
    /// </summary> 
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
