namespace Dong_bo_cham_cong.Frm.VnEdu
{
  partial class frm_cauhinh_thietbi_vnEdu
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cb_thietbi_diemdanh = new System.Windows.Forms.ComboBox();
      this.btn_timkiem = new System.Windows.Forms.Button();
      this.btn_save = new System.Windows.Forms.Button();
      this.btn_add = new System.Windows.Forms.Button();
      this.txt_ma = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_key_vnEdu = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txt_SN_vnEdu = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.grv_devices = new System.Windows.Forms.DataGridView();
      this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SN_vnEdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.key_vnEdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Btn_edit = new System.Windows.Forms.DataGridViewButtonColumn();
      this.Btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
      this.btn_close = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_devices)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btn_close);
      this.groupBox1.Controls.Add(this.cb_thietbi_diemdanh);
      this.groupBox1.Controls.Add(this.btn_timkiem);
      this.groupBox1.Controls.Add(this.btn_save);
      this.groupBox1.Controls.Add(this.btn_add);
      this.groupBox1.Controls.Add(this.txt_ma);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txt_key_vnEdu);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txt_SN_vnEdu);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1016, 158);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thiết bị điểm danh VnEdu";
      // 
      // cb_thietbi_diemdanh
      // 
      this.cb_thietbi_diemdanh.FormattingEnabled = true;
      this.cb_thietbi_diemdanh.Location = new System.Drawing.Point(563, 28);
      this.cb_thietbi_diemdanh.Name = "cb_thietbi_diemdanh";
      this.cb_thietbi_diemdanh.Size = new System.Drawing.Size(207, 24);
      this.cb_thietbi_diemdanh.TabIndex = 26;
      this.cb_thietbi_diemdanh.TextChanged += new System.EventHandler(this.cb_thietbi_diemdanh_TextChanged);
      // 
      // btn_timkiem
      // 
      this.btn_timkiem.Location = new System.Drawing.Point(495, 114);
      this.btn_timkiem.Name = "btn_timkiem";
      this.btn_timkiem.Size = new System.Drawing.Size(93, 23);
      this.btn_timkiem.TabIndex = 25;
      this.btn_timkiem.Text = "Tìm kiếm";
      this.btn_timkiem.UseVisualStyleBackColor = true;
      this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
      // 
      // btn_save
      // 
      this.btn_save.Location = new System.Drawing.Point(396, 114);
      this.btn_save.Name = "btn_save";
      this.btn_save.Size = new System.Drawing.Size(93, 23);
      this.btn_save.TabIndex = 24;
      this.btn_save.Text = "Lưu lại";
      this.btn_save.UseVisualStyleBackColor = true;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      // 
      // btn_add
      // 
      this.btn_add.Location = new System.Drawing.Point(297, 114);
      this.btn_add.Name = "btn_add";
      this.btn_add.Size = new System.Drawing.Size(93, 23);
      this.btn_add.TabIndex = 23;
      this.btn_add.Text = "Thêm mới";
      this.btn_add.UseVisualStyleBackColor = true;
      this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
      // 
      // txt_ma
      // 
      this.txt_ma.Enabled = false;
      this.txt_ma.Location = new System.Drawing.Point(563, 63);
      this.txt_ma.Name = "txt_ma";
      this.txt_ma.Size = new System.Drawing.Size(207, 22);
      this.txt_ma.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(429, 66);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(121, 16);
      this.label4.TabIndex = 6;
      this.label4.Text = "Mã thiết bị (Serial)*:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(429, 33);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 16);
      this.label3.TabIndex = 4;
      this.label3.Text = "Tên máy* :";
      // 
      // txt_key_vnEdu
      // 
      this.txt_key_vnEdu.Location = new System.Drawing.Point(133, 63);
      this.txt_key_vnEdu.Name = "txt_key_vnEdu";
      this.txt_key_vnEdu.Size = new System.Drawing.Size(229, 22);
      this.txt_key_vnEdu.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 66);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Key vnEdu *: ";
      // 
      // txt_SN_vnEdu
      // 
      this.txt_SN_vnEdu.Location = new System.Drawing.Point(133, 28);
      this.txt_SN_vnEdu.Name = "txt_SN_vnEdu";
      this.txt_SN_vnEdu.Size = new System.Drawing.Size(229, 22);
      this.txt_SN_vnEdu.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Số Serial vnEdu *:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.grv_devices);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 158);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1016, 292);
      this.groupBox2.TabIndex = 1;
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
            this.Ma,
            this.Ten,
            this.SN_vnEdu,
            this.key_vnEdu,
            this.Btn_edit,
            this.Btn_delete});
      this.grv_devices.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grv_devices.Location = new System.Drawing.Point(3, 18);
      this.grv_devices.Name = "grv_devices";
      this.grv_devices.RowHeadersWidth = 51;
      this.grv_devices.RowTemplate.Height = 24;
      this.grv_devices.Size = new System.Drawing.Size(1010, 271);
      this.grv_devices.TabIndex = 1;
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
      // SN_vnEdu
      // 
      this.SN_vnEdu.DataPropertyName = "SN_vnEdu";
      this.SN_vnEdu.HeaderText = "Số Serial vnEdu";
      this.SN_vnEdu.MinimumWidth = 6;
      this.SN_vnEdu.Name = "SN_vnEdu";
      this.SN_vnEdu.Width = 180;
      // 
      // key_vnEdu
      // 
      this.key_vnEdu.DataPropertyName = "key_vnEdu";
      this.key_vnEdu.HeaderText = "Key vnEdu";
      this.key_vnEdu.MinimumWidth = 6;
      this.key_vnEdu.Name = "key_vnEdu";
      this.key_vnEdu.Width = 120;
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
      // btn_close
      // 
      this.btn_close.Location = new System.Drawing.Point(594, 114);
      this.btn_close.Name = "btn_close";
      this.btn_close.Size = new System.Drawing.Size(93, 23);
      this.btn_close.TabIndex = 27;
      this.btn_close.Text = "Đóng lại";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
      // 
      // frm_cauhinh_thietbi_vnEdu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1016, 450);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frm_cauhinh_thietbi_vnEdu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Cấu hình thiết bị vnEdu";
      this.Load += new System.EventHandler(this.frm_cauhinh_thietbi_vnEdu_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grv_devices)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txt_key_vnEdu;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_SN_vnEdu;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_ma;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btn_timkiem;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_add;
    private System.Windows.Forms.DataGridView grv_devices;
    private System.Windows.Forms.ComboBox cb_thietbi_diemdanh;
    private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    private System.Windows.Forms.DataGridViewTextBoxColumn SN_vnEdu;
    private System.Windows.Forms.DataGridViewTextBoxColumn key_vnEdu;
    private System.Windows.Forms.DataGridViewButtonColumn Btn_edit;
    private System.Windows.Forms.DataGridViewButtonColumn Btn_delete;
    private System.Windows.Forms.Button btn_close;
  }
}