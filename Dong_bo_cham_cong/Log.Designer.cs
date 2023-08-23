
namespace Dong_bo_cham_cong
{
  partial class frm_log
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_trangSau = new System.Windows.Forms.Button();
      this.btn_trangTruoc = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.lb_totalPage = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_page = new System.Windows.Forms.TextBox();
      this.grv_logs = new System.Windows.Forms.DataGridView();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btn_dongbo = new System.Windows.Forms.Button();
      this.btn_close = new System.Windows.Forms.Button();
      this.btn_search = new System.Windows.Forms.Button();
      this.txt_denngay = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.txt_tungay = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_dongbo_vnEdu = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_logs)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.grv_logs);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox1.Location = new System.Drawing.Point(0, 126);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1124, 398);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Danh sách";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_trangSau);
      this.panel1.Controls.Add(this.btn_trangTruoc);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.lb_totalPage);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.txt_page);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(3, 363);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1118, 32);
      this.panel1.TabIndex = 1;
      // 
      // btn_trangSau
      // 
      this.btn_trangSau.Location = new System.Drawing.Point(707, 4);
      this.btn_trangSau.Name = "btn_trangSau";
      this.btn_trangSau.Size = new System.Drawing.Size(75, 23);
      this.btn_trangSau.TabIndex = 5;
      this.btn_trangSau.Text = "Sau";
      this.btn_trangSau.UseVisualStyleBackColor = true;
      this.btn_trangSau.Click += new System.EventHandler(this.btn_trangSau_Click);
      // 
      // btn_trangTruoc
      // 
      this.btn_trangTruoc.Location = new System.Drawing.Point(544, 5);
      this.btn_trangTruoc.Name = "btn_trangTruoc";
      this.btn_trangTruoc.Size = new System.Drawing.Size(75, 23);
      this.btn_trangTruoc.TabIndex = 4;
      this.btn_trangTruoc.Text = "Trước";
      this.btn_trangTruoc.UseVisualStyleBackColor = true;
      this.btn_trangTruoc.Click += new System.EventHandler(this.btn_trangTruoc_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(489, 7);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 16);
      this.label4.TabIndex = 3;
      this.label4.Text = "Trang:";
      // 
      // lb_totalPage
      // 
      this.lb_totalPage.AutoSize = true;
      this.lb_totalPage.Location = new System.Drawing.Point(686, 7);
      this.lb_totalPage.Name = "lb_totalPage";
      this.lb_totalPage.Size = new System.Drawing.Size(14, 16);
      this.lb_totalPage.TabIndex = 2;
      this.lb_totalPage.Text = "1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(678, 7);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(11, 16);
      this.label3.TabIndex = 1;
      this.label3.Text = "/";
      // 
      // txt_page
      // 
      this.txt_page.Location = new System.Drawing.Point(621, 5);
      this.txt_page.Name = "txt_page";
      this.txt_page.Size = new System.Drawing.Size(56, 22);
      this.txt_page.TabIndex = 0;
      this.txt_page.Text = "1";
      this.txt_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txt_page.TextChanged += new System.EventHandler(this.txt_page_TextChanged);
      this.txt_page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_page_KeyPress);
      // 
      // grv_logs
      // 
      this.grv_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grv_logs.Dock = System.Windows.Forms.DockStyle.Top;
      this.grv_logs.Location = new System.Drawing.Point(3, 18);
      this.grv_logs.Name = "grv_logs";
      this.grv_logs.RowHeadersWidth = 51;
      this.grv_logs.RowTemplate.Height = 24;
      this.grv_logs.Size = new System.Drawing.Size(1118, 343);
      this.grv_logs.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btn_dongbo_vnEdu);
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
      this.groupBox2.Size = new System.Drawing.Size(1124, 126);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tìm kiếm log";
      // 
      // btn_dongbo
      // 
      this.btn_dongbo.Enabled = false;
      this.btn_dongbo.Location = new System.Drawing.Point(467, 77);
      this.btn_dongbo.Name = "btn_dongbo";
      this.btn_dongbo.Size = new System.Drawing.Size(108, 23);
      this.btn_dongbo.TabIndex = 6;
      this.btn_dongbo.Text = "Đồng bộ HRM";
      this.btn_dongbo.UseVisualStyleBackColor = true;
      this.btn_dongbo.Click += new System.EventHandler(this.btn_dongbo_Click);
      // 
      // btn_close
      // 
      this.btn_close.Location = new System.Drawing.Point(581, 40);
      this.btn_close.Name = "btn_close";
      this.btn_close.Size = new System.Drawing.Size(111, 23);
      this.btn_close.TabIndex = 5;
      this.btn_close.Text = "Đóng lại";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(467, 40);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(108, 23);
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
      // txt_tungay
      // 
      this.txt_tungay.CustomFormat = "";
      this.txt_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.txt_tungay.Location = new System.Drawing.Point(83, 41);
      this.txt_tungay.Name = "txt_tungay";
      this.txt_tungay.Size = new System.Drawing.Size(255, 22);
      this.txt_tungay.TabIndex = 1;
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
      // btn_dongbo_vnEdu
      // 
      this.btn_dongbo_vnEdu.Enabled = false;
      this.btn_dongbo_vnEdu.Location = new System.Drawing.Point(581, 76);
      this.btn_dongbo_vnEdu.Name = "btn_dongbo_vnEdu";
      this.btn_dongbo_vnEdu.Size = new System.Drawing.Size(111, 23);
      this.btn_dongbo_vnEdu.TabIndex = 7;
      this.btn_dongbo_vnEdu.Text = "Đồng bộ VnEdu";
      this.btn_dongbo_vnEdu.UseVisualStyleBackColor = true;
      this.btn_dongbo_vnEdu.Click += new System.EventHandler(this.btn_dongbo_vnEdu_Click);
      // 
      // frm_log
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1124, 524);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frm_log";
      this.Text = "Xem log thiết bị";
      this.Load += new System.EventHandler(this.frm_log_Load);
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grv_logs)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView grv_logs;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btn_search;
    private System.Windows.Forms.DateTimePicker txt_denngay;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker txt_tungay;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_close;
    private System.Windows.Forms.Button btn_dongbo;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_trangSau;
    private System.Windows.Forms.Button btn_trangTruoc;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lb_totalPage;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_page;
    private System.Windows.Forms.Button btn_dongbo_vnEdu;
  }
}