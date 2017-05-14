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
    public partial class FrmQues : Form
    {
        public FrmQues()
        {
            InitializeComponent();
        }

        private void FrmQues_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==result.ToString())
            {
                MessageBox.Show("验证成功");
                Close();
                FrmChangeLogin FrmChangeLogin = new FrmChangeLogin();
                FrmChangeLogin.Show();
            }
            else
            {
                MessageBox.Show("验证失败，请重新验证");
                Close();
            }
        }
        public static char[] chars = {'+','-','*'};
        public static int result;

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Random ran = new Random();
            int RandKey1 = ran.Next(100, 999);
            int RandKey2 = ran.Next(100, 999);
            label2.Text = RandKey1.ToString();
            label3.Text = RandKey2.ToString();
            sb.Append(chars[ran.Next(0, chars.Length)]);
            label4.Text = sb.ToString();
            switch (chars[ran.Next(0, chars.Length)])
            {
                case '+': result = RandKey1 + RandKey2;break;
                case '-': result = RandKey1 - RandKey2;break;
                case '*': result = RandKey1 * RandKey2;break;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
