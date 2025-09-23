// Decompiled with JetBrains decompiler
// Type: GClass70
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass70
{
  public GClass0 gclass0_0;
  public GClass40 gclass40_0;
  public int int_0;
  public bool bool_0;

  public string SquadronName { get; set; } = "New Squadron";

  public GClass70(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public List<GClass40> method_0()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).ToList<GClass40>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3520);
      return (List<GClass40>) null;
    }
  }

  public Decimal method_1(AuroraComponentType auroraComponentType_0)
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass40 gclass40 in this.method_0())
        num += gclass40.method_157(auroraComponentType_0, true);
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3527);
      return 0M;
    }
  }

  public double method_2()
  {
    try
    {
      double num1 = 0.0;
      foreach (GClass40 gclass40 in this.method_0())
      {
        double num2 = gclass40.method_220();
        if (num2 > num1)
          num1 = num2;
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3524);
      return 0.0;
    }
  }

  public double method_3(Decimal decimal_0)
  {
    try
    {
      double num = 0.0;
      foreach (GClass40 gclass40 in this.method_0())
      {
        GClass71 gclass71 = gclass40.method_213(decimal_0, (GClass36) null);
        if (gclass71.double_0 > num)
          num = gclass71.double_0;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3525);
      return 0.0;
    }
  }

  public double method_4()
  {
    try
    {
      double num1 = 0.0;
      foreach (GClass40 gclass40 in this.method_0())
      {
        double num2 = gclass40.method_178();
        if (num2 > num1)
          num1 = num2;
      }
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3526);
      return 0.0;
    }
  }

  public int method_5()
  {
    try
    {
      List<GClass40> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this && gclass40_1.gclass40_0 == null && gclass40_1.gclass40_3 == null)).ToList<GClass40>();
      return list.Count == 0 ? 1 : (int) list.Min<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_171(false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3522);
      return 1;
    }
  }

  public Decimal method_6()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass40 gclass40 in this.method_0())
        num += gclass40.method_177();
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3523);
      return 0M;
    }
  }

  public GClass55 method_7()
  {
    try
    {
      List<GClass55> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Select<GClass40, GClass55>((Func<GClass40, GClass55>) (gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))).ToList<GClass55>();
      return list.Count == 0 ? (GClass55) null : list.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0 != null)).OrderBy<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.gclass61_0.int_1)).ThenBy<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.int_4)).FirstOrDefault<GClass55>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3521);
      return (GClass55) null;
    }
  }

  public int method_8()
  {
    try
    {
      return this.method_0().Sum<GClass40>((Func<GClass40, int>) (gclass40_0 => gclass40_0.method_124()));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3528);
      return 0;
    }
  }

  public Decimal method_9()
  {
    try
    {
      return (Decimal) (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this && !gclass40_1.gclass22_0.bool_2)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)) * GClass226.decimal_17;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3531);
      return 0M;
    }
  }

  public Decimal method_10()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.MaintenanceModule, false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3532);
      return 0M;
    }
  }

  public int method_11()
  {
    try
    {
      return (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.FuelStorage, false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3533);
      return 0;
    }
  }

  public Decimal method_12()
  {
    try
    {
      return (Decimal) (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_172()));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3529);
      return 0M;
    }
  }

  public Decimal method_13()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.decimal_4));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3530);
      return 0M;
    }
  }

  public Decimal method_14()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.decimal_14));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3534);
      return 0M;
    }
  }

  public int method_15()
  {
    try
    {
      return (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.TroopTransport, false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3535);
      return 0;
    }
  }

  public Decimal method_16()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.CargoHold, false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3536);
      return 0M;
    }
  }

  public Decimal method_17()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.ColonistTransport, false))) + this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass70_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.PassengerModule, false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3537);
      return 0M;
    }
  }
}
