namespace Dong_bo_cham_cong.Frm
{
  partial class frm_cauhinh_chung
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
      this.txtUrlCloud = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.ckCheckCloud = new System.Windows.Forms.CheckBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnClose);
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.ckCheckCloud);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtUrlCloud);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 131);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Cấu hình chung";
      // 
      // txtUrlCloud
      // 
      this.txtUrlCloud.Location = new System.Drawing.Point(292, 22);
      this.txtUrlCloud.Name = "txtUrlCloud";
      this.txtUrlCloud.Size = new System.Drawing.Size(486, 22);
      this.txtUrlCloud.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(201, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 16);
      this.label1.TabIndex = 1;
      this.label1.Text = "Đường dẫn:";
      // 
      // ckCheckCloud
      // 
      this.ckCheckCloud.AutoSize = true;
      this.ckCheckCloud.Location = new System.Drawing.Point(15, 22);
      this.ckCheckCloud.Name = "ckCheckCloud";
      this.ckCheckCloud.Size = new System.Drawing.Size(116, 20);
      this.ckCheckCloud.TabIndex = 2;
      this.ckCheckCloud.Text = "Sử dụng Cloud";
      this.ckCheckCloud.UseVisualStyleBackColor = true;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(316, 85);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Lưu lại";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(397, 85);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "Đóng lại";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frm_cauhinh_chung
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 131);
      this.Controls.Add(this.groupBox1);
      this.Name = "frm_cauhinh_chung";
      this.Text = "Cấu hình chung";
      this.Load += new System.EventHandler(this.frm_cauhinh_chung_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox ckCheckCloud;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUrlCloud;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSave;
  }
}