// Decompiled with JetBrains decompiler
// Type: GClass145
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass145
{
  private GClass0 gclass0_0;
  public GClass144 gclass144_0;
  public GClass202 gclass202_0;
  public GClass202 gclass202_1;
  public GClass146 gclass146_0;
  public GClass133 gclass133_0;
  public GClass120 gclass120_0;
  public GEnum13 genum13_0 = GEnum13.const_1;
  public GEnum125 genum125_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public double double_0;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public bool bool_0;
  public string string_0;
  public string string_1 = "";

  public GClass145(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(GClass85 gclass85_0)
  {
    try
    {
      GClass139 gclass139 = new GClass139()
      {
        int_0 = this.gclass0_0.method_26(GEnum0.const_37),
        int_1 = this.int_0,
        gclass85_0 = gclass85_0,
        gclass21_0 = this.gclass202_0.gclass21_0,
        gclass202_0 = this.gclass202_0,
        genum13_0 = this.genum13_0,
        genum125_0 = this.genum125_0,
        int_2 = this.int_3,
        gclass146_0 = this.gclass146_0,
        gclass133_0 = this.gclass133_0,
        gclass202_1 = this.gclass202_1,
        gclass120_0 = this.gclass120_0,
        decimal_1 = this.decimal_1,
        double_0 = this.double_0,
        decimal_2 = this.decimal_0,
        int_3 = this.int_2
      };
      gclass139.int_4 = gclass139.int_3;
      gclass139.int_5 = this.int_4;
      gclass139.bool_1 = this.bool_0;
      gclass139.decimal_0 = this.decimal_2;
      gclass139.int_7 = this.int_1;
      gclass139.string_1 = this.string_1;
      gclass139.string_0 = this.string_0;
      gclass85_0.dictionary_0.Add(gclass139.int_0, gclass139);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2082);
    }
  }
}
