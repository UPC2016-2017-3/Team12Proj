namespace 收银界面
{
    partial class renyuanGL
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
            this.L11 = new System.Windows.Forms.Label();
            this.L12 = new System.Windows.Forms.Label();
            this.L13 = new System.Windows.Forms.Label();
            this.sousuoID = new System.Windows.Forms.TextBox();
            this.sousuoName = new System.Windows.Forms.TextBox();
            this.sousuozhiwei = new System.Windows.Forms.ComboBox();
            this.chaxun_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gengxinID = new System.Windows.Forms.TextBox();
            this.gengxinmingcheng = new System.Windows.Forms.TextBox();
            this.gengxinAge = new System.Windows.Forms.TextBox();
            this.gengxinzhiwei = new System.Windows.Forms.ComboBox();
            this.gengxinSex = new System.Windows.Forms.ComboBox();
            this.shanchu_bt = new System.Windows.Forms.Button();
            this.gengxin_bt = new System.Windows.Forms.Button();
            this.chaxunkuang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.xiugaikuang.SuspendLayout();
            this.SuspendLayout();
            // 
            // chaxunkuang
            // 
            this.chaxunkuang.Controls.Add(this.chaxun_bt);
            this.chaxunkuang.Controls.Add(this.sousuozhiwei);
            this.chaxunkuang.Controls.Add(this.sousuoName);
            this.chaxunkuang.Controls.Add(this.sousuoID);
            this.chaxunkuang.Controls.Add(this.L13);
            this.chaxunkuang.Controls.Add(this.L12);
            this.chaxunkuang.Controls.Add(this.L11);
            this.groupBox1.Controls.SetChildIndex(this.shangpinGL, 0);
            // 
            // xiugaikuang
            // 
            this.xiugaikuang.Controls.Add(this.gengxin_bt);
            this.xiugaikuang.Controls.Add(this.shanchu_bt);
            this.xiugaikuang.Controls.Add(this.gengxinSex);
            this.xiugaikuang.Controls.Add(this.gengxinzhiwei);
            this.xiugaikuang.Controls.Add(this.gengxinAge);
            this.xiugaikuang.Controls.Add(this.gengxinmingcheng);
            this.xiugaikuang.Controls.Add(this.gengxinID);
            this.xiugaikuang.Controls.Add(this.label5);
            this.xiugaikuang.Controls.Add(this.label4);
            this.xiugaikuang.Controls.Add(this.label3);
            this.xiugaikuang.Controls.Add(this.label2);
            this.xiugaikuang.Controls.Add(this.label1);
            // 
            // L11
            // 
            this.L11.AutoSize = true;
            this.L11.Location = new System.Drawing.Point(42, 86);
            this.L11.Name = "L11";
            this.L11.Size = new System.Drawing.Size(85, 19);
            this.L11.TabIndex = 0;
            this.L11.Text = "人员编号";
            // 
            // L12
            // 
            this.L12.AutoSize = true;
            this.L12.Location = new System.Drawing.Point(271, 86);
            this.L12.Name = "L12";
            this.L12.Size = new System.Drawing.Size(85, 19);
            this.L12.TabIndex = 1;
            this.L12.Text = "人员名称";
            // 
            // L13
            // 
            this.L13.AutoSize = true;
            this.L13.Location = new System.Drawing.Point(514, 86);
            this.L13.Name = "L13";
            this.L13.Size = new System.Drawing.Size(47, 19);
            this.L13.TabIndex = 2;
            this.L13.Text = "职位";
            // 
            // sousuoID
            // 
            this.sousuoID.Location = new System.Drawing.Point(142, 80);
            this.sousuoID.Name = "sousuoID";
            this.sousuoID.Size = new System.Drawing.Size(100, 28);
            this.sousuoID.TabIndex = 3;
            this.sousuoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sousuoID_KeyPress);
            // 
            // sousuoName
            // 
            this.sousuoName.Location = new System.Drawing.Point(375, 80);
            this.sousuoName.Name = "sousuoName";
            this.sousuoName.Size = new System.Drawing.Size(100, 28);
            this.sousuoName.TabIndex = 4;
            // 
            // sousuozhiwei
            // 
            this.sousuozhiwei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sousuozhiwei.FormattingEnabled = true;
            this.sousuozhiwei.Items.AddRange(new object[] {
            "所有类型",
            "boss",
            "管理员",
            "服务员",
            "后厨"});
            this.sousuozhiwei.Location = new System.Drawing.Point(572, 82);
            this.sousuozhiwei.Name = "sousuozhiwei";
            this.sousuozhiwei.Size = new System.Drawing.Size(121, 26);
            this.sousuozhiwei.TabIndex = 5;
            // 
            // chaxun_bt
            // 
            this.chaxun_bt.Location = new System.Drawing.Point(734, 80);
            this.chaxun_bt.Name = "chaxun_bt";
            this.chaxun_bt.Size = new System.Drawing.Size(75, 30);
            this.chaxun_bt.TabIndex = 6;
            this.chaxun_bt.Text = "搜索";
            this.chaxun_bt.UseVisualStyleBackColor = true;
            this.chaxun_bt.Click += new System.EventHandler(this.chaxun_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "人员编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "人员名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "职位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "年龄";
            // 
            // gengxinID
            // 
            this.gengxinID.Location = new System.Drawing.Point(149, 35);
            this.gengxinID.Name = "gengxinID";
            this.gengxinID.Size = new System.Drawing.Size(100, 28);
            this.gengxinID.TabIndex = 5;
            this.gengxinID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gengxinID_KeyPress);
            // 
            // gengxinmingcheng
            // 
            this.gengxinmingcheng.Location = new System.Drawing.Point(352, 35);
            this.gengxinmingcheng.Name = "gengxinmingcheng";
            this.gengxinmingcheng.Size = new System.Drawing.Size(152, 28);
            this.gengxinmingcheng.TabIndex = 6;
            // 
            // gengxinAge
            // 
            this.gengxinAge.Location = new System.Drawing.Point(354, 104);
            this.gengxinAge.Name = "gengxinAge";
            this.gengxinAge.Size = new System.Drawing.Size(100, 28);
            this.gengxinAge.TabIndex = 7;
            this.gengxinAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gengxinAge_KeyPress);
            // 
            // gengxinzhiwei
            // 
            this.gengxinzhiwei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gengxinzhiwei.FormattingEnabled = true;
            this.gengxinzhiwei.Items.AddRange(new object[] {
            "所有类型",
            "boss",
            "管理员",
            "前台",
            "服务员",
            "后厨"});
            this.gengxinzhiwei.Location = new System.Drawing.Point(575, 34);
            this.gengxinzhiwei.Name = "gengxinzhiwei";
            this.gengxinzhiwei.Size = new System.Drawing.Size(121, 26);
            this.gengxinzhiwei.TabIndex = 8;
            // 
            // gengxinSex
            // 
            this.gengxinSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gengxinSex.FormattingEnabled = true;
            this.gengxinSex.Items.AddRange(new object[] {
            "其他",
            "男",
            "女"});
            this.gengxinSex.Location = new System.Drawing.Point(128, 106);
            this.gengxinSex.Name = "gengxinSex";
            this.gengxinSex.Size = new System.Drawing.Size(121, 26);
            this.gengxinSex.TabIndex = 9;
            // 
            // shanchu_bt
            // 
            this.shanchu_bt.Location = new System.Drawing.Point(540, 104);
            this.shanchu_bt.Name = "shanchu_bt";
            this.shanchu_bt.Size = new System.Drawing.Size(75, 30);
            this.shanchu_bt.TabIndex = 10;
            this.shanchu_bt.Text = "删除";
            this.shanchu_bt.UseVisualStyleBackColor = true;
            this.shanchu_bt.Click += new System.EventHandler(this.shanchu_bt_Click);
            // 
            // gengxin_bt
            // 
            this.gengxin_bt.Location = new System.Drawing.Point(696, 104);
            this.gengxin_bt.Name = "gengxin_bt";
            this.gengxin_bt.Size = new System.Drawing.Size(120, 30);
            this.gengxin_bt.TabIndex = 11;
            this.gengxin_bt.Text = "修改/新增";
            this.gengxin_bt.UseVisualStyleBackColor = true;
            this.gengxin_bt.Click += new System.EventHandler(this.gengxin_bt_Click);
            // 
            // renyuanGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 689);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "renyuanGL";
            this.Text = "人员管理";
            this.Load += new System.EventHandler(this.renyuanGL_Load);
            this.chaxunkuang.ResumeLayout(false);
            this.chaxunkuang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.xiugaikuang.ResumeLayout(false);
            this.xiugaikuang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L11;
        private System.Windows.Forms.Label L13;
        private System.Windows.Forms.Label L12;
        private System.Windows.Forms.ComboBox sousuozhiwei;
        private System.Windows.Forms.TextBox sousuoName;
        private System.Windows.Forms.TextBox sousuoID;
        private System.Windows.Forms.Button chaxun_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gengxinSex;
        private System.Windows.Forms.ComboBox gengxinzhiwei;
        private System.Windows.Forms.TextBox gengxinAge;
        private System.Windows.Forms.TextBox gengxinmingcheng;
        private System.Windows.Forms.TextBox gengxinID;
        private System.Windows.Forms.Button gengxin_bt;
        private System.Windows.Forms.Button shanchu_bt;
    }
}