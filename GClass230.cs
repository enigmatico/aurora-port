// Decompiled with JetBrains decompiler
// Type: GClass230
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;

#nullable disable
// TODO: high chance of technology (Sensor)
public class GClass230
{
  public List<GClass164> list_0 = new List<GClass164>();
  public List<GClass164> list_1 = new List<GClass164>();
  public GClass164 gclass164_0;
  public GClass230 gclass230_0;
  public GClass231 gclass231_0;
  public GClass123 gclass123_0;
  public GClass185 gclass185_0;
  public GEnum87 genum87_0;
  public GEnum86 genum86_0;
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
  public int int_14;
  public int int_15;
  public int int_16;
  public int int_17;
  public int int_18;
  public int int_19;
  public int int_20;
  public int int_21;
  public int int_22;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5 = 1M;
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
  public double double_0;
  public bool bool_0;
  public bool bool_1;
  public bool bool_2;
  public bool bool_3; // probably civilian tag
  public bool bool_4;
  public bool bool_5;
  public bool bool_6;
  public bool bool_7;
  public bool bool_8;
  public bool bool_9;
  public bool bool_10;
  public bool bool_11;
  public bool bool_12;
  public bool bool_13;
  public Decimal decimal_17;
  public double double_1;
  public Decimal decimal_18;
  public int int_23;

  public string Name { get; set; }

  public string DisplayName { get; set; }

  public string method_0()
  {
    try
    {
      if (this.genum86_0 == GEnum86.const_0)
        this.DisplayName = this.Name;
      else if (this.genum86_0 == GEnum86.const_1)
        this.DisplayName = this.Name + " (P)";
      else if (this.genum86_0 == GEnum86.const_2)
        this.DisplayName = this.Name + " (FP)";
      else if (this.genum86_0 == GEnum86.const_3)
        this.DisplayName = this.Name + " (RP)";
      return this.DisplayName;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2680);
      return this.Name;
    }
  }

  public void method_1(GClass0 gclass0_0)
  {
    try
    {
      if (this.int_16 > 0)
        this.method_2(gclass0_0, this.int_16);
      if (this.int_17 > 0)
        this.method_2(gclass0_0, this.int_17);
      if (this.int_18 > 0)
        this.method_2(gclass0_0, this.int_18);
      if (this.int_19 > 0)
        this.method_2(gclass0_0, this.int_19);
      if (this.int_20 > 0)
        this.method_2(gclass0_0, this.int_20);
      if (this.int_21 > 0)
        this.method_2(gclass0_0, this.int_21);
      if (this.int_22 <= 0)
        return;
      this.method_2(gclass0_0, this.int_22);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2681);
    }
  }

  public void method_2(GClass0 gclass0_0, int int_24)
  {
    try
    {
      if (int_24 <= 0 || !gclass0_0.dictionary_50.ContainsKey(int_24))
        return;
      this.list_0.Add(gclass0_0.dictionary_50[int_24]);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2682);
    }
  }

  public int method_3()
  {
    try
    {
      return this.bool_4 ? (int) Math.Ceiling(!(this.decimal_0 == 0M) ? this.decimal_0 / this.decimal_4 : 1M) * 5 : 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2683);
      return 0;
    }
  }

  public int method_4()
  {
    try
    {
      return this.int_8 > 0 ? this.int_8 : this.int_6 * (int) this.decimal_17;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2684);
      return 0;
    }
  }

  public int method_5(int int_24)
  {
    try
    {
      if (this.int_8 > 0)
        return int_24 <= this.int_8 ? this.int_6 : 0;
      if (this.decimal_17 == 0M)
        return 1;
      Decimal num = (Decimal) int_24 / this.decimal_17;
      if (num < 1M)
        num = 1M;
      return (int) ((Decimal) this.int_6 / num);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2685);
      return 0;
    }
  }

  public GClass164 method_6()
  {
    try
    {
      return this.list_0[GClass226.smethod_13(this.list_0.Count) - 1];
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2686);
      return (GClass164) null;
    }
  }

  public int method_7()
  {
    try
    {
      return (int) Math.Ceiling(!(this.decimal_0 == 0M) ? this.decimal_0 / this.decimal_4 : 1M) * 5;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2687);
      return 0;
    }
  }

  public string method_8(Decimal decimal_19, int int_24, int int_25, int int_26, int int_27)
  {
    int num1 = (int) Math.Ceiling(!(this.decimal_0 == 0M) ? this.decimal_0 / this.decimal_4 : 1M) * 5;
    Decimal decimal_73 = (Decimal) this.int_8;
    if (this.int_8 == 0)
      decimal_73 = (Decimal) this.int_6 * this.decimal_17;
    if ((Decimal) int_24 < decimal_73)
      decimal_73 = (Decimal) int_24;
    string str;
    if (this.int_3 > 0)
    {
      if (this.gclass231_0.auroraComponentType_0 == AuroraComponentType.CIWS)
        str = $"{this.Name} ({decimal_19.ToString()}x{this.int_7.ToString()})    Range 1000 km     TS: {GClass226.smethod_37(this.int_3)} km/s     ROF {num1.ToString()}       ";
      else
        str = $"{this.Name} ({decimal_19.ToString()}x{this.int_7.ToString()})    Range {GClass226.smethod_38(decimal_73)}km     TS: {this.int_3.ToString()} km/s     Power {this.decimal_0.ToString()}-{this.decimal_4.ToString()}    ROF {num1.ToString()}       ";
    }
    else if (this.int_8 > 0)
      str = $"{this.Name} ({decimal_19.ToString()})    Range {GClass226.smethod_38(decimal_73)}km     TS: {GClass226.smethod_37(int_25)} km/s     Power {this.decimal_0.ToString()}-{this.decimal_4.ToString()}    ROF {num1.ToString()}       ";
    else if (this.int_7 > 1 && this.decimal_0 == 0M)
    {
      if (this.decimal_5 > 0M && this.decimal_5 < 1M)
        str = $"{this.Name} ({decimal_19.ToString()}x{this.int_7.ToString()})    Range {GClass226.smethod_38(decimal_73)}km     TS: {GClass226.smethod_37(int_25)} km/s     Accuracy Modifier {(this.decimal_5 * 100M).ToString()}%     ROF {num1.ToString()}       ";
      else
        str = $"{this.Name} ({decimal_19.ToString()}x{this.int_7.ToString()})    Range {GClass226.smethod_38(decimal_73)}km     TS: {GClass226.smethod_37(int_25)} km/s     Power {this.decimal_0.ToString()}-{this.decimal_4.ToString()}     ROF {num1.ToString()}       ";
    }
    else if (this.int_7 > 1 && this.decimal_0 > 0M)
    {
      if (this.decimal_5 > 0M && this.decimal_5 < 1M)
        str = $"{this.Name} ({decimal_19.ToString()}x{this.int_7.ToString()})    Range {GClass226.smethod_38(decimal_73)}km     TS: {GClass226.smethod_37(int_25)} km/s     Power {this.decimal_0.ToString()}-{this.decimal_4.ToString()}     Accuracy Modifier {(this.decimal_5 * 100M).ToString()}%     ROF {num1.ToString()}       ";
      else
        str = $"{this.Name} ({decimal_19.ToString()}x{this.int_7.ToString()})    Range {GClass226.smethod_38(decimal_73)}km     TS: {GClass226.smethod_37(int_25)} km/s     Power {this.decimal_0.ToString()}-{this.decimal_4.ToString()}     ROF {num1.ToString()}       ";
    }
    else
      str = $"{this.Name} ({decimal_19.ToString()})    Range {GClass226.smethod_38(decimal_73)}km     TS: {GClass226.smethod_37(int_25)} km/s     Power {this.decimal_0.ToString()}-{this.decimal_4.ToString()}     ROF {num1.ToString()}       ";
    if (int_26 > 0 && int_27 == 1)
    {
      if (this.gclass231_0.auroraComponentType_0 == AuroraComponentType.CIWS)
      {
        str += "Base 50% to hit";
      }
      else
      {
        for (int index = int_26; index < int_26 * 11; index += int_26)
        {
          if (this.int_8 == 0)
          {
            if ((Decimal) index <= decimal_73)
            {
              Decimal num2 = (Decimal) index / this.decimal_17;
              if (num2 < 1M)
                num2 = 1M;
              str = $"{str} {((int) ((Decimal) this.int_6 / num2)).ToString()}";
            }
            else
              str += " 0";
          }
          else
            str = !(decimal_73 >= (Decimal) index) ? str + " 0" : $"{str} {this.int_6.ToString()}";
        }
      }
    }
    return str + Environment.NewLine;
  }

  public string method_9(int int_24, int int_25)
  {
    try
    {
      if (this.gclass231_0.auroraComponentType_0 != AuroraComponentType.BeamFireControl)
        return "Not Beam Fire Control";
      string str = "";
      for (int index = int_24; index < int_24 * 11; index += int_24)
      {
        Decimal num = 1M - (Decimal) index / this.decimal_3;
        if (int_25 > this.int_3)
          num *= (Decimal) this.int_3 / (Decimal) int_25;
        if (num < 0M)
          num = 0M;
        str = $"{str} {Math.Round(num * 100M).ToString()}";
      }
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2688);
      return "Error";
    }
  }

  public double method_10(double double_2, double double_3, int int_24, Decimal decimal_19)
  {
    try
    {
      if (this.gclass231_0.auroraComponentType_0 != AuroraComponentType.BeamFireControl)
        return 0.0;
      double num1 = 1.0 - double_2 / (double) this.decimal_3;
      int num2 = this.int_3;
      if (int_24 > 0 && int_24 < this.int_3)
        num2 = int_24;
      int num3 = (int) Math.Round((Decimal) num2 * decimal_19);
      if (double_3 > (double) num3)
        num1 *= (double) num3 / double_3;
      if (num1 < 0.0)
        num1 = 0.0;
      return num1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2689);
      return 0.0;
    }
  }

  public double method_11(Decimal decimal_19)
  {
    try
    {
      return (double) GClass226.smethod_35(this.decimal_3 * decimal_19) * GClass226.double_18;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2690);
      return 0.0;
    }
  }

  public double method_12(Decimal decimal_19, Decimal decimal_20)
  {
    try
    {
      return (double) GClass226.smethod_35(this.decimal_3 * decimal_20 * decimal_19) * GClass226.double_18;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2691);
      return 0.0;
    }
  }

  public string method_13(Decimal decimal_19)
  {
    try
    {
      string str1 = "";
      switch (this.gclass231_0.auroraComponentType_0)
      {
        case AuroraComponentType.Engine:
          string[] strArray = new string[13];
          strArray[0] = this.Name;
          strArray[1] = " (";
          strArray[2] = decimal_19.ToString();
          strArray[3] = ")    Power ";
          strArray[4] = Math.Round(this.decimal_3 * decimal_19, 1).ToString();
          strArray[5] = "    Fuel Use ";
          Decimal num1 = Math.Round(this.decimal_8 * 100M, 2);
          strArray[6] = num1.ToString();
          strArray[7] = "%    Signature ";
          num1 = this.decimal_9 * this.decimal_3;
          strArray[8] = num1.ToString();
          strArray[9] = "    Explosion ";
          strArray[10] = this.decimal_11.ToString();
          strArray[11] = "%";
          strArray[12] = Environment.NewLine;
          return string.Concat(strArray);
        case AuroraComponentType.GravitationalSurveySensors:
        case AuroraComponentType.GeologicalSurveySensors:
          return $"{this.Name} ({decimal_19.ToString()})   {(this.decimal_3 * decimal_19).ToString()} Survey Points Per Hour{Environment.NewLine}";
        case AuroraComponentType.ThermalSensors:
        case AuroraComponentType.EMSensors:
          double num2 = this.method_11(1000M);
          return $"{this.Name} ({decimal_19.ToString()})     Sensitivity {this.decimal_3.ToString()}     Detect Sig Strength 1000:  {GClass226.smethod_44(num2 / 1000000.0, 1)}m km{Environment.NewLine}";
        case AuroraComponentType.Shields:
          Decimal num3 = this.decimal_7 * decimal_19;
          return $"{this.Name} ({decimal_19.ToString()})     Recharge Time {this.decimal_4.ToString()} seconds ({GClass226.smethod_42(this.decimal_3 / this.decimal_4 * decimal_19, 1)} per second){Environment.NewLine}";
        case AuroraComponentType.JumpDrive:
          return $"{this.Name}     Max Ship Size {(this.decimal_3 * 50M).ToString()} tons    Distance {this.int_9.ToString()}k km     Squadron Size {this.int_10.ToString()}{Environment.NewLine}";
        case AuroraComponentType.PowerPlant:
          return $"{this.Name} ({decimal_19.ToString()})     Total Power Output {GClass226.smethod_42(this.decimal_3 * decimal_19, 1)}    Exp {this.decimal_11.ToString()}%{Environment.NewLine}";
        case AuroraComponentType.BeamFireControl:
          if (this.decimal_13 > 0M)
            str1 = "   ECCM-" + GClass226.smethod_38(this.decimal_13);
          return $"{this.Name} ({decimal_19.ToString()})     Max Range: {GClass226.smethod_38(this.decimal_3)} km   TS: {this.int_3.ToString()} km/s{str1}{Environment.NewLine}";
        case AuroraComponentType.MissileLauncher:
          return !this.bool_7 ? $"{this.Name} ({decimal_19.ToString()})     Missile Size: {this.decimal_3.ToString()}    Rate of Fire {this.int_11.ToString()}{Environment.NewLine}" : $"{this.Name} ({decimal_19.ToString()})     Missile Size: {this.decimal_3.ToString()}    Hangar Reload {GClass226.smethod_42((Decimal) (this.int_11 / 60), 1)} minutes    MF Reload {GClass226.smethod_42((Decimal) (this.int_11 / 360), 1)} hours{Environment.NewLine}";
        case AuroraComponentType.ActiveSearchSensors:
          string str2 = this.double_0 <= 1000000.0 ? $"     Range {GClass226.smethod_44(this.double_0 / 1000.0, 1)}k km    " : $"     Range {GClass226.smethod_44(this.double_0 / 1000000.0, 1)}m km    ";
          if (this.decimal_6 == 1M)
          {
            double num4 = Math.Pow(GClass226.double_20, 2.0) * this.double_0;
            str2 = num4 < 1000000.0 ? $"{str2}MCR {GClass226.smethod_44(num4 / 1000.0, 1)}k km    " : $"{str2}MCR {GClass226.smethod_44(num4 / 1000000.0, 1)}m km    ";
          }
          return $"{this.Name} ({decimal_19.ToString()})     GPS {Math.Ceiling(this.decimal_3 * this.decimal_6).ToString()}{str2}Resolution {this.decimal_6.ToString()}{Environment.NewLine}";
        case AuroraComponentType.MissileFireControl:
          if (this.decimal_13 > 0M)
            str1 = "   ECCM-" + GClass226.smethod_38(this.decimal_13);
          return this.double_0 > 1000000.0 ? $"{this.Name} ({decimal_19.ToString()})     Range {GClass226.smethod_44(this.double_0 / 1000000.0, 1)}m km    Resolution {this.decimal_6.ToString()}{str1}{Environment.NewLine}" : $"{this.Name} ({decimal_19.ToString()})     Range {GClass226.smethod_44(this.double_0 / 1000.0, 1)}k km    Resolution {this.decimal_6.ToString()}{str1}{Environment.NewLine}";
        case AuroraComponentType.FighterPodBay:
          return $"{this.Name} ({decimal_19.ToString()})     Pod Size: {this.decimal_3.ToString()}    Hangar Reload {GClass226.smethod_42((Decimal) (this.int_11 / 60), 1)} minutes    MF Reload {GClass226.smethod_42((Decimal) (this.int_11 / 360), 1)} hours{Environment.NewLine}";
        case AuroraComponentType.ELINTModule:
          double num5 = this.method_12(1000M, decimal_19);
          return $"ELINT Module ({decimal_19.ToString()})     Sensitivity {(this.decimal_3 * decimal_19).ToString()}     Detect Sig Strength 1000:  {GClass226.smethod_44(num5 / 1000000.0, 1)}m km{Environment.NewLine}";
        case AuroraComponentType.DecoyMissileLauncher:
          return $"{this.Name} ({decimal_19.ToString()})     Decoy Size: {this.decimal_3.ToString()}    Hangar Reload {GClass226.smethod_42((Decimal) (this.int_11 / 60), 1)} minutes    MF Reload {GClass226.smethod_42((Decimal) (this.int_11 / 360), 1)} hours{Environment.NewLine}";
        default:
          return "Component Type Not Found";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2692);
      return "error";
    }
  }

  public string method_14()
  {
    try
    {
      string str1 = this.Name + Environment.NewLine;
      Decimal num1;
      switch (this.gclass231_0.auroraComponentType_0)
      {
        case AuroraComponentType.Engine:
          string str2 = $"{str1}Engine Power {this.decimal_3.ToString()}    Fuel Use Per Hour {GClass226.smethod_42(this.decimal_3 * this.decimal_8, 1)} litres    Fuel per EPH {GClass226.smethod_42(this.decimal_8, 3)}{Environment.NewLine}";
          string[] strArray1 = new string[7];
          strArray1[0] = str2;
          strArray1[1] = "Thermal Signature ";
          num1 = this.decimal_9 * this.decimal_3;
          strArray1[2] = num1.ToString();
          strArray1[3] = "    Explosion Chance ";
          strArray1[4] = this.decimal_11.ToString();
          strArray1[5] = "%";
          strArray1[6] = Environment.NewLine;
          string str3 = string.Concat(strArray1);
          str1 = !this.bool_1 ? $"{str3}Commercial Engine{Environment.NewLine}" : $"{str3}Military Engine{Environment.NewLine}";
          break;
        case AuroraComponentType.GravitationalSurveySensors:
        case AuroraComponentType.GeologicalSurveySensors:
          str1 = $"{str1}{this.decimal_3.ToString()} Survey Points Per Hour{Environment.NewLine}";
          break;
        case AuroraComponentType.ThermalSensors:
        case AuroraComponentType.EMSensors:
          str1 = $"{$"{$"{str1}Sensitivity {this.decimal_3.ToString()}{Environment.NewLine}"}Detect Sig Strength 100:  {GClass226.smethod_44(Math.Sqrt((double) this.decimal_3 * 100.0) * GClass226.double_18 / 1000000.0, 2)}m km{Environment.NewLine}"}Detect Sig Strength 1000:  {GClass226.smethod_44(Math.Sqrt((double) this.decimal_3 * 1000.0) * GClass226.double_18 / 1000000.0, 2)}m km{Environment.NewLine}";
          break;
        case AuroraComponentType.Shields:
          str1 = $"{str1}Shield Strength {this.decimal_3.ToString()}    Recharge Time {this.decimal_4.ToString()}{Environment.NewLine}";
          break;
        case AuroraComponentType.JumpDrive:
          str1 = $"{$"{str1}Max Ship Size {GClass226.smethod_38(this.decimal_3 * 50M)} tons    Jump Radius {GClass226.smethod_37(this.int_9)}k km     Squadron Size {this.int_10.ToString()}{Environment.NewLine}"}Max Ship Size vs Drive Size Ratio {GClass226.smethod_38(this.decimal_3 / this.decimal_1)}{Environment.NewLine}";
          break;
        case AuroraComponentType.PowerPlant:
          str1 = $"{str1}Total Power Output {GClass226.smethod_42(this.decimal_3, 2)}    Explosion Chance {this.decimal_11.ToString()}%{Environment.NewLine}";
          break;
        case AuroraComponentType.BeamFireControl:
          str1 = $"{str1}Max Range {GClass226.smethod_38(this.decimal_3)} km    Tracking Speed {GClass226.smethod_37(this.int_3)} km/s    ECCM-{GClass226.smethod_38(this.decimal_13)}{Environment.NewLine}";
          if (this.genum87_0 == GEnum87.const_6)
          {
            str1 = $"{str1}Single Weapon Only{Environment.NewLine}";
            break;
          }
          break;
        case AuroraComponentType.MissileLauncher:
          if (!this.bool_7)
          {
            str1 = $"{str1}Missile Size: {this.decimal_3.ToString()}    Rate of Fire {this.int_11.ToString()}{Environment.NewLine}";
            break;
          }
          str1 = $"{str1}Missile Size: {this.decimal_3.ToString()}    Hangar Reload {GClass226.smethod_42((Decimal) (this.int_11 / 60), 1)} minutes    MF Reload {GClass226.smethod_42((Decimal) (this.int_11 / 360), 1)} hours{Environment.NewLine}";
          break;
        case AuroraComponentType.ActiveSearchSensors:
        case AuroraComponentType.MissileFireControl:
          string str4 = this.double_0 <= 1000000.0 ? GClass226.smethod_44(this.double_0 / 1000.0, 1) + "k km    " : GClass226.smethod_44(this.double_0 / 1000000.0, 1) + "m km    ";
          if (this.decimal_6 == 1M)
          {
            double num2 = Math.Pow(GClass226.double_20, 2.0) * this.double_0;
            str4 = num2 < 1000000.0 ? $"{str4}MCR {GClass226.smethod_44(num2 / 1000.0, 1)}k km    " : $"{str4}MCR {GClass226.smethod_44(num2 / 1000000.0, 1)}m km    ";
          }
          str1 = $"{$"{$"{str1}Resolution {this.decimal_6.ToString()}   Range vs {GClass226.smethod_38(this.decimal_6 * GClass226.decimal_17)} ton object (or larger) {str4}{Environment.NewLine}"}Range vs 1000 ton object {this.method_16(this.method_15(20M))}{Environment.NewLine}"}Range vs 250 ton object {this.method_16(this.method_15(5M))}{Environment.NewLine}";
          if (this.decimal_13 > 0M)
            str1 = $"{str1}ECCM-{this.decimal_13.ToString()}{Environment.NewLine}";
          if (this.gclass231_0.auroraComponentType_0 == AuroraComponentType.ActiveSearchSensors)
          {
            str1 = $"{str1}Signature vs Passive Detection: {Math.Ceiling(this.decimal_3 * this.decimal_6).ToString()}{Environment.NewLine}";
            break;
          }
          break;
        case AuroraComponentType.CIWS:
          str1 = $"{$"{str1}Rate of Fire {this.int_7.ToString()} shots every five seconds{Environment.NewLine}"}Tracking Speed {GClass226.smethod_37(this.int_3)} km/s     ECCM-{GClass226.smethod_38(this.decimal_13)}{Environment.NewLine}";
          break;
      }
      string str5 = $"{str1}Cost {this.decimal_2.ToString()}   Size {GClass226.smethod_42(this.decimal_1 * GClass226.decimal_17, 2)} tons   Crew {this.int_1.ToString()}   HTK {this.int_4.ToString()}{Environment.NewLine}";
      if (this.decimal_5 > 0M && this.decimal_5 < 1M)
      {
        string[] strArray2 = new string[5]
        {
          str5,
          "Base Chance to hit ",
          null,
          null,
          null
        };
        num1 = Math.Round(this.decimal_5 * 100M, 1);
        strArray2[2] = num1.ToString();
        strArray2[3] = "%";
        strArray2[4] = Environment.NewLine;
        str5 = string.Concat(strArray2);
      }
      return $"{str5}Materials Required: {this.gclass123_0.method_36()}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2693);
      return "error";
    }
  }

  public double method_15(Decimal decimal_19)
  {
    try
    {
      if (this.decimal_6 <= decimal_19)
        return this.double_0;
      double num = (double) (decimal_19 / this.decimal_6);
      return this.double_0 * num * num;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2694);
      return 0.0;
    }
  }

  public string method_16(double double_2)
  {
    try
    {
      return double_2 > 1000000.0 ? GClass226.smethod_44(double_2 / 1000000.0, 1) + "m km" : GClass226.smethod_44(double_2 / 1000.0, 1) + "k km";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2695);
      return "error";
    }
  }

  public string method_17(int int_24, int int_25, Decimal decimal_19)
  {
    try
    {
      string str1 = "";
      if (this.gclass231_0.auroraComponentType_0 == AuroraComponentType.BeamFireControl)
      {
        string str2 = $"{this.Name} ({decimal_19.ToString()})     Max Range: {GClass226.smethod_38(this.decimal_3)} km   TS: {GClass226.smethod_37(this.int_3)} km/s    ECCM-{GClass226.smethod_38(this.decimal_13)}    ";
        if (int_25 > 0 && int_24 > 0)
          str2 += this.method_9(int_24, int_25);
        str1 = str2 + Environment.NewLine;
      }
      return str1 == "" ? "Component Type Not Found" : str1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2696);
      return "error";
    }
  }

  public int method_18()
  {
    try
    {
      if (!this.bool_11)
        return 0;
      if (this.int_8 > 0)
        return this.int_8;
      return this.int_6 > 0 ? (int) ((Decimal) this.int_6 * this.decimal_17) : 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2697);
      return 0;
    }
  }
}
