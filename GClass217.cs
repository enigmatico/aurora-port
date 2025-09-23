// Decompiled with JetBrains decompiler
// Type: GClass217
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass217
{
  public GClass0 gclass0_0;
  public GEnum3 genum3_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public int int_8;
  public int int_9;
  public double double_0;
  public double double_1;
  public double double_2;
  public bool bool_0;
  public string string_0;
  public string string_1;
  public int int_10;
  public int int_11;
  public double double_3;
  public double double_4;

  public string StellarDescription { get; set; }

  public GClass217(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public GClass217 method_0()
  {
    try
    {
      return (GClass217) this.MemberwiseClone();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3062);
      return (GClass217) null;
    }
  }

  public double method_1() => this.double_2 * 1391000.0;

  public double method_2(double double_5, GClass217 gclass217_0, double double_6, double double_7)
  {
    try
    {
      if (this.gclass0_0.int_85 == 0)
      {
        this.double_4 = 0.0;
        return double_5;
      }
      int num1 = 0;
      if (double_5 < 0.05)
        num1 = 2;
      else if (double_5 < 5.0)
        num1 = 1;
      int num2 = 0;
      double num3;
      do
      {
        int num4 = GClass226.smethod_13(10) - num1;
        this.double_4 = num4 >= 2 ? (num4 >= 3 ? (num4 >= 5 ? (num4 >= 7 ? (num4 >= 10 ? 0.6 + (double) GClass226.smethod_13(10) * 0.03 : 0.4 + (double) GClass226.smethod_13(10) * 0.02) : 0.3 + (double) GClass226.smethod_13(10) * 0.01) : 0.2 + (double) GClass226.smethod_13(10) * 0.01) : 0.1 + (double) GClass226.smethod_13(10) * 0.01) : (double) GClass226.smethod_13(10) * 0.01;
        num3 = double_5 * (1.0 - this.double_4);
        double num5 = double_5 * (1.0 + this.double_4);
        if (num3 <= gclass217_0.double_2 * GClass226.double_7 || num3 < double_6 && double_6 != 0.0 || num5 > double_7 && double_7 != 0.0)
          ++num2;
        else
          goto label_9;
      }
      while (num2 != 10);
      goto label_10;
label_9:
      return num3;
label_10:
      this.double_4 = 0.0;
      return double_5;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3436);
      return double_5;
    }
  }
}
