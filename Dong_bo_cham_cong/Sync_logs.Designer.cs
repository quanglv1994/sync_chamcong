
namespace Dong_bo_cham_cong
{
  partial class Sync_logs
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
      this.btn_search = new System.Windows.Forms.Button();
      this.txt_denngay = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_dongbo = new System.Windows.Forms.Button();
      this.btn_close = new System.Windows.Forms.Button();
      this.txt_tungay = new System.Windows.Forms.DateTimePicker();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.grv_logs = new System.Windows.Forms.DataGridView();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_logs)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(467, 40);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(75, 23);
      this.btn_search.TabIndex = 4;
      this.btn_search.Text = "Tìm kiếm";
      this.btn_search.UseVisualStyleBackColor = true;
      this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
      // 
      // txt_denngay
      // 
      this.txt_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.txt_denngay.Location = new System.Drawing.Point(83, 78);
      this.txt_denngay.Name = "txt_denngay";
      this.txt_denngay.Size = new System.Drawing.Size(255, 22);
      this.txt_denngay.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Đến ngày:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Từ ngày:";
      // 
      // btn_dongbo
      // 
      this.btn_dongbo.Enabled = false;
      this.btn_dongbo.Location = new System.Drawing.Point(467, 77);
      this.btn_dongbo.Name = "btn_dongbo";
      this.btn_dongbo.Size = new System.Drawing.Size(168, 23);
      this.btn_dongbo.TabIndex = 6;
      this.btn_dongbo.Text = "Đồng bộ";
      this.btn_dongbo.UseVisualStyleBackColor = true;
      this.btn_dongbo.Click += new System.EventHandler(this.btn_dongbo_Click);
      // 
      // btn_close
      // 
      this.btn_close.Location = new System.Drawing.Point(560, 40);
      this.btn_close.Name = "btn_close";
      this.btn_close.Size = new System.Drawing.Size(75, 23);
      this.btn_close.TabIndex = 5;
      this.btn_close.Text = "Đóng lại";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
      // 
      // txt_tungay
      // 
      this.txt_tungay.CustomFormat = "";
      this.txt_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.txt_tungay.Location = new System.Drawing.Point(83, 41);
      this.txt_tungay.Name = "txt_tungay";
      this.txt_tungay.Size = new System.Drawing.Size(255, 22);
      this.txt_tungay.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.grv_logs);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox1.Location = new System.Drawing.Point(0, 125);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1268, 325);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Danh sách";
      // 
      // grv_logs
      // 
      this.grv_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grv_logs.Dock = System.Windows.Forms.DockStyle.Top;
      this.grv_logs.Location = new System.Drawing.Point(3, 18);
      this.grv_logs.Name = "grv_logs";
      this.grv_logs.RowHeadersWidth = 51;
      this.grv_logs.RowTemplate.Height = 24;
      this.grv_logs.Size = new System.Drawing.Size(1262, 307);
      this.grv_logs.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btn_dongbo);
      this.groupBox2.Controls.Add(this.btn_close);
      this.groupBox2.Controls.Add(this.btn_search);
      this.groupBox2.Controls.Add(this.txt_denngay);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.txt_tungay);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1268, 126);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tìm kiếm log";
      // 
      // Sync_logs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1268, 450);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Name = "Sync_logs";
      this.Text = "Đồng bộ tất cả dữ liệu chấm công";
      this.Load += new System.EventHandler(this.Sync_logs_Load);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grv_logs)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_search;
    private System.Windows.Forms.DateTimePicker txt_denngay;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_dongbo;
    private System.Windows.Forms.Button btn_close;
    private System.Windows.Forms.DateTimePicker txt_tungay;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView grv_logs;
    private System.Windows.Forms.GroupBox groupBox2;
  }
}