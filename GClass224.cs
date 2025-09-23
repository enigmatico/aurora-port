// Decompiled with JetBrains decompiler
// Type: GClass224
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass224
{
  public GClass223 gclass223_0;
  public int int_0;
  public double double_0;
  public double double_1;
  public bool bool_0;

  public GClass224()
  {
  }

  public GClass224(GClass1 gclass1_0, GClass223 gclass223_1, double double_2, double double_3)
  {
    this.gclass223_0 = gclass223_1;
    this.double_1 = double_2;
    this.double_0 = double_3;
    this.int_0 = gclass1_0.int_0;
  }

  public string method_0(GClass194 gclass194_0)
  {
    try
    {
      string str = this.gclass223_0.Name;
      if (this.bool_0)
        str += " (F)";
      if (this.gclass223_0 == gclass194_0.gclass223_0)
        str = $"{str} ({GClass226.smethod_50(this.double_1)})";
      return $"{str} {GClass226.smethod_50(this.double_0)}%";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3064);
      return "error";
    }
  }
}
