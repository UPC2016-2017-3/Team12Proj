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
    public partial class cp : Form
    {
    private string sql = "";
    

        public cp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cp_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "select 商品编号 ,商品价格 ,商品名称,商品分类 from 商品表";                      
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            textBox5.Text = System.DateTime.Now.ToShortDateString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MakeSqlStr()
        {
            //清空上次的查询字符串
            sql = "";
            if (comboBox3.SelectedItem==null)
            { }
            //if (comboBox3.Text != "所有类型")
            else
            {
                if(comboBox3.SelectedItem.ToString() != "所有类型")
                sql = " and 商品分类='" + comboBox3.Text + "'";
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            MakeSqlStr();
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "select 商品编号 as '商品编号',商品价格 as '商品价格',商品名称 as '商品名称',商品分类 as '商品分类' from 商品表 where 1=1"+sql;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
            DataGridViewCellCollection dgvcc = dgvRow.Cells;
            textBox1.Text = dgvcc[0].Value.ToString();
            textBox2.Text = dgvcc[2].Value.ToString();
            textBox7.Text = dgvcc[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "select 订单编号，商品编号,商品名称,商品数量，商品价格 from xiangxidingdan";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(_sql, conn);
                 conn.Open();
            
            int sum;
            sum = int.Parse(textBox3.Text) * Convert.ToInt32(textBox7.Text.Trim());
            textBox8.Text = sum.ToString();
           
            string sql = "insert into 详细订单(菜品号,桌号,订单编号,商品编号,商品名称,商品数量,时间,人数,总价)values('" + textBox6.Text.Trim() + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox4.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox5.Text.Trim() + "', '" + comboBox2.SelectedItem.ToString() + "','" + textBox8.Text.Trim() + "')";
            
           
            
            string sqllll = "insert into xiangxidingdan(订单编号,商品编号,商品名称,商品数量,商品价格)values('" + textBox4.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox7.Text.Trim() + "')  ";
            SqlCommand cmc = new SqlCommand(sqllll, conn);
            SqlCommand cmd2 = new SqlCommand(sql, conn);
           cmd2.ExecuteNonQuery();
           cmc.ExecuteNonQuery();
           string _sql3 = "select 菜品号,桌号,订单编号,商品编号,商品名称,商品数量,时间,人数,总价 from 详细订单 where 桌号='" + comboBox1.SelectedItem.ToString() + "'and 订单编号='"+textBox4.Text.Trim()+"'";
           SqlDataAdapter sda1 = new SqlDataAdapter(_sql3, conn);
           DataSet ds1 = new DataSet();
           sda1.Fill(ds1);
           dataGridView2.DataSource = ds1.Tables[0].DefaultView;
           string strSelID = comboBox1.Items[comboBox1.SelectedIndex].ToString().Trim();



           string _sqll = "update zhuoweiqingkuang  set 是否占用='占用'  where 桌号='" + strSelID + "'";
           string _sqlll = "update dingdan set 是否结账='否'  where 桌号='" + strSelID + "'";
           SqlCommand comm = new SqlCommand(_sqll, conn);
           SqlCommand comn = new SqlCommand(_sqlll, conn);
                          MessageBox.Show("点餐成功！",
                          "提示",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        
           conn.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {      
            SetDefaultValue();
        }
            protected void SetDefaultValue()
        {
            string connStr = "Data Source=.;Initial Catalog=A;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connStr);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select 订单编号 from 详细订单";


        }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox7_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
            {

            }

            private void textBox8_TextChanged(object sender, EventArgs e)
            {
                //textBox8.Text = (int.Parse(textBox3.Text) * int.Parse(textBox7.Text)).ToString();
            }

            private void textBox6_TextChanged(object sender, EventArgs e)
            {

            }

            private void label12_Click(object sender, EventArgs e)
            {

            }

            private void button3_Click(object sender, EventArgs e)
            {
               
                string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                 SqlConnection conn = new SqlConnection(connStr);
                     
                 conn.Open();
            
                 SqlCommand cmd = conn.CreateCommand();
                 cmd.CommandText = "select 总价 from 详细订单 where 订单编号=1";
                 SqlDataAdapter sda = new SqlDataAdapter(cmd);
                 DataSet ds = new DataSet();
                 sda.Fill(ds);
                 dataGridView2.DataSource = ds;
                 int sum = 0;
                 int number = ds.Tables[0].Rows.Count;
                 for (int i = 0; i < number; i++) {
                     string ss = ds.Tables[0].Rows[i][0].ToString().Trim();
                     int m = int.Parse(ss);
                     sum = sum + m;
                 }
                 textBox9.Text = sum.ToString();
            
                 
                string _sql5 = "insert into dingdan(订单编号,桌号,生成时间,人数,应收账款,是否结账)values('" + textBox4.Text.Trim() + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox5.Text.Trim() + "', '" + comboBox2.SelectedItem.ToString() + "','" + textBox9.Text.Trim() + "','" + "否" +"')";
                SqlCommand cmd2 = new SqlCommand(_sql5, conn);

                cmd2.ExecuteNonQuery();
                string _sql3 = "select  * from dingdan where 1=1 ";
                SqlDataAdapter sda1 = new SqlDataAdapter(_sql3, conn);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1);
                dataGridView2.DataSource = ds1.Tables[0].DefaultView;
                string strSelID = comboBox1.Items[comboBox1.SelectedIndex].ToString().Trim();
            }

            private void textBox9_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {

            }
        
     }
}    
