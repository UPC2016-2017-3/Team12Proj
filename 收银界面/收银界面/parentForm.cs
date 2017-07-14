using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 收银界面
{
    public partial class parentForm : Form
    {
        public parentForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void parentForm_Load(object sender, EventArgs e)
        {
            //程序加载时在状态栏显示时间
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        shangpinGL f1;//实例化窗口shangpinGL
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1 = new shangpinGL();//窗口实例化
            f1.Show();
        }
        renyuanGL f2;//实例化窗口renyanGL
        private void renyuanGL_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new renyuanGL();//窗口实例化
            f2.Show();
        }
        dingdanGL f3;//实例化窗口dingdanGL
        private void dingdanGL_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3 = new dingdanGL();//窗口实例化
            f3.Show();
        }
        Form1 f5;//
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            f5 = new Form1();
            f5.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //每秒状态栏时钟都会变化，显示最新的时间
            toolStripStatusLabel1.Text = DateTime.Now.ToString() + "   ";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public virtual void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
