// Decompiled with JetBrains decompiler
// Type: GClass5
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass5
{
    private GClass0 gclass0_0;
    private FCTShipData40 gclass40_0;
    public RaceMissile gclass129_0;
    public GEnum99 genum99_0 = GEnum99.const_4;
    public GEnum101 genum101_0 = GEnum101.const_3;
    public GEnum102 genum102_0 = GEnum102.const_3;
    public GEnum103 genum103_0 = GEnum103.const_4;
    public double double_0;
    public double double_1;
    public GClass71 gclass71_0;
    public GClass72 gclass72_0;
    public double double_2;
    public double double_3;
    public double double_4;
    public double double_5;
    public bool bool_0;

    public GClass5(GClass0 gclass0_1, FCTShipData40 gclass40_1)
    {
        this.gclass0_0 = gclass0_1;
        this.gclass40_0 = gclass40_1;
    }

    public bool method_0()
    {
        try
        {
            if (this.gclass40_0.gclass22_0.gclass14_0.SurrenderStatus == SurrenderStatusDesignType.const_0)
                return false;
            if (this.gclass40_0.gclass22_0.gclass14_0.SurrenderStatus == SurrenderStatusDesignType.const_1)
                return true;
            if (this.gclass40_0.gclass22_0.gclass14_0.SurrenderStatus == SurrenderStatusDesignType.const_2)
            {
                if (this.gclass40_0.gclass5_0.genum99_0 == GEnum99.const_0)
                    return true;
            }
            else if (this.gclass40_0.gclass22_0.gclass14_0.SurrenderStatus == SurrenderStatusDesignType.const_3 &&
                     (this.gclass40_0.gclass5_0.genum99_0 == GEnum99.const_0 ||
                      this.gclass40_0.gclass5_0.genum103_0 == GEnum103.const_0))
                return true;

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 100);
            return false;
        }
    }

    public bool method_1(FCTShipData40 gclass40_1, double double_6)
    {
        try
        {
            this.method_13(gclass40_1.method_51(), false);
            double num = this.double_1 / (double)this.gclass129_0.decimal_5;
            this.double_5 = this.double_1 - gclass40_1.gclass22_0.int_32 * num;
            return double_6 < this.double_5;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 101);
            return false;
        }
    }

    public bool method_2(double double_6)
    {
        try
        {
            this.method_13(1000M, false);
            return double_6 < this.double_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 101);
            return false;
        }
    }

    public void method_3()
    {
        try
        {
            int num = (int)this.gclass40_0.method_171(false);
            if (num == this.gclass40_0.gclass22_0.int_32)
                return;
            if (num > this.gclass40_0.gclass22_0.int_32 * 0.75)
            {
                this.method_5(GEnum99.const_3);
                this.method_6(GEnum102.const_1);
            }
            else if (num >= this.gclass40_0.gclass22_0.int_32 * 0.5)
            {
                this.method_5(GEnum99.const_2);
                this.method_6(GEnum102.const_1);
            }
            else if (num > this.gclass40_0.gclass22_0.int_32 * 0.25)
            {
                this.method_5(GEnum99.const_1);
                this.method_6(GEnum102.const_0);
            }
            else
            {
                this.genum99_0 = GEnum99.const_0;
                this.method_6(GEnum102.const_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 102);
        }
    }

    public void method_4()
    {
        try
        {
            if (this.gclass40_0.gclass22_0.int_63 == 0)
                return;
            this.genum101_0 = GEnum101.const_3;
            if (this.gclass40_0.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.Harvester)
                return;
            if (this.gclass40_0.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.Tanker)
            {
                if (this.gclass40_0.decimal_14 < (int)(this.gclass40_0.gclass22_0.int_63 * 0.1))
                {
                    this.genum101_0 = GEnum101.const_2;
                }
                else
                {
                    if (!(this.gclass40_0.decimal_14 < (int)(this.gclass40_0.gclass22_0.int_63 * 0.05)))
                        return;
                    this.genum101_0 = GEnum101.const_1;
                }
            }
            else if (this.gclass40_0.decimal_14 == 0M)
            {
                this.genum99_0 = GEnum99.const_0;
                this.genum101_0 = GEnum101.const_0;
            }
            else if (this.gclass40_0.decimal_14 < (int)(this.gclass40_0.gclass22_0.int_63 * 0.2))
            {
                this.method_5(GEnum99.const_1);
                this.genum101_0 = GEnum101.const_1;
            }
            else if (this.gclass40_0.decimal_14 < (int)(this.gclass40_0.gclass22_0.int_63 * 0.3))
            {
                this.method_5(GEnum99.const_2);
                this.genum101_0 = GEnum101.const_2;
            }
            else
            {
                if (!(this.gclass40_0.decimal_14 < (int)(this.gclass40_0.gclass22_0.int_63 * 0.4)))
                    return;
                this.method_5(GEnum99.const_3);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 103);
        }
    }

    public void method_5(GEnum99 genum99_1)
    {
        try
        {
            if (this.genum99_0 <= genum99_1)
                return;
            this.genum99_0 = genum99_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 104);
        }
    }

    public void method_6(GEnum102 genum102_1)
    {
        try
        {
            if (this.genum102_0 <= genum102_1)
                return;
            this.genum102_0 = genum102_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 105);
        }
    }

    public void method_7()
    {
        try
        {
            if (this.gclass40_0.gclass22_0.int_37 == 1)
                return;
            double num = this.gclass40_0.dictionary_5.Values.Sum() /
                         (double)(this.gclass40_0.gclass22_0.int_3 * this.gclass40_0.gclass22_0.int_2);
            if (num > 0.6)
                this.method_6(GEnum102.const_0);
            else if (num > 0.4)
            {
                this.method_6(GEnum102.const_1);
            }
            else
            {
                if (num <= 0.2)
                    return;
                this.method_6(GEnum102.const_2);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 106);
        }
    }

    public void method_8(bool bool_1)
    {
        try
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            AuroraComponentType auroraComponentType = AuroraComponentType.MissileFireControl;
            if (!bool_1)
                auroraComponentType = AuroraComponentType.BeamFireControl;
            foreach (GClass228 gclass228_0 in this.gclass40_0.gclass22_0.dictionary_0.Values)
            {
                if (gclass228_0.gclass230_0.bool_4 && !bool_1)
                {
                    num1 += (int)gclass228_0.decimal_0;
                    num2 += this.gclass40_0.method_158(gclass228_0);
                }
                else if (gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                         AuroraComponentType.MissileLauncher && bool_1)
                {
                    num1 += (int)gclass228_0.decimal_0;
                    num2 += this.gclass40_0.method_158(gclass228_0);
                }
                else if (gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == auroraComponentType)
                {
                    num3 += (int)gclass228_0.decimal_0;
                    num4 += this.gclass40_0.method_158(gclass228_0);
                }
            }

            if (num4 == num3 && num2 == num1)
                return;
            if (num4 != 0 && num2 != 0)
            {
                if (num4 < num3)
                {
                    this.method_5(GEnum99.const_3);
                    this.method_6(GEnum102.const_1);
                }

                if (num2 < num1 * 0.25)
                {
                    this.genum99_0 = GEnum99.const_0;
                    this.genum102_0 = GEnum102.const_0;
                }
                else if (num2 < num1 * 0.5)
                {
                    this.method_5(GEnum99.const_1);
                    this.genum102_0 = GEnum102.const_0;
                }
                else if (num2 < num1 * 0.75)
                {
                    this.method_5(GEnum99.const_2);
                    this.method_6(GEnum102.const_1);
                }
                else
                {
                    if (num2 >= num1)
                        return;
                    this.method_5(GEnum99.const_3);
                    this.method_6(GEnum102.const_2);
                }
            }
            else
            {
                this.genum99_0 = GEnum99.const_0;
                this.method_6(GEnum102.const_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 107);
        }
    }

    public void method_9()
    {
        try
        {
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            this.genum103_0 = GEnum103.const_3;
            if (this.gclass40_0.gclass22_0.gclass14_0.MissileDesignType == MissileDesignType.const_0)
                return;
            Decimal num3 = this.gclass40_0.gclass22_0.list_0
                .Where<GClass130>(gclass130_0 => gclass130_0.gclass129_0.int_14 == 0)
                .Select<GClass130, Decimal>(gclass130_0 => gclass130_0.gclass129_0.decimal_4)
                .DefaultIfEmpty<Decimal>(0M).Min<Decimal>(decimal_0 => decimal_0);
            Decimal num4 = this.gclass40_0.method_208();
            if (num4 < num3)
                return;
            foreach (GClass130 gclass130 in this.gclass40_0.list_10)
                num1 += gclass130.gclass129_0.decimal_4 * gclass130.int_0;
            if (num1 == 0M)
            {
                this.method_5(GEnum99.const_0);
                this.genum103_0 = GEnum103.const_0;
            }
            else if (num1 > num4 * 0.5M)
                this.genum103_0 = GEnum103.const_2;
            else if (num1 > num4 * 0.3M)
            {
                this.method_5(GEnum99.const_3);
                this.genum103_0 = GEnum103.const_2;
            }
            else
            {
                this.genum103_0 = GEnum103.const_1;
                if (num1 > num2 * 0.15M)
                    this.method_5(GEnum99.const_2);
                else
                    this.method_5(GEnum99.const_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 108);
        }
    }

    public void method_10(AuroraComponentType auroraComponentType_0)
    {
        try
        {
            // ISSUE: reference to a compiler-generated method
            GClass228 gclass228_0 = this.gclass40_0.gclass22_0.dictionary_0.Values.FirstOrDefault(value =>
                value.gclass230_0.gclass231_0.ComponentTypeID == auroraComponentType_0);
            int num = this.gclass40_0.method_158(gclass228_0);
            if (num == gclass228_0.decimal_0)
                return;
            if (num < (double)gclass228_0.decimal_0 * 0.25)
            {
                this.genum99_0 = GEnum99.const_0;
                this.genum102_0 = GEnum102.const_0;
            }
            else if (num < (double)gclass228_0.decimal_0 * 0.5)
            {
                this.method_5(GEnum99.const_1);
                this.genum102_0 = GEnum102.const_0;
            }
            else if (num < (double)gclass228_0.decimal_0 * 0.75)
            {
                this.method_5(GEnum99.const_2);
                this.method_6(GEnum102.const_1);
            }
            else
            {
                if (num >= (double)gclass228_0.decimal_0)
                    return;
                this.method_5(GEnum99.const_3);
                this.method_6(GEnum102.const_2);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 109);
        }
    }

    public void method_11()
    {
        try
        {
            int num1 = 0;
            int num2 = 0;
            foreach (GClass228 gclass228_0 in this.gclass40_0.gclass22_0.dictionary_0.Values.Where<GClass228>(
                             gclass228_0 =>
                                 gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                                 AuroraComponentType.ActiveSearchSensors ||
                                 gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                                 AuroraComponentType.ThermalSensors ||
                                 gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                                 AuroraComponentType.EMSensors)
                         .ToList<GClass228>())
            {
                num2 += (int)gclass228_0.decimal_0;
                num1 += this.gclass40_0.method_158(gclass228_0);
            }

            if (num1 == num2)
                return;
            if (num1 < num2 * 0.3)
            {
                this.genum99_0 = GEnum99.const_0;
                this.genum102_0 = GEnum102.const_0;
            }
            else if (num1 < num2 * 0.6)
            {
                this.method_5(GEnum99.const_1);
                this.genum102_0 = GEnum102.const_0;
            }
            else
            {
                if (num1 >= num2)
                    return;
                this.method_5(GEnum99.const_2);
                this.method_6(GEnum102.const_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 110);
        }
    }

    public GEnum99 method_12()
    {
        try
        {
            this.genum99_0 = GEnum99.const_4;
            this.genum102_0 = GEnum102.const_3;
            this.genum103_0 = GEnum103.const_4;
            if (this.gclass40_0.dictionary_5.Count > 0)
                this.method_7();
            if (this.gclass40_0.list_12.Count > 0)
                this.method_3();
            if (this.gclass40_0.gclass21_0.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                this.genum101_0 = GEnum101.const_3;
            else
                this.method_4();
            switch (this.gclass40_0.gclass22_0.gclass14_0.AutomatedClassDesignTypeID)
            {
                case AutomatedClassDesignType.SmallFreighter:
                case AutomatedClassDesignType.LargeFreighter:
                case AutomatedClassDesignType.HugeFreighter:
                    if (this.gclass40_0.method_157(AuroraComponentType.CargoHold, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                    }

                    if (this.gclass40_0.method_157(AuroraComponentType.CargoShuttleBay, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.SmallColony:
                case AutomatedClassDesignType.LargeColony:
                case AutomatedClassDesignType.Liner:
                case AutomatedClassDesignType.LargeLiner:
                case AutomatedClassDesignType.HugeColony:
                    if (this.gclass40_0.method_157(AuroraComponentType.ColonistTransport, false) == 0M &&
                        this.gclass40_0.method_157(AuroraComponentType.PassengerModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                    }

                    if (this.gclass40_0.method_157(AuroraComponentType.CargoShuttleBay, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.TerraFormer:
                    if (this.gclass40_0.method_157(AuroraComponentType.TerraformingModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.Harvester:
                    if (this.gclass40_0.method_157(AuroraComponentType.SoriumHarvester, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.Geosurvey:
                case AutomatedClassDesignType.SwarmGeosurvey:
                    if (this.gclass40_0.method_157(AuroraComponentType.GeologicalSurveySensors, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.Gravsurvey:
                case AutomatedClassDesignType.SwarmGravsurvey:
                    if (this.gclass40_0.method_157(AuroraComponentType.GravitationalSurveySensors, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.BeamDD:
                case AutomatedClassDesignType.BeamCA:
                case AutomatedClassDesignType.BeamBC:
                case AutomatedClassDesignType.BeamDE:
                case AutomatedClassDesignType.BeamCLE:
                case AutomatedClassDesignType.BeamDefenceBase:
                case AutomatedClassDesignType.SwarmMicrowaveFAC:
                case AutomatedClassDesignType.SwarmBioAcidFAC:
                case AutomatedClassDesignType.SwarmEscort:
                case AutomatedClassDesignType.EnergyFighter:
                    this.method_8(false);
                    break;
                case AutomatedClassDesignType.MissileDD:
                case AutomatedClassDesignType.MissileCA:
                case AutomatedClassDesignType.MissileBC:
                case AutomatedClassDesignType.MissileDE:
                case AutomatedClassDesignType.MissileCLE:
                case AutomatedClassDesignType.FAC:
                case AutomatedClassDesignType.MissileDefenceBase:
                case AutomatedClassDesignType.FACKillerDD:
                case AutomatedClassDesignType.FighterKillerDD:
                case AutomatedClassDesignType.MissileFighter:
                case AutomatedClassDesignType.MissileBase:
                    this.method_8(true);
                    this.method_9();
                    break;
                case AutomatedClassDesignType.MissileJumpCA:
                case AutomatedClassDesignType.MissileJumpBC:
                case AutomatedClassDesignType.MissileJumpDD:
                case AutomatedClassDesignType.MissileJumpDE:
                case AutomatedClassDesignType.MissileJumpCLE:
                case AutomatedClassDesignType.FACKillerJumpDD:
                case AutomatedClassDesignType.FighterKillerJumpDD:
                    this.method_8(true);
                    this.method_9();
                    if (this.gclass40_0.method_157(AuroraComponentType.JumpDrive, false) == 0M)
                    {
                        this.method_5(GEnum99.const_2);
                        this.genum102_0 = GEnum102.const_1;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.BeamJumpDD:
                case AutomatedClassDesignType.BeamJumpCA:
                case AutomatedClassDesignType.BeamJumpBC:
                case AutomatedClassDesignType.BeamJumpDE:
                case AutomatedClassDesignType.BeamJumpCLE:
                case AutomatedClassDesignType.SwarmHiveSmall:
                case AutomatedClassDesignType.SwarmHiveMedium:
                case AutomatedClassDesignType.SwarmHiveLarge:
                case AutomatedClassDesignType.SwarmHiveVeryLarge:
                case AutomatedClassDesignType.SwarmCruiser:
                case AutomatedClassDesignType.BeamDreadnought:
                case AutomatedClassDesignType.CarrierBattle:
                    this.method_8(false);
                    if (this.gclass40_0.method_157(AuroraComponentType.JumpDrive, false) == 0M)
                    {
                        if (this.genum99_0 > GEnum99.const_2)
                            this.genum99_0 = GEnum99.const_2;
                        this.genum102_0 = GEnum102.const_1;
                    }

                    if (this.gclass40_0.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.CarrierBattle)
                    {
                        this.method_10(AuroraComponentType.HangarDeck);
                        break;
                    }

                    break;
                case AutomatedClassDesignType.Scout:
                    this.method_11();
                    break;
                case AutomatedClassDesignType.CarrierMissile:
                case AutomatedClassDesignType.CarrierEnergy:
                    this.method_10(AuroraComponentType.HangarDeck);
                    if (this.gclass40_0.gclass22_0.int_29 > 0 &&
                        this.gclass40_0.method_157(AuroraComponentType.JumpDrive, false) == 0M)
                    {
                        this.method_5(GEnum99.const_2);
                        this.genum102_0 = GEnum102.const_1;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.AsteroidMiner:
                case AutomatedClassDesignType.SwarmWorker:
                    if (this.gclass40_0.method_157(AuroraComponentType.OrbitalMiningModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.TroopTransport:
                case AutomatedClassDesignType.SwarmBoardingFAC:
                case AutomatedClassDesignType.SwarmAssualtTransport:
                    if (this.gclass40_0.method_157(AuroraComponentType.TroopTransport, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.MilitaryJumpShip:
                case AutomatedClassDesignType.CommercialJumpTender:
                case AutomatedClassDesignType.SwarmJumpFAC:
                    if (this.gclass40_0.method_157(AuroraComponentType.JumpDrive, false) == 0M)
                    {
                        this.method_5(GEnum99.const_2);
                        this.genum102_0 = GEnum102.const_1;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.SwarmSalvager:
                case AutomatedClassDesignType.Salvager:
                    if (this.gclass40_0.method_157(AuroraComponentType.SalvageModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.ConstructionShip:
                    if (this.gclass40_0.method_157(AuroraComponentType.JumpPointStabilisation, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
            }

            return this.genum99_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 111);
            return GEnum99.const_0;
        }
    }

    public void method_13(Decimal decimal_0, bool bool_1)
    {
        try
        {
            this.method_14(bool_1);
            if (this.gclass129_0 == null)
            {
                this.gclass40_0.gclass5_0.double_0 = 0.0;
                this.gclass40_0.gclass5_0.double_1 = 0.0;
            }
            else
            {
                this.gclass40_0.gclass5_0.double_0 = this.gclass40_0.method_215(decimal_0);
                if (this.gclass40_0.gclass5_0.double_0 == 0.0)
                    this.gclass40_0.gclass5_0.double_1 = 0.0;
                else if (this.gclass40_0.gclass5_0.double_0 < this.gclass40_0.gclass5_0.gclass129_0.double_4)
                    this.gclass40_0.gclass5_0.double_1 = this.gclass40_0.gclass5_0.double_0;
                else
                    this.gclass40_0.gclass5_0.double_1 = this.gclass40_0.gclass5_0.gclass129_0.double_4;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 112 /*0x70*/);
        }
    }

    public void method_14(bool bool_1)
    {
        try
        {
            this.gclass129_0 = null;
            Decimal num = 0M;
            List<GClass228> list = this.gclass40_0.gclass22_0.dictionary_0.Values
                .Where<GClass228>(gclass228_0 => gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                                                 AuroraComponentType.MissileLauncher)
                .OrderByDescending<GClass228, Decimal>(gclass228_0 => gclass228_0.gclass230_0.decimal_3)
                .ToList<GClass228>();
            if (bool_1)
                list = list.Where<GClass228>(gclass228_0 => gclass228_0.gclass230_0.decimal_1 >= 2M)
                    .ToList<GClass228>();
            foreach (GClass228 gclass228_0 in list)
            {
                if (this.gclass40_0.method_158(gclass228_0) > 0)
                {
                    num = gclass228_0.gclass230_0.decimal_3;
                    break;
                }
            }

            foreach (GClass130 gclass130 in this.gclass40_0.list_10)
            {
                if (!(gclass130.gclass129_0.decimal_4 > num))
                {
                    if (this.gclass129_0 == null)
                        this.gclass129_0 = gclass130.gclass129_0;
                    else if (gclass130.gclass129_0.double_4 > this.gclass129_0.double_4)
                        this.gclass129_0 = gclass130.gclass129_0;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 113);
        }
    }
}