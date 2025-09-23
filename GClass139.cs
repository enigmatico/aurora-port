// Decompiled with JetBrains decompiler
// Type: GClass139
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass139
{
  public GClass85 gclass85_0;
  public GClass21 gclass21_0;
  public GClass202 gclass202_0;
  public GClass202 gclass202_1;
  public GClass120 gclass120_0;
  public GEnum13 genum13_0;
  public GClass146 gclass146_0;
  public GClass133 gclass133_0;
  public GEnum125 genum125_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public double double_0;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public string string_0;
  public string string_1 = "";
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;

  public int method_0(int int_8)
  {
    try
    {
      if (this.int_6 > int_8)
      {
        this.int_6 -= int_8;
        return 0;
      }
      int num = int_8 - this.int_6;
      this.int_6 = 0;
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 661);
      return int_8;
    }
  }
}
