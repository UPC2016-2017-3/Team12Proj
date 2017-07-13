using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Excel = Microsoft.Office.Interop.Excel;

namespace 收银界面
{
    public partial class SY : Form
    {
        public SY()
        {
            InitializeComponent();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SY_Load(object sender, EventArgs e)
        {
            label4.Text = System.DateTime.Now.ToString();
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sssql = "select 是否占用 as '是否占用',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sssql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows[0][0].ToString().Trim().Equals("占用"))
            {
                button11.BackColor = Color.PowderBlue;
                button11.Text = "桌1[有客]";
            }
            else
            {
                button11.BackColor = Color.Snow;
                button11.Text = "桌1[空闲]";
            }
            if (ds.Tables[0].Rows[1][0].ToString().Trim().Equals("占用"))
            {
                button12.BackColor = Color.PowderBlue;
                button12.Text = "桌2[有客]";
            }
            else
            {
                button12.BackColor = Color.Snow;
                button12.Text = "桌2[空闲]";
            }
            if (ds.Tables[0].Rows[2][0].ToString().Trim().Equals("占用"))
            {
                button13.BackColor = Color.PowderBlue;
                button13.Text = "桌3[有客]";
            }
            else
            {
                button13.BackColor = Color.Snow;
                button13.Text = "桌3[空闲]";
            }
            if (ds.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
                button14.BackColor = Color.PowderBlue;
                button14.Text = "桌4[有客]";
            }
            else
            {
                button14.BackColor = Color.Snow;
                button14.Text = "桌4[空闲]";
            }
            if (ds.Tables[0].Rows[4][0].ToString().Trim().Equals("占用"))
            {
                button15.BackColor = Color.PowderBlue;
                button15.Text = "桌5[有客]";
            }
            else
            {
                button15.BackColor = Color.Snow;
                button15.Text = "桌5[空闲]";
            }
            if (ds.Tables[0].Rows[5][0].ToString().Trim().Equals("占用"))
            {
                button16.BackColor = Color.PowderBlue;
                button16.Text = "桌6[有客]";
            }
            else
            {
                button16.BackColor = Color.Snow;
                button16.Text = "桌6[空闲]";
            }
            if (ds.Tables[0].Rows[6][0].ToString().Trim().Equals("占用"))
            {
                button17.BackColor = Color.PowderBlue;
                button17.Text = "桌7[有客]";
            }
            else
            {
                button17.BackColor = Color.Snow;
                button17.Text = "桌7[空闲]";
            }
            if (ds.Tables[0].Rows[7][0].ToString().Trim().Equals("占用"))
            {
                button18.BackColor = Color.PowderBlue;
                button18.Text = "桌8[有客]";
            }
            else
            {
                button18.BackColor = Color.Snow;
                button18.Text = "桌8[空闲]";
            }
            if (ds.Tables[0].Rows[8][0].ToString().Trim().Equals("占用"))
            {
                button19.BackColor = Color.PowderBlue;
                button19.Text = "桌9[有客]";
            }
            else
            {
                button19.BackColor = Color.Snow;
                button19.Text = "桌9[空闲]";
            }
            if (ds.Tables[0].Rows[10][0].ToString().Trim().Equals("占用"))
            {
                button20.BackColor = Color.PowderBlue;
                button20.Text = "桌10[有客]";
            }
            else
            {
                button20.BackColor = Color.Snow;
                button20.Text = "桌10[空闲]";
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chaxunBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 NewFrm = new Form1();
            NewFrm.Show();
        }

        private void zhuohao_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[0][0].ToString().Trim().Equals("占用"))
            {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                 + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                 + " where   桌号=1 and 是否结账='否'";

            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds);
  
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            string _ssql = "select 订单编号 as '订单编号',人数 as '人数',总价 as '总价'from dingdan where 是否结账='否'and 桌号=1";
            SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
            DataSet dr = new DataSet();
            sdb.Fill(dr);    
            label3.Text = "1".ToString();
            label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
            label9.Text = dr.Tables[0].Rows[0][0].ToString();
            label11.Text =dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = System.DateTime.Now.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[1][0].ToString().Trim().Equals("占用"))
            {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                 + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                 + " where   桌号=2 and 是否结账='否'";
            string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=2";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
            DataSet dr = new DataSet();
            sda.Fill(ds);
            sdb.Fill(dr);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            label3.Text = "2".ToString();
            label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
            label9.Text = dr.Tables[0].Rows[0][0].ToString();
            label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[2][0].ToString().Trim().Equals("占用"))
            {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                 + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                 + " where   桌号=3 and 是否结账='否'";
            string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=3";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
            DataSet dr = new DataSet();
            sda.Fill(ds);
            sdb.Fill(dr);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            label3.Text = "3".ToString();
            label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
            label9.Text = dr.Tables[0].Rows[0][0].ToString();
            label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JZ NewFrm = new JZ();
            NewFrm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                 + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                 + " where   桌号=4 and 是否结账='否'";
            string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=4";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
            DataSet dr = new DataSet();
            sda.Fill(ds);
            sdb.Fill(dr);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            label3.Text = "4".ToString();
            label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
            label9.Text = dr.Tables[0].Rows[0][0].ToString();
            label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                     + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                     + " where   桌号=5 and 是否结账='否'";
                string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=5";
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
                DataSet dr = new DataSet();
                sda.Fill(ds);
                sdb.Fill(dr);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                label3.Text = "5".ToString();
                label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
                label9.Text = dr.Tables[0].Rows[0][0].ToString();
                label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                     + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                     + " where   桌号=6 and 是否结账='否'";
                string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=6";
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
                DataSet dr = new DataSet();
                sda.Fill(ds);
                sdb.Fill(dr);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                label3.Text = "6".ToString();
                label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
                label9.Text = dr.Tables[0].Rows[0][0].ToString();
                label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }
        private void button17_Click_1(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                     + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                     + " where   桌号=7 and 是否结账='否'";
                string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=7";
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
                DataSet dr = new DataSet();
                sda.Fill(ds);
                sdb.Fill(dr);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                label3.Text = "7".ToString();
                label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
                label9.Text = dr.Tables[0].Rows[0][0].ToString();
                label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }
        private void button18_Click_1(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                     + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                     + " where   桌号=8 and 是否结账='否'";
                string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=8";
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
                DataSet dr = new DataSet();
                sda.Fill(ds);
                sdb.Fill(dr);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                label3.Text = "8".ToString();
                label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
                label9.Text = dr.Tables[0].Rows[0][0].ToString();
                label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                     + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                     + " where   桌号=9 and 是否结账='否'";
                string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=9";
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
                DataSet dr = new DataSet();
                sda.Fill(ds);
                sdb.Fill(dr);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                label3.Text = "9".ToString();
                label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
                label9.Text = dr.Tables[0].Rows[0][0].ToString();
                label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            string connnStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _ssssql = "select 是否占用 as 'takeup',桌号 as '桌号'from zhuoweiqingkuang";
            SqlConnection connn = new SqlConnection(connnStr);
            SqlDataAdapter sdaa = new SqlDataAdapter(_ssssql, connn);
            DataSet dss = new DataSet();
            sdaa.Fill(dss);
            if (dss.Tables[0].Rows[3][0].ToString().Trim().Equals("占用"))
            {
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                     + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                     + " where   桌号=10 and 是否结账='否'";
                string _ssql = "select 订单编号 as 'ddbh',人数 as 'renshu',总价 as 'zongjia'from dingdan where 是否结账='否'and 桌号=10";
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
                DataSet dr = new DataSet();
                sda.Fill(ds);
                sdb.Fill(dr);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                label3.Text = "10".ToString();
                label7.Text = '￥' + dr.Tables[0].Rows[0][2].ToString();
                label9.Text = dr.Tables[0].Rows[0][0].ToString();
                label11.Text = dr.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("桌位空闲！", "---");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SY_Load(sender, e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SY_Load(sender, e);
        }




        private void button9_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "SELECT dbo.xiangxidingdan.菜品名称, dbo.xiangxidingdan.菜品分类, dbo.xiangxidingdan.菜品数量, "
                     + "  dbo.xiangxidingdan.单价," + "dbo.xiangxidingdan.菜品数量*dbo.xiangxidingdan.单价 as '小计' FROM      dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                     + " where   是否结账='是'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            string fileName = "";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
            //写入标题             
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            { worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText; }
            //写入数值
            for (int r = 0; r < dataGridView1.Rows.Count; r++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dataGridView1.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
                }
                catch (Exception ex)
                {//fileSaved = false;                      
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//双击查看原图行销毁   
        }
    }
}