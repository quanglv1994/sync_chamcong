namespace Dong_bo_cham_cong.Frm
{
  partial class frm_cauhinh_calamviec
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
      this.btnClose = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtEndMinute = new System.Windows.Forms.NumericUpDown();
      this.txtEndHour = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtStartMinute = new System.Windows.Forms.NumericUpDown();
      this.txtStartHour = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.txtTen = new System.Windows.Forms.TextBox();
      this.lbTen = new System.Windows.Forms.Label();
      this.txtMa = new System.Windows.Forms.TextBox();
      this.lbMa = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.grvCaLamViec = new System.Windows.Forms.DataGridView();
      this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
      this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grvCaLamViec)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnClose);
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.btnAdd);
      this.groupBox1.Controls.Add(this.txtEndMinute);
      this.groupBox1.Controls.Add(this.txtEndHour);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtStartMinute);
      this.groupBox1.Controls.Add(this.txtStartHour);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtTen);
      this.groupBox1.Controls.Add(this.lbTen);
      this.groupBox1.Controls.Add(this.txtMa);
      this.groupBox1.Controls.Add(this.lbMa);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 141);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Cấu hình ca điểm danh";
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(426, 106);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 13;
      this.btnClose.Text = "Đóng";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(345, 106);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 12;
      this.btnSave.Text = "Lưu lại";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(264, 106);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 11;
      this.btnAdd.Text = "Thêm mới";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtEndMinute
      // 
      this.txtEndMinute.Location = new System.Drawing.Point(526, 64);
      this.txtEndMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.txtEndMinute.Name = "txtEndMinute";
      this.txtEndMinute.Size = new System.Drawing.Size(56, 22);
      this.txtEndMinute.TabIndex = 10;
      // 
      // txtEndHour
      // 
      this.txtEndHour.Location = new System.Drawing.Point(452, 64);
      this.txtEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.txtEndHour.Name = "txtEndHour";
      this.txtEndHour.Size = new System.Drawing.Size(56, 22);
      this.txtEndHour.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(337, 66);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(108, 16);
      this.label3.TabIndex = 8;
      this.label3.Text = "Giờ/phút kết thúc:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(191, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(10, 16);
      this.label2.TabIndex = 7;
      this.label2.Text = ":";
      // 
      // txtStartMinute
      // 
      this.txtStartMinute.Location = new System.Drawing.Point(201, 60);
      this.txtStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.txtStartMinute.Name = "txtStartMinute";
      this.txtStartMinute.Size = new System.Drawing.Size(56, 22);
      this.txtStartMinute.TabIndex = 6;
      // 
      // txtStartHour
      // 
      this.txtStartHour.Location = new System.Drawing.Point(129, 60);
      this.txtStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.txtStartHour.Name = "txtStartHour";
      this.txtStartHour.Size = new System.Drawing.Size(56, 22);
      this.txtStartHour.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 16);
      this.label1.TabIndex = 4;
      this.label1.Text = "Giờ/phút bắt đầu:";
      // 
      // txtTen
      // 
      this.txtTen.Location = new System.Drawing.Point(451, 26);
      this.txtTen.Name = "txtTen";
      this.txtTen.Size = new System.Drawing.Size(343, 22);
      this.txtTen.TabIndex = 3;
      // 
      // lbTen
      // 
      this.lbTen.AutoSize = true;
      this.lbTen.Location = new System.Drawing.Point(393, 29);
      this.lbTen.Name = "lbTen";
      this.lbTen.Size = new System.Drawing.Size(52, 16);
      this.lbTen.TabIndex = 2;
      this.lbTen.Text = "Tên ca:";
      // 
      // txtMa
      // 
      this.txtMa.Location = new System.Drawing.Point(128, 26);
      this.txtMa.Name = "txtMa";
      this.txtMa.Size = new System.Drawing.Size(158, 22);
      this.txtMa.TabIndex = 1;
      // 
      // lbMa
      // 
      this.lbMa.AutoSize = true;
      this.lbMa.Location = new System.Drawing.Point(93, 29);
      this.lbMa.Name = "lbMa";
      this.lbMa.Size = new System.Drawing.Size(29, 16);
      this.lbMa.TabIndex = 0;
      this.lbMa.Text = "Mã:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.grvCaLamViec);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 141);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(800, 309);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Danh sách ca điểm danh";
      // 
      // grvCaLamViec
      // 
      this.grvCaLamViec.AllowUserToAddRows = false;
      this.grvCaLamViec.AllowUserToDeleteRows = false;
      this.grvCaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvCaLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma,
            this.Ten,
            this.StartTime,
            this.EndTime,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.btnEdit,
            this.btnDelete});
      this.grvCaLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grvCaLamViec.Location = new System.Drawing.Point(3, 18);
      this.grvCaLamViec.Name = "grvCaLamViec";
      this.grvCaLamViec.ReadOnly = true;
      this.grvCaLamViec.RowHeadersWidth = 51;
      this.grvCaLamViec.RowTemplate.Height = 24;
      this.grvCaLamViec.Size = new System.Drawing.Size(794, 288);
      this.grvCaLamViec.TabIndex = 0;
      this.grvCaLamViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCaLamViec_CellContentClick);
      // 
      // STT
      // 
      this.STT.DataPropertyName = "STT";
      this.STT.HeaderText = "STT";
      this.STT.MinimumWidth = 6;
      this.STT.Name = "STT";
      this.STT.ReadOnly = true;
      this.STT.Width = 40;
      // 
      // Ma
      // 
      this.Ma.DataPropertyName = "Ma";
      this.Ma.HeaderText = "Mã ca";
      this.Ma.MinimumWidth = 6;
      this.Ma.Name = "Ma";
      this.Ma.ReadOnly = true;
      this.Ma.Width = 125;
      // 
      // Ten
      // 
      this.Ten.DataPropertyName = "Ten";
      this.Ten.HeaderText = "Tên ca";
      this.Ten.MinimumWidth = 6;
      this.Ten.Name = "Ten";
      this.Ten.ReadOnly = true;
      this.Ten.Width = 180;
      // 
      // StartTime
      // 
      this.StartTime.DataPropertyName = "StartTime";
      this.StartTime.HeaderText = "Thời gian bắt đầu";
      this.StartTime.MinimumWidth = 6;
      this.StartTime.Name = "StartTime";
      this.StartTime.ReadOnly = true;
      this.StartTime.Width = 125;
      // 
      // EndTime
      // 
      this.EndTime.DataPropertyName = "EndTime";
      this.EndTime.HeaderText = "Thời gian kết thúc";
      this.EndTime.MinimumWidth = 6;
      this.EndTime.Name = "EndTime";
      this.EndTime.ReadOnly = true;
      this.EndTime.Width = 125;
      // 
      // Column1
      // 
      this.Column1.DataPropertyName = "StartHour";
      this.Column1.HeaderText = "StartHour";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Visible = false;
      this.Column1.Width = 125;
      // 
      // Column2
      // 
      this.Column2.DataPropertyName = "StartMinute";
      this.Column2.HeaderText = "StartMinute";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Visible = false;
      this.Column2.Width = 125;
      // 
      // Column3
      // 
      this.Column3.DataPropertyName = "EndMinute";
      this.Column3.HeaderText = "EndMinute";
      this.Column3.MinimumWidth = 6;
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Visible = false;
      this.Column3.Width = 125;
      // 
      // Column4
      // 
      this.Column4.DataPropertyName = "EndHour";
      this.Column4.HeaderText = "EndHour";
      this.Column4.MinimumWidth = 6;
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Visible = false;
      this.Column4.Width = 125;
      // 
      // btnEdit
      // 
      this.btnEdit.HeaderText = "Sửa";
      this.btnEdit.MinimumWidth = 6;
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.ReadOnly = true;
      this.btnEdit.Text = "Sửa";
      this.btnEdit.UseColumnTextForButtonValue = true;
      this.btnEdit.Width = 60;
      // 
      // btnDelete
      // 
      this.btnDelete.HeaderText = "Xóa";
      this.btnDelete.MinimumWidth = 6;
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.ReadOnly = true;
      this.btnDelete.Text = "Xóa";
      this.btnDelete.UseColumnTextForButtonValue = true;
      this.btnDelete.Width = 60;
      // 
      // frm_cauhinh_calamviec
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frm_cauhinh_calamviec";
      this.Text = "frm_cauhinh_calamviec";
      this.Load += new System.EventHandler(this.frm_cauhinh_calamviec_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtEndMinute)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartMinute)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grvCaLamViec)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtMa;
    private System.Windows.Forms.Label lbMa;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtTen;
    private System.Windows.Forms.Label lbTen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown txtStartMinute;
    private System.Windows.Forms.NumericUpDown txtStartHour;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown txtEndMinute;
    private System.Windows.Forms.NumericUpDown txtEndHour;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridView grvCaLamViec;
    private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
    private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
  }
}