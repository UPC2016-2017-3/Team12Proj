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
    public partial class shangpinGL : parentForm
    {
        //保存查询字符串
        private string sql = "";

        public shangpinGL()
        {
            InitializeComponent();
        }
        //在窗口初始化时显示所有商品信息
        private void shangpinGL_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            //创建数据库连接
            string _sql = "select * from 商品表";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);//adapter 通过_sql，conn建立
            DataSet ds = new DataSet();
            sda.Fill(ds);//用DataAdapter操作dataset,对dataset进行填充
            dataGridView1.DataSource = ds.Tables[0].DefaultView;//将dataset的内容显示在datagridview 控件中
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            leixing.SelectedIndex = 0;

        }
        //获取输入文本信息
        private void MakeSqlStr()
        {
            //清空上次的查询字符串
            sql = "";
            if (bianhao.Text.Trim() != string.Empty)
            {
                sql = " and 商品编号 like '%" + bianhao.Text.Trim() + "%'";//通过限制条件对结果进行约束过滤
            }
            if (mingcheng.Text.Trim() != string.Empty)
            {
                sql += " and 商品名称 like '%" + mingcheng.Text.Trim() + "%'";
            }
            if (leixing.Text != "所有类型")
            {
                sql += "and 商品分类='" + leixing.Text + "'";
            }
        }
        
      
       
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        //点击按钮进行查询操作
        private void sousuo_Click(object sender, EventArgs e)
        {
            //获取查询字符串
            MakeSqlStr();
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            string _sql = "select 商品编号 as '商品编号',商品名称 as '商品名称',商品分类 as '商品种类'," +
                          "商品价格 as '商品价格' from 商品表 where 1=1"
                             + sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void leixing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public override void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataSet ds = new DataSet();
            //获得选中的记录行
            DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
            //获得行单元格集合
            DataGridViewCellCollection dgvCC = dgvRow.Cells;
            //获得单元格数据
            //DataTable dt =(DataTable) dataGridView1.DataSource;
            gengxinID.Text = dgvCC[0].Value.ToString();
            gengxinmingcheng.Text = dgvCC[1].Value.ToString();
            gengxinjiage.Text = dgvCC[3].Value.ToString();
            gengxinleixing.SelectedItem = dgvCC[2].Value.ToString().Trim();
        }
        //没用的
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void gengxinleixing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //删除按钮设置
        private void shanchu_bt_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            DialogResult ret = MessageBox.Show("确定要删除么？", "删除", MessageBoxButtons.OKCancel,
                                                                      MessageBoxIcon.Question);
            if (ret == DialogResult.Cancel)
            {
                return;
            }
            string _sql = "delete from 商品表 where 商品编号='" + gengxinID.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                shangpinGL_Load(null, null);
                if (rows == 1)
                {
                    MessageBox.Show("删除成功！",
                                    "提示",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        //更新按钮设置
        private void gengxin_bt_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            string _sql = "select count(*) from 商品表 where 商品编号='" + gengxinID.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            //检查是否有该商品记录，有则修改，无则添加
            try
            {
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                //修改记录
                if (cnt == 1)
                {
                    _sql = "update 商品表 set 商品编号 ='" + gengxinID.Text.Trim() + "',商品名称='"
                        + gengxinmingcheng.Text.Trim() + "',商品分类='" +
                        gengxinleixing.SelectedItem + "',商品价格='" + gengxinjiage.Text.Trim() +"'where 商品编号='"+ gengxinID.Text+"'";
                    MessageBox.Show("修改成功！",
                        "提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                //添加新记录
                else
                {
                    _sql = "insert into 商品表 values('" + gengxinID.Text.Trim() + "','" 
                        + gengxinmingcheng.Text.Trim() + "','" + gengxinleixing.SelectedItem + "','"
                           + gengxinjiage.Text.Trim() +  "')";
                    MessageBox.Show("添加成功！",
                        "提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();  
                shangpinGL_Load(null, null);

                //updata 商品表 set 商品编号 = '0001      ', 商品名称 = '拔丝红薯  ', 商品分类 = '菜品',商品价格='System.Windows.Forms.TextBox, Text: 15        '
            }
            finally
            {
                conn.Close();
            }
        }

        private void bianhao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入按键是否为数字
            //(char)8是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则只提示错误，而不允许输入到文本中
           // if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            //{
              //  e.Handled = true;//经过判断为数字，可以输入
            //}
            //else
            //    e.Handled = false;
        }

        private void gengxinID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入按键是否为数字
            //(char)8是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则只提示错误，而不允许输入到文本中
            //if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            //{
            //    e.Handled = true;//经过判断为数字，可以输入
            //}
            //else
            //    e.Handled = false;
        }

        private void gengxinjiage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入按键是否为数字
            //(char)8是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则只提示错误，而不允许输入到文本中
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;//经过判断为数字，可以输入
                MessageBox.Show("请输入数字");
            }
            else
                e.Handled = false;
        }
    }
}
