using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 策略模式_商场管理软件
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：2018/6/24 15:42:49 
    /// 版权：2018-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// 策略模式_商场管理软件说明：本代码版权归海陵所有 
    /// 唯一标识：32931afb-50dd-4ff7-baba-b59a30146f11 
    /// </summary>
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
