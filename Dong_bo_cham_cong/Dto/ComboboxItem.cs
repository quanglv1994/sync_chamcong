using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dong_bo_cham_cong.Dto
{
  public class ComboboxItem
    {
      public string Text { get; set; }
      public string Value { get; set; }
      public override string ToString() { return Text; }
    }
}
