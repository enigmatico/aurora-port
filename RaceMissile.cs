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
                    string.Format("{0}{1} Stage Flight Time: {2} hours    {3} Stage Range: {4}m km{5}", str1, str2,
                        AuroraUtils.smethod_38(this.Endurance / 3600M), str2,
                        AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 1), Environment.NewLine);
            else if (this.Endurance > 120M)
                str3 =
                    string.Format("{0}{1} Stage Flight Time: {2} minutes    {3} Stage Range: {4}m km{5}", str1, str2,
                        AuroraUtils.smethod_38(this.Endurance / 60M), str2,
                        AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 2), Environment.NewLine);
            else
                str3 =
                    string.Format("{0}{1} Stage Flight Time: {2} seconds    {3} Stage Range: {4}k km{5}", str1, str2,
                        AuroraUtils.smethod_38(this.Endurance), str2,
                        AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000.0, 1), Environment.NewLine);
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
                    string.Format("{0}Cost Per Pod: {1}     Development Cost: {2}{3}",
                        string.Format(
                            "Fighter Pod Size: {0} MSP  ({1} Tons)     Armour Penetration: {2}    Damage: {3}    Shots: {4}{5}",
                            this.Size.ToString(), (this.Size * 2.5M).ToString(), this.GroundAP.ToString(),
                            this.GroundDamage.ToString(), this.GroundShots.ToString(), Environment.NewLine),
                        this.Cost.ToString(), AuroraUtils.smethod_38(this.Cost * 100M), Environment.NewLine);
            }
            else
            {
                string str2 = "";
                if (this.MultipleWarheads > 1)
                    str2 = string.Format(" (MW-{0})", this.MultipleWarheads.ToString());
                string str3;
                if (this.LaserWarhead > 0M)
                    str3 =
                        string.Format("{0}Maximum Detonation Range: {1}    Impact Damage: {2}{3}",
                            string.Format("{0}Minimum Detonation Range: {1}    Impact Damage: {2}{3}",
                                string.Format("Missile Size: {0} MSP  ({1} Tons)     Laser Warhead: {2}{3}",
                                    this.Size.ToString(), (this.Size * 2.5M).ToString(), this.LaserWarhead.ToString(),
                                    Environment.NewLine),
                                AuroraUtils.smethod_38(this.MinDetonationRange),
                                AuroraUtils.FormatNumberToDigits(this.method_2(this.MinDetonationRange), 3),
                                Environment.NewLine),
                            AuroraUtils.smethod_38(this.MaxDetonationRange),
                            AuroraUtils.FormatNumberToDigits(this.method_2(this.MaxDetonationRange), 3),
                            Environment.NewLine);
                else if (this.ShipDecoy == 1)
                    str3 =
                        string.Format(
                            "Decoy Missile Size: {0} MSP  ({1} Tons)     Decoy Signature: {2} tons    ECM-{3}{4}",
                            this.Size.ToString(), (this.Size * 2.5M).ToString(), this.WarheadStrength.ToString(),
                            this.MissileECM.ToString(), Environment.NewLine);
                else
                    str3 =
                        string.Format(
                            "Missile Size: {0} MSP  ({1} Tons)     Warhead: {2}{3}    Radiation Damage: {4}{5}",
                            this.Size.ToString(), (this.Size * 2.5M).ToString(), this.WarheadStrength.ToString(), str2,
                            this.RadDamage.ToString(), Environment.NewLine);
                string str4 =
                    string.Format("{0}Speed: {1} km/s     Fuel: {2}     ", str3, AuroraUtils.smethod_38(this.Speed),
                        AuroraUtils.smethod_37(this.FuelRequired));
                string str5;
                if (this.NumSS > 0)
                    str5 = str4 + this.method_6(1);
                else if (this.TotalFlightTime > 10000M)
                    str5 =
                        string.Format("{0}Flight Time: {1} hours     Range: {2}m km{3}", str4,
                            AuroraUtils.smethod_38(this.Endurance / 3600M),
                            AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 1), Environment.NewLine);
                else if (this.TotalFlightTime > 120M)
                    str5 =
                        string.Format("{0}Flight Time: {1} minutes     Range: {2}m km{3}", str4,
                            AuroraUtils.smethod_38(this.Endurance / 60M),
                            AuroraUtils.FormatDoubleToPrecision(this.MaxRange / 1000000.0, 2), Environment.NewLine);
                else
                    str5 =
                        string.Format("{0}Flight Time: {1} seconds     Range: {2} km{3}", str4,
                            AuroraUtils.FormatNumberToDigits(this.Endurance, 1), AuroraUtils.smethod_43(this.MaxRange),
                            Environment.NewLine);
                if (this.SensorStrength > 0.0)
                    str5 =
                        string.Format("{0}Resolution: {1}    Maximum Range vs {2} ton object (or larger): {3} km{4}",
                            string.Format("{0}Active Sensor Strength: {1}   EM Sensitivity Modifier: {2}{3}", str5,
                                this.SensorStrength.ToString(), this.EMSensitivity.ToString(), Environment.NewLine),
                            this.SensorResolution.ToString(), (this.SensorResolution * 50).ToString(),
                            AuroraUtils.smethod_39(this.SensorRange), Environment.NewLine);
                if (this.ThermalStrength > 0.0)
                    str5 =
                        string.Format("{0}Thermal Sensor Strength: {1}    Detect Sig Strength 1000:  {2} km{3}", str5,
                            this.ThermalStrength.ToString(), AuroraUtils.smethod_43(this.method_4(1000.0)),
                            Environment.NewLine);
                if (this.EMStrength > 0.0)
                    str5 =
                        string.Format("{0}EM Sensor Strength: {1}    Detect Sig Strength 1000:  {2} km{3}", str5,
                            this.EMStrength.ToString(), AuroraUtils.smethod_43(this.method_5(1000.0)),
                            Environment.NewLine);
                if (this.GeoStrength > 0M)
                    str5 =
                        string.Format("{0}Geo Sensor Strength: {1}     Geo Points Per Day: {2}{3}", str5,
                            this.GeoStrength.ToString(), (this.GeoStrength * 24M).ToString(), Environment.NewLine);
                string str6 = "";
                if (this.NumDecoys > 0)
                    str6 = string.Format("{0}Decoys: {1} ECM-{2}     ", str6, this.NumDecoys.ToString(),
                        this.MissileECM.ToString());
                if (this.ECCM > 0)
                    str6 = string.Format("{0}ECCM-{1}     ", str6, this.ECCM.ToString());
                if (this.ATG > 1M)
                    str6 = string.Format("{0}ATG: {1}%     ", str6, AuroraUtils.smethod_38((this.ATG - 1M) * 100M));
                if (this.Retargeting > 0)
                    str6 += "Retarget Capable";
                if (str6 != "")
                    str5 = str5 + str6 + Environment.NewLine;
                string str7 =
                    string.Format("{0}Cost Per Missile: {1}     Development Cost: {2}{3}", str5, this.Cost.ToString(),
                        this.gclass0_0.method_445(this.Cost * 5M).ToString(), Environment.NewLine);
                if (this.NumSS > 0 && this.SecondStageMissile != null)
                    str7 =
                        string.Format("{0}Second Stage Separation Range: {1} km{2}",
                            string.Format("{0}Second Stage: {1} x{2}{3}", str7, this.SecondStageMissile.Name,
                                this.NumSS.ToString(), Environment.NewLine),
                            AuroraUtils.smethod_37(this.SeparationRange), Environment.NewLine);
                str1 =
                    string.Format("{0}100% Chance to Hit: {1} km/s   50% Chance: {2} km/s   25% Chance: {3} km/s{4}{5}",
                        str7 + Environment.NewLine, AuroraUtils.smethod_39(this.method_1(100M)),
                        AuroraUtils.smethod_39(this.method_1(50M)), AuroraUtils.smethod_39(this.method_1(25M)),
                        Environment.NewLine, Environment.NewLine);
            }

            string str8 = string.Format("{0}Materials Required{1}", str1, Environment.NewLine);
            if (this.ProductionMineralCost.Corbomite > 0M)
                str8 = string.Format("{0}Corbomite  {1}{2}", str8, this.ProductionMineralCost.Corbomite.ToString(),
                    Environment.NewLine);
            if (this.ProductionMineralCost.Tritanium > 0M)
                str8 = string.Format("{0}Tritanium  {1}{2}", str8, this.ProductionMineralCost.Tritanium.ToString(),
                    Environment.NewLine);
            if (this.ProductionMineralCost.Boronide > 0M)
                str8 = string.Format("{0}Boronide  {1}{2}", str8, this.ProductionMineralCost.Boronide.ToString(),
                    Environment.NewLine);
            if (this.ProductionMineralCost.Vendarite > 0M)
                str8 = string.Format("{0}Vendarite  {1}{2}", str8, this.ProductionMineralCost.Vendarite.ToString(),
                    Environment.NewLine);
            if (this.ProductionMineralCost.Uridium > 0M)
                str8 = string.Format("{0}Uridium  {1}{2}", str8, this.ProductionMineralCost.Uridium.ToString(),
                    Environment.NewLine);
            if (this.ProductionMineralCost.Corundium > 0M)
                str8 = string.Format("{0}Corundium  {1}{2}", str8, this.ProductionMineralCost.Corundium.ToString(),
                    Environment.NewLine);
            if (this.ProductionMineralCost.Gallicite > 0M)
                str8 = string.Format("{0}Gallicite  {1}{2}", str8, this.ProductionMineralCost.Gallicite.ToString(),
                    Environment.NewLine);
            if (this.FuelRequired > 0)
                str8 = string.Format("{0}Fuel:  {1}{2}", str8, this.FuelRequired.ToString(), Environment.NewLine);
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
                    string.Format("Missile Size: {0} MSP  ({1} Tons)     Laser Warhead{2}", this.Size.ToString(),
                        (this.Size * 2.5M).ToString(), Environment.NewLine);
            else
                str1 =
                    string.Format("Missile Size: {0} MSP  ({1} Tons){2}", this.Size.ToString(),
                        (this.Size * 2.5M).ToString(), Environment.NewLine);
            string str2 = string.Format("{0}Speed: {1} km/s{2}", str1, AuroraUtils.smethod_38(this.Speed),
                Environment.NewLine);
            if (this.NumSS > 0)
                str2 = string.Format("{0}Contains Second Stage{1}", str2, Environment.NewLine);
            return
                string.Format("{0}Cost Per Missile: {1}     Development Cost: {2}{3}", str2, this.Cost.ToString(),
                    this.gclass0_0.method_445(this.Cost * 5M).ToString(), Environment.NewLine);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2056);
            return "error";
        }
    }
}