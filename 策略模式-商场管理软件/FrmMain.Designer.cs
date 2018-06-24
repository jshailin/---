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
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "单价：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(76, 14);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(129, 29);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(241, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 21;
            this.lbxList.Location = new System.Drawing.Point(12, 84);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(304, 109);
            this.lbxList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "数量：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(76, 49);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(129, 29);
            this.txtNum.TabIndex = 2;
            this.txtNum.Text = "0";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(241, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "总计：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(105, 215);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 33);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0.00";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 276);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMain";
            this.Text = "商场管理软件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
    }
}

