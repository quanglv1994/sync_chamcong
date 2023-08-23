namespace Dong_bo_cham_cong.Frm.VnEdu
{
  partial class frm_cauhinh_chung_vnEdu
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
      this.btn_close = new System.Windows.Forms.Button();
      this.txt_Url = new System.Windows.Forms.TextBox();
      this.lb_url = new System.Windows.Forms.Label();
      this.btn_save = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btn_close);
      this.groupBox1.Controls.Add(this.txt_Url);
      this.groupBox1.Controls.Add(this.lb_url);
      this.groupBox1.Controls.Add(this.btn_save);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(691, 130);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Cấu hình tham số API VnEdu";
      // 
      // btn_close
      // 
      this.btn_close.Location = new System.Drawing.Point(343, 95);
      this.btn_close.Name = "btn_close";
      this.btn_close.Size = new System.Drawing.Size(75, 23);
      this.btn_close.TabIndex = 3;
      this.btn_close.Text = "Đóng lại";
      this.btn_close.UseVisualStyleBackColor = true;
      this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
      // 
      // txt_Url
      // 
      this.txt_Url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Url.Location = new System.Drawing.Point(81, 31);
      this.txt_Url.Name = "txt_Url";
      this.txt_Url.Size = new System.Drawing.Size(598, 22);
      this.txt_Url.TabIndex = 2;
      // 
      // lb_url
      // 
      this.lb_url.AutoSize = true;
      this.lb_url.Location = new System.Drawing.Point(13, 34);
      this.lb_url.Name = "lb_url";
      this.lb_url.Size = new System.Drawing.Size(59, 16);
      this.lb_url.TabIndex = 1;
      this.lb_url.Text = "Url API *:";
      // 
      // btn_save
      // 
      this.btn_save.Location = new System.Drawing.Point(262, 95);
      this.btn_save.Name = "btn_save";
      this.btn_save.Size = new System.Drawing.Size(75, 23);
      this.btn_save.TabIndex = 0;
      this.btn_save.Text = "Lưu lại";
      this.btn_save.UseVisualStyleBackColor = true;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      // 
      // frm_cauhinh_chung_vnEdu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(691, 130);
      this.Controls.Add(this.groupBox1);
      this.Name = "frm_cauhinh_chung_vnEdu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Cấu hình chung vnEdu";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txt_Url;
    private System.Windows.Forms.Label lb_url;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_close;
  }
}