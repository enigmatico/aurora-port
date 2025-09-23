// Decompiled with JetBrains decompiler
// Type: GClass39
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
public class GClass39
{
  #region CompilerGenerated
  [CompilerGenerated]
  private sealed class Class794
  {
    public GClass103 gclass103_0;
    public GClass39 gclass39_0;

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0 && gclass103_1 != this.gclass39_0.gclass103_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class795
  {
    public GClass103 gclass103_0;

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class796
  {
    public GClass103 gclass103_0;
    public GClass39 gclass39_0;

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0 && gclass103_1 != this.gclass39_0.gclass103_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class797
  {
    public GClass103 gclass103_0;

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class798
  {
    public int int_0;

    internal bool method_0(GClass39 gclass39_0)
    {
      return (long) this.int_0 >= gclass39_0.long_0 && (long) this.int_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class799
  {
    public int int_0;

    internal bool method_0(GClass39 gclass39_0)
    {
      return (long) this.int_0 >= gclass39_0.long_0 && (long) this.int_0 <= gclass39_0.long_1;
    }
  }

  [CompilerGenerated]
  private sealed class Class800
  {
    public int int_0;

    internal bool method_0(GClass183 gclass183_0)
    {
      return gclass183_0.int_0 == this.int_0;
    }
  }
  #endregion
  
  public Dictionary<GClass101, GClass104> dictionary_0 = new Dictionary<GClass101, GClass104>();
  public List<int> list_0 = new List<int>();
  public List<GClass21> list_1 = new List<GClass21>();
  public GClass0 gclass0_0;
  public GClass101 gclass101_0;
  public GClass103 gclass103_0;
  public GClass102 gclass102_0;
  public GClass194 gclass194_0;
  public AuroraTargetSelection auroraTargetSelection_0 = AuroraTargetSelection.RandomShip;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5 = 10;
  public int int_6;
  public Decimal decimal_0 = 100M;
  public Decimal decimal_1 = 1M;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public long long_0;
  public long long_1;
  public int int_7;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public bool bool_4;
  public bool bool_5;
  public int int_8;

  public double method_0(int int_9)
  {
    try
    {
      if (int_9 == 0)
        return 1.0;
      int_9 -= this.gclass101_0.int_7;
      return int_9 <= 0 ? 1.0 : Math.Pow(0.75, (double) int_9);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 322);
      return 0.0;
    }
  }

  public double method_1(
    double double_0,
    double double_1,
    double double_2,
    bool bool_6,
    Decimal decimal_5)
  {
    try
    {
      double num1 = (1.0 - double_0 / (double) this.gclass101_0.int_2) * 100.0;
      int num2 = (int) Math.Round((Decimal) this.gclass101_0.int_4 * decimal_5);
      if (double_1 > (double) num2)
        num1 *= (double) num2 / double_1;
      if (num1 < 0.0)
        num1 = 0.0;
      double num3 = num1 * double_2;
      if (num3 <= 0.0)
        return 0.0;
      if (!bool_6)
        return num3;
      if (this.gclass103_0.gclass55_0 != null)
        num3 *= (double) this.gclass103_0.gclass55_0.method_5(GEnum121.const_26);
      return num3 * (double) (this.decimal_0 / 100M);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 323);
      return 0.0;
    }
  }

  public void method_2()
  {
    try
    {
      int num1 = this.int_1 - this.list_0.Count;
      if (num1 <= 0)
        return;
      if (this.auroraTargetSelection_0 != AuroraTargetSelection.RandomShip && this.auroraTargetSelection_0 != AuroraTargetSelection.Fastest && this.auroraTargetSelection_0 != AuroraTargetSelection.SlowestShip && this.auroraTargetSelection_0 != AuroraTargetSelection.LargestShip && this.auroraTargetSelection_0 != AuroraTargetSelection.SmallestShip && this.auroraTargetSelection_0 != AuroraTargetSelection.HighestToHit)
      {
        if (this.auroraTargetSelection_0 != AuroraTargetSelection.Shipyards && this.auroraTargetSelection_0 != AuroraTargetSelection.Population && this.auroraTargetSelection_0 != AuroraTargetSelection.GroundForces)
          return;
        GClass146 gclass146 = (GClass146) null;
        AuroraContactType auroraContactType_0 = AuroraContactType.Population;
        if (this.auroraTargetSelection_0 == AuroraTargetSelection.Population)
          gclass146 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass103_0.gclass146_0.gclass202_0.gclass200_0 && gclass65_0.gclass21_1 == this.gclass103_0.gclass21_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Population)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass146_0.gclass1_0 != this.gclass103_0.gclass146_0.gclass1_0)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.method_28(gclass65_0.double_0, gclass65_0.double_1, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88()) <= (double) this.gclass101_0.int_1)).OrderByDescending<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_0)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).FirstOrDefault<GClass146>();
        else if (this.auroraTargetSelection_0 == AuroraTargetSelection.Shipyards)
        {
          auroraContactType_0 = AuroraContactType.Shipyard;
          gclass146 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass103_0.gclass146_0.gclass202_0.gclass200_0 && gclass65_0.gclass21_1 == this.gclass103_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Shipyard)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.method_28(gclass65_0.double_0, gclass65_0.double_1, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88()) <= (double) this.gclass101_0.int_1)).OrderByDescending<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_0)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).FirstOrDefault<GClass146>();
        }
        else if (this.auroraTargetSelection_0 == AuroraTargetSelection.GroundForces)
        {
          auroraContactType_0 = AuroraContactType.GroundUnit;
          gclass146 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass103_0.gclass146_0.gclass202_0.gclass200_0 && gclass65_0.gclass21_1 == this.gclass103_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.GroundUnit)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass146_0.gclass1_0 != this.gclass103_0.gclass146_0.gclass1_0)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.method_28(gclass65_0.double_0, gclass65_0.double_1, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88()) <= (double) this.gclass101_0.int_1)).OrderByDescending<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_0)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).FirstOrDefault<GClass146>();
        }
        else if (this.auroraTargetSelection_0 == AuroraTargetSelection.STOGroundForces)
        {
          auroraContactType_0 = AuroraContactType.STOGroundUnit;
          gclass146 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass103_0.gclass146_0.gclass202_0.gclass200_0 && gclass65_0.gclass21_1 == this.gclass103_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.STOGroundUnit)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass146_0.gclass1_0 != this.gclass103_0.gclass146_0.gclass1_0)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.method_28(gclass65_0.double_0, gclass65_0.double_1, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88()) <= (double) this.gclass101_0.int_1)).OrderByDescending<GClass65, Decimal>((Func<GClass65, Decimal>) (gclass65_0 => gclass65_0.decimal_0)).Select<GClass65, GClass146>((Func<GClass65, GClass146>) (gclass65_0 => gclass65_0.gclass146_0)).FirstOrDefault<GClass146>();
        }
        if (gclass146 == null)
          return;
        this.bool_1 = true;
        double num2 = this.gclass0_0.method_28(gclass146.method_87(), gclass146.method_88(), this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88());
        double double_9 = this.method_1(num2, 0.0, 1.0, true, 1M);
        int decimal_13 = this.gclass101_0.gclass230_0.method_5((int) num2);
        int num3 = 0;
        int int_137 = 0;
        for (int index1 = 1; index1 <= num1; ++index1)
        {
          this.list_0.Add(this.gclass101_0.int_5);
          for (int index2 = 1; index2 <= this.gclass101_0.gclass230_0.int_7; ++index2)
          {
            if ((double) GClass226.smethod_13(100) <= double_9)
              ++num3;
          }
          int_137 += this.gclass101_0.gclass230_0.int_7;
        }
        string string0 = this.gclass103_0.gclass21_0.dictionary_13[gclass146.int_6].string_0;
        this.gclass0_0.method_1(this.gclass103_0.gclass21_0, (GClass40) null, this.gclass101_0.gclass230_0, (GClass129) null, this, auroraContactType_0, gclass146.int_6, int_137, num3, 0, 0, 0, (Decimal) decimal_13, 0M, num2, double_9, string0, gclass146.gclass21_0, false, false, false, false, false, GEnum62.const_0);
        this.gclass0_0.method_19(AuroraContactType.EWImpact, (Decimal) decimal_13, num3, this.gclass103_0.gclass146_0.gclass202_0.gclass200_0, gclass146.method_87(), gclass146.method_88(), false);
      }
      else
      {
        List<GClass40> list1 = this.gclass0_0.dictionary_1.Values.Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass1_0 != null && gclass85_0.method_35())).SelectMany<GClass85, GClass40>((Func<GClass85, IEnumerable<GClass40>>) (gclass85_0 => (IEnumerable<GClass40>) gclass85_0.method_176())).ToList<GClass40>();
        List<GClass40> list2 = this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.gclass200_0 == this.gclass103_0.gclass146_0.gclass202_0.gclass200_0 && gclass65_0.gclass21_1 == this.gclass103_0.gclass21_0 && gclass65_0.genum10_0 == GEnum10.const_0 && gclass65_0.auroraContactType_0 == AuroraContactType.Ship && gclass65_0.gclass40_0 != null && gclass65_0.decimal_3 == this.gclass0_0.decimal_0)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.gclass40_0.gclass40_0 == null)).Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => this.gclass0_0.method_28(gclass65_0.double_0, gclass65_0.double_1, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88()) <= (double) this.gclass101_0.int_1)).Select<GClass65, GClass40>((Func<GClass65, GClass40>) (gclass65_0 => gclass65_0.gclass40_0)).Except<GClass40>((IEnumerable<GClass40>) list1).ToList<GClass40>();
        if (list2.Count == 0)
          return;
        foreach (GClass40 gclass40 in list2)
          gclass40.method_55(this.gclass103_0.gclass21_0);
        this.bool_1 = true;
        if (list2.Count > 1)
        {
          if (!this.gclass103_0.gclass21_0.bool_0)
          {
            if (this.auroraTargetSelection_0 == AuroraTargetSelection.LargestShip)
              list2 = list2.OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).ToList<GClass40>();
            else if (this.auroraTargetSelection_0 == AuroraTargetSelection.SmallestShip)
              list2 = list2.OrderBy<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)).ToList<GClass40>();
            else if (this.auroraTargetSelection_0 == AuroraTargetSelection.Fastest)
              list2 = list2.OrderByDescending<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.int_35)).ToList<GClass40>();
            else if (this.auroraTargetSelection_0 == AuroraTargetSelection.SlowestShip)
              list2 = list2.OrderBy<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.int_35)).ToList<GClass40>();
            else if (this.auroraTargetSelection_0 == AuroraTargetSelection.RandomShip)
            {
              foreach (GClass40 gclass40 in list2)
                gclass40.int_36 = GClass226.smethod_13(1000);
              list2 = list2.OrderBy<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.int_36)).ToList<GClass40>();
            }
            else if (this.auroraTargetSelection_0 == AuroraTargetSelection.HighestToHit)
            {
              foreach (GClass40 gclass40 in list2)
              {
                double double_2 = this.method_0((int) gclass40.method_156(AuroraJammerType.FireControl));
                double double_0 = this.gclass0_0.method_28(gclass40.gclass85_0.double_2, gclass40.gclass85_0.double_3, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88());
                gclass40.double_1 = this.method_1(double_0, (double) gclass40.gclass85_0.int_6, double_2, false, 1M);
              }
              list2 = list2.OrderByDescending<GClass40, double>((Func<GClass40, double>) (gclass40_0 => gclass40_0.double_1)).ToList<GClass40>();
            }
          }
          else
          {
            foreach (GClass40 gclass40 in list2)
            {
              gclass40.int_36 = GClass226.smethod_13(1000);
              double num4 = this.gclass0_0.method_28(gclass40.gclass85_0.double_2, gclass40.gclass85_0.double_3, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88()) / 1000.0;
              if (num4 < 1.0)
                num4 = 1.0;
              gclass40.double_3 /= num4;
            }
            list2 = list2.OrderByDescending<GClass40, double>((Func<GClass40, double>) (gclass40_0 => gclass40_0.double_3)).ThenBy<GClass40, int>((Func<GClass40, int>) (gclass40_0 => gclass40_0.int_36)).ToList<GClass40>();
          }
        }
        int num5 = this.int_6;
        if (this.int_6 == 0)
          num5 = num1;
        if (this.gclass103_0.gclass21_0.bool_0)
        {
          if (list2[0].gclass22_0.decimal_14 < 10M)
            num5 = 1;
          else if (list2[0].gclass22_0.decimal_14 < 20M)
            num5 = 2;
        }
        int num6 = 0;
label_87:
        using (List<GClass40>.Enumerator enumerator = list2.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            GClass40 current = enumerator.Current;
            double num7 = this.gclass0_0.method_28(current.gclass85_0.double_2, current.gclass85_0.double_3, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88());
            if (num7 > (double) this.gclass101_0.int_1)
              return;
            double double_2 = this.method_0((int) current.method_156(AuroraJammerType.FireControl));
            double double_9 = this.method_1(num7, (double) current.gclass85_0.int_6, double_2, true, 1M);
            int decimal_13 = this.gclass101_0.gclass230_0.method_5((int) num7);
            int num8 = 0;
            int int_137 = 0;
            for (int index3 = 1; index3 <= num5; ++index3)
            {
              this.list_0.Add(this.gclass101_0.int_5);
              for (int index4 = 1; index4 <= this.gclass101_0.gclass230_0.int_7; ++index4)
              {
                if ((double) GClass226.smethod_13(100) <= double_9)
                  ++num8;
              }
              int_137 += this.gclass101_0.gclass230_0.int_7;
              ++num6;
              if (num6 >= num1)
                break;
            }
            string string_10 = this.gclass103_0.gclass21_0.dictionary_12[current.int_8].method_11();
            this.gclass0_0.method_1(this.gclass103_0.gclass21_0, (GClass40) null, this.gclass101_0.gclass230_0, (GClass129) null, this, AuroraContactType.Ship, current.int_8, int_137, num8, 0, 0, 0, (Decimal) decimal_13, 0M, num7, double_9, string_10, current.gclass21_0, false, false, false, false, false, GEnum62.const_0);
            this.gclass0_0.method_19(AuroraContactType.EWImpact, (Decimal) decimal_13, num8, this.gclass103_0.gclass146_0.gclass202_0.gclass200_0, current.gclass85_0.double_2, current.gclass85_0.double_3, false);
            if (num6 >= num1)
              return;
          }
          goto label_87;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 325);
    }
  }

  public GClass39(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public GClass39 method_3(GClass21 gclass21_0, GClass103 gclass103_1, GClass102 gclass102_1)
  {
    try
    {
      GClass39 gclass39_1 = new GClass39(this.gclass0_0);
      GClass39 gclass39_2 = (GClass39) this.MemberwiseClone();
      gclass39_2.int_0 = this.gclass0_0.method_26(GEnum0.const_44);
      gclass39_2.gclass103_0 = gclass103_1;
      gclass39_2.gclass102_0 = gclass102_1;
      gclass39_2.dictionary_0.Clear();
      gclass39_2.list_0.Clear();
      gclass39_2.list_1.Clear();
      return gclass39_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1803);
      return (GClass39) null;
    }
  }

  public Decimal method_4()
  {
    try
    {
      return this.gclass103_0.gclass146_0 == null ? 0M : this.gclass101_0.decimal_2 * (Decimal) this.int_1 / (this.decimal_1 * this.gclass103_0.gclass146_0.gclass1_0.gclass99_0.decimal_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1804);
      return 0M;
    }
  }

  public void method_5(
    GClass1 gclass1_0,
    GClass40 gclass40_0,
    GClass101 gclass101_1,
    int int_9,
    int int_10,
    int int_11,
    int int_12)
  {
    try
    {
      if (this.dictionary_0.ContainsKey(gclass101_1))
      {
        this.dictionary_0[gclass101_1].int_0 += int_9;
        this.dictionary_0[gclass101_1].int_1 += int_10;
        this.dictionary_0[gclass101_1].int_2 += int_11;
        this.dictionary_0[gclass101_1].int_3 += int_12;
      }
      else
      {
        GClass104 gclass104 = new GClass104()
        {
          gclass1_0 = gclass1_0,
          gclass40_0 = gclass40_0,
          gclass101_0 = gclass101_1
        };
        gclass104.string_0 = this.gclass103_0.gclass21_0.method_323(gclass104.gclass101_0);
        gclass104.int_0 = int_9;
        gclass104.int_1 = int_10;
        gclass104.int_2 = int_11;
        gclass104.int_3 = int_12;
        this.dictionary_0.Add(gclass101_1, gclass104);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1805);
    }
  }

  public Decimal method_6(
    GClass39 gclass39_0_1,
    GClass40 gclass40_0,
    GClass1 gclass1_0,
    GClass40 gclass40_1,
    Decimal decimal_5,
    Decimal decimal_6,
    bool bool_6)
  {
    try
    {
      ++this.int_3;
      gclass39_0_1?.method_5(gclass1_0, gclass40_1, this.gclass101_0, 0, 1, 0, 0);
      gclass40_0?.method_58(this.gclass101_0, 0, 1, 0, 0);
      Decimal num1 = this.gclass101_0.method_7();
      Decimal num2 = (Decimal) this.int_1 * this.gclass101_0.decimal_2;
      if (num1 > decimal_5)
      {
        Decimal num3 = GClass226.smethod_64(decimal_5 / num1, 2);
        if ((Decimal) GClass226.smethod_13(100) > num3 * 100M)
          return 0M;
      }
      ++this.int_4;
      gclass39_0_1?.method_5(gclass1_0, gclass40_1, this.gclass101_0, 0, 0, 1, 0);
      gclass40_0?.method_58(this.gclass101_0, 0, 0, 1, 0);
      Decimal num4 = this.gclass101_0.method_8();
      if (num4 > decimal_6)
      {
        Decimal num5 = GClass226.smethod_64(decimal_6 / num4, 2);
        if ((Decimal) GClass226.smethod_13(100) > num5 * 100M)
          return 0M;
      }
      ++this.int_2;
      gclass39_0_1?.method_5(gclass1_0, gclass40_1, this.gclass101_0, 0, 0, 0, 1);
      gclass40_0?.method_58(this.gclass101_0, 0, 0, 0, 1);
      if (this.gclass103_0.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.FrontlineAttack && bool_6)
      {
        if (this.gclass103_0.gclass21_0.genum6_0 != GEnum6.const_1)
          this.decimal_3 -= this.decimal_0 / (Decimal) this.int_1 / 2M;
        if (gclass39_0_1 != null)
          gclass39_0_1.decimal_3 += this.gclass101_0.decimal_2 / num2 / 5M;
      }
      else
      {
        if (this.gclass103_0.gclass21_0.genum6_0 != GEnum6.const_1)
          this.decimal_3 -= this.decimal_0 / (Decimal) this.int_1 / 4M;
        if (gclass39_0_1 != null)
          gclass39_0_1.decimal_3 += this.gclass101_0.decimal_2 / num2 / 10M;
      }
      int num6 = this.gclass101_0.method_6();
      if (num6 > 0)
      {
        GClass55 gclass550 = this.gclass103_0.gclass55_0;
        if (gclass550 != null)
        {
          double num7 = (double) this.gclass103_0.list_0.Sum<GClass39>((Func<GClass39, int>) (gclass39_0_2 => gclass39_0_2.int_1 * gclass39_0_2.gclass101_0.method_6()));
          double num8 = (double) num6 / num7 * 0.25;
          if ((double) GClass226.smethod_13(1000) < num8 * 1000.0)
          {
            if (this.gclass103_0.gclass146_0 != null)
            {
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_63, $"{gclass550.method_17(false)} has been killed due to the destruction of {this.gclass101_0.ClassName} on {this.gclass103_0.gclass146_0.PopName}", this.gclass103_0.gclass21_0, this.gclass103_0.gclass146_0.gclass202_0.gclass200_0, this.gclass103_0.gclass146_0.method_87(), this.gclass103_0.gclass146_0.method_88(), AuroraEventCategory.Combat);
              gclass550.method_46($"Killed due to the destruction of {this.gclass101_0.ClassName} on {this.gclass103_0.gclass146_0.PopName}", GEnum28.const_0);
            }
            else if (this.gclass103_0.gclass40_0 != null)
            {
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_63, $"{gclass550.method_17(false)} has been killed due to the destruction of {this.gclass101_0.ClassName} on {gclass550.gclass21_0.method_267(this.gclass103_0.gclass40_0).string_0}", this.gclass103_0.gclass21_0, this.gclass103_0.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass103_0.gclass40_0.gclass85_0.double_2, this.gclass103_0.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Combat);
              gclass550.method_46($"Killed due to the destruction of {this.gclass101_0.ClassName} on {gclass550.gclass21_0.method_267(this.gclass103_0.gclass40_0).string_0}", GEnum28.const_0);
            }
            gclass550.method_42(AuroraRetirementStatus.KilledGround);
          }
        }
      }
      return this.gclass101_0.decimal_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1806);
      return 0M;
    }
  }

  public bool method_7()
  {
    try
    {
      if (this.gclass101_0.decimal_4 == 0M)
        return true;
      if (this.gclass103_0.decimal_20 > 1M)
      {
        int num = (int) ((this.gclass103_0.decimal_20 - 1M) * 100M);
        if (GClass226.smethod_13(100) <= num)
          return true;
      }
      bool flag = false;
      Decimal decimal_26_1 = this.gclass101_0.decimal_4 * (Decimal) this.int_1 * 0.1M;
      List<GClass103> list = this.method_9().OrderByDescending<GClass103, int>((Func<GClass103, int>) (gclass103_0 => gclass103_0.int_10)).ToList<GClass103>();
      foreach (GClass103 gclass103_2 in list)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass39.Class794 class794 = new GClass39.Class794();
        // ISSUE: reference to a compiler-generated field
        class794.gclass39_0 = this;
        // ISSUE: reference to a compiler-generated field
        class794.gclass103_0 = gclass103_2;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        foreach (GClass103 gclass103_3 in this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class794.method_0)).Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.method_14() == GEnum55.const_9)).Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(new GClass39.Class795()
        {
          gclass103_0 = gclass103_1
        }.method_0)).Count<GClass103>() == 0)).ToList<GClass103>())
        {
          if (flag = gclass103_3.method_20(decimal_26_1, this.gclass103_0))
            break;
        }
        // ISSUE: reference to a compiler-generated field
        if (flag = class794.gclass103_0.method_20(decimal_26_1, this.gclass103_0))
          break;
      }
      if (!flag && this.int_5 > 0)
      {
        flag = true;
        --this.int_5;
      }
      if (flag && this.int_5 < 10)
      {
        Decimal decimal_26_2 = this.gclass101_0.decimal_4 * (Decimal) this.int_1 * ((Decimal) (10 - this.int_5) * 0.1M);
        foreach (GClass103 gclass103 in list)
        {
          if (gclass103.method_20(decimal_26_2, this.gclass103_0))
          {
            this.int_5 = 10;
            break;
          }
        }
      }
      return flag;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1807);
      return false;
    }
  }

  public bool method_8()
  {
    try
    {
      if (this.gclass101_0.decimal_4 == 0M)
        return true;
      bool flag = false;
      Decimal decimal_26 = this.gclass101_0.decimal_4 * (Decimal) this.int_1 * ((Decimal) (10 - this.int_5) * 0.1M);
      if (this.gclass103_0.gclass55_0 != null)
      {
        Decimal num = this.gclass103_0.gclass55_0.method_5(GEnum121.const_20) - 2M;
        decimal_26 = Math.Round(decimal_26 * num, 1);
      }
      foreach (GClass103 gclass103_2 in this.method_9().OrderByDescending<GClass103, int>((Func<GClass103, int>) (gclass103_0 => gclass103_0.int_10)).ToList<GClass103>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass39.Class796 class796 = new GClass39.Class796();
        // ISSUE: reference to a compiler-generated field
        class796.gclass39_0 = this;
        // ISSUE: reference to a compiler-generated field
        class796.gclass103_0 = gclass103_2;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        foreach (GClass103 gclass103_3 in this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class796.method_0)).Where<GClass103>((Func<GClass103, bool>) (gclass103_0 => gclass103_0.method_14() == GEnum55.const_9)).Where<GClass103>((Func<GClass103, bool>) (gclass103_1 => this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(new GClass39.Class797()
        {
          gclass103_0 = gclass103_1
        }.method_0)).Count<GClass103>() == 0)).ToList<GClass103>())
        {
          if (flag = gclass103_3.method_20(decimal_26, this.gclass103_0))
          {
            this.int_5 = 10;
            break;
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (flag = class796.gclass103_0.method_20(decimal_26, this.gclass103_0))
        {
          this.int_5 = 10;
          break;
        }
      }
      return flag;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3543);
      return false;
    }
  }

  public List<GClass103> method_9()
  {
    try
    {
      List<GClass103> list_3 = new List<GClass103>();
      this.gclass103_0.int_10 = 1;
      list_3.Add(this.gclass103_0);
      this.gclass103_0.method_21(list_3, 2);
      return list_3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1808);
      return (List<GClass103>) null;
    }
  }

  public double method_10(GClass40 gclass40_0, List<GClass39> list_2, int int_9, int int_10)
  {
    try
    {
      Decimal num1 = (Decimal) this.int_1 * this.gclass101_0.decimal_2;
      double num2 = 0.0;
      Decimal decimal_26 = 0M;
      for (int index1 = 1; index1 <= this.int_1; ++index1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        GClass39 gclass39 = list_2.FirstOrDefault<GClass39>(new Func<GClass39, bool>(new GClass39.Class798()
        {
          int_0 = GClass226.smethod_13(int_9)
        }.method_0));
        Decimal num3 = (Decimal) GClass226.int_41 * (this.decimal_0 / 100M) * this.gclass103_0.decimal_19;
        if (this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_1))
          num3 *= 2M;
        if (this.gclass101_0.bool_0)
          num3 /= 5M;
        Decimal num4 = (Decimal) int_10 * gclass39.gclass103_0.decimal_18;
        Decimal num5 = num3 / num4;
        foreach (GClass100 gclass100 in this.gclass101_0.list_0)
        {
          if (gclass100.method_1(this.gclass101_0.decimal_1) > 0M)
          {
            Decimal decimal_6 = gclass100.method_2(this.gclass101_0.decimal_1);
            this.method_5((GClass1) null, gclass40_0, gclass39.gclass101_0, gclass100.int_0, 0, 0, 0);
            for (int index2 = 1; index2 <= gclass100.int_0; ++index2)
            {
              num2 += Math.Pow((double) gclass100.decimal_1, 3.0);
              if (!((Decimal) GClass226.smethod_13(10000) > num5))
                decimal_26 += gclass39.method_6(this, (GClass40) null, (GClass1) null, gclass40_0, gclass100.method_1(this.gclass101_0.decimal_1), decimal_6, true);
            }
          }
        }
      }
      if (decimal_26 > 0M)
        this.gclass103_0.method_9(AuroraMeasurementType.GroundForcesDestroyed, decimal_26, true);
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1809);
      return 0.0;
    }
  }

  public void method_11(
    GClass103 gclass103_1,
    GClass39 gclass39_0,
    GClass1 gclass1_0,
    bool bool_6)
  {
    try
    {
      Decimal num1 = (Decimal) this.int_1 * this.gclass101_0.decimal_2;
      Decimal decimal_26 = 0M;
      Decimal num2 = 1M;
      if (gclass1_0.double_7 < this.gclass194_0.double_7 && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_3))
        num2 *= 2M;
      if (gclass1_0.double_7 > this.gclass194_0.double_8 && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_2))
        num2 *= 2M;
      if (gclass1_0.double_15 > this.gclass194_0.double_2 && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_8))
        num2 *= 2M;
      if ((gclass1_0.double_4 > this.gclass194_0.double_11 || gclass1_0.double_4 < this.gclass194_0.double_12) && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_4))
        num2 *= 2M;
      if (gclass1_0.gclass99_0.bool_0 && this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_7))
        num2 /= 2M;
      if (gclass1_0.gclass99_0.bool_1 && this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_6))
        num2 /= 2M;
      if (gclass1_0.gclass99_0.genum111_1 != GEnum111.const_0 && this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_5))
        num2 /= 2M;
      int num3 = this.method_7() ? 1 : 0;
      int num4 = this.int_1;
      if (num3 == 0)
        num4 = (int) Math.Floor((double) this.int_1 / 4.0);
      for (int index1 = 1; index1 <= num4; ++index1)
      {
        GClass39 gclass39 = gclass39_0;
        if (gclass39 == null)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          gclass39 = gclass103_1.list_0.FirstOrDefault<GClass39>(new Func<GClass39, bool>(new GClass39.Class799()
          {
            int_0 = GClass226.smethod_13(gclass103_1.int_9)
          }.method_0));
        }
        Decimal num5;
        Decimal num6;
        if (gclass39.decimal_1 == 1M)
        {
          num5 = (Decimal) GClass226.int_41 * gclass1_0.gclass99_0.decimal_0 * gclass39.gclass101_0.gclass96_0.decimal_3 * (this.decimal_0 / 100M);
          num6 = 1M;
        }
        else
        {
          num5 = (Decimal) GClass226.int_41 * gclass1_0.gclass99_0.decimal_0 * (this.decimal_0 / 100M);
          num6 = gclass1_0.gclass99_0.decimal_1 * gclass39.decimal_1 * gclass39.gclass103_0.decimal_18;
        }
        if (this.gclass101_0.bool_0)
          num5 /= 5M;
        Decimal num7 = num6 * num2;
        Decimal num8 = num5 / num7;
        foreach (GClass100 gclass100 in this.gclass101_0.list_0)
        {
          if (gclass100.method_1(this.gclass101_0.decimal_1) > 0M && (!bool_6 || gclass100.genum53_0 != GEnum53.const_0))
          {
            Decimal decimal_6 = gclass100.method_2(this.gclass101_0.decimal_1);
            this.method_5(gclass1_0, (GClass40) null, gclass39.gclass101_0, gclass100.int_0, 0, 0, 0);
            for (int index2 = 1; index2 <= gclass100.int_0; ++index2)
            {
              gclass39.gclass103_0.gclass146_0.method_38(this.gclass103_0.gclass21_0, Math.Pow((double) gclass100.decimal_1, 3.0));
              if (gclass100.genum53_0 == GEnum53.const_0)
                num8 *= this.gclass103_0.decimal_19;
              else
                num8 *= this.gclass103_0.decimal_22;
              if (!((Decimal) GClass226.smethod_13(10000) > num8))
              {
                decimal_26 += gclass39.method_6(this, (GClass40) null, gclass1_0, (GClass40) null, gclass100.method_1(this.gclass101_0.decimal_1), decimal_6, true);
                gclass39.gclass103_0.gclass21_0.method_22(this.gclass103_0.gclass21_0, -(decimal_26 / 100M), true);
              }
            }
          }
        }
      }
      if (!(decimal_26 > 0M))
        return;
      this.gclass103_0.method_9(AuroraMeasurementType.GroundForcesDestroyed, decimal_26, false);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1810);
    }
  }

  public void method_12(List<GClass40> list_2, GClass1 gclass1_0, GEnum54 genum54_0)
  {
    try
    {
      int num1 = this.method_7() ? 1 : 0;
      Decimal num2 = 1M;
      if (gclass1_0.double_7 < this.gclass194_0.double_7 && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_3))
        num2 *= 2M;
      if (gclass1_0.double_7 > this.gclass194_0.double_8 && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_2))
        num2 *= 2M;
      if (gclass1_0.double_15 > this.gclass194_0.double_2 && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_8))
        num2 *= 2M;
      if ((gclass1_0.double_4 > this.gclass194_0.double_11 || gclass1_0.double_4 < this.gclass194_0.double_12) && !this.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_4))
        num2 *= 2M;
      if (num1 == 0)
        Math.Floor((double) this.int_1 / 4.0);
      for (int index = 1; index <= this.int_1; ++index)
      {
        GClass40 gclass40 = list_2.ElementAt<GClass40>(GClass226.smethod_13(list_2.Count) - 1);
        Decimal num3 = (Decimal) this.gclass101_0.int_4 / gclass40.method_171(true);
        if (num3 > 1M)
          num3 = 1M;
        Decimal num4 = (Decimal) GClass226.int_42 * num3 * (this.decimal_0 / 100M) * this.gclass103_0.decimal_23 / num2;
        foreach (GClass100 gclass100 in this.gclass101_0.list_0)
        {
          if (gclass100.genum54_0 >= genum54_0)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass39.Class800 class800 = new GClass39.Class800();
            if (!((Decimal) GClass226.smethod_13(10000) > num4))
            {
              // ISSUE: reference to a compiler-generated field
              class800.int_0 = gclass100.method_0(this.gclass101_0.decimal_1);
              // ISSUE: reference to a compiler-generated field
              if (class800.int_0 != 0)
              {
                // ISSUE: reference to a compiler-generated method
                GClass183 gclass183_1 = gclass40.list_19.FirstOrDefault<GClass183>(new Func<GClass183, bool>(class800.method_0));
                if (gclass183_1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  GClass183 gclass183_2 = new GClass183(class800.int_0, 1);
                  gclass40.list_19.Add(gclass183_2);
                }
                else
                  ++gclass183_1.int_1;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1811);
    }
  }

  public Decimal method_13()
  {
    try
    {
      this.decimal_2 = (Decimal) this.int_1 * this.gclass101_0.decimal_6;
      if (this.gclass103_0.gclass55_0 != null)
        this.decimal_2 *= this.gclass103_0.gclass55_0.method_5(GEnum121.const_4);
      return this.decimal_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1812);
      return 0M;
    }
  }

  public GClass39 method_14()
  {
    GClass39 gclass39 = new GClass39(this.gclass0_0);
    return (GClass39) this.MemberwiseClone();
  }

  public void method_15(ListView listView_0)
  {
    try
    {
      string string_13 = "-";
      string str = GClass226.smethod_10(this.gclass101_0.int_6);
      int num1 = this.int_1 * this.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_4));
      Decimal num2 = (Decimal) this.int_1 * this.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_3));
      Decimal num3 = (Decimal) this.int_1 * this.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_4));
      Decimal num4 = (Decimal) (this.int_1 * this.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5)));
      string string_20 = "";
      if (str != "-")
        string_20 = $"{string_20}HQ{str}  ";
      if (this.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_2)) > 0)
        string_20 += "ST  ";
      if (this.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_1)) > 0)
        string_20 += "CW  ";
      if (num1 > 0)
        string_20 = $"{string_20}FD{num1.ToString()}  ";
      if (num2 > 0M)
      {
        Decimal d = num2 * this.gclass103_0.gclass21_0.decimal_13 * 100M;
        if (this.gclass103_0.gclass55_0 != null)
          d *= this.gclass103_0.gclass55_0.method_5(GEnum121.const_4);
        string_20 = $"{string_20}CN{num2.ToString()}  FC{Math.Round(d).ToString()}";
      }
      if (num3 > 0M)
        string_20 = $"{string_20}GE{num3.ToString()}  ";
      if (num4 > 0M)
        string_20 = $"{string_20}LG{Math.Round(num4 / 1000M).ToString()}  ";
      if (this.gclass101_0.decimal_4 > 0M)
        string_13 = GClass226.smethod_37(this.int_5 * 10) + "%";
      this.gclass0_0.method_620(listView_0, this.gclass101_0.gclass96_0.string_0, this.gclass101_0.ClassName, GClass226.smethod_37(this.int_1), string_13, GClass226.smethod_38(this.decimal_0), GClass226.smethod_42(this.decimal_1, 2), GClass226.smethod_38(this.gclass101_0.decimal_2 * (Decimal) this.int_1), GClass226.smethod_38(this.gclass101_0.decimal_3 * (Decimal) this.int_1), GClass226.smethod_38(this.gclass101_0.method_8() * (Decimal) this.int_1), GClass226.smethod_38(this.gclass101_0.decimal_4 * (Decimal) this.int_1), string_20, (object) this);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1813);
    }
  }
}
