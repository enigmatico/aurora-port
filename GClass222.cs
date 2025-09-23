// Decompiled with JetBrains decompiler
// Type: GClass222
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass222
{
  public Dictionary<double, int> dictionary_0 = new Dictionary<double, int>();
  public List<GClass197> list_0 = new List<GClass197>();
  public List<GClass1> list_1 = new List<GClass1>();
  public List<GClass120> list_2 = new List<GClass120>();
  public List<GClass214> list_3 = new List<GClass214>();
  public List<GClass85> list_4 = new List<GClass85>();
  public List<GClass132> list_5 = new List<GClass132>();
  public List<GClass233> list_6 = new List<GClass233>();
  public List<GClass59> list_7 = new List<GClass59>();
  public List<GClass65> list_8 = new List<GClass65>();
  public List<GClass40> list_9 = new List<GClass40>();
  public List<GClass132> list_10 = new List<GClass132>();
  public List<GClass146> list_11 = new List<GClass146>();
  public List<GClass212> list_12 = new List<GClass212>();
  public List<GClass213> list_13 = new List<GClass213>();
  public List<GClass126> list_14 = new List<GClass126>();
  public List<GClass146> list_15 = new List<GClass146>();
  public GClass211 gclass211_0;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public int int_0;
  public int int_1;
  public bool bool_0;
  public bool bool_1;

  public object method_0()
  {
    try
    {
      if (this.list_4.Count > 0)
        return (object) this.list_4.OrderByDescending<GClass85, Decimal>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.method_176().Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)))).FirstOrDefault<GClass85>();
      if (this.list_1.Count > 0)
        return (object) this.list_1.OrderByDescending<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.double_8)).FirstOrDefault<GClass1>();
      return this.list_5.Count > 0 ? (object) this.list_5.OrderByDescending<GClass132, Decimal>((Func<GClass132, Decimal>) (gclass132_0 => gclass132_0.gclass129_0.decimal_4)).FirstOrDefault<GClass132>() : (object) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3063);
      return (object) "error";
    }
  }

  public GClass1 method_1()
  {
    try
    {
      return this.list_1.Count > 0 ? this.list_1.OrderByDescending<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.double_8)).FirstOrDefault<GClass1>() : (GClass1) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3453);
      return (GClass1) null;
    }
  }
}
