// Decompiled with JetBrains decompiler
// Type: GClass156
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class GClass156
{
  public GClass21 gclass21_0;
  public GClass146 gclass146_0;
  public GClass194 gclass194_0;
  public GClass123 gclass123_0;
  public GClass150 gclass150_0;
  public GClass22 gclass22_0;
  public GClass22 gclass22_1;
  public GClass157 gclass157_0;
  public GClass129 gclass129_0;
  public GClass230 gclass230_0;
  private GClass0 gclass0_0;
  public AuroraProductionType auroraProductionType_0;
  public AuroraProductionCategory auroraProductionCategory_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public bool bool_0;
  public string string_0;

  public GClass156(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(Decimal decimal_4)
  {
    try
    {
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Duranium, this.gclass123_0.decimal_0 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Neutronium, this.gclass123_0.decimal_1 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Corbomite, this.gclass123_0.decimal_2 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Tritanium, this.gclass123_0.decimal_3 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Boronide, this.gclass123_0.decimal_4 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Mercassium, this.gclass123_0.decimal_5 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Vendarite, this.gclass123_0.decimal_6 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Sorium, this.gclass123_0.decimal_7 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Uridium, this.gclass123_0.decimal_8 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Corundium, this.gclass123_0.decimal_9 * decimal_4);
      this.gclass146_0.method_21((GEnum85) this.gclass150_0.genum84_0, AuroraElement.Gallicite, this.gclass123_0.decimal_10 * decimal_4);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3936);
    }
  }
}
