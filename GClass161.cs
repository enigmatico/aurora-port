// Decompiled with JetBrains decompiler
// Type: GClass161
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Linq;

#nullable disable
public class GClass161
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass146 gclass146_0;
  public GClass164 gclass164_0;
  public GClass55 gclass55_0;
  public GClass162 gclass162_0;
  public int int_0;
  public int int_1;
  public Decimal decimal_0;
  public bool bool_0;
  public bool bool_1;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public string string_0 = "";

  public GClass161(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0()
  {
    try
    {
      GClass167 gclass167 = new GClass167();
      gclass167.gclass164_0 = this.gclass164_0;
      gclass167.int_0 = this.gclass164_0.int_4 - (int) this.decimal_0;
      if (this.gclass164_0.int_4 - (int) this.decimal_0 > 0)
        this.gclass21_0.list_6.Add(gclass167);
      foreach (GClass166 gclass166 in this.gclass21_0.list_5.Where<GClass166>((Func<GClass166, bool>) (gclass166_0 => gclass166_0.gclass161_0 == this)).ToList<GClass166>())
        this.gclass21_0.list_5.Remove(gclass166);
      this.gclass146_0.dictionary_1.Remove(this.int_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2604);
    }
  }
}
