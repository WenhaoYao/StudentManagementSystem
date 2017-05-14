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
    public partial class FrmExam : Form
    {
        public FrmExam()
        {
            InitializeComponent();
        }

        private void FrmExam_Load(object sender, EventArgs e)
        {
            string SqlStr = "Server=.;Database=school;uid=sa;pwd=ywh19990629";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            string selectsql = "select * from StudentExam";
            SqlCommand cmd = new SqlCommand(selectsql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.SubItems[0].Text = sdr["日期"].ToString();
                //lt.SubItems.Add(sdr["时间&节次"].ToString());
                lt.SubItems.Add(sdr["时间"].ToString());
                lt.SubItems.Add(sdr["地点"].ToString());
                lt.SubItems.Add(sdr["考试信息"].ToString());
                lt.SubItems.Add(sdr["监考老师"].ToString());
                //lt.SubItems.Add(sdr["晚修"].ToString());
                listView1.Items.Add(lt);
            }
            con.Close();
        }
    }
}
