// Decompiled with JetBrains decompiler
// Type: GClass42
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass42
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public Image image_0;
  public int int_0;
  public int int_1;
  public bool bool_0;
  public string string_0;
  public string string_1;
  public string string_2;
  public string string_3;

  public GClass42(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(ListBox listBox_0)
  {
    try
    {
      List<GClass43> list = this.gclass0_0.list_1.Where<GClass44>((Func<GClass44, bool>) (gclass44_0 => gclass44_0.gclass42_0 == this)).Select<GClass44, GClass43>((Func<GClass44, GClass43>) (gclass44_0 => gclass44_0.gclass43_0)).ToList<GClass43>();
      listBox_0.DisplayMember = "Description";
      listBox_0.DataSource = (object) list;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 366);
    }
  }
}
