// Decompiled with JetBrains decompiler
// Type: GClass103
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass103
{
  private sealed class Class1041
  {
    public GClass39 gclass39_0;

    public Class1041()
    {
      
    }

    internal bool method_0(GClass39 gclass39_1)
    {
      return gclass39_1.gclass101_0 == this.gclass39_0.gclass101_0;
    }
  }

  
  private sealed class Class1042
  {
    public int int_0;

    public Class1042()
    {
      
    }

    internal bool method_0(GClass61 gclass61_0)
    {
      return gclass61_0.auroraCommanderType_0 == AuroraCommanderType.GroundForce && gclass61_0.int_1 == this.int_0;
    }
  }

  
  private sealed class Class1043
  {
    public GClass39 gclass39_0;

    public Class1043()
    {
      
    }

    internal bool method_0(GClass39 gclass39_1)
    {
      return gclass39_1.gclass101_0 == this.gclass39_0.gclass101_0;
    }
  }

  
  private sealed class Class1044
  {
    public GClass39 gclass39_0;

    public Class1044()
    {
      
    }

    internal bool method_0(GClass39 gclass39_1)
    {
      return gclass39_1.gclass101_0 == this.gclass39_0.gclass101_0;
    }
  }

  
  private sealed class Class1045
  {
    public GClass40 gclass40_0;

    public Class1045()
    {
      
    }

    internal bool method_0(GClass117 gclass117_0)
    {
      return gclass117_0.gclass40_0 == this.gclass40_0;
    }
  }

  
  private sealed class Class1046
  {
    public GClass103 gclass103_0;
    public GClass103 gclass103_1;

    public Class1046()
    {
      
    }

    internal bool method_0(GClass39 gclass39_0)
    {
      return gclass39_0.gclass101_0.method_1() > 0 && this.gclass103_0.gclass146_0 != null;
    }

    internal bool method_1(GClass39 gclass39_0)
    {
      return this.gclass103_0.gclass146_0 == this.gclass103_1.gclass146_0;
    }

    internal bool method_2(GClass39 gclass39_0)
    {
      return gclass39_0.gclass101_0.method_1() > 0 && gclass39_0.gclass101_0.gclass96_0.genum112_0 == GEnum112.const_6 && this.gclass103_0.gclass146_0 != null;
    }

    internal bool method_3(GClass39 gclass39_0)
    {
      return this.gclass103_0.gclass146_0 == this.gclass103_1.gclass146_0;
    }
  }

  
  private sealed class Class1047
  {
    public GClass103 gclass103_0;
    public GClass146 gclass146_0;
    public GClass40 gclass40_0;

    public Class1047()
    {
      
    }

    internal bool method_0(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0 && gclass103_1.gclass146_0 == this.gclass146_0;
    }

    internal bool method_1(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0 && gclass103_1.gclass40_0 == this.gclass40_0;
    }

    internal bool method_2(GClass103 gclass103_1)
    {
      return gclass103_1.gclass103_0 == this.gclass103_0;
    }
  }

  
  private sealed class Class1048
  {
    public GClass103 gclass103_0;
    public GClass103 gclass103_1;

    public Class1048()
    {
      
    }

    internal bool method_0(GClass103 gclass103_2)
    {
      return gclass103_2.gclass103_0 == this.gclass103_0;
    }

    internal bool method_1(GClass103 gclass103_2)
    {
      return gclass103_2.gclass102_0 == this.gclass103_1.gclass102_0 && gclass103_2.gclass146_0 == this.gclass103_1.gclass146_0 && gclass103_2.gclass146_0 != null;
    }
  }
  
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass61 gclass61_0;
  public GClass146 gclass146_0;
  public GClass40 gclass40_0;
  public GClass55 gclass55_0;
  public GClass103 gclass103_0;
  public GClass103 gclass103_1;
  public GClass103 gclass103_2;
  public GClass102 gclass102_0;
  public GClass102 gclass102_1;
  public List<GClass39> list_0 = new List<GClass39>();
  public List<GClass39> list_1 = new List<GClass39>();
  public Dictionary<GClass101, int> dictionary_0 = new Dictionary<GClass101, int>();
  public Dictionary<GClass101, int> dictionary_1 = new Dictionary<GClass101, int>();
  public AuroraGroundFormationFieldPosition auroraGroundFormationFieldPosition_0;
  public GEnum44 genum44_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4 = 10;
  public int int_5;
  public int int_6;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3;
  public bool bool_4;
  public string string_1;
  private GClass123 gclass123_0;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public Decimal decimal_8;
  public Decimal decimal_9;
  public Decimal decimal_10;
  public Decimal decimal_11;
  public Decimal decimal_12;
  public Decimal decimal_13;
  public Decimal decimal_14;
  public Decimal decimal_15;
  public Decimal decimal_16;
  public Decimal decimal_17;
  private string string_2 = "";
  public string string_3 = "";
  public string string_4 = "Unknown";
  public bool bool_5;
  public int int_7;
  public int int_8;
  public List<GClass40> list_2 = new List<GClass40>();
  public long long_0;
  public long long_1;
  public int int_9;
  public Decimal decimal_18 = 1M;
  public Decimal decimal_19 = 1M;
  public Decimal decimal_20 = 1M;
  public Decimal decimal_21 = 1M;
  public Decimal decimal_22 = 1M;
  public Decimal decimal_23 = 1M;
  public Decimal decimal_24;
  public Decimal decimal_25;
  public bool bool_6;
  public int int_10;

  public string Name { get; set; }

  public GClass103(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public Decimal method_0(GEnum121 genum121_0)
  {
    try
    {
      return this.gclass103_0 == null || this.gclass103_0.gclass146_0 == null || this.gclass103_0.gclass146_0 != this.gclass146_0 || this.gclass103_0.gclass55_0 == null ? 1M : (1M + (this.gclass103_0.gclass55_0.method_5(genum121_0) - 1M) * GClass226.decimal_7 * this.gclass103_0.gclass55_0.decimal_3) * this.gclass103_0.method_0(genum121_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3705);
      return 0M;
    }
  }

  public int method_1(GClass39 gclass39_0, int int_11)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass103.Class1043 class1043 = new GClass103.Class1043();
    // ISSUE: reference to a compiler-generated field
    class1043.gclass39_0 = gclass39_0;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (class1043.gclass39_0.int_1 < int_11)
      {
        // ISSUE: reference to a compiler-generated field
        int_11 = class1043.gclass39_0.int_1;
      }
      // ISSUE: reference to a compiler-generated method
      GClass39 gclass39 = this.list_0.FirstOrDefault<GClass39>(new Func<GClass39, bool>(class1043.method_0));
      if (gclass39 != null)
      {
        // ISSUE: reference to a compiler-generated field
        gclass39.decimal_0 = Math.Floor((gclass39.decimal_0 * (Decimal) gclass39.int_1 + class1043.gclass39_0.decimal_0 * (Decimal) int_11) / (Decimal) (gclass39.int_1 + int_11));
        // ISSUE: reference to a compiler-generated field
        double d = (double) (gclass39.int_5 * gclass39.int_1 + class1043.gclass39_0.int_5 * int_11) / (double) (gclass39.int_1 + int_11);
        gclass39.int_5 = (int) Math.Floor(d);
        gclass39.int_1 += int_11;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.list_0.Add(new GClass39(this.gclass0_0)
        {
          int_0 = this.gclass0_0.method_26(GEnum0.const_44),
          gclass101_0 = class1043.gclass39_0.gclass101_0,
          gclass103_0 = this,
          gclass194_0 = class1043.gclass39_0.gclass194_0,
          int_1 = int_11,
          int_5 = class1043.gclass39_0.int_5,
          decimal_0 = class1043.gclass39_0.decimal_0,
          decimal_1 = class1043.gclass39_0.decimal_1
        });
      }
      // ISSUE: reference to a compiler-generated field
      if (int_11 == class1043.gclass39_0.int_1)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class1043.gclass39_0.gclass103_0.list_0.Remove(class1043.gclass39_0);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class1043.gclass39_0.int_1 -= int_11;
      }
      return int_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3360);
      return 0;
    }
  }

  public bool method_2(GClass103 gclass103_3)
  {
    try
    {
      return (this.gclass146_0 == null || gclass103_3.gclass146_0 == this.gclass146_0) && (this.gclass40_0 == null || gclass103_3.gclass40_0 == this.gclass40_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3229);
      return false;
    }
  }

  public List<GClass65> method_3()
  {
    try
    {
      return this.gclass0_0.dictionary_28.Values.Where<GClass65>((Func<GClass65, bool>) (gclass65_0 => gclass65_0.auroraContactType_0 == AuroraContactType.GroundUnit && gclass65_0.int_1 == this.int_0)).ToList<GClass65>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1759);
      return (List<GClass65>) null;
    }
  }

  public void method_4(GClass146 gclass146_1, List<GClass61> list_3, bool bool_7)
  {
    try
    {
      if (this.gclass55_0 != null)
        this.gclass55_0.method_40(true);
      this.gclass21_0 = gclass146_1.gclass21_0;
      this.gclass146_0 = gclass146_1;
      this.gclass61_0 = list_3.FirstOrDefault<GClass61>((Func<GClass61, bool>) (gclass61_1 => gclass61_1.int_1 == this.gclass61_0.int_1));
      this.gclass103_1 = (GClass103) null;
      this.gclass103_2 = (GClass103) null;
      this.gclass102_0 = (GClass102) null;
      this.gclass102_1 = (GClass102) null;
      foreach (GClass65 gclass65 in this.method_3())
        this.gclass0_0.dictionary_28.Remove(gclass65.int_0);
      if (!bool_7)
        return;
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass103_0 == this)).ToList<GClass103>())
        gclass103.method_4(gclass146_1, list_3, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1760);
    }
  }

  public void method_5(Decimal decimal_26)
  {
    try
    {
      foreach (GClass39 gclass39 in this.list_0)
      {
        int num = (int) Math.Floor((Decimal) gclass39.int_1 * decimal_26);
        if (num != 0)
        {
          gclass39.int_1 -= num;
          this.gclass0_0.gclass92_0.method_2(GEnum126.const_61, $"Due to external damage during boarding combat, {num.ToString()}x {gclass39.gclass101_0.ClassName} from {this.Name} have been lost", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1761);
    }
  }

  public void method_6(GClass103 gclass103_3)
  {
    try
    {
      foreach (GClass39 gclass39_1 in gclass103_3.list_0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass103.Class1044 class1044 = new GClass103.Class1044();
        // ISSUE: reference to a compiler-generated field
        class1044.gclass39_0 = gclass39_1;
        // ISSUE: reference to a compiler-generated method
        GClass39 gclass39_2 = this.list_0.FirstOrDefault<GClass39>(new Func<GClass39, bool>(class1044.method_0));
        if (gclass39_2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          gclass39_2.decimal_0 = Math.Floor((gclass39_2.decimal_0 * (Decimal) gclass39_2.int_1 + class1044.gclass39_0.decimal_0 * (Decimal) class1044.gclass39_0.int_1) / (Decimal) (gclass39_2.int_1 + class1044.gclass39_0.int_1));
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          double d = (double) (gclass39_2.int_5 * gclass39_2.int_1 + class1044.gclass39_0.int_5 * class1044.gclass39_0.int_1) / (double) (gclass39_2.int_1 + class1044.gclass39_0.int_1);
          gclass39_2.int_5 = (int) Math.Floor(d);
          // ISSUE: reference to a compiler-generated field
          gclass39_2.int_1 += class1044.gclass39_0.int_1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.list_0.Add(new GClass39(this.gclass0_0)
          {
            int_0 = this.gclass0_0.method_26(GEnum0.const_44),
            gclass101_0 = class1044.gclass39_0.gclass101_0,
            gclass103_0 = this,
            gclass194_0 = class1044.gclass39_0.gclass194_0,
            int_1 = class1044.gclass39_0.int_1,
            int_5 = class1044.gclass39_0.int_5,
            decimal_0 = class1044.gclass39_0.decimal_0,
            decimal_1 = class1044.gclass39_0.decimal_1
          });
        }
      }
      this.gclass0_0.dictionary_71.Remove(gclass103_3.int_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1762);
    }
  }

  public void method_7(GClass101 gclass101_0, int int_11)
  {
    try
    {
      if (this.dictionary_0.ContainsKey(gclass101_0))
        this.dictionary_0[gclass101_0] = this.dictionary_0[gclass101_0] + int_11;
      else
        this.dictionary_0.Add(gclass101_0, int_11);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1763);
    }
  }

  public void method_8(GClass101 gclass101_0, int int_11)
  {
    try
    {
      if (this.dictionary_1.ContainsKey(gclass101_0))
        this.dictionary_1[gclass101_0] = this.dictionary_1[gclass101_0] + int_11;
      else
        this.dictionary_1.Add(gclass101_0, int_11);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1764);
    }
  }

  public void method_9(
    AuroraMeasurementType auroraMeasurementType_0,
    Decimal decimal_26,
    bool bool_7)
  {
    try
    {
      if (this.gclass55_0 == null)
        return;
      this.gclass55_0.method_1(auroraMeasurementType_0, decimal_26);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1765);
    }
  }

  public bool method_10(GClass139 gclass139_0)
  {
    try
    {
      if (!this.gclass0_0.dictionary_28.ContainsKey(gclass139_0.int_2))
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"{this.Name} (FLT: {this.gclass40_0.gclass85_0.FleetName}) was unable to launch a boarding attempt as the target ship does not exist", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
        return false;
      }
      GClass40 gclass400 = this.gclass0_0.dictionary_28[gclass139_0.int_2].gclass40_0;
      if (gclass400 != null)
        return this.method_11(gclass400);
      this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"{this.Name} (FLT: {this.gclass40_0.gclass85_0.FleetName}) was unable to launch a boarding attempt as the target contact is not a ship", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1766);
      return false;
    }
  }

  public bool method_11(GClass40 gclass40_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass103.Class1045 class1045 = new GClass103.Class1045();
    // ISSUE: reference to a compiler-generated field
    class1045.gclass40_0 = gclass40_1;
    try
    {
      // ISSUE: reference to a compiler-generated field
      if (class1045.gclass40_0.gclass85_0.int_6 > this.gclass40_0.gclass85_0.int_6)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"{this.Name} (FLT: {this.gclass40_0.gclass85_0.FleetName}) was unable to launch a boarding attempt as the target ship is moving faster than the ship from which the formation is making the boarding attempt", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
        return false;
      }
      if (this.list_0.Count<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass101_0.gclass96_0.genum112_0 != 0)) > 0)
      {
        this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"{this.Name} (FLT: {this.gclass40_0.gclass85_0.FleetName}) was unable to launch a boarding attempt as it contains non-infantry elements", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
        return false;
      }
      // ISSUE: reference to a compiler-generated method
      GClass117 gclass117 = this.gclass21_0.dictionary_12.Values.FirstOrDefault<GClass117>(new Func<GClass117, bool>(class1045.method_0));
      // ISSUE: reference to a compiler-generated field
      double num1 = 100.0 * ((double) this.gclass40_0.gclass85_0.int_6 / (double) class1045.gclass40_0.gclass85_0.int_6);
      foreach (GClass39 gclass39 in this.list_0.ToList<GClass39>())
      {
        int num2 = 0;
        double num3 = num1;
        if (gclass39.gclass101_0.dictionary_0.ContainsKey(GEnum113.const_1))
          num3 *= 2.0;
        if (num3 < 1000.0)
        {
          for (int index = 1; index <= gclass39.int_1; ++index)
          {
            if ((double) GClass226.smethod_13(1000) > num3)
              ++num2;
          }
          if (num2 != 0)
          {
            if (gclass39.gclass101_0.int_6 > 0)
            {
              GClass55 gclass550 = this.gclass55_0;
              if (gclass550 != null && GClass226.smethod_13(gclass39.int_1) <= num2)
              {
                this.gclass0_0.gclass92_0.method_2(GEnum126.const_63, $"{gclass550.string_0}( {gclass550.method_17(false)}) has been killed during a boarding attempt on {gclass117.method_11()}", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
                gclass550.method_46("Killed during a boarding attempt on " + gclass117.method_11(), GEnum28.const_0);
                gclass550.method_42(AuroraRetirementStatus.KilledBoarding);
              }
            }
            if (num2 == gclass39.int_1)
            {
              this.list_0.Remove(gclass39);
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"{num2.ToString()}x {gclass39.gclass101_0.ClassName} were lost in the boarding attempt by {this.Name} (FLT: {this.gclass40_0.gclass85_0.FleetName}). No more units of this type remain within the formation", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
              this.gclass40_0 = (GClass40) null;
            }
            else
            {
              gclass39.int_1 -= num2;
              this.gclass0_0.gclass92_0.method_2(GEnum126.const_120, $"{num2.ToString()}x {gclass39.gclass101_0.ClassName} were lost in the boarding attempt by {this.Name} (FLT: {this.gclass40_0.gclass85_0.FleetName}). {gclass39.int_1.ToString()} of this type remain within the formation", this.gclass21_0, this.gclass40_0.gclass85_0.gclass202_0.gclass200_0, this.gclass40_0.gclass85_0.double_2, this.gclass40_0.gclass85_0.double_3, AuroraEventCategory.Ship);
            }
          }
        }
      }
      if (this.list_0.Count == 0)
        return true;
      this.genum44_0 = GEnum44.const_1;
      // ISSUE: reference to a compiler-generated field
      this.gclass40_0 = class1045.gclass40_0;
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1767);
      return false;
    }
  }

  public bool method_12()
  {
    try
    {
      return this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass103_1 == this)).Count<GClass103>() > 0 || this.gclass0_0.dictionary_4.Values.Where<GClass40>((Func<GClass40, bool>) (gclass40_1 => gclass40_1.gclass103_0 == this)).Count<GClass40>() > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1768);
      return false;
    }
  }

  public bool method_13()
  {
    try
    {
      return this.list_0.SelectMany<GClass39, GClass100>((Func<GClass39, IEnumerable<GClass100>>) (gclass39_0 => (IEnumerable<GClass100>) gclass39_0.gclass101_0.list_0)).Count<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_4 > 0M)) > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1769);
      return false;
    }
  }

  public GEnum55 method_14()
  {
    try
    {
      Decimal num1 = 0M;
      Decimal num2 = 0M;
      Decimal num3 = 0M;
      Decimal num4 = 0M;
      Decimal num5 = 0M;
      Decimal num6 = 0M;
      Decimal num7 = 0M;
      Decimal num8 = 0M;
      Decimal num9 = 0M;
      Decimal num10 = 0M;
      Decimal num11 = 0M;
      this.decimal_0 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
      {
        this.decimal_0 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.gclass96_0.genum112_0 == GEnum112.const_5)
          num4 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        else if (gclass39.gclass101_0.gclass96_0.genum112_0 == GEnum112.const_0)
          num2 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        else if (gclass39.gclass101_0.gclass96_0.genum112_0 == GEnum112.const_1)
          num3 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.int_5 > 0)).Count<GClass100>() > 0)
          num1 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.genum53_0 != 0)).Count<GClass100>() > 0)
          num5 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.genum54_0 != 0)).Count<GClass100>() > 0)
          num6 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_3 > 0M)).Count<GClass100>() > 0)
          num7 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_4 > 0M)).Count<GClass100>() > 0)
          num8 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_5 > 0M)).Count<GClass100>() > 0)
          num9 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.decimal_7 > 0M)).Count<GClass100>() > 0)
          num11 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.list_0.Where<GClass100>((Func<GClass100, bool>) (gclass100_0 => gclass100_0.int_2 > 0)).Count<GClass100>() > 0)
          num10 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
      }
      Decimal num12 = this.decimal_0 - num1;
      if (num1 > num12 * 2M)
        return GEnum55.const_9;
      if (num5 > num12 * 0.4M)
        return GEnum55.const_2;
      if (num6 > num12 * 0.4M)
        return GEnum55.const_3;
      if (this.decimal_7 > num12 * 0.4M)
        return GEnum55.const_5;
      if (num8 > num12 * 0.4M)
        return GEnum55.const_6;
      if (num9 > num12 * 0.4M)
        return GEnum55.const_8;
      if (num11 > num12 * 0.4M)
        return GEnum55.const_10;
      if (num10 > num12 * 0.4M)
        return GEnum55.const_7;
      if (num3 > num12 * 0.6M)
        return GEnum55.const_1;
      return num4 > num4 * 0.6M ? GEnum55.const_4 : GEnum55.const_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1770);
      return GEnum55.const_0;
    }
  }

  public TreeNode method_15(TreeView treeView_0, CheckState checkState_0, CheckState checkState_1)
  {
    try
    {
      TreeNode node = new TreeNode();
      node.Text = this.method_25(checkState_0, checkState_1);
      node.Tag = (object) this;
      if (this.gclass103_1 != null && checkState_1 == CheckState.Checked)
        node.ForeColor = GClass226.color_0;
      if (this.bool_5 && checkState_1 == CheckState.Checked)
        node.ForeColor = GClass226.color_1;
      treeView_0.Nodes.Add(node);
      return node;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1771);
      return (TreeNode) null;
    }
  }

  public TreeNode method_16(TreeNode treeNode_0, CheckState checkState_0, CheckState checkState_1)
  {
    try
    {
      TreeNode node = new TreeNode();
      node.Text = this.method_25(checkState_0, checkState_1);
      node.Tag = (object) this;
      if (this.gclass103_1 != null && checkState_1 == CheckState.Checked)
        node.ForeColor = GClass226.color_0;
      if (this.bool_5 && checkState_1 == CheckState.Checked)
        node.ForeColor = GClass226.color_1;
      treeNode_0.Nodes.Add(node);
      return node;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1772);
      return (TreeNode) null;
    }
  }

  public void method_17(TreeNode treeNode_0)
  {
    try
    {
      this.list_0 = this.list_0.OrderByDescending<GClass39, int>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1)).ToList<GClass39>();
      foreach (GClass39 gclass39 in this.list_0)
        treeNode_0.Nodes.Add(new TreeNode()
        {
          Text = $"{gclass39.int_1.ToString()}x {gclass39.gclass101_0.ClassName}",
          Tag = (object) gclass39
        });
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1773);
    }
  }

  public bool method_18(GClass103 gclass103_3_1)
  {
    try
    {
      if (this.gclass146_0.gclass1_0 != gclass103_3_1.gclass146_0.gclass1_0)
      {
        int num = (int) MessageBox.Show("Support can only be provided when the supporting formation is on the same system body as the supported formation", "Support Not Possible");
        return false;
      }
      List<GClass103> list_3 = new List<GClass103>();
      List<GClass103> gclass103List = gclass103_3_1.method_19(list_3);
      if (gclass103List == null)
        return false;
      bool flag = false;
      if (gclass103List.Contains(this))
        flag = true;
      else if (this.gclass103_0 != null && gclass103List.Contains(this.gclass103_0) && this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_3_2 => gclass103_3_2.gclass103_0 == this)).Count<GClass103>() == 0)
        flag = true;
      if (flag)
        return true;
      int num1 = (int) MessageBox.Show("Support can only be provided when the supporting formation is a superior formation in the hierarchy of the supported formation, or is directly subordinate to a superior formation in the hierarchy of the supported formation and does not itself have any subordinate formations (an independent artillery formation for example)", "Support Not Possible");
      return false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1774);
      return false;
    }
  }

  public List<GClass103> method_19(List<GClass103> list_3)
  {
    try
    {
      if (this.gclass103_0 == null)
        return (List<GClass103>) null;
      list_3.Add(this.gclass103_0);
      this.gclass103_0.method_19(list_3);
      return list_3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1775);
      return (List<GClass103>) null;
    }
  }

  public bool method_20(Decimal decimal_26, GClass103 gclass103_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass103.Class1046 class1046 = new GClass103.Class1046();
    // ISSUE: reference to a compiler-generated field
    class1046.gclass103_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1046.gclass103_1 = gclass103_3;
    try
    {
      if (decimal_26 <= 0M)
        return true;
      bool flag = false;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<GClass39> gclass39List = class1046.gclass103_1 != this ? this.list_0.Where<GClass39>(new Func<GClass39, bool>(class1046.method_2)).Where<GClass39>(new Func<GClass39, bool>(class1046.method_3)).OrderByDescending<GClass39, int>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1)).ToList<GClass39>() : this.list_0.Where<GClass39>(new Func<GClass39, bool>(class1046.method_0)).Where<GClass39>(new Func<GClass39, bool>(class1046.method_1)).OrderByDescending<GClass39, int>((Func<GClass39, int>) (gclass39_0 => gclass39_0.int_1)).ToList<GClass39>();
      if (gclass39List.Count == 0)
        return false;
      foreach (GClass39 gclass39 in gclass39List)
      {
        Decimal num1 = (Decimal) gclass39.gclass101_0.method_1();
        if (!(decimal_26 > num1 * (Decimal) gclass39.int_1))
        {
          if (decimal_26 > num1)
          {
            int num2 = (int) Math.Floor(decimal_26 / num1);
            decimal_26 -= (Decimal) num2 * num1;
            gclass39.int_1 -= num2;
          }
          Decimal num3 = decimal_26 / num1 * 1000M;
          if ((Decimal) GClass226.smethod_13(1000) <= num3)
            --gclass39.int_1;
          flag = true;
        }
      }
      this.list_0 = this.list_0.Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.int_1 > 0)).ToList<GClass39>();
      return flag;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1776);
      return false;
    }
  }

  public void method_21(List<GClass103> list_3, int int_11)
  {
    try
    {
      if (this.gclass103_0 == null)
        return;
      this.gclass103_0.int_10 = int_11;
      list_3.Add(this.gclass103_0);
      ++int_11;
      this.gclass103_0.method_21(list_3, int_11);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1777);
    }
  }

  public List<GClass103> method_22(GClass146 gclass146_1, GClass40 gclass40_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass103.Class1047 class1047 = new GClass103.Class1047();
    // ISSUE: reference to a compiler-generated field
    class1047.gclass103_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1047.gclass146_0 = gclass146_1;
    // ISSUE: reference to a compiler-generated field
    class1047.gclass40_0 = gclass40_1;
    try
    {
      List<GClass103> gclass103List1 = new List<GClass103>();
      List<GClass103> gclass103List2 = new List<GClass103>();
      // ISSUE: reference to a compiler-generated field
      if (class1047.gclass146_0 != null)
      {
        // ISSUE: reference to a compiler-generated method
        gclass103List1 = this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1047.method_0)).ToList<GClass103>();
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (GClass103 gclass103 in class1047.gclass40_0 == null ? this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1047.method_2)).ToList<GClass103>() : this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1047.method_1)).ToList<GClass103>())
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        gclass103List2.AddRange((IEnumerable<GClass103>) gclass103.method_22(class1047.gclass146_0, class1047.gclass40_0));
      }
      gclass103List2.Add(this);
      return gclass103List2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1778);
      return (List<GClass103>) null;
    }
  }

  public int method_23()
  {
    try
    {
      Decimal d = 0M;
      foreach (GClass39 gclass39 in this.list_0)
      {
        d += GClass226.smethod_35(gclass39.gclass101_0.decimal_2) * (Decimal) gclass39.int_1 * gclass39.decimal_0 / 10000M;
        if (this.gclass55_0 != null)
          d *= this.gclass55_0.method_5(GEnum121.const_25);
      }
      return (int) Math.Round(d);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1779);
      return 0;
    }
  }

  public void method_24(
    AuroraGroundFormationFieldPosition auroraGroundFormationFieldPosition_1,
    bool bool_7,
    bool bool_8,
    GClass103 gclass103_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass103.Class1048 class1048 = new GClass103.Class1048();
    // ISSUE: reference to a compiler-generated field
    class1048.gclass103_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1048.gclass103_1 = gclass103_3;
    try
    {
      if (!bool_8)
        this.auroraGroundFormationFieldPosition_0 = auroraGroundFormationFieldPosition_1;
      if (this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.FrontlineAttack)
      {
        foreach (GClass39 gclass39 in this.list_0)
          gclass39.decimal_1 = 1M;
      }
      if (bool_7 || bool_8)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1048.method_0)).ToList<GClass103>())
          gclass103.method_24(auroraGroundFormationFieldPosition_1, true, false, (GClass103) null);
      }
      // ISSUE: reference to a compiler-generated field
      if (class1048.gclass103_1 == null)
        return;
      // ISSUE: reference to a compiler-generated method
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>(new Func<GClass103, bool>(class1048.method_1)).ToList<GClass103>())
        gclass103.method_24(auroraGroundFormationFieldPosition_1, false, false, (GClass103) null);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1780);
    }
  }

  public string method_25(CheckState checkState_0, CheckState checkState_1)
  {
    try
    {
      string str = checkState_0 == CheckState.Unchecked || this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.FrontlineDefence ? $"{this.string_1} {this.Name}" : (this.auroraGroundFormationFieldPosition_0 != AuroraGroundFormationFieldPosition.FrontlineAttack ? (this.auroraGroundFormationFieldPosition_0 != AuroraGroundFormationFieldPosition.Support ? (this.auroraGroundFormationFieldPosition_0 != AuroraGroundFormationFieldPosition.RearEchelon ? $"{this.string_1} {this.Name}" : $"{this.string_1} {this.Name}  (RE)") : $"{this.string_1} {this.Name}  (SP)") : $"{this.string_1} {this.Name}  (FA)");
      if (this.bool_2)
        str += " (A)";
      if (this.int_6 == 1)
        str += " (DNR)";
      if (checkState_1 == CheckState.Checked && this.gclass103_1 != null)
        str = $"{str} ---> {this.gclass103_1.string_1} {this.gclass103_1.Name}";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1781);
      return "error";
    }
  }

  public void method_26(bool bool_7, bool bool_8)
  {
    try
    {
      Decimal num1 = 0M;
      Decimal num2 = 0M;
      Decimal num3 = 0M;
      Decimal num4 = 0M;
      this.decimal_0 = 0M;
      this.decimal_1 = 0M;
      this.decimal_2 = 0M;
      this.decimal_3 = 0M;
      this.decimal_4 = 0M;
      this.decimal_5 = 0M;
      this.decimal_6 = 0M;
      this.decimal_7 = 0M;
      this.decimal_8 = 0M;
      this.decimal_9 = 0M;
      this.int_1 = 0;
      this.decimal_13 = 0M;
      this.decimal_14 = 0M;
      this.decimal_15 = 0M;
      this.decimal_17 = 0M;
      this.decimal_10 = 0M;
      this.decimal_11 = 0M;
      this.decimal_16 = 1M;
      this.string_2 = "";
      this.gclass123_0 = new GClass123(this.gclass0_0);
      this.list_1 = this.list_0.ToList<GClass39>();
      if (bool_7)
        this.method_27();
      if (bool_8)
      {
        List<GClass39> list1 = this.list_1.Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass103_0.gclass146_0 != null)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass103_0.gclass146_0 == this.gclass146_0)).ToList<GClass39>();
        List<GClass39> list2 = this.list_1.Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass103_0.gclass40_0 != null)).Where<GClass39>((Func<GClass39, bool>) (gclass39_0 => gclass39_0.gclass103_0.gclass40_0 == this.gclass40_0)).ToList<GClass39>();
        this.list_1 = list1.ToList<GClass39>();
        this.list_1.AddRange((IEnumerable<GClass39>) list2.ToList<GClass39>());
      }
      foreach (GClass39 gclass39 in this.list_1)
      {
        this.decimal_3 += (Decimal) gclass39.int_1;
        this.decimal_0 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        this.decimal_1 += gclass39.gclass101_0.decimal_3 * (Decimal) gclass39.int_1;
        this.decimal_2 += gclass39.gclass101_0.method_8() * (Decimal) gclass39.int_1;
        this.decimal_4 += (Decimal) (gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_0)) * gclass39.int_1);
        this.decimal_13 += gclass39.gclass101_0.decimal_4 * (Decimal) gclass39.int_1;
        num3 += gclass39.decimal_0 * (Decimal) gclass39.int_1 * gclass39.gclass101_0.decimal_2;
        num4 += gclass39.decimal_1 * (Decimal) gclass39.int_1 * gclass39.gclass101_0.decimal_2;
        if (gclass39.gclass101_0.decimal_4 > 0M)
        {
          num1 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
          num2 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1 * ((Decimal) gclass39.int_5 / 10M);
        }
        if (gclass39.gclass101_0.int_6 > this.int_1)
          this.int_1 = gclass39.gclass101_0.int_6;
        this.decimal_7 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.decimal_6;
        this.decimal_10 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_4));
        this.decimal_11 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_5));
        this.decimal_12 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_7));
        this.decimal_9 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_4)));
        this.decimal_6 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_2)));
        this.decimal_5 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_1)));
        this.decimal_17 += (Decimal) (gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, int>) (gclass100_0 => gclass100_0.int_5)));
      }
      if (this.decimal_0 == 0M)
      {
        this.decimal_15 = 0M;
        this.decimal_16 = 1M;
      }
      else
      {
        this.decimal_15 = num3 / this.decimal_0;
        this.decimal_16 = num4 / this.decimal_0;
      }
      if (num1 > 0M)
        this.decimal_14 = num2 / num1;
      string str = GClass226.smethod_10(this.int_1);
      if (str != "-")
        this.string_2 = $"{this.string_2}HQ{str}  ";
      if (this.decimal_6 > 0M)
        this.string_2 = $"{this.string_2}ST{this.decimal_6.ToString()}  ";
      if (this.decimal_5 > 0M)
        this.string_2 = $"{this.string_2}CW{this.decimal_5.ToString()}  ";
      if (this.decimal_9 > 0M)
        this.string_2 = $"{this.string_2}FD{this.decimal_9.ToString()}  ";
      if (this.decimal_7 > 0M)
        this.string_2 = $"{this.string_2}CN{this.decimal_7.ToString()}  ";
      if (this.decimal_10 > 0M)
        this.string_2 = $"{this.string_2}GE{this.decimal_10.ToString()}  ";
      if (this.decimal_11 > 0M)
        this.string_2 = $"{this.string_2}XN{this.decimal_11.ToString()}  ";
      if (this.decimal_12 > 0M)
        this.string_2 = $"{this.string_2}DC{this.decimal_12.ToString()}  ";
      if (!(this.decimal_17 > 0M))
        return;
      this.string_2 = $"{this.string_2}LG{Math.Round(this.decimal_17 / 1000M).ToString()}  ";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1782);
    }
  }

  public void method_27()
  {
    try
    {
      this.list_1.Clear();
      foreach (GClass39 gclass39 in this.list_0)
        this.list_1.Add(gclass39);
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass103_0 == this)).ToList<GClass103>())
      {
        gclass103.method_27();
        foreach (GClass39 gclass39 in gclass103.list_1)
          this.list_1.Add(gclass39);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1783);
    }
  }

  public Decimal method_28()
  {
    try
    {
      Decimal int7 = (Decimal) this.int_7;
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass103_0 == this)).ToList<GClass103>())
        int7 += gclass103.method_28();
      return int7;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3704);
      return 0M;
    }
  }

  public void method_29()
  {
    try
    {
      List<GClass39> gclass39List = new List<GClass39>();
      foreach (GClass39 gclass39_1 in this.list_1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass103.Class1041 class1041 = new GClass103.Class1041();
        // ISSUE: reference to a compiler-generated field
        class1041.gclass39_0 = gclass39_1;
        // ISSUE: reference to a compiler-generated method
        GClass39 gclass39_2 = gclass39List.FirstOrDefault<GClass39>(new Func<GClass39, bool>(class1041.method_0));
        if (gclass39_2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          if (class1041.gclass39_0.decimal_0 != gclass39_2.decimal_0)
          {
            Decimal num1 = gclass39_2.gclass101_0.decimal_2 * (Decimal) gclass39_2.int_1;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Decimal num2 = class1041.gclass39_0.gclass101_0.decimal_2 * (Decimal) class1041.gclass39_0.int_1;
            Decimal num3 = num1 + num2;
            // ISSUE: reference to a compiler-generated field
            Decimal num4 = num1 * gclass39_2.decimal_0 + num2 * class1041.gclass39_0.decimal_0;
            gclass39_2.decimal_0 = num4 / num3;
          }
          // ISSUE: reference to a compiler-generated field
          gclass39_2.int_1 += class1041.gclass39_0.int_1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          GClass39 gclass39_3 = class1041.gclass39_0.method_14();
          gclass39List.Add(gclass39_3);
        }
      }
      this.list_1 = this.gclass21_0.method_161(gclass39List);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1784);
    }
  }

  public void method_30(
    ListView listView_0,
    TextBox textBox_0,
    TextBox textBox_1,
    TextBox textBox_2,
    TextBox textBox_3,
    CheckBox checkBox_0,
    bool bool_7)
  {
    try
    {
      string string_21_1 = "-";
      if (this.gclass55_0 == null)
      {
        textBox_0.Text = "No commander assigned";
      }
      else
      {
        textBox_0.Text = $"{this.gclass55_0.method_36()}    {this.gclass55_0.method_29(true)}";
        string_21_1 = this.gclass55_0.gclass61_0.method_0();
      }
      if (this.gclass40_0 != null)
        textBox_1.Text = this.gclass40_0.method_187();
      else if (this.gclass146_0 != null)
        textBox_1.Text = $"{this.gclass146_0.PopName}  ({this.gclass146_0.gclass202_0.Name})";
      else
        textBox_1.Text = "Location Unknown";
      textBox_2.Text = "None";
      if (this.gclass102_1 != null)
        textBox_2.Text = this.gclass102_1.Name;
      textBox_3.Text = this.int_4.ToString();
      checkBox_0.CheckState = GClass226.smethod_28(this.bool_4);
      listView_0.Items.Clear();
      this.gclass0_0.method_624(listView_0, "Abbr", "Name", "Units", "Supply", "Morale", "Fort", "Size", "Cost", "HP", "GSP", "Formation Attributes", "AR", "RR", (object) null);
      this.gclass0_0.method_594(listView_0, "");
      List<GClass103> list = this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass103_0 == this)).ToList<GClass103>();
      if (bool_7 && this.gclass146_0 != null)
        list = list.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass146_0 == this.gclass146_0)).ToList<GClass103>();
      if (bool_7 && this.gclass40_0 != null)
        list = list.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass40_0 == this.gclass40_0)).ToList<GClass103>();
      if (list.Count > 0)
        this.gclass0_0.method_599(listView_0, "", "Formation and Direct Attachments", GClass226.color_2, (object) null);
      this.method_26(false, false);
      string string_13_1 = "-";
      if (this.decimal_13 > 0M)
        string_13_1 = GClass226.smethod_39(this.decimal_14 * 100M) + "%";
      this.gclass0_0.method_624(listView_0, this.string_1, this.Name, GClass226.smethod_38(this.decimal_3), string_13_1, GClass226.smethod_38(this.decimal_15), GClass226.smethod_42(this.decimal_16, 2), GClass226.smethod_38(this.decimal_0), GClass226.smethod_38(this.decimal_1), GClass226.smethod_38(this.decimal_2), GClass226.smethod_38(this.decimal_13), this.string_2, string_21_1, this.method_32().method_0(), (object) this);
      if (list.Count > 0)
      {
        foreach (GClass103 object_1 in list)
        {
          string string_21_2 = object_1.gclass55_0 != null ? object_1.gclass55_0.gclass61_0.method_0() : "-";
          object_1.method_26(true, bool_7);
          string string_13_2 = "-";
          if (object_1.decimal_13 > 0M)
            string_13_2 = GClass226.smethod_39(object_1.decimal_14 * 100M) + "%";
          this.gclass0_0.method_624(listView_0, object_1.string_1, "      " + object_1.Name, GClass226.smethod_38(object_1.decimal_3), string_13_2, GClass226.smethod_38(object_1.decimal_15), GClass226.smethod_42(object_1.decimal_16, 2), GClass226.smethod_38(object_1.decimal_0), GClass226.smethod_38(object_1.decimal_1), GClass226.smethod_38(object_1.decimal_2), GClass226.smethod_38(object_1.decimal_13), object_1.string_2, string_21_2, object_1.method_32().method_0(), (object) object_1);
        }
        this.method_26(true, bool_7);
        string string_13_3 = "-";
        if (this.decimal_13 > 0M)
          string_13_3 = GClass226.smethod_39(this.decimal_14 * 100M) + "%";
        this.gclass0_0.method_594(listView_0, "");
        this.gclass0_0.method_620(listView_0, "", "Total Organization", GClass226.smethod_38(this.decimal_3), string_13_3, GClass226.smethod_38(this.decimal_15), GClass226.smethod_42(this.decimal_16, 2), GClass226.smethod_38(this.decimal_0), GClass226.smethod_38(this.decimal_1), GClass226.smethod_38(this.decimal_2), GClass226.smethod_38(this.decimal_13), this.string_2, (object) this);
      }
      this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_599(listView_0, "", "Formation Unit List", GClass226.color_2, (object) null);
      this.list_0 = this.gclass21_0.method_161(this.list_0);
      foreach (GClass39 gclass39 in this.list_0)
        gclass39.method_15(listView_0);
      if (list.Count <= 0)
        return;
      this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_599(listView_0, "", "Complete Organization Unit List", GClass226.color_2, (object) null);
      this.method_27();
      this.method_29();
      foreach (GClass39 gclass39 in this.list_1)
        gclass39.method_15(listView_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1785);
    }
  }

  public int method_31()
  {
    try
    {
      if (this.gclass61_0 != null)
        return this.gclass61_0.int_1;
      int int_57 = this.method_33();
      this.decimal_0 = this.method_34();
      GClass61 gclass61 = this.gclass21_0.method_156((int) this.decimal_0, int_57);
      foreach (GClass103 gclass103 in this.gclass0_0.dictionary_71.Values.Where<GClass103>((Func<GClass103, bool>) (gclass103_3 => gclass103_3.gclass103_0 == this)).ToList<GClass103>())
      {
        if (gclass103.gclass55_0 != null && gclass103.gclass55_0.gclass61_0.int_1 <= gclass61.int_1)
          gclass61 = gclass103.gclass55_0.gclass61_0.method_1();
      }
      return gclass61 != null ? gclass61.int_1 : 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1786);
      return 1;
    }
  }

  public GClass61 method_32()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return this.gclass21_0.dictionary_1.Values.Where<GClass61>(new Func<GClass61, bool>(new GClass103.Class1042()
      {
        int_0 = this.method_31()
      }.method_0)).FirstOrDefault<GClass61>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1787);
      return (GClass61) null;
    }
  }

  public int method_33()
  {
    try
    {
      return this.list_0.Count == 0 ? 0 : this.list_0.Max<GClass39>((Func<GClass39, int>) (gclass39_0 => gclass39_0.gclass101_0.int_6));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1788);
      return 0;
    }
  }

  public Decimal method_34()
  {
    try
    {
      this.decimal_0 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        this.decimal_0 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
      return this.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1789);
      return 0M;
    }
  }

  public Decimal method_35(GClass21 gclass21_1)
  {
    try
    {
      this.decimal_0 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
      {
        if (gclass39.list_1.Contains(gclass21_1))
          this.decimal_0 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
      }
      return this.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1790);
      return 0M;
    }
  }

  public Decimal method_36()
  {
    try
    {
      if (this.gclass146_0 == null)
        return 0M;
      this.decimal_0 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        this.decimal_0 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1 / (gclass39.decimal_1 * this.gclass146_0.gclass1_0.gclass99_0.decimal_1);
      return this.decimal_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1791 /*0x06FF*/);
      return 0M;
    }
  }

  public Decimal method_37()
  {
    try
    {
      Decimal num = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        num += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_2 * (100M / gclass39.decimal_0);
      return num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1792 /*0x0700*/);
      return 0M;
    }
  }

  public Decimal method_38()
  {
    try
    {
      if (this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.Support || this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.RearEchelon)
        return 0M;
      Decimal num1 = 0M;
      Decimal num2 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
      {
        num2 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1;
        if (gclass39.gclass101_0.gclass96_0.genum112_0 != GEnum112.const_5)
        {
          Decimal num3 = 1M;
          if (gclass39.gclass101_0.gclass96_0.genum112_0 == GEnum112.const_0)
            num3 = 0.5M;
          num1 += gclass39.gclass101_0.decimal_2 * (Decimal) gclass39.int_1 * (gclass39.decimal_0 / 100M) * num3;
        }
      }
      if (num2 == 0M)
        return 0M;
      if (this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.FrontlineAttack)
        num1 *= 2M;
      return num1 / num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1793);
      return 0M;
    }
  }

  public int method_39()
  {
    try
    {
      this.decimal_0 = this.method_34();
      if (this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.FrontlineDefence || this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.FrontlineAttack)
        return (int) Math.Round(this.decimal_0);
      if (this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.Support)
        return (int) Math.Round(this.decimal_0 / 4M);
      return this.auroraGroundFormationFieldPosition_0 == AuroraGroundFormationFieldPosition.RearEchelon ? (int) Math.Round(this.decimal_0 / 20M) : (int) Math.Round(this.decimal_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1794);
      return 0;
    }
  }

  public Decimal method_40(bool bool_7)
  {
    try
    {
      this.decimal_7 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
      {
        if (!gclass39.bool_4 || !bool_7)
          this.decimal_7 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.decimal_6;
      }
      if (this.decimal_7 == 0M)
        return 0M;
      if (this.gclass55_0 != null)
        this.decimal_7 *= this.gclass55_0.method_3(GEnum121.const_4);
      return this.decimal_7;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1795);
      return 0M;
    }
  }

  public Decimal method_41()
  {
    try
    {
      this.decimal_10 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        this.decimal_10 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_4));
      if (this.gclass55_0 != null)
        this.decimal_10 *= this.gclass55_0.method_3(GEnum121.const_1);
      return this.decimal_10;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1796);
      return 0M;
    }
  }

  public Decimal method_42()
  {
    try
    {
      this.decimal_11 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        this.decimal_11 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_5));
      if (this.gclass55_0 != null)
        this.decimal_11 *= this.gclass55_0.method_3(GEnum121.const_14);
      return this.decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1797);
      return 0M;
    }
  }

  public Decimal method_43()
  {
    try
    {
      this.decimal_12 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        this.decimal_12 += (Decimal) gclass39.int_1 * gclass39.gclass101_0.list_0.Sum<GClass100>((Func<GClass100, Decimal>) (gclass100_0 => gclass100_0.decimal_7));
      if (this.gclass55_0 != null)
        this.decimal_12 *= this.gclass55_0.method_3(GEnum121.const_33);
      return this.decimal_12;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1797);
      return 0M;
    }
  }

  public Decimal method_44()
  {
    try
    {
      this.decimal_1 = 0M;
      foreach (GClass39 gclass39 in this.list_0)
        this.decimal_1 += gclass39.gclass101_0.decimal_3 * (Decimal) gclass39.int_1;
      return this.decimal_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1798);
      return 0M;
    }
  }

  public string method_45()
  {
    try
    {
      return $"{this.string_1} {this.Name}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1799);
      return "Error";
    }
  }

  public string method_46()
  {
    try
    {
      if (this.gclass146_0 != null)
        return this.gclass146_0.PopName;
      return this.gclass40_0 != null ? this.gclass40_0.method_187() : "Unknown";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1800);
      return "Error";
    }
  }

  public void method_47()
  {
    try
    {
      this.string_3 = "";
      if (this.gclass55_0 != null)
        this.string_3 = $"{this.gclass55_0.gclass61_0.string_0} {this.gclass55_0.string_0}   {this.gclass55_0.method_29(true)}";
      this.string_4 = "Unknown";
      if (this.gclass146_0 != null)
        this.string_4 = this.gclass146_0.PopName;
      if (this.gclass40_0 == null)
        return;
      this.string_4 = this.gclass40_0.method_187();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1802);
    }
  }
}
