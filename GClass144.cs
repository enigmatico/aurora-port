// Decompiled with JetBrains decompiler
// Type: GClass144
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass144
{
  public List<GClass145> list_0 = new List<GClass145>();
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass202 gclass202_0;
  public int int_0;
  public string string_0;

  public GClass144(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(GClass85 gclass85_0)
  {
    try
    {
      gclass85_0.dictionary_0.Clear();
      this.list_0 = this.list_0.OrderBy<GClass145, int>((Func<GClass145, int>) (gclass145_0 => gclass145_0.int_0)).ToList<GClass145>();
      foreach (GClass145 gclass145 in this.list_0)
        gclass145.method_0(gclass85_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2080);
    }
  }

  public void method_1(GClass85 gclass85_0)
  {
    try
    {
      foreach (GClass139 gclass139 in gclass85_0.dictionary_0.Values)
        this.list_0.Add(new GClass145(this.gclass0_0)
        {
          gclass144_0 = this,
          int_0 = gclass139.int_1,
          gclass202_0 = gclass139.gclass202_0,
          genum13_0 = gclass139.genum13_0,
          genum125_0 = gclass139.genum125_0,
          int_3 = gclass139.int_2,
          gclass146_0 = gclass139.gclass146_0,
          gclass133_0 = gclass139.gclass133_0,
          gclass202_1 = gclass139.gclass202_1,
          gclass120_0 = gclass139.gclass120_0,
          decimal_1 = gclass139.decimal_1,
          double_0 = gclass139.double_0,
          decimal_0 = gclass139.decimal_2,
          int_2 = gclass139.int_3,
          int_4 = gclass139.int_5,
          bool_0 = gclass139.bool_1,
          decimal_2 = gclass139.decimal_0,
          int_1 = gclass139.int_7,
          string_1 = gclass139.string_1,
          string_0 = gclass139.string_0
        });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2081);
    }
  }
}
