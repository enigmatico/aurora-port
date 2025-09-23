// Decompiled with JetBrains decompiler
// Type: GClass176
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass176
{
  private GClass0 gclass0_0;
  public List<GClass175> list_0 = new List<GClass175>();
  public GEnum39 genum39_0;
  public AuroraInstallationType auroraInstallationType_0;
  public GEnum122 genum122_0;
  public GClass162 gclass162_0;
  public int int_0;
  public int int_1;
  public int int_2 = 1;
  public int int_3 = 1;
  public int int_4;
  private string string_0;

  public GClass176(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public bool method_0(GClass146 gclass146_0, GClass39 gclass39_0)
  {
    try
    {
      this.gclass0_0.int_61 += this.int_0;
      if (this.gclass0_0.int_59 > this.gclass0_0.int_61)
        return false;
      if (this.genum39_0 == GEnum39.const_1)
      {
        int num = GClass226.smethod_13(11);
        this.int_1 = GClass226.smethod_21(5) * 200;
        if (num == 1)
          this.int_1 *= 2;
        gclass146_0.gclass123_0.method_33((AuroraElement) num, (Decimal) this.int_1);
        if (!gclass146_0.gclass21_0.bool_0)
          gclass146_0.method_21(GEnum85.const_10, (AuroraElement) num, (Decimal) this.int_1);
        this.string_0 = $"{GClass226.smethod_37(this.int_1)} tons of {GClass226.smethod_82((Enum) (AuroraElement) num)}";
      }
      else if (this.genum39_0 == GEnum39.const_3)
      {
        this.int_1 = GClass226.smethod_21(5) * 200000;
        gclass146_0.decimal_3 += (Decimal) this.int_1;
        this.string_0 = GClass226.smethod_37(this.int_1) + " litres of fuel";
      }
      else if (this.genum39_0 == GEnum39.const_5)
      {
        this.int_1 = GClass226.smethod_21(5) * 200;
        gclass146_0.decimal_0 += (Decimal) this.int_1;
        this.string_0 = GClass226.smethod_37(this.int_1) + " maintenance supplies";
      }
      else if (this.genum39_0 == GEnum39.const_4)
      {
        this.int_1 = GClass226.smethod_21(5) * 200;
        gclass146_0.gclass21_0.method_300((Decimal) this.int_1, this.gclass0_0.dictionary_45[GEnum84.const_28]);
        this.string_0 = GClass226.smethod_37(this.int_1) + " wealth";
      }
      else if (this.genum39_0 == GEnum39.const_6)
      {
        GClass190 gclass190 = gclass146_0.dictionary_4.Values.FirstOrDefault<GClass190>((Func<GClass190, bool>) (gclass190_0 => gclass190_0.gclass189_0.int_0 == 15));
        if (gclass190 == null)
        {
          gclass190 = new GClass190();
          gclass190.gclass146_0 = gclass146_0;
          gclass190.gclass189_0 = this.gclass0_0.dictionary_56[15];
          gclass190.decimal_1 = 0M;
          gclass190.decimal_2 = 0M;
          gclass190.decimal_0 = 0M;
          gclass146_0.dictionary_4.Add(gclass190.gclass189_0.int_0, gclass190);
        }
        this.int_1 = GClass226.smethod_22(50, 4);
        gclass190.decimal_1 += (Decimal) this.int_1;
        this.string_0 = GClass226.smethod_37(this.int_1) + " alien artifacts";
      }
      else if (this.genum39_0 == GEnum39.const_2)
      {
        this.gclass0_0.int_63 = this.list_0.Sum<GClass175>((Func<GClass175, int>) (gclass175_0 => gclass175_0.int_0));
        this.gclass0_0.int_62 = GClass226.smethod_13(this.gclass0_0.int_63);
        this.gclass0_0.int_64 = 0;
        foreach (GClass175 gclass175 in this.list_0)
        {
          if (gclass175.method_0(gclass146_0, gclass39_0))
            break;
        }
      }
      else if (this.genum39_0 == GEnum39.const_0)
      {
        this.int_1 = GClass226.smethod_13(this.int_2) * this.int_3;
        gclass146_0.method_65(this.auroraInstallationType_0, (Decimal) this.int_1);
        this.string_0 = this.int_1 != 1 ? $"{this.int_1.ToString()} abandoned {GClass226.smethod_11(GClass226.smethod_82((Enum) this.auroraInstallationType_0))}" : "an abandoned " + GClass226.smethod_82((Enum) this.auroraInstallationType_0);
        if (this.auroraInstallationType_0 == AuroraInstallationType.SectorCommand)
          gclass146_0.method_66();
        if (GClass226.smethod_13(this.int_4) == 1)
        {
          if (this.genum122_0 == GEnum122.const_0)
            this.genum122_0 = this.gclass0_0.method_494(this.gclass162_0);
          GClass164 gclass164_1 = gclass146_0.gclass21_0.method_387(this.genum122_0);
          GClass164 gclass164_2 = this.gclass0_0.method_493(this.genum122_0, gclass146_0.gclass1_0.gclass171_0.int_1);
          if (gclass164_2 != null)
          {
            int num = 0;
            if (gclass164_1 != null)
              num = gclass164_1.int_4;
            if (gclass164_2.int_4 > num)
            {
              GClass164 gclass164_0 = gclass146_0.gclass21_0.method_392(this.genum122_0);
              gclass146_0.gclass21_0.method_282(gclass164_0, (GClass55) null, (GClass146) null, (GClass21) null, true, false);
              this.string_0 = $"{this.string_0} plus technical information on {gclass164_0.Name}";
            }
          }
        }
      }
      if (this.genum39_0 != GEnum39.const_2)
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_65, $"{gclass39_0.gclass103_0.Name} has recovered {this.string_0} on {gclass146_0.gclass1_0.method_78(gclass146_0.gclass21_0)}", gclass146_0.gclass21_0, gclass146_0.gclass202_0.gclass200_0, gclass146_0.method_87(), gclass146_0.method_88(), AuroraEventCategory.PopGroundUnits);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2662);
      return false;
    }
  }
}
