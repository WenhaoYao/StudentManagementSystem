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
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            label15.Text = Use.UserId;
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            string selectsql = "select * from StudentInfo where ID='" + label15.Text + "'";//(ID,姓名,专业,班级,性别,电话,住址) values ('" + label14.Text + "','" + label7.Text + "','" + label8.Text + "','" + label9.Text + "','" + label10.Text + "','" + label11.Text + "','" + label12.Text + "')
            SqlCommand cmd = new SqlCommand(selectsql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                label7.Text = sdr["姓名"].ToString();
                label8.Text = sdr["专业"].ToString();
                label9.Text = sdr["班级"].ToString();
                label10.Text = sdr["性别"].ToString();
                label11.Text = sdr["电话"].ToString();
                label12.Text = sdr["住址"].ToString();
                label14.Text = sdr["ID"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            string selectsql;
            selectsql = "delete  from StudentInfo where 姓名 = '" + label7.Text + "'";
            SqlCommand cmd = new SqlCommand(selectsql, con);
            cmd.CommandType = CommandType.Text;
            //SqlDataReader sdr;
            //sdr = cmd.ExecuteReader();
            //DialogResult = DialogResult.OK;
            if (cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("删除用户成功，将退出登录");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
