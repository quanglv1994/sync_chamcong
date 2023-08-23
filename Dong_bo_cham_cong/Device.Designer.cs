
namespace Dong_bo_cham_cong
{
  partial class frm_Device
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Device));
      this.panel2 = new System.Windows.Forms.Panel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.grv_devices = new System.Windows.Forms.DataGridView();
      this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Btn_edit = new System.Windows.Forms.DataGridViewButtonColumn();
      this.Btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
      this.Btn_log = new System.Windows.Forms.DataGridViewButtonColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lbTime = new System.Windows.Forms.Label();
      this.btn_close = new System.Windows.Forms.Button();
      this.btn_timkiem = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.txt_password = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txt_username = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txt_port = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txt_model = new System.Windows.Forms.TextBox();
      this.cb_vendor = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btn_save = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_ip = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txt_ma = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txt_name = new System.Windows.Forms.TextBox();
      this.btn_add = new System.Windows.Forms.Button();
      this.notifyIconSystem = new System.Windows.Forms.NotifyIcon(this.components);
      this.ctMenuTrayIconSytem = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_devices)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.ctMenuTrayIconSytem.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 221);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1279, 288);
      this.panel2.TabIndex = 2;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.grv_devices);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1279, 288);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Danh sách thiết bị";
      // 
      // grv_devices
      // 
      this.grv_devices.AllowUserToAddRows = false;
      this.grv_devices.AllowUserToOrderColumns = true;
      this.grv_devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grv_devices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.Id,
            this.Ma,
            this.Ten,
            this.Ip,
            this.Port,
            this.Username,
            this.Password,
            this.Hang,
            this.Model,
            this.Trang_thai,
            this.Btn_edit,
            this.Btn_delete,
            this.Btn_log});
      this.grv_devices.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grv_devices.Location = new System.Drawing.Point(3, 18);
      this.grv_devices.Name = "grv_devices";
      this.grv_devices.RowHeadersWidth = 51;
      this.grv_devices.RowTemplate.Height = 24;
      this.grv_devices.Size = new System.Drawing.Size(1273, 267);
      this.grv_devices.TabIndex = 0;
      this.grv_devices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_devices_CellContentClick);
      // 
      // Stt
      // 
      this.Stt.DataPropertyName = "Stt";
      this.Stt.HeaderText = "STT";
      this.Stt.MinimumWidth = 6;
      this.Stt.Name = "Stt";
      this.Stt.Width = 50;
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      this.Id.HeaderText = "ID";
      this.Id.MinimumWidth = 6;
      this.Id.Name = "Id";
      this.Id.Width = 50;
      // 
      // Ma
      // 
      this.Ma.DataPropertyName = "Ma";
      this.Ma.HeaderText = "Mã thiết bị";
      this.Ma.MinimumWidth = 6;
      this.Ma.Name = "Ma";
      this.Ma.Width = 105;
      // 
      // Ten
      // 
      this.Ten.DataPropertyName = "Ten";
      this.Ten.HeaderText = "Tên thiết bị";
      this.Ten.MinimumWidth = 6;
      this.Ten.Name = "Ten";
      this.Ten.Width = 125;
      // 
      // Ip
      // 
      this.Ip.DataPropertyName = "Ip";
      this.Ip.HeaderText = "IP";
      this.Ip.MinimumWidth = 6;
      this.Ip.Name = "Ip";
      this.Ip.Width = 125;
      // 
      // Port
      // 
      this.Port.DataPropertyName = "Port";
      this.Port.HeaderText = "Port";
      this.Port.MinimumWidth = 6;
      this.Port.Name = "Port";
      this.Port.Width = 60;
      // 
      // Username
      // 
      this.Username.DataPropertyName = "Username";
      this.Username.HeaderText = "Username";
      this.Username.MinimumWidth = 6;
      this.Username.Name = "Username";
      this.Username.Width = 80;
      // 
      // Password
      // 
      this.Password.DataPropertyName = "Password";
      this.Password.HeaderText = "Password";
      this.Password.MinimumWidth = 6;
      this.Password.Name = "Password";
      this.Password.Width = 80;
      // 
      // Hang
      // 
      this.Hang.DataPropertyName = "Hang";
      this.Hang.HeaderText = "Hãng";
      this.Hang.MinimumWidth = 6;
      this.Hang.Name = "Hang";
      this.Hang.Width = 85;
      // 
      // Model
      // 
      this.Model.DataPropertyName = "Model";
      this.Model.HeaderText = "Model";
      this.Model.MinimumWidth = 6;
      this.Model.Name = "Model";
      this.Model.Width = 125;
      // 
      // Trang_thai
      // 
      this.Trang_thai.DataPropertyName = "Trang_thai";
      this.Trang_thai.HeaderText = "Trạng thái";
      this.Trang_thai.MinimumWidth = 6;
      this.Trang_thai.Name = "Trang_thai";
      this.Trang_thai.Width = 125;
      // 
      // Btn_edit
      // 
      this.Btn_edit.HeaderText = "Sửa";
      this.Btn_edit.MinimumWidth = 6;
      this.Btn_edit.Name = "Btn_edit";
      this.Btn_edit.Text = "Sửa";
      this.Btn_edit.UseColumnTextForButtonValue = true;
      this.Btn_edit.Width = 60;
      // 
      // Btn_delete
      // 
      this.Btn_delete.HeaderText = "Xóa";
      this.Btn_delete.MinimumWidth = 6;
      this.Btn_delete.Name = "Btn_delete";
      this.Btn_delete.Text = "Xóa";
      this.Btn_delete.UseColumnTextForButtonValue = true;
      this.Btn_delete.Width = 60;
      // 
      // Btn_log
      // 
      this.Btn_log.HeaderText = "Xem log";
      this.Btn_log.MinimumWidth = 6;
      this.Btn_log.Name = "Btn_log";
      this.Btn_log.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Btn_log.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.Btn_log.Text = "Log";
      this.Btn_log.UseColumnTextForButtonValue = true;
      this.Btn_log.Width = 60;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lbTime);
      this.groupBox1.Controls.Add(this.btn_close);
      this.groupBox1.Controls.Add(this.btn_timkiem);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.txt_password);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.txt_username);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.txt_port);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.txt_model);
      this.groupBox1.Controls.Add(this.cb_vendor);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.btn_save);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txt_ip);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txt_ma);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txt_name);
      this.groupBox1.Controls.Add(this.btn_add);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox1.Location = new System.Drawing.Point(0, 31);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1279, 190);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thiết bị chấm công";
      // 
      // lbTime
      // 
      this.lbTime.AutoSize = true;
      this.lbTime.Location = new System.Drawing.Point(931, 138);
      this.lbTime.Name = "lbTime";
      this.lbTime.Size = new System.Drawing.Size(14, 16);
      this.lbTime.TabIndex = 24;
      this.lbTime.Text = "0";
      // 
      // btn_close
      // 
      this.btn_close.Location = new System.Drawing.Point(712, 154);
      this.btn_close.Name = "btn_close";
      this.btn_close.Size = new System.Drawing.Size(93, 23);
      this.btn_close.TabIndex = 23;
      this.btn_close.Text = "Đóng lại";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
      // 
      // btn_timkiem
      // 
      this.btn_timkiem.Location = new System.Drawing.Point(613, 154);
      this.btn_timkiem.Name = "btn_timkiem";
      this.btn_timkiem.Size = new System.Drawing.Size(93, 23);
      this.btn_timkiem.TabIndex = 22;
      this.btn_timkiem.Text = "Tìm kiếm";
      this.btn_timkiem.UseVisualStyleBackColor = true;
      this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(447, 60);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(70, 16);
      this.label9.TabIndex = 21;
      this.label9.Text = "Password:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_password
      // 
      this.txt_password.Enabled = false;
      this.txt_password.Location = new System.Drawing.Point(532, 65);
      this.txt_password.Name = "txt_password";
      this.txt_password.Size = new System.Drawing.Size(227, 22);
      this.txt_password.TabIndex = 20;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(447, 28);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(73, 16);
      this.label8.TabIndex = 19;
      this.label8.Text = "Username:";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_username
      // 
      this.txt_username.Enabled = false;
      this.txt_username.Location = new System.Drawing.Point(532, 33);
      this.txt_username.Name = "txt_username";
      this.txt_username.Size = new System.Drawing.Size(227, 22);
      this.txt_username.TabIndex = 18;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(447, 90);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(34, 16);
      this.label7.TabIndex = 17;
      this.label7.Text = "Port:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_port
      // 
      this.txt_port.Enabled = false;
      this.txt_port.Location = new System.Drawing.Point(532, 97);
      this.txt_port.Name = "txt_port";
      this.txt_port.Size = new System.Drawing.Size(227, 22);
      this.txt_port.TabIndex = 16;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(846, 60);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 16);
      this.label6.TabIndex = 15;
      this.label6.Text = "Model:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_model
      // 
      this.txt_model.Location = new System.Drawing.Point(931, 64);
      this.txt_model.Name = "txt_model";
      this.txt_model.Size = new System.Drawing.Size(227, 22);
      this.txt_model.TabIndex = 14;
      // 
      // cb_vendor
      // 
      this.cb_vendor.FormattingEnabled = true;
      this.cb_vendor.Location = new System.Drawing.Point(931, 32);
      this.cb_vendor.Name = "cb_vendor";
      this.cb_vendor.Size = new System.Drawing.Size(227, 24);
      this.cb_vendor.TabIndex = 13;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(846, 28);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(43, 16);
      this.label5.TabIndex = 12;
      this.label5.Text = "Hãng:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btn_save
      // 
      this.btn_save.Location = new System.Drawing.Point(514, 154);
      this.btn_save.Name = "btn_save";
      this.btn_save.Size = new System.Drawing.Size(93, 23);
      this.btn_save.TabIndex = 10;
      this.btn_save.Text = "Lưu lại";
      this.btn_save.UseVisualStyleBackColor = true;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 16);
      this.label3.TabIndex = 6;
      this.label3.Text = "Địa chỉ IP:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_ip
      // 
      this.txt_ip.Location = new System.Drawing.Point(158, 97);
      this.txt_ip.Name = "txt_ip";
      this.txt_ip.Size = new System.Drawing.Size(227, 22);
      this.txt_ip.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(113, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Mã thiết bị(Serial):";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_ma
      // 
      this.txt_ma.Location = new System.Drawing.Point(158, 32);
      this.txt_ma.Name = "txt_ma";
      this.txt_ma.Size = new System.Drawing.Size(227, 22);
      this.txt_ma.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Tên thiết bị:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_name
      // 
      this.txt_name.Location = new System.Drawing.Point(158, 64);
      this.txt_name.Name = "txt_name";
      this.txt_name.Size = new System.Drawing.Size(227, 22);
      this.txt_name.TabIndex = 1;
      // 
      // btn_add
      // 
      this.btn_add.Location = new System.Drawing.Point(415, 154);
      this.btn_add.Name = "btn_add";
      this.btn_add.Size = new System.Drawing.Size(93, 23);
      this.btn_add.TabIndex = 0;
      this.btn_add.Text = "Thêm mới";
      this.btn_add.UseVisualStyleBackColor = true;
      this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
      // 
      // notifyIconSystem
      // 
      this.notifyIconSystem.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.notifyIconSystem.BalloonTipText = "Đồng bộ dữ liệu chấm công VNPT";
      this.notifyIconSystem.BalloonTipTitle = "Đồng bộ dữ liệu chấm công";
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
            this.closeToolStripMenuItem});
      this.ctMenuTrayIconSytem.Name = "ctMenuTrayIconSytem";
      this.ctMenuTrayIconSytem.Size = new System.Drawing.Size(188, 52);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
      this.openToolStripMenuItem.Text = "Mở";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
      this.closeToolStripMenuItem.Text = "Tắt chương trình";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1279, 32);
      this.panel1.TabIndex = 5;
      // 
      // frm_Device
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1279, 509);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panel2);
      this.Name = "frm_Device";
      this.Text = "Thiết bị chấm công";
      this.Load += new System.EventHandler(this.frm_Device_Load);
      this.Resize += new System.EventHandler(this.frm_Device_Resize);
      this.panel2.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grv_devices)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ctMenuTrayIconSytem.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView grv_devices;
    private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ip;
    private System.Windows.Forms.DataGridViewTextBoxColumn Port;
    private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    private System.Windows.Forms.DataGridViewTextBoxColumn Hang;
    private System.Windows.Forms.DataGridViewTextBoxColumn Model;
    private System.Windows.Forms.DataGridViewTextBoxColumn Trang_thai;
    private System.Windows.Forms.DataGridViewButtonColumn Btn_edit;
    private System.Windows.Forms.DataGridViewButtonColumn Btn_delete;
    private System.Windows.Forms.DataGridViewButtonColumn Btn_log;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btn_timkiem;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txt_password;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txt_username;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txt_port;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txt_model;
    private System.Windows.Forms.ComboBox cb_vendor;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_ip;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_ma;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txt_name;
    private System.Windows.Forms.Button btn_add;
    private System.Windows.Forms.NotifyIcon notifyIconSystem;
    private System.Windows.Forms.ContextMenuStrip ctMenuTrayIconSytem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.Button btn_close;
    private System.Windows.Forms.Label lbTime;
    private System.Windows.Forms.Panel panel1;
  }
}