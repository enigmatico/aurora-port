// Decompiled with JetBrains decompiler
// Type: GClass200
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
public class GClass200
{
  [CompilerGenerated]
  private sealed class Class1168
  {
    public GClass202 gclass202_0;
    public GClass200 gclass200_0;
    public double double_0;
    public double double_1;

    public Class1168()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass202_0.gclass21_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass202_0 == this.gclass202_0 && gclass139_0.gclass133_0.genum123_0 == GEnum123.const_39;
    }

    internal bool method_2(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_29.ContainsKey(gclass139_0.int_2);
    }

    internal GClass233 method_3(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_29[gclass139_0.int_2];
    }

    internal bool method_4(GClass233 gclass233_0)
    {
      return gclass233_0.gclass200_0 == this.gclass200_0;
    }

    internal double method_5(GClass233 gclass233_0)
    {
      return this.gclass200_0.method_3(this.double_0, this.double_1, gclass233_0.double_0, gclass233_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class1169
  {
    public GClass202 gclass202_0;
    public GClass200 gclass200_0;
    public double double_0;
    public double double_1;

    public Class1169()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass202_0.gclass21_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass202_0 == this.gclass202_0 && gclass139_0.gclass133_0.genum123_0 == GEnum123.const_109;
    }

    internal bool method_2(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_22.ContainsKey(gclass139_0.int_2);
    }

    internal GClass146 method_3(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_22[gclass139_0.int_2];
    }

    internal bool method_4(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0.gclass200_0 == this.gclass200_0 && gclass146_0.dictionary_0.Count > 0;
    }

    internal double method_5(GClass146 gclass146_0)
    {
      return this.gclass200_0.method_3(this.double_0, this.double_1, gclass146_0.method_87(), gclass146_0.method_88());
    }
  }

  [CompilerGenerated]
  private sealed class Class1170
  {
    public GClass202 gclass202_0;
    public GClass200 gclass200_0;
    public AuroraContactStatus auroraContactStatus_0;
    public AuroraContactType auroraContactType_0;
    public bool bool_0;
    public double double_0;
    public double double_1;

    public Class1170()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass202_0.gclass21_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass202_0 == this.gclass202_0 && gclass139_0.gclass133_0.genum123_0 == GEnum123.const_15 && gclass139_0.genum13_0 == GEnum13.const_4;
    }

    internal bool method_2(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_28.ContainsKey(gclass139_0.int_2);
    }

    internal GClass65 method_3(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_28[gclass139_0.int_2];
    }

    internal bool method_4(GClass65 gclass65_0)
    {
      if (gclass65_0.gclass200_0 != this.gclass200_0 || gclass65_0.method_5() > this.auroraContactStatus_0 || gclass65_0.auroraContactType_0 != this.auroraContactType_0)
        return false;
      return !this.bool_0 || gclass65_0.genum10_0 == GEnum10.const_0;
    }

    internal double method_5(GClass65 gclass65_0)
    {
      return this.gclass200_0.method_3(this.double_0, this.double_1, gclass65_0.double_0, gclass65_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class1171
  {
    public GClass202 gclass202_0;
    public GClass200 gclass200_0;
    public WayPointType wayPointType_0;
    public int int_0;
    public double double_0;
    public double double_1;

    public Class1171()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass202_0.gclass21_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass202_0 == this.gclass202_0 && gclass139_0.gclass133_0.genum123_0 == GEnum123.const_1 && gclass139_0.genum13_0 == GEnum13.const_3;
    }

    internal bool method_2(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_13.ContainsKey(gclass139_0.int_2);
    }

    internal GClass214 method_3(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_13[gclass139_0.int_2];
    }

    internal bool method_4(GClass214 gclass214_0)
    {
      return gclass214_0.gclass200_0 == this.gclass200_0 && gclass214_0.wayPointType_0 == this.wayPointType_0 && gclass214_0.gclass21_0 == this.gclass202_0.gclass21_0 && gclass214_0.int_2 == this.int_0;
    }

    internal double method_5(GClass214 gclass214_0)
    {
      return this.gclass200_0.method_3(this.double_0, this.double_1, gclass214_0.double_0, gclass214_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class1172
  {
    public GClass202 gclass202_0;
    public GClass200 gclass200_0;
    public double double_0;
    public double double_1;

    public Class1172()
    {
      
    }

    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass202_0.gclass21_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass202_0 == this.gclass202_0 && gclass139_0.gclass133_0.genum123_0 == GEnum123.const_32;
    }

    internal bool method_2(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_30.ContainsKey(gclass139_0.int_2);
    }

    internal GClass59 method_3(GClass139 gclass139_0)
    {
      return this.gclass200_0.gclass0_0.dictionary_30[gclass139_0.int_2];
    }

    internal bool method_4(GClass59 gclass59_0)
    {
      return gclass59_0.gclass200_0 == this.gclass200_0;
    }

    internal double method_5(GClass59 gclass59_0)
    {
      return this.gclass200_0.method_3(this.double_0, this.double_1, gclass59_0.double_0, gclass59_0.double_1);
    }
  }

  [CompilerGenerated]
  private sealed class Class1173
  {
    public GClass200 gclass200_0;
    public double double_0;
    public GClass21 gclass21_0;

    public Class1173()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.method_77(this.gclass21_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1174
  {
    public GClass164 gclass164_0;
    public GClass200.Class1173 class1173_0;

    public Class1174()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.double_20 * 2.0 < (double) this.gclass164_0.decimal_0 && gclass1_0.double_0 < this.class1173_0.double_0 && gclass1_0.double_1 < this.class1173_0.double_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1175
  {
    public GClass21 gclass21_0;
    public GClass200 gclass200_0;
    public Decimal decimal_0;

    public Class1175()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass21_0 == this.gclass21_0 && gclass146_0.gclass202_0.gclass200_0 == this.gclass200_0 && gclass146_0.decimal_30 >= this.decimal_0;
    }

    internal bool method_1(GClass1 gclass1_0)
    {
      return gclass1_0.gclass200_0 == this.gclass200_0;
    }

    internal bool method_2(GClass1 gclass1_0)
    {
      return gclass1_0.method_77(this.gclass21_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class1176
  {
    public GClass120 gclass120_0;

    public Class1176()
    {
      
    }

    internal bool method_0(GClass120 gclass120_1)
    {
      return gclass120_1.gclass120_0 == this.gclass120_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1177
  {
    public GClass200 gclass200_0;
    public GClass21 gclass21_0;

    public Class1177()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      return gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_1 == 1 && gclass120_0.gclass120_0 != null;
    }
  }

  [CompilerGenerated]
  private sealed class Class1178
  {
    public GClass21 gclass21_0;

    public Class1178()
    {
      
    }

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID);
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      return gclass120_0.dictionary_0[this.gclass21_0.RaceID].int_1 == 1 && gclass120_0.gclass120_0 != null;
    }
  }

  [CompilerGenerated]
  private sealed class Class1179
  {
    public GClass200 gclass200_0;
    public GClass21 gclass21_0;

    public Class1179()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass202_0.gclass200_0 == this.gclass200_0 && gclass146_0.gclass21_0 == this.gclass21_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class1180
  {
    public GClass197 gclass197_0;

    public Class1180()
    {
      
    }

    internal bool method_0(GClass146 gclass146_0)
    {
      return gclass146_0.gclass1_0.genum12_0 == GEnum12.const_3 && gclass146_0.gclass1_0.gclass197_0 == this.gclass197_0 && gclass146_0.gclass1_0.bool_2;
    }
  }
  
  private GClass0 gclass0_0;
  public Dictionary<int, GClass213> dictionary_0 = new Dictionary<int, GClass213>();
  public Dictionary<int, GClass120> dictionary_1 = new Dictionary<int, GClass120>();
  public Dictionary<int, GClass120> dictionary_2 = new Dictionary<int, GClass120>();
  public List<GClass197> list_0 = new List<GClass197>();
  public GClass198 gclass198_0;
  public int int_0;
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
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public double double_5;
  public double double_6;
  public bool bool_0;
  public GClass200 gclass200_0;
  public GClass200 gclass200_1;
  public GClass120 gclass120_0;
  public int int_11;
  public double double_7;
  public int int_12;
  public bool bool_1;
  public int int_13;

  public GClass200(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0()
  {
    try
    {
      int num = 1;
      foreach (GClass1 gclass1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass200_0 == this && gclass1_0.genum12_0 == GEnum12.const_3)).OrderBy<GClass1, int>((Func<GClass1, int>) (gclass1_0 => gclass1_0.gclass197_0.int_3)).ThenBy<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.double_2)).ToList<GClass1>())
      {
        gclass1.string_0 = "Asteroid #" + num.ToString();
        gclass1.int_4 = num;
        gclass1.genum5_0 = GEnum5.const_1;
        ++num;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3955);
    }
  }

  public void method_1(double double_8)
  {
    try
    {
      this.gclass0_0.method_545(this, true);
      this.double_2 = 1.0;
      this.double_1 = double_8;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3586);
    }
  }

  public GClass210 method_2()
  {
    try
    {
      return this.gclass0_0.dictionary_16.Values.FirstOrDefault<GClass210>((Func<GClass210, bool>) (gclass210_0 => gclass210_0.gclass200_0 == this));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3414);
      return (GClass210) null;
    }
  }

  public double method_3(double double_8, double double_9, double double_10, double double_11)
  {
    try
    {
      double num1 = this.gclass0_0.method_28(double_8, double_9, double_10, double_11);
      List<GClass212> list = this.gclass0_0.dictionary_14.Values.Where<GClass212>((Func<GClass212, bool>) (gclass212_0 => gclass212_0.gclass200_0 == this)).ToList<GClass212>();
      if (list.Count < 2)
        return num1;
      List<GClass212> gclass212List = new List<GClass212>((IEnumerable<GClass212>) list);
      foreach (GClass212 gclass212_1 in list)
      {
        double num2 = this.gclass0_0.method_28(double_8, double_9, gclass212_1.double_0, gclass212_1.double_1);
        if (num2 < num1)
        {
          foreach (GClass212 gclass212_2 in gclass212List)
          {
            if (gclass212_2 != gclass212_1)
            {
              double num3 = this.gclass0_0.method_28(gclass212_2.double_0, gclass212_2.double_1, double_10, double_11);
              if (num2 + num3 < num1)
                num1 = num2 + num3;
            }
          }
        }
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2959);
      return 0.0;
    }
  }

  public GClass120 method_4()
  {
    try
    {
      return this.dictionary_1.OrderByDescending<KeyValuePair<int, GClass120>, int>((Func<KeyValuePair<int, GClass120>, int>) (keyValuePair_0 => keyValuePair_0.Key)).Select<KeyValuePair<int, GClass120>, GClass120>((Func<KeyValuePair<int, GClass120>, GClass120>) (keyValuePair_0 => keyValuePair_0.Value)).FirstOrDefault<GClass120>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2960);
      return (GClass120) null;
    }
  }

  public GClass233 method_5(double double_8, double double_9, GClass202 gclass202_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1168 class1168 = new GClass200.Class1168();
    // ISSUE: reference to a compiler-generated field
    class1168.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class1168.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1168.double_0 = double_8;
    // ISSUE: reference to a compiler-generated field
    class1168.double_1 = double_9;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass233> list = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1168.method_0)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1168.method_1)).Where<GClass139>(new Func<GClass139, bool>(class1168.method_2)).Select<GClass139, GClass233>(new Func<GClass139, GClass233>(class1168.method_3)).ToList<GClass233>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_29.Values.Where<GClass233>(new Func<GClass233, bool>(class1168.method_4)).Except<GClass233>((IEnumerable<GClass233>) list).OrderBy<GClass233, double>(new Func<GClass233, double>(class1168.method_5)).FirstOrDefault<GClass233>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2961);
      return (GClass233) null;
    }
  }

  public GClass146 method_6(double double_8, double double_9, GClass202 gclass202_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1169 class1169 = new GClass200.Class1169();
    // ISSUE: reference to a compiler-generated field
    class1169.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class1169.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1169.double_0 = double_8;
    // ISSUE: reference to a compiler-generated field
    class1169.double_1 = double_9;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass146> list = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1169.method_0)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1169.method_1)).Where<GClass139>(new Func<GClass139, bool>(class1169.method_2)).Select<GClass139, GClass146>(new Func<GClass139, GClass146>(class1169.method_3)).ToList<GClass146>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1169.method_4)).Except<GClass146>((IEnumerable<GClass146>) list).OrderBy<GClass146, double>(new Func<GClass146, double>(class1169.method_5)).FirstOrDefault<GClass146>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2962);
      return (GClass146) null;
    }
  }

  public GClass65 method_7(
    double double_8,
    double double_9,
    GClass202 gclass202_0,
    AuroraContactStatus auroraContactStatus_0,
    AuroraContactType auroraContactType_0,
    bool bool_2,
    bool bool_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1170 class1170 = new GClass200.Class1170();
    // ISSUE: reference to a compiler-generated field
    class1170.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class1170.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1170.auroraContactStatus_0 = auroraContactStatus_0;
    // ISSUE: reference to a compiler-generated field
    class1170.auroraContactType_0 = auroraContactType_0;
    // ISSUE: reference to a compiler-generated field
    class1170.bool_0 = bool_2;
    // ISSUE: reference to a compiler-generated field
    class1170.double_0 = double_8;
    // ISSUE: reference to a compiler-generated field
    class1170.double_1 = double_9;
    try
    {
      List<GClass65> second = new List<GClass65>();
      if (!bool_3)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        second = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1170.method_0)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1170.method_1)).Where<GClass139>(new Func<GClass139, bool>(class1170.method_2)).Select<GClass139, GClass65>(new Func<GClass139, GClass65>(class1170.method_3)).ToList<GClass65>();
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_28.Values.Where<GClass65>(new Func<GClass65, bool>(class1170.method_4)).Except<GClass65>((IEnumerable<GClass65>) second).OrderBy<GClass65, double>(new Func<GClass65, double>(class1170.method_5)).FirstOrDefault<GClass65>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2963);
      return (GClass65) null;
    }
  }

  public GClass214 method_8(
    double double_8,
    double double_9,
    GClass202 gclass202_0,
    WayPointType wayPointType_0,
    int int_14)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1171 class1171 = new GClass200.Class1171();
    // ISSUE: reference to a compiler-generated field
    class1171.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class1171.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1171.wayPointType_0 = wayPointType_0;
    // ISSUE: reference to a compiler-generated field
    class1171.int_0 = int_14;
    // ISSUE: reference to a compiler-generated field
    class1171.double_0 = double_8;
    // ISSUE: reference to a compiler-generated field
    class1171.double_1 = double_9;
    try
    {
      List<GClass214> second = new List<GClass214>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class1171.wayPointType_0 == WayPointType.POI || class1171.wayPointType_0 == WayPointType.UrgentPOI || class1171.wayPointType_0 == WayPointType.TransitPOI)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        second = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1171.method_0)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1171.method_1)).Where<GClass139>(new Func<GClass139, bool>(class1171.method_2)).Select<GClass139, GClass214>(new Func<GClass139, GClass214>(class1171.method_3)).ToList<GClass214>();
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_13.Values.Where<GClass214>(new Func<GClass214, bool>(class1171.method_4)).Except<GClass214>((IEnumerable<GClass214>) second).OrderBy<GClass214, double>(new Func<GClass214, double>(class1171.method_5)).FirstOrDefault<GClass214>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2964);
      return (GClass214) null;
    }
  }

  public GClass59 method_9(double double_8, double double_9, GClass202 gclass202_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1172 class1172 = new GClass200.Class1172();
    // ISSUE: reference to a compiler-generated field
    class1172.gclass202_0 = gclass202_0;
    // ISSUE: reference to a compiler-generated field
    class1172.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1172.double_0 = double_8;
    // ISSUE: reference to a compiler-generated field
    class1172.double_1 = double_9;
    try
    {
      List<GClass59> gclass59List = new List<GClass59>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass59> list = this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1172.method_0)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class1172.method_1)).Where<GClass139>(new Func<GClass139, bool>(class1172.method_2)).Select<GClass139, GClass59>(new Func<GClass139, GClass59>(class1172.method_3)).ToList<GClass59>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_30.Values.Where<GClass59>(new Func<GClass59, bool>(class1172.method_4)).Except<GClass59>((IEnumerable<GClass59>) list).OrderBy<GClass59, double>(new Func<GClass59, double>(class1172.method_5)).FirstOrDefault<GClass59>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2964);
      return (GClass59) null;
    }
  }

  public GClass1 method_10(double double_8, GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1173 class1173 = new GClass200.Class1173();
    // ISSUE: reference to a compiler-generated field
    class1173.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1173.double_0 = double_8;
    // ISSUE: reference to a compiler-generated field
    class1173.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass200.Class1174 class1174 = new GClass200.Class1174()
      {
        class1173_0 = class1173
      };
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class1174.gclass164_0 = class1174.class1173_0.gclass21_0.method_387(GEnum122.const_175);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      List<GClass1> list = this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1174.class1173_0.method_0)).Where<GClass1>(new Func<GClass1, bool>(class1174.method_0)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.dictionary_0.ContainsKey(AuroraElement.Duranium))).Where<GClass1>(new Func<GClass1, bool>(class1174.class1173_0.method_1)).ToList<GClass1>();
      return list.Count == 0 ? (GClass1) null : list.OrderByDescending<GClass1, Decimal>((Func<GClass1, Decimal>) (gclass1_0 => gclass1_0.dictionary_0.Values.Sum<GClass124>((Func<GClass124, Decimal>) (gclass124_0 => gclass124_0.decimal_1)))).FirstOrDefault<GClass1>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2965);
      return (GClass1) null;
    }
  }

  public GClass1 method_11(GClass21 gclass21_0, Decimal decimal_0, bool bool_2)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1175 class1175 = new GClass200.Class1175();
    // ISSUE: reference to a compiler-generated field
    class1175.gclass21_0 = gclass21_0;
    // ISSUE: reference to a compiler-generated field
    class1175.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1175.decimal_0 = decimal_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      if (class1175.decimal_0 > 0M && this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1175.method_0)).Sum<GClass146>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_30)) < 10M)
        return (GClass1) null;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass1> list = this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1175.method_1)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.dictionary_0.ContainsKey(AuroraElement.Sorium))).Where<GClass1>(new Func<GClass1, bool>(class1175.method_2)).ToList<GClass1>();
      if (list.Count == 0)
        return (GClass1) null;
      if (bool_2)
      {
        // ISSUE: reference to a compiler-generated field
        list = list.Except<GClass1>((IEnumerable<GClass1>) class1175.gclass21_0.list_9).ToList<GClass1>();
        if (list.Count == 0)
          return (GClass1) null;
      }
      return list.OrderByDescending<GClass1, Decimal>((Func<GClass1, Decimal>) (gclass1_0 => gclass1_0.dictionary_0[AuroraElement.Sorium].decimal_1)).FirstOrDefault<GClass1>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2966);
      return (GClass1) null;
    }
  }

  public double method_12()
  {
    try
    {
      return this.double_6 <= 1.0 ? Math.Sqrt(this.double_6) : Math.Pow(this.double_6, 1.0 / 3.0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3573);
      return 1.0;
    }
  }

  public void method_13()
  {
    try
    {
      foreach (GClass1 gclass1_1 in this.method_20())
      {
        gclass1_1.dictionary_0.Clear();
        if (gclass1_1.auroraSystemBodyType_0 != AuroraSystemBodyType.GasGiant && gclass1_1.auroraSystemBodyType_0 != AuroraSystemBodyType.Superjovian)
        {
          if (gclass1_1.auroraSystemBodyType_0 == AuroraSystemBodyType.Comet)
            this.gclass0_0.method_670(gclass1_1);
          else
            this.gclass0_0.method_672(gclass1_1, (GClass21) null);
        }
        else
          this.gclass0_0.method_669(gclass1_1, false);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2967);
    }
  }

  public GClass120 method_14(bool bool_2)
  {
    try
    {
      GClass120 gclass120_2 = new GClass120(this.gclass0_0);
      GClass120 gclass120_0_1 = new GClass120(this.gclass0_0);
      gclass120_0_1.int_0 = this.gclass0_0.method_26(GEnum0.const_8);
      gclass120_0_1.gclass200_0 = this;
      double num1 = this.method_12();
      gclass120_0_1.int_1 = GClass226.smethod_13(360);
      gclass120_0_1.double_0 = (double) GClass226.smethod_13(4000) / 100.0 * num1;
      if (bool_2 && gclass120_0_1.double_0 > 30.0)
        gclass120_0_1.double_0 = (double) GClass226.smethod_13(4000) / 100.0 * num1;
      GClass221 gclass221 = this.gclass0_0.method_592(0.0, 0.0, gclass120_0_1.double_0 * GClass226.double_14, (double) gclass120_0_1.int_1);
      gclass120_0_1.double_1 = gclass221.double_0;
      gclass120_0_1.double_2 = gclass221.double_1;
      if (this.gclass0_0.int_88 == 1)
        gclass120_0_1.int_2 = 1000;
      this.gclass0_0.dictionary_12.Add(gclass120_0_1.int_0, gclass120_0_1);
      int num2 = 1;
      foreach (GClass120 gclass120_3 in this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_1 => gclass120_1.gclass200_0 == this)).OrderBy<GClass120, double>((Func<GClass120, double>) (gclass120_0 => gclass120_0.double_0)).ToList<GClass120>())
      {
        gclass120_3.int_5 = num2;
        ++num2;
      }
      foreach (GClass21 gclass21 in this.gclass0_0.dictionary_36.Values.SelectMany<GClass21, GClass202>((Func<GClass21, IEnumerable<GClass202>>) (gclass21_0 => (IEnumerable<GClass202>) gclass21_0.dictionary_0.Values)).Where<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass200_0 == this)).Select<GClass202, GClass21>((Func<GClass202, GClass21>) (gclass202_0 => gclass202_0.gclass21_0)).ToList<GClass21>())
        gclass21.method_264(gclass120_0_1, 0, 0);
      return gclass120_0_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2968);
      return (GClass120) null;
    }
  }

  public void method_15(GClass120 gclass120_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1176 class1176 = new GClass200.Class1176();
    // ISSUE: reference to a compiler-generated field
    class1176.gclass120_0 = gclass120_1;
    try
    {
      // ISSUE: reference to a compiler-generated method
      GClass120 gclass120 = this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1176.method_0)).FirstOrDefault<GClass120>();
      if (gclass120 != null)
      {
        gclass120.gclass120_0 = (GClass120) null;
        gclass120.int_4 = 0;
        foreach (GClass203 gclass203 in gclass120.dictionary_0.Values)
          gclass203.int_1 = 0;
      }
      // ISSUE: reference to a compiler-generated field
      this.gclass0_0.dictionary_12.Remove(class1176.gclass120_0.int_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2969);
    }
  }

  public List<GClass200> method_16(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1177 class1177 = new GClass200.Class1177();
    // ISSUE: reference to a compiler-generated field
    class1177.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1177.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1177.method_0)).Where<GClass120>(new Func<GClass120, bool>(class1177.method_1)).Select<GClass120, GClass200>((Func<GClass120, GClass200>) (gclass120_0 => gclass120_0.gclass120_0.gclass200_0)).ToList<GClass200>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2970);
      return (List<GClass200>) null;
    }
  }

  public List<GClass200> method_17()
  {
    try
    {
      return this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_1 => gclass120_1.gclass200_0 == this && gclass120_1.gclass120_0 != null)).Select<GClass120, GClass200>((Func<GClass120, GClass200>) (gclass120_0 => gclass120_0.gclass120_0.gclass200_0)).ToList<GClass200>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2971);
      return (List<GClass200>) null;
    }
  }

  public List<GClass120> method_18(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1178 class1178 = new GClass200.Class1178();
    // ISSUE: reference to a compiler-generated field
    class1178.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1178.method_0)).Where<GClass120>(new Func<GClass120, bool>(class1178.method_1)).OrderBy<GClass120, double>((Func<GClass120, double>) (gclass120_0 => gclass120_0.double_0)).ToList<GClass120>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2972);
      return (List<GClass120>) null;
    }
  }

  public Dictionary<int, GClass1> method_19()
  {
    try
    {
      return this.gclass0_0.dictionary_11.Where<KeyValuePair<int, GClass1>>((Func<KeyValuePair<int, GClass1>, bool>) (keyValuePair_0 => keyValuePair_0.Key == this.int_0)).ToDictionary<KeyValuePair<int, GClass1>, int, GClass1>((Func<KeyValuePair<int, GClass1>, int>) (keyValuePair_0 => keyValuePair_0.Key), (Func<KeyValuePair<int, GClass1>, GClass1>) (keyValuePair_0 => keyValuePair_0.Value));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2973);
      return new Dictionary<int, GClass1>();
    }
  }

  public List<GClass1> method_20()
  {
    try
    {
      return this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass200_0 == this)).ToList<GClass1>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2974);
      return new List<GClass1>();
    }
  }

  public int method_21()
  {
    try
    {
      return this.gclass0_0.dictionary_11.Values.Count<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass200_0 == this && gclass1_0.genum12_0 != GEnum12.const_5));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2975);
      return 0;
    }
  }

  public string method_22(double double_8, double double_9, GClass202 gclass202_0)
  {
    try
    {
      double num1 = -1.0;
      double num2 = -1.0;
      GClass1 gclass1 = this.method_23(double_8, double_9);
      GClass197 gclass197 = this.method_24(double_8, double_9);
      GClass120 gclass120 = this.method_25(double_8, double_9, gclass202_0.gclass21_0);
      if (gclass1 != null)
        num1 = Math.Sqrt(Math.Pow(gclass1.double_0 - double_8, 2.0) + Math.Pow(gclass1.double_1 - double_9, 2.0));
      if (gclass120 != null)
        num2 = Math.Sqrt(Math.Pow(gclass120.double_1 - double_8, 2.0) + Math.Pow(gclass120.double_2 - double_9, 2.0));
      double num3 = Math.Sqrt(Math.Pow(gclass197.double_0 - double_8, 2.0) + Math.Pow(gclass197.double_1 - double_9, 2.0));
      if (num1 > -1.0 && (num1 <= num2 || num2 == -1.0) && num1 <= num3)
      {
        Decimal num4 = (Decimal) Math.Round(this.gclass0_0.method_591(double_8, double_9, gclass1.double_0, gclass1.double_1));
        return num1 < 10000000.0 ? $"{Math.Round(num1 / 1000000.0, 1).ToString()}m km from {gclass1.method_78(gclass202_0.gclass21_0)} at bearing {num4.ToString()}°" : $"{Math.Round(num1 / 1000000.0).ToString()}m km from {gclass1.method_78(gclass202_0.gclass21_0)} at bearing {num4.ToString()}°";
      }
      if (num2 > -1.0 && (num2 <= num1 || num1 == -1.0) && num2 <= num3)
      {
        Decimal num5 = (Decimal) Math.Round(this.gclass0_0.method_591(double_8, double_9, gclass120.double_1, gclass120.double_2));
        return num1 < 10000000.0 ? $"{Math.Round(num2 / 1000000.0, 1).ToString()}m km from {gclass120.method_8(gclass202_0)} at bearing {num5.ToString()}°" : $"{Math.Round(num2 / 1000000.0).ToString()}m km from {gclass120.method_8(gclass202_0)} at bearing {num5.ToString()}°";
      }
      Decimal num6 = (Decimal) Math.Round(this.gclass0_0.method_591(double_8, double_9, gclass197.double_0, gclass197.double_1));
      return num1 < 10000000.0 ? $"{Math.Round(num3 / 1000000.0, 1).ToString()}m km from {gclass197.method_18(gclass202_0.gclass21_0)} at bearing {num6.ToString()}°" : $"{Math.Round(num3 / 1000000.0).ToString()}m km from {gclass197.method_18(gclass202_0.gclass21_0)} at bearing {num6.ToString()}°";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2976);
      return "";
    }
  }

  public GClass1 method_23(double double_8, double double_9)
  {
    try
    {
      GClass1 gclass1_1 = (GClass1) null;
      double num1 = -1.0;
      foreach (GClass1 gclass1_2 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass200_0 == this && gclass1_0.genum12_0 == GEnum12.const_1)).ToList<GClass1>())
      {
        double num2 = Math.Sqrt(Math.Pow(gclass1_2.double_0 - double_8, 2.0) + Math.Pow(gclass1_2.double_1 - double_9, 2.0));
        if (num1 == -1.0 || num2 < num1)
        {
          num1 = num2;
          gclass1_1 = gclass1_2;
        }
      }
      return gclass1_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2977);
      return (GClass1) null;
    }
  }

  public GClass197 method_24(double double_8, double double_9)
  {
    try
    {
      GClass197 gclass197_1 = (GClass197) null;
      double num1 = -1.0;
      foreach (GClass197 gclass197_2 in this.method_26())
      {
        double num2 = Math.Sqrt(Math.Pow(gclass197_2.double_0 - double_8, 2.0) + Math.Pow(gclass197_2.double_1 - double_9, 2.0));
        if (num1 == -1.0 || num2 < num1)
        {
          num1 = num2;
          gclass197_1 = gclass197_2;
        }
      }
      return gclass197_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2978);
      return (GClass197) null;
    }
  }

  public GClass120 method_25(double double_8, double double_9, GClass21 gclass21_0)
  {
    try
    {
      GClass120 gclass120_1 = (GClass120) null;
      double num1 = -1.0;
      foreach (GClass120 gclass120_2 in this.method_27())
      {
        if (gclass120_2.dictionary_0.ContainsKey(gclass21_0.RaceID) && gclass120_2.dictionary_0[gclass21_0.RaceID].int_2 == 1)
        {
          double num2 = Math.Sqrt(Math.Pow(gclass120_2.double_1 - double_8, 2.0) + Math.Pow(gclass120_2.double_2 - double_9, 2.0));
          if (num1 == -1.0 || num2 < num1)
          {
            num1 = num2;
            gclass120_1 = gclass120_2;
          }
        }
      }
      return gclass120_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2979);
      return (GClass120) null;
    }
  }

  public List<GClass197> method_26()
  {
    try
    {
      return this.gclass0_0.dictionary_10.Values.Where<GClass197>((Func<GClass197, bool>) (gclass197_0 => gclass197_0.gclass200_0 == this)).OrderBy<GClass197, int>((Func<GClass197, int>) (gclass197_0 => gclass197_0.int_3)).ToList<GClass197>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2980);
      return new List<GClass197>();
    }
  }

  public List<GClass120> method_27()
  {
    try
    {
      return this.gclass0_0.dictionary_12.Values.Where<GClass120>((Func<GClass120, bool>) (gclass120_1 => gclass120_1.gclass200_0 == this)).OrderBy<GClass120, double>((Func<GClass120, double>) (gclass120_0 => gclass120_0.double_0)).ToList<GClass120>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2981);
      return new List<GClass120>();
    }
  }

  public void method_28()
  {
    try
    {
      int num = 1;
      foreach (GClass212 gclass212 in this.gclass0_0.dictionary_14.Values.Where<GClass212>((Func<GClass212, bool>) (gclass212_0 => gclass212_0.gclass197_0.gclass200_0 == this)).OrderBy<GClass212, int>((Func<GClass212, int>) (gclass212_0 => gclass212_0.gclass197_0.int_3)).ThenBy<GClass212, double>((Func<GClass212, double>) (gclass212_0 => gclass212_0.double_2)).ToList<GClass212>())
      {
        gclass212.int_1 = num;
        ++num;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2982);
    }
  }

  public List<GClass212> method_29()
  {
    try
    {
      int num = 1;
      List<GClass212> list = this.gclass0_0.dictionary_14.Values.Where<GClass212>((Func<GClass212, bool>) (gclass212_0 => gclass212_0.gclass197_0.gclass200_0 == this)).OrderBy<GClass212, int>((Func<GClass212, int>) (gclass212_0 => gclass212_0.gclass197_0.int_3)).ThenBy<GClass212, double>((Func<GClass212, double>) (gclass212_0 => gclass212_0.double_2)).ToList<GClass212>();
      foreach (GClass212 gclass212 in list)
      {
        gclass212.int_1 = num;
        ++num;
      }
      return list;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2983);
      return (List<GClass212>) null;
    }
  }

  public List<GClass85> method_30()
  {
    try
    {
      return this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass202_0.gclass200_0 == this)).OrderBy<GClass85, string>((Func<GClass85, string>) (gclass85_0 => gclass85_0.FleetName)).ToList<GClass85>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2984);
      return new List<GClass85>();
    }
  }

  public List<GClass132> method_31()
  {
    try
    {
      return this.gclass0_0.dictionary_6.Values.Where<GClass132>((Func<GClass132, bool>) (gclass132_0 => gclass132_0.gclass200_0 == this)).OrderBy<GClass132, string>((Func<GClass132, string>) (gclass132_0 => gclass132_0.string_0)).ToList<GClass132>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2985);
      return new List<GClass132>();
    }
  }

  public List<GClass146> method_32()
  {
    try
    {
      return this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_0 => gclass146_0.gclass202_0.gclass200_0 == this)).OrderBy<GClass146, string>((Func<GClass146, string>) (gclass146_0 => gclass146_0.PopName)).ToList<GClass146>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2986);
      return new List<GClass146>();
    }
  }

  public List<GClass146> method_33(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass200.Class1179 class1179 = new GClass200.Class1179();
    // ISSUE: reference to a compiler-generated field
    class1179.gclass200_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1179.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1179.method_0)).OrderBy<GClass146, string>((Func<GClass146, string>) (gclass146_0 => gclass146_0.PopName)).ToList<GClass146>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2987);
      return new List<GClass146>();
    }
  }

  public List<GClass65> method_34()
  {
    try
    {
      return this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this)).OrderBy<GClass65, string>((Func<GClass65, string>) (gclass65_0 => gclass65_0.string_0)).ToList<GClass65>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2988);
      return new List<GClass65>();
    }
  }

  public List<GClass233> method_35()
  {
    try
    {
      return this.gclass0_0.dictionary_29.Values.Where<GClass233>((Func<GClass233, bool>) (gclass233_0 => gclass233_0.gclass200_0 == this)).OrderBy<GClass233, string>((Func<GClass233, string>) (gclass233_0 => gclass233_0.ViewingName)).ToList<GClass233>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2989);
      return new List<GClass233>();
    }
  }

  public List<GClass59> method_36()
  {
    try
    {
      return this.gclass0_0.dictionary_30.Values.Where<GClass59>((Func<GClass59, bool>) (gclass59_0 => gclass59_0.gclass200_0 == this)).OrderBy<GClass59, string>((Func<GClass59, string>) (gclass59_0 => gclass59_0.string_0)).ToList<GClass59>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2990);
      return new List<GClass59>();
    }
  }

  public int method_37()
  {
    try
    {
      return this.gclass0_0.dictionary_12.Values.Count<GClass120>((Func<GClass120, bool>) (gclass120_1 => gclass120_1.gclass200_0 == this));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2991);
      return 0;
    }
  }

  public TreeNode method_38(GClass202 gclass202_0)
  {
    try
    {
      TreeNode treeNode = new TreeNode();
      treeNode.Text = gclass202_0.Name;
      treeNode.Tag = (object) this;
      treeNode.Expand();
      List<GClass197> gclass197List = this.method_26();
      foreach (GClass197 gclass197 in gclass197List)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass200.Class1180 class1180 = new GClass200.Class1180();
        // ISSUE: reference to a compiler-generated field
        class1180.gclass197_0 = gclass197;
        TreeNode node1 = new TreeNode();
        if (gclass197List.Count > 1)
        {
          // ISSUE: reference to a compiler-generated field
          node1.Text = class1180.gclass197_0.method_18(gclass202_0.gclass21_0);
          // ISSUE: reference to a compiler-generated field
          node1.Tag = (object) class1180.gclass197_0;
          node1.Expand();
        }
        else
          node1 = treeNode;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass146 gclass146 in this.gclass0_0.dictionary_22.Values.Where<GClass146>(new Func<GClass146, bool>(class1180.method_0)).ToList<GClass146>())
          node1.Nodes.Add(new TreeNode()
          {
            Text = gclass146.PopName,
            Tag = (object) gclass146.gclass1_0
          });
        // ISSUE: reference to a compiler-generated field
        foreach (GClass1 gclass1_1 in class1180.gclass197_0.method_15())
        {
          TreeNode node2 = new TreeNode();
          node2.Text = gclass1_1.method_78(gclass202_0.gclass21_0);
          node2.Tag = (object) gclass1_1;
          foreach (GClass1 gclass1_2 in gclass1_1.method_82())
            node2.Nodes.Add(new TreeNode()
            {
              Text = gclass1_2.method_78(gclass202_0.gclass21_0),
              Tag = (object) gclass1_2
            });
          node1.Nodes.Add(node2);
        }
        // ISSUE: reference to a compiler-generated field
        List<GClass1> gclass1List1 = class1180.gclass197_0.method_16(gclass202_0.gclass21_0);
        if (gclass1List1.Count > 0)
        {
          TreeNode node3 = new TreeNode();
          node3.Text = "Asteroids";
          foreach (GClass1 gclass1 in gclass1List1)
            node3.Nodes.Add(new TreeNode()
            {
              Text = gclass1.method_78(gclass202_0.gclass21_0),
              Tag = (object) gclass1
            });
          node1.Nodes.Add(node3);
        }
        // ISSUE: reference to a compiler-generated field
        List<GClass1> gclass1List2 = class1180.gclass197_0.method_17(gclass202_0.gclass21_0);
        if (gclass1List2.Count > 0)
        {
          TreeNode node4 = new TreeNode();
          node4.Text = "Comets";
          foreach (GClass1 gclass1 in gclass1List2)
            node4.Nodes.Add(new TreeNode()
            {
              Text = gclass1.method_78(gclass202_0.gclass21_0),
              Tag = (object) gclass1
            });
          node1.Nodes.Add(node4);
        }
        if (gclass197List.Count > 1)
          treeNode.Nodes.Add(node1);
      }
      return treeNode;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2992);
      return (TreeNode) null;
    }
  }

  public double method_39()
  {
    try
    {
      double num = 0.0;
      foreach (GClass197 gclass197 in this.method_26())
      {
        if (gclass197.double_2 > num)
          num = gclass197.double_2;
      }
      foreach (GClass1 gclass1 in this.method_20())
      {
        if (gclass1.genum2_0 == GEnum2.const_0 && gclass1.double_2 > num)
          num = gclass1.double_2;
      }
      foreach (GClass120 gclass120 in this.method_27())
      {
        if (gclass120.double_0 > num)
          num = gclass120.double_0;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2993);
      return 1.0;
    }
  }
}
