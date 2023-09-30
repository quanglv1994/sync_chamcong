namespace ManagerLicense
{
  partial class Form1
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
      this.txtKey = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.txtText = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtKey);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.txtText);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(800, 241);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Lấy mã kích hoạt";
      // 
      // txtKey
      // 
      this.txtKey.Location = new System.Drawing.Point(79, 87);
      this.txtKey.Name = "txtKey";
      this.txtKey.Size = new System.Drawing.Size(697, 22);
      this.txtKey.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 16);
      this.label2.TabIndex = 3;
      this.label2.Text = "Key : ";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(600, 35);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(176, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Generate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtText
      // 
      this.txtText.Location = new System.Drawing.Point(79, 35);
      this.txtText.Name = "txtText";
      this.txtText.Size = new System.Drawing.Size(503, 22);
      this.txtText.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Text : ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 241);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtText;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtKey;
  }
}

