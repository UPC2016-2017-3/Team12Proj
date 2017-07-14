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

namespace 收银界面
{
    public partial class JZ : Form
    {
        public JZ()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void JZ_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() != String.Empty)
            {
                Double s = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(label7.Text.Replace("￥", ""));
                label8.Text = '￥' + s.ToString();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            if (textBox3.Text.Trim() != String.Empty && comboBox1.Text.Trim() != String.Empty && label7.Text.Trim() != String.Empty && label8.Text.Trim() != String.Empty)
            {
                string strSelID = comboBox1.Items[comboBox1.SelectedIndex].ToString().Trim();

                string _sql = "update zhuoweiqingkuang  set 是否占用='空闲'  where 桌号='" + strSelID + "'";
                string _sqll = "update dingdan set 是否结账='是'  where 桌号='" + strSelID + "'";
                SqlCommand comm = new SqlCommand(_sql, conn);
                SqlCommand comn = new SqlCommand(_sqll, conn);
                int irow= comm.ExecuteNonQuery();
                int jrow = comn.ExecuteNonQuery();
                if (irow > 0&&jrow>0)
                {
                    MessageBox.Show("结账成功，欢迎下次光临！", "ok");
                }
                else
                {
                    MessageBox.Show("结账失败！！！", "注意");
                }
                conn.Close();
                //this.Close();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string strSelID = comboBox1.Items[comboBox1.SelectedIndex].ToString().Trim();

            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            //string _sssql = "select 桌号 as '桌号',总价 as '总价'from dingdan where 桌号='" + strSelID + "'";
            string _sssql = "select sum(dbo.xiangxidingdan.商品数量*dbo.xiangxidingdan.商品价格) FROM dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                    + " where   桌号='" + strSelID + "' and 是否结账='否'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sssql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            label7.Text = '￥' + ds.Tables[0].Rows[0][0].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = "收据清单"; 
            //纸张大小
            PaperSize pageSize = new PaperSize("Your Paper Name", 100, 70);
            pageSize.RawKind = 9; //如果是自定义纸张，就要大于118，（A4值为9，先前150 ）
            printDocument1.DefaultPageSettings.PaperSize = pageSize; 
            //打印开始前
            //printDocument1.BeginPrint += new PrintEventHandler(printDocument_BeginPrint);
            //打印输出（过程）
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            //打印结束
            //printDocument1.EndPrint += new PrintEventHandler(printDocument_EndPrint);
            //跳出打印对话框，提供打印参数可视化设置，如选择哪个打印机打印此文档等
            printDialog1.Document = printDocument1;
            //打印对话框
            if (DialogResult.OK == printDialog1.ShowDialog()) //如果确认，将会覆盖所有的打印参数设置
            { 
                //页面设置对话框（可以不使用，其实PrintDialog对话框已提供页面设置）
                pageSetupDialog1.Document = printDocument1; 
                if (DialogResult.OK == pageSetupDialog1.ShowDialog()) 
                {
                    //打印预览
                    printPreviewDialog1.Document = printDocument1;
                    if (DialogResult.OK == printPreviewDialog1.ShowDialog())
                        printDocument1.Print(); //打印
                }
            } 
        }
        //打印开始前
        void printDocument_BeginPrint(object sender, PrintEventArgs e)
        { 

        }
        //打印输出（过程）

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (textBox3.Text.Trim() != String.Empty && comboBox1.Text.Trim() != String.Empty && label7.Text.Trim() != String.Empty && label8.Text.Trim() != String.Empty)
            {
                string strSelID = comboBox1.Items[comboBox1.SelectedIndex].ToString().Trim();
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                string _sql = "select dbo.xiangxidingdan.商品名称 as '菜品名称',dbo.xiangxidingdan.商品价格 as '单价',dbo.xiangxidingdan.商品数量 as '菜品数量', (dbo.xiangxidingdan.商品数量*dbo.xiangxidingdan.商品价格) as '小计' FROM dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
        + " where   桌号='" + strSelID + "' and 是否结账='否'"; ;
                string _ssql = "select 订单编号 as '订单编号',人数 as '人数' from dingdan where 桌号='" + strSelID + "'";
                string _ssqll = "select sum(dbo.xiangxidingdan.商品数量*dbo.xiangxidingdan.商品价格) FROM dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
        + " where   桌号='" + strSelID + "' and 是否结账='否'";
                string _sssql = "select count(*) as 'length' FROM dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号 where 桌号='" + strSelID + "'and 是否结账='否'";
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sdb = new SqlDataAdapter(_ssql, conn);
                DataSet dr = new DataSet();
                SqlDataAdapter sdc = new SqlDataAdapter(_sssql, conn);
                DataSet dt = new DataSet();
                SqlDataAdapter sdd = new SqlDataAdapter(_ssqll, conn);
                DataSet du = new DataSet();

                sda.Fill(ds);
                sdb.Fill(dr);
                sdc.Fill(dt);
                sdd.Fill(du);
                int m = Convert.ToInt32(dt.Tables[0].Rows[0][0].ToString());

                int speed = 20;
                int flag = 1;
                //打印内容 
                Graphics g = e.Graphics;
                Brush blackPen = new SolidBrush(Color.Black);
                //黑色画笔
                Brush redPen = new SolidBrush(Color.Red);
                //红色笔 
                // Image image = Image.FromFile("icon.png");
                //清单图标
                Font titleFont = new Font("黑体", 20);
                //标题字体
                Font contFont = new Font("宋体", 16);
                //内容字体
                Font menuFont = new Font("宋体", 9);
                //商品项目字体
                Font itemFont = new Font("华文中宋", 12);
                Pen tablePan = new Pen(Color.Black, 1);
                float[] dashValues = { 2, 3 };
                tablePan.DashPattern = dashValues;
                //Logo部分
                g.DrawImage(Image.FromFile(@"C:\icon.png"), 40, 40);
                //标题 
                string title = "实习餐饮消费清单\n";
                g.DrawString(title, titleFont, blackPen, new PointF((e.PageBounds.Width - g.MeasureString(title, titleFont).Width) / 2, speed * flag++));
                //清单表头部分
                g.DrawString("订单编号：", itemFont, blackPen, new Point(200, 80));
                g.DrawString(dr.Tables[0].Rows[0][0].ToString(), new Font("宋体", 20), redPen, new Point(300, 80));
                //g.DrawLine(tablePan, new Point(300, 100), new Point(400, 100));
                g.DrawString("桌号：", itemFont, blackPen, new Point(200, 140));
                g.DrawString("桌1", new Font("宋体", 20), redPen, new Point(300, 140));
                //g.DrawLine(tablePan, new Point(300, 160), new Point(400, 160));
                g.DrawString("人数：", itemFont, blackPen, new Point(500, 80));
                g.DrawString(dr.Tables[0].Rows[0][1].ToString(), new Font("宋体", 20), redPen, new Point(600, 80));
                // g.DrawLine(tablePan, new Point(600, 100), new Point(700, 100)); 
                g.DrawString("消费总额：", itemFont, blackPen, new Point(500, 140));
                g.DrawString(du.Tables[0].Rows[0][0].ToString(), new Font("宋体", 20), redPen, new Point(600, 140));
                // g.DrawLine(tablePan, new Point(600, 160), new Point(700, 160)); 
                //上分隔线 
                g.DrawLine(tablePan, new Point(30, 200), new Point(e.PageBounds.Width - 30, 200));
                g.DrawString("菜品名称\t\t菜品单价\t\t\t\t菜品数量\t\t\t   小计", menuFont, blackPen, new Point(35, 205));
                int hieght = 205;
                for (int i = 0; i < m; i++)
                {
                    hieght += 20;
                    g.DrawString(ds.Tables[0].Rows[i][0].ToString() + "   \t\t" + ds.Tables[0].Rows[i][1].ToString() + "   \t\t\t\t   " + ds.Tables[0].Rows[i][2].ToString()
                        + "   \t\t  " + ds.Tables[0].Rows[i][3].ToString(), menuFont, blackPen, new Point(35, hieght));
                }
                //下分隔线
                g.DrawLine(tablePan, new Point(30, e.PageBounds.Height - 260), new Point(e.PageBounds.Width - 30, e.PageBounds.Height - 260));
                //联系地址及总计
                g.DrawString(System.DateTime.Now.ToString(), new Font("宋体", 15), blackPen, new Point(e.PageBounds.Width - 250, e.PageBounds.Height - 270));
                g.DrawString("总计：￥" + du.Tables[0].Rows[0][0].ToString(), new Font("宋体", 20), redPen, new Point(e.PageBounds.Width - 250, e.PageBounds.Height - 240));
                g.DrawString("实付：￥" + textBox3.Text.ToString(), new Font("宋体", 20), redPen, new Point(e.PageBounds.Width - 250, e.PageBounds.Height - 190));
                g.DrawString("找零：" + label8.Text.ToString(), new Font("宋体", 20), redPen, new Point(e.PageBounds.Width - 250, e.PageBounds.Height - 140));
                g.DrawString("地址：山东省青岛市黄岛区长江西路66号", new Font("宋体", 15), blackPen, new Point(100, e.PageBounds.Height - 85));
                g.DrawString("预订电话：0000-0000000", new Font("宋体", 15), blackPen, new Point(e.PageBounds.Width - 300, e.PageBounds.Height - 85));
                //e.Cancel//获取或设置是否取消打印
                //e.HasMorePages 
                //为true时，该函数执行完毕后还会重新执行一遍（可用于动态分页）
            }
        }
        //打印结束
        void printDocument_EndPrint(object sender, PrintEventArgs e)
        { 
            //MessageBox.Show("打印完成");
        }
    }
}
