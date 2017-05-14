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
    
    public partial class FrmUserLogin : Form
    {
       
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            string selectsql;
            if (radioButton1.Checked)
            {
                Use.idetify = true;
                selectsql = "Select * from ManagerInfo where ID = '" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                Use.UserId = textBox1.Text;
                SqlCommand cmd = new SqlCommand(selectsql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("登陆失败!请检查用户名或者密码！");
                    return;
                }
                con.Close();
            }
            else if (radioButton2.Checked)
            {
                Use.idetify = false;
                selectsql = "Select * from StudentInfo where ID = '" + textBox1.Text + "' and Pwd='" + textBox2.Text + "'";
                Use.UserId = textBox1.Text;
                SqlCommand cmd = new SqlCommand(selectsql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("登陆失败!请检查用户名或者密码！");
                    return;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("请选择登录用户类型");
            }
        }
       
        
        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("iexplore.exe","hppt://www.4399.com");
            FrmRegist FrmRegist = new FrmRegist();
            FrmRegist.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*FrmChangeLogin FrmChangeLogin = new FrmChangeLogin();
            FrmChangeLogin.Show();*/
            FrmQues frm = new FrmQues();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLink FrmLink = new FrmLink();
            FrmLink.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    public class Use
        {
        public static string UserId = "";
        public static bool idetify;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
