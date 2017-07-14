namespace 收银界面
{
    partial class dingdanGL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.zhuhao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.renshu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.TextBox();
            this.chaxun_bt = new System.Windows.Forms.Button();
            this.chaxunkuang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chaxunkuang
            // 
            this.chaxunkuang.Controls.Add(this.chaxun_bt);
            this.chaxunkuang.Controls.Add(this.time2);
            this.chaxunkuang.Controls.Add(this.label4);
            this.chaxunkuang.Controls.Add(this.time1);
            this.chaxunkuang.Controls.Add(this.label3);
            this.chaxunkuang.Controls.Add(this.renshu);
            this.chaxunkuang.Controls.Add(this.label2);
            this.chaxunkuang.Controls.Add(this.zhuhao);
            this.chaxunkuang.Controls.Add(this.label1);
            this.groupBox1.Controls.SetChildIndex(this.shangpinGL, 0);
            // 
            // xiugaikuang
            // 
            this.xiugaikuang.Enter += new System.EventHandler(this.xiugaikuang_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "桌号";
            // 
            // zhuhao
            // 
            this.zhuhao.Location = new System.Drawing.Point(143, 72);
            this.zhuhao.Name = "zhuhao";
            this.zhuhao.Size = new System.Drawing.Size(100, 28);
            this.zhuhao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "人数";
            // 
            // renshu
            // 
            this.renshu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renshu.FormattingEnabled = true;
            this.renshu.Items.AddRange(new object[] {
            "所有",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.renshu.Location = new System.Drawing.Point(369, 74);
            this.renshu.Name = "renshu";
            this.renshu.Size = new System.Drawing.Size(121, 26);
            this.renshu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "时间  从";
            // 
            // time1
            // 
            this.time1.Location = new System.Drawing.Point(143, 132);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(130, 28);
            this.time1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "到";
            // 
            // time2
            // 
            this.time2.Location = new System.Drawing.Point(369, 132);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(130, 28);
            this.time2.TabIndex = 7;
            // 
            // chaxun_bt
            // 
            this.chaxun_bt.Location = new System.Drawing.Point(593, 129);
            this.chaxun_bt.Name = "chaxun_bt";
            this.chaxun_bt.Size = new System.Drawing.Size(75, 30);
            this.chaxun_bt.TabIndex = 8;
            this.chaxun_bt.Text = "查询";
            this.chaxun_bt.UseVisualStyleBackColor = true;
            this.chaxun_bt.Click += new System.EventHandler(this.chaxun_bt_Click);
            // 
            // dingdanGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 688);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "dingdanGL";
            this.Text = "订单管理";
            this.Load += new System.EventHandler(this.dingdanGL_Load);
            this.chaxunkuang.ResumeLayout(false);
            this.chaxunkuang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zhuhao;
        private System.Windows.Forms.ComboBox renshu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox time2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.Button chaxun_bt;
    }
}