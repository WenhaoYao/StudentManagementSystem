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

namespace WinformTest
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("请重新确认姓名");

            }
            else
            {
                string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
                SqlConnection con = new SqlConnection(SqlStr);
                con.Open();
                string selectsql = "update StudentInfo set 住址 ='" + textBox2.Text + "'where 住址='" + textBox1.Text + "'";
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

        private void FrmAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
