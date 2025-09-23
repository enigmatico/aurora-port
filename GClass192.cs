// Decompiled with JetBrains decompiler
// Type: GClass192
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class GClass192
{
  public GClass21 gclass21_0;
  public GClass146 gclass146_0;
  public GClass193 gclass193_0;
  public GClass40 gclass40_0;
  public GClass83 gclass83_0;
  public GClass22 gclass22_0;
  public GClass22 gclass22_1;
  public GClass85 gclass85_0;
  public GClass123 gclass123_0;
  public AuroraSYTaskType auroraSYTaskType_0;
  public int int_0;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public string string_0;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;

  public string method_0()
  {
    try
    {
      switch (this.auroraSYTaskType_0)
      {
        case AuroraSYTaskType.Construction:
          return $"Build {this.gclass22_0.gclass76_0.Abbreviation} {this.gclass22_0.ClassName}";
        case AuroraSYTaskType.Repair:
          return "Repair";
        case AuroraSYTaskType.Refit:
          return $"Refit {this.gclass22_0.ClassName} to {this.gclass22_1.ClassName}";
        case AuroraSYTaskType.Scrap:
          return "Scrap";
        case AuroraSYTaskType.AutoRefit:
          return $"Auto Refit {this.gclass22_0.ClassName} to {this.gclass22_1.ClassName}";
        default:
          return "No Task Found";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2921);
      return "Error";
    }
  }

  public void method_1(Decimal decimal_5)
  {
    try
    {
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Duranium, this.gclass123_0.decimal_0 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Neutronium, this.gclass123_0.decimal_1 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Corbomite, this.gclass123_0.decimal_2 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Tritanium, this.gclass123_0.decimal_3 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Boronide, this.gclass123_0.decimal_4 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Mercassium, this.gclass123_0.decimal_5 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Vendarite, this.gclass123_0.decimal_6 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Sorium, this.gclass123_0.decimal_7 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Uridium, this.gclass123_0.decimal_8 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Corundium, this.gclass123_0.decimal_9 * decimal_5);
      this.gclass146_0.method_21(GEnum85.const_5, AuroraElement.Gallicite, this.gclass123_0.decimal_10 * decimal_5);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3937);
    }
  }
}
