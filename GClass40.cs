// Decompiled with JetBrains decompiler
// Type: GClass40
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
public partial class GClass40
{
  public List<GClass54> list_0 = new List<GClass54>();
  public List<GClass180> list_1 = new List<GClass180>();
  public List<GClass31> list_2 = new List<GClass31>();
  public List<GClass32> list_3 = new List<GClass32>();
  public List<GClass36> list_4 = new List<GClass36>();
  public List<GClass30> list_5 = new List<GClass30>();
  public List<GClass35> list_6 = new List<GClass35>();
  public List<GClass27> list_7 = new List<GClass27>();
  public List<GClass28> list_8 = new List<GClass28>();
  public List<GClass130> list_9 = new List<GClass130>();
  public List<GClass130> list_10 = new List<GClass130>();
  public List<GClass177> list_11 = new List<GClass177>();
  public List<GClass178> list_12 = new List<GClass178>();
  public List<GClass26> list_13 = new List<GClass26>();
  public List<GClass66> list_14 = new List<GClass66>();
  public List<GClass182> list_15 = new List<GClass182>();
  public Dictionary<int, GClass70> dictionary_0 = new Dictionary<int, GClass70>();
  public List<GClass132> list_16 = new List<GClass132>();
  public Dictionary<AuroraCommandType, GClass55> dictionary_1 = new Dictionary<AuroraCommandType, GClass55>();
  public Dictionary<AuroraInstallationType, GClass158> dictionary_2 = new Dictionary<AuroraInstallationType, GClass158>();
  public Dictionary<int, GClass191> dictionary_3 = new Dictionary<int, GClass191>();
  public List<GClass73> list_17 = new List<GClass73>();
  public List<GClass181> list_18 = new List<GClass181>();
  public GClass123 gclass123_0;
  public Dictionary<GClass101, GClass104> dictionary_4 = new Dictionary<GClass101, GClass104>();
  public Dictionary<int, int> dictionary_5 = new Dictionary<int, int>();
  public Dictionary<int, GClass178> dictionary_6 = new Dictionary<int, GClass178>();
  public List<GClass183> list_19 = new List<GClass183>();
  public List<GClass21> list_20 = new List<GClass21>();
  public int int_0;
  public int int_1;
  public int int_2;
  public Decimal decimal_0;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public bool bool_4;
  public bool bool_5;
  public bool bool_6;
  public bool bool_7;
  public GClass21 gclass21_0;
  public GClass194 gclass194_0;
  public GClass22 gclass22_0;
  public GClass85 gclass85_0;
  public GClass84 gclass84_0;
  public GClass40 gclass40_0;
  public GClass40 gclass40_1;
  public GClass40 gclass40_2;
  public GClass40 gclass40_3;
  public GClass193 gclass193_0;
  public GClass187 gclass187_0;
  public GClass70 gclass70_0;
  public GClass103 gclass103_0;
  public AuroraRefuelStatus auroraRefuelStatus_0;
  public AuroraResupplyStatus auroraResupplyStatus_0;
  public AuroraOrdnanceTransferStatus auroraOrdnanceTransferStatus_0;
  public GEnum43 genum43_0;
  public GEnum29 genum29_0;
  public GEnum78 genum78_0;
  public GClass5 gclass5_0;
  private GClass0 gclass0_0;
  public int int_8;
  public int int_9;
  public int int_10;
  public int int_11;
  public int int_12;
  public int int_13;
  public int int_14;
  public int int_15;
  public int int_16;
  public int int_17;
  public int int_18 = 5;
  public int int_19 = 5;
  public int int_20;
  public int int_21;
  public int int_22;
  public int int_23 = 50;
  public int int_24;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public Decimal decimal_8;
  public Decimal decimal_9 = 1M;
  public Decimal decimal_10;
  public Decimal decimal_11;
  public Decimal decimal_12;
  public Decimal decimal_13;
  public Decimal decimal_14;
  public Decimal decimal_15;
  public Decimal decimal_16;
  public Decimal decimal_17;
  public bool bool_8;
  public bool bool_9;
  public bool bool_10;
  public bool bool_11;
  public bool bool_12;
  public bool bool_13;
  public bool bool_14;
  public bool bool_15;
  public bool bool_16;
  public string string_0;
  public string string_1 = "";
  public string string_2 = "";
  public int int_25;
  public Decimal decimal_18;
  public Decimal decimal_19;
  public Decimal decimal_20;
  public Decimal decimal_21;
  public int int_26;
  public int int_27;
  public int int_28;
  public int int_29;
  public int int_30;
  public int int_31;
  public Decimal decimal_22;
  public Decimal decimal_23;
  public Decimal decimal_24;
  public Decimal decimal_25;
  public bool bool_17;
  public bool bool_18;
  public bool bool_19;
  public int int_32;
  public int int_33;
  public GEnum121 genum121_0;
  public Decimal decimal_26;
  public int int_34;
  public Decimal decimal_27;
  public Decimal decimal_28;
  public Decimal decimal_29;
  public Decimal decimal_30;
  public Decimal decimal_31;
  public Decimal decimal_32;
  public Decimal decimal_33;
  public Decimal decimal_34;
  public string string_3 = "";
  public bool bool_20;
  public Decimal decimal_35 = 1M;
  public Decimal decimal_36;
  public Decimal decimal_37;
  public Decimal decimal_38;
  public Decimal decimal_39;
  public Decimal decimal_40;
  public int int_35;
  public int int_36;
  public int int_37;
  public int int_38;
  public double double_0 = 1.0;
  public double double_1;
  public double double_2;
  public double double_3;
  public Decimal decimal_41;
  public bool bool_21;
  public int int_39;
  public string string_4 = "";
  public GClass221 gclass221_0;
  public AuroraContactStatus auroraContactStatus_0 = AuroraContactStatus.None;
  public GEnum79 genum79_0;

  public GEnum51 method_0(
    GClass230 gclass230_0,
    GClass129 gclass129_0,
    Decimal decimal_42,
    bool bool_22,
    GClass117 gclass117_0,
    bool bool_23,
    bool bool_24,
    GClass37 gclass37_0)
  {
    try
    {
      GEnum51 genum51 = GEnum51.const_0;
      bool flag1 = false;
      bool flag2 = false;
      bool bool_23_1 = false;
      bool flag3 = false;
      Decimal num1 = 0M;
      int num2 = (int) Math.Floor(decimal_42);
      if (gclass230_0 != null)
      {
        flag1 = gclass230_0.bool_8;
        flag2 = gclass230_0.bool_9;
        bool_23_1 = gclass230_0.bool_10;
        num1 = gclass230_0.decimal_12;
        if (gclass230_0.genum87_0 == GEnum87.const_5)
          flag3 = true;
      }
      if (this.decimal_3 > 0M && !flag2 && !bool_22 && !bool_23 && !bool_24)
      {
        if (bool_23_1)
          decimal_42 *= 3M;
        if (this.decimal_3 >= decimal_42)
        {
          this.decimal_3 -= decimal_42;
          this.decimal_0 += decimal_42;
          gclass117_0?.method_9(decimal_42, GEnum51.const_1);
          return GEnum51.const_1;
        }
        decimal_42 -= this.decimal_3;
        this.decimal_0 += this.decimal_3;
        num2 -= (int) Math.Floor(this.decimal_3);
        gclass117_0?.method_9(this.decimal_3, GEnum51.const_1);
        this.decimal_3 = 0M;
        if (bool_23_1)
          decimal_42 /= 3M;
      }
      int num3 = 0;
      if (!bool_23_1)
      {
        Decimal num4 = decimal_42 / this.gclass22_0.decimal_14 * 1000M;
        if (num4 >= 50M && (Decimal) GClass226.smethod_13(1000) < num4)
        {
          Decimal d = decimal_42 / 5M;
          Decimal num5 = d * 100M;
          Decimal int_72 = Math.Floor(d);
          int num6 = (int) (num5 % 100M);
          if (GClass226.smethod_13(100) <= num6)
            ++int_72;
          num3 = GClass226.smethod_13((int) int_72);
        }
      }
      Decimal num7 = decimal_42 * (100M / this.gclass22_0.decimal_14);
      if (this.gclass22_0.bool_2)
        num7 /= 10M;
      this.decimal_15 += num7;
      int int_136 = 1;
      if (gclass230_0 != null)
      {
        if (gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Carronade)
          int_136 = 1;
        if (gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Laser)
          int_136 = 3;
        if (gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Railgun)
          int_136 = 2;
        if (gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ParticleBeam && gclass230_0.genum87_0 == GEnum87.const_0)
          int_136 = 2;
        if (gclass230_0.genum87_0 == GEnum87.const_3)
          int_136 = 0;
      }
      else if (gclass129_0 != null && gclass129_0.decimal_1 > 0M)
        int_136 = 3;
      int num8 = 0;
      int num9 = 0;
      int num10 = 0;
      if (!flag1 && !bool_22 && !bool_23 && !bool_24 && this.gclass22_0.int_37 == 0)
      {
        Dictionary<int, int> dictionary = this.gclass0_0.method_24(int_136, (int) Math.Floor(decimal_42));
        genum51 = GEnum51.const_2;
        int key = GClass226.smethod_13(this.gclass22_0.int_3);
        foreach (int num11 in dictionary.Values)
        {
          if (num11 > num9)
          {
            num9 = num11;
            num10 = key;
          }
          if (!this.dictionary_5.ContainsKey(key))
            this.dictionary_5.Add(key, 0);
          if (this.dictionary_5[key] >= this.gclass22_0.int_2)
            num8 += num11;
          else if (num1 > 0M)
          {
            int y = this.gclass22_0.int_2 - this.dictionary_5[key];
            int num12 = (int) (Math.Pow((double) (1M - num1), (double) y) * 1000.0);
            if (GClass226.smethod_13(1000) < num12)
            {
              ++num8;
            }
            else
            {
              this.dictionary_5[key]++;
              ++this.int_0;
              gclass117_0?.method_9(1M, GEnum51.const_2);
            }
          }
          else if (this.dictionary_5[key] + num11 <= this.gclass22_0.int_2)
          {
            this.dictionary_5[key] += num11;
            this.int_0 += num11;
            if (gclass117_0 != null)
            {
              gclass117_0.method_9((Decimal) num11, GEnum51.const_2);
              gclass117_0.gclass115_0.method_12(num11);
            }
          }
          else
          {
            int int_8 = this.gclass22_0.int_2 - this.dictionary_5[key];
            this.int_0 += int_8;
            if (gclass117_0 != null)
            {
              gclass117_0.gclass115_0.method_12(int_8);
              gclass117_0.method_9((Decimal) num11, GEnum51.const_2);
            }
            num8 += num11 - int_8;
            this.dictionary_5[key] = this.gclass22_0.int_2;
          }
          ++key;
          if (key > this.gclass22_0.int_3)
            key = 1;
        }
      }
      else
        num8 = (int) Math.Floor(decimal_42);
      int num13 = num8 + num3;
      gclass117_0?.method_9((Decimal) num13, GEnum51.const_3);
      if (num13 > 0)
        genum51 = GEnum51.const_3;
      while (num13 > 0)
      {
        num13 = this.method_2(num13, false, bool_23_1);
        if (num13 == -1)
        {
          if (gclass117_0 != null && gclass37_0 != null)
          {
            this.method_1(gclass117_0.gclass21_1, gclass37_0);
            gclass117_0.bool_0 = true;
          }
          return GEnum51.const_4;
        }
      }
      if (flag3)
      {
        Decimal num14 = (Decimal) (120 / num2);
        if (num14 < 5M)
          num14 = 5M;
        else if (num14 % 5M > 0M)
          num14 += 5M - num14 % 5M;
        this.gclass0_0.list_6.Add(new GClass25()
        {
          gclass40_0 = this,
          int_1 = (int) num14,
          int_2 = num2,
          decimal_0 = this.gclass0_0.decimal_0,
          int_0 = num13 <= 0 ? num10 : 0
        });
      }
      return genum51;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 327);
      return GEnum51.const_0;
    }
  }

  public void method_1(GClass21 gclass21_1, GClass37 gclass37_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class803 class803 = new GClass40.Class803();
    // ISSUE: reference to a compiler-generated field
    class803.gclass40_0 = this;
    // ISSUE: reference to a compiler-generated field
    class803.gclass21_0 = gclass21_1;
    // ISSUE: reference to a compiler-generated field
    class803.gclass37_0 = gclass37_0;
    try
    {
      List<GClass21> gclass21List1 = new List<GClass21>();
      List<GClass21> gclass21List2 = new List<GClass21>();
      // ISSUE: reference to a compiler-generated method
      List<GClass21> list = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class803.method_0)).Select<GClass65, GClass21>((Func<GClass65, GClass21>) (gclass65_0 => gclass65_0.gclass21_1)).Distinct<GClass21>().ToList<GClass21>();
      // ISSUE: reference to a compiler-generated field
      if (class803.gclass37_0.gclass40_0 != null)
      {
        // ISSUE: reference to a compiler-generated method
        gclass21List1 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class803.method_1)).Select<GClass65, GClass21>((Func<GClass65, GClass21>) (gclass65_0 => gclass65_0.gclass21_1)).Distinct<GClass21>().ToList<GClass21>();
      }
      // ISSUE: reference to a compiler-generated field
      if (class803.gclass37_0.gclass39_0 != null)
      {
        // ISSUE: reference to a compiler-generated method
        gclass21List2 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class803.method_2)).Select<GClass65, GClass21>((Func<GClass65, GClass21>) (gclass65_0 => gclass65_0.gclass21_1)).Distinct<GClass21>().ToList<GClass21>();
      }
      foreach (GClass21 gclass21 in list)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        GClass117 gclass117_1 = gclass21.dictionary_12.Values.FirstOrDefault<GClass117>(class803.func_0 ?? (class803.func_0 = new Func<GClass117, bool>(class803.method_3)));
        if (gclass117_1 != null)
        {
          gclass117_1.bool_0 = true;
          string string_0 = $"[{gclass117_1.gclass110_0.string_0}] {gclass117_1.method_11()} has been destroyed";
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (gclass21List1.Count > 0 && class803.gclass37_0.gclass230_0 != null && class803.gclass37_0.gclass230_0.bool_4)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            GClass117 gclass117_2 = gclass21.dictionary_12.Values.FirstOrDefault<GClass117>(class803.func_1 ?? (class803.func_1 = new Func<GClass117, bool>(class803.method_4)));
            if (gclass117_2 != null)
              string_0 = $"{string_0} by energy weapon fire from [{gclass117_2.gclass110_0.string_0}] {gclass117_2.method_11()}";
          }
          if (gclass21List2.Count > 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            GClass113 gclass113 = gclass21.dictionary_13.Values.FirstOrDefault<GClass113>(class803.func_2 ?? (class803.func_2 = new Func<GClass113, bool>(class803.method_5)));
            if (gclass113 != null)
              string_0 = $"{string_0} by energy weapon fire from STO weapons based at [{gclass113.gclass110_0.string_0}] {gclass113.string_0}";
          }
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_66, string_0, this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 327);
    }
  }

  public int method_2(int int_40, bool bool_22, bool bool_23)
  {
    try
    {
      int num1 = 0;
      GClass228 gclass228_0_1;
      do
      {
        ++num1;
        if (bool_23)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          gclass228_0_1 = this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(new GClass40.Class838()
          {
            int_0 = GClass226.smethod_13(this.gclass22_0.int_22)
          }.method_0)).OrderBy<GClass228, int>((Func<GClass228, int>) (gclass228_0 => gclass228_0.int_2)).FirstOrDefault<GClass228>();
        }
        else
          goto label_6;
label_2:
        int num2 = this.method_158(gclass228_0_1);
        if (num2 > 0 && (!bool_22 || !gclass228_0_1.gclass230_0.bool_6))
        {
          int num3 = (int) ((Decimal) num2 / gclass228_0_1.decimal_0 * 100M);
          if (GClass226.smethod_13(100) <= num3)
            goto label_10;
        }
        if (num1 != 20 || bool_23)
          continue;
        goto label_44;
label_6:
        do
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          IEnumerable<GClass228> source = this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(new GClass40.Class837()
          {
            int_0 = GClass226.smethod_13(this.gclass22_0.int_31)
          }.method_0));
          // ISSUE: reference to a compiler-generated field
          Func<GClass228, int> func = GClass40.staticCompGen.staticCompMem__2_1;
          if (func == null)
            goto label_8;
          goto label_74;
label_7:
          Func<GClass228, int> keySelector;
          gclass228_0_1 = source.OrderBy<GClass228, int>(keySelector).FirstOrDefault<GClass228>();
          continue;
label_74:
          keySelector = func;
          goto label_7;
label_8:
          // ISSUE: reference to a compiler-generated field
          GClass40.staticCompGen.staticCompMem__2_1 = keySelector = (Func<GClass228, int>) (gclass228_0 => gclass228_0.int_2);
          goto label_7;
        }
        while (bool_22 && gclass228_0_1.gclass230_0.bool_6);
        goto label_2;
      }
      while (num1 < 20 || !bool_23);
      goto label_72;
label_10:
      if (bool_22)
      {
        int num4 = (int) Math.Round((this.gclass0_0.decimal_0 - this.decimal_7) / GClass226.decimal_31 / this.gclass22_0.decimal_9 * 100M);
        string str1 = $" Maintenance Clock: {GClass226.smethod_42((this.gclass0_0.decimal_0 - this.decimal_6) / GClass226.decimal_29, 2)} years. Average Class Maintenance Life: {GClass226.smethod_42(this.gclass22_0.method_89(), 2)} years. Current Deployment: {num4.ToString()}%";
        if (this.decimal_4 >= gclass228_0_1.gclass230_0.decimal_2)
        {
          string str2 = "";
          if (this.gclass85_0.method_180() > 1)
            str2 = $" ({this.gclass85_0.FleetName})";
          this.decimal_4 -= gclass228_0_1.gclass230_0.decimal_2;
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_89, $"A {gclass228_0_1.gclass230_0.Name} on {this.method_187()}{str2} has suffered a maintenance failure. Repairs have been carried out that required {GClass226.smethod_42(gclass228_0_1.gclass230_0.decimal_2, 2)} maintenance supplies. The ship has {GClass226.smethod_38(this.decimal_4)} maintenance supplies remaining.{str1}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          return 0;
        }
      }
      else
      {
        if (bool_23 && gclass228_0_1.gclass230_0.int_2 < 100 && GClass226.smethod_13(100) > gclass228_0_1.gclass230_0.int_2)
        {
          int_40 -= gclass228_0_1.gclass230_0.int_4;
          return int_40 < 1 ? 0 : int_40;
        }
        if (int_40 < gclass228_0_1.gclass230_0.int_4)
        {
          int num5 = (int) ((Decimal) int_40 / (Decimal) gclass228_0_1.gclass230_0.int_4 * 100M);
          if (GClass226.smethod_13(100) > num5)
          {
            ++this.int_2;
            return 0;
          }
          int_40 = 0;
        }
        else
          int_40 -= gclass228_0_1.gclass230_0.int_4;
      }
      if (!bool_22)
      {
        if (this.decimal_4 >= gclass228_0_1.gclass230_0.decimal_2)
        {
          int num6 = (int) Math.Floor(this.method_154());
          if (GClass226.smethod_13(100) <= num6)
          {
            string str = "";
            if (this.gclass85_0.method_180() > 1)
              str = $" ({this.gclass85_0.FleetName})";
            this.decimal_4 -= gclass228_0_1.gclass230_0.decimal_2;
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_219, $"A {gclass228_0_1.gclass230_0.Name} on {this.method_187()}{str} was struck by enemy fire but continued functioning due to the efforts of damage control teams. {gclass228_0_1.gclass230_0.decimal_2.ToString()} maintenance supplies were expended. The ship has {GClass226.smethod_38(this.decimal_4)} maintenance supplies remaining.", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            return int_40;
          }
        }
        if (this.gclass22_0.int_11 > 0)
        {
          int num7 = (int) ((double) gclass228_0_1.gclass230_0.int_1 * (0.25 + 0.05 * (double) GClass226.smethod_13(10)));
          if (num7 > this.int_11 - 1)
            num7 = this.int_11 - 1;
          this.int_11 -= num7;
          this.int_1 += num7;
        }
        this.method_13(gclass228_0_1.gclass230_0);
        List<GClass103> list1 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.genum44_0 == GEnum44.const_1 && gclass103_0.gclass40_0 != null)).Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).ToList<GClass103>();
        if (list1.Count > 0)
        {
          Decimal num8 = gclass228_0_1.gclass230_0.decimal_1 / this.gclass22_0.decimal_14;
          List<GClass103> list2 = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.genum44_0 == GEnum44.const_0 && gclass103_1.gclass21_0 == this.gclass21_0 && gclass103_1.gclass40_0 != null)).Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).ToList<GClass103>();
          list1.AddRange((IEnumerable<GClass103>) list2);
          foreach (GClass103 gclass103 in list1)
          {
            num8 *= 0.25M + 0.05M * (Decimal) GClass226.smethod_13(10);
            Decimal decimal_26 = num8;
            gclass103.method_5(decimal_26);
          }
        }
      }
      else
      {
        string str3 = "";
        if (this.gclass85_0.method_180() > 1)
          str3 = $" ({this.gclass85_0.FleetName})";
        string str4 = $" Current Maintenance Clock: {GClass226.smethod_42((this.gclass0_0.decimal_0 - this.decimal_6) / GClass226.decimal_29, 2)} years";
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_229, $"A {gclass228_0_1.gclass230_0.Name} on {this.method_187()}{str3} has been damaged due to a maintenance failure. Insufficient maintenance supplies were available to effect an immediate repair. The ship has {GClass226.smethod_38(this.decimal_4)} maintenance supplies remaining.{str4}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      }
      int num9 = this.method_4(gclass228_0_1);
      return int_40 + num9;
label_44:
      foreach (GClass37 gclass37 in this.gclass0_0.list_22.Where<GClass37>((Func<GClass37, bool>) (gclass37_0 => gclass37_0.auroraContactType_0 == AuroraContactType.Ship && gclass37_0.int_0 == this.int_8)).ToList<GClass37>())
      {
        string string_0 = "";
        string str5 = "";
        if (gclass37.int_3 > 0)
          str5 = $"{str5}    Shield Hits {gclass37.int_3.ToString()}";
        if (gclass37.int_4 > 0)
          str5 = $"{str5}    Armour Hits {gclass37.int_4.ToString()}";
        if (gclass37.int_5 > 0)
          str5 = $"{str5}    Penetrating Hits {gclass37.int_5.ToString()}";
        if (gclass37.gclass39_0 != null)
        {
          string str6 = gclass37.gclass39_0.gclass103_0.gclass146_0.gclass1_0.method_78(gclass37.gclass21_0);
          if (str6 != null)
            string_0 = $"{this.method_187()} attacked by surface-based energy weapons based on {str6}.    Range {GClass226.smethod_39((Decimal) gclass37.double_1)} km    Shots {gclass37.int_1.ToString()}    Damage per Hit {GClass226.smethod_42(gclass37.decimal_0, 3)}{str5}";
          else
            string_0 = $"{this.method_187()} attacked by unknown energy weapons.   Damage per Hit {GClass226.smethod_42(gclass37.decimal_0, 3)}{str5}";
        }
        else if (gclass37.gclass230_0 != null)
        {
          GClass117 gclass117 = gclass37.gclass21_0.method_267(gclass37.gclass40_0);
          if (gclass117 != null)
            string_0 = $"{this.method_187()} attacked by {gclass117.method_11()} using energy weapons.    Range {GClass226.smethod_39((Decimal) gclass37.double_1)} km    Shots {gclass37.int_1.ToString()}    Damage per Hit {GClass226.smethod_42(gclass37.decimal_0, 3)}{str5}";
          else
            string_0 = $"{this.method_187()} attacked by unknown ship using energy weapons.   Damage per Hit {GClass226.smethod_42(gclass37.decimal_0, 3)}{str5}";
        }
        else if (gclass37.gclass129_0 != null)
          string_0 = $"{this.method_187()} attacked by missiles.   Damage per Hit {GClass226.smethod_42(gclass37.decimal_0, 3)}{str5}";
        else if (gclass37.genum62_0 == GEnum62.const_1)
          string_0 = $"{this.method_187()} rammed by enemy ship.   Damage received {GClass226.smethod_42(gclass37.decimal_0, 3)}{str5}";
        else if (gclass37.genum62_0 == GEnum62.const_2)
          string_0 = $"{this.method_187()} rammed enemy ship. Self-inflicted damage {GClass226.smethod_42(gclass37.decimal_0, 3)}{str5}";
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_213, string_0, this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.CombatResults);
        gclass37.gclass21_0 = (GClass21) null;
      }
      this.bool_9 = true;
      this.gclass0_0.list_23.Add(this);
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_20, $"{this.method_187()} has suffered a catastrophic failure and exploded!{this.method_6()}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      GClass85 gclass850 = this.gclass85_0;
      this.gclass21_0.method_303(this, GEnum22.const_1);
      if (gclass850 != null)
        gclass850.int_6 = gclass850.method_195();
      return -1;
label_72:
      return 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 328);
      return 0;
    }
  }

  public void method_3(GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class877 class877 = new GClass40.Class877();
    // ISSUE: reference to a compiler-generated field
    class877.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass40.Class878 class878 = new GClass40.Class878();
      // ISSUE: reference to a compiler-generated field
      class878.class877_0 = class877;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (!this.gclass22_0.dictionary_0.ContainsKey(class878.class877_0.gclass230_0.int_0))
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      GClass178 gclass178 = this.list_12.FirstOrDefault<GClass178>(new Func<GClass178, bool>(class878.class877_0.method_0));
      if (gclass178 != null)
      {
        ++gclass178.int_0;
      }
      else
      {
        gclass178 = new GClass178();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass178.gclass230_0 = class878.class877_0.gclass230_0;
        gclass178.int_0 = 1;
        this.list_12.Add(gclass178);
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      GClass228 gclass228 = this.gclass22_0.dictionary_0[class878.class877_0.gclass230_0.int_0];
      // ISSUE: reference to a compiler-generated field
      class878.int_0 = (int) gclass228.decimal_0 - gclass178.int_0;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class878.method_0)).ToList<GClass31>())
        this.list_2.Remove(gclass31);
      // ISSUE: reference to a compiler-generated method
      foreach (GClass27 gclass27 in this.list_7.Where<GClass27>(new Func<GClass27, bool>(class878.method_1)).ToList<GClass27>())
        this.list_7.Remove(gclass27);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 329);
    }
  }

  public int method_4(GClass228 gclass228_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class886 class886 = new GClass40.Class886();
    // ISSUE: reference to a compiler-generated field
    class886.gclass228_0 = gclass228_0;
    // ISSUE: reference to a compiler-generated field
    class886.gclass40_0 = this;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass40.Class887 class887 = new GClass40.Class887();
      // ISSUE: reference to a compiler-generated field
      class887.class886_0 = class886;
      // ISSUE: reference to a compiler-generated field
      class887.int_0 = 0;
      int decimal_13 = 0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      GClass178 gclass178 = this.list_12.FirstOrDefault<GClass178>(new Func<GClass178, bool>(class887.class886_0.method_0));
      if (gclass178 != null)
      {
        ++gclass178.int_0;
      }
      else
      {
        gclass178 = new GClass178();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass178.gclass230_0 = class887.class886_0.gclass228_0.gclass230_0;
        gclass178.int_0 = 1;
        this.list_12.Add(gclass178);
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class887.int_0 = (int) class887.class886_0.gclass228_0.decimal_0 - gclass178.int_0;
      bool bool_22 = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class887.class886_0.gclass228_0.gclass230_0.decimal_11 > 0M)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        Decimal num = class887.class886_0.gclass228_0.gclass230_0.decimal_11 * 100M;
        GClass55 gclass55 = this.method_192(AuroraCommandType.ChiefEngineer);
        if (gclass55 != null)
          num *= 2M - gclass55.method_5(GEnum121.const_24);
        if ((Decimal) GClass226.smethod_13(10000) <= num)
          bool_22 = true;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class887.class886_0.gclass228_0.gclass230_0.bool_11)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class887.method_0)).ToList<GClass31>())
          this.list_2.Remove(gclass31);
        // ISSUE: reference to a compiler-generated method
        foreach (GClass32 gclass32 in this.list_3.Where<GClass32>(new Func<GClass32, bool>(class887.method_1)).ToList<GClass32>())
          this.list_3.Remove(gclass32);
        // ISSUE: reference to a compiler-generated method
        foreach (GClass27 gclass27 in this.list_7.Where<GClass27>(new Func<GClass27, bool>(class887.method_2)).ToList<GClass27>())
          this.list_7.Remove(gclass27);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.MissileFireControl && class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.BeamFireControl)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Magazine)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            decimal_13 = this.method_12(class887.class886_0.gclass228_0, bool_22);
            if (bool_22)
              this.gclass0_0.method_19(AuroraContactType.SecondaryMg, (Decimal) decimal_13, 1, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, false);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.Engine && class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.PowerPlant)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.JumpPointStabilisation)
              {
                if (this.gclass85_0.dictionary_0.Values.FirstOrDefault<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_18 || gclass139_0.gclass133_0.genum123_0 == GEnum123.const_107)) != null)
                {
                  this.gclass85_0.method_263();
                  this.gclass0_0.gclass92_0.method_2(GEnum126.const_61, $"Due to damage to the jump point stabilisation module of {this.method_187()}, {this.gclass85_0.FleetName} cannot complete its mission", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
                }
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Shields)
                {
                  this.bool_4 = true;
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.CommandAndControl)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_11(class887.class886_0.gclass228_0.gclass230_0.int_0);
                  }
                  else
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ColonistTransport)
                    {
                      this.bool_1 = true;
                    }
                    else
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.FuelStorage)
                      {
                        this.bool_0 = true;
                      }
                      else
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.TroopTransport)
                        {
                          this.bool_2 = true;
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if (class887.class886_0.gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.CargoHold)
                            this.bool_3 = true;
                        }
                      }
                    }
                  }
                }
              }
            }
            else if (bool_22)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              decimal_13 = GClass226.smethod_13(class887.class886_0.gclass228_0.gclass230_0.int_5);
              this.gclass0_0.method_19(AuroraContactType.SecondaryPower, (Decimal) decimal_13, 1, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, false);
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          List<GClass36> list = this.list_4.Where<GClass36>(new Func<GClass36, bool>(class887.class886_0.method_1)).OrderBy<GClass36, int>((Func<GClass36, int>) (gclass36_0 => gclass36_0.int_0)).ToList<GClass36>();
          int num = 1;
          foreach (GClass36 gclass36 in list)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass40.Class888 class888 = new GClass40.Class888();
            // ISSUE: reference to a compiler-generated field
            class888.class887_0 = class887;
            // ISSUE: reference to a compiler-generated field
            class888.gclass36_0 = gclass36;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (num > class888.class887_0.int_0)
            {
              // ISSUE: reference to a compiler-generated method
              foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class888.method_0)).ToList<GClass31>())
                this.list_2.Remove(gclass31);
              // ISSUE: reference to a compiler-generated method
              foreach (GClass132 gclass132 in this.gclass0_0.dictionary_6.Values.Where<GClass132>(new Func<GClass132, bool>(class888.method_1)).ToList<GClass132>())
                gclass132.method_17();
              // ISSUE: reference to a compiler-generated field
              class888.gclass36_0.bool_0 = false;
              // ISSUE: reference to a compiler-generated field
              this.list_4.Remove(class888.gclass36_0);
            }
            ++num;
          }
        }
      }
      return decimal_13;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 330);
      return 0;
    }
  }

  public string method_5()
  {
    try
    {
      Decimal num1 = (Decimal) this.method_124();
      Decimal num2 = this.dictionary_3.Values.Sum<GClass191>((Func<GClass191, Decimal>) (gclass191_0 => gclass191_0.decimal_0)) * GClass226.decimal_53;
      Decimal num3 = this.dictionary_2.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.decimal_0 * (Decimal) gclass158_0.gclass157_0.int_1));
      Decimal num4 = this.list_17.Sum<GClass73>((Func<GClass73, Decimal>) (gclass73_0 => gclass73_0.gclass230_0.decimal_1 * GClass226.decimal_17));
      Decimal num5 = this.gclass123_0.method_7() * GClass226.decimal_28;
      Decimal num6 = num3;
      Decimal num7 = num2 + num6 + num4 + num5;
      if (num7 <= num1)
        return "";
      string str = "Loss of Cargo:";
      Decimal num8 = (num7 - num1) / num7;
      Decimal decimal_11 = 1M - num8;
      foreach (GClass191 gclass191 in this.dictionary_3.Values)
      {
        gclass191.decimal_0 *= decimal_11;
        str = $"{str}   {GClass226.smethod_42(num8 * gclass191.decimal_0, 2)} {gclass191.gclass189_0.string_0}";
      }
      foreach (GClass158 gclass158 in this.dictionary_2.Values)
      {
        gclass158.decimal_0 *= decimal_11;
        str = $"{str}   {GClass226.smethod_42(num8 * gclass158.decimal_0, 2)} {gclass158.gclass157_0.Name}";
      }
      foreach (GClass73 gclass73 in this.list_17)
      {
        gclass73.decimal_0 *= decimal_11;
        str = $"{str}   {GClass226.smethod_42(num8 * gclass73.decimal_0, 2)} {gclass73.gclass230_0.Name}";
      }
      if (num5 > 0M)
      {
        foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof (AuroraElement)))
        {
          Decimal decimal_73 = this.gclass123_0.method_14(auroraElement_0);
          if (decimal_73 > 0M)
            str = $"{str}   {GClass226.smethod_39(decimal_73)} {auroraElement_0.ToString()}";
        }
        this.gclass123_0.method_12(decimal_11);
      }
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 331);
      return "error";
    }
  }

  public string method_6()
  {
    try
    {
      Decimal num1 = (Decimal) this.method_124();
      Decimal num2 = this.dictionary_3.Values.Sum<GClass191>((Func<GClass191, Decimal>) (gclass191_0 => gclass191_0.decimal_0)) * GClass226.decimal_53;
      Decimal num3 = this.dictionary_2.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => gclass158_0.decimal_0 * (Decimal) gclass158_0.gclass157_0.int_1));
      Decimal num4 = this.list_17.Sum<GClass73>((Func<GClass73, Decimal>) (gclass73_0 => gclass73_0.gclass230_0.decimal_1 * GClass226.decimal_17));
      Decimal num5 = this.gclass123_0.method_7() * GClass226.decimal_28;
      Decimal num6 = num3;
      if (num2 + num6 + num4 + num5 <= num1)
        return "";
      string str = "   Loss of Cargo:";
      foreach (GClass191 gclass191 in this.dictionary_3.Values)
        str = $"{str}   {GClass226.smethod_42(gclass191.decimal_0, 2)}x {gclass191.gclass189_0.string_0}";
      if (this.dictionary_2.Count > 0)
      {
        foreach (GClass158 gclass158 in this.dictionary_2.Values)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class889 class889 = new GClass40.Class889();
          // ISSUE: reference to a compiler-generated field
          class889.gclass158_0 = gclass158;
          if (this.gclass187_0 != null)
          {
            GClass139 gclass139 = this.gclass85_0.dictionary_0.Values.FirstOrDefault<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_72));
            if (gclass139 != null && gclass139.gclass146_0 != null)
            {
              // ISSUE: reference to a compiler-generated method
              GClass148 gclass148_1 = gclass139.gclass146_0.dictionary_5.Values.FirstOrDefault<GClass148>(new Func<GClass148, bool>(class889.method_0));
              if (gclass148_1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                gclass148_1.decimal_0 += class889.gclass158_0.decimal_0;
              }
              else
              {
                GClass148 gclass148_2 = new GClass148();
                // ISSUE: reference to a compiler-generated field
                gclass148_2.decimal_0 = class889.gclass158_0.decimal_0;
                // ISSUE: reference to a compiler-generated field
                gclass148_2.gclass157_0 = class889.gclass158_0.gclass157_0;
                gclass148_2.bool_0 = false;
                gclass148_2.gclass146_0 = gclass139.gclass146_0;
                gclass139.gclass146_0.dictionary_5.Add(gclass148_2.gclass157_0.auroraInstallationType_0, gclass148_2);
              }
            }
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          str = $"{str}   {GClass226.smethod_42(class889.gclass158_0.decimal_0, 2)}x {class889.gclass158_0.gclass157_0.Name}";
        }
      }
      else if (this.gclass187_0 != null)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class890 class890 = new GClass40.Class890();
        // ISSUE: reference to a compiler-generated field
        class890.gclass139_0 = this.gclass85_0.dictionary_0.Values.FirstOrDefault<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_71));
        // ISSUE: reference to a compiler-generated field
        if (class890.gclass139_0 != null)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class891 class891 = new GClass40.Class891();
          // ISSUE: reference to a compiler-generated field
          Decimal num7 = num1 / (Decimal) this.gclass0_0.dictionary_44[(AuroraInstallationType) class890.gclass139_0.int_7].int_1;
          // ISSUE: reference to a compiler-generated field
          if (class890.gclass139_0.gclass146_0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            GClass148 gclass148_3 = class890.gclass139_0.gclass146_0.dictionary_5.Values.FirstOrDefault<GClass148>(new Func<GClass148, bool>(class890.method_0));
            if (gclass148_3 != null)
            {
              gclass148_3.decimal_0 += num7;
            }
            else
            {
              GClass148 gclass148_4 = new GClass148();
              gclass148_4.decimal_0 = num7;
              // ISSUE: reference to a compiler-generated field
              gclass148_4.gclass157_0 = this.gclass0_0.dictionary_44[(AuroraInstallationType) class890.gclass139_0.int_7];
              gclass148_4.bool_0 = true;
              // ISSUE: reference to a compiler-generated field
              gclass148_4.gclass146_0 = class890.gclass139_0.gclass146_0;
              // ISSUE: reference to a compiler-generated field
              class890.gclass139_0.gclass146_0.dictionary_5.Add(gclass148_4.gclass157_0.auroraInstallationType_0, gclass148_4);
            }
          }
          // ISSUE: reference to a compiler-generated field
          class891.gclass139_0 = this.gclass85_0.dictionary_0.Values.FirstOrDefault<GClass139>((Func<GClass139, bool>) (gclass139_0 => gclass139_0.gclass133_0.genum123_0 == GEnum123.const_72));
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class891.gclass139_0 != null && class891.gclass139_0.gclass146_0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            GClass148 gclass148_5 = class891.gclass139_0.gclass146_0.dictionary_5.Values.FirstOrDefault<GClass148>(new Func<GClass148, bool>(class891.method_0));
            if (gclass148_5 != null)
            {
              gclass148_5.decimal_0 += num7;
            }
            else
            {
              GClass148 gclass148_6 = new GClass148();
              gclass148_6.decimal_0 = num7;
              // ISSUE: reference to a compiler-generated field
              gclass148_6.gclass157_0 = this.gclass0_0.dictionary_44[(AuroraInstallationType) class891.gclass139_0.int_7];
              gclass148_6.bool_0 = false;
              // ISSUE: reference to a compiler-generated field
              gclass148_6.gclass146_0 = class891.gclass139_0.gclass146_0;
              // ISSUE: reference to a compiler-generated field
              class891.gclass139_0.gclass146_0.dictionary_5.Add(gclass148_6.gclass157_0.auroraInstallationType_0, gclass148_6);
            }
          }
        }
      }
      foreach (GClass73 gclass73 in this.list_17)
        str = $"{str}   {GClass226.smethod_42(gclass73.decimal_0, 2)}x {gclass73.gclass230_0.Name}";
      if (num5 > 0M)
      {
        foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof (AuroraElement)))
        {
          Decimal decimal_73 = this.gclass123_0.method_14(auroraElement_0);
          if (decimal_73 > 0M)
            str = $"{str}   {GClass226.smethod_39(decimal_73)}x {auroraElement_0.ToString()}";
        }
      }
      foreach (GClass181 gclass181 in this.list_18)
        str = $"{str}   {GClass226.smethod_37(gclass181.int_0)}x {gclass181.gclass194_0?.ToString()}";
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).ToList<GClass103>())
        str = $"{str}   {gclass103.Name}";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3418);
      return "error";
    }
  }

  public string method_7()
  {
    try
    {
      List<GClass103> list = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).ToList<GClass103>();
      if (list.Count == 0)
        return "";
      Decimal num1 = list.Sum<GClass103>((Func<GClass103, Decimal>) (gclass103_0 => gclass103_0.method_34()));
      Decimal num2 = this.method_157(AuroraComponentType.TroopTransport, false);
      if (num1 <= num2)
        return "";
      if (num2 == 0M)
      {
        string str = "Ground Unit Formations Destroyed:";
        foreach (GClass103 gclass103_0 in list)
        {
          str = $"{str}   {gclass103_0.method_45()}";
          this.gclass21_0.method_131(gclass103_0, true);
        }
        return "";
      }
      Decimal num3 = (num1 - num2) / num1;
      string str1 = $"Ground Unit Formations suffering approximately {GClass226.smethod_38(num3 * 100M)}% Casualties:";
      foreach (GClass103 gclass103 in list)
      {
        str1 = $"{str1}   {gclass103.method_45()}";
        foreach (GClass39 gclass39 in gclass103.list_0.ToList<GClass39>())
        {
          int num4 = (int) Math.Round((Decimal) gclass39.int_1 * num3);
          if (num4 >= gclass39.int_1)
            gclass103.list_0.Remove(gclass39);
          else
            gclass39.int_1 -= num4;
        }
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_61, $"Due to damage to the troop transport bays on {this.method_187()}, approximately {GClass226.smethod_38(num3 * 100M)} percent of the embarked ground forces has been destroyed", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      }
      return str1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 332);
      return "error";
    }
  }

  public Decimal method_8()
  {
    try
    {
      Decimal num1 = this.method_151();
      Decimal num2 = 0M;
      if (this.decimal_14 > num1)
      {
        num2 = this.decimal_14 - num1;
        this.decimal_14 = num1;
      }
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 333);
      return 0M;
    }
  }

  public Decimal method_9()
  {
    try
    {
      Decimal num1 = this.method_157(AuroraComponentType.Shields, false) * this.decimal_9;
      Decimal num2 = 0M;
      if (this.decimal_3 > num1)
      {
        num2 = this.decimal_3 - num1;
        this.decimal_3 = num1;
      }
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 334);
      return 0M;
    }
  }

  public Decimal method_10()
  {
    try
    {
      Decimal num1 = this.method_149();
      Decimal num2 = (Decimal) this.list_18.Sum<GClass181>((Func<GClass181, int>) (gclass181_0 => gclass181_0.int_0));
      Decimal num3 = 0M;
      if (num2 > num1)
      {
        num3 = num2 - num1;
        Decimal num4 = 1M - num3 / num2;
        foreach (GClass181 gclass181 in this.list_18)
          gclass181.int_0 = (int) ((Decimal) gclass181.int_0 * num4);
      }
      return num3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 335);
      return 0M;
    }
  }

  public void method_11(int int_40)
  {
    try
    {
      GClass55 gclass55_1 = (GClass55) null;
      GClass55 gclass55_2 = (GClass55) null;
      List<GClass55> gclass55List = new List<GClass55>();
      string str1 = "";
      string str2 = "";
      switch (int_40)
      {
        case 18:
          gclass55_1 = this.method_192(AuroraCommandType.Ship);
          gclass55_2 = this.method_192(AuroraCommandType.ScienceOfficer);
          str1 = "the Bridge";
          break;
        case 225:
          gclass55List = this.method_193();
          str1 = "the Flag Bridge";
          str2 = "Flag Officer ";
          break;
        case 65736:
          gclass55_1 = this.method_192(AuroraCommandType.ExecutiveOfficer);
          str1 = "Auxiliary Control";
          str2 = "Executive Officer ";
          break;
        case 65737:
          gclass55_1 = this.method_192(AuroraCommandType.ChiefEngineer);
          str1 = "Main Engineering";
          str2 = "Chief Engineer ";
          break;
        case 65738:
          gclass55_1 = this.method_192(AuroraCommandType.TacticalOfficer);
          str1 = "the Combat Information Centre";
          str2 = "Tactical Officer ";
          break;
      }
      if (gclass55_1 != null)
        gclass55List.Add(gclass55_1);
      if (gclass55_2 != null)
        gclass55List.Add(gclass55_2);
      foreach (GClass55 gclass55_3 in gclass55List)
      {
        if (GClass226.smethod_23())
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_63, $"{gclass55_3.method_36()} ({gclass55_3.method_17(false)}) has been killed due to the destruction of {str1} on {this.method_187()}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          this.method_204($"{str2}{gclass55_3.method_36()} killed due to the destruction of {str1}");
          gclass55_3.method_46($"Killed due to the destruction of {str1} on {this.method_187()}", GEnum28.const_0);
          gclass55_3.method_42(AuroraRetirementStatus.KilledNaval);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 336);
    }
  }

  public int method_12(GClass228 gclass228_0, bool bool_22)
  {
    try
    {
      int num1 = 0;
      if (this.list_10.Sum<GClass130>((Func<GClass130, Decimal>) (gclass130_0 => (Decimal) gclass130_0.int_0 * gclass130_0.gclass129_0.decimal_4)) == 0M)
        return 0;
      Decimal num2 = this.method_181();
      Decimal num3 = num2 + gclass228_0.gclass230_0.decimal_3;
      Decimal num4 = 1M - num2 / num3;
      foreach (GClass130 gclass130 in this.list_10.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 0)).ToList<GClass130>())
      {
        int num5 = (int) Math.Ceiling((Decimal) gclass130.int_0 * num4);
        gclass130.int_0 -= num5;
        if (bool_22)
          num1 += (int) Math.Floor((Decimal) num5 * gclass130.gclass129_0.decimal_0);
        if (gclass130.gclass129_0.gclass129_0 != null)
          num1 += (int) Math.Floor((Decimal) (num5 * gclass130.gclass129_0.int_16) * gclass130.gclass129_0.gclass129_0.decimal_0);
      }
      this.list_10 = this.list_10.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.int_0 > 0)).ToList<GClass130>();
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 337);
      return 0;
    }
  }

  public void method_13(GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class801 class801 = new GClass40.Class801();
    // ISSUE: reference to a compiler-generated field
    class801.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass178 gclass178 = this.dictionary_6.Values.FirstOrDefault<GClass178>(new Func<GClass178, bool>(class801.method_0));
      if (gclass178 != null)
      {
        ++gclass178.int_0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.dictionary_6.Add(class801.gclass230_0.int_0, new GClass178()
        {
          gclass230_0 = class801.gclass230_0,
          int_0 = 1
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 338);
    }
  }

  public GClass132 method_14(int int_40)
  {
    try
    {
      if (this.gclass0_0.dictionary_6.ContainsKey(int_40))
        return this.gclass0_0.dictionary_6[int_40];
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated missile salvo target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      return (GClass132) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 339);
      return (GClass132) null;
    }
  }

  public GClass146 method_15(int int_40, AuroraContactType auroraContactType_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class802 class802 = new GClass40.Class802();
    // ISSUE: reference to a compiler-generated field
    class802.gclass40_0 = this;
    // ISSUE: reference to a compiler-generated field
    class802.int_0 = int_40;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (!this.gclass0_0.dictionary_22.ContainsKey(class802.int_0))
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated population target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        return (GClass146) null;
      }
      switch (auroraContactType_0)
      {
        case AuroraContactType.GroundUnit:
          // ISSUE: reference to a compiler-generated method
          if (this.gclass0_0.dictionary_71.Values.Count<GClass103>(new Func<GClass103, bool>(class802.method_1)) == 0)
          {
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated ground forces target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            return (GClass146) null;
          }
          break;
        case AuroraContactType.STOGroundUnit:
          // ISSUE: reference to a compiler-generated method
          List<GClass103> list = this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class802.method_2)).ToList<GClass103>();
          // ISSUE: reference to a compiler-generated method
          if (this.gclass0_0.dictionary_71.Values.Count<GClass103>(new Func<GClass103, bool>(class802.method_3)) == 0)
          {
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated STO ground forces target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            return (GClass146) null;
          }
          if (list.SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).Count<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass101_0.gclass230_0 != null)) == 0)
          {
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated STO ground forces target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            return (GClass146) null;
          }
          break;
        case AuroraContactType.Shipyard:
          // ISSUE: reference to a compiler-generated method
          if (this.gclass0_0.dictionary_31.Values.Count<GClass193>(new Func<GClass193, bool>(class802.method_0)) == 0)
          {
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated shipyard target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            return (GClass146) null;
          }
          break;
      }
      // ISSUE: reference to a compiler-generated field
      return this.gclass0_0.dictionary_22[class802.int_0];
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 340);
      return (GClass146) null;
    }
  }

  public GClass214 method_16(int int_40)
  {
    try
    {
      if (this.gclass0_0.dictionary_13.ContainsKey(int_40))
        return this.gclass0_0.dictionary_13[int_40];
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated waypoint target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      return (GClass214) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 341);
      return (GClass214) null;
    }
  }

  public GClass40 method_17(int int_40)
  {
    try
    {
      if (this.gclass0_0.dictionary_4.ContainsKey(int_40))
        return this.gclass0_0.dictionary_4[int_40];
      if (this.gclass21_0.dictionary_12.ContainsKey(int_40))
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, $"{this.ShipName} cannot locate its designated target: {this.gclass21_0.dictionary_12[int_40].method_11()}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      else
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_10, this.ShipName + " cannot locate its designated ship target", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      return (GClass40) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 342);
      return (GClass40) null;
    }
  }

  public bool method_18(bool bool_22)
  {
    try
    {
      if (bool_22)
      {
        if (this.list_4.FirstOrDefault<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.bool_0 || gclass36_0.auroraPointDefenceMode_0 != 0)) != null)
          return true;
      }
      else if (this.list_4.FirstOrDefault<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.bool_0)) != null)
        return true;
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 343);
      return false;
    }
  }

  public bool method_19(bool bool_22)
  {
    try
    {
      return !bool_22 ? this.list_4.FirstOrDefault<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.auroraPointDefenceMode_0 == AuroraPointDefenceMode.PointBlankDefensiveFire || gclass36_0.auroraPointDefenceMode_0 == AuroraPointDefenceMode.PointBlankDefensiveFireSelf || gclass36_0.auroraPointDefenceMode_0 == AuroraPointDefenceMode.RangedDefensiveFire)) != null : this.list_4.FirstOrDefault<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.auroraPointDefenceMode_0 == AuroraPointDefenceMode.AreaDefence)) != null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 344);
      return false;
    }
  }

  public List<GClass31> method_20(List<GClass31> list_21)
  {
    try
    {
      foreach (GClass27 gclass27 in this.list_7)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        GClass31 gclass31 = list_21.FirstOrDefault<GClass31>(new Func<GClass31, bool>(new GClass40.Class804()
        {
          gclass27_0 = gclass27
        }.method_0));
        if (gclass31 != null)
          list_21.Remove(gclass31);
      }
      return list_21;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 345);
      return (List<GClass31>) null;
    }
  }

  public List<GClass32> method_21(List<GClass32> list_21)
  {
    try
    {
      foreach (GClass27 gclass27 in this.list_7)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        GClass32 gclass32 = list_21.FirstOrDefault<GClass32>(new Func<GClass32, bool>(new GClass40.Class805()
        {
          gclass27_0 = gclass27
        }.method_0));
        if (gclass32 != null)
          list_21.Remove(gclass32);
      }
      return list_21;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3685);
      return (List<GClass32>) null;
    }
  }

  public double method_22()
  {
    try
    {
      double num = 1.0 * (1.0 + (double) this.method_189() / 100.0) * (double) this.decimal_2 * (double) this.decimal_9;
      GClass55 gclass55_1 = this.method_192(AuroraCommandType.Ship);
      if (gclass55_1 != null)
        num *= (double) gclass55_1.method_7(GEnum121.const_17);
      GClass55 gclass55_2 = this.method_192(AuroraCommandType.TacticalOfficer);
      if (gclass55_2 != null)
        num *= (double) gclass55_2.method_5(GEnum121.const_17);
      return num * (double) this.decimal_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 346);
      return 1.0;
    }
  }

  public List<GClass132> method_23(List<GClass132> list_21)
  {
    try
    {
      return list_21.OrderBy<GClass132, double>((Func<GClass132, double>) (gclass132_0 => this.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass132_0.double_0, gclass132_0.double_1))).ThenByDescending<GClass132, int>((Func<GClass132, int>) (gclass132_0 => gclass132_0.dictionary_2.Count)).ToList<GClass132>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 347);
      return (List<GClass132>) null;
    }
  }

  public void method_24(GEnum35 genum35_0)
  {
    try
    {
      List<GClass40> gclass40List = new List<GClass40>();
      switch (genum35_0)
      {
        case GEnum35.const_0:
          gclass40List = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4 != this && gclass40_4.gclass85_0 == this.gclass85_0 && gclass40_4.gclass22_0 == this.gclass22_0)).ToList<GClass40>();
          break;
        case GEnum35.const_1:
          if (this.gclass84_0 == null)
          {
            int num = (int) MessageBox.Show("This ship is not assigned to a sub-fleet");
            return;
          }
          gclass40List = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4 != this && gclass40_4.gclass84_0 == this.gclass84_0 && gclass40_4.gclass22_0 == this.gclass22_0)).ToList<GClass40>();
          break;
        case GEnum35.const_2:
          gclass40List = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4 != this && gclass40_4.gclass85_0.gclass202_0 == this.gclass85_0.gclass202_0 && gclass40_4.gclass22_0 == this.gclass22_0)).ToList<GClass40>();
          break;
        case GEnum35.const_3:
          gclass40List = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4 != this && gclass40_4.gclass22_0 == this.gclass22_0)).ToList<GClass40>();
          break;
      }
      foreach (GClass40 gclass40 in gclass40List)
      {
        gclass40.list_4.Clear();
        gclass40.list_2.Clear();
        gclass40.list_5.Clear();
        gclass40.list_3.Clear();
        foreach (GClass36 gclass36_1 in this.list_4)
        {
          if (gclass40.method_160(gclass36_1.gclass230_0) >= gclass36_1.int_0)
          {
            GClass36 gclass36_2 = gclass36_1.method_0();
            gclass36_2.gclass40_0 = gclass40;
            gclass40.list_4.Add(gclass36_2);
            if (!gclass40.bool_15)
            {
              gclass40.int_13 = gclass40.method_86(GEnum14.const_0);
              gclass40.bool_15 = true;
            }
          }
        }
        foreach (GClass31 gclass31_1 in this.list_2)
        {
          if (gclass40.method_160(gclass31_1.gclass230_0) >= gclass31_1.int_0)
          {
            GClass31 gclass31_2 = gclass31_1.method_0();
            gclass31_2.gclass40_0 = gclass40;
            gclass40.list_2.Add(gclass31_2);
          }
        }
        foreach (GClass30 gclass30_1 in this.list_5)
        {
          if (gclass40.method_160(gclass30_1.gclass230_0) >= gclass30_1.int_0)
          {
            GClass30 gclass30_2 = gclass30_1.method_0();
            gclass40.list_5.Add(gclass30_2);
          }
        }
        foreach (GClass32 gclass32_1 in this.list_3)
        {
          if (gclass40.method_160(gclass32_1.gclass230_0) >= gclass32_1.int_0)
          {
            GClass32 gclass32_2 = gclass32_1.method_0();
            gclass32_2.gclass40_0 = gclass40;
            gclass40.list_3.Add(gclass32_2);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 348);
    }
  }

  public void method_25(
    GClass36 gclass36_0,
    GClass31 gclass31_0_1,
    CheckState checkState_0,
    CheckState checkState_1,
    int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class816 class816 = new GClass40.Class816();
    // ISSUE: reference to a compiler-generated field
    class816.gclass31_0 = gclass31_0_1;
    try
    {
      if (checkState_0 == CheckState.Unchecked && (checkState_1 == CheckState.Unchecked || int_40 < 1))
      {
        // ISSUE: reference to a compiler-generated field
        class816.gclass31_0.gclass230_1 = gclass36_0.gclass230_0;
        // ISSUE: reference to a compiler-generated field
        class816.gclass31_0.int_1 = gclass36_0.int_0;
      }
      else if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class816.method_0)).ToList<GClass31>())
        {
          gclass31.gclass230_1 = gclass36_0.gclass230_0;
          gclass31.int_1 = gclass36_0.int_0;
        }
      }
      else
      {
        if (checkState_1 != CheckState.Checked)
          return;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class816.method_1)).OrderBy<GClass31, int>((Func<GClass31, int>) (gclass31_0_2 => gclass31_0_2.int_0)).Take<GClass31>(int_40).ToList<GClass31>())
        {
          gclass31.gclass230_1 = gclass36_0.gclass230_0;
          gclass31.int_1 = gclass36_0.int_0;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 349);
    }
  }

  public void method_26(GClass36 gclass36_0, GClass65 gclass65_0)
  {
    try
    {
      gclass36_0.int_1 = gclass65_0.int_1;
      gclass36_0.auroraContactType_0 = gclass65_0.auroraContactType_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 350);
    }
  }

  public void method_27(GClass36 gclass36_0, GClass214 gclass214_0)
  {
    try
    {
      gclass36_0.int_1 = gclass214_0.int_0;
      gclass36_0.auroraContactType_0 = AuroraContactType.WayPoint;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 351);
    }
  }

  public void method_28(GClass36 gclass36_0, AuroraPointDefenceMode auroraPointDefenceMode_0)
  {
    try
    {
      gclass36_0.auroraPointDefenceMode_0 = auroraPointDefenceMode_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 352);
    }
  }

  public void method_29(
    GClass31 gclass31_0_1,
    CheckState checkState_0,
    CheckState checkState_1,
    int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class836 class836 = new GClass40.Class836();
    // ISSUE: reference to a compiler-generated field
    class836.gclass31_0 = gclass31_0_1;
    try
    {
      if (checkState_0 == CheckState.Unchecked && (checkState_1 == CheckState.Unchecked || int_40 < 1))
      {
        // ISSUE: reference to a compiler-generated field
        this.list_2.Remove(class836.gclass31_0);
      }
      else if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class836.method_0)).ToList<GClass31>())
          this.list_2.Remove(gclass31);
      }
      else
      {
        if (checkState_1 != CheckState.Checked)
          return;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class836.method_1)).OrderBy<GClass31, int>((Func<GClass31, int>) (gclass31_0_2 => gclass31_0_2.int_0)).Take<GClass31>(int_40).ToList<GClass31>())
          this.list_2.Remove(gclass31);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 353);
    }
  }

  public void method_30(
    GClass32 gclass32_0_1,
    CheckState checkState_0,
    CheckState checkState_1,
    int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class841 class841 = new GClass40.Class841();
    // ISSUE: reference to a compiler-generated field
    class841.gclass32_0 = gclass32_0_1;
    try
    {
      if (checkState_0 == CheckState.Unchecked && (checkState_1 == CheckState.Unchecked || int_40 < 1))
      {
        // ISSUE: reference to a compiler-generated field
        this.list_3.Remove(class841.gclass32_0);
      }
      else if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass32 gclass32 in this.list_3.Where<GClass32>(new Func<GClass32, bool>(class841.method_0)).ToList<GClass32>())
          this.list_3.Remove(gclass32);
      }
      else
      {
        if (checkState_1 != CheckState.Checked)
          return;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass32 gclass32 in this.list_3.Where<GClass32>(new Func<GClass32, bool>(class841.method_1)).OrderBy<GClass32, int>((Func<GClass32, int>) (gclass32_0_2 => gclass32_0_2.int_0)).Take<GClass32>(int_40).ToList<GClass32>())
          this.list_3.Remove(gclass32);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3683);
    }
  }

  public void method_31(GEnum61 genum61_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class844 class844 = new GClass40.Class844();
    // ISSUE: reference to a compiler-generated field
    class844.genum61_0 = genum61_0;
    try
    {
      foreach (GClass228 gclass228 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl || gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class845 class845 = new GClass40.Class845();
        // ISSUE: reference to a compiler-generated field
        class845.class844_0 = class844;
        // ISSUE: reference to a compiler-generated field
        class845.gclass228_0 = gclass228;
        // ISSUE: reference to a compiler-generated field
        int num = this.method_158(class845.gclass228_0);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        for (class845.int_0 = 1; class845.int_0 <= num; class845.int_0++)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          GClass36 gclass36 = this.list_4.Where<GClass36>(class845.func_0 ?? (class845.func_0 = new Func<GClass36, bool>(class845.method_0))).FirstOrDefault<GClass36>();
          if (gclass36 != null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class845.class844_0.genum61_0 == GEnum61.const_2)
            {
              gclass36.bool_0 = false;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (class845.class844_0.genum61_0 == GEnum61.const_1)
              {
                gclass36.bool_0 = true;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class845.class844_0.genum61_0 == GEnum61.const_3 && gclass36.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl)
                {
                  gclass36.bool_0 = true;
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  if (class845.class844_0.genum61_0 == GEnum61.const_4 && gclass36.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl)
                    gclass36.bool_0 = true;
                }
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 354);
    }
  }

  public void method_32(GClass36 gclass36_0)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass40.Class849 class849 = new GClass40.Class849();
      // ISSUE: reference to a compiler-generated field
      class849.gclass40_0 = this;
      List<GClass65> list1 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0 && gclass65_0.gclass21_1 == this.gclass21_0 && this.gclass0_0.decimal_0 == gclass65_0.decimal_3)).ToList<GClass65>();
      if (list1.Count == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class849.list_0 = list1.Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated method
      List<GClass40> list2 = this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class849.method_0)).Select<GClass103, GClass40>((Func<GClass103, GClass40>) (gclass103_0 => gclass103_0.gclass40_0)).Distinct<GClass40>().ToList<GClass40>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class849.list_0 = class849.list_0.Except<GClass40>((IEnumerable<GClass40>) list2).ToList<GClass40>();
      // ISSUE: reference to a compiler-generated method
      this.gclass21_0.dictionary_12.Values.Where<GClass117>(new Func<GClass117, bool>(class849.method_1)).ToList<GClass117>();
      List<GClass40> gclass40List = new List<GClass40>();
      List<GClass36> list3 = this.list_4.ToList<GClass36>();
      if (gclass36_0 != null)
      {
        list3.Clear();
        list3.Add(gclass36_0);
      }
      foreach (GClass36 gclass36_0_1 in list3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class850 class850 = new GClass40.Class850();
        // ISSUE: reference to a compiler-generated field
        class850.class849_0 = class849;
        int int_72 = 0;
        List<GClass40> list4;
        if (gclass36_0_1.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class851 class851 = new GClass40.Class851();
          // ISSUE: reference to a compiler-generated field
          class851.class850_0 = class850;
          // ISSUE: reference to a compiler-generated field
          class851.gclass71_0 = this.method_213(0M, gclass36_0_1);
          // ISSUE: reference to a compiler-generated field
          if (class851.gclass71_0.double_0 != 0.0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            list4 = class851.class850_0.class849_0.list_0.Where<GClass40>(new Func<GClass40, bool>(class851.method_0)).ToList<GClass40>();
            foreach (GClass40 gclass40_1 in list4)
            {
              double num1 = this.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass40_1.gclass85_0.double_2, gclass40_1.gclass85_0.double_3);
              if (num1 < 10000.0)
                num1 = 10000.0;
              double num2 = 1.0;
              GClass117 gclass117 = this.gclass21_0.method_267(gclass40_1);
              if (gclass117 != null && gclass117.gclass115_0.genum70_0 == GEnum70.const_2)
                num2 = 0.1;
              gclass40_1.int_37 = (int) Math.Floor((double) gclass40_1.gclass22_0.decimal_14 / num1 * 10000000.0 * num2);
              if (gclass40_1.int_37 < 1)
                gclass40_1.int_37 = 1;
              int_72 += gclass40_1.int_37;
              gclass40_1.int_38 = int_72;
            }
          }
          else
            continue;
        }
        else
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class852 class852 = new GClass40.Class852();
          // ISSUE: reference to a compiler-generated field
          class852.class850_0 = class850;
          // ISSUE: reference to a compiler-generated field
          class852.double_0 = this.method_221(gclass36_0_1);
          // ISSUE: reference to a compiler-generated field
          if (class852.double_0 > 0.0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            list4 = class852.class850_0.class849_0.list_0.Where<GClass40>(new Func<GClass40, bool>(class852.method_0)).ToList<GClass40>();
            if (list4.Count != 0)
            {
              foreach (GClass40 gclass40_4 in list4)
              {
                this.method_107(gclass40_4, gclass36_0_1);
                gclass40_4.int_37 = (int) Math.Floor(gclass40_4.double_2 * 1000.0);
                if (gclass40_4.int_37 < 1)
                  gclass40_4.int_37 = 1;
                int_72 += gclass40_4.int_37;
                gclass40_4.int_38 = int_72;
              }
              if (int_72 == 0)
                continue;
            }
            else
              continue;
          }
          else
            continue;
        }
        // ISSUE: reference to a compiler-generated field
        class850.int_0 = GClass226.smethod_13(int_72);
        // ISSUE: reference to a compiler-generated method
        GClass40 gclass40 = list4.Where<GClass40>(new Func<GClass40, bool>(class850.method_0)).OrderBy<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.int_38)).FirstOrDefault<GClass40>();
        gclass36_0_1.int_1 = gclass40.int_8;
        gclass36_0_1.auroraContactType_0 = AuroraContactType.Ship;
        gclass36_0_1.bool_0 = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 59);
    }
  }

  public void method_33(
    GClass36 gclass36_0,
    GClass35 gclass35_0_1,
    CheckState checkState_0,
    CheckState checkState_1,
    int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class853 class853 = new GClass40.Class853();
    // ISSUE: reference to a compiler-generated field
    class853.gclass35_0 = gclass35_0_1;
    try
    {
      if (checkState_0 == CheckState.Unchecked && (checkState_1 == CheckState.Unchecked || int_40 < 1))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.list_2.Add(new GClass31()
        {
          gclass40_0 = this,
          gclass230_1 = gclass36_0.gclass230_0,
          int_1 = gclass36_0.int_0,
          gclass230_0 = class853.gclass35_0.gclass230_0,
          int_0 = class853.gclass35_0.int_0
        });
      }
      else if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass35 gclass35 in this.list_6.Where<GClass35>(new Func<GClass35, bool>(class853.method_0)).ToList<GClass35>())
          this.list_2.Add(new GClass31()
          {
            gclass40_0 = this,
            gclass230_1 = gclass36_0.gclass230_0,
            int_1 = gclass36_0.int_0,
            gclass230_0 = gclass35.gclass230_0,
            int_0 = gclass35.int_0
          });
      }
      else
      {
        if (checkState_1 != CheckState.Checked)
          return;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass35 gclass35 in this.list_6.Where<GClass35>(new Func<GClass35, bool>(class853.method_1)).OrderBy<GClass35, int>((Func<GClass35, int>) (gclass35_0_2 => gclass35_0_2.int_0)).Take<GClass35>(int_40).ToList<GClass35>())
          this.list_2.Add(new GClass31()
          {
            gclass40_0 = this,
            gclass230_1 = gclass36_0.gclass230_0,
            int_1 = gclass36_0.int_0,
            gclass230_0 = gclass35.gclass230_0,
            int_0 = gclass35.int_0
          });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 355);
    }
  }

  public void method_34(
    GClass35 gclass35_0_1,
    CheckState checkState_0,
    CheckState checkState_1,
    int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class857 class857 = new GClass40.Class857();
    // ISSUE: reference to a compiler-generated field
    class857.gclass35_0 = gclass35_0_1;
    try
    {
      if (checkState_0 == CheckState.Unchecked && (checkState_1 == CheckState.Unchecked || int_40 < 1))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.list_3.Add(new GClass32()
        {
          gclass40_0 = this,
          gclass230_0 = class857.gclass35_0.gclass230_0,
          int_0 = class857.gclass35_0.int_0
        });
      }
      else if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass35 gclass35 in this.list_6.Where<GClass35>(new Func<GClass35, bool>(class857.method_0)).ToList<GClass35>())
          this.list_3.Add(new GClass32()
          {
            gclass40_0 = this,
            gclass230_0 = gclass35.gclass230_0,
            int_0 = gclass35.int_0
          });
      }
      else
      {
        if (checkState_1 != CheckState.Checked)
          return;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass35 gclass35 in this.list_6.Where<GClass35>(new Func<GClass35, bool>(class857.method_1)).OrderBy<GClass35, int>((Func<GClass35, int>) (gclass35_0_2 => gclass35_0_2.int_0)).Take<GClass35>(int_40).ToList<GClass35>())
          this.list_3.Add(new GClass32()
          {
            gclass40_0 = this,
            gclass230_0 = gclass35.gclass230_0,
            int_0 = gclass35.int_0
          });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3684);
    }
  }

  public void method_35(
    GClass31 gclass31_0_1,
    GClass130 gclass130_0,
    CheckState checkState_0,
    CheckState checkState_1,
    int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class861 class861 = new GClass40.Class861();
    // ISSUE: reference to a compiler-generated field
    class861.gclass31_0 = gclass31_0_1;
    try
    {
      if (checkState_0 == CheckState.Unchecked && (checkState_1 == CheckState.Unchecked || int_40 < 1))
      {
        // ISSUE: reference to a compiler-generated method
        GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class861.method_0)).FirstOrDefault<GClass30>();
        if (gclass30 != null)
        {
          gclass30.gclass129_0 = gclass130_0.gclass129_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.list_5.Add(new GClass30()
          {
            gclass230_0 = class861.gclass31_0.gclass230_0,
            int_0 = class861.gclass31_0.int_0,
            gclass129_0 = gclass130_0.gclass129_0
          });
        }
      }
      else if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class861.method_1)).ToList<GClass31>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class862 class862 = new GClass40.Class862();
          // ISSUE: reference to a compiler-generated field
          class862.gclass31_0 = gclass31;
          // ISSUE: reference to a compiler-generated method
          GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class862.method_0)).FirstOrDefault<GClass30>();
          if (gclass30 != null)
          {
            gclass30.gclass129_0 = gclass130_0.gclass129_0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.list_5.Add(new GClass30()
            {
              gclass230_0 = class862.gclass31_0.gclass230_0,
              int_0 = class862.gclass31_0.int_0,
              gclass129_0 = gclass130_0.gclass129_0
            });
          }
        }
      }
      else
      {
        if (checkState_1 != CheckState.Checked)
          return;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class861.method_2)).OrderBy<GClass31, int>((Func<GClass31, int>) (gclass31_0_2 => gclass31_0_2.int_0)).Take<GClass31>(int_40).ToList<GClass31>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class863 class863 = new GClass40.Class863();
          // ISSUE: reference to a compiler-generated field
          class863.gclass31_0 = gclass31;
          // ISSUE: reference to a compiler-generated method
          GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class863.method_0)).FirstOrDefault<GClass30>();
          if (gclass30 != null)
          {
            gclass30.gclass129_0 = gclass130_0.gclass129_0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.list_5.Add(new GClass30()
            {
              gclass230_0 = class863.gclass31_0.gclass230_0,
              int_0 = class863.gclass31_0.int_0,
              gclass129_0 = gclass130_0.gclass129_0
            });
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 356);
    }
  }

  public void method_36(
    GClass32 gclass32_0_1,
    GClass130 gclass130_0,
    CheckState checkState_0,
    CheckState checkState_1,
    int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class864 class864 = new GClass40.Class864();
    // ISSUE: reference to a compiler-generated field
    class864.gclass32_0 = gclass32_0_1;
    try
    {
      if (checkState_0 == CheckState.Unchecked && (checkState_1 == CheckState.Unchecked || int_40 < 1))
      {
        // ISSUE: reference to a compiler-generated method
        GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class864.method_0)).FirstOrDefault<GClass30>();
        if (gclass30 != null)
        {
          gclass30.gclass129_0 = gclass130_0.gclass129_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.list_5.Add(new GClass30()
          {
            gclass230_0 = class864.gclass32_0.gclass230_0,
            int_0 = class864.gclass32_0.int_0,
            gclass129_0 = gclass130_0.gclass129_0
          });
        }
      }
      else if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass32 gclass32 in this.list_3.Where<GClass32>(new Func<GClass32, bool>(class864.method_1)).ToList<GClass32>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class865 class865 = new GClass40.Class865();
          // ISSUE: reference to a compiler-generated field
          class865.gclass32_0 = gclass32;
          // ISSUE: reference to a compiler-generated method
          GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class865.method_0)).FirstOrDefault<GClass30>();
          if (gclass30 != null)
          {
            gclass30.gclass129_0 = gclass130_0.gclass129_0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.list_5.Add(new GClass30()
            {
              gclass230_0 = class865.gclass32_0.gclass230_0,
              int_0 = class865.gclass32_0.int_0,
              gclass129_0 = gclass130_0.gclass129_0
            });
          }
        }
      }
      else
      {
        if (checkState_1 != CheckState.Checked)
          return;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass32 gclass32 in this.list_3.Where<GClass32>(new Func<GClass32, bool>(class864.method_2)).OrderBy<GClass32, int>((Func<GClass32, int>) (gclass32_0_2 => gclass32_0_2.int_0)).Take<GClass32>(int_40).ToList<GClass32>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class866 class866 = new GClass40.Class866();
          // ISSUE: reference to a compiler-generated field
          class866.gclass32_0 = gclass32;
          // ISSUE: reference to a compiler-generated method
          GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class866.method_0)).FirstOrDefault<GClass30>();
          if (gclass30 != null)
          {
            gclass30.gclass129_0 = gclass130_0.gclass129_0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.list_5.Add(new GClass30()
            {
              gclass230_0 = class866.gclass32_0.gclass230_0,
              int_0 = class866.gclass32_0.int_0,
              gclass129_0 = gclass130_0.gclass129_0
            });
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3702);
    }
  }

  public void method_37(TreeView treeView_0, TreeView treeView_1, bool bool_22)
  {
    try
    {
      treeView_0.Visible = false;
      treeView_1.Visible = false;
      treeView_0.Nodes.Clear();
      treeView_1.Nodes.Clear();
      this.list_6.Clear();
      List<GClass228> list1 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl || gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>();
      if (list1.Count > 0)
      {
        TreeNode node1 = new TreeNode();
        node1.Text = "Fire Controls";
        node1.Tag = (object) this;
        treeView_0.Nodes.Add(node1);
        foreach (GClass228 gclass228 in list1)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class867 class867 = new GClass40.Class867();
          // ISSUE: reference to a compiler-generated field
          class867.gclass228_0 = gclass228;
          // ISSUE: reference to a compiler-generated field
          int num = this.method_158(class867.gclass228_0);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          for (class867.int_0 = 1; class867.int_0 <= num; class867.int_0++)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            GClass36 gclass36 = this.list_4.Where<GClass36>(class867.func_0 ?? (class867.func_0 = new Func<GClass36, bool>(class867.method_0))).FirstOrDefault<GClass36>();
            if (gclass36 == null)
            {
              gclass36 = new GClass36(this.gclass0_0);
              gclass36.gclass40_0 = this;
              // ISSUE: reference to a compiler-generated field
              gclass36.gclass230_0 = class867.gclass228_0.gclass230_0;
              // ISSUE: reference to a compiler-generated field
              gclass36.int_0 = class867.int_0;
              gclass36.int_1 = 0;
              gclass36.auroraContactType_0 = AuroraContactType.None;
              gclass36.bool_2 = true;
              gclass36.bool_0 = false;
              gclass36.bool_1 = false;
              gclass36.auroraPointDefenceMode_0 = AuroraPointDefenceMode.None;
              gclass36.auroraPointDefenceConcentration_0 = AuroraPointDefenceConcentration.ThreeShots;
              gclass36.auroraPointDefencePriority_0 = AuroraPointDefencePriority.PriorityThree;
              this.list_4.Add(gclass36);
            }
            TreeNode node2 = new TreeNode();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            node2.Text = $"{class867.gclass228_0.gclass230_0.Name} #{class867.int_0.ToString()}";
            node2.Tag = (object) gclass36;
            node2.ForeColor = gclass36.bool_0 ? Color.Orange : GClass226.color_2;
            node1.Nodes.Add(node2);
            if (gclass36.int_1 > 0)
            {
              string str1 = this.method_38(gclass36.int_1, gclass36.auroraContactType_0, true);
              if (str1 == "")
              {
                gclass36.int_1 = 0;
                gclass36.auroraContactType_0 = AuroraContactType.None;
              }
              else
              {
                string str2 = str1 + gclass36.method_1(this);
                node2.Nodes.Add(new TreeNode()
                {
                  Text = "Target:  " + str2,
                  Tag = (object) gclass36.int_1
                });
              }
            }
            if (gclass36.auroraPointDefenceMode_0 != AuroraPointDefenceMode.None)
            {
              TreeNode node3 = new TreeNode();
              node3.Text = "Point Defence:  " + GClass226.smethod_82((Enum) gclass36.auroraPointDefenceMode_0);
              if (gclass36.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl)
                node3.Text = $"{node3.Text}, {GClass226.smethod_82((Enum) gclass36.auroraPointDefencePriority_0)}, {GClass226.smethod_82((Enum) gclass36.auroraPointDefenceConcentration_0)}";
              else if (gclass36.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl && gclass36.double_0 > 0.0)
                node3.Text = $"{node3.Text}, Minimum Range {GClass226.smethod_43(gclass36.double_0)} km";
              node3.Tag = (object) gclass36.auroraPointDefenceMode_0;
              node2.Nodes.Add(node3);
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(class867.func_1 ?? (class867.func_1 = new Func<GClass31, bool>(class867.method_1))).ToList<GClass31>())
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass40.Class868 class868 = new GClass40.Class868();
              // ISSUE: reference to a compiler-generated field
              class868.gclass31_0 = gclass31;
              // ISSUE: reference to a compiler-generated method
              GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class868.method_0)).FirstOrDefault<GClass30>();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str = $"{class868.gclass31_0.gclass230_0.Name} #{class868.gclass31_0.int_0.ToString()}";
              if (gclass30 != null)
                str = $"{str}    MSL: {gclass30.gclass129_0.Name}";
              // ISSUE: reference to a compiler-generated method
              GClass27 gclass27 = this.list_7.FirstOrDefault<GClass27>(new Func<GClass27, bool>(class868.method_1));
              if (gclass27 != null)
                str = gclass27.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.MissileLauncher ? $"{str}  ({gclass27.decimal_0.ToString()} power)" : $"{str}  ({gclass27.decimal_0.ToString()} seconds)";
              // ISSUE: reference to a compiler-generated field
              node2.Nodes.Add(new TreeNode()
              {
                Text = str,
                Tag = (object) class868.gclass31_0
              });
            }
            if (gclass36.bool_2)
              node2.Expand();
          }
        }
        node1.Expand();
      }
      TreeNode node4 = new TreeNode();
      node4.Text = $"Decoy Launchers. Threshold: {this.int_23.ToString()} MSP";
      node4.Tag = (object) "Decoys";
      treeView_0.Nodes.Add(node4);
      foreach (GClass32 gclass32 in this.list_3)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class869 class869 = new GClass40.Class869();
        // ISSUE: reference to a compiler-generated field
        class869.gclass32_0 = gclass32;
        // ISSUE: reference to a compiler-generated method
        GClass30 gclass30 = this.list_5.Where<GClass30>(new Func<GClass30, bool>(class869.method_0)).FirstOrDefault<GClass30>();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        string str = $"{class869.gclass32_0.gclass230_0.Name} #{class869.gclass32_0.int_0.ToString()}";
        if (gclass30 != null)
          str = $"{str}    DCY: {gclass30.gclass129_0.Name}";
        // ISSUE: reference to a compiler-generated method
        GClass27 gclass27 = this.list_7.FirstOrDefault<GClass27>(new Func<GClass27, bool>(class869.method_1));
        if (gclass27 != null)
          str = $"{str}  ({gclass27.decimal_0.ToString()} seconds)";
        // ISSUE: reference to a compiler-generated field
        node4.Nodes.Add(new TreeNode()
        {
          Text = str,
          Tag = (object) class869.gclass32_0
        });
      }
      node4.Expand();
      List<GClass228> list2 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.bool_11 && gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.CIWS)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>();
      TreeNode node5 = new TreeNode();
      node5.Text = "Unassigned Weapons";
      node5.Tag = (object) "Unassigned";
      treeView_0.Nodes.Add(node5);
      if (list2.Count > 0)
      {
        foreach (GClass228 gclass228 in list2)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class870 class870 = new GClass40.Class870();
          // ISSUE: reference to a compiler-generated field
          class870.gclass228_0 = gclass228;
          // ISSUE: reference to a compiler-generated field
          int num = this.method_158(class870.gclass228_0);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          for (class870.int_0 = 1; class870.int_0 <= num; class870.int_0++)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            GClass31 gclass31 = this.list_2.Where<GClass31>(class870.func_0 ?? (class870.func_0 = new Func<GClass31, bool>(class870.method_0))).FirstOrDefault<GClass31>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            GClass32 gclass32 = this.list_3.Where<GClass32>(class870.func_1 ?? (class870.func_1 = new Func<GClass32, bool>(class870.method_1))).FirstOrDefault<GClass32>();
            if (gclass31 == null && gclass32 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              GClass30 gclass30 = this.list_5.Where<GClass30>(class870.func_2 ?? (class870.func_2 = new Func<GClass30, bool>(class870.method_2))).FirstOrDefault<GClass30>();
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str = $"{class870.gclass228_0.gclass230_0.Name} #{class870.int_0.ToString()}";
              if (gclass30 != null)
                str = $"{str}    MSL: {gclass30.gclass129_0.Name}";
              GClass35 gclass35 = new GClass35();
              // ISSUE: reference to a compiler-generated field
              gclass35.gclass230_0 = class870.gclass228_0.gclass230_0;
              // ISSUE: reference to a compiler-generated field
              gclass35.int_0 = class870.int_0;
              this.list_6.Add(gclass35);
              node5.Nodes.Add(new TreeNode()
              {
                Text = str,
                Tag = (object) gclass35
              });
            }
          }
        }
      }
      node5.Expand();
      if (this.list_10.Count > 0)
      {
        TreeNode node6 = new TreeNode();
        node6.Text = "Available Missiles";
        node6.Tag = (object) null;
        treeView_0.Nodes.Add(node6);
        foreach (GClass130 gclass130 in this.list_10)
        {
          string str = $"{gclass130.int_0.ToString()}x {gclass130.gclass129_0.Name}";
          node6.Nodes.Add(new TreeNode()
          {
            Text = str,
            Tag = (object) gclass130
          });
        }
        node6.Expand();
      }
      if (list1.Count > 0)
      {
        TreeNode node7 = new TreeNode();
        node7.Text = "Point Defence";
        node7.Tag = (object) "PD";
        treeView_1.Nodes.Add(node7);
        TreeNode node8 = new TreeNode();
        node8.Text = "Mode";
        node8.Tag = (object) "Mode";
        node7.Nodes.Add(node8);
        foreach (AuroraPointDefenceMode enum_0 in Enum.GetValues(typeof (AuroraPointDefenceMode)))
          node8.Nodes.Add(new TreeNode()
          {
            Text = GClass226.smethod_82((Enum) enum_0),
            Tag = (object) enum_0
          });
        TreeNode node9 = new TreeNode();
        node9.Text = "BFC Engagement Priority (1 = Highest)";
        node9.Tag = (object) "PR";
        node7.Nodes.Add(node9);
        foreach (AuroraPointDefencePriority enum_0 in Enum.GetValues(typeof (AuroraPointDefencePriority)))
          node9.Nodes.Add(new TreeNode()
          {
            Text = GClass226.smethod_82((Enum) enum_0),
            Tag = (object) enum_0
          });
        TreeNode node10 = new TreeNode();
        node10.Text = "BFC Fire Concentration (Attacks per Inbound)";
        node10.Tag = (object) "CON";
        node7.Nodes.Add(node10);
        foreach (AuroraPointDefenceConcentration enum_0 in Enum.GetValues(typeof (AuroraPointDefenceConcentration)))
          node10.Nodes.Add(new TreeNode()
          {
            Text = GClass226.smethod_82((Enum) enum_0),
            Tag = (object) enum_0
          });
        if (bool_22)
          node7.Expand();
        node8.Expand();
        node9.Expand();
        node10.Expand();
      }
      TreeNode node11 = new TreeNode();
      node11.Text = "Potential Targets";
      node11.Tag = (object) null;
      treeView_1.Nodes.Add(node11);
      List<GClass40> list3 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass1_0 != null && gclass85_0.method_35())).SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).ToList<GClass40>();
      List<GClass65> list4 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 =>
      {
        if (gclass65_0.gclass21_1 != this.gclass21_0 || !(gclass65_0.decimal_3 == this.gclass0_0.decimal_0) || gclass65_0.gclass200_0 != this.gclass85_0.gclass202_0.gclass200_0)
          return false;
        return gclass65_0.genum10_0 == GEnum10.const_0 || gclass65_0.auroraContactType_0 == AuroraContactType.Population;
      })).ToList<GClass65>();
      List<GClass65> source1 = new List<GClass65>();
      foreach (GClass65 gclass65 in list4)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class871 class871 = new GClass40.Class871();
        // ISSUE: reference to a compiler-generated field
        class871.gclass65_0 = gclass65;
        // ISSUE: reference to a compiler-generated field
        if (class871.gclass65_0.auroraContactType_0 == AuroraContactType.Population)
        {
          // ISSUE: reference to a compiler-generated method
          if (source1.Where<GClass65>(new Func<GClass65, bool>(class871.method_0)).FirstOrDefault<GClass65>() == null)
          {
            // ISSUE: reference to a compiler-generated field
            source1.Add(class871.gclass65_0);
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class871.gclass65_0.gclass40_0 == null || !list3.Contains(class871.gclass65_0.gclass40_0))
          {
            // ISSUE: reference to a compiler-generated field
            source1.Add(class871.gclass65_0);
          }
        }
      }
      if (source1.Count > 0)
      {
        List<GClass110> source2 = new List<GClass110>();
        foreach (GClass65 gclass65 in source1)
        {
          gclass65.string_1 = this.method_38(gclass65.int_1, gclass65.auroraContactType_0, false);
          if (gclass65.string_1 == "")
          {
            gclass65.gclass110_0 = (GClass110) null;
          }
          else
          {
            double num = this.gclass0_0.method_28(gclass65.double_0, gclass65.double_1, this.gclass85_0.double_2, this.gclass85_0.double_3);
            gclass65.string_1 = $"{gclass65.string_1}  {GClass226.smethod_50(num / 1000000.0)}m";
            GClass110 gclass110 = this.gclass21_0.dictionary_10[gclass65.gclass21_0.RaceID];
            if (!source2.Contains(gclass110))
              source2.Add(gclass110);
            gclass65.gclass110_0 = gclass110;
          }
        }
        foreach (GClass110 gclass110 in source2.OrderBy<GClass110, string>((Func<GClass110, string>) (gclass110_0 => gclass110_0.AlienRaceName)).ToList<GClass110>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass40.Class872 class872 = new GClass40.Class872();
          // ISSUE: reference to a compiler-generated field
          class872.gclass110_0 = gclass110;
          TreeNode node12 = new TreeNode();
          // ISSUE: reference to a compiler-generated field
          node12.Text = class872.gclass110_0.AlienRaceName;
          // ISSUE: reference to a compiler-generated field
          node12.Tag = (object) class872.gclass110_0;
          node11.Nodes.Add(node12);
          // ISSUE: reference to a compiler-generated method
          foreach (GClass65 gclass65 in source1.Where<GClass65>(new Func<GClass65, bool>(class872.method_0)).OrderBy<GClass65, AuroraContactType>((Func<GClass65, AuroraContactType>) (gclass65_0 => gclass65_0.auroraContactType_0)).ThenBy<GClass65, string>((Func<GClass65, string>) (gclass65_0 => gclass65_0.string_1)).ToList<GClass65>())
            node12.Nodes.Add(new TreeNode()
            {
              Text = gclass65.string_1,
              Tag = (object) gclass65
            });
          // ISSUE: reference to a compiler-generated field
          if (class872.gclass110_0.bool_6)
            node12.Expand();
          else
            node12.Collapse();
        }
      }
      List<GClass214> list5 = this.gclass0_0.dictionary_13.Values.Where<GClass214>((Func<GClass214, bool>) (gclass214_0 => gclass214_0.gclass21_0 == this.gclass21_0 && gclass214_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0)).OrderBy<GClass214, string>((Func<GClass214, string>) (gclass214_0 => gclass214_0.method_2(true))).ToList<GClass214>();
      if (list5.Count > 0)
      {
        TreeNode node13 = new TreeNode();
        node13.Text = "Waypoints";
        node11.Nodes.Add(node13);
        foreach (GClass214 gclass214 in list5)
          node13.Nodes.Add(new TreeNode()
          {
            Text = gclass214.method_2(true),
            Tag = (object) gclass214
          });
        node13.Expand();
      }
      node11.Expand();
      treeView_0.Visible = true;
      treeView_1.Visible = true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 357);
    }
  }

  public string method_38(int int_40, AuroraContactType auroraContactType_0, bool bool_22)
  {
    try
    {
      string str1 = "";
      switch (auroraContactType_0)
      {
        case AuroraContactType.Ship:
          if (this.gclass0_0.dictionary_4.ContainsKey(int_40))
          {
            str1 = this.gclass21_0.method_34(int_40);
            break;
          }
          break;
        case AuroraContactType.Salvo:
          if (this.gclass0_0.dictionary_6.ContainsKey(int_40))
          {
            str1 = "Missile Salvo #" + this.gclass0_0.dictionary_6[int_40].int_1.ToString();
            break;
          }
          break;
        case AuroraContactType.Population:
        case AuroraContactType.GroundUnit:
        case AuroraContactType.STOGroundUnit:
        case AuroraContactType.Shipyard:
          if (this.gclass0_0.dictionary_22.ContainsKey(int_40))
          {
            string str2 = this.gclass0_0.dictionary_22[int_40].gclass1_0.method_78(this.gclass21_0);
            string str3 = "";
            if (bool_22 && this.gclass21_0.dictionary_10.ContainsKey(this.gclass0_0.dictionary_22[int_40].gclass21_0.RaceID))
              str3 = $"[{this.gclass21_0.dictionary_10[this.gclass0_0.dictionary_22[int_40].gclass21_0.RaceID].string_0}]  ";
            switch (auroraContactType_0)
            {
              case AuroraContactType.Population:
                str1 = $"{str3}Pop: {str2}";
                break;
              case AuroraContactType.GroundUnit:
                str1 = $"{str3}Ground Forces: {str2}";
                break;
              case AuroraContactType.STOGroundUnit:
                str1 = $"{str3}STO Ground Forces: {str2}";
                break;
              case AuroraContactType.Shipyard:
                str1 = $"{str3}Shipyards: {str2}";
                break;
            }
          }
          else
          {
            if (auroraContactType_0 == AuroraContactType.Shipyard && this.gclass0_0.dictionary_31.ContainsKey(int_40))
            {
              str1 = $"[{this.gclass21_0.dictionary_10[this.gclass0_0.dictionary_22[int_40].gclass21_0.RaceID].string_0}]  " + "Deep Space Shipyard";
              break;
            }
            break;
          }
          break;
        case AuroraContactType.WayPoint:
          if (this.gclass0_0.dictionary_13.ContainsKey(int_40))
          {
            str1 = this.gclass0_0.dictionary_13[int_40].method_2(true);
            break;
          }
          break;
        default:
          if (this.gclass0_0.dictionary_28.ContainsKey(int_40))
          {
            str1 = this.gclass0_0.dictionary_28[int_40].string_0;
            break;
          }
          break;
      }
      return str1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 358);
      return "error";
    }
  }

  public void method_39(GClass230 gclass230_0, int int_40, GClass230 gclass230_1, int int_41)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class876 class876 = new GClass40.Class876();
    // ISSUE: reference to a compiler-generated field
    class876.gclass230_0 = gclass230_1;
    // ISSUE: reference to a compiler-generated field
    class876.int_0 = int_41;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass31 gclass31 = this.list_2.Where<GClass31>(new Func<GClass31, bool>(class876.method_0)).FirstOrDefault<GClass31>();
      if (gclass31 != null)
      {
        gclass31.gclass230_1 = gclass230_0;
        gclass31.int_1 = int_40;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.list_2.Add(new GClass31()
        {
          gclass40_0 = this,
          gclass230_1 = gclass230_0,
          int_1 = int_40,
          gclass230_0 = class876.gclass230_0,
          int_0 = class876.int_0
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 359);
    }
  }

  public void method_40(int int_40)
  {
    try
    {
      Decimal num1 = this.method_157(AuroraComponentType.Shields, false) * this.decimal_9;
      Decimal num2 = num1 - this.decimal_3;
      Decimal num3 = this.method_175(int_40);
      if (num3 >= num2)
        this.decimal_3 = num1;
      else
        this.decimal_3 += num3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 360);
    }
  }

  public void method_41(int int_40)
  {
    try
    {
      int num1 = (int) Math.Floor((Decimal) (this.gclass22_0.int_2 * this.gclass22_0.int_3) * ((Decimal) int_40 / GClass226.decimal_34));
      if (num1 == 0)
        return;
      int num2 = this.dictionary_5.Values.Sum<int>((Func<int, int>) (int_0 => int_0));
      if (num1 >= num2)
      {
        this.dictionary_5.Clear();
      }
      else
      {
        do
        {
          Dictionary<int, int> dictionary5 = this.dictionary_5;
          // ISSUE: reference to a compiler-generated field
          Func<KeyValuePair<int, int>, int> func = GClass40.staticCompGen.staticCompMem__41_1;
          if (func == null)
            goto label_9;
          goto label_12;
label_5:
          Func<KeyValuePair<int, int>, int> keySelector;
          int key = dictionary5.OrderByDescending<KeyValuePair<int, int>, int>(keySelector).Select<KeyValuePair<int, int>, int>((Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Key)).FirstOrDefault<int>();
          if (this.dictionary_5[key] == 1)
            this.dictionary_5.Remove(key);
          else
            this.dictionary_5[key]--;
          --num1;
          continue;
label_12:
          keySelector = func;
          goto label_5;
label_9:
          // ISSUE: reference to a compiler-generated field
          GClass40.staticCompGen.staticCompMem__41_1 = keySelector = (Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Value);
          goto label_5;
        }
        while (num1 != 0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 361);
    }
  }

  public GEnum52 method_42(List<GClass146> list_21, List<GClass85> list_22)
  {
    try
    {
      return list_21.FirstOrDefault<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass21_0 == this.gclass21_0 && gclass146_0.gclass202_0 == this.gclass85_0.gclass202_0 && gclass146_0.method_87() == this.gclass85_0.double_2 && gclass146_0.method_88() == this.gclass85_0.double_3)) != null || list_22.FirstOrDefault<GClass85>((Func<GClass85, bool>) (gclass85_1 => gclass85_1.gclass21_0 == this.gclass21_0 && gclass85_1.gclass202_0 == this.gclass85_0.gclass202_0 && gclass85_1.double_2 == this.gclass85_0.double_2 && gclass85_1.double_3 == this.gclass85_0.double_3)) != null ? GEnum52.const_0 : GEnum52.const_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 362);
      return GEnum52.const_1;
    }
  }

  public void method_43(int int_40, List<GClass146> list_21, List<GClass85> list_22)
  {
    try
    {
      this.list_7 = this.list_7.OrderBy<GClass27, Decimal>((Func<GClass27, Decimal>) (gclass27_0 => gclass27_0.gclass230_0.decimal_0)).ToList<GClass27>();
      Decimal num1 = this.method_157(AuroraComponentType.PowerPlant, false) * (Decimal) ((double) int_40 / 5.0);
      GEnum52 genum52 = GEnum52.const_2;
      foreach (GClass27 gclass27 in this.list_7)
      {
        if (gclass27.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.MissileLauncher && gclass27.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.DecoyMissileLauncher)
        {
          if (num1 > 0M)
          {
            Decimal num2 = gclass27.gclass230_0.decimal_4 * (Decimal) ((double) int_40 / 5.0);
            if (num1 < num2)
              num2 = num1;
            if (gclass27.decimal_0 <= num2)
            {
              num1 -= gclass27.decimal_0;
              gclass27.decimal_0 = 0M;
            }
            else
            {
              num1 -= num2;
              gclass27.decimal_0 -= num2;
            }
          }
        }
        else
        {
          bool flag = false;
          Decimal num3 = 1M;
          if (this.gclass40_0 != null)
          {
            Decimal num4 = this.gclass40_0.method_123(GEnum121.const_6);
            num3 /= num4;
          }
          if (!gclass27.gclass230_0.bool_7)
            flag = true;
          else if (this.gclass40_0 != null)
          {
            flag = true;
          }
          else
          {
            switch (genum52)
            {
              case GEnum52.const_0:
                flag = true;
                num3 = GClass226.decimal_38;
                break;
              case GEnum52.const_2:
                genum52 = this.method_42(list_21, list_22);
                if (genum52 == GEnum52.const_0)
                {
                  flag = true;
                  num3 = GClass226.decimal_38;
                  break;
                }
                break;
            }
          }
          if (flag)
          {
            if (gclass27.decimal_0 <= (Decimal) int_40 / num3)
            {
              gclass27.decimal_0 = 0M;
            }
            else
            {
              gclass27.decimal_0 -= (Decimal) int_40 / num3;
              if (this.gclass21_0.bool_0 && gclass27.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileLauncher && this.gclass22_0.gclass14_0.genum69_0 == GEnum69.const_3)
                this.gclass85_0.int_11 = 1;
            }
          }
        }
      }
      this.list_7 = this.list_7.Where<GClass27>((Func<GClass27, bool>) (gclass27_0 => gclass27_0.decimal_0 > 0M)).ToList<GClass27>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 363);
    }
  }

  public void method_44()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class884 class884 = new GClass40.Class884();
    // ISSUE: reference to a compiler-generated field
    class884.gclass40_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0 = new GClass233(this.gclass0_0);
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.int_0 = this.gclass0_0.method_26(GEnum0.const_41);
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.int_1 = this.int_8;
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.gclass21_0 = this.gclass21_0;
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.gclass200_0 = this.gclass85_0.gclass202_0.gclass200_0;
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.gclass22_0 = this.gclass22_0;
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.gclass123_0 = new GClass123(this.gclass0_0);
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.gclass123_0.method_13(this.gclass22_0);
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.double_0 = this.gclass85_0.double_2;
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.double_1 = this.gclass85_0.double_3;
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.decimal_0 = this.gclass22_0.decimal_14;
      // ISSUE: reference to a compiler-generated field
      class884.gclass233_0.method_0();
      foreach (GClass228 gclass228 in this.gclass22_0.dictionary_0.Values)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class885 class885 = new GClass40.Class885();
        // ISSUE: reference to a compiler-generated field
        class885.gclass228_0 = gclass228;
        // ISSUE: reference to a compiler-generated field
        if (!class885.gclass228_0.gclass230_0.bool_0)
        {
          // ISSUE: reference to a compiler-generated method
          GClass178 gclass178 = this.list_12.Where<GClass178>(new Func<GClass178, bool>(class885.method_0)).FirstOrDefault<GClass178>();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          int num = gclass178 != null ? (int) class885.gclass228_0.decimal_0 - gclass178.int_0 : (int) class885.gclass228_0.decimal_0;
          if (num > 5)
            num = 5;
          if (num > 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class884.gclass233_0.list_1.Add(new GClass235()
            {
              gclass230_0 = class885.gclass228_0.gclass230_0,
              int_0 = num
            });
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      GClass1 gclass1 = this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class884.method_0)).FirstOrDefault<GClass1>();
      if (gclass1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        class884.gclass233_0.gclass1_0 = gclass1;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.gclass0_0.dictionary_29.Add(class884.gclass233_0.int_0, class884.gclass233_0);
      // ISSUE: reference to a compiler-generated method
      List<GClass21> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class884.method_1)).Select<GClass40, GClass21>((Func<GClass40, GClass21>) (gclass40_0 => gclass40_0.gclass21_0)).Distinct<GClass21>().ToList<GClass21>();
      // ISSUE: reference to a compiler-generated method
      list.AddRange((IEnumerable<GClass21>) this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class884.method_2)).Select<GClass146, GClass21>((Func<GClass146, GClass21>) (gclass146_0 => gclass146_0.gclass21_0)).Distinct<GClass21>().ToList<GClass21>());
      // ISSUE: reference to a compiler-generated method
      foreach (GClass21 gclass21 in list.Distinct<GClass21>().Where<GClass21>(new Func<GClass21, bool>(class884.method_3)).ToList<GClass21>())
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_224, $"{class884.gclass233_0.method_1(gclass21, false)} detected in {gclass21.method_277(class884.gclass233_0.gclass200_0.int_0)}", gclass21, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Combat);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 364);
    }
  }

  public void method_45(GEnum22 genum22_0)
  {
    try
    {
      GClass59 gclass59 = new GClass59(this.gclass0_0);
      GClass146 gclass146 = (GClass146) null;
      List<GClass55> source = this.method_198();
      foreach (GClass55 gclass55 in this.method_193())
        source.Add(gclass55);
      Decimal d = (Decimal) this.int_11;
      if (genum22_0 != GEnum22.const_4)
        d = (Decimal) this.int_11 * ((Decimal) (GClass226.smethod_13(50) + 25) / 100M);
      if (d <= 0M)
        return;
      gclass59.gclass21_0 = this.gclass21_0;
      gclass59.gclass194_0 = this.gclass194_0;
      gclass59.gclass200_0 = this.gclass85_0.gclass202_0.gclass200_0;
      gclass59.gclass22_0 = this.gclass22_0;
      gclass59.double_0 = this.gclass85_0.double_2;
      gclass59.double_1 = this.gclass85_0.double_3;
      gclass59.string_0 = this.ShipName;
      gclass59.decimal_0 = this.gclass0_0.decimal_0;
      gclass59.decimal_1 = this.decimal_15;
      gclass59.int_0 = this.gclass0_0.method_26(GEnum0.const_28);
      gclass59.int_1 = (int) Math.Floor(d);
      this.gclass0_0.dictionary_30.Add(gclass59.int_0, gclass59);
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_145, $"Lifepods launched prior to the destruction of {this.ShipName}. {gclass59.int_1.ToString()} have survived from an original crew of {this.gclass22_0.int_11.ToString()}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      GClass55 gclass55_1 = this.method_192(AuroraCommandType.Ship);
      if (gclass55_1 != null)
        source.Add(gclass55_1);
      GClass55 gclass55_2 = this.method_192(AuroraCommandType.ExecutiveOfficer);
      if (gclass55_2 != null)
        source.Add(gclass55_2);
      GClass55 gclass55_3 = this.method_192(AuroraCommandType.ChiefEngineer);
      if (gclass55_3 != null)
        source.Add(gclass55_3);
      GClass55 gclass55_4 = this.method_192(AuroraCommandType.ScienceOfficer);
      if (gclass55_4 != null)
        source.Add(gclass55_4);
      GClass55 gclass55_5 = this.method_192(AuroraCommandType.TacticalOfficer);
      if (gclass55_5 != null)
        source.Add(gclass55_5);
      GClass55 gclass55_6 = this.method_192(AuroraCommandType.CAG);
      if (gclass55_6 != null)
        source.Add(gclass55_6);
      foreach (GClass55 gclass55_7 in source.Distinct<GClass55>().ToList<GClass55>())
      {
        gclass55_7.method_40(true);
        gclass55_7.gclass40_0 = (GClass40) null;
        if (!GClass226.smethod_23() && genum22_0 != GEnum22.const_4)
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_7, $"{gclass55_7.string_0} failed to escape the destruction of {this.ShipName}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          gclass55_7.method_46("Killed during the destruction of " + this.ShipName, GEnum28.const_0);
          gclass55_7.method_42(AuroraRetirementStatus.KilledNaval);
        }
        else if (gclass59 != null)
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_7, $"{gclass55_7.string_0} escaped to a lifepod before the destruction of {this.ShipName}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          gclass55_7.method_46($"Escaped the destruction of {this.ShipName} and made it to a lifepod", GEnum28.const_0);
          gclass55_7.method_1(AuroraMeasurementType.ShipDestructionSurvived, 1M);
          gclass55_7.gclass59_0 = gclass59;
        }
        else
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_7, $"{gclass55_7.string_0} escaped from the destruction of {this.ShipName}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          gclass55_7.method_46("Escaped the destruction of " + this.ShipName, GEnum28.const_0);
          if (gclass146 != null)
            gclass55_7.gclass146_0 = gclass146;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 365);
    }
  }

  public string ShipName { get; set; }

  public string ShipNameWithHull { get; set; }

  public string ShipNameWithHullAndClass { get; set; }

  public string ContactDropdownName { get; set; }

  public GClass40(GClass0 gclass0_1)
  {
    this.gclass0_0 = gclass0_1;
    this.gclass123_0 = new GClass123(gclass0_1);
  }

  public void method_46()
  {
    try
    {
      this.decimal_18 = this.gclass0_0.decimal_0;
      this.gclass85_0.decimal_8 = this.decimal_18;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3889);
    }
  }

  public void method_47(GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class806 class806 = new GClass40.Class806();
    // ISSUE: reference to a compiler-generated field
    class806.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass73> list = this.list_17.Where<GClass73>(new Func<GClass73, bool>(class806.method_0)).ToList<GClass73>();
      if (list.Count == 0)
        return;
      Decimal decimal_73_1 = list.Sum<GClass73>((Func<GClass73, Decimal>) (gclass73_0 => gclass73_0.decimal_0));
      Decimal decimal_11 = decimal_73_1 * 0.3M;
      // ISSUE: reference to a compiler-generated field
      Decimal num = class806.gclass230_0.decimal_2 * decimal_73_1 * 0.3M;
      // ISSUE: reference to a compiler-generated field
      Decimal decimal_73_2 = class806.gclass230_0.gclass123_0.method_7() * decimal_11;
      // ISSUE: reference to a compiler-generated field
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_69, $"{GClass226.smethod_38(decimal_73_1)}x {class806.gclass230_0.Name} scrapped on {this.ShipName}. Recovered {GClass226.smethod_38(num)} wealth and {GClass226.smethod_38(decimal_73_2)} tons of minerals", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      // ISSUE: reference to a compiler-generated field
      this.gclass123_0.method_11(class806.gclass230_0.gclass123_0, decimal_11);
      this.gclass21_0.method_300(num, this.gclass0_0.dictionary_45[GEnum84.const_9]);
      // ISSUE: reference to a compiler-generated method
      this.list_17 = this.list_17.Where<GClass73>(new Func<GClass73, bool>(class806.method_1)).ToList<GClass73>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2119);
    }
  }

  public bool method_48()
  {
    try
    {
      return this.list_4.Count<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.bool_0)) > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3787);
      return false;
    }
  }

  public Decimal method_49()
  {
    try
    {
      int num1 = this.gclass22_0.int_2 * this.gclass22_0.int_3;
      int num2 = this.dictionary_5.Sum<KeyValuePair<int, int>>((Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Value));
      return (Decimal) (num1 - num2) / (Decimal) num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3703);
      return 1M;
    }
  }

  public void method_50()
  {
    try
    {
      foreach (GClass75 gclass75 in this.gclass22_0.list_2)
      {
        for (int index = 1; index <= gclass75.int_0; ++index)
        {
          string string_10 = $"{GClass226.smethod_80(gclass75.gclass102_0.int_1 + 1)} {gclass75.gclass102_0.Name}";
          if (this.gclass21_0.checkState_0 == CheckState.Checked)
          {
            string str = GClass226.smethod_79(gclass75.gclass102_0.int_1 + 1);
            string_10 = $"{gclass75.gclass102_0.Name} {str}";
          }
          ++gclass75.gclass102_0.int_1;
          this.gclass21_0.method_158(string_10, gclass75.gclass102_0.string_1, gclass75.gclass102_0, (GClass146) null, this, this.gclass194_0, (GClass103) null, 0, AuroraGroundFormationFieldPosition.FrontlineDefence);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3635);
    }
  }

  public Decimal method_51()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass40.Class807 class807 = new GClass40.Class807();
      if (this.gclass22_0.decimal_2 == this.gclass22_0.decimal_14)
        return this.gclass22_0.decimal_14;
      if (this.list_12.Count == 0)
        return this.gclass22_0.decimal_2;
      // ISSUE: reference to a compiler-generated field
      class807.gclass228_0 = this.gclass22_0.dictionary_0.Values.FirstOrDefault<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.CloakingDevice));
      // ISSUE: reference to a compiler-generated method
      return this.list_12.Count<GClass178>(new Func<GClass178, bool>(class807.method_0)) > 0 ? this.gclass22_0.decimal_14 : this.gclass22_0.decimal_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3577);
      return this.gclass22_0.decimal_14;
    }
  }

  public Decimal method_52()
  {
    try
    {
      Decimal num = this.gclass22_0.decimal_14 * (Decimal) this.gclass22_0.int_32;
      if (this.gclass22_0.bool_2)
        num /= 100M;
      if (this.gclass22_0.decimal_14 < 21M)
        num /= 2M;
      if (this.gclass0_0.decimal_0 - this.decimal_12 < 300M && this.decimal_12 > this.decimal_13)
        num /= 5M;
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3571);
      return 0M;
    }
  }

  public void method_53(Decimal decimal_42)
  {
    try
    {
      Decimal num1 = 0M;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ColonistTransport && gclass228_0.gclass230_0.genum87_0 == GEnum87.const_7)).ToList<GClass228>())
      {
        this.method_158(gclass228_0);
        num1 += gclass228_0.gclass230_0.decimal_3;
      }
      int num2 = this.list_18.Sum<GClass181>((Func<GClass181, int>) (gclass181_0 => gclass181_0.int_0));
      if (!((Decimal) num2 < num1))
        return;
      Decimal num3 = (Decimal) num2;
      Decimal num4 = (1M - (Decimal) num2 / num1) * 0.05M * decimal_42;
      foreach (GClass181 gclass181 in this.list_18)
      {
        num4 *= gclass181.gclass194_0.decimal_1;
        gclass181.int_0 *= (int) Math.Round(1M + num4);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3558);
    }
  }

  public void method_54(GClass70 gclass70_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class808 class808 = new GClass40.Class808();
    // ISSUE: reference to a compiler-generated field
    class808.gclass70_0 = gclass70_1;
    try
    {
      // ISSUE: reference to a compiler-generated method
      foreach (GClass40 gclass40 in this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class808.method_0)).ToList<GClass40>())
      {
        gclass40.gclass70_0 = (GClass70) null;
        gclass40.int_22 = 0;
      }
      // ISSUE: reference to a compiler-generated field
      this.dictionary_0.Remove(class808.gclass70_0.int_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3518);
    }
  }

  public void method_55(GClass21 gclass21_1)
  {
    try
    {
      this.double_3 = 1.0;
      if (!gclass21_1.bool_0)
        return;
      GClass117 gclass117 = gclass21_1.method_267(this);
      if (gclass117 == null)
        this.double_3 = 0.0;
      if (gclass117.gclass115_0.list_1.Count > 0)
        this.double_3 = 6.0;
      if (gclass117.gclass115_0.genum70_0 != GEnum70.const_2)
        this.double_3 = 2.0;
      this.double_3 *= (double) this.gclass22_0.decimal_14;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2708);
    }
  }

  public void method_56(AuroraMeasurementType auroraMeasurementType_0, Decimal decimal_42)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class809 class809 = new GClass40.Class809();
    // ISSUE: reference to a compiler-generated field
    class809.auroraMeasurementType_0 = auroraMeasurementType_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass54 gclass54_1 = this.list_0.FirstOrDefault<GClass54>(new Func<GClass54, bool>(class809.method_0));
      if (gclass54_1 != null)
      {
        gclass54_1.decimal_0 += decimal_42;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.list_0.Add(new GClass54()
        {
          auroraMeasurementType_0 = class809.auroraMeasurementType_0,
          decimal_0 = decimal_42,
          bool_0 = false
        });
      }
      if (this.gclass40_1 == null)
        return;
      // ISSUE: reference to a compiler-generated method
      GClass54 gclass54_2 = this.gclass40_1.list_0.FirstOrDefault<GClass54>(new Func<GClass54, bool>(class809.method_1));
      if (gclass54_2 != null)
      {
        gclass54_2.decimal_0 += decimal_42;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.gclass40_1.list_0.Add(new GClass54()
        {
          auroraMeasurementType_0 = class809.auroraMeasurementType_0,
          decimal_0 = decimal_42,
          bool_0 = true
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2709);
    }
  }

  public GClass65 method_57(
    List<GClass65> list_21,
    AuroraComponentType auroraComponentType_0,
    double double_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class810 class810 = new GClass40.Class810();
    // ISSUE: reference to a compiler-generated field
    class810.auroraComponentType_0 = auroraComponentType_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass36> list = this.list_4.Where<GClass36>(new Func<GClass36, bool>(class810.method_0)).ToList<GClass36>();
      if (list.Count == 0)
        return (GClass65) null;
      GClass65 gclass65_0 = (GClass65) null;
      foreach (GClass65 gclass65 in list_21)
      {
        if (gclass65.gclass40_0 != null)
        {
          double num1 = this.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, gclass65.gclass40_0.gclass85_0.double_2, gclass65.gclass40_0.gclass85_0.double_3);
          foreach (GClass36 gclass36 in list)
          {
            double num2 = gclass36.method_3(this) * double_4;
            if (num2 != 0.0 && num1 <= num2)
            {
              gclass65_0 = gclass65;
              break;
            }
          }
          if (gclass65_0 != null)
            break;
        }
      }
      if (gclass65_0 == null)
        return (GClass65) null;
      foreach (GClass36 gclass36_0 in list)
        this.method_26(gclass36_0, gclass65_0);
      return gclass65_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2710);
      return (GClass65) null;
    }
  }

  public void method_58(GClass101 gclass101_0, int int_40, int int_41, int int_42, int int_43)
  {
    try
    {
      if (this.dictionary_4.ContainsKey(gclass101_0))
      {
        this.dictionary_4[gclass101_0].int_0 += int_40;
        this.dictionary_4[gclass101_0].int_1 += int_41;
        this.dictionary_4[gclass101_0].int_2 += int_42;
        this.dictionary_4[gclass101_0].int_3 += int_43;
      }
      else
      {
        GClass104 gclass104 = new GClass104()
        {
          gclass101_0 = gclass101_0
        };
        gclass104.string_0 = this.gclass21_0.method_323(gclass104.gclass101_0);
        gclass104.int_0 = int_40;
        gclass104.int_1 = int_41;
        gclass104.int_2 = int_42;
        gclass104.int_3 = int_43;
        this.dictionary_4.Add(gclass101_0, gclass104);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2711);
    }
  }

  public void method_59(
    GClass103 gclass103_1,
    GClass39 gclass39_0_1,
    GClass1 gclass1_0,
    Decimal decimal_42,
    GEnum56 genum56_0,
    GClass109 gclass109_0)
  {
    try
    {
      switch (genum56_0)
      {
        case GEnum56.const_1:
          gclass103_1.int_9 = 0;
          using (List<GClass39>.Enumerator enumerator = gclass103_1.list_0.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              GClass39 current = enumerator.Current;
              Decimal num = (Decimal) current.int_1 * current.gclass101_0.decimal_2;
              if (current.gclass101_0.bool_0)
                num /= 5M;
              current.long_0 = (long) (gclass103_1.int_9 + 1);
              gclass103_1.int_9 += (int) num;
              current.long_1 = (long) gclass103_1.int_9;
            }
            break;
          }
        case GEnum56.const_2:
          gclass103_1.int_9 = 0;
          List<GClass39> list1 = gclass103_1.list_0.Where<GClass39>((Func<GClass39, bool>) (gclass39_0_2 => gclass39_0_2.gclass101_0.method_3(GEnum54.const_1))).ToList<GClass39>();
          if (list1.Count == 0)
          {
            gclass103_1.list_2.Add(this);
            return;
          }
          using (List<GClass39>.Enumerator enumerator = list1.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              GClass39 current = enumerator.Current;
              Decimal num = (Decimal) current.int_1 * current.gclass101_0.decimal_2;
              if (current.gclass101_0.bool_0)
                num /= 5M;
              current.long_0 = (long) (gclass103_1.int_9 + 1);
              gclass103_1.int_9 += (int) num;
              current.long_1 = (long) gclass103_1.int_9;
            }
            break;
          }
      }
      Decimal decimal_42_1 = 0M;
      if (genum56_0 != GEnum56.const_3)
      {
        if (gclass39_0_1 != null)
          gclass39_0_1.gclass103_0.list_2.Add(this);
        else
          gclass103_1?.list_2.Add(this);
      }
      Decimal num1 = this.method_190();
      Decimal num2 = this.method_123(GEnum121.const_31);
      if (genum56_0 == GEnum56.const_3)
      {
        foreach (GClass36 gclass36 in this.list_4.Where<GClass36>((Func<GClass36, bool>) (gclass36_0 => gclass36_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl && !gclass36_0.bool_1)).ToList<GClass36>())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          List<GClass31> list2 = this.list_2.Where<GClass31>(new Func<GClass31, bool>(new GClass40.Class811()
          {
            gclass36_0 = gclass36
          }.method_0)).ToList<GClass31>();
          if (list2.Count != 0)
          {
            List<GClass31> gclass31List = this.method_20(list2);
            if (gclass31List.Count != 0)
            {
              foreach (GClass31 gclass31_0 in gclass31List)
              {
                GClass39 gclass39 = gclass39_0_1;
                if (gclass39 == null)
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: reference to a compiler-generated method
                  gclass39 = gclass103_1.list_0.FirstOrDefault<GClass39>(new Func<GClass39, bool>(new GClass40.Class812()
                  {
                    int_0 = GClass226.smethod_13(gclass103_1.int_9)
                  }.method_0));
                }
                Decimal num3;
                Decimal num4;
                if (gclass39.decimal_1 == 1M)
                {
                  num3 = (Decimal) GClass226.int_41 * gclass1_0.gclass99_0.decimal_0 * gclass39.gclass101_0.gclass96_0.decimal_3 * num1 * num2 * decimal_42;
                  num4 = 1M;
                }
                else
                {
                  num3 = (Decimal) GClass226.int_41 * gclass1_0.gclass99_0.decimal_0 * num1 * num2 * decimal_42;
                  num4 = gclass1_0.gclass99_0.decimal_1 * gclass39.decimal_1 * gclass39.gclass103_0.decimal_18;
                }
                Decimal num5 = num3 / num4;
                if (gclass31_0.gclass230_0.decimal_5 > 0M && gclass31_0.gclass230_0.decimal_5 < 1M)
                  num5 *= gclass31_0.gclass230_0.decimal_5;
                if (this.gclass21_0.genum6_0 != GEnum6.const_0 || this.gclass0_0.int_97 != 0 || !this.method_92(gclass31_0))
                {
                  Decimal decimal_6 = (Decimal) Math.Floor(20.0 * Math.Sqrt((double) gclass31_0.gclass230_0.method_5(1)));
                  Decimal decimal_5 = Math.Floor(decimal_6 / 2M);
                  this.method_58(gclass39.gclass101_0, gclass31_0.gclass230_0.int_7, 0, 0, 0);
                  for (int index = 1; index <= gclass31_0.gclass230_0.int_7; ++index)
                  {
                    gclass39.gclass103_0.gclass146_0.method_38(this.gclass21_0, Math.Pow((double) decimal_6 / 5.0, 3.0));
                    if (!((Decimal) GClass226.smethod_13(10000) > num5))
                      decimal_42_1 += gclass39.method_6((GClass39) null, this, gclass1_0, (GClass40) null, decimal_5, decimal_6, false);
                  }
                }
              }
            }
          }
        }
      }
      else
      {
        foreach (GClass30 gclass30 in this.list_5.Where<GClass30>((Func<GClass30, bool>) (gclass30_0 => gclass30_0.gclass129_0.decimal_18 > 0M)).ToList<GClass30>())
        {
          GClass39 gclass39 = gclass39_0_1;
          if (gclass39 == null)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            gclass39 = gclass103_1.list_0.FirstOrDefault<GClass39>(new Func<GClass39, bool>(new GClass40.Class813()
            {
              int_0 = GClass226.smethod_13(gclass103_1.int_9)
            }.method_0));
          }
          Decimal num6;
          Decimal num7;
          if (gclass39.decimal_1 == 1M)
          {
            num6 = (Decimal) GClass226.int_41 * gclass1_0.gclass99_0.decimal_0 * gclass39.gclass101_0.gclass96_0.decimal_3 * num1 * num2 * decimal_42;
            num7 = 1M;
          }
          else
          {
            num6 = (Decimal) GClass226.int_41 * gclass1_0.gclass99_0.decimal_0 * num1 * num2 * decimal_42;
            num7 = gclass1_0.gclass99_0.decimal_1 * gclass39.decimal_1 * gclass39.gclass103_0.decimal_18;
          }
          Decimal num8 = num6 / num7;
          this.method_58(gclass39.gclass101_0, (int) gclass30.gclass129_0.decimal_19, 0, 0, 0);
          for (int index = 1; (Decimal) index <= gclass30.gclass129_0.decimal_19; ++index)
          {
            gclass39.gclass103_0.gclass146_0.method_38(this.gclass21_0, Math.Pow((double) gclass30.gclass129_0.decimal_20, 3.0));
            if (!((Decimal) GClass226.smethod_13(10000) > num8))
              decimal_42_1 += gclass39.method_6((GClass39) null, this, gclass1_0, (GClass40) null, gclass30.gclass129_0.decimal_17, gclass30.gclass129_0.decimal_18, false);
          }
        }
      }
      if (!(decimal_42_1 > 0M))
        return;
      this.method_72(AuroraMeasurementType.GroundForcesDestroyed, decimal_42_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2712);
    }
  }

  public string method_60(CheckState checkState_0)
  {
    try
    {
      string str = this.method_187();
      if (checkState_0 == CheckState.Checked && this.gclass103_0 != null)
        str = $"{str} ---> {this.gclass103_0.string_1} {this.gclass103_0.Name}";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2713);
      return "error";
    }
  }

  public void method_61(GClass21 gclass21_1)
  {
    try
    {
      GClass115 gclass115 = gclass21_1.method_36(this.gclass22_0);
      gclass115.method_8();
      gclass115.gclass110_0.bool_4 = true;
      GClass110 gclass110 = this.gclass21_0.method_325(gclass21_1.RaceID);
      string str = "an unknown alien race";
      if (gclass110 != null)
        str = gclass110.AlienRaceName;
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_98, $"{this.method_187()} has surrended to {str}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_98, $"The alien ship {gclass21_1.dictionary_12.Values.FirstOrDefault<GClass117>((Func<GClass117, bool>) (gclass117_0 => gclass117_0.gclass40_0 == this)).method_11()} has surrended to our forces", gclass21_1, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      GClass180 gclass180 = new GClass180();
      gclass180.gclass21_0 = this.gclass21_0;
      gclass180.gclass194_0 = this.gclass194_0;
      gclass180.int_0 = this.int_11;
      gclass180.gclass40_0 = this;
      foreach (GClass55 gclass55 in this.dictionary_1.Values.ToList<GClass55>())
      {
        gclass55.method_46("Surrendered to " + gclass21_1.RaceTitle, GEnum28.const_2);
        gclass55.method_40(false);
        gclass55.gclass40_0 = this;
        gclass55.bool_4 = true;
      }
      this.gclass21_0.method_271(this, (GClass85) null, gclass21_1, true);
      this.list_1.Add(gclass180);
      this.decimal_9 = 0.01M;
      this.decimal_7 = this.gclass0_0.decimal_0 - this.gclass22_0.decimal_9 * 2M * GClass226.decimal_31;
      this.int_11 = 1;
      this.int_1 = 0;
      if (this.gclass22_0.bool_2)
        return;
      this.decimal_2 = 0.25M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2714);
    }
  }

  public void method_62(bool bool_22)
  {
    try
    {
      this.list_10.Clear();
      List<GClass130> gclass130List = this.gclass22_0.list_0;
      if (bool_22 && this.list_9.Count > 0)
        gclass130List = this.list_9;
      foreach (GClass130 gclass130 in gclass130List)
        this.list_10.Add(new GClass130()
        {
          gclass129_0 = gclass130.gclass129_0,
          int_0 = gclass130.int_0
        });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2715);
    }
  }

  public void method_63(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_601(listView_0, "Ship Template Loadout", "Num", (string) null);
      this.gclass0_0.method_594(listView_0, "");
      List<GClass130> list = this.list_9.OrderBy<GClass130, string>((Func<GClass130, string>) (gclass130_0 => gclass130_0.gclass129_0.Name)).ToList<GClass130>();
      foreach (GClass130 object_1 in list)
        this.gclass0_0.method_598(listView_0, object_1.gclass129_0.Name, GClass226.smethod_37(object_1.int_0), (object) object_1);
      Decimal decimal_73_1 = this.method_70();
      Decimal decimal_73_2 = this.method_71();
      if (list.Count > 0)
        this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_597(listView_0, "Available Space", $"{GClass226.smethod_42(decimal_73_1, 2)} / {GClass226.smethod_42(decimal_73_2, 2)}");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2716);
    }
  }

  public void method_64(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_601(listView_0, "Current Loadout", "Num", (string) null);
      this.gclass0_0.method_594(listView_0, "");
      List<GClass130> list = this.list_10.OrderBy<GClass130, string>((Func<GClass130, string>) (gclass130_0 => gclass130_0.gclass129_0.Name)).ToList<GClass130>();
      foreach (GClass130 object_1 in list)
        this.gclass0_0.method_598(listView_0, object_1.gclass129_0.Name, GClass226.smethod_37(object_1.int_0), (object) object_1);
      Decimal decimal_73_1 = this.method_208();
      Decimal decimal_73_2 = this.method_209();
      if (list.Count > 0)
        this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_597(listView_0, "Available Space", $"{GClass226.smethod_42(decimal_73_1, 2)} / {GClass226.smethod_42(decimal_73_2, 2)}");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2717);
    }
  }

  public void method_65()
  {
    try
    {
      this.list_9.Clear();
      foreach (GClass130 gclass130 in this.gclass22_0.list_0)
        this.list_9.Add(new GClass130()
        {
          gclass129_0 = gclass130.gclass129_0,
          int_0 = gclass130.int_0
        });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2718);
    }
  }

  public void method_66()
  {
    try
    {
      this.gclass22_0.list_0.Clear();
      foreach (GClass130 gclass130 in this.list_9)
        this.gclass22_0.list_0.Add(new GClass130()
        {
          gclass129_0 = gclass130.gclass129_0,
          int_0 = gclass130.int_0
        });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2719);
    }
  }

  public void method_67()
  {
    try
    {
      foreach (GClass40 gclass40 in this.gclass85_0.method_176().Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4 != this && gclass40_4.gclass22_0 == this.gclass22_0)).ToList<GClass40>())
      {
        gclass40.list_9.Clear();
        foreach (GClass130 gclass130 in this.list_9)
          gclass40.list_9.Add(new GClass130()
          {
            gclass129_0 = gclass130.gclass129_0,
            int_0 = gclass130.int_0
          });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2720);
    }
  }

  public void method_68(GClass129 gclass129_0, int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class814 class814 = new GClass40.Class814();
    // ISSUE: reference to a compiler-generated field
    class814.gclass129_0 = gclass129_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (int_40 == 0 || class814.gclass129_0 == null)
        return;
      // ISSUE: reference to a compiler-generated field
      if (class814.gclass129_0.int_14 == 0)
      {
        Decimal num = this.method_70();
        // ISSUE: reference to a compiler-generated field
        if (class814.gclass129_0.decimal_4 * (Decimal) int_40 > num)
        {
          // ISSUE: reference to a compiler-generated field
          int_40 = (int) (num / class814.gclass129_0.decimal_4);
        }
      }
      else
      {
        Decimal num = this.method_71();
        // ISSUE: reference to a compiler-generated field
        if (class814.gclass129_0.decimal_4 * (Decimal) int_40 > num)
        {
          // ISSUE: reference to a compiler-generated field
          int_40 = (int) (num / class814.gclass129_0.decimal_4);
        }
      }
      // ISSUE: reference to a compiler-generated method
      List<GClass130> list = this.list_9.Where<GClass130>(new Func<GClass130, bool>(class814.method_0)).ToList<GClass130>();
      if (list.Count == 1)
      {
        list[0].int_0 += int_40;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.list_9.Add(new GClass130()
        {
          gclass129_0 = class814.gclass129_0,
          int_0 = int_40
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2721);
    }
  }

  public void method_69(GClass130 gclass130_0, int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class815 class815 = new GClass40.Class815();
    // ISSUE: reference to a compiler-generated field
    class815.gclass130_0 = gclass130_0;
    try
    {
      if (int_40 == 0)
        return;
      // ISSUE: reference to a compiler-generated method
      List<GClass130> list = this.list_9.Where<GClass130>(new Func<GClass130, bool>(class815.method_0)).ToList<GClass130>();
      if (list.Count != 1)
        return;
      if (list[0].int_0 > int_40)
      {
        list[0].int_0 -= int_40;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.list_9.Remove(class815.gclass130_0);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2722);
    }
  }

  public Decimal method_70()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass130 gclass130 in this.list_9.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 0)).ToList<GClass130>())
        num += gclass130.gclass129_0.decimal_4 * (Decimal) gclass130.int_0;
      return this.method_181() - num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2723);
      return 0M;
    }
  }

  public Decimal method_71()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass130 gclass130 in this.list_9.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 1)).ToList<GClass130>())
        num += gclass130.gclass129_0.decimal_4 * (Decimal) gclass130.int_0;
      return this.method_182() - num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3698);
      return 0M;
    }
  }

  public void method_72(AuroraMeasurementType auroraMeasurementType_0, Decimal decimal_42)
  {
    try
    {
      this.method_56(auroraMeasurementType_0, decimal_42);
      this.method_192(AuroraCommandType.Ship)?.method_1(auroraMeasurementType_0, decimal_42);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2724);
    }
  }

  public Decimal method_73()
  {
    try
    {
      return Math.Round((this.gclass0_0.decimal_0 - this.decimal_7) / GClass226.decimal_31 / this.gclass22_0.decimal_9 * 100M);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2725);
      return 0M;
    }
  }

  public int method_74()
  {
    try
    {
      return this.gclass85_0.dictionary_0.Count == 0 ? 0 : this.gclass85_0.int_6;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2726);
      return 0;
    }
  }

  public double method_75(int int_40)
  {
    try
    {
      double num1 = 0.0;
      int num2 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileLauncher && gclass228_0.decimal_4 < (Decimal) GClass226.int_53)).Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
      int num3 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.bool_4 && gclass228_0.gclass230_0.decimal_4 > gclass228_0.gclass230_0.decimal_0 / 2M)).Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
      if (num2 == 0 && num3 == 0)
        return 0.0;
      if (num2 > 0 && this.list_10.Count > 0)
      {
        double num4 = (double) this.list_10.Select<GClass130, GClass129>((Func<GClass130, GClass129>) (gclass130_0 => gclass130_0.gclass129_0)).Distinct<GClass129>().OrderByDescending<GClass129, Decimal>((Func<GClass129, Decimal>) (gclass129_0 => gclass129_0.decimal_5)).FirstOrDefault<GClass129>().decimal_5 / (double) int_40 * (double) GClass226.int_9 * 0.01;
        num1 += (double) num2 * num4;
      }
      if (num3 > 0)
      {
        GClass230 gclass230 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl)).Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => this.method_158(gclass228_0) > 0)).Select<GClass228, GClass230>((Func<GClass228, GClass230>) (gclass228_0 => gclass228_0.gclass230_0)).OrderByDescending<GClass230, int>((Func<GClass230, int>) (gclass230_0 => gclass230_0.int_3)).FirstOrDefault<GClass230>();
        if (gclass230 != null)
        {
          if (gclass230.int_3 >= int_40)
            num1 += (double) num3;
          else
            num1 += (double) (num3 * (gclass230.int_3 / int_40));
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2727);
      return 0.0;
    }
  }

  public Decimal method_76(GClass40 gclass40_4, double double_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class817 class817 = new GClass40.Class817();
    // ISSUE: reference to a compiler-generated field
    class817.gclass40_0 = gclass40_4;
    // ISSUE: reference to a compiler-generated field
    class817.gclass40_1 = this;
    try
    {
      int num = 0;
      // ISSUE: reference to a compiler-generated method
      List<GClass36> list = this.list_4.Where<GClass36>(new Func<GClass36, bool>(class817.method_0)).ToList<GClass36>();
      if (list.Count == 0)
        return 0M;
      // ISSUE: reference to a compiler-generated method
      List<GClass31> gclass31List = this.method_20(list.SelectMany<GClass36, GClass31>(new Func<GClass36, IEnumerable<GClass31>>(class817.method_1)).ToList<GClass31>().Where<GClass31>((Func<GClass31, bool>) (gclass31_0 => !gclass31_0.gclass230_0.bool_10)).ToList<GClass31>());
      if (gclass31List.Count == 0)
        return 0M;
      foreach (GClass31 gclass31 in gclass31List)
        num += gclass31.gclass230_0.method_5((int) double_4) * gclass31.gclass230_0.int_7;
      return (Decimal) num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2728);
      return 0M;
    }
  }

  public Decimal method_77(GClass40 gclass40_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class818 class818 = new GClass40.Class818();
    // ISSUE: reference to a compiler-generated field
    class818.gclass40_0 = gclass40_4;
    // ISSUE: reference to a compiler-generated field
    class818.gclass40_1 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass36> list = this.list_4.Where<GClass36>(new Func<GClass36, bool>(class818.method_0)).ToList<GClass36>();
      if (list.Count == 0)
        return 0M;
      // ISSUE: reference to a compiler-generated method
      List<GClass31> source = this.method_20(list.SelectMany<GClass36, GClass31>(new Func<GClass36, IEnumerable<GClass31>>(class818.method_1)).ToList<GClass31>());
      // ISSUE: reference to a compiler-generated method
      return source.Count == 0 ? 0M : source.Select<GClass31, GClass30>(new Func<GClass31, GClass30>(class818.method_2)).ToList<GClass30>().Sum<GClass30>((Func<GClass30, Decimal>) (gclass30_0 => gclass30_0.gclass129_0.decimal_4));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2729);
      return 0M;
    }
  }

  public Decimal method_78(GClass146 gclass146_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class819 class819 = new GClass40.Class819();
    // ISSUE: reference to a compiler-generated field
    class819.gclass146_0 = gclass146_0;
    // ISSUE: reference to a compiler-generated field
    class819.gclass40_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      List<GClass36> list = this.list_4.Where<GClass36>(new Func<GClass36, bool>(class819.method_0)).ToList<GClass36>();
      if (list.Count == 0)
        return 0M;
      // ISSUE: reference to a compiler-generated method
      List<GClass31> source = this.method_20(list.SelectMany<GClass36, GClass31>(new Func<GClass36, IEnumerable<GClass31>>(class819.method_1)).ToList<GClass31>());
      // ISSUE: reference to a compiler-generated method
      return source.Count == 0 ? 0M : source.Select<GClass31, GClass30>(new Func<GClass31, GClass30>(class819.method_2)).ToList<GClass30>().Sum<GClass30>((Func<GClass30, Decimal>) (gclass30_0 => gclass30_0.gclass129_0.decimal_4));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2730);
      return 0M;
    }
  }

  public List<GClass31> method_79(GClass36 gclass36_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class820 class820 = new GClass40.Class820();
    // ISSUE: reference to a compiler-generated field
    class820.gclass36_0 = gclass36_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.list_2.Where<GClass31>(new Func<GClass31, bool>(class820.method_0)).ToList<GClass31>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2731);
      return (List<GClass31>) null;
    }
  }

  public GClass30 method_80(GClass31 gclass31_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class821 class821 = new GClass40.Class821();
    // ISSUE: reference to a compiler-generated field
    class821.gclass31_0 = gclass31_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.list_5.FirstOrDefault<GClass30>(new Func<GClass30, bool>(class821.method_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2732);
      return (GClass30) null;
    }
  }

  public Decimal method_81()
  {
    try
    {
      Decimal num1 = this.method_157(AuroraComponentType.Engine, false) * this.decimal_9;
      if (num1 == 0M)
        num1 = 1M;
      Decimal num2 = (Decimal) (int) (num1 / this.gclass22_0.decimal_14 * 1000M);
      if (num2 > 270000M)
        num2 = 270000M;
      return this.decimal_14 / (num1 * this.gclass22_0.decimal_6) * (num2 * 3600M);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2733);
      return 0M;
    }
  }

  public void method_82(GClass21 gclass21_1, double double_4)
  {
    try
    {
      if (double_4 == 0.0)
        return;
      double_4 /= 10000.0;
      double num1 = double_4 * 100.0;
      int decimal_13 = (int) Math.Floor(double_4);
      int num2 = (int) (num1 % 100.0);
      if (GClass226.smethod_13(100) <= num2)
        ++decimal_13;
      if (decimal_13 == 0)
        return;
      GClass117 gclass117 = gclass21_1.dictionary_12.Values.FirstOrDefault<GClass117>((Func<GClass117, bool>) (gclass117_0 => gclass117_0.gclass40_0 == this));
      this.gclass0_0.method_1(gclass21_1, (GClass40) null, (GClass230) null, (GClass129) null, (GClass39) null, AuroraContactType.Ship, this.int_8, 1, 1, 0, 0, 0, (Decimal) decimal_13, 0M, 0.0, 100.0, gclass117.method_11(), this.gclass21_0, false, false, false, true, false, GEnum62.const_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2734);
    }
  }

  public void method_83()
  {
    try
    {
      if (!this.gclass22_0.bool_2)
        this.decimal_9 = 0.01M;
      this.genum29_0 = GEnum29.const_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2735);
    }
  }

  public bool method_84()
  {
    try
    {
      return !this.gclass22_0.bool_2 && (this.gclass40_0 == null || this.gclass40_0.gclass22_0.bool_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2736);
      return false;
    }
  }

  public Decimal method_85()
  {
    try
    {
      GClass55 gclass55 = this.method_192(AuroraCommandType.Ship);
      Decimal num1 = 1M;
      if (gclass55 != null)
        num1 = gclass55.method_5(GEnum121.const_12);
      Decimal num2 = this.gclass85_0.gclass83_0.method_5(this.gclass85_0.gclass202_0.gclass200_0.int_0, GEnum121.const_12);
      return num1 * num2 - 1M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2737);
      return 0M;
    }
  }

  public int method_86(GEnum14 genum14_0)
  {
    try
    {
      if (this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.decimal_3 == this.gclass0_0.decimal_0)).Count<GClass65>() == 0)
        return 0;
      Decimal num1 = 1M - this.method_85();
      Decimal num2 = 1M;
      if (genum14_0 == GEnum14.const_1 || genum14_0 == GEnum14.const_2)
        num2 = 0.5M;
      int num3 = (int) Math.Round((1M - this.decimal_16 / 500M) * num1 * (Decimal) (GClass226.smethod_13(10) * GClass226.smethod_13(10)) * 0.5M * num2);
      return this.int_13 > num3 && genum14_0 != GEnum14.const_1 ? this.int_13 : num3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2738);
      return 0;
    }
  }

  public void method_87()
  {
    try
    {
      if (this.list_12.Count == 0)
        return;
      this.list_13.Clear();
      List<GClass178> list = this.list_12.OrderBy<GClass178, int>((Func<GClass178, int>) (gclass178_0 => gclass178_0.gclass230_0.gclass231_0.int_1)).ToList<GClass178>();
      int num = 1;
      foreach (GClass178 gclass178 in list)
      {
        for (int index = 1; index <= gclass178.int_0; ++index)
        {
          this.list_13.Add(new GClass26()
          {
            gclass230_0 = gclass178.gclass230_0,
            gclass40_0 = this,
            int_0 = num
          });
          ++num;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2739);
    }
  }

  public void method_88(GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class822 class822 = new GClass40.Class822();
    // ISSUE: reference to a compiler-generated field
    class822.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass178 gclass178 = this.list_12.FirstOrDefault<GClass178>(new Func<GClass178, bool>(class822.method_0));
      if (gclass178 == null)
        return;
      if (gclass178.int_0 > 1)
        --gclass178.int_0;
      else
        this.list_12.Remove(gclass178);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2740);
    }
  }

  public void method_89(ListView listView_0, int int_40)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_603(listView_0, "", "Component", "Repair", (string) null);
      this.gclass0_0.method_597(listView_0, "", (string) null);
      this.list_13 = this.list_13.OrderBy<GClass26, int>((Func<GClass26, int>) (gclass26_0 => gclass26_0.int_0)).ToList<GClass26>();
      foreach (GClass26 object_1 in this.list_13)
      {
        string str = "-";
        if (int_40 > 0)
        {
          Decimal num = this.method_90(object_1.gclass230_0, int_40);
          str = GClass226.smethod_39(num * 100M);
          if (num < 0.01M)
            str = GClass226.smethod_42(num * 100M, 2);
          else if (num < 0.1M)
            str = GClass226.smethod_42(num * 100M, 1);
        }
        this.gclass0_0.method_602(listView_0, object_1.int_0.ToString(), object_1.gclass230_0.Name, str + "%", (object) object_1);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2741);
    }
  }

  public Decimal method_90(GClass230 gclass230_0, int int_40)
  {
    try
    {
      Decimal num1 = this.method_153();
      if (this.gclass40_0 != null)
        num1 += this.gclass40_0.method_153();
      Decimal num2 = gclass230_0.decimal_2 * 2M;
      return (Decimal) int_40 / num2 * num1 / 1000M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2742);
      return 0M;
    }
  }

  public void method_91()
  {
    try
    {
      int num = 1;
      this.list_13 = this.list_13.OrderBy<GClass26, int>((Func<GClass26, int>) (gclass26_0 => gclass26_0.int_0)).ToList<GClass26>();
      foreach (GClass26 gclass26 in this.list_13)
      {
        gclass26.int_0 = num;
        ++num;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2743);
    }
  }

  public bool method_92(GClass31 gclass31_0)
  {
    try
    {
      if (this.gclass0_0.int_97 == 1 || GClass226.smethod_13(50) != 5)
        return false;
      string str = "";
      if (this.gclass85_0.method_180() > 1)
        str = $" ({this.gclass85_0.FleetName})";
      if (this.decimal_4 >= gclass31_0.gclass230_0.decimal_2)
      {
        this.decimal_4 -= gclass31_0.gclass230_0.decimal_2;
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_89, $"A {gclass31_0.gclass230_0.Name} on {this.method_187()}{str} suffered a maintenance failure while firing. Immediate repairs have been carried out that required {GClass226.smethod_42(gclass31_0.gclass230_0.decimal_2, 2)} maintenance supplies. The ship has {GClass226.smethod_38(this.decimal_4)} maintenance supplies remaining ({this.method_93()}).", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        return false;
      }
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_229, $"A {gclass31_0.gclass230_0.Name} on {this.method_187()}{str} has suffered a maintenance failure. Insufficient maintenance supplies were available to effect an immediate repair. The ship has {GClass226.smethod_38(this.decimal_4)} maintenance supplies remaining ({this.method_93()}).", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      this.method_3(gclass31_0.gclass230_0);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2744);
      return false;
    }
  }

  public string method_93()
  {
    try
    {
      return this.gclass22_0.int_50 == 0 ? "0%" : GClass226.smethod_39(this.decimal_4 / (Decimal) this.gclass22_0.int_50 * 100M) + "%";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3789);
      return "0%";
    }
  }

  public void method_94()
  {
    try
    {
      this.list_4.Clear();
      this.list_2.Clear();
      this.list_6.Clear();
      this.list_5.Clear();
      this.list_3.Clear();
      this.method_97(false);
      this.method_97(true);
      this.method_95(false);
      this.method_95(true);
      this.method_96();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2745);
    }
  }

  public void method_95(bool bool_22)
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass40.Class823 class823 = new GClass40.Class823();
      bool flag1 = false;
      // ISSUE: reference to a compiler-generated field
      class823.int_0 = (int) this.gclass21_0.method_388(this.gclass0_0.dictionary_49[GEnum122.const_5]).decimal_0;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass228> source1 = !bool_22 ? this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(class823.method_1)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>() : this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(class823.method_0)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>();
      Decimal num1 = (Decimal) source1.Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
      if (num1 == 0M)
        return;
      Decimal num2 = (Decimal) source1.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.genum87_0 == GEnum87.const_6)).Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
      List<GClass228> source2 = !bool_22 ? this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.bool_4 && gclass228_0.gclass230_0.int_3 == 0)).OrderByDescending<GClass228, Decimal>((Func<GClass228, Decimal>) (gclass228_0 => gclass228_0.gclass230_0.decimal_0)).ThenBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>() : this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.bool_4 && gclass228_0.gclass230_0.int_3 > 0 && gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.CIWS)).OrderByDescending<GClass228, Decimal>((Func<GClass228, Decimal>) (gclass228_0 => gclass228_0.gclass230_0.decimal_0)).ThenBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>();
      int num3 = source2.Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
      if (num3 == 0)
        return;
      int num4 = (int) Math.Ceiling((Decimal) num3 / num1);
      if (num2 > 0M && num4 > 1)
      {
        Decimal num5 = num1 - num2;
        num4 = (int) Math.Ceiling(((Decimal) num3 - num2) / num5);
      }
      foreach (GClass228 gclass228_0 in source2)
      {
        int num6 = this.method_158(gclass228_0);
        for (int index = 1; index <= num6; ++index)
        {
          bool flag2 = false;
          foreach (GClass228 gclass228 in source1)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass40.Class824 class824 = new GClass40.Class824();
            // ISSUE: reference to a compiler-generated field
            class824.gclass228_0 = gclass228;
            // ISSUE: reference to a compiler-generated field
            int num7 = this.method_158(class824.gclass228_0);
            if (flag1)
              num7 = 1;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            for (class824.int_0 = 1; class824.int_0 <= num7; class824.int_0++)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              int num8 = num4 - this.list_2.Where<GClass31>(class824.func_0 ?? (class824.func_0 = new Func<GClass31, bool>(class824.method_0))).Count<GClass31>();
              // ISSUE: reference to a compiler-generated field
              if (class824.gclass228_0.gclass230_0.genum87_0 == GEnum87.const_6)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                num8 = 1 - this.list_2.Where<GClass31>(class824.func_1 ?? (class824.func_1 = new Func<GClass31, bool>(class824.method_1))).Count<GClass31>();
              }
              if (num8 > 0)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.list_2.Add(new GClass31()
                {
                  gclass40_0 = this,
                  gclass230_1 = class824.gclass228_0.gclass230_0,
                  int_1 = class824.int_0,
                  gclass230_0 = gclass228_0.gclass230_0,
                  int_0 = index
                });
                flag2 = true;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                if (this.list_4.Where<GClass36>(class824.func_2 ?? (class824.func_2 = new Func<GClass36, bool>(class824.method_2))).FirstOrDefault<GClass36>() == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  this.list_4.Add(new GClass36(this.gclass0_0)
                  {
                    gclass40_0 = this,
                    gclass230_0 = class824.gclass228_0.gclass230_0,
                    int_0 = class824.int_0,
                    int_1 = 0,
                    auroraContactType_0 = AuroraContactType.None,
                    bool_2 = true,
                    bool_0 = false,
                    bool_1 = false,
                    auroraPointDefenceMode_0 = AuroraPointDefenceMode.RangedDefensiveFire
                  });
                  break;
                }
                break;
              }
            }
            if (flag2)
              break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2746);
    }
  }

  public void method_96()
  {
    try
    {
      List<GClass228> list = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.DecoyMissileLauncher)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>();
      if (list.Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0))) == 0)
        return;
      foreach (GClass228 gclass228 in list)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class825 class825 = new GClass40.Class825();
        // ISSUE: reference to a compiler-generated field
        class825.gclass228_0 = gclass228;
        // ISSUE: reference to a compiler-generated field
        int num = this.method_158(class825.gclass228_0);
        for (int index = 1; index <= num; ++index)
        {
          GClass32 gclass32 = new GClass32();
          gclass32.gclass40_0 = this;
          // ISSUE: reference to a compiler-generated field
          gclass32.gclass230_0 = class825.gclass228_0.gclass230_0;
          gclass32.int_0 = index;
          this.list_3.Add(gclass32);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          GClass130 gclass130 = this.list_10.Where<GClass130>(class825.func_0 ?? (class825.func_0 = new Func<GClass130, bool>(class825.method_0))).OrderByDescending<GClass130, Decimal>((Func<GClass130, Decimal>) (gclass130_0 => gclass130_0.gclass129_0.decimal_4)).ThenByDescending<GClass130, int>((Func<GClass130, int>) (gclass130_0 => gclass130_0.gclass129_0.int_12)).FirstOrDefault<GClass130>();
          if (gclass130 != null)
            this.list_5.Add(new GClass30()
            {
              gclass230_0 = gclass32.gclass230_0,
              int_0 = gclass32.int_0,
              gclass129_0 = gclass130.gclass129_0
            });
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3701);
    }
  }

  public void method_97(bool bool_22)
  {
    try
    {
      List<GClass228> source1 = !bool_22 ? this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl && gclass228_0.gclass230_0.decimal_6 > 1M)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>() : this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl && gclass228_0.gclass230_0.decimal_6 == 1M)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>();
      Decimal num1 = (Decimal) source1.Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
      if (num1 == 0M)
        return;
      List<GClass228> source2 = !bool_22 ? this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileLauncher && gclass228_0.gclass230_0.decimal_3 >= (Decimal) GClass226.int_53)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>() : this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileLauncher && gclass228_0.gclass230_0.decimal_3 < (Decimal) GClass226.int_53)).OrderBy<GClass228, string>((Func<GClass228, string>) (gclass228_0 => gclass228_0.gclass230_0.Name)).ToList<GClass228>();
      int num2 = source2.Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
      if (num2 == 0)
        return;
      int num3 = (int) Math.Ceiling((Decimal) num2 / num1);
      foreach (GClass228 gclass228_1 in source2)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class826 class826 = new GClass40.Class826();
        // ISSUE: reference to a compiler-generated field
        class826.gclass228_0 = gclass228_1;
        // ISSUE: reference to a compiler-generated field
        int num4 = this.method_158(class826.gclass228_0);
        for (int index = 1; index <= num4; ++index)
        {
          bool flag = false;
          foreach (GClass228 gclass228_2 in source1)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass40.Class827 class827 = new GClass40.Class827();
            // ISSUE: reference to a compiler-generated field
            class827.gclass228_0 = gclass228_2;
            // ISSUE: reference to a compiler-generated field
            int num5 = this.method_158(class827.gclass228_0);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            for (class827.int_0 = 1; class827.int_0 <= num5; class827.int_0++)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              if (num3 - this.list_2.Where<GClass31>(class827.func_0 ?? (class827.func_0 = new Func<GClass31, bool>(class827.method_0))).Count<GClass31>() > 0)
              {
                GClass31 gclass31 = new GClass31();
                gclass31.gclass40_0 = this;
                // ISSUE: reference to a compiler-generated field
                gclass31.gclass230_1 = class827.gclass228_0.gclass230_0;
                // ISSUE: reference to a compiler-generated field
                gclass31.int_1 = class827.int_0;
                // ISSUE: reference to a compiler-generated field
                gclass31.gclass230_0 = class826.gclass228_0.gclass230_0;
                gclass31.int_0 = index;
                this.list_2.Add(gclass31);
                flag = true;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                if (this.list_4.Where<GClass36>(class827.func_1 ?? (class827.func_1 = new Func<GClass36, bool>(class827.method_1))).FirstOrDefault<GClass36>() == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  GClass36 gclass36 = new GClass36(this.gclass0_0)
                  {
                    gclass40_0 = this,
                    gclass230_0 = class827.gclass228_0.gclass230_0,
                    int_0 = class827.int_0,
                    int_1 = 0,
                    auroraContactType_0 = AuroraContactType.None,
                    bool_2 = true,
                    bool_0 = false,
                    bool_1 = false,
                    auroraPointDefenceMode_0 = AuroraPointDefenceMode.None
                  };
                  gclass36.auroraPointDefenceMode_0 = !bool_22 ? AuroraPointDefenceMode.None : AuroraPointDefenceMode.ThreeMissilesPerTarget;
                  this.list_4.Add(gclass36);
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                GClass130 gclass130 = this.list_10.Where<GClass130>(class826.func_0 ?? (class826.func_0 = new Func<GClass130, bool>(class826.method_0))).OrderByDescending<GClass130, Decimal>((Func<GClass130, Decimal>) (gclass130_0 => gclass130_0.gclass129_0.decimal_4)).ThenByDescending<GClass130, Decimal>((Func<GClass130, Decimal>) (gclass130_0 => gclass130_0.gclass129_0.decimal_0)).ThenByDescending<GClass130, Decimal>((Func<GClass130, Decimal>) (gclass130_0 => gclass130_0.gclass129_0.decimal_5)).FirstOrDefault<GClass130>();
                if (gclass130 != null)
                {
                  this.list_5.Add(new GClass30()
                  {
                    gclass230_0 = gclass31.gclass230_0,
                    int_0 = gclass31.int_0,
                    gclass129_0 = gclass130.gclass129_0
                  });
                  break;
                }
                break;
              }
            }
            if (flag)
              break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2747);
    }
  }

  public void method_98(Graphics graphics_0, Panel panel_0)
  {
    try
    {
      float float_2 = (float) panel_0.Width / (float) this.gclass22_0.int_3;
      if ((double) float_2 > 20.0)
        float_2 = 20f;
      for (int key = 1; key <= this.gclass22_0.int_3; ++key)
      {
        if (this.dictionary_5.ContainsKey(key))
        {
          for (int index = 1; index <= this.dictionary_5[key]; ++index)
            this.method_99(graphics_0, (float) (key - 1) * float_2, (float) (index - 1) * float_2, float_2, true);
          for (int index = this.dictionary_5[key] + 1; index <= this.gclass22_0.int_2; ++index)
            this.method_99(graphics_0, (float) (key - 1) * float_2, (float) (index - 1) * float_2, float_2, false);
        }
        else
        {
          for (int index = 1; index <= this.gclass22_0.int_2; ++index)
            this.method_99(graphics_0, (float) (key - 1) * float_2, (float) (index - 1) * float_2, float_2, false);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2748);
    }
  }

  public void method_99(
    Graphics graphics_0,
    float float_0,
    float float_1,
    float float_2,
    bool bool_22)
  {
    try
    {
      Color color = Color.WhiteSmoke;
      if (bool_22)
        color = Color.Red;
      SolidBrush solidBrush = new SolidBrush(color);
      graphics_0.FillRectangle((Brush) solidBrush, float_0, float_1, float_2, float_2);
      Pen pen = new Pen(GClass226.color_19);
      graphics_0.DrawRectangle(pen, float_0, float_1, float_2, float_2);
      pen.Dispose();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2749);
    }
  }

  public void method_100(GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class828 class828 = new GClass40.Class828();
    // ISSUE: reference to a compiler-generated field
    class828.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass28 gclass28 = this.list_8.FirstOrDefault<GClass28>(new Func<GClass28, bool>(class828.method_0));
      if (gclass28 != null)
      {
        ++gclass28.int_0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.list_8.Add(new GClass28(class828.gclass230_0, 1));
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2750);
    }
  }

  public GClass132 method_101(
    GClass36 gclass36_0,
    GClass30 gclass30_0,
    int int_40,
    AuroraContactType auroraContactType_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class829 class829 = new GClass40.Class829();
    // ISSUE: reference to a compiler-generated field
    class829.gclass40_0 = this;
    // ISSUE: reference to a compiler-generated field
    class829.gclass30_0 = gclass30_0;
    // ISSUE: reference to a compiler-generated field
    class829.gclass36_0 = gclass36_0;
    // ISSUE: reference to a compiler-generated field
    class829.int_0 = int_40;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass132 gclass132 = this.gclass0_0.dictionary_6.Values.FirstOrDefault<GClass132>(new Func<GClass132, bool>(class829.method_0));
      if (gclass132 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return this.gclass21_0.method_129(this, class829.gclass30_0.gclass129_0, class829.gclass36_0, class829.int_0, auroraContactType_0, this.double_0);
      }
      gclass132.method_7();
      return gclass132;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2751);
      return (GClass132) null;
    }
  }

  public GClass132 method_102(
    GClass30 gclass30_0,
    int int_40,
    AuroraContactType auroraContactType_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class830 class830 = new GClass40.Class830();
    // ISSUE: reference to a compiler-generated field
    class830.gclass40_0 = this;
    // ISSUE: reference to a compiler-generated field
    class830.gclass30_0 = gclass30_0;
    // ISSUE: reference to a compiler-generated field
    class830.int_0 = int_40;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass132 gclass132 = this.gclass0_0.dictionary_6.Values.FirstOrDefault<GClass132>(new Func<GClass132, bool>(class830.method_0));
      if (gclass132 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return this.gclass21_0.method_129(this, class830.gclass30_0.gclass129_0, (GClass36) null, class830.int_0, auroraContactType_0, this.double_0);
      }
      gclass132.method_7();
      return gclass132;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3686);
      return (GClass132) null;
    }
  }

  public bool method_103(GClass129 gclass129_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class831 class831 = new GClass40.Class831();
    // ISSUE: reference to a compiler-generated field
    class831.gclass129_0 = gclass129_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass130 gclass130 = this.list_10.FirstOrDefault<GClass130>(new Func<GClass130, bool>(class831.method_0));
      if (gclass130 == null)
        return false;
      if (gclass130.int_0 <= 0)
      {
        this.list_10.Remove(gclass130);
        return false;
      }
      --gclass130.int_0;
      if (gclass130.int_0 == 0)
        this.list_10.Remove(gclass130);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2752);
      return false;
    }
  }

  public void method_104()
  {
    try
    {
      this.double_0 = this.method_22();
      this.int_35 = (int) this.method_171(true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2753);
    }
  }

  public void method_105()
  {
    try
    {
      this.dictionary_6.Clear();
      this.list_20.Clear();
      this.dictionary_4.Clear();
      this.int_0 = 0;
      this.decimal_0 = 0M;
      this.int_1 = 0;
      this.int_2 = 0;
      this.int_3 = 0;
      this.int_4 = 0;
      this.int_5 = 0;
      this.int_6 = 0;
      this.int_7 = 0;
      this.bool_0 = false;
      this.bool_1 = false;
      this.bool_4 = false;
      this.bool_2 = false;
      this.bool_3 = false;
      this.bool_5 = false;
      this.bool_6 = false;
      this.bool_15 = false;
      this.bool_16 = false;
      this.bool_7 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2754);
    }
  }

  public double method_106(
    GClass31 gclass31_0,
    GClass36 gclass36_0,
    double double_4,
    double double_5,
    double double_6,
    Decimal decimal_42)
  {
    try
    {
      int int_24 = gclass31_0.gclass230_0.int_3;
      if (int_24 == 0)
      {
        int_24 = this.gclass21_0.int_54;
        if (this.int_35 > int_24)
          int_24 = this.int_35;
      }
      if (int_24 > gclass36_0.gclass230_0.int_3)
        int_24 = gclass36_0.gclass230_0.int_3;
      double num = gclass36_0.gclass230_0.method_10(double_4, double_5, int_24, decimal_42) * 100.0 * double_6;
      if (gclass31_0.gclass230_0.decimal_5 > 0M && gclass31_0.gclass230_0.decimal_5 < 1M)
        num *= (double) gclass31_0.gclass230_0.decimal_5;
      return num <= 0.0 ? 0.0 : num * this.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2755);
      return 0.0;
    }
  }

  public void method_107(GClass40 gclass40_4, GClass36 gclass36_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class832 class832 = new GClass40.Class832();
    // ISSUE: reference to a compiler-generated field
    class832.gclass36_0 = gclass36_0;
    try
    {
      double num1 = 0.0;
      double double2 = gclass40_4.gclass85_0.double_2;
      double double3 = gclass40_4.gclass85_0.double_3;
      int num2 = (int) gclass40_4.method_156(AuroraJammerType.FireControl);
      if (num2 > 0)
        this.gclass21_0.method_35(gclass40_4, AuroraJammerType.FireControl, (Decimal) num2);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      double num3 = class832.gclass36_0.method_6(this, num2, class832.gclass36_0.gclass230_0);
      int double_3 = 0;
      double num4 = this.gclass0_0.method_28(this.gclass85_0.double_2, this.gclass85_0.double_3, double2, double3);
      if (gclass40_4.genum29_0 == GEnum29.const_0)
        double_3 = gclass40_4.int_35;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass31 gclass31 in this.list_2.Where<GClass31>(new Func<GClass31, bool>(class832.method_0)).ToList<GClass31>())
      {
        int int_24 = gclass31.gclass230_0.int_3;
        if (int_24 == 0)
        {
          int_24 = this.gclass21_0.int_54;
          if (this.int_35 > int_24)
            int_24 = this.int_35;
        }
        // ISSUE: reference to a compiler-generated field
        if (int_24 > class832.gclass36_0.gclass230_0.int_3)
        {
          // ISSUE: reference to a compiler-generated field
          int_24 = class832.gclass36_0.gclass230_0.int_3;
        }
        // ISSUE: reference to a compiler-generated field
        double num5 = class832.gclass36_0.gclass230_0.method_10(num4, (double) double_3, int_24, 1M) * num3;
        if (gclass31.gclass230_0.decimal_5 > 0M && gclass31.gclass230_0.decimal_5 < 1M)
          num5 *= (double) gclass31.gclass230_0.decimal_5;
        if (num5 > 0.0)
        {
          int num6 = gclass31.gclass230_0.method_5((int) num4);
          num1 += num5 * (double) num6;
        }
      }
      gclass40_4.double_2 = num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3374);
    }
  }

  public double method_108(GClass230 gclass230_0, GClass132 gclass132_0)
  {
    try
    {
      double num = 50.0;
      if (gclass132_0.double_9 > (double) gclass230_0.int_3)
        num *= (double) gclass230_0.int_3 / gclass132_0.double_9;
      return num <= 0.0 ? 0.0 : num * this.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2756);
      return 0.0;
    }
  }

  public void method_109()
  {
    try
    {
      this.dictionary_2.Clear();
      this.dictionary_3.Clear();
      this.list_17.Clear();
      this.list_18.Clear();
      this.gclass123_0.method_6();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2757);
    }
  }

  public bool method_110(int int_40)
  {
    try
    {
      if (int_40 == 100)
      {
        if (this.decimal_14 == (Decimal) this.gclass22_0.int_63)
          return true;
      }
      else if (this.decimal_14 <= (Decimal) (this.gclass22_0.int_63 * int_40) / 100M)
        return true;
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2758);
      return false;
    }
  }

  public bool method_111(int int_40)
  {
    try
    {
      return this.decimal_4 <= (Decimal) this.gclass22_0.int_50 * ((Decimal) int_40 / 100M);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2759);
      return false;
    }
  }

  public void method_112(GClass164 gclass164_0, Decimal decimal_42)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class833 class833 = new GClass40.Class833();
    // ISSUE: reference to a compiler-generated field
    class833.gclass164_0 = gclass164_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_77, $"{decimal_42.ToString()} research points for {class833.gclass164_0.Name} gained by {this.method_187()}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Fleet);
      // ISSUE: reference to a compiler-generated method
      GClass182 gclass182 = this.list_15.FirstOrDefault<GClass182>(new Func<GClass182, bool>(class833.method_0));
      if (gclass182 == null)
      {
        // ISSUE: reference to a compiler-generated field
        this.list_15.Add(new GClass182()
        {
          gclass40_0 = this,
          gclass164_0 = class833.gclass164_0,
          decimal_0 = decimal_42
        });
      }
      else
        gclass182.decimal_0 += decimal_42;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2760);
    }
  }

  public Decimal method_113(GClass146 gclass146_0, bool bool_22)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class834 class834 = new GClass40.Class834();
    // ISSUE: reference to a compiler-generated field
    class834.gclass146_0 = gclass146_0;
    try
    {
      Decimal num1 = 1M;
      Decimal num2 = 1M;
      Decimal num3 = 1M;
      GClass55 gclass55 = this.method_192(AuroraCommandType.Ship);
      if (gclass55 != null)
        num1 = gclass55.method_5(GEnum121.const_20);
      Decimal num4 = this.gclass85_0.gclass83_0.method_5(this.gclass85_0.gclass202_0.gclass200_0.int_0, GEnum121.const_20);
      // ISSUE: reference to a compiler-generated field
      if (class834.gclass146_0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        if (class834.gclass146_0.gclass55_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          num2 = class834.gclass146_0.gclass55_0.method_5(GEnum121.const_20);
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (class834.gclass146_0.gclass202_0.gclass62_0 != null && class834.gclass146_0.gclass202_0.gclass62_0.gclass55_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          num3 = class834.gclass146_0.gclass202_0.gclass62_0.gclass55_0.method_8(GEnum121.const_20);
        }
      }
      Decimal num5 = !(this.gclass22_0.decimal_14 <= 10M) ? this.method_157(AuroraComponentType.CargoShuttleBay, false) * num4 * num1 * num2 * num3 * (Decimal) this.gclass21_0.int_9 : 1M * num4 * num1 * num2 * num3 * (Decimal) this.gclass21_0.int_9;
      // ISSUE: reference to a compiler-generated field
      if (class834.gclass146_0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        if (class834.gclass146_0.method_62(AuroraProductionCategory.CargoShuttles) >= 1M)
          num5 += (Decimal) this.gclass21_0.int_9;
        else if (bool_22)
        {
          // ISSUE: reference to a compiler-generated field
          if (class834.gclass146_0.method_62(AuroraProductionCategory.MaintenanceFacility) > 0M)
          {
            num5 += (Decimal) this.gclass21_0.int_9;
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            if (this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class834.method_0)).Sum<GClass85>((Func<GClass85, int>) (gclass85_0 => gclass85_0.method_127(AuroraComponentType.MaintenanceModule))) > 0)
              num5 += (Decimal) this.gclass21_0.int_9;
          }
        }
      }
      return num5;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2761);
      return 1M;
    }
  }

  public Decimal method_114()
  {
    try
    {
      Decimal num1 = 1M;
      GClass55 gclass55 = this.method_192(AuroraCommandType.Ship);
      if (gclass55 != null)
        num1 = gclass55.method_5(GEnum121.const_20);
      Decimal num2 = this.gclass85_0.gclass83_0.method_5(this.gclass85_0.gclass202_0.gclass200_0.int_0, GEnum121.const_20);
      return this.method_157(AuroraComponentType.CargoShuttleBay, false) * num2 * num1 * (Decimal) this.gclass21_0.int_9;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3502);
      return 1M;
    }
  }

  public void method_115(GClass129 gclass129_0, int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class835 class835 = new GClass40.Class835();
    // ISSUE: reference to a compiler-generated field
    class835.gclass129_0 = gclass129_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass130 gclass130 = this.list_10.FirstOrDefault<GClass130>(new Func<GClass130, bool>(class835.method_0));
      if (gclass130 != null)
      {
        gclass130.int_0 += int_40;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.list_10.Add(new GClass130()
        {
          gclass129_0 = class835.gclass129_0,
          int_0 = int_40
        });
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2762);
    }
  }

  public void method_116(GClass146 gclass146_0)
  {
    try
    {
      foreach (GClass180 gclass180 in this.list_1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class839 class839 = new GClass40.Class839();
        // ISSUE: reference to a compiler-generated field
        class839.gclass180_0 = gclass180;
        // ISSUE: reference to a compiler-generated method
        GClass147 gclass147 = gclass146_0.list_3.FirstOrDefault<GClass147>(new Func<GClass147, bool>(class839.method_0));
        if (gclass147 != null)
        {
          // ISSUE: reference to a compiler-generated field
          gclass147.int_0 += class839.gclass180_0.int_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass146_0.list_3.Add(new GClass147()
          {
            gclass21_0 = class839.gclass180_0.gclass21_0,
            gclass194_0 = class839.gclass180_0.gclass194_0,
            int_0 = class839.gclass180_0.int_0,
            gclass146_0 = gclass146_0
          });
        }
      }
      foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0.bool_4 && gclass55_0.gclass40_0 == this)).ToList<GClass55>())
      {
        gclass55.gclass40_0 = (GClass40) null;
        gclass55.gclass146_0 = gclass146_0;
      }
      this.list_1.Clear();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2763);
    }
  }

  public void method_117(GClass40 gclass40_4)
  {
    try
    {
      if (gclass40_4 == null)
        return;
      foreach (GClass180 gclass180_1 in this.list_1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class840 class840 = new GClass40.Class840();
        // ISSUE: reference to a compiler-generated field
        class840.gclass180_0 = gclass180_1;
        // ISSUE: reference to a compiler-generated method
        GClass180 gclass180_2 = gclass40_4.list_1.FirstOrDefault<GClass180>(new Func<GClass180, bool>(class840.method_0));
        if (gclass180_2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          gclass180_2.int_0 += class840.gclass180_0.int_0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          class840.gclass180_0.gclass40_0 = gclass40_4;
          // ISSUE: reference to a compiler-generated field
          gclass40_4.list_1.Add(class840.gclass180_0);
        }
      }
      foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0.bool_4 && gclass55_0.gclass40_0 == this)).ToList<GClass55>())
        gclass55.gclass40_0 = gclass40_4;
      this.list_1.Clear();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2764);
    }
  }

  public void method_118(Decimal decimal_42, double double_4, List<GClass81> list_21)
  {
    try
    {
      if (!this.gclass22_0.bool_7)
        this.decimal_7 = this.gclass0_0.decimal_0;
      GClass81 gclass81 = (GClass81) null;
      if (this.gclass85_0.gclass83_0.gclass79_0.genum37_0 != GEnum37.const_5)
        gclass81 = list_21.FirstOrDefault<GClass81>((Func<GClass81, bool>) (gclass81_0 => this.gclass0_0.method_519(gclass81_0.double_0, this.gclass85_0.double_2, 1.0) && this.gclass0_0.method_519(gclass81_0.double_1, this.gclass85_0.double_3, 1.0) && gclass81_0.gclass202_0 == this.gclass85_0.gclass202_0 && gclass81_0.gclass21_0 == this.gclass21_0));
      if (gclass81 != null)
      {
        if (!this.gclass22_0.bool_7)
          return;
        bool flag = false;
        if (this.decimal_7 < this.gclass0_0.decimal_0 - decimal_42)
          flag = true;
        Decimal num = 10M;
        if (this.int_11 < this.gclass22_0.int_11)
          num = (Decimal) this.int_11 / (Decimal) this.gclass22_0.int_11;
        this.decimal_7 += decimal_42 * num;
        if (this.decimal_7 >= this.gclass0_0.decimal_0)
        {
          this.decimal_7 = this.gclass0_0.decimal_0;
          if (this.decimal_7 == this.gclass0_0.decimal_0 && flag)
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_135, $"The crew of {this.method_187()} has completed shore leave and is fully rested", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        }
        this.method_191();
      }
      else if (this.gclass40_0 != null)
      {
        if (!this.gclass22_0.bool_7)
          return;
        Decimal num = (this.gclass0_0.decimal_0 - this.gclass40_0.decimal_7) / GClass226.decimal_31 / this.gclass22_0.decimal_9;
        if (num < 1M)
          this.decimal_7 += decimal_42 + decimal_42 * 10M * (1M - num);
        else
          this.decimal_7 += decimal_42;
        if (this.decimal_7 > this.gclass0_0.decimal_0)
          this.decimal_7 = this.gclass0_0.decimal_0;
        this.method_191();
      }
      else
      {
        if (this.gclass85_0.gclass83_0.gclass79_0.genum37_0 == GEnum37.const_5 && this.genum29_0 != GEnum29.const_1)
          this.decimal_7 -= decimal_42;
        int num1 = 1;
        if (this.list_12.Count > 0)
          num1 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.CrewQuarters)).Sum<GClass228>((Func<GClass228, int>) (gclass228_0 => this.method_158(gclass228_0)));
        if (num1 == 0)
        {
          if (this.gclass22_0.bool_7)
          {
            this.decimal_7 -= 12M * decimal_42;
            this.decimal_2 = 0.1M;
          }
          int num2 = GClass226.smethod_13(20) + GClass226.smethod_13(20) + GClass226.smethod_13(20) + GClass226.smethod_13(20);
          int num3 = (int) ((Decimal) this.int_11 * ((Decimal) num2 / 100M));
          if (num3 > this.int_11 - 1)
            num3 = this.int_11 - 1;
          this.int_11 -= num3;
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_136, $"Due to the complete failure of the life support systems on board {this.method_187()}, {num3.ToString()} crew members have died. The remaining {this.int_11.ToString()} crew members are struggling to stay alive.", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          if (this.list_1.Count > 0)
          {
            Decimal num4 = (Decimal) this.method_121() / (Decimal) this.method_120();
            if (num4 > 0M)
            {
              foreach (GClass180 gclass180 in this.list_1)
              {
                int num5 = (int) ((Decimal) gclass180.int_0 * num4 * ((Decimal) num2 / 100M));
                if (num5 > gclass180.int_0)
                  num5 = gclass180.int_0;
                gclass180.int_0 -= num5;
                GClass110 gclass110 = this.gclass21_0.method_325(gclass180.gclass21_0.RaceID);
                this.gclass0_0.gclass92_0.method_2(GEnum126.const_136, $"Due to the complete failure of the life support systems on board {this.method_187()}, {num5.ToString()} prisoners of the {gclass110.AlienRaceName} have died. The remaining {gclass180.int_0.ToString()} prisoners are struggling to stay alive.", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
              }
              this.list_1 = this.list_1.Where<GClass180>((Func<GClass180, bool>) (gclass180_0 => gclass180_0.int_0 > 0)).ToList<GClass180>();
            }
          }
          foreach (GClass55 gclass55 in this.dictionary_1.Values.ToList<GClass55>())
          {
            if ((double) GClass226.smethod_13(100) < (double) num2 / 2.0)
            {
              gclass55.method_42(AuroraRetirementStatus.DiedLifeSupportFailure);
              gclass55.method_46("Died due to life support failure on board " + this.method_187(), GEnum28.const_0);
              this.method_204($"{GClass226.smethod_82((Enum) gclass55.auroraCommandType_0)} {gclass55.method_36()} died due to life support failure");
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_136, $"Due to the complete failure of the life support systems on board {this.method_187()}, {gclass55.method_36()} has died. Assignment prior to death: {gclass55.method_17(false)}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            }
          }
        }
        else if (this.list_12.Count <= 0 && this.list_1.Count<GClass180>() <= 0)
        {
          if (!this.gclass22_0.bool_7)
            return;
          this.method_191();
        }
        else
        {
          Decimal num6 = this.gclass22_0.method_80(this.int_11 + (this.method_167(AuroraComponentType.HangarDeck) + this.method_167(AuroraComponentType.CommercialHangarDeck)) * 20 + this.method_121());
          Decimal num7 = this.method_157(AuroraComponentType.CrewQuarters, false);
          this.decimal_35 = 1M;
          if (!(num6 > num7))
            return;
          this.decimal_35 = GClass226.smethod_64(num6 / num7, 2);
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_151, $"{this.method_187()} has insufficient crew accomodation for the personnel on board (including any survivors not in cryo). This will increase the rate at which time passes for deployment purposes by {GClass226.smethod_42(this.decimal_35, 2)}x", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          if (this.gclass22_0.bool_7)
            this.decimal_7 -= (this.decimal_35 - 1M) * decimal_42;
          this.method_191();
          if (!(this.decimal_35 > 1.5M))
            return;
          double num8 = (double) this.decimal_35 * 10000.0 * double_4;
          if ((double) GClass226.smethod_13(10000) >= num8)
            return;
          this.method_119();
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2765);
    }
  }

  public void method_119()
  {
    try
    {
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.CrewQuarters)).OrderByDescending<GClass228, Decimal>((Func<GClass228, Decimal>) (gclass228_0 => gclass228_0.gclass230_0.decimal_3)).ToList<GClass228>())
      {
        if (this.method_158(gclass228_0) > 0)
        {
          string str = "";
          if (this.gclass85_0.method_180() > 1)
            str = $" ({this.gclass85_0.FleetName})";
          if (this.decimal_4 >= gclass228_0.gclass230_0.decimal_2)
          {
            this.decimal_4 -= gclass228_0.gclass230_0.decimal_2;
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_89, $"A {gclass228_0.gclass230_0.Name} on {this.method_187()}{str} has suffered a maintenance failure due to strain on life support systems. Repairs have been carried out that required {GClass226.smethod_42(gclass228_0.gclass230_0.decimal_2, 2)} maintenance supplies. The ship has {GClass226.smethod_38(this.decimal_4)} maintenance supplies remaining.", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            break;
          }
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_229, $"A {gclass228_0.gclass230_0.Name} on {this.method_187()}{str} has suffered a maintenance failure due to strain on life support systems. Insufficient maintenance supplies were available to effect an immediate repair. The ship has {GClass226.smethod_38(this.decimal_4)} maintenance supplies remaining.", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          this.method_4(gclass228_0);
          break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2766);
    }
  }

  public int method_120()
  {
    try
    {
      return this.list_1.Sum<GClass180>((Func<GClass180, int>) (gclass180_0 => gclass180_0.int_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2767);
      return 0;
    }
  }

  public int method_121()
  {
    try
    {
      int num1 = (int) this.method_149() - this.list_18.Sum<GClass181>((Func<GClass181, int>) (gclass181_0 => gclass181_0.int_0));
      int num2 = this.method_120();
      return num1 >= num2 ? 0 : num2 - num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2768);
      return 0;
    }
  }

  public int method_122()
  {
    try
    {
      return (int) this.method_149() - this.list_18.Sum<GClass181>((Func<GClass181, int>) (gclass181_0 => gclass181_0.int_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3422);
      return 0;
    }
  }

  public Decimal method_123(GEnum121 genum121_1)
  {
    try
    {
      Decimal num1 = 1M;
      int num2 = (int) this.method_157(AuroraComponentType.CommandAndControl, false);
      if (num2 == 0 && this.gclass22_0.decimal_14 <= 20M)
        num2 = 1;
      GClass55 gclass55_1 = this.method_192(AuroraCommandType.Ship);
      switch (genum121_1)
      {
        case GEnum121.const_0:
          if (num2 > 0)
          {
            GClass55 gclass55_2 = this.method_192(AuroraCommandType.ExecutiveOfficer);
            if (gclass55_2 != null)
              num1 = gclass55_2.method_5(genum121_1);
          }
          if (gclass55_1 != null && num2 > 0)
          {
            num1 *= gclass55_1.method_7(genum121_1);
            break;
          }
          break;
        case GEnum121.const_1:
          if (this.method_159(GEnum118.const_61))
          {
            GClass55 gclass55_3 = this.method_192(AuroraCommandType.ScienceOfficer);
            if (gclass55_3 != null)
              num1 = gclass55_3.method_5(genum121_1);
          }
          if (gclass55_1 != null && num2 > 0)
          {
            num1 *= gclass55_1.method_7(genum121_1);
            break;
          }
          break;
        case GEnum121.const_6:
          if (this.method_159(GEnum118.const_62))
          {
            GClass55 gclass55_4 = this.method_192(AuroraCommandType.CAG);
            if (gclass55_4 != null)
              num1 = gclass55_4.method_5(genum121_1);
          }
          if (gclass55_1 != null && num2 > 0)
          {
            num1 *= gclass55_1.method_7(genum121_1);
            break;
          }
          break;
        case GEnum121.const_17:
          if (this.method_159(GEnum118.const_60))
          {
            GClass55 gclass55_5 = this.method_192(AuroraCommandType.TacticalOfficer);
            if (gclass55_5 != null)
              num1 = gclass55_5.method_5(genum121_1);
          }
          if (gclass55_1 != null && num2 > 0)
          {
            num1 *= gclass55_1.method_7(genum121_1);
            break;
          }
          break;
        case GEnum121.const_24:
          if (this.method_159(GEnum118.const_59))
          {
            GClass55 gclass55_6 = this.method_192(AuroraCommandType.ChiefEngineer);
            if (gclass55_6 != null)
              num1 = gclass55_6.method_5(genum121_1);
          }
          if (gclass55_1 != null && num2 > 0)
          {
            num1 *= gclass55_1.method_7(genum121_1);
            break;
          }
          break;
        case GEnum121.const_31:
          if (this.method_159(GEnum118.const_60))
          {
            GClass55 gclass55_7 = this.method_192(AuroraCommandType.TacticalOfficer);
            if (gclass55_7 != null && num2 > 0)
              num1 = gclass55_7.method_5(genum121_1);
          }
          if (gclass55_1 != null && num2 > 0)
          {
            num1 *= gclass55_1.method_7(genum121_1);
            break;
          }
          break;
        default:
          num1 = gclass55_1.method_5(genum121_1);
          break;
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2769);
      return 1M;
    }
  }

  public int method_124()
  {
    try
    {
      Decimal num1 = this.method_157(AuroraComponentType.CargoHold, false);
      Decimal num2 = this.dictionary_2.Values.Sum<GClass158>((Func<GClass158, Decimal>) (gclass158_0 => (Decimal) gclass158_0.gclass157_0.int_1 * gclass158_0.decimal_0));
      Decimal num3 = this.list_17.Sum<GClass73>((Func<GClass73, Decimal>) (gclass73_0 => gclass73_0.gclass230_0.decimal_1 * GClass226.decimal_17 * gclass73_0.decimal_0));
      Decimal num4 = this.dictionary_3.Values.Sum<GClass191>((Func<GClass191, Decimal>) (gclass191_0 => gclass191_0.decimal_0)) * GClass226.decimal_53;
      Decimal num5 = this.gclass123_0.method_7() * GClass226.decimal_28;
      Decimal num6 = num2;
      Decimal num7 = num1 - num6 - num3 - num4 - num5;
      if (num7 < 0M)
        num7 = 0M;
      return (int) num7;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2770);
      return 0;
    }
  }

  public Decimal method_125()
  {
    try
    {
      return this.method_157(AuroraComponentType.HangarDeck, false) + this.method_157(AuroraComponentType.CommercialHangarDeck, false) - this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4.gclass40_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2771);
      return 0M;
    }
  }

  public Decimal method_126()
  {
    try
    {
      return this.method_157(AuroraComponentType.HangarDeck, false) + this.method_157(AuroraComponentType.CommercialHangarDeck, false) - this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4.gclass40_0 == this || gclass40_4.gclass40_1 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3859);
      return 0M;
    }
  }

  public Decimal method_127(GClass146 gclass146_0, Decimal decimal_42)
  {
    try
    {
      Decimal num = this.method_149() - (Decimal) this.list_18.Sum<GClass181>((Func<GClass181, int>) (gclass181_0 => gclass181_0.int_0));
      if (num == 0M)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_52, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to load colonists from {gclass146_0.PopName} due to a lack of capacity", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        if (this.gclass187_0 != null)
          this.gclass85_0.method_263();
        return 0M;
      }
      if (this.method_113(gclass146_0, false) == 0M)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_52, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to load colonists from {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        if (this.gclass187_0 != null)
          this.gclass85_0.method_263();
        return 0M;
      }
      if (gclass146_0.decimal_4 * 1000000M < num)
        num = gclass146_0.decimal_4 * 1000000M;
      if (num > decimal_42 && decimal_42 > 0M)
        num = decimal_42;
      if (num > 0M)
      {
        GClass181 gclass181 = new GClass181();
        gclass181.int_0 = (int) num;
        gclass181.gclass194_0 = gclass146_0.gclass194_0;
        gclass181.gclass146_0 = gclass146_0;
        if (gclass146_0.int_2 == 1)
          gclass181.bool_0 = true;
        this.list_18.Add(gclass181);
        if (this.gclass187_0 != null)
          this.decimal_11 = this.decimal_10;
        gclass146_0.method_25(gclass146_0.decimal_4 - num / 1000000M);
        if (this.gclass187_0 != null)
          gclass146_0.decimal_11 -= num / 1000000M;
        return (Decimal) gclass181.int_0;
      }
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_52, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to load colonists from {gclass146_0.PopName} as none were available for pickup", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      if (this.gclass187_0 != null)
        this.gclass85_0.method_263();
      return 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2772);
      return 0M;
    }
  }

  public bool method_128(GClass139 gclass139_0, GClass103 gclass103_1)
  {
    try
    {
      Decimal num1 = 0M;
      if (gclass139_0.gclass133_0.genum123_0 == GEnum123.const_23 || gclass139_0.gclass133_0.genum123_0 == GEnum123.const_108 || gclass139_0.gclass133_0.genum123_0 == GEnum123.const_122)
        num1 = (Decimal) this.method_211();
      if (!(num1 > 0M))
        return false;
      Decimal num2 = gclass103_1.method_34();
      if (num1 < num2)
        return false;
      Decimal num3;
      if (gclass139_0.gclass133_0.genum123_0 != GEnum123.const_23 && gclass139_0.gclass133_0.genum123_0 != GEnum123.const_122)
      {
        if (gclass139_0.gclass133_0.genum123_0 == GEnum123.const_108 && gclass103_1.gclass40_0 != null && gclass103_1.gclass40_0.gclass85_0.int_3 == gclass139_0.int_2)
        {
          gclass103_1.gclass40_0 = this;
          gclass103_1.gclass146_0 = (GClass146) null;
          num3 = num1 - num2;
          foreach (GClass39 gclass39 in gclass103_1.list_0)
            gclass39.decimal_1 = 1M;
        }
      }
      else if (gclass103_1.gclass146_0 == gclass139_0.gclass146_0)
      {
        gclass103_1.gclass40_0 = this;
        gclass103_1.gclass146_0 = (GClass146) null;
        num3 = num1 - num2;
        foreach (GClass39 gclass39 in gclass103_1.list_0)
          gclass39.decimal_1 = 1M;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2773);
      return false;
    }
  }

  public Decimal method_129(
    GClass146 gclass146_0,
    AuroraInstallationType auroraInstallationType_0,
    Decimal decimal_42)
  {
    try
    {
      Decimal num1 = (Decimal) this.method_124();
      if (num1 == 0M)
      {
        if (this.gclass187_0 != null)
          this.gclass85_0.method_263();
        return 0M;
      }
      if (this.method_113(gclass146_0, false) == 0M)
      {
        if (this.gclass187_0 != null)
          this.gclass85_0.method_263();
        return 0M;
      }
      Decimal num2 = gclass146_0.method_75(auroraInstallationType_0);
      if (num2 == 0M)
      {
        if (this.gclass187_0 != null)
          this.gclass85_0.method_263();
        return 0M;
      }
      Decimal decimal_90 = num1 / (Decimal) this.gclass0_0.dictionary_44[auroraInstallationType_0].int_1;
      if (num2 < decimal_90)
        decimal_90 = num2;
      if (decimal_42 > 0M && decimal_42 < decimal_90)
        decimal_90 = decimal_42;
      if (decimal_90 > 0M)
      {
        if (this.dictionary_2.ContainsKey(auroraInstallationType_0))
          this.dictionary_2[auroraInstallationType_0].decimal_0 += decimal_90;
        else
          this.dictionary_2.Add(auroraInstallationType_0, new GClass158()
          {
            gclass157_0 = this.gclass0_0.dictionary_44[auroraInstallationType_0],
            gclass40_0 = this,
            decimal_0 = decimal_90,
            gclass146_1 = gclass146_0
          });
        if (this.gclass187_0 != null)
          this.decimal_11 = this.decimal_10;
        gclass146_0.method_68(auroraInstallationType_0, decimal_90);
        return decimal_90;
      }
      if (this.gclass187_0 != null)
        this.gclass85_0.method_263();
      return 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2774);
      return 0M;
    }
  }

  public void method_130(GClass146 gclass146_0, int int_40)
  {
    try
    {
      Decimal num1 = (Decimal) this.method_124();
      if (num1 == 0M)
      {
        if (this.gclass187_0 == null)
          return;
        this.gclass85_0.method_263();
      }
      else if (this.method_113(gclass146_0, false) == 0M)
      {
        if (this.gclass187_0 == null)
          return;
        this.gclass85_0.method_263();
      }
      else
      {
        Decimal num2 = gclass146_0.method_42(int_40);
        Decimal num3 = num1 / GClass226.decimal_53;
        if (num2 < num3)
          num3 = num2;
        if (num3 > 0M)
        {
          if (this.dictionary_3.ContainsKey(int_40))
          {
            this.dictionary_3[int_40].decimal_0 += num3;
          }
          else
          {
            GClass191 gclass191 = new GClass191();
            gclass191.gclass189_0 = this.gclass0_0.dictionary_56[int_40];
            gclass191.gclass40_0 = this;
            gclass191.decimal_0 = num3;
            gclass191.gclass146_0 = gclass146_0;
            this.dictionary_3.Add(gclass191.gclass189_0.int_0, gclass191);
          }
          if (this.gclass187_0 != null)
            this.decimal_11 = this.decimal_10;
          gclass146_0.dictionary_4[int_40].decimal_1 -= num3;
        }
        else
        {
          if (this.gclass187_0 == null)
            return;
          this.gclass85_0.method_263();
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2775);
    }
  }

  public void method_131(GClass123 gclass123_1)
  {
    try
    {
      Decimal num1 = (Decimal) this.method_124();
      if (num1 == 0M)
        return;
      foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof (AuroraElement)))
      {
        Decimal num2 = gclass123_1.method_14(auroraElement_0);
        if (!(num2 == 0M))
        {
          Decimal decimal_11 = num1 / GClass226.decimal_28;
          if (num2 < decimal_11)
            decimal_11 = num2;
          if (!(decimal_11 > 0M))
            break;
          this.gclass123_0.method_33(auroraElement_0, decimal_11);
          gclass123_1.method_33(auroraElement_0, -decimal_11);
          num1 -= decimal_11 * GClass226.decimal_28;
          if (num1 == 0M)
            break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2776);
    }
  }

  public void method_132(GClass233 gclass233_0, GClass235 gclass235_0, GClass80 gclass80_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class842 class842 = new GClass40.Class842();
    // ISSUE: reference to a compiler-generated field
    class842.gclass235_0 = gclass235_0;
    try
    {
      Decimal num = (Decimal) this.method_124();
      if (num == 0M)
        return;
      // ISSUE: reference to a compiler-generated field
      int int_0 = (int) (num / (class842.gclass235_0.gclass230_0.decimal_1 * GClass226.decimal_17));
      // ISSUE: reference to a compiler-generated field
      if (class842.gclass235_0.int_0 < int_0)
      {
        // ISSUE: reference to a compiler-generated field
        int_0 = class842.gclass235_0.int_0;
      }
      if (int_0 <= 0)
        return;
      // ISSUE: reference to a compiler-generated method
      GClass73 gclass73 = this.list_17.FirstOrDefault<GClass73>(new Func<GClass73, bool>(class842.method_0));
      if (gclass73 != null)
      {
        gclass73.decimal_0 += (Decimal) int_0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.list_17.Add(new GClass73()
        {
          gclass230_0 = class842.gclass235_0.gclass230_0,
          int_0 = class842.gclass235_0.gclass230_0.int_0,
          decimal_0 = (Decimal) int_0
        });
      }
      // ISSUE: reference to a compiler-generated field
      gclass80_0.method_0(class842.gclass235_0.gclass230_0, int_0);
      // ISSUE: reference to a compiler-generated field
      class842.gclass235_0.int_0 -= int_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2778);
    }
  }

  public Decimal method_133(GClass146 gclass146_0, GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class843 class843 = new GClass40.Class843();
    // ISSUE: reference to a compiler-generated field
    class843.gclass230_0 = gclass230_0;
    try
    {
      Decimal num1 = (Decimal) this.method_124();
      if (num1 == 0M)
      {
        if (this.gclass187_0 != null)
          this.gclass85_0.method_263();
        return 0M;
      }
      if (this.method_113(gclass146_0, false) == 0M)
      {
        if (this.gclass187_0 != null)
          this.gclass85_0.method_263();
        return 0M;
      }
      // ISSUE: reference to a compiler-generated field
      Decimal num2 = gclass146_0.method_76(class843.gclass230_0.int_0);
      // ISSUE: reference to a compiler-generated field
      Decimal decimal_90 = num1 / (class843.gclass230_0.decimal_1 * GClass226.decimal_17);
      if (num2 < decimal_90)
        decimal_90 = num2;
      if (decimal_90 > 0M)
      {
        // ISSUE: reference to a compiler-generated method
        GClass73 gclass73 = this.list_17.FirstOrDefault<GClass73>(new Func<GClass73, bool>(class843.method_0));
        // ISSUE: reference to a compiler-generated method
        gclass146_0.list_2.FirstOrDefault<GClass73>(new Func<GClass73, bool>(class843.method_1));
        if (gclass73 != null)
        {
          gclass73.decimal_0 += decimal_90;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.list_17.Add(new GClass73()
          {
            gclass230_0 = class843.gclass230_0,
            int_0 = class843.gclass230_0.int_0,
            decimal_0 = decimal_90,
            gclass146_0 = gclass146_0
          });
        }
        // ISSUE: reference to a compiler-generated field
        gclass146_0.method_69(class843.gclass230_0, decimal_90);
      }
      else if (this.gclass187_0 != null)
        this.gclass85_0.method_263();
      return decimal_90;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2779);
      return 0M;
    }
  }

  public Decimal method_134(
    GClass146 gclass146_0,
    AuroraElement auroraElement_0,
    Decimal decimal_42,
    Decimal decimal_43)
  {
    try
    {
      Decimal num1 = decimal_43;
      Decimal num2 = 0M;
      foreach (AuroraElement auroraElement_0_1 in Enum.GetValues(typeof (AuroraElement)))
      {
        if (auroraElement_0_1 == auroraElement_0 || auroraElement_0 == AuroraElement.None)
        {
          Decimal num3 = (Decimal) this.method_124();
          if (num3 == 0M && auroraElement_0_1 != AuroraElement.None || this.method_113(gclass146_0, false) == 0M)
            return num2;
          Decimal num4 = gclass146_0.gclass123_0.method_14(auroraElement_0_1);
          if (num4 < decimal_42)
            return num2;
          Decimal num5 = num4 - gclass146_0.gclass123_2.method_14(auroraElement_0_1);
          Decimal num6 = num3 / GClass226.decimal_28;
          if (num5 < num6)
            num6 = num5;
          if (num1 < num6 && num1 > 0M)
            num6 = decimal_43;
          if (num6 > 0M)
          {
            this.gclass123_0.method_33(auroraElement_0_1, num6);
            gclass146_0.gclass123_0.method_33(auroraElement_0_1, -num6);
            if (!gclass146_0.gclass21_0.bool_0)
              gclass146_0.method_21(GEnum85.const_8, auroraElement_0_1, num6);
            num1 -= num6;
            num2 += num6;
          }
        }
      }
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2780);
      return 0M;
    }
  }

  public void method_135(GClass146 gclass146_0)
  {
    try
    {
      foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof (AuroraElement)))
      {
        Decimal num1 = this.gclass123_0.method_14(auroraElement_0);
        if (!(num1 == 0M))
        {
          Decimal num2 = gclass146_0.gclass123_2.method_14(auroraElement_0) - gclass146_0.gclass123_0.method_14(auroraElement_0);
          if (!(num2 <= 0M))
          {
            if (!(this.method_113(gclass146_0, false) == 0M))
            {
              if (num1 > num2)
                num1 = num2;
              this.gclass123_0.method_33(auroraElement_0, -num1);
              gclass146_0.gclass123_0.method_33(auroraElement_0, num1);
              if (!gclass146_0.gclass21_0.bool_0)
                gclass146_0.method_21(GEnum85.const_7, auroraElement_0, num1);
            }
            else
            {
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to unload minerals to {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
              return;
            }
          }
        }
      }
      foreach (AuroraElement auroraElement in Enum.GetValues(typeof (AuroraElement)))
      {
        Decimal num3 = gclass146_0.gclass123_0.method_14(auroraElement) - gclass146_0.gclass123_2.method_14(auroraElement);
        if (!(num3 <= 0M))
        {
          Decimal num4 = (Decimal) this.method_124();
          if (!(this.method_113(gclass146_0, false) == 0M))
          {
            Decimal num5 = num4 / GClass226.decimal_28;
            if (num3 < num5)
              num5 = num3;
            if (num5 > 0M)
            {
              this.gclass123_0.method_33(auroraElement, num5);
              gclass146_0.gclass123_0.method_33(auroraElement, -num5);
              if (!gclass146_0.gclass21_0.bool_0)
                gclass146_0.method_21(GEnum85.const_8, auroraElement, num5);
            }
          }
          else
          {
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_52, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to load {GClass226.smethod_82((Enum) auroraElement)} from {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2781);
    }
  }

  public void method_136(GClass139 gclass139_0)
  {
    try
    {
      if (this.gclass0_0.dictionary_71.ContainsKey(gclass139_0.int_7))
      {
        List<GClass103> gclass103List = new List<GClass103>();
        if (gclass139_0.bool_1)
          gclass103List = this.gclass0_0.dictionary_71[gclass139_0.int_7].method_22((GClass146) null, this);
        else
          gclass103List.Add(this.gclass0_0.dictionary_71[gclass139_0.int_7]);
        foreach (GClass103 gclass103 in gclass103List)
        {
          if (gclass103.gclass40_0 == this && gclass103.method_10(gclass139_0))
          {
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"All units of {gclass103.Name} were lost in a boarding attempt launched from {gclass103.gclass40_0.method_187()}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
            this.gclass0_0.dictionary_71.Remove(gclass103.int_0);
          }
        }
      }
      else
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to launch a boarding attempt as the assigned ground unit does not exist", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2782);
    }
  }

  public void method_137(GClass139 gclass139_0)
  {
    try
    {
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).ToList<GClass103>())
      {
        if (gclass103.method_10(gclass139_0))
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"All units of {gclass103.Name} were lost in a boarding attempt launched from {gclass103.gclass40_0.method_187()}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          this.gclass0_0.dictionary_71.Remove(gclass103.int_0);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2783);
    }
  }

  public void method_138(GClass139 gclass139_0)
  {
    try
    {
      bool flag = false;
      if (this.gclass0_0.dictionary_71.ContainsKey(gclass139_0.int_7))
      {
        List<GClass103> gclass103List = new List<GClass103>();
        if (gclass139_0.bool_1)
          gclass103List = this.gclass0_0.dictionary_71[gclass139_0.int_7].method_22((GClass146) null, this);
        else
          gclass103List.Add(this.gclass0_0.dictionary_71[gclass139_0.int_7]);
        foreach (GClass103 gclass103 in gclass103List)
        {
          if (gclass103.gclass40_0 == this)
          {
            gclass103.gclass40_0 = (GClass40) null;
            gclass103.gclass146_0 = gclass139_0.gclass146_0;
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_227, $"{gclass103.Name} unloaded to {gclass103.gclass146_0.PopName}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.PopGroundUnits);
            if (gclass139_0.gclass133_0.genum123_0 == GEnum123.const_93 || gclass139_0.gclass133_0.genum123_0 == GEnum123.const_93)
            {
              flag = true;
              if (gclass103.gclass55_0 != null)
                gclass103.gclass55_0.method_1(AuroraMeasurementType.CombatDropFormation, 1M);
            }
            foreach (GClass39 gclass39 in gclass103.list_0)
              gclass39.decimal_1 = 1M;
          }
        }
        if (!flag)
          return;
        this.method_56(AuroraMeasurementType.CombatDropTransport, 1M);
        this.method_192(AuroraCommandType.Ship)?.method_1(AuroraMeasurementType.CombatDropTransport, 1M);
      }
      else
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to unload ground units as the target ground unit does not exist", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2784);
    }
  }

  public void method_139(GClass139 gclass139_0)
  {
    try
    {
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).ToList<GClass103>())
      {
        gclass103.gclass40_0 = (GClass40) null;
        gclass103.gclass146_0 = gclass139_0.gclass146_0;
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_227, $"{gclass103.Name} unloaded to {gclass103.gclass146_0.PopName}", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.PopGroundUnits);
        foreach (GClass39 gclass39 in gclass103.list_0)
          gclass39.decimal_1 = 1M;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2785);
    }
  }

  public Decimal method_140(
    GClass146 gclass146_0,
    AuroraInstallationType auroraInstallationType_0,
    Decimal decimal_42)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class846 class846 = new GClass40.Class846();
    // ISSUE: reference to a compiler-generated field
    class846.auroraInstallationType_0 = auroraInstallationType_0;
    try
    {
      if (this.method_113(gclass146_0, false) == 0M)
      {
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to unload {this.gclass0_0.dictionary_44[class846.auroraInstallationType_0].Name} at {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        return 0M;
      }
      // ISSUE: reference to a compiler-generated field
      if (class846.auroraInstallationType_0 == AuroraInstallationType.NoType)
      {
        foreach (GClass158 gclass158 in this.dictionary_2.Values)
          gclass146_0.method_65(gclass158.gclass157_0.auroraInstallationType_0, gclass158.decimal_0);
        this.dictionary_2.Clear();
        return 0M;
      }
      // ISSUE: reference to a compiler-generated method
      GClass158 gclass158_1 = this.dictionary_2.Values.FirstOrDefault<GClass158>(new Func<GClass158, bool>(class846.method_0));
      if (gclass158_1 == null)
        return 0M;
      if (this.gclass187_0 != null)
      {
        Decimal num1 = (this.decimal_10 - this.decimal_11) / 1000000000M;
        this.decimal_11 = this.decimal_10;
        Decimal num2 = gclass158_1.method_0() * GClass226.decimal_3 * num1;
        Decimal decimal_29 = num2 * this.gclass21_0.decimal_5;
        Decimal num3 = num2 - decimal_29;
        if (this.gclass21_0.bool_0)
          num3 *= GClass226.decimal_70;
        this.gclass21_0.method_299(num3, this.gclass0_0.dictionary_45[GEnum84.const_23]);
        this.gclass187_0.method_12(gclass158_1.gclass146_1, gclass146_0, this, num3, false, false, false, (GClass189) null);
        this.gclass21_0.method_300(decimal_29, this.gclass0_0.dictionary_45[GEnum84.const_14]);
      }
      Decimal decimal_90 = gclass158_1.decimal_0;
      if (decimal_42 < decimal_90 && decimal_42 > 0M)
        decimal_90 = decimal_42;
      gclass146_0.method_65(gclass158_1.gclass157_0.auroraInstallationType_0, decimal_90);
      if (decimal_90 == gclass158_1.decimal_0)
        this.dictionary_2.Remove(gclass158_1.gclass157_0.auroraInstallationType_0);
      else
        gclass158_1.decimal_0 -= decimal_90;
      return decimal_90;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2786);
      return 0M;
    }
  }

  public Decimal method_141(
    GClass85 gclass85_1,
    List<GClass40> list_21,
    AuroraInstallationType auroraInstallationType_0,
    int int_40,
    Decimal decimal_42)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class847 class847 = new GClass40.Class847();
    // ISSUE: reference to a compiler-generated field
    class847.auroraInstallationType_0 = auroraInstallationType_0;
    try
    {
      if (this.method_114() + (Decimal) int_40 == 0M)
      {
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to transfer {this.gclass0_0.dictionary_44[class847.auroraInstallationType_0].Name} to {gclass85_1.FleetName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        return 0M;
      }
      List<GClass158> list = this.dictionary_2.Values.ToList<GClass158>();
      // ISSUE: reference to a compiler-generated field
      if (class847.auroraInstallationType_0 != AuroraInstallationType.NoType)
      {
        // ISSUE: reference to a compiler-generated method
        list = list.Where<GClass158>(new Func<GClass158, bool>(class847.method_0)).ToList<GClass158>();
      }
      if (list.Count == 0)
        return decimal_42;
      foreach (GClass158 gclass158 in list)
      {
        // ISSUE: reference to a compiler-generated field
        class847.auroraInstallationType_0 = gclass158.gclass157_0.auroraInstallationType_0;
        foreach (GClass40 gclass40 in list_21)
        {
          Decimal num1 = (Decimal) gclass40.method_124();
          if (!(num1 <= 0M))
          {
            // ISSUE: reference to a compiler-generated field
            Decimal num2 = num1 / (Decimal) this.gclass0_0.dictionary_44[class847.auroraInstallationType_0].int_1;
            if (gclass158.decimal_0 < num2)
              num2 = gclass158.decimal_0;
            if (decimal_42 > 0M && decimal_42 < num2)
              num2 = decimal_42;
            if (num2 > 0M)
            {
              // ISSUE: reference to a compiler-generated field
              if (gclass40.dictionary_2.ContainsKey(class847.auroraInstallationType_0))
              {
                // ISSUE: reference to a compiler-generated field
                gclass40.dictionary_2[class847.auroraInstallationType_0].decimal_0 += num2;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass40.dictionary_2.Add(class847.auroraInstallationType_0, new GClass158()
                {
                  gclass157_0 = this.gclass0_0.dictionary_44[class847.auroraInstallationType_0],
                  gclass40_0 = this,
                  decimal_0 = num2,
                  gclass146_1 = gclass158.gclass146_1
                });
              }
              if (decimal_42 > 0M)
                decimal_42 -= num2;
              gclass158.decimal_0 -= num2;
              if (gclass158.decimal_0 <= 0M)
                break;
            }
          }
        }
      }
      return decimal_42;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2786);
      return 0M;
    }
  }

  public Decimal method_142(
    GClass85 gclass85_1,
    List<GClass40> list_21,
    AuroraElement auroraElement_0,
    int int_40,
    Decimal decimal_42)
  {
    try
    {
      if (this.method_114() + (Decimal) int_40 == 0M)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to transfer {GClass226.smethod_82((Enum) auroraElement_0)} to {gclass85_1.FleetName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        return 0M;
      }
      if (auroraElement_0 == AuroraElement.None)
      {
        foreach (GClass40 gclass40 in list_21)
        {
          Decimal num1 = (Decimal) gclass40.method_124();
          if (!(num1 <= 0M))
          {
            foreach (AuroraElement auroraElement_0_1 in Enum.GetValues(typeof (AuroraElement)))
            {
              Decimal num2 = this.gclass123_0.method_14(auroraElement_0_1);
              Decimal decimal_11 = num1 / GClass226.decimal_28;
              if (num2 < decimal_11)
                decimal_11 = num2;
              if (decimal_42 > 0M && decimal_42 < decimal_11)
                decimal_11 = decimal_42;
              if (decimal_11 > 0M)
              {
                gclass40.gclass123_0.method_33(auroraElement_0_1, decimal_11);
                this.gclass123_0.method_33(auroraElement_0_1, -decimal_11);
                if (decimal_42 > 0M)
                  decimal_42 -= decimal_11;
                num1 -= decimal_11 * GClass226.decimal_28;
                if (num1 <= 0M)
                  break;
              }
            }
          }
        }
      }
      return decimal_42;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2789);
      return 0M;
    }
  }

  public void method_143(GClass146 gclass146_0, GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class848 class848 = new GClass40.Class848();
    // ISSUE: reference to a compiler-generated field
    class848.gclass230_0 = gclass230_0;
    try
    {
      if (this.method_113(gclass146_0, false) == 0M)
      {
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to unload {class848.gclass230_0.Name} at {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        foreach (GClass73 gclass73 in class848.gclass230_0 == null ? this.list_17.ToList<GClass73>() : this.list_17.Where<GClass73>(new Func<GClass73, bool>(class848.method_0)).ToList<GClass73>())
        {
          gclass146_0.method_67(gclass73.gclass230_0, gclass73.decimal_0);
          this.list_17.Remove(gclass73);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2787);
    }
  }

  public void method_144(GClass146 gclass146_0, int int_40)
  {
    try
    {
      GClass191 gclass191 = this.dictionary_3[int_40];
      if (this.method_113(gclass146_0, false) == 0M)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to unload {this.gclass0_0.dictionary_56[int_40].string_0} at {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
      }
      else
      {
        Decimal num1 = (this.decimal_10 - this.decimal_11) / 1000000000M;
        this.decimal_11 = this.decimal_10;
        Decimal num2 = gclass191.decimal_0 * GClass226.decimal_0 * num1;
        Decimal decimal_29 = num2 * this.gclass21_0.decimal_5;
        Decimal decimal_3 = num2 - decimal_29;
        if (this.gclass21_0.bool_0)
          decimal_3 *= GClass226.decimal_70;
        if (decimal_29 > 0M)
          this.gclass21_0.method_300(decimal_29, this.gclass0_0.dictionary_45[GEnum84.const_14]);
        if (decimal_3 > 0M)
          this.gclass187_0.method_12(gclass191.gclass146_0, gclass146_0, this, decimal_3, false, false, false, gclass191.gclass189_0);
        if (gclass191.gclass189_0.genum49_0 == GEnum49.const_2)
          gclass146_0.method_65(AuroraInstallationType.Infrastructure, gclass191.decimal_0);
        else if (gclass146_0.dictionary_4.ContainsKey(int_40))
          gclass146_0.dictionary_4[int_40].decimal_1 += gclass191.decimal_0;
        this.dictionary_3.Remove(int_40);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2788);
    }
  }

  public Decimal method_145(
    GClass146 gclass146_0,
    AuroraElement auroraElement_0,
    Decimal decimal_42)
  {
    try
    {
      if (this.method_113(gclass146_0, false) == 0M)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to unload {GClass226.smethod_82((Enum) auroraElement_0)} at {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
        return 0M;
      }
      if (auroraElement_0 == AuroraElement.None)
      {
        gclass146_0.gclass123_0.method_10(this.gclass123_0);
        if (!gclass146_0.gclass21_0.bool_0)
          this.gclass123_0.method_24(gclass146_0, GEnum85.const_7);
        this.gclass123_0.method_6();
        return 0M;
      }
      Decimal num = this.gclass123_0.method_14(auroraElement_0);
      if (decimal_42 < num && decimal_42 > 0M)
        num = decimal_42;
      gclass146_0.gclass123_0.method_33(auroraElement_0, num);
      if (!gclass146_0.gclass21_0.bool_0)
        gclass146_0.method_21(GEnum85.const_7, auroraElement_0, num);
      this.gclass123_0.method_33(auroraElement_0, -num);
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2789);
      return 0M;
    }
  }

  public void method_146(GClass146 gclass146_0)
  {
    try
    {
      foreach (GClass181 gclass181 in this.list_18)
      {
        if (gclass181.gclass194_0 != gclass146_0.gclass194_0)
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_143, "Cannot unload colonists from one species at population of a different species", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Fleet);
        else if (gclass181.bool_0 && gclass181.gclass146_0.gclass202_0.gclass200_0 == this.gclass85_0.gclass202_0.gclass200_0)
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_143, "Cannot unload colonists from a neutral empire in the same system in which they were loaded", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Fleet);
        else if (!(this.method_113(gclass146_0, false) == 0M))
        {
          if (this.gclass187_0 != null)
          {
            Decimal num1 = (this.decimal_10 - this.decimal_11) / 1000000000M;
            this.decimal_11 = this.decimal_10;
            if (this.gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.Liner)
            {
              Decimal num2 = (Decimal) gclass181.int_0 * GClass226.decimal_2 * num1;
              Decimal decimal_29 = num2 * this.gclass21_0.decimal_5;
              Decimal decimal_3 = num2 - decimal_29;
              if (this.gclass21_0.bool_0)
                decimal_3 *= GClass226.decimal_70;
              this.gclass21_0.method_300(decimal_29, this.gclass0_0.dictionary_45[GEnum84.const_22]);
              this.gclass187_0.method_12(gclass181.gclass146_0, gclass146_0, this, decimal_3, false, false, true, (GClass189) null);
            }
            else if (this.gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.ColonyShip)
            {
              Decimal num3 = (Decimal) gclass181.int_0 * GClass226.decimal_1 * num1;
              Decimal decimal_29 = num3 * this.gclass21_0.decimal_5;
              Decimal decimal_3 = num3 - decimal_29;
              if (this.gclass21_0.bool_0)
                decimal_3 *= GClass226.decimal_70;
              this.gclass21_0.method_300(decimal_29, this.gclass0_0.dictionary_45[GEnum84.const_16]);
              this.gclass187_0.method_12(gclass181.gclass146_0, gclass146_0, this, decimal_3, false, false, true, (GClass189) null);
            }
          }
          gclass146_0.method_25(gclass146_0.decimal_4 + (Decimal) gclass181.int_0 / 1000000M);
          gclass181.bool_1 = true;
        }
        else
        {
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_53, $"{this.ShipName} (FLT: {this.gclass85_0.FleetName}) was unable to unload colonists at {gclass146_0.PopName} due to a lack of cargo shuttles", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Fleet);
          return;
        }
      }
      this.list_18 = this.list_18.Where<GClass181>((Func<GClass181, bool>) (gclass181_0 => !gclass181_0.bool_1)).ToList<GClass181>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2790);
    }
  }

  public void method_147(GEnum8 genum8_0)
  {
    try
    {
      GClass55 gclass55 = this.method_192(AuroraCommandType.Ship);
      if (gclass55 == null || genum8_0 != GEnum8.const_0)
        return;
      if (GClass226.smethod_23())
        gclass55.method_10(GEnum121.const_1, 0.01M, true);
      this.method_192(AuroraCommandType.ScienceOfficer)?.method_10(GEnum121.const_1, 0.01M, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2791);
    }
  }

  public GClass230 method_148(bool bool_22)
  {
    try
    {
      List<GClass228> gclass228List = new List<GClass228>();
      foreach (GClass228 gclass228_0 in bool_22 ? this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.JumpDrive)).ToList<GClass228>() : this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.JumpDrive && gclass228_0.gclass230_0.genum87_0 == GEnum87.const_0)).ToList<GClass228>())
      {
        if (this.method_158(gclass228_0) > 0)
          return gclass228_0.gclass230_0;
      }
      return (GClass230) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2792);
      return (GClass230) null;
    }
  }

  public Decimal method_149()
  {
    try
    {
      return this.method_157(AuroraComponentType.ColonistTransport, false) + this.method_157(AuroraComponentType.PassengerModule, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2793);
      return 0M;
    }
  }

  public Decimal method_150()
  {
    try
    {
      Decimal num1 = 0M;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ColonistTransport && gclass228_0.gclass230_0.genum87_0 == GEnum87.const_7)).ToList<GClass228>())
      {
        int num2 = this.method_158(gclass228_0);
        num1 += gclass228_0.gclass230_0.decimal_3 * (Decimal) num2;
      }
      int num3 = this.list_18.Sum<GClass181>((Func<GClass181, int>) (gclass181_0 => gclass181_0.int_0));
      return (Decimal) num3 < num1 ? (Decimal) num3 : num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3554);
      return 0M;
    }
  }

  public Decimal method_151()
  {
    try
    {
      return this.method_157(AuroraComponentType.FuelStorage, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2794);
      return 0M;
    }
  }

  public Decimal method_152()
  {
    try
    {
      return this.method_157(AuroraComponentType.ELINTModule, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2795);
      return 0M;
    }
  }

  public Decimal method_153()
  {
    try
    {
      if (this.gclass21_0.genum6_0 == GEnum6.const_2)
        return this.gclass22_0.decimal_14 / 100M;
      Decimal num = (this.method_157(AuroraComponentType.DamageControl, false) + this.method_157(AuroraComponentType.CommercialDamageControl, false) + this.method_157(AuroraComponentType.Engineering, false)) * ((this.method_123(GEnum121.const_24) - 1M) * 5M + 1M);
      if (num < 1M)
        num = 1M;
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2796);
      return 0M;
    }
  }

  public Decimal method_154()
  {
    try
    {
      Decimal num1 = this.method_157(AuroraComponentType.DamageControl, false) + this.method_157(AuroraComponentType.CommercialDamageControl, false) + this.method_157(AuroraComponentType.Engineering, false);
      if (num1 < 1M)
        return 0M;
      Decimal num2 = Math.Floor(num1 * (200M / this.gclass22_0.decimal_14));
      if (num2 > 50M)
        num2 = 50M;
      Decimal num3 = this.method_123(GEnum121.const_24);
      num2 *= num3;
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3590);
      return 0M;
    }
  }

  public bool method_155()
  {
    try
    {
      return this.gclass40_0 != null && (this.gclass22_0.bool_2 || this.gclass40_0.method_157(AuroraComponentType.HangarDeck, false) > 0M);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3550);
      return false;
    }
  }

  public Decimal method_156(AuroraJammerType auroraJammerType_0)
  {
    try
    {
      GClass228 gclass228_0_1 = (GClass228) null;
      switch (auroraJammerType_0)
      {
        case AuroraJammerType.Sensor:
          gclass228_0_1 = this.gclass22_0.dictionary_0.Values.FirstOrDefault<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass164_0.gclass163_0.genum122_0 == GEnum122.const_50));
          break;
        case AuroraJammerType.FireControl:
          gclass228_0_1 = this.gclass22_0.dictionary_0.Values.FirstOrDefault<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass164_0.gclass163_0.genum122_0 == GEnum122.const_131));
          break;
        case AuroraJammerType.Missile:
          gclass228_0_1 = this.gclass22_0.dictionary_0.Values.FirstOrDefault<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass164_0.gclass163_0.genum122_0 == GEnum122.const_130));
          break;
      }
      return gclass228_0_1 == null || this.method_158(gclass228_0_1) <= 0 ? 0M : gclass228_0_1.gclass230_0.decimal_3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3659);
      return 0M;
    }
  }

  public Decimal method_157(AuroraComponentType auroraComponentType_0, bool bool_22)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class854 class854 = new GClass40.Class854();
    // ISSUE: reference to a compiler-generated field
    class854.auroraComponentType_0 = auroraComponentType_0;
    try
    {
      Decimal num1 = 0M;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(class854.method_0)).ToList<GClass228>())
      {
        int num2 = this.method_158(gclass228_0);
        // ISSUE: reference to a compiler-generated field
        switch (class854.auroraComponentType_0)
        {
          case AuroraComponentType.SoriumHarvester:
            num1 += (Decimal) num2 * this.gclass21_0.decimal_12;
            continue;
          case AuroraComponentType.TerraformingModule:
            num1 += (Decimal) num2 * this.gclass21_0.decimal_18;
            continue;
          case AuroraComponentType.OrbitalMiningModule:
            num1 += (Decimal) num2 * this.gclass21_0.decimal_17;
            continue;
          case AuroraComponentType.MaintenanceModule:
            num1 += (Decimal) num2 * this.gclass21_0.decimal_22;
            continue;
          default:
            num1 += (Decimal) num2 * gclass228_0.gclass230_0.decimal_3;
            continue;
        }
      }
      if (!bool_22)
        return num1;
      GClass55 gclass55 = this.method_192(AuroraCommandType.Ship);
      if (gclass55 != null && num1 > 0M)
      {
        // ISSUE: reference to a compiler-generated field
        switch (class854.auroraComponentType_0)
        {
          case AuroraComponentType.GravitationalSurveySensors:
          case AuroraComponentType.GeologicalSurveySensors:
            num1 *= this.method_123(GEnum121.const_1);
            break;
          case AuroraComponentType.CargoShuttleBay:
            num1 *= gclass55.method_5(GEnum121.const_20);
            break;
          case AuroraComponentType.SoriumHarvester:
          case AuroraComponentType.OrbitalMiningModule:
            num1 *= gclass55.method_5(GEnum121.const_5);
            break;
          case AuroraComponentType.TerraformingModule:
            num1 *= gclass55.method_5(GEnum121.const_8);
            break;
          case AuroraComponentType.SalvageModule:
            num1 *= gclass55.method_5(GEnum121.const_4);
            break;
        }
      }
      if (num1 > 0M)
      {
        // ISSUE: reference to a compiler-generated field
        switch (class854.auroraComponentType_0)
        {
          case AuroraComponentType.GravitationalSurveySensors:
          case AuroraComponentType.GeologicalSurveySensors:
            num1 *= this.decimal_2;
            break;
        }
        // ISSUE: reference to a compiler-generated field
        switch (class854.auroraComponentType_0)
        {
          case AuroraComponentType.GravitationalSurveySensors:
          case AuroraComponentType.GeologicalSurveySensors:
          case AuroraComponentType.SoriumHarvester:
          case AuroraComponentType.TerraformingModule:
          case AuroraComponentType.OrbitalMiningModule:
          case AuroraComponentType.SalvageModule:
          case AuroraComponentType.MaintenanceModule:
            if (this.int_11 < this.gclass22_0.int_11)
            {
              Decimal num3 = (Decimal) this.int_11 / (Decimal) this.gclass22_0.int_11;
              num1 *= num3;
              break;
            }
            break;
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2797);
      return 0M;
    }
  }

  public int method_158(GClass228 gclass228_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class855 class855 = new GClass40.Class855();
    // ISSUE: reference to a compiler-generated field
    class855.gclass228_0 = gclass228_0;
    try
    {
      if (this.list_12.Count == 0)
      {
        // ISSUE: reference to a compiler-generated field
        return (int) class855.gclass228_0.decimal_0;
      }
      // ISSUE: reference to a compiler-generated method
      GClass178 gclass178 = this.list_12.Where<GClass178>(new Func<GClass178, bool>(class855.method_0)).FirstOrDefault<GClass178>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return gclass178 != null ? (int) class855.gclass228_0.decimal_0 - gclass178.int_0 : (int) class855.gclass228_0.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2798);
      return 0;
    }
  }

  public bool method_159(GEnum118 genum118_0)
  {
    try
    {
      return this.gclass22_0.dictionary_0.ContainsKey((int) genum118_0) && this.method_158(this.gclass22_0.dictionary_0[(int) genum118_0]) > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2799);
      return false;
    }
  }

  public int method_160(GClass230 gclass230_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class856 class856 = new GClass40.Class856();
    // ISSUE: reference to a compiler-generated field
    class856.gclass230_0 = gclass230_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass228 gclass228_0 = this.gclass22_0.dictionary_0.Values.FirstOrDefault<GClass228>(new Func<GClass228, bool>(class856.method_0));
      return gclass228_0 == null ? 0 : this.method_158(gclass228_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3764);
      return 0;
    }
  }

  public void method_161(ListView listView_0)
  {
    try
    {
      foreach (GClass54 gclass54 in this.list_0.Where<GClass54>((Func<GClass54, bool>) (gclass54_0 => !gclass54_0.bool_0)).OrderBy<GClass54, string>((Func<GClass54, string>) (gclass54_0 => GClass226.smethod_82((Enum) gclass54_0.auroraMeasurementType_0))).ToList<GClass54>())
        this.gclass0_0.method_601(listView_0, GClass226.smethod_82((Enum) gclass54.auroraMeasurementType_0), GClass226.smethod_38(gclass54.decimal_0), (string) null);
      foreach (GClass54 gclass54 in this.list_0.Where<GClass54>((Func<GClass54, bool>) (gclass54_0 => gclass54_0.bool_0)).OrderBy<GClass54, string>((Func<GClass54, string>) (gclass54_0 => GClass226.smethod_82((Enum) gclass54_0.auroraMeasurementType_0))).ToList<GClass54>())
        this.gclass0_0.method_601(listView_0, GClass226.smethod_82((Enum) gclass54.auroraMeasurementType_0) + " (SG)", GClass226.smethod_38(gclass54.decimal_0), (string) null);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2800);
    }
  }

  public string method_162()
  {
    try
    {
      if (this.decimal_10 < 1000000M)
        return GClass226.smethod_42(this.decimal_10 / 1000000M, 2) + "m";
      if (this.decimal_10 < 10000000M)
        return GClass226.smethod_42(this.decimal_10 / 1000000M, 1) + "m";
      if (this.decimal_10 < 1000000000M)
        return GClass226.smethod_39(this.decimal_10 / 1000000M) + "m";
      return this.decimal_10 < 10000000000M ? GClass226.smethod_42(this.decimal_10 / 1000000000M, 1) + "b" : GClass226.smethod_39(this.decimal_10 / 1000000000M) + "b";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3384);
      return "0";
    }
  }

  public string method_163()
  {
    try
    {
      Decimal decimal_73 = this.decimal_10 / 1000000000M;
      if (decimal_73 < 0.01M)
        return GClass226.smethod_42(decimal_73, 3);
      if (decimal_73 < 1M)
        return GClass226.smethod_42(decimal_73, 2);
      return decimal_73 < 10M ? GClass226.smethod_42(decimal_73, 1) : GClass226.smethod_39(decimal_73);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3648);
      return "0";
    }
  }

  public string method_164(
    int int_40,
    int int_41,
    ComboBox comboBox_0,
    ComboBox comboBox_1,
    ComboBox comboBox_2,
    ComboBox comboBox_3,
    FlowLayoutPanel flowLayoutPanel_0,
    ListView listView_0,
    ListView listView_1,
    ListView listView_2,
    ListView listView_3,
    ListView listView_4,
    ListView listView_5,
    ListView listView_6,
    ListView listView_7,
    ListView listView_8,
    int int_42)
  {
    try
    {
      GClass22 gclass22 = this.gclass22_0.method_50((GClass21) null, false);
      gclass22.ClassName = this.gclass22_0.ClassName;
      if (this.gclass22_0.int_23 == 1)
      {
        comboBox_0.Visible = true;
        comboBox_0.SelectedIndex = (int) this.auroraRefuelStatus_0;
      }
      else
        comboBox_0.Visible = false;
      if (this.gclass22_0.int_52 == 1)
      {
        comboBox_1.Visible = true;
        comboBox_1.SelectedIndex = (int) this.auroraResupplyStatus_0;
      }
      else
        comboBox_1.Visible = false;
      if (this.gclass22_0.int_5 == 1)
      {
        comboBox_2.Visible = true;
        comboBox_2.SelectedIndex = (int) this.auroraOrdnanceTransferStatus_0;
      }
      else
        comboBox_2.Visible = false;
      if (!(this.gclass22_0.method_72(AuroraComponentType.HangarDeck) > 0M) && !(this.gclass22_0.method_72(AuroraComponentType.CommercialHangarDeck) > 0M))
      {
        comboBox_3.Visible = false;
      }
      else
      {
        comboBox_3.Visible = true;
        comboBox_3.SelectedIndex = (int) this.genum43_0;
      }
      if (this.gclass22_0.method_49())
        flowLayoutPanel_0.Visible = true;
      else
        flowLayoutPanel_0.Visible = false;
      gclass22.list_0 = new List<GClass130>();
      foreach (GClass130 gclass130 in this.list_10)
        gclass22.list_0.Add(new GClass130()
        {
          gclass129_0 = gclass130.gclass129_0,
          int_0 = gclass130.int_0
        });
      gclass22.list_1.Clear();
      foreach (GClass228 gclass228_0 in gclass22.dictionary_0.Values)
        gclass228_0.int_4 = this.method_158(gclass228_0);
      gclass22.method_85(int_40, int_41, this.method_187());
      string string_11_1 = this.method_189().ToString() + "%";
      string string_11_2 = Math.Round(this.decimal_16 / 5M).ToString() + "%";
      string string_11_3 = GClass226.smethod_38(this.decimal_2 * 100M) + "%";
      Decimal num1;
      if (this.method_172() > 0M)
      {
        num1 = Math.Round(this.decimal_4 / this.method_172() * 100M);
        string str = num1.ToString() + "%";
      }
      Decimal num2 = this.method_157(AuroraComponentType.FuelStorage, false);
      if (num2 > 0M)
      {
        num1 = Math.Round(this.decimal_14 / num2 * 100M);
        string str = num1.ToString() + "%";
      }
      if (this.method_181() > 0M)
      {
        num1 = Math.Round(this.method_212());
        string str = num1.ToString() + "%";
      }
      int num3 = this.gclass22_0.int_2 * this.gclass22_0.int_3;
      int num4 = this.dictionary_5.Sum<KeyValuePair<int, int>>((Func<KeyValuePair<int, int>, int>) (keyValuePair_0 => keyValuePair_0.Value));
      num1 = Math.Round((Decimal) (num3 - num4) / (Decimal) num3 * 100M);
      string string_11_4 = num1.ToString() + "%";
      Decimal num5 = this.method_157(AuroraComponentType.Shields, false) * this.decimal_9;
      string string_11_5 = "-";
      if (num5 > 0M)
      {
        num1 = Math.Round(this.decimal_3 / num5 * 100M);
        string_11_5 = num1.ToString() + "%";
      }
      string string_11_6 = "-";
      if (!this.gclass22_0.bool_2)
        string_11_6 = GClass226.smethod_45((this.gclass0_0.decimal_0 - this.decimal_7) / GClass226.decimal_31, 2);
      string string_11_7 = "-";
      if (!this.gclass22_0.bool_2)
        string_11_7 = GClass226.smethod_45((this.gclass0_0.decimal_0 - this.decimal_6) / GClass226.decimal_29, 2);
      string string_11_8 = GClass226.smethod_42(this.method_166(), 2);
      num1 = Math.Round(this.method_171(false) / (Decimal) this.gclass22_0.int_32 * 100M);
      string string_11_9 = num1.ToString() + "%";
      listView_2.Items.Clear();
      listView_0.Items.Clear();
      listView_1.Items.Clear();
      listView_3.Items.Clear();
      listView_4.Items.Clear();
      this.gclass0_0.method_597(listView_1, "Construction Date", this.gclass0_0.method_584(this.decimal_1));
      this.gclass0_0.method_597(listView_1, "Distance Travelled", this.method_162());
      this.gclass0_0.method_597(listView_1, "Deployment Clock", string_11_6);
      this.gclass0_0.method_597(listView_1, "Maintenance Clock", string_11_7);
      this.gclass0_0.method_597(listView_1, "Current Range", string_11_8);
      this.gclass0_0.method_597(listView_1, "Fuel Amount", GClass226.smethod_38(this.decimal_14));
      this.gclass0_0.method_597(listView_1, "Maint. Supply Points", GClass226.smethod_38(this.decimal_4));
      this.gclass0_0.method_597(listView_1, "Crew Casualties", GClass226.smethod_37(this.gclass22_0.int_11 - this.int_11));
      if (this.gclass40_1 != null)
        this.gclass0_0.method_597(listView_1, "Assigned Mothership", this.gclass40_1.method_187());
      this.gclass0_0.method_597(listView_2, "Armour", string_11_4);
      this.gclass0_0.method_597(listView_2, "Shields", string_11_5);
      this.gclass0_0.method_597(listView_2, "Engines", string_11_9);
      this.gclass0_0.method_597(listView_2, "Required Power", this.method_165());
      this.gclass0_0.method_597(listView_2, "Crew Grade", string_11_1);
      this.gclass0_0.method_597(listView_2, "Crew Morale", string_11_3);
      this.gclass0_0.method_597(listView_2, "Fleet Training", string_11_2);
      this.method_161(listView_7);
      if (this.gclass21_0.genum6_0 == GEnum6.const_2)
        this.gclass0_0.method_597(listView_0, "Bio-Energy", GClass226.smethod_39(this.decimal_17));
      foreach (GClass130 gclass130 in this.list_10)
        this.gclass0_0.method_597(listView_3, gclass130.gclass129_0.Name, GClass226.smethod_37(gclass130.int_0));
      foreach (GClass158 gclass158 in this.dictionary_2.Values)
        this.gclass0_0.method_597(listView_3, gclass158.gclass157_0.Name, GClass226.smethod_42(gclass158.decimal_0, 2));
      foreach (GClass191 gclass191 in this.dictionary_3.Values)
        this.gclass0_0.method_597(listView_3, gclass191.gclass189_0.string_0, GClass226.smethod_42(gclass191.decimal_0, 2));
      foreach (GClass73 gclass73 in this.list_17)
        this.gclass0_0.method_597(listView_3, gclass73.gclass230_0.Name, GClass226.smethod_42(gclass73.decimal_0, 2));
      foreach (GClass181 gclass181 in this.list_18)
        this.gclass0_0.method_597(listView_3, gclass181.gclass194_0.SpeciesName, GClass226.smethod_37(gclass181.int_0));
      this.gclass123_0.method_30(listView_3);
      GClass55 object_1_1 = this.method_192(AuroraCommandType.Ship);
      if (object_1_1 != null)
        this.gclass0_0.method_598(listView_4, "Commanding Officer", $"{object_1_1.method_36()} {object_1_1.method_37()}   {object_1_1.method_29(false)}", (object) object_1_1);
      if (this.gclass22_0.method_35(GEnum118.const_58))
      {
        GClass55 object_1_2 = this.method_192(AuroraCommandType.ExecutiveOfficer);
        if (object_1_2 != null)
          this.gclass0_0.method_598(listView_4, "Executive Officer", $"{object_1_2.method_36()} {object_1_2.method_37()}   {object_1_2.method_29(false)}", (object) object_1_2);
      }
      if (this.gclass22_0.method_35(GEnum118.const_61))
      {
        GClass55 object_1_3 = this.method_192(AuroraCommandType.ScienceOfficer);
        if (object_1_3 != null)
          this.gclass0_0.method_598(listView_4, "Science Officer", $"{object_1_3.method_36()} {object_1_3.method_37()}   {object_1_3.method_29(false)}", (object) object_1_3);
      }
      if (this.gclass22_0.method_35(GEnum118.const_59))
      {
        GClass55 object_1_4 = this.method_192(AuroraCommandType.ChiefEngineer);
        if (object_1_4 != null)
          this.gclass0_0.method_598(listView_4, "Chief Engineer", $"{object_1_4.method_36()} {object_1_4.method_37()}   {object_1_4.method_29(false)}", (object) object_1_4);
      }
      if (this.gclass22_0.method_35(GEnum118.const_60))
      {
        GClass55 object_1_5 = this.method_192(AuroraCommandType.TacticalOfficer);
        if (object_1_5 != null)
          this.gclass0_0.method_598(listView_4, "Tactical Officer", $"{object_1_5.method_36()} {object_1_5.method_37()}   {object_1_5.method_29(false)}", (object) object_1_5);
      }
      if (this.gclass22_0.method_35(GEnum118.const_62))
      {
        GClass55 object_1_6 = this.method_192(AuroraCommandType.CAG);
        if (object_1_6 != null)
          this.gclass0_0.method_598(listView_4, "Commander Air Group", $"{object_1_6.method_36()} {object_1_6.method_37()}   {object_1_6.method_29(false)}", (object) object_1_6);
      }
      listView_8.Items.Clear();
      List<GClass177> list = this.list_11.OrderByDescending<GClass177, Decimal>((Func<GClass177, Decimal>) (gclass177_0 => gclass177_0.decimal_0)).ToList<GClass177>();
      if (list.Count > 0)
      {
        foreach (GClass177 gclass177 in list)
        {
          string string_10 = this.gclass0_0.method_582((double) gclass177.decimal_0, true);
          this.gclass0_0.method_597(listView_8, string_10, gclass177.Description);
        }
        listView_8.Items[listView_8.Items.Count - 1].EnsureVisible();
      }
      this.gclass22_0.method_65(listView_5, this);
      this.method_89(listView_6, int_42);
      return gclass22.string_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2801);
      return "error";
    }
  }

  public string method_165()
  {
    try
    {
      Decimal num1 = 0M;
      Decimal num2 = 0M;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.decimal_4 > 0M && gclass228_0.gclass230_0.bool_11)).ToList<GClass228>())
      {
        int num3 = this.method_158(gclass228_0);
        num2 += (Decimal) num3 * gclass228_0.gclass230_0.decimal_4;
      }
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.PowerPlant)).ToList<GClass228>())
      {
        int num4 = this.method_158(gclass228_0);
        num1 += (Decimal) num4 * gclass228_0.gclass230_0.decimal_3;
      }
      return num2 == 0M ? "-" : GClass226.smethod_38(num1 / num2 * 100M) + "%";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2802);
      return "error";
    }
  }

  public Decimal method_166()
  {
    try
    {
      this.decimal_34 = this.method_157(AuroraComponentType.Engine, false) * this.decimal_9;
      if (this.decimal_34 == 0M)
        return 0M;
      this.decimal_33 = this.decimal_14 / (this.decimal_34 * this.gclass22_0.decimal_6) * this.method_171(false) * 3600M / 1000000000M;
      return this.decimal_33;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2803);
      return 0M;
    }
  }

  public int method_167(AuroraComponentType auroraComponentType_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class858 class858 = new GClass40.Class858();
    // ISSUE: reference to a compiler-generated field
    class858.auroraComponentType_0 = auroraComponentType_0;
    try
    {
      int num1 = 0;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(class858.method_0)).ToList<GClass228>())
      {
        int num2 = this.method_158(gclass228_0);
        num1 += num2;
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2804);
      return 0;
    }
  }

  public Decimal method_168(AuroraComponentType auroraComponentType_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class859 class859 = new GClass40.Class859();
    // ISSUE: reference to a compiler-generated field
    class859.auroraComponentType_0 = auroraComponentType_0;
    try
    {
      Decimal num = 0M;
      // ISSUE: reference to a compiler-generated method
      this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(class859.method_0)).ToList<GClass228>();
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values)
      {
        if (this.method_158(gclass228_0) > 0 && gclass228_0.gclass230_0.decimal_3 > num)
          num = gclass228_0.gclass230_0.decimal_3;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2805);
      return 0M;
    }
  }

  public Decimal method_169(AuroraComponentType auroraComponentType_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class860 class860 = new GClass40.Class860();
    // ISSUE: reference to a compiler-generated field
    class860.auroraComponentType_0 = auroraComponentType_0;
    try
    {
      Decimal num1 = 0M;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(class860.method_0)).ToList<GClass228>())
      {
        Decimal num2 = (Decimal) this.method_158(gclass228_0);
        num1 += num2 * gclass228_0.gclass230_0.decimal_1;
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2806);
      return 0M;
    }
  }

  public Decimal method_170()
  {
    try
    {
      Decimal num = this.method_157(AuroraComponentType.Engine, false) * this.decimal_9;
      if (num == 0M)
        num = 1M;
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2807);
      return 0M;
    }
  }

  public Decimal method_171(bool bool_22)
  {
    try
    {
      if (this.gclass40_3 != null || this.genum29_0 == GEnum29.const_1 || !this.gclass21_0.bool_0 && this.decimal_14 == 0M)
        return 1M;
      Decimal num1 = this.method_157(AuroraComponentType.Engine, false) * this.decimal_9;
      if (num1 <= 0M)
        return 1M;
      Decimal num2 = this.gclass22_0.decimal_14;
      if (this.gclass40_2 != null)
        num2 = this.gclass22_0.decimal_14 + this.gclass40_2.gclass22_0.decimal_14;
      else if (this.gclass193_0 != null)
        num2 = this.gclass22_0.decimal_14 + this.gclass193_0.decimal_0 / 25M * (Decimal) this.gclass193_0.int_1;
      Decimal num3 = (Decimal) (int) (num1 / num2 * 1000M);
      if (num3 > 270000M)
        num3 = 270000M;
      return num3 < 1M ? 1M : num3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2808);
      return 1M;
    }
  }

  public Decimal method_172()
  {
    try
    {
      Decimal num1 = this.method_157(AuroraComponentType.Engineering, false);
      Decimal num2 = this.method_157(AuroraComponentType.MaintenanceStorage, false);
      if (!(num1 > 0M))
        return num2;
      return Math.Round(Math.Floor(1M / (this.gclass22_0.decimal_14 * GClass226.decimal_21 / num1) * (this.gclass22_0.decimal_4 / 2M) + num2));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2809);
      return 0M;
    }
  }

  public Decimal method_173()
  {
    try
    {
      Decimal num1 = (this.gclass0_0.decimal_0 - this.decimal_6) / GClass226.decimal_29;
      Decimal num2 = this.method_157(AuroraComponentType.Engineering, false);
      return !(num2 == 0M) ? this.gclass22_0.decimal_14 / 2M * (this.gclass22_0.decimal_14 * GClass226.decimal_21 / num2) * num1 : this.gclass22_0.decimal_14 * 10M * num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2810);
      return 0M;
    }
  }

  public bool method_174(Decimal decimal_42, Decimal decimal_43)
  {
    try
    {
      Decimal num1 = this.method_173();
      if (num1 == 0M)
        return false;
      if (this.gclass85_0.gclass83_0.gclass79_0.genum37_0 == GEnum37.const_5)
        num1 *= 2M;
      Decimal num2 = decimal_42 * (num1 * decimal_43) * (2M - this.method_190());
      Decimal num3 = this.gclass85_0.gclass83_0.method_5(this.gclass85_0.gclass202_0.gclass200_0.int_0, GEnum121.const_24);
      Decimal num4 = this.method_123(GEnum121.const_24) * num3;
      this.decimal_26 = num2 * (2M - num4);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2811);
      return false;
    }
  }

  public Decimal method_175(int int_40)
  {
    try
    {
      int num = this.method_167(AuroraComponentType.Shields);
      GClass228 gclass228 = this.gclass22_0.method_77();
      return (Decimal) num * gclass228.gclass230_0.decimal_3 * ((Decimal) int_40 / gclass228.gclass230_0.decimal_4);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2812);
      return 0M;
    }
  }

  public Decimal method_176()
  {
    try
    {
      Decimal num1 = 0M;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values)
      {
        if (gclass228_0.gclass230_0.bool_4)
        {
          int num2 = this.method_158(gclass228_0);
          num1 += (Decimal) num2 * gclass228_0.gclass230_0.decimal_4;
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2813);
      return 0M;
    }
  }

  public Decimal method_177()
  {
    try
    {
      if (this.gclass22_0.bool_2)
        return 0M;
      Decimal num1 = 0M;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values)
      {
        if (gclass228_0.gclass230_0.bool_11 && gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.CIWS && gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.DecoyMissileLauncher)
        {
          int num2 = this.method_158(gclass228_0);
          num1 += (Decimal) num2 * gclass228_0.gclass230_0.decimal_1;
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2814);
      return 0M;
    }
  }

  public double method_178()
  {
    try
    {
      double num = 0.0;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors)).ToList<GClass228>())
      {
        if (this.method_158(gclass228_0) > 0 && gclass228_0.gclass230_0.double_0 > num)
          num = gclass228_0.gclass230_0.double_0;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2815 /*0x0AFF*/);
      return 0.0;
    }
  }

  public void method_179()
  {
    try
    {
      this.list_14.Clear();
      this.int_39 = (int) this.method_152();
      if (this.bool_8)
      {
        foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors)).ToList<GClass228>())
        {
          if (this.list_12.Count <= 0 || this.method_158(gclass228_0) != 0)
          {
            GClass66 gclass66 = new GClass66(this.gclass0_0);
            gclass66.gclass21_0 = this.gclass21_0;
            gclass66.gclass200_0 = this.gclass85_0.gclass202_0.gclass200_0;
            gclass66.double_2 = gclass228_0.gclass230_0.double_0;
            gclass66.int_0 = (int) gclass228_0.gclass230_0.decimal_6;
            gclass66.decimal_0 = (Decimal) (int) gclass228_0.gclass230_0.decimal_3;
            gclass66.double_0 = this.gclass85_0.double_2;
            gclass66.double_1 = this.gclass85_0.double_3;
            gclass66.gclass230_0 = gclass228_0.gclass230_0;
            gclass66.decimal_1 = gclass228_0.gclass230_0.decimal_13;
            this.gclass0_0.list_26.Add(gclass66);
            this.list_14.Add(gclass66);
          }
        }
      }
      else if (this.gclass21_0.bool_0)
      {
        foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors && gclass228_0.gclass230_0.decimal_6 == 1M)).ToList<GClass228>())
        {
          if (this.list_12.Count <= 0 || this.method_158(gclass228_0) != 0)
          {
            GClass66 gclass66 = new GClass66(this.gclass0_0);
            gclass66.gclass21_0 = this.gclass21_0;
            gclass66.gclass200_0 = this.gclass85_0.gclass202_0.gclass200_0;
            gclass66.double_2 = gclass228_0.gclass230_0.double_0;
            gclass66.int_0 = (int) gclass228_0.gclass230_0.decimal_6;
            gclass66.decimal_0 = (Decimal) (int) gclass228_0.gclass230_0.decimal_3;
            gclass66.double_0 = this.gclass85_0.double_2;
            gclass66.double_1 = this.gclass85_0.double_3;
            gclass66.gclass230_0 = gclass228_0.gclass230_0;
            this.gclass0_0.list_26.Add(gclass66);
            this.list_14.Add(gclass66);
          }
        }
      }
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ThermalSensors || gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.EMSensors)).ToList<GClass228>())
      {
        if (this.list_12.Count <= 0 || this.method_158(gclass228_0) != 0)
        {
          GClass67 gclass67 = new GClass67(this.gclass0_0);
          gclass67.gclass21_0 = this.gclass21_0;
          gclass67.gclass200_0 = this.gclass85_0.gclass202_0.gclass200_0;
          gclass67.double_0 = this.gclass85_0.double_2;
          gclass67.double_1 = this.gclass85_0.double_3;
          if (gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ThermalSensors)
          {
            gclass67.double_2 = (double) gclass228_0.gclass230_0.decimal_3;
            this.gclass0_0.list_27.Add(gclass67);
          }
          else
          {
            gclass67.double_3 = (double) gclass228_0.gclass230_0.decimal_3;
            this.gclass0_0.list_28.Add(gclass67);
          }
        }
      }
      if (this.int_39 <= 0)
        return;
      GClass55 gclass55 = this.method_192(AuroraCommandType.Ship);
      this.gclass0_0.list_28.Add(new GClass67(this.gclass0_0)
      {
        gclass21_0 = this.gclass21_0,
        gclass200_0 = this.gclass85_0.gclass202_0.gclass200_0,
        double_0 = this.gclass85_0.double_2,
        double_1 = this.gclass85_0.double_3,
        double_3 = (double) this.int_39
      });
      GClass68 gclass68 = new GClass68(this.gclass0_0);
      gclass68.gclass21_0 = this.gclass21_0;
      gclass68.gclass200_0 = this.gclass85_0.gclass202_0.gclass200_0;
      gclass68.double_0 = this.gclass85_0.double_2;
      gclass68.double_1 = this.gclass85_0.double_3;
      gclass68.double_2 = (double) this.int_39;
      gclass68.decimal_0 = 1M;
      if (gclass55 != null)
        gclass68.decimal_0 = gclass55.method_5(GEnum121.const_19);
      this.gclass0_0.list_29.Add(gclass68);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2816 /*0x0B00*/);
    }
  }

  public Decimal method_180()
  {
    try
    {
      Decimal num = 0M;
      this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.JumpDrive)).ToList<GClass228>();
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values)
      {
        if (this.method_158(gclass228_0) > 0 && (Decimal) gclass228_0.gclass230_0.int_10 > num)
          num = (Decimal) gclass228_0.gclass230_0.int_10;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2817);
      return 0M;
    }
  }

  public Decimal method_181()
  {
    try
    {
      Decimal num1 = this.method_157(AuroraComponentType.Magazine, false);
      Decimal num2 = this.method_157(AuroraComponentType.MissileLauncher, false);
      Decimal num3 = this.method_157(AuroraComponentType.FighterPodBay, false);
      Decimal num4 = num2;
      return num1 + num4 + num3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2818);
      return 0M;
    }
  }

  public Decimal method_182()
  {
    try
    {
      return this.method_157(AuroraComponentType.DecoyMissileLauncher, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3696);
      return 0M;
    }
  }

  public Decimal method_183()
  {
    try
    {
      return this.method_182() + this.method_181();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3700);
      return 0M;
    }
  }

  public Decimal method_184()
  {
    try
    {
      Decimal num1 = this.gclass22_0.decimal_14 / 20M;
      if (this.gclass85_0.dictionary_0.Count == 0)
        return num1;
      GClass228 gclass228 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.Engine)).FirstOrDefault<GClass228>();
      if (gclass228 == null)
        return 0M;
      Decimal num2 = this.gclass22_0.decimal_14;
      if (this.gclass40_2 != null)
        num2 = this.gclass22_0.decimal_14 + this.gclass40_2.gclass22_0.decimal_14;
      else if (this.gclass193_0 != null)
        num2 = this.gclass22_0.decimal_14 + this.gclass193_0.decimal_0 / 25M * (Decimal) this.gclass193_0.int_1;
      Decimal num3 = gclass228.gclass230_0.decimal_3 * gclass228.decimal_0;
      Decimal num4 = num3 * gclass228.gclass230_0.decimal_9 * ((Decimal) this.gclass85_0.int_6 / (Decimal) (int) (num3 / num2 * 1000M));
      if (num4 < num1)
        num4 = num1;
      return num4;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2819);
      return 0M;
    }
  }

  public void method_185(
    GClass85 gclass85_1,
    bool bool_22,
    bool bool_23,
    bool bool_24,
    bool bool_25)
  {
    try
    {
      this.gclass85_0.list_3.Remove(this);
      gclass85_1.method_3(this);
      GClass85 gclass850 = this.gclass85_0;
      this.gclass85_0 = gclass85_1;
      if (bool_25)
        this.gclass70_0 = (GClass70) null;
      foreach (GClass40 gclass40 in this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4.gclass40_0 == this)).ToList<GClass40>())
      {
        gclass850.list_3.Remove(gclass40);
        gclass85_1.method_3(this);
        gclass40.gclass84_0 = this.gclass84_0;
        gclass40.gclass85_0 = this.gclass85_0;
      }
      GClass192 gclass192 = this.gclass0_0.dictionary_32.Values.Where<GClass192>((Func<GClass192, bool>) (gclass192_0 => gclass192_0.gclass40_0 == this)).FirstOrDefault<GClass192>();
      if (gclass192 != null)
      {
        if (!bool_24)
          gclass192.gclass85_0 = gclass85_1;
        else
          this.gclass0_0.dictionary_32.Remove(gclass192.int_0);
      }
      if (this.gclass40_2 != null)
      {
        if (!bool_24)
        {
          if (this.gclass40_2.gclass85_0 != this.gclass85_0)
            this.gclass40_2.method_185(this.gclass85_0, true, bool_23, false, true);
        }
        else
        {
          this.gclass40_2.gclass40_3 = (GClass40) null;
          this.gclass40_2 = (GClass40) null;
        }
      }
      else if (this.gclass40_3 != null && this.gclass40_3.gclass85_0 != this.gclass85_0)
      {
        this.gclass40_3.gclass40_2 = (GClass40) null;
        this.gclass40_3 = (GClass40) null;
      }
      if (bool_22)
      {
        this.gclass85_0.int_6 = this.gclass85_0.method_195();
        gclass850.int_6 = gclass850.method_195();
      }
      if (gclass850.method_179() != 0 || !bool_23)
        return;
      gclass850.gclass21_0.method_302(gclass850, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2820);
    }
  }

  public GClass70 method_186(string string_9)
  {
    try
    {
      GClass70 gclass70 = new GClass70(this.gclass0_0);
      gclass70.int_0 = this.gclass0_0.method_26(GEnum0.const_52);
      gclass70.gclass40_0 = this;
      gclass70.SquadronName = string_9;
      this.dictionary_0.Add(gclass70.int_0, gclass70);
      return gclass70;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3539);
      return (GClass70) null;
    }
  }

  public string method_187()
  {
    try
    {
      if (this.gclass21_0.chkUseHullNumbers == CheckState.Unchecked || this.gclass22_0.int_65 == 0 || this.gclass187_0 != null)
        return $"{this.gclass22_0.gclass76_0.Abbreviation} {this.ShipName}";
      return $"{this.gclass22_0.gclass76_0.Abbreviation}-{GClass226.smethod_32(this.int_20)} {this.ShipName}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2821);
      return "Unknown";
    }
  }

  public string method_188(bool bool_22, bool bool_23)
  {
    try
    {
      string str = "";
      if (this.gclass40_0 != null)
        str = $" ({this.gclass40_0.method_187()})";
      if (!bool_23 || this.gclass21_0.chkUseHullNumbers != CheckState.Checked || this.gclass22_0.int_65 != 1)
        return $"{this.gclass22_0.gclass76_0.Abbreviation} {this.ShipName}{str}";
      return $"{this.gclass22_0.gclass76_0.Abbreviation}-{GClass226.smethod_32(this.int_20)} {this.ShipName}{str}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2822);
      return "Unknown";
    }
  }

  public Decimal method_189() => (Decimal) Math.Round(Math.Sqrt((double) this.decimal_15) - 10.0);

  public Decimal method_190()
  {
    try
    {
      return (Decimal) (1.0 + Math.Round(Math.Sqrt((double) this.decimal_15) - 10.0) / 100.0) * this.decimal_2 * this.decimal_9;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2823);
      return 0M;
    }
  }

  public void method_191()
  {
    try
    {
      if (this.gclass21_0.genum6_0 == GEnum6.const_0 && !(this.gclass22_0.decimal_9 == 0M))
      {
        this.decimal_37 = (this.gclass0_0.decimal_0 - this.decimal_7) / GClass226.decimal_31;
        if (this.decimal_37 > this.gclass22_0.decimal_9 && this.decimal_37 > 0.1M)
        {
          this.decimal_36 = this.decimal_37 / this.gclass22_0.decimal_9;
          Decimal num = this.gclass22_0.decimal_9 / this.decimal_37;
          if ((double) this.int_11 < (double) this.gclass22_0.int_11 / 2.0)
            num *= (Decimal) (this.int_11 / this.gclass22_0.int_11) * 2M;
          if (num < 0.25M)
            num = 0.25M;
          if (this.decimal_2 == 1M)
          {
            string str = "";
            if (this.gclass85_0.method_180() > 1)
              str = $" ({this.gclass85_0.FleetName})";
            this.gclass0_0.gclass92_0.method_2(GEnum126.const_189, $"{this.method_187()}{str} has exceeded its deployment time.", this.gclass21_0, this.gclass85_0.gclass202_0.gclass200_0, this.gclass85_0.double_2, this.gclass85_0.double_3, AuroraEventCategory.Ship);
          }
          this.decimal_2 = num;
        }
        else
          this.decimal_2 = 1M;
      }
      else
        this.decimal_2 = 1M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2824);
    }
  }

  public GClass55 method_192(AuroraCommandType auroraCommandType_0)
  {
    try
    {
      return this.dictionary_1.ContainsKey(auroraCommandType_0) ? this.dictionary_1[auroraCommandType_0] : (GClass55) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2825);
      return (GClass55) null;
    }
  }

  public List<GClass55> method_193()
  {
    try
    {
      return this.gclass0_0.dictionary_0.Values.Where<GClass83>((Func<GClass83, bool>) (gclass83_0 => gclass83_0.gclass40_0 == this)).Select<GClass83, GClass55>((Func<GClass83, GClass55>) (gclass83_0 => gclass83_0.gclass55_0)).ToList<GClass55>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3929);
      return (List<GClass55>) null;
    }
  }

  public List<GClass83> method_194()
  {
    try
    {
      return this.gclass0_0.dictionary_0.Values.Where<GClass83>((Func<GClass83, bool>) (gclass83_0 => gclass83_0.gclass40_0 == this)).ToList<GClass83>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3930);
      return (List<GClass83>) null;
    }
  }

  public List<GClass103> method_195()
  {
    return this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).ToList<GClass103>();
  }

  public int method_196()
  {
    try
    {
      return this.gclass0_0.dictionary_71.Values.Count<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2826);
      return 0;
    }
  }

  public List<GClass65> method_197()
  {
    try
    {
      return this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.int_1 == this.int_8)).ToList<GClass65>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2827);
      return (List<GClass65>) null;
    }
  }

  public List<GClass55> method_198()
  {
    try
    {
      return this.gclass0_0.dictionary_42.Values.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0.gclass40_0 == this)).ToList<GClass55>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2828);
      return (List<GClass55>) null;
    }
  }

  public void method_199(GClass22 gclass22_1, GClass146 gclass146_0)
  {
    try
    {
      this.dictionary_5.Clear();
      this.list_12.Clear();
      this.list_4.Clear();
      this.list_2.Clear();
      this.list_6.Clear();
      this.list_5.Clear();
      GClass22 gclass220 = this.gclass22_0;
      this.gclass22_0 = gclass22_1;
      ++this.gclass22_0.int_55;
      if (this.gclass21_0.genum6_0 != GEnum6.const_2)
      {
        this.decimal_3 = 0M;
        this.bool_10 = false;
        this.int_11 = this.gclass22_0.int_11;
        gclass146_0.method_148(this);
        if (this.decimal_14 < (Decimal) this.gclass22_0.int_63)
        {
          this.decimal_14 += gclass146_0.method_170((Decimal) this.gclass22_0.int_63 - this.decimal_14);
        }
        else
        {
          gclass146_0.decimal_3 += this.decimal_14 - (Decimal) this.gclass22_0.int_63;
          this.decimal_14 = (Decimal) this.gclass22_0.int_63;
        }
        if (this.decimal_4 < (Decimal) this.gclass22_0.int_50)
        {
          this.decimal_4 += gclass146_0.method_171((Decimal) this.gclass22_0.int_50 - this.decimal_4);
        }
        else
        {
          gclass146_0.decimal_0 += this.decimal_4 - (Decimal) this.gclass22_0.int_50;
          this.decimal_4 = (Decimal) this.gclass22_0.int_50;
        }
        if (this.gclass22_0.decimal_11 < gclass220.decimal_11)
        {
          if (this.gclass22_0.decimal_11 == 0M)
          {
            this.list_10.Clear();
          }
          else
          {
            Decimal num1 = this.method_70();
            if (num1 < 0M)
            {
              Decimal num2 = this.gclass22_0.decimal_11 / (Math.Abs(num1) + this.gclass22_0.decimal_11);
              foreach (GClass130 gclass130 in this.list_10.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 0)).ToList<GClass130>())
              {
                int num3 = (int) Math.Floor((Decimal) gclass130.int_0 * num2);
                if (num3 != gclass130.int_0)
                {
                  gclass146_0.method_149(gclass130.gclass129_0, gclass130.int_0 - num3);
                  gclass130.int_0 = num3;
                }
              }
            }
          }
        }
      }
      foreach (GClass117 gclass117 in this.gclass0_0.dictionary_36.Values.SelectMany<GClass21, GClass117>((Func<GClass21, IEnumerable<GClass117>>) (gclass21_0 => (IEnumerable<GClass117>) gclass21_0.dictionary_12.Values)).Where<GClass117>((Func<GClass117, bool>) (gclass117_0 => gclass117_0.gclass40_0 == this)).ToList<GClass117>())
        gclass117.gclass21_1.dictionary_12.Remove(gclass117.gclass40_0.int_8);
      this.gclass85_0.int_6 = this.gclass85_0.method_195();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2829);
    }
  }

  public void method_200(GClass146 gclass146_0)
  {
    try
    {
      foreach (GClass228 gclass228 in this.gclass22_0.dictionary_0.Values)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class873 class873 = new GClass40.Class873();
        // ISSUE: reference to a compiler-generated field
        class873.gclass228_0 = gclass228;
        // ISSUE: reference to a compiler-generated field
        if (!class873.gclass228_0.gclass230_0.bool_0)
        {
          // ISSUE: reference to a compiler-generated method
          GClass178 gclass178 = this.list_12.Where<GClass178>(new Func<GClass178, bool>(class873.method_0)).FirstOrDefault<GClass178>();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          int decimal_90 = gclass178 != null ? (int) class873.gclass228_0.decimal_0 - gclass178.int_0 : (int) class873.gclass228_0.decimal_0;
          if (decimal_90 > 0)
          {
            // ISSUE: reference to a compiler-generated field
            gclass146_0.method_67(class873.gclass228_0.gclass230_0, (Decimal) decimal_90);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2830);
    }
  }

  public void method_201()
  {
    try
    {
      List<GClass40> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4.gclass40_0 == this)).ToList<GClass40>();
      if (list.Count == 0)
        return;
      string str = this.ShipName + " Parasites";
      foreach (GClass40 gclass40 in list)
        gclass40.gclass40_0 = (GClass40) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3372);
    }
  }

  public void method_202(GClass146 gclass146_0)
  {
    try
    {
      foreach (GClass130 gclass130 in this.list_10)
        gclass146_0.method_149(gclass130.gclass129_0, gclass130.int_0);
      this.list_10.Clear();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2831);
    }
  }

  public int method_203(bool bool_22)
  {
    try
    {
      List<GClass55> gclass55List = this.method_198();
      foreach (GClass55 gclass55 in this.method_193())
        gclass55List.Add(gclass55);
      GClass55 gclass55_1 = this.method_192(AuroraCommandType.Ship);
      if (gclass55_1 != null)
        gclass55List.Add(gclass55_1);
      GClass55 gclass55_2 = this.method_192(AuroraCommandType.ExecutiveOfficer);
      if (gclass55_2 != null)
        gclass55List.Add(gclass55_2);
      GClass55 gclass55_3 = this.method_192(AuroraCommandType.ChiefEngineer);
      if (gclass55_3 != null)
        gclass55List.Add(gclass55_3);
      GClass55 gclass55_4 = this.method_192(AuroraCommandType.ScienceOfficer);
      if (gclass55_4 != null)
        gclass55List.Add(gclass55_4);
      GClass55 gclass55_5 = this.method_192(AuroraCommandType.TacticalOfficer);
      if (gclass55_5 != null)
        gclass55List.Add(gclass55_5);
      GClass55 gclass55_6 = this.method_192(AuroraCommandType.CAG);
      if (gclass55_6 != null)
        gclass55List.Add(gclass55_6);
      GClass146 gclass146 = this.gclass0_0.method_569(this.gclass21_0, this.gclass85_0.double_2, this.gclass85_0.double_3);
      if (bool_22 && this.decimal_15 > (Decimal) GClass226.int_26)
        this.gclass21_0.decimal_8 += (Decimal) (int) ((Decimal) this.int_11 * this.decimal_15 / (Decimal) (GClass226.int_26 * this.gclass21_0.int_30));
      foreach (GClass55 gclass55_7 in gclass55List)
      {
        gclass55_7.method_40(true);
        gclass55_7.gclass40_0 = (GClass40) null;
        if (gclass146 != null)
          gclass55_7.gclass146_0 = gclass146;
      }
      return gclass55List.Count;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2832);
      return 0;
    }
  }

  public void method_204(string string_9)
  {
    try
    {
      this.list_11.Add(new GClass177()
      {
        decimal_0 = this.gclass0_0.decimal_0,
        Description = string_9
      });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3669);
    }
  }

  public List<GClass40> method_205()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_4 => gclass40_4.gclass40_0 == this)).ToList<GClass40>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2835);
      return (List<GClass40>) null;
    }
  }

  public Decimal method_206()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass178 gclass178 in this.list_12)
        num += gclass178.gclass230_0.decimal_2 * (Decimal) gclass178.int_0;
      GClass230 gclass2300 = this.gclass22_0.method_76().gclass230_0;
      return num + gclass2300.decimal_2 * ((Decimal) this.dictionary_5.Values.Sum<int>((Func<int, int>) (int_0 => int_0)) / gclass2300.decimal_3);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2833);
      return 0M;
    }
  }

  public GClass123 method_207()
  {
    try
    {
      GClass123 gclass123 = new GClass123(this.gclass0_0);
      foreach (GClass178 gclass178 in this.list_12)
        gclass123.method_11(gclass178.gclass230_0.gclass123_0, GClass226.decimal_6);
      GClass230 gclass2300 = this.gclass22_0.method_76().gclass230_0;
      Decimal num = (Decimal) this.dictionary_5.Values.Sum<int>((Func<int, int>) (int_0 => int_0)) / gclass2300.decimal_3;
      gclass123.method_11(gclass2300.gclass123_0, GClass226.decimal_6 * num);
      return gclass123;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2834);
      return (GClass123) null;
    }
  }

  public Decimal method_208()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass130 gclass130 in this.list_10.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 0)).ToList<GClass130>())
        num += gclass130.gclass129_0.decimal_4 * (Decimal) gclass130.int_0;
      return this.method_181() - num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2836);
      return 0M;
    }
  }

  public Decimal method_209()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass130 gclass130 in this.list_10.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 1)).ToList<GClass130>())
        num += gclass130.gclass129_0.decimal_4 * (Decimal) gclass130.int_0;
      return this.method_182() - num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3697);
      return 0M;
    }
  }

  public Decimal method_210()
  {
    try
    {
      return this.method_209() + this.method_208();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3699);
      return 0M;
    }
  }

  public int method_211()
  {
    try
    {
      int num = (int) this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => gclass103_1.gclass40_0 == this)).Sum<GClass103>((Func<GClass103, Decimal>) (gclass103_0 => gclass103_0.method_34()));
      return (int) this.method_157(AuroraComponentType.TroopTransport, false) - num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2837);
      return 0;
    }
  }

  public Decimal method_212()
  {
    try
    {
      Decimal num1 = 0M;
      Decimal num2 = this.method_183();
      if (num2 == 0M)
        return 0M;
      foreach (GClass130 gclass130 in this.list_10)
        num1 += gclass130.gclass129_0.decimal_4 * (Decimal) gclass130.int_0;
      return num1 / num2 * 100M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2838);
      return 0M;
    }
  }

  public GClass71 method_213(Decimal decimal_42, GClass36 gclass36_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class874 class874 = new GClass40.Class874();
    // ISSUE: reference to a compiler-generated field
    class874.gclass36_0 = gclass36_0;
    try
    {
      GClass71 gclass71 = new GClass71();
      gclass71.double_0 = 0.0;
      gclass71.int_0 = 0;
      gclass71.decimal_0 = 0M;
      gclass71.int_2 = 0;
      List<GClass228> list1 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileLauncher)).OrderByDescending<GClass228, Decimal>((Func<GClass228, Decimal>) (gclass228_0 => gclass228_0.gclass230_0.decimal_3)).ToList<GClass228>();
      // ISSUE: reference to a compiler-generated field
      if (class874.gclass36_0 != null)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass40.Class875 class875 = new GClass40.Class875();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class875.list_0 = this.list_2.Where<GClass31>(new Func<GClass31, bool>(class874.method_0)).Select<GClass31, GClass230>((Func<GClass31, GClass230>) (gclass31_0 => gclass31_0.gclass230_0)).ToList<GClass230>();
        // ISSUE: reference to a compiler-generated field
        if (class875.list_0.Count == 0)
          return gclass71;
        // ISSUE: reference to a compiler-generated method
        list1 = list1.Where<GClass228>(new Func<GClass228, bool>(class875.method_0)).ToList<GClass228>();
      }
      foreach (GClass228 gclass228_0 in list1)
      {
        gclass71.int_0 = this.method_158(gclass228_0);
        if (gclass71.int_0 > 0)
        {
          gclass71.decimal_0 = gclass228_0.gclass230_0.decimal_3;
          break;
        }
      }
      if (gclass71.decimal_0 == 0M)
      {
        gclass71.int_0 = 0;
        return gclass71;
      }
      if (this.list_10.Count == 0)
      {
        gclass71.int_0 = 0;
        return gclass71;
      }
      List<GClass130> list2 = this.list_10.Where<GClass130>((Func<GClass130, bool>) (gclass130_0 => gclass130_0.gclass129_0.int_14 == 0)).ToList<GClass130>();
      if (list2.Count == 0)
        return gclass71;
      foreach (GClass130 gclass130 in list2)
      {
        gclass71.int_1 += gclass130.int_0;
        if (gclass130.gclass129_0.double_4 > gclass71.double_0 && gclass130.gclass129_0.decimal_4 <= gclass71.decimal_0)
          gclass71.double_0 = gclass130.gclass129_0.double_4;
        if (gclass130.gclass129_0.decimal_5 > (Decimal) gclass71.int_2 && gclass130.gclass129_0.decimal_4 <= gclass71.decimal_0)
        {
          gclass71.gclass129_0 = gclass130.gclass129_0;
          gclass71.int_2 = (int) gclass130.gclass129_0.decimal_5;
        }
      }
      if (gclass71.double_0 == 0.0)
        return gclass71;
      double num = this.method_215(decimal_42);
      if (num < gclass71.double_0)
        gclass71.double_0 = num;
      return gclass71;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2839);
      return (GClass71) null;
    }
  }

  public GClass72 method_214()
  {
    try
    {
      GClass72 gclass72 = new GClass72();
      if (this.dictionary_0.Count == 0)
        return gclass72;
      List<GClass40> gclass40List = this.dictionary_0[0].method_0();
      gclass72.int_0 = gclass40List.Count;
      foreach (GClass40 gclass40 in gclass40List)
      {
        if ((gclass40.gclass22_0.list_0.Count <= 0 || gclass40.list_10.Count != 0) && gclass40.list_12.Count != 0)
        {
          if (gclass40.list_7.Count > 0)
            gclass72.list_1.Add(gclass40);
          else
            gclass72.list_0.Add(gclass40);
        }
      }
      gclass72.decimal_0 = gclass72.list_0.Min<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_166())) / 2.5M;
      gclass72.decimal_1 = gclass72.list_0.Min<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_171(false)));
      List<GClass130> list = gclass72.list_0.SelectMany<GClass40, GClass130>((Func<GClass40, IEnumerable<GClass130>>) (gclass40_0 => (IEnumerable<GClass130>) gclass40_0.list_10)).ToList<GClass130>();
      if (list.Count > 0)
        gclass72.int_1 = list.Sum<GClass130>((Func<GClass130, int>) (gclass130_0 => gclass130_0.int_0));
      return gclass72;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3857);
      return (GClass72) null;
    }
  }

  public double method_215(Decimal decimal_42)
  {
    try
    {
      double num1 = 0.0;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl)).ToList<GClass228>())
      {
        if (this.method_158(gclass228_0) != 0)
        {
          if (decimal_42 > 0M)
          {
            double num2 = gclass228_0.gclass230_0.method_15(decimal_42);
            if (num2 > num1)
              num1 = num2;
          }
          else
            num1 = gclass228_0.gclass230_0.double_0;
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2840);
      return 0.0;
    }
  }

  public double method_216(Decimal decimal_42)
  {
    try
    {
      double num1 = 0.0;
      foreach (GClass228 gclass228_0 in this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors)).ToList<GClass228>())
      {
        if (this.method_158(gclass228_0) != 0 && decimal_42 > 0M)
        {
          double num2 = gclass228_0.gclass230_0.method_15(decimal_42);
          if (num2 > num1)
            num1 = num2;
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2841);
      return 0.0;
    }
  }

  public double method_217()
  {
    try
    {
      GClass228 gclass228 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors)).Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => this.method_158(gclass228_0) > 0)).OrderByDescending<GClass228, double>((Func<GClass228, double>) (gclass228_0 => gclass228_0.gclass230_0.double_0)).FirstOrDefault<GClass228>();
      return gclass228 == null ? 0.0 : gclass228.gclass230_0.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2842);
      return 0.0;
    }
  }

  public double method_218(Decimal decimal_42)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class879 class879 = new GClass40.Class879();
    // ISSUE: reference to a compiler-generated field
    class879.decimal_0 = decimal_42;
    // ISSUE: reference to a compiler-generated field
    class879.gclass40_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      GClass228 gclass228 = this.gclass22_0.dictionary_0.Values.Where<GClass228>(new Func<GClass228, bool>(class879.method_0)).Where<GClass228>(new Func<GClass228, bool>(class879.method_1)).OrderByDescending<GClass228, double>((Func<GClass228, double>) (gclass228_0 => gclass228_0.gclass230_0.double_0)).FirstOrDefault<GClass228>();
      return gclass228 == null ? 0.0 : gclass228.gclass230_0.double_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2843);
      return 0.0;
    }
  }

  public double method_219()
  {
    try
    {
      List<GClass228> list = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl)).ToList<GClass228>();
      if (list.Count == 0)
        return 0.0;
      double num = 0.0;
      foreach (GClass228 gclass228_0 in list)
      {
        if (this.method_158(gclass228_0) > 0)
        {
          double decimal3 = (double) gclass228_0.gclass230_0.decimal_3;
          if (decimal3 > num)
            num = decimal3;
        }
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2844);
      return 0.0;
    }
  }

  public double method_220()
  {
    try
    {
      List<GClass228> list1 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl)).ToList<GClass228>();
      if (list1.Count == 0)
        return 0.0;
      double num1 = 0.0;
      foreach (GClass228 gclass228_0 in list1)
      {
        if (this.method_158(gclass228_0) > 0)
        {
          double decimal3 = (double) gclass228_0.gclass230_0.decimal_3;
          if (decimal3 > num1)
            num1 = decimal3;
        }
      }
      if (num1 == 0.0)
        return 0.0;
      double num2 = 0.0;
      List<GClass228> list2 = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.bool_4)).ToList<GClass228>();
      if (list2.Count == 0)
        return 0.0;
      foreach (GClass228 gclass228_0 in list2)
      {
        if (this.method_158(gclass228_0) > 0)
        {
          int num3 = gclass228_0.gclass230_0.int_8;
          if (gclass228_0.gclass230_0.int_8 == 0)
            num3 = (int) ((Decimal) gclass228_0.gclass230_0.int_6 * gclass228_0.gclass230_0.decimal_17);
          if ((double) num3 > num2)
            num2 = (double) num3;
        }
      }
      if (num2 > num1)
        num2 = num1;
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2845);
      return 0.0;
    }
  }

  public double method_221(GClass36 gclass36_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class880 class880 = new GClass40.Class880();
    // ISSUE: reference to a compiler-generated field
    class880.gclass36_0 = gclass36_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass40.Class881 class881 = new GClass40.Class881();
      double num1 = 0.0;
      // ISSUE: reference to a compiler-generated method
      GClass228 gclass228_0_1 = this.gclass22_0.dictionary_0.Values.FirstOrDefault<GClass228>(new Func<GClass228, bool>(class880.method_0));
      if (gclass228_0_1 == null || this.method_158(gclass228_0_1) == 0)
        return 0.0;
      double decimal3 = (double) gclass228_0_1.gclass230_0.decimal_3;
      if (decimal3 == 0.0)
        return 0.0;
      List<GClass228> list = this.gclass22_0.dictionary_0.Values.Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.bool_4)).ToList<GClass228>();
      if (list.Count == 0)
        return 0.0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class881.list_0 = this.list_2.Where<GClass31>(new Func<GClass31, bool>(class880.method_1)).Select<GClass31, GClass230>((Func<GClass31, GClass230>) (gclass31_0 => gclass31_0.gclass230_0)).ToList<GClass230>();
      // ISSUE: reference to a compiler-generated field
      if (class881.list_0.Count == 0)
        return 0.0;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass228 gclass228 in list.Where<GClass228>(new Func<GClass228, bool>(class881.method_0)).ToList<GClass228>())
      {
        double num2 = (double) gclass228.gclass230_0.int_8;
        if (gclass228.gclass230_0.int_8 == 0)
          num2 = (double) (int) ((Decimal) gclass228.gclass230_0.int_6 * gclass228.gclass230_0.decimal_17);
        if (num2 != 0.0 && num2 > num1)
          num1 = num2;
      }
      if (num1 > decimal3)
        num1 = decimal3;
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3372);
      return 0.0;
    }
  }

  public Decimal method_222(GClass21 gclass21_1, GEnum10 genum10_0)
  {
    try
    {
      foreach (GClass65 gclass65 in this.method_197())
      {
        if (gclass65.gclass21_1 == gclass21_1 && this.gclass0_0.decimal_0 == gclass65.decimal_3 && gclass65.genum10_0 == genum10_0)
          return gclass65.decimal_0;
      }
      return 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2846);
      return 0M;
    }
  }

  public GClass221 method_223(GClass21 gclass21_1)
  {
    try
    {
      GClass221 gclass221 = new GClass221();
      foreach (GClass65 gclass65 in this.method_197())
      {
        if (gclass65.gclass21_1 == gclass21_1 && this.gclass0_0.decimal_0 == gclass65.decimal_3)
        {
          gclass221.double_0 = gclass65.double_4;
          gclass221.double_1 = gclass65.double_5;
          break;
        }
      }
      return gclass221;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2847);
      return (GClass221) null;
    }
  }

  public bool method_224(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0,
    int int_40,
    CheckState checkState_0,
    int int_41)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class882 class882 = new GClass40.Class882();
    // ISSUE: reference to a compiler-generated field
    class882.gclass40_0 = this;
    // ISSUE: reference to a compiler-generated field
    class882.gclass202_0 = gclass202_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (!class882.gclass202_0.gclass21_0.dictionary_10.ContainsKey(this.gclass21_0.RaceID))
        return false;
      // ISSUE: reference to a compiler-generated field
      AuroraContactStatus auroraContactStatus0 = class882.gclass202_0.gclass21_0.dictionary_10[this.gclass21_0.RaceID].auroraContactStatus_0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (!class882.gclass202_0.gclass21_0.method_319(auroraContactStatus0) || this.method_222(class882.gclass202_0.gclass21_0, GEnum10.const_0) == 0M && class882.gclass202_0.gclass21_0.chkActiveOnly == CheckState.Checked)
        return false;
      // ISSUE: reference to a compiler-generated field
      string str1 = this.method_226(class882.gclass202_0.gclass21_0, false, int_41);
      // ISSUE: reference to a compiler-generated field
      string string0 = class882.gclass202_0.gclass21_0.dictionary_10[this.gclass21_0.RaceID].string_0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class882.gclass202_0.gclass21_0.chkShowDist == CheckState.Checked && (class882.gclass202_0.gclass221_0.double_0 != 0.0 || class882.gclass202_0.gclass221_0.double_1 != 0.0))
      {
        double num;
        if (this.genum79_0 == GEnum79.const_2)
        {
          // ISSUE: reference to a compiler-generated method
          GClass65 gclass65 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class882.method_0)).OrderByDescending<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_3)).FirstOrDefault<GClass65>();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          num = this.gclass0_0.method_28(class882.gclass202_0.gclass221_0.double_0, class882.gclass202_0.gclass221_0.double_1, gclass65.double_0, gclass65.double_1);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          num = this.gclass0_0.method_28(class882.gclass202_0.gclass221_0.double_0, class882.gclass202_0.gclass221_0.double_1, this.gclass85_0.double_2, this.gclass85_0.double_3);
        }
        str1 = $"{str1}  {GClass226.smethod_50(num / 1000000.0)}m";
      }
      string s = $"[{string0}]  {str1}";
      if (this.genum79_0 == GEnum79.const_2)
        s += "   [LOST]";
      else if (this.genum79_0 == GEnum79.const_1)
        s += "   [PARTIAL]";
      SolidBrush solidBrush = new SolidBrush(GClass226.color_6);
      Pen pen = new Pen(GClass226.color_6);
      solidBrush.Color = GClass226.smethod_81(auroraContactStatus0);
      pen.Color = solidBrush.Color;
      double x = gclass222_0.double_2 - (double) (GClass226.int_61 / 2);
      double y = gclass222_0.double_3 - (double) (GClass226.int_61 / 2);
      // ISSUE: reference to a compiler-generated field
      GClass221 gclass221_1 = this.method_223(class882.gclass202_0.gclass21_0);
      if (gclass221_1.double_0 != 0.0 || gclass221_1.double_1 != 0.0)
      {
        GClass221 gclass221_2 = new GClass221();
        // ISSUE: reference to a compiler-generated field
        GClass221 gclass221_3 = class882.gclass202_0.method_47(gclass221_1.double_0, gclass221_1.double_1);
        graphics_0.DrawLine(pen, (float) gclass222_0.double_2, (float) gclass222_0.double_3, (float) gclass221_3.double_0, (float) gclass221_3.double_1);
      }
      if (int_40 == 0)
        graphics_0.FillEllipse((Brush) solidBrush, (float) x, (float) y, (float) GClass226.int_61, (float) GClass226.int_61);
      GClass221 gclass221_4 = new GClass221();
      gclass221_4.double_0 = x + (double) GClass226.int_61 + 5.0;
      gclass221_4.double_1 = y - 3.0 - (double) (int_40 * 15);
      graphics_0.DrawString(s, font_0, (Brush) solidBrush, (float) gclass221_4.double_0, (float) gclass221_4.double_1);
      if (checkState_0 == CheckState.Checked)
      {
        // ISSUE: reference to a compiler-generated field
        this.gclass0_0.method_557(class882.gclass202_0.gclass21_0, GEnum10.const_2, AuroraContactType.Ship, this.int_8, int_41);
        // ISSUE: reference to a compiler-generated field
        GClass117 gclass117 = class882.gclass202_0.gclass21_0.method_267(this);
        if (gclass117 != null)
        {
          List<GClass118> list = gclass117.gclass115_0.list_0.Where<GClass118>((Func<GClass118, bool>) (gclass118_0 => gclass118_0.double_1 >= 100.0)).ToList<GClass118>();
          pen.DashStyle = DashStyle.Dash;
          pen.DashPattern = new float[2]{ 15f, 5f };
          pen.Color = Color.Red;
          solidBrush.Color = Color.Red;
          foreach (GClass118 gclass118 in list)
          {
            if (gclass118.method_0(gclass117.gclass40_0.gclass85_0.double_2, gclass117.gclass40_0.gclass85_0.double_3))
            {
              // ISSUE: reference to a compiler-generated field
              double key = gclass118.double_0 / class882.gclass202_0.double_2;
              if (key >= 1.0)
              {
                graphics_0.DrawEllipse(pen, (float) (gclass222_0.double_2 - key), (float) (gclass222_0.double_3 - key), (float) key * 2f, (float) key * 2f);
                string str2 = gclass118.double_0 <= 10000000.0 ? GClass226.smethod_44(gclass118.double_0 / 1000000.0, 1) : GClass226.smethod_44(gclass118.double_0 / 1000000.0, 0);
                string str3 = $"{gclass118.string_0}  {str2}m  R{gclass118.int_1.ToString()}";
                float num = graphics_0.MeasureString(str3, font_0).Width / 2f;
                if (gclass222_0.dictionary_0.ContainsKey(key))
                  gclass222_0.dictionary_0[key]++;
                else
                  gclass222_0.dictionary_0.Add(key, 1);
                graphics_0.DrawString(str3, font_0, (Brush) solidBrush, (float) gclass222_0.double_2 - num, (float) (gclass222_0.double_3 - key - 5.0) - (float) (15 * gclass222_0.dictionary_0[key]));
              }
            }
          }
        }
      }
      this.string_1 = s;
      // ISSUE: reference to a compiler-generated field
      class882.gclass202_0.list_1.Add(this);
      pen.Dispose();
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2848);
      return false;
    }
  }

  public string method_225(GClass202 gclass202_0, int int_40)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass40.Class883 class883 = new GClass40.Class883();
    // ISSUE: reference to a compiler-generated field
    class883.gclass40_0 = this;
    // ISSUE: reference to a compiler-generated field
    class883.gclass202_0 = gclass202_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (!class883.gclass202_0.gclass21_0.dictionary_10.ContainsKey(this.gclass21_0.RaceID))
        return "";
      // ISSUE: reference to a compiler-generated field
      AuroraContactStatus auroraContactStatus0 = class883.gclass202_0.gclass21_0.dictionary_10[this.gclass21_0.RaceID].auroraContactStatus_0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (!class883.gclass202_0.gclass21_0.method_319(auroraContactStatus0) || this.method_222(class883.gclass202_0.gclass21_0, GEnum10.const_0) == 0M && class883.gclass202_0.gclass21_0.chkActiveOnly == CheckState.Checked)
        return "";
      // ISSUE: reference to a compiler-generated field
      string str1 = this.method_226(class883.gclass202_0.gclass21_0, true, int_40);
      // ISSUE: reference to a compiler-generated field
      string string0 = class883.gclass202_0.gclass21_0.dictionary_10[this.gclass21_0.RaceID].string_0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class883.gclass202_0.gclass21_0.chkShowDist == CheckState.Checked && (class883.gclass202_0.gclass221_0.double_0 != 0.0 || class883.gclass202_0.gclass221_0.double_1 != 0.0))
      {
        double num;
        if (this.genum79_0 == GEnum79.const_2)
        {
          // ISSUE: reference to a compiler-generated method
          GClass65 gclass65 = this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class883.method_0)).OrderByDescending<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_3)).FirstOrDefault<GClass65>();
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          num = this.gclass0_0.method_28(class883.gclass202_0.gclass221_0.double_0, class883.gclass202_0.gclass221_0.double_1, gclass65.double_0, gclass65.double_1);
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          num = this.gclass0_0.method_28(class883.gclass202_0.gclass221_0.double_0, class883.gclass202_0.gclass221_0.double_1, this.gclass85_0.double_2, this.gclass85_0.double_3);
        }
        str1 = $"{str1}  {GClass226.smethod_50(num / 1000000.0)}m";
      }
      string str2 = $"[{string0}]  {str1}";
      if (this.genum79_0 == GEnum79.const_2)
        str2 += "   [LOST]";
      else if (this.genum79_0 == GEnum79.const_1)
        str2 += "   [PARTIAL]";
      return str2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2849);
      return "";
    }
  }

  public string method_226(GClass21 gclass21_1, bool bool_22, int int_40)
  {
    try
    {
      int num1 = 0;
      int num2 = 0;
      this.int_25 = 0;
      GClass117 gclass117 = gclass21_1.method_267(this);
      if (gclass117 == null)
        return "Unknown Ship";
      string str1 = gclass117.method_11();
      if (bool_22)
        str1 = gclass21_1.method_33(this);
      GClass65 gclass65_1 = this.gclass0_0.method_556(gclass21_1, GEnum10.const_0, AuroraContactType.Ship, this.int_8, int_40);
      if (gclass65_1 != null && gclass65_1.decimal_0 > 0M)
      {
        string str2 = "";
        if (gclass65_1.gclass21_0 != null && gclass65_1.gclass21_0.bool_6)
          str2 = " BIO ";
        str1 = $"{str1}  {str2}{GClass226.smethod_38(gclass65_1.decimal_0 * GClass226.decimal_17)} tons";
        this.int_25 = gclass65_1.int_0;
        if (gclass65_1.decimal_3 == this.gclass0_0.decimal_0)
          ++num1;
        else
          ++num2;
      }
      GClass65 gclass65_2 = this.gclass0_0.method_556(gclass21_1, GEnum10.const_1, AuroraContactType.Ship, this.int_8, int_40);
      if (gclass65_2 != null)
      {
        string str3 = gclass117.gclass115_0.method_4();
        if (gclass65_2.decimal_0 > 0M)
          str1 = $"{str1}   Thermal {str3}{GClass226.smethod_38(gclass65_2.decimal_0)}";
        if (this.int_25 == 0)
          this.int_25 = gclass65_2.int_0;
        if (gclass65_2.decimal_3 == this.gclass0_0.decimal_0)
          ++num1;
        else
          ++num2;
      }
      GClass65 gclass65_3 = this.gclass0_0.method_556(gclass21_1, GEnum10.const_3, AuroraContactType.Ship, this.int_8, int_40);
      if (gclass65_3 != null)
      {
        if (gclass65_3.decimal_0 > 0M)
          str1 = $"{str1}   Shields {GClass226.smethod_38(gclass65_3.decimal_0 / GClass226.decimal_27)}";
        if (this.int_25 == 0)
          this.int_25 = gclass65_3.int_0;
        if (gclass65_3.decimal_3 == this.gclass0_0.decimal_0)
          ++num1;
        else
          ++num2;
      }
      List<GClass65> gclass65List = this.gclass0_0.method_557(gclass21_1, GEnum10.const_2, AuroraContactType.Ship, this.int_8, int_40);
      if (gclass65List.Count > 0)
      {
        foreach (GClass65 gclass65_4 in gclass65List)
        {
          GClass118 gclass118 = gclass21_1.method_39(gclass65_4.decimal_0, gclass65_4.int_3, this.gclass22_0);
          if (gclass118 != null)
          {
            if (gclass65_4.decimal_0 > 0M)
              str1 = $"{str1}   {gclass118.method_3()}";
            if (this.int_25 == 0)
              this.int_25 = gclass65_4.int_0;
            if (gclass65_4.decimal_3 == this.gclass0_0.decimal_0)
              ++num1;
            else
              ++num2;
          }
        }
      }
      GClass65 gclass65_5 = this.gclass0_0.method_556(gclass21_1, GEnum10.const_4, AuroraContactType.Ship, this.int_8, int_40);
      if (gclass65_5 != null)
      {
        if (gclass65_5.decimal_0 > 0M)
          str1 += "   (TP) ";
        if (this.int_25 == 0)
          this.int_25 = gclass65_5.int_0;
        if (gclass65_5.decimal_3 == this.gclass0_0.decimal_0)
          ++num1;
        else
          ++num2;
      }
      this.genum79_0 = GEnum79.const_0;
      if (num2 > 0)
        this.genum79_0 = num1 != 0 ? GEnum79.const_1 : GEnum79.const_2;
      string str4 = $"{str1}   {GClass226.smethod_39((Decimal) this.method_74())} km/s";
      this.string_2 = str4;
      return str4;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2850);
      return "Error";
    }
  }
}
