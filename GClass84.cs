// Decompiled with JetBrains decompiler
// Type: GClass84
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass84
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass85 gclass85_0;
  public GClass84 gclass84_0;
  public int int_0;
  public int int_1;
  public bool bool_0;
  public string string_0;
  public GClass85 gclass85_1;
  public GClass117 gclass117_0;
  public int int_2;
  public int int_3;
  public int int_4;
  public double double_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;

  public GClass84(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public List<GClass40> method_0()
  {
    return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).ToList<GClass40>();
  }

  public Decimal method_1()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.ColonistTransport, false))) + this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.PassengerModule, false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3479);
      return 0M;
    }
  }

  public int method_2()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, int>) (gclass40_0 => gclass40_0.method_124()));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3472);
      return 0;
    }
  }

  public Decimal method_3()
  {
    return (Decimal) (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this && !gclass40_0.gclass22_0.bool_2)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.gclass22_0.decimal_14)) * GClass226.decimal_17;
  }

  public Decimal method_4()
  {
    return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.MaintenanceModule, false)));
  }

  public int method_5()
  {
    return (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.FuelStorage, false)));
  }

  public Decimal method_6()
  {
    try
    {
      return (Decimal) (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_172()));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3481);
      return 0M;
    }
  }

  public Decimal method_7()
  {
    try
    {
      return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.decimal_4));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3484);
      return 0M;
    }
  }

  public Decimal method_8()
  {
    return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.decimal_14));
  }

  public int method_9()
  {
    return (int) this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.TroopTransport, false)));
  }

  public Decimal method_10()
  {
    return this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Sum<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_157(AuroraComponentType.CargoHold, false)));
  }

  public double method_11()
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
      GClass226.smethod_74(ex, 3470);
      return 0.0;
    }
  }

  public double method_12()
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
      GClass226.smethod_74(ex, 3469);
      return 0.0;
    }
  }

  public double method_13(Decimal decimal_0)
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
      GClass226.smethod_74(ex, 3468);
      return 0.0;
    }
  }

  public Decimal method_14()
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
      GClass226.smethod_74(ex, 3467);
      return 0M;
    }
  }

  public int method_15()
  {
    try
    {
      List<GClass40> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this && gclass40_0.gclass40_0 == null && gclass40_0.gclass40_3 == null)).ToList<GClass40>();
      return list.Count == 0 ? 1 : (int) list.Min<GClass40>((Func<GClass40, Decimal>) (gclass40_0 => gclass40_0.method_171(false)));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3466);
      return 1;
    }
  }

  public GClass55 method_16()
  {
    try
    {
      List<GClass55> list = this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_0 => gclass40_0.gclass84_0 == this)).Select<GClass40, GClass55>((Func<GClass40, GClass55>) (gclass40_0 => gclass40_0.method_192(AuroraCommandType.Ship))).ToList<GClass55>();
      return list.Count == 0 ? (GClass55) null : list.Where<GClass55>((Func<GClass55, bool>) (gclass55_0 => gclass55_0 != null)).OrderBy<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.gclass61_0.int_1)).ThenBy<GClass55, int>((Func<GClass55, int>) (gclass55_0 => gclass55_0.int_4)).FirstOrDefault<GClass55>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3465);
      return (GClass55) null;
    }
  }

  public void method_17(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      if (this.gclass85_1 == null)
        this.gclass0_0.method_601(listView_0, "Anchor Fleet", "None", (string) null);
      else
        this.gclass0_0.method_601(listView_0, "Anchor Fleet", this.gclass85_1.FleetName, (string) null);
      this.gclass0_0.method_601(listView_0, "Desired Distance", GClass226.smethod_59(this.double_0, "km"), (string) null);
      this.gclass0_0.method_601(listView_0, "Desired Bearing Offset", GClass226.smethod_58(this.int_4, "°"), (string) null);
      if (this.gclass117_0 == null)
        this.gclass0_0.method_601(listView_0, "Specific Threat", "None", (string) null);
      else
        this.gclass0_0.method_601(listView_0, "Specific Threat", this.gclass117_0.method_11(), (string) null);
      this.gclass0_0.method_601(listView_0, "Guard vs Nearest Hostile Warship", GClass226.smethod_70(this.bool_2), (string) null);
      this.gclass0_0.method_601(listView_0, "Guard vs Nearest Hostile Contact", GClass226.smethod_70(this.bool_1), (string) null);
      this.gclass0_0.method_601(listView_0, "Use Anchor Fleet Destination", GClass226.smethod_70(this.bool_3), (string) null);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3363);
    }
  }

  public void method_18(GClass85 gclass85_2)
  {
    try
    {
      this.gclass85_0 = gclass85_2;
      this.gclass21_0.method_270(this.method_0(), this.gclass85_0, gclass85_2, false, false);
      foreach (GClass84 gclass84 in this.gclass0_0.dictionary_2.Values.Where<GClass84>((Func<GClass84, bool>) (gclass84_1 => gclass84_1.gclass84_0 == this)).ToList<GClass84>())
        gclass84.method_18(gclass85_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3221);
    }
  }
}
