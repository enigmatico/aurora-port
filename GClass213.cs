// Decompiled with JetBrains decompiler
// Type: GClass213
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class GClass213
{
  public List<int> list_0 = new List<int>();
  public int int_0;
  public int int_1;
  public int int_2;
  public double double_0;
  public double double_1;

  public void method_0(GClass21 gclass21_0)
  {
    try
    {
      if (this.list_0.Contains(gclass21_0.RaceID))
        return;
      this.list_0.Add(gclass21_0.RaceID);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2998);
    }
  }

  public void method_1(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0)
  {
    try
    {
      if (gclass202_0.gclass21_0.chkHideSL == CheckState.Checked && this.list_0.Contains(gclass202_0.gclass21_0.RaceID))
        return;
      SolidBrush solidBrush = new SolidBrush(Color.Wheat);
      Pen pen = new Pen((Brush) solidBrush);
      GClass221 gclass221 = new GClass221();
      string str = "SL " + this.int_2.ToString();
      double x = gclass222_0.double_2 - (double) GClass226.int_61 / 2.0;
      double y = gclass222_0.double_3 - (double) GClass226.int_61 / 2.0;
      if (this.list_0.Contains(gclass202_0.gclass21_0.RaceID))
        graphics_0.FillEllipse((Brush) solidBrush, (float) x, (float) y, (float) GClass226.int_61 * 0.8f, (float) GClass226.int_61 * 0.8f);
      else
        graphics_0.DrawEllipse(pen, (float) x, (float) y, (float) GClass226.int_61 * 0.8f, (float) GClass226.int_61 * 0.8f);
      solidBrush.Color = Color.LimeGreen;
      double num = (double) graphics_0.MeasureString(str, font_0).Width / 2.0;
      gclass221.double_0 = gclass222_0.double_2 - num;
      gclass221.double_1 = gclass222_0.double_3 + (double) GClass226.int_61;
      graphics_0.DrawString(str, font_0, (Brush) solidBrush, (float) gclass221.double_0, (float) gclass221.double_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2999);
    }
  }
}
