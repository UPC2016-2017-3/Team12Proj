using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 收银界面
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection();

        SqlCommand sqlCmd = new SqlCommand();
        
        String id = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = "Data Source=WHM;Initial Catalog=A;Integrated Security=True";
                sqlCon.Open();


            //comboBox1.Items.Clear();  //每次事件开始就清空控件

            sqlCmd.Connection=sqlCon;

            sqlCmd.CommandText = "select *from Login";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqlCmd.CommandText = "select * from Login where id='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "'and idtype='" + this.comboBox1.Text + "'";
            sqlCmd.Connection = sqlCon;

            SqlDataReader sqlDr = sqlCmd.ExecuteReader();

            if (sqlDr.Read())
            {
                if (this.comboBox1.Text.Equals("收银员"))
                {
                    this.Hide();
                    id = this.textBox1.Text;
                    SY NewFrm = new SY();
                    NewFrm.Show();
                }
                if (this.comboBox1.Text.Equals("服务员"))
                {
                    this.Hide();
                    id = this.textBox1.Text;
                    cp NewFrm = new cp();
                    NewFrm.Show();
                }
                if (this.comboBox1.Text.Equals("管理员"))
                {
                    this.Hide();
                    id = this.textBox1.Text;
                    parentForm  NewFrm = new parentForm();
                    NewFrm.Show();
                }
                if (this.comboBox1.Text.Equals("后厨"))
                {
                    this.Hide();
                    id = this.textBox1.Text;
                    DDXQ NewFrm = new DDXQ();
                    NewFrm.Show();
                }
            }
        }
    }
}