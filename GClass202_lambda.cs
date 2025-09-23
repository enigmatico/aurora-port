
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aurora;

public partial class GClass202
{
    
  [CompilerGenerated]
  private bool method_48(GClass120 gclass120_0)
  {
    return gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_4 == 0 && gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_1 == 1;
  }

  [CompilerGenerated]
  private bool method_49(GClass146 gclass146_0)
  {
    return gclass146_0.gclass202_0 == this;
  }

  [CompilerGenerated]
  private bool method_50(GClass110 gclass110_1)
  {
    return gclass110_1.gclass21_0 == this.gclass110_0.gclass21_0;
  }

  [CompilerGenerated]
  private bool method_51(GClass146 gclass146_0)
  {
    return gclass146_0.gclass202_0 == this;
  }

  [CompilerGenerated]
  private bool method_52(GClass146 gclass146_0)
  {
    if (gclass146_0.gclass202_0 != this)
      return false;
    return gclass146_0.decimal_4 > 0.01M || gclass146_0.dictionary_0.Count > 0;
  }

  [CompilerGenerated]
  private bool method_53(GClass146 gclass146_0)
  {
    return gclass146_0.gclass202_0 == this && gclass146_0.decimal_4 <= 0.01M && gclass146_0.dictionary_0.Count == 0;
  }

  [CompilerGenerated]
  private bool method_54(GClass126 gclass126_0)
  {
    return gclass126_0.gclass200_0 == this.gclass200_0 && gclass126_0.gclass21_0 == this.gclass21_0;
  }

  [CompilerGenerated]
  private bool method_55(GClass214 gclass214_0)
  {
    return gclass214_0.gclass200_0 == this.gclass200_0 && gclass214_0.gclass21_0 == this.gclass21_0;
  }

  [CompilerGenerated]
  private bool method_56(GClass65 gclass65_0)
  {
    return gclass65_0.gclass200_0 == this.gclass200_0 && gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.method_5() == AuroraContactStatus.Hostile;
  }

  [CompilerGenerated]
  private bool method_57(GClass85 gclass85_1)
  {
    return gclass85_1.gclass202_0 == this;
  }

  [CompilerGenerated]
  private bool method_58(GClass213 gclass213_0)
  {
    return gclass213_0.list_0.Contains(this.gclass21_0.RaceID);
  }

  [CompilerGenerated]
  private bool method_59(GClass197 gclass197_0)
  {
    return gclass197_0.gclass200_0 == this.gclass200_0;
  }

  [CompilerGenerated]
  private bool method_60(GClass40 gclass40_0)
  {
    return gclass40_0.gclass22_0 == this.gclass21_0.gclass22_0;
  }

  [CompilerGenerated]
  private bool method_61(GClass65 gclass65_0)
  {
    return gclass65_0.gclass21_1 == this.gclass21_0 && gclass65_0.gclass21_0 == this.gclass21_0.gclass112_0.gclass110_0.gclass21_0 && gclass65_0.decimal_3 >= this.gclass0_0.decimal_0 - (Decimal) this.gclass21_0.int_47 && gclass65_0.gclass200_0 == this.gclass200_0;
  }

  [CompilerGenerated]
  private bool method_62(GClass146 gclass146_0)
  {
    return gclass146_0.gclass202_0 == this;
  }

  [CompilerGenerated]
  private bool method_63(GClass120 gclass120_0)
  {
    return gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
  }

  [CompilerGenerated]
  private bool method_64(GClass213 gclass213_0)
  {
    return gclass213_0.list_0.Contains(this.gclass21_0.RaceID);
  }

  [CompilerGenerated]
  private bool method_65(GClass1 gclass1_1)
  {
    return gclass1_1.gclass200_0 == this.gclass200_0;
  }

  [CompilerGenerated]
  private bool method_66(GClass213 gclass213_0)
  {
    return gclass213_0.list_0.Contains(this.gclass21_0.RaceID);
  }

  [CompilerGenerated]
  private bool method_67(GClass1 gclass1_1)
  {
    return gclass1_1.gclass200_0 == this.gclass200_0;
  }

  [CompilerGenerated]
  private bool method_68(GClass146 gclass146_0)
  {
    return gclass146_0.gclass21_0 == this.gclass21_0 && gclass146_0.gclass202_0 == this;
  }

  [CompilerGenerated]
  [Serializable]
  private sealed class compStatics
  {
    public static readonly GClass202.compStatics staticCompField;
    public static Func<GClass120, GClass200> staticCompField__108_1;
    public static Func<GClass111, AuroraSystemProtectionStatus> staticCompField__109_0;
    public static Func<GClass146, Decimal> staticCompField__110_1;
    public static Func<GClass202, bool> staticCompField__116_2;
    public static Func<GClass202, Decimal> staticCompField__116_3;
    public static Func<GClass202, bool> staticCompField__121_0;
    public static Func<GClass202, bool> staticCompField__121_1;
    public static Func<GClass214, int> staticCompField__123_1;
    public static Func<GClass110, bool> staticCompField__126_0;
    public static Func<GClass110, GClass21> staticCompField__126_1;
    public static Func<GClass190, bool> staticCompField__126_5;
    public static Func<GClass146, bool> staticCompField__126_3;
    public static Func<GClass85, IEnumerable<GClass40>> staticCompField__127_1;
    public static Func<GClass40, Decimal> staticCompField__127_2;
    public static Func<GClass1, bool> staticCompField__134_0;
    public static Func<GClass1, bool> staticCompField__134_7;
    public static Func<GClass1, bool> staticCompField__134_14;
    public static Func<GClass197, int> staticCompField__140_1;
    public static Func<GClass120, double> staticCompField__140_2;
    public static Func<GClass120, double> staticCompField__140_3;
    public static Func<GClass1, bool> staticCompField__141_0;
    public static Func<GClass146, Decimal> staticCompField__143_1;
    public static Func<GClass120, GClass200> staticCompField__144_2;
    public static Func<GClass120, GClass200> staticCompField__145_2;
    public static Func<GClass120, GClass200> staticCompField__146_2;
    public static Func<GClass120, double> staticCompField__147_1;
    public static Func<GClass110, string> staticCompField__153_4;
    public static Func<GClass146, Decimal> staticCompField__154_1;

    static compStatics()
    {
      GClass202.compStatics.staticCompField = new GClass202.compStatics();
    }

    public compStatics()
    {
      
    }

    internal GClass200 method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass120_0.gclass200_0;
    }

    internal AuroraSystemProtectionStatus method_1(GClass111 gclass111_0)
    {
      return gclass111_0.auroraSystemProtectionStatus_0;
    }

    internal Decimal method_2(GClass146 gclass146_0)
    {
      return gclass146_0.method_190();
    }

    internal bool method_3(GClass202 gclass202_0)
    {
      return gclass202_0 != null;
    }

    internal Decimal method_4(GClass202 gclass202_0)
    {
      return gclass202_0.decimal_0;
    }

    internal bool method_5(GClass202 gclass202_0)
    {
      return !gclass202_0.method_20();
    }

    internal bool method_6(GClass202 gclass202_0)
    {
      return !gclass202_0.method_21();
    }

    internal int method_7(GClass214 gclass214_0)
    {
      return gclass214_0.int_3;
    }

    internal bool method_8(GClass110 gclass110_0)
    {
      return gclass110_0.bool_0;
    }

    internal GClass21 method_9(GClass110 gclass110_0)
    {
      return gclass110_0.gclass21_0;
    }

    internal bool method_10(GClass146 gclass146_0)
    {
      return gclass146_0.dictionary_4.Values.FirstOrDefault<GClass190>(method_11) != null;
    }

    internal bool method_11(GClass190 gclass190_0)
    {
      return gclass190_0.decimal_1 > 10M;
    }

    internal IEnumerable<GClass40> method_12(GClass85 gclass85_0)
    {
      return (IEnumerable<GClass40>) gclass85_0.method_176();
    }

    internal Decimal method_13(GClass40 gclass40_0)
    {
      return gclass40_0.gclass22_0.decimal_10;
    }

    internal bool method_14(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_0 == 0M;
    }

    internal bool method_15(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 == 0M;
    }

    internal bool method_16(GClass1 gclass1_0)
    {
      return gclass1_0.genum12_0 == GEnum12.const_5;
    }

    internal int method_17(GClass197 gclass197_0)
    {
      return gclass197_0.int_3;
    }

    internal double method_18(GClass120 gclass120_0)
    {
      return gclass120_0.double_0;
    }

    internal double method_19(GClass120 gclass120_0)
    {
      return gclass120_0.double_0;
    }

    internal bool method_20(GClass1 gclass1_0)
    {
      return gclass1_0.genum12_0 != GEnum12.const_5 && gclass1_0.genum12_0 != GEnum12.const_3;
    }

    internal Decimal method_21(GClass146 gclass146_0)
    {
      return gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters);
    }

    internal GClass200 method_22(GClass120 gclass120_0)
    {
      return gclass120_0.gclass120_0.gclass200_0;
    }

    internal GClass200 method_23(GClass120 gclass120_0)
    {
      return gclass120_0.gclass120_0.gclass200_0;
    }

    internal GClass200 method_24(GClass120 gclass120_0)
    {
      return gclass120_0.gclass120_0.gclass200_0;
    }

    internal double method_25(GClass120 gclass120_0)
    {
      return gclass120_0.double_0;
    }

    internal string method_26(GClass110 gclass110_0)
    {
      return gclass110_0.AlienRaceName;
    }

    internal Decimal method_27(GClass146 gclass146_0)
    {
      return gclass146_0.decimal_30;
    }
  }

  [CompilerGenerated]
  private sealed class Class1182
  {
    public List<GClass200> list_0;

    public Class1182()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return this.list_0.Contains(gclass202_0.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1183
  {
    public KeyValuePair<GClass110, GClass111> keyValuePair_0;

    public Class1183()
    {
      
    }

    internal bool method_0(GClass110 gclass110_0)
    {
      return gclass110_0.gclass21_0 == this.keyValuePair_0.Key.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1184
  {
    public GClass202 gclass202_0;
    public GClass202 gclass202_1;

    public Class1184()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass120_0.gclass120_0 != null;
    }

    internal GClass202 method_1(GClass120 gclass120_0)
    {
      return this.gclass202_1.gclass21_0.method_128(gclass120_0.gclass120_0.gclass200_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1185
  {
    public double double_0;
    public double double_1;

    public Class1185()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return Math.Abs(gclass202_0.double_5 - this.double_0) < (double) GClass226.int_1 && Math.Abs(gclass202_0.double_6 - this.double_1) < (double) GClass226.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1186
  {
    public GClass202 gclass202_0;
    public GClass202 gclass202_1;

    public Class1186()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass202_0.gclass21_0.RaceID);
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      return gclass120_0.dictionary_0[this.gclass202_0.gclass21_0.RaceID].int_1 == 1 && gclass120_0.gclass120_0 != null;
    }

    internal bool method_2(GClass120 gclass120_0)
    {
      return gclass120_0.gclass120_0.gclass200_0 == this.gclass202_1.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1187
  {
    public GClass202 gclass202_0;
    public GClass85 gclass85_0;

    public Class1187()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      if (gclass146_0.gclass202_0 != this.gclass202_0 || gclass146_0.genum19_0 != GEnum19.const_1)
        return false;
      return this.gclass85_0.gclass187_0 == null || !gclass146_0.bool_8;
    }

    internal bool method_1(GClass146 gclass146_0)
    {
      if (gclass146_0.gclass202_0 != this.gclass202_0 || !(gclass146_0.decimal_4 > GClass226.decimal_12))
        return false;
      return this.gclass85_0.gclass187_0 == null || !gclass146_0.bool_8;
    }

    internal bool method_2(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0 == this.gclass202_0 && gclass146_0.bool_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1188
  {
    public GClass202 gclass202_0;
    public double double_0;
    public double double_1;

    public Class1188()
    {
      
    }

    internal double method_0(GClass146 gclass146_0)
    {
      return this.gclass202_0.gclass200_0.method_3(this.double_0, this.double_1, gclass146_0.method_87(), gclass146_0.method_88());
    }
  }

  [CompilerGenerated]
  private sealed class Class1189
  {
    public List<GClass21> list_0;

    public Class1189()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return this.list_0.Contains(gclass146_0.gclass21_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1190
  {
    public GClass194 gclass194_0;
    public GClass202 gclass202_0;

    public Class1190()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass202_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1191
  {
    public Decimal decimal_0;
    public List<GClass1> list_0;
    public GClass202.Class1190 class1190_0;

    public Class1191()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_0 >= 0M && gclass1_0.decimal_0 < 2M * this.decimal_0 && gclass1_0.double_7 >= this.class1190_0.gclass194_0.double_7;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_0 >= 0M && gclass1_0.decimal_0 < 2M * this.decimal_0;
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_0 >= 2M * this.decimal_0 && gclass1_0.decimal_0 < 3M * this.decimal_0 && gclass1_0.double_7 >= this.class1190_0.gclass194_0.double_7;
    }

    internal bool method_3(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_0 >= 2M * this.decimal_0 && gclass1_0.decimal_0 < 3M * this.decimal_0;
    }

    internal bool method_4(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_0 >= 3M * this.decimal_0 && gclass1_0.decimal_0 < 5M * this.decimal_0 && gclass1_0.double_7 >= this.class1190_0.gclass194_0.double_7;
    }

    internal bool method_5(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_0 >= 3M * this.decimal_0 && gclass1_0.decimal_0 < 5M * this.decimal_0;
    }

    internal bool method_6(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 >= 0M && gclass1_0.decimal_1 < 2M * this.decimal_0 && gclass1_0.double_7 >= this.class1190_0.gclass194_0.double_7;
    }

    internal bool method_7(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 >= 0M && gclass1_0.decimal_1 < 2M * this.decimal_0;
    }

    internal bool method_8(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 >= 2M * this.decimal_0 && gclass1_0.decimal_1 < 3M * this.decimal_0 && gclass1_0.double_7 >= this.class1190_0.gclass194_0.double_7;
    }

    internal bool method_9(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 >= 2M * this.decimal_0 && gclass1_0.decimal_1 < 3M * this.decimal_0;
    }

    internal bool method_10(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 >= 3M * this.decimal_0 && gclass1_0.decimal_1 < 5M * this.decimal_0 && gclass1_0.double_7 >= this.class1190_0.gclass194_0.double_7;
    }

    internal bool method_11(GClass1 gclass1_0)
    {
      return gclass1_0.decimal_1 >= 3M * this.decimal_0 && gclass1_0.decimal_1 < 5M * this.decimal_0;
    }

    internal bool method_12(GClass215 gclass215_0)
    {
      return gclass215_0.gclass21_0 == this.class1190_0.gclass202_0.gclass21_0 && this.list_0.Contains(gclass215_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1192
  {
    public GClass202 gclass202_0;
    public bool bool_0;
    public bool bool_1;

    public Class1192()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass202_0.gclass21_0.RaceID);
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      if (gclass120_0.dictionary_0[this.gclass202_0.gclass21_0.RaceID].int_1 != 1 || gclass120_0.gclass120_0 == null)
        return false;
      return this.bool_0 || gclass120_0.int_2 > 0;
    }

    internal bool method_2(GClass202 gclass202_1)
    {
      return !gclass202_1.bool_3 || !this.bool_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class1193
  {
    public List<GClass200> list_0;

    public Class1193()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      GClass202.Class1194 class1194 = new GClass202.Class1194();
      class1194.gclass202_0 = gclass202_0;
      return this.list_0.Any<GClass200>(class1194.method_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1194
  {
    public GClass202 gclass202_0;

    public Class1194()
    {
      
    }

    internal bool method_0(GClass200 gclass200_0)
    {
      return gclass200_0 == this.gclass202_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1195
  {
    public GClass202 gclass202_0;
    public bool bool_0;

    public Class1195()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass202_0.gclass21_0.RaceID);
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      if (gclass120_0.dictionary_0[this.gclass202_0.gclass21_0.RaceID].int_1 != 1 || gclass120_0.gclass120_0 == null)
        return false;
      return this.bool_0 || gclass120_0.int_2 > 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1196
  {
    public List<GClass200> list_0;

    public Class1196()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      GClass202.Class1197 class1197 = new GClass202.Class1197();
      class1197.gclass202_0 = gclass202_0;
      return this.list_0.Any<GClass200>(class1197.method_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1197
  {
    public GClass202 gclass202_0;

    public Class1197()
    {
      
    }

    internal bool method_0(GClass200 gclass200_0)
    {
      return gclass200_0 == this.gclass202_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1198
  {
    public GClass202 gclass202_0;
    public bool bool_0;
    public GEnum96 genum96_0;

    public Class1198()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass202_0.gclass21_0.RaceID);
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      if (gclass120_0.dictionary_0[this.gclass202_0.gclass21_0.RaceID].int_1 != 1 || gclass120_0.gclass120_0 == null)
        return false;
      return this.bool_0 || gclass120_0.int_2 > 0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1199
  {
    public List<GClass200> list_0;
    public GClass202.Class1198 class1198_0;

    public Class1199()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      GClass202.Class1200 class1200 = new GClass202.Class1200();
      class1200.gclass202_0 = gclass202_0;
      return this.list_0.Any<GClass200>(class1200.method_0) && class1200.gclass202_0.gclass3_0.genum96_0 <= this.class1198_0.genum96_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1200
  {
    public GClass202 gclass202_0;

    public Class1200()
    {
      
    }

    internal bool method_0(GClass200 gclass200_0)
    {
      return gclass200_0 == this.gclass202_0.gclass200_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1201
  {
    public List<GClass1> list_0;
    public GClass202 gclass202_0;

    public Class1201()
    {
      
    }

    internal bool method_0(GClass215 gclass215_0)
    {
      return gclass215_0.gclass21_0 == this.gclass202_0.gclass21_0 && this.list_0.Contains(gclass215_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1202
  {
    public GClass197 gclass197_0;

    public Class1202()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass197_0 == this.gclass197_0 && !gclass1_0.bool_2;
    }
  }

  [CompilerGenerated]
  private sealed class Class1203
  {
    public List<GClass1> list_0;
    public GClass202 gclass202_0;

    public Class1203()
    {
      
    }

    internal bool method_0(GClass215 gclass215_0)
    {
      return gclass215_0.gclass21_0 == this.gclass202_0.gclass21_0 && this.list_0.Contains(gclass215_0.gclass1_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1204
  {
    public GClass202 gclass202_0;
    public GClass21 gclass21_0;
    public Func<GClass110, bool> func_0;

    public Class1204()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0;
    }

    internal bool method_1(GClass110 gclass110_0)
    {
      return gclass110_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1205
  {
    public GClass120 gclass120_0;

    public Class1205()
    {
      
    }

    internal double method_0(GClass213 gclass213_0)
    {
      return Math.Pow(gclass213_0.double_0 - this.gclass120_0.double_1, 2.0) + Math.Pow(gclass213_0.double_1 - this.gclass120_0.double_2, 2.0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1206
  {
    public double double_0;

    public Class1206()
    {
      
    }

    internal bool method_0(GClass213 gclass213_0)
    {
      return Math.Pow(gclass213_0.double_0, 2.0) + Math.Pow(gclass213_0.double_1, 2.0) > this.double_0;
    }
  }
}