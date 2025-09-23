// Decompiled with JetBrains decompiler
// Type: GClass174
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass174
{
  private sealed class Class1151
  {
    public GClass1 gclass1_0;

    public Class1151()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return gclass202_0.gclass200_0 == this.gclass1_0.gclass200_0;
    }

    internal bool method_1(GClass1 gclass1_1)
    {
      return gclass1_1.gclass200_0 == this.gclass1_0.gclass200_0;
    }
  }

  
  private sealed class Class1152
  {
    public GClass21 gclass21_0;

    public Class1152()
    {
      
    }

    internal bool method_0(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass102 gclass102_0)
    {
      return gclass102_0.gclass21_0 == this.gclass21_0 && gclass102_0.genum116_0 == GEnum116.const_9;
    }

    internal bool method_2(GClass102 gclass102_0)
    {
      return gclass102_0.gclass21_0 == this.gclass21_0 && gclass102_0.genum116_0 == GEnum116.const_11;
    }
  }

  
  private sealed class Class1153
  {
    public GClass1 gclass1_0;

    public Class1153()
    {
      
    }

    internal bool method_0(GClass202 gclass202_0)
    {
      return gclass202_0.gclass200_0 == this.gclass1_0.gclass200_0;
    }

    internal bool method_1(GClass1 gclass1_1)
    {
      return gclass1_1.gclass200_0 == this.gclass1_0.gclass200_0;
    }
  }

  
  private sealed class Class1154
  {
    public GClass21 gclass21_0;
    public GClass202 gclass202_0;
    public GClass146 gclass146_0;

    public Class1154()
    {
      
    }

    internal bool method_0(GClass83 gclass83_0)
    {
      return gclass83_0.gclass21_0 == this.gclass21_0 && gclass83_0.gclass83_0 == null;
    }

    internal bool method_1(GClass22 gclass22_0)
    {
      return gclass22_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_2(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.gclass202_0 == this.gclass202_0 && gclass40_0.gclass22_0.int_32 > 1;
    }

    internal bool method_3(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.gclass202_0 == this.gclass202_0;
    }

    internal bool method_4(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass21_0 && gclass103_0.gclass146_0 == this.gclass146_0;
    }

    internal bool method_5(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.gclass202_0 == this.gclass202_0;
    }

    internal bool method_6(GClass40 gclass40_0)
    {
      return gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass85_0.gclass202_0 == this.gclass202_0;
    }

    internal bool method_7(GClass103 gclass103_0)
    {
      return gclass103_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_8(GClass103 gclass103_0)
    {
      return gclass103_0.gclass146_0.gclass202_0 == this.gclass202_0;
    }
  }
  
  private GClass0 gclass0_0;
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
  public int int_11;
  public int int_12;
  public int int_13;
  public Decimal decimal_0;
  public string string_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;

  public GClass174(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public int method_0(int int_14)
  {
    try
    {
      if (this.gclass0_0.int_125 == 1)
        int_14 = (int) ((double) int_14 * 1.5);
      int num1 = (int) Math.Floor((double) int_14 / 100.0);
      int num2 = (int) ((double) int_14 % 100.0);
      if (GClass226.smethod_13(100) <= num2)
        ++num1;
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2658);
      return 0;
    }
  }

  public void method_1(
    GClass21 gclass21_0,
    GClass1 gclass1_0,
    GClass9 gclass9_0,
    GClass102 gclass102_0,
    int int_14,
    List<GClass22> list_0)
  {
    try
    {
      Decimal num1 = this.decimal_3;
      if (gclass9_0 != null)
      {
        Decimal num2 = 0.01M * (Decimal) (GClass226.smethod_13(300) + GClass226.smethod_13(300)) * GClass226.decimal_29;
        Decimal num3 = 1M;
        if (gclass9_0.genum104_0 == GEnum104.const_4)
          num3 = 3M;
        else if (gclass9_0.genum104_0 == GEnum104.const_19)
          num3 = 2M;
        else if (gclass9_0.bool_1)
          num3 = 1.5M;
        num1 = this.decimal_3 + num2 / num3;
      }
      this.gclass0_0.list_8.Add(new GClass172()
      {
        gclass1_0 = gclass1_0,
        gclass9_0 = gclass9_0,
        gclass102_0 = gclass102_0,
        int_0 = int_14,
        decimal_0 = num1
      });
      if (gclass9_0 == null)
        return;
      GClass173 gclass173 = this.gclass0_0.method_56(gclass21_0, gclass9_0, list_0, int_14);
      this.decimal_1 += gclass173.decimal_0;
      this.decimal_2 += gclass173.decimal_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3873);
    }
  }

  public void method_2(GClass1 gclass1_0_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass174.Class1151 class1151 = new GClass174.Class1151();
    // ISSUE: reference to a compiler-generated field
    class1151.gclass1_0 = gclass1_0_1;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass174.Class1152 class1152 = new GClass174.Class1152();
      if (GClass226.smethod_13(100) < this.int_2)
        return;
      this.decimal_1 = 0M;
      this.decimal_2 = 0M;
      this.decimal_3 = this.gclass0_0.decimal_0 + 0.01M * (Decimal) (GClass226.smethod_13(1000) + GClass226.smethod_13(1000)) * GClass226.decimal_29 / this.decimal_0;
      // ISSUE: reference to a compiler-generated field
      class1152.gclass21_0 = this.gclass0_0.dictionary_36.Values.FirstOrDefault<GClass21>((Func<GClass21, bool>) (gclass21_0 => gclass21_0.genum6_0 == GEnum6.const_1));
      // ISSUE: reference to a compiler-generated method
      List<GClass22> list = this.gclass0_0.dictionary_3.Values.Where<GClass22>(new Func<GClass22, bool>(class1152.method_0)).ToList<GClass22>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      if (class1152.gclass21_0.dictionary_0.Values.FirstOrDefault<GClass202>(new Func<GClass202, bool>(class1151.method_0)) == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1152.gclass21_0.method_262(class1151.gclass1_0.gclass200_0, 1);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1152.gclass21_0.method_263(class1151.gclass1_0.gclass200_0, class1152.gclass21_0.gclass140_1, "", true);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1152.gclass21_0.method_258(class1151.gclass1_0.gclass200_0, false);
      }
      // ISSUE: reference to a compiler-generated field
      class1152.gclass21_0.gclass20_0.list_3.OrderBy<GClass12, int>((Func<GClass12, int>) (gclass12_0 => gclass12_0.int_0)).ToList<GClass12>();
      int int_14_1 = this.method_0(this.int_5);
      GClass9 gclass9_0_1 = this.gclass0_0.dictionary_41[GEnum105.const_4];
      if (gclass9_0_1 != null && int_14_1 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_1, (GClass102) null, int_14_1, list);
      }
      int int_14_2 = this.method_0(this.int_6);
      GClass9 gclass9_0_2 = this.gclass0_0.dictionary_41[GEnum105.const_19];
      if (gclass9_0_2 != null && int_14_2 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_2, (GClass102) null, int_14_2, list);
      }
      int int_14_3 = this.method_0(this.int_7);
      GClass9 gclass9_0_3 = GClass226.smethod_13(4) != 1 ? this.gclass0_0.dictionary_41[GEnum105.const_1] : this.gclass0_0.dictionary_41[GEnum105.const_24];
      if (gclass9_0_3 != null && int_14_3 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_3, (GClass102) null, int_14_3, list);
        int int_14_4 = this.method_0((int) Math.Floor((double) this.int_7 / 2.0));
        GClass9 gclass9_0_4 = this.gclass0_0.dictionary_41[GEnum105.const_10];
        if (gclass9_0_4 != null && int_14_4 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_4, (GClass102) null, int_14_4, list);
        }
      }
      int int_14_5 = this.method_0(this.int_8);
      GClass9 gclass9_0_5 = GClass226.smethod_13(4) != 1 ? this.gclass0_0.dictionary_41[GEnum105.const_22] : this.gclass0_0.dictionary_41[GEnum105.const_23];
      if (gclass9_0_5 != null && int_14_5 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_5, (GClass102) null, int_14_5, list);
        int int_14_6 = this.method_0((int) Math.Floor((double) this.int_8 / 2.0));
        GClass9 gclass9_0_6 = this.gclass0_0.dictionary_41[GEnum105.const_21];
        if (gclass9_0_6 != null && int_14_6 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_6, (GClass102) null, int_14_6, list);
        }
      }
      int int_14_7 = this.method_0(this.int_9);
      GClass9 gclass9_0_7 = GClass226.smethod_13(4) != 1 ? this.gclass0_0.dictionary_41[GEnum105.const_6] : this.gclass0_0.dictionary_41[GEnum105.const_25];
      if (gclass9_0_7 != null && int_14_7 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_7, (GClass102) null, int_14_7, list);
      }
      int int_14_8 = this.method_0(this.int_9);
      GClass9 gclass9_0_8 = this.gclass0_0.dictionary_41[GEnum105.const_66];
      if (gclass9_0_8 != null && int_14_8 > 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_8, (GClass102) null, int_14_8, list);
      }
      if (this.decimal_1 > 100000M)
      {
        int num = (int) Math.Floor(this.decimal_1 / 100000M);
        GClass9 gclass9_0_9 = this.gclass0_0.dictionary_41[GEnum105.const_5];
        if (gclass9_0_9 != null && int_14_8 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_9, (GClass102) null, int_14_8, list);
        }
      }
      // ISSUE: reference to a compiler-generated method
      if (this.decimal_2 > 5000000M && this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1151.method_1)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0_2 => gclass1_0_2.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0_2.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0_3 => gclass1_0_3.dictionary_0.ContainsKey(AuroraElement.Sorium))).OrderByDescending<GClass1, Decimal>((Func<GClass1, Decimal>) (gclass1_0_4 => gclass1_0_4.dictionary_0[AuroraElement.Sorium].decimal_1)).FirstOrDefault<GClass1>() != null)
      {
        int num = (int) Math.Floor(this.decimal_2 / 5000000M);
        GClass9 gclass9_0_10 = this.gclass0_0.dictionary_41[GEnum105.const_20];
        if (gclass9_0_10 != null && int_14_8 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_10, (GClass102) null, int_14_8, list);
        }
        GClass9 gclass9_0_11 = this.gclass0_0.dictionary_41[GEnum105.const_13];
        if (gclass9_0_11 != null && int_14_8 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.method_1(class1152.gclass21_0, class1151.gclass1_0, gclass9_0_11, (GClass102) null, int_14_8, list);
        }
      }
      int int_14_9 = this.method_0(this.int_11);
      int num1 = this.method_0(this.int_11);
      if (int_14_9 > 0)
      {
        // ISSUE: reference to a compiler-generated method
        GClass102 gclass102_0 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>(new Func<GClass102, bool>(class1152.method_1));
        if (gclass102_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.method_1(class1152.gclass21_0, class1151.gclass1_0, (GClass9) null, gclass102_0, int_14_9, (List<GClass22>) null);
        }
      }
      if (num1 <= 0)
        return;
      // ISSUE: reference to a compiler-generated method
      GClass102 gclass102_0_1 = this.gclass0_0.dictionary_72.Values.FirstOrDefault<GClass102>(new Func<GClass102, bool>(class1152.method_2));
      if (gclass102_0_1 == null)
        return;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.method_1(class1152.gclass21_0, class1151.gclass1_0, (GClass9) null, gclass102_0_1, int_14_9, (List<GClass22>) null);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3884);
    }
  }

  public void method_3(GClass1 gclass1_0_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass174.Class1153 class1153 = new GClass174.Class1153();
    // ISSUE: reference to a compiler-generated field
    class1153.gclass1_0 = gclass1_0_1;
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass174.Class1154 class1154 = new GClass174.Class1154();
      if (this.gclass0_0.int_125 == 1)
      {
        // ISSUE: reference to a compiler-generated field
        this.method_2(class1153.gclass1_0);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class1154.gclass21_0 = this.gclass0_0.dictionary_36.Values.FirstOrDefault<GClass21>((Func<GClass21, bool>) (gclass21_0 => gclass21_0.genum6_0 == GEnum6.const_1));
        // ISSUE: reference to a compiler-generated field
        GClass194 gclass194_1 = class1154.gclass21_0.method_165(GEnum6.const_1);
        // ISSUE: reference to a compiler-generated field
        class1154.gclass146_0 = (GClass146) null;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class1154.gclass202_0 = class1154.gclass21_0.dictionary_0.Values.FirstOrDefault<GClass202>(new Func<GClass202, bool>(class1153.method_0));
        // ISSUE: reference to a compiler-generated field
        if (class1154.gclass202_0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1154.gclass21_0.method_262(class1153.gclass1_0.gclass200_0, 1);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1154.gclass202_0 = class1154.gclass21_0.method_263(class1153.gclass1_0.gclass200_0, class1154.gclass21_0.gclass140_1, "", true);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1154.gclass21_0.method_258(class1153.gclass1_0.gclass200_0, false);
        }
        // ISSUE: reference to a compiler-generated method
        GClass83 gclass83_0 = this.gclass0_0.dictionary_0.Values.FirstOrDefault<GClass83>(new Func<GClass83, bool>(class1154.method_0));
        // ISSUE: reference to a compiler-generated method
        List<GClass22> list1 = this.gclass0_0.dictionary_3.Values.Where<GClass22>(new Func<GClass22, bool>(class1154.method_1)).ToList<GClass22>();
        // ISSUE: reference to a compiler-generated field
        class1154.gclass21_0.gclass20_0.list_3.OrderBy<GClass12, int>((Func<GClass12, int>) (gclass12_0 => gclass12_0.int_0)).ToList<GClass12>();
        int int_136_1 = this.method_0(this.int_5);
        GClass9 gclass9_0_1 = this.gclass0_0.dictionary_41[GEnum105.const_4];
        if (gclass9_0_1 != null && int_136_1 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_1, list1, int_136_1, true);
        }
        int int_136_2 = this.method_0(this.int_6);
        GClass9 gclass9_0_2 = this.gclass0_0.dictionary_41[GEnum105.const_19];
        if (gclass9_0_2 != null && int_136_2 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_2, list1, int_136_2, true);
        }
        int int_136_3 = this.method_0(this.int_7);
        GClass9 gclass9_0_3 = GClass226.smethod_13(4) != 1 ? this.gclass0_0.dictionary_41[GEnum105.const_1] : this.gclass0_0.dictionary_41[GEnum105.const_24];
        if (gclass9_0_3 != null && int_136_3 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_3, list1, int_136_3, false);
          int int_136_4 = this.method_0((int) Math.Floor((double) this.int_7 / 2.0));
          GClass9 gclass9_0_4 = this.gclass0_0.dictionary_41[GEnum105.const_10];
          if (gclass9_0_4 != null && int_136_4 > 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_4, list1, int_136_4, true);
          }
        }
        int int_136_5 = this.method_0(this.int_8);
        GClass9 gclass9_0_5 = GClass226.smethod_13(4) != 1 ? this.gclass0_0.dictionary_41[GEnum105.const_22] : this.gclass0_0.dictionary_41[GEnum105.const_23];
        if (gclass9_0_5 != null && int_136_5 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_5, list1, int_136_5, false);
          int int_136_6 = this.method_0((int) Math.Floor((double) this.int_8 / 2.0));
          GClass9 gclass9_0_6 = this.gclass0_0.dictionary_41[GEnum105.const_21];
          if (gclass9_0_6 != null && int_136_6 > 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_6, list1, int_136_6, true);
          }
        }
        int int_136_7 = this.method_0(this.int_9);
        GClass9 gclass9_0_7 = GClass226.smethod_13(4) != 1 ? this.gclass0_0.dictionary_41[GEnum105.const_6] : this.gclass0_0.dictionary_41[GEnum105.const_25];
        if (gclass9_0_7 != null && int_136_7 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_7, list1, int_136_7, false);
        }
        int int_136_8 = this.method_0(this.int_9);
        GClass9 gclass9_0_8 = this.gclass0_0.dictionary_41[GEnum105.const_66];
        if (gclass9_0_8 != null && int_136_8 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_8, list1, int_136_8, false);
        }
        // ISSUE: reference to a compiler-generated method
        Decimal num1 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1154.method_2)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14 * GClass226.decimal_17));
        if (num1 > 100000M)
        {
          int int_136_9 = (int) Math.Floor(num1 / 100000M);
          GClass9 gclass9_0_9 = this.gclass0_0.dictionary_41[GEnum105.const_5];
          if (gclass9_0_9 != null && int_136_8 > 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, class1153.gclass1_0, gclass83_0, gclass9_0_9, list1, int_136_9, false);
          }
        }
        // ISSUE: reference to a compiler-generated method
        int num2 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1154.method_3)).Sum<GClass40>((Func<GClass40, int>) (gclass40_0 => gclass40_0.gclass22_0.int_63));
        if (num2 > 5000000)
        {
          // ISSUE: reference to a compiler-generated method
          GClass1 gclass1_1 = this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1153.method_1)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0_2 => gclass1_0_2.auroraSystemBodyType_0 == AuroraSystemBodyType.GasGiant || gclass1_0_2.auroraSystemBodyType_0 == AuroraSystemBodyType.Superjovian)).Where<GClass1>((Func<GClass1, bool>) (gclass1_0_3 => gclass1_0_3.dictionary_0.ContainsKey(AuroraElement.Sorium))).OrderByDescending<GClass1, Decimal>((Func<GClass1, Decimal>) (gclass1_0_4 => gclass1_0_4.dictionary_0[AuroraElement.Sorium].decimal_1)).FirstOrDefault<GClass1>();
          if (gclass1_1 != null)
          {
            int int_136_10 = (int) Math.Floor((double) num2 / 5000000.0);
            GClass9 gclass9_0_10 = this.gclass0_0.dictionary_41[GEnum105.const_20];
            if (gclass9_0_10 != null && int_136_8 > 0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, gclass1_1, gclass83_0, gclass9_0_10, list1, int_136_10, true);
            }
            GClass9 gclass9_0_11 = this.gclass0_0.dictionary_41[GEnum105.const_13];
            if (gclass9_0_11 != null && int_136_8 > 0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.method_57(class1154.gclass21_0, gclass194_1, class1154.gclass202_0, gclass1_1, gclass83_0, gclass9_0_11, list1, 1, false);
            }
          }
        }
        int num3 = this.method_0(this.int_11);
        int num4 = this.method_0(this.int_11);
        int num5 = num3 + num4;
        if (num5 > 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class1154.gclass146_0 = class1154.gclass21_0.method_275(class1153.gclass1_0, gclass194_1);
        }
        if (num3 > 0)
        {
          for (int int_72 = 1; int_72 <= num3; ++int_72)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1154.gclass21_0.method_157($"{GClass226.smethod_80(int_72)} {class1153.gclass1_0.method_78(class1154.gclass21_0)} Mech Regiment", GEnum116.const_9, class1154.gclass146_0, gclass194_1, (GClass103) null, false, false).auroraGroundFormationFieldPosition_0 = AuroraGroundFormationFieldPosition.FrontlineDefence;
          }
        }
        if (num4 > 0)
        {
          for (int int_72 = 1; int_72 <= num4; ++int_72)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1154.gclass21_0.method_157($"{GClass226.smethod_80(int_72)} {class1153.gclass1_0.method_78(class1154.gclass21_0)} Planetary Defence Regiment", GEnum116.const_11, class1154.gclass146_0, gclass194_1, (GClass103) null, false, false).auroraGroundFormationFieldPosition_0 = AuroraGroundFormationFieldPosition.RearEchelon;
          }
        }
        if (num5 > 1)
        {
          // ISSUE: reference to a compiler-generated method
          int num6 = (int) Math.Ceiling((double) (int) this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1154.method_4)).Sum<GClass103>((Func<GClass103, Decimal>) (gclass103_0 => gclass103_0.method_34())) / 250000.0);
          if (num6 > 0)
          {
            for (int int_72 = 1; int_72 <= num6; ++int_72)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class1154.gclass21_0.method_157($"{GClass226.smethod_80(int_72)} {class1153.gclass1_0.method_78(class1154.gclass21_0)} Planetary Headquarters", GEnum116.const_10, class1154.gclass146_0, gclass194_1, (GClass103) null, false, false).auroraGroundFormationFieldPosition_0 = AuroraGroundFormationFieldPosition.Support;
            }
            if (num3 > 0)
            {
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.method_540(class1154.gclass146_0, GEnum116.const_10, GEnum116.const_9);
            }
            if (num4 > 0)
            {
              // ISSUE: reference to a compiler-generated field
              this.gclass0_0.method_540(class1154.gclass146_0, GEnum116.const_10, GEnum116.const_11);
            }
          }
        }
        // ISSUE: reference to a compiler-generated method
        Decimal num7 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1154.method_5)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14));
        // ISSUE: reference to a compiler-generated method
        List<GClass130> list2 = this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class1154.method_6)).SelectMany<GClass40, GClass130>((Func<GClass40, IEnumerable<GClass130>>) (gclass40_0 => (IEnumerable<GClass130>) gclass40_0.gclass22_0.list_0)).ToList<GClass130>();
        if (num7 > 0M)
        {
          // ISSUE: reference to a compiler-generated field
          if (class1154.gclass146_0 == null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1154.gclass146_0 = class1154.gclass21_0.method_275(class1153.gclass1_0, gclass194_1);
          }
          if (num1 > 0M)
          {
            // ISSUE: reference to a compiler-generated field
            class1154.gclass146_0.method_65(AuroraInstallationType.RefuellingStation, 1M);
          }
          if (list2.Count > 0)
          {
            // ISSUE: reference to a compiler-generated field
            class1154.gclass146_0.method_65(AuroraInstallationType.OrdnanceTransferStation, 1M);
            // ISSUE: reference to a compiler-generated field
            class1154.gclass146_0.list_1 = this.gclass0_0.method_399(list2, 4);
          }
          int decimal_90 = this.int_12 + GClass226.smethod_13(this.int_13);
          if (decimal_90 > 0)
          {
            // ISSUE: reference to a compiler-generated field
            class1154.gclass146_0.method_65(AuroraInstallationType.TrackingStation, (Decimal) decimal_90);
          }
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        foreach (GClass39 gclass39 in this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1154.method_7)).Where<GClass103>(new Func<GClass103, bool>(class1154.method_8)).SelectMany<GClass103, GClass39>((Func<GClass103, IEnumerable<GClass39>>) (gclass103_0 => (IEnumerable<GClass39>) gclass103_0.list_0)).ToList<GClass39>())
          gclass39.decimal_1 = gclass39.gclass101_0.gclass96_0.decimal_2;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2659);
    }
  }
}
