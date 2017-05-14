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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }



        private void FrmMain_Load(object sender, EventArgs e)
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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 名字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmName Frm = new FrmName();
            Frm.Show();
        }

        private void 性别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSex Frm = new FrmSex();
            Frm.Show();
        }

        private void 班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClass Frm = new FrmClass();
            Frm.Show();
        }

        private void 电话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTel Frm = new FrmTel();
            Frm.Show();
        }

        private void 家庭住址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd Frm = new FrmAdd();
            Frm.Show();
        }

        private void 基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInfo Frm = new FrmInfo();
            Frm.Show();
        }

        private void 软件学院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("iexplore.exe", "http://www.jxau.edu.cn");
            FrmOff FrmOff = new FrmOff();
            FrmOff.Show();
        }

        private void 课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 软件学院ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSoft FrmSoft = new FrmSoft();
            FrmSoft.Show();
        }

        private void 校图书馆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibra FrmLibra = new FrmLibra();
            FrmLibra.Show();
        }

        private void 教务系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSystem FrmSystem = new FrmSystem();
            FrmSystem.Show();
        }


        private void cSDNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://edu.csdn.net/");
        }

        private void 慕课网ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.imooc.com/");
        }

        private void w3schoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.w3school.com.cn/");
        }

        private void 博客园ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.cnblogs.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 文档管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTxt frm = new FrmTxt();
            frm.Show();
        }

        private void 考试信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExam frm = new FrmExam();
            frm.Show();
        }

    }
}
