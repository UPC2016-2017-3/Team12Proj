namespace 收银界面
{
    partial class parentForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dingdanGL = new System.Windows.Forms.Button();
            this.renyuanGL = new System.Windows.Forms.Button();
            this.shangpinGL = new System.Windows.Forms.Button();
            this.xianshikuang = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chaxunkuang = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.xiugaikuang = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.xianshikuang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dingdanGL);
            this.groupBox1.Controls.Add(this.renyuanGL);
            this.groupBox1.Controls.Add(this.shangpinGL);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 640);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TWELVE";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(336, 98);
            this.button5.TabIndex = 4;
            this.button5.Text = "切换用户";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dingdanGL
            // 
            this.dingdanGL.Location = new System.Drawing.Point(6, 271);
            this.dingdanGL.Name = "dingdanGL";
            this.dingdanGL.Size = new System.Drawing.Size(336, 98);
            this.dingdanGL.TabIndex = 2;
            this.dingdanGL.Text = "订单管理";
            this.dingdanGL.UseVisualStyleBackColor = true;
            this.dingdanGL.Click += new System.EventHandler(this.dingdanGL_Click);
            // 
            // renyuanGL
            // 
            this.renyuanGL.Location = new System.Drawing.Point(7, 156);
            this.renyuanGL.Name = "renyuanGL";
            this.renyuanGL.Size = new System.Drawing.Size(336, 98);
            this.renyuanGL.TabIndex = 1;
            this.renyuanGL.Text = "人员管理";
            this.renyuanGL.UseVisualStyleBackColor = true;
            this.renyuanGL.Click += new System.EventHandler(this.renyuanGL_Click);
            // 
            // shangpinGL
            // 
            this.shangpinGL.Location = new System.Drawing.Point(7, 37);
            this.shangpinGL.Name = "shangpinGL";
            this.shangpinGL.Size = new System.Drawing.Size(336, 98);
            this.shangpinGL.TabIndex = 0;
            this.shangpinGL.Text = "商品管理";
            this.shangpinGL.UseVisualStyleBackColor = true;
            this.shangpinGL.Click += new System.EventHandler(this.button1_Click);
            // 
            // xianshikuang
            // 
            this.xianshikuang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xianshikuang.Controls.Add(this.dataGridView1);
            this.xianshikuang.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xianshikuang.Location = new System.Drawing.Point(367, 424);
            this.xianshikuang.Name = "xianshikuang";
            this.xianshikuang.Size = new System.Drawing.Size(894, 228);
            this.xianshikuang.TabIndex = 2;
            this.xianshikuang.TabStop = false;
            this.xianshikuang.Text = "显示界面";
            this.xianshikuang.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(882, 198);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // chaxunkuang
            // 
            this.chaxunkuang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chaxunkuang.BackColor = System.Drawing.SystemColors.Control;
            this.chaxunkuang.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chaxunkuang.Location = new System.Drawing.Point(367, 12);
            this.chaxunkuang.Name = "chaxunkuang";
            this.chaxunkuang.Size = new System.Drawing.Size(894, 200);
            this.chaxunkuang.TabIndex = 3;
            this.chaxunkuang.TabStop = false;
            this.chaxunkuang.Text = "输入查询条件";
            this.chaxunkuang.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1273, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // xiugaikuang
            // 
            this.xiugaikuang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xiugaikuang.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xiugaikuang.Location = new System.Drawing.Point(367, 218);
            this.xiugaikuang.Name = "xiugaikuang";
            this.xiugaikuang.Size = new System.Drawing.Size(894, 200);
            this.xiugaikuang.TabIndex = 5;
            this.xiugaikuang.TabStop = false;
            this.xiugaikuang.Text = "信息修改更新";
            this.xiugaikuang.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // parentForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 680);
            this.Controls.Add(this.xiugaikuang);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chaxunkuang);
            this.Controls.Add(this.xianshikuang);
            this.Controls.Add(this.groupBox1);
            this.Name = "parentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.parentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.xianshikuang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button dingdanGL;
        private System.Windows.Forms.Button renyuanGL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.GroupBox chaxunkuang;
        public System.Windows.Forms.Button shangpinGL;
        public System.Windows.Forms.GroupBox xianshikuang;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox xiugaikuang;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}