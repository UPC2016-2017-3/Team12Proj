namespace 收银界面
{
    partial class shangpinGL
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bianhao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mingcheng = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.leixing = new System.Windows.Forms.ComboBox();
            this.sousuo = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.jiage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gengxin = new System.Windows.Forms.Button();
            this.shanchu = new System.Windows.Forms.Button();
            this.SID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gengxinID = new System.Windows.Forms.TextBox();
            this.gengxinmingcheng = new System.Windows.Forms.TextBox();
            this.gengxinleixing = new System.Windows.Forms.ComboBox();
            this.shanchu_bt = new System.Windows.Forms.Button();
            this.gengxinjiage = new System.Windows.Forms.TextBox();
            this.gengxin_bt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.chaxunkuang.SuspendLayout();
            this.xiugaikuang.SuspendLayout();
            this.SuspendLayout();
            // 
            // chaxunkuang
            // 
            this.chaxunkuang.Controls.Add(this.sousuo);
            this.chaxunkuang.Controls.Add(this.leixing);
            this.chaxunkuang.Controls.Add(this.label8);
            this.chaxunkuang.Controls.Add(this.mingcheng);
            this.chaxunkuang.Controls.Add(this.label7);
            this.chaxunkuang.Controls.Add(this.label6);
            this.chaxunkuang.Controls.Add(this.bianhao);
            this.chaxunkuang.Controls.Add(this.label5);
            this.chaxunkuang.Text = "t";
            this.chaxunkuang.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // xiugaikuang
            // 
            this.xiugaikuang.Controls.Add(this.label13);
            this.xiugaikuang.Controls.Add(this.gengxin_bt);
            this.xiugaikuang.Controls.Add(this.gengxinjiage);
            this.xiugaikuang.Controls.Add(this.shanchu_bt);
            this.xiugaikuang.Controls.Add(this.gengxinleixing);
            this.xiugaikuang.Controls.Add(this.gengxinmingcheng);
            this.xiugaikuang.Controls.Add(this.gengxinID);
            this.xiugaikuang.Controls.Add(this.label12);
            this.xiugaikuang.Controls.Add(this.label11);
            this.xiugaikuang.Controls.Add(this.label10);
            this.xiugaikuang.Controls.Add(this.SID);
            this.xiugaikuang.Text = "更新修改";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "类型";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "主食",
            "菜品",
            "饮品"});
            this.comboBox1.Location = new System.Drawing.Point(520, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "商品编号";
            // 
            // bianhao
            // 
            this.bianhao.Location = new System.Drawing.Point(129, 81);
            this.bianhao.Name = "bianhao";
            this.bianhao.Size = new System.Drawing.Size(100, 28);
            this.bianhao.TabIndex = 1;
            this.bianhao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bianhao_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "输入查询条件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "商品名称";
            // 
            // mingcheng
            // 
            this.mingcheng.Location = new System.Drawing.Point(343, 80);
            this.mingcheng.Name = "mingcheng";
            this.mingcheng.Size = new System.Drawing.Size(100, 28);
            this.mingcheng.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "商品类型";
            // 
            // leixing
            // 
            this.leixing.AutoCompleteCustomSource.AddRange(new string[] {
            "菜品",
            "主食",
            "饮品"});
            this.leixing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leixing.FormattingEnabled = true;
            this.leixing.Items.AddRange(new object[] {
            "所有类型",
            "菜品",
            "主食",
            "饮品"});
            this.leixing.Location = new System.Drawing.Point(581, 79);
            this.leixing.Name = "leixing";
            this.leixing.Size = new System.Drawing.Size(121, 26);
            this.leixing.TabIndex = 8;
            this.leixing.SelectedIndexChanged += new System.EventHandler(this.leixing_SelectedIndexChanged);
            // 
            // sousuo
            // 
            this.sousuo.Location = new System.Drawing.Point(733, 77);
            this.sousuo.Name = "sousuo";
            this.sousuo.Size = new System.Drawing.Size(75, 30);
            this.sousuo.TabIndex = 8;
            this.sousuo.Text = "搜索";
            this.sousuo.UseVisualStyleBackColor = true;
            this.sousuo.Click += new System.EventHandler(this.sousuo_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(164, 144);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(89, 19);
            this.L1.TabIndex = 9;
            this.L1.Text = "商品价格";
            // 
            // jiage
            // 
            this.jiage.Location = new System.Drawing.Point(273, 135);
            this.jiage.Name = "jiage";
            this.jiage.Size = new System.Drawing.Size(100, 25);
            this.jiage.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "元";
            // 
            // gengxin
            // 
            this.gengxin.Location = new System.Drawing.Point(609, 119);
            this.gengxin.Name = "gengxin";
            this.gengxin.Size = new System.Drawing.Size(75, 30);
            this.gengxin.TabIndex = 12;
            this.gengxin.Text = "更新";
            this.gengxin.UseVisualStyleBackColor = true;
            // 
            // shanchu
            // 
            this.shanchu.Location = new System.Drawing.Point(735, 132);
            this.shanchu.Name = "shanchu";
            this.shanchu.Size = new System.Drawing.Size(75, 30);
            this.shanchu.TabIndex = 13;
            this.shanchu.Text = "删除";
            this.shanchu.UseVisualStyleBackColor = true;
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(29, 56);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(85, 19);
            this.SID.TabIndex = 0;
            this.SID.Text = "商品编号";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "商品名称";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "商品类型";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "商品价格";
            // 
            // gengxinID
            // 
            this.gengxinID.Location = new System.Drawing.Point(120, 53);
            this.gengxinID.Name = "gengxinID";
            this.gengxinID.Size = new System.Drawing.Size(100, 28);
            this.gengxinID.TabIndex = 4;
            this.gengxinID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gengxinID_KeyPress);
            // 
            // gengxinmingcheng
            // 
            this.gengxinmingcheng.Location = new System.Drawing.Point(334, 53);
            this.gengxinmingcheng.Name = "gengxinmingcheng";
            this.gengxinmingcheng.Size = new System.Drawing.Size(100, 28);
            this.gengxinmingcheng.TabIndex = 5;
            // 
            // gengxinleixing
            // 
            this.gengxinleixing.BackColor = System.Drawing.SystemColors.Window;
            this.gengxinleixing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gengxinleixing.FormattingEnabled = true;
            this.gengxinleixing.Items.AddRange(new object[] {
            "所有类型",
            "菜品",
            "主食",
            "饮品"});
            this.gengxinleixing.Location = new System.Drawing.Point(572, 53);
            this.gengxinleixing.Name = "gengxinleixing";
            this.gengxinleixing.Size = new System.Drawing.Size(121, 26);
            this.gengxinleixing.TabIndex = 6;
            this.gengxinleixing.SelectedIndexChanged += new System.EventHandler(this.gengxinleixing_SelectedIndexChanged);
            // 
            // shanchu_bt
            // 
            this.shanchu_bt.Location = new System.Drawing.Point(359, 119);
            this.shanchu_bt.Name = "shanchu_bt";
            this.shanchu_bt.Size = new System.Drawing.Size(75, 30);
            this.shanchu_bt.TabIndex = 7;
            this.shanchu_bt.Text = "删除";
            this.shanchu_bt.UseVisualStyleBackColor = true;
            this.shanchu_bt.Click += new System.EventHandler(this.shanchu_bt_Click);
            // 
            // gengxinjiage
            // 
            this.gengxinjiage.Location = new System.Drawing.Point(120, 122);
            this.gengxinjiage.Name = "gengxinjiage";
            this.gengxinjiage.Size = new System.Drawing.Size(100, 28);
            this.gengxinjiage.TabIndex = 8;
            this.gengxinjiage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gengxinjiage_KeyPress);
            // 
            // gengxin_bt
            // 
            this.gengxin_bt.Location = new System.Drawing.Point(573, 120);
            this.gengxin_bt.Name = "gengxin_bt";
            this.gengxin_bt.Size = new System.Drawing.Size(120, 30);
            this.gengxin_bt.TabIndex = 9;
            this.gengxin_bt.Text = "修改/新增";
            this.gengxin_bt.UseVisualStyleBackColor = true;
            this.gengxin_bt.Click += new System.EventHandler(this.gengxin_bt_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(226, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "元";
            // 
            // shangpinGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 689);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "shangpinGL";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.shangpinGL_Load);
            this.chaxunkuang.ResumeLayout(false);
            this.chaxunkuang.PerformLayout();
            this.xiugaikuang.ResumeLayout(false);
            this.xiugaikuang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bianhao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox leixing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mingcheng;
        private System.Windows.Forms.Button sousuo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jiage;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Button shanchu;
        private System.Windows.Forms.Button gengxin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button gengxin_bt;
        private System.Windows.Forms.TextBox gengxinjiage;
        private System.Windows.Forms.Button shanchu_bt;
        private System.Windows.Forms.ComboBox gengxinleixing;
        private System.Windows.Forms.TextBox gengxinmingcheng;
        private System.Windows.Forms.TextBox gengxinID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SID;
    }
}