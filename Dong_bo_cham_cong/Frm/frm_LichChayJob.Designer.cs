namespace Dong_bo_cham_cong.Frm
{
  partial class frm_LichChayJob
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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lb_ma = new System.Windows.Forms.Label();
      this.txt_key = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txt_hour = new System.Windows.Forms.NumericUpDown();
      this.txt_minute = new System.Windows.Forms.NumericUpDown();
      this.btn_save = new System.Windows.Forms.Button();
      this.btn_close = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_name = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btn_add = new System.Windows.Forms.Button();
      this.grv_jobs = new System.Windows.Forms.DataGridView();
      this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btn_edit = new System.Windows.Forms.DataGridViewButtonColumn();
      this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_hour)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_minute)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_jobs)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.grv_jobs);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 100);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(788, 223);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Danh sách Job";
      // 
      // lb_ma
      // 
      this.lb_ma.AutoSize = true;
      this.lb_ma.Location = new System.Drawing.Point(13, 34);
      this.lb_ma.Name = "lb_ma";
      this.lb_ma.Size = new System.Drawing.Size(63, 16);
      this.lb_ma.TabIndex = 0;
      this.lb_ma.Text = "Mã Job* :";
      // 
      // txt_key
      // 
      this.txt_key.Location = new System.Drawing.Point(82, 31);
      this.txt_key.Name = "txt_key";
      this.txt_key.Size = new System.Drawing.Size(137, 22);
      this.txt_key.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(554, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Giờ:phút*:";
      // 
      // txt_hour
      // 
      this.txt_hour.Location = new System.Drawing.Point(637, 32);
      this.txt_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.txt_hour.Name = "txt_hour";
      this.txt_hour.Size = new System.Drawing.Size(53, 22);
      this.txt_hour.TabIndex = 3;
      // 
      // txt_minute
      // 
      this.txt_minute.Location = new System.Drawing.Point(711, 32);
      this.txt_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.txt_minute.Name = "txt_minute";
      this.txt_minute.Size = new System.Drawing.Size(53, 22);
      this.txt_minute.TabIndex = 4;
      // 
      // btn_save
      // 
      this.btn_save.Location = new System.Drawing.Point(324, 71);
      this.btn_save.Name = "btn_save";
      this.btn_save.Size = new System.Drawing.Size(75, 23);
      this.btn_save.TabIndex = 6;
      this.btn_save.Text = "Lưu lại";
      this.btn_save.UseVisualStyleBackColor = true;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      // 
      // btn_close
      // 
      this.btn_close.Location = new System.Drawing.Point(407, 71);
      this.btn_close.Name = "btn_close";
      this.btn_close.Size = new System.Drawing.Size(75, 23);
      this.btn_close.TabIndex = 7;
      this.btn_close.Text = "Đóng lại";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btn_add);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txt_name);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.btn_close);
      this.groupBox1.Controls.Add(this.btn_save);
      this.groupBox1.Controls.Add(this.txt_minute);
      this.groupBox1.Controls.Add(this.txt_hour);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txt_key);
      this.groupBox1.Controls.Add(this.lb_ma);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(788, 100);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Cấu hình Job";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(239, 34);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 16);
      this.label3.TabIndex = 8;
      this.label3.Text = "Tên Job* :";
      // 
      // txt_name
      // 
      this.txt_name.Location = new System.Drawing.Point(318, 31);
      this.txt_name.Name = "txt_name";
      this.txt_name.Size = new System.Drawing.Size(223, 22);
      this.txt_name.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(696, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(10, 16);
      this.label2.TabIndex = 10;
      this.label2.Text = ":";
      // 
      // btn_add
      // 
      this.btn_add.Location = new System.Drawing.Point(239, 71);
      this.btn_add.Name = "btn_add";
      this.btn_add.Size = new System.Drawing.Size(79, 23);
      this.btn_add.TabIndex = 11;
      this.btn_add.Text = "Thêm mới";
      this.btn_add.UseVisualStyleBackColor = true;
      this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
      // 
      // grv_jobs
      // 
      this.grv_jobs.AllowUserToAddRows = false;
      this.grv_jobs.AllowUserToDeleteRows = false;
      this.grv_jobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grv_jobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.Ma,
            this.Ten,
            this.Thoigian,
            this.btn_edit,
            this.btn_delete});
      this.grv_jobs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grv_jobs.Location = new System.Drawing.Point(3, 18);
      this.grv_jobs.Name = "grv_jobs";
      this.grv_jobs.RowHeadersWidth = 51;
      this.grv_jobs.RowTemplate.Height = 24;
      this.grv_jobs.Size = new System.Drawing.Size(782, 202);
      this.grv_jobs.TabIndex = 0;
      this.grv_jobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_jobs_CellContentClick);
      // 
      // Stt
      // 
      this.Stt.DataPropertyName = "Stt";
      this.Stt.HeaderText = "Stt";
      this.Stt.MinimumWidth = 6;
      this.Stt.Name = "Stt";
      this.Stt.Width = 50;
      // 
      // Ma
      // 
      this.Ma.DataPropertyName = "Ma";
      this.Ma.HeaderText = "Mã Job";
      this.Ma.MinimumWidth = 6;
      this.Ma.Name = "Ma";
      this.Ma.Width = 120;
      // 
      // Ten
      // 
      this.Ten.DataPropertyName = "Ten";
      this.Ten.HeaderText = "Tên Job";
      this.Ten.MinimumWidth = 6;
      this.Ten.Name = "Ten";
      this.Ten.Width = 160;
      // 
      // Thoigian
      // 
      this.Thoigian.DataPropertyName = "Thoigian";
      this.Thoigian.HeaderText = "Thời gian";
      this.Thoigian.MinimumWidth = 6;
      this.Thoigian.Name = "Thoigian";
      // 
      // btn_edit
      // 
      this.btn_edit.HeaderText = "Sửa";
      this.btn_edit.MinimumWidth = 6;
      this.btn_edit.Name = "btn_edit";
      this.btn_edit.Text = "Sửa";
      this.btn_edit.UseColumnTextForButtonValue = true;
      this.btn_edit.Width = 60;
      // 
      // btn_delete
      // 
      this.btn_delete.HeaderText = "Xóa";
      this.btn_delete.MinimumWidth = 6;
      this.btn_delete.Name = "btn_delete";
      this.btn_delete.Text = "Xóa";
      this.btn_delete.UseColumnTextForButtonValue = true;
      this.btn_delete.Width = 60;
      // 
      // frm_LichChayJob
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(788, 323);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frm_LichChayJob";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Cấu hình lịch chạy Job";
      this.Load += new System.EventHandler(this.frm_LichChayJob_Load);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txt_hour)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_minute)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_jobs)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView grv_jobs;
    private System.Windows.Forms.Label lb_ma;
    private System.Windows.Forms.TextBox txt_key;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown txt_hour;
    private System.Windows.Forms.NumericUpDown txt_minute;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_close;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btn_add;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_name;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    private System.Windows.Forms.DataGridViewTextBoxColumn Thoigian;
    private System.Windows.Forms.DataGridViewButtonColumn btn_edit;
    private System.Windows.Forms.DataGridViewButtonColumn btn_delete;
  }
}