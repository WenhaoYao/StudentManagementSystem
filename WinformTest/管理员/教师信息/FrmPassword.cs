﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinformTest.管理员.教师信息
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox1.Text)
            {
                MessageBox.Show("请重新确认密码");
            }
            else
            {
                string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
                SqlConnection con = new SqlConnection(SqlStr);
                con.Open();
                string selectsql = "update ManagerInfo set Password ='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请刷新");
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
