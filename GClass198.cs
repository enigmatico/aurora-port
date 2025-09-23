// Decompiled with JetBrains decompiler
// Type: GClass198
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;

#nullable disable
public class GClass198
{
  public Dictionary<int, GClass217> dictionary_0 = new Dictionary<int, GClass217>();
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public double double_5;
  public double double_6;
  public double double_7;
  public double double_8;
  public double double_9;
  public double double_10;
  public string string_0;
  public string string_1;
  public bool bool_0;
  public bool bool_1;

  public string method_0(int int_4)
  {
    try
    {
      return this.string_1.Length > 1 && int_4 == 1 ? this.string_1 : this.string_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3367);
      return this.string_0;
    }
  }
}
