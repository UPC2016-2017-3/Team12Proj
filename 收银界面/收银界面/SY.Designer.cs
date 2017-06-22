namespace 收银界面
{
    partial class SY
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
            this.chaxunBox1 = new System.Windows.Forms.GroupBox();
            this.zhuohao = new System.Windows.Forms.Label();
            this.aDataSet = new 系统主界面.ADataSet();
            this.dingdanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dingdanTableAdapter = new 系统主界面.ADataSetTableAdapters.dingdanTableAdapter();
            this.caozuoBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zhuBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chaxunBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dingdanBindingSource)).BeginInit();
            this.caozuoBox1.SuspendLayout();
            this.zhuBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chaxunBox1
            // 
            this.chaxunBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chaxunBox1.BackColor = System.Drawing.Color.Khaki;
            this.chaxunBox1.Controls.Add(this.label3);
            this.chaxunBox1.Controls.Add(this.label2);
            this.chaxunBox1.Controls.Add(this.dataGridView1);
            this.chaxunBox1.Controls.Add(this.label1);
            this.chaxunBox1.Controls.Add(this.zhuohao);
            this.chaxunBox1.Location = new System.Drawing.Point(3, 71);
            this.chaxunBox1.Name = "chaxunBox1";
            this.chaxunBox1.Size = new System.Drawing.Size(798, 296);
            this.chaxunBox1.TabIndex = 1;
            this.chaxunBox1.TabStop = false;
            this.chaxunBox1.Enter += new System.EventHandler(this.chaxunBox1_Enter);
            // 
            // zhuohao
            // 
            this.zhuohao.AutoSize = true;
            this.zhuohao.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhuohao.Location = new System.Drawing.Point(156, 17);
            this.zhuohao.Name = "zhuohao";
            this.zhuohao.Size = new System.Drawing.Size(69, 20);
            this.zhuohao.TabIndex = 0;
            this.zhuohao.Text = "桌号：";
            this.zhuohao.Click += new System.EventHandler(this.zhuohao_Click);
            // 
            // aDataSet
            // 
            this.aDataSet.DataSetName = "ADataSet";
            this.aDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dingdanBindingSource
            // 
            this.dingdanBindingSource.DataMember = "dingdan";
            this.dingdanBindingSource.DataSource = this.aDataSet;
            // 
            // dingdanTableAdapter
            // 
            this.dingdanTableAdapter.ClearBeforeFill = true;
            // 
            // caozuoBox1
            // 
            this.caozuoBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caozuoBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.caozuoBox1.Controls.Add(this.dateTimePicker1);
            this.caozuoBox1.Controls.Add(this.button6);
            this.caozuoBox1.Controls.Add(this.button5);
            this.caozuoBox1.Controls.Add(this.button4);
            this.caozuoBox1.Controls.Add(this.button3);
            this.caozuoBox1.Controls.Add(this.button2);
            this.caozuoBox1.Controls.Add(this.button1);
            this.caozuoBox1.Location = new System.Drawing.Point(3, 373);
            this.caozuoBox1.Name = "caozuoBox1";
            this.caozuoBox1.Size = new System.Drawing.Size(958, 73);
            this.caozuoBox1.TabIndex = 2;
            this.caozuoBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(836, 35);
            this.dateTimePicker1.MaxDate = new System.DateTime(2017, 6, 22, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2017, 6, 22, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(549, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "刷新";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(443, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "返回";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "撤销结账";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "打印消费单";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "结账";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "催菜";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // zhuBox1
            // 
            this.zhuBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zhuBox1.BackColor = System.Drawing.Color.Thistle;
            this.zhuBox1.Controls.Add(this.tableLayoutPanel1);
            this.zhuBox1.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhuBox1.Location = new System.Drawing.Point(494, 71);
            this.zhuBox1.Name = "zhuBox1";
            this.zhuBox1.Size = new System.Drawing.Size(467, 296);
            this.zhuBox1.TabIndex = 3;
            this.zhuBox1.TabStop = false;
            this.zhuBox1.Text = "桌台状态显示";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button10.Location = new System.Drawing.Point(898, 39);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 20);
            this.button10.TabIndex = 3;
            this.button10.Text = "注销";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.Location = new System.Drawing.Point(203, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 44);
            this.button9.TabIndex = 2;
            this.button9.Text = "报表";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button8.Location = new System.Drawing.Point(106, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 44);
            this.button8.TabIndex = 1;
            this.button8.Text = "开台";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 44);
            this.button7.TabIndex = 0;
            this.button7.Text = "桌台";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button20, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button19, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button18, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button17, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button16, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button15, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 220);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "单  ：";
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 47);
            this.button11.TabIndex = 0;
            this.button11.Text = "桌1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(783, 125);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "人数：";
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(93, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 47);
            this.button12.TabIndex = 1;
            this.button12.Text = "桌2";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(182, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 47);
            this.button13.TabIndex = 2;
            this.button13.Text = "桌3";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Location = new System.Drawing.Point(271, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 47);
            this.button14.TabIndex = 3;
            this.button14.Text = "桌4";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(360, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(86, 47);
            this.button15.TabIndex = 4;
            this.button15.Text = "桌5";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(4, 58);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 47);
            this.button16.TabIndex = 5;
            this.button16.Text = "桌6";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Location = new System.Drawing.Point(93, 58);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 47);
            this.button17.TabIndex = 6;
            this.button17.Text = "桌7";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Location = new System.Drawing.Point(182, 58);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 47);
            this.button18.TabIndex = 7;
            this.button18.Text = "桌8";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Location = new System.Drawing.Point(271, 58);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(82, 47);
            this.button19.TabIndex = 8;
            this.button19.Text = "桌9";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Location = new System.Drawing.Point(360, 58);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(86, 47);
            this.button20.TabIndex = 9;
            this.button20.Text = "桌10";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(221, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "  ";
            // 
            // SY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zhuBox1);
            this.Controls.Add(this.caozuoBox1);
            this.Controls.Add(this.chaxunBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SY";
            this.Text = "欢迎使用收银台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SY_Load);
            this.chaxunBox1.ResumeLayout(false);
            this.chaxunBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dingdanBindingSource)).EndInit();
            this.caozuoBox1.ResumeLayout(false);
            this.zhuBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chaxunBox1;
        private 系统主界面.ADataSet aDataSet;
        private System.Windows.Forms.BindingSource dingdanBindingSource;
        private 系统主界面.ADataSetTableAdapters.dingdanTableAdapter dingdanTableAdapter;
        private System.Windows.Forms.GroupBox caozuoBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox zhuBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label zhuohao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label3;

    }
}