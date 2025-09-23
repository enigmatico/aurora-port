// Decompiled with JetBrains decompiler
// Type: GClass171
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Windows.Forms;

#nullable disable
public class GClass171
{
  private GClass0 gclass0_0;
  public int int_0;
  public int int_1;
  public string string_0;
  public string string_1;
  public string string_2;
  public string string_3;

  public GClass171(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public GClass230 method_0()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_13, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_3, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.method_493(GEnum122.const_1, this.int_1);
      GClass164 gclass164_4 = this.gclass0_0.dictionary_50[26596];
      GClass164 gclass164_5_1 = this.gclass0_0.dictionary_50[55406];
      if (GClass226.smethod_13(3) < 3)
      {
        GClass230 gclass230 = this.gclass0_0.method_473((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5_1, false, (TextBox) null, (TextBox) null, false);
        return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.Laser, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_473((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5_1, false, (TextBox) null, (TextBox) null, true);
      }
      GClass164 gclass164_5_2 = this.gclass0_0.method_493(GEnum122.const_135, this.int_1);
      GClass230 gclass230_1 = this.gclass0_0.method_473((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5_2, false, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.Laser, gclass230_1.decimal_1, gclass230_1.decimal_3, gclass230_1.decimal_2) ?? this.gclass0_0.method_473((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5_2, false, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2647);
      return (GClass230) null;
    }
  }

  public GClass230 method_1()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_45, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_46, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.method_493(GEnum122.const_1, this.int_1);
      GClass230 gclass230 = this.gclass0_0.method_471((GClass21) null, gclass164_1, gclass164_2, gclass164_3, 4, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.Railgun, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_471((GClass21) null, gclass164_1, gclass164_2, gclass164_3, 4, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2648);
      return (GClass230) null;
    }
  }

  public GClass230 method_2()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_33, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_34, this.int_1);
      GClass164 gclass164_4 = this.gclass0_0.method_493(GEnum122.const_141, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.method_493(GEnum122.const_1, this.int_1);
      GClass164 gclass164_5 = this.gclass0_0.dictionary_50[55406];
      GClass230 gclass230 = this.gclass0_0.method_467((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.ParticleBeam, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_467((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2649);
      return (GClass230) null;
    }
  }

  public GClass230 method_3()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_41, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_42, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.method_493(GEnum122.const_1, this.int_1);
      GClass164 gclass164_4 = this.gclass0_0.method_493(GEnum122.const_177, this.int_1);
      GClass230 gclass230 = this.gclass0_0.method_468((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.MesonCannon, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_468((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2650);
      return (GClass230) null;
    }
  }

  public GClass230 method_4()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_47, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_1, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.dictionary_50[55406];
      GClass230 gclass230 = this.gclass0_0.method_470((GClass21) null, gclass164_1, gclass164_2, gclass164_3, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.Carronade, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_470((GClass21) null, gclass164_1, gclass164_2, gclass164_3, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2651);
      return (GClass230) null;
    }
  }

  public GClass230 method_5()
  {
    try
    {
      GClass164 gclass164_1_1 = this.gclass0_0.method_493(GEnum122.const_95, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_98, this.int_1);
      GClass164 gclass164_1_2 = this.gclass0_0.method_493(GEnum122.const_44, this.int_1);
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_5, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.dictionary_50[26645];
      GClass164 gclass164_4 = this.gclass0_0.dictionary_50[24375];
      GClass230 gclass230_1 = this.gclass0_0.method_466((GClass21) null, gclass164_1_1, gclass164_2, gclass164_3, (TextBox) null, (TextBox) null, false);
      GClass230 gclass230_2 = this.gclass0_0.method_489((GClass21) null, AuroraComponentType.GaussCannon, gclass230_1.decimal_1, gclass230_1.decimal_3, gclass230_1.decimal_2);
      GClass230 gclass230_2_1 = gclass230_1;
      if (gclass230_2 != null)
        gclass230_2_1 = gclass230_2;
      GClass230 gclass230_3 = this.gclass0_0.method_450((GClass21) null, gclass164_1_2, gclass230_2_1, 2, (int) gclass164_1.decimal_0 * 4, 0, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.GaussCannon, gclass230_3.decimal_1, gclass230_3.decimal_3, gclass230_3.decimal_2) ?? this.gclass0_0.method_450((GClass21) null, gclass164_1_2, gclass230_2_1, 2, (int) gclass164_1.decimal_0 * 4, 0, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2652);
      return (GClass230) null;
    }
  }

  public GClass230 method_6()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_14, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_12, this.int_1);
      GClass164 gclass164 = this.gclass0_0.method_493(GEnum122.const_147, this.int_1);
      GClass230 gclass230 = this.gclass0_0.method_455((GClass21) null, gclass164_1, gclass164_2, gclass164.decimal_0, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.Shields, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_455((GClass21) null, gclass164_1, gclass164_2, gclass164.decimal_0, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2653);
      return (GClass230) null;
    }
  }

  public GClass230 method_7()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_27, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_36, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.dictionary_50[26091];
      int decimal_14 = 5 + this.int_1 * 5;
      GClass230 gclass230 = this.gclass0_0.method_457((GClass21) null, gclass164_1, gclass164_2, gclass164_3, 1M, (Decimal) decimal_14, (TextBox) null, (TextBox) null, (GClass187) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.Engine, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_457((GClass21) null, gclass164_1, gclass164_2, gclass164_3, 1M, (Decimal) decimal_14, (TextBox) null, (TextBox) null, (GClass187) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2654);
      return (GClass230) null;
    }
  }

  public GClass230 method_8()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_27, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_36, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.method_493(GEnum122.const_133, this.int_1);
      GClass164 gclass164_4 = this.gclass0_0.method_493(GEnum122.const_146, this.int_1);
      GClass164 gclass164_3_1 = this.gclass0_0.dictionary_50[26091];
      GClass230 gclass230 = this.gclass0_0.method_457((GClass21) null, gclass164_1, gclass164_2, gclass164_3_1, gclass164_3.decimal_0, gclass164_4.decimal_0, (TextBox) null, (TextBox) null, (GClass187) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.Engine, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_457((GClass21) null, gclass164_1, gclass164_2, gclass164_3_1, gclass164_3.decimal_0, gclass164_4.decimal_0, (TextBox) null, (TextBox) null, (GClass187) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2655);
      return (GClass230) null;
    }
  }

  public GClass230 method_9()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_95, this.int_1);
      GClass164 gclass164_5 = this.gclass0_0.method_493(GEnum122.const_44, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.method_493(GEnum122.const_5, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_4, this.int_1);
      GClass164 gclass164_4 = this.gclass0_0.method_493(GEnum122.const_18, this.int_1);
      GClass164 gclass164_6 = this.gclass0_0.method_493(GEnum122.const_51, this.int_1);
      GClass230 gclass230 = this.gclass0_0.method_460((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5, gclass164_6, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.CIWS, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_460((GClass21) null, gclass164_1, gclass164_2, gclass164_3, gclass164_4, gclass164_5, gclass164_6, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2656);
      return (GClass230) null;
    }
  }

  public GClass230 method_10()
  {
    try
    {
      GClass164 gclass164_1 = this.gclass0_0.method_493(GEnum122.const_8, this.int_1);
      GClass164 gclass164_2 = this.gclass0_0.method_493(GEnum122.const_7, this.int_1);
      GClass164 gclass164_3 = this.gclass0_0.method_493(GEnum122.const_6, this.int_1);
      GClass164 gclass164_4 = this.gclass0_0.dictionary_50[33302];
      Decimal decimal_13 = (Decimal) (GClass226.smethod_13(100) + GClass226.smethod_13(100) + 10);
      if (GClass226.smethod_13(3) == 1)
        gclass164_4 = this.gclass0_0.dictionary_50[33303];
      GClass230 gclass230 = this.gclass0_0.method_456((GClass21) null, decimal_13, gclass164_1, gclass164_2, gclass164_3, gclass164_4, (TextBox) null, (TextBox) null, false);
      return this.gclass0_0.method_489((GClass21) null, AuroraComponentType.JumpDrive, gclass230.decimal_1, gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_456((GClass21) null, decimal_13, gclass164_1, gclass164_2, gclass164_3, gclass164_4, (TextBox) null, (TextBox) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2657);
      return (GClass230) null;
    }
  }
}
