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

namespace WinformTest
{
    public partial class FrmUpdating : Form
    {
        public FrmUpdating()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            string selectsql = "insert into StudentInfo (ID,Pwd,姓名,性别,专业,班级,电话,住址) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlCommand cmd = new SqlCommand(selectsql, con);
            if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("添加成功，请点击刷新");
                Close();
            }
            else
            {
                MessageBox.Show("添加失败，请重新尝试");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdating_Load(object sender, EventArgs e)
        {

        }
    }
}
