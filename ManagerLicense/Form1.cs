using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerLicense
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if(String.IsNullOrEmpty(txtText.Text.Trim()))
      {
        MessageBox.Show("Vui lòng nhập text.");
        return;
      }

      EncryptVNPT encryptVNPT = new EncryptVNPT();

      txtKey.Text = encryptVNPT.Encode(txtText.Text);
    }
  }
}
