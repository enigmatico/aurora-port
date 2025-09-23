// Decompiled with JetBrains decompiler
// Type: GClass126
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class GClass126
{
  public GClass123 gclass123_0;
  public GClass21 gclass21_0;
  public GClass200 gclass200_0;
  public GClass146 gclass146_0;
  public int int_0;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public double double_5;
  public bool bool_0;

  public void method_0(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0,
    int int_1)
  {
    try
    {
      SolidBrush solidBrush = new SolidBrush(Color.LightGray);
      Pen pen = new Pen(Color.LightGray);
      double x = gclass222_0.double_2 - (double) (GClass226.int_61 / 2);
      double y = gclass222_0.double_3 - (double) (GClass226.int_61 / 2);
      GClass221 gclass221_1 = new GClass221();
      GClass221 gclass221_2 = gclass202_0.method_47(this.double_4, this.double_5);
      graphics_0.DrawLine(pen, (float) gclass222_0.double_2, (float) gclass222_0.double_3, (float) gclass221_2.double_0, (float) gclass221_2.double_1);
      if (int_1 == 0)
        graphics_0.FillEllipse((Brush) solidBrush, (float) x, (float) y, (float) GClass226.int_61, (float) GClass226.int_61);
      string str1 = "";
      if (gclass202_0.gclass21_0.chkMPC == CheckState.Checked)
        str1 = "   " + this.gclass123_0.method_38();
      string str2 = GClass226.smethod_39(this.decimal_0) + " km/s";
      GClass221 gclass221_3 = new GClass221();
      gclass221_3.double_0 = x + (double) GClass226.int_61 + 5.0;
      gclass221_3.double_1 = y - 3.0 - (double) (int_1 * 15);
      graphics_0.DrawString($"Mineral Packet to {this.gclass146_0.PopName}   {GClass226.smethod_42(this.decimal_1, 0)} tons   {str2}{str1}", font_0, (Brush) solidBrush, (float) gclass221_3.double_0, (float) gclass221_3.double_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2012);
    }
  }
}
