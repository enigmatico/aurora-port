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
public class NPRShipBehaviour_5
{
    private GClass0 Game;
    private ShipData Ship;
    public RaceMissile Missile;
    public GEnum99 genum99_0 = GEnum99.const_4;
    public GEnum101 genum101_0 = GEnum101.const_3;
    public GEnum102 genum102_0 = GEnum102.const_3;
    public GEnum103 genum103_0 = GEnum103.const_4;
    public double MaximumMFCRange;
    public double MissileAttackRange;
    public GClass71 gclass71_0;
    public GClass72 gclass72_0;
    public double double_2;
    public double double_3;
    public double double_4;
    public double double_5;
    public bool bool_0;

    /// <summary>
    /// quite sure this one is about controlling NPR-owned ships
    /// </summary>
    /// <param name="game"></param>
    /// <param name="ship"></param>
    public NPRShipBehaviour_5(GClass0 game, ShipData ship)
    {
        this.Game = game;
        this.Ship = ship;
    }

    public bool method_0()
    {
        try
        {
            if (this.Ship.Class.AutomatedClassDesign.SurrenderStatus == SurrenderStatus.const_0)
                return false;
            if (this.Ship.Class.AutomatedClassDesign.SurrenderStatus == SurrenderStatus.const_1)
                return true;
            if (this.Ship.Class.AutomatedClassDesign.SurrenderStatus == SurrenderStatus.const_2)
            {
                if (this.Ship.NPRShipBehaviour.genum99_0 == GEnum99.const_0)
                    return true;
            }
            else if (this.Ship.Class.AutomatedClassDesign.SurrenderStatus == SurrenderStatus.const_3 &&
                     (this.Ship.NPRShipBehaviour.genum99_0 == GEnum99.const_0 ||
                      this.Ship.NPRShipBehaviour.genum103_0 == GEnum103.const_0))
                return true;

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 100);
            return false;
        }
    }

    public bool method_1(ShipData gclass40_1, double double_6)
    {
        try
        {
            this.UpdateMissileAttackRange(gclass40_1.method_51(), false);
            double num = this.MissileAttackRange / (double)this.Missile.Speed;
            this.double_5 = this.MissileAttackRange - gclass40_1.Class.MaxSpeed * num;
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
            this.UpdateMissileAttackRange(1000M, false);
            return double_6 < this.MissileAttackRange;
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
            int num = (int)this.Ship.method_171(false);
            if (num == this.Ship.Class.MaxSpeed)
                return;
            if (num > this.Ship.Class.MaxSpeed * 0.75)
            {
                this.method_5(GEnum99.const_3);
                this.method_6(GEnum102.const_1);
            }
            else if (num >= this.Ship.Class.MaxSpeed * 0.5)
            {
                this.method_5(GEnum99.const_2);
                this.method_6(GEnum102.const_1);
            }
            else if (num > this.Ship.Class.MaxSpeed * 0.25)
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
            if (this.Ship.Class.FuelCapacity == 0)
                return;
            this.genum101_0 = GEnum101.const_3;
            if (this.Ship.Class.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.Harvester)
                return;
            if (this.Ship.Class.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.Tanker)
            {
                if (this.Ship.decimal_14 < (int)(this.Ship.Class.FuelCapacity * 0.1))
                {
                    this.genum101_0 = GEnum101.const_2;
                }
                else
                {
                    if (!(this.Ship.decimal_14 < (int)(this.Ship.Class.FuelCapacity * 0.05)))
                        return;
                    this.genum101_0 = GEnum101.const_1;
                }
            }
            else if (this.Ship.decimal_14 == 0M)
            {
                this.genum99_0 = GEnum99.const_0;
                this.genum101_0 = GEnum101.const_0;
            }
            else if (this.Ship.decimal_14 < (int)(this.Ship.Class.FuelCapacity * 0.2))
            {
                this.method_5(GEnum99.const_1);
                this.genum101_0 = GEnum101.const_1;
            }
            else if (this.Ship.decimal_14 < (int)(this.Ship.Class.FuelCapacity * 0.3))
            {
                this.method_5(GEnum99.const_2);
                this.genum101_0 = GEnum101.const_2;
            }
            else
            {
                if (!(this.Ship.decimal_14 < (int)(this.Ship.Class.FuelCapacity * 0.4)))
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
            if (this.Ship.Class.NoArmour == 1)
                return;
            double num = this.Ship.ArmorDamages.Values.Sum() /
                         (double)(this.Ship.Class.ArmourWidth * this.Ship.Class.ArmourThickness);
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
            foreach (ClassComponent gclass228_0 in this.Ship.Class.ClassComponents.Values)
            {
                if (gclass228_0.Component.bool_4 && !bool_1)
                {
                    num1 += (int)gclass228_0.NumComponent;
                    num2 += this.Ship.method_158(gclass228_0);
                }
                else if (gclass228_0.Component.Data.ComponentTypeID ==
                         AuroraComponentType.MissileLauncher && bool_1)
                {
                    num1 += (int)gclass228_0.NumComponent;
                    num2 += this.Ship.method_158(gclass228_0);
                }
                else if (gclass228_0.Component.Data.ComponentTypeID == auroraComponentType)
                {
                    num3 += (int)gclass228_0.NumComponent;
                    num4 += this.Ship.method_158(gclass228_0);
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
            if (this.Ship.Class.AutomatedClassDesign.MissileDesignType == MissileDesignType.const_0)
                return;
            Decimal num3 = this.Ship.Class.OrdnanceTemplate
                .Where<ShipOrdnance>(gclass130_0 => gclass130_0.RaceMissile.ShipDecoy == 0)
                .Select<ShipOrdnance, Decimal>(gclass130_0 => gclass130_0.RaceMissile.Size)
                .DefaultIfEmpty<Decimal>(0M).Min<Decimal>(decimal_0 => decimal_0);
            Decimal num4 = this.Ship.method_208();
            if (num4 < num3)
                return;
            foreach (ShipOrdnance gclass130 in this.Ship.Ordnances)
                num1 += gclass130.RaceMissile.Size * gclass130.Amount;
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
            ClassComponent gclass228_0 = this.Ship.Class.ClassComponents.Values.FirstOrDefault(value =>
                value.Component.Data.ComponentTypeID == auroraComponentType_0);
            int num = this.Ship.method_158(gclass228_0);
            if (num == gclass228_0.NumComponent)
                return;
            if (num < (double)gclass228_0.NumComponent * 0.25)
            {
                this.genum99_0 = GEnum99.const_0;
                this.genum102_0 = GEnum102.const_0;
            }
            else if (num < (double)gclass228_0.NumComponent * 0.5)
            {
                this.method_5(GEnum99.const_1);
                this.genum102_0 = GEnum102.const_0;
            }
            else if (num < (double)gclass228_0.NumComponent * 0.75)
            {
                this.method_5(GEnum99.const_2);
                this.method_6(GEnum102.const_1);
            }
            else
            {
                if (num >= (double)gclass228_0.NumComponent)
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
            foreach (ClassComponent gclass228_0 in this.Ship.Class.ClassComponents.Values.Where<ClassComponent>(
                             gclass228_0 =>
                                 gclass228_0.Component.Data.ComponentTypeID ==
                                 AuroraComponentType.ActiveSearchSensors ||
                                 gclass228_0.Component.Data.ComponentTypeID ==
                                 AuroraComponentType.ThermalSensors ||
                                 gclass228_0.Component.Data.ComponentTypeID ==
                                 AuroraComponentType.EMSensors)
                         .ToList<ClassComponent>())
            {
                num2 += (int)gclass228_0.NumComponent;
                num1 += this.Ship.method_158(gclass228_0);
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
            if (this.Ship.ArmorDamages.Count > 0)
                this.method_7();
            if (this.Ship.ComponentDamages.Count > 0)
                this.method_3();
            if (this.Ship.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                this.genum101_0 = GEnum101.const_3;
            else
                this.method_4();
            switch (this.Ship.Class.AutomatedClassDesign.AutomatedClassDesignTypeID)
            {
                case AutomatedClassDesignType.SmallFreighter:
                case AutomatedClassDesignType.LargeFreighter:
                case AutomatedClassDesignType.HugeFreighter:
                    if (this.Ship.method_157(AuroraComponentType.CargoHold, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                    }

                    if (this.Ship.method_157(AuroraComponentType.CargoShuttleBay, false) == 0M)
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
                    if (this.Ship.method_157(AuroraComponentType.ColonistTransport, false) == 0M &&
                        this.Ship.method_157(AuroraComponentType.PassengerModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                    }

                    if (this.Ship.method_157(AuroraComponentType.CargoShuttleBay, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.TerraFormer:
                    if (this.Ship.method_157(AuroraComponentType.TerraformingModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.Harvester:
                    if (this.Ship.method_157(AuroraComponentType.SoriumHarvester, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.Geosurvey:
                case AutomatedClassDesignType.SwarmGeosurvey:
                    if (this.Ship.method_157(AuroraComponentType.GeologicalSurveySensors, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.Gravsurvey:
                case AutomatedClassDesignType.SwarmGravsurvey:
                    if (this.Ship.method_157(AuroraComponentType.GravitationalSurveySensors, false) == 0M)
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
                    if (this.Ship.method_157(AuroraComponentType.JumpDrive, false) == 0M)
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
                    if (this.Ship.method_157(AuroraComponentType.JumpDrive, false) == 0M)
                    {
                        if (this.genum99_0 > GEnum99.const_2)
                            this.genum99_0 = GEnum99.const_2;
                        this.genum102_0 = GEnum102.const_1;
                    }

                    if (this.Ship.Class.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.CarrierBattle)
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
                    if (this.Ship.Class.JumpRating > 0 &&
                        this.Ship.method_157(AuroraComponentType.JumpDrive, false) == 0M)
                    {
                        this.method_5(GEnum99.const_2);
                        this.genum102_0 = GEnum102.const_1;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.AsteroidMiner:
                case AutomatedClassDesignType.SwarmWorker:
                    if (this.Ship.method_157(AuroraComponentType.OrbitalMiningModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.TroopTransport:
                case AutomatedClassDesignType.SwarmBoardingFAC:
                case AutomatedClassDesignType.SwarmAssualtTransport:
                    if (this.Ship.method_157(AuroraComponentType.TroopTransport, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.MilitaryJumpShip:
                case AutomatedClassDesignType.CommercialJumpTender:
                case AutomatedClassDesignType.SwarmJumpFAC:
                    if (this.Ship.method_157(AuroraComponentType.JumpDrive, false) == 0M)
                    {
                        this.method_5(GEnum99.const_2);
                        this.genum102_0 = GEnum102.const_1;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.SwarmSalvager:
                case AutomatedClassDesignType.Salvager:
                    if (this.Ship.method_157(AuroraComponentType.SalvageModule, false) == 0M)
                    {
                        this.genum99_0 = GEnum99.const_0;
                        this.genum102_0 = GEnum102.const_0;
                        break;
                    }

                    break;
                case AutomatedClassDesignType.ConstructionShip:
                    if (this.Ship.method_157(AuroraComponentType.JumpPointStabilisation, false) == 0M)
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

    public void UpdateMissileAttackRange(Decimal decimal_0, bool bool_1)
    {
        try
        {
            this.method_14(bool_1);
            if (this.Missile == null)
            {
                this.Ship.NPRShipBehaviour.MaximumMFCRange = 0.0;
                this.Ship.NPRShipBehaviour.MissileAttackRange = 0.0;
            }
            else
            {
                this.Ship.NPRShipBehaviour.MaximumMFCRange = this.Ship.GetMaxMFCRange(decimal_0);
                if (this.Ship.NPRShipBehaviour.MaximumMFCRange == 0.0)
                    this.Ship.NPRShipBehaviour.MissileAttackRange = 0.0;
                else if (this.Ship.NPRShipBehaviour.MaximumMFCRange < this.Ship.NPRShipBehaviour.Missile.CombinatedMaxRange)
                    this.Ship.NPRShipBehaviour.MissileAttackRange = this.Ship.NPRShipBehaviour.MaximumMFCRange;
                else
                    this.Ship.NPRShipBehaviour.MissileAttackRange = this.Ship.NPRShipBehaviour.Missile.CombinatedMaxRange;
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
            this.Missile = null;
            Decimal num = 0M;
            List<ClassComponent> list = this.Ship.Class.ClassComponents.Values
                .Where<ClassComponent>(gclass228_0 => gclass228_0.Component.Data.ComponentTypeID ==
                                                 AuroraComponentType.MissileLauncher)
                .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.Component.decimal_3)
                .ToList<ClassComponent>();
            if (bool_1)
                list = list.Where<ClassComponent>(gclass228_0 => gclass228_0.Component.decimal_1 >= 2M)
                    .ToList<ClassComponent>();
            foreach (ClassComponent gclass228_0 in list)
            {
                if (this.Ship.method_158(gclass228_0) > 0)
                {
                    num = gclass228_0.Component.decimal_3;
                    break;
                }
            }

            foreach (ShipOrdnance gclass130 in this.Ship.Ordnances)
            {
                if (!(gclass130.RaceMissile.Size > num))
                {
                    if (this.Missile == null)
                        this.Missile = gclass130.RaceMissile;
                    else if (gclass130.RaceMissile.CombinatedMaxRange > this.Missile.CombinatedMaxRange)
                        this.Missile = gclass130.RaceMissile;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 113);
        }
    }
}