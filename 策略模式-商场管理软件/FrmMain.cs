using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private double total = 0.0d;

        private void btnOK_Click(object sender, EventArgs e)
        {
            double totalPrices = 0d;
            switch (cbxType.SelectedIndex)
            {
                case 0:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
                    break;
                case 1:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text)*0.8;
                    break;
                case 2:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text)*0.7;
                    break;
                case 3:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text)*0.5;
                    break;
            }

            total += totalPrices;

            lbxList.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text +" "+cbxType.SelectedItem+ " 合计：" + totalPrices.ToString());
            lblResult.Text = total.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            total = 0.0d;
            txtNum.Text = "0";
            txtPrice.Text = "0.00";
            cbxType.SelectedIndex = 0;
            lbxList.Items.Clear();
            lblResult.Text = total.ToString("N2");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[]{"正常收费","打八折","打七折","打五折"});
            cbxType.SelectedIndex = 0;
        }
    }
}
