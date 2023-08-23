using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dong_bo_cham_cong.Ultils
{
  public partial class BoxLoading : Form
  {
    private string _text;
    public BoxLoading()
    {
      InitializeComponent();
    }
    public BoxLoading(string text)
    {
      this._text = text;
      MinimizeBox = false;
      MaximizeBox = false;

      InitializeComponent();
    }
    private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams cp = base.CreateParams;
        cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
        return cp;
      }
    }
  }
}
