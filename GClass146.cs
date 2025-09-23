// Decompiled with JetBrains decompiler
// Type: GClass146
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public partial class GClass146
{
  public Dictionary<AuroraInstallationType, GClass158> dictionary_0 = new Dictionary<AuroraInstallationType, GClass158>();
  public Dictionary<int, GClass161> dictionary_1 = new Dictionary<int, GClass161>();
  public Dictionary<int, GClass156> dictionary_2 = new Dictionary<int, GClass156>();
  public Dictionary<int, GClass106> dictionary_3 = new Dictionary<int, GClass106>();
  public List<GClass107> list_0 = new List<GClass107>();
  public Dictionary<int, GClass190> dictionary_4 = new Dictionary<int, GClass190>();
  public Dictionary<AuroraInstallationType, GClass148> dictionary_5 = new Dictionary<AuroraInstallationType, GClass148>();
  public List<GClass130> list_1 = new List<GClass130>();
  public List<GClass73> list_2 = new List<GClass73>();
  public List<GClass147> list_3 = new List<GClass147>();
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass21 gclass21_1;
  public GClass194 gclass194_0;
  public GClass194 gclass194_1;
  public GClass55 gclass55_0;
  public GClass123 gclass123_0;
  public GClass123 gclass123_1;
  public GClass123 gclass123_2;
  public GClass123 gclass123_3;
  public GClass123 gclass123_4;
  public GClass146 gclass146_0;
  public GClass85 gclass85_0;
  public GClass85 gclass85_1;
  public GClass85 gclass85_2;
  public GClass202 gclass202_0;
  public GClass1 gclass1_0;
  public GClass223 gclass223_0;
  public GClass160 gclass160_0;
  public GClass127 gclass127_0;
  public GClass6 gclass6_0;
  public GEnum19 genum19_0;
  public GEnum31 genum31_0;
  public GEnum121 genum121_0 = GEnum121.const_7;
  public GEnum121 genum121_1 = GEnum121.const_16;
  public GEnum121 genum121_2 = GEnum121.const_5;
  public int int_0 = 5;
  public GEnum64 genum64_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public int int_8;
  public int int_9;
  public int int_10;
  public int int_11;
  public int int_12 = 1;
  public int int_13;
  public int int_14;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5 = 1M;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public Decimal decimal_8;
  public Decimal decimal_9;
  public Decimal decimal_10;
  public Decimal decimal_11;
  public Decimal decimal_12;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2 = true;
  public bool bool_3;
  public bool bool_4 = true;
  public bool bool_5;
  public bool bool_6;
  public bool bool_7;
  public bool bool_8;
  public bool bool_9 = true;
  public string string_0;
  public string string_1 = "";
  public double double_0;
  public Decimal decimal_13;
  public Decimal decimal_14;
  public Decimal decimal_15;
  public Decimal decimal_16;
  public Decimal decimal_17;
  public Decimal decimal_18;
  public Decimal decimal_19;
  public Decimal decimal_20 = 1M;
  public Decimal decimal_21 = 1M;
  public Decimal decimal_22;
  public Decimal decimal_23;
  public Decimal decimal_24;
  public Decimal decimal_25 = 1M;
  public Decimal decimal_26 = 1M;
  public Decimal decimal_27;
  public Decimal decimal_28;
  public Decimal decimal_29;
  public Decimal decimal_30;
  public Decimal decimal_31 = 1M;
  public Decimal decimal_32;
  public Decimal decimal_33;
  public Decimal decimal_34;
  public Decimal decimal_35;
  public Decimal decimal_36;
  public Decimal decimal_37;
  public Decimal decimal_38;
  public Decimal decimal_39;
  public Decimal decimal_40;
  public Decimal decimal_41;
  public Decimal decimal_42;
  public Decimal decimal_43;
  public Decimal decimal_44;
  public Decimal decimal_45;
  public Decimal decimal_46;
  public Decimal decimal_47;
  public Decimal decimal_48;
  public Decimal decimal_49;
  public Decimal decimal_50;
  public Decimal decimal_51;
  public Decimal decimal_52;
  public Decimal decimal_53;
  public Decimal decimal_54;
  public Decimal decimal_55;
  public Decimal decimal_56;
  public Decimal decimal_57;
  public Decimal decimal_58;
  public Decimal decimal_59;
  public Decimal decimal_60;
  public Decimal decimal_61;
  public Decimal decimal_62;
  public Decimal decimal_63 = 1M;
  public Decimal decimal_64 = 1M;
  public Decimal decimal_65;
  public Decimal decimal_66;
  public Decimal decimal_67;
  public Decimal decimal_68;
  public Decimal decimal_69;
  public Decimal decimal_70;
  public int int_15;
  public int int_16;
  public int int_17;
  public Decimal decimal_71;
  public Decimal decimal_72;
  public Decimal decimal_73;
  public string string_2 = "";
  public int int_18;
  public Decimal decimal_74;
  public double double_1;
  public int int_19;
  public int int_20;
  public int int_21;
  public Decimal decimal_75;
  public Decimal decimal_76;
  public int int_22;
  public Decimal decimal_77;
  public Decimal decimal_78;
  public Decimal decimal_79;
  public Decimal decimal_80;
  public GClass123 gclass123_5;
  public AuroraProductionType auroraProductionType_0;
  public object object_0;
  public Decimal decimal_81;
  public Decimal decimal_82;
  public Decimal decimal_83;
  public Decimal decimal_84;
  public Decimal decimal_85;
  public Decimal decimal_86;
  public Decimal decimal_87;
  public Decimal decimal_88;
  public Decimal decimal_89;
  public List<GClass39> list_4 = new List<GClass39>();
  public Dictionary<GClass21, double> dictionary_6 = new Dictionary<GClass21, double>();
  public int int_23;
  public int int_24;

  public void method_0(Decimal decimal_90)
  {
    try
    {
      Decimal decimal_90_1 = decimal_90 / GClass226.decimal_29;
      this.gclass1_0.method_58(this.gclass21_0, this.gclass194_0, false);
      this.decimal_18 = this.gclass1_0.decimal_0;
      this.decimal_19 = this.gclass1_0.decimal_1;
      this.decimal_12 = this.decimal_19 + 2M;
      this.gclass1_0.method_62(this.gclass194_0);
      this.method_182();
      this.method_184();
      this.method_187();
      this.method_188(decimal_90_1, true);
      this.method_180();
      this.method_146();
      this.method_3(decimal_90_1);
      this.method_4(decimal_90);
      this.method_183(decimal_90_1);
      this.gclass123_3.method_6();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2083);
    }
  }

  public void method_1(Decimal decimal_90)
  {
    try
    {
      this.method_89();
      this.method_90();
      this.method_96();
      this.method_97();
      this.method_176(true);
      this.method_93();
      this.method_99();
      this.method_100();
      this.method_91();
      this.method_98();
      this.method_95();
      this.method_94(true);
      this.gclass123_1 = this.gclass123_0.method_25();
      this.method_25(this.decimal_4 * (1M + this.decimal_35 * decimal_90));
      if (this.gclass21_0.bool_0 && this.gclass0_0.bool_24)
      {
        if (this.gclass21_0.genum82_0 != GEnum82.const_0 && this.gclass21_0.genum82_0 != GEnum82.const_4)
        {
          if (this.gclass21_0.genum82_0 == GEnum82.const_2)
            this.gclass6_0.method_1();
        }
        else
          this.gclass6_0.method_0();
      }
      if (this.decimal_22 > 0M)
        this.method_10(decimal_90);
      if (this.dictionary_2.Count > 0)
        this.method_19(decimal_90);
      if (this.dictionary_3.Count > 0)
        this.method_13(decimal_90);
      if (this.decimal_24 > 0M)
        this.method_8((double) decimal_90);
      if (this.decimal_69 > 0M)
        this.method_9(decimal_90);
      this.method_2(decimal_90);
      if (this.decimal_30 > 0M)
      {
        this.method_18(decimal_90);
        this.method_15(decimal_90);
        this.method_11(decimal_90);
        if ((int) this.method_62(AuroraProductionCategory.Research) > 0)
        {
          if (!this.gclass21_0.bool_0)
            this.method_6(decimal_90);
          else if (this.gclass0_0.bool_24)
            this.method_5(decimal_90);
        }
        if (this.gclass194_1 != null)
          this.method_20(decimal_90);
        this.method_12(decimal_90);
        this.method_7(decimal_90);
        if (this.decimal_30 >= 1M)
        {
          int int_25 = (int) this.method_62(AuroraProductionCategory.NavalHeadquarters);
          if (int_25 > 0 && this.gclass160_0.genum27_0 == GEnum27.const_0)
            this.method_22(int_25, decimal_90);
          else if (this.gclass21_0.bool_0)
            this.method_22(1, decimal_90);
        }
      }
      if (this.decimal_3 < (Decimal) this.int_10)
      {
        if (this.int_12 == 1 || this.int_13 == 0)
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_228, $"The fuel stockpile on {this.PopName} is {GClass226.smethod_38(this.decimal_3)} litres. This is below the warning level of {GClass226.smethod_37(this.int_10)} litres", this.gclass21_0, this.gclass1_0.gclass200_0, this.gclass1_0.double_0, this.gclass1_0.double_1, AuroraEventCategory.PopSummary);
          this.int_13 = 1;
        }
      }
      else
        this.int_13 = 0;
      if (this.decimal_0 < (Decimal) this.int_11)
      {
        if (this.int_12 != 1 && this.int_14 != 0)
          return;
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_228, $"The maintenance stockpile on {this.PopName} is {GClass226.smethod_38(this.decimal_0)} MSP. This is below the warning level of {GClass226.smethod_37(this.int_11)} MSP", this.gclass21_0, this.gclass1_0.gclass200_0, this.gclass1_0.double_0, this.gclass1_0.double_1, AuroraEventCategory.PopSummary);
        this.int_14 = 1;
      }
      else
        this.int_14 = 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2084);
    }
  }

  public void method_2(Decimal decimal_90)
  {
    try
    {
      int num = this.method_73(AuroraInstallationType.MilitaryAcademy);
      if (num == 0)
        return;
      this.decimal_7 += (Decimal) (num * GClass226.int_33) * decimal_90;
      this.gclass21_0.decimal_8 += (Decimal) (num * (GClass226.int_34 / this.gclass21_0.int_30)) * decimal_90;
      while (this.decimal_7 >= 1M)
      {
        GClass55 gclass55_1 = this.method_82();
        this.decimal_7 -= 1M;
        this.gclass21_0.method_256(this, true, gclass55_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2085);
    }
  }

  public void method_3(Decimal decimal_90)
  {
    try
    {
      string str1 = "";
      string str2 = "";
      Decimal decimal8 = this.decimal_8;
      if (this.gclass1_0.decimal_3 > 0M && this.decimal_4 > 0M)
      {
        this.decimal_8 += 100M * (this.gclass1_0.decimal_3 / 1000M) * decimal_90;
        str1 = "radiation levels";
      }
      string str3;
      if (this.decimal_38 > 0M)
      {
        this.decimal_8 += this.decimal_38;
        if (str1 != "")
          str3 = str1 + ", ";
        str1 = "overcrowding";
      }
      this.method_116((ListView) null);
      if (this.decimal_84 > 0M && this.decimal_84 > this.decimal_85)
      {
        if (this.decimal_85 == 0M)
          this.decimal_8 += 100M * decimal_90;
        else
          this.decimal_8 += 100M * (1M - this.decimal_85 / this.decimal_84) * decimal_90;
        if (str1 != "")
          str3 = str1 + ", ";
        str1 = "an insufficient occupation force";
      }
      if (this.decimal_4 > 10M && !this.bool_0 && !this.gclass21_0.bool_0)
      {
        this.method_179();
        if (this.decimal_28 < this.decimal_70)
        {
          Decimal num = 1M - this.decimal_28 / this.decimal_70;
          this.decimal_8 += 25M * num * decimal_90;
          if (str1 != "")
            str3 = str1 + ", ";
          str1 = "insufficient military protection";
          this.decimal_12 += num / 10M;
        }
      }
      if (str1 == "" && this.decimal_8 > 0M)
        this.decimal_8 -= (Decimal) (20 * (1 - this.gclass194_0.int_7 / 100)) * decimal_90;
      if (this.decimal_86 > 0M && this.decimal_8 > 0M)
      {
        this.decimal_8 -= 100M * this.decimal_88 * decimal_90;
        str2 = "action by ground forces";
      }
      if (this.decimal_8 > 99M)
        this.decimal_8 = 99M;
      if (this.decimal_8 < 0M)
        this.decimal_8 = 0M;
      this.decimal_33 = 1M - this.decimal_8 / 100M;
      if (!(this.decimal_33 < 0.99M) || !(str1 != "") || !(this.decimal_8 > decimal8))
        return;
      int startIndex = str1.LastIndexOf(",");
      if (startIndex != -1)
        str1 = str1.Remove(startIndex, 1).Insert(startIndex, " and");
      if (str2 != "")
        str1 = $"{str1}. Unrest reduced due to {str2}";
      this.gclass0_0.gclass92_0.method_3(GEnum126.const_91, $"Unrest is rising on {this.PopName} due to {str1}. Political stability now {GClass226.smethod_42(this.decimal_33 * 100M, 1)}%", this.gclass21_0, this.gclass1_0.gclass200_0, this, this.gclass1_0.double_0, this.gclass1_0.double_1, AuroraEventCategory.PopSummary);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2086);
    }
  }

  public void method_4(Decimal decimal_90)
  {
    try
    {
      if (!(this.decimal_8 == 0M) || this.gclass160_0.genum27_0 == GEnum27.const_0)
        return;
      Decimal num1 = 1.5M - (Decimal) ((this.gclass194_0.int_7 + this.gclass194_0.int_5 + this.gclass194_0.int_2) / 300);
      if (this.gclass1_0.decimal_3 > 100M)
      {
        Decimal num2 = this.gclass1_0.decimal_3 / 100M;
        num1 /= num2;
      }
      this.decimal_6 += decimal_90 / 86400M * num1;
      if (!(this.decimal_6 > (Decimal) this.gclass160_0.int_0) || this.int_1 != 0)
        return;
      this.decimal_6 = 0M;
      this.gclass160_0 = this.gclass160_0.gclass160_0;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_70, $"{this.PopName} has moved to a political status of {this.gclass160_0.string_0}", this.gclass21_0, this.gclass1_0.gclass200_0, this.gclass1_0.double_0, this.gclass1_0.double_1, AuroraEventCategory.PopSummary);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2087);
    }
  }

  public void method_5(Decimal decimal_90)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass146.Class1148 class1148 = new GClass146.Class1148();
      int num1 = (int) this.method_62(AuroraProductionCategory.Research);
      // ISSUE: reference to a compiler-generated field
      class1148.gclass19_0 = this.gclass21_0.method_242();
      // ISSUE: reference to a compiler-generated field
      if (class1148.gclass19_0 == null)
        return;
      List<GClass55> list = this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass21_0 == this.gclass21_0 && gclass55_1.auroraCommanderType_0 == AuroraCommanderType.Scientist)).ToList<GClass55>();
      // ISSUE: reference to a compiler-generated method
      GClass55 gclass55_2 = list.Where<GClass55>(new Func<GClass55, bool>(class1148.method_0)).OrderByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_0 => gclass55_0.method_5(GEnum121.const_2))).FirstOrDefault<GClass55>();
      GClass55 gclass55_3 = list.OrderByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_0 => gclass55_0.method_5(GEnum121.const_2))).FirstOrDefault<GClass55>();
      Decimal num2 = 1M;
      Decimal num3 = 1M;
      if (gclass55_2 != null)
        num2 = gclass55_2.method_5(GEnum121.const_2) * 4M - 3M;
      if (gclass55_3 != null)
        num3 = gclass55_3.method_5(GEnum121.const_2);
      Decimal num4 = num2;
      if (num3 > num4)
        num4 = num3;
      this.gclass21_0.decimal_4 += this.decimal_26 * (Decimal) num1 * num4 * decimal_90;
      if (!(this.gclass21_0.decimal_4 >= (Decimal) this.gclass21_0.int_26))
        return;
      GClass19 gclass19 = this.gclass21_0.method_240();
      if (gclass19 == null)
        return;
      if (gclass19.genum107_0 == GEnum107.const_1)
        this.gclass21_0.method_1();
      if (gclass19.gclass163_0 != null && gclass19.gclass163_0.genum122_0 == GEnum122.const_52)
        this.gclass21_0.method_2();
      this.gclass21_0.decimal_4 -= (Decimal) this.gclass21_0.int_26;
      this.gclass21_0.int_26 = this.gclass21_0.method_241();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2088);
    }
  }

  public void method_6(Decimal decimal_90)
  {
    try
    {
      GClass162 gclass162 = (GClass162) null;
      Decimal num1 = 1M;
      if (this.gclass1_0.gclass220_0 != null)
      {
        num1 = this.gclass1_0.gclass220_0.decimal_0;
        gclass162 = this.gclass1_0.gclass220_0.gclass162_0;
      }
      List<GClass161> list1 = this.dictionary_1.Values.OrderByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.int_0)).ToList<GClass161>();
      int num2 = list1.Sum<GClass161>((Func<GClass161, int>) (gclass161_0 => gclass161_0.int_0));
      int num3 = (int) this.method_62(AuroraProductionCategory.Research);
      if (num2 < num3)
      {
        int num4 = num3 - num2;
        foreach (GClass161 gclass161 in this.dictionary_1.Values.Where<GClass161>((Func<GClass161, bool>) (gclass161_0 => gclass161_0.bool_1)).OrderByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.int_0)).ToList<GClass161>())
        {
          int num5 = (int) gclass161.gclass55_0.method_5(GEnum121.const_23);
          if (gclass161.int_0 < num5)
          {
            int num6 = num5 - gclass161.int_0;
            if (num6 < num4)
            {
              num4 -= num6;
              gclass161.int_0 = num5;
            }
            else
            {
              gclass161.int_0 += num4;
              num4 = 0;
              break;
            }
          }
          if (num4 <= 0)
            break;
        }
        if (num4 > 0)
          this.gclass0_0.gclass92_0.method_3(GEnum126.const_40, $"{num4.ToString()} inactive research facilities on {this.PopName}", this.gclass21_0, this.gclass1_0.gclass200_0, this, this.gclass1_0.double_0, this.gclass1_0.double_1, AuroraEventCategory.PopResearch);
      }
      if (num2 > num3)
      {
        this.gclass0_0.gclass92_0.method_3(GEnum126.const_126, this.PopName + " has too few research facilities for its assigned projects. Appropriate adjustments will be made", this.gclass21_0, this.gclass1_0.gclass200_0, this, this.gclass1_0.double_0, this.gclass1_0.double_1, AuroraEventCategory.PopResearch);
        int num7 = num2 - num3;
        List<GClass161> list2 = this.dictionary_1.Values.Where<GClass161>((Func<GClass161, bool>) (gclass161_0 => !gclass161_0.bool_1)).OrderByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.int_0)).ToList<GClass161>();
        if (list2.Count == 0)
          list2 = this.dictionary_1.Values.OrderByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.int_0)).ToList<GClass161>();
        foreach (GClass161 gclass161 in list2)
        {
          if (gclass161.int_0 < num7)
          {
            num7 -= gclass161.int_0;
            gclass161.int_0 = 0;
          }
          else
          {
            gclass161.int_0 -= num7;
            break;
          }
        }
      }
      foreach (GClass161 gclass161_1 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1149 class1149 = new GClass146.Class1149();
        // ISSUE: reference to a compiler-generated field
        class1149.gclass146_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1149.gclass161_0 = gclass161_1;
        // ISSUE: reference to a compiler-generated field
        if (!class1149.gclass161_0.bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          GClass55 gclass550 = class1149.gclass161_0.gclass55_0;
          // ISSUE: reference to a compiler-generated field
          Decimal num8 = class1149.gclass161_0.gclass162_0 != gclass550.gclass162_0 ? gclass550.method_5(GEnum121.const_2) : gclass550.method_5(GEnum121.const_2) * 4M - 3M;
          // ISSUE: reference to a compiler-generated field
          if (class1149.gclass161_0.gclass162_0 == gclass162)
            num8 *= num1;
          // ISSUE: reference to a compiler-generated field
          Decimal num9 = num8 * this.gclass21_0.dictionary_5[class1149.gclass161_0.gclass162_0.ResearchFieldID];
          // ISSUE: reference to a compiler-generated field
          Decimal decimal_4 = this.decimal_26 * (Decimal) class1149.gclass161_0.int_0 * num9 * decimal_90;
          // ISSUE: reference to a compiler-generated field
          Decimal decimal_29 = this.decimal_26 * (Decimal) class1149.gclass161_0.int_0 * decimal_90 * (Decimal) (100.0 / (double) this.gclass0_0.int_106) * (1M / this.gclass194_0.decimal_2);
          // ISSUE: reference to a compiler-generated field
          if (decimal_4 < class1149.gclass161_0.decimal_0)
          {
            if (!this.gclass21_0.bool_0)
              this.gclass21_0.method_299(decimal_29, this.gclass0_0.dictionary_45[GEnum84.const_6]);
            // ISSUE: reference to a compiler-generated field
            class1149.gclass161_0.decimal_0 -= decimal_4;
            gclass550.method_1(AuroraMeasurementType.ResearchPointsGenerated, decimal_4);
          }
          else
          {
            if (!this.gclass21_0.bool_0)
            {
              // ISSUE: reference to a compiler-generated field
              this.gclass21_0.method_299(class1149.gclass161_0.decimal_0 * (decimal_29 / decimal_4), this.gclass0_0.dictionary_45[GEnum84.const_6]);
            }
            Decimal num10 = 0M;
            Decimal num11 = 0M;
            // ISSUE: reference to a compiler-generated field
            gclass550.method_1(AuroraMeasurementType.ResearchPointsGenerated, class1149.gclass161_0.decimal_0);
            gclass550.method_1(AuroraMeasurementType.ResearchProjectsCompleted, 1M);
            // ISSUE: reference to a compiler-generated field
            if (class1149.gclass161_0.decimal_0 < decimal_4)
            {
              // ISSUE: reference to a compiler-generated field
              num10 = decimal_4 - class1149.gclass161_0.decimal_0;
              num11 = num10 / decimal_4;
            }
            // ISSUE: reference to a compiler-generated field
            this.dictionary_1.Remove(class1149.gclass161_0.int_1);
            gclass550.gclass161_0 = (GClass161) null;
            gclass550.auroraCommandType_0 = AuroraCommandType.None;
            // ISSUE: reference to a compiler-generated field
            this.gclass21_0.method_282(class1149.gclass161_0.gclass164_0, gclass550, this, (GClass21) null, false, false);
            // ISSUE: reference to a compiler-generated field
            this.gclass21_0.method_281(class1149.gclass161_0.gclass164_0, false);
            // ISSUE: reference to a compiler-generated method
            List<GClass166> list3 = this.gclass21_0.list_5.Where<GClass166>(new Func<GClass166, bool>(class1149.method_0)).OrderBy<GClass166, int>((Func<GClass166, int>) (gclass166_0 => gclass166_0.int_0)).ToList<GClass166>();
            foreach (GClass166 gclass166 in list3)
            {
              Decimal num12 = gclass166.gclass164_0.gclass163_0.gclass162_0 != gclass550.gclass162_0 ? gclass550.method_5(GEnum121.const_2) : gclass550.method_5(GEnum121.const_2) * 4M - 3M;
              if (gclass166.gclass164_0.gclass163_0.gclass162_0 == gclass162)
                num12 *= num1;
              // ISSUE: reference to a compiler-generated field
              Decimal num13 = num12 * this.gclass21_0.dictionary_5[class1149.gclass161_0.gclass162_0.ResearchFieldID];
              // ISSUE: reference to a compiler-generated field
              Decimal decimal_90_1 = this.decimal_26 * (Decimal) class1149.gclass161_0.int_0 * num13 * decimal_90 * num11;
              // ISSUE: reference to a compiler-generated field
              Decimal num14 = this.decimal_26 * (Decimal) class1149.gclass161_0.int_0 * decimal_90 * num11;
              if ((Decimal) gclass166.gclass164_0.int_4 <= num10)
              {
                this.gclass21_0.method_282(gclass166.gclass164_0, gclass550, this, (GClass21) null, false, false);
                num10 = decimal_90_1 - (Decimal) gclass166.gclass164_0.int_4;
                num11 *= num10 / decimal_90_1;
                this.gclass21_0.list_5.Remove(gclass166);
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                GClass161 gclass161_2 = this.method_104(gclass166.gclass164_0, gclass550, class1149.gclass161_0.int_0, decimal_90_1);
                this.gclass0_0.gclass92_0.method_3(GEnum126.const_56, $"A science team led by {gclass550.string_0} on {this.PopName} has begun research into {gclass161_2.gclass164_0.Name}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_87(), AuroraEventCategory.PopResearch);
                this.gclass21_0.list_5.Remove(gclass166);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                this.gclass21_0.list_5.Where<GClass166>(class1149.func_0 ?? (class1149.func_0 = new Func<GClass166, bool>(class1149.method_1))).OrderBy<GClass166, int>((Func<GClass166, int>) (gclass166_0 => gclass166_0.int_0)).ToList<GClass166>();
                using (List<GClass166>.Enumerator enumerator = list3.GetEnumerator())
                {
                  while (enumerator.MoveNext())
                    enumerator.Current.gclass161_0 = gclass161_2;
                  break;
                }
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2089);
    }
  }

  public void method_7(Decimal decimal_90)
  {
    try
    {
      foreach (GClass189 gclass189 in this.gclass0_0.dictionary_56.Values)
      {
        if (this.decimal_30 > gclass189.decimal_0 && !this.dictionary_4.ContainsKey(gclass189.int_0))
        {
          GClass190 gclass190 = new GClass190();
          gclass190.gclass146_0 = this;
          gclass190.gclass189_0 = gclass189;
          gclass190.decimal_1 = 0M;
          gclass190.decimal_2 = 0M;
          switch (gclass189.genum49_0)
          {
            case GEnum49.const_0:
              gclass190.decimal_0 = GClass226.smethod_13(4) >= 4 ? (Decimal) (GClass226.smethod_13(4) + 1) : (Decimal) (GClass226.smethod_13(11) - 1) / 10M;
              break;
            case GEnum49.const_1:
              gclass190.decimal_0 = 0M;
              break;
            case GEnum49.const_2:
              gclass190.decimal_0 = 2M;
              break;
          }
          this.dictionary_4.Add(gclass190.gclass189_0.int_0, gclass190);
        }
      }
      Decimal num1 = this.decimal_66 / 100M;
      foreach (GClass190 gclass190 in this.dictionary_4.Values)
      {
        if (this.decimal_30 > gclass190.gclass189_0.decimal_0)
        {
          gclass190.decimal_2 = gclass190.decimal_1;
          if (gclass190.gclass189_0.genum49_0 == GEnum49.const_0)
          {
            Decimal num2 = gclass190.decimal_0 * this.decimal_30 * num1 * GClass226.decimal_4 * this.decimal_46;
            Decimal num3 = this.decimal_30 * num1 * GClass226.decimal_4 * this.decimal_46;
            gclass190.decimal_1 += num2 * decimal_90;
            gclass190.decimal_1 -= num3 * decimal_90;
            if (num2 > num3 && gclass190.decimal_1 > num2 - num3)
              gclass190.decimal_1 = num2 - num3;
            if (num3 > num2 && gclass190.decimal_1 < 0M - num3 + num2)
              gclass190.decimal_1 = 0M - num3 + num2;
          }
          else if (gclass190.gclass189_0.genum49_0 == GEnum49.const_2)
          {
            Decimal num4 = this.method_62(AuroraProductionCategory.Infrastructure);
            Decimal num5 = gclass190.decimal_0 * this.decimal_30 * num1 * GClass226.decimal_4 * this.decimal_46;
            gclass190.decimal_1 += num5 * decimal_90;
            Decimal num6 = (Decimal) this.int_4 - num4;
            if (this.genum19_0 == GEnum19.const_0)
              num6 = (Decimal) this.int_4 * GClass226.decimal_56 - num4;
            if (num6 > 0M)
            {
              this.method_65(AuroraInstallationType.Infrastructure, gclass190.decimal_1);
              gclass190.decimal_1 = 0M;
            }
            if (gclass190.decimal_1 > num5)
              gclass190.decimal_1 = num5;
          }
          else if (gclass190.gclass189_0.genum49_0 == GEnum49.const_1 && this.gclass1_0.gclass174_0 == null)
          {
            Decimal num7 = this.decimal_30 * num1 * GClass226.decimal_4 * this.decimal_46;
            gclass190.decimal_1 -= num7 * decimal_90;
            if (gclass190.decimal_1 > num7)
              gclass190.decimal_1 = num7;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2090);
    }
  }

  public void method_8(double double_2)
  {
    try
    {
      if (this.gclass6_0 != null)
        this.gclass6_0.method_8();
      if (this.gclass223_0 == null)
        this.gclass223_0 = this.gclass0_0.dictionary_23[GEnum47.const_0];
      if (this.gclass223_0 == this.gclass0_0.dictionary_23[GEnum47.const_0] || this.gclass1_0.double_7 < GClass226.double_28)
        return;
      double num1 = (double) this.decimal_24 * double_2;
      double num2 = 4.0 * GClass226.double_13 * Math.Pow(this.gclass1_0.double_20, 2.0);
      double num3 = num1 * ((double) GClass226.decimal_15 / num2);
      this.gclass1_0.method_49(this.gclass194_0);
      GClass224 gclass224 = this.gclass1_0.list_0.Where<GClass224>((Func<GClass224, bool>) (gclass224_0 => gclass224_0.gclass223_0 == this.gclass223_0)).FirstOrDefault<GClass224>();
      if (gclass224 == null && this.genum31_0 == GEnum31.const_1)
        this.gclass1_0.list_0.Add(new GClass224()
        {
          gclass223_0 = this.gclass223_0,
          int_0 = this.gclass1_0.int_0,
          double_1 = num3,
          double_0 = 0.0,
          bool_0 = false
        });
      else if (gclass224 == null && this.genum31_0 == GEnum31.const_0)
      {
        if (this.gclass223_0.genum47_0 != GEnum47.const_5 || this.gclass1_0.double_19 == 0.0)
        {
          this.gclass223_0 = (GClass223) null;
          this.double_0 = 0.0;
        }
      }
      else if (gclass224 != null && this.genum31_0 == GEnum31.const_1)
      {
        gclass224.double_1 += num3;
        if (gclass224.double_1 > this.double_0 && this.double_0 > 0.0)
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_47, $"Addition of {gclass224.gclass223_0.Name} to the atmosphere of {this.PopName} has reached the required level", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopEnvironment);
          this.gclass223_0 = (GClass223) null;
          this.double_0 = 0.0;
        }
      }
      else if (gclass224 != null && this.genum31_0 == GEnum31.const_0)
      {
        gclass224.double_1 -= num3;
        if (gclass224.double_1 <= 0.0)
        {
          if (this.gclass223_0.genum47_0 == GEnum47.const_5 && this.gclass1_0.double_19 != 0.0)
          {
            gclass224.double_1 = 0.0;
          }
          else
          {
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_46, $"All traces of {gclass224.gclass223_0.Name} have been removed from the atmosphere of {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopEnvironment);
            this.gclass1_0.list_0.Remove(gclass224);
            this.gclass223_0 = (GClass223) null;
          }
        }
        else if (gclass224.double_1 <= this.double_0 && this.double_0 > 0.0)
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_46, $"Removal of {gclass224.gclass223_0.Name} from the atmosphere of {this.PopName} has reached the required level", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopEnvironment);
          this.gclass223_0 = (GClass223) null;
          this.double_0 = 0.0;
        }
      }
      this.gclass1_0.method_46();
      this.gclass1_0.method_49(this.gclass194_0);
      this.gclass1_0.method_36(this.gclass21_0);
      this.gclass1_0.method_35();
      this.gclass1_0.method_32();
      this.gclass1_0.method_58(this.gclass21_0, this.gclass194_0, true);
      if (this.gclass1_0.decimal_1 >= 0M && this.gclass1_0.decimal_1 < 1.5M && this.decimal_4 == 0M && this.gclass21_0.bool_0)
        this.gclass21_0.gclass2_0.method_26(this.gclass1_0, this.gclass194_0);
      this.method_184();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2091);
    }
  }

  public void method_9(Decimal decimal_90)
  {
    try
    {
      Decimal num1 = 0M;
      foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof (AuroraElement)))
      {
        Decimal num2 = this.gclass123_0.method_14(auroraElement_0);
        if (!(num2 == 0M))
        {
          Decimal num3 = this.gclass123_2.method_14(auroraElement_0);
          Decimal num4 = num2 - num3;
          if (!(num4 <= 0M))
            num1 += num4;
        }
      }
      if (num1 < 1M)
        return;
      Decimal num5 = this.decimal_69 * decimal_90;
      GClass126 gclass126 = new GClass126();
      gclass126.int_0 = this.gclass0_0.method_26(GEnum0.const_27);
      gclass126.gclass146_0 = this.gclass146_0;
      gclass126.gclass200_0 = this.gclass202_0.gclass200_0;
      gclass126.gclass21_0 = this.gclass21_0;
      gclass126.double_0 = this.method_87();
      gclass126.double_1 = this.method_88();
      gclass126.double_2 = this.method_87();
      gclass126.double_3 = this.method_88();
      gclass126.double_4 = this.method_87();
      gclass126.double_5 = this.method_88();
      gclass126.gclass123_0 = new GClass123(this.gclass0_0);
      gclass126.decimal_0 = (Decimal) GClass226.int_29;
      Decimal num6 = 1M;
      if (num1 > num5)
        num6 = num5 / num1;
      foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof (AuroraElement)))
      {
        if (auroraElement_0 != AuroraElement.None)
        {
          Decimal num7 = this.gclass123_0.method_14(auroraElement_0);
          if (!(num7 == 0M))
          {
            Decimal num8 = this.gclass123_2.method_14(auroraElement_0);
            Decimal num9 = num7 - num8;
            if (!(num9 <= 0M))
            {
              Decimal decimal_11 = num9 * num6;
              gclass126.gclass123_0.method_33(auroraElement_0, decimal_11);
              this.gclass123_0.method_33(auroraElement_0, -decimal_11);
              this.gclass123_3.method_33(auroraElement_0, -decimal_11);
            }
          }
        }
      }
      gclass126.decimal_1 = gclass126.gclass123_0.method_7();
      if (!(gclass126.decimal_1 > 0M))
        return;
      this.gclass0_0.dictionary_7.Add(gclass126.int_0, gclass126);
      gclass126.decimal_0 = (Decimal) GClass226.int_29 * (num5 / gclass126.decimal_1);
      if (this.gclass21_0.bool_0)
        return;
      gclass126.gclass123_0.method_24(this, GEnum85.const_12);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2092);
    }
  }

  public void method_10(Decimal decimal_90)
  {
    try
    {
      GClass126 gclass126 = new GClass126();
      GEnum24 genum24 = GEnum24.const_0;
      this.gclass123_4 = new GClass123(this.gclass0_0);
      if (this.decimal_23 > 0M)
      {
        if (this.gclass1_0.dictionary_0.Count > 0)
        {
          int num = this.method_73(AuroraInstallationType.CivilianMiningComplex);
          if (this.gclass21_0.bool_0)
            genum24 = GEnum24.const_2;
          else if (this.bool_1)
          {
            this.gclass21_0.method_299((Decimal) (num * GClass226.int_4) * decimal_90, this.gclass0_0.dictionary_45[GEnum84.const_18]);
            genum24 = this.gclass146_0 != null ? GEnum24.const_3 : GEnum24.const_2;
          }
          else
          {
            this.gclass21_0.method_300((Decimal) (num * GClass226.int_3) * decimal_90, this.gclass0_0.dictionary_45[GEnum84.const_17]);
            genum24 = GEnum24.const_1;
          }
        }
        else if (this.dictionary_0.ContainsKey(AuroraInstallationType.CivilianMiningComplex))
        {
          this.dictionary_0.Remove(AuroraInstallationType.CivilianMiningComplex);
          this.method_68(AuroraInstallationType.TrackingStation, 1M);
          this.method_68(AuroraInstallationType.MassDriver, 1M);
          foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 == this && gclass103_0.gclass102_0.genum116_0 == GEnum116.const_2)).ToList<GClass103>())
            this.gclass0_0.dictionary_71.Remove(gclass103.int_0);
          if (this.gclass21_0.method_100(this))
          {
            this.gclass21_0.method_132(this);
            this.gclass0_0.gclass92_0.method_3(GEnum126.const_114, $"{this.gclass1_0.method_78(this.gclass21_0)} has exhausted all mineral deposits. Therefore, the civilian mining complexes at {this.PopName} have been disbanded and the colony has been removed.", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopMining);
            return;
          }
          this.gclass0_0.gclass92_0.method_3(GEnum126.const_114, $"{this.gclass1_0.method_78(this.gclass21_0)} has exhausted all mineral deposits. Therefore, the civilian mining complexes at {this.PopName} have been disbanded.", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopMining);
          return;
        }
      }
      if (genum24 == GEnum24.const_3)
      {
        gclass126.int_0 = this.gclass0_0.method_26(GEnum0.const_27);
        gclass126.gclass146_0 = this.gclass146_0;
        gclass126.gclass200_0 = this.gclass202_0.gclass200_0;
        gclass126.gclass21_0 = this.gclass21_0;
        gclass126.double_0 = this.method_87();
        gclass126.double_1 = this.method_88();
        gclass126.double_2 = this.method_87();
        gclass126.double_3 = this.method_88();
        gclass126.double_4 = this.method_87();
        gclass126.double_5 = this.method_88();
        gclass126.gclass123_0 = new GClass123(this.gclass0_0);
        gclass126.decimal_0 = (Decimal) GClass226.int_29;
      }
      foreach (AuroraElement auroraElement in Enum.GetValues(typeof (AuroraElement)))
      {
        if (auroraElement != AuroraElement.None)
        {
          string str1 = auroraElement.ToString();
          if (this.gclass1_0.dictionary_0.ContainsKey(auroraElement))
          {
            Decimal num1 = this.decimal_22 * this.gclass1_0.dictionary_0[auroraElement].decimal_1 * decimal_90;
            if (num1 > this.gclass1_0.dictionary_0[auroraElement].decimal_0)
            {
              num1 = this.gclass1_0.dictionary_0[auroraElement].decimal_0;
              string str2 = this.gclass1_0.method_78(this.gclass21_0);
              this.gclass0_0.gclass92_0.method_3(GEnum126.const_43, $"Deposits of {str1} have been exhausted on {str2}", this.gclass21_0, this.gclass1_0.gclass200_0, this, this.gclass1_0.double_0, this.gclass1_0.double_1, AuroraEventCategory.PopMining);
              this.gclass1_0.dictionary_0.Remove(auroraElement);
            }
            else
            {
              this.gclass1_0.dictionary_0[auroraElement].decimal_0 -= num1;
              if (this.gclass1_0.dictionary_0[auroraElement].decimal_0 < this.gclass1_0.dictionary_0[auroraElement].decimal_2)
                this.gclass1_0.dictionary_0[auroraElement].decimal_1 = Math.Round((this.gclass1_0.dictionary_0[auroraElement].decimal_3 - 0.1M) * (this.gclass1_0.dictionary_0[auroraElement].decimal_0 / this.gclass1_0.dictionary_0[auroraElement].decimal_2) + 0.1M, 2);
            }
            Decimal num2 = this.decimal_23 / this.decimal_22 * num1;
            switch (genum24)
            {
              case GEnum24.const_0:
              case GEnum24.const_2:
                this.gclass123_0.method_33(auroraElement, num1);
                if (!this.gclass21_0.bool_0)
                {
                  if (genum24 == GEnum24.const_0)
                  {
                    this.method_21(GEnum85.const_1, auroraElement, num1);
                  }
                  else
                  {
                    this.method_21(GEnum85.const_1, auroraElement, num1 - num2);
                    this.method_21(GEnum85.const_11, auroraElement, num2);
                  }
                }
                if (this.gclass1_0.dictionary_0.ContainsKey(auroraElement))
                {
                  this.gclass123_4.method_33(auroraElement, this.decimal_22 * this.gclass1_0.dictionary_0[auroraElement].decimal_1);
                  continue;
                }
                continue;
              case GEnum24.const_1:
                if (num1 > num2)
                {
                  this.gclass123_0.method_33(auroraElement, num1 - num2);
                  if (!this.gclass21_0.bool_0)
                    this.method_21(GEnum85.const_1, auroraElement, num1 - num2);
                  if (this.gclass1_0.dictionary_0.ContainsKey(auroraElement))
                  {
                    this.gclass123_4.method_33(auroraElement, this.decimal_22 * this.gclass1_0.dictionary_0[auroraElement].decimal_1 * (this.decimal_22 - this.decimal_23 / this.decimal_22));
                    continue;
                  }
                  continue;
                }
                continue;
              case GEnum24.const_3:
                if (num1 > num2)
                  this.gclass123_0.method_33(auroraElement, num1 - num2);
                gclass126.gclass123_0.method_33(auroraElement, num2);
                if (this.gclass1_0.dictionary_0.ContainsKey(auroraElement))
                {
                  this.gclass123_4.method_33(auroraElement, this.decimal_22 * this.gclass1_0.dictionary_0[auroraElement].decimal_1);
                  continue;
                }
                continue;
              default:
                continue;
            }
          }
        }
      }
      if (genum24 != GEnum24.const_3)
        return;
      gclass126.decimal_1 = gclass126.gclass123_0.method_7();
      if (!(gclass126.decimal_1 > 0M))
        return;
      this.gclass0_0.dictionary_7.Add(gclass126.int_0, gclass126);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2093);
    }
  }

  public void method_11(Decimal decimal_90)
  {
    try
    {
      if (!this.bool_2)
        return;
      Decimal num = this.decimal_61 * decimal_90;
      if (this.gclass123_0.decimal_7 < num / (Decimal) GClass226.int_28)
      {
        num = this.gclass123_0.decimal_7 / (Decimal) GClass226.int_28;
        this.gclass0_0.gclass92_0.method_3(GEnum126.const_41, "Shortage of Sorium in fuel production at " + this.PopName, this.gclass21_0, this.gclass1_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
      }
      this.gclass123_0.decimal_7 -= num / (Decimal) GClass226.int_28;
      if (!this.gclass21_0.bool_0)
        this.method_21(GEnum85.const_14, AuroraElement.Sorium, num / (Decimal) GClass226.int_28);
      this.decimal_3 += num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2094);
    }
  }

  public void method_12(Decimal decimal_90)
  {
    try
    {
      if (!this.bool_4)
        return;
      Decimal num1 = this.decimal_62 * decimal_90;
      Decimal num2 = num1;
      if (this.gclass123_0.decimal_0 < GClass226.decimal_9 * num2)
        num2 = this.gclass123_0.decimal_0 / GClass226.decimal_9;
      if (this.gclass123_0.decimal_8 < GClass226.decimal_10 * num2)
        num2 = this.gclass123_0.decimal_8 / GClass226.decimal_10;
      if (this.gclass123_0.decimal_10 < GClass226.decimal_11 * num2)
        num2 = this.gclass123_0.decimal_10 / GClass226.decimal_11;
      if (num2 < num1)
      {
        this.gclass0_0.gclass92_0.method_3(GEnum126.const_41, "Mineral shortage in maintenance supply production at " + this.PopName, this.gclass21_0, this.gclass1_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
        num1 = num2;
      }
      this.gclass21_0.method_299(num1 / GClass226.decimal_43, this.gclass0_0.dictionary_45[GEnum84.const_11]);
      this.gclass123_0.decimal_0 -= num1 * GClass226.decimal_9;
      this.gclass123_0.decimal_8 -= num1 * GClass226.decimal_10;
      this.gclass123_0.decimal_10 -= num1 * GClass226.decimal_11;
      if (!this.gclass21_0.bool_0)
      {
        this.method_21(GEnum85.const_16, AuroraElement.Duranium, num1 * GClass226.decimal_9);
        this.method_21(GEnum85.const_16, AuroraElement.Uridium, num1 * GClass226.decimal_10);
        this.method_21(GEnum85.const_16, AuroraElement.Gallicite, num1 * GClass226.decimal_11);
      }
      this.decimal_0 += num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2095);
    }
  }

  public void method_13(Decimal decimal_90)
  {
    try
    {
      Decimal num1 = 0M;
      this.method_14();
      Decimal num2 = decimal_90;
      while (true)
      {
        List<GClass106> list = this.dictionary_3.Values.ToList<GClass106>();
        if (list.Count != 0)
        {
          foreach (GClass106 gclass106 in list)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass146.Class1088 class1088 = new GClass146.Class1088();
            // ISSUE: reference to a compiler-generated field
            class1088.gclass106_0 = gclass106;
            // ISSUE: reference to a compiler-generated field
            if (!(class1088.gclass106_0.decimal_0 == 0M))
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              Decimal decimal_11_1 = Math.Round(Math.Round(this.decimal_67 * decimal_90 * (class1088.gclass106_0.decimal_2 / 100M), 4) / class1088.gclass106_0.decimal_0, 4);
              // ISSUE: reference to a compiler-generated field
              GClass123 gclass123_0 = class1088.gclass106_0.gclass102_0.method_4();
              // ISSUE: reference to a compiler-generated field
              Decimal num3 = Math.Round(this.gclass123_0.method_19(class1088.gclass106_0, gclass123_0, decimal_11_1), 4);
              if (num3 > 0M || num1 == 0M)
              {
                // ISSUE: reference to a compiler-generated field
                Decimal decimal_29 = Math.Round(num3 * class1088.gclass106_0.decimal_0, 0);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                num1 = Math.Round(class1088.gclass106_0.decimal_0 - class1088.gclass106_0.decimal_1, 4);
                if (decimal_29 > num1)
                {
                  Decimal num4 = 1M - num1 / decimal_29;
                  if (num2 > decimal_90 * num4)
                    num2 = decimal_90 * num4;
                  decimal_29 = num1;
                }
                else
                  num2 = 0M;
                // ISSUE: reference to a compiler-generated field
                Decimal decimal_11_2 = Math.Round(decimal_29 / class1088.gclass106_0.decimal_0, 4);
                this.gclass21_0.method_299(decimal_29, this.gclass0_0.dictionary_45[GEnum84.const_5]);
                this.gclass123_0.method_22(gclass123_0, decimal_11_2);
                if (!this.gclass21_0.bool_0)
                  gclass123_0.method_23(this, GEnum85.const_6, decimal_11_2);
                if (decimal_29 < num1)
                {
                  // ISSUE: reference to a compiler-generated field
                  class1088.gclass106_0.decimal_1 += decimal_29;
                }
                else
                {
                  GClass103 gclass103_0 = (GClass103) null;
                  // ISSUE: reference to a compiler-generated field
                  if (class1088.gclass106_0.int_2 > 0)
                  {
                    // ISSUE: reference to a compiler-generated method
                    gclass103_0 = this.gclass0_0.dictionary_71.Values.FirstOrDefault<GClass103>(new Func<GClass103, bool>(class1088.method_0));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  this.gclass21_0.method_158(class1088.gclass106_0.string_0, class1088.gclass106_0.gclass102_0.string_1, class1088.gclass106_0.gclass102_0, class1088.gclass106_0.gclass146_0, (GClass40) null, class1088.gclass106_0.gclass146_0.gclass194_0, gclass103_0, class1088.gclass106_0.int_1, class1088.gclass106_0.auroraGroundFormationFieldPosition_0);
                  // ISSUE: reference to a compiler-generated field
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_6, $"{class1088.gclass106_0.string_0} trained on {this.PopName}", this.gclass21_0, this.gclass1_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopGroundUnits);
                  // ISSUE: reference to a compiler-generated field
                  this.dictionary_3.Remove(class1088.gclass106_0.int_0);
                }
              }
            }
          }
          if (!(num2 == 0M) && this.list_0.Count != 0 && this.method_14())
            decimal_90 = num2;
          else
            goto label_23;
        }
        else
          break;
      }
      return;
label_23:
      if (this.list_0.Count == 0)
        return;
      this.method_14();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2096);
    }
  }

  public bool method_14()
  {
    try
    {
      if ((int) this.method_62(AuroraProductionCategory.GroundTraining) <= 0)
        return false;
      bool flag = false;
      Decimal num1 = this.dictionary_3.Values.Sum<GClass106>((Func<GClass106, Decimal>) (gclass106_0 => gclass106_0.decimal_2));
      if (num1 < 100M)
      {
        Decimal num2 = 100M - num1;
        foreach (GClass107 gclass107 in this.list_0.OrderBy<GClass107, int>((Func<GClass107, int>) (gclass107_0 => gclass107_0.int_0)).ToList<GClass107>())
        {
          if (!(gclass107.decimal_0 > num2))
          {
            this.method_122(gclass107.gclass102_0, gclass107.string_0, gclass107.decimal_0, gclass107.auroraGroundFormationFieldPosition_0, gclass107.int_2, gclass107.int_1);
            this.gclass0_0.gclass92_0.method_3(GEnum126.const_191, $"New formation training task started for {gclass107.string_0} at {this.PopName}", this.gclass21_0, this.gclass1_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopGroundUnits);
            this.list_0.Remove(gclass107);
            flag = true;
            num2 -= gclass107.decimal_0;
          }
          else
            break;
        }
        this.method_138();
      }
      return flag;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3399);
      return false;
    }
  }

  public void method_15(Decimal decimal_90)
  {
    try
    {
      Decimal num1 = 0M;
      foreach (GClass192 gclass192_0 in this.gclass0_0.dictionary_32.Values.Where<GClass192>((Func<GClass192, bool>) (gclass192_0 => gclass192_0.gclass146_0 == this && !gclass192_0.bool_2)).OrderBy<GClass192, bool>((Func<GClass192, bool>) (gclass192_0 => gclass192_0.bool_0)).ThenByDescending<GClass192, Decimal>((Func<GClass192, Decimal>) (gclass192_0 => gclass192_0.gclass22_0.decimal_14)).ThenBy<GClass192, string>((Func<GClass192, string>) (gclass192_0 => gclass192_0.string_0)).ToList<GClass192>())
      {
        if (gclass192_0.gclass193_0.gclass40_1 != null && gclass192_0.gclass193_0.gclass40_1.gclass85_0.gclass146_0 != gclass192_0.gclass193_0.gclass146_0)
        {
          int num2 = (int) MessageBox.Show($"{gclass192_0.method_0()} at {gclass192_0.gclass193_0.string_0} is not possible because the ship-based shipyard is no longer in orbit", "Task Not Possible");
        }
        else
        {
          if (gclass192_0.auroraSYTaskType_0 != AuroraSYTaskType.Refit && gclass192_0.auroraSYTaskType_0 != AuroraSYTaskType.AutoRefit)
            gclass192_0.gclass193_0.method_7(gclass192_0.gclass22_0);
          else
            gclass192_0.gclass193_0.method_7(gclass192_0.gclass22_1);
          Decimal num3 = Math.Round(gclass192_0.gclass193_0.decimal_4 * decimal_90, 4);
          Decimal decimal_11 = Math.Round(num3 / gclass192_0.decimal_0, 4);
          if (gclass192_0.auroraSYTaskType_0 != AuroraSYTaskType.Scrap)
            decimal_11 = Math.Round(this.gclass123_0.method_18(gclass192_0, decimal_11), 4);
          if (decimal_11 > 0M || num1 == 0M || decimal_11 == 0M && num3 > 0M)
          {
            Decimal decimal_29_1 = decimal_11 * gclass192_0.decimal_0;
            num1 = Math.Round(gclass192_0.decimal_0 - gclass192_0.decimal_1, 4);
            if (decimal_29_1 > num1)
              decimal_29_1 = num1;
            Decimal num4 = Math.Round(decimal_29_1 / gclass192_0.decimal_0, 4);
            switch (gclass192_0.auroraSYTaskType_0)
            {
              case AuroraSYTaskType.Construction:
                this.gclass21_0.method_299(decimal_29_1, this.gclass0_0.dictionary_45[GEnum84.const_4]);
                break;
              case AuroraSYTaskType.Repair:
                this.gclass21_0.method_299(decimal_29_1, this.gclass0_0.dictionary_45[GEnum84.const_26]);
                break;
              case AuroraSYTaskType.Refit:
              case AuroraSYTaskType.AutoRefit:
                this.gclass21_0.method_299(decimal_29_1, this.gclass0_0.dictionary_45[GEnum84.const_27]);
                break;
            }
            if (gclass192_0.auroraSYTaskType_0 != AuroraSYTaskType.Scrap)
            {
              this.gclass123_0.method_21(gclass192_0, num4);
              if (!this.gclass21_0.bool_0)
                gclass192_0.method_1(num4);
            }
            if (decimal_29_1 >= num1)
            {
              switch (gclass192_0.auroraSYTaskType_0)
              {
                case AuroraSYTaskType.Construction:
                  Decimal decimal_29_2 = this.gclass21_0.method_291(gclass192_0.gclass22_0);
                  GClass85 gclass85_0 = this.method_16(gclass192_0.gclass85_0);
                  GClass40 gclass40 = this.gclass21_0.method_304(this, (GClass40) null, gclass192_0.gclass193_0, gclass192_0.gclass22_0, gclass85_0, gclass192_0.gclass83_0, this.gclass194_0, (GClass40) null, (GClass187) null, gclass192_0.string_0, decimal_29_2, false, false, GEnum20.const_1);
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_2, $"{gclass40.ShipName} ({gclass40.gclass22_0.ClassName}) built at {this.PopName} and assigned to {gclass40.gclass85_0.FleetName}", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, this, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.PopShipbuiding);
                  if (gclass40.gclass21_0.bool_0 && gclass40.gclass85_0.gclass9_0.genum105_0 == GEnum105.const_11)
                  {
                    gclass40.gclass85_0.method_202();
                    break;
                  }
                  break;
                case AuroraSYTaskType.Repair:
                  gclass192_0.gclass40_0.list_12.Clear();
                  gclass192_0.gclass40_0.dictionary_5.Clear();
                  gclass192_0.gclass40_0.list_13.Clear();
                  gclass192_0.gclass40_0.bool_9 = false;
                  gclass192_0.gclass40_0.method_204("Repair completed at " + this.PopName);
                  Decimal decimal_73_1 = gclass192_0.gclass21_0.method_293(gclass192_0.gclass40_0);
                  if (gclass192_0.gclass40_0.decimal_15 > decimal_73_1)
                    this.gclass0_0.gclass92_0.method_3(GEnum126.const_3, $"{gclass192_0.string_0} repaired at {this.PopName}. Due to replacement crew, grade points have been reduced from {GClass226.smethod_39(gclass192_0.gclass40_0.decimal_15)} to {GClass226.smethod_39(decimal_73_1)}", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, this, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.PopShipbuiding);
                  else
                    this.gclass0_0.gclass92_0.method_3(GEnum126.const_3, $"{gclass192_0.string_0} repaired at {this.PopName}", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, this, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.PopShipbuiding);
                  gclass192_0.gclass40_0.decimal_15 = decimal_73_1;
                  Decimal num5 = (this.gclass0_0.decimal_0 - gclass192_0.gclass40_0.decimal_6) * (gclass192_0.decimal_0 / gclass192_0.gclass40_0.gclass22_0.decimal_4);
                  gclass192_0.gclass40_0.decimal_6 += num5;
                  this.gclass0_0.gclass92_0.method_2(GEnum126.const_108, $"As a result of repairs to {gclass192_0.string_0}, her maintenance clock has been reduced by {GClass226.smethod_42(num5 / GClass226.decimal_29, 2)} years", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.Ship);
                  break;
                case AuroraSYTaskType.Refit:
                case AuroraSYTaskType.AutoRefit:
                  string str1 = "";
                  string str2 = "";
                  int num6 = 0;
                  gclass192_0.gclass40_0.method_204($"Refit to {gclass192_0.gclass22_1.ClassName} completed at {this.PopName}");
                  if (gclass192_0.gclass22_1.int_11 > gclass192_0.gclass40_0.int_11)
                  {
                    Decimal decimal_73_2 = gclass192_0.gclass21_0.method_293(gclass192_0.gclass40_0);
                    str1 = $". {(gclass192_0.gclass22_1.int_11 - gclass192_0.gclass40_0.int_11).ToString()} additional crew required, changing grade points to {GClass226.smethod_39(decimal_73_2)}";
                  }
                  if (gclass192_0.gclass22_1.gclass61_0 != gclass192_0.gclass40_0.gclass22_0.gclass61_0)
                  {
                    num6 = gclass192_0.gclass40_0.method_203(false);
                    if (num6 == 1)
                      str2 = ". 1 officer was reassigned due to the rank requirement of the new design";
                    else if (num6 > 1)
                      str2 = $". {num6.ToString()} officers were reassigned due to the rank requirements of the new design";
                  }
                  Decimal num7 = (this.gclass0_0.decimal_0 - gclass192_0.gclass40_0.decimal_6) * (gclass192_0.decimal_0 / gclass192_0.gclass40_0.gclass22_0.decimal_4);
                  gclass192_0.gclass40_0.decimal_6 += num7;
                  gclass192_0.gclass40_0.list_7.Clear();
                  if (gclass192_0.auroraSYTaskType_0 == AuroraSYTaskType.AutoRefit)
                    this.method_17(gclass192_0);
                  gclass192_0.gclass40_0.method_199(gclass192_0.gclass22_1, this);
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_4, $"{gclass192_0.string_0} refitted to {gclass192_0.gclass22_1.ClassName} class at {this.PopName}{str2}{str1}", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, this, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.PopShipbuiding);
                  this.gclass0_0.gclass92_0.method_2(GEnum126.const_108, $"As a result of the refit to {gclass192_0.string_0}, her maintenance clock has been reduced by {GClass226.smethod_42(num7 / GClass226.decimal_29, 2)} years", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.Ship);
                  break;
                case AuroraSYTaskType.Scrap:
                  gclass192_0.gclass40_0.method_200(this);
                  gclass192_0.gclass40_0.method_202(this);
                  gclass192_0.gclass40_0.method_201();
                  this.decimal_3 += gclass192_0.gclass40_0.decimal_14;
                  this.decimal_0 += gclass192_0.gclass40_0.decimal_4;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_5, $"{gclass192_0.string_0} scrapped at {this.PopName}. Any intact components, fuel, maintenance supplies and ordnance have been recovered", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, this, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.PopShipbuiding);
                  this.gclass21_0.method_303(gclass192_0.gclass40_0, GEnum22.const_2);
                  break;
              }
              this.gclass0_0.dictionary_32.Remove(gclass192_0.int_0);
            }
            else
              gclass192_0.decimal_1 += decimal_29_1;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2097);
    }
  }

  public GClass85 method_16(GClass85 gclass85_3)
  {
    try
    {
      return gclass85_3 == null || this.gclass0_0.method_28(this.method_87(), this.method_88(), gclass85_3.double_2, gclass85_3.double_3) != 0.0 ? (GClass85) null : gclass85_3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3196);
      return (GClass85) null;
    }
  }

  public void method_17(GClass192 gclass192_0_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1089 class1089 = new GClass146.Class1089();
    // ISSUE: reference to a compiler-generated field
    class1089.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1089.gclass192_0 = gclass192_0_1;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass146.Class1090 class1090 = new GClass146.Class1090();
      // ISSUE: reference to a compiler-generated field
      class1090.class1089_0 = class1089;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (!class1090.class1089_0.gclass192_0.gclass193_0.method_8().Contains(class1090.class1089_0.gclass192_0.gclass22_1))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_185, $"{class1090.class1089_0.gclass192_0.gclass193_0.string_0} can no longer support the auto-refit task for {class1090.class1089_0.gclass192_0.gclass22_1.ClassName}", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopShipbuiding);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class1090.list_0 = this.gclass0_0.dictionary_32.Values.Where<GClass192>(new Func<GClass192, bool>(class1090.class1089_0.method_0)).Select<GClass192, GClass40>((Func<GClass192, GClass40>) (gclass192_0_2 => gclass192_0_2.gclass40_0)).ToList<GClass40>();
        // ISSUE: reference to a compiler-generated method
        GClass40 gclass40 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1090.method_0)).FirstOrDefault<GClass40>();
        if (gclass40 == null)
          return;
        GClass192 gclass192_0 = new GClass192();
        gclass192_0.int_0 = this.gclass0_0.method_26(GEnum0.const_2);
        gclass192_0.gclass21_0 = this.gclass21_0;
        gclass192_0.gclass146_0 = this;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass192_0.gclass193_0 = class1090.class1089_0.gclass192_0.gclass193_0;
        gclass192_0.gclass40_0 = gclass40;
        gclass192_0.gclass85_0 = gclass40.gclass85_0;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass192_0.gclass123_0 = class1090.class1089_0.gclass192_0.gclass123_0;
        gclass192_0.auroraSYTaskType_0 = AuroraSYTaskType.AutoRefit;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass192_0.decimal_0 = class1090.class1089_0.gclass192_0.decimal_0;
        gclass192_0.decimal_1 = 0M;
        gclass192_0.string_0 = gclass40.ShipName;
        gclass192_0.bool_2 = false;
        gclass192_0.bool_1 = this.gclass21_0.bool_0;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass192_0.bool_0 = class1090.class1089_0.gclass192_0.gclass22_0.bool_2;
        gclass192_0.gclass22_0 = gclass40.gclass22_0;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass192_0.gclass22_1 = class1090.class1089_0.gclass192_0.gclass22_1;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass192_0.bool_3 = class1090.class1089_0.gclass192_0.bool_3;
        if (gclass192_0.bool_3)
          this.method_34(gclass192_0, CheckState.Checked);
        this.gclass0_0.dictionary_32.Add(gclass192_0.int_0, gclass192_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2098);
    }
  }

  public void method_18(Decimal decimal_90)
  {
    try
    {
      foreach (GClass193 gclass193 in this.method_85())
      {
        if (gclass193.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.None && !gclass193.bool_0)
        {
          gclass193.method_6();
          Decimal decimal3 = gclass193.decimal_3;
          if (gclass193.auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.Retool)
            decimal3 *= (Decimal) gclass193.int_1;
          Decimal decimal_29 = decimal3 * decimal_90;
          if (gclass193.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.Continual)
          {
            Decimal num = gclass193.decimal_1 - gclass193.decimal_2;
            if (decimal_29 > num)
              decimal_29 = num;
          }
          if (this.gclass123_0.decimal_0 < decimal_29 / 2M)
          {
            this.gclass0_0.gclass92_0.method_3(GEnum126.const_41, $"Shortage of Duranium for shipyard upgrade of {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
            decimal_29 = this.gclass123_0.decimal_0 * 2M;
          }
          if (this.gclass123_0.decimal_1 < decimal_29 / 2M)
          {
            this.gclass0_0.gclass92_0.method_3(GEnum126.const_41, $"Shortage of Neutronium for shipyard upgrade of {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
            decimal_29 = this.gclass123_0.decimal_1 * 2M;
          }
          if (decimal_29 > 0M)
          {
            this.gclass21_0.method_299(decimal_29, this.gclass0_0.dictionary_45[GEnum84.const_10]);
            this.gclass123_0.decimal_0 -= decimal_29 / 2M;
            this.gclass123_0.decimal_1 -= decimal_29 / 2M;
            if (!this.gclass21_0.bool_0)
            {
              this.method_21(GEnum85.const_9, AuroraElement.Duranium, decimal_29 / 2M);
              this.method_21(GEnum85.const_9, AuroraElement.Neutronium, decimal_29 / 2M);
            }
            gclass193.decimal_2 += decimal_29;
            if (gclass193.decimal_2 == gclass193.decimal_1 || gclass193.auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.Continual)
            {
              switch (gclass193.auroraShipyardUpgradeType_0)
              {
                case AuroraShipyardUpgradeType.AddSlipway:
                  ++gclass193.int_1;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"Slipway added to {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                  break;
                case AuroraShipyardUpgradeType.Add500:
                  gclass193.decimal_0 += 500M;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"500 tons of capacity added to {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                  break;
                case AuroraShipyardUpgradeType.Add1000:
                  gclass193.decimal_0 += 1000M;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"1000 tons of capacity added to {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                  break;
                case AuroraShipyardUpgradeType.Add2000:
                  gclass193.decimal_0 += 2000M;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"2000 tons of capacity added to {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                  break;
                case AuroraShipyardUpgradeType.Add5000:
                  gclass193.decimal_0 += 5000M;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"5000 tons of capacity added to {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                  break;
                case AuroraShipyardUpgradeType.Add10000:
                  gclass193.decimal_0 += 10000M;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"10000 tons of capacity added to {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                  break;
                case AuroraShipyardUpgradeType.Retool:
                  gclass193.gclass22_0 = gclass193.gclass22_1;
                  this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"Retooling for {gclass193.gclass22_1.ClassName} class completed at {gclass193.string_0} at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                  break;
                case AuroraShipyardUpgradeType.Continual:
                  Decimal num = (Decimal) (GClass226.int_56 * gclass193.int_1) * this.gclass21_0.decimal_21;
                  if (gclass193.auroraShipyardType_0 != AuroraShipyardType.Commercial && gclass193.auroraShipyardType_0 != AuroraShipyardType.RepairYard)
                    gclass193.decimal_0 += decimal_29 / num * 500M;
                  else
                    gclass193.decimal_0 += decimal_29 / num * 5000M;
                  if (gclass193.decimal_0 >= (Decimal) gclass193.int_2 && gclass193.int_2 > 0)
                  {
                    gclass193.decimal_0 = (Decimal) gclass193.int_2;
                    this.gclass0_0.gclass92_0.method_3(GEnum126.const_74, $"The continual capacity task for {gclass193.string_0} at {this.PopName} has reached its target capacity", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.SYUpgrade);
                    gclass193.gclass22_1 = (GClass22) null;
                    gclass193.decimal_1 = 0M;
                    gclass193.decimal_2 = 0M;
                    gclass193.auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.None;
                    break;
                  }
                  break;
              }
              if (gclass193.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.Continual)
              {
                gclass193.gclass22_1 = (GClass22) null;
                gclass193.decimal_1 = 0M;
                gclass193.decimal_2 = 0M;
                gclass193.auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.None;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2099);
    }
  }

  public void method_19(Decimal decimal_90)
  {
    try
    {
      Decimal num1 = 0M;
      foreach (GClass156 gclass156_1 in this.dictionary_2.Values.Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.int_2 == 0 && !gclass156_0.bool_0)).ToList<GClass156>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1091 class1091 = new GClass146.Class1091();
        // ISSUE: reference to a compiler-generated field
        class1091.gclass156_0 = gclass156_1;
        // ISSUE: reference to a compiler-generated field
        if (!(class1091.gclass156_0.decimal_2 <= 0M))
        {
          // ISSUE: reference to a compiler-generated field
          switch (class1091.gclass156_0.auroraProductionCategory_0)
          {
            case AuroraProductionCategory.Construction:
              // ISSUE: reference to a compiler-generated field
              num1 = this.decimal_58 * decimal_90 * (class1091.gclass156_0.decimal_3 / 100M);
              break;
            case AuroraProductionCategory.Ordnance:
              // ISSUE: reference to a compiler-generated field
              num1 = this.decimal_59 * decimal_90 * (class1091.gclass156_0.decimal_3 / 100M);
              break;
            case AuroraProductionCategory.Fighter:
              // ISSUE: reference to a compiler-generated field
              num1 = this.decimal_60 * decimal_90 * (class1091.gclass156_0.decimal_3 / 100M);
              break;
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class1091.gclass156_0.auroraProductionCategory_0 == AuroraProductionCategory.Construction && class1091.gclass156_0.gclass157_0 != null && (class1091.gclass156_0.gclass157_0.auroraInstallationType_0 == AuroraInstallationType.ForcedLabourConstructionCamp || class1091.gclass156_0.gclass157_0.auroraInstallationType_0 == AuroraInstallationType.ForcedLabourMiningCamp) && class1091.gclass156_0.gclass146_0.decimal_30 < 0.1M)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_147, $"There is insufficient population to complete {class1091.gclass156_0.string_0} at {class1091.gclass156_0.gclass146_0.PopName}", class1091.gclass156_0.gclass21_0, class1091.gclass156_0.gclass146_0.gclass1_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            Decimal decimal_11 = num1 / class1091.gclass156_0.decimal_2;
            // ISSUE: reference to a compiler-generated field
            if (decimal_11 > class1091.gclass156_0.decimal_0)
            {
              // ISSUE: reference to a compiler-generated field
              decimal_11 = class1091.gclass156_0.decimal_0;
            }
            // ISSUE: reference to a compiler-generated field
            Decimal num2 = this.gclass123_0.method_17(class1091.gclass156_0, decimal_11);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (num2 > 0M && class1091.gclass156_0.int_1 > 0 && this.decimal_3 < (Decimal) class1091.gclass156_0.int_1 * num2)
            {
              // ISSUE: reference to a compiler-generated field
              num2 = this.decimal_3 / (Decimal) class1091.gclass156_0.int_1;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_80, $"Fuel shortage in Production of {class1091.gclass156_0.string_0} at {class1091.gclass156_0.gclass146_0.PopName}", class1091.gclass156_0.gclass21_0, class1091.gclass156_0.gclass146_0.gclass1_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class1091.gclass156_0.auroraProductionType_0 == AuroraProductionType.Construction && class1091.gclass156_0.gclass157_0.auroraInstallationType_1 > AuroraInstallationType.NoType)
            {
              // ISSUE: reference to a compiler-generated field
              Decimal num3 = this.method_63(class1091.gclass156_0.gclass157_0.auroraInstallationType_0, num2);
              if (num3 < num2)
              {
                num2 = num3;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.gclass92_0.method_2(GEnum126.const_144, $"Cannot continue installation conversion at {class1091.gclass156_0.gclass146_0.PopName} due to a lack of source installations", class1091.gclass156_0.gclass21_0, class1091.gclass156_0.gclass146_0.gclass1_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
              }
            }
            if (num2 > 0M)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (class1091.gclass156_0.auroraProductionCategory_0 != AuroraProductionCategory.Ordnance || !class1091.gclass156_0.gclass21_0.bool_0)
              {
                // ISSUE: reference to a compiler-generated field
                Decimal decimal_29 = num2 * class1091.gclass156_0.decimal_2;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1091.gclass156_0.gclass21_0.method_299(decimal_29, class1091.gclass156_0.gclass150_0);
                // ISSUE: reference to a compiler-generated field
                this.gclass123_0.method_20(class1091.gclass156_0, num2);
                if (!this.gclass21_0.bool_0)
                {
                  // ISSUE: reference to a compiler-generated field
                  class1091.gclass156_0.method_0(num2);
                }
                // ISSUE: reference to a compiler-generated field
                this.decimal_3 -= (Decimal) class1091.gclass156_0.int_1 * num2;
              }
              // ISSUE: reference to a compiler-generated field
              class1091.gclass156_0.decimal_1 += num2;
              // ISSUE: reference to a compiler-generated field
              int num4 = (int) Math.Floor(class1091.gclass156_0.decimal_1);
              // ISSUE: reference to a compiler-generated field
              class1091.gclass156_0.decimal_1 -= (Decimal) num4;
              if (num4 > 0)
              {
                // ISSUE: reference to a compiler-generated field
                switch (class1091.gclass156_0.auroraProductionType_0)
                {
                  case AuroraProductionType.Construction:
                    // ISSUE: reference to a compiler-generated field
                    if (class1091.gclass156_0.gclass157_0 != null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      this.method_65(class1091.gclass156_0.gclass157_0.auroraInstallationType_0, (Decimal) num4);
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (class1091.gclass156_0.gclass157_0.auroraInstallationType_0 == AuroraInstallationType.ForcedLabourConstructionCamp || class1091.gclass156_0.gclass157_0.auroraInstallationType_0 == AuroraInstallationType.ForcedLabourMiningCamp)
                      {
                        // ISSUE: reference to a compiler-generated field
                        class1091.gclass156_0.gclass146_0.decimal_8 += 5M;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1091.gclass156_0.gclass146_0.method_25(class1091.gclass156_0.gclass146_0.decimal_4 - 0.1M);
                        break;
                      }
                      break;
                    }
                    break;
                  case AuroraProductionType.Ordnance:
                    // ISSUE: reference to a compiler-generated field
                    if (class1091.gclass156_0.gclass129_0 != null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      this.method_149(class1091.gclass156_0.gclass129_0, num4);
                      break;
                    }
                    break;
                  case AuroraProductionType.Fighter:
                    // ISSUE: reference to a compiler-generated field
                    if (class1091.gclass156_0.gclass22_0 != null)
                    {
                      for (; num4 > 0; --num4)
                      {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass146.Class1092 class1092 = new GClass146.Class1092();
                        // ISSUE: reference to a compiler-generated field
                        Decimal decimal_29 = this.gclass21_0.method_291(class1091.gclass156_0.gclass22_0);
                        bool flag = true;
                        // ISSUE: reference to a compiler-generated field
                        class1092.genum105_0 = GEnum105.const_0;
                        if (!this.gclass21_0.bool_0)
                        {
                          if (this.gclass85_0 == null)
                            flag = false;
                          else if (this.gclass85_0.double_2 != this.method_87() || this.gclass85_0.double_3 != this.method_88())
                            flag = false;
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          class1092.genum105_0 = !(class1091.gclass156_0.gclass22_0.decimal_11 > 0M) ? GEnum105.const_84 : GEnum105.const_83;
                          // ISSUE: reference to a compiler-generated method
                          this.gclass85_0 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => gclass85_3.gclass1_0 == this.gclass1_0 && gclass85_3.gclass21_0 == this.gclass21_0)).FirstOrDefault<GClass85>(new Func<GClass85, bool>(class1092.method_0));
                          if (this.gclass85_0 == null)
                            flag = false;
                        }
                        if (!flag)
                        {
                          // ISSUE: reference to a compiler-generated field
                          this.gclass85_0 = this.gclass21_0.method_308(this.gclass21_0.method_290("New Fighters - " + this.PopName), (GClass83) null, this.gclass202_0, this.method_87(), this.method_88(), this.gclass1_0, class1092.genum105_0);
                        }
                        // ISSUE: reference to a compiler-generated field
                        GClass40 gclass40_2 = this.gclass85_0.method_181(class1091.gclass156_0.gclass22_0);
                        // ISSUE: reference to a compiler-generated field
                        string string_10 = class1091.gclass156_0.gclass22_0.method_39();
                        // ISSUE: reference to a compiler-generated field
                        GClass40 gclass40 = this.gclass21_0.method_304(this, (GClass40) null, (GClass193) null, class1091.gclass156_0.gclass22_0, this.gclass85_0, (GClass83) null, this.gclass194_0, gclass40_2, (GClass187) null, string_10, decimal_29, false, false, GEnum20.const_1);
                        this.gclass0_0.gclass92_0.method_3(GEnum126.const_187, $"{gclass40.ShipName} constructed at {this.PopName} and assigned to {gclass40.gclass85_0.FleetName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
                      }
                      break;
                    }
                    break;
                  case AuroraProductionType.Components:
                    // ISSUE: reference to a compiler-generated field
                    if (class1091.gclass156_0.gclass230_0 != null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      this.method_67(class1091.gclass156_0.gclass230_0, (Decimal) num4);
                      break;
                    }
                    break;
                  case AuroraProductionType.SpaceStation:
                    // ISSUE: reference to a compiler-generated field
                    if (class1091.gclass156_0.gclass22_0 != null)
                    {
                      for (; num4 > 0; --num4)
                      {
                        // ISSUE: reference to a compiler-generated field
                        Decimal decimal_29 = this.gclass21_0.method_291(class1091.gclass156_0.gclass22_0);
                        bool flag = true;
                        if (this.gclass85_1 == null)
                          flag = false;
                        else if (this.gclass85_1.double_2 != this.method_87() || this.gclass85_1.double_3 != this.method_88())
                          flag = false;
                        if (!flag)
                        {
                          // ISSUE: reference to a compiler-generated field
                          this.gclass85_1 = this.method_194(class1091.gclass156_0.gclass22_0.auroraClassMainFunction_0) ?? this.gclass21_0.method_308("Space Station", (GClass83) null, this.gclass202_0, this.method_87(), this.method_88(), this.gclass1_0, GEnum105.const_0);
                        }
                        // ISSUE: reference to a compiler-generated field
                        string string_10 = class1091.gclass156_0.gclass22_0.method_39();
                        // ISSUE: reference to a compiler-generated field
                        GClass40 gclass40 = this.gclass21_0.method_304(this, (GClass40) null, (GClass193) null, class1091.gclass156_0.gclass22_0, this.gclass85_1, (GClass83) null, this.gclass194_0, (GClass40) null, (GClass187) null, string_10, decimal_29, false, false, GEnum20.const_1);
                        this.gclass0_0.gclass92_0.method_3(GEnum126.const_2, $"{gclass40.ShipName} constructed at {this.PopName} and assigned to {gclass40.gclass85_0.FleetName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
                      }
                      break;
                    }
                    break;
                }
              }
              // ISSUE: reference to a compiler-generated field
              if (num2 == class1091.gclass156_0.decimal_0)
              {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass146.Class1093 class1093 = new GClass146.Class1093();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.gclass92_0.method_3(GEnum126.const_1, $"Production of {class1091.gclass156_0.string_0} completed at {class1091.gclass156_0.gclass146_0.PopName}", class1091.gclass156_0.gclass21_0, class1091.gclass156_0.gclass146_0.gclass1_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1093.gclass146_0 = class1091.gclass156_0.gclass146_0;
                // ISSUE: reference to a compiler-generated field
                this.method_135(class1091.gclass156_0);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                List<GClass156> list1 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1093.method_0)).SelectMany<GClass146, GClass156>((Func<GClass146, IEnumerable<GClass156>>) (gclass146_0 => (IEnumerable<GClass156>) gclass146_0.dictionary_2.Values)).Where<GClass156>(new Func<GClass156, bool>(class1091.method_0)).OrderBy<GClass156, int>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)).ToList<GClass156>();
                if (list1.Count > 0)
                {
                  // ISSUE: reference to a compiler-generated method
                  Decimal num5 = 100M - this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1091.method_1)).Sum<GClass156>((Func<GClass156, Decimal>) (gclass156_0 => gclass156_0.decimal_3));
                  foreach (GClass156 gclass156_2 in list1)
                  {
                    if (num5 >= gclass156_2.decimal_3)
                    {
                      gclass156_2.int_2 = 0;
                      num5 -= gclass156_2.decimal_3;
                      this.gclass0_0.gclass92_0.method_3(GEnum126.const_188, $"Production of {gclass156_2.string_0} has begun at {this.PopName}", this.gclass21_0, this.gclass202_0.gclass200_0, this, this.method_87(), this.method_88(), AuroraEventCategory.PopProduction);
                      if (num5 <= 0M)
                        break;
                    }
                  }
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  List<GClass156> list2 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1093.method_1)).SelectMany<GClass146, GClass156>((Func<GClass146, IEnumerable<GClass156>>) (gclass146_0 => (IEnumerable<GClass156>) gclass146_0.dictionary_2.Values)).Where<GClass156>(new Func<GClass156, bool>(class1091.method_2)).OrderBy<GClass156, int>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)).ToList<GClass156>();
                  int num6 = 1;
                  foreach (GClass156 gclass156_3 in list2)
                  {
                    gclass156_3.int_2 = num6;
                    ++num6;
                  }
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                class1091.gclass156_0.decimal_0 -= num2;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2100);
    }
  }

  public void method_20(Decimal decimal_90)
  {
    try
    {
      if (!this.bool_3)
        return;
      Decimal num = this.decimal_68 * decimal_90;
      if (this.decimal_4 < num)
        num = this.decimal_4;
      GClass146 gclass146 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass194_0 == this.gclass194_1 && gclass146_1.gclass21_0 == this.gclass21_0 && gclass146_1.gclass1_0 == this.gclass1_0)).FirstOrDefault<GClass146>() ?? this.gclass21_0.method_275(this.gclass1_0, this.gclass194_1);
      gclass146.method_25(gclass146.decimal_4 + num);
      this.method_25(this.decimal_4 - num);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2101);
    }
  }

  public string PopName { get; set; }

  public string PopNameWithRace { get; set; }

  public string ContactDropdownName { get; set; }

  public GClass146(GClass0 gclass0_1)
  {
    this.gclass0_0 = gclass0_1;
    this.gclass123_5 = new GClass123(this.gclass0_0);
  }

  public void method_21(GEnum85 genum85_0, AuroraElement auroraElement_0, Decimal decimal_90)
  {
    try
    {
      if (decimal_90 <= 0M)
        return;
      this.gclass21_0.list_4.Add(new GClass153()
      {
        gclass21_0 = this.gclass21_0,
        gclass146_0 = this,
        decimal_1 = this.gclass0_0.decimal_0,
        genum85_0 = genum85_0,
        auroraElement_0 = auroraElement_0,
        decimal_0 = decimal_90
      });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3935);
    }
  }

  public void method_22(int int_25, Decimal decimal_90)
  {
    try
    {
      int num1 = (int) ((Decimal) (int_25 * 5000) * decimal_90);
      foreach (GClass147 gclass147 in this.list_3)
        gclass147.gclass110_0 = this.gclass21_0.method_325(gclass147.gclass21_0.RaceID);
      this.list_3 = this.list_3.OrderBy<GClass147, AuroraContactStatus>((Func<GClass147, AuroraContactStatus>) (gclass147_0 => gclass147_0.gclass110_0.auroraContactStatus_0)).ThenByDescending<GClass147, int>((Func<GClass147, int>) (gclass147_0 => gclass147_0.int_0 - gclass147_0.int_1)).ToList<GClass147>();
      foreach (GClass147 gclass147 in this.list_3)
      {
        double num2 = 0.0;
        if (gclass147.gclass110_0.auroraCommStatus_0 == AuroraCommStatus.CommunicationEstablished)
        {
          int num3 = gclass147.int_0 - gclass147.int_1;
          double num4;
          if (num3 > num1)
          {
            gclass147.int_1 += num1;
            num4 = (double) num1 / 10.0;
          }
          else
          {
            num1 -= num3;
            gclass147.int_1 = gclass147.int_0;
            num4 = num2 + (double) num3 / 10.0;
          }
          if (gclass147.gclass110_0.auroraContactStatus_0 == AuroraContactStatus.Neutral)
            num4 /= 2.0;
          else if (gclass147.gclass110_0.auroraContactStatus_0 == AuroraContactStatus.Friendly)
            num4 /= 5.0;
          else if (gclass147.gclass110_0.auroraContactStatus_0 == AuroraContactStatus.Allied)
            num4 /= 10.0;
          else if (gclass147.gclass110_0.auroraContactStatus_0 == AuroraContactStatus.Civilian)
            num4 = 0.0;
          this.gclass21_0.method_162(gclass147.gclass110_0, num4);
          if (num4 > 0.0)
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_235, $"Enlisted prisoner interrogations on {this.PopName} have yielded {GClass226.smethod_44(num4, 1)} intelligence points on the {gclass147.gclass110_0.AlienRaceName}", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopResearch);
        }
      }
      foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass146_0 == this && gclass55_1.bool_4 && !gclass55_1.bool_5)).ToList<GClass55>())
      {
        GClass110 gclass110_1 = this.gclass21_0.method_325(gclass55.gclass21_0.RaceID);
        if (gclass110_1.auroraCommStatus_0 == AuroraCommStatus.CommunicationEstablished)
        {
          int num5 = gclass55.method_0();
          double num6 = (double) (gclass55.gclass194_0.int_7 + gclass55.gclass194_0.int_2) / (50.0 * (double) num5);
          double num7 = (double) (int_25 * 200) * (double) decimal_90 * num6;
          if ((double) GClass226.smethod_13(100) < num7)
          {
            gclass55.bool_5 = true;
            int int_72 = (int) Math.Pow((double) (num5 + 1), 3.0);
            double num8 = (double) (GClass226.smethod_13(int_72) + GClass226.smethod_13(int_72));
            if (gclass110_1.auroraContactStatus_0 == AuroraContactStatus.Neutral)
              num8 /= 2.0;
            else if (gclass110_1.auroraContactStatus_0 == AuroraContactStatus.Friendly)
              num8 /= 5.0;
            else if (gclass110_1.auroraContactStatus_0 == AuroraContactStatus.Allied)
              num8 /= 10.0;
            else if (gclass110_1.auroraContactStatus_0 == AuroraContactStatus.Civilian)
              num8 = 0.0;
            this.gclass21_0.method_162(gclass110_1, num8);
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_235, $"Interrogation of {gclass55.method_36()} (L{num5.ToString()}) of the {gclass110_1.AlienRaceName} has concluded, yielding {GClass226.smethod_43(num8)} intelligence points on the {gclass110_1.AlienRaceName}", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopResearch);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3821);
    }
  }

  public void method_23(ComboBox comboBox_0)
  {
    try
    {
      List<GClass194> list = this.gclass0_0.dictionary_37.Values.Where<GClass194>((Func<GClass194, bool>) (gclass194_2 => gclass194_2.gclass164_0 != null && gclass194_2.gclass194_0 == this.gclass194_0)).Where<GClass194>((Func<GClass194, bool>) (gclass194_2 => gclass194_2.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))).OrderBy<GClass194, string>((Func<GClass194, string>) (gclass194_0 => gclass194_0.SpeciesName)).ToList<GClass194>();
      comboBox_0.DisplayMember = "SpeciesName";
      comboBox_0.DataSource = (object) list;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3689);
    }
  }

  public Decimal method_24()
  {
    try
    {
      GClass158 gclass158 = this.dictionary_0.Values.FirstOrDefault<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.auroraInstallationType_0 == AuroraInstallationType.ResearchLab));
      return gclass158 == null ? 0M : gclass158.decimal_0 * this.gclass21_0.EconomicProdModifier * this.decimal_5 * this.decimal_31 * this.decimal_33 * this.gclass160_0.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3638);
      return 0M;
    }
  }

  public void method_25(Decimal decimal_90)
  {
    try
    {
      this.decimal_4 = !(decimal_90 < 0M) ? decimal_90 : 0M;
      this.decimal_30 = this.decimal_4 + this.decimal_29;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3555);
    }
  }

  public void method_26(Decimal decimal_90)
  {
    try
    {
      this.decimal_29 = !(decimal_90 < 0M) ? decimal_90 : 0M;
      this.decimal_30 = this.decimal_4 + this.decimal_29;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3556);
    }
  }

  public string method_27()
  {
    try
    {
      return this.gclass1_0.int_10 > 0 && this.gclass1_0.method_77(this.gclass21_0) ? $"  ({this.gclass0_0.dictionary_38[this.gclass1_0.int_8].string_0})" : "";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3253);
      return "";
    }
  }

  public bool method_28()
  {
    try
    {
      return this.dictionary_5.Values.Count<GClass148>((Func<GClass148, bool>) (gclass148_0 => gclass148_0.bool_0)) > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3417);
      return false;
    }
  }

  public void method_29(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_1)
  {
    try
    {
      SolidBrush solidBrush_0 = new SolidBrush(Color.Blue);
      Pen pen = new Pen(GClass226.color_3);
      if (this.gclass202_0.gclass21_0.chkPassive10 == CheckState.Checked || this.gclass202_0.gclass21_0.chkPassive100 == CheckState.Checked || this.gclass202_0.gclass21_0.chkPassive1000 == CheckState.Checked || this.gclass202_0.gclass21_0.chkPassive10000 == CheckState.Checked)
      {
        if (this.int_24 > 0)
        {
          if (this.gclass21_0.chkPassive10 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_24, 10, "Thermal");
          if (this.gclass21_0.chkPassive100 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_24, 100, "Thermal");
          if (this.gclass21_0.chkPassive1000 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_24, 1000, "Thermal");
          if (this.gclass21_0.chkPassive10000 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_24, 10000, "Thermal");
        }
        if (this.int_23 > 0)
        {
          if (this.gclass21_0.chkPassive10 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_23, 10, "EM");
          if (this.gclass21_0.chkPassive100 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_23, 100, "EM");
          if (this.gclass21_0.chkPassive1000 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_23, 1000, "EM");
          if (this.gclass21_0.chkPassive10000 == CheckState.Checked)
            this.method_31(graphics_0, solidBrush_0, pen, font_0, gclass222_0, this.gclass202_0, (double) this.int_23, 10000, "EM");
        }
      }
      if (this.gclass21_0.chkFiringRanges == CheckState.Checked && gclass202_1.double_2 < 100000000.0)
      {
        List<GClass229> gclass229List = this.method_30();
        pen.DashStyle = DashStyle.Dash;
        pen.DashPattern = new float[2]{ 10f, 3f };
        pen.Color = Color.FromArgb((int) byte.MaxValue, 185, 15);
        solidBrush_0.Color = Color.FromArgb((int) byte.MaxValue, 185, 15);
        foreach (GClass229 gclass229 in gclass229List)
        {
          double key = (double) (int) ((double) gclass229.int_0 / gclass202_1.double_2);
          if (key >= 1.0 && key <= 10000.0)
          {
            graphics_0.DrawEllipse(pen, (float) (gclass222_0.double_2 - key), (float) (gclass222_0.double_3 - key), (float) key * 2f, (float) key * 2f);
            string str = $"{gclass229.gclass230_0.Name}  {(gclass229.int_0 / 1000).ToString()}k";
            float num = graphics_0.MeasureString(str, font_0).Width / 2f;
            if (gclass222_0.dictionary_0.ContainsKey(key))
              gclass222_0.dictionary_0[key]++;
            else
              gclass222_0.dictionary_0.Add(key, 1);
            graphics_0.DrawString(str, font_0, (Brush) solidBrush_0, (float) gclass222_0.double_2 - num, (float) (gclass222_0.double_3 - key - 5.0) - (float) (15 * gclass222_0.dictionary_0[key]));
          }
        }
      }
      pen.Dispose();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3055);
    }
  }

  public List<GClass229> method_30()
  {
    try
    {
      Dictionary<GClass230, GClass229> dictionary = new Dictionary<GClass230, GClass229>();
      foreach (GClass39 gclass39 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 == this)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass101_0.gclass230_0 != null && gclass39_0.int_1 > 0)).ToList<GClass39>())
      {
        int int2 = gclass39.gclass101_0.int_2;
        int int_1 = gclass39.gclass101_0.int_1;
        if (int2 < int_1)
          int_1 = int2;
        if (!dictionary.ContainsKey(gclass39.gclass101_0.gclass230_0))
          dictionary.Add(gclass39.gclass101_0.gclass230_0, new GClass229(gclass39.gclass101_0.gclass230_0, int_1));
        else if (dictionary[gclass39.gclass101_0.gclass230_0].int_0 < int_1)
          dictionary[gclass39.gclass101_0.gclass230_0].int_0 = int_1;
      }
      return dictionary.Values.ToList<GClass229>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 911);
      return (List<GClass229>) null;
    }
  }

  public void method_31(
    Graphics graphics_0,
    SolidBrush solidBrush_0,
    Pen pen_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_1,
    double double_2,
    int int_25,
    string string_6)
  {
    try
    {
      pen_0.DashStyle = DashStyle.Dash;
      pen_0.DashPattern = new float[2]{ 12f, 4f };
      pen_0.Color = Color.LightCoral;
      solidBrush_0.Color = Color.LightCoral;
      if (string_6 == "EM")
      {
        pen_0.Color = Color.Thistle;
        solidBrush_0.Color = Color.Thistle;
      }
      double num1 = Math.Sqrt(double_2 * (double) int_25) * GClass226.double_18;
      double key = num1 / gclass202_1.double_2;
      if (key < 1.0)
        return;
      graphics_0.DrawEllipse(pen_0, (float) (gclass222_0.double_2 - key), (float) (gclass222_0.double_3 - key), (float) key * 2f, (float) key * 2f);
      string str1 = num1 <= 10000000.0 ? GClass226.smethod_44(num1 / 1000000.0, 1) : GClass226.smethod_44(num1 / 1000000.0, 0);
      string str2 = $"{this.PopName} vs {string_6} Signature-{int_25.ToString()}   {str1}m";
      float num2 = graphics_0.MeasureString(str2, font_0).Width / 2f;
      if (gclass222_0.dictionary_0.ContainsKey(key))
        gclass222_0.dictionary_0[key]++;
      else
        gclass222_0.dictionary_0.Add(key, 1);
      graphics_0.DrawString(str2, font_0, (Brush) solidBrush_0, (float) gclass222_0.double_2 - num2, (float) (gclass222_0.double_3 - key - 5.0) - (float) (15 * gclass222_0.dictionary_0[key]));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 915);
    }
  }

  public TreeNode method_32(TreeNode treeNode_0, GClass146 gclass146_1)
  {
    try
    {
      TreeNode node = new TreeNode();
      bool flag = false;
      int int_72_1 = (int) this.method_62(AuroraProductionCategory.Sensors);
      int int_72_2 = this.method_73(AuroraInstallationType.CivilianMiningComplex);
      if (this.decimal_30 > 0M)
      {
        node.Text = $"{this.string_0}  {GClass226.smethod_42(this.decimal_30, 2)}m{this.method_27()}";
        node.ForeColor = GClass226.color_2;
      }
      else if (this.decimal_72 > 0M)
        node.Text = $"{this.string_0}  {GClass226.smethod_38(this.decimal_72)}x AM";
      else if (int_72_2 > 0)
      {
        node.Text = $"{this.string_0}  {GClass226.smethod_37(int_72_2)}x CMC";
        if (this.bool_1 && this.decimal_30 == 0M)
          node.ForeColor = GClass226.color_13;
      }
      else
        node.Text = !(this.decimal_73 > 0M) ? (int_72_1 <= 0 ? this.string_0 + this.method_27() : $"{this.string_0}  {GClass226.smethod_37(int_72_1)}x DST") : $"{this.string_0}  {GClass226.smethod_38(this.decimal_73)}x Terra";
      if (this.bool_0 && gclass146_1 == null)
        flag = true;
      else if (gclass146_1 != null && this == gclass146_1)
        flag = true;
      node.Tag = (object) this;
      treeNode_0.Nodes.Add(node);
      return flag ? node : (TreeNode) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2103);
      return (TreeNode) null;
    }
  }

  public void method_33(GClass192 gclass192_0, CheckState checkState_0)
  {
    try
    {
      foreach (GClass228 gclass228 in gclass192_0.gclass22_0.dictionary_0.Values)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1094 class1094 = new GClass146.Class1094();
        // ISSUE: reference to a compiler-generated field
        class1094.gclass228_0 = gclass228;
        // ISSUE: reference to a compiler-generated field
        if (!class1094.gclass228_0.gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) || checkState_0 != CheckState.Unchecked)
        {
          // ISSUE: reference to a compiler-generated method
          GClass73 gclass73 = this.list_2.FirstOrDefault<GClass73>(new Func<GClass73, bool>(class1094.method_0));
          if (gclass73 != null)
          {
            Decimal decimal0 = gclass73.decimal_0;
            // ISSUE: reference to a compiler-generated field
            if (decimal0 > class1094.gclass228_0.decimal_0)
            {
              // ISSUE: reference to a compiler-generated field
              decimal0 = class1094.gclass228_0.decimal_0;
            }
            // ISSUE: reference to a compiler-generated field
            gclass192_0.decimal_0 -= class1094.gclass228_0.gclass230_0.decimal_2 * decimal0;
            // ISSUE: reference to a compiler-generated field
            gclass192_0.gclass123_0.method_11(class1094.gclass228_0.gclass230_0.gclass123_0, -decimal0);
            gclass73.decimal_0 -= decimal0;
            if (gclass73.decimal_0 <= 0M)
              this.list_2.Remove(gclass73);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2104);
    }
  }

  public void method_34(GClass192 gclass192_0, CheckState checkState_0)
  {
    try
    {
      if (gclass192_0.gclass22_1 == null)
        return;
      foreach (GClass228 gclass228_1 in gclass192_0.gclass22_1.dictionary_0.Values)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1095 class1095 = new GClass146.Class1095();
        // ISSUE: reference to a compiler-generated field
        class1095.gclass228_0 = gclass228_1;
        // ISSUE: reference to a compiler-generated method
        GClass228 gclass228_2 = gclass192_0.gclass22_0.dictionary_0.Values.FirstOrDefault<GClass228>(new Func<GClass228, bool>(class1095.method_0));
        Decimal num1 = 0M;
        if (gclass228_2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          num1 = class1095.gclass228_0.decimal_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (gclass228_2.decimal_0 < class1095.gclass228_0.decimal_0)
          {
            // ISSUE: reference to a compiler-generated field
            num1 = class1095.gclass228_0.decimal_0 - gclass228_2.decimal_0;
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (num1 > 0M && (!class1095.gclass228_0.gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) || checkState_0 != CheckState.Unchecked))
        {
          // ISSUE: reference to a compiler-generated method
          GClass73 gclass73 = this.list_2.FirstOrDefault<GClass73>(new Func<GClass73, bool>(class1095.method_1));
          if (gclass73 != null)
          {
            Decimal num2 = gclass73.decimal_0;
            if (num2 > num1)
              num2 = num1;
            // ISSUE: reference to a compiler-generated field
            gclass192_0.decimal_0 -= class1095.gclass228_0.gclass230_0.decimal_2 * num2;
            // ISSUE: reference to a compiler-generated field
            gclass192_0.gclass123_0.method_11(class1095.gclass228_0.gclass230_0.gclass123_0, -num2);
            gclass73.decimal_0 -= num2;
            if (gclass73.decimal_0 <= 0M)
              this.list_2.Remove(gclass73);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2105);
    }
  }

  public string method_35()
  {
    try
    {
      string str = $"{this.PopName + Environment.NewLine}Population: {Math.Round(this.decimal_30, 2).ToString()}m{Environment.NewLine}";
      if (this.decimal_13 > 0M)
        str = $"{str}Naval Shipyard Capacity: {GClass226.smethod_38(this.decimal_13)} tons{Environment.NewLine}";
      if (this.decimal_14 > 0M)
        str = $"{str}Commercial Shipyard Capacity: {GClass226.smethod_38(this.decimal_14)} tons{Environment.NewLine}";
      if (this.decimal_15 > 0M)
        str = $"{str}Repair Yard Capacity: {GClass226.smethod_38(this.decimal_15)} tons{Environment.NewLine}";
      if (this.decimal_77 > 0M)
        str = $"{str}Maintenance Capacity: {GClass226.smethod_38(this.decimal_77)} tons{Environment.NewLine}";
      foreach (GClass158 gclass158 in this.dictionary_0.Values.OrderBy<GClass158, Decimal>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_20)).ToList<GClass158>())
        str = $"{str}{gclass158.gclass157_0.Name}: {GClass226.smethod_39(gclass158.decimal_0)}{Environment.NewLine}";
      return str + Environment.NewLine;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2106);
      return "error";
    }
  }

  public void method_36(GClass146 gclass146_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1096 class1096 = new GClass146.Class1096();
    // ISSUE: reference to a compiler-generated field
    class1096.gclass146_0 = gclass146_1;
    try
    {
      // ISSUE: reference to a compiler-generated field
      foreach (GClass158 gclass158 in class1096.gclass146_0.dictionary_0.Values)
        this.method_65(gclass158.gclass157_0.auroraInstallationType_0, gclass158.decimal_0);
      // ISSUE: reference to a compiler-generated field
      foreach (GClass130 gclass130 in class1096.gclass146_0.list_1)
        this.method_149(gclass130.gclass129_0, gclass130.int_0);
      // ISSUE: reference to a compiler-generated field
      foreach (GClass73 gclass73 in class1096.gclass146_0.list_2)
        this.method_67(gclass73.gclass230_0, gclass73.decimal_0);
      // ISSUE: reference to a compiler-generated method
      foreach (GClass193 gclass193 in this.gclass0_0.dictionary_31.Values.Where<GClass193>(new Func<GClass193, bool>(class1096.method_0)).ToList<GClass193>())
        gclass193.gclass146_0 = this;
      // ISSUE: reference to a compiler-generated field
      this.gclass123_0.method_10(class1096.gclass146_0.gclass123_0);
      // ISSUE: reference to a compiler-generated field
      this.method_25(this.decimal_4 + class1096.gclass146_0.decimal_4);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class1096.gclass146_0.gclass21_0.method_132(class1096.gclass146_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2107);
    }
  }

  public bool method_37()
  {
    try
    {
      return this.decimal_30 > 0.01M || this.dictionary_0.Count > 0 || this.gclass0_0.dictionary_71.Values.Count<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 == this)) > 0 || this.gclass123_0.method_7() > 0M || this.list_3.Count > 0 || this.gclass21_0.genum6_0 != GEnum6.const_1 && this.list_1.Count > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2108);
      return false;
    }
  }

  public void method_38(GClass21 gclass21_2, double double_2)
  {
    try
    {
      if (this.dictionary_6.ContainsKey(gclass21_2))
        this.dictionary_6[gclass21_2] = this.dictionary_6[gclass21_2] + double_2;
      else
        this.dictionary_6.Add(gclass21_2, double_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2109);
    }
  }

  public void method_39()
  {
    try
    {
      GClass158 gclass158_1 = this.dictionary_0.Values.FirstOrDefault<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.auroraInstallationType_0 == AuroraInstallationType.FighterFactory));
      GClass158 gclass158_2 = this.dictionary_0.Values.FirstOrDefault<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.auroraInstallationType_0 == AuroraInstallationType.OrdnanceFactory));
      if (!this.gclass21_0.gclass20_0.bool_0 && this.gclass21_0.gclass20_0.bool_1 && gclass158_1 != null)
      {
        this.method_65(AuroraInstallationType.OrdnanceFactory, gclass158_1.decimal_0);
        this.dictionary_0.Remove(AuroraInstallationType.FighterFactory);
      }
      else if (!this.gclass21_0.gclass20_0.bool_1 && this.gclass21_0.gclass20_0.bool_0 && gclass158_2 != null)
      {
        this.method_65(AuroraInstallationType.FighterFactory, gclass158_2.decimal_0);
        this.dictionary_0.Remove(AuroraInstallationType.OrdnanceFactory);
      }
      else if (!this.gclass21_0.gclass20_0.bool_0 && gclass158_1 != null)
      {
        this.method_65(AuroraInstallationType.ConstructionFactory, gclass158_1.decimal_0);
        this.dictionary_0.Remove(AuroraInstallationType.FighterFactory);
      }
      else
      {
        if (this.gclass21_0.gclass20_0.bool_1 || gclass158_2 == null)
          return;
        this.method_65(AuroraInstallationType.ConstructionFactory, gclass158_2.decimal_0);
        this.dictionary_0.Remove(AuroraInstallationType.OrdnanceFactory);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2110);
    }
  }

  public bool method_40()
  {
    try
    {
      return this.gclass1_0.double_7 < this.gclass194_0.double_7;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2111);
      return false;
    }
  }

  public Decimal method_41()
  {
    try
    {
      return this.dictionary_4.Count == 0 ? 0M : this.dictionary_4.Values.Max<GClass190>((Func<GClass190, Decimal>) (gclass190_0 => gclass190_0.decimal_1));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2112);
      return 0M;
    }
  }

  public Decimal method_42(int int_25)
  {
    try
    {
      return !this.dictionary_4.ContainsKey(int_25) ? 0M : this.dictionary_4[int_25].decimal_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2113);
      return 0M;
    }
  }

  public Decimal method_43(GClass85 gclass85_3_1)
  {
    try
    {
      if (!this.gclass21_0.bool_0 && gclass85_3_1.gclass187_0 != null && this.decimal_12 >= 10M)
        return 0M;
      Decimal num1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3_2 => gclass85_3_2.gclass21_0 == this.gclass21_0)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_5 && gclass139_0.gclass146_0 == this)).Select<GClass139, GClass85>((Func<GClass139, GClass85>) (gclass139_0 => gclass139_0.gclass85_0)).Distinct<GClass85>().Sum<GClass85>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.method_150())) / 1000000M;
      Decimal num2 = this.gclass1_0.method_62(this.gclass194_0) - this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass1_0 == this.gclass1_0)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_4));
      Decimal num3 = this.method_186();
      if (num2 < num3)
        num3 = num2;
      return num3 - num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2114);
      return 0M;
    }
  }

  public Decimal method_44()
  {
    try
    {
      return this.decimal_11 - this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => gclass85_3.gclass21_0 == this.gclass21_0 && gclass85_3.gclass187_0 != null)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_3 && gclass139_0.gclass146_0 == this)).Select<GClass139, GClass85>((Func<GClass139, GClass85>) (gclass139_0 => gclass139_0.gclass85_0)).Distinct<GClass85>().Sum<GClass85>((Func<GClass85, Decimal>) (gclass85_0 => gclass85_0.method_148())) / 1000000M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3776);
      return 0M;
    }
  }

  public void method_45(GClass230 gclass230_0)
  {
    try
    {
      if (gclass230_0.gclass164_0.gclass163_0.genum122_0 == GEnum122.const_55)
      {
        if (gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
          return;
        int num = (int) ((double) gclass230_0.gclass164_0.int_4 / 100.0 * (double) GClass226.smethod_13(5));
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_132, $"{GClass226.smethod_37(num)} research points for {gclass230_0.gclass164_0.Name} gained from disassembly of {gclass230_0.Name}", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopResearch);
        this.gclass21_0.method_76(gclass230_0.gclass164_0, num, this);
      }
      else
      {
        foreach (GClass164 gclass164 in gclass230_0.list_0)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass146.Class1097 class1097 = new GClass146.Class1097();
          // ISSUE: reference to a compiler-generated field
          class1097.gclass146_0 = this;
          // ISSUE: reference to a compiler-generated field
          class1097.gclass164_0 = gclass164;
          // ISSUE: reference to a compiler-generated field
          if (!class1097.gclass164_0.bool_0)
          {
            // ISSUE: reference to a compiler-generated method
            GClass164 gclass164_0_1 = this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1097.method_0)).OrderBy<GClass164, int>((Func<GClass164, int>) (gclass164_0 => gclass164_0.int_4)).FirstOrDefault<GClass164>();
            if (gclass164_0_1 != null)
            {
              string str = "";
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (class1097.gclass164_0 != gclass164_0_1 && class1097.gclass164_0.Name != gclass230_0.Name)
              {
                // ISSUE: reference to a compiler-generated field
                str = $" ({class1097.gclass164_0.Name})";
              }
              int num = (int) ((double) gclass164_0_1.int_4 / 100.0 * (double) GClass226.smethod_13(5));
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_132, $"{GClass226.smethod_37(num)} research points for {gclass164_0_1.Name} gained from disassembly of {gclass230_0.Name}{str}", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopResearch);
              this.gclass21_0.method_76(gclass164_0_1, num, this);
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2116);
    }
  }

  public bool method_46(GClass129 gclass129_0)
  {
    try
    {
      return gclass129_0.gclass164_0.gclass21_0 != null && !gclass129_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3811);
      return false;
    }
  }

  public void method_47(GClass73 gclass73_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1098 class1098 = new GClass146.Class1098();
    // ISSUE: reference to a compiler-generated field
    class1098.gclass73_0 = gclass73_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class1098.gclass73_0.gclass230_0.gclass164_0.gclass21_0 == null || class1098.gclass73_0.gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
        return;
      // ISSUE: reference to a compiler-generated field
      GClass230 gclass230 = this.gclass0_0.method_490(class1098.gclass73_0.gclass230_0, this.gclass21_0);
      if (gclass230 == null)
        return;
      // ISSUE: reference to a compiler-generated method
      GClass73 gclass73 = this.list_2.Where<GClass73>(new Func<GClass73, bool>(class1098.method_0)).FirstOrDefault<GClass73>();
      if (gclass73 != null)
      {
        // ISSUE: reference to a compiler-generated field
        gclass73.decimal_0 += class1098.gclass73_0.decimal_0;
        // ISSUE: reference to a compiler-generated field
        this.list_2.Remove(class1098.gclass73_0);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class1098.gclass73_0.gclass230_0 = gclass230;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3809);
    }
  }

  public bool method_48(GClass164 gclass164_0)
  {
    try
    {
      if (gclass164_0.gclass21_0 == null || gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID) || this.gclass21_0.list_18.Contains(gclass164_0))
        return false;
      this.gclass21_0.list_18.Add(gclass164_0);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3814);
      return false;
    }
  }

  public void method_49(GClass73 gclass73_0)
  {
    try
    {
      this.method_45(gclass73_0.gclass230_0);
      if (gclass73_0.decimal_0 == 1M)
        this.list_2.Remove(gclass73_0);
      else
        --gclass73_0.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2117);
    }
  }

  public void method_50(GClass235 gclass235_0)
  {
    try
    {
      for (int index = 1; index <= gclass235_0.int_0; ++index)
        this.method_45(gclass235_0.gclass230_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2118);
    }
  }

  public void method_51(GClass73 gclass73_0)
  {
    try
    {
      Decimal decimal_11 = gclass73_0.decimal_0 * 0.3M;
      Decimal num = gclass73_0.gclass230_0.decimal_2 * gclass73_0.decimal_0 * 0.3M;
      Decimal decimal_73 = gclass73_0.gclass230_0.gclass123_0.method_7() * decimal_11;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_69, $"{GClass226.smethod_38(gclass73_0.decimal_0)}x {gclass73_0.gclass230_0.Name} scrapped on {this.PopName}. Recovered {GClass226.smethod_38(num)} wealth and {GClass226.smethod_38(decimal_73)} tons of minerals", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopSummary);
      this.gclass123_0.method_11(gclass73_0.gclass230_0.gclass123_0, decimal_11);
      if (!this.gclass21_0.bool_0)
        gclass73_0.gclass230_0.gclass123_0.method_23(this, GEnum85.const_15, decimal_11);
      this.gclass21_0.method_300(num, this.gclass0_0.dictionary_45[GEnum84.const_9]);
      this.list_2.Remove(gclass73_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2119);
    }
  }

  public void method_52(GClass39 gclass39_0)
  {
    try
    {
      Decimal decimal_11 = (Decimal) gclass39_0.int_1 * 0.3M;
      Decimal num = gclass39_0.gclass101_0.decimal_3 * decimal_11;
      Decimal decimal_73 = gclass39_0.gclass101_0.gclass123_0.method_7() * decimal_11;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_197, $"{GClass226.smethod_37(gclass39_0.int_1)}x {gclass39_0.gclass101_0.ClassName} scrapped on {this.PopName}. Recovered {GClass226.smethod_38(num)} wealth and {GClass226.smethod_38(decimal_73)} tons of minerals", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopSummary);
      this.gclass123_0.method_11(gclass39_0.gclass101_0.gclass123_0, decimal_11);
      if (!this.gclass21_0.bool_0)
        gclass39_0.gclass101_0.gclass123_0.method_23(this, GEnum85.const_17, decimal_11);
      this.gclass21_0.method_300(num, this.gclass0_0.dictionary_45[GEnum84.const_9]);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2119);
    }
  }

  public void method_53(Decimal decimal_90, GClass157 gclass157_0)
  {
    try
    {
      Decimal decimal_11 = decimal_90 * 0.3M;
      Decimal num = gclass157_0.decimal_21 * decimal_11;
      Decimal decimal_73 = gclass157_0.gclass123_0.method_7() * decimal_11;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_196, $"{GClass226.smethod_38(decimal_90)}x {gclass157_0.Name} scrapped on {this.PopName}. Recovered {GClass226.smethod_38(num)} wealth and {GClass226.smethod_38(decimal_73)} tons of minerals", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopSummary);
      this.gclass123_0.method_11(gclass157_0.gclass123_0, decimal_11);
      if (!this.gclass21_0.bool_0)
        gclass157_0.gclass123_0.method_23(this, GEnum85.const_18, decimal_11);
      this.gclass21_0.method_300(num, this.gclass0_0.dictionary_45[GEnum84.const_9]);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3402);
    }
  }

  public void method_54(GClass130 gclass130_0)
  {
    try
    {
      Decimal decimal_11 = (Decimal) gclass130_0.int_0 * 0.25M;
      Decimal decimal_73_1 = (Decimal) (gclass130_0.gclass129_0.int_4 * gclass130_0.int_0);
      Decimal num = gclass130_0.gclass129_0.decimal_3 * (Decimal) gclass130_0.int_0 * 0.25M;
      Decimal decimal_73_2 = gclass130_0.gclass129_0.gclass123_0.method_7() * decimal_11;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_196, $"{GClass226.smethod_37(gclass130_0.int_0)}x {gclass130_0.gclass129_0.Name} scrapped on {this.PopName}. Recovered {GClass226.smethod_38(num)} wealth, {GClass226.smethod_38(decimal_73_1)} litres of fuel and {GClass226.smethod_38(decimal_73_2)} tons of minerals", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.PopSummary);
      this.gclass123_0.method_11(gclass130_0.gclass129_0.gclass123_0, decimal_11);
      if (!this.gclass21_0.bool_0)
        gclass130_0.gclass129_0.gclass123_0.method_23(this, GEnum85.const_19, decimal_11);
      this.decimal_3 += decimal_73_1;
      this.gclass21_0.method_300(num, this.gclass0_0.dictionary_45[GEnum84.const_9]);
      this.list_1.Remove(gclass130_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2120);
    }
  }

  public List<GClass103> method_55()
  {
    try
    {
      return this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 == this)).ToList<GClass103>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2121);
      return (List<GClass103>) null;
    }
  }

  public int method_56()
  {
    try
    {
      double a = 0.0;
      foreach (GClass103 gclass103 in this.method_55())
        a += (double) gclass103.method_23();
      return (int) Math.Round(a);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2122);
      return 0;
    }
  }

  public void method_57(ListView listView_0)
  {
    try
    {
      string string_20 = "";
      listView_0.Items.Clear();
      this.gclass0_0.method_620(listView_0, "Abbr", "Name", "Units", "Supply", "Morale", "Fort", "Size", "Cost", "HP", "GSP", "Formation Attributes", (object) null);
      List<GClass39> list = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 == this)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).ToList<GClass39>();
      if (list.Count == 0)
        return;
      List<GClass39> gclass39List = new List<GClass39>();
      foreach (GClass39 gclass39_1 in list)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1099 class1099 = new GClass146.Class1099();
        // ISSUE: reference to a compiler-generated field
        class1099.gclass39_0 = gclass39_1;
        // ISSUE: reference to a compiler-generated method
        GClass39 gclass39_2 = gclass39List.FirstOrDefault<GClass39>(new Func<GClass39, bool>(class1099.method_0));
        if (gclass39_2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          gclass39_2.int_1 += class1099.gclass39_0.int_1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          GClass39 gclass39_3 = class1099.gclass39_0.method_14();
          gclass39List.Add(gclass39_3);
        }
      }
      List<GClass39> source = this.gclass21_0.method_161(gclass39List);
      Decimal decimal_73_1 = (Decimal) source.Sum<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1));
      Decimal decimal_73_2 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => gclass39_0.gclass101_0.decimal_2 * (Decimal) gclass39_0.int_1));
      Decimal decimal_73_3 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => gclass39_0.gclass101_0.decimal_3 * (Decimal) gclass39_0.int_1));
      Decimal decimal_73_4 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => gclass39_0.gclass101_0.decimal_4 * (Decimal) gclass39_0.int_1));
      Decimal decimal_73_5 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => gclass39_0.gclass101_0.method_8() * (Decimal) gclass39_0.int_1));
      int int_72 = source.Max<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.gclass101_0.int_6));
      Decimal num1 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => (Decimal) gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_3))));
      Decimal num2 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => (Decimal) gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_4))));
      Decimal num3 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => (Decimal) gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_5))));
      Decimal num4 = source.Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => (Decimal) gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_7))));
      Decimal num5 = (Decimal) source.Sum<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_4))));
      Decimal num6 = (Decimal) source.Sum<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_2))));
      Decimal num7 = (Decimal) source.Sum<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_1))));
      Decimal num8 = (Decimal) source.Sum<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1 * gclass39_0.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5))));
      string str = GClass226.smethod_10(int_72);
      if (str != "-")
        string_20 = $"{string_20}HQ{str}  ";
      if (num6 > 0M)
        string_20 = $"{string_20}ST{num6.ToString()}  ";
      if (num7 > 0M)
        string_20 = $"{string_20}CW{num7.ToString()}  ";
      if (num5 > 0M)
        string_20 = $"{string_20}FD{num5.ToString()}  ";
      if (num1 > 0M)
      {
        Decimal num9 = num1 * this.gclass21_0.decimal_13 * 100M;
        string_20 = $"{string_20}CN{num1.ToString()}  FC{num9.ToString()}";
      }
      if (num2 > 0M)
        string_20 = $"{string_20}GE{num2.ToString()}  ";
      if (num3 > 0M)
        string_20 = $"{string_20}XN{num3.ToString()}  ";
      if (num4 > 0M)
        string_20 = $"{string_20}DC{num4.ToString()}  ";
      if (num8 > 0M)
        string_20 = $"{string_20}LG{Math.Round(num8 / 1000M).ToString()}  ";
      this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_621(listView_0, "", "Total Population Forces", GClass226.smethod_38(decimal_73_1), "-", "-", "-", GClass226.smethod_38(decimal_73_2), GClass226.smethod_38(decimal_73_3), GClass226.smethod_38(decimal_73_5), GClass226.smethod_38(decimal_73_4), string_20, "", (object) this);
      this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_599(listView_0, "", "Formation Unit List", GClass226.color_2, (object) null);
      foreach (GClass39 gclass39 in source)
        gclass39.method_15(listView_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2123);
    }
  }

  public void method_58(ListView listView_0, ListView listView_1)
  {
    try
    {
      listView_0.Items.Clear();
      listView_1.Items.Clear();
      this.list_1 = this.list_1.OrderBy<GClass130, string>((Func<GClass130, string>) (gclass130_0 => gclass130_0.gclass129_0.Name)).ToList<GClass130>();
      this.list_2 = this.list_2.OrderBy<GClass73, string>((Func<GClass73, string>) (gclass73_0 => gclass73_0.gclass230_0.Name)).ToList<GClass73>();
      foreach (GClass130 object_1 in this.list_1)
      {
        if (this.method_46(object_1.gclass129_0))
          this.gclass0_0.method_599(listView_0, object_1.gclass129_0.Name, GClass226.smethod_37(object_1.int_0), GClass226.color_13, (object) object_1);
        else
          this.gclass0_0.method_598(listView_0, object_1.gclass129_0.Name, GClass226.smethod_37(object_1.int_0), (object) object_1);
      }
      foreach (GClass73 object_1 in this.list_2)
      {
        int num = this.gclass21_0.method_103(object_1.gclass230_0) ? 1 : 0;
        bool flag1 = this.gclass21_0.method_104(object_1.gclass230_0);
        bool flag2 = this.gclass21_0.method_105(object_1.gclass230_0);
        if (num != 0)
          this.gclass0_0.method_599(listView_1, object_1.gclass230_0.Name, GClass226.smethod_38(object_1.decimal_0), GClass226.color_2, (object) object_1);
        else if (flag1)
          this.gclass0_0.method_599(listView_1, object_1.gclass230_0.Name, GClass226.smethod_38(object_1.decimal_0), GClass226.color_10, (object) object_1);
        else if (flag2)
          this.gclass0_0.method_599(listView_1, object_1.gclass230_0.Name, GClass226.smethod_38(object_1.decimal_0), GClass226.color_13, (object) object_1);
        else
          this.gclass0_0.method_598(listView_1, object_1.gclass230_0.Name, GClass226.smethod_38(object_1.decimal_0), (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2124);
    }
  }

  public void method_59(CheckState checkState_0, GClass143 gclass143_0, int int_25)
  {
    try
    {
      this.dictionary_0.Clear();
      this.decimal_3 = 0M;
      this.decimal_0 = 0M;
      this.gclass21_0.int_32 = 0;
      this.decimal_74 = this.decimal_4 / 4M;
      if (checkState_0 != CheckState.Unchecked)
        return;
      if (this.gclass21_0.genum82_0 != GEnum82.const_0 && this.gclass21_0.genum82_0 != GEnum82.const_4)
      {
        if (this.gclass21_0.genum82_0 == GEnum82.const_1)
        {
          this.gclass21_0.int_41 = 2;
          this.method_64(AuroraInstallationType.ConventionalIndustry, (Decimal) (int) (this.decimal_4 * 1.6M));
          this.method_64(AuroraInstallationType.MilitaryAcademy, 1M);
          this.method_64(AuroraInstallationType.GFCC, 1M);
          this.method_64(AuroraInstallationType.NavalHeadquarters, 1M);
          this.method_64(AuroraInstallationType.TrackingStation, 1M);
          this.method_64(AuroraInstallationType.MaintenanceFacility, 5M);
          this.method_64(AuroraInstallationType.Spaceport, 1M);
          this.method_64(AuroraInstallationType.ResearchLab, (Decimal) (int) Math.Floor(this.decimal_4 / 60M));
        }
        else
        {
          if (this.gclass21_0.genum82_0 != GEnum82.const_2)
            return;
          this.gclass21_0.int_41 = 2;
          this.method_64(AuroraInstallationType.ConventionalIndustry, (Decimal) (int) (this.decimal_4 * 1.6M));
          this.method_64(AuroraInstallationType.MilitaryAcademy, 1M);
          this.method_64(AuroraInstallationType.GFCC, 3M);
          this.method_64(AuroraInstallationType.NavalHeadquarters, 1M);
          this.method_64(AuroraInstallationType.TrackingStation, 3M);
          this.method_64(AuroraInstallationType.MaintenanceFacility, 25M);
          this.method_64(AuroraInstallationType.Spaceport, 1M);
        }
      }
      else
      {
        int decimal_90_1 = (int) Math.Floor(this.decimal_4 / 25M);
        if (!this.gclass21_0.bool_0 && decimal_90_1 > 50)
          decimal_90_1 = 50;
        if (decimal_90_1 > 100)
          decimal_90_1 = 100;
        this.method_64(AuroraInstallationType.ResearchLab, (Decimal) decimal_90_1);
        Decimal num = this.gclass0_0.decimal_0 / GClass226.decimal_29 + 20M;
        this.gclass21_0.int_32 = (int) ((Decimal) decimal_90_1 * num * 200M * (Decimal) ((double) this.gclass0_0.int_106 / 100.0) * this.gclass194_0.decimal_2);
        if (gclass143_0 != null)
        {
          this.gclass21_0.int_32 = (int) ((Decimal) this.gclass21_0.int_32 * gclass143_0.decimal_3);
          if (this.gclass21_0.int_32 < gclass143_0.int_11)
            this.gclass21_0.int_32 = gclass143_0.int_11;
        }
        if (this.gclass21_0.bool_0 && this.gclass21_0.int_32 < 150000)
          this.gclass21_0.int_32 = 150000;
        if (this.gclass21_0.genum6_0 == GEnum6.const_5 && this.gclass21_0.int_32 < int_25)
          this.gclass21_0.int_32 = int_25;
        if (!this.gclass21_0.bool_0 && this.gclass21_0.int_32 > this.gclass0_0.int_134)
          this.gclass0_0.int_134 = this.gclass21_0.int_32;
        this.gclass21_0.int_41 = (int) ((Decimal) decimal_90_1 / 5M);
        this.method_64(AuroraInstallationType.MilitaryAcademy, (Decimal) (int) Math.Ceiling((Decimal) this.gclass21_0.int_41 / 5M));
        if (this.gclass21_0.genum6_0 == GEnum6.const_0)
        {
          this.method_64(AuroraInstallationType.GFCC, (Decimal) this.gclass21_0.int_41);
          this.method_64(AuroraInstallationType.MassDriver, 1M);
          this.method_64(AuroraInstallationType.Infrastructure, 200M);
          this.method_64(AuroraInstallationType.TrackingStation, (Decimal) (2 + (int) (this.decimal_4 / 200M)));
          this.method_64(AuroraInstallationType.Spaceport, 1M);
          this.method_64(AuroraInstallationType.RefuellingStation, 1M);
          this.method_64(AuroraInstallationType.OrdnanceTransferStation, 1M);
          this.method_64(AuroraInstallationType.CargoShuttleStation, 1M);
          this.method_64(AuroraInstallationType.NavalHeadquarters, 1M);
          int decimal_90_2 = (int) (this.decimal_4 * 0.3M);
          this.method_64(AuroraInstallationType.MaintenanceFacility, (Decimal) decimal_90_2);
          this.decimal_0 = (Decimal) (decimal_90_2 * 200);
          int decimal_90_3 = (int) (this.decimal_4 * 0.8M);
          this.method_64(AuroraInstallationType.ConstructionFactory, (Decimal) decimal_90_3);
          this.method_64(AuroraInstallationType.Mine, (Decimal) decimal_90_3);
          this.method_64(AuroraInstallationType.FuelRefinery, (Decimal) Math.Round((double) decimal_90_3 / 4.0));
          this.method_64(AuroraInstallationType.OrdnanceFactory, (Decimal) Math.Round((double) decimal_90_3 / 4.0));
          this.method_64(AuroraInstallationType.FinancialCentre, (Decimal) Math.Round((double) decimal_90_3 / 2.0));
          this.method_64(AuroraInstallationType.AutomatedMine, (Decimal) Math.Round((double) decimal_90_3 / 5.0));
          this.method_64(AuroraInstallationType.FighterFactory, (Decimal) Math.Round((double) decimal_90_3 / 10.0));
          this.decimal_3 = (Decimal) (decimal_90_3 * 30000);
        }
        this.gclass21_0.decimal_25 = 3M * this.method_181();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2125);
    }
  }

  public void method_60(GClass157 gclass157_0, int int_25, bool bool_10)
  {
    try
    {
      this.method_61(gclass157_0, (Decimal) int_25, bool_10, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2126);
    }
  }

  public void method_61(GClass157 gclass157_0, Decimal decimal_90, bool bool_10, bool bool_11)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1100 class1100 = new GClass146.Class1100();
    // ISSUE: reference to a compiler-generated field
    class1100.gclass157_0 = gclass157_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass148 gclass148 = this.dictionary_5.Values.FirstOrDefault<GClass148>(new Func<GClass148, bool>(class1100.method_0));
      if (gclass148 != null)
        this.dictionary_5.Remove(gclass148.gclass157_0.auroraInstallationType_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.dictionary_5.Add(class1100.gclass157_0.auroraInstallationType_0, new GClass148()
      {
        gclass146_0 = this,
        gclass157_0 = class1100.gclass157_0,
        decimal_0 = decimal_90,
        bool_0 = bool_10,
        bool_1 = bool_11
      });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2127);
    }
  }

  public Decimal method_62(
    AuroraProductionCategory auroraProductionCategory_0)
  {
    try
    {
      Decimal num = 0M;
      switch (auroraProductionCategory_0)
      {
        case AuroraProductionCategory.Construction:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_0 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Ordnance:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_1 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Fighter:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_2 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Refinery:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_3 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Research:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_4 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Terraforming:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_5 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.MaintenanceFacility:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_6 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.MannedMining:
          num = this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.decimal_22 > 0M && !gclass158_0.gclass157_0.bool_4)).Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_7 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.AutomatedMining:
          num = this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.decimal_22 == 0M && !gclass158_0.gclass157_0.bool_4)).Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_7 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.CivilianMining:
          num = this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.bool_4)).Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_7 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Infrastructure:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_8 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Sensors:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_9 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.GroundTraining:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_10 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.Academy:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_11 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.SectorCommand:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_12 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.MassDriver:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_13 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.FinancialProduction:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_14 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.CargoShuttles:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_15 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.GeneticModification:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_16 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.RefuellingPoint:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_17 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.NavalHeadquarters:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_18 * gclass158_0.decimal_0));
          break;
        case AuroraProductionCategory.OrdnanceTransferPoint:
          num = this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_19 * gclass158_0.decimal_0));
          break;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2128);
      return 0M;
    }
  }

  public Decimal method_63(AuroraInstallationType auroraInstallationType_0, Decimal decimal_90)
  {
    try
    {
      AuroraInstallationType installationType2 = this.gclass0_0.dictionary_44[auroraInstallationType_0].auroraInstallationType_2;
      return !this.dictionary_0.ContainsKey(installationType2) ? 0M : (!(this.dictionary_0[installationType2].decimal_0 < decimal_90) ? decimal_90 : (Decimal) (int) this.dictionary_0[installationType2].decimal_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2129);
      return 0M;
    }
  }

  public void method_64(AuroraInstallationType auroraInstallationType_0, Decimal decimal_90)
  {
    try
    {
      if (this.dictionary_0.ContainsKey(auroraInstallationType_0))
      {
        if (decimal_90 == 0M)
          this.dictionary_0.Remove(auroraInstallationType_0);
        else
          this.dictionary_0[auroraInstallationType_0].decimal_0 = decimal_90;
      }
      else
      {
        if (!(decimal_90 > 0M))
          return;
        this.dictionary_0.Add(auroraInstallationType_0, new GClass158()
        {
          gclass157_0 = this.gclass0_0.dictionary_44[auroraInstallationType_0],
          decimal_0 = decimal_90,
          gclass146_0 = this,
          gclass40_0 = (GClass40) null
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2130);
    }
  }

  public void method_65(AuroraInstallationType auroraInstallationType_0, Decimal decimal_90)
  {
    try
    {
      switch (auroraInstallationType_0)
      {
        case AuroraInstallationType.NavalShipyard:
          this.method_150(AuroraShipyardType.Naval);
          break;
        case AuroraInstallationType.CommercialShipyard:
          this.method_150(AuroraShipyardType.Commercial);
          break;
        case AuroraInstallationType.RepairYard:
          this.method_150(AuroraShipyardType.RepairYard);
          break;
        default:
          if (this.gclass0_0.dictionary_44[auroraInstallationType_0].auroraInstallationType_1 > AuroraInstallationType.NoType)
          {
            AuroraInstallationType installationType2 = this.gclass0_0.dictionary_44[auroraInstallationType_0].auroraInstallationType_2;
            AuroraInstallationType installationType1 = this.gclass0_0.dictionary_44[auroraInstallationType_0].auroraInstallationType_1;
            if (this.dictionary_0[installationType2].decimal_0 < decimal_90)
              decimal_90 = (Decimal) (int) this.dictionary_0[installationType2].decimal_0;
            if (decimal_90 == this.dictionary_0[installationType2].decimal_0)
              this.dictionary_0.Remove(installationType2);
            else
              this.dictionary_0[installationType2].decimal_0 -= decimal_90;
            this.method_65(installationType1, decimal_90);
            break;
          }
          if (this.dictionary_0.ContainsKey(auroraInstallationType_0))
          {
            this.dictionary_0[auroraInstallationType_0].decimal_0 += decimal_90;
            if (this.dictionary_0[auroraInstallationType_0].gclass157_0.auroraInstallationType_0 != AuroraInstallationType.SectorCommand || !(this.dictionary_0[auroraInstallationType_0].decimal_0 >= 1M))
              break;
            this.method_66();
            break;
          }
          GClass158 gclass158 = new GClass158();
          gclass158.gclass157_0 = this.gclass0_0.dictionary_44[auroraInstallationType_0];
          gclass158.decimal_0 = decimal_90;
          gclass158.gclass146_0 = this;
          gclass158.gclass40_0 = (GClass40) null;
          this.dictionary_0.Add(auroraInstallationType_0, gclass158);
          if (gclass158.gclass157_0.auroraInstallationType_0 != AuroraInstallationType.SectorCommand || !(gclass158.decimal_0 >= 1M))
            break;
          this.method_66();
          break;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2131);
    }
  }

  public void method_66()
  {
    try
    {
      if (this.gclass21_0.dictionary_2.Values.FirstOrDefault<GClass62>((Func<GClass62, bool>) (gclass62_0 => gclass62_0.gclass146_0 == this)) != null)
        return;
      GClass62 gclass62 = new GClass62(this.gclass0_0);
      gclass62.int_0 = this.gclass0_0.method_26(GEnum0.const_30);
      gclass62.gclass146_0 = this;
      gclass62.gclass21_0 = this.gclass21_0;
      gclass62.SectorName = this.gclass202_0.Name + " Sector";
      gclass62.color_0 = Color.Red;
      this.gclass21_0.dictionary_2.Add(gclass62.int_0, gclass62);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2132);
    }
  }

  public void method_67(GClass230 gclass230_0, Decimal decimal_90)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1101 class1101 = new GClass146.Class1101();
    // ISSUE: reference to a compiler-generated field
    class1101.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass73 gclass73 = this.list_2.FirstOrDefault<GClass73>(new Func<GClass73, bool>(class1101.method_0));
      if (gclass73 != null)
      {
        gclass73.decimal_0 += decimal_90;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.list_2.Add(new GClass73()
        {
          gclass230_0 = class1101.gclass230_0,
          int_0 = class1101.gclass230_0.int_0,
          decimal_0 = decimal_90
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2133);
    }
  }

  public void method_68(AuroraInstallationType auroraInstallationType_0, Decimal decimal_90)
  {
    try
    {
      if (!this.dictionary_0.ContainsKey(auroraInstallationType_0))
        return;
      if (decimal_90 == this.dictionary_0[auroraInstallationType_0].decimal_0)
        this.dictionary_0.Remove(auroraInstallationType_0);
      else
        this.dictionary_0[auroraInstallationType_0].decimal_0 -= decimal_90;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2134);
    }
  }

  public void method_69(GClass230 gclass230_0, Decimal decimal_90)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1102 class1102 = new GClass146.Class1102();
    // ISSUE: reference to a compiler-generated field
    class1102.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass73 gclass73 = this.list_2.FirstOrDefault<GClass73>(new Func<GClass73, bool>(class1102.method_0));
      if (gclass73 == null)
        return;
      if (decimal_90 >= gclass73.decimal_0)
        this.list_2.Remove(gclass73);
      else
        gclass73.decimal_0 -= decimal_90;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2135);
    }
  }

  public void method_70(ListView listView_0)
  {
    try
    {
      foreach (GClass73 gclass73 in this.list_2.OrderBy<GClass73, string>((Func<GClass73, string>) (gclass73_0 => gclass73_0.gclass230_0.Name)).ToList<GClass73>())
        this.gclass0_0.method_598(listView_0, gclass73.gclass230_0.Name, GClass226.smethod_38(gclass73.decimal_0), (object) gclass73.gclass230_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2136);
    }
  }

  public void method_71(ListView listView_0)
  {
    try
    {
      foreach (GClass55 object_1 in this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass146_0 == this)).OrderBy<GClass55, AuroraCommanderType>((Func<GClass55, AuroraCommanderType>) (gclass55_0 => gclass55_0.auroraCommanderType_0)).ThenBy<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.gclass61_0.int_1)).ThenBy<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.int_4)).ThenBy<GClass55, string>((Func<GClass55, string>) (gclass55_0 => gclass55_0.string_0)).ToList<GClass55>())
        this.gclass0_0.method_598(listView_0, object_1.method_38(), "", (object) object_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2137);
    }
  }

  public void method_72(ListView listView_0, bool bool_10)
  {
    try
    {
      List<GClass158> list = this.dictionary_0.Values.OrderBy<GClass158, Decimal>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_20)).ToList<GClass158>();
      if (bool_10)
      {
        foreach (GClass158 gclass158 in list)
          this.gclass0_0.method_598(listView_0, $"{gclass158.gclass157_0.Name} ({GClass226.smethod_44((double) gclass158.gclass157_0.int_1 / 25000.0, 2)})", GClass226.smethod_42(gclass158.decimal_0, 4).ToString(), (object) gclass158.gclass157_0);
      }
      else
      {
        foreach (GClass158 gclass158 in list)
          this.gclass0_0.method_598(listView_0, gclass158.gclass157_0.Name, GClass226.smethod_42(gclass158.decimal_0, 4).ToString(), (object) gclass158.gclass157_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2138);
    }
  }

  public int method_73(AuroraInstallationType auroraInstallationType_0)
  {
    try
    {
      return this.dictionary_0.ContainsKey(auroraInstallationType_0) ? (int) Math.Floor(this.dictionary_0[auroraInstallationType_0].decimal_0) : 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2139);
      return 0;
    }
  }

  public int method_74()
  {
    try
    {
      return (int) this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.int_0 > 2)).Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.decimal_0 * (Decimal) gclass158_0.gclass157_0.int_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2140);
      return 0;
    }
  }

  public Decimal method_75(AuroraInstallationType auroraInstallationType_0)
  {
    try
    {
      return this.dictionary_0.ContainsKey(auroraInstallationType_0) ? this.dictionary_0[auroraInstallationType_0].decimal_0 : 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2141);
      return 0M;
    }
  }

  public Decimal method_76(int int_25)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1103 class1103 = new GClass146.Class1103();
    // ISSUE: reference to a compiler-generated field
    class1103.int_0 = int_25;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.list_2.Where<GClass73>(new Func<GClass73, bool>(class1103.method_0)).Sum<GClass73>((Func<GClass73, Decimal>) (gclass73_0 => gclass73_0.decimal_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2142);
      return 0M;
    }
  }

  public Decimal method_77()
  {
    try
    {
      return this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_23 * gclass158_0.decimal_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2143);
      return 0M;
    }
  }

  public Decimal method_78()
  {
    try
    {
      return this.dictionary_0.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_24 * gclass158_0.decimal_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2144);
      return 0M;
    }
  }

  public bool method_79(GClass21 gclass21_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1104 class1104 = new GClass146.Class1104();
    // ISSUE: reference to a compiler-generated field
    class1104.gclass21_0 = gclass21_2;
    // ISSUE: reference to a compiler-generated field
    class1104.gclass146_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class1104.method_0)).ToList<GClass65>().Count > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2145);
      return false;
    }
  }

  public string method_80(GClass21 gclass21_2)
  {
    try
    {
      this.int_18 = 0;
      GClass113 gclass113 = gclass21_2.dictionary_13.Values.FirstOrDefault<GClass113>((Func<GClass113, bool>) (gclass113_0 => gclass113_0.gclass146_0 == this));
      string str;
      if (gclass113 != null)
      {
        str = gclass113.string_0;
        if (gclass113.double_0 < 100.0)
        {
          GClass65 gclass65_1 = this.gclass0_0.method_556(gclass21_2, GEnum10.const_1, AuroraContactType.Population, this.int_6, 0);
          if (gclass65_1 != null)
          {
            if (gclass65_1.decimal_0 > 0M)
              str = $"{str}   Thermal {GClass226.smethod_38(gclass65_1.decimal_0)}";
            if (this.int_18 == 0)
              this.int_18 = gclass65_1.int_0;
          }
          GClass65 gclass65_2 = this.gclass0_0.method_556(gclass21_2, GEnum10.const_3, AuroraContactType.Population, this.int_6, 0);
          if (gclass65_2 != null)
          {
            if (gclass65_2.decimal_0 > 0M)
              str = $"{str}   EM {GClass226.smethod_38(gclass65_2.decimal_0)}";
            if (this.int_18 == 0)
              this.int_18 = gclass65_2.int_0;
          }
        }
        else
          str = $"{str}  {GClass226.smethod_47(gclass113.decimal_1)}m   INST {gclass113.int_0.ToString()}";
        if (gclass113.double_0 > 1.0)
          str = $"{str}   IP {((int) Math.Floor(gclass113.double_0)).ToString()}";
      }
      else
        str = "";
      this.string_2 = str;
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2146);
      return "error";
    }
  }

  public bool method_81(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_1,
    int int_25)
  {
    try
    {
      AuroraContactStatus auroraContactStatus0 = gclass202_1.gclass21_0.dictionary_10[this.gclass21_0.RaceID].auroraContactStatus_0;
      if (!gclass202_1.gclass21_0.method_319(auroraContactStatus0))
        return false;
      string str = this.method_80(gclass202_1.gclass21_0);
      string string0 = gclass202_1.gclass21_0.dictionary_10[this.gclass21_0.RaceID].string_0;
      SolidBrush solidBrush = new SolidBrush(GClass226.color_6);
      Pen pen = new Pen(GClass226.color_6);
      solidBrush.Color = GClass226.smethod_81(auroraContactStatus0);
      Color color = solidBrush.Color;
      pen.Color = color;
      double x = gclass222_0.double_2 - (double) (GClass226.int_61 / 2);
      double y = gclass222_0.double_3 - (double) (GClass226.int_61 / 2);
      if (int_25 == 0)
        graphics_0.FillEllipse((Brush) solidBrush, (float) x, (float) y, (float) GClass226.int_61, (float) GClass226.int_61);
      if (gclass202_1.gclass21_0.chkShowDist == CheckState.Checked && (gclass202_1.gclass221_0.double_0 != 0.0 || gclass202_1.gclass221_0.double_1 != 0.0))
      {
        double num = this.gclass0_0.method_28(gclass202_1.gclass221_0.double_0, gclass202_1.gclass221_0.double_1, gclass222_0.double_0, gclass222_0.double_1);
        str = $"{str}  {GClass226.smethod_50(num / 1000000.0)}m";
      }
      GClass221 gclass221 = new GClass221();
      gclass221.double_0 = x + (double) GClass226.int_61 + 5.0;
      gclass221.double_1 = y - 3.0 - (double) (int_25 * 15);
      graphics_0.DrawString($"[{string0}]  {str}", font_0, (Brush) solidBrush, (float) gclass221.double_0, (float) gclass221.double_1);
      this.string_2 = str;
      gclass202_1.list_2.Add(this);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2147);
      return false;
    }
  }

  public GClass55 method_82()
  {
    try
    {
      return this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass146_3 == this)).FirstOrDefault<GClass55>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2149);
      return (GClass55) null;
    }
  }

  public GClass55 method_83()
  {
    try
    {
      return this.gclass202_0.gclass62_0 == null ? (GClass55) null : this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass62_0 == this.gclass202_0.gclass62_0)).FirstOrDefault<GClass55>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2150);
      return (GClass55) null;
    }
  }

  public List<GClass103> method_84()
  {
    try
    {
      return this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 == this)).ToList<GClass103>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2151);
      return (List<GClass103>) null;
    }
  }

  public List<GClass193> method_85()
  {
    try
    {
      return this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass146_0 == this)).ToList<GClass193>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2152);
      return (List<GClass193>) null;
    }
  }

  public int method_86()
  {
    try
    {
      return this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass146_0 == this)).Count<GClass193>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2153);
      return 0;
    }
  }

  public double method_87()
  {
    try
    {
      return this.gclass1_0 != null ? this.gclass1_0.double_0 : 0.0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2154);
      return 0.0;
    }
  }

  public double method_88()
  {
    try
    {
      return this.gclass1_0 != null ? this.gclass1_0.double_1 : 0.0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2155);
      return 0.0;
    }
  }

  public void method_89()
  {
    try
    {
      this.decimal_63 = 1M;
      if (this.gclass55_0 != null)
        this.decimal_63 *= this.gclass55_0.method_5(GEnum121.const_4);
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
        this.decimal_63 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_4);
      this.decimal_63 = this.decimal_63 * this.gclass194_0.decimal_3 * this.gclass21_0.EconomicProdModifier * this.decimal_5 * this.decimal_31 * this.decimal_33 * this.gclass160_0.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2156);
    }
  }

  public void method_90()
  {
    try
    {
      this.decimal_65 = 1M;
      if (this.gclass55_0 != null)
        this.decimal_65 *= this.gclass55_0.method_5(GEnum121.const_3);
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
        this.decimal_65 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_3);
      this.decimal_65 = this.decimal_65 * this.gclass194_0.decimal_3 * this.gclass21_0.decimal_11 * this.gclass21_0.EconomicProdModifier * this.decimal_5 * this.decimal_31 * this.decimal_33 * this.gclass160_0.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2157);
    }
  }

  public void method_91()
  {
    try
    {
      this.decimal_67 = (Decimal) (this.gclass21_0.int_10 * this.method_73(AuroraInstallationType.GFCC));
      if (this.gclass55_0 != null)
        this.decimal_67 *= this.gclass55_0.method_5(GEnum121.const_10);
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
        this.decimal_67 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_10);
      this.decimal_67 = this.decimal_67 * this.gclass194_0.decimal_3 * this.gclass21_0.EconomicProdModifier * this.decimal_31 * this.decimal_5 * this.decimal_33 * this.gclass160_0.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2158);
    }
  }

  public void method_92()
  {
    try
    {
      this.decimal_64 = 1M * this.gclass21_0.EconomicProdModifier * this.decimal_31;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2159);
    }
  }

  public void method_93()
  {
    try
    {
      int num1 = (int) this.method_62(AuroraProductionCategory.Construction);
      int num2 = (int) this.method_62(AuroraProductionCategory.Ordnance);
      int num3 = (int) this.method_62(AuroraProductionCategory.Fighter);
      int num4 = (int) this.method_62(AuroraProductionCategory.Refinery);
      int num5 = (int) this.method_62(AuroraProductionCategory.MaintenanceFacility);
      this.decimal_58 = this.gclass21_0.decimal_13 * this.decimal_63 * (Decimal) num1 + this.gclass21_0.decimal_13 * this.decimal_64 * this.decimal_71;
      this.decimal_59 = this.gclass21_0.decimal_14 * this.decimal_63 * (Decimal) num2;
      this.decimal_60 = this.gclass21_0.decimal_15 * this.decimal_63 * (Decimal) num3;
      this.decimal_61 = this.gclass21_0.decimal_12 * this.decimal_63 * (Decimal) num4;
      this.decimal_62 = (Decimal) this.gclass21_0.int_33 * this.decimal_63 * (Decimal) num5 * GClass226.decimal_43;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2160);
    }
  }

  public void method_94(bool bool_10)
  {
    try
    {
      if (this.gclass146_0 == null && bool_10)
        this.decimal_69 = 0M;
      else
        this.decimal_69 = (Decimal) (this.method_73(AuroraInstallationType.MassDriver) * GClass226.int_25);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2161);
    }
  }

  public void method_95()
  {
    try
    {
      this.decimal_68 = this.gclass21_0.decimal_24 * (Decimal) (int) this.method_62(AuroraProductionCategory.GeneticModification) * this.decimal_63;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2162);
    }
  }

  public void method_96()
  {
    try
    {
      this.decimal_20 = 1M;
      this.decimal_21 = 1M;
      if (this.gclass55_0 != null)
      {
        this.decimal_20 *= this.gclass55_0.method_5(GEnum121.const_5);
        this.decimal_21 *= this.gclass55_0.method_5(GEnum121.const_5);
      }
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
      {
        this.decimal_20 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_5);
        this.decimal_21 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_5);
      }
      this.decimal_20 = this.decimal_20 * this.decimal_5 * this.decimal_31 * this.decimal_33 * this.gclass160_0.decimal_0;
      this.decimal_21 *= this.decimal_31;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2163);
    }
  }

  public void method_97()
  {
    try
    {
      this.decimal_25 = 1M;
      if (this.gclass55_0 != null)
        this.decimal_25 *= this.gclass55_0.method_5(GEnum121.const_8);
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
        this.decimal_25 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_8);
      this.decimal_25 = this.decimal_25 * this.decimal_5 * this.decimal_31 * this.decimal_33 * this.gclass160_0.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2164);
    }
  }

  public void method_98()
  {
    try
    {
      this.decimal_26 = this.gclass194_0.decimal_2 * (Decimal) this.gclass21_0.int_28 * this.gclass21_0.EconomicProdModifier * this.decimal_5 * this.decimal_31 * this.decimal_33 * this.gclass160_0.decimal_0 * (Decimal) ((double) this.gclass0_0.int_106 / 100.0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2165);
    }
  }

  public void method_99()
  {
    try
    {
      int num1 = (int) this.method_62(AuroraProductionCategory.MannedMining);
      int num2 = (int) this.method_62(AuroraProductionCategory.AutomatedMining);
      int num3 = (int) this.method_62(AuroraProductionCategory.CivilianMining);
      Decimal num4 = this.gclass21_0.decimal_17 * this.decimal_20 * (Decimal) num1;
      Decimal num5 = this.gclass21_0.decimal_17 * this.decimal_21 * (Decimal) (num2 + num3);
      Decimal num6 = 0M;
      if (this.gclass1_0.double_20 * 2.0 <= (double) this.gclass21_0.int_11)
        num6 = this.method_203(AuroraComponentType.OrbitalMiningModule, GEnum121.const_5);
      this.decimal_23 = this.gclass21_0.decimal_17 * this.decimal_21 * (Decimal) num3;
      this.decimal_22 = num4 + num5 + num6;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2166);
    }
  }

  public void method_100()
  {
    try
    {
      this.decimal_24 = (this.gclass21_0.decimal_18 * this.decimal_25 * (Decimal) (int) this.method_62(AuroraProductionCategory.Terraforming) + this.method_203(AuroraComponentType.TerraformingModule, GEnum121.const_8)) * (Decimal) ((double) this.gclass0_0.int_107 / 100.0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2167);
    }
  }

  public void method_101()
  {
    try
    {
      this.decimal_75 = 0M;
      this.decimal_76 = 0M;
      List<GClass40> list1 = this.gclass0_0.dictionary_32.Values.Where<GClass192>((Func<GClass192, bool>) (gclass192_0 => gclass192_0.gclass193_0.gclass146_0 == this && gclass192_0.gclass40_0 != null)).Select<GClass192, GClass40>((Func<GClass192, GClass40>) (gclass192_0 => gclass192_0.gclass40_0)).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.method_84())).ToList<GClass40>();
      List<GClass40> list2 = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass85_0.gclass202_0 == this.gclass202_0)).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.method_84())).Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass85_0.double_2 == this.method_87() && gclass40_0.gclass85_0.double_3 == this.method_88())).Except<GClass40>((IEnumerable<GClass40>) list1).ToList<GClass40>();
      if (list2.Count > 0)
        this.decimal_75 = list2.Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14 * GClass226.decimal_17));
      if (list1.Count <= 0)
        return;
      this.decimal_76 = list1.Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14 * GClass226.decimal_17));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2168);
    }
  }

  public void method_102(
    ListView listView_0,
    Label label_0,
    bool bool_10,
    ComboBox comboBox_0,
    CheckBox checkBox_0,
    bool bool_11)
  {
    try
    {
      GClass162 gclass162_1 = (GClass162) null;
      Decimal num1 = 1M;
      Decimal num2 = 0M;
      GClass162 gclass162_2 = (GClass162) null;
      if (checkBox_0.CheckState == CheckState.Checked)
        gclass162_2 = (GClass162) comboBox_0.SelectedValue;
      this.gclass21_0.method_338();
      List<GClass161> gclass161List = new List<GClass161>();
      List<GClass161> source = !bool_11 ? this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass21_0 == this.gclass21_0 && gclass146_1.dictionary_1.Count > 0)).SelectMany<GClass146, GClass161>((Func<GClass146, IEnumerable<GClass161>>) (gclass146_0 => (IEnumerable<GClass161>) gclass146_0.dictionary_1.Values)).OrderByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.int_0)).ThenByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.gclass164_0.int_4)).ToList<GClass161>() : this.dictionary_1.Values.OrderByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.int_0)).ThenByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.gclass164_0.int_4)).ToList<GClass161>();
      listView_0.Items.Clear();
      this.gclass0_0.method_617(listView_0, "Field", "Research Project", "Project Leader", "Bonus", "Bonus Mod", "Labs", "Annual RP", "RP Remaining", "Completion Date", "Pause", (object) null);
      this.gclass0_0.method_597(listView_0, "", "");
      if (this.gclass1_0.gclass220_0 != null && this.gclass1_0.gclass220_0.bool_0)
      {
        num1 = this.gclass1_0.gclass220_0.decimal_0;
        gclass162_1 = this.gclass1_0.gclass220_0.gclass162_0;
      }
      foreach (GClass161 gclass161 in source)
      {
        if (gclass161.gclass55_0 != null)
        {
          gclass161.decimal_3 = 1M;
          num2 += (Decimal) gclass161.int_0;
          gclass161.decimal_3 = gclass161.gclass162_0 != gclass161.gclass55_0.gclass162_0 ? gclass161.gclass55_0.method_5(GEnum121.const_2) : gclass161.gclass55_0.method_5(GEnum121.const_2) * 4M - 3M;
          if (gclass161.gclass146_0 == this)
          {
            if (gclass161.gclass162_0 == gclass162_1)
              gclass161.decimal_3 *= num1;
          }
          else if (gclass161.gclass146_0.gclass1_0.gclass220_0 != null && gclass161.gclass146_0.gclass1_0.gclass220_0.bool_0)
          {
            Decimal decimal0 = gclass161.gclass146_0.gclass1_0.gclass220_0.decimal_0;
            GClass162 gclass1620 = gclass161.gclass146_0.gclass1_0.gclass220_0.gclass162_0;
            if (gclass161.gclass162_0 == gclass1620)
              gclass161.decimal_3 *= decimal0;
          }
          gclass161.decimal_3 *= this.gclass21_0.dictionary_5[gclass161.gclass162_0.ResearchFieldID];
          gclass161.decimal_2 = this.decimal_26 * (Decimal) gclass161.int_0 * gclass161.decimal_3;
          gclass161.decimal_1 = !(gclass161.decimal_2 == 0M) ? gclass161.decimal_0 / gclass161.decimal_2 * GClass226.decimal_29 : GClass226.decimal_29 * 1000M;
          gclass161.string_0 = "No";
          if (gclass161.bool_0)
            gclass161.string_0 = "Yes";
        }
      }
      if (!bool_10)
        source = source.OrderBy<GClass161, Decimal>((Func<GClass161, Decimal>) (gclass161_0 => gclass161_0.decimal_1)).ThenByDescending<GClass161, int>((Func<GClass161, int>) (gclass161_0 => gclass161_0.gclass164_0.int_4)).ToList<GClass161>();
      foreach (GClass161 object_1 in source)
      {
        string string_11 = object_1.gclass164_0.Name;
        if (object_1.bool_1)
          string_11 = "(N) " + string_11;
        if (object_1.gclass146_0 != this)
          string_11 = "(E) " + string_11;
        string string_12 = object_1.gclass55_0.string_0;
        if (object_1.gclass146_0 != this)
          string_12 = object_1.gclass146_0.PopName;
        Color color_0 = GClass226.color_13;
        if (gclass162_2 == null || gclass162_2 != object_1.gclass162_0)
          color_0 = GClass226.color_3;
        this.gclass0_0.method_618(listView_0, object_1.gclass162_0.Abbreviation, string_11, string_12, $"{object_1.gclass55_0.gclass162_0.Abbreviation} {GClass226.smethod_39((object_1.gclass55_0.method_5(GEnum121.const_2) - 1M) * 100M)}%", GClass226.smethod_42(object_1.decimal_3, 3) + "x", $"{object_1.int_0.ToString()} / {object_1.gclass55_0.method_5(GEnum121.const_23).ToString()}", GClass226.smethod_39(object_1.decimal_2), GClass226.smethod_39(object_1.decimal_0), this.gclass0_0.method_584(this.gclass0_0.decimal_0 + object_1.decimal_1), object_1.string_0, color_0, (object) object_1);
      }
      int num3 = (int) this.method_62(AuroraProductionCategory.Research);
      this.int_16 = (int) ((Decimal) num3 - num2);
      label_0.Text = GClass226.smethod_38((Decimal) num3 - num2);
      List<GClass166> list = this.gclass21_0.list_5.Where<GClass166>((Func<GClass166, bool>) (gclass166_0 => gclass166_0.gclass146_0 == this)).OrderByDescending<GClass166, int>((Func<GClass166, int>) (gclass166_0 => gclass166_0.gclass161_0.int_0)).ThenBy<GClass166, int>((Func<GClass166, int>) (gclass166_0 => gclass166_0.int_0)).ToList<GClass166>();
      if (list.Count <= 0)
        return;
      this.gclass0_0.method_597(listView_0, "", "");
      this.gclass0_0.method_597(listView_0, "", "Research Queue");
      foreach (GClass166 gclass166 in list)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1105 class1105 = new GClass146.Class1105();
        // ISSUE: reference to a compiler-generated field
        class1105.gclass166_0 = gclass166;
        // ISSUE: reference to a compiler-generated field
        GClass55 gclass550 = class1105.gclass166_0.gclass161_0.gclass55_0;
        if (gclass550 == null)
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass21_0.list_5.Remove(class1105.gclass166_0);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Decimal decimal_73_1 = (Decimal) class1105.gclass166_0.gclass164_0.int_4;
          // ISSUE: reference to a compiler-generated field
          GClass226.smethod_37(class1105.gclass166_0.gclass164_0.int_4);
          // ISSUE: reference to a compiler-generated method
          GClass167 gclass167 = this.gclass21_0.list_6.Where<GClass167>(new Func<GClass167, bool>(class1105.method_0)).FirstOrDefault<GClass167>();
          if (gclass167 != null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string str = $"{GClass226.smethod_37(class1105.gclass166_0.gclass164_0.int_4 - gclass167.int_0)} / {GClass226.smethod_37(class1105.gclass166_0.gclass164_0.int_4)}";
            // ISSUE: reference to a compiler-generated field
            decimal_73_1 = (Decimal) (class1105.gclass166_0.gclass164_0.int_4 - gclass167.int_0);
          }
          // ISSUE: reference to a compiler-generated field
          Decimal num4 = class1105.gclass166_0.gclass164_0.gclass163_0.gclass162_0 != gclass550.gclass162_0 ? gclass550.method_5(GEnum121.const_2) : gclass550.method_5(GEnum121.const_2) * 4M - 3M;
          // ISSUE: reference to a compiler-generated field
          if (class1105.gclass166_0.gclass164_0.gclass163_0.gclass162_0 == gclass162_1)
            num4 *= num1;
          // ISSUE: reference to a compiler-generated field
          Decimal decimal_73_2 = num4 * this.gclass21_0.dictionary_5[class1105.gclass166_0.gclass164_0.gclass163_0.gclass162_0.ResearchFieldID];
          // ISSUE: reference to a compiler-generated field
          Decimal decimal_73_3 = this.decimal_26 * (Decimal) class1105.gclass166_0.gclass161_0.int_0 * decimal_73_2;
          Decimal decimal_73_4 = 0M;
          decimal_73_4 = !(decimal_73_3 == 0M) ? decimal_73_1 / decimal_73_3 : 1000M;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_617(listView_0, class1105.gclass166_0.gclass164_0.gclass163_0.gclass162_0.Abbreviation, class1105.gclass166_0.gclass164_0.Name, gclass550.string_0, $"{gclass550.gclass162_0.Abbreviation} {GClass226.smethod_39((gclass550.method_5(GEnum121.const_2) - 1M) * 100M)}%", GClass226.smethod_42(decimal_73_2, 2) + "x", $"{class1105.gclass166_0.gclass161_0.int_0.ToString()} / {gclass550.method_5(GEnum121.const_23).ToString()}", GClass226.smethod_39(decimal_73_3), GClass226.smethod_39(decimal_73_1), GClass226.smethod_42(decimal_73_4, 2) + " years", class1105.gclass166_0.int_0.ToString(), (object) class1105.gclass166_0);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2169);
    }
  }

  public void method_103(GClass161 gclass161_0, GClass164 gclass164_0)
  {
    try
    {
      this.gclass21_0.list_5.Add(new GClass166()
      {
        int_0 = 1000,
        gclass146_0 = this,
        gclass164_0 = gclass164_0,
        gclass161_0 = gclass161_0
      });
      this.method_105(gclass161_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2170);
    }
  }

  public GClass161 method_104(
    GClass164 gclass164_0,
    GClass55 gclass55_1,
    int int_25,
    Decimal decimal_90)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1106 class1106 = new GClass146.Class1106();
    // ISSUE: reference to a compiler-generated field
    class1106.gclass164_0 = gclass164_0;
    try
    {
      GClass161 gclass161 = new GClass161(this.gclass0_0);
      // ISSUE: reference to a compiler-generated field
      int int4 = class1106.gclass164_0.int_4;
      // ISSUE: reference to a compiler-generated method
      GClass167 gclass167 = this.gclass21_0.list_6.Where<GClass167>(new Func<GClass167, bool>(class1106.method_0)).FirstOrDefault<GClass167>();
      if (gclass167 != null)
      {
        int4 -= gclass167.int_0;
        this.gclass21_0.list_6.Remove(gclass167);
      }
      this.gclass0_0.dictionary_22.Values.SelectMany<GClass146, GClass161>((Func<GClass146, IEnumerable<GClass161>>) (gclass146_0 => (IEnumerable<GClass161>) gclass146_0.dictionary_1.Values)).ToList<GClass161>();
      int key = this.gclass0_0.method_26(GEnum0.const_31);
      gclass161.int_0 = int_25;
      gclass161.bool_0 = false;
      gclass161.int_1 = key;
      gclass161.gclass146_0 = this;
      gclass161.gclass21_0 = this.gclass21_0;
      // ISSUE: reference to a compiler-generated field
      gclass161.gclass162_0 = class1106.gclass164_0.gclass163_0.gclass162_0;
      // ISSUE: reference to a compiler-generated field
      gclass161.gclass164_0 = class1106.gclass164_0;
      gclass161.decimal_0 = (Decimal) int4 - decimal_90;
      gclass55_1.gclass161_0 = gclass161;
      gclass55_1.auroraCommandType_0 = AuroraCommandType.ResearchProject;
      gclass55_1.gclass146_0 = this;
      gclass55_1.gclass40_0 = (GClass40) null;
      gclass161.gclass55_0 = gclass55_1;
      this.dictionary_1.Add(key, gclass161);
      return gclass161;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2171);
      return (GClass161) null;
    }
  }

  public void method_105(GClass161 gclass161_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1107 class1107 = new GClass146.Class1107();
    // ISSUE: reference to a compiler-generated field
    class1107.gclass161_0 = gclass161_0;
    try
    {
      int num = 1;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass166 gclass166 in this.gclass21_0.list_5.Where<GClass166>(new Func<GClass166, bool>(class1107.method_0)).OrderBy<GClass166, int>((Func<GClass166, int>) (gclass166_0 => gclass166_0.int_0)).ToList<GClass166>())
      {
        gclass166.int_0 = num;
        ++num;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2172);
    }
  }

  public void method_106(GClass166 gclass166_0_1, bool bool_10)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1108 class1108 = new GClass146.Class1108();
    // ISSUE: reference to a compiler-generated field
    class1108.gclass166_0 = gclass166_0_1;
    try
    {
      int num1 = 1;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass166 gclass166 in this.gclass21_0.list_5.Where<GClass166>(new Func<GClass166, bool>(class1108.method_0)).OrderBy<GClass166, int>((Func<GClass166, int>) (gclass166_0_2 => gclass166_0_2.int_0)).ToList<GClass166>())
      {
        gclass166.int_0 = num1 * 10;
        // ISSUE: reference to a compiler-generated field
        if (gclass166 == class1108.gclass166_0)
        {
          if (bool_10)
            gclass166.int_0 -= 15;
          else
            gclass166.int_0 += 15;
        }
        ++num1;
      }
      // ISSUE: reference to a compiler-generated method
      List<GClass166> list = this.gclass21_0.list_5.Where<GClass166>(new Func<GClass166, bool>(class1108.method_1)).OrderBy<GClass166, int>((Func<GClass166, int>) (gclass166_0_3 => gclass166_0_3.int_0)).ToList<GClass166>();
      int num2 = 1;
      foreach (GClass166 gclass166 in list)
      {
        gclass166.int_0 = num2;
        ++num2;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2173);
    }
  }

  public void method_107(ListView listView_0, GClass162 gclass162_0, CheckState checkState_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1109 class1109 = new GClass146.Class1109();
    // ISSUE: reference to a compiler-generated field
    class1109.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1109.gclass162_0 = gclass162_0;
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_603(listView_0, "Scientist", "Specialization", "Bonus", "Max Labs");
      this.gclass0_0.method_597(listView_0, "", "");
      // ISSUE: reference to a compiler-generated method
      foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values.Where<GClass55>(new Func<GClass55, bool>(class1109.method_0)).ToList<GClass55>())
      {
        if (gclass55.auroraCommandType_0 == AuroraCommandType.ResearchProject && gclass55.gclass161_0 == null)
          gclass55.method_40(false);
      }
      // ISSUE: reference to a compiler-generated method
      List<GClass55> list = this.gclass0_0.dictionary_42.Values.Where<GClass55>(new Func<GClass55, bool>(class1109.method_1)).OrderByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_0 => gclass55_0.method_5(GEnum121.const_2))).ThenByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_0 => gclass55_0.method_5(GEnum121.const_23))).ToList<GClass55>();
      if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        list = list.Where<GClass55>(new Func<GClass55, bool>(class1109.method_2)).OrderByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_0 => gclass55_0.method_5(GEnum121.const_2))).ThenByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_0 => gclass55_0.method_5(GEnum121.const_23))).ToList<GClass55>();
      }
      foreach (GClass55 object_1 in list)
        this.gclass0_0.method_604(listView_0, object_1.string_0, object_1.gclass162_0.FieldName, GClass226.smethod_39((object_1.method_5(GEnum121.const_2) - 1M) * 100M) + "%", GClass226.smethod_39(object_1.method_5(GEnum121.const_23)), (object) object_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2174);
    }
  }

  public void method_108(ListView listView_0, GClass162 gclass162_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1110 class1110 = new GClass146.Class1110();
    // ISSUE: reference to a compiler-generated field
    class1110.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1110.gclass162_0 = gclass162_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass146.Class1111 class1111 = new GClass146.Class1111();
      // ISSUE: reference to a compiler-generated field
      class1111.class1110_0 = class1110;
      listView_0.Items.Clear();
      this.gclass0_0.method_597(listView_0, "Technology", "Research Cost");
      this.gclass0_0.method_597(listView_0, "", "");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class1111.list_0 = this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1111.class1110_0.method_0)).ToList<GClass164>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class1111.list_1 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1111.class1110_0.method_1)).SelectMany<GClass146, GClass164>((Func<GClass146, IEnumerable<GClass164>>) (gclass146_0 => gclass146_0.dictionary_1.Values.Select<GClass161, GClass164>((Func<GClass161, GClass164>) (gclass161_0 => gclass161_0.gclass164_0)))).ToList<GClass164>();
      // ISSUE: reference to a compiler-generated field
      class1111.list_2 = this.gclass21_0.list_5.Select<GClass166, GClass164>((Func<GClass166, GClass164>) (gclass166_0 => gclass166_0.gclass164_0)).ToList<GClass164>();
      // ISSUE: reference to a compiler-generated method
      List<GClass164> list1 = this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1111.method_0)).ToList<GClass164>();
      // ISSUE: reference to a compiler-generated method
      List<GClass164> list2 = this.gclass0_0.dictionary_54.Values.Where<GClass230>((Func<GClass230, bool>) (gclass230_0 => gclass230_0.genum86_0 == GEnum86.const_3)).Select<GClass230, GClass164>((Func<GClass230, GClass164>) (gclass230_0 => gclass230_0.gclass164_0)).Where<GClass164>(new Func<GClass164, bool>(class1111.method_1)).ToList<GClass164>();
      if (list2.Count > 0)
        list1.AddRange((IEnumerable<GClass164>) list2);
      foreach (GClass164 gclass164 in list1.OrderBy<GClass164, string>((Func<GClass164, string>) (gclass164_0 => gclass164_0.Name)).ToList<GClass164>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1112 class1112 = new GClass146.Class1112();
        // ISSUE: reference to a compiler-generated field
        class1112.gclass164_0 = gclass164;
        // ISSUE: reference to a compiler-generated field
        string name = class1112.gclass164_0.Name;
        // ISSUE: reference to a compiler-generated method
        GClass167 gclass167 = this.gclass21_0.list_6.Where<GClass167>(new Func<GClass167, bool>(class1112.method_0)).FirstOrDefault<GClass167>();
        // ISSUE: reference to a compiler-generated method
        GClass230 gclass230 = this.gclass0_0.dictionary_54.Values.FirstOrDefault<GClass230>(new Func<GClass230, bool>(class1112.method_1));
        if (gclass230 != null && gclass230.genum86_0 == GEnum86.const_3)
          name += " (P)";
        if (gclass167 != null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_598(listView_0, name, $"{GClass226.smethod_37(class1112.gclass164_0.int_4 - gclass167.int_0)} / {GClass226.smethod_37(class1112.gclass164_0.int_4)}", (object) class1112.gclass164_0);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_598(listView_0, name, GClass226.smethod_37(class1112.gclass164_0.int_4), (object) class1112.gclass164_0);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2175);
    }
  }

  public void method_109(ListView listView_0, GClass162 gclass162_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1113 class1113 = new GClass146.Class1113();
    // ISSUE: reference to a compiler-generated field
    class1113.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1113.gclass162_0 = gclass162_0;
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_597(listView_0, "Technology", "Research Cost");
      this.gclass0_0.method_597(listView_0, "", "");
      // ISSUE: reference to a compiler-generated method
      foreach (GClass164 object_1 in this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1113.method_0)).ToList<GClass164>())
        this.gclass0_0.method_598(listView_0, object_1.Name, GClass226.smethod_37(object_1.int_4), (object) object_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2175);
    }
  }

  public void method_110(
    ListView listView_0,
    ListView listView_1,
    TextBox textBox_0,
    TextBox textBox_1,
    TextBox textBox_2,
    TextBox textBox_3,
    Decimal decimal_90)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1114 class1114 = new GClass146.Class1114();
    // ISSUE: reference to a compiler-generated field
    class1114.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1114.decimal_0 = decimal_90;
    try
    {
      List<GClass152> source1 = new List<GClass152>();
      List<GClass152> source2 = new List<GClass152>();
      listView_0.Items.Clear();
      listView_1.Items.Clear();
      textBox_0.Text = GClass226.smethod_39(this.gclass21_0.decimal_3);
      textBox_1.Text = GClass226.smethod_42(this.gclass21_0.decimal_20, 2);
      textBox_2.Text = GClass226.smethod_42(this.decimal_66, 2);
      textBox_3.Text = GClass226.smethod_42(this.gclass21_0.decimal_5 * 100M, 2) + "%";
      List<GClass150> list1 = this.gclass21_0.list_3.Select<GClass151, GClass150>((Func<GClass151, GClass150>) (gclass151_0 => gclass151_0.gclass150_0)).Distinct<GClass150>().ToList<GClass150>();
      // ISSUE: reference to a compiler-generated method
      Decimal decimal_73_1 = this.gclass21_0.list_3.Where<GClass151>(new Func<GClass151, bool>(class1114.method_0)).Sum<GClass151>((Func<GClass151, Decimal>) (gclass151_0 => gclass151_0.decimal_0));
      // ISSUE: reference to a compiler-generated method
      Decimal decimal_73_2 = this.gclass21_0.list_3.Where<GClass151>(new Func<GClass151, bool>(class1114.method_1)).Sum<GClass151>((Func<GClass151, Decimal>) (gclass151_0 => gclass151_0.decimal_0));
      foreach (GClass150 gclass150 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1115 class1115 = new GClass146.Class1115();
        // ISSUE: reference to a compiler-generated field
        class1115.class1114_0 = class1114;
        // ISSUE: reference to a compiler-generated field
        class1115.gclass150_0 = gclass150;
        // ISSUE: reference to a compiler-generated method
        Decimal num1 = this.gclass21_0.list_3.Where<GClass151>(new Func<GClass151, bool>(class1115.method_0)).Sum<GClass151>((Func<GClass151, Decimal>) (gclass151_0 => gclass151_0.decimal_0));
        if (!(num1 == 0M))
        {
          // ISSUE: reference to a compiler-generated field
          if (class1115.gclass150_0.bool_0)
          {
            Decimal num2 = num1 / decimal_73_1;
            // ISSUE: reference to a compiler-generated field
            source1.Add(new GClass152()
            {
              string_0 = class1115.gclass150_0.string_0,
              string_1 = GClass226.smethod_42(num2 * 100M, 1) + "%",
              decimal_0 = num1
            });
          }
          else
          {
            Decimal num3 = num1 / decimal_73_2;
            // ISSUE: reference to a compiler-generated field
            source2.Add(new GClass152()
            {
              string_0 = class1115.gclass150_0.string_0,
              string_1 = GClass226.smethod_42(num3 * 100M, 1) + "%",
              decimal_0 = num1
            });
          }
        }
      }
      this.gclass0_0.method_601(listView_0, "Income Type", "Amount", "Percentage");
      this.gclass0_0.method_597(listView_0, "", "");
      this.gclass0_0.method_601(listView_1, "Expenditure Type", "Amount", "Percentage");
      this.gclass0_0.method_597(listView_1, "", "");
      List<GClass152> list2 = source1.OrderByDescending<GClass152, Decimal>((Func<GClass152, Decimal>) (gclass152_0 => gclass152_0.decimal_0)).ToList<GClass152>();
      List<GClass152> list3 = source2.OrderByDescending<GClass152, Decimal>((Func<GClass152, Decimal>) (gclass152_0 => gclass152_0.decimal_0)).ToList<GClass152>();
      foreach (GClass152 gclass152 in list2)
        this.gclass0_0.method_601(listView_0, gclass152.string_0, GClass226.smethod_42(gclass152.decimal_0, 1), gclass152.string_1);
      this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_597(listView_0, "Total Income", GClass226.smethod_42(decimal_73_1, 1));
      foreach (GClass152 gclass152 in list3)
        this.gclass0_0.method_601(listView_1, gclass152.string_0, GClass226.smethod_42(gclass152.decimal_0, 1), gclass152.string_1);
      this.gclass0_0.method_594(listView_1, "");
      this.gclass0_0.method_597(listView_1, "Total Expenditure", GClass226.smethod_42(decimal_73_2, 1));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2176);
    }
  }

  public void method_111(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_609(listView_0, "Date", "Length", "Balance", "Change", "Daily Change");
      this.gclass0_0.method_597(listView_0, "", "");
      this.gclass21_0.list_12 = this.gclass21_0.list_12.OrderBy<GClass206, Decimal>((Func<GClass206, Decimal>) (gclass206_0 => gclass206_0.decimal_0)).ToList<GClass206>();
      Decimal num1 = 0M;
      Decimal num2 = 0M;
      bool flag = true;
      foreach (GClass206 gclass206 in this.gclass21_0.list_12)
      {
        if (flag)
        {
          gclass206.decimal_2 = 0M;
          gclass206.int_0 = 0;
          flag = false;
        }
        else
        {
          gclass206.decimal_2 = gclass206.decimal_1 - num1;
          gclass206.int_0 = (int) (gclass206.decimal_0 - num2);
        }
        num1 = gclass206.decimal_1;
        num2 = gclass206.decimal_0;
      }
      this.gclass21_0.list_12 = this.gclass21_0.list_12.OrderByDescending<GClass206, Decimal>((Func<GClass206, Decimal>) (gclass206_0 => gclass206_0.decimal_0)).Take<GClass206>(18).ToList<GClass206>();
      foreach (GClass206 gclass206 in this.gclass21_0.list_12)
      {
        Decimal num3 = (Decimal) (gclass206.int_0 / 86400);
        if (num3 == 0M)
        {
          this.gclass0_0.method_611(listView_0, this.gclass0_0.method_584(gclass206.decimal_0), "-", GClass226.smethod_39(gclass206.decimal_1), "-", "-", (string) null);
        }
        else
        {
          Decimal decimal_73 = gclass206.decimal_2 / num3;
          this.gclass0_0.method_611(listView_0, this.gclass0_0.method_584(gclass206.decimal_0), this.gclass0_0.method_568(gclass206.int_0, false), GClass226.smethod_39(gclass206.decimal_1), GClass226.smethod_42(gclass206.decimal_2, 1), GClass226.smethod_42(decimal_73, 1), (string) null);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3578);
    }
  }

  public void method_112(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_611(listView_0, "Trade Good", "Production", "Shortfall", "Surplus", "Required", "Available");
      this.gclass0_0.method_597(listView_0, "", "");
      foreach (GClass190 gclass190 in this.dictionary_4.Values.OrderBy<GClass190, string>((Func<GClass190, string>) (gclass190_0 => gclass190_0.gclass189_0.string_0)).ToList<GClass190>())
      {
        Decimal decimal_73_1 = gclass190.decimal_0 * this.decimal_30 * (this.decimal_66 / 100M) * GClass226.decimal_4 * this.decimal_46;
        Decimal num1 = this.decimal_30 * (this.decimal_66 / 100M) * GClass226.decimal_4 * this.decimal_46;
        Decimal decimal_73_2 = 0M;
        Decimal decimal_73_3 = 0M;
        Decimal decimal_73_4;
        if (gclass190.gclass189_0.genum49_0 == GEnum49.const_2)
        {
          Decimal num2 = this.method_62(AuroraProductionCategory.Infrastructure);
          decimal_73_4 = this.genum19_0 != GEnum19.const_0 ? (Decimal) this.int_4 - num2 : (Decimal) this.int_4 * GClass226.decimal_56 - num2;
          if (decimal_73_4 > 0M)
          {
            if (decimal_73_1 > decimal_73_4)
              decimal_73_2 = decimal_73_1 - decimal_73_4;
            else
              decimal_73_3 = decimal_73_4 - decimal_73_1;
          }
          else
            decimal_73_2 = decimal_73_1;
        }
        else
        {
          if (gclass190.decimal_0 > 1M)
          {
            decimal_73_2 = decimal_73_1 - num1;
            decimal_73_3 = 0M;
          }
          else
          {
            decimal_73_3 = num1 - decimal_73_1;
            decimal_73_2 = 0M;
          }
          decimal_73_4 = !(gclass190.decimal_1 >= 0M) ? 0M - gclass190.decimal_1 : 0M;
        }
        string string_14 = !(decimal_73_4 > 0M) ? "-" : GClass226.smethod_42(decimal_73_4, 1);
        string string_13 = !(decimal_73_2 > 0M) ? "-" : GClass226.smethod_42(decimal_73_2, 1);
        string string_12 = !(decimal_73_3 > 0M) ? "-" : GClass226.smethod_42(decimal_73_3, 1);
        string string_15 = !(gclass190.decimal_1 > 0M) ? "-" : GClass226.smethod_42(gclass190.decimal_1, 1);
        this.gclass0_0.method_611(listView_0, gclass190.gclass189_0.string_0, GClass226.smethod_42(decimal_73_1, 1), string_12, string_13, string_14, string_15);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2177);
    }
  }

  public void method_113(
    ListView listView_0,
    ComboBox comboBox_0,
    ComboBox comboBox_1,
    Label label_0,
    Label label_1,
    Label label_2)
  {
    try
    {
      if (this.int_8 > 0)
      {
        label_2.Text = this.method_118();
        label_2.Visible = true;
      }
      else
        label_2.Visible = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2178);
    }
  }

  public void method_114(
    GClass21 gclass21_2,
    GEnum27 genum27_0,
    bool bool_10,
    bool bool_11,
    bool bool_12)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1116 class1116 = new GClass146.Class1116();
    // ISSUE: reference to a compiler-generated field
    class1116.gclass21_0 = gclass21_2;
    // ISSUE: reference to a compiler-generated field
    class1116.gclass146_0 = this;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass146.Class1117 class1117 = new GClass146.Class1117();
      // ISSUE: reference to a compiler-generated field
      class1117.class1116_0 = class1116;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (this.gclass21_1 != class1117.class1116_0.gclass21_0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        GClass110 gclass110_1 = class1117.class1116_0.gclass21_0.method_325(this.gclass21_0.RaceID);
        if (this.decimal_4 > 0M)
          gclass110_1.bool_4 = true;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1117.class1116_0.gclass21_0.method_163(gclass110_1, this.gclass194_0, GEnum25.const_0);
        if (this.decimal_4 > 0M)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1117.class1116_0.gclass21_0.method_163(gclass110_1, this.gclass194_0, GEnum25.const_0);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass194_0 = class1117.class1116_0.gclass21_0.method_164();
        }
        if (bool_10 && this.gclass21_0.genum6_0 == GEnum6.const_0)
        {
          switch (genum27_0)
          {
            case GEnum27.const_0:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: reference to a compiler-generated method
              using (List<GClass164>.Enumerator enumerator = this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1117.class1116_0.method_1)).ToList<GClass164>().Where<GClass164>(new Func<GClass164, bool>(new GClass146.Class1118()
              {
                list_0 = this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1117.class1116_0.method_0)).ToList<GClass164>()
              }.method_0)).ToList<GClass164>().GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  GClass164 current = enumerator.Current;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  class1117.class1116_0.gclass21_0.method_282(current, (GClass55) null, (GClass146) null, this.gclass21_0, false, false);
                }
                break;
              }
            case GEnum27.const_1:
              int num1 = this.method_73(AuroraInstallationType.ResearchLab);
              if (num1 > 0)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                foreach (GClass164 gclass164_0 in this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1117.class1116_0.method_3)).ToList<GClass164>().Where<GClass164>(new Func<GClass164, bool>(new GClass146.Class1119()
                {
                  list_0 = this.gclass0_0.dictionary_50.Values.Where<GClass164>(new Func<GClass164, bool>(class1117.class1116_0.method_2)).ToList<GClass164>()
                }.method_0)).ToList<GClass164>())
                {
                  if (GClass226.smethod_13(100) <= num1)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class1117.class1116_0.gclass21_0.method_282(gclass164_0, (GClass55) null, (GClass146) null, this.gclass21_0, false, false);
                  }
                }
              }
              int decimal_90 = this.method_73(AuroraInstallationType.CivilianMiningComplex);
              if (decimal_90 > 0)
              {
                this.method_64(AuroraInstallationType.CivilianMiningComplex, 0M);
                this.method_65(AuroraInstallationType.ExCivilianMiningComplex, (Decimal) decimal_90);
                break;
              }
              break;
          }
        }
        if (this.gclass21_0.decimal_0 > 0M && this.gclass21_0.genum6_0 == GEnum6.const_0 && bool_11)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          Decimal num2 = this.gclass21_0.decimal_0 * (this.decimal_4 / this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1117.class1116_0.method_4)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_4)));
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1117.class1116_0.gclass21_0.method_300(num2, this.gclass0_0.dictionary_45[GEnum84.const_12]);
          this.gclass21_0.method_299(num2, this.gclass0_0.dictionary_45[GEnum84.const_13]);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_96, $"As a result of conquering a hostile pop on {this.gclass1_0.method_78(class1117.class1116_0.gclass21_0)}, suitable reparations to the value of {GClass226.smethod_39(num2)} have been appropriated and added to total racial wealth.", class1117.class1116_0.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.Combat);
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_97, $"Due to the loss of {this.PopName}, {GClass226.smethod_39(num2)} wealth has been looted by the conquering barbarians", this.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.Combat);
        }
      }
      this.dictionary_1.Clear();
      this.dictionary_2.Clear();
      this.dictionary_3.Clear();
      this.dictionary_5.Clear();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass166 gclass166 in this.gclass21_0.list_5.Where<GClass166>(new Func<GClass166, bool>(class1117.class1116_0.method_5)).ToList<GClass166>())
        this.gclass21_0.list_5.Remove(gclass166);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass62 gclass62_0 in this.gclass21_0.dictionary_2.Values.Where<GClass62>(new Func<GClass62, bool>(class1117.class1116_0.method_6)).ToList<GClass62>())
        this.gclass21_0.method_124(gclass62_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass83 gclass83_0 in this.gclass0_0.dictionary_0.Values.Where<GClass83>(new Func<GClass83, bool>(class1117.class1116_0.method_7)).ToList<GClass83>())
        this.gclass0_0.method_560(gclass83_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass113 gclass113 in this.gclass0_0.dictionary_36.Values.SelectMany<GClass21, GClass113>((Func<GClass21, IEnumerable<GClass113>>) (gclass21_0 => (IEnumerable<GClass113>) gclass21_0.dictionary_13.Values)).Where<GClass113>(new Func<GClass113, bool>(class1117.class1116_0.method_8)).ToList<GClass113>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1120 class1120 = new GClass146.Class1120();
        // ISSUE: reference to a compiler-generated field
        class1120.class1117_0 = class1117;
        // ISSUE: reference to a compiler-generated field
        class1120.gclass113_0 = gclass113;
        // ISSUE: reference to a compiler-generated method
        if (this.gclass0_0.dictionary_28.Values.Count<GClass65>(new Func<GClass65, bool>(class1120.method_0)) == 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1120.gclass113_0.gclass21_0.dictionary_13.Remove(class1120.gclass113_0.gclass146_0.int_6);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (!class1120.gclass113_0.gclass21_0.dictionary_10.ContainsKey(class1120.class1117_0.class1116_0.gclass21_0.RaceID))
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1120.gclass113_0.gclass21_0.dictionary_13.Remove(class1120.gclass113_0.gclass146_0.int_6);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_66, $"The population of the {class1120.gclass113_0.gclass110_0.AlienRaceName} on {this.gclass1_0.method_78(class1120.gclass113_0.gclass21_0)} has been transferred to the {class1120.gclass113_0.gclass21_0.dictionary_10[class1120.class1117_0.class1116_0.gclass21_0.RaceID].AlienRaceName}", class1120.gclass113_0.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.Intelligence);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1120.gclass113_0.gclass110_0 = class1120.gclass113_0.gclass21_0.dictionary_10[class1120.class1117_0.class1116_0.gclass21_0.RaceID];
          }
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass65> list = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class1117.class1116_0.method_9)).ToList<GClass65>();
      // ISSUE: reference to a compiler-generated field
      class1117.list_0 = list.Select<GClass65, int>((Func<GClass65, int>) (gclass65_0 => gclass65_0.int_0)).ToList<int>();
      foreach (GClass65 gclass65 in list)
        this.gclass0_0.dictionary_28.Remove(gclass65.int_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (GClass85 gclass85 in this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1117.class1116_0.method_10)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1117.method_0)).Select<GClass139, GClass85>((Func<GClass139, GClass85>) (gclass139_0 => gclass139_0.gclass85_0)).ToList<GClass85>())
      {
        if (gclass85.genum106_0 == GEnum106.const_1 || gclass85.genum106_0 == GEnum106.const_2)
          gclass85.method_44();
        gclass85.method_263();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass85 gclass85 in this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1117.class1116_0.method_11)).ToList<GClass85>())
        gclass85.gclass146_0 = (GClass146) null;
      this.decimal_30 = this.decimal_4;
      this.bool_1 = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass192 gclass192 in this.gclass0_0.dictionary_32.Values.Where<GClass192>(new Func<GClass192, bool>(class1117.class1116_0.method_12)).ToList<GClass192>())
        this.gclass0_0.dictionary_32.Remove(gclass192.int_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass193 gclass193 in this.gclass0_0.dictionary_31.Values.Where<GClass193>(new Func<GClass193, bool>(class1117.class1116_0.method_13)).ToList<GClass193>())
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass193.gclass21_0 = class1117.class1116_0.gclass21_0;
        gclass193.gclass22_0 = (GClass22) null;
        gclass193.gclass22_1 = (GClass22) null;
        gclass193.gclass85_0 = (GClass85) null;
        gclass193.auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.None;
        gclass193.int_2 = 0;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values.Where<GClass55>(new Func<GClass55, bool>(class1117.class1116_0.method_14)).ToList<GClass55>())
        gclass55.method_40(true);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1117.class1116_0.method_15)).ToList<GClass103>())
      {
        if (gclass103.gclass55_0 != null)
          gclass103.gclass55_0.method_40(true);
        this.gclass0_0.dictionary_71.Remove(gclass103.int_0);
      }
      if (this.gclass21_0.genum6_0 == GEnum6.const_1)
        this.list_1.Clear();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      int int_72 = this.list_3.Where<GClass147>(new Func<GClass147, bool>(class1117.class1116_0.method_16)).Sum<GClass147>((Func<GClass147, int>) (gclass147_0 => gclass147_0.int_0));
      if (int_72 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_140, $"As a result of conquering a hostile pop on {this.gclass1_0.method_78(class1117.class1116_0.gclass21_0)}, {GClass226.smethod_37(int_72)} prisoners of war have been rescued", class1117.class1116_0.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.Intelligence);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1117.class1116_0.gclass21_0.decimal_8 += (Decimal) int_72;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values.Where<GClass55>(new Func<GClass55, bool>(class1117.class1116_0.method_17)).ToList<GClass55>())
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_140, $"As a result of conquering a hostile pop on {this.gclass1_0.method_78(class1117.class1116_0.gclass21_0)}, {gclass55.method_36()} has been rescued", class1117.class1116_0.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.Intelligence);
        gclass55.bool_4 = false;
        gclass55.bool_5 = false;
        gclass55.gclass146_0 = (GClass146) null;
        gclass55.auroraRetirementStatus_0 = AuroraRetirementStatus.Active;
      }
      if (bool_12 && this.decimal_4 >= 10M)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        foreach (GClass40 gclass40 in this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1117.class1116_0.method_18)).ToList<GClass40>())
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass40.method_61(class1117.class1116_0.gclass21_0);
        }
      }
      if (this.bool_0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        GClass146 gclass146 = this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1117.class1116_0.method_19)).OrderByDescending<GClass146, Decimal>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_30)).FirstOrDefault<GClass146>();
        if (gclass146 != null)
          gclass146.bool_0 = true;
        this.bool_0 = false;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.gclass160_0 = this.gclass21_1 == class1117.class1116_0.gclass21_0 || this.decimal_4 == 0M ? this.gclass0_0.dictionary_39[GEnum27.const_0] : this.gclass0_0.dictionary_39[genum27_0];
      this.decimal_6 = 0M;
      this.decimal_8 = 0M;
      this.gclass146_0 = (GClass146) null;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (!class1117.class1116_0.gclass21_0.bool_0)
        this.gclass6_0 = (GClass6) null;
      else if (!this.gclass21_0.bool_0)
        this.gclass6_0 = new GClass6(this.gclass0_0, this);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      foreach (GClass132 gclass132 in this.gclass0_0.dictionary_6.Values.Where<GClass132>(new Func<GClass132, bool>(class1117.class1116_0.method_20)).ToList<GClass132>())
        this.gclass0_0.dictionary_6.Remove(gclass132.int_1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      if (this.gclass21_0.bool_0 && this.gclass21_0.genum6_0 == GEnum6.const_0 && this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1117.class1116_0.method_21)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_30)) == this.decimal_4)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        foreach (GClass40 gclass40 in this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1117.class1116_0.method_22)).ToList<GClass40>())
        {
          if (gclass40.gclass5_0.method_0())
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            gclass40.method_61(class1117.class1116_0.gclass21_0);
          }
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.gclass202_0 = class1117.class1116_0.gclass21_0.method_128(this.gclass202_0.gclass200_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.PopName = this.gclass1_0.method_78(class1117.class1116_0.gclass21_0);
      this.gclass21_1 = this.gclass21_0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.gclass21_0 = class1117.class1116_0.gclass21_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2179);
    }
  }

  public bool method_115(GClass146 gclass146_1)
  {
    try
    {
      this.decimal_83 = (Decimal) (this.gclass194_0.int_7 + this.gclass194_0.int_5 + this.gclass194_0.int_2) / 300M;
      Decimal decimal_73_1 = this.decimal_83 * this.decimal_4;
      Decimal decimal_73_2 = (Decimal) gclass146_1.method_56();
      if (decimal_73_2 >= decimal_73_1)
      {
        if (gclass146_1.gclass21_0 == this.gclass21_1)
        {
          if (this.decimal_4 > 0M)
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_45, $"Enemy forces on {this.gclass1_0.method_78(gclass146_1.gclass21_0)} have been defeated and the population has been liberated.", gclass146_1.gclass21_0, gclass146_1.gclass202_0.gclass200_0, gclass146_1.method_87(), gclass146_1.method_88(), AuroraEventCategory.Combat);
          else
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_45, $"Enemy forces on {this.gclass1_0.method_78(gclass146_1.gclass21_0)} have been defeated and the colony has been liberated.", gclass146_1.gclass21_0, gclass146_1.gclass202_0.gclass200_0, gclass146_1.method_87(), gclass146_1.method_88(), AuroraEventCategory.Combat);
        }
        else if (this.decimal_4 > 0M)
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_45, $"Enemy forces on {this.gclass1_0.method_78(gclass146_1.gclass21_0)} have been defeated and the enemy population has surrendered.", gclass146_1.gclass21_0, gclass146_1.gclass202_0.gclass200_0, gclass146_1.method_87(), gclass146_1.method_88(), AuroraEventCategory.Combat);
        else
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_45, $"Enemy forces on {this.gclass1_0.method_78(gclass146_1.gclass21_0)} have been defeated and the enemy colony has been occupied.", gclass146_1.gclass21_0, gclass146_1.gclass202_0.gclass200_0, gclass146_1.method_87(), gclass146_1.method_88(), AuroraEventCategory.Combat);
        this.method_114(gclass146_1.gclass21_0, GEnum27.const_1, GClass226.smethod_68(this.gclass0_0.int_105), true, true);
        return true;
      }
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_45, $"Enemy forces on {this.gclass1_0.method_78(gclass146_1.gclass21_0)} have been defeated but the population refuses to surrender. Current occupation strength is {GClass226.smethod_39(decimal_73_2)}. Required strength to force surrender is {GClass226.smethod_39(decimal_73_1)}", gclass146_1.gclass21_0, gclass146_1.gclass202_0.gclass200_0, gclass146_1.method_87(), gclass146_1.method_88(), AuroraEventCategory.Combat);
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2180);
      return false;
    }
  }

  public void method_116(ListView listView_0)
  {
    try
    {
      this.decimal_83 = (Decimal) (this.gclass194_0.int_7 + this.gclass194_0.int_5 + this.gclass194_0.int_2) / 300M;
      this.decimal_84 = this.decimal_83 * this.decimal_4 * this.gclass160_0.decimal_2;
      this.decimal_85 = (Decimal) this.method_56();
      if (listView_0 != null && this.gclass160_0.genum27_0 != GEnum27.const_0)
        this.gclass0_0.method_597(listView_0, "Occupation Required / Actual", $"{GClass226.smethod_39(this.decimal_84)} / {GClass226.smethod_39(this.decimal_85)}");
      if (!(this.decimal_4 > 0M))
        return;
      this.decimal_86 = this.decimal_85 - this.decimal_84;
      this.decimal_87 = this.decimal_83 * this.decimal_4;
      this.decimal_88 = 1M;
      if (this.decimal_87 > 0M)
        this.decimal_88 = this.decimal_86 / this.decimal_87;
      if (listView_0 == null)
        return;
      this.gclass0_0.method_597(listView_0, "Police Strength / Resistance", $"{GClass226.smethod_39(this.decimal_86)} / {GClass226.smethod_39(this.decimal_87)}");
      this.gclass0_0.method_597(listView_0, "Annual Unrest Reduction", GClass226.smethod_39(this.decimal_88 * 100M) + "%");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2181);
    }
  }

  public List<GClass108> method_117()
  {
    try
    {
      List<GClass108> gclass108List = new List<GClass108>();
      List<GClass146> list = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass1_0 == this.gclass1_0 && gclass146_1.gclass21_0 == this.gclass21_0 && gclass146_1 != this)).OrderBy<GClass146, string>((Func<GClass146, string>) (gclass146_0 => gclass146_0.PopName)).ToList<GClass146>();
      List<GClass40> gclass40List = this.method_196();
      foreach (GClass146 gclass146 in list)
        gclass108List.Add(new GClass108()
        {
          gclass146_0 = gclass146,
          Description = gclass146.PopName
        });
      foreach (GClass40 gclass40 in gclass40List)
      {
        int num = gclass40.method_211();
        gclass108List.Add(new GClass108()
        {
          gclass40_0 = gclass40,
          Description = $"{gclass40.gclass22_0.gclass76_0.Abbreviation} {gclass40.ShipName} - Cap {num.ToString()}"
        });
      }
      return gclass108List;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2182);
      return (List<GClass108>) null;
    }
  }

  public string method_118()
  {
    try
    {
      return "Ground Attack In Progress vs " + this.gclass21_0.method_284(this.int_8);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2183);
      return "";
    }
  }

  public void method_119(ListView listView_0, ListView listView_1, ListView listView_2)
  {
    try
    {
      bool flag = this.gclass1_0.method_77(this.gclass21_0);
      Decimal decimal_73_1 = this.method_203(AuroraComponentType.OrbitalMiningModule, GEnum121.const_5);
      Decimal decimal_73_2 = !(decimal_73_1 > 0M) ? 1M : decimal_73_1 / (this.decimal_72 * this.gclass21_0.decimal_17);
      int int_72_1 = this.method_73(AuroraInstallationType.Mine);
      int int_72_2 = this.method_73(AuroraInstallationType.AutomatedMine);
      int int_72_3 = this.method_73(AuroraInstallationType.CivilianMiningComplex);
      int int_72_4 = this.method_73(AuroraInstallationType.ExCivilianMiningComplex);
      int int_72_5 = this.method_73(AuroraInstallationType.ConventionalIndustry);
      int int_72_6 = this.method_73(AuroraInstallationType.ForcedLabourMiningCamp);
      string string_12_1 = this.gclass21_0.decimal_17.ToString();
      string string_12_2 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.gclass0_0.dictionary_44[AuroraInstallationType.ConventionalIndustry].decimal_7, 2).ToString();
      string string_12_3 = GClass226.smethod_42(this.gclass21_0.decimal_17 * 10M, 1).ToString();
      string string_13 = GClass226.smethod_42(this.decimal_5, 2).ToString();
      string string_14_1 = GClass226.smethod_42(this.decimal_33, 2).ToString();
      string string_15 = GClass226.smethod_42(this.gclass160_0.decimal_0, 2).ToString();
      string string_16 = GClass226.smethod_42(this.decimal_31, 2).ToString();
      string string_20_1 = GClass226.smethod_42(this.decimal_20, 2).ToString();
      string string_20_2 = GClass226.smethod_42(this.decimal_21, 2).ToString();
      string string_21_1 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_20, 2).ToString();
      string string_21_2 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_20 / 10M, 2).ToString();
      string string_21_3 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_21, 2).ToString();
      string string_21_4 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_21 * 10M, 2).ToString();
      string string_21_5 = GClass226.smethod_42(decimal_73_2 * this.gclass21_0.decimal_17, 2).ToString();
      string string_22_1 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_20 * (Decimal) int_72_1, 2).ToString();
      string string_22_2 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_20 * (Decimal) int_72_6, 2).ToString();
      string string_22_3 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_20 * (Decimal) int_72_5 * this.gclass0_0.dictionary_44[AuroraInstallationType.ConventionalIndustry].decimal_7, 2).ToString();
      string string_22_4 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_21 * (Decimal) int_72_2, 2).ToString();
      string string_22_5 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_21 * (Decimal) int_72_4 * 10M, 2).ToString();
      string string_22_6 = GClass226.smethod_42(this.gclass21_0.decimal_17 * this.decimal_21 * (Decimal) int_72_3 * 10M, 2).ToString();
      string string_22_7 = GClass226.smethod_42(decimal_73_1, 2).ToString();
      string str = GClass226.smethod_42(decimal_73_2, 2).ToString();
      string string_17 = "1";
      if (this.gclass55_0 != null)
        string_17 = GClass226.smethod_42(this.gclass55_0.method_5(GEnum121.const_5), 2).ToString();
      string string_18 = "1";
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
        string_18 = GClass226.smethod_42(this.gclass202_0.gclass62_0.gclass55_0.method_5(GEnum121.const_5), 2).ToString();
      listView_1.Items.Clear();
      this.gclass0_0.method_623(listView_1, "Mining Modifiers", "Amount", "Production", "Manu Effic", "Stability", "Polit Status", "Radiation", "Governor", "Sector", "Ship COs", "Total Mod", "Per Mine", "Total Prod");
      this.gclass0_0.method_597(listView_1, "", "");
      if (int_72_1 > 0)
        this.gclass0_0.method_623(listView_1, "Manned Mines", GClass226.smethod_37(int_72_1).ToString(), string_12_1, string_13, string_14_1, string_15, string_16, string_17, string_18, "-", string_20_1, string_21_1, string_22_1);
      if (int_72_2 > 0)
        this.gclass0_0.method_623(listView_1, "Automated Mines", GClass226.smethod_37(int_72_2).ToString(), string_12_1, "-", "-", "-", string_16, string_17, string_18, "-", string_20_2, string_21_3, string_22_4);
      if (int_72_6 > 0)
        this.gclass0_0.method_623(listView_1, "Mining Labour Camps", GClass226.smethod_37(int_72_6).ToString(), string_12_1, string_13, string_14_1, string_15, string_16, string_17, string_18, "-", string_20_1, string_21_1, string_22_2);
      if (this.decimal_72 > 0M)
        this.gclass0_0.method_623(listView_1, "Orbital Mining Modules", GClass226.smethod_38(this.decimal_72).ToString(), string_12_1, "-", "-", "-", "-", "-", "-", str, str, string_21_5, string_22_7);
      if (int_72_5 > 0)
        this.gclass0_0.method_623(listView_1, "Conventional Industry", GClass226.smethod_37(int_72_5).ToString(), string_12_2, string_13, string_14_1, string_15, string_16, string_17, string_18, "-", string_20_1, string_21_2, string_22_3);
      if (int_72_4 > 0)
        this.gclass0_0.method_623(listView_1, "Ex-Civilian Complexes", GClass226.smethod_37(int_72_4).ToString(), string_12_3, "-", "-", "-", string_16, string_17, string_18, "-", string_20_2, string_21_4, string_22_5);
      if (int_72_3 > 0)
        this.gclass0_0.method_623(listView_1, "Civilian Complexes", GClass226.smethod_37(int_72_3).ToString(), string_12_3, "-", "-", "-", string_16, string_17, string_18, "-", string_20_2, string_21_4, string_22_6);
      listView_0.Items.Clear();
      this.gclass0_0.method_620(listView_0, "Mineral Data", "Quantity", "Accessibility", "Production", "Depletion (yrs)", "Stockpile", "Recent SP", "Mass Driver", "SP + Production", "Projected Usage", "Reserve", (object) null);
      this.gclass0_0.method_597(listView_0, "", "");
      this.gclass127_0.method_1();
      Decimal decimal_73_3 = 0M;
      Decimal decimal_73_4 = 0M;
      Decimal decimal_73_5 = 0M;
      Decimal decimal_73_6 = 0M;
      Decimal decimal_73_7 = 0M;
      Decimal decimal_73_8 = 0M;
      Decimal decimal_73_9 = 0M;
      Decimal decimal_73_10 = 0M;
      Decimal decimal_73_11 = 0M;
      Decimal decimal_73_12 = 0M;
      foreach (AuroraElement auroraElement in Enum.GetValues(typeof (AuroraElement)))
      {
        if (auroraElement != AuroraElement.None)
        {
          string string_10 = auroraElement.ToString();
          Decimal decimal_73_13;
          Decimal decimal_73_14;
          Decimal decimal_73_15;
          Decimal decimal_73_16;
          Decimal decimal_73_17;
          if (this.gclass1_0.dictionary_0.ContainsKey(auroraElement))
          {
            Decimal decimal0 = this.gclass1_0.dictionary_0[auroraElement].decimal_0;
            Decimal decimal1 = this.gclass1_0.dictionary_0[auroraElement].decimal_1;
            Decimal decimal_73_18 = this.decimal_22 * decimal1;
            decimal_73_3 += decimal0;
            decimal_73_4 += decimal1;
            decimal_73_5 += decimal_73_18;
            string string_14_2;
            if (decimal_73_18 > 0.001M)
            {
              Decimal decimal_73_19 = decimal0 / decimal_73_18;
              if (decimal_73_19 > decimal_73_6)
                decimal_73_6 = decimal_73_19;
              string_14_2 = GClass226.smethod_42(decimal_73_19, 1).ToString();
            }
            else
              string_14_2 = "-";
            decimal_73_13 = this.gclass123_0.method_14(auroraElement);
            decimal_73_14 = decimal_73_13 - this.gclass123_1.method_14(auroraElement);
            decimal_73_15 = this.gclass123_3.method_14(auroraElement);
            Decimal decimal_73_20 = decimal_73_13 + decimal_73_18;
            decimal_73_10 += decimal_73_20;
            decimal_73_16 = this.gclass127_0.gclass123_8.method_14(auroraElement);
            decimal_73_17 = this.gclass123_2.method_14(auroraElement);
            Color color_0 = GClass226.color_16;
            if (decimal_73_16 > decimal_73_20)
              color_0 = !(decimal_73_16 > decimal0 + decimal_73_13) ? Color.Orange : Color.Red;
            if (flag)
              this.gclass0_0.method_619(listView_0, string_10, GClass226.smethod_39(decimal0).ToString(), GClass226.smethod_42(decimal1, 2).ToString(), GClass226.smethod_39(decimal_73_18).ToString(), string_14_2, GClass226.smethod_39(decimal_73_13).ToString(), GClass226.smethod_39(decimal_73_14).ToString(), GClass226.smethod_39(decimal_73_15).ToString(), GClass226.smethod_39(decimal_73_20).ToString(), GClass226.smethod_39(decimal_73_16).ToString(), GClass226.smethod_39(decimal_73_17).ToString(), color_0, (object) auroraElement);
            else
              this.gclass0_0.method_619(listView_0, string_10, "??", "??", "??", "??", GClass226.smethod_39(decimal_73_13).ToString(), "??", GClass226.smethod_39(decimal_73_15).ToString(), "??", GClass226.smethod_39(decimal_73_16).ToString(), GClass226.smethod_39(decimal_73_17).ToString(), GClass226.color_16, (object) auroraElement);
          }
          else
          {
            decimal_73_13 = this.gclass123_0.method_14(auroraElement);
            decimal_73_10 += decimal_73_13;
            decimal_73_14 = decimal_73_13 - this.gclass123_1.method_14(auroraElement);
            decimal_73_15 = 0M;
            decimal_73_16 = this.gclass127_0.gclass123_8.method_14(auroraElement);
            decimal_73_17 = this.gclass123_2.method_14(auroraElement);
            if (flag)
              this.gclass0_0.method_620(listView_0, string_10, "-", "-", "-", "-", GClass226.smethod_39(decimal_73_13).ToString(), GClass226.smethod_39(decimal_73_14).ToString(), GClass226.smethod_39(decimal_73_15).ToString(), GClass226.smethod_39(decimal_73_13).ToString(), GClass226.smethod_39(decimal_73_16).ToString(), GClass226.smethod_39(decimal_73_17).ToString(), (object) auroraElement);
            else
              this.gclass0_0.method_619(listView_0, string_10, "??", "??", "??", "??", GClass226.smethod_39(decimal_73_13).ToString(), "??", GClass226.smethod_39(decimal_73_15).ToString(), "??", GClass226.smethod_39(decimal_73_16).ToString(), GClass226.smethod_39(decimal_73_17).ToString(), GClass226.color_16, (object) auroraElement);
          }
          decimal_73_7 += decimal_73_13;
          decimal_73_8 += decimal_73_14;
          decimal_73_9 += decimal_73_15;
          decimal_73_11 += decimal_73_16;
          decimal_73_12 += decimal_73_17;
        }
      }
      this.gclass0_0.method_597(listView_0, "", "");
      if (flag)
        this.gclass0_0.method_620(listView_0, "Total", GClass226.smethod_38(decimal_73_3), GClass226.smethod_42(decimal_73_4, 2), GClass226.smethod_38(decimal_73_5), GClass226.smethod_42(decimal_73_6, 1), GClass226.smethod_38(decimal_73_7), GClass226.smethod_38(decimal_73_8), GClass226.smethod_38(decimal_73_9), GClass226.smethod_38(decimal_73_10), GClass226.smethod_38(decimal_73_11), GClass226.smethod_38(decimal_73_12), (object) null);
      else
        this.gclass0_0.method_620(listView_0, "Total", "??", "??", "??", "??", GClass226.smethod_38(decimal_73_7), "??", GClass226.smethod_38(decimal_73_9), "??", GClass226.smethod_38(decimal_73_11), GClass226.smethod_38(decimal_73_12), (object) null);
      listView_2.Items.Clear();
      this.gclass0_0.method_617(listView_2, "Mineral Usage", "Construction", "Ordnance", "Fighter", "SY Tasks", "SY Mods", "Refineries", "GU Training", "Maintenance", "Total", (object) null);
      this.gclass0_0.method_597(listView_2, "", "");
      foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof (AuroraElement)))
      {
        if (auroraElement_0 != AuroraElement.None)
        {
          string string_10 = auroraElement_0.ToString();
          Decimal decimal_73_21 = this.gclass127_0.gclass123_0.method_14(auroraElement_0);
          Decimal decimal_73_22 = this.gclass127_0.gclass123_1.method_14(auroraElement_0);
          Decimal decimal_73_23 = this.gclass127_0.gclass123_2.method_14(auroraElement_0);
          Decimal decimal_73_24 = this.gclass127_0.gclass123_4.method_14(auroraElement_0);
          Decimal decimal_73_25 = this.gclass127_0.gclass123_3.method_14(auroraElement_0);
          Decimal decimal_73_26 = this.gclass127_0.gclass123_6.method_14(auroraElement_0);
          Decimal decimal_73_27 = this.gclass127_0.gclass123_5.method_14(auroraElement_0);
          Decimal decimal_73_28 = this.gclass127_0.gclass123_7.method_14(auroraElement_0);
          Decimal decimal_73_29 = this.gclass127_0.gclass123_8.method_14(auroraElement_0);
          this.gclass0_0.method_617(listView_2, string_10, GClass226.smethod_39(decimal_73_21).ToString(), GClass226.smethod_42(decimal_73_22, 2).ToString(), GClass226.smethod_39(decimal_73_23).ToString(), GClass226.smethod_39(decimal_73_24).ToString(), GClass226.smethod_39(decimal_73_25).ToString(), GClass226.smethod_39(decimal_73_26).ToString(), GClass226.smethod_39(decimal_73_27).ToString(), GClass226.smethod_39(decimal_73_28).ToString(), GClass226.smethod_39(decimal_73_29).ToString(), (object) null);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2184);
    }
  }

  public void method_120(ListView listView_0, RadioButton radioButton_0)
  {
    try
    {
      this.gclass127_0.gclass123_4.method_6();
      listView_0.Items.Clear();
      List<GClass192> list = this.gclass0_0.dictionary_32.Values.Where<GClass192>((Func<GClass192, bool>) (gclass192_0 => gclass192_0.gclass146_0 == this)).OrderBy<GClass192, bool>((Func<GClass192, bool>) (gclass192_0 => gclass192_0.bool_0)).ThenByDescending<GClass192, Decimal>((Func<GClass192, Decimal>) (gclass192_0 => gclass192_0.gclass22_0.decimal_14)).ThenBy<GClass192, string>((Func<GClass192, string>) (gclass192_0 => gclass192_0.string_0)).ToList<GClass192>();
      this.gclass0_0.method_613(listView_0, "Shipyard", "Task Description", "Ship Name", "Fleet / Admin", "Completion Date", "Progress", "Build Rate", (object) null);
      this.gclass0_0.method_597(listView_0, "", "");
      foreach (GClass192 gclass192_0 in list)
      {
        gclass192_0.decimal_2 = gclass192_0.decimal_1 / gclass192_0.decimal_0 * 100M;
        if (gclass192_0.auroraSYTaskType_0 != AuroraSYTaskType.Refit && gclass192_0.auroraSYTaskType_0 != AuroraSYTaskType.AutoRefit)
          gclass192_0.gclass193_0.method_7(gclass192_0.gclass22_0);
        else
          gclass192_0.gclass193_0.method_7(gclass192_0.gclass22_1);
        gclass192_0.decimal_3 = Math.Abs(gclass192_0.decimal_0 - gclass192_0.decimal_1) / gclass192_0.gclass193_0.decimal_4 * GClass226.decimal_29;
        gclass192_0.decimal_4 = this.gclass0_0.decimal_0 + gclass192_0.decimal_3;
        this.gclass127_0.gclass123_4.method_9(gclass192_0);
      }
      if (!radioButton_0.Checked)
        list = list.OrderBy<GClass192, Decimal>((Func<GClass192, Decimal>) (gclass192_0 => gclass192_0.decimal_4)).ToList<GClass192>();
      foreach (GClass192 object_1 in list)
      {
        string string_14 = this.gclass0_0.method_583((double) object_1.decimal_4);
        string string_13 = "No Fleet Set";
        if (object_1.gclass85_0 != null)
          string_13 = object_1.gclass85_0.FleetName;
        if (object_1.gclass83_0 != null)
          string_13 = object_1.gclass83_0.AdminCommandName;
        if (!object_1.bool_2)
          this.gclass0_0.method_613(listView_0, object_1.gclass193_0.string_0, object_1.method_0(), object_1.string_0, string_13, string_14, GClass226.smethod_42(object_1.decimal_2, 1) + "%", GClass226.smethod_39(object_1.gclass193_0.decimal_4), (object) object_1);
        else
          this.gclass0_0.method_613(listView_0, object_1.gclass193_0.string_0, object_1.method_0(), object_1.string_0, string_13, string_14, GClass226.smethod_42(object_1.decimal_2, 1) + "%", "Paused", (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2185);
    }
  }

  public void method_121(ListView listView_0)
  {
    try
    {
      Decimal decimal_73_1 = 0M;
      Decimal num1 = 0M;
      string str = "";
      this.gclass127_0.gclass123_5.method_6();
      listView_0.Items.Clear();
      this.gclass0_0.method_612(listView_0, "Unit Type", "Formation Name", "BP Cost", "Allocation", "Progress", "Completion Date", (object) null);
      List<GClass106> list = this.dictionary_3.Values.OrderBy<GClass106, Decimal>((Func<GClass106, Decimal>) (gclass106_0 => gclass106_0.decimal_0)).ThenBy<GClass106, string>((Func<GClass106, string>) (gclass106_0 => gclass106_0.string_0)).ToList<GClass106>();
      foreach (GClass106 object_1 in list)
      {
        if (object_1.decimal_0 == 0M)
          object_1.decimal_0 = 1M;
        Decimal decimal_73_2 = object_1.decimal_1 / object_1.decimal_0 * 100M;
        Decimal num2 = object_1.decimal_0 - object_1.decimal_1;
        string string_15;
        if (this.decimal_67 <= 0M)
        {
          string_15 = "N/A";
        }
        else
        {
          decimal_73_1 = Math.Abs(num2) / this.decimal_67 * (100M / object_1.decimal_2) * GClass226.decimal_29;
          this.gclass127_0.gclass123_5.method_10(object_1.gclass102_0.method_4());
          string_15 = this.gclass0_0.method_583((double) (this.gclass0_0.decimal_0 + decimal_73_1));
        }
        num1 += object_1.decimal_2;
        this.gclass0_0.method_612(listView_0, object_1.gclass102_0.Name, object_1.string_0, GClass226.smethod_38(object_1.decimal_0), GClass226.smethod_38(object_1.decimal_2) + " % ", GClass226.smethod_42(decimal_73_2, 1) + " % ", string_15, (object) object_1);
      }
      if (num1 < 100M)
      {
        if (list.Count > 0)
          this.gclass0_0.method_597(listView_0, "", "");
        this.gclass0_0.method_597(listView_0, $" Capacity Available: {GClass226.smethod_39(this.decimal_67 * ((100M - num1) / 100M))} BP  ({GClass226.smethod_42(100M - num1, 1)}%)", (string) null);
      }
      if (this.list_0.Count <= 0)
        return;
      this.gclass0_0.method_597(listView_0, "", "");
      this.gclass0_0.method_612(listView_0, "Queued Tasks", "Formation Name", "BP Cost", "Allocation", "Queue ID", "Build Time", (object) null);
      foreach (GClass107 object_1 in this.list_0.OrderBy<GClass107, int>((Func<GClass107, int>) (gclass107_0 => gclass107_0.int_0)).ToList<GClass107>())
      {
        Decimal decimal_73_3 = object_1.gclass102_0.method_3(this);
        if (this.decimal_67 <= 0M)
        {
          str = "N/A";
        }
        else
        {
          decimal_73_1 = decimal_73_3 / this.decimal_67 * (object_1.decimal_0 / 100M);
          this.gclass127_0.gclass123_5.method_10(object_1.gclass102_0.method_4());
          str = this.gclass0_0.method_583((double) (this.gclass0_0.decimal_0 + decimal_73_1));
        }
        this.gclass0_0.method_612(listView_0, object_1.gclass102_0.Name, object_1.string_0, GClass226.smethod_38(decimal_73_3), GClass226.smethod_38(object_1.decimal_0) + " % ", object_1.int_0.ToString(), GClass226.smethod_42(decimal_73_1, 2) + " years", (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2186);
    }
  }

  public void method_122(
    GClass102 gclass102_0,
    string string_6,
    Decimal decimal_90,
    AuroraGroundFormationFieldPosition auroraGroundFormationFieldPosition_0,
    int int_25,
    int int_26)
  {
    try
    {
      GClass106 gclass106 = new GClass106(this.gclass0_0);
      gclass106.int_0 = this.gclass0_0.method_26(GEnum0.const_34);
      gclass106.gclass146_0 = this;
      gclass106.gclass21_0 = this.gclass21_0;
      gclass106.string_0 = string_6;
      gclass106.gclass102_0 = gclass102_0;
      gclass106.decimal_0 = gclass102_0.method_3(this);
      gclass106.decimal_1 = 0M;
      gclass106.decimal_2 = decimal_90;
      gclass106.auroraGroundFormationFieldPosition_0 = auroraGroundFormationFieldPosition_0;
      gclass106.int_2 = int_25;
      gclass106.int_1 = int_26;
      this.dictionary_3.Add(gclass106.int_0, gclass106);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2187);
    }
  }

  public void method_123(
    GClass193 gclass193_0,
    string string_6,
    Label label_0,
    Label label_1,
    ComboBox comboBox_0,
    Label label_2,
    TextBox textBox_0,
    Label label_3,
    TextBox textBox_1,
    bool bool_10)
  {
    try
    {
      Decimal decimal_73 = 0M;
      if (gclass193_0 == null)
        return;
      if (bool_10)
      {
        label_2.Visible = false;
        textBox_0.Visible = false;
        label_3.Visible = false;
        textBox_1.Visible = false;
        comboBox_0.Visible = false;
      }
      if (string_6 != null)
      {
        switch (string_6.Length)
        {
          case 6:
            if (string_6 == "Retool")
            {
              this.method_126(gclass193_0, comboBox_0);
              if (bool_10)
                comboBox_0.Visible = true;
              decimal_73 = 0M;
              break;
            }
            break;
          case 11:
            if (string_6 == "Add Slipway")
            {
              decimal_73 = gclass193_0.decimal_0 / 500M * (Decimal) GClass226.int_56 * this.gclass21_0.decimal_21;
              break;
            }
            break;
          case 20:
            if (string_6 == "Add 500 ton Capacity")
            {
              decimal_73 = (Decimal) (gclass193_0.int_1 * GClass226.int_56) * this.gclass21_0.decimal_21;
              break;
            }
            break;
          case 21:
            switch (string_6[4])
            {
              case '1':
                if (string_6 == "Add 1000 ton Capacity")
                {
                  decimal_73 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 2) * this.gclass21_0.decimal_21;
                  break;
                }
                break;
              case '2':
                if (string_6 == "Add 2000 ton Capacity")
                {
                  decimal_73 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 4) * this.gclass21_0.decimal_21;
                  break;
                }
                break;
              case '5':
                if (string_6 == "Add 5000 ton Capacity")
                {
                  decimal_73 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 10) * this.gclass21_0.decimal_21;
                  break;
                }
                break;
            }
            break;
          case 23:
            if (string_6 == "Add 10,000 ton Capacity")
            {
              decimal_73 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 20) * this.gclass21_0.decimal_21;
              break;
            }
            break;
          case 24:
            if (string_6 == "Spacemaster Modification")
            {
              if (bool_10)
              {
                label_2.Visible = true;
                textBox_0.Visible = true;
                label_3.Visible = true;
                textBox_1.Visible = true;
                label_2.Text = "Set Capacity";
              }
              decimal_73 = 0M;
              textBox_0.Text = gclass193_0.decimal_0.ToString();
              textBox_1.Text = gclass193_0.int_1.ToString();
              break;
            }
            break;
          case 26:
            if (string_6 == "Continual Capacity Upgrade")
            {
              decimal_73 = 0M;
              if (bool_10)
              {
                label_2.Visible = true;
                textBox_0.Visible = true;
                label_2.Text = "Capacity Target";
              }
              if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval)
              {
                textBox_0.Text = Math.Round(gclass193_0.decimal_0 + 2000M).ToString();
                break;
              }
              textBox_0.Text = Math.Round(gclass193_0.decimal_0 + 10000M).ToString();
              break;
            }
            break;
        }
      }
      if (decimal_73 > 0M)
      {
        if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial || gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard)
          decimal_73 *= GClass226.decimal_67;
        label_0.Text = GClass226.smethod_42(decimal_73, 1);
        if (gclass193_0.decimal_3 <= 0M)
        {
          label_1.Text = "Infinte";
        }
        else
        {
          Decimal num = decimal_73 / gclass193_0.decimal_3 * GClass226.decimal_29;
          label_1.Text = this.gclass0_0.method_583((double) (this.gclass0_0.decimal_0 + num));
        }
      }
      else
      {
        if (!(string_6 != "Retool"))
          return;
        label_0.Text = "N/A";
        label_1.Text = "N/A";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2188);
    }
  }

  public void method_124(
    GClass193 gclass193_0,
    AuroraShipyardUpgradeType auroraShipyardUpgradeType_0,
    GClass22 gclass22_0,
    int int_25)
  {
    try
    {
      if (gclass193_0 == null)
        return;
      if (auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.Retool && gclass193_0.gclass22_0 == null)
      {
        gclass193_0.gclass22_0 = gclass22_0;
        gclass22_0.bool_3 = true;
      }
      else
      {
        Decimal num1 = 0M;
        switch (auroraShipyardUpgradeType_0)
        {
          case AuroraShipyardUpgradeType.AddSlipway:
            num1 = gclass193_0.decimal_0 / 500M * (Decimal) GClass226.int_56 * this.gclass21_0.decimal_21;
            if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial || gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard)
            {
              num1 *= GClass226.decimal_67;
              break;
            }
            break;
          case AuroraShipyardUpgradeType.Add500:
            num1 = (Decimal) (gclass193_0.int_1 * GClass226.int_56) * this.gclass21_0.decimal_21;
            if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial || gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard)
            {
              num1 *= GClass226.decimal_67;
              break;
            }
            break;
          case AuroraShipyardUpgradeType.Add1000:
            num1 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 2) * this.gclass21_0.decimal_21;
            if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial || gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard)
            {
              num1 *= GClass226.decimal_67;
              break;
            }
            break;
          case AuroraShipyardUpgradeType.Add2000:
            num1 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 4) * this.gclass21_0.decimal_21;
            if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial || gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard)
            {
              num1 *= GClass226.decimal_67;
              break;
            }
            break;
          case AuroraShipyardUpgradeType.Add5000:
            num1 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 10) * this.gclass21_0.decimal_21;
            if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial || gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard)
            {
              num1 *= GClass226.decimal_67;
              break;
            }
            break;
          case AuroraShipyardUpgradeType.Add10000:
            num1 = (Decimal) (gclass193_0.int_1 * GClass226.int_56 * 20) * this.gclass21_0.decimal_21;
            if (gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial || gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard)
            {
              num1 *= GClass226.decimal_67;
              break;
            }
            break;
          case AuroraShipyardUpgradeType.Retool:
            Decimal num2 = (0.5M + (Decimal) gclass193_0.int_1 * 0.25M) * this.gclass21_0.decimal_21;
            Decimal num3 = gclass193_0.gclass22_0.method_40(gclass22_0, (GClass123) null, (ListView) null);
            if (num3 == 0M)
            {
              gclass193_0.gclass22_0 = gclass22_0;
              gclass22_0.bool_3 = true;
              return;
            }
            num1 = !(num3 < gclass22_0.decimal_4) ? gclass22_0.decimal_4 * num2 : num3 * num2;
            gclass193_0.gclass22_1 = gclass22_0;
            gclass22_0.bool_3 = true;
            break;
          case AuroraShipyardUpgradeType.Continual:
            num1 = 0M;
            break;
        }
        gclass193_0.auroraShipyardUpgradeType_0 = auroraShipyardUpgradeType_0;
        gclass193_0.decimal_1 = num1;
        gclass193_0.decimal_2 = 0M;
        gclass193_0.int_2 = int_25;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2189);
    }
  }

  public void method_125(GClass193 gclass193_0)
  {
    try
    {
      Decimal num = 0M;
      switch (gclass193_0.auroraShipyardUpgradeType_0)
      {
        case AuroraShipyardUpgradeType.Add500:
          num = gclass193_0.decimal_2 / gclass193_0.decimal_1 * 500M;
          break;
        case AuroraShipyardUpgradeType.Add1000:
          num = gclass193_0.decimal_2 / gclass193_0.decimal_1 * 1000M;
          break;
        case AuroraShipyardUpgradeType.Add2000:
          num = gclass193_0.decimal_2 / gclass193_0.decimal_1 * 2000M;
          break;
        case AuroraShipyardUpgradeType.Add5000:
          num = gclass193_0.decimal_2 / gclass193_0.decimal_1 * 5000M;
          break;
        case AuroraShipyardUpgradeType.Add10000:
          num = gclass193_0.decimal_2 / gclass193_0.decimal_1 * 10000M;
          break;
      }
      gclass193_0.decimal_0 += Math.Floor(num / 100M) * 100M;
      gclass193_0.auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.None;
      gclass193_0.gclass22_1 = (GClass22) null;
      gclass193_0.decimal_1 = 0M;
      gclass193_0.decimal_2 = 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2190);
    }
  }

  public void method_126(GClass193 gclass193_0, ComboBox comboBox_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1121 class1121 = new GClass146.Class1121();
    // ISSUE: reference to a compiler-generated field
    class1121.gclass193_0 = gclass193_0;
    // ISSUE: reference to a compiler-generated field
    class1121.gclass146_0 = this;
    try
    {
      comboBox_0.DataSource = (object) null;
      List<GClass22> source = new List<GClass22>();
      // ISSUE: reference to a compiler-generated field
      if (class1121.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial)
      {
        // ISSUE: reference to a compiler-generated method
        source = this.gclass0_0.dictionary_3.Values.Where<GClass22>(new Func<GClass22, bool>(class1121.method_0)).OrderBy<GClass22, string>((Func<GClass22, string>) (gclass22_0 => gclass22_0.ClassName)).ToList<GClass22>();
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (class1121.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval)
        {
          // ISSUE: reference to a compiler-generated method
          source = this.gclass0_0.dictionary_3.Values.Where<GClass22>(new Func<GClass22, bool>(class1121.method_1)).OrderBy<GClass22, string>((Func<GClass22, string>) (gclass22_0 => gclass22_0.ClassName)).ToList<GClass22>();
        }
      }
      List<GClass22> list = source.Where<GClass22>((Func<GClass22, bool>) (gclass22_0 => !gclass22_0.method_28())).ToList<GClass22>();
      foreach (GClass22 gclass22 in list)
        gclass22.ClassNameWithHull = gclass22.method_34();
      comboBox_0.DataSource = (object) list;
      comboBox_0.DisplayMember = "ClassNameWithHull";
      if (list.Count <= 0)
        return;
      comboBox_0.SelectedItem = (object) list[0];
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2191);
    }
  }

  public void method_127(GClass193 gclass193_0, GClass22 gclass22_0, Label label_0, Label label_1)
  {
    try
    {
      if (gclass193_0.gclass22_0 != null)
      {
        if (gclass22_0 != null)
        {
          GClass123 gclass123_1 = new GClass123(this.gclass0_0);
          Decimal num1 = (0.5M + (Decimal) gclass193_0.int_1 * 0.25M) * this.gclass21_0.decimal_21;
          Decimal num2 = gclass193_0.gclass22_0.method_40(gclass22_0, gclass123_1, (ListView) null);
          Decimal decimal_73 = !(num2 < gclass22_0.decimal_4) ? gclass22_0.decimal_4 * num1 : num2 * num1;
          label_0.Text = GClass226.smethod_42(decimal_73, 1);
          Decimal num3 = decimal_73 / gclass193_0.decimal_3 * GClass226.decimal_29 / (Decimal) gclass193_0.int_1;
          label_1.Text = this.gclass0_0.method_583((double) (this.gclass0_0.decimal_0 + num3));
        }
        else
        {
          label_0.Text = "";
          label_1.Text = "";
        }
      }
      else
      {
        label_0.Text = "Free";
        label_1.Text = "Immediate";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2192);
    }
  }

  public void method_128(
    GClass193 gclass193_0,
    bool bool_10,
    bool bool_11,
    bool bool_12,
    bool bool_13,
    ComboBox comboBox_0)
  {
    try
    {
      List<GClass22> gclass22List = !bool_10 ? gclass193_0.method_9(bool_11, bool_12, bool_13) : gclass193_0.method_8();
      foreach (GClass22 gclass22 in gclass22List)
        gclass22.ClassNameWithHull = gclass22.method_34();
      if (gclass22List.Count > 0)
      {
        comboBox_0.DisplayMember = "ClassNameWithHull";
        comboBox_0.DataSource = (object) gclass22List;
        comboBox_0.SelectedItem = (object) gclass22List[0];
      }
      else
        comboBox_0.DataSource = (object) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2193);
    }
  }

  public void method_129(
    GClass22 gclass22_0,
    ComboBox comboBox_0,
    bool bool_10,
    bool bool_11,
    bool bool_12)
  {
    try
    {
      List<GClass40> gclass40List = this.method_195(gclass22_0, bool_10, bool_11, bool_12);
      foreach (GClass40 gclass40 in gclass40List)
        gclass40.ShipNameWithHull = gclass40.method_188(false, false);
      comboBox_0.DataSource = (object) null;
      comboBox_0.DisplayMember = "ShipNameWithHull";
      comboBox_0.DataSource = (object) gclass40List;
      if (gclass40List.Count <= 0)
        return;
      comboBox_0.SelectedItem = (object) gclass40List[0];
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2194);
    }
  }

  public string method_130()
  {
    try
    {
      if (this.decimal_30 > 0M)
      {
        if (this.decimal_30 > 10M)
          return $"{this.PopName}  {GClass226.smethod_39(this.decimal_30)}m";
        return this.decimal_30 > 3M ? $"{this.PopName}  {GClass226.smethod_42(this.decimal_30, 1)}m" : $"{this.PopName}  {GClass226.smethod_42(this.decimal_30, 2)}m";
      }
      if (this.decimal_72 > 0M)
        return $"{this.PopName}  {GClass226.smethod_38(this.decimal_72)}x AM";
      int int_72_1 = this.method_73(AuroraInstallationType.CivilianMiningComplex);
      if (int_72_1 > 0)
        return $"{this.PopName}  {GClass226.smethod_37(int_72_1)}x CMC";
      if (this.decimal_73 > 0M)
        return $"{this.PopName}  {GClass226.smethod_38(this.decimal_73)}x Terra";
      int int_72_2 = (int) this.method_62(AuroraProductionCategory.Sensors);
      return int_72_2 > 0 ? $"{this.PopName}  {GClass226.smethod_37(int_72_2)}x DST" : this.PopName;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2195);
      return "Error";
    }
  }

  public void method_131(ListView listView_0, bool bool_10)
  {
    try
    {
      string str = "";
      this.gclass127_0.gclass123_3.method_6();
      List<GClass193> list1 = this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass146_0 == this)).OrderBy<GClass193, AuroraShipyardType>((Func<GClass193, AuroraShipyardType>) (gclass193_0 => gclass193_0.auroraShipyardType_0)).ThenByDescending<GClass193, Decimal>((Func<GClass193, Decimal>) (gclass193_0 => gclass193_0.decimal_0)).ThenByDescending<GClass193, int>((Func<GClass193, int>) (gclass193_0 => gclass193_0.int_1)).ToList<GClass193>();
      listView_0.Items.Clear();
      this.gclass0_0.method_617(listView_0, "Name", "Type", "Capacity", "SW", "Avail", "Assigned Class", "Current Activity", "Progress", "Completion Date", "Mod Rate", (object) null);
      foreach (GClass193 gclass193 in list1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1122 class1122 = new GClass146.Class1122();
        // ISSUE: reference to a compiler-generated field
        class1122.gclass193_0 = gclass193;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (class1122.gclass193_0.gclass40_1 != null && class1122.gclass193_0.gclass40_1.gclass85_0.gclass146_0 != class1122.gclass193_0.gclass146_0)
        {
          // ISSUE: reference to a compiler-generated field
          class1122.gclass193_0.gclass146_0 = (GClass146) null;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string string_11 = class1122.gclass193_0.auroraShipyardType_0 != AuroraShipyardType.Naval ? (class1122.gclass193_0.auroraShipyardType_0 != AuroraShipyardType.Commercial ? "R" : "C") : "N";
          if (str != string_11)
          {
            this.gclass0_0.method_597(listView_0, "", "");
            str = string_11;
          }
          // ISSUE: reference to a compiler-generated field
          class1122.gclass193_0.method_6();
          // ISSUE: reference to a compiler-generated field
          string string_19 = GClass226.smethod_39(class1122.gclass193_0.decimal_3);
          // ISSUE: reference to a compiler-generated field
          if (class1122.gclass193_0.bool_0)
            string_19 = "Paused";
          string string_16;
          // ISSUE: reference to a compiler-generated field
          if (class1122.gclass193_0.gclass40_1 != null)
          {
            string_16 = "Ship-Based";
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (class1122.gclass193_0.auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.Retool)
            {
              // ISSUE: reference to a compiler-generated field
              if (class1122.gclass193_0.gclass22_1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                class1122.gclass193_0.auroraShipyardUpgradeType_0 = AuroraShipyardUpgradeType.None;
                // ISSUE: reference to a compiler-generated field
                class1122.gclass193_0.gclass22_1 = (GClass22) null;
                string_16 = "No Activity";
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                string_16 = "Retool: " + class1122.gclass193_0.gclass22_1.ClassName;
              }
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string_16 = class1122.gclass193_0.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.Continual || class1122.gclass193_0.int_2 <= 0 ? GClass226.smethod_82((Enum) class1122.gclass193_0.auroraShipyardUpgradeType_0) : $"CC Upgrade: {GClass226.smethod_37(class1122.gclass193_0.int_2)} tons";
            }
          }
          // ISSUE: reference to a compiler-generated method
          List<GClass192> list2 = this.gclass0_0.dictionary_32.Values.Where<GClass192>(new Func<GClass192, bool>(class1122.method_0)).ToList<GClass192>();
          // ISSUE: reference to a compiler-generated field
          string string_14 = (class1122.gclass193_0.int_1 - list2.Count).ToString();
          string string_18;
          string string_17;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class1122.gclass193_0.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.None && class1122.gclass193_0.auroraShipyardUpgradeType_0 != AuroraShipyardUpgradeType.Continual)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Decimal num1 = class1122.gclass193_0.decimal_1 - class1122.gclass193_0.decimal_2;
            // ISSUE: reference to a compiler-generated field
            Decimal num2 = num1 / class1122.gclass193_0.decimal_3 * GClass226.decimal_29;
            // ISSUE: reference to a compiler-generated field
            if (class1122.gclass193_0.auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.Retool)
            {
              // ISSUE: reference to a compiler-generated field
              num2 /= (Decimal) class1122.gclass193_0.int_1;
            }
            string_18 = this.gclass0_0.method_583((double) (this.gclass0_0.decimal_0 + num2));
            // ISSUE: reference to a compiler-generated field
            if (!class1122.gclass193_0.bool_0)
            {
              this.gclass127_0.gclass123_3.decimal_0 += num1 / 2M;
              this.gclass127_0.gclass123_3.decimal_1 += num1 / 2M;
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            string_17 = !(class1122.gclass193_0.decimal_1 == 0M) ? GClass226.smethod_42(class1122.gclass193_0.decimal_2 / class1122.gclass193_0.decimal_1 * 100M, 1).ToString() + "%" : "100%";
          }
          else
          {
            string_18 = "-";
            string_17 = "-";
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string string_15 = class1122.gclass193_0.gclass22_0 == null ? (class1122.gclass193_0.auroraShipyardType_0 != AuroraShipyardType.RepairYard ? "No Class Assigned" : "N/A") : $"{class1122.gclass193_0.gclass22_0.gclass76_0.Abbreviation} {class1122.gclass193_0.gclass22_0.ClassName}";
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_617(listView_0, class1122.gclass193_0.string_0, string_11, GClass226.smethod_38(class1122.gclass193_0.decimal_0), class1122.gclass193_0.int_1.ToString(), string_14, string_15, string_16, string_17, string_18, string_19, (object) class1122.gclass193_0);
        }
      }
      if (list1.Count <= 2 || !bool_10)
        return;
      listView_0.Items[2].Selected = true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2196);
    }
  }

  public void method_132(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass127_0.gclass123_0.method_6();
      this.gclass127_0.gclass123_1.method_6();
      this.gclass127_0.gclass123_2.method_6();
      this.gclass0_0.method_614(listView_0, "Type", "Project", "Amount", "Cap %", "Prod Rate", "Item Cost", "Completion Date", "Pause/Queue", (object) null);
      this.gclass0_0.method_597(listView_0, "", "");
      List<GClass156> list1 = this.dictionary_2.Values.Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.int_2 == 0)).Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.auroraProductionType_0 == AuroraProductionType.Construction || gclass156_0.auroraProductionType_0 == AuroraProductionType.SpaceStation || gclass156_0.auroraProductionType_0 == AuroraProductionType.Components)).OrderByDescending<GClass156, Decimal>((Func<GClass156, Decimal>) (gclass156_0 => gclass156_0.decimal_3)).ToList<GClass156>();
      this.method_133(listView_0, list1);
      List<GClass156> list2 = this.dictionary_2.Values.Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.int_2 == 0)).Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.auroraProductionType_0 == AuroraProductionType.Fighter)).OrderByDescending<GClass156, Decimal>((Func<GClass156, Decimal>) (gclass156_0 => gclass156_0.decimal_3)).ToList<GClass156>();
      this.method_133(listView_0, list2);
      List<GClass156> list3 = this.dictionary_2.Values.Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.int_2 == 0)).Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.auroraProductionType_0 == AuroraProductionType.Ordnance)).OrderByDescending<GClass156, Decimal>((Func<GClass156, Decimal>) (gclass156_0 => gclass156_0.decimal_3)).ToList<GClass156>();
      this.method_133(listView_0, list3);
      List<GClass156> list4 = this.dictionary_2.Values.Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.int_2 > 0)).Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.auroraProductionType_0 == AuroraProductionType.Construction || gclass156_0.auroraProductionType_0 == AuroraProductionType.SpaceStation || gclass156_0.auroraProductionType_0 == AuroraProductionType.Components)).OrderBy<GClass156, int>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)).ToList<GClass156>();
      this.method_133(listView_0, list4);
      List<GClass156> list5 = this.dictionary_2.Values.Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.int_2 > 0)).Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.auroraProductionType_0 == AuroraProductionType.Fighter)).OrderBy<GClass156, int>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)).ToList<GClass156>();
      this.method_133(listView_0, list5);
      List<GClass156> list6 = this.dictionary_2.Values.Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.int_2 > 0)).Where<GClass156>((Func<GClass156, bool>) (gclass156_0 => gclass156_0.auroraProductionType_0 == AuroraProductionType.Ordnance)).OrderBy<GClass156, int>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)).ToList<GClass156>();
      this.method_133(listView_0, list6);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2197);
    }
  }

  public void method_133(ListView listView_0, List<GClass156> list_5)
  {
    try
    {
      Decimal decimal_73 = 0M;
      Decimal num1 = 0M;
      string string_10 = "";
      string str = "";
      if (list_5.Count == 0)
        return;
      foreach (GClass156 gclass156 in list_5)
      {
        switch (gclass156.auroraProductionType_0)
        {
          case AuroraProductionType.Construction:
          case AuroraProductionType.Components:
          case AuroraProductionType.SpaceStation:
            decimal_73 = this.decimal_58 * (gclass156.decimal_3 / 100M);
            this.gclass127_0.gclass123_0.method_8(gclass156);
            string_10 = "Construction";
            str = "C";
            break;
          case AuroraProductionType.Ordnance:
            decimal_73 = this.decimal_59 * (gclass156.decimal_3 / 100M);
            this.gclass127_0.gclass123_1.method_8(gclass156);
            string_10 = "Ordnance";
            str = "O";
            break;
          case AuroraProductionType.Fighter:
            decimal_73 = this.decimal_60 * (gclass156.decimal_3 / 100M);
            this.gclass127_0.gclass123_2.method_8(gclass156);
            string_10 = "Fighter";
            str = "F";
            break;
        }
        num1 += gclass156.decimal_3;
        if (decimal_73 == 0M)
          decimal_73 = 1M;
        Decimal num2 = gclass156.decimal_2 * gclass156.decimal_0 / decimal_73 * GClass226.decimal_29;
        if (gclass156.int_2 == 0)
        {
          string string_17 = !gclass156.bool_0 ? "No" : "Yes";
          this.gclass0_0.method_614(listView_0, string_10, gclass156.string_0, GClass226.smethod_42(gclass156.decimal_0, 2), GClass226.smethod_42(gclass156.decimal_3, 2), GClass226.smethod_42(decimal_73, 1), GClass226.smethod_42(gclass156.decimal_2, 2), this.gclass0_0.method_583((double) (this.gclass0_0.decimal_0 + num2)), string_17, (object) gclass156);
        }
        else
          this.gclass0_0.method_614(listView_0, string_10, gclass156.string_0, GClass226.smethod_42(gclass156.decimal_0, 2), GClass226.smethod_42(gclass156.decimal_3, 2), "-", GClass226.smethod_42(gclass156.decimal_2, 2), "-", $"Queue {str}{gclass156.int_2.ToString()}", (object) gclass156);
      }
      if (num1 < 100M)
        this.gclass0_0.method_609(listView_0, "", "Unused " + string_10, "", GClass226.smethod_42(100M - num1, 2), (string) null);
      this.gclass0_0.method_597(listView_0, "", "");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2198);
    }
  }

  public int method_134(
    AuroraProductionCategory auroraProductionCategory_0,
    Decimal decimal_90)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1123 class1123 = new GClass146.Class1123();
    // ISSUE: reference to a compiler-generated field
    class1123.auroraProductionCategory_0 = auroraProductionCategory_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return 100M - this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1123.method_0)).Sum<GClass156>((Func<GClass156, Decimal>) (gclass156_0 => gclass156_0.decimal_3)) >= decimal_90 ? 0 : this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1123.method_1)).Max<GClass156>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)) + 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2199);
      return 0;
    }
  }

  public void method_135(GClass156 gclass156_0)
  {
    try
    {
      AuroraProductionCategory productionCategory0 = gclass156_0.auroraProductionCategory_0;
      this.dictionary_2.Remove(gclass156_0.int_0);
      this.method_137(productionCategory0);
      gclass156_0.gclass146_0 = (GClass146) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2200);
    }
  }

  public void method_136(GClass156 gclass156_0)
  {
    try
    {
      if (gclass156_0.bool_0)
        gclass156_0.bool_0 = false;
      else
        gclass156_0.bool_0 = true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2201);
    }
  }

  public void method_137(
    AuroraProductionCategory auroraProductionCategory_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1124 class1124 = new GClass146.Class1124();
    // ISSUE: reference to a compiler-generated field
    class1124.auroraProductionCategory_0 = auroraProductionCategory_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass156> list = this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1124.method_0)).OrderBy<GClass156, int>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)).ToList<GClass156>();
      int num = 1;
      foreach (GClass156 gclass156 in list)
      {
        gclass156.int_2 = num;
        ++num;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2202);
    }
  }

  public void method_138()
  {
    try
    {
      List<GClass107> list = this.list_0.OrderBy<GClass107, int>((Func<GClass107, int>) (gclass107_0 => gclass107_0.int_0)).ToList<GClass107>();
      int num = 1;
      foreach (GClass107 gclass107 in list)
      {
        gclass107.int_0 = num;
        ++num;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2202);
    }
  }

  public void method_139(
    AuroraProductionCategory auroraProductionCategory_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1125 class1125 = new GClass146.Class1125();
    // ISSUE: reference to a compiler-generated field
    class1125.auroraProductionCategory_0 = auroraProductionCategory_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      foreach (GClass156 gclass156 in this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1125.method_0)).OrderBy<GClass156, int>((Func<GClass156, int>) (gclass156_0 => gclass156_0.int_2)).ToList<GClass156>())
        ++gclass156.int_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2203);
    }
  }

  public void method_140(GClass156 gclass156_0_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1126 class1126 = new GClass146.Class1126();
    // ISSUE: reference to a compiler-generated field
    class1126.gclass156_0 = gclass156_0_1;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (class1126.gclass156_0.int_2 == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      if (class1126.gclass156_0.int_2 == 1)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        if (100M - this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1126.method_0)).Sum<GClass156>((Func<GClass156, Decimal>) (gclass156_0_2 => gclass156_0_2.decimal_3)) < class1126.gclass156_0.decimal_3)
        {
          int num = (int) MessageBox.Show("There is insufficient available capacity to move this project to the top of the queue", "Change Not Possible");
          return;
        }
        // ISSUE: reference to a compiler-generated field
        class1126.gclass156_0.int_2 = 0;
        // ISSUE: reference to a compiler-generated field
        this.method_137(class1126.gclass156_0.auroraProductionCategory_0);
      }
      // ISSUE: reference to a compiler-generated field
      if (class1126.gclass156_0.int_2 <= 1)
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass146.Class1127 class1127 = new GClass146.Class1127()
      {
        class1126_0 = class1126
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class1127.int_0 = class1127.class1126_0.gclass156_0.int_2 - 1;
      // ISSUE: reference to a compiler-generated method
      List<GClass156> list = this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1127.method_0)).ToList<GClass156>();
      if (list.Count != 1)
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      list[0].int_2 = class1127.class1126_0.gclass156_0.int_2;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class1127.class1126_0.gclass156_0.int_2 = class1127.int_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2204);
    }
  }

  public void method_141(GClass156 gclass156_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1128 class1128 = new GClass146.Class1128();
    // ISSUE: reference to a compiler-generated field
    class1128.gclass156_0 = gclass156_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (class1128.gclass156_0.int_2 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1128.int_0 = class1128.gclass156_0.int_2 + 1;
        // ISSUE: reference to a compiler-generated method
        List<GClass156> list = this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1128.method_0)).ToList<GClass156>();
        if (list.Count != 1)
          return;
        // ISSUE: reference to a compiler-generated field
        list[0].int_2 = class1128.gclass156_0.int_2;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1128.gclass156_0.int_2 = class1128.int_0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.method_139(class1128.gclass156_0.auroraProductionCategory_0);
        // ISSUE: reference to a compiler-generated field
        class1128.gclass156_0.int_2 = 1;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2205);
    }
  }

  public void method_142(GClass156 gclass156_0_1, Decimal decimal_90, Decimal decimal_91)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1129 class1129 = new GClass146.Class1129();
    // ISSUE: reference to a compiler-generated field
    class1129.gclass156_0 = gclass156_0_1;
    try
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      if (class1129.gclass156_0.int_2 == 0 && 100M - this.dictionary_2.Values.Where<GClass156>(new Func<GClass156, bool>(class1129.method_0)).Sum<GClass156>((Func<GClass156, Decimal>) (gclass156_0_2 => gclass156_0_2.decimal_3)) < decimal_91)
      {
        int num = (int) MessageBox.Show("This modification would result in a total percentage for this factory type greater than 100%", "Modification Not Possible");
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class1129.gclass156_0.decimal_0 = decimal_90;
        // ISSUE: reference to a compiler-generated field
        class1129.gclass156_0.decimal_3 = decimal_91;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2206);
    }
  }

  public void method_143(Decimal decimal_90, Decimal decimal_91)
  {
    try
    {
      GClass156 gclass156 = new GClass156(this.gclass0_0);
      gclass156.gclass146_0 = this;
      gclass156.gclass21_0 = this.gclass21_0;
      gclass156.gclass194_0 = this.gclass194_0;
      gclass156.gclass123_0 = this.gclass123_5;
      gclass156.int_1 = (int) this.decimal_82;
      gclass156.auroraProductionType_0 = this.auroraProductionType_0;
      gclass156.bool_0 = false;
      gclass156.decimal_0 = decimal_90;
      gclass156.decimal_3 = decimal_91;
      gclass156.decimal_2 = this.decimal_81;
      switch (this.auroraProductionType_0)
      {
        case AuroraProductionType.Construction:
          gclass156.gclass157_0 = (GClass157) this.object_0;
          gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Construction;
          gclass156.gclass150_0 = this.gclass0_0.dictionary_45[GEnum84.const_3];
          gclass156.string_0 = gclass156.gclass157_0.Name;
          break;
        case AuroraProductionType.Ordnance:
          gclass156.gclass129_0 = (GClass129) this.object_0;
          gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Ordnance;
          gclass156.gclass150_0 = this.gclass0_0.dictionary_45[GEnum84.const_1];
          gclass156.string_0 = gclass156.gclass129_0.Name;
          break;
        case AuroraProductionType.Fighter:
          gclass156.gclass22_0 = (GClass22) this.object_0;
          gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Fighter;
          gclass156.gclass150_0 = this.gclass0_0.dictionary_45[GEnum84.const_2];
          gclass156.string_0 = gclass156.gclass22_0.ClassName;
          gclass156.gclass22_0.bool_3 = true;
          break;
        case AuroraProductionType.Components:
          gclass156.gclass230_0 = (GClass230) this.object_0;
          gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Construction;
          gclass156.gclass150_0 = this.gclass0_0.dictionary_45[GEnum84.const_20];
          gclass156.string_0 = gclass156.gclass230_0.Name;
          break;
        case AuroraProductionType.SpaceStation:
          gclass156.gclass22_0 = (GClass22) this.object_0;
          if (!gclass156.gclass22_0.method_29(this))
          {
            int num = (int) MessageBox.Show("A space station cannot be built if it contains alien components that are not available in the population stockpile", "Task Not Possible");
            return;
          }
          if (gclass156.gclass22_0.method_28())
          {
            int num = (int) MessageBox.Show("A space station cannot be built if it contains prototype components", "Task Not Possible");
            return;
          }
          gclass156.gclass22_0.bool_3 = true;
          gclass156.auroraProductionCategory_0 = AuroraProductionCategory.Construction;
          gclass156.gclass150_0 = this.gclass0_0.dictionary_45[GEnum84.const_24];
          gclass156.string_0 = gclass156.gclass22_0.method_34();
          break;
      }
      gclass156.int_0 = this.gclass0_0.method_26(GEnum0.const_26);
      gclass156.int_2 = this.method_134(gclass156.auroraProductionCategory_0, gclass156.decimal_3);
      this.dictionary_2.Add(gclass156.int_0, gclass156);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2207);
    }
  }

  public void method_144()
  {
    try
    {
      this.decimal_13 = this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval && gclass193_0.gclass146_0 == this)).Sum<GClass193>((Func<GClass193, Decimal>) (gclass193_0 => (Decimal) gclass193_0.int_1 * gclass193_0.decimal_0));
      this.decimal_14 = this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial && gclass193_0.gclass146_0 == this)).Sum<GClass193>((Func<GClass193, Decimal>) (gclass193_0 => (Decimal) gclass193_0.int_1 * gclass193_0.decimal_0));
      this.decimal_15 = this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.auroraShipyardType_0 == AuroraShipyardType.RepairYard && gclass193_0.gclass146_0 == this)).Sum<GClass193>((Func<GClass193, Decimal>) (gclass193_0 => (Decimal) gclass193_0.int_1 * gclass193_0.decimal_0));
      this.int_15 = this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass146_0 == this)).Sum<GClass193>((Func<GClass193, int>) (gclass193_0 => gclass193_0.int_1));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2208);
    }
  }

  public void method_145()
  {
    try
    {
      this.decimal_72 = (Decimal) this.method_202(AuroraComponentType.OrbitalMiningModule);
      this.decimal_73 = (Decimal) this.method_202(AuroraComponentType.TerraformingModule);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2209);
    }
  }

  public void method_146()
  {
    try
    {
      this.decimal_5 = 1M;
      this.decimal_56 = this.method_204();
      foreach (GClass158 gclass158 in this.dictionary_0.Values)
        this.decimal_56 += gclass158.decimal_0 * gclass158.gclass157_0.decimal_22;
      if (this.decimal_56 == 0M)
      {
        this.decimal_5 = 1M;
      }
      else
      {
        if (this.decimal_56 > this.decimal_52)
          this.decimal_5 = this.decimal_52 / this.decimal_56;
        if (!(this.decimal_5 < 0M))
          return;
        this.decimal_5 = 0M;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2210);
    }
  }

  public Decimal method_147()
  {
    try
    {
      this.decimal_56 = 0M;
      this.decimal_56 += this.method_204();
      foreach (GClass158 gclass158 in this.dictionary_0.Values)
        this.decimal_56 += gclass158.decimal_0 * gclass158.gclass157_0.decimal_22;
      return this.decimal_52 - this.decimal_56;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2211);
      return 0M;
    }
  }

  public void method_148(GClass40 gclass40_0)
  {
    try
    {
      foreach (GClass130 gclass130 in gclass40_0.list_10)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1130 class1130 = new GClass146.Class1130();
        // ISSUE: reference to a compiler-generated field
        class1130.gclass130_0 = gclass130;
        // ISSUE: reference to a compiler-generated method
        List<GClass130> list = this.list_1.Where<GClass130>(new Func<GClass130, bool>(class1130.method_0)).ToList<GClass130>();
        if (list.Count > 0)
        {
          // ISSUE: reference to a compiler-generated field
          list[0].int_0 += class1130.gclass130_0.int_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.list_1.Add(new GClass130()
          {
            gclass129_0 = class1130.gclass130_0.gclass129_0,
            int_0 = class1130.gclass130_0.int_0
          });
        }
      }
      if (gclass40_0.gclass22_0.list_0.Count == 0)
        return;
      gclass40_0.list_10.Clear();
      List<GClass130> gclass130List = gclass40_0.gclass22_0.list_0;
      if (gclass40_0.list_9.Count > 0)
        gclass130List = gclass40_0.list_9;
      foreach (GClass130 gclass130_1 in gclass130List)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1131 class1131 = new GClass146.Class1131();
        // ISSUE: reference to a compiler-generated field
        class1131.gclass130_0 = gclass130_1;
        // ISSUE: reference to a compiler-generated method
        List<GClass130> list = this.list_1.Where<GClass130>(new Func<GClass130, bool>(class1131.method_0)).ToList<GClass130>();
        if (list.Count > 0)
        {
          GClass130 gclass130_2 = new GClass130();
          // ISSUE: reference to a compiler-generated field
          gclass130_2.gclass129_0 = class1131.gclass130_0.gclass129_0;
          // ISSUE: reference to a compiler-generated field
          if (list[0].int_0 > class1131.gclass130_0.int_0)
          {
            // ISSUE: reference to a compiler-generated field
            gclass130_2.int_0 = class1131.gclass130_0.int_0;
            list[0].int_0 -= gclass130_2.int_0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (list[0].int_0 == class1131.gclass130_0.int_0)
            {
              // ISSUE: reference to a compiler-generated field
              gclass130_2.int_0 = class1131.gclass130_0.int_0;
              this.list_1.Remove(list[0]);
            }
            else
            {
              gclass130_2.int_0 = list[0].int_0;
              this.list_1.Remove(list[0]);
            }
          }
          gclass40_0.list_10.Add(gclass130_2);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2212);
    }
  }

  public void method_149(GClass129 gclass129_0, int int_25)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1132 class1132 = new GClass146.Class1132();
    // ISSUE: reference to a compiler-generated field
    class1132.gclass129_0 = gclass129_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass130> list = this.list_1.Where<GClass130>(new Func<GClass130, bool>(class1132.method_0)).ToList<GClass130>();
      if (list.Count > 0)
      {
        list[0].int_0 += int_25;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.list_1.Add(new GClass130()
        {
          gclass129_0 = class1132.gclass129_0,
          int_0 = int_25
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2213);
    }
  }

  public GClass193 method_150(AuroraShipyardType auroraShipyardType_0)
  {
    try
    {
      GClass193 gclass193 = new GClass193(this.gclass0_0);
      gclass193.int_0 = this.gclass0_0.method_26(GEnum0.const_1);
      gclass193.gclass21_0 = this.gclass21_0;
      gclass193.gclass146_0 = this;
      gclass193.auroraShipyardType_0 = auroraShipyardType_0;
      gclass193.int_1 = 1;
      gclass193.double_0 = 0.0;
      gclass193.double_1 = 0.0;
      gclass193.bool_0 = false;
      gclass193.decimal_1 = 0M;
      gclass193.decimal_2 = 0M;
      gclass193.decimal_0 = 1000M;
      if (auroraShipyardType_0 == AuroraShipyardType.Commercial || auroraShipyardType_0 == AuroraShipyardType.RepairYard)
        gclass193.decimal_0 = 10000M;
      gclass193.string_0 = this.method_151();
      this.gclass0_0.dictionary_31.Add(gclass193.int_0, gclass193);
      return gclass193;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2214);
      return (GClass193) null;
    }
  }

  public string method_151()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass146.Class1133 class1133 = new GClass146.Class1133();
      // ISSUE: reference to a compiler-generated field
      class1133.gclass58_0 = this.gclass21_0.method_116();
      // ISSUE: reference to a compiler-generated method
      List<GClass57> list = this.gclass0_0.list_14.Where<GClass57>(new Func<GClass57, bool>(class1133.method_0)).ToList<GClass57>();
      if (list.Count == 0)
      {
        // ISSUE: reference to a compiler-generated method
        list = this.gclass0_0.list_14.Where<GClass57>(new Func<GClass57, bool>(class1133.method_1)).ToList<GClass57>();
      }
      if (list.Count == 0)
        list = this.gclass0_0.list_14.ToList<GClass57>();
      int num = GClass226.smethod_13(list.Count);
      return $"{list[num - 1].string_0} {this.gclass0_0.list_17[GClass226.smethod_13(this.gclass0_0.list_17.Count) - 1]}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2215);
      return "No Name";
    }
  }

  public void method_152()
  {
    try
    {
      this.method_189();
      this.int_17 = (int) Math.Ceiling(this.decimal_16 / 5000M);
      if (this.int_17 <= 5)
        return;
      this.int_17 = 5;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2216);
    }
  }

  public void method_153(
    ListView listView_0,
    ComboBox comboBox_0,
    ComboBox comboBox_1,
    ComboBox comboBox_2,
    RadioButton radioButton_0,
    RadioButton radioButton_1,
    RadioButton radioButton_2,
    TextBox textBox_0)
  {
    try
    {
      listView_0.Items.Clear();
      if (this.gclass55_0 == null)
      {
        this.gclass0_0.method_601(listView_0, "Current Governor", "None", (string) null);
      }
      else
      {
        this.gclass0_0.method_601(listView_0, "Current Governor", this.gclass55_0.string_0, (string) null);
        string string_11 = "Unknown";
        if (this.gclass55_0.gclass146_2 != null)
        {
          string_11 = this.gclass55_0.gclass146_2.PopName;
          if (this.gclass55_0.gclass146_2.string_1 != "")
            string_11 = this.gclass55_0.gclass146_2.string_1;
        }
        this.gclass0_0.method_597(listView_0, "University", string_11);
        this.gclass0_0.method_597(listView_0, "Age and Health", $"{this.gclass55_0.method_13().ToString()} / {this.gclass55_0.method_15()}");
        this.gclass0_0.method_597(listView_0, "Career Start Date", this.gclass0_0.method_583((double) this.gclass55_0.decimal_2));
        this.gclass0_0.method_594(listView_0, "");
        this.gclass55_0.method_30(listView_0, false);
        if (this.gclass55_0.dictionary_2.Count > 0)
        {
          this.gclass0_0.method_594(listView_0, "");
          this.gclass55_0.method_20(listView_0);
        }
      }
      if (this.method_73(AuroraInstallationType.MilitaryAcademy) > 0)
      {
        this.gclass0_0.method_594(listView_0, "");
        GClass55 gclass55 = this.method_82();
        if (gclass55 == null)
        {
          this.gclass0_0.method_601(listView_0, "Academy Commandant", "None", (string) null);
        }
        else
        {
          this.gclass0_0.method_601(listView_0, "Academy Commandant", gclass55.string_0, (string) null);
          string string_11 = "Unknown";
          if (gclass55.gclass146_2 != null)
          {
            string_11 = gclass55.gclass146_2.PopName;
            if (gclass55.gclass146_2.string_1 != "")
              string_11 = gclass55.gclass146_2.string_1;
          }
          this.gclass0_0.method_597(listView_0, "Commander Type", GClass226.smethod_82((Enum) gclass55.auroraCommanderType_0));
          this.gclass0_0.method_597(listView_0, "University", string_11);
          this.gclass0_0.method_597(listView_0, "Age and Health", $"{gclass55.method_13().ToString()} / {gclass55.method_15()}");
          this.gclass0_0.method_597(listView_0, "Career Start Date", this.gclass0_0.method_583((double) gclass55.decimal_2));
          this.gclass0_0.method_594(listView_0, "");
          if (gclass55.auroraCommanderType_0 == AuroraCommanderType.Scientist)
            this.gclass0_0.method_597(listView_0, "Research Field", gclass55.gclass162_0.FieldName);
          gclass55.method_30(listView_0, false);
          if (gclass55.dictionary_2.Count > 0)
          {
            this.gclass0_0.method_594(listView_0, "");
            gclass55.method_20(listView_0);
          }
        }
      }
      this.gclass0_0.bool_9 = true;
      comboBox_0.SelectedItem = (object) this.gclass0_0.dictionary_62[this.genum121_0];
      comboBox_1.SelectedItem = (object) this.gclass0_0.dictionary_62[this.genum121_1];
      comboBox_2.SelectedItem = (object) this.gclass0_0.dictionary_62[this.genum121_2];
      textBox_0.Text = this.int_0.ToString();
      if (this.genum64_0 == GEnum64.const_1)
        radioButton_1.Checked = true;
      else if (this.genum64_0 == GEnum64.const_0)
        radioButton_0.Checked = true;
      else if (this.genum64_0 == GEnum64.const_2)
        radioButton_2.Checked = true;
      this.gclass0_0.bool_9 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3314);
    }
  }

  public void method_154()
  {
    try
    {
      this.method_152();
      List<GClass55> list = this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass21_0 == this.gclass21_0 && gclass55_1.auroraCommanderType_0 == AuroraCommanderType.Administrator && gclass55_1.gclass146_1 == null && gclass55_1.gclass62_0 == null && gclass55_1.gclass146_3 == null)).Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.method_5(GEnum121.const_21) >= (Decimal) this.int_17 && gclass55_1.dictionary_0.ContainsKey(this.genum121_0))).ToList<GClass55>();
      if (list.Count == 0)
        return;
      GClass55 gclass55 = list.OrderByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_1 => gclass55_1.method_5(this.genum121_0))).ThenByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_1 => gclass55_1.method_5(this.genum121_1))).ThenByDescending<GClass55, Decimal>((Func<GClass55, Decimal>) (gclass55_1 => gclass55_1.method_5(this.genum121_2))).FirstOrDefault<GClass55>();
      gclass55.method_40(false);
      if (this.gclass55_0 != null)
        this.gclass55_0.method_40(true);
      gclass55.gclass146_1 = this;
      gclass55.auroraCommandType_0 = AuroraCommandType.Colony;
      gclass55.gclass146_0 = this;
      gclass55.decimal_1 = this.gclass0_0.decimal_0;
      this.gclass55_0 = gclass55;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_78, $"{gclass55.method_36()} assigned as governor of {this.PopName}", gclass55.gclass21_0, this.gclass202_0.gclass200_0, this.method_87(), this.method_88(), AuroraEventCategory.Commander);
      gclass55.method_46("Assigned to " + this.PopName, GEnum28.const_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3321);
    }
  }

  public void method_155(
    ListView listView_0,
    ListView listView_1,
    ListView listView_2,
    Label label_0,
    Label label_1,
    ComboBox comboBox_0,
    ComboBox comboBox_1,
    ComboBox comboBox_2,
    ComboBox comboBox_3,
    ComboBox comboBox_4,
    Label label_2,
    Label label_3,
    Label label_4,
    Button button_0,
    Button button_1,
    Button button_2,
    ComboBox comboBox_5,
    CheckBox checkBox_0,
    TextBox textBox_0,
    Label label_5)
  {
    try
    {
      GClass55 gclass55 = this.method_83();
      List<GClass146> list1 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass1_0 == this.gclass1_0)).ToList<GClass146>();
      this.gclass1_0.decimal_2 = 0M;
      foreach (GClass146 gclass146 in list1)
      {
        gclass146.method_182();
        gclass146.gclass1_0.decimal_2 += gclass146.decimal_4;
      }
      this.gclass1_0.method_58(this.gclass21_0, this.gclass194_0, true);
      this.decimal_18 = this.gclass1_0.decimal_0;
      this.decimal_19 = this.gclass1_0.decimal_1;
      this.decimal_12 = this.decimal_19 + 2M;
      this.method_184();
      this.method_187();
      this.method_188(1M, false);
      this.method_181();
      this.method_180();
      this.method_146();
      this.method_179();
      this.method_144();
      this.method_145();
      this.method_89();
      this.method_90();
      this.method_96();
      this.method_176(false);
      this.method_93();
      this.method_99();
      this.method_91();
      this.method_189();
      this.method_190();
      this.method_98();
      this.method_101();
      this.method_95();
      if (this.decimal_4 > 10M && !this.bool_0 && !this.gclass21_0.bool_0)
      {
        this.method_179();
        if (this.decimal_28 < this.decimal_70)
          this.decimal_12 += (1M - this.decimal_28 / this.decimal_70) * 10M;
      }
      this.gclass127_0 = new GClass127(this.gclass0_0);
      this.gclass127_0.gclass123_0 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_1 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_2 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_3 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_4 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_5 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_6 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_7 = new GClass123(this.gclass0_0);
      this.gclass127_0.gclass123_8 = new GClass123(this.gclass0_0);
      if (this.gclass55_0 != null)
        label_0.Text = $"{this.gclass55_0.string_0}   {this.gclass55_0.method_29(false)}";
      else
        label_0.Text = "None";
      if (gclass55 != null)
        label_1.Text = $"{gclass55.string_0}   {gclass55.method_29(false)}";
      else
        label_1.Text = "None";
      if (this.gclass223_0 != null)
        comboBox_5.SelectedItem = (object) this.gclass223_0;
      checkBox_0.CheckState = this.genum31_0 != GEnum31.const_1 ? CheckState.Unchecked : CheckState.Checked;
      textBox_0.Text = this.double_0.ToString();
      string str1 = "Fuel Refinery Capacity  " + GClass226.smethod_37((int) this.method_62(AuroraProductionCategory.Refinery));
      string str2;
      if (this.bool_2)
      {
        str2 = $"{str1}        Annual Production  {GClass226.smethod_42(this.decimal_61 / 1000000M, 2)}m";
        button_0.Text = "Stop";
        this.gclass127_0.gclass123_6.decimal_7 = this.decimal_61 / (Decimal) GClass226.int_28;
      }
      else
      {
        str2 = str1 + "        Annual Production  0m";
        button_0.Text = "Start";
      }
      string str3 = $"{str2}        Fuel Reserves  {GClass226.smethod_42(this.decimal_3 / 1000000M, 2)}m";
      label_2.Text = str3;
      string str4 = "Genetic Modification Centres  " + GClass226.smethod_37((int) this.method_62(AuroraProductionCategory.GeneticModification));
      string str5;
      if (this.bool_3)
      {
        str5 = $"{str4}        Annual Modification Rate  {GClass226.smethod_42(this.decimal_68, 2)}m";
        button_2.Text = "Stop";
      }
      else
      {
        str5 = str4 + "        Annual Modification Rate  0m";
        button_2.Text = "Start";
      }
      label_4.Text = str5;
      this.int_22 = (int) this.method_62(AuroraProductionCategory.MaintenanceFacility);
      this.decimal_77 = this.method_62(AuroraProductionCategory.MaintenanceFacility) * this.gclass21_0.decimal_22 * this.decimal_5 * this.decimal_31 * this.decimal_33 * this.gclass160_0.decimal_0 * this.gclass21_0.EconomicProdModifier;
      string str6 = "Maintenance Facilities  " + GClass226.smethod_37(this.int_22);
      string str7;
      if (this.bool_4)
      {
        str7 = $"{str6}        Annual Production  {GClass226.smethod_39(this.decimal_62)} MSP";
        button_1.Text = "Stop";
        this.gclass127_0.gclass123_7.decimal_0 = this.decimal_62 * GClass226.decimal_9;
        this.gclass127_0.gclass123_7.decimal_8 = this.decimal_62 * GClass226.decimal_10;
        this.gclass127_0.gclass123_7.decimal_10 = this.decimal_62 * GClass226.decimal_11;
      }
      else
      {
        str7 = str6 + "        Annual Production  0 MSP";
        button_1.Text = "Start";
      }
      string str8 = $"{str7}        Maintenance Stockpile  {GClass226.smethod_38(this.decimal_0)} MSP";
      label_3.Text = str8;
      listView_0.Items.Clear();
      this.gclass0_0.method_597(listView_0, "Political Status", this.gclass160_0.string_0);
      this.gclass0_0.method_597(listView_0, "Species (Surface)", this.gclass194_0.SpeciesName);
      if (this.decimal_18 == -1M)
        this.gclass0_0.method_597(listView_0, "Planetary Suitability (Colony Cost)", "Not Habitable");
      else if (this.gclass1_0.double_7 < this.gclass194_0.double_7)
        this.gclass0_0.method_597(listView_0, "Planetary Suitability (Colony Cost)", GClass226.smethod_45(this.decimal_18, 4) + " LG");
      else
        this.gclass0_0.method_597(listView_0, "Planetary Suitability (Colony Cost)", GClass226.smethod_45(this.decimal_18, 4));
      if (this.decimal_19 > this.decimal_18)
      {
        if (this.gclass1_0.double_7 < this.gclass194_0.double_7)
          this.gclass0_0.method_597(listView_0, "Maximum Colony Cost", GClass226.smethod_45(this.decimal_19, 4) + " LG");
        else
          this.gclass0_0.method_597(listView_0, "Maximum Colony Cost", GClass226.smethod_45(this.decimal_19, 4));
      }
      if (this.gclass1_0.bool_2)
        this.gclass0_0.method_597(listView_0, "Dominant Planetary Terrain", "Deep Space Pop");
      else
        this.gclass0_0.method_597(listView_0, "Dominant Planetary Terrain", this.gclass1_0.gclass99_0.Name);
      this.method_152();
      this.gclass0_0.method_597(listView_0, "Administration Level Required", this.int_17.ToString());
      if (this.gclass202_0.gclass62_0 != null)
        this.gclass0_0.method_597(listView_0, "Parent Sector", this.gclass202_0.gclass62_0.SectorName);
      string[] strArray1 = new string[5]
      {
        "Radiation   -",
        null,
        null,
        null,
        null
      };
      Decimal num1 = Math.Round(100M - this.decimal_31 * 100M, 1);
      strArray1[1] = num1.ToString();
      strArray1[2] = "% Industry  -";
      strArray1[3] = GClass226.smethod_42(this.decimal_32, 1);
      strArray1[4] = "% Growth";
      string string_10_1 = string.Concat(strArray1);
      if (this.gclass1_0.decimal_3 > 1000M)
      {
        string[] strArray2 = new string[5]
        {
          "Radiation   -",
          null,
          null,
          null,
          null
        };
        num1 = Math.Round(100M - this.decimal_31 * 100M, 0);
        strArray2[1] = num1.ToString();
        strArray2[2] = "% Industry  -";
        strArray2[3] = GClass226.smethod_42(this.decimal_32, 1);
        strArray2[4] = "% Growth";
        string_10_1 = string.Concat(strArray2);
      }
      if (this.gclass1_0.decimal_3 > 0M)
        this.gclass0_0.method_597(listView_0, string_10_1, GClass226.smethod_39(this.gclass1_0.decimal_3));
      if (this.gclass1_0.decimal_4 > 0M)
      {
        GClass0 gclass00 = this.gclass0_0;
        ListView listView_0_1 = listView_0;
        num1 = Math.Round(this.gclass1_0.decimal_4 / 100M, 1);
        string string_10_2 = $"Atmospheric Dust   (Temp -{num1.ToString()} deg)";
        string string_11 = GClass226.smethod_39(this.gclass1_0.decimal_4);
        gclass00.method_597(listView_0_1, string_10_2, string_11);
      }
      this.gclass0_0.method_597(listView_0, "", "");
      if (this.decimal_41 > 0M)
        this.gclass0_0.method_597(listView_0, "Annual Worker Taxes", GClass226.smethod_39(this.decimal_41).ToString());
      if (this.decimal_40 > 0M)
        this.gclass0_0.method_597(listView_0, "Annual Financial Centre Value", GClass226.smethod_39(this.decimal_40).ToString());
      this.gclass0_0.method_597(listView_0, "", "");
      if (this.decimal_30 > 0M)
      {
        if (this.decimal_4 > 0M && this.decimal_29 == 0M)
        {
          GClass0 gclass00 = this.gclass0_0;
          ListView listView_0_2 = listView_0;
          num1 = Math.Round(this.decimal_4, 2);
          string string_11 = num1.ToString() + "m";
          gclass00.method_597(listView_0_2, "Population", string_11);
        }
        else if (this.decimal_4 == 0M && this.decimal_29 > 0M)
        {
          GClass0 gclass00 = this.gclass0_0;
          ListView listView_0_3 = listView_0;
          num1 = Math.Round(this.decimal_29, 2);
          string string_11 = num1.ToString() + "m";
          gclass00.method_597(listView_0_3, "Orbital Population", string_11);
        }
        else
        {
          GClass0 gclass00_1 = this.gclass0_0;
          ListView listView_0_4 = listView_0;
          num1 = Math.Round(this.decimal_4, 2);
          string string_11_1 = num1.ToString() + "m";
          gclass00_1.method_597(listView_0_4, "Surface Population", string_11_1);
          GClass0 gclass00_2 = this.gclass0_0;
          ListView listView_0_5 = listView_0;
          num1 = Math.Round(this.decimal_29, 2);
          string string_11_2 = num1.ToString() + "m";
          gclass00_2.method_597(listView_0_5, "Orbital Population", string_11_2);
          GClass0 gclass00_3 = this.gclass0_0;
          ListView listView_0_6 = listView_0;
          num1 = Math.Round(this.decimal_30, 2);
          string string_11_3 = num1.ToString() + "m";
          gclass00_3.method_597(listView_0_6, "Total Population", string_11_3);
        }
      }
      else
        this.gclass0_0.method_597(listView_0, "Population", "0");
      int int_72 = 2;
      if (this.decimal_30 > 20M)
        int_72 = 1;
      if (this.decimal_30 > 100M)
        int_72 = 0;
      if (this.decimal_18 == this.decimal_19)
      {
        GClass0 gclass00_4 = this.gclass0_0;
        ListView listView_0_7 = listView_0;
        num1 = Math.Round(this.decimal_42 * 100M, 1);
        string string_10_3 = $"   Agriculture / Environmental ({num1.ToString()}%)";
        string string_11_4 = GClass226.smethod_42(this.decimal_48, 2) + "m";
        gclass00_4.method_597(listView_0_7, string_10_3, string_11_4);
        GClass0 gclass00_5 = this.gclass0_0;
        ListView listView_0_8 = listView_0;
        num1 = Math.Round(this.decimal_44 * 100M, 1);
        string string_10_4 = $"   Service Industries ({num1.ToString()}%)";
        string string_11_5 = GClass226.smethod_42(this.decimal_50, 2) + "m";
        gclass00_5.method_597(listView_0_8, string_10_4, string_11_5);
        GClass0 gclass00_6 = this.gclass0_0;
        ListView listView_0_9 = listView_0;
        num1 = Math.Round(this.decimal_46 * 100M, 1);
        string string_10_5 = $"   Manufacturing ({num1.ToString()}%)";
        string string_11_6 = GClass226.smethod_42(this.decimal_52, 2) + "m";
        gclass00_6.method_597(listView_0_9, string_10_5, string_11_6);
      }
      else
      {
        GClass0 gclass00_7 = this.gclass0_0;
        ListView listView_0_10 = listView_0;
        num1 = Math.Round(this.decimal_42 * 100M, 1);
        string string_10_6 = $"   Agriculture / Environmental ({num1.ToString()}%)";
        string string_11_7 = $"{GClass226.smethod_42(this.decimal_48, int_72)}m / {GClass226.smethod_42(this.decimal_49, int_72)}m";
        gclass00_7.method_597(listView_0_10, string_10_6, string_11_7);
        if (this.decimal_50 == this.decimal_51)
        {
          GClass0 gclass00_8 = this.gclass0_0;
          ListView listView_0_11 = listView_0;
          num1 = Math.Round(this.decimal_44 * 100M, 1);
          string string_10_7 = $"   Service Industries ({num1.ToString()}%)";
          string string_11_8 = GClass226.smethod_42(this.decimal_50, int_72) + "m";
          gclass00_8.method_597(listView_0_11, string_10_7, string_11_8);
        }
        else
        {
          GClass0 gclass00_9 = this.gclass0_0;
          ListView listView_0_12 = listView_0;
          num1 = Math.Round(this.decimal_44 * 100M, 1);
          string string_10_8 = $"   Service Industries ({num1.ToString()}%)";
          string string_11_9 = $"{GClass226.smethod_42(this.decimal_50, int_72)}m / {GClass226.smethod_42(this.decimal_51, int_72)}m";
          gclass00_9.method_597(listView_0_12, string_10_8, string_11_9);
        }
        GClass0 gclass00_10 = this.gclass0_0;
        ListView listView_0_13 = listView_0;
        num1 = Math.Round(this.decimal_46 * 100M, 1);
        string string_10_9 = $"   Manufacturing ({num1.ToString()}%)";
        string string_11_10 = $"{GClass226.smethod_42(this.decimal_52, int_72)}m / {GClass226.smethod_42(this.decimal_53, int_72)}m";
        gclass00_10.method_597(listView_0_13, string_10_9, string_11_10);
      }
      if (this.decimal_4 > 0M)
        this.gclass0_0.method_597(listView_0, "Annual Growth Rate (Surface)", GClass226.smethod_42(this.decimal_35 * 100M, 2) + "%");
      this.gclass0_0.method_597(listView_0, "", "");
      Decimal object_1 = this.method_62(AuroraProductionCategory.Infrastructure);
      if (this.decimal_18 == -1M)
      {
        this.gclass0_0.method_595(listView_0, "Current Infrastructure", (object) object_1);
        this.gclass0_0.method_597(listView_0, "Infrastructure per Million Population", "N/A");
        this.gclass0_0.method_597(listView_0, "Supported Population", "N/A");
      }
      else if (this.decimal_18 == 0M && this.decimal_19 == 0M)
      {
        this.gclass0_0.method_595(listView_0, "Current Infrastructure", (object) object_1);
        this.gclass0_0.method_597(listView_0, "Infrastructure per Million Population", "0");
        this.gclass0_0.method_597(listView_0, "Supported Population ", "No Maximum");
      }
      else
      {
        string string_11_11;
        string string_11_12;
        if (this.decimal_18 == 0M)
        {
          string_11_11 = "0";
          string_11_12 = "No Max";
        }
        else
        {
          string_11_11 = this.decimal_54.ToString();
          string_11_12 = GClass226.smethod_42(this.decimal_37, int_72).ToString() + "m";
        }
        string str9 = this.decimal_55.ToString();
        string str10 = GClass226.smethod_42(this.decimal_36, int_72).ToString() + "m";
        this.gclass0_0.method_595(listView_0, "Current Infrastructure", (object) object_1);
        if (this.decimal_19 > this.decimal_18)
          this.gclass0_0.method_597(listView_0, "Infrastructure per Million (Current / Max)", $"{string_11_11} / {str9}");
        else
          this.gclass0_0.method_597(listView_0, "Infrastructure per Million", string_11_11);
        if (this.decimal_37 == 0M && this.decimal_36 == 0M)
          this.gclass0_0.method_597(listView_0, "Supported Population", "0");
        else if (this.decimal_19 > this.decimal_18)
          this.gclass0_0.method_597(listView_0, "Supported Population (Current / Min)", $"{string_11_12} / {str10}");
        else
          this.gclass0_0.method_597(listView_0, "Supported Population", string_11_12);
      }
      this.decimal_56 = 0M;
      this.gclass0_0.method_597(listView_0, "", "");
      this.gclass0_0.method_597(listView_0, "Manufacturing Sector Breakdown", "");
      Dictionary<string, Decimal> source = new Dictionary<string, Decimal>();
      List<GClass193> gclass193List = this.method_85();
      if (gclass193List.Count > 0)
      {
        this.decimal_56 += this.method_204();
        source.Add("Shipyard Workers", this.decimal_56);
      }
      foreach (GClass158 gclass158 in this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.decimal_22 > 0M)).OrderBy<GClass158, Decimal>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.gclass157_0.decimal_20)).ToList<GClass158>())
      {
        Decimal num2 = gclass158.gclass157_0.decimal_22 * gclass158.decimal_0;
        this.decimal_56 += num2;
        if (source.ContainsKey(gclass158.gclass157_0.string_1))
          source[gclass158.gclass157_0.string_1] = source[gclass158.gclass157_0.string_1] + num2;
        else
          source.Add(gclass158.gclass157_0.string_1, num2);
      }
      foreach (KeyValuePair<string, Decimal> keyValuePair in source.OrderByDescending<KeyValuePair<string, Decimal>, Decimal>((Func<KeyValuePair<string, Decimal>, Decimal>) (keyValuePair_0 => keyValuePair_0.Value)).ToDictionary<KeyValuePair<string, Decimal>, string, Decimal>((Func<KeyValuePair<string, Decimal>, string>) (keyValuePair_0 => keyValuePair_0.Key), (Func<KeyValuePair<string, Decimal>, Decimal>) (keyValuePair_0 => keyValuePair_0.Value)))
        this.gclass0_0.method_597(listView_0, "   " + keyValuePair.Key, GClass226.smethod_42(keyValuePair.Value, 2).ToString() + "m");
      if (this.decimal_52 >= this.decimal_56)
        this.gclass0_0.method_597(listView_0, "Available Workers", GClass226.smethod_42(this.decimal_52 - this.decimal_56, 2).ToString() + "m");
      else
        this.gclass0_0.method_597(listView_0, "Worker Shortage", GClass226.smethod_42(this.decimal_52 - this.decimal_56, 2).ToString() + "m");
      this.gclass0_0.method_597(listView_0, "", "");
      if (this.gclass1_0.bool_2)
      {
        this.gclass0_0.method_597(listView_0, "System Body Diameter", "N/A");
        this.gclass0_0.method_597(listView_0, "Gravity", "N/A");
        this.gclass0_0.method_597(listView_0, "Temperature", GClass226.smethod_44(this.gclass1_0.double_4 - (double) GClass226.int_17, 1).ToString() + " C");
        this.gclass0_0.method_597(listView_0, "Atmosphere", "N/A");
        this.gclass0_0.method_597(listView_0, "Population Capacity", "0");
      }
      else
      {
        this.gclass0_0.method_597(listView_0, "System Body Diameter", GClass226.smethod_43(this.gclass1_0.double_20 * 2.0).ToString() + " km");
        if (this.gclass1_0.double_7 > 0.01)
          this.gclass0_0.method_597(listView_0, "Gravity", GClass226.smethod_44(this.gclass1_0.double_7, 2).ToString() + " G");
        else
          this.gclass0_0.method_597(listView_0, "Gravity", GClass226.smethod_44(this.gclass1_0.double_7, 4).ToString() + " G");
        this.gclass0_0.method_597(listView_0, "Temperature", GClass226.smethod_44(this.gclass1_0.double_4 - (double) GClass226.int_17, 1).ToString() + " C");
        if (this.gclass1_0.method_43(this.gclass194_0) == 3)
          this.gclass0_0.method_597(listView_0, "Atmosphere", "Toxic");
        else if (this.gclass1_0.double_15 > this.gclass194_0.double_2)
          this.gclass0_0.method_597(listView_0, "Atmosphere", "High Pressure");
        else if (this.gclass1_0.method_50(this.gclass194_0))
          this.gclass0_0.method_597(listView_0, "Atmosphere", "Breathable");
        else
          this.gclass0_0.method_597(listView_0, "Atmosphere", "Not Breathable");
        Decimal decimal_73 = this.gclass1_0.method_62(this.gclass194_0);
        if (decimal_73 > 0M)
          this.gclass0_0.method_597(listView_0, "Population Capacity", GClass226.smethod_53(decimal_73) + "m");
      }
      this.gclass0_0.method_597(listView_0, "", "");
      if (this.gclass1_0.method_77(this.gclass21_0))
        this.gclass0_0.method_597(listView_0, "Ground Based Survey Potential", GClass226.smethod_82((Enum) this.gclass1_0.auroraGroundMineralSurvey_0));
      else if (this.gclass1_0.double_20 > 2000.0)
        this.gclass0_0.method_597(listView_0, "Ground Based Survey Potential", "Unknown");
      else
        this.gclass0_0.method_597(listView_0, "Ground Based Survey Potential", "None");
      if (this.bool_7)
        this.gclass0_0.method_594(listView_0, "Do Not Delete if Empty");
      listView_1.Items.Clear();
      int decimal_13_1 = (int) this.method_62(AuroraProductionCategory.SectorCommand);
      if (decimal_13_1 > 0)
        this.gclass0_0.method_597(listView_1, "Sector Command HQ", $"Level {decimal_13_1.ToString()}  Radius {this.gclass0_0.method_589((Decimal) decimal_13_1).ToString()}");
      int decimal_13_2 = (int) this.method_62(AuroraProductionCategory.NavalHeadquarters);
      if (decimal_13_2 > 0)
        this.gclass0_0.method_597(listView_1, "Naval Headquarters", $"Level {decimal_13_2.ToString()}  Radius {this.gclass0_0.method_589((Decimal) decimal_13_2).ToString()}");
      if (this.decimal_13 > 0M)
        this.gclass0_0.method_597(listView_1, "Naval Shipyard Capacity", GClass226.smethod_38(this.decimal_13) + " tons");
      if (this.decimal_14 > 0M)
        this.gclass0_0.method_597(listView_1, "Commercial Shipyard Capacity", GClass226.smethod_38(this.decimal_14) + " tons");
      if (this.decimal_15 > 0M)
        this.gclass0_0.method_597(listView_1, "Repair Yard Capacity", GClass226.smethod_38(this.decimal_15) + " tons");
      if (this.int_22 > 0)
        this.gclass0_0.method_597(listView_1, "Maintenance Facilities Capacity", GClass226.smethod_38(this.decimal_77) + " tons");
      int num3 = this.method_202(AuroraComponentType.MaintenanceModule);
      if (num3 > 0)
        this.gclass0_0.method_597(listView_1, "Maintenance Capacity including Orbital", GClass226.smethod_38(this.decimal_77 + (Decimal) num3 * this.gclass21_0.decimal_22 * this.gclass21_0.EconomicProdModifier) + " tons");
      if (this.decimal_75 > 0M)
        this.gclass0_0.method_597(listView_1, "Shipping Tonnage Maintained", GClass226.smethod_38(this.decimal_75) + " tons");
      if (this.decimal_76 > 0M)
        this.gclass0_0.method_597(listView_1, "Maintained plus SY Task Tonnage", GClass226.smethod_38(this.decimal_75 + this.decimal_76) + " tons");
      int num4 = (int) this.method_62(AuroraProductionCategory.Academy);
      if (num4 > 0)
      {
        string string_10_10 = "Military Academy";
        if (this.string_1 != "")
          string_10_10 = this.string_1;
        this.gclass0_0.method_597(listView_1, string_10_10, "Level " + num4.ToString());
      }
      int num5 = (int) this.method_62(AuroraProductionCategory.Sensors);
      if (num5 > 0)
        this.gclass0_0.method_597(listView_1, "Tracking Station Strength ", GClass226.smethod_37(num5 * this.gclass21_0.int_29).ToString());
      int num6 = (int) this.method_62(AuroraProductionCategory.GeneticModification);
      if (num6 > 0)
        this.gclass0_0.method_597(listView_1, "Annual Genetic Conversion Rate", GClass226.smethod_42((Decimal) num6 * this.gclass21_0.decimal_24, 2).ToString());
      int num7 = (int) this.method_62(AuroraProductionCategory.MassDriver);
      if (num7 > 0)
        this.gclass0_0.method_597(listView_1, "Mass Driver Capacity", GClass226.smethod_37(GClass226.int_25 * num7) + " tons");
      if (decimal_13_1 > 0 || decimal_13_2 > 0 || num4 > 0 || num5 > 0 || num6 > 0 || this.int_22 > 0 || num7 > 0 || this.decimal_13 > 0M || this.decimal_14 > 0M || this.decimal_15 > 0M)
        this.gclass0_0.method_597(listView_1, "", "");
      if (gclass193List.Count > 0)
        this.gclass0_0.method_597(listView_1, "Shipyards / Slipways", $"{gclass193List.Count.ToString()} / {this.int_15.ToString()}");
      this.method_72(listView_1, false);
      if (this.decimal_72 > 0M)
        this.gclass0_0.method_597(listView_1, "Orbital Mining Modules", GClass226.smethod_38(this.decimal_72).ToString());
      if (this.decimal_73 > 0M)
        this.gclass0_0.method_597(listView_1, "Orbital Terraforming Modules", GClass226.smethod_38(this.decimal_73).ToString());
      this.gclass0_0.method_597(listView_1, "", "");
      this.gclass0_0.method_597(listView_1, "Thermal Signature of Colony", GClass226.smethod_39(this.decimal_16).ToString());
      this.gclass0_0.method_597(listView_1, "EM Signature of Colony", GClass226.smethod_39(this.decimal_17).ToString());
      this.gclass0_0.method_597(listView_1, "", "");
      if (this.decimal_4 > 0M && !this.bool_0)
        this.gclass0_0.method_597(listView_1, "Protection Required / Actual", $"{GClass226.smethod_39(this.decimal_70).ToString()} / {GClass226.smethod_39(this.decimal_28).ToString()}");
      this.method_116(listView_1);
      this.gclass0_0.method_597(listView_1, "", "");
      this.gclass0_0.method_597(listView_1, "Economic Production Modifier", GClass226.smethod_42(this.gclass21_0.EconomicProdModifier * 100M, 2) + "%");
      this.gclass0_0.method_597(listView_1, "Manufacturing Efficiency Modifier", GClass226.smethod_42(this.decimal_5 * 100M, 2) + "%");
      this.gclass0_0.method_597(listView_1, "Political Status Production Modifier", GClass226.smethod_42(this.gclass160_0.decimal_0 * 100M, 2) + "%");
      this.gclass0_0.method_597(listView_1, "Political Status Wealth Modifier", GClass226.smethod_42(this.gclass160_0.decimal_1 * 100M, 2) + "%");
      this.gclass0_0.method_597(listView_1, "Political Stability Modifier", GClass226.smethod_42(this.decimal_33 * 100M, 2) + "%");
      listView_2.Items.Clear();
      if (this.gclass1_0.gclass220_0 != null)
      {
        this.gclass0_0.method_597(listView_2, "Ancient Construct", this.gclass1_0.gclass220_0.method_0());
        this.gclass0_0.method_597(listView_2, "", "");
      }
      if (this.gclass1_0.int_10 > 0)
      {
        if (this.gclass21_0.method_301(this.gclass1_0.int_9))
        {
          this.gclass0_0.method_597(listView_2, "Abandoned Installations", this.gclass1_0.int_10.ToString());
          this.gclass0_0.method_597(listView_2, $"{this.gclass1_0.gclass171_0.string_0} - TL{this.gclass1_0.gclass171_0.int_1.ToString()}", "");
        }
        else
        {
          this.gclass0_0.method_597(listView_2, "Abandoned Installations", "??");
          this.gclass0_0.method_597(listView_2, "Unknown Race - Xenoarchaeology Required", "");
        }
        this.gclass0_0.method_597(listView_1, "", "");
      }
      if ((int) this.method_62(AuroraProductionCategory.RefuellingPoint) > 0)
        this.gclass0_0.method_597(listView_2, "Refuelling Capability", "Yes");
      else
        this.gclass0_0.method_597(listView_2, "Refuelling Capability", "No");
      if ((int) this.method_62(AuroraProductionCategory.OrdnanceTransferPoint) > 0)
        this.gclass0_0.method_597(listView_2, "Ordnance Transfer Capability", "Yes");
      else
        this.gclass0_0.method_597(listView_2, "Ordnance Transfer Capability", "No");
      if ((int) this.method_62(AuroraProductionCategory.CargoShuttles) > 0)
        this.gclass0_0.method_597(listView_2, "Cargo Handling Capability", "Yes");
      else
        this.gclass0_0.method_597(listView_2, "Cargo Handling Capability", "No");
      if (this.gclass1_0.double_20 * 2.0 <= (double) this.gclass21_0.int_11 && !this.gclass1_0.bool_2)
        this.gclass0_0.method_597(listView_2, "Eligible for Orbital Mining", "Yes");
      else
        this.gclass0_0.method_597(listView_2, "Eligible for Orbital Mining", "No");
      this.gclass0_0.method_594(listView_2, "");
      this.gclass0_0.method_597(listView_2, "Fuel Available", GClass226.smethod_39(this.decimal_3).ToString());
      this.gclass0_0.method_597(listView_2, "Maintenance Supplies Available", GClass226.smethod_38(this.decimal_0).ToString());
      if (this.genum19_0 == GEnum19.const_1)
      {
        this.gclass0_0.method_597(listView_2, "", "");
        this.gclass0_0.method_597(listView_2, "Colonisation Pressure", GClass226.smethod_42(this.decimal_12, 2) + "%");
        this.gclass0_0.method_597(listView_2, "Available Colonists", GClass226.smethod_42(this.decimal_11, 2) + "m");
      }
      this.gclass0_0.method_597(listView_2, "", "");
      this.gclass123_0.method_28(listView_2);
      if (this.method_55().Count > 0)
      {
        this.gclass0_0.method_597(listView_2, "", "");
        this.method_173(listView_2);
      }
      if (this.list_1.Count > 0)
      {
        this.gclass0_0.method_597(listView_2, "", "");
        this.method_177(listView_2);
      }
      List<GClass85> list2 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => gclass85_3.gclass21_0 == this.gclass21_0 && this.gclass0_0.method_519(gclass85_3.double_2, this.method_87(), 1.0) && this.gclass0_0.method_519(gclass85_3.double_3, this.method_88(), 1.0))).OrderBy<GClass85, string>((Func<GClass85, string>) (gclass85_0 => gclass85_0.FleetName)).ToList<GClass85>();
      bool bool9 = this.gclass0_0.bool_9;
      this.gclass0_0.bool_9 = true;
      comboBox_0.DataSource = (object) list2;
      comboBox_0.DisplayMember = "FleetName";
      this.gclass0_0.bool_9 = bool9;
      comboBox_0.SelectedItem = (object) this.gclass85_0;
      List<GClass85> list3 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => gclass85_3.gclass21_0 == this.gclass21_0 && this.gclass0_0.method_519(gclass85_3.double_2, this.method_87(), 1.0) && this.gclass0_0.method_519(gclass85_3.double_3, this.method_88(), 1.0))).OrderBy<GClass85, string>((Func<GClass85, string>) (gclass85_0 => gclass85_0.FleetName)).ToList<GClass85>();
      this.gclass0_0.bool_9 = true;
      comboBox_1.DataSource = (object) list3;
      comboBox_1.DisplayMember = "FleetName";
      this.gclass0_0.bool_9 = bool9;
      comboBox_1.SelectedItem = (object) this.gclass85_1;
      List<GClass85> list4 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => gclass85_3.gclass21_0 == this.gclass21_0 && this.gclass0_0.method_519(gclass85_3.double_2, this.method_87(), 1.0) && this.gclass0_0.method_519(gclass85_3.double_3, this.method_88(), 1.0))).OrderBy<GClass85, string>((Func<GClass85, string>) (gclass85_0 => gclass85_0.FleetName)).ToList<GClass85>();
      this.gclass0_0.bool_9 = true;
      comboBox_2.DataSource = (object) list4;
      comboBox_2.DisplayMember = "FleetName";
      this.gclass0_0.bool_9 = bool9;
      comboBox_2.SelectedItem = (object) this.gclass85_2;
      List<GClass85> gclass85List = this.method_201();
      comboBox_3.DisplayMember = "FleetName";
      comboBox_3.DataSource = (object) gclass85List;
      if (gclass85List.Count > 0)
        comboBox_3.SelectedItem = (object) gclass85List[0];
      List<GClass83> list5 = this.gclass0_0.dictionary_0.Values.Where<GClass83>((Func<GClass83, bool>) (gclass83_0 => gclass83_0.gclass21_0 == this.gclass21_0)).OrderBy<GClass83, string>((Func<GClass83, string>) (gclass83_0 => gclass83_0.AdminCommandName)).ToList<GClass83>();
      comboBox_4.DisplayMember = "AdminCommandName";
      comboBox_4.DataSource = (object) list5;
      this.method_156(label_5);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2217);
    }
  }

  public void method_156(Label label_0)
  {
    try
    {
      if (this.gclass146_0 == null)
      {
        label_0.Text = "N/A";
      }
      else
      {
        double num = this.gclass0_0.method_28(this.method_87(), this.method_88(), this.gclass146_0.method_87(), this.gclass146_0.method_88()) / 1000.0;
        string str = num >= 170000.0 ? (num >= 1700000.0 ? GClass226.smethod_43(num / 86400.0) + " days" : GClass226.smethod_44(num / 86400.0, 1) + " days") : GClass226.smethod_44(num / 3600.0, 1) + " hours";
        label_0.Text = str;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3504);
    }
  }

  public void method_157(string string_6, Label label_0)
  {
    try
    {
      Decimal decimal_73 = 0M;
      List<GClass158> list;
      switch (string_6)
      {
        case "Ordnance":
          label_0.Text = $"Ordnance Production:  {GClass226.smethod_38(this.decimal_59)} BP";
          list = this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.decimal_1 > 0M)).ToList<GClass158>();
          break;
        case "Fighter":
          label_0.Text = $"Fighter Production:  {GClass226.smethod_38(this.decimal_60)} BP";
          list = this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.decimal_2 > 0M)).ToList<GClass158>();
          break;
        default:
          label_0.Text = $"Construction Capacity:  {GClass226.smethod_38(this.decimal_58)} BP";
          list = this.dictionary_0.Values.Where<GClass158>((Func<GClass158, bool>) (gclass158_0 => gclass158_0.gclass157_0.decimal_0 > 0M)).ToList<GClass158>();
          foreach (GClass103 gclass103 in this.method_84())
            decimal_73 += gclass103.method_40(false);
          decimal_73 = decimal_73 * this.gclass21_0.decimal_13 * this.decimal_64;
          break;
      }
      foreach (GClass158 gclass158 in list)
        label_0.Text = $"{label_0.Text}   {gclass158.decimal_0.ToString()} x {gclass158.gclass157_0.string_2}";
      if (!(decimal_73 > 0M))
        return;
      label_0.Text = $"{label_0.Text}   Engineer Contribution {GClass226.smethod_39(decimal_73)} BP";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2218);
    }
  }

  public void method_158(ListBox listBox_0, string string_6, Label label_0, ComboBox comboBox_0)
  {
    try
    {
      int num = this.method_73(AuroraInstallationType.ConventionalIndustry);
      switch (string_6)
      {
        case "Construction":
          if (num > 0)
          {
            this.method_160(listBox_0, true);
            break;
          }
          this.method_160(listBox_0, false);
          break;
        case "Ordnance":
          this.method_167(listBox_0);
          break;
        case "Fighter":
          this.method_168(listBox_0);
          break;
        case "Components":
          this.method_172(listBox_0);
          break;
        case "Space Station":
          if (this.dictionary_0.ContainsKey(AuroraInstallationType.Spaceport))
          {
            this.method_169(listBox_0);
            break;
          }
          comboBox_0.SelectedIndex = 0;
          break;
      }
      this.method_157(string_6, label_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2219);
    }
  }

  public void method_159(ListView listView_0, string string_6, object object_1)
  {
    try
    {
      this.decimal_82 = 0M;
      this.object_0 = object_1;
      switch (string_6)
      {
        case "Construction":
          GClass157 gclass157 = (GClass157) object_1;
          this.gclass123_5 = gclass157.gclass123_0;
          this.decimal_81 = gclass157.decimal_21;
          this.auroraProductionType_0 = AuroraProductionType.Construction;
          break;
        case "Ordnance":
          GClass129 gclass129 = (GClass129) object_1;
          this.gclass123_5 = gclass129.gclass123_0;
          this.decimal_81 = gclass129.decimal_3;
          this.decimal_82 = (Decimal) gclass129.int_4;
          this.auroraProductionType_0 = AuroraProductionType.Ordnance;
          break;
        case "Space Station":
          GClass22 gclass22_1 = (GClass22) object_1;
          this.gclass123_5 = gclass22_1.gclass123_0;
          this.decimal_81 = gclass22_1.decimal_4;
          this.auroraProductionType_0 = AuroraProductionType.SpaceStation;
          break;
        case "Fighter":
          GClass22 gclass22_2 = (GClass22) object_1;
          this.gclass123_5 = gclass22_2.gclass123_0;
          this.decimal_81 = gclass22_2.decimal_4;
          this.auroraProductionType_0 = AuroraProductionType.Fighter;
          break;
        case "Components":
          GClass230 gclass230 = (GClass230) object_1;
          this.gclass123_5 = gclass230.gclass123_0;
          this.decimal_81 = gclass230.decimal_2;
          this.auroraProductionType_0 = AuroraProductionType.Components;
          break;
      }
      List<string> stringList = new List<string>();
      listView_0.Items.Clear();
      this.gclass0_0.method_601(listView_0, "Resource", "Required", "Available");
      this.gclass0_0.method_601(listView_0, "Wealth", GClass226.smethod_42(this.decimal_81, 2).ToString(), "");
      if (this.gclass123_5.decimal_0 > 0M)
        this.gclass0_0.method_601(listView_0, "Duranium", GClass226.smethod_42(this.gclass123_5.decimal_0, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_0).ToString());
      if (this.gclass123_5.decimal_1 > 0M)
        this.gclass0_0.method_601(listView_0, "Neutronium", GClass226.smethod_42(this.gclass123_5.decimal_1, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_1).ToString());
      if (this.gclass123_5.decimal_2 > 0M)
        this.gclass0_0.method_601(listView_0, "Corbomite", GClass226.smethod_42(this.gclass123_5.decimal_2, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_2).ToString());
      if (this.gclass123_5.decimal_3 > 0M)
        this.gclass0_0.method_601(listView_0, "Tritanium", GClass226.smethod_42(this.gclass123_5.decimal_3, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_3).ToString());
      if (this.gclass123_5.decimal_4 > 0M)
        this.gclass0_0.method_601(listView_0, "Boronide", GClass226.smethod_42(this.gclass123_5.decimal_4, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_4).ToString());
      if (this.gclass123_5.decimal_5 > 0M)
        this.gclass0_0.method_601(listView_0, "Mercassium", GClass226.smethod_42(this.gclass123_5.decimal_5, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_5).ToString());
      if (this.gclass123_5.decimal_6 > 0M)
        this.gclass0_0.method_601(listView_0, "Vendarite", GClass226.smethod_42(this.gclass123_5.decimal_6, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_6).ToString());
      if (this.gclass123_5.decimal_7 > 0M)
        this.gclass0_0.method_601(listView_0, "Sorium", GClass226.smethod_42(this.gclass123_5.decimal_7, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_7).ToString());
      if (this.gclass123_5.decimal_8 > 0M)
        this.gclass0_0.method_601(listView_0, "Uridium", GClass226.smethod_42(this.gclass123_5.decimal_8, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_8).ToString());
      if (this.gclass123_5.decimal_9 > 0M)
        this.gclass0_0.method_601(listView_0, "Corundium", GClass226.smethod_42(this.gclass123_5.decimal_9, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_9).ToString());
      if (this.gclass123_5.decimal_10 > 0M)
        this.gclass0_0.method_601(listView_0, "Gallicite", GClass226.smethod_42(this.gclass123_5.decimal_10, 1).ToString(), GClass226.smethod_39(this.gclass123_0.decimal_10).ToString());
      if (!(this.decimal_82 > 0M))
        return;
      this.gclass0_0.method_601(listView_0, "Fuel", GClass226.smethod_42(this.decimal_82, 2).ToString(), GClass226.smethod_42(this.decimal_3 / 1000000M, 1) + "m");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2220);
    }
  }

  public void method_160(ListBox listBox_0, bool bool_10)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass146.Class1134 class1134 = new GClass146.Class1134();
      // ISSUE: reference to a compiler-generated field
      class1134.list_0 = this.gclass21_0.method_294();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass157> gclass157List = !bool_10 ? this.gclass0_0.dictionary_44.Values.Where<GClass157>(new Func<GClass157, bool>(class1134.method_1)).OrderBy<GClass157, string>((Func<GClass157, string>) (gclass157_0 => gclass157_0.Name)).ToList<GClass157>() : this.gclass0_0.dictionary_44.Values.Where<GClass157>(new Func<GClass157, bool>(class1134.method_0)).OrderBy<GClass157, string>((Func<GClass157, string>) (gclass157_0 => gclass157_0.Name)).ToList<GClass157>();
      listBox_0.DataSource = (object) gclass157List;
      listBox_0.DisplayMember = "Name";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2221);
    }
  }

  public void method_161(ComboBox comboBox_0, bool bool_10, GClass157 gclass157_0_1)
  {
    try
    {
      this.gclass21_0.method_294();
      List<GClass157> gclass157List = bool_10 ? this.gclass0_0.dictionary_44.Values.Where<GClass157>((Func<GClass157, bool>) (gclass157_0_2 => gclass157_0_2.int_1 > 0 && this.dictionary_0.ContainsKey(gclass157_0_2.auroraInstallationType_0))).OrderBy<GClass157, string>((Func<GClass157, string>) (gclass157_0_3 => gclass157_0_3.Name)).ToList<GClass157>() : this.gclass0_0.dictionary_44.Values.Where<GClass157>((Func<GClass157, bool>) (gclass157_0_4 => gclass157_0_4.int_1 > 0)).OrderBy<GClass157, string>((Func<GClass157, string>) (gclass157_0_5 => gclass157_0_5.Name)).ToList<GClass157>();
      comboBox_0.DataSource = (object) gclass157List;
      comboBox_0.DisplayMember = "Name";
      comboBox_0.SelectedItem = (object) gclass157_0_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2222);
    }
  }

  public void method_162(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_601(listView_0, "Installation Type (Cargo Holds)", "Amount", (string) null);
      this.gclass0_0.method_594(listView_0, "");
      foreach (GClass158 object_1 in this.dictionary_0.Values.OrderBy<GClass158, string>((Func<GClass158, string>) (gclass158_0 => gclass158_0.gclass157_0.Name)).ToList<GClass158>())
        this.gclass0_0.method_598(listView_0, $"{object_1.gclass157_0.Name} ({GClass226.smethod_44((double) object_1.gclass157_0.int_1 / 25000.0, 2)})", GClass226.smethod_42(object_1.decimal_0, 2), (object) object_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2223);
    }
  }

  public void method_163(ListView listView_0, bool bool_10)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1135 class1135 = new GClass146.Class1135();
    // ISSUE: reference to a compiler-generated field
    class1135.bool_0 = bool_10;
    // ISSUE: reference to a compiler-generated field
    class1135.gclass146_0 = this;
    try
    {
      listView_0.Items.Clear();
      // ISSUE: reference to a compiler-generated field
      if (!class1135.bool_0)
        this.gclass0_0.method_603(listView_0, "Installation Type Demanded", "Amount", "Assigned", (string) null);
      else
        this.gclass0_0.method_603(listView_0, "Installation Type Supplied", "Amount", "Assigned", (string) null);
      this.gclass0_0.method_594(listView_0, "");
      // ISSUE: reference to a compiler-generated method
      foreach (GClass148 gclass148 in this.dictionary_5.Values.Where<GClass148>(new Func<GClass148, bool>(class1135.method_0)).ToList<GClass148>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1136 class1136 = new GClass146.Class1136();
        // ISSUE: reference to a compiler-generated field
        class1136.class1135_0 = class1135;
        // ISSUE: reference to a compiler-generated field
        class1136.gclass148_0 = gclass148;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        Decimal decimal_73 = class1136.class1135_0.bool_0 ? (Decimal) (this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.genum106_0 == GEnum106.const_1)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1136.method_1)).SelectMany<GClass139, GClass40>((Func<GClass139, IEnumerable<GClass40>>) (gclass139_0 => (IEnumerable<GClass40>) gclass139_0.gclass85_0.method_176())).Sum<GClass40>((Func<GClass40, int>) (gclass40_0 => gclass40_0.method_124())) / class1136.gclass148_0.gclass157_0.int_1) : (Decimal) (this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.genum106_0 == GEnum106.const_1)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1136.method_0)).SelectMany<GClass139, GClass40>((Func<GClass139, IEnumerable<GClass40>>) (gclass139_0 => (IEnumerable<GClass40>) gclass139_0.gclass85_0.method_176())).Sum<GClass40>((Func<GClass40, int>) (gclass40_0 => gclass40_0.method_124())) / class1136.gclass148_0.gclass157_0.int_1);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.method_602(listView_0, class1136.gclass148_0.gclass157_0.Name, GClass226.smethod_42(class1136.gclass148_0.decimal_0, 2), GClass226.smethod_42(decimal_73, 2), (object) class1136.gclass148_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2224);
    }
  }

  public void method_164(
    RadioButton radioButton_0,
    RadioButton radioButton_1,
    RadioButton radioButton_2)
  {
    try
    {
      radioButton_0.Visible = true;
      radioButton_1.Visible = true;
      radioButton_2.Visible = true;
      Decimal num1 = this.gclass1_0.method_62(this.gclass194_0);
      Decimal num2 = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass1_0 == this.gclass1_0)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_4));
      Decimal num3 = num1 - num2;
      if (this.decimal_4 <= 10M && num2 < num1 * 0.5M)
      {
        this.genum19_0 = GEnum19.const_0;
        radioButton_1.Visible = false;
        radioButton_2.Visible = false;
        radioButton_0.Checked = true;
      }
      else if (this.genum19_0 == GEnum19.const_0)
        radioButton_0.Checked = true;
      else if (this.genum19_0 == GEnum19.const_1)
      {
        radioButton_1.Checked = true;
      }
      else
      {
        if (this.genum19_0 != GEnum19.const_2)
          return;
        radioButton_2.Checked = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2225);
    }
  }

  public void method_165(
    FlowLayoutPanel flowLayoutPanel_0,
    RadioButton radioButton_0,
    RadioButton radioButton_1,
    Label label_0,
    TextBox textBox_0)
  {
    try
    {
      flowLayoutPanel_0.Visible = false;
      int num = this.method_73(AuroraInstallationType.CivilianMiningComplex);
      if (num == 0)
        return;
      flowLayoutPanel_0.Visible = true;
      if (this.bool_1)
      {
        radioButton_0.Checked = true;
        label_0.Text = "Annual Purchase Cost";
        textBox_0.Text = GClass226.smethod_37(num * GClass226.int_4);
      }
      else
      {
        radioButton_1.Checked = true;
        label_0.Text = "Annual Tax Amount";
        textBox_0.Text = GClass226.smethod_37(num * GClass226.int_3);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2226);
    }
  }

  public void method_166(ComboBox comboBox_0)
  {
    try
    {
      this.gclass0_0.bool_13 = true;
      List<GClass170> source = new List<GClass170>();
      source.Add(new GClass170("None", 0M, 0.0));
      if (this.method_73(AuroraInstallationType.MassDriver) > 0)
      {
        foreach (GClass146 gclass146 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass202_0 == this.gclass202_0)).Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.method_73(AuroraInstallationType.MassDriver) > 0 && gclass146_1 != this)).ToList<GClass146>())
        {
          GClass170 gclass170 = new GClass170(gclass146.PopName, (Decimal) gclass146.int_6, 1.0);
          source.Add(gclass170);
        }
      }
      source.OrderBy<GClass170, double>((Func<GClass170, double>) (gclass170_0 => gclass170_0.double_0)).ThenBy<GClass170, string>((Func<GClass170, string>) (gclass170_0 => gclass170_0.DisplayText)).ToList<GClass170>();
      comboBox_0.DisplayMember = "DisplayText";
      comboBox_0.DataSource = (object) source;
      if (this.gclass146_0 != null)
      {
        GClass170 gclass170 = source.FirstOrDefault<GClass170>((Func<GClass170, bool>) (gclass170_0 => gclass170_0.DisplayText == this.gclass146_0.PopName));
        comboBox_0.SelectedItem = (object) gclass170;
      }
      else
        comboBox_0.SelectedItem = (object) 0;
      this.gclass0_0.bool_13 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2227);
    }
  }

  public void method_167(ListBox listBox_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1137 class1137 = new GClass146.Class1137();
    // ISSUE: reference to a compiler-generated field
    class1137.gclass146_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated field
      class1137.list_0 = this.gclass21_0.method_294();
      // ISSUE: reference to a compiler-generated method
      List<GClass129> list = this.gclass0_0.dictionary_5.Values.Where<GClass129>(new Func<GClass129, bool>(class1137.method_0)).ToList<GClass129>();
      listBox_0.DataSource = (object) list;
      listBox_0.DisplayMember = "Name";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2228);
    }
  }

  public void method_168(ListBox listBox_0)
  {
    List<GClass22> list = this.gclass0_0.dictionary_3.Values.Where<GClass22>((Func<GClass22, bool>) (gclass22_0 => gclass22_0.decimal_14 <= 10M && gclass22_0.int_38 == 0 && gclass22_0.gclass21_0 == this.gclass21_0 && !gclass22_0.method_28())).ToList<GClass22>();
    foreach (GClass22 gclass22 in list)
      gclass22.ClassNameWithHull = gclass22.method_34();
    listBox_0.DataSource = (object) list;
    listBox_0.DisplayMember = "ClassNameWithHull";
  }

  public void method_169(ListBox listBox_0)
  {
    List<GClass22> list = this.gclass0_0.dictionary_3.Values.Where<GClass22>((Func<GClass22, bool>) (gclass22_0 => gclass22_0.int_37 == 1 && gclass22_0.int_38 == 0 && gclass22_0.gclass21_0 == this.gclass21_0)).ToList<GClass22>();
    foreach (GClass22 gclass22 in list)
      gclass22.ClassNameWithHull = gclass22.method_34();
    listBox_0.DataSource = (object) list;
    listBox_0.DisplayMember = "ClassNameWithHull";
  }

  public Decimal method_170(Decimal decimal_90)
  {
    try
    {
      if (decimal_90 == 0M)
        return 0M;
      if (this.decimal_3 > decimal_90)
      {
        this.decimal_3 -= decimal_90;
        return decimal_90;
      }
      Decimal decimal3 = this.decimal_3;
      this.decimal_3 = 0M;
      return decimal3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2229);
      return 0M;
    }
  }

  public Decimal method_171(Decimal decimal_90)
  {
    try
    {
      if (this.decimal_0 > decimal_90)
      {
        this.decimal_0 -= decimal_90;
        return decimal_90;
      }
      Decimal decimal0 = this.decimal_0;
      this.decimal_0 = 0M;
      return decimal0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2230);
      return 0M;
    }
  }

  public void method_172(ListBox listBox_0)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      List<GClass230> list = this.gclass0_0.dictionary_54.Values.Where<GClass230>(new Func<GClass230, bool>(new GClass146.Class1138()
      {
        list_0 = this.gclass21_0.method_294()
      }.method_0)).OrderBy<GClass230, string>((Func<GClass230, string>) (gclass230_0 => gclass230_0.Name)).ToList<GClass230>();
      listBox_0.DataSource = (object) list;
      listBox_0.DisplayMember = "Name";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2231);
    }
  }

  public void method_173(ListView listView_0)
  {
    try
    {
      Decimal decimal_73_1 = 0M;
      Decimal decimal_73_2 = 0M;
      Decimal num = 0M;
      Decimal decimal_73_3 = 0M;
      Decimal decimal_73_4 = 0M;
      Decimal decimal_73_5 = 0M;
      foreach (GClass39 gclass39 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.gclass146_0 == this)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).ToList<GClass39>())
      {
        decimal_73_3 += (Decimal) gclass39.int_1;
        decimal_73_1 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        decimal_73_2 += gclass39.gclass101_0.decimal_3 * (Decimal) gclass39.int_1;
        num += gclass39.gclass101_0.method_8() * (Decimal) gclass39.int_1;
        decimal_73_4 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_2)));
        decimal_73_5 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_3));
      }
      if (!(decimal_73_3 > 0M))
        return;
      this.gclass0_0.method_597(listView_0, "Total Ground Units", GClass226.smethod_38(decimal_73_3));
      this.gclass0_0.method_597(listView_0, "Total Ground Force Size", GClass226.smethod_38(decimal_73_1));
      this.gclass0_0.method_597(listView_0, "Total Ground Force Cost", GClass226.smethod_38(decimal_73_2));
      if (decimal_73_4 > 0M)
        this.gclass0_0.method_597(listView_0, "Surface To Orbit Ground Units", GClass226.smethod_38(decimal_73_4));
      if (!(decimal_73_4 > 0M))
        return;
      this.gclass0_0.method_597(listView_0, "Ground Unit Construction", GClass226.smethod_38(decimal_73_5));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2232);
    }
  }

  public void method_174(ListView listView_0, bool bool_10)
  {
    try
    {
      foreach (GClass193 gclass193 in this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass146_0 == this)).OrderByDescending<GClass193, Decimal>((Func<GClass193, Decimal>) (gclass193_0 => gclass193_0.decimal_0)).ToList<GClass193>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1139 class1139 = new GClass146.Class1139();
        // ISSUE: reference to a compiler-generated field
        class1139.gclass193_0 = gclass193;
        // ISSUE: reference to a compiler-generated method
        if (!bool_10 || this.gclass0_0.dictionary_32.Values.Count<GClass192>(new Func<GClass192, bool>(class1139.method_0)) <= 0)
        {
          // ISSUE: reference to a compiler-generated field
          if (class1139.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.method_598(listView_0, "C - " + class1139.gclass193_0.string_0, $"{GClass226.smethod_38(class1139.gclass193_0.decimal_0)}  ({class1139.gclass193_0.int_1.ToString()})", (object) class1139.gclass193_0);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (class1139.gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.method_598(listView_0, "N - " + class1139.gclass193_0.string_0, $"{GClass226.smethod_38(class1139.gclass193_0.decimal_0)}  ({class1139.gclass193_0.int_1.ToString()})", (object) class1139.gclass193_0);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.method_598(listView_0, "R - " + class1139.gclass193_0.string_0, $"{GClass226.smethod_38(class1139.gclass193_0.decimal_0)}  ({class1139.gclass193_0.int_1.ToString()})", (object) class1139.gclass193_0);
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2233);
    }
  }

  public void method_175(ListView listView_0)
  {
    try
    {
      List<GClass103> list = this.method_84().OrderBy<GClass103, string>((Func<GClass103, string>) (gclass103_0 => gclass103_0.Name)).ToList<GClass103>();
      this.gclass0_0.method_420(listView_0, list);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2234);
    }
  }

  public void method_176(bool bool_10)
  {
    try
    {
      this.decimal_71 = 0M;
      foreach (GClass103 gclass103 in this.method_84())
        this.decimal_71 += gclass103.method_40(bool_10);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2235);
    }
  }

  public void method_177(ListView listView_0)
  {
    try
    {
      this.list_1 = this.list_1.OrderBy<GClass130, string>((Func<GClass130, string>) (gclass130_0 => gclass130_0.gclass129_0.Name)).ToList<GClass130>();
      foreach (GClass130 gclass130 in this.list_1)
        this.gclass0_0.method_597(listView_0, gclass130.gclass129_0.Name, GClass226.smethod_37(gclass130.int_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2236);
    }
  }

  public void method_178(ListView listView_0, bool bool_10)
  {
    try
    {
      listView_0.Items.Clear();
      int num1 = 0;
      this.gclass0_0.method_612(listView_0, "Location", "NHQ", "System", "Race", "Name and Rank", "Processed", (object) null);
      this.gclass0_0.method_597(listView_0, "", (string) null);
      List<GClass147> gclass147List1 = new List<GClass147>();
      List<GClass55> gclass55List = new List<GClass55>();
      List<GClass55> source1 = new List<GClass55>();
      List<GClass180> gclass180List = new List<GClass180>();
      List<GClass55> source2 = bool_10 ? this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0.bool_4 && gclass55_0.gclass146_0 != null)).Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass146_0.gclass21_0 == this.gclass21_0)).ToList<GClass55>() : this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.bool_4 && gclass55_1.gclass146_0 == this)).ToList<GClass55>();
      if (bool_10)
        source1 = this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0.bool_4 && gclass55_0.gclass40_0 != null)).Where<GClass55>((Func<GClass55, bool>) (gclass55_1 => gclass55_1.gclass40_0.gclass21_0 == this.gclass21_0)).ToList<GClass55>();
      foreach (GClass55 gclass55 in source2)
      {
        gclass55.int_10 = gclass55.method_0();
        gclass55.gclass110_0 = this.gclass21_0.method_325(gclass55.gclass21_0.RaceID);
      }
      foreach (GClass55 gclass55 in source1)
      {
        gclass55.int_10 = gclass55.method_0();
        gclass55.gclass110_0 = this.gclass21_0.method_325(gclass55.gclass21_0.RaceID);
      }
      List<GClass55> list1 = source2.OrderBy<GClass55, string>((Func<GClass55, string>) (gclass55_0 => gclass55_0.gclass146_0.PopName)).ThenBy<GClass55, string>((Func<GClass55, string>) (gclass55_0 => gclass55_0.gclass110_0.AlienRaceName)).ThenByDescending<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.int_10)).ToList<GClass55>();
      List<GClass55> list2 = source1.OrderBy<GClass55, string>((Func<GClass55, string>) (gclass55_0 => gclass55_0.gclass40_0.ShipName)).ThenBy<GClass55, string>((Func<GClass55, string>) (gclass55_0 => gclass55_0.gclass110_0.AlienRaceName)).ThenByDescending<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.int_10)).ToList<GClass55>();
      foreach (GClass55 object_1 in list1)
      {
        int num2 = (int) object_1.gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters);
        string string_10;
        string string_12;
        if (num1 != object_1.gclass146_0.int_6)
        {
          string_10 = object_1.gclass146_0.PopName;
          string_12 = object_1.gclass146_0.gclass202_0.Name;
          num1 = object_1.gclass146_0.int_6;
        }
        else
        {
          string_10 = "";
          string_12 = "";
        }
        string string_11 = "-";
        if (num2 > 0)
          string_11 = num2.ToString();
        string string_14 = $"{object_1.gclass61_0.RankName} (L{object_1.int_10.ToString()}) {object_1.string_0}";
        string string_15 = "-";
        if (object_1.bool_5)
          string_15 = "Yes";
        this.gclass0_0.method_612(listView_0, string_10, string_11, string_12, object_1.gclass110_0.AlienRaceName, string_14, string_15, (object) object_1);
      }
      int num3 = 0;
      foreach (GClass55 object_1 in list2)
      {
        string string_14 = $"{object_1.gclass61_0.RankName} (L{object_1.int_10.ToString()}) {object_1.string_0}";
        string string_15 = "-";
        if (object_1.bool_5)
          string_15 = "Yes";
        string string_10;
        string string_12;
        if (num3 != object_1.gclass40_0.int_8)
        {
          string_10 = object_1.gclass40_0.method_187();
          string_12 = object_1.gclass40_0.gclass85_0.gclass202_0.Name;
          num3 = object_1.gclass40_0.int_8;
        }
        else
        {
          string_10 = "";
          string_12 = "";
        }
        this.gclass0_0.method_612(listView_0, string_10, "-", string_12, object_1.gclass110_0.AlienRaceName, string_14, string_15, (object) object_1);
      }
      if (list1.Count <= 0 && list2.Count <= 0)
        listView_0.Items.Clear();
      else
        this.gclass0_0.method_597(listView_0, "", (string) null);
      this.gclass0_0.method_612(listView_0, "Location", "NHQ", "System", "Race", "Enlisted Prisoners", "Processed", (object) null);
      this.gclass0_0.method_597(listView_0, "", (string) null);
      List<GClass147> gclass147List2 = bool_10 ? this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass21_0 == this.gclass21_0 && gclass146_1.list_3.Count > 0)).SelectMany<GClass146, GClass147>((Func<GClass146, IEnumerable<GClass147>>) (gclass146_0 => (IEnumerable<GClass147>) gclass146_0.list_3)).OrderByDescending<GClass147, int>((Func<GClass147, int>) (gclass147_0 => gclass147_0.int_0)).ToList<GClass147>() : this.list_3.OrderBy<GClass147, string>((Func<GClass147, string>) (gclass147_0 => gclass147_0.gclass146_0.PopName)).ThenBy<GClass147, string>((Func<GClass147, string>) (gclass147_0 => gclass147_0.gclass21_0.string_0)).ThenBy<GClass147, string>((Func<GClass147, string>) (gclass147_0 => gclass147_0.gclass194_0.SpeciesName)).OrderByDescending<GClass147, int>((Func<GClass147, int>) (gclass147_0 => gclass147_0.int_0)).ToList<GClass147>();
      if (bool_10)
        gclass180List = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.list_1.Count > 0)).SelectMany<GClass40, GClass180>((Func<GClass40, IEnumerable<GClass180>>) (gclass40_0 => (IEnumerable<GClass180>) gclass40_0.list_1)).OrderBy<GClass180, string>((Func<GClass180, string>) (gclass180_0 => gclass180_0.gclass40_0.ShipName)).ThenByDescending<GClass180, int>((Func<GClass180, int>) (gclass180_0 => gclass180_0.int_0)).ToList<GClass180>();
      int num4 = 0;
      foreach (GClass147 object_1 in gclass147List2)
      {
        GClass110 gclass110 = this.gclass21_0.method_325(object_1.gclass21_0.RaceID);
        int num5 = (int) object_1.gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters);
        string string_11 = "-";
        if (num5 > 0)
          string_11 = num5.ToString();
        string string_10;
        string string_12;
        if (num4 != object_1.gclass146_0.int_6)
        {
          string_10 = object_1.gclass146_0.PopName;
          string_12 = object_1.gclass146_0.gclass202_0.Name;
          num4 = object_1.gclass146_0.int_6;
        }
        else
        {
          string_10 = "";
          string_12 = "";
        }
        this.gclass0_0.method_612(listView_0, string_10, string_11, string_12, gclass110.AlienRaceName, GClass226.smethod_37(object_1.int_0), GClass226.smethod_37(object_1.int_1), (object) object_1);
      }
      this.gclass0_0.method_597(listView_0, "", (string) null);
      int num6 = 0;
      foreach (GClass180 object_1 in gclass180List)
      {
        string string_10;
        string string_12;
        if (num6 != object_1.gclass40_0.int_8)
        {
          string_10 = object_1.gclass40_0.method_187();
          string_12 = object_1.gclass40_0.gclass85_0.gclass202_0.Name;
          num6 = object_1.gclass40_0.int_8;
        }
        else
        {
          string_10 = "";
          string_12 = "";
        }
        GClass110 gclass110 = this.gclass21_0.method_325(object_1.gclass21_0.RaceID);
        this.gclass0_0.method_612(listView_0, string_10, "-", string_12, gclass110.AlienRaceName, GClass226.smethod_37(object_1.int_0), "-", (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3822);
    }
  }

  public void method_179()
  {
    try
    {
      this.decimal_28 = 0M;
      this.decimal_70 = this.decimal_4 * ((Decimal) this.gclass194_0.int_5 / 100M) * this.gclass160_0.decimal_3;
      foreach (GClass85 gclass85 in this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => gclass85_3.gclass202_0 == this.gclass202_0 && gclass85_3.gclass21_0 == this.gclass21_0 && gclass85_3.genum106_0 == GEnum106.const_0)).ToList<GClass85>())
        this.decimal_28 += gclass85.method_156();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2237);
    }
  }

  public void method_180()
  {
    try
    {
      this.decimal_42 = GClass226.decimal_36 * (this.decimal_18 + 1M);
      if (this.decimal_42 > 1M)
        this.decimal_42 = 1M;
      this.decimal_43 = GClass226.decimal_36 * (this.decimal_19 + 1M);
      if (this.decimal_43 > 1M)
        this.decimal_43 = 1M;
      this.decimal_48 = this.decimal_42 * this.decimal_4;
      this.decimal_49 = this.decimal_43 * this.decimal_4;
      if (this.decimal_30 > 0M)
      {
        this.decimal_42 = this.decimal_48 / this.decimal_30;
        this.decimal_43 = this.decimal_49 / this.decimal_30;
      }
      this.decimal_44 = (Decimal) Math.Sqrt(Math.Sqrt((double) this.decimal_30 * 100000.0)) / 100M;
      if (this.decimal_44 > GClass226.decimal_37)
        this.decimal_44 = GClass226.decimal_37;
      this.decimal_45 = this.decimal_44;
      if (this.decimal_44 + this.decimal_42 > 1M)
        this.decimal_44 = 1M - this.decimal_42;
      if (this.decimal_45 + this.decimal_43 > 1M)
        this.decimal_45 = 1M - this.decimal_43;
      this.decimal_50 = this.decimal_44 * this.decimal_30;
      this.decimal_51 = this.decimal_45 * this.decimal_30;
      this.decimal_52 = this.decimal_30 - this.decimal_48 - this.decimal_50;
      this.decimal_53 = this.decimal_30 - this.decimal_49 - this.decimal_51;
      this.decimal_46 = !(this.decimal_52 > 0M) ? 0M : this.decimal_52 / this.decimal_30;
      if (this.decimal_53 > 0M)
        this.decimal_47 = this.decimal_53 / this.decimal_30;
      else
        this.decimal_47 = 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2238);
    }
  }

  public Decimal method_181()
  {
    try
    {
      this.decimal_57 = this.method_204();
      foreach (GClass158 gclass158 in this.dictionary_0.Values)
      {
        if (gclass158.gclass157_0.bool_5)
          this.decimal_57 += gclass158.decimal_0 * gclass158.gclass157_0.decimal_22;
      }
      this.decimal_40 = 0M;
      this.decimal_41 = 0M;
      this.decimal_66 = this.gclass160_0.decimal_1 * this.gclass21_0.decimal_20 * this.decimal_31;
      if (this.gclass55_0 != null)
        this.decimal_66 *= this.gclass55_0.method_5(GEnum121.const_16);
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
        this.decimal_66 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_16);
      if (this.decimal_8 > 0M)
        this.decimal_66 *= this.decimal_33;
      this.decimal_40 = this.method_62(AuroraProductionCategory.FinancialProduction) * this.decimal_5 * this.decimal_66;
      this.decimal_41 = this.decimal_57 * this.decimal_5 * this.decimal_66;
      this.decimal_39 = this.decimal_40 + this.decimal_41;
      return this.decimal_39;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2239);
      return 0M;
    }
  }

  public void method_182()
  {
    try
    {
      this.decimal_29 = 0M;
      foreach (GClass85 gclass85 in this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => this.gclass0_0.method_521(gclass85_3.double_2, this.method_87(), gclass85_3.double_3, this.method_88(), 1.0) && gclass85_3.genum106_0 == GEnum106.const_0 && gclass85_3.gclass21_0 == this.gclass21_0 && gclass85_3.dictionary_0.Count == 0)).ToList<GClass85>().Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.method_176().Count<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.bool_9)) > 0)).ToList<GClass85>())
      {
        if (gclass85.gclass146_0 == null)
          gclass85.gclass146_0 = this;
        else if (gclass85.gclass146_0 != this && gclass85.gclass146_0.gclass1_0 != this.gclass1_0)
          gclass85.gclass146_0 = this;
        if (gclass85.gclass146_0 == this)
          this.decimal_29 += (Decimal) gclass85.method_194();
      }
      this.decimal_29 /= 1000000M;
      this.decimal_30 = this.decimal_4 + this.decimal_29;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2240);
    }
  }

  public void method_183(Decimal decimal_90)
  {
    try
    {
      Decimal num = this.decimal_12 / 100M * this.decimal_4;
      this.decimal_11 += num * decimal_90;
      if (!(this.decimal_11 > num))
        return;
      this.decimal_11 = num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3775);
    }
  }

  public void method_184()
  {
    try
    {
      Decimal num1 = this.method_62(AuroraProductionCategory.Infrastructure);
      int num2 = this.method_185();
      this.int_3 = (int) (this.decimal_4 * 100M * this.decimal_18 * (Decimal) num2 / this.gclass194_0.decimal_0);
      this.int_4 = (int) (this.decimal_4 * 100M * this.decimal_19 * (Decimal) num2 / this.gclass194_0.decimal_0);
      this.decimal_54 = Math.Ceiling(this.decimal_18 * 100M * (Decimal) num2 / this.gclass194_0.decimal_0);
      this.decimal_55 = Math.Ceiling(this.decimal_19 * 100M * (Decimal) num2 / this.gclass194_0.decimal_0);
      if (this.decimal_19 > 0M && this.decimal_55 < 1M)
      {
        this.decimal_55 = 1M;
        this.decimal_54 = 1M;
      }
      if (this.decimal_19 == -1M)
      {
        this.decimal_36 = 0M;
        this.decimal_37 = 0M;
      }
      this.decimal_36 = !(this.decimal_19 == 0M) ? num1 / this.decimal_55 : -1M;
      if (this.decimal_18 == 0M)
        this.decimal_37 = -1M;
      else
        this.decimal_37 = num1 / this.decimal_54;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2241);
    }
  }

  public int method_185()
  {
    try
    {
      return this.gclass194_0.double_7 > this.gclass1_0.double_7 ? GClass226.int_54 : 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3890);
      return 1;
    }
  }

  public Decimal method_186()
  {
    try
    {
      this.gclass1_0.method_58(this.gclass21_0, this.gclass194_0, true);
      if (this.gclass1_0.decimal_1 == -1M)
        return 0M;
      if (this.gclass1_0.decimal_1 == 0M)
        return 1000000000M;
      Decimal num = this.method_62(AuroraProductionCategory.Infrastructure);
      this.decimal_55 = (Decimal) (int) (this.gclass1_0.decimal_1 * 100M * (Decimal) this.method_185() / this.gclass194_0.decimal_0);
      if (this.decimal_55 < 1M)
        this.decimal_55 = 1M;
      Decimal decimal55 = this.decimal_55;
      return num / decimal55 - this.decimal_4;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2242);
      return 0M;
    }
  }

  public void method_187()
  {
    try
    {
      this.decimal_31 = 1M - this.gclass1_0.decimal_3 / 10000M;
      if (this.decimal_31 < 0M)
        this.decimal_31 = 0M;
      this.decimal_32 = Math.Round(this.gclass1_0.decimal_3 * 0.0025M, 2);
      this.decimal_12 += this.gclass1_0.decimal_3 / 50M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2243);
    }
  }

  public void method_188(Decimal decimal_90, bool bool_10)
  {
    try
    {
      this.decimal_38 = 0M;
      this.decimal_27 = 0M;
      if (this.decimal_18 > 0M)
      {
        Decimal num1 = this.method_62(AuroraProductionCategory.Infrastructure);
        if ((Decimal) this.int_3 > num1)
        {
          if (num1 > 0M)
          {
            Decimal num2 = (Decimal) this.int_3 - num1;
            this.decimal_27 = this.decimal_18 * (num2 / (Decimal) this.int_3);
            if (bool_10)
              this.decimal_38 = 50M * (num2 / (Decimal) this.int_3) * decimal_90;
          }
          else
          {
            this.decimal_27 = this.decimal_18;
            if (bool_10)
              this.decimal_38 = 50M * decimal_90;
          }
        }
      }
      Decimal num3 = 1M;
      if (this.gclass55_0 != null)
        num3 = this.gclass55_0.method_5(GEnum121.const_7);
      if (this.gclass202_0.gclass62_0 != null && this.gclass202_0.gclass62_0.gclass55_0 != null)
        num3 *= this.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_7);
      if (this.decimal_4 > 0M)
      {
        if (this.decimal_18 == -1M)
        {
          this.decimal_35 = -100M;
        }
        else
        {
          if (this.decimal_27 == 0M)
          {
            this.decimal_35 = 20M / (Decimal) Math.Pow((double) this.decimal_4, 1.0 / 3.0);
            if (this.decimal_35 > 10M)
              this.decimal_35 = 10M;
            this.decimal_35 *= num3;
          }
          else
          {
            this.decimal_35 = -(this.decimal_27 * 25M);
            this.decimal_12 += this.decimal_27 * 25M;
          }
          this.decimal_35 *= this.gclass194_0.decimal_1;
          this.decimal_35 -= this.decimal_32;
          if (this.decimal_35 > 0M)
          {
            if (this.gclass1_0.decimal_5 == 0M)
              this.gclass1_0.method_62(this.gclass194_0);
            if (this.gclass1_0.decimal_2 > this.gclass1_0.decimal_5)
            {
              this.decimal_35 = 0M;
              Decimal num4 = this.gclass1_0.decimal_2 - this.gclass1_0.decimal_5;
              if (bool_10)
                this.decimal_38 += 50M * (num4 / this.gclass1_0.decimal_5) * decimal_90;
              this.decimal_12 += (this.gclass1_0.decimal_2 - this.gclass1_0.decimal_5) / this.gclass1_0.decimal_2;
            }
            else if (this.gclass1_0.decimal_2 > this.gclass1_0.decimal_5 / 3M)
              this.decimal_35 *= (this.gclass1_0.decimal_5 - this.gclass1_0.decimal_2) / (this.gclass1_0.decimal_5 * 0.6667M);
          }
        }
      }
      else
        this.decimal_35 = 0M;
      this.decimal_35 /= 100M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2244);
    }
  }

  public Decimal method_189()
  {
    try
    {
      Decimal num = this.decimal_30;
      if (this.gclass21_0.bool_0)
      {
        num -= 0.01M;
        if (num < 0M)
          num = 0M;
      }
      this.decimal_16 = (num + this.method_204() * 20M + this.method_77()) * (Decimal) GClass226.int_23;
      return this.decimal_16;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2245);
      return 0M;
    }
  }

  public Decimal method_190()
  {
    try
    {
      Decimal num = this.decimal_30;
      if (this.gclass21_0.bool_0)
      {
        num -= 0.01M;
        if (num < 0M)
          num = 0M;
      }
      this.decimal_17 = (num * 10M + this.method_204() * 20M + this.method_78()) * (Decimal) GClass226.int_23;
      return this.decimal_17;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2246);
      return 0M;
    }
  }

  public Decimal method_191()
  {
    try
    {
      this.decimal_34 = this.method_55().Sum<GClass103>((Func<GClass103, Decimal>) (gclass103_0 => gclass103_0.method_36())) / 100M;
      return this.decimal_34;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2247);
      return 0M;
    }
  }

  public Decimal method_192(GClass21 gclass21_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1140 class1140 = new GClass146.Class1140();
    // ISSUE: reference to a compiler-generated field
    class1140.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1140.gclass21_0 = gclass21_2;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1140.method_0)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Where<GClass39>(new Func<GClass39, bool>(class1140.method_1)).Sum<GClass39>((Func<GClass39, Decimal>) (gclass39_0 => gclass39_0.method_4())) / 100M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2248);
      return 0M;
    }
  }

  public double method_193()
  {
    try
    {
      this.double_1 = (double) this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass146_0 == this)).Sum<GClass193>((Func<GClass193, Decimal>) (gclass193_0 => gclass193_0.decimal_0 * (Decimal) gclass193_0.int_1)) / 25.0;
      return this.double_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2249);
      return 0.0;
    }
  }

  public GClass85 method_194(AuroraClassMainFunction auroraClassMainFunction_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1141 class1141 = new GClass146.Class1141();
    // ISSUE: reference to a compiler-generated field
    class1141.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1141.auroraClassMainFunction_0 = auroraClassMainFunction_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      foreach (GClass85 gclass85 in this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1141.method_0)).ToList<GClass85>())
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        if (gclass85.method_176().Where<GClass40>(class1141.func_0 ?? (class1141.func_0 = new Func<GClass40, bool>(class1141.method_1))).Count<GClass40>() > 0)
          return gclass85;
      }
      return (GClass85) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2250);
      return (GClass85) null;
    }
  }

  public List<GClass40> method_195(GClass22 gclass22_0, bool bool_10, bool bool_11, bool bool_12)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1142 class1142 = new GClass146.Class1142();
    // ISSUE: reference to a compiler-generated field
    class1142.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1142.gclass22_0 = gclass22_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1142.method_0)).OrderBy<GClass40, string>((Func<GClass40, string>) (gclass40_0 => gclass40_0.ShipName)).ToList<GClass40>();
      if (bool_10)
        list = list.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.dictionary_5.Count == 0 && gclass40_0.list_12.Count == 0)).OrderBy<GClass40, string>((Func<GClass40, string>) (gclass40_0 => gclass40_0.ShipName)).ToList<GClass40>();
      if (bool_11)
        list = list.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.dictionary_5.Count > 0 || gclass40_0.list_12.Count > 0)).OrderBy<GClass40, string>((Func<GClass40, string>) (gclass40_0 => gclass40_0.ShipName)).ToList<GClass40>();
      if (bool_12)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        list = list.Where<GClass40>(new Func<GClass40, bool>(new GClass146.Class1143()
        {
          list_0 = this.gclass0_0.dictionary_32.Values.Where<GClass192>(new Func<GClass192, bool>(class1142.method_1)).Select<GClass192, GClass40>((Func<GClass192, GClass40>) (gclass192_0 => gclass192_0.gclass40_0)).ToList<GClass40>()
        }.method_0)).OrderBy<GClass40, string>((Func<GClass40, string>) (gclass40_0 => gclass40_0.ShipName)).ToList<GClass40>();
      }
      return list;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2251);
      return (List<GClass40>) null;
    }
  }

  public List<GClass40> method_196()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.method_520(gclass40_0.gclass85_0.double_2, this.method_87(), gclass40_0.gclass85_0.double_3, this.method_88()) && gclass40_0.method_157(AuroraComponentType.TroopTransport, false) > 0M && gclass40_0.gclass21_0 == this.gclass21_0)).OrderBy<GClass40, string>((Func<GClass40, string>) (gclass40_0 => gclass40_0.ShipName)).ToList<GClass40>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2252);
      return (List<GClass40>) null;
    }
  }

  public List<GClass40> method_197()
  {
    try
    {
      List<GClass40> gclass40List = new List<GClass40>();
      foreach (GClass40 gclass40 in this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => this.gclass0_0.method_520(gclass40_0.gclass85_0.double_2, this.method_87(), gclass40_0.gclass85_0.double_3, this.method_88()) && gclass40_0.gclass21_0 != this.gclass21_0)).ToList<GClass40>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1144 class1144 = new GClass146.Class1144();
        // ISSUE: reference to a compiler-generated field
        class1144.gclass146_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1144.gclass40_0 = gclass40;
        // ISSUE: reference to a compiler-generated method
        Decimal num = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class1144.method_0)).Select<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_0)).FirstOrDefault<Decimal>();
        if (num > 0M)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1144.gclass40_0.ContactDropdownName = this.gclass21_0.method_32(class1144.gclass40_0);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1144.gclass40_0.ContactDropdownName = $"{class1144.gclass40_0.ContactDropdownName}  {GClass226.smethod_38(num * GClass226.decimal_17)} tons";
          // ISSUE: reference to a compiler-generated field
          gclass40List.Add(class1144.gclass40_0);
        }
      }
      return gclass40List;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2253);
      return (List<GClass40>) null;
    }
  }

  public List<GClass146> method_198()
  {
    try
    {
      List<GClass146> gclass146List = new List<GClass146>();
      foreach (GClass146 gclass146 in this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass1_0 == this.gclass1_0 && gclass146_1.gclass21_0 != this.gclass21_0)).ToList<GClass146>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass146.Class1145 class1145 = new GClass146.Class1145();
        // ISSUE: reference to a compiler-generated field
        class1145.gclass146_1 = this;
        // ISSUE: reference to a compiler-generated field
        class1145.gclass146_0 = gclass146;
        // ISSUE: reference to a compiler-generated field
        if (this.gclass21_0.dictionary_10.ContainsKey(class1145.gclass146_0.gclass21_0.RaceID))
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1145.gclass146_0.ContactDropdownName = this.gclass21_0.dictionary_10[class1145.gclass146_0.gclass21_0.RaceID].AlienRaceName + "   ";
          // ISSUE: reference to a compiler-generated method
          Decimal decimal_73_1 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class1145.method_0)).Select<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_0)).FirstOrDefault<Decimal>();
          if (decimal_73_1 > 0M)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1145.gclass146_0.ContactDropdownName = $"{class1145.gclass146_0.ContactDropdownName}Thermal {GClass226.smethod_38(decimal_73_1)}    ";
          }
          // ISSUE: reference to a compiler-generated method
          Decimal decimal_73_2 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class1145.method_1)).Select<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_0)).FirstOrDefault<Decimal>();
          if (decimal_73_2 > 0M)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1145.gclass146_0.ContactDropdownName = $"{class1145.gclass146_0.ContactDropdownName}EM {GClass226.smethod_38(decimal_73_2)}";
          }
          if (decimal_73_1 > 0M || decimal_73_2 > 0M)
          {
            // ISSUE: reference to a compiler-generated field
            gclass146List.Add(class1145.gclass146_0);
          }
        }
      }
      return gclass146List;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2254);
      return (List<GClass146>) null;
    }
  }

  public void method_199(GClass22 gclass22_0, ComboBox comboBox_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1146 class1146 = new GClass146.Class1146();
    // ISSUE: reference to a compiler-generated field
    class1146.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1146.gclass22_0 = gclass22_0;
    try
    {
      comboBox_0.DataSource = (object) null;
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list1 = this.gclass0_0.dictionary_32.Values.Where<GClass192>(new Func<GClass192, bool>(class1146.method_0)).Select<GClass192, GClass40>((Func<GClass192, GClass40>) (gclass192_0 => gclass192_0.gclass40_0)).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list2 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1146.method_1)).Where<GClass40>(new Func<GClass40, bool>(class1146.method_2)).Except<GClass40>((IEnumerable<GClass40>) list1).OrderBy<GClass40, string>((Func<GClass40, string>) (gclass40_0 => gclass40_0.ShipName)).ToList<GClass40>();
      if (list2.Count > 0)
      {
        comboBox_0.DisplayMember = "ShipName";
        comboBox_0.DataSource = (object) list2;
        comboBox_0.SelectedItem = (object) list2[0];
      }
      else
        comboBox_0.DataSource = (object) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2255);
    }
  }

  public void method_200(GClass193 gclass193_0, ComboBox comboBox_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass146.Class1147 class1147 = new GClass146.Class1147();
    // ISSUE: reference to a compiler-generated field
    class1147.gclass146_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1147.gclass193_0 = gclass193_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list1 = this.gclass0_0.dictionary_32.Values.Where<GClass192>(new Func<GClass192, bool>(class1147.method_0)).Select<GClass192, GClass40>((Func<GClass192, GClass40>) (gclass192_0 => gclass192_0.gclass40_0)).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass22> list2 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1147.method_1)).Where<GClass40>(new Func<GClass40, bool>(class1147.method_2)).Except<GClass40>((IEnumerable<GClass40>) list1).OrderBy<GClass40, string>((Func<GClass40, string>) (gclass40_0 => gclass40_0.ShipName)).ToList<GClass40>().Where<GClass40>(new Func<GClass40, bool>(class1147.method_3)).Select<GClass40, GClass22>((Func<GClass40, GClass22>) (gclass40_0 => gclass40_0.gclass22_0)).Distinct<GClass22>().ToList<GClass22>();
      if (list2.Count > 0)
      {
        comboBox_0.DisplayMember = "ClassName";
        comboBox_0.DataSource = (object) list2;
        comboBox_0.SelectedItem = (object) list2[0];
      }
      else
        comboBox_0.DataSource = (object) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2256);
    }
  }

  public List<GClass85> method_201()
  {
    try
    {
      return this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => this.gclass0_0.method_520(gclass85_3.double_2, this.method_87(), gclass85_3.double_3, this.method_88()) && gclass85_3.genum106_0 == GEnum106.const_0 && gclass85_3.gclass21_0 == this.gclass21_0)).OrderBy<GClass85, string>((Func<GClass85, string>) (gclass85_0 => gclass85_0.FleetName)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2257);
      return (List<GClass85>) null;
    }
  }

  public int method_202(AuroraComponentType auroraComponentType_0)
  {
    try
    {
      int num = 0;
      foreach (GClass85 gclass85 in this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => this.gclass0_0.method_520(gclass85_3.double_2, this.method_87(), gclass85_3.double_3, this.method_88()) && gclass85_3.genum106_0 == GEnum106.const_0 && gclass85_3.gclass21_0 == this.gclass21_0)).ToList<GClass85>())
      {
        if (gclass85.gclass146_0 == null)
          gclass85.gclass146_0 = this;
        if (gclass85.gclass146_0 == this)
          num += gclass85.method_127(auroraComponentType_0);
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2258);
      return 0;
    }
  }

  public Decimal method_203(AuroraComponentType auroraComponentType_0, GEnum121 genum121_3)
  {
    try
    {
      Decimal num1 = 0M;
      foreach (GClass85 gclass85 in this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_3 => this.gclass0_0.method_520(gclass85_3.double_2, this.method_87(), gclass85_3.double_3, this.method_88()) && gclass85_3.gclass21_0 == this.gclass21_0)).ToList<GClass85>())
      {
        if (gclass85.gclass146_0 == null)
          gclass85.gclass146_0 = this;
        if (gclass85.gclass146_0 == this)
        {
          Decimal num2 = gclass85.method_125(auroraComponentType_0);
          if (!(num2 == 0M))
          {
            Decimal num3 = gclass85.gclass83_0.method_5(gclass85.gclass202_0.gclass200_0.int_0, genum121_3);
            num1 += num2 * num3;
          }
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2259);
      return 0M;
    }
  }

  public Decimal method_204()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass193 gclass193 in this.gclass0_0.dictionary_31.Values.Where<GClass193>((Func<GClass193, bool>) (gclass193_0 => gclass193_0.gclass146_0 == this && gclass193_0.gclass40_1 == null)).ToList<GClass193>())
      {
        if (gclass193.auroraShipyardType_0 == AuroraShipyardType.Naval)
          num += (Decimal) gclass193.int_1 * gclass193.decimal_0 * 0.00025M;
        else
          num += (Decimal) gclass193.int_1 * gclass193.decimal_0 * 0.000025M;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2260);
      return 0M;
    }
  }
}
