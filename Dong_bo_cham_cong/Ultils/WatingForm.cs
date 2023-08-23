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
  public partial class WatingForm : Form
  {
    public Action Worker { get; set; }
    public WatingForm(Action worker)
    {
      InitializeComponent();
      if (worker == null) { throw new ArgumentNullException(); }
      Worker = worker;
    }
    public WatingForm(Action worker, string text)
    {
      InitializeComponent();
      if (worker == null) { throw new ArgumentNullException(); }
      Worker = worker;
      lb_text.Text = text;
    }
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
    }
  }
}
