// Decompiled with JetBrains decompiler
// Type: GClass122
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;

#nullable disable
public class GClass122
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public Color color_0;
  public Font font_0;
  public string string_0;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public double double_5;
  public double double_6;
  public double double_7;

  public GClass122(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0()
  {
    try
    {
      this.double_6 = this.double_2 + this.gclass21_0.double_2;
      this.double_7 = this.double_3 + this.gclass21_0.double_3;
      this.double_6 = this.double_2 + this.gclass21_0.double_2;
      this.double_7 = this.double_3 + this.gclass21_0.double_3;
      this.double_6 = this.gclass0_0.double_6 - (this.gclass0_0.double_6 - this.double_6) * this.gclass21_0.double_0;
      this.double_7 = this.gclass0_0.double_7 - (this.gclass0_0.double_7 - this.double_7) * this.gclass21_0.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1976);
    }
  }

  public void method_1(Graphics graphics_0, bool bool_0)
  {
    try
    {
      this.method_0();
      this.double_0 = GClass226.smethod_12(this.string_0, graphics_0, this.font_0);
      this.double_1 = (double) this.font_0.SizeInPoints * (double) graphics_0.DpiX / 72.0;
      if (bool_0 && (this.double_6 < 0.0 - this.double_0 || this.double_6 > this.gclass0_0.double_2 || this.double_7 < 0.0 - this.double_1 || this.double_7 > this.gclass0_0.double_3))
        return;
      this.gclass0_0.method_528(graphics_0, this.font_0, this.color_0, this.double_6, this.double_7, (double) (int) (this.double_0 * 1.2), (int) (this.double_1 * 1.5), this.string_0, StringAlignment.Near, StringAlignment.Near);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1977);
    }
  }

  public void method_2(int int_0, int int_1)
  {
    try
    {
      this.double_2 += (double) int_0 / this.gclass21_0.double_0;
      this.double_3 += (double) int_1 / this.gclass21_0.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1978);
    }
  }

  public void method_3()
  {
    try
    {
      this.double_2 = this.double_4;
      this.double_3 = this.double_5;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1979);
    }
  }

  public void method_4()
  {
    try
    {
      this.double_4 = this.double_2;
      this.double_5 = this.double_3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1980);
    }
  }
}
