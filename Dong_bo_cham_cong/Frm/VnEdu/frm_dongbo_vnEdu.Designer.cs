namespace Dong_bo_cham_cong.Frm.VnEdu
{
  partial class frm_dongbo_vnEdu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dongbo_vnEdu));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btn_dongbo = new System.Windows.Forms.Button();
      this.btn_close = new System.Windows.Forms.Button();
      this.btn_search = new System.Windows.Forms.Button();
      this.txt_denngay = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.txt_tungay = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.grLogDevices = new System.Windows.Forms.GroupBox();
      this.grv_logs = new System.Windows.Forms.DataGridView();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.ltLogs = new System.Windows.Forms.ListView();
      this.notifyIconSystem = new System.Windows.Forms.NotifyIcon(this.components);
      this.ctMenuTrayIconSytem = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tuDongChayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tatTudongChayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel2 = new System.Windows.Forms.Panel();
      this.lbTotalSync = new System.Windows.Forms.Label();
      this.lbTotalLog = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.grLogDevices.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_logs)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.ctMenuTrayIconSytem.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btn_dongbo);
      this.groupBox1.Controls.Add(this.btn_close);
      this.groupBox1.Controls.Add(this.btn_search);
      this.groupBox1.Controls.Add(this.txt_denngay);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txt_tungay);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(0, 36);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(840, 104);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tìm kiếm điểm danh";
      // 
      // btn_dongbo
      // 
      this.btn_dongbo.Enabled = false;
      this.btn_dongbo.Location = new System.Drawing.Point(328, 77);
      this.btn_dongbo.Name = "btn_dongbo";
      this.btn_dongbo.Size = new System.Drawing.Size(98, 23);
      this.btn_dongbo.TabIndex = 13;
      this.btn_dongbo.Text = "Đồng bộ";
      this.btn_dongbo.UseVisualStyleBackColor = true;
      this.btn_dongbo.Click += new System.EventHandler(this.btn_dongbo_Click);
      // 
      // btn_close
      // 
      this.btn_close.Location = new System.Drawing.Point(432, 77);
      this.btn_close.Name = "btn_close";
      this.btn_close.Size = new System.Drawing.Size(75, 23);
      this.btn_close.TabIndex = 12;
      this.btn_close.Text = "Đóng lại";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(187, 77);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(135, 23);
      this.btn_search.TabIndex = 11;
      this.btn_search.Text = "Lấy dữ liệu";
      this.btn_search.UseVisualStyleBackColor = true;
      this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
      // 
      // txt_denngay
      // 
      this.txt_denngay.CustomFormat = "dd/MM/yyyy HH:mm";
      this.txt_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.txt_denngay.Location = new System.Drawing.Point(442, 33);
      this.txt_denngay.Name = "txt_denngay";
      this.txt_denngay.Size = new System.Drawing.Size(255, 22);
      this.txt_denngay.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(372, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 16);
      this.label2.TabIndex = 9;
      this.label2.Text = "Đến ngày:";
      // 
      // txt_tungay
      // 
      this.txt_tungay.CustomFormat = "dd/MM/yyyy HH:mm";
      this.txt_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.txt_tungay.Location = new System.Drawing.Point(80, 32);
      this.txt_tungay.Name = "txt_tungay";
      this.txt_tungay.Size = new System.Drawing.Size(255, 22);
      this.txt_tungay.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 16);
      this.label1.TabIndex = 7;
      this.label1.Text = "Từ ngày:";
      // 
      // grLogDevices
      // 
      this.grLogDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.grLogDevices.AutoSize = true;
      this.grLogDevices.Controls.Add(this.panel2);
      this.grLogDevices.Controls.Add(this.grv_logs);
      this.grLogDevices.Location = new System.Drawing.Point(0, 146);
      this.grLogDevices.Name = "grLogDevices";
      this.grLogDevices.Size = new System.Drawing.Size(840, 416);
      this.grLogDevices.TabIndex = 1;
      this.grLogDevices.TabStop = false;
      // 
      // grv_logs
      // 
      this.grv_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grv_logs.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.grv_logs.Location = new System.Drawing.Point(3, 43);
      this.grv_logs.Name = "grv_logs";
      this.grv_logs.RowHeadersWidth = 51;
      this.grv_logs.RowTemplate.Height = 24;
      this.grv_logs.Size = new System.Drawing.Size(834, 370);
      this.grv_logs.TabIndex = 1;
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.ltLogs);
      this.groupBox3.Location = new System.Drawing.Point(843, 36);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(491, 511);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Log";
      // 
      // ltLogs
      // 
      this.ltLogs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ltLogs.GridLines = true;
      this.ltLogs.HideSelection = false;
      this.ltLogs.Location = new System.Drawing.Point(3, 18);
      this.ltLogs.Name = "ltLogs";
      this.ltLogs.Size = new System.Drawing.Size(485, 490);
      this.ltLogs.Sorting = System.Windows.Forms.SortOrder.Descending;
      this.ltLogs.TabIndex = 0;
      this.ltLogs.UseCompatibleStateImageBehavior = false;
      this.ltLogs.View = System.Windows.Forms.View.List;
      // 
      // notifyIconSystem
      // 
      this.notifyIconSystem.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.notifyIconSystem.BalloonTipText = "Chuyển về chế độ chạy ngầm";
      this.notifyIconSystem.BalloonTipTitle = "Đồng bộ dữ liệu chấm công VNPT";
      this.notifyIconSystem.ContextMenuStrip = this.ctMenuTrayIconSytem;
      this.notifyIconSystem.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystem.Icon")));
      this.notifyIconSystem.Text = "Đồng bộ dữ liệu chấm công VNPT";
      this.notifyIconSystem.Visible = true;
      this.notifyIconSystem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystem_MouseDoubleClick);
      // 
      // ctMenuTrayIconSytem
      // 
      this.ctMenuTrayIconSytem.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.ctMenuTrayIconSytem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.tuDongChayToolStripMenuItem,
            this.tatTudongChayToolStripMenuItem,
            this.closeToolStripMenuItem});
      this.ctMenuTrayIconSytem.Name = "ctMenuTrayIconSytem";
      this.ctMenuTrayIconSytem.Size = new System.Drawing.Size(192, 100);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
      this.openToolStripMenuItem.Text = "Mở";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // tuDongChayToolStripMenuItem
      // 
      this.tuDongChayToolStripMenuItem.Name = "tuDongChayToolStripMenuItem";
      this.tuDongChayToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
      this.tuDongChayToolStripMenuItem.Text = "Bật tự động chạy";
      this.tuDongChayToolStripMenuItem.Click += new System.EventHandler(this.tuDongChayToolStripMenuItem_Click);
      // 
      // tatTudongChayToolStripMenuItem
      // 
      this.tatTudongChayToolStripMenuItem.Name = "tatTudongChayToolStripMenuItem";
      this.tatTudongChayToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
      this.tatTudongChayToolStripMenuItem.Text = "Tắt tự động chạy";
      this.tatTudongChayToolStripMenuItem.Click += new System.EventHandler(this.tatTudongChayToolStripMenuItem_Click);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
      this.closeToolStripMenuItem.Text = "Tắt chương trình";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1334, 30);
      this.panel1.TabIndex = 5;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 5000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lbTotalLog);
      this.panel2.Controls.Add(this.lbTotalSync);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 18);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(834, 25);
      this.panel2.TabIndex = 2;
      // 
      // lbTotalSync
      // 
      this.lbTotalSync.AutoSize = true;
      this.lbTotalSync.Dock = System.Windows.Forms.DockStyle.Left;
      this.lbTotalSync.Location = new System.Drawing.Point(0, 0);
      this.lbTotalSync.Name = "lbTotalSync";
      this.lbTotalSync.Size = new System.Drawing.Size(99, 16);
      this.lbTotalSync.TabIndex = 0;
      this.lbTotalSync.Text = "Tổng: 0 bản ghi";
      // 
      // lbTotalLog
      // 
      this.lbTotalLog.AutoSize = true;
      this.lbTotalLog.Dock = System.Windows.Forms.DockStyle.Right;
      this.lbTotalLog.Location = new System.Drawing.Point(669, 0);
      this.lbTotalLog.Name = "lbTotalLog";
      this.lbTotalLog.Size = new System.Drawing.Size(165, 16);
      this.lbTotalLog.TabIndex = 1;
      this.lbTotalLog.Text = "Tổng: 0 bản ghi điểm danh";
      // 
      // frm_dongbo_vnEdu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1334, 551);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.grLogDevices);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frm_dongbo_vnEdu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Đồng bộ dữ liệu đến vnEdu";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_dongbo_vnEdu_FormClosing);
      this.Load += new System.EventHandler(this.frm_dongbo_vnEdu_Load);
      this.Resize += new System.EventHandler(this.frm_dongbo_vnEdu_Resize);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.grLogDevices.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grv_logs)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.ctMenuTrayIconSytem.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox grLogDevices;
    private System.Windows.Forms.Button btn_dongbo;
    private System.Windows.Forms.Button btn_close;
    private System.Windows.Forms.Button btn_search;
    private System.Windows.Forms.DateTimePicker txt_denngay;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker txt_tungay;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView grv_logs;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.NotifyIcon notifyIconSystem;
    private System.Windows.Forms.ContextMenuStrip ctMenuTrayIconSytem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ToolStripMenuItem tuDongChayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tatTudongChayToolStripMenuItem;
    private System.Windows.Forms.ListView ltLogs;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lbTotalLog;
    private System.Windows.Forms.Label lbTotalSync;
  }
}