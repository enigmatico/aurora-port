// Decompiled with JetBrains decompiler
// Type: GClass129
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class RaceMissile
{
    private GClass0 gclass0_0;
    public TechSystem gclass164_0;
    public ShipComponent gclass230_0;
    public RaceMissile gclass129_0;
    public AllMineralsValue gclass123_0;
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
    public int int_13 = 1;
    public int int_14;
    public int int_15;
    public int int_16;
    public int int_17;
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
    public Decimal decimal_18;
    public Decimal decimal_19;
    public Decimal decimal_20;
    public Decimal decimal_21;
    public Decimal decimal_22;
    public Decimal decimal_23;
    public Decimal decimal_24;
    public Decimal decimal_25;
    public Decimal decimal_26;
    public double double_0;
    public double double_1;
    public double double_2;
    public double double_3;
    public double double_4;
    public double double_5;
    public bool bool_0;
    public bool bool_1;
    public Decimal decimal_27;
    public Decimal decimal_28;

    public string Name { get; set; }

    public RaceMissile(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public double method_0(double double_6, double double_7, double double_8)
    {
        try
        {
            if (double_6 == 0.0)
                return 100.0;
            if (this.decimal_26 < 1M)
                this.decimal_26 = 1M;
            return (double)this.decimal_5 / double_6 * AuroraUtils.int_9 * double_8 * (double)this.decimal_26 *
                   double_7;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2062);
            return 0.0;
        }
    }

    public Decimal method_1(Decimal decimal_29)
    {
        try
        {
            if (this.decimal_26 < 1M)
                this.decimal_26 = 1M;
            return this.decimal_5 * AuroraUtils.int_9 * this.decimal_26 / decimal_29;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2062);
            return 0M;
        }
    }

    public Decimal method_2(Decimal decimal_29)
    {
        try
        {
            if (this.int_11 == 0)
                return 0M;
            Decimal num = decimal_29 / this.int_11;
            if (num < 1M)
                num = 1M;
            return this.decimal_1 / num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3651);
            return 0M;
        }
    }

    public double method_3(FCTShipData40 gclass40_0)
    {
        try
        {
            int y = (int)gclass40_0.method_156(AuroraJammerType.Missile);
            return y == 0 || y - this.int_8 <= 0 ? 1.0 : Math.Pow(0.75, y);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 297);
            return 0.0;
        }
    }

    public double method_4(double double_6)
    {
        try
        {
            return Math.Sqrt(this.double_1 * double_6) * AuroraUtils.double_18;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2053);
            return 0.0;
        }
    }

    public double method_5(double double_6)
    {
        try
        {
            return Math.Sqrt(this.double_2 * double_6) * AuroraUtils.double_18;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2054);
            return 0.0;
        }
    }

    public string method_6(int int_18)
    {
        try
        {
            string str1 = "";
            string str2 = AuroraUtils.smethod_80(int_18);
            string str3;
            if (this.decimal_21 > 10000M)
                str3 =
                    $"{str1}{str2} Stage Flight Time: {AuroraUtils.smethod_38(this.decimal_21 / 3600M)} hours    {str2} Stage Range: {AuroraUtils.smethod_44(this.double_5 / 1000000.0, 1)}m km{Environment.NewLine}";
            else if (this.decimal_21 > 120M)
                str3 =
                    $"{str1}{str2} Stage Flight Time: {AuroraUtils.smethod_38(this.decimal_21 / 60M)} minutes    {str2} Stage Range: {AuroraUtils.smethod_44(this.double_5 / 1000000.0, 2)}m km{Environment.NewLine}";
            else
                str3 =
                    $"{str1}{str2} Stage Flight Time: {AuroraUtils.smethod_38(this.decimal_21)} seconds    {str2} Stage Range: {AuroraUtils.smethod_44(this.double_5 / 1000.0, 1)}k km{Environment.NewLine}";
            if (this.int_16 > 0 && this.gclass129_0 != null)
            {
                ++int_18;
                str3 += this.gclass129_0.method_6(int_18);
            }

            return str3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2055);
            return "error";
        }
    }

    public string method_7(bool bool_2)
    {
        try
        {
            string str1;
            if (bool_2)
            {
                str1 =
                    $"{$"Fighter Pod Size: {this.decimal_4.ToString()} MSP  ({(this.decimal_4 * 2.5M).ToString()} Tons)     Armour Penetration: {this.decimal_17.ToString()}    Damage: {this.decimal_18.ToString()}    Shots: {this.decimal_19.ToString()}{Environment.NewLine}"}Cost Per Pod: {this.decimal_3.ToString()}     Development Cost: {AuroraUtils.smethod_38(this.decimal_3 * 100M)}{Environment.NewLine}";
            }
            else
            {
                string str2 = "";
                if (this.int_13 > 1)
                    str2 = $" (MW-{this.int_13.ToString()})";
                string str3;
                if (this.decimal_1 > 0M)
                    str3 =
                        $"{$"{$"Missile Size: {this.decimal_4.ToString()} MSP  ({(this.decimal_4 * 2.5M).ToString()} Tons)     Laser Warhead: {this.decimal_1.ToString()}{Environment.NewLine}"}Minimum Detonation Range: {AuroraUtils.smethod_38(this.decimal_24)}    Impact Damage: {AuroraUtils.FormatNumberToDigits(this.method_2(this.decimal_24), 3)}{Environment.NewLine}"}Maximum Detonation Range: {AuroraUtils.smethod_38(this.decimal_25)}    Impact Damage: {AuroraUtils.FormatNumberToDigits(this.method_2(this.decimal_25), 3)}{Environment.NewLine}";
                else if (this.int_14 == 1)
                    str3 =
                        $"Decoy Missile Size: {this.decimal_4.ToString()} MSP  ({(this.decimal_4 * 2.5M).ToString()} Tons)     Decoy Signature: {this.decimal_0.ToString()} tons    ECM-{this.int_12.ToString()}{Environment.NewLine}";
                else
                    str3 =
                        $"Missile Size: {this.decimal_4.ToString()} MSP  ({(this.decimal_4 * 2.5M).ToString()} Tons)     Warhead: {this.decimal_0.ToString()}{str2}    Radiation Damage: {this.decimal_2.ToString()}{Environment.NewLine}";
                string str4 =
                    $"{str3}Speed: {AuroraUtils.smethod_38(this.decimal_5)} km/s     Fuel: {AuroraUtils.smethod_37(this.int_4)}     ";
                string str5;
                if (this.int_16 > 0)
                    str5 = str4 + this.method_6(1);
                else if (this.decimal_22 > 10000M)
                    str5 =
                        $"{str4}Flight Time: {AuroraUtils.smethod_38(this.decimal_21 / 3600M)} hours     Range: {AuroraUtils.smethod_44(this.double_5 / 1000000.0, 1)}m km{Environment.NewLine}";
                else if (this.decimal_22 > 120M)
                    str5 =
                        $"{str4}Flight Time: {AuroraUtils.smethod_38(this.decimal_21 / 60M)} minutes     Range: {AuroraUtils.smethod_44(this.double_5 / 1000000.0, 2)}m km{Environment.NewLine}";
                else
                    str5 =
                        $"{str4}Flight Time: {AuroraUtils.FormatNumberToDigits(this.decimal_21, 1)} seconds     Range: {AuroraUtils.smethod_43(this.double_5)} km{Environment.NewLine}";
                if (this.double_0 > 0.0)
                    str5 =
                        $"{$"{str5}Active Sensor Strength: {this.double_0.ToString()}   EM Sensitivity Modifier: {this.double_3.ToString()}{Environment.NewLine}"}Resolution: {this.int_5.ToString()}    Maximum Range vs {(this.int_5 * 50).ToString()} ton object (or larger): {AuroraUtils.smethod_39(this.int_6)} km{Environment.NewLine}";
                if (this.double_1 > 0.0)
                    str5 =
                        $"{str5}Thermal Sensor Strength: {this.double_1.ToString()}    Detect Sig Strength 1000:  {AuroraUtils.smethod_43(this.method_4(1000.0))} km{Environment.NewLine}";
                if (this.double_2 > 0.0)
                    str5 =
                        $"{str5}EM Sensor Strength: {this.double_2.ToString()}    Detect Sig Strength 1000:  {AuroraUtils.smethod_43(this.method_5(1000.0))} km{Environment.NewLine}";
                if (this.decimal_16 > 0M)
                    str5 =
                        $"{str5}Geo Sensor Strength: {this.decimal_16.ToString()}     Geo Points Per Day: {(this.decimal_16 * 24M).ToString()}{Environment.NewLine}";
                string str6 = "";
                if (this.int_7 > 0)
                    str6 = $"{str6}Decoys: {this.int_7.ToString()} ECM-{this.int_12.ToString()}     ";
                if (this.int_8 > 0)
                    str6 = $"{str6}ECCM-{this.int_8.ToString()}     ";
                if (this.decimal_26 > 1M)
                    str6 = $"{str6}ATG: {AuroraUtils.smethod_38((this.decimal_26 - 1M) * 100M)}%     ";
                if (this.int_10 > 0)
                    str6 += "Retarget Capable";
                if (str6 != "")
                    str5 = str5 + str6 + Environment.NewLine;
                string str7 =
                    $"{str5}Cost Per Missile: {this.decimal_3.ToString()}     Development Cost: {this.gclass0_0.method_445(this.decimal_3 * 5M).ToString()}{Environment.NewLine}";
                if (this.int_16 > 0 && this.gclass129_0 != null)
                    str7 =
                        $"{$"{str7}Second Stage: {this.gclass129_0.Name} x{this.int_16.ToString()}{Environment.NewLine}"}Second Stage Separation Range: {AuroraUtils.smethod_37(this.int_17)} km{Environment.NewLine}";
                str1 =
                    $"{str7 + Environment.NewLine}100% Chance to Hit: {AuroraUtils.smethod_39(this.method_1(100M))} km/s   50% Chance: {AuroraUtils.smethod_39(this.method_1(50M))} km/s   25% Chance: {AuroraUtils.smethod_39(this.method_1(25M))} km/s{Environment.NewLine}{Environment.NewLine}";
            }

            string str8 = $"{str1}Materials Required{Environment.NewLine}";
            if (this.gclass123_0.Corbomite > 0M)
                str8 = $"{str8}Corbomite  {this.gclass123_0.Corbomite.ToString()}{Environment.NewLine}";
            if (this.gclass123_0.Tritanium > 0M)
                str8 = $"{str8}Tritanium  {this.gclass123_0.Tritanium.ToString()}{Environment.NewLine}";
            if (this.gclass123_0.Boronide > 0M)
                str8 = $"{str8}Boronide  {this.gclass123_0.Boronide.ToString()}{Environment.NewLine}";
            if (this.gclass123_0.Vendarite > 0M)
                str8 = $"{str8}Vendarite  {this.gclass123_0.Vendarite.ToString()}{Environment.NewLine}";
            if (this.gclass123_0.Uridium > 0M)
                str8 = $"{str8}Uridium  {this.gclass123_0.Uridium.ToString()}{Environment.NewLine}";
            if (this.gclass123_0.Corundium > 0M)
                str8 = $"{str8}Corundium  {this.gclass123_0.Corundium.ToString()}{Environment.NewLine}";
            if (this.gclass123_0.Gallicite > 0M)
                str8 = $"{str8}Gallicite  {this.gclass123_0.Gallicite.ToString()}{Environment.NewLine}";
            if (this.int_4 > 0)
                str8 = $"{str8}Fuel:  {this.int_4.ToString()}{Environment.NewLine}";
            return str8;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2056);
            return "error";
        }
    }

    public string method_8()
    {
        try
        {
            string str1;
            if (this.decimal_1 > 0M)
                str1 =
                    $"Missile Size: {this.decimal_4.ToString()} MSP  ({(this.decimal_4 * 2.5M).ToString()} Tons)     Laser Warhead{Environment.NewLine}";
            else
                str1 =
                    $"Missile Size: {this.decimal_4.ToString()} MSP  ({(this.decimal_4 * 2.5M).ToString()} Tons){Environment.NewLine}";
            string str2 = $"{str1}Speed: {AuroraUtils.smethod_38(this.decimal_5)} km/s{Environment.NewLine}";
            if (this.int_16 > 0)
                str2 = $"{str2}Contains Second Stage{Environment.NewLine}";
            return
                $"{str2}Cost Per Missile: {this.decimal_3.ToString()}     Development Cost: {this.gclass0_0.method_445(this.decimal_3 * 5M).ToString()}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2056);
            return "error";
        }
    }
}