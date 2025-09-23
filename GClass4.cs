// Decompiled with JetBrains decompiler
// Type: GClass4
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class GClass4
{
  #region CompilerGenerated
  [CompilerGenerated]
  private sealed class Class475
  {
    public Decimal decimal_0;

    public Class475()
    {
      
    }

    internal double method_0(GClass40 gclass40_0)
    {
      return gclass40_0.method_218(this.decimal_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class476
  {
    public GClass4 gclass4_0;
    public GClass22 gclass22_0;

    public Class476()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass85_0 == this.gclass4_0.gclass85_0 && gclass40_0.gclass22_0.gclass14_0 == this.gclass22_0.gclass14_0;
    }

    internal bool method_1(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass4_0.gclass85_0.gclass21_0;
    }

    internal bool method_2(GClass139 gclass139_0)
    {
      return gclass139_0.gclass133_0.genum123_0 == GEnum123.const_2 && gclass139_0.int_2 == this.gclass4_0.gclass85_0.int_3;
    }

    internal bool method_3(GClass40 gclass40_0)
    {
      return gclass40_0.gclass22_0.gclass14_0 == this.gclass22_0.gclass14_0;
    }
  }

  [CompilerGenerated]
  private sealed class Class477
  {
    public Decimal decimal_0;

    public Class477()
    {
      
    }

    internal double method_0(GClass40 gclass40_0)
    {
      return gclass40_0.method_216(this.decimal_0);
    }
  }

  [CompilerGenerated]
  private sealed class Class478
  {
    public GClass11 gclass11_0;

    public Class478()
    {
      
    }

    internal bool method_0(GClass40 gclass40_0)
    {
      return gclass40_0.gclass5_0.genum103_0 != GEnum103.const_4 && gclass40_0.gclass22_0.gclass14_0.genum120_0 == this.gclass11_0.gclass14_0.genum120_0;
    }

    internal bool method_1(GClass40 gclass40_0)
    {
      return gclass40_0.gclass22_0.gclass14_0.genum120_0 == this.gclass11_0.gclass14_0.genum120_0;
    }
  }
  #endregion
  
  private GClass0 gclass0_0;
  private GClass85 gclass85_0;
  public GClass40 gclass40_0;
  public GEnum100 genum100_0;
  public GEnum101 genum101_0 = GEnum101.const_3;
  public GEnum103 genum103_0 = GEnum103.const_3;
  public GEnum102 genum102_0 = GEnum102.const_3;
  public GClass202 gclass202_0;
  public int int_0;
  public double double_0 = -1.0;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public bool bool_4;

  public GClass4(GClass0 gclass0_1, GClass85 gclass85_1)
  {
    this.gclass0_0 = gclass0_1;
    this.gclass85_0 = gclass85_1;
  }

  public void method_0()
  {
    try
    {
      List<GClass40> source = this.gclass85_0.method_176();
      if (this.gclass85_0.gclass187_0 != null)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_17];
      else if (this.gclass85_0.method_125(AuroraComponentType.GravitationalSurveySensors) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_3];
      else if (this.gclass85_0.method_125(AuroraComponentType.GeologicalSurveySensors) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_2];
      else if (this.gclass85_0.method_125(AuroraComponentType.TerraformingModule) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_8];
      else if (this.gclass85_0.method_125(AuroraComponentType.SoriumHarvester) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_18];
      else if (this.gclass85_0.method_125(AuroraComponentType.SalvageModule) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_9];
      else if (this.gclass85_0.method_125(AuroraComponentType.JumpPointStabilisation) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_7];
      else if (this.gclass85_0.method_125(AuroraComponentType.OrbitalMiningModule) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_16];
      else if (this.gclass85_0.method_125(AuroraComponentType.DiplomacyModule) > 0M)
        this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_44];
      else if (!(this.gclass85_0.method_125(AuroraComponentType.MissileFireControl) > 0M) && !(this.gclass85_0.method_125(AuroraComponentType.BeamFireControl) > 0M))
      {
        if (this.gclass85_0.method_125(AuroraComponentType.RefuellingSystem) > 0M)
          this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_13];
        else if (this.gclass85_0.method_125(AuroraComponentType.TroopTransport) > 0M)
          this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_14];
        else if (source.Count == 1)
        {
          if (source.SelectMany<GClass40, GClass228>((Func<GClass40, IEnumerable<GClass228>>) (gclass40_0 => (IEnumerable<GClass228>) gclass40_0.gclass22_0.dictionary_0.Values)).Count<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors && gclass228_0.gclass230_0.decimal_1 >= 3M)) <= 0)
            return;
          this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_5];
        }
        else
        {
          this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_11];
          if (source.Count <= 1)
            return;
          foreach (GClass40 gclass40_0 in source)
          {
            this.gclass85_0.method_75(gclass40_0, GEnum105.const_11, false);
            if (source.Count == 1)
              break;
          }
        }
      }
      else
      {
        Decimal num1 = this.gclass85_0.method_125(AuroraComponentType.MissileFireControl);
        Decimal num2 = this.gclass85_0.method_125(AuroraComponentType.BeamFireControl);
        Decimal num3 = source.Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14 * GClass226.decimal_17));
        Decimal num4 = num2;
        if (num1 > num4)
        {
          if (this.gclass85_0.method_125(AuroraComponentType.Engine) == 0M)
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_19];
          else if (num3 < 30000M)
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_6];
          else if (num3 < 60000M)
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_22];
          else
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_1];
        }
        else
        {
          if (!(num2 > 0M))
            return;
          if (this.gclass85_0.method_125(AuroraComponentType.Engine) == 0M)
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_45];
          else if (num3 < 30000M)
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_25];
          else if (num3 < 60000M)
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_23];
          else
            this.gclass85_0.gclass9_0 = this.gclass0_0.dictionary_41[GEnum105.const_24];
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3398);
    }
  }

  public void method_1(List<GClass117> list_0)
  {
    try
    {
      GClass85 gclass85_5 = list_0.Select<GClass117, GClass85>((Func<GClass117, GClass85>) (gclass117_0 => gclass117_0.gclass40_0.gclass85_0)).Distinct<GClass85>().OrderBy<GClass85, double>((Func<GClass85, double>) (gclass85_1 => this.gclass0_0.method_30(this.gclass85_0.gclass202_0.gclass200_0, gclass85_1.double_2, gclass85_1.double_3, this.gclass85_0.double_2, this.gclass85_0.double_3))).FirstOrDefault<GClass85>();
      if (gclass85_5 == null)
        return;
      this.gclass85_0.method_263();
      this.gclass85_0.method_229(gclass85_5);
      this.gclass85_0.gclass4_0.bool_1 = true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 81);
    }
  }

  public Decimal method_2()
  {
    try
    {
      return this.genum100_0 == GEnum100.const_0 ? 0M : (Decimal) (int) this.genum100_0 / 4M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 82);
      return 0M;
    }
  }

  public void method_3()
  {
    try
    {
      List<GClass40> list = this.gclass85_0.method_176().Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass22_0.int_1 > 0)).ToList<GClass40>();
      foreach (GClass40 gclass40 in list)
        gclass40.bool_8 = false;
      this.method_4(list);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 83);
    }
  }

  public void method_4(List<GClass40> list_0)
  {
    try
    {
      foreach (Decimal num in list_0.SelectMany<GClass40, GClass228>((Func<GClass40, IEnumerable<GClass228>>) (gclass40_0 => (IEnumerable<GClass228>) gclass40_0.gclass22_0.dictionary_0.Values)).Where<GClass228>((Func<GClass228, bool>) (gclass228_0 => gclass228_0.gclass230_0.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors)).Select<GClass228, Decimal>((Func<GClass228, Decimal>) (gclass228_0 => gclass228_0.gclass230_0.decimal_6)).Distinct<Decimal>().ToList<Decimal>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        List<GClass40> list = list_0.OrderByDescending<GClass40, double>(new Func<GClass40, double>(new GClass4.Class475()
        {
          decimal_0 = num
        }.method_0)).ThenBy<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.decimal_1)).ToList<GClass40>();
        if (list.Count != 0)
        {
          list[0].bool_8 = true;
          if (list.Count > 1)
            list[1].bool_8 = true;
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 84);
    }
  }

  public void method_5()
  {
    try
    {
      if (this.gclass85_0.dictionary_0.Count == 0)
      {
        this.gclass202_0 = (GClass202) null;
        this.gclass85_0.gclass4_0.bool_1 = false;
      }
      else
      {
        GClass139 gclass139 = this.gclass85_0.dictionary_0.Values.OrderByDescending<GClass139, int>((Func<GClass139, int>) (gclass139_0 => gclass139_0.int_1)).FirstOrDefault<GClass139>();
        if (gclass139.gclass202_1 != null)
          this.gclass202_0 = gclass139.gclass202_1;
        else
          this.gclass202_0 = gclass139.gclass202_0;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 85);
    }
  }

  public void method_6()
  {
    try
    {
      this.gclass85_0.dictionary_1.Clear();
      this.gclass85_0.method_1(1, this.gclass85_0.gclass9_0.gclass136_0);
      this.gclass85_0.method_1(2, this.gclass85_0.gclass9_0.gclass136_1);
      this.gclass85_0.long_0 = GClass226.long_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 87);
    }
  }

  public bool method_7()
  {
    try
    {
      return this.gclass85_0.gclass9_0.bool_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 88);
      return false;
    }
  }

  public bool method_8(GClass22 gclass22_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass4.Class476 class476 = new GClass4.Class476();
    // ISSUE: reference to a compiler-generated field
    class476.gclass4_0 = this;
    // ISSUE: reference to a compiler-generated field
    class476.gclass22_0 = gclass22_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      int num = this.gclass85_0.gclass9_0.method_2(this.gclass85_0.gclass21_0, class476.gclass22_0.gclass14_0);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return num != 0 && this.gclass0_0.dictionary_4.Values.Where<GClass40>(new Func<GClass40, bool>(class476.method_0)).Count<GClass40>() + this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class476.method_1)).Where<GClass85>((Func<GClass85, bool>) (gclass85_0 => gclass85_0.gclass9_0.genum104_0 == GEnum104.const_11)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).Where<GClass139>(new Func<GClass139, bool>(class476.method_2)).SelectMany<GClass139, GClass40>((Func<GClass139, IEnumerable<GClass40>>) (gclass139_0 => (IEnumerable<GClass40>) gclass139_0.gclass85_0.method_176())).Where<GClass40>(new Func<GClass40, bool>(class476.method_3)).Count<GClass40>() < num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 89);
      return false;
    }
  }

  public bool method_9(GClass117 gclass117_0, List<GClass146> list_0)
  {
    try
    {
      double num1 = -1.0;
      GClass40 gclass40 = (GClass40) null;
      if (gclass117_0 == null)
        return false;
      if (this.gclass85_0.method_25())
      {
        this.gclass85_0.method_230(gclass117_0);
        return true;
      }
      if (gclass40 == null)
        gclass40 = this.method_15(gclass117_0.gclass40_0.method_51());
      if (num1 == -1.0)
        num1 = this.gclass85_0.method_159();
      if (gclass40 == null && num1 <= 0.0)
        return false;
      double num2 = 0.0;
      if (gclass40 != null)
      {
        double num3 = gclass40.gclass5_0.double_1 / (double) gclass40.gclass5_0.gclass129_0.decimal_5;
        double num4 = (double) gclass117_0.gclass115_0.int_2 * num3;
        num2 = gclass40.gclass5_0.double_1 - num4;
      }
      else if (num1 > 0.0)
      {
        double num5 = gclass117_0.gclass115_0.method_7();
        if (num1 > num5 * 1.2)
          num2 = num5 * 1.2;
        else if (num1 > num5 * 1.1)
          num2 = num5 * 1.1;
      }
      this.gclass85_0.method_263();
      if (list_0.Count > 0)
      {
        GClass221 gclass221_0 = this.gclass0_0.method_53(GEnum13.const_7, gclass117_0.gclass40_0.gclass85_0.int_3, gclass117_0.gclass40_0.gclass85_0.gclass202_0.gclass200_0, (GClass120) null, this.gclass85_0, num2, 0M);
        if ((gclass221_0.double_0 != 0.0 || gclass221_0.double_1 != 0.0) && this.method_10(gclass221_0, list_0))
          return true;
      }
      this.gclass85_0.method_225(gclass117_0, (double) (int) num2);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 90);
      return false;
    }
  }

  public bool method_10(GClass221 gclass221_0, List<GClass146> list_0)
  {
    try
    {
      bool flag1 = false;
      int num1 = 0;
      GClass221 gclass221 = new GClass221(gclass221_0.double_0, gclass221_0.double_1);
      double double_11 = this.gclass0_0.method_591(gclass221.double_0, gclass221.double_1, this.gclass85_0.double_2, this.gclass85_0.double_3);
      if (this.gclass85_0.int_9 <= 0)
      {
        this.gclass85_0.bool_22 = GClass226.smethod_23();
        this.gclass85_0.int_9 = 86400;
      }
      while (true)
      {
        bool flag2 = false;
        foreach (GClass146 gclass146 in list_0)
        {
          double num2 = this.gclass0_0.method_28(gclass146.method_87(), gclass146.method_88(), this.gclass85_0.double_2, this.gclass85_0.double_3);
          double num3 = this.gclass0_0.method_517(gclass146.method_87(), gclass146.method_88(), this.gclass85_0.double_2, this.gclass85_0.double_3, gclass221.double_0, gclass221.double_1);
          if (num3 < 500000.0 && num3 < num2)
          {
            flag2 = true;
            break;
          }
        }
        if (flag2)
        {
          ++num1;
          if (num1 != 36)
          {
            if (this.gclass85_0.bool_22)
            {
              double_11 += 10.0;
              if (double_11 >= 360.0)
                double_11 -= 360.0;
            }
            else
            {
              double_11 -= 10.0;
              if (double_11 <= 360.0)
                double_11 += 360.0;
            }
            gclass221 = this.gclass0_0.method_592(this.gclass85_0.double_2, this.gclass85_0.double_3, 100000000.0, double_11);
          }
          else
            goto label_18;
        }
        else
          break;
      }
      if (num1 > 0)
        flag1 = true;
label_18:
      if (!flag1)
        return false;
      GClass214 gclass214_0 = this.gclass85_0.gclass21_0.method_188(this.gclass85_0.gclass202_0.gclass200_0, (GClass1) null, (GClass120) null, WayPointType.Temporary, gclass221.double_0, gclass221.double_1, this.gclass85_0.FleetName + " Manoeuvre Point", 0);
      this.gclass85_0.method_263();
      this.gclass85_0.method_217(gclass214_0, GEnum123.const_1, this.gclass85_0.gclass202_0);
      this.gclass85_0.gclass4_0.bool_1 = true;
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3885);
      return false;
    }
  }

  public bool method_11(GClass117 gclass117_0)
  {
    try
    {
      if (gclass117_0 == null)
        return false;
      double double_11 = this.gclass85_0.gclass4_0.method_16(gclass117_0.gclass40_0.method_51()) * 0.95;
      this.gclass85_0.method_263();
      this.gclass85_0.method_225(gclass117_0, (double) (int) double_11);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 91);
      return false;
    }
  }

  public bool method_12(GClass40 gclass40_1)
  {
    try
    {
      if (gclass40_1 == null)
        return false;
      double double_11 = this.gclass85_0.gclass4_0.method_16(gclass40_1.method_51()) * 0.95;
      this.gclass85_0.method_226(gclass40_1, (double) (int) double_11);
      return true;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 92);
      return false;
    }
  }

  public void method_13()
  {
    try
    {
      if (!this.method_18(this.gclass85_0.method_176()))
        return;
      GClass146 gclass146_1 = this.gclass85_0.method_164();
      if (gclass146_1 == null)
        return;
      this.gclass85_0.method_219(gclass146_1, GEnum123.const_12);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 93);
    }
  }

  public GClass40 method_14(Decimal decimal_0)
  {
    try
    {
      List<GClass40> source = this.gclass85_0.method_176();
      foreach (GClass40 gclass40 in source)
        gclass40.gclass5_0.method_13(decimal_0, false);
      return source.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass5_0.double_1 > 0.0)).OrderByDescending<GClass40, double>((Func<GClass40, double>) (gclass40_0 => gclass40_0.gclass5_0.double_1)).FirstOrDefault<GClass40>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 94);
      return (GClass40) null;
    }
  }

  public GClass40 method_15(Decimal decimal_0)
  {
    try
    {
      List<GClass40> source = this.gclass85_0.method_176();
      foreach (GClass40 gclass40 in source)
        gclass40.gclass5_0.method_13(decimal_0, true);
      return source.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass5_0.double_1 > 0.0)).OrderBy<GClass40, double>((Func<GClass40, double>) (gclass40_0 => gclass40_0.gclass5_0.double_1)).FirstOrDefault<GClass40>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 95);
      return (GClass40) null;
    }
  }

  public double method_16(Decimal decimal_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass4.Class477 class477 = new GClass4.Class477();
    // ISSUE: reference to a compiler-generated field
    class477.decimal_0 = decimal_0;
    try
    {
      List<GClass40> source = this.gclass85_0.method_176();
      // ISSUE: reference to a compiler-generated method
      return source.Count == 0 ? 0.0 : source.Max<GClass40>(new Func<GClass40, double>(class477.method_0));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 96 /*0x60*/);
      return 0.0;
    }
  }

  public void method_17()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass4.Class478 class478 = new GClass4.Class478();
      // ISSUE: reference to a compiler-generated field
      class478.gclass11_0 = this.gclass85_0.gclass9_0.method_1(this.gclass85_0.gclass21_0);
      List<GClass40> source = this.gclass85_0.method_176();
      if (this.gclass85_0.gclass21_0.genum6_0 == GEnum6.const_2)
      {
        this.genum101_0 = GEnum101.const_3;
        this.genum103_0 = GEnum103.const_4;
      }
      else
      {
        double num1 = 0.0;
        foreach (GClass40 gclass40 in source)
          num1 += (double) gclass40.gclass5_0.genum101_0;
        if (num1 == 0.0)
        {
          this.genum101_0 = GEnum101.const_0;
          this.genum100_0 = GEnum100.const_0;
        }
        else
        {
          double num2 = num1 / (double) source.Count;
          this.genum101_0 = num2 <= 2.5 ? (num2 <= 1.5 ? GEnum101.const_1 : GEnum101.const_2) : GEnum101.const_3;
        }
        double num3 = 0.0;
        double num4 = 0.0;
        this.genum103_0 = GEnum103.const_4;
        List<GClass40> list = source.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass5_0.genum103_0 != GEnum103.const_4)).ToList<GClass40>();
        List<GClass40> gclass40List = new List<GClass40>();
        // ISSUE: reference to a compiler-generated field
        if (class478.gclass11_0 != null)
        {
          // ISSUE: reference to a compiler-generated method
          gclass40List = source.Where<GClass40>(new Func<GClass40, bool>(class478.method_0)).ToList<GClass40>();
        }
        if (list.Count > 0)
        {
          foreach (GClass40 gclass40 in list)
            num3 += (double) gclass40.gclass5_0.genum103_0;
          foreach (GClass40 gclass40 in gclass40List)
            num4 += (double) gclass40.gclass5_0.genum103_0;
          if (num3 == 0.0)
            this.genum103_0 = GEnum103.const_0;
          else if (gclass40List.Count > 0 && num4 == 0.0)
          {
            this.genum100_0 = GEnum100.const_0;
            this.genum103_0 = GEnum103.const_0;
          }
          else
          {
            double num5 = num3 / (double) list.Count;
            this.genum103_0 = num5 != 3.0 ? (num5 <= 1.5 ? GEnum103.const_1 : GEnum103.const_2) : GEnum103.const_3;
            if (gclass40List.Count > 0)
            {
              double num6 = num4 / (double) gclass40List.Count;
              if (num6 <= 1.5 && this.genum103_0 > GEnum103.const_1)
                this.genum103_0 = GEnum103.const_1;
              else if (num6 <= 2.5 && this.genum103_0 > GEnum103.const_2)
                this.genum103_0 = GEnum103.const_2;
            }
          }
        }
      }
      double num7 = 0.0;
      foreach (GClass40 gclass40 in source)
        num7 += (double) gclass40.gclass5_0.genum102_0;
      if (num7 == 0.0)
      {
        this.genum102_0 = GEnum102.const_0;
        this.genum100_0 = GEnum100.const_0;
      }
      else
      {
        double num8 = num7 / (double) source.Count;
        this.genum102_0 = num8 <= 2.5 ? (num8 <= 1.5 ? GEnum102.const_1 : GEnum102.const_2) : GEnum102.const_3;
      }
      // ISSUE: reference to a compiler-generated field
      if (class478.gclass11_0 == null)
      {
        this.genum100_0 = GEnum100.const_1;
      }
      else
      {
        if (this.genum100_0 == GEnum100.const_0)
          return;
        // ISSUE: reference to a compiler-generated method
        List<GClass40> list = source.Where<GClass40>(new Func<GClass40, bool>(class478.method_1)).ToList<GClass40>();
        double num9 = 0.0;
        foreach (GClass40 gclass40 in list)
          num9 += (double) gclass40.gclass5_0.genum99_0;
        if (num9 == 0.0)
          this.genum100_0 = GEnum100.const_1;
        else
          this.genum100_0 = GEnum100.const_2;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 97);
    }
  }

  public bool method_18(List<GClass40> list_0)
  {
    try
    {
      foreach (GClass40 gclass40 in list_0)
      {
        if (gclass40.gclass22_0.gclass14_0.genum69_0 > GEnum69.const_0)
        {
          if (gclass40.gclass22_0.list_0.Count == 0)
            return false;
          Decimal num = gclass40.gclass22_0.list_0.Min<GClass130>((Func<GClass130, Decimal>) (gclass130_0 => gclass130_0.gclass129_0.decimal_4));
          if (gclass40.method_208() > num)
            return true;
        }
      }
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 99);
      return false;
    }
  }
}
