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
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            string selectsql = "select * from ClassInfo";
            SqlCommand cmd = new SqlCommand(selectsql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.SubItems[0].Text = sdr["时间&节次"].ToString();
                //lt.SubItems.Add(sdr["时间&节次"].ToString());
                lt.SubItems.Add(sdr["上午1-2节"].ToString());
                lt.SubItems.Add(sdr["上午3-4节"].ToString());
                lt.SubItems.Add(sdr["下午5-6节"].ToString());
                lt.SubItems.Add(sdr["下午7-8节"].ToString());
                lt.SubItems.Add(sdr["晚修"].ToString());
                listView1.Items.Add(lt);
            }
            con.Close();
        }

        private void 地址ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            if (comboBox2.Text == "上午1-2节")
            {
                string selectsql = "update ClassInfo set [上午1-2节] ='" + textBox1.Text + "'where [时间&节次] = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请刷新");
                }
                else
                {
                    MessageBox.Show("更改失败，请重新尝试");
                }
            }
            else if (comboBox2.Text == "上午3-4节")
            {
                string selectsql = "update ClassInfo set [上午3-4节] ='" + textBox1.Text + "'where [时间&节次] = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请刷新");
                }
                else
                {
                    MessageBox.Show("更改失败，请重新尝试");
                }
            }
            else if (comboBox2.Text == "下午5-6节")
            {
                string selectsql = "update ClassInfo set [下午5-6节] ='" + textBox1.Text + "'where [时间&节次] = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请刷新");
                }
                else
                {
                    MessageBox.Show("更改失败，请重新尝试");
                }
            }
            else if (comboBox2.Text == "下午7-8节")
            {
                string selectsql = "update ClassInfo set [下午7-8节] ='" + textBox1.Text + "'where [时间&节次] = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请刷新");
                }
                else
                {
                    MessageBox.Show("更改失败，请重新尝试");
                }
            }
            else if (comboBox2.Text == "晚修")
            {
                string selectsql = "update ClassInfo set [晚修] ='" + textBox1.Text + "'where [时间&节次] = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("更改成功，请刷新");
                }
                else
                {
                    MessageBox.Show("更改失败，请重新尝试");
                }
            }
            con.Close();
        }

        private void 刷新课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            string selectsql = "select * from ClassInfo";
            SqlCommand cmd = new SqlCommand(selectsql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.SubItems[0].Text = sdr["时间&节次"].ToString();
                lt.SubItems.Add(sdr["上午1-2节"].ToString());
                lt.SubItems.Add(sdr["上午3-4节"].ToString());
                lt.SubItems.Add(sdr["下午5-6节"].ToString());
                lt.SubItems.Add(sdr["下午7-8节"].ToString());
                lt.SubItems.Add(sdr["晚修"].ToString());
                listView1.Items.Add(lt);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
