// Decompiled with JetBrains decompiler
// Type: GClass36
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class GClass36
{
  [CompilerGenerated]
  private sealed class Class792
  {
    public GClass31 gclass31_0;

    internal bool method_0(GClass30 gclass30_0)
    {
      return gclass30_0.gclass230_0 == this.gclass31_0.gclass230_0 && gclass30_0.int_0 == this.gclass31_0.int_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class793
  {
    public GClass21 gclass21_0;
    public GClass132 gclass132_0;

    internal bool method_0(GClass132 gclass132_1)
    {
      return gclass132_1.gclass21_0 == this.gclass21_0 && gclass132_1.gclass132_0 == this.gclass132_0;
    }
  }
  
  private GClass0 gclass0_0;
  public GClass40 gclass40_0;
  public GClass230 gclass230_0;
  public AuroraContactType auroraContactType_0;
  public AuroraPointDefenceMode auroraPointDefenceMode_0;
  public AuroraPointDefencePriority auroraPointDefencePriority_0 = AuroraPointDefencePriority.PriorityThree;
  public AuroraPointDefenceConcentration auroraPointDefenceConcentration_0 = AuroraPointDefenceConcentration.ThreeShots;
  public int int_0;
  public int int_1;
  public int int_2;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public double double_0;

  public GClass36(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public GClass36 method_0()
  {
    try
    {
      return (GClass36) this.MemberwiseClone();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 291);
      return (GClass36) null;
    }
  }

  public string method_1(GClass40 gclass40_1)
  {
    try
    {
      string str = "";
      double num = this.method_3(gclass40_1);
      return num >= 1000000.0 ? (num >= 10000000.0 ? (num >= 100000000.0 ? $"{str}  (Max {GClass226.smethod_43(num / 1000000.0)}m km)" : $"{str}  (Max {GClass226.smethod_44(num / 1000000.0, 1)}m km)") : $"{str}  (Max {GClass226.smethod_44(num / 1000000.0, 2)}m km)") : $"{str}  (Max {GClass226.smethod_43(num / 1000.0)}k km)";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 292);
      return "error";
    }
  }

  public double method_2(GClass85 gclass85_0)
  {
    try
    {
      if (this.auroraContactType_0 == AuroraContactType.Ship)
      {
        if (!this.gclass0_0.dictionary_4.ContainsKey(this.int_1))
          return -1.0;
        GClass85 gclass850 = this.gclass0_0.dictionary_4[this.int_1].gclass85_0;
        return this.gclass0_0.method_28(gclass85_0.double_2, gclass85_0.double_3, gclass850.double_2, gclass850.double_3);
      }
      if (this.auroraContactType_0 == AuroraContactType.Salvo)
      {
        if (!this.gclass0_0.dictionary_6.ContainsKey(this.int_1))
          return -1.0;
        GClass132 gclass132 = this.gclass0_0.dictionary_6[this.int_1];
        return this.gclass0_0.method_28(gclass85_0.double_2, gclass85_0.double_3, gclass132.double_0, gclass132.double_1);
      }
      if (this.auroraContactType_0 != AuroraContactType.Population && this.auroraContactType_0 != AuroraContactType.GroundUnit && this.auroraContactType_0 != AuroraContactType.STOGroundUnit && this.auroraContactType_0 != AuroraContactType.Shipyard)
        return 0.0;
      if (!this.gclass0_0.dictionary_22.ContainsKey(this.int_1))
        return -1.0;
      GClass146 gclass146 = this.gclass0_0.dictionary_22[this.int_1];
      return this.gclass0_0.method_28(gclass85_0.double_2, gclass85_0.double_3, gclass146.method_87(), gclass146.method_88());
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 293);
      return 0.0;
    }
  }

  public double method_3(GClass40 gclass40_1)
  {
    try
    {
      double num1 = 0.0;
      if (this.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.MissileFireControl)
      {
        if (this.auroraContactType_0 == AuroraContactType.Ship)
        {
          if (this.gclass0_0.dictionary_4.ContainsKey(this.int_1))
            num1 = this.method_4(gclass40_1, this.gclass0_0.dictionary_4[this.int_1], this.gclass230_0);
        }
        else if (this.auroraContactType_0 == AuroraContactType.Salvo)
        {
          if (this.gclass0_0.dictionary_6.ContainsKey(this.int_1))
            num1 = this.method_5(gclass40_1, this.gclass0_0.dictionary_6[this.int_1].gclass129_0, this.gclass230_0);
        }
        else
          num1 = this.gclass230_0.double_0;
      }
      else
        num1 = (double) this.gclass230_0.decimal_3;
      if (num1 == 0.0)
        return 0.0;
      List<GClass31> list = gclass40_1.list_2.Where<GClass31>((Func<GClass31, bool>) (gclass31_0 => gclass31_0.gclass230_1 == this.gclass230_0 && gclass31_0.int_1 == this.int_0)).ToList<GClass31>();
      if (list.Count == 0)
        return 0.0;
      double num2 = 0.0;
      foreach (GClass31 gclass31 in list)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass36.Class792 class792 = new GClass36.Class792();
        // ISSUE: reference to a compiler-generated field
        class792.gclass31_0 = gclass31;
        // ISSUE: reference to a compiler-generated method
        GClass30 gclass30 = gclass40_1.list_5.Where<GClass30>(new Func<GClass30, bool>(class792.method_0)).FirstOrDefault<GClass30>();
        if (gclass30 != null)
        {
          if (gclass30.gclass129_0.double_4 > num2)
            num2 = gclass30.gclass129_0.double_4;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (class792.gclass31_0.gclass230_0.gclass231_0.auroraComponentType_0 != AuroraComponentType.MissileLauncher)
          {
            // ISSUE: reference to a compiler-generated field
            int num3 = class792.gclass31_0.gclass230_0.int_8;
            if (num3 == 0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              num3 = (int) ((Decimal) class792.gclass31_0.gclass230_0.int_6 * class792.gclass31_0.gclass230_0.decimal_17);
            }
            if ((double) num3 > num2)
              num2 = (double) num3;
          }
        }
      }
      if (num2 < num1)
        num1 = num2;
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 294);
      return 0.0;
    }
  }

  public double method_4(GClass40 gclass40_1, GClass40 gclass40_2, GClass230 gclass230_1)
  {
    try
    {
      double num1 = 1.0;
      if (gclass230_1.decimal_6 > gclass40_2.method_51())
        num1 = Math.Pow((double) gclass40_2.method_51() / (double) gclass230_1.decimal_6, 2.0);
      Decimal decimal_29 = gclass40_2.method_156(AuroraJammerType.Sensor);
      if (decimal_29 > 0M)
        gclass40_1.gclass21_0.method_35(gclass40_2, AuroraJammerType.Sensor, decimal_29);
      if (gclass230_1.decimal_13 >= decimal_29)
        return gclass230_1.double_0 * num1;
      double num2 = Math.Pow(0.75, (double) (decimal_29 - gclass230_1.decimal_13));
      return gclass230_1.double_0 * num1 * num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 295);
      return 0.0;
    }
  }

  public double method_5(GClass40 gclass40_1, GClass129 gclass129_0, GClass230 gclass230_1)
  {
    try
    {
      double num1 = 1.0;
      double num2 = (double) gclass129_0.decimal_4;
      if (num2 < 0.33)
        num2 = 0.33;
      if ((double) gclass230_1.decimal_6 > num2)
        num1 = Math.Pow(num2 / (double) gclass230_1.decimal_6, 2.0);
      return gclass230_1.double_0 * num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 296);
      return 0.0;
    }
  }

  public double method_6(GClass40 gclass40_1, int int_3, GClass230 gclass230_1)
  {
    try
    {
      if (int_3 == 0)
        return 1.0;
      if (gclass230_1.decimal_13 > 0M)
      {
        int_3 -= (int) gclass230_1.decimal_13;
        if (int_3 <= 0)
          return 1.0;
      }
      return Math.Pow(0.75, (double) int_3);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 297);
      return 0.0;
    }
  }

  public int method_7(GClass21 gclass21_0, GClass132 gclass132_0_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass36.Class793 class793 = new GClass36.Class793();
    // ISSUE: reference to a compiler-generated field
    class793.gclass21_0 = gclass21_0;
    // ISSUE: reference to a compiler-generated field
    class793.gclass132_0 = gclass132_0_1;
    try
    {
      int num1 = 0;
      if (this.auroraPointDefenceMode_0 == AuroraPointDefenceMode.FiveMissilesPerTarget)
        num1 = 5;
      if (this.auroraPointDefenceMode_0 == AuroraPointDefenceMode.FourMissilesPerTarget)
        num1 = 4;
      if (this.auroraPointDefenceMode_0 == AuroraPointDefenceMode.ThreeMissilesPerTarget)
        num1 = 3;
      if (this.auroraPointDefenceMode_0 == AuroraPointDefenceMode.TwoMissilesPerTarget)
        num1 = 2;
      if (this.auroraPointDefenceMode_0 == AuroraPointDefenceMode.OneMissilePerTarget)
        num1 = 1;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      int num2 = num1 * class793.gclass132_0.dictionary_2.Count - this.gclass0_0.dictionary_6.Values.Where<GClass132>(new Func<GClass132, bool>(class793.method_0)).Select<GClass132, int>((Func<GClass132, int>) (gclass132_0_2 => gclass132_0_2.dictionary_2.Count)).DefaultIfEmpty<int>(0).Sum();
      if (num2 < 0)
        num2 = 0;
      return num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 298);
      return 0;
    }
  }
}
