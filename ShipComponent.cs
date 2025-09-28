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
public class ShipComponent
{
    public List<TechSystem> list_0 = new List<TechSystem>();
    public List<TechSystem> list_1 = new List<TechSystem>();
    public TechSystem gclass164_0;
    public ShipComponent gclass230_0;
    public ComponentTypeData Data;
    public AllMineralsValue gclass123_0;
    public ShipComponentTemplate gclass185_0;
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
    public Decimal Resolution;
    public Decimal decimal_7;
    public Decimal decimal_8;
    public Decimal decimal_9;
    public Decimal decimal_10;
    public Decimal ExplosionChance;
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
                this.DisplayName = string.Format("{0} (P)", this.Name);
            else if (this.genum86_0 == GEnum86.const_2)
                this.DisplayName = string.Format("{0} (FP)", this.Name);
            else if (this.genum86_0 == GEnum86.const_3)
                this.DisplayName = string.Format("{0} (RP)", this.Name);
            return this.DisplayName;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2680);
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
            AuroraUtils.ShowExceptionPopup(ex, 2681);
        }
    }

    public void method_2(GClass0 gclass0_0, int int_24)
    {
        try
        {
            if (int_24 <= 0 || !gclass0_0.TechSystems.ContainsKey(int_24))
                return;
            this.list_0.Add(gclass0_0.TechSystems[int_24]);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2682);
        }
    }

    public int method_3()
    {
        try
        {
            return this.bool_4
                ? (int)Math.Ceiling(!(this.decimal_0 == 0M) ? this.decimal_0 / this.decimal_4 : 1M) * 5
                : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2683);
            return 0;
        }
    }

    public int method_4()
    {
        try
        {
            return this.int_8 > 0 ? this.int_8 : this.int_6 * (int)this.decimal_17;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2684);
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
            Decimal num = int_24 / this.decimal_17;
            if (num < 1M)
                num = 1M;
            return (int)(this.int_6 / num);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2685);
            return 0;
        }
    }

    public TechSystem method_6()
    {
        try
        {
            return this.list_0[AuroraUtils.GetRandomInteger(this.list_0.Count) - 1];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2686);
            return null;
        }
    }

    public int method_7()
    {
        try
        {
            return (int)Math.Ceiling(!(this.decimal_0 == 0M) ? this.decimal_0 / this.decimal_4 : 1M) * 5;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2687);
            return 0;
        }
    }

    public string method_8(Decimal decimal_19, int int_24, int int_25, int int_26, int int_27)
    {
        int num1 = (int)Math.Ceiling(!(this.decimal_0 == 0M) ? this.decimal_0 / this.decimal_4 : 1M) * 5;
        Decimal decimal_73 = this.int_8;
        if (this.int_8 == 0)
            decimal_73 = this.int_6 * this.decimal_17;
        if (int_24 < decimal_73)
            decimal_73 = int_24;
        string str;
        if (this.int_3 > 0)
        {
            if (this.Data.ComponentTypeID == AuroraComponentType.CIWS)
                str =
                    string.Format("{0} ({1}x{2})    Range 1000 km     TS: {3} km/s     ROF {4}       ", this.Name,
                        decimal_19.ToString(), this.int_7.ToString(), AuroraUtils.smethod_37(this.int_3),
                        num1.ToString());
            else
                str =
                    string.Format("{0} ({1}x{2})    Range {3}km     TS: {4} km/s     Power {5}-{6}    ROF {7}       ",
                        this.Name, decimal_19.ToString(), this.int_7.ToString(), AuroraUtils.smethod_38(decimal_73),
                        this.int_3.ToString(), this.decimal_0.ToString(), this.decimal_4.ToString(), num1.ToString());
        }
        else if (this.int_8 > 0)
            str =
                string.Format("{0} ({1})    Range {2}km     TS: {3} km/s     Power {4}-{5}    ROF {6}       ",
                    this.Name, decimal_19.ToString(), AuroraUtils.smethod_38(decimal_73),
                    AuroraUtils.smethod_37(int_25), this.decimal_0.ToString(), this.decimal_4.ToString(),
                    num1.ToString());
        else if (this.int_7 > 1 && this.decimal_0 == 0M)
        {
            if (this.decimal_5 > 0M && this.decimal_5 < 1M)
                str =
                    string.Format(
                        "{0} ({1}x{2})    Range {3}km     TS: {4} km/s     Accuracy Modifier {5}%     ROF {6}       ",
                        this.Name, decimal_19.ToString(), this.int_7.ToString(), AuroraUtils.smethod_38(decimal_73),
                        AuroraUtils.smethod_37(int_25), (this.decimal_5 * 100M).ToString(), num1.ToString());
            else
                str =
                    string.Format("{0} ({1}x{2})    Range {3}km     TS: {4} km/s     Power {5}-{6}     ROF {7}       ",
                        this.Name, decimal_19.ToString(), this.int_7.ToString(), AuroraUtils.smethod_38(decimal_73),
                        AuroraUtils.smethod_37(int_25), this.decimal_0.ToString(), this.decimal_4.ToString(),
                        num1.ToString());
        }
        else if (this.int_7 > 1 && this.decimal_0 > 0M)
        {
            if (this.decimal_5 > 0M && this.decimal_5 < 1M)
                str =
                    string.Format(
                        "{0} ({1}x{2})    Range {3}km     TS: {4} km/s     Power {5}-{6}     Accuracy Modifier {7}%     ROF {8}       ",
                        this.Name, decimal_19.ToString(), this.int_7.ToString(), AuroraUtils.smethod_38(decimal_73),
                        AuroraUtils.smethod_37(int_25), this.decimal_0.ToString(), this.decimal_4.ToString(),
                        (this.decimal_5 * 100M).ToString(), num1.ToString());
            else
                str =
                    string.Format("{0} ({1}x{2})    Range {3}km     TS: {4} km/s     Power {5}-{6}     ROF {7}       ",
                        this.Name, decimal_19.ToString(), this.int_7.ToString(), AuroraUtils.smethod_38(decimal_73),
                        AuroraUtils.smethod_37(int_25), this.decimal_0.ToString(), this.decimal_4.ToString(),
                        num1.ToString());
        }
        else
            str =
                string.Format("{0} ({1})    Range {2}km     TS: {3} km/s     Power {4}-{5}     ROF {6}       ",
                    this.Name, decimal_19.ToString(), AuroraUtils.smethod_38(decimal_73),
                    AuroraUtils.smethod_37(int_25), this.decimal_0.ToString(), this.decimal_4.ToString(),
                    num1.ToString());

        if (int_26 > 0 && int_27 == 1)
        {
            if (this.Data.ComponentTypeID == AuroraComponentType.CIWS)
            {
                str += "Base 50% to hit";
            }
            else
            {
                for (int index = int_26; index < int_26 * 11; index += int_26)
                {
                    if (this.int_8 == 0)
                    {
                        if (index <= decimal_73)
                        {
                            Decimal num2 = index / this.decimal_17;
                            if (num2 < 1M)
                                num2 = 1M;
                            str = string.Format("{0} {1}", str, ((int)(this.int_6 / num2)).ToString());
                        }
                        else
                            str += " 0";
                    }
                    else
                        str = !(decimal_73 >= index) ? string.Format("{0} 0", str) : string.Format("{0} {1}", str,
                            this.int_6.ToString());
                }
            }
        }

        return str + Environment.NewLine;
    }

    public string method_9(int int_24, int int_25)
    {
        try
        {
            if (this.Data.ComponentTypeID != AuroraComponentType.BeamFireControl)
                return "Not Beam Fire Control";
            string str = "";
            for (int index = int_24; index < int_24 * 11; index += int_24)
            {
                Decimal num = 1M - index / this.decimal_3;
                if (int_25 > this.int_3)
                    num *= this.int_3 / (Decimal)int_25;
                if (num < 0M)
                    num = 0M;
                str = string.Format("{0} {1}", str, Math.Round(num * 100M).ToString());
            }

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2688);
            return "Error";
        }
    }

    public double method_10(double double_2, double double_3, int int_24, Decimal decimal_19)
    {
        try
        {
            if (this.Data.ComponentTypeID != AuroraComponentType.BeamFireControl)
                return 0.0;
            double num1 = 1.0 - double_2 / (double)this.decimal_3;
            int num2 = this.int_3;
            if (int_24 > 0 && int_24 < this.int_3)
                num2 = int_24;
            int num3 = (int)Math.Round(num2 * decimal_19);
            if (double_3 > num3)
                num1 *= num3 / double_3;
            if (num1 < 0.0)
                num1 = 0.0;
            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2689);
            return 0.0;
        }
    }

    public double method_11(Decimal decimal_19)
    {
        try
        {
            return (double)AuroraUtils.smethod_35(this.decimal_3 * decimal_19) * AuroraUtils.double_18;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2690);
            return 0.0;
        }
    }

    public double method_12(Decimal decimal_19, Decimal decimal_20)
    {
        try
        {
            return (double)AuroraUtils.smethod_35(this.decimal_3 * decimal_20 * decimal_19) * AuroraUtils.double_18;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2691);
            return 0.0;
        }
    }

    public string GetComponentSpecLine(Decimal performanceRating)
    {
        try
        {
            string str1 = "";
            switch (this.Data.ComponentTypeID)
            {
                case AuroraComponentType.Engine:
                    return
                        string.Format("{0} ({1})    Power {2}    Fuel Use {3}%    Signature {4}    Explosion {5}%\n",
                            Name, performanceRating, Math.Round(decimal_3 * performanceRating, 1),
                            Math.Round(this.decimal_8 * 100M, 2), decimal_9 * decimal_3, ExplosionChance);
                case AuroraComponentType.GravitationalSurveySensors:
                case AuroraComponentType.GeologicalSurveySensors:
                    return
                        string.Format("{0} ({1})   {2} Survey Points Per Hour{3}", this.Name,
                            performanceRating.ToString(), (this.decimal_3 * performanceRating).ToString(),
                            Environment.NewLine);
                case AuroraComponentType.ThermalSensors:
                case AuroraComponentType.EMSensors:
                    double num2 = this.method_11(1000M);
                    return
                        string.Format("{0} ({1})     Sensitivity {2}     Detect Sig Strength 1000:  {3}m km{4}",
                            this.Name, performanceRating.ToString(), this.decimal_3.ToString(),
                            AuroraUtils.FormatDoubleToPrecision(num2 / 1000000.0, 1), Environment.NewLine);
                case AuroraComponentType.Shields:
                    Decimal num3 = this.decimal_7 * performanceRating;
                    return
                        string.Format("{0} ({1})     Recharge Time {2} seconds ({3} per second){4}", this.Name,
                            performanceRating.ToString(), this.decimal_4.ToString(),
                            AuroraUtils.FormatNumberToDigits(this.decimal_3 / this.decimal_4 * performanceRating, 1),
                            Environment.NewLine);
                case AuroraComponentType.JumpDrive:
                    return
                        string.Format("{0}     Max Ship Size {1} tons    Distance {2}k km     Squadron Size {3}{4}",
                            this.Name, (this.decimal_3 * 50M).ToString(), this.int_9.ToString(), this.int_10.ToString(),
                            Environment.NewLine);
                case AuroraComponentType.PowerPlant:
                    return
                        string.Format("{0} ({1})     Total Power Output {2}    Exp {3}%{4}", this.Name,
                            performanceRating.ToString(),
                            AuroraUtils.FormatNumberToDigits(this.decimal_3 * performanceRating, 1),
                            this.ExplosionChance.ToString(), Environment.NewLine);
                case AuroraComponentType.BeamFireControl:
                    if (this.decimal_13 > 0M)
                        str1 = string.Format("   ECCM-{0}", AuroraUtils.smethod_38(this.decimal_13));
                    return
                        string.Format("{0} ({1})     Max Range: {2} km   TS: {3} km/s{4}{5}", this.Name,
                            performanceRating.ToString(), AuroraUtils.smethod_38(this.decimal_3), this.int_3.ToString(),
                            str1, Environment.NewLine);
                case AuroraComponentType.MissileLauncher:
                    return !this.bool_7
                        ? string.Format("{0} ({1})     Missile Size: {2}    Rate of Fire {3}{4}", this.Name,
                            performanceRating.ToString(), this.decimal_3.ToString(), this.int_11.ToString(),
                            Environment.NewLine)
                        : string.Format(
                            "{0} ({1})     Missile Size: {2}    Hangar Reload {3} minutes    MF Reload {4} hours{5}",
                            this.Name, performanceRating.ToString(), this.decimal_3.ToString(),
                            AuroraUtils.FormatNumberToDigits(this.int_11 / 60, 1),
                            AuroraUtils.FormatNumberToDigits(this.int_11 / 360, 1), Environment.NewLine);
                case AuroraComponentType.ActiveSearchSensors:
                    string str2 = this.double_0 <= 1000000.0
                        ? string.Format("     Range {0}k km    ",
                            AuroraUtils.FormatDoubleToPrecision(this.double_0 / 1000.0, 1))
                        : string.Format("     Range {0}m km    ",
                            AuroraUtils.FormatDoubleToPrecision(this.double_0 / 1000000.0, 1));
                    if (this.Resolution == 1M)
                    {
                        double num4 = Math.Pow(AuroraUtils.double_20, 2.0) * this.double_0;
                        str2 = num4 < 1000000.0
                            ? string.Format("{0}MCR {1}k km    ", str2,
                                AuroraUtils.FormatDoubleToPrecision(num4 / 1000.0, 1))
                            : string.Format("{0}MCR {1}m km    ", str2,
                                AuroraUtils.FormatDoubleToPrecision(num4 / 1000000.0, 1));
                    }

                    return
                        string.Format("{0} ({1})     GPS {2}{3}Resolution {4}{5}", this.Name,
                            performanceRating.ToString(), Math.Ceiling(this.decimal_3 * this.Resolution).ToString(),
                            str2, this.Resolution.ToString(), Environment.NewLine);
                case AuroraComponentType.MissileFireControl:
                    if (this.decimal_13 > 0M)
                        str1 = string.Format("   ECCM-{0}", AuroraUtils.smethod_38(this.decimal_13));
                    return this.double_0 > 1000000.0
                        ? string.Format("{0} ({1})     Range {2}m km    Resolution {3}{4}{5}", this.Name,
                            performanceRating.ToString(),
                            AuroraUtils.FormatDoubleToPrecision(this.double_0 / 1000000.0, 1),
                            this.Resolution.ToString(), str1, Environment.NewLine)
                        : string.Format("{0} ({1})     Range {2}k km    Resolution {3}{4}{5}", this.Name,
                            performanceRating.ToString(),
                            AuroraUtils.FormatDoubleToPrecision(this.double_0 / 1000.0, 1), this.Resolution.ToString(),
                            str1, Environment.NewLine);
                case AuroraComponentType.FighterPodBay:
                    return
                        string.Format(
                            "{0} ({1})     Pod Size: {2}    Hangar Reload {3} minutes    MF Reload {4} hours{5}",
                            this.Name, performanceRating.ToString(), this.decimal_3.ToString(),
                            AuroraUtils.FormatNumberToDigits(this.int_11 / 60, 1),
                            AuroraUtils.FormatNumberToDigits(this.int_11 / 360, 1), Environment.NewLine);
                case AuroraComponentType.ELINTModule:
                    double num5 = this.method_12(1000M, performanceRating);
                    return
                        string.Format(
                            "ELINT Module ({0})     Sensitivity {1}     Detect Sig Strength 1000:  {2}m km{3}",
                            performanceRating.ToString(), (this.decimal_3 * performanceRating).ToString(),
                            AuroraUtils.FormatDoubleToPrecision(num5 / 1000000.0, 1), Environment.NewLine);
                case AuroraComponentType.DecoyMissileLauncher:
                    return
                        string.Format(
                            "{0} ({1})     Decoy Size: {2}    Hangar Reload {3} minutes    MF Reload {4} hours{5}",
                            this.Name, performanceRating.ToString(), this.decimal_3.ToString(),
                            AuroraUtils.FormatNumberToDigits(this.int_11 / 60, 1),
                            AuroraUtils.FormatNumberToDigits(this.int_11 / 360, 1), Environment.NewLine);
                default:
                    return "Component Type Not Found";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2692);
            return "error";
        }
    }

    public string method_14()
    {
        try
        {
            string str1 = this.Name + Environment.NewLine;
            switch (this.Data.ComponentTypeID)
            {
                case AuroraComponentType.Engine:
                    string str2 =
                        string.Format("{0}Engine Power {1}    Fuel Use Per Hour {2} litres    Fuel per EPH {3}{4}",
                            str1, this.decimal_3.ToString(),
                            AuroraUtils.FormatNumberToDigits(this.decimal_3 * this.decimal_8, 1),
                            AuroraUtils.FormatNumberToDigits(this.decimal_8, 3), Environment.NewLine);
                    string str3 = string.Format("{0}Thermal Signature {1}    Explosion Chance {2}%\n", str2,
                        decimal_9 * decimal_3, ExplosionChance);
                    str1 = !this.bool_1
                        ? string.Format("{0}Commercial Engine{1}", str3, Environment.NewLine)
                        : string.Format("{0}Military Engine{1}", str3, Environment.NewLine);
                    break;
                case AuroraComponentType.GravitationalSurveySensors:
                case AuroraComponentType.GeologicalSurveySensors:
                    str1 = string.Format("{0}{1} Survey Points Per Hour{2}", str1, this.decimal_3.ToString(),
                        Environment.NewLine);
                    break;
                case AuroraComponentType.ThermalSensors:
                case AuroraComponentType.EMSensors:
                    str1 =
                        string.Format("{0}Detect Sig Strength 1000:  {1}m km{2}",
                            string.Format("{0}Detect Sig Strength 100:  {1}m km{2}",
                                string.Format("{0}Sensitivity {1}{2}", str1, this.decimal_3.ToString(),
                                    Environment.NewLine),
                                AuroraUtils.FormatDoubleToPrecision(
                                    Math.Sqrt((double)this.decimal_3 * 100.0) * AuroraUtils.double_18 / 1000000.0, 2),
                                Environment.NewLine),
                            AuroraUtils.FormatDoubleToPrecision(
                                Math.Sqrt((double)this.decimal_3 * 1000.0) * AuroraUtils.double_18 / 1000000.0, 2),
                            Environment.NewLine);
                    break;
                case AuroraComponentType.Shields:
                    str1 =
                        string.Format("{0}Shield Strength {1}    Recharge Time {2}{3}", str1, this.decimal_3.ToString(),
                            this.decimal_4.ToString(), Environment.NewLine);
                    break;
                case AuroraComponentType.JumpDrive:
                    str1 =
                        string.Format("{0}Max Ship Size vs Drive Size Ratio {1}{2}",
                            string.Format("{0}Max Ship Size {1} tons    Jump Radius {2}k km     Squadron Size {3}{4}",
                                str1, AuroraUtils.smethod_38(this.decimal_3 * 50M), AuroraUtils.smethod_37(this.int_9),
                                this.int_10.ToString(), Environment.NewLine),
                            AuroraUtils.smethod_38(this.decimal_3 / this.decimal_1), Environment.NewLine);
                    break;
                case AuroraComponentType.PowerPlant:
                    str1 =
                        string.Format("{0}Total Power Output {1}    Explosion Chance {2}%{3}", str1,
                            AuroraUtils.FormatNumberToDigits(this.decimal_3, 2), this.ExplosionChance.ToString(),
                            Environment.NewLine);
                    break;
                case AuroraComponentType.BeamFireControl:
                    str1 =
                        string.Format("{0}Max Range {1} km    Tracking Speed {2} km/s    ECCM-{3}{4}", str1,
                            AuroraUtils.smethod_38(this.decimal_3), AuroraUtils.smethod_37(this.int_3),
                            AuroraUtils.smethod_38(this.decimal_13), Environment.NewLine);
                    if (this.genum87_0 == GEnum87.const_6)
                    {
                        str1 = string.Format("{0}Single Weapon Only{1}", str1, Environment.NewLine);
                        break;
                    }

                    break;
                case AuroraComponentType.MissileLauncher:
                    if (!this.bool_7)
                    {
                        str1 =
                            string.Format("{0}Missile Size: {1}    Rate of Fire {2}{3}", str1,
                                this.decimal_3.ToString(), this.int_11.ToString(), Environment.NewLine);
                        break;
                    }

                    str1 =
                        string.Format("{0}Missile Size: {1}    Hangar Reload {2} minutes    MF Reload {3} hours{4}",
                            str1, this.decimal_3.ToString(), AuroraUtils.FormatNumberToDigits(this.int_11 / 60, 1),
                            AuroraUtils.FormatNumberToDigits(this.int_11 / 360, 1), Environment.NewLine);
                    break;
                case AuroraComponentType.ActiveSearchSensors:
                case AuroraComponentType.MissileFireControl:
                    string str4 = this.double_0 <= 1000000.0
                        ? string.Format("{0}k km    ", AuroraUtils.FormatDoubleToPrecision(this.double_0 / 1000.0, 1))
                        : string.Format("{0}m km    ",
                            AuroraUtils.FormatDoubleToPrecision(this.double_0 / 1000000.0, 1));
                    if (this.Resolution == 1M)
                    {
                        double num2 = Math.Pow(AuroraUtils.double_20, 2.0) * this.double_0;
                        str4 = num2 < 1000000.0
                            ? string.Format("{0}MCR {1}k km    ", str4,
                                AuroraUtils.FormatDoubleToPrecision(num2 / 1000.0, 1))
                            : string.Format("{0}MCR {1}m km    ", str4,
                                AuroraUtils.FormatDoubleToPrecision(num2 / 1000000.0, 1));
                    }

                    str1 =
                        string.Format("{0}Range vs 250 ton object {1}{2}",
                            string.Format("{0}Range vs 1000 ton object {1}{2}",
                                string.Format("{0}Resolution {1}   Range vs {2} ton object (or larger) {3}{4}", str1,
                                    this.Resolution.ToString(),
                                    AuroraUtils.smethod_38(this.Resolution * AuroraUtils.decimal_17), str4,
                                    Environment.NewLine),
                                this.method_16(this.method_15(20M)), Environment.NewLine),
                            this.method_16(this.method_15(5M)), Environment.NewLine);
                    if (this.decimal_13 > 0M)
                        str1 = string.Format("{0}ECCM-{1}{2}", str1, this.decimal_13.ToString(), Environment.NewLine);
                    if (this.Data.ComponentTypeID == AuroraComponentType.ActiveSearchSensors)
                    {
                        str1 =
                            string.Format("{0}Signature vs Passive Detection: {1}{2}", str1,
                                Math.Ceiling(this.decimal_3 * this.Resolution).ToString(), Environment.NewLine);
                        break;
                    }

                    break;
                case AuroraComponentType.CIWS:
                    str1 =
                        string.Format("{0}Tracking Speed {1} km/s     ECCM-{2}{3}",
                            string.Format("{0}Rate of Fire {1} shots every five seconds{2}", str1,
                                this.int_7.ToString(), Environment.NewLine),
                            AuroraUtils.smethod_37(this.int_3), AuroraUtils.smethod_38(this.decimal_13),
                            Environment.NewLine);
                    break;
            }

            string str5 =
                string.Format("{0}Cost {1}   Size {2} tons   Crew {3}   HTK {4}{5}", str1, this.decimal_2.ToString(),
                    AuroraUtils.FormatNumberToDigits(this.decimal_1 * AuroraUtils.decimal_17, 2), this.int_1.ToString(),
                    this.int_4.ToString(), Environment.NewLine);
            if (this.decimal_5 > 0M && this.decimal_5 < 1M)
            {
                str5 = string.Format("{0}Base Chance to hit {1}%\n", str5, Math.Round(this.decimal_5 * 100M, 1));
            }

            return string.Format("{0}Materials Required: {1}", str5, this.gclass123_0.method_36());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2693);
            return "error";
        }
    }

    public double method_15(Decimal decimal_19)
    {
        try
        {
            if (this.Resolution <= decimal_19)
                return this.double_0;
            double num = (double)(decimal_19 / this.Resolution);
            return this.double_0 * num * num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2694);
            return 0.0;
        }
    }

    public string method_16(double double_2)
    {
        try
        {
            return double_2 > 1000000.0
                ? string.Format("{0}m km", AuroraUtils.FormatDoubleToPrecision(double_2 / 1000000.0, 1))
                : string.Format("{0}k km", AuroraUtils.FormatDoubleToPrecision(double_2 / 1000.0, 1));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2695);
            return "error";
        }
    }

    public string method_17(int int_24, int int_25, Decimal decimal_19)
    {
        try
        {
            string str1 = "";
            if (this.Data.ComponentTypeID == AuroraComponentType.BeamFireControl)
            {
                string str2 =
                    string.Format("{0} ({1})     Max Range: {2} km   TS: {3} km/s    ECCM-{4}    ", this.Name,
                        decimal_19.ToString(), AuroraUtils.smethod_38(this.decimal_3),
                        AuroraUtils.smethod_37(this.int_3), AuroraUtils.smethod_38(this.decimal_13));
                if (int_25 > 0 && int_24 > 0)
                    str2 += this.method_9(int_24, int_25);
                str1 = str2 + Environment.NewLine;
            }

            return str1 == "" ? "Component Type Not Found" : str1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2696);
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
            return this.int_6 > 0 ? (int)(this.int_6 * this.decimal_17) : 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2697);
            return 0;
        }
    }
}