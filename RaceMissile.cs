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
    public TechSystem TechSystem;
    public ShipComponent EngineComponent;
    public RaceMissile SecondStageMissile;
    public AllMineralsValue ProductionMineralCost;
    public int MissileID;
    public int MissileSeriesID;
    public int MissilesRequired;
    public int MissilesAvailable;
    public int FuelRequired;
    public int SensorResolution;
    public int SensorRange;
    public int NumDecoys;
    public int ECCM;
    public int NumEngines;
    public int Retargeting;
    public int LaserWarheadRangeModifier;
    public int MissileECM;
    public int MultipleWarheads = 1;
    public int ShipDecoy;
    public int SecondStageID;
    public int NumSS;
    public int SeparationRange;
    public Decimal WarheadStrength;
    public Decimal LaserWarhead;
    public Decimal RadDamage;
    public Decimal Cost;
    public Decimal Size;
    public Decimal Speed;
    public Decimal MSPReactor;
    public Decimal MSPWarhead;
    public Decimal MSPEngine;
    public Decimal MSPFuel;
    public Decimal MSPActive;
    public Decimal MSPThermal;
    public Decimal MSPEM;
    public Decimal MSPGeo;
    public Decimal MSPDecoys;
    public Decimal MSPMultipleWarheads;
    public Decimal GeoStrength;
    public Decimal GroundAP;
    public Decimal GroundDamage;
    public Decimal GroundShots;
    public Decimal GroundBaseDamage;
    public Decimal Endurance;
    public Decimal TotalFlightTime;
    public Decimal PowerMod;
    public Decimal MinDetonationRange;
    public Decimal MaxDetonationRange;
    public Decimal ATG;
    public double SensorStrength;
    public double ThermalStrength;
    public double EMStrength;
    public double EMSensitivity;
    public double CombinatedMaxRange;
    public double MaxRange;
    public bool PrecursorMissile;
    public bool PreTNT;
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
            if (this.ATG < 1M)
                this.ATG = 1M;
            return (double)this.Speed / double_6 * AuroraUtils.int_9 * double_8 * (double)this.ATG *
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
            if (this.ATG < 1M)
                this.ATG = 1M;
            return this.Speed * AuroraUtils.int_9 * this.ATG / decimal_29;
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
            if (this.LaserWarheadRangeModifier == 0)
                return 0M;
            Decimal num = decimal_29 / this.LaserWarheadRangeModifier;
            if (num < 1M)
                num = 1M;
            return this.LaserWarhead / num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3651);
            return 0M;
        }
    }

    public double method_3(ShipData gclass40_0)
    {
        try
        {
            int y = (int)gclass40_0.method_156(AuroraJammerType.Missile);
            return y == 0 || y - this.ECCM <= 0 ? 1.0 : Math.Pow(0.75, y);
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
            return Math.Sqrt(this.ThermalStrength * double_6) * AuroraUtils.double_18;
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
            return Math.Sqrt(this.EMStrength * double_6) * AuroraUtils.double_18;
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
            if (this.Endurance > 10000M)
                str3 =
                    $"{str1}{str2} Stage Flight Time: {AuroraUtils.smethod_38(this.Endurance / 3600M)} hours    {str2} Stage Range: {AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 1)}m km{Environment.NewLine}";
            else if (this.Endurance > 120M)
                str3 =
                    $"{str1}{str2} Stage Flight Time: {AuroraUtils.smethod_38(this.Endurance / 60M)} minutes    {str2} Stage Range: {AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 2)}m km{Environment.NewLine}";
            else
                str3 =
                    $"{str1}{str2} Stage Flight Time: {AuroraUtils.smethod_38(this.Endurance)} seconds    {str2} Stage Range: {AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000.0, 1)}k km{Environment.NewLine}";
            if (this.NumSS > 0 && this.SecondStageMissile != null)
            {
                ++int_18;
                str3 += this.SecondStageMissile.method_6(int_18);
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
                    $"{$"Fighter Pod Size: {this.Size.ToString()} MSP  ({(this.Size * 2.5M).ToString()} Tons)     Armour Penetration: {this.GroundAP.ToString()}    Damage: {this.GroundDamage.ToString()}    Shots: {this.GroundShots.ToString()}{Environment.NewLine}"}Cost Per Pod: {this.Cost.ToString()}     Development Cost: {AuroraUtils.smethod_38(this.Cost * 100M)}{Environment.NewLine}";
            }
            else
            {
                string str2 = "";
                if (this.MultipleWarheads > 1)
                    str2 = $" (MW-{this.MultipleWarheads.ToString()})";
                string str3;
                if (this.LaserWarhead > 0M)
                    str3 =
                        $"{$"{$"Missile Size: {this.Size.ToString()} MSP  ({(this.Size * 2.5M).ToString()} Tons)     Laser Warhead: {this.LaserWarhead.ToString()}{Environment.NewLine}"}Minimum Detonation Range: {AuroraUtils.smethod_38(this.MinDetonationRange)}    Impact Damage: {AuroraUtils.FormatNumberToDigits(this.method_2(this.MinDetonationRange), 3)}{Environment.NewLine}"}Maximum Detonation Range: {AuroraUtils.smethod_38(this.MaxDetonationRange)}    Impact Damage: {AuroraUtils.FormatNumberToDigits(this.method_2(this.MaxDetonationRange), 3)}{Environment.NewLine}";
                else if (this.ShipDecoy == 1)
                    str3 =
                        $"Decoy Missile Size: {this.Size.ToString()} MSP  ({(this.Size * 2.5M).ToString()} Tons)     Decoy Signature: {this.WarheadStrength.ToString()} tons    ECM-{this.MissileECM.ToString()}{Environment.NewLine}";
                else
                    str3 =
                        $"Missile Size: {this.Size.ToString()} MSP  ({(this.Size * 2.5M).ToString()} Tons)     Warhead: {this.WarheadStrength.ToString()}{str2}    Radiation Damage: {this.RadDamage.ToString()}{Environment.NewLine}";
                string str4 =
                    $"{str3}Speed: {AuroraUtils.smethod_38(this.Speed)} km/s     Fuel: {AuroraUtils.smethod_37(this.FuelRequired)}     ";
                string str5;
                if (this.NumSS > 0)
                    str5 = str4 + this.method_6(1);
                else if (this.TotalFlightTime > 10000M)
                    str5 =
                        $"{str4}Flight Time: {AuroraUtils.smethod_38(this.Endurance / 3600M)} hours     Range: {AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 1)}m km{Environment.NewLine}";
                else if (this.TotalFlightTime > 120M)
                    str5 =
                        $"{str4}Flight Time: {AuroraUtils.smethod_38(this.Endurance / 60M)} minutes     Range: {AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 2)}m km{Environment.NewLine}";
                else
                    str5 =
                        $"{str4}Flight Time: {AuroraUtils.FormatNumberToDigits(this.Endurance, 1)} seconds     Range: {AuroraUtils.smethod_43(this.MaxRange)} km{Environment.NewLine}";
                if (this.SensorStrength > 0.0)
                    str5 =
                        $"{$"{str5}Active Sensor Strength: {this.SensorStrength.ToString()}   EM Sensitivity Modifier: {this.EMSensitivity.ToString()}{Environment.NewLine}"}Resolution: {this.SensorResolution.ToString()}    Maximum Range vs {(this.SensorResolution * 50).ToString()} ton object (or larger): {AuroraUtils.smethod_39(this.SensorRange)} km{Environment.NewLine}";
                if (this.ThermalStrength > 0.0)
                    str5 =
                        $"{str5}Thermal Sensor Strength: {this.ThermalStrength.ToString()}    Detect Sig Strength 1000:  {AuroraUtils.smethod_43(this.method_4(1000.0))} km{Environment.NewLine}";
                if (this.EMStrength > 0.0)
                    str5 =
                        $"{str5}EM Sensor Strength: {this.EMStrength.ToString()}    Detect Sig Strength 1000:  {AuroraUtils.smethod_43(this.method_5(1000.0))} km{Environment.NewLine}";
                if (this.GeoStrength > 0M)
                    str5 =
                        $"{str5}Geo Sensor Strength: {this.GeoStrength.ToString()}     Geo Points Per Day: {(this.GeoStrength * 24M).ToString()}{Environment.NewLine}";
                string str6 = "";
                if (this.NumDecoys > 0)
                    str6 = $"{str6}Decoys: {this.NumDecoys.ToString()} ECM-{this.MissileECM.ToString()}     ";
                if (this.ECCM > 0)
                    str6 = $"{str6}ECCM-{this.ECCM.ToString()}     ";
                if (this.ATG > 1M)
                    str6 = $"{str6}ATG: {AuroraUtils.smethod_38((this.ATG - 1M) * 100M)}%     ";
                if (this.Retargeting > 0)
                    str6 += "Retarget Capable";
                if (str6 != "")
                    str5 = str5 + str6 + Environment.NewLine;
                string str7 =
                    $"{str5}Cost Per Missile: {this.Cost.ToString()}     Development Cost: {this.gclass0_0.method_445(this.Cost * 5M).ToString()}{Environment.NewLine}";
                if (this.NumSS > 0 && this.SecondStageMissile != null)
                    str7 =
                        $"{$"{str7}Second Stage: {this.SecondStageMissile.Name} x{this.NumSS.ToString()}{Environment.NewLine}"}Second Stage Separation Range: {AuroraUtils.smethod_37(this.SeparationRange)} km{Environment.NewLine}";
                str1 =
                    $"{str7 + Environment.NewLine}100% Chance to Hit: {AuroraUtils.smethod_39(this.method_1(100M))} km/s   50% Chance: {AuroraUtils.smethod_39(this.method_1(50M))} km/s   25% Chance: {AuroraUtils.smethod_39(this.method_1(25M))} km/s{Environment.NewLine}{Environment.NewLine}";
            }

            string str8 = $"{str1}Materials Required{Environment.NewLine}";
            if (this.ProductionMineralCost.Corbomite > 0M)
                str8 = $"{str8}Corbomite  {this.ProductionMineralCost.Corbomite.ToString()}{Environment.NewLine}";
            if (this.ProductionMineralCost.Tritanium > 0M)
                str8 = $"{str8}Tritanium  {this.ProductionMineralCost.Tritanium.ToString()}{Environment.NewLine}";
            if (this.ProductionMineralCost.Boronide > 0M)
                str8 = $"{str8}Boronide  {this.ProductionMineralCost.Boronide.ToString()}{Environment.NewLine}";
            if (this.ProductionMineralCost.Vendarite > 0M)
                str8 = $"{str8}Vendarite  {this.ProductionMineralCost.Vendarite.ToString()}{Environment.NewLine}";
            if (this.ProductionMineralCost.Uridium > 0M)
                str8 = $"{str8}Uridium  {this.ProductionMineralCost.Uridium.ToString()}{Environment.NewLine}";
            if (this.ProductionMineralCost.Corundium > 0M)
                str8 = $"{str8}Corundium  {this.ProductionMineralCost.Corundium.ToString()}{Environment.NewLine}";
            if (this.ProductionMineralCost.Gallicite > 0M)
                str8 = $"{str8}Gallicite  {this.ProductionMineralCost.Gallicite.ToString()}{Environment.NewLine}";
            if (this.FuelRequired > 0)
                str8 = $"{str8}Fuel:  {this.FuelRequired.ToString()}{Environment.NewLine}";
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
            if (this.LaserWarhead > 0M)
                str1 =
                    $"Missile Size: {this.Size.ToString()} MSP  ({(this.Size * 2.5M).ToString()} Tons)     Laser Warhead{Environment.NewLine}";
            else
                str1 =
                    $"Missile Size: {this.Size.ToString()} MSP  ({(this.Size * 2.5M).ToString()} Tons){Environment.NewLine}";
            string str2 = $"{str1}Speed: {AuroraUtils.smethod_38(this.Speed)} km/s{Environment.NewLine}";
            if (this.NumSS > 0)
                str2 = $"{str2}Contains Second Stage{Environment.NewLine}";
            return
                $"{str2}Cost Per Missile: {this.Cost.ToString()}     Development Cost: {this.gclass0_0.method_445(this.Cost * 5M).ToString()}{Environment.NewLine}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2056);
            return "error";
        }
    }
}