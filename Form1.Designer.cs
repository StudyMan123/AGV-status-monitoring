namespace AGVS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.warning = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Addbutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Deletbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AGVcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Disconnectbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.connectbutton = new System.Windows.Forms.Button();
            this.IPbox = new System.Windows.Forms.TextBox();
            this.Combox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Mainbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.warning);
            this.panel1.Location = new System.Drawing.Point(1, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 427);
            this.panel1.TabIndex = 0;
            // 
            // warning
            // 
            this.warning.BackColor = System.Drawing.Color.SkyBlue;
            this.warning.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.warning.Cursor = System.Windows.Forms.Cursors.Default;
            this.warning.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.warning.FullRowSelect = true;
            this.warning.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.warning.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.warning.HideSelection = false;
            this.warning.Location = new System.Drawing.Point(0, 3);
            this.warning.Name = "warning";
            this.warning.ShowGroups = false;
            this.warning.ShowItemToolTips = true;
            this.warning.Size = new System.Drawing.Size(472, 424);
            this.warning.TabIndex = 1;
            this.warning.UseCompatibleStateImageBehavior = false;
            this.warning.View = System.Windows.Forms.View.Details;
            this.warning.SelectedIndexChanged += new System.EventHandler(this.warning_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "       报警信息";
            this.columnHeader1.Width = 206;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "报警时间";
            this.columnHeader2.Width = 437;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(601, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(601, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(312, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AGVcomboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Disconnectbutton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.connectbutton);
            this.panel2.Controls.Add(this.IPbox);
            this.panel2.Controls.Add(this.Combox);
            this.panel2.Location = new System.Drawing.Point(479, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 427);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Addbutton);
            this.panel4.Location = new System.Drawing.Point(3, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 38);
            this.panel4.TabIndex = 16;
            // 
            // Addbutton
            // 
            this.Addbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addbutton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Addbutton.ForeColor = System.Drawing.Color.Black;
            this.Addbutton.Location = new System.Drawing.Point(0, 0);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(303, 38);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = "添加AGV";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Deletbutton);
            this.panel3.Location = new System.Drawing.Point(3, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 38);
            this.panel3.TabIndex = 15;
            // 
            // Deletbutton
            // 
            this.Deletbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deletbutton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Deletbutton.ForeColor = System.Drawing.Color.Black;
            this.Deletbutton.Location = new System.Drawing.Point(0, 0);
            this.Deletbutton.Name = "Deletbutton";
            this.Deletbutton.Size = new System.Drawing.Size(303, 38);
            this.Deletbutton.TabIndex = 10;
            this.Deletbutton.Text = "删除";
            this.Deletbutton.UseVisualStyleBackColor = true;
            this.Deletbutton.Click += new System.EventHandler(this.Deletbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "选择AGV：";
            // 
            // AGVcomboBox
            // 
            this.AGVcomboBox.FormattingEnabled = true;
            this.AGVcomboBox.Location = new System.Drawing.Point(120, 220);
            this.AGVcomboBox.Name = "AGVcomboBox";
            this.AGVcomboBox.Size = new System.Drawing.Size(160, 20);
            this.AGVcomboBox.TabIndex = 7;
            this.AGVcomboBox.SelectedIndexChanged += new System.EventHandler(this.AGVcomboBox_SelectedIndexChanged);
            this.AGVcomboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AGVcomboBox_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP地址：";
            // 
            // Disconnectbutton
            // 
            this.Disconnectbutton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Disconnectbutton.ForeColor = System.Drawing.Color.Black;
            this.Disconnectbutton.Location = new System.Drawing.Point(193, 136);
            this.Disconnectbutton.Name = "Disconnectbutton";
            this.Disconnectbutton.Size = new System.Drawing.Size(106, 35);
            this.Disconnectbutton.TabIndex = 13;
            this.Disconnectbutton.Text = "断开连接";
            this.Disconnectbutton.UseVisualStyleBackColor = true;
            this.Disconnectbutton.Click += new System.EventHandler(this.Disconnectbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "端口：";
            // 
            // connectbutton
            // 
            this.connectbutton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connectbutton.ForeColor = System.Drawing.Color.Black;
            this.connectbutton.Location = new System.Drawing.Point(24, 136);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(106, 35);
            this.connectbutton.TabIndex = 12;
            this.connectbutton.Text = "连接";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // IPbox
            // 
            this.IPbox.Location = new System.Drawing.Point(104, 18);
            this.IPbox.Multiline = true;
            this.IPbox.Name = "IPbox";
            this.IPbox.Size = new System.Drawing.Size(176, 28);
            this.IPbox.TabIndex = 10;
            // 
            // Combox
            // 
            this.Combox.Location = new System.Drawing.Point(104, 60);
            this.Combox.Multiline = true;
            this.Combox.Name = "Combox";
            this.Combox.Size = new System.Drawing.Size(87, 28);
            this.Combox.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::AGVS.Properties.Resources.微信图片_20210508101553;
            this.panel5.Controls.Add(this.Mainbutton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 465);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 150);
            this.panel5.TabIndex = 7;
            // 
            // Mainbutton
            // 
            this.Mainbutton.Location = new System.Drawing.Point(703, 557);
            this.Mainbutton.Name = "Mainbutton";
            this.Mainbutton.Size = new System.Drawing.Size(75, 23);
            this.Mainbutton.TabIndex = 0;
            this.Mainbutton.Text = "主界面";
            this.Mainbutton.UseVisualStyleBackColor = true;
            this.Mainbutton.Click += new System.EventHandler(this.Mainbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AGVS.Properties.Resources.微信图片_20210506123643;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "恺韵来AGV状态监控";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView warning;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AGVcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Disconnectbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.TextBox IPbox;
        private System.Windows.Forms.TextBox Combox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Deletbutton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Mainbutton;
    }
}

