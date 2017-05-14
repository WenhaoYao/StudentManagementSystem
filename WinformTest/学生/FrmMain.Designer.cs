namespace WinformTest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.性别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家庭住址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作息安排ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学院介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.软件学院ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件学院ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.校图书馆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教务系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程学习ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSDNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.慕课网ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.w3schoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.博客园ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文档管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.schoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息ToolStripMenuItem,
            this.日程管理ToolStripMenuItem,
            this.学院介绍ToolStripMenuItem,
            this.课程学习ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jnToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生信息ToolStripMenuItem.Text = "学生信息";
            // 
            // jnToolStripMenuItem
            // 
            this.jnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息ToolStripMenuItem,
            this.考试信息ToolStripMenuItem});
            this.jnToolStripMenuItem.Name = "jnToolStripMenuItem";
            this.jnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jnToolStripMenuItem.Text = "查询";
            // 
            // 基本信息ToolStripMenuItem
            // 
            this.基本信息ToolStripMenuItem.Name = "基本信息ToolStripMenuItem";
            this.基本信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.基本信息ToolStripMenuItem.Text = "基本信息";
            this.基本信息ToolStripMenuItem.Click += new System.EventHandler(this.基本信息ToolStripMenuItem_Click);
            // 
            // 考试信息ToolStripMenuItem
            // 
            this.考试信息ToolStripMenuItem.Name = "考试信息ToolStripMenuItem";
            this.考试信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.考试信息ToolStripMenuItem.Text = "考试信息";
            this.考试信息ToolStripMenuItem.Click += new System.EventHandler(this.考试信息ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.名字ToolStripMenuItem,
            this.性别ToolStripMenuItem,
            this.班级ToolStripMenuItem,
            this.电话ToolStripMenuItem,
            this.家庭住址ToolStripMenuItem});
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 名字ToolStripMenuItem
            // 
            this.名字ToolStripMenuItem.Name = "名字ToolStripMenuItem";
            this.名字ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.名字ToolStripMenuItem.Text = "名字";
            this.名字ToolStripMenuItem.Click += new System.EventHandler(this.名字ToolStripMenuItem_Click);
            // 
            // 性别ToolStripMenuItem
            // 
            this.性别ToolStripMenuItem.Name = "性别ToolStripMenuItem";
            this.性别ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.性别ToolStripMenuItem.Text = "性别";
            this.性别ToolStripMenuItem.Click += new System.EventHandler(this.性别ToolStripMenuItem_Click);
            // 
            // 班级ToolStripMenuItem
            // 
            this.班级ToolStripMenuItem.Name = "班级ToolStripMenuItem";
            this.班级ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.班级ToolStripMenuItem.Text = "班级";
            this.班级ToolStripMenuItem.Click += new System.EventHandler(this.班级ToolStripMenuItem_Click);
            // 
            // 电话ToolStripMenuItem
            // 
            this.电话ToolStripMenuItem.Name = "电话ToolStripMenuItem";
            this.电话ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.电话ToolStripMenuItem.Text = "电话";
            this.电话ToolStripMenuItem.Click += new System.EventHandler(this.电话ToolStripMenuItem_Click);
            // 
            // 家庭住址ToolStripMenuItem
            // 
            this.家庭住址ToolStripMenuItem.Name = "家庭住址ToolStripMenuItem";
            this.家庭住址ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.家庭住址ToolStripMenuItem.Text = "家庭住址";
            this.家庭住址ToolStripMenuItem.Click += new System.EventHandler(this.家庭住址ToolStripMenuItem_Click);
            // 
            // 日程管理ToolStripMenuItem
            // 
            this.日程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作息安排ToolStripMenuItem,
            this.课表查询ToolStripMenuItem});
            this.日程管理ToolStripMenuItem.Name = "日程管理ToolStripMenuItem";
            this.日程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.日程管理ToolStripMenuItem.Text = "日程管理";
            // 
            // 作息安排ToolStripMenuItem
            // 
            this.作息安排ToolStripMenuItem.Name = "作息安排ToolStripMenuItem";
            this.作息安排ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.作息安排ToolStripMenuItem.Text = "作息安排";
            // 
            // 课表查询ToolStripMenuItem
            // 
            this.课表查询ToolStripMenuItem.Name = "课表查询ToolStripMenuItem";
            this.课表查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.课表查询ToolStripMenuItem.Text = "课表查询";
            this.课表查询ToolStripMenuItem.Click += new System.EventHandler(this.课表查询ToolStripMenuItem_Click);
            // 
            // 学院介绍ToolStripMenuItem
            // 
            this.学院介绍ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.软件学院ToolStripMenuItem});
            this.学院介绍ToolStripMenuItem.Name = "学院介绍ToolStripMenuItem";
            this.学院介绍ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学院介绍ToolStripMenuItem.Text = "学校介绍";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // 软件学院ToolStripMenuItem
            // 
            this.软件学院ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.软件学院ToolStripMenuItem1,
            this.校图书馆ToolStripMenuItem,
            this.教务系统ToolStripMenuItem});
            this.软件学院ToolStripMenuItem.Name = "软件学院ToolStripMenuItem";
            this.软件学院ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.软件学院ToolStripMenuItem.Text = "江西农业大学";
            this.软件学院ToolStripMenuItem.Click += new System.EventHandler(this.软件学院ToolStripMenuItem_Click);
            // 
            // 软件学院ToolStripMenuItem1
            // 
            this.软件学院ToolStripMenuItem1.Name = "软件学院ToolStripMenuItem1";
            this.软件学院ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.软件学院ToolStripMenuItem1.Text = "软件学院";
            this.软件学院ToolStripMenuItem1.Click += new System.EventHandler(this.软件学院ToolStripMenuItem1_Click);
            // 
            // 校图书馆ToolStripMenuItem
            // 
            this.校图书馆ToolStripMenuItem.Name = "校图书馆ToolStripMenuItem";
            this.校图书馆ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.校图书馆ToolStripMenuItem.Text = "校图书馆";
            this.校图书馆ToolStripMenuItem.Click += new System.EventHandler(this.校图书馆ToolStripMenuItem_Click);
            // 
            // 教务系统ToolStripMenuItem
            // 
            this.教务系统ToolStripMenuItem.Name = "教务系统ToolStripMenuItem";
            this.教务系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.教务系统ToolStripMenuItem.Text = "教务系统";
            this.教务系统ToolStripMenuItem.Click += new System.EventHandler(this.教务系统ToolStripMenuItem_Click);
            // 
            // 课程学习ToolStripMenuItem
            // 
            this.课程学习ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSDNToolStripMenuItem,
            this.慕课网ToolStripMenuItem,
            this.w3schoolToolStripMenuItem,
            this.博客园ToolStripMenuItem});
            this.课程学习ToolStripMenuItem.Name = "课程学习ToolStripMenuItem";
            this.课程学习ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程学习ToolStripMenuItem.Text = "课程学习";
            // 
            // cSDNToolStripMenuItem
            // 
            this.cSDNToolStripMenuItem.Name = "cSDNToolStripMenuItem";
            this.cSDNToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cSDNToolStripMenuItem.Text = "CSDN";
            this.cSDNToolStripMenuItem.Click += new System.EventHandler(this.cSDNToolStripMenuItem_Click);
            // 
            // 慕课网ToolStripMenuItem
            // 
            this.慕课网ToolStripMenuItem.Name = "慕课网ToolStripMenuItem";
            this.慕课网ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.慕课网ToolStripMenuItem.Text = "慕课网";
            this.慕课网ToolStripMenuItem.Click += new System.EventHandler(this.慕课网ToolStripMenuItem_Click);
            // 
            // w3schoolToolStripMenuItem
            // 
            this.w3schoolToolStripMenuItem.Name = "w3schoolToolStripMenuItem";
            this.w3schoolToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.w3schoolToolStripMenuItem.Text = "w3school";
            this.w3schoolToolStripMenuItem.Click += new System.EventHandler(this.w3schoolToolStripMenuItem_Click);
            // 
            // 博客园ToolStripMenuItem
            // 
            this.博客园ToolStripMenuItem.Name = "博客园ToolStripMenuItem";
            this.博客园ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.博客园ToolStripMenuItem.Text = "博客园";
            this.博客园ToolStripMenuItem.Click += new System.EventHandler(this.博客园ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文档管理ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 文档管理ToolStripMenuItem
            // 
            this.文档管理ToolStripMenuItem.Name = "文档管理ToolStripMenuItem";
            this.文档管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.文档管理ToolStripMenuItem.Text = "文档管理";
            this.文档管理ToolStripMenuItem.Click += new System.EventHandler(this.文档管理ToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(368, 265);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(606, 206);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "时间&节次";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "上午1-2节";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "上午3-4节";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "下午1-2节";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "下午3-4节";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "晚修";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "课表信息";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource;
        private System.Windows.Forms.BindingSource schoolDataSetBindingSource1;
        private System.Windows.Forms.BindingSource studentinformationBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 性别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家庭住址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作息安排ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学院介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程学习ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 软件学院ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件学院ToolStripMenuItem1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem 校图书馆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教务系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSDNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 慕课网ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem w3schoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 博客园ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem 文档管理ToolStripMenuItem;
    }
}