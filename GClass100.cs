// Decompiled with JetBrains decompiler
// Type: GClass100
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass100
{
  public GClass164 gclass164_0;
  public GEnum114 genum114_0;
  public GEnum53 genum53_0;
  public GEnum54 genum54_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public bool bool_4;
  public bool bool_5;
  public bool bool_6;
  public bool bool_7;
  public string string_1;

  public string ComponentName { get; set; }

  public int method_0(Decimal decimal_8)
  {
    try
    {
      return (int) Math.Floor(Math.Pow((double) this.method_2(decimal_8 / 20M), 2.0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1736);
      return 0;
    }
  }

  public Decimal method_1(Decimal decimal_8)
  {
    try
    {
      return Math.Round(this.decimal_2 * decimal_8, 2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1737);
      return 0M;
    }
  }

  public Decimal method_2(Decimal decimal_8)
  {
    try
    {
      return Math.Round(this.decimal_1 * decimal_8, 2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1738);
      return 0M;
    }
  }

  public string method_3(Decimal decimal_8)
  {
    try
    {
      string str = this.ComponentName + ":";
      if (this.decimal_1 > 0M)
      {
        str = $"{str}      Shots {this.int_0.ToString()}      Penetration {this.method_1(decimal_8).ToString()}      Damage {this.method_2(decimal_8).ToString()}";
        if (this.genum54_0 != GEnum54.const_0)
          str = $"{str}      AA Value {this.method_0(decimal_8).ToString()}";
      }
      else if (this.decimal_3 > 0M)
        str = $"{str}      Construction Factory Equivalent {GClass226.smethod_42(this.decimal_3, 2)}";
      else if (this.int_5 > 0)
        str = $"{str}      Ground Supply Points {GClass226.smethod_37(this.int_5)}";
      else if (this.decimal_4 > 0M)
        str = $"{str}      Geo Survey Points {GClass226.smethod_42(this.decimal_4, 1)}";
      else if (this.decimal_5 > 0M)
        str = $"{str}      Xenoarchaeology Points {GClass226.smethod_42(this.decimal_5, 1)}";
      else if (this.decimal_7 > 0M)
        str = $"{str}      Decontamination Rate {GClass226.smethod_42(this.decimal_7, 1)}%";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1739);
      return "error";
    }
  }
}
