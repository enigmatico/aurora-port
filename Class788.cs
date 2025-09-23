// Decompiled with JetBrains decompiler
// Type: Class788
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Linq;
using System.Windows.Forms;
using Aurora;

#nullable disable
internal class Class788
{
  private GClass0 gclass0_0;

  public Class788(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  private sealed class Class789
  {
    public GClass21 gclass21_0;

    internal bool method_0(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
    }

    internal bool method_1(GClass100 gclass100_0)
    {
      return gclass100_0.bool_1 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.decimal_1 == 1M && gclass100_0.int_0 == 1 && gclass100_0.genum53_0 == GEnum53.const_0;
    }

    internal bool method_2(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_3(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_4(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_5(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_2 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_6(GClass100 gclass100_0)
    {
      return gclass100_0.bool_3 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_7(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_8(GClass100 gclass100_0)
    {
      return gclass100_0.bool_1 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_5 > 0;
    }

    internal bool method_9(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_6 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_10(GClass100 gclass100_0)
    {
      return gclass100_0.bool_6 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_5 > 0;
    }

    internal bool method_11(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_12(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_13(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_14(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_15(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
    }

    internal bool method_16(GClass100 gclass100_0)
    {
      return gclass100_0.bool_1 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum54_0 == GEnum54.const_1;
    }

    internal bool method_17(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
    }

    internal bool method_18(GClass100 gclass100_0)
    {
      return gclass100_0.bool_1 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0;
    }

    internal bool method_19(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_20(GClass100 gclass100_0)
    {
      return gclass100_0.bool_1 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.decimal_1 == 1M && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.decimal_2 < 2M;
    }

    internal bool method_21(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_22(GClass100 gclass100_0)
    {
      return gclass100_0.bool_1 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.decimal_1 == 1M && gclass100_0.genum53_0 == GEnum53.const_0;
    }

    internal bool method_23(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass97_0.decimal_0 < 2M;
    }

    internal bool method_24(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_25(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_26(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_27(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_28(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_29(GClass100 gclass100_0)
    {
      return gclass100_0.bool_3 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_30(GClass100 gclass100_0)
    {
      return gclass100_0.bool_3 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_31(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_32(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum54_0 > GEnum54.const_1;
    }

    internal bool method_33(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_34(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_35(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_36(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_37(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_38(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_2 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_39(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_40(GClass100 gclass100_0)
    {
      return gclass100_0.bool_3 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_41(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_3 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_42(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_43(GClass100 gclass100_0)
    {
      return gclass100_0.bool_4 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_44(GClass100 gclass100_0)
    {
      return gclass100_0.bool_4 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_45(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_5 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_46(GClass100 gclass100_0)
    {
      return gclass100_0.bool_0 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 != 0;
    }

    internal bool method_47(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_48(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 != 0;
    }

    internal bool method_49(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_0 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_50(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_51(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_52(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_53(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_54(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_1 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_55(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_56(GClass100 gclass100_0)
    {
      return gclass100_0.bool_2 && gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.genum53_0 == GEnum53.const_0 && gclass100_0.genum54_0 == GEnum54.const_0;
    }

    internal bool method_57(GClass230 gclass230_0)
    {
      return gclass230_0.bool_4 && gclass230_0.int_3 == 0 && gclass230_0.decimal_0 > 0M && gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_58(GClass230 gclass230_0)
    {
      return !gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
    }

    internal bool method_59(GClass230 gclass230_0)
    {
      if (gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Laser && this.gclass21_0.gclass20_0.genum36_0 == GEnum36.const_1 || gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Railgun && this.gclass21_0.gclass20_0.genum36_0 == GEnum36.const_3 || gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ParticleBeam && this.gclass21_0.gclass20_0.genum36_0 == GEnum36.const_2 || gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MesonCannon && this.gclass21_0.gclass20_0.genum36_0 == GEnum36.const_4)
        return true;
      return gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Carronade && this.gclass21_0.gclass20_0.genum36_0 == GEnum36.const_5;
    }

    internal bool method_60(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_5 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_61(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_5 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_62(GClass100 gclass100_0)
    {
      return gclass100_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass100_0.int_3 > 0;
    }

    internal bool method_63(GClass230 gclass230_0)
    {
      return gclass230_0.bool_4 && gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.CIWS && gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_64(GClass230 gclass230_0)
    {
      return !gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
    }

    internal bool method_65(GClass230 gclass230_0)
    {
      if (gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Laser && this.gclass21_0.gclass20_0.genum36_2 == GEnum36.const_1 || gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Railgun && this.gclass21_0.gclass20_0.genum36_2 == GEnum36.const_3 || gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MesonCannon && this.gclass21_0.gclass20_0.genum36_2 == GEnum36.const_4)
        return true;
      return gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.GaussCannon && this.gclass21_0.gclass20_0.genum36_2 == GEnum36.const_6;
    }

    internal bool method_66(GClass97 gclass97_0)
    {
      return gclass97_0.genum112_0 == GEnum112.const_5 && gclass97_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }
  }
  
  private sealed class Class790
  {
    public GClass21 gclass21_0;
    public GClass24 gclass24_0;

    internal bool method_0(GClass101 gclass101_0)
    {
      return gclass101_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) && gclass101_0.genum115_0 == this.gclass24_0.genum115_0;
    }

    internal bool method_1(GClass101 gclass101_0)
    {
      return !gclass101_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
    }
  }
  
  public GClass101 method_0(
    GClass21 gclass21_0,
    GEnum115 genum115_0,
    string string_0,
    int int_0,
    GClass194 gclass194_0,
    bool bool_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Class788.Class789 class789 = new Class788.Class789();
    // ISSUE: reference to a compiler-generated field
    class789.gclass21_0 = gclass21_0;
    try
    {
      GClass101 gclass101 = (GClass101) null;
      Decimal int_136 = Math.Ceiling((Decimal) int_0 * 1.05M / 1000M) * 1000M;
      if (genum115_0 == GEnum115.const_1)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_1 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_0)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_1)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_1, gclass100_0_1, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      if (genum115_0 == GEnum115.const_27)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_2 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_2)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        GClass100 gclass100_0_2 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.genum114_0 == GEnum114.const_16));
        string_0 = "Swarm Warrior";
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_2, gclass100_0_2, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      if (genum115_0 == GEnum115.const_28)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_3 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_3)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.genum114_0 == GEnum114.const_1));
        string_0 = "Swarm Ravener";
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_3, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      if (genum115_0 == GEnum115.const_30)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_4 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_4)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.genum114_0 == GEnum114.const_11));
        string_0 = "Swarm Biovore";
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_4, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      if (genum115_0 == GEnum115.const_29)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_5 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_5)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_6)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        string_0 = "Swarm Reaper";
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_5, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      if (genum115_0 == GEnum115.const_22)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_6 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_7)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_3 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_8)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_6, gclass100_0_3, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 0);
      }
      if (genum115_0 == GEnum115.const_21)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_7 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_9)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_4 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_10)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_6], gclass97_0_7, gclass100_0_4, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 0);
      }
      if (genum115_0 == GEnum115.const_24)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_8 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_11)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_4 > 0M));
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_8, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 0);
      }
      if (genum115_0 == GEnum115.const_25)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_9 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_12)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_5 > 0M));
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_9, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 0);
      }
      if (genum115_0 == GEnum115.const_33)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_10 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_13)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_7 > 0M));
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_10, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 0);
      }
      if (genum115_0 == GEnum115.const_26)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_11 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_14)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_3 > 0M));
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_11, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 0);
      }
      else if (genum115_0 == GEnum115.const_5)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_12 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_15)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_5 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_16)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_12, gclass100_0_5, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_4)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_13 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_17)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_6 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_18)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_13, gclass100_0_6, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_2)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_14 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_19)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_7 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_20)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_14, gclass100_0_7, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_3)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_15 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_21)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_8 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_22)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_15, gclass100_0_8, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_6)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_16 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_23)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_24));
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_16, gclass100_0, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, (int) int_136);
      }
      else if (genum115_0 == GEnum115.const_7)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_17 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_25)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_9 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_26)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_27)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)} {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_17, gclass100_0_9, gclass100_1, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_18)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_18 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_28)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_10 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_29)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_30)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_18, gclass100_0_10, gclass100_1, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_8)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_19 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_31)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_32)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_19, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_9)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_20 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_33)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_34)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4) + " Infantry Support Tank";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_20, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_10)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_21 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_35)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_11 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_36));
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_37)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_21, gclass100_0_11, gclass100_1, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, (int) int_136);
      }
      else if (genum115_0 == GEnum115.const_19)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_22 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_38)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_12 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_39));
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_40)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_2], gclass97_0_22, gclass100_0_12, gclass100_1, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, (int) int_136);
      }
      else if (genum115_0 == GEnum115.const_20)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_23 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_41)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_13 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_42));
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_43)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_2 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_44)).OrderByDescending<GClass100, int>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_3], gclass97_0_23, gclass100_0_13, gclass100_1, gclass100_2, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, (int) int_136);
      }
      else if (genum115_0 == GEnum115.const_11)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_24 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_45)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_14 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_46)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_5], gclass97_0_24, gclass100_0_14, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_12)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_25 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_47)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_48)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_25, gclass100, gclass100, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_13)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_26 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_49)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_50));
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_0], gclass97_0_26, gclass100_0, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 50000);
      }
      else if (genum115_0 == GEnum115.const_14)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_27 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_51)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_15 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_52));
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_53)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_27, gclass100_0_15, gclass100_1, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 50000);
      }
      else if (genum115_0 == GEnum115.const_23)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_28 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_54)).OrderByDescending<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0_16 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_55));
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_1 = this.gclass0_0.dictionary_68.Values.Where<GClass100>(new Func<GClass100, bool>(class789.method_56)).OrderByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_2)).ThenByDescending<GClass100, Decimal>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_1)).FirstOrDefault<GClass100>();
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_1], gclass97_0_28, gclass100_0_16, gclass100_1, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, 250000);
      }
      else if (genum115_0 == GEnum115.const_16)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        GClass230 gclass230_2 = this.gclass0_0.dictionary_54.Values.Where<GClass230>(new Func<GClass230, bool>(class789.method_57)).Where<GClass230>(new Func<GClass230, bool>(class789.method_58)).Where<GClass230>(new Func<GClass230, bool>(class789.method_59)).OrderByDescending<GClass230, Decimal>((Func<GClass230, Decimal>) (gclass230_0 => gclass230_0.decimal_0)).FirstOrDefault<GClass230>();
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_29 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_60)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)}  {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_5], gclass97_0_29, this.gclass0_0.dictionary_68[GEnum114.const_22], (GClass100) null, (GClass100) null, (GClass100) null, gclass230_2, gclass194_0.dictionary_1, string_10, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      else if (genum115_0 == GEnum115.const_17)
      {
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_30 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_61)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        // ISSUE: reference to a compiler-generated method
        GClass100 gclass100_0 = this.gclass0_0.dictionary_68.Values.FirstOrDefault<GClass100>(new Func<GClass100, bool>(class789.method_62));
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_5], gclass97_0_30, gclass100_0, (GClass100) null, (GClass100) null, (GClass100) null, (GClass230) null, gclass194_0.dictionary_1, string_0, true, CheckState.Unchecked, CheckState.Unchecked, CheckState.Checked, (int) int_136);
      }
      else if (genum115_0 == GEnum115.const_15)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        GClass230 gclass230_2 = this.gclass0_0.dictionary_54.Values.Where<GClass230>(new Func<GClass230, bool>(class789.method_63)).Where<GClass230>(new Func<GClass230, bool>(class789.method_64)).Where<GClass230>(new Func<GClass230, bool>(class789.method_65)).OrderBy<GClass230, int>((Func<GClass230, int>) (gclass230_0 => gclass230_0.int_11)).ThenByDescending<GClass230, Decimal>((Func<GClass230, Decimal>) (gclass230_0 => gclass230_0.decimal_1)).FirstOrDefault<GClass230>();
        // ISSUE: reference to a compiler-generated method
        GClass97 gclass97_0_31 = this.gclass0_0.dictionary_67.Values.Where<GClass97>(new Func<GClass97, bool>(class789.method_66)).OrderBy<GClass97, Decimal>((Func<GClass97, Decimal>) (gclass97_0 => gclass97_0.decimal_0)).FirstOrDefault<GClass97>();
        string string_10 = string_0;
        if (bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_10 = $"{class789.gclass21_0.gclass140_2.method_0(class789.gclass21_0, GEnum21.const_4)} {string_0}";
        }
        // ISSUE: reference to a compiler-generated field
        gclass101 = this.gclass0_0.method_448(class789.gclass21_0, this.gclass0_0.dictionary_66[GEnum112.const_5], gclass97_0_31, this.gclass0_0.dictionary_68[GEnum114.const_22], (GClass100) null, (GClass100) null, (GClass100) null, gclass230_2, gclass194_0.dictionary_1, string_10, true, CheckState.Checked, CheckState.Unchecked, CheckState.Unchecked, 0);
      }
      gclass101.genum115_0 = genum115_0;
      return gclass101;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 222);
      return (GClass101) null;
    }
  }

  public GClass101 method_1(
    GClass21 gclass21_0,
    GClass24 gclass24_0,
    int int_0,
    GClass194 gclass194_0,
    bool bool_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Class788.Class790 class790 = new Class788.Class790();
    // ISSUE: reference to a compiler-generated field
    class790.gclass21_0 = gclass21_0;
    // ISSUE: reference to a compiler-generated field
    class790.gclass24_0 = gclass24_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return this.gclass0_0.dictionary_70.Values.Where<GClass101>(new Func<GClass101, bool>(class790.method_0)).Where<GClass101>(new Func<GClass101, bool>(class790.method_1)).OrderByDescending<GClass101, Decimal>((Func<GClass101, Decimal>) (gclass101_0 => gclass101_0.decimal_3)).FirstOrDefault<GClass101>() ?? this.method_0(class790.gclass21_0, class790.gclass24_0.genum115_0, class790.gclass24_0.string_0, int_0, gclass194_0, bool_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 223);
      return (GClass101) null;
    }
  }

  public GClass102 method_2(
    GClass21 gclass21_0,
    GEnum116 genum116_0,
    GClass194 gclass194_0,
    bool bool_0)
  {
    try
    {
      if (!this.gclass0_0.dictionary_74.ContainsKey(genum116_0))
        return (GClass102) null;
      Decimal num1 = 0M;
      if (gclass21_0.genum6_0 == GEnum6.const_0)
        this.method_3(gclass194_0);
      if (gclass21_0.genum6_0 == GEnum6.const_4)
      {
        this.method_3(gclass194_0);
        GClass164 gclass164 = gclass21_0.method_387(GEnum122.const_180);
        if (gclass164 != null)
        {
          if (gclass164.int_0 == 67771)
            gclass194_0.dictionary_1.Add(GEnum113.const_10, this.gclass0_0.dictionary_69[GEnum113.const_10]);
          else if (gclass164.int_0 == 67772)
            gclass194_0.dictionary_1.Add(GEnum113.const_11, this.gclass0_0.dictionary_69[GEnum113.const_11]);
          else if (gclass164.int_0 == 67773)
            gclass194_0.dictionary_1.Add(GEnum113.const_12, this.gclass0_0.dictionary_69[GEnum113.const_12]);
        }
      }
      GClass23 gclass23 = this.gclass0_0.dictionary_74[genum116_0];
      GClass102 gclass102 = new GClass102(this.gclass0_0);
      gclass102.int_0 = this.gclass0_0.method_26(GEnum0.const_33);
      gclass102.Name = gclass23.string_0;
      gclass102.string_1 = gclass23.string_1;
      gclass102.gclass21_0 = gclass21_0;
      gclass102.genum116_0 = genum116_0;
      GClass24 gclass24_0_1 = gclass23.list_0.FirstOrDefault<GClass24>((Func<GClass24, bool>) (gclass24_0 => gclass24_0.bool_0));
      if (gclass24_0_1 == null)
        return (GClass102) null;
      GClass101 gclass101_0_1 = this.method_1(gclass21_0, gclass24_0_1, 0, gclass194_0, bool_0);
      int int_3_1 = gclass24_0_1.int_0 + GClass226.smethod_22(gclass24_0_1.int_1, gclass24_0_1.int_2) * gclass24_0_1.int_3;
      gclass102.method_12(gclass101_0_1, int_3_1);
      Decimal num2 = num1 + gclass101_0_1.decimal_4 * (Decimal) int_3_1;
      foreach (GClass24 gclass24_0_2 in gclass23.list_0.Where<GClass24>((Func<GClass24, bool>) (gclass24_0 => !gclass24_0.bool_0 && !gclass24_0.bool_1 && !gclass24_0.bool_2 && !gclass24_0.bool_3)).ToList<GClass24>())
      {
        GClass101 gclass101_0_2 = this.method_1(gclass21_0, gclass24_0_2, 0, gclass194_0, bool_0);
        int int_3_2 = (int) ((double) (gclass24_0_2.int_0 + GClass226.smethod_22(gclass24_0_2.int_1, gclass24_0_2.int_2) * gclass24_0_2.int_3) / 1000.0 * (double) int_3_1);
        gclass102.method_12(gclass101_0_2, int_3_2);
        num2 += gclass101_0_2.decimal_4 * (Decimal) int_3_2;
      }
      GClass24 gclass24_0_3 = gclass23.list_0.FirstOrDefault<GClass24>((Func<GClass24, bool>) (gclass24_0 => gclass24_0.bool_3));
      if (gclass24_0_3 != null)
      {
        GClass101 gclass101_0_3 = this.method_1(gclass21_0, gclass24_0_3, 0, gclass194_0, bool_0);
        int int_3_3 = gclass24_0_3.int_0;
        if (int_3_3 == 0)
        {
          int_3_3 = (int) ((double) (GClass226.smethod_22(gclass24_0_3.int_1, gclass24_0_3.int_2) * gclass24_0_3.int_3) / 10000.0 * (double) int_3_1);
          if (int_3_3 < 1)
            int_3_3 = 1;
        }
        gclass102.method_12(gclass101_0_3, int_3_3);
      }
      GClass24 gclass24_0_4 = gclass23.list_0.FirstOrDefault<GClass24>((Func<GClass24, bool>) (gclass24_0 => gclass24_0.bool_2));
      if (gclass24_0_4 != null)
      {
        GClass101 gclass101_0_4 = this.method_1(gclass21_0, gclass24_0_4, 0, gclass194_0, bool_0);
        int int_3_4 = gclass24_0_4.int_0;
        if (int_3_4 == 0)
          int_3_4 = (int) Math.Ceiling(num2 * (Decimal) gclass24_0_4.int_3 / (Decimal) gclass101_0_4.method_1());
        gclass102.method_12(gclass101_0_4, int_3_4);
      }
      GClass24 gclass24_0_5 = gclass23.list_0.FirstOrDefault<GClass24>((Func<GClass24, bool>) (gclass24_0 => gclass24_0.bool_1));
      if (gclass24_0_5 != null)
      {
        int int_0 = (int) Math.Ceiling(gclass102.method_9());
        GClass101 gclass101_0_5 = this.method_1(gclass21_0, gclass24_0_5, int_0, gclass194_0, bool_0);
        gclass102.method_12(gclass101_0_5, gclass24_0_5.int_0);
        Decimal num3 = num2 + gclass101_0_5.decimal_4 * (Decimal) gclass24_0_5.int_0;
      }
      this.gclass0_0.dictionary_72.Add(gclass102.int_0, gclass102);
      return gclass102;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 224 /*0xE0*/);
      return (GClass102) null;
    }
  }

  public void method_3(GClass194 gclass194_0)
  {
    try
    {
      gclass194_0.dictionary_1.Clear();
      if (gclass194_0.gclass1_0 == null || gclass194_0.gclass1_0.gclass99_0 == null)
        return;
      if (gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_9)
        gclass194_0.dictionary_1.Add(GEnum113.const_7, this.gclass0_0.dictionary_69[GEnum113.const_7]);
      if (gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_4 || gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_8 || gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_14)
        gclass194_0.dictionary_1.Add(GEnum113.const_6, this.gclass0_0.dictionary_69[GEnum113.const_6]);
      if (gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_2 || gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_8 || gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_7 || gclass194_0.gclass1_0.gclass99_0.genum111_0 == GEnum111.const_19)
        gclass194_0.dictionary_1.Add(GEnum113.const_5, this.gclass0_0.dictionary_69[GEnum113.const_5]);
      if (gclass194_0.gclass1_0.gclass99_0.genum111_0 != GEnum111.const_12 && gclass194_0.gclass1_0.gclass99_0.genum111_0 != GEnum111.const_13 && gclass194_0.gclass1_0.gclass99_0.genum111_0 != GEnum111.const_14 && gclass194_0.gclass1_0.gclass99_0.genum111_0 != GEnum111.const_20)
        return;
      gclass194_0.dictionary_1.Add(GEnum113.const_9, this.gclass0_0.dictionary_69[GEnum113.const_9]);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 225);
    }
  }
}
