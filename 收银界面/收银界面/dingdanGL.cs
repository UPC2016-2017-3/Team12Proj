using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 收银界面
{
    public partial class dingdanGL : parentForm
    {
        //保存查询字符串
        private string sql = "";
        public dingdanGL()
        {
            InitializeComponent();
        }
        //在窗口初始化时显示最新订单
        private void dingdanGL_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            //创建数据库连接
            //string _sql = "select 桌号 as '桌号',菜品号 as '菜品号',订单编号 as '订单编号'," +
            //    "商品名称 as '商品名称',商品数量 as '商品数量',时间 as '时间',人数 as '人数' from dingdan";
            string _sql = "select * from dingdan";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);//adapter 通过_sql，conn建立
            DataSet ds = new DataSet();
            sda.Fill(ds);//用DataAdapter操作dataset,对dataset进行填充
            dataGridView1.DataSource = ds.Tables[0].DefaultView;//将dataset的内容显示在datagridview 控件中
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            renshu.SelectedIndex = 0;
        }
        //获取输入文本信息
        private void MakeSqlStr()
        {
            //清空上次的查询字符串
            sql = "";
            if (zhuhao.Text.Trim() != string.Empty)
            {
                sql = " and 桌号 like '%" + zhuhao.Text.Trim() + "%'";//通过限制条件对结果进行约束过滤
            }
            //if (renshu.Text.Trim() != string.Empty)
            //{
            //    sql += " and 人数 like '%" + renshu.Text.Trim() + "%'";
            //}
            if (renshu.Text.Trim() != "所有")
            {
                sql = "and 人数 like '%" + renshu.Text.Trim() + "%'";
            }
            if (time1.Text.Trim() != string.Empty)
            {
                //sql = " and 生成时间 like '%" + time1.Text.Trim() + "%'";
            }
            if (time2.Text.Trim() != string.Empty)
            {
                //sql = " and 生成时间 like '%" + time2.Text.Trim() + "%'";
            }
        }


        private void xiugaikuang_Enter(object sender, EventArgs e)
        {

        }

        private void chaxun_bt_Click(object sender, EventArgs e)
        {

            string str = time1.Text.Trim();//2017-7-13

            //获取查询字符串
            MakeSqlStr();
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            string _sql = //"select 桌号 as '桌号',菜品号 as '菜品号',订单编号 as '订单编号'," +
                          //"商品编号 as '商品编号',商品名称 as '商品名称',商品数量 as '商品数量',时间 as '时间' from dingdan where 1=1"
                    "select * from dingdan where DATEDIFF(day,'" + str + "', 生成时间) >=0 and DATEDIFF(day, 生成时间,'" + time2.Text.Trim() + "')>= 0"
                                  + sql;
            //"select * from dingdan where 1=1"+ sql;
            //select * from dingdan where  DATEDIFF(day,'2017-7-2',时间)>=0 and DATEDIFF(day,时间,'2017-7-10')>0

            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
