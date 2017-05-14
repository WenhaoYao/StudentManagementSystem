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
using static WinformTest.FrmUserLogin;

namespace WinformTest
{
    public partial class FrmChangeLogin : Form
    {
        public FrmChangeLogin()
        {
            InitializeComponent();
        }

        private void FrmChangeLogin_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*FrmQues frm = new FrmQues();
            frm.Show();*/
            if (Use.idetify == true)
            {
                string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
                SqlConnection con = new SqlConnection(SqlStr);
                con.Open();
                string selectsql = "update StudentInfo set Pwd='" + textBox3.Text + "'where ID='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请重新登录");
                    Close();
                }
                else
                {
                    MessageBox.Show("更改失败，请重新尝试");
                }
                con.Close();
            }
            if (Use.idetify==false)
            {
                string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
                SqlConnection con = new SqlConnection(SqlStr);
                con.Open();
                string selectsql = "update ManagerInfo set Password='" + textBox3.Text + "'where ID='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请重新登录");
                    Close();
                }
                else
                {
                    MessageBox.Show("更改失败，请重新尝试");
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
