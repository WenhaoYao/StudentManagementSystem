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
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }

        private void FrmRegist_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar ='*' ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="管理员身份")
            {
                string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
                SqlConnection con = new SqlConnection(SqlStr);
                con.Open();
                string selectsql = "insert into ManagerInfo (ID,Password,Name,Sex,Majority,Tel,Add) values ('"+ textBox1.Text + "','"+ textBox2.Text + "','"+ textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery())>0)
                {
                  MessageBox.Show("管理员注册成功，请登录");
                  Close();
                }
                 else
                {
                 MessageBox.Show("请重新注册");
                }
             con.Close();
             }
            else
            {
                string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
                SqlConnection con = new SqlConnection(SqlStr);
                con.Open();
                string selectsql = "insert into StudentInfo (ID,Pwd,姓名,专业,班级,性别,电话,住址) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("用户注册成功，请登录");
                    Close();
                }
                else
                {
                    MessageBox.Show("请重新注册");
                }
                con.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
