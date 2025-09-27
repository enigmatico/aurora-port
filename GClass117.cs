// Decompiled with JetBrains decompiler
// Type: GClass117
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass117
{
    private GClass0 gclass0_0;
    public AlienRaceInfo gclass110_0;
    public GClass115 gclass115_0;
    public GClass116 gclass116_0;
    public FCTShipData40 gclass40_0;
    public FCTRaceRecordC21 gclass21_0;
    public FCTRaceRecordC21 gclass21_1;
    public SystemData200 gclass200_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public Decimal decimal_5;
    public Decimal decimal_6;
    public Decimal decimal_7;
    public double double_0;
    public double double_1;
    public double double_2;
    public string string_0;
    public bool bool_0;
    public bool bool_1;
    public int int_4;
    public Decimal decimal_8;

    public GClass117(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public bool method_0(int int_5)
    {
        try
        {
            foreach (JumpPoint120 gclass120 in this.gclass0_0.JumpPointDictionary.Values
                         .Where<JumpPoint120>(gclass120_0 =>
                             gclass120_0.SystemData == this.gclass40_0.gclass85_0.System.ActualSystemData)
                         .Where<JumpPoint120>(gclass120_0 =>
                             gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass21_1.RaceID))
                         .Where<JumpPoint120>(
                             gclass120_0 => gclass120_0.RacialJumpPointSurveys[this.gclass21_1.RaceID].Charted == 1)
                         .ToList<JumpPoint120>())
            {
                if (this.gclass0_0.GetDistanceBetween(gclass120.XCoord, gclass120.YCoord, this.gclass40_0.gclass85_0.XCoord,
                        this.gclass40_0.gclass85_0.YCoord) < int_5 * 30)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3954);
            return false;
        }
    }

    public void method_1()
    {
        try
        {
            this.decimal_3 = 0M;
            if (this.gclass115_0.list_1.Count > 0)
                this.decimal_3 = 50M;
            if (this.gclass115_0.genum70_0 == EngineDesignType.const_2)
                return;
            this.decimal_3 = 20M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1912);
        }
    }

    public GClass117 method_2(FCTRaceRecordC21 gclass21_2, List<AlienRaceInfo> list_0, List<GClass115> list_1)
    {
        try
        {
            GClass117 gclass117_1 = new GClass117(this.gclass0_0);
            GClass117 gclass117_2 = (GClass117)this.MemberwiseClone();
            gclass117_2.gclass21_1 = gclass21_2;
            gclass117_2.gclass110_0 =
                list_0.FirstOrDefault<AlienRaceInfo>(gclass110_1 => gclass110_1.ActualAlienRace == this.gclass21_0);
            gclass117_2.gclass115_0 =
                list_1.FirstOrDefault<GClass115>(gclass115_1 => gclass115_1.gclass22_0 == this.gclass115_0.gclass22_0);
            return gclass117_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1913);
            return null;
        }
    }

    public void method_3(int int_5)
    {
        try
        {
            this.int_0 = int_5;
            if (!this.gclass0_0.FCTShipDataDictionary.ContainsKey(this.int_0))
                return;
            this.gclass40_0 = this.gclass0_0.FCTShipDataDictionary[this.int_0];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1914);
        }
    }

    public void method_4(List<GClass116> list_0)
    {
        try
        {
            GClass116 gclass116 = list_0.FirstOrDefault<GClass116>(gclass116_1 =>
                this.gclass0_0.method_521(this.gclass40_0.gclass85_0.XCoord, gclass116_1.double_0,
                    this.gclass40_0.gclass85_0.YCoord, gclass116_1.double_1, 50000.0));
            if (gclass116 == null)
            {
                gclass116 = new GClass116();
                gclass116.double_0 = this.gclass40_0.gclass85_0.XCoord;
                gclass116.double_1 = this.gclass40_0.gclass85_0.YCoord;
                gclass116.int_1 = this.gclass40_0.gclass22_0.int_32;
                list_0.Add(gclass116);
            }
            else if (this.gclass40_0.gclass22_0.int_32 > gclass116.int_1 && this.gclass40_0.gclass40_0 == null)
                gclass116.int_1 = this.gclass40_0.gclass22_0.int_32;

            if (this.gclass115_0.int_6 > 0)
                gclass116.double_2 +=
                    this.gclass115_0.int_5 * (this.gclass115_0.int_7 / (double)this.gclass115_0.int_6);
            if (this.gclass115_0.bool_0)
                ++gclass116.int_2;
            gclass116.list_0.Add(this);
            this.gclass116_0 = gclass116;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1915);
        }
    }

    public void method_5()
    {
        try
        {
            this.method_1();
            this.decimal_4 = this.gclass115_0.gclass22_0.decimal_14 +
                             this.gclass115_0.list_1.Sum<GClass119>(gclass119_0 =>
                                 gclass119_0.gclass230_0.decimal_2 * gclass119_0.int_1) +
                             this.gclass115_0.list_0.Sum<GClass118>(gclass118_0 => gclass118_0.gclass230_0.decimal_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1916);
        }
    }

    public void method_6(FCTShipData40 gclass40_1)
    {
        try
        {
            this.double_2 = this.gclass0_0.GetDistanceBetween(gclass40_1.gclass85_0.XCoord, gclass40_1.gclass85_0.YCoord,
                this.gclass40_0.gclass85_0.XCoord, this.gclass40_0.gclass85_0.YCoord);
            if (this.double_2 < 100000.0)
            {
                if (this.gclass115_0.genum57_0 == GEnum57.const_4)
                    this.decimal_5 = this.decimal_4 * 1000M;
                else if (this.gclass115_0.genum57_0 == GEnum57.const_3)
                {
                    this.decimal_5 = this.decimal_4 * 500M;
                }
                else
                {
                    if (this.gclass115_0.genum57_0 != GEnum57.const_2)
                        return;
                    this.decimal_5 = this.decimal_4 * 300M;
                }
            }
            else if (this.double_2 < 500000.0)
            {
                if (this.gclass115_0.genum57_0 == GEnum57.const_3)
                {
                    this.decimal_5 = this.decimal_4 * 50M;
                }
                else
                {
                    if (this.gclass115_0.genum57_0 != GEnum57.const_2)
                        return;
                    this.decimal_5 = this.decimal_4 * 30M;
                }
            }
            else if (this.double_2 < 5000000.0)
            {
                if (this.gclass115_0.genum57_0 == GEnum57.const_2)
                {
                    this.decimal_5 = this.decimal_4 * 20M;
                }
                else
                {
                    if (this.gclass115_0.genum57_0 != GEnum57.const_1)
                        return;
                    this.decimal_5 = this.decimal_4 * 10M;
                }
            }
            else if (this.gclass115_0.genum57_0 == GEnum57.const_1)
                this.decimal_5 = this.decimal_4 * 6M;
            else if (this.gclass115_0.genum57_0 == GEnum57.const_2)
                this.decimal_5 = this.decimal_4 * 2M;
            else
                this.decimal_5 = this.decimal_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1917);
        }
    }

    public Decimal method_7()
    {
        try
        {
            Decimal num1 = Math.Round(this.gclass115_0.gclass22_0.decimal_14 + this.gclass40_0.decimal_3);
            if (this.gclass115_0.gclass22_0.bool_2)
                num1 /= 10M;
            if (this.gclass116_0 == null)
                return num1;
            Decimal num2 = num1 / this.gclass21_1.DesignDoctrine.MissileStandard.decimal_4;
            if ((Decimal)this.gclass116_0.double_2 > num2)
            {
                double num3 = Math.Sqrt(this.gclass116_0.double_2 / (double)num2);
                num1 *= (Decimal)num3;
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1918);
            return 0M;
        }
    }

    public Decimal method_8()
    {
        try
        {
            Decimal num = Math.Round(this.gclass115_0.gclass22_0.decimal_14 + this.gclass40_0.decimal_3);
            if (this.gclass115_0.gclass22_0.bool_2)
                num /= 10M;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1919);
            return 0M;
        }
    }

    public void method_9(Decimal decimal_9, GEnum51 genum51_0)
    {
        try
        {
            switch (genum51_0)
            {
                case GEnum51.const_1:
                    this.decimal_7 += decimal_9;
                    break;
                case GEnum51.const_2:
                    this.int_2 += (int)Math.Floor(decimal_9);
                    break;
                case GEnum51.const_3:
                    this.int_3 += (int)Math.Floor(decimal_9);
                    break;
            }

            this.decimal_6 += decimal_9;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1920);
        }
    }

    public void method_10(FCTShipData40 gclass40_1)
    {
        try
        {
            this.decimal_0 = this.gclass0_0.decimal_0;
            this.gclass200_0 = gclass40_1.gclass85_0.System.ActualSystemData;
            this.double_0 = gclass40_1.gclass85_0.XCoord;
            this.double_1 = gclass40_1.gclass85_0.YCoord;
            this.int_1 = gclass40_1.gclass85_0.Speed;
            if (this.gclass110_0.dictionary_1.ContainsKey(this.gclass200_0.SystemID))
                return;
            RacialSystemSurvey gclass202 = this.gclass21_1.method_128(gclass40_1.gclass85_0.System.ActualSystemData);
            string str = "";
            if (gclass202.AutoSystemProtectionStatus != AuroraSystemProtectionStatus.NoProtection)
            {
                gclass202.dictionary_0.Add(this.gclass110_0, new AlienRaceSystemStatus()
                {
                    auroraSystemProtectionStatus_0 = gclass202.AutoSystemProtectionStatus,
                    gclass202_0 = gclass202,
                    gclass110_0 = this.gclass110_0
                });
                str =
                    $" As per the system-level auto-protection setting, the protection status for {this.gclass110_0.AlienRaceName} has been set to '{AuroraUtils.smethod_82(gclass202.AutoSystemProtectionStatus)}.";
            }
            else
            {
                AuroraSystemProtectionStatus enum_0 = gclass202.method_1();
                if (enum_0 != AuroraSystemProtectionStatus.NoProtection)
                    str =
                        $" This system has a protection status set to '{AuroraUtils.smethod_82(enum_0)}' for a different race.";
            }

            this.gclass110_0.dictionary_1.Add(this.gclass200_0.SystemID, this.gclass200_0);
            this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                $"The {this.gclass110_0.AlienRaceName} has been detected in {gclass202.Name} for the first time.{str}",
                this.gclass21_1, gclass202.ActualSystemData, gclass40_1.gclass85_0.XCoord, gclass40_1.gclass85_0.YCoord,
                AuroraEventCategory.Intelligence);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1921);
        }
    }

    public string method_11()
    {
        try
        {
            return $"{this.gclass115_0.gclass76_0.Abbreviation} {this.string_0}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1922);
            return "error";
        }
    }
}