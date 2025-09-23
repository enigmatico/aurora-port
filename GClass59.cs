// Decompiled with JetBrains decompiler
// Type: GClass59
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass59
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass194 gclass194_0;
  public GClass200 gclass200_0;
  public GClass22 gclass22_0;
  public int int_0;
  public int int_1;
  public double double_0;
  public double double_1;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public string string_0;

  public GClass59(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0,
    int int_2)
  {
    try
    {
      if (gclass202_0.gclass21_0.chkLifepods == CheckState.Unchecked)
        return;
      SolidBrush solidBrush = new SolidBrush(GClass226.color_11);
      double x = gclass222_0.double_2 - (double) (GClass226.int_63 / 2);
      double y = gclass222_0.double_3 - (double) (GClass226.int_63 / 2);
      if (int_2 == 0)
        graphics_0.FillEllipse((Brush) solidBrush, (float) x, (float) y, (float) GClass226.int_62, (float) GClass226.int_62);
      string s;
      if (this.gclass21_0 == gclass202_0.gclass21_0)
      {
        string str1 = !(GClass226.decimal_35 - (this.gclass0_0.decimal_0 - this.decimal_0) < 0M) ? "LS: " + this.gclass0_0.method_568((int) (GClass226.decimal_35 - (this.gclass0_0.decimal_0 - this.decimal_0)), false) : "Life Support Failure Imminent";
        string str2 = $"{this.string_0} Life Pods:  {GClass226.smethod_37(this.int_1)} crew";
        foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0.gclass59_0 == this)).ToList<GClass55>())
          str2 = $"{str2}   {gclass55.method_38()}";
        s = $"{str2}   {str1}";
      }
      else
        s = $"{gclass202_0.gclass21_0.method_324(this.gclass22_0.int_0)} life pods #{this.int_0.ToString()}";
      GClass221 gclass221 = new GClass221();
      gclass221.double_0 = x + (double) GClass226.int_61 + 5.0;
      gclass221.double_1 = y - 3.0 - (double) (int_2 * 15);
      graphics_0.DrawString(s, font_0, (Brush) solidBrush, (float) gclass221.double_0, (float) gclass221.double_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 411);
    }
  }
}
