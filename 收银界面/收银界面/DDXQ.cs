using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 收银界面
{
    public partial class DDXQ : Form
    {
        public DDXQ()
        {
            InitializeComponent();
        }

        private void DDXQ_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "SELECT dbo.dingdan.桌号,  dbo.xiangxidingdan.商品编号 , "
                 + "  dbo.xiangxidingdan.商品名称 FROM   dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                 + " where  是否结账='否'";
            DataSet ret = new DataSet();
            using (SqlConnection cnn = new SqlConnection(connStr))
            {
                cnn.Open();
                string queryString = _sql;
                SqlDataAdapter ad = new SqlDataAdapter();
                SqlCommand com = new SqlCommand(queryString, cnn);
                com.CommandType = CommandType.Text;

                ad.SelectCommand = com;
                ad.Fill(ret);

                dataGridView1.DataSource = ret.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 NewFrm = new Form1();
           // NewFrm.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                                   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
            string _sql = "SELECT dbo.dingdan.桌号,  dbo.xiangxidingdan.商品编号 , "
                 + "  dbo.xiangxidingdan.商品名称 FROM   dbo.dingdan RIGHT OUTER JOIN dbo.xiangxidingdan ON dbo.dingdan.订单编号 = dbo.xiangxidingdan.订单编号"
                 + " where   桌号= '"+comboBox1.Text + "'  and 是否结账='否'";
            DataSet ret = new DataSet();
            using (SqlConnection cnn = new SqlConnection(connStr))
            {
                cnn.Open();
                string queryString = _sql;
                SqlDataAdapter ad = new SqlDataAdapter();
                SqlCommand com = new SqlCommand(queryString, cnn);
                com.CommandType = CommandType.Text;

                ad.SelectCommand = com;
                ad.Fill(ret);

                dataGridView1.DataSource = ret.Tables[0];

            }
        }

        
    }
}
