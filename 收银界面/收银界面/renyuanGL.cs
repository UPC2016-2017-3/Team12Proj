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
    public partial class renyuanGL : parentForm
    {
        //保存查询字符串
        private string sql = "";

        public renyuanGL()
        {
            InitializeComponent();
        }

        //在窗口初始化时显示所有人员信息
        private void renyuanGL_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            //创建数据库连接
            string _sql = "select RYID as '人员编号',RYName as '人员名称',RYSex as '性别',RYAge as '年龄',RYJob as '职位' from RYM";
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);//adapter 通过_sql，conn建立
            DataSet ds = new DataSet();
            sda.Fill(ds);//用DataAdapter操作dataset,对dataset进行填充
            dataGridView1.DataSource = ds.Tables[0].DefaultView;//将dataset的内容显示在datagridview 控件中
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sousuozhiwei.SelectedIndex = 0;
        }

        //获取输入文本信息
        private void MakeSqlStr()
        {
            //清空上次的查询字符串
            sql = "";
            if (sousuoID.Text.Trim() != string.Empty)
            {
                sql = " and RYID like '%" + sousuoID.Text.Trim() + "%'";//通过限制条件对结果进行约束过滤
            }
            if (sousuoName.Text.Trim() != string.Empty)
            {
                sql += " and RYName like '%" + sousuoName.Text.Trim() + "%'";
            }
            if (sousuozhiwei.Text != "所有类型")
            {
                sql += "and RYJob='" + sousuozhiwei.Text.Trim() + "'";
            }
        }

        //点击按钮进行查询操作
        private void chaxun_bt_Click(object sender, EventArgs e)
        {

            //获取查询字符串
            MakeSqlStr();
            string connStr = @"Data Source=.;Initial Catalog=A;Integrated Security=True";
            string _sql = "select RYID as '人员编号',RYName as '人员名称'," +
                          "RYSex as '性别',RYAge as '年龄',RYJob as '职位' from RYM where 1=1"
                          + sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
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
            gengxinID.Text = dgvCC[0].Value.ToString().Trim();
            gengxinmingcheng.Text = dgvCC[1].Value.ToString().Trim();
            gengxinSex.SelectedItem = dgvCC[2].Value.ToString().Trim();
            gengxinAge.Text = dgvCC[3].Value.ToString().Trim();
            gengxinzhiwei.SelectedItem = dgvCC[4].Value.ToString().Trim();
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
            string _sql = "delete from RYM where RYID='" + gengxinID.Text + "'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                renyuanGL_Load(null, null);
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
            string _sql = "select count(*) from RYM where RYID='" + gengxinID.Text + "'";
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
                    _sql = "update RYM set RYID ='" + gengxinID.Text.Trim() + "',RYName='"
                        + gengxinmingcheng.Text.Trim() + "',RYSex='" +
                        gengxinSex.SelectedItem + "',RYAge='" + gengxinAge.Text.Trim() 
                        + "',RYJob='" + gengxinzhiwei.SelectedItem + "'where RYID='" + gengxinID.Text + "'";
                    MessageBox.Show("修改成功！",
                        "提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                //添加新记录
                else
                {
                    _sql = "insert into RYM values('" + gengxinID.Text.Trim() + "','"
                        + gengxinmingcheng.Text.Trim() + "','" + gengxinSex.SelectedItem + "','"
                          + gengxinAge.Text.Trim() +"','"  + gengxinzhiwei.SelectedItem + "')";
                    MessageBox.Show("添加成功！",
                        "提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                cmd = new SqlCommand(_sql, conn);
                cmd.ExecuteNonQuery();
                renyuanGL_Load(null, null);
            }
            finally
            {
                conn.Close();
            }
        }

        private void gengxinAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入按键是否为数字
            //(char)8是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则只提示错误，而不允许输入到文本中
            if ((!Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
               // MessageBox.Show("请输入数字");
                 e.Handled = true;//经过判断不为数字，不可以输入
                MessageBox.Show("请输入数字");
                //gengxinAge.Text = gengxinAge.Text.Substring(0, gengxinAge.Text.Length - 1);
            }
            else
            { 
            e.Handled = false;
            }
 
        }

        private void gengxinID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入按键是否为数字
            //(char)8是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则只提示错误，而不允许输入到文本中
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;//经过判断为数字，可以输入
            }
            else
                e.Handled = false;
        }

        private void sousuoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入按键是否为数字
            //(char)8是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则只提示错误，而不允许输入到文本中
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;//经过判断为数字，可以输入
            }
            else
                e.Handled = false;
        }
    }
}
