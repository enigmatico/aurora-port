// Decompiled with JetBrains decompiler
// Type: GClass22
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public partial class ShipClass
{
    public Dictionary<int, ClassComponent> ClassComponents = new Dictionary<int, ClassComponent>();
    public List<ShipOrdnance> OrdnanceTemplate = new List<ShipOrdnance>();
    public List<ClassFighterTemplate> FighterClassTemplates = new List<ClassFighterTemplate>();
    public List<ClassGroundTemplate> GroundUnitTemplates = new List<ClassGroundTemplate>();
    public AllMineralsValue ClassMaterials;
    public GameRace Race;
    public ShipHull ShipHull;
    public RacialRank RacialRankTheme;
    public AutomatedClassDesign AutomatedClassDesign;
    public ShippingLineData gclass187_0;
    public NamingTheme NameTheme;
    private GClass0 gclass0_0;
    public AuroraClassMainFunction MainFunction;
    public TechTypeData gclass163_0;
    public GEnum16 genum16_0;
    public int ShipClassID;
    public int ActiveSensorStrength;
    public int ArmourThickness = 1;
    public int ArmourWidth;
    public int int_4;
    public int Collier;
    public int SeniorCO;
    public int ColonistCapacity;
    public int CommanderPriority = 5;
    public int ControlRating;
    public int ConscriptOnly;
    public int Crew;
    public int ELINTRating;
    public int DiplomacyRating;
    public int CommercialJumpDrive;
    public int NoOfficers;
    public int PDProtectionPriority = 5;
    public int DCRating;
    public int RankRequired;
    public int RepairYardCapacity;
    public int int_20;
    public int EMSensorStrength;
    public int ESMaxDACRoll;
    public int FuelTanker;
    public int GravSurvey;
    public int Harvesters;
    public int int_26;
    public int JGConstructionTime;
    public int JumpDistance;
    public int JumpRating;
    public int MaxChance;
    public int MaxDACRoll;
    public int MaxSpeed;
    public int MaintModules;
    public int MaintPriority = 5;
    public int RandomShipNameFromTheme;
    public int MiningModules;
    public int NoArmour;
    public int Obsolete;
    public int OtherRaceClassID;
    public int PassiveSensorStrength;
    public int SalvageRate;
    public int ShieldStrength;
    public int RefuellingRate = 10000;
    public int RefuelPriority = 5;
    public int ResupplyPriority = 5;
    public int MinimumFuel;
    public int MinimumSupplies;
    public int OrdnanceTransferRate;
    public int int_49;
    public int MaintSupplies;
    public int STSTractor;
    public int SupplyShip;
    public int Terraformers;
    public int OrdnanceTransferHub;
    public int TotalNumber;
    public int CargoShuttleStrength;
    public int TroopCapacity;
    public int WorkerCapacity;
    public int int_59;
    public int int_60;
    public int int_61;
    public int CargoCapacity;
    public int FuelCapacity;
    public int BioEnergyCapacity;
    public int ClassHullNumbers = 1;
    public Decimal EnginePower;
    public Decimal BaseFailureChance;
    public Decimal ClassCrossSection;
    public Decimal ClassThermal;
    public Decimal Cost;
    public Decimal CrewQuartersHS;
    public Decimal FuelEfficiency;
    public Decimal decimal_7;
    public Decimal ParasiteCapacity;
    public Decimal PlannedDeployment = 3M;
    public Decimal ProtectionValue;
    public Decimal MagazineCapacity;
    public Decimal DecoyCapacity;
    public Decimal SensorReduction = 1M;
    public Decimal Size;
    public Decimal ReactorPower;
    public Decimal RequiredPower;
    public Decimal GeoSurvey;
    public Decimal ActiveJammerStrength;
    public Decimal FireControlJammerStrength;
    public Decimal MissileJammerStrength;
    public Decimal CrewDesignEfficiency = 1M;
    public bool CommercialHangar;
    public bool FighterClass;
    public bool Commercial;
    public bool Locked;
    public bool PreTNT;
    public bool RecreationalModule;
    public bool bool_6;
    public bool MoraleCheckRequired;
    public bool MilitaryEngines;
    public bool ArkShip;
    public bool FlagBridge;
    public string string_0 = "";
    public string Notes = "";
    public string string_2 = "";
    public string PrefixName = "";
    public string SuffixName = "";
    public int int_66;
    public int int_67;
    public int int_68 = 1;
    public Decimal decimal_22;
    public Decimal decimal_23;
    public string string_5 = "";

    public void method_0(int int_69, GEnum118 genum118_0)
    {
        try
        {
            if (int_69 == 0 || !this.gclass0_0.ComponentDataDictionary.ContainsKey((int)genum118_0))
                return;
            this.method_51(this.gclass0_0.ComponentDataDictionary[(int)genum118_0], int_69);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 210);
        }
    }

    public ClassComponent method_1(int int_69, TechType genum122_0)
    {
        try
        {
            if (int_69 == 0)
                return null;
            TechSystem gclass164 = this.Race.method_387(genum122_0);
            return gclass164 == null || !this.gclass0_0.ComponentDataDictionary.ContainsKey(gclass164.TechSystemID)
                ? null
                : this.method_51(this.gclass0_0.ComponentDataDictionary[gclass164.TechSystemID], int_69);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 211);
            return null;
        }
    }

    public void method_2(int int_69, DesignDoctrine gclass20_0)
    {
        try
        {
            if (int_69 <= 0)
                return;
            ShipComponent gclass230_0 = null;
            if (int_69 == 1)
                gclass230_0 = gclass20_0.ThermalSensorSize1;
            else if (int_69 == 2)
                gclass230_0 = gclass20_0.ThermalSensorSize2;
            else if (int_69 == 3)
                gclass230_0 = gclass20_0.ThermalSensorSize3;
            else if (int_69 == 6)
                gclass230_0 = gclass20_0.ThermalSensorSize6;
            this.method_51(gclass230_0, 1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 212);
        }
    }

    public void method_3(int int_69, DesignDoctrine gclass20_0)
    {
        try
        {
            if (int_69 == 0)
                return;
            ShipComponent gclass230_0 = null;
            if (int_69 == 1)
                gclass230_0 = gclass20_0.EMSensorSize1;
            else if (int_69 == 2)
                gclass230_0 = gclass20_0.EMSensorSize2;
            else if (int_69 == 3)
                gclass230_0 = gclass20_0.EMSensorSize3;
            else if (int_69 == 6)
                gclass230_0 = gclass20_0.EMSensorSize6;
            this.method_51(gclass230_0, 1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 213);
        }
    }

    public void method_4(ActiveSensorDesignType genum74_0, DesignDoctrine gclass20_0)
    {
        try
        {
            if (genum74_0 == ActiveSensorDesignType.const_0)
                return;
            ShipComponent gclass230_0 = null;
            if (genum74_0 == ActiveSensorDesignType.const_1)
                gclass230_0 = gclass20_0.ActiveVeryLarge;
            else if (genum74_0 == ActiveSensorDesignType.const_2)
                gclass230_0 = gclass20_0.ActiveLarge;
            else if (genum74_0 == ActiveSensorDesignType.const_3)
                gclass230_0 = gclass20_0.ActiveStandard;
            else if (genum74_0 == ActiveSensorDesignType.const_4)
                gclass230_0 = gclass20_0.ActiveSmall;
            else if (genum74_0 == ActiveSensorDesignType.const_8)
                gclass230_0 = gclass20_0.ActiveNavigation;
            else if (genum74_0 == ActiveSensorDesignType.const_5)
                gclass230_0 = gclass20_0.ActiveAntiMissile;
            else if (genum74_0 == ActiveSensorDesignType.const_6)
                gclass230_0 = gclass20_0.ActiveAntiFighter;
            else if (genum74_0 == ActiveSensorDesignType.const_7)
                gclass230_0 = gclass20_0.ActiveAntiFAC;
            else if (genum74_0 == ActiveSensorDesignType.const_9)
                gclass230_0 = gclass20_0.ActiveAntiMissileSmall;
            else if (genum74_0 == ActiveSensorDesignType.const_10)
                gclass230_0 = gclass20_0.ActiveFighterMissile;
            else if (genum74_0 == ActiveSensorDesignType.const_11)
                gclass230_0 = gclass20_0.ActiveFighterBeam;
            this.method_51(gclass230_0, 1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 214);
        }
    }

    public void method_5(AutomatedClassDesign gclass14_1, DesignDoctrine gclass20_0)
    {
        try
        {
            if (gclass14_1.BeamFireControl == BFCDesignType.const_0)
                return;
            if (gclass14_1.BeamFireControl == BFCDesignType.const_3)
            {
                this.method_51(gclass20_0.BeamFCSRange, 1);
                this.method_51(gclass20_0.BeamFCSSpeed, gclass14_1.NumFireControls);
            }
            else if (gclass14_1.BeamFireControl == BFCDesignType.const_4)
            {
                int int_69 = gclass14_1.NumFireControls / 2;
                this.method_51(gclass20_0.BeamFCSRange, int_69);
                this.method_51(gclass20_0.BeamFCSSpeed, int_69);
            }
            else if (gclass14_1.BeamFireControl == BFCDesignType.const_5)
            {
                int int_69_1 = gclass14_1.NumFireControls / 3;
                int int_69_2 = gclass14_1.NumFireControls - int_69_1;
                this.method_51(gclass20_0.BeamFCSRange, int_69_1);
                this.method_51(gclass20_0.BeamFCSSpeed, int_69_2);
            }
            else
            {
                ShipComponent gclass230_0 = null;
                if (gclass14_1.BeamFireControl == BFCDesignType.const_1)
                    gclass230_0 = gclass20_0.BeamFCSRange;
                else if (gclass14_1.BeamFireControl == BFCDesignType.const_2 && gclass20_0.PointDefenceWeapon.int_3 == 0)
                    gclass230_0 = gclass20_0.BeamFCSShortRange;
                else if (gclass14_1.BeamFireControl == BFCDesignType.const_2)
                    gclass230_0 = gclass20_0.BeamFCSSpeed;
                else if (gclass14_1.BeamFireControl == BFCDesignType.const_6)
                    gclass230_0 = gclass20_0.BeamFCSFighter;
                this.method_51(gclass230_0, gclass14_1.NumFireControls);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 215);
        }
    }

    public ShipComponent method_6(AutomatedClassDesign gclass14_1, DesignDoctrine gclass20_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class787 class787 = new ShipClass.Class787();
        // ISSUE: reference to a compiler-generated field
        class787.gclass20_0 = gclass20_0;
        try
        {
            if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_0)
                return null;
            TechSystem gclass164_1 = this.Race.method_387(TechType.JumpDriveEfficiency);
            if (gclass164_1 == null)
                return null;
            ShipComponent gclass230_0 = null;
            if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_6)
                return this.method_7(true);
            if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_10)
                return this.method_7(false);
            if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_4)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveSurvey;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_1)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveDestroyer;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_2)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveCruiser;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_3)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveBattlecruiser;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_11)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveDreadnought;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_7)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveMediumHive;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_8)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveLargeHive;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_9)
            {
                // ISSUE: reference to a compiler-generated field
                gclass230_0 = class787.gclass20_0.JumpDriveVeryLargeHive;
            }
            else if (gclass14_1.JumpDriveDesignType == JumpDriveDesignType.const_5)
            {
                // ISSUE: reference to a compiler-generated method
                Decimal num = this.gclass0_0.ShipClasses.Values.Where<ShipClass>(class787.method_0)
                    .OrderByDescending<ShipClass, Decimal>(gclass22_0 => gclass22_0.Size)
                    .Select<ShipClass, Decimal>(gclass22_0 => gclass22_0.Size).FirstOrDefault<Decimal>();
                // ISSUE: reference to a compiler-generated field
                TechSystem gclass164_2 = class787.gclass20_0.Race.method_387(TechType.MaxJumpSquadronSize);
                // ISSUE: reference to a compiler-generated field
                TechSystem gclass164_3 = class787.gclass20_0.Race.method_387(TechType.MaxSquadronJumpRadius);
                TechSystem gclass164_4 = this.gclass0_0.TechSystems[33303];
                Decimal int36 = AuroraUtils.int_36;
                int decimal_13 = (int)Math.Ceiling(num / int36) + 1;
                if (gclass164_1 != null && gclass164_2 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass230_0 = this.gclass0_0.method_456(class787.gclass20_0.Race, decimal_13, gclass164_1,
                        gclass164_2, gclass164_3, gclass164_4, null, null, true);
                }
            }

            this.method_51(gclass230_0, 1);
            return gclass230_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 216);
            return null;
        }
    }

    public ShipComponent method_7(bool bool_11)
    {
        try
        {
            TechSystem gclass164_1 = this.Race.method_387(TechType.JumpDriveEfficiency);
            TechSystem gclass164_3 = this.gclass0_0.TechSystems[827];
            TechSystem gclass164_2 = this.gclass0_0.TechSystems[819];
            TechSystem gclass164_4 = this.gclass0_0.TechSystems[33302];
            this.method_85(0, 0, "");
            Decimal decimal_13 = (int)Math.Ceiling(this.Size);
            if (!bool_11)
            {
                gclass164_4 = this.gclass0_0.TechSystems[33303];
                decimal_13 = (int)Math.Ceiling(this.Size / AuroraUtils.int_36);
            }

            ShipComponent gclass230;
            while (true)
            {
                gclass230 = this.gclass0_0.method_456(this.Race, decimal_13, gclass164_1, gclass164_2,
                    gclass164_3, gclass164_4, null, null, false);
                this.ClassComponents.Add(gclass230.int_0, new ClassComponent()
                {
                    Component = gclass230,
                    NumComponent = 1M
                });
                this.method_85(0, 0, "");
                if (!(this.Size <= gclass230.decimal_3))
                {
                    this.ClassComponents.Remove(gclass230.int_0);
                    ++decimal_13;
                }
                else
                    break;
            }

            this.gclass0_0.method_474(this.Race);
            return gclass230;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 217);
            return null;
        }
    }

    public void method_8(AutomatedClassDesign gclass14_1, DesignDoctrine gclass20_0)
    {
        try
        {
            if (gclass14_1.MissileFireControl == ActiveSensorDesignType.const_0)
                return;
            ShipComponent gclass230_0 = null;
            if (gclass14_1.MissileFireControl == ActiveSensorDesignType.const_3)
                gclass230_0 = gclass20_0.FCSStandardMissile;
            else if (gclass14_1.MissileFireControl == ActiveSensorDesignType.const_4)
                gclass230_0 = gclass20_0.FCSFastAttackCraftMissile;
            else if (gclass14_1.MissileFireControl == ActiveSensorDesignType.const_5)
                gclass230_0 = gclass20_0.FCSAntiMissile;
            else if (gclass14_1.MissileFireControl == ActiveSensorDesignType.const_6)
                gclass230_0 = gclass20_0.FCSAntiFighter;
            else if (gclass14_1.MissileFireControl == ActiveSensorDesignType.const_7)
                gclass230_0 = gclass20_0.FCSAntiFAC;
            this.method_51(gclass230_0, gclass14_1.NumFireControls);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 218);
        }
    }

    public void method_9(AutomatedClassDesign gclass14_1, DesignDoctrine gclass20_0)
    {
        try
        {
            if (gclass14_1.bool_0)
            {
                this.ArmourThickness = gclass20_0.WarshipArmour + gclass14_1.ArmourAdjustment;
                if (this.ArmourThickness >= 1)
                    return;
                this.ArmourThickness = 1;
            }
            else
                this.ArmourThickness = 1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 219);
        }
    }

    public void method_10(AutomatedClassDesign gclass14_1, DesignDoctrine gclass20_0)
    {
        try
        {
            if (gclass14_1.EngineeringType == EngineeringDesignType.const_0)
                this.method_51(this.gclass0_0.ComponentDataDictionary[25147], gclass14_1.Engineering);
            else
                this.method_51(this.gclass0_0.ComponentDataDictionary[25147], gclass14_1.Engineering * gclass20_0.WarshipEngineering);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 220);
        }
    }

    public void method_11(AutomatedClassDesign gclass14_1, DesignDoctrine gclass20_0)
    {
        try
        {
            if (gclass20_0.CIWS == null)
                return;
            int int_69 = gclass14_1.CIWSFixed + AuroraUtils.GetRandomInteger(gclass14_1.CIWSRandom);
            if (int_69 <= 0)
                return;
            this.method_51(gclass20_0.CIWS, int_69);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 221);
        }
    }

    public void method_12(AutomatedClassDesign gclass14_1, DesignDoctrine gclass20_0, Decimal decimal_24)
    {
        try
        {
            ShipComponent gclass230_0 = null;
            int int_69 = 0;
            if (gclass14_1.EngineNumberType == NumberOfEngineDesignType.const_1)
                int_69 = gclass14_1.EngineNumber;
            else if (gclass14_1.EngineNumberType == NumberOfEngineDesignType.const_3)
                int_69 = gclass14_1.EngineNumber + AuroraUtils.GetRandomInteger(gclass14_1.RandomEngineElement);
            if (gclass14_1.EngineType == EngineDesignType.const_1)
            {
                gclass230_0 = gclass20_0.EngineMilitary;
                if (gclass14_1.EngineNumberType == NumberOfEngineDesignType.const_2)
                    int_69 = gclass20_0.NumWarshipEngines * gclass14_1.EngineNumber;
                else if (gclass14_1.EngineNumberType == NumberOfEngineDesignType.const_4)
                    int_69 = gclass20_0.NumWarshipEngines - gclass14_1.EngineNumber;
                if (int_69 < 1)
                    int_69 = 1;
            }
            else if (gclass14_1.EngineType == EngineDesignType.const_2)
            {
                gclass230_0 = gclass20_0.EngineCommercial;
                if (gclass14_1.EngineNumberType == NumberOfEngineDesignType.const_2)
                    int_69 = gclass20_0.NumCommercialEngines * gclass14_1.EngineNumber;
                else if (gclass14_1.EngineNumberType == NumberOfEngineDesignType.const_4)
                    int_69 = gclass20_0.NumCommercialEngines - gclass14_1.EngineNumber;
                if (int_69 < 1)
                    int_69 = 1;
            }
            else if (gclass14_1.EngineType == EngineDesignType.const_3)
                gclass230_0 = gclass20_0.EngineFAC;
            else if (gclass14_1.EngineType == EngineDesignType.const_4)
                gclass230_0 = gclass20_0.EngineSurvey;
            else if (gclass14_1.EngineType == EngineDesignType.const_5)
                gclass230_0 = gclass20_0.EngineFighter;

            this.method_51(gclass230_0, int_69);
            if (gclass20_0.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                return;
            this.method_13(gclass230_0, int_69, gclass14_1, decimal_24);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 222);
        }
    }

    public void method_13(
        ShipComponent gclass230_0,
        int int_69,
        AutomatedClassDesign gclass14_1,
        Decimal decimal_24)
    {
        try
        {
            Decimal num1 = gclass230_0.decimal_8 * gclass230_0.decimal_3 * int_69 * gclass14_1.FuelDuration * 720M /
                           50000M;
            if (gclass14_1.MaxFuelHullPercentage > 0M && decimal_24 > 0M && num1 > decimal_24 * gclass14_1.MaxFuelHullPercentage)
                num1 = decimal_24 * gclass14_1.MaxFuelHullPercentage;
            Decimal num2 = this.method_73(AuroraComponentType.SoriumHarvester);
            Decimal decimal_24_1 = num1 + num2 / 2M;
            if (gclass14_1.HullClassDesignType == HullClassDesignType.const_3 && decimal_24_1 > 0.4M)
                decimal_24_1 = 0.4M;
            this.method_14(decimal_24_1, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 213);
        }
    }

    public void method_14(Decimal decimal_24, bool bool_11)
    {
        try
        {
            if (bool_11)
            {
                foreach (ClassComponent gclass228 in this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                             gclass228_0.Component.Data.ComponentTypeID ==
                             AuroraComponentType.FuelStorage).ToList<ClassComponent>())
                    this.ClassComponents.Remove(gclass228.ComponentID);
            }

            if (decimal_24 <= 0.1M && this.Race.method_394(GEnum118.const_51))
                this.method_51(this.gclass0_0.ComponentDataDictionary[38117], 1);
            else if (decimal_24 <= 0.8M)
                this.method_51(this.gclass0_0.ComponentDataDictionary[26266], (int)Math.Ceiling(decimal_24 / 0.2M));
            else if (!(decimal_24 <= 4M) && this.Race.method_394(GEnum118.const_53))
            {
                int int_69 = (int)Math.Floor(decimal_24 / 5M);
                this.method_51(this.gclass0_0.ComponentDataDictionary[43529], int_69);
                this.method_51(this.gclass0_0.ComponentDataDictionary[600], (int)Math.Ceiling(decimal_24) - int_69 * 5);
            }
            else
                this.method_51(this.gclass0_0.ComponentDataDictionary[600], (int)Math.Ceiling(decimal_24));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 214);
        }
    }

    public bool method_15(Decimal decimal_24)
    {
        try
        {
            Decimal num1 = this.FuelCapacity / 50000M;
            Decimal num2 = Math.Abs(decimal_24 - this.Size);
            if (!(num1 > num2 * 3M))
                return false;
            this.method_14(num1 - num2, true);
            this.method_85(0, 0, "");
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 215);
            return false;
        }
    }

    public bool method_16(Decimal decimal_24)
    {
        try
        {
            while (this.ArmourThickness > 1)
            {
                --this.ArmourThickness;
                this.method_85(0, 0, "");
                if (this.Size <= decimal_24)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 216);
            return false;
        }
    }

    public void method_17(Decimal decimal_24)
    {
        try
        {
            Decimal decimal_24_1 = this.FuelCapacity / 50000M + (decimal_24 - this.Size);
            this.method_14(decimal_24_1, true);
            this.method_85(0, 0, "");
            while (this.Size > decimal_24 && decimal_24_1 >= 0.2M)
            {
                decimal_24_1 -= 0.1M;
                this.method_14(decimal_24_1, true);
                this.method_85(0, 0, "");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 217);
        }
    }

    public void method_18(Decimal decimal_24)
    {
        try
        {
            do
            {
                ++this.ArmourThickness;
                this.method_85(0, 0, "");
            } while (!(this.Size > decimal_24));

            --this.ArmourThickness;
            this.method_85(0, 0, "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 218);
        }
    }

    public void method_19(ShipComponent gclass230_0, Decimal decimal_24)
    {
        try
        {
            this.method_51(gclass230_0, 1);
            this.method_85(0, 0, "");
            if (!(this.Size > decimal_24))
                return;
            this.method_52(gclass230_0, 1);
            this.method_85(0, 0, "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3866);
        }
    }

    public void method_20(Decimal decimal_24, int int_69, AutomatedClassDesign gclass14_1)
    {
        try
        {
            ClassComponent gclass228 = this.ClassComponents.Values.FirstOrDefault<ClassComponent>(gclass228_0 =>
                gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.Engine);
            if (gclass228 == null)
                return;
            do
            {
                ++gclass228.NumComponent;
                this.method_13(gclass228.Component, (int)gclass228.NumComponent, gclass14_1, decimal_24);
                this.method_85(0, 0, "");
                if (this.Size > decimal_24)
                    goto label_3;
            } while (this.MaxSpeed < int_69 || int_69 <= 0);

            return;
            label_3:
            --gclass228.NumComponent;
            this.method_13(gclass228.Component, (int)gclass228.NumComponent, gclass14_1, decimal_24);
            this.method_85(0, 0, "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 219);
        }
    }

    public void method_21(Decimal decimal_24, DesignDoctrine gclass20_0)
    {
        try
        {
            if (gclass20_0.CIWS == null)
                return;
            ClassComponent gclass228 = this.ClassComponents.Values.FirstOrDefault<ClassComponent>(gclass228_0 =>
                gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.CIWS);
            if (gclass228 == null)
                gclass228 = this.method_51(gclass20_0.CIWS, 1);
            else
                ++gclass228.NumComponent;
            this.method_85(0, 0, "");
            if (!(this.Size > decimal_24))
                return;
            this.method_52(gclass228.Component, 1);
            this.method_85(0, 0, "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 220);
        }
    }

    public void method_22(Decimal decimal_24, GEnum118 genum118_0)
    {
        try
        {
            Decimal num = decimal_24 - this.Size;
            ShipComponent gclass230_0 = this.gclass0_0.ComponentDataDictionary[(int)genum118_0];
            if (!(gclass230_0.decimal_1 < num) || this.ClassComponents.ContainsKey(gclass230_0.int_0))
                return;
            this.method_51(gclass230_0, 1);
            this.method_85(0, 0, "");
            if (!(this.Size > decimal_24))
                return;
            this.method_52(gclass230_0, 1);
            this.method_85(0, 0, "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 221);
        }
    }

    public string ClassName { get; set; } = "New Class";

    public string ClassNameWithHull { get; set; } = "New Class";

    public ShipClass(GClass0 gclass0_1)
    {
        this.gclass0_0 = gclass0_1;
        this.ClassMaterials = new AllMineralsValue(gclass0_1);
    }

    public string method_23()
    {
        try
        {
            string str = "";
            foreach (ShipData gclass40 in this.method_36())
                str = string.Format("{0}{1}, ", str, gclass40.ShipName);
            return str.Remove(str.Length - 2) + Environment.NewLine;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3958);
            return "error";
        }
    }

    public void method_24()
    {
        try
        {
            ShipClassTemplate184 gclass184 = new ShipClassTemplate184();
            gclass184.ShipClassTemplateID = this.gclass0_0.method_26(GEnum0.const_54);
            gclass184.HullID = this.ShipHull.ShipHullDescriptionID;
            gclass184.ShipClassTemplateName = this.ClassName;
            gclass184.ArmourThickness = this.ArmourThickness;
            gclass184.PlannedDeployment = this.PlannedDeployment;
            gclass184.Collier = this.Collier;
            gclass184.ConscriptOnly = this.ConscriptOnly;
            gclass184.FuelTanker = this.FuelTanker;
            gclass184.SupplyShip = this.SupplyShip;
            gclass184.NoArmour = this.NoArmour;
            gclass184.NoOfficers = this.NoOfficers;
            gclass184.SeniorCO = this.SeniorCO;
            gclass184.MinimumFuel = this.MinimumFuel;
            gclass184.MinimumSupplies = this.MinimumSupplies;
            gclass184.RefuelPriority = this.RefuelPriority;
            gclass184.ResupplyPriority = this.ResupplyPriority;
            gclass184.PDProtectionPriority = this.PDProtectionPriority;
            gclass184.CommanderPriority = this.CommanderPriority;
            gclass184.MaintPriority = this.MaintPriority;
            foreach (ClassComponent gclass228 in this.ClassComponents.Values)
            {
                ClassComponentTemplate186 gclass186 = new ClassComponentTemplate186(this.gclass0_0);
                gclass186.ShipClassTemplateID = gclass184.ShipClassTemplateID;
                if (gclass228.Component.gclass164_0.gclass21_0 == null)
                    gclass186.StandardComponentID = gclass228.Component.gclass164_0.TechSystemID;
                else
                    gclass186.ShipComponentTemplateID = gclass228.Component.gclass185_0 == null
                        ? this.Race.method_71(gclass228.Component)
                        : gclass228.Component.gclass185_0.int_0;
                gclass186.NumComponent = (int)gclass228.NumComponent;
                gclass184.ComponentTemplateList.Add(gclass186);
            }

            this.gclass0_0.ShipClassTemplateDictionary.Add(gclass184.ShipClassTemplateID, gclass184);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3711);
        }
    }

    public List<ShipClass> method_25()
    {
        try
        {
            List<ShipClass> gclass22List = new List<ShipClass>();
            foreach (ShipClass gclass22 in !this.Commercial
                         ? this.gclass0_0.ShipClasses.Values.Where<ShipClass>(gclass22_0 =>
                                 gclass22_0.gclass187_0 == null && gclass22_0.Obsolete == 0 && gclass22_0.OtherRaceClassID == 0 &&
                                 gclass22_0 != this && gclass22_0.Race == this.Race)
                             .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>()
                         : this.gclass0_0.ShipClasses.Values.Where<ShipClass>(gclass22_0 =>
                                 gclass22_0.gclass187_0 == null && gclass22_0.Obsolete == 0 && gclass22_0.OtherRaceClassID == 0 &&
                                 gclass22_0 != this && gclass22_0.Commercial && gclass22_0.Race == this.Race)
                             .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>())
            {
                if (!(this.Size < gclass22.Size * 0.8M) &&
                    !(this.Size > gclass22.Size * 1.2M) &&
                    gclass22.method_40(this, null, null) <= this.Cost / 5M)
                    gclass22List.Add(gclass22);
            }

            return gclass22List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3758);
            return null;
        }
    }

    public void method_26(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            List<ShipClass> list = this.gclass0_0.ShipClasses.Values.Where<ShipClass>(gclass22_0 =>
                    gclass22_0.gclass187_0 == null && gclass22_0 != this && gclass22_0.Race == this.Race &&
                    gclass22_0.Size >= this.Size * 0.8M && gclass22_0.Size <= this.Size * 1.2M)
                .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>();
            if (list.Count == 0)
                return;
            this.gclass0_0.method_611(listView_0, "Refit From Listed Class to Current Class", "Cost", "% Original",
                "% Refit", "SY", null);
            this.gclass0_0.method_601(listView_0, "", "", "");
            foreach (ShipClass gclass22 in list)
            {
                string string_14 = "-";
                Decimal decimal_73 = gclass22.method_40(this, null, null);
                if (decimal_73 <= gclass22.Cost / 5M && this.Commercial == gclass22.Commercial)
                    string_14 = "Yes";
                this.gclass0_0.method_611(listView_0, gclass22.ClassName, AuroraUtils.smethod_39(decimal_73),
                    AuroraUtils.smethod_39(decimal_73 / gclass22.Cost * 100M),
                    AuroraUtils.smethod_39(decimal_73 / this.Cost * 100M), string_14, null);
            }

            this.gclass0_0.method_601(listView_0, "", "", "");
            this.gclass0_0.method_611(listView_0, "Refit from Current Class to Listed Class", "Cost", "% Original",
                "% Refit", "SY", null);
            this.gclass0_0.method_601(listView_0, "", "", "");
            foreach (ShipClass gclass22_0 in this.gclass0_0.ShipClasses.Values.Where<ShipClass>(gclass22_0 =>
                             gclass22_0.gclass187_0 == null && gclass22_0 != this &&
                             gclass22_0.Race == this.Race &&
                             this.Size >= gclass22_0.Size * 0.8M &&
                             this.Size <= gclass22_0.Size * 1.2M)
                         .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>())
            {
                string string_14 = "-";
                Decimal decimal_73 = this.method_40(gclass22_0, null, null);
                if (decimal_73 <= this.Cost / 5M && this.Commercial == gclass22_0.Commercial)
                    string_14 = "Yes";
                this.gclass0_0.method_611(listView_0, gclass22_0.ClassName, AuroraUtils.smethod_39(decimal_73),
                    AuroraUtils.smethod_39(decimal_73 / this.Cost * 100M),
                    AuroraUtils.smethod_39(decimal_73 / gclass22_0.Cost * 100M), string_14, null);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3639);
        }
    }

    public int method_27()
    {
        try
        {
            int num = (int)Math.Floor(this.DCRating * (200M / this.Size));
            if (num > 50)
                num = 50;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3589);
            return 0;
        }
    }

    public bool method_28()
    {
        try
        {
            return this.ClassComponents.Values.Count<ClassComponent>(gclass228_0 => gclass228_0.Component.genum86_0 != 0) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2851);
            return false;
        }
    }

    public bool method_29(PopulationData gclass146_0)
    {
        try
        {
            List<ClassComponent> list = this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                    !gclass228_0.Component.gclass164_0.dictionary_0.ContainsKey(this.Race.RaceID))
                .ToList<ClassComponent>();
            if (list.Count == 0)
                return true;
            foreach (ClassComponent gclass228 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                ShipClass.Class767 class767 = new ShipClass.Class767();
                // ISSUE: reference to a compiler-generated field
                class767.gclass228_0 = gclass228;
                // ISSUE: reference to a compiler-generated method
                Decimal num = gclass146_0.StoredComponents.Where<StoredComponent>(class767.method_0)
                    .Sum<StoredComponent>(gclass73_0 => gclass73_0.Amount);
                // ISSUE: reference to a compiler-generated field
                if (class767.gclass228_0.NumComponent > num)
                    return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2852);
            return false;
        }
    }

    public bool method_30(ShipClass gclass22_0, PopulationData gclass146_0)
    {
        try
        {
            if (gclass22_0 == null)
                return true;
            List<ClassComponent> gclass228List = new List<ClassComponent>();
            foreach (ClassComponent gclass228_1 in gclass22_0.ClassComponents.Values)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                ShipClass.Class768 class768 = new ShipClass.Class768();
                // ISSUE: reference to a compiler-generated field
                class768.gclass228_0 = gclass228_1;
                // ISSUE: reference to a compiler-generated method
                ClassComponent gclass228_2 = this.ClassComponents.Values.FirstOrDefault<ClassComponent>(class768.method_0);
                Decimal num1 = 0M;
                if (gclass228_2 == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    num1 = class768.gclass228_0.NumComponent;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (gclass228_2.NumComponent < class768.gclass228_0.NumComponent)
                    {
                        // ISSUE: reference to a compiler-generated field
                        num1 = class768.gclass228_0.NumComponent - gclass228_2.NumComponent;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                if (num1 > 0M &&
                    !class768.gclass228_0.Component.gclass164_0.dictionary_0.ContainsKey(this.Race.RaceID))
                {
                    // ISSUE: reference to a compiler-generated method
                    Decimal num2 = gclass146_0.StoredComponents.Where<StoredComponent>(class768.method_1)
                        .Sum<StoredComponent>(gclass73_0 => gclass73_0.Amount);
                    if (num1 > num2)
                        return false;
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2853);
            return false;
        }
    }

    public void method_31()
    {
        try
        {
            if (this.method_73(AuroraComponentType.GravitationalSurveySensors) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Gravsurvey];
            else if (this.method_73(AuroraComponentType.GeologicalSurveySensors) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Geosurvey];
            else if (this.method_73(AuroraComponentType.MissileFireControl) > 0M)
            {
                if (this.method_74(AuroraComponentType.MissileFireControl)
                        .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component)
                        .OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.Resolution)
                        .FirstOrDefault<ShipComponent>().Resolution == 1M)
                {
                    if (this.MaxSpeed < 10)
                        this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MissileDefenceBase];
                    else if (this.Size < 200M)
                        this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MissileDE];
                    else
                        this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MissileCLE];
                }
                else if (this.MaxSpeed < 10)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MissileBase];
                else if (this.Size <= 20M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.FAC];
                else if (this.Size < 200M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MissileDD];
                else if (this.Size < 400M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MissileCA];
                else
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MissileBC];
            }
            else if (this.method_73(AuroraComponentType.BeamFireControl) > 0M)
            {
                if (this.method_73(AuroraComponentType.HangarDeck) > 0M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.CarrierBattle];
                else if (this.method_74(AuroraComponentType.BeamFireControl)
                             .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component)
                             .OrderByDescending<ShipComponent, GEnum87>(gclass230_0 => gclass230_0.genum87_0)
                             .FirstOrDefault<ShipComponent>().genum87_0 == GEnum87.const_1)
                {
                    if (this.MaxSpeed < 10)
                        this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamDefenceBase];
                    if (this.Size < 200M)
                        this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamDE];
                    else
                        this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamCLE];
                }
                else if (this.Size <= 20M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.FAC];
                else if (this.Size < 200M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamDD];
                else if (this.Size < 400M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamCA];
                else if (this.Size < 800M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamBC];
                else
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamDreadnought];
            }
            else if (this.method_73(AuroraComponentType.HangarDeck) > 0M)
            {
                if (this.method_73(AuroraComponentType.Magazine) > 0M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.CarrierMissile];
                else
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.CarrierEnergy];
            }
            else if (this.method_73(AuroraComponentType.RefuellingSystem) > 0M && this.FuelCapacity > 2000000)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Tanker];
            else if (this.ClassComponents.Values
                         .Where<ClassComponent>(gclass228_0 =>
                             gclass228_0.Component.gclass164_0.gclass163_0.TechType ==
                             TechType.SmallRefuellingSystem).Sum<ClassComponent>(gclass228_0 => gclass228_0.NumComponent) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Tanker];
            else if (!this.Commercial)
            {
                if (this.method_74(AuroraComponentType.ActiveSearchSensors)
                        .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component)
                        .FirstOrDefault<ShipComponent>(gclass230_0 => gclass230_0.decimal_1 > 3M) != null)
                {
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Scout];
                }
                else
                {
                    if (!(this.method_73(AuroraComponentType.JumpDrive) > 0M))
                        return;
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.MilitaryJumpShip];
                }
            }
            else if (this.method_73(AuroraComponentType.JumpDrive) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.CommercialJumpTender];
            else if (this.method_73(AuroraComponentType.TroopTransport) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.TroopTransport];
            else if (this.method_73(AuroraComponentType.TerraformingModule) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.TerraFormer];
            else if (this.method_73(AuroraComponentType.OrbitalMiningModule) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.AsteroidMiner];
            else if (this.method_73(AuroraComponentType.SoriumHarvester) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Harvester];
            else if (this.method_73(AuroraComponentType.SalvageModule) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Salvager];
            else if (this.method_73(AuroraComponentType.JumpPointStabilisation) > 0M)
                this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.ConstructionShip];
            else if (this.method_73(AuroraComponentType.ColonistTransport) > 0M)
            {
                if (this.Size < 600M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.SmallColony];
                else if (this.Size < 1200M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.LargeColony];
                else
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.HugeColony];
            }
            else
            {
                if (!(this.method_73(AuroraComponentType.CargoHold) > 0M))
                    return;
                if (this.Size < 1000M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.SmallFreighter];
                else if (this.Size < 2000M)
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.LargeFreighter];
                else
                    this.AutomatedClassDesign = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.HugeFreighter];
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2854);
        }
    }

    public AutomatedClassDesignType method_32()
    {
        try
        {
            return this.AutomatedClassDesign == null ? AutomatedClassDesignType.const_0 : this.AutomatedClassDesign.AutomatedClassDesignTypeID;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2855);
            return AutomatedClassDesignType.const_0;
        }
    }

    public bool method_33()
    {
        try
        {
            return this.AutomatedClassDesign != null && this.AutomatedClassDesign.bool_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2856);
            return false;
        }
    }

    public string method_34() => string.Format("{0} {1}", this.ShipHull.Abbreviation, this.ClassName);

    public bool method_35(GEnum118 genum118_0)
    {
        try
        {
            return this.ClassComponents.ContainsKey((int)genum118_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2857);
            return false;
        }
    }

    public List<ShipData> method_36()
    {
        return this.gclass0_0.Ships.Values
            .Where<ShipData>(gclass40_0 => gclass40_0.Class == this).ToList<ShipData>();
    }

    public int method_37()
    {
        return this.gclass0_0.Ships.Values.Count<ShipData>(gclass40_0 =>
            gclass40_0.Class == this);
    }

    public ShipComponent method_38()
    {
        try
        {
            List<ShipComponent> list = this.ClassComponents.Values
                .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component).ToList<ShipComponent>();
            return list[AuroraUtils.GetRandomInteger(list.Count) - 1];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2858);
            return null;
        }
    }

    public string method_39()
    {
        try
        {
            string str = "";
            if (this.NameTheme != null)
            {
                if (this.NameTheme.ThemeID == 0)
                    str = this.ClassName;
                else if (this.NameTheme.ThemeID > 1)
                    str = this.NameTheme.method_2(this.Race, GEnum21.const_0, this.RandomShipNameFromTheme, this.PrefixName,
                        this.SuffixName);
            }

            if (str == "")
                str =
                    string.Format("{0} {1}", this.ClassName,
                        AuroraUtils.smethod_33(this.TotalNumber +
                                               this.gclass0_0.dictionary_32.Values.Count<ShipyardTask>(gclass192_0 =>
                                                   gclass192_0.gclass22_0 == this) + 1));
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2859);
            return "None";
        }
    }

    public Decimal method_40(ShipClass gclass22_0, AllMineralsValue gclass123_1, ListView listView_0)
    {
        try
        {
            Decimal num1 = 0M;
            if (listView_0 != null)
            {
                listView_0.Items.Clear();
                this.gclass0_0.method_601(listView_0, "Modification", "Amount", "Cost");
                this.gclass0_0.method_601(listView_0, "", "", "");
            }

            if (gclass22_0 == null)
                return 0M;
            foreach (ClassComponent gclass228_1 in gclass22_0.ClassComponents.Values)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                ShipClass.Class769 class769 = new ShipClass.Class769();
                // ISSUE: reference to a compiler-generated field
                class769.gclass228_0 = gclass228_1;
                // ISSUE: reference to a compiler-generated method
                ClassComponent gclass228_2 = this.ClassComponents.Values.FirstOrDefault<ClassComponent>(class769.method_0);
                Decimal num2 = 0M;
                if (gclass228_2 == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    num2 = class769.gclass228_0.NumComponent;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (gclass228_2.NumComponent < class769.gclass228_0.NumComponent)
                    {
                        // ISSUE: reference to a compiler-generated field
                        num2 = class769.gclass228_0.NumComponent - gclass228_2.NumComponent;
                    }
                }

                if (num2 > 0M)
                {
                    // ISSUE: reference to a compiler-generated field
                    num1 += num2 * class769.gclass228_0.Component.decimal_2;
                    // ISSUE: reference to a compiler-generated field
                    gclass123_1?.method_35(class769.gclass228_0.Component, Math.Round(num2, 1));
                    if (listView_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass0_0.method_601(listView_0, class769.gclass228_0.Component.Name,
                            AuroraUtils.FormatNumberToDigits(num2, 1),
                            AuroraUtils.FormatNumberToDigits(num2 * class769.gclass228_0.Component.decimal_2, 1).ToString());
                    }
                }
            }

            Decimal decimal_73_1 = Math.Abs(gclass22_0.Size - this.Size) / this.Size * num1;
            Decimal decimal_73_2 = num1 * 0.2M;
            Decimal decimal_73_3 = num1 + decimal_73_2 + decimal_73_1;
            if (listView_0 != null)
            {
                this.gclass0_0.method_601(listView_0, "Refit Overhead Cost", "",
                    AuroraUtils.FormatNumberToDigits(decimal_73_2, 1));
                this.gclass0_0.method_601(listView_0, "Size Difference Cost ", "",
                    AuroraUtils.smethod_39(decimal_73_1));
                this.gclass0_0.method_601(listView_0, "", "", "");
                this.gclass0_0.method_601(listView_0, "Total", "", AuroraUtils.FormatNumberToDigits(decimal_73_3, 1).ToString());
            }

            return decimal_73_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2860);
            return 0M;
        }
    }

    public Decimal method_41()
    {
        try
        {
            return this.EnginePower > 0M ? this.FuelCapacity / (this.EnginePower * this.FuelEfficiency) * this.MaxSpeed * 3600M : 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2861);
            return 0M;
        }
    }

    public int method_42()
    {
        try
        {
            return this.ConscriptOnly == 1 ? -1 : this.Crew;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2862);
            return 0;
        }
    }

    public void method_43(ShipData gclass40_0)
    {
        try
        {
            gclass40_0.Ordnances.Clear();
            foreach (ShipOrdnance gclass130 in gclass40_0.Class.OrdnanceTemplate)
                gclass40_0.Ordnances.Add(new ShipOrdnance()
                {
                    RaceMissile = gclass130.RaceMissile,
                    Amount = gclass130.Amount
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2863);
        }
    }

    public void method_44(ShipData gclass40_0)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            ShipClass.Class770 class770 = new ShipClass.Class770();
            // ISSUE: reference to a compiler-generated field
            class770.gclass130_0 =
                gclass40_0.Class.OrdnanceTemplate.FirstOrDefault<ShipOrdnance>(gclass130_0 =>
                    gclass130_0.RaceMissile.ShipDecoy == 1);
            // ISSUE: reference to a compiler-generated field
            if (class770.gclass130_0 == null)
                return;
            // ISSUE: reference to a compiler-generated method
            ShipOrdnance gclass130 = gclass40_0.Ordnances.FirstOrDefault<ShipOrdnance>(class770.method_0);
            if (gclass130 == null)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass40_0.Ordnances.Add(new ShipOrdnance()
                {
                    RaceMissile = class770.gclass130_0.RaceMissile,
                    Amount = class770.gclass130_0.Amount
                });
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                gclass130.Amount = class770.gclass130_0.Amount;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3687);
        }
    }

    public Decimal method_45()
    {
        try
        {
            Decimal num = 0M;
            foreach (ShipOrdnance gclass130 in this.OrdnanceTemplate
                         .Where<ShipOrdnance>(gclass130_0 => gclass130_0.RaceMissile.ShipDecoy == 0).ToList<ShipOrdnance>())
                num += gclass130.RaceMissile.Size * gclass130.Amount;
            return this.MagazineCapacity - num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2864);
            return 0M;
        }
    }

    public Decimal method_46()
    {
        try
        {
            Decimal num = 0M;
            foreach (ShipOrdnance gclass130 in this.OrdnanceTemplate
                         .Where<ShipOrdnance>(gclass130_0 => gclass130_0.RaceMissile.ShipDecoy == 1).ToList<ShipOrdnance>())
                num += gclass130.RaceMissile.Size * gclass130.Amount;
            return this.DecoyCapacity - num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3695);
            return 0M;
        }
    }

    public Decimal method_47()
    {
        try
        {
            Decimal num = 0M;
            foreach (ClassFighterTemplate gclass74 in this.FighterClassTemplates)
                num += gclass74.FighterClass.Size * gclass74.Number;
            return this.ParasiteCapacity - num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2865);
            return 0M;
        }
    }

    public List<ClassComponent> method_48()
    {
        try
        {
            return this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_11)
                .ToList<ClassComponent>().OrderBy<ClassComponent, string>(gclass228_0 => gclass228_0.Component.Name)
                .ToList<ClassComponent>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2866);
            return null;
        }
    }

    public bool method_49()
    {
        try
        {
            return this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                gclass228_0.Component.bool_11 && gclass228_0.Component.Data.ComponentTypeID !=
                AuroraComponentType.MissileLauncher).Count<ClassComponent>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2867);
            return false;
        }
    }

    public ShipClass method_50(GameRace gclass21_1, bool bool_11)
    {
        try
        {
            ShipClass gclass22_1 = new ShipClass(this.gclass0_0);
            ShipClass gclass22_2 = (ShipClass)this.MemberwiseClone();
            string str = string.Format("{0} - Copy", this.ClassName);
            if (bool_11)
            {
                AlienShipClassIntel gclass115 = gclass21_1.method_118(this);
                if (gclass115 != null)
                    str = gclass115.ClassName;
            }

            gclass22_2.ShipClassID = this.gclass0_0.method_26(GEnum0.const_18);
            gclass22_2.ClassName = str;
            gclass22_2.TotalNumber = 0;
            gclass22_2.OtherRaceClassID = 0;
            gclass22_2.Locked = false;
            if (gclass21_1 != null)
            {
                gclass22_2.Race = gclass21_1;
                gclass22_2.RacialRankTheme = null;
                gclass22_2.gclass187_0 = null;
            }

            gclass22_2.ClassMaterials = this.ClassMaterials.method_25();
            gclass22_2.ClassComponents = new Dictionary<int, ClassComponent>();
            foreach (ClassComponent gclass228_1 in this.ClassComponents.Values)
            {
                ClassComponent gclass228_2 = gclass228_1.method_1();
                gclass228_2.ClassID = gclass22_2.ShipClassID;
                gclass22_2.ClassComponents.Add(gclass228_2.ComponentID, gclass228_2);
            }

            gclass22_2.OrdnanceTemplate = new List<ShipOrdnance>();
            gclass22_2.FighterClassTemplates = new List<ClassFighterTemplate>();
            gclass22_2.GroundUnitTemplates = new List<ClassGroundTemplate>();
            if (gclass21_1 == null)
            {
                foreach (ShipOrdnance gclass130 in this.OrdnanceTemplate)
                    gclass22_2.OrdnanceTemplate.Add(new ShipOrdnance()
                    {
                        RaceMissile = gclass130.RaceMissile,
                        Amount = gclass130.Amount
                    });
                foreach (ClassFighterTemplate gclass74 in this.FighterClassTemplates)
                    gclass22_2.FighterClassTemplates.Add(new ClassFighterTemplate()
                    {
                        FighterClass = gclass74.FighterClass,
                        Number = gclass74.Number
                    });
                foreach (ClassGroundTemplate gclass75 in this.GroundUnitTemplates)
                    gclass22_2.GroundUnitTemplates.Add(new ClassGroundTemplate()
                    {
                        GroundUnitTemplate = gclass75.GroundUnitTemplate,
                        Number = gclass75.Number
                    });
            }

            if (gclass21_1 != null)
                this.method_85(0, 0, "");
            return gclass22_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2868);
            return null;
        }
    }

    public ClassComponent method_51(ShipComponent gclass230_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class771 class771 = new ShipClass.Class771();
        // ISSUE: reference to a compiler-generated field
        class771.gclass230_0 = gclass230_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (int_69 == 0 || class771.gclass230_0 == null)
                return null;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((class771.gclass230_0.bool_12 || class771.gclass230_0.bool_13) && int_69 > 1)
                int_69 = 1;
            // ISSUE: reference to a compiler-generated method
            ClassComponent gclass228 = this.ClassComponents.Values.Where<ClassComponent>(class771.method_0)
                .FirstOrDefault<ClassComponent>();
            if (gclass228 != null)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if ((class771.gclass230_0.bool_12 || class771.gclass230_0.bool_13) && gclass228.NumComponent > 0M)
                {
                    int num = (int)MessageBox.Show(
                        "Only a single component of this type can be added to a class design");
                    return null;
                }

                gclass228.NumComponent += int_69;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.Data.ComponentTypeID == AuroraComponentType.Engine && this
                        .ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.Engine)
                        .Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one type of engine can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.Data.ComponentTypeID == AuroraComponentType.RefuellingSystem &&
                    this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.Data.ComponentTypeID ==
                        AuroraComponentType.RefuellingSystem).Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one type of Refuelling System can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.gclass164_0.gclass163_0.TechType == TechType.SensorJammer && this
                        .ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.gclass164_0.gclass163_0.TechType == TechType.SensorJammer)
                        .Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one type of Active Jammer can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.gclass164_0.gclass163_0.TechType == TechType.FireControlJammer && this
                        .ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.gclass164_0.gclass163_0.TechType == TechType.FireControlJammer)
                        .Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one type of Fire Control Jammer can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.gclass164_0.gclass163_0.TechType == TechType.MissileJammer && this
                        .ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.gclass164_0.gclass163_0.TechType == TechType.MissileJammer)
                        .Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one type of Missile Jammer can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.Data.ComponentTypeID ==
                    AuroraComponentType.JumpPointStabilisation && this.ClassComponents.Values
                        .Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.Data.ComponentTypeID ==
                            AuroraComponentType.JumpPointStabilisation).Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one type of stabilisation module can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.Data.ComponentTypeID == AuroraComponentType.Shields && this
                        .ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.Shields)
                        .Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one type of shield generator can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.Data.ComponentTypeID == AuroraComponentType.CommercialHangarDeck)
                {
                    if (this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                                gclass228_0.Component.Data.ComponentTypeID ==
                                AuroraComponentType.HangarDeck)
                            .Count<ClassComponent>() > 0)
                    {
                        int num = (int)MessageBox.Show(
                            "Hangars and Commercial Hangars cannot both be added to the same ship");
                        return null;
                    }
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class771.gclass230_0.Data.ComponentTypeID == AuroraComponentType.HangarDeck && this
                            .ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                                gclass228_0.Component.Data.ComponentTypeID ==
                                AuroraComponentType.CommercialHangarDeck).Count<ClassComponent>() > 0)
                    {
                        int num = (int)MessageBox.Show(
                            "Hangars and Commercial Hangars cannot both be added to the same ship");
                        return null;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.Data.ComponentTypeID == AuroraComponentType.JumpDrive && this
                        .ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.JumpDrive)
                        .Count<ClassComponent>() > 0)
                {
                    int num = (int)MessageBox.Show("Only one jump drive can be added to a class");
                    return null;
                }

                // ISSUE: reference to a compiler-generated field
                if (class771.gclass230_0.bool_13 && !this.Race.NPR &&
                    this.ClassComponents.Values.Count<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_13) > 0)
                {
                    int num = (int)MessageBox.Show("Only a single spinal weapon can be added to a class design");
                    return null;
                }

                gclass228 = new ClassComponent();
                // ISSUE: reference to a compiler-generated field
                gclass228.Component = class771.gclass230_0;
                // ISSUE: reference to a compiler-generated field
                gclass228.ComponentID = class771.gclass230_0.int_0;
                gclass228.ClassID = this.ShipClassID;
                gclass228.NumComponent = int_69;
                this.ClassComponents.Add(gclass228.ComponentID, gclass228);
            }

            return gclass228;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2869);
            return null;
        }
    }

    public void method_52(ShipComponent gclass230_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class772 class772 = new ShipClass.Class772();
        // ISSUE: reference to a compiler-generated field
        class772.gclass230_0 = gclass230_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (int_69 == 0 || class772.gclass230_0 == null)
                return;
            // ISSUE: reference to a compiler-generated method
            List<ClassComponent> list = this.ClassComponents.Values.Where<ClassComponent>(class772.method_0).ToList<ClassComponent>();
            if (list.Count != 1)
                return;
            if (list[0].NumComponent > int_69)
                list[0].NumComponent -= int_69;
            else
                this.ClassComponents.Remove(list[0].Component.int_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2870);
        }
    }

    public void method_53()
    {
        try
        {
            ClassComponent gclass228 = this.method_76();
            if (gclass228 == null)
                return;
            this.ClassComponents.Remove(gclass228.ComponentID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2871);
        }
    }

    public void method_54(RaceMissile gclass129_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class773 class773 = new ShipClass.Class773();
        // ISSUE: reference to a compiler-generated field
        class773.gclass129_0 = gclass129_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (int_69 == 0 || class773.gclass129_0 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            if (class773.gclass129_0.ShipDecoy == 0)
            {
                Decimal num = this.method_45();
                // ISSUE: reference to a compiler-generated field
                if (class773.gclass129_0.Size * int_69 > num)
                {
                    // ISSUE: reference to a compiler-generated field
                    int_69 = (int)(num / class773.gclass129_0.Size);
                }
            }
            else
            {
                Decimal num = this.method_46();
                // ISSUE: reference to a compiler-generated field
                if (class773.gclass129_0.Size * int_69 > num)
                {
                    // ISSUE: reference to a compiler-generated field
                    int_69 = (int)(num / class773.gclass129_0.Size);
                }
            }

            if (int_69 <= 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<ShipOrdnance> list = this.OrdnanceTemplate.Where<ShipOrdnance>(class773.method_0).ToList<ShipOrdnance>();
            if (list.Count == 1)
            {
                list[0].Amount += int_69;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.OrdnanceTemplate.Add(new ShipOrdnance()
                {
                    RaceMissile = class773.gclass129_0,
                    Amount = int_69
                });
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2872);
        }
    }

    public void method_55(ShipOrdnance gclass130_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class774 class774 = new ShipClass.Class774();
        // ISSUE: reference to a compiler-generated field
        class774.gclass130_0 = gclass130_0;
        try
        {
            if (int_69 == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<ShipOrdnance> list = this.OrdnanceTemplate.Where<ShipOrdnance>(class774.method_0).ToList<ShipOrdnance>();
            if (list.Count != 1)
                return;
            if (list[0].Amount > int_69)
            {
                list[0].Amount -= int_69;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.OrdnanceTemplate.Remove(class774.gclass130_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2873);
        }
    }

    public void method_56(ShipClass gclass22_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class775 class775 = new ShipClass.Class775();
        // ISSUE: reference to a compiler-generated field
        class775.gclass22_0 = gclass22_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (int_69 == 0 || class775.gclass22_0 == null)
                return;
            Decimal num = this.method_47();
            // ISSUE: reference to a compiler-generated field
            if (class775.gclass22_0.Size * int_69 > num)
            {
                // ISSUE: reference to a compiler-generated field
                int_69 = (int)(num / class775.gclass22_0.Size);
            }

            // ISSUE: reference to a compiler-generated method
            List<ClassFighterTemplate> list = this.FighterClassTemplates.Where<ClassFighterTemplate>(class775.method_0).ToList<ClassFighterTemplate>();
            if (list.Count == 1)
            {
                list[0].Number += int_69;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.FighterClassTemplates.Add(new ClassFighterTemplate()
                {
                    FighterClass = class775.gclass22_0,
                    Number = int_69
                });
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2874);
        }
    }

    public void method_57(GroundUnitFormationTemplateData gclass102_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class776 class776 = new ShipClass.Class776();
        // ISSUE: reference to a compiler-generated field
        class776.gclass102_0 = gclass102_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (int_69 == 0 || class776.gclass102_0 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            Decimal num1 = class776.gclass102_0.method_9();
            Decimal num2 = this.TroopCapacity -
                           this.GroundUnitTemplates.Sum<ClassGroundTemplate>(gclass75_0 =>
                               gclass75_0.GroundUnitTemplate.method_9() * gclass75_0.Number);
            if (num1 * int_69 > num2)
                int_69 = (int)(num2 / num1);
            if (int_69 == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<ClassGroundTemplate> list = this.GroundUnitTemplates.Where<ClassGroundTemplate>(class776.method_0).ToList<ClassGroundTemplate>();
            if (list.Count == 1)
            {
                list[0].Number += int_69;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.GroundUnitTemplates.Add(new ClassGroundTemplate()
                {
                    GroundUnitTemplate = class776.gclass102_0,
                    Number = int_69
                });
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3628);
        }
    }

    public void method_58(ClassFighterTemplate gclass74_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class777 class777 = new ShipClass.Class777();
        // ISSUE: reference to a compiler-generated field
        class777.gclass74_0 = gclass74_0;
        try
        {
            if (int_69 == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<ClassFighterTemplate> list = this.FighterClassTemplates.Where<ClassFighterTemplate>(class777.method_0).ToList<ClassFighterTemplate>();
            if (list.Count != 1)
                return;
            if (list[0].Number > int_69)
            {
                list[0].Number -= int_69;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.FighterClassTemplates.Remove(class777.gclass74_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2875);
        }
    }

    public void method_59(ClassGroundTemplate gclass75_0, int int_69)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class778 class778 = new ShipClass.Class778();
        // ISSUE: reference to a compiler-generated field
        class778.gclass75_0 = gclass75_0;
        try
        {
            if (int_69 == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<ClassGroundTemplate> list = this.GroundUnitTemplates.Where<ClassGroundTemplate>(class778.method_0).ToList<ClassGroundTemplate>();
            if (list.Count != 1)
                return;
            if (list[0].Number > int_69)
            {
                list[0].Number -= int_69;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                this.GroundUnitTemplates.Remove(class778.gclass75_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3634);
        }
    }

    public void method_60(ListBox listBox_0, Label label_0)
    {
        try
        {
            Decimal decimal8 = this.ParasiteCapacity;
            List<ClassFighterTemplate> list = this.FighterClassTemplates.OrderBy<ClassFighterTemplate, string>(gclass74_0 => gclass74_0.FighterClass.ClassName)
                .ToList<ClassFighterTemplate>();
            foreach (ClassFighterTemplate gclass74 in list)
            {
                gclass74.Combined = string.Format("{0}x {1}", gclass74.Number.ToString(), gclass74.FighterClass.ClassName);
                decimal8 -= gclass74.Number * gclass74.FighterClass.Size;
            }

            listBox_0.DataSource = list;
            listBox_0.DisplayMember = "Combined";
            listBox_0.SelectedItem = null;
            label_0.Text = string.Format("Capacity Remaining: {0} tons", AuroraUtils.smethod_39(decimal8 * 50M));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2876);
        }
    }

    public void method_61(ListBox listBox_0, Label label_0)
    {
        try
        {
            Decimal int57 = this.TroopCapacity;
            List<ClassGroundTemplate> list = this.GroundUnitTemplates.OrderBy<ClassGroundTemplate, string>(gclass75_0 => gclass75_0.GroundUnitTemplate.Name)
                .ToList<ClassGroundTemplate>();
            foreach (ClassGroundTemplate gclass75 in list)
            {
                gclass75.Combined = string.Format("{0}x {1}", gclass75.Number.ToString(), gclass75.GroundUnitTemplate.Name);
                int57 -= gclass75.Number * gclass75.GroundUnitTemplate.method_9();
            }

            listBox_0.DataSource = list;
            listBox_0.DisplayMember = "Combined";
            listBox_0.SelectedItem = null;
            label_0.Text = string.Format("Capacity Remaining: {0} tons", AuroraUtils.smethod_39(int57));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3632);
        }
    }

    public void method_62(ListBox listBox_0, Label label_0)
    {
        try
        {
            Decimal decimal_73 = this.MagazineCapacity + this.DecoyCapacity;
            List<ShipOrdnance> list = this.OrdnanceTemplate.OrderBy<ShipOrdnance, string>(gclass130_0 => gclass130_0.RaceMissile.Name)
                .ToList<ShipOrdnance>();
            foreach (ShipOrdnance gclass130 in list)
            {
                gclass130.Combined = string.Format("{0}x {1}", gclass130.Amount.ToString(), gclass130.RaceMissile.Name);
                decimal_73 -= gclass130.Amount * gclass130.RaceMissile.Size;
            }

            listBox_0.DataSource = list;
            listBox_0.DisplayMember = "Combined";
            listBox_0.SelectedItem = null;
            label_0.Text = string.Format("Capacity Remaining: {0} MSP", AuroraUtils.smethod_39(decimal_73));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2877);
        }
    }

    public void method_63(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            this.gclass0_0.method_601(listView_0, "Class Template Loadout", "Num", null);
            this.gclass0_0.method_594(listView_0, "");
            List<ShipOrdnance> list = this.OrdnanceTemplate.OrderBy<ShipOrdnance, string>(gclass130_0 => gclass130_0.RaceMissile.Name)
                .ToList<ShipOrdnance>();
            foreach (ShipOrdnance object_1 in list)
                this.gclass0_0.method_598(listView_0, object_1.RaceMissile.Name, AuroraUtils.smethod_37(object_1.Amount),
                    object_1);
            Decimal decimal_73_1 = this.method_45();
            Decimal decimal_73_2 = this.method_46();
            if (list.Count > 0)
                this.gclass0_0.method_594(listView_0, "");
            this.gclass0_0.method_597(listView_0, "Available Space",
                string.Format("{0} / {1}", AuroraUtils.FormatNumberToDigits(decimal_73_1, 2),
                    AuroraUtils.FormatNumberToDigits(decimal_73_2, 2)));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2878);
        }
    }

    public void method_64(ListView listView_0, GEnum18 genum18_0, CheckState checkState_0)
    {
        try
        {
            listView_0.Items.Clear();
            List<ClassComponent> gclass228List = new List<ClassComponent>();
            listView_0.Items.Add(new ListViewItem("Component Name")
            {
                SubItems =
                {
                    "Amount",
                    "Size",
                    "Cost",
                    "Crew",
                    "HTK",
                    "Size %",
                    "Cost %",
                    "Crew %",
                    "HTK %",
                    "DAC %",
                    "E-DAC %"
                }
            });
            this.gclass0_0.method_594(listView_0, "");
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            Decimal num3 = 0M;
            Decimal num4 = 0M;
            foreach (ClassComponent gclass228 in this.ClassComponents.Values)
            {
                gclass228.decimal_2 = gclass228.NumComponent * gclass228.Component.decimal_2;
                gclass228.decimal_3 = gclass228.NumComponent * gclass228.Component.int_1;
                gclass228.decimal_4 = gclass228.NumComponent * gclass228.Component.decimal_1;
                gclass228.decimal_5 = gclass228.NumComponent * gclass228.Component.int_4;
                num1 += gclass228.decimal_2;
                num3 += gclass228.decimal_3;
                num2 += gclass228.decimal_4;
                num4 += gclass228.decimal_5;
            }

            List<ClassComponent> list1 = this.ClassComponents.Values.OrderBy<ClassComponent, int>(gclass228_0 => gclass228_0.ChanceToHit)
                .ToList<ClassComponent>();
            int num5 = 0;
            int num6 = 0;
            foreach (ClassComponent gclass228 in list1)
            {
                gclass228.decimal_6 = 0M;
                gclass228.decimal_7 = 0M;
                gclass228.decimal_6 = (gclass228.ChanceToHit - num5) / (Decimal)this.MaxDACRoll;
                num5 = gclass228.ChanceToHit;
                if (gclass228.Component.bool_5)
                {
                    gclass228.decimal_7 = (gclass228.ElectronicCTH - num6) / (Decimal)this.ESMaxDACRoll;
                    num6 = gclass228.ElectronicCTH;
                }
            }

            switch (genum18_0)
            {
                case GEnum18.const_0:
                    list1 = this.ClassComponents.Values
                        .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.NumComponent)
                        .ToList<ClassComponent>();
                    break;
                case GEnum18.const_1:
                    list1 = this.ClassComponents.Values
                        .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.decimal_2)
                        .ToList<ClassComponent>();
                    break;
                case GEnum18.const_2:
                    list1 = this.ClassComponents.Values
                        .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.decimal_4)
                        .ToList<ClassComponent>();
                    break;
                case GEnum18.const_3:
                    list1 = this.ClassComponents.Values
                        .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.decimal_3)
                        .ToList<ClassComponent>();
                    break;
                case GEnum18.const_4:
                    list1 = this.ClassComponents.Values
                        .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.decimal_5)
                        .ToList<ClassComponent>();
                    break;
                case GEnum18.const_12:
                    list1 = this.ClassComponents.Values
                        .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.decimal_6)
                        .ToList<ClassComponent>();
                    break;
                case GEnum18.const_13:
                    list1 = this.ClassComponents.Values
                        .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.decimal_7)
                        .ToList<ClassComponent>();
                    break;
            }

            if (checkState_0 == CheckState.Checked)
            {
                foreach (ClassSummaryType gclass232 in this.gclass0_0.ClassSummaryTypeDictionary.Values)
                    gclass232.method_0();
                foreach (ClassComponent gclass228 in list1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    ShipClass.Class779 class779 = new ShipClass.Class779();
                    // ISSUE: reference to a compiler-generated field
                    class779.gclass228_0 = gclass228;
                    // ISSUE: reference to a compiler-generated method
                    ClassSummaryType gclass232 = this.gclass0_0.ClassSummaryTypeDictionary
                        .Where<KeyValuePair<ClassSummaryTypeID, ClassSummaryType>>(class779.method_0)
                        .Select<KeyValuePair<ClassSummaryTypeID, ClassSummaryType>, ClassSummaryType>(keyValuePair_0 => keyValuePair_0.Value)
                        .FirstOrDefault<ClassSummaryType>();
                    if (gclass232 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass232.decimal_0 += class779.gclass228_0.decimal_4;
                        // ISSUE: reference to a compiler-generated field
                        gclass232.decimal_1 += class779.gclass228_0.decimal_2;
                        // ISSUE: reference to a compiler-generated field
                        gclass232.decimal_2 += class779.gclass228_0.decimal_3;
                        // ISSUE: reference to a compiler-generated field
                        gclass232.decimal_3 += class779.gclass228_0.decimal_5;
                        // ISSUE: reference to a compiler-generated field
                        gclass232.decimal_4 += class779.gclass228_0.NumComponent;
                        gclass232.bool_0 = true;
                    }
                }

                List<ClassSummaryType> list2 = this.gclass0_0.ClassSummaryTypeDictionary.Values
                    .Where<ClassSummaryType>(gclass232_0 => gclass232_0.bool_0)
                    .OrderByDescending<ClassSummaryType, Decimal>(gclass232_0 => gclass232_0.decimal_1).ToList<ClassSummaryType>();
                switch (genum18_0)
                {
                    case GEnum18.const_2:
                        list2 = list2.OrderByDescending<ClassSummaryType, Decimal>(gclass232_0 => gclass232_0.decimal_0)
                            .ToList<ClassSummaryType>();
                        break;
                    case GEnum18.const_3:
                        list2 = list2.OrderByDescending<ClassSummaryType, Decimal>(gclass232_0 => gclass232_0.decimal_2)
                            .ToList<ClassSummaryType>();
                        break;
                    case GEnum18.const_4:
                        list2 = list2.OrderByDescending<ClassSummaryType, Decimal>(gclass232_0 => gclass232_0.decimal_3)
                            .ToList<ClassSummaryType>();
                        break;
                }

                foreach (ClassSummaryType gclass232 in list2)
                {
                    ListViewItem listViewItem = new ListViewItem(gclass232.string_0);
                    listViewItem.SubItems.Add("-");
                    listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass232.decimal_0, 2).ToString());
                    listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass232.decimal_1, 2).ToString());
                    listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass232.decimal_2, 2).ToString());
                    listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass232.decimal_3, 2).ToString());
                    listViewItem.SubItems.Add(
                        string.Format("{0}%", AuroraUtils.FormatNumberToDigits(gclass232.decimal_0 / num2 * 100M, 1)));
                    listViewItem.SubItems.Add(
                        string.Format("{0}%", AuroraUtils.FormatNumberToDigits(gclass232.decimal_1 / num1 * 100M, 1)));
                    if (num3 > 0M)
                        listViewItem.SubItems.Add(
                            string.Format("{0}%",
                                AuroraUtils.FormatNumberToDigits(gclass232.decimal_2 / num3 * 100M, 1)));
                    else
                        listViewItem.SubItems.Add("-");
                    if (num4 > 0M)
                        listViewItem.SubItems.Add(
                            string.Format("{0}%",
                                AuroraUtils.FormatNumberToDigits(gclass232.decimal_3 / num4 * 100M, 1)));
                    else
                        listViewItem.SubItems.Add("-");
                    listViewItem.SubItems.Add("-");
                    listViewItem.SubItems.Add("-");
                    listView_0.Items.Add(listViewItem);
                }

                this.gclass0_0.method_594(listView_0, "");
            }

            foreach (ClassComponent gclass228 in list1)
            {
                ListViewItem listViewItem = new ListViewItem(gclass228.Component.Name);
                listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass228.NumComponent, 2).ToString());
                listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass228.decimal_4, 2).ToString());
                listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass228.decimal_2, 2).ToString());
                listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass228.decimal_3, 2).ToString());
                listViewItem.SubItems.Add(AuroraUtils.FormatNumberToDigits(gclass228.decimal_5, 2).ToString());
                listViewItem.SubItems.Add(string.Format("{0}%",
                    AuroraUtils.FormatNumberToDigits(gclass228.decimal_4 / num2 * 100M, 1)));
                listViewItem.SubItems.Add(string.Format("{0}%",
                    AuroraUtils.FormatNumberToDigits(gclass228.decimal_2 / num1 * 100M, 1)));
                if (num3 > 0M)
                    listViewItem.SubItems.Add(
                        string.Format("{0}%", AuroraUtils.FormatNumberToDigits(gclass228.decimal_3 / num3 * 100M, 1)));
                else
                    listViewItem.SubItems.Add("-");
                if (num4 > 0M)
                    listViewItem.SubItems.Add(
                        string.Format("{0}%", AuroraUtils.FormatNumberToDigits(gclass228.decimal_5 / num4 * 100M, 1)));
                else
                    listViewItem.SubItems.Add("-");
                if (gclass228.decimal_6 > 0M)
                    listViewItem.SubItems.Add(string.Format("{0}%",
                        AuroraUtils.FormatNumberToDigits(gclass228.decimal_6 * 100M, 1)));
                else
                    listViewItem.SubItems.Add("-");
                if (gclass228.decimal_7 > 0M)
                    listViewItem.SubItems.Add(string.Format("{0}%",
                        AuroraUtils.FormatNumberToDigits(gclass228.decimal_7 * 100M, 1)));
                else
                    listViewItem.SubItems.Add("-");
                listView_0.Items.Add(listViewItem);
            }

            this.gclass0_0.method_594(listView_0, "");
            AllMineralsValue gclass123_0_1 = this.ClassMaterials.method_25();
            AllMineralsValue gclass123_0_2 = new AllMineralsValue(this.gclass0_0);
            AllMineralsValue gclass123_0_3 = new AllMineralsValue(this.gclass0_0);
            AllMineralsValue gclass123 = new AllMineralsValue(this.gclass0_0);
            Decimal int63 = this.FuelCapacity;
            Decimal decimal_73_1 = 0M;
            string string_14 = "-";
            foreach (ShipOrdnance object_1 in this.OrdnanceTemplate)
            {
                decimal_73_1 += object_1.RaceMissile.Cost * object_1.Amount;
                this.gclass0_0.method_604(listView_0, object_1.RaceMissile.Name, AuroraUtils.smethod_37(object_1.Amount),
                    AuroraUtils.smethod_38(object_1.RaceMissile.Size * object_1.Amount),
                    AuroraUtils.smethod_38(object_1.RaceMissile.Cost * object_1.Amount), object_1);
                gclass123_0_3.method_11(object_1.RaceMissile.ProductionMineralCost, object_1.Amount);
                int63 += object_1.RaceMissile.FuelRequired * object_1.Amount;
            }

            if (this.OrdnanceTemplate.Count > 0)
                this.gclass0_0.method_594(listView_0, "");
            gclass123_0_2.method_3(this.MaintSupplies);
            Decimal num7 = int63 / AuroraUtils.int_28;
            this.gclass0_0.method_601(listView_0, "Fuel (including ordnance)", AuroraUtils.smethod_38(int63), null);
            this.gclass0_0.method_601(listView_0, "Maintenance Supply Points", AuroraUtils.smethod_37(this.MaintSupplies),
                null);
            this.gclass0_0.method_594(listView_0, "");
            this.gclass0_0.method_612(listView_0, "", "Class", "Ordnance", "MSP", "Fuel", "Total", null);
            gclass123.AddMineralsFrom(gclass123_0_1);
            gclass123.AddMineralsFrom(gclass123_0_2);
            gclass123.AddMineralsFrom(gclass123_0_3);
            gclass123.AddSpecific(AuroraElement.Sorium, num7);
            foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof(AuroraElement)))
            {
                switch (auroraElement_0)
                {
                    case AuroraElement.None:
                        continue;
                    case AuroraElement.Sorium:
                        string_14 = AuroraUtils.FormatNumberToDigits(num7, 1);
                        if (!(gclass123_0_1.GetValueOfElement(auroraElement_0) == 0M) ||
                            !(gclass123_0_3.GetValueOfElement(auroraElement_0) == 0M) ||
                            !(gclass123_0_2.GetValueOfElement(auroraElement_0) == 0M) || !(num7 == 0M))
                            break;
                        continue;
                    default:
                        string_14 = "-";
                        if (!(gclass123_0_1.GetValueOfElement(auroraElement_0) == 0M) ||
                            !(gclass123_0_3.GetValueOfElement(auroraElement_0) == 0M) ||
                            !(gclass123_0_2.GetValueOfElement(auroraElement_0) == 0M))
                            break;
                        continue;
                }

                this.gclass0_0.method_612(listView_0, auroraElement_0.ToString(),
                    gclass123_0_1.GetElementValueFormattedString(auroraElement_0, 1), gclass123_0_3.GetElementValueFormattedString(auroraElement_0, 1),
                    gclass123_0_2.GetElementValueFormattedString(auroraElement_0, 1), string_14, gclass123.GetElementValueFormattedString(auroraElement_0, 1),
                    null);
            }

            this.gclass0_0.method_612(listView_0, "Total", AuroraUtils.smethod_41(gclass123_0_1.GetTotalAmount(), 1),
                AuroraUtils.smethod_41(gclass123_0_3.GetTotalAmount(), 1),
                AuroraUtils.smethod_41(gclass123_0_2.GetTotalAmount(), 1), string_14,
                AuroraUtils.smethod_41(gclass123.GetTotalAmount(), 1), null);
            this.gclass0_0.method_594(listView_0, "");
            Decimal decimal_73_2 = this.MaintSupplies / AuroraUtils.decimal_43;
            this.gclass0_0.method_612(listView_0, "Wealth", AuroraUtils.FormatNumberToDigits(this.Cost, 1),
                AuroraUtils.smethod_41(decimal_73_1, 1), AuroraUtils.smethod_41(decimal_73_2, 1), "-",
                AuroraUtils.FormatNumberToDigits(this.Cost + decimal_73_1 + decimal_73_2, 1), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2879);
        }
    }

    public void method_65(ListView listView_0, ShipData gclass40_0)
    {
        try
        {
            listView_0.Items.Clear();
            List<ClassComponent> gclass228List = new List<ClassComponent>();
            ListViewItem listViewItem1 = new ListViewItem("Component Name");
            listViewItem1.SubItems.Add("Amount");
            listViewItem1.SubItems.Add("Cost");
            listViewItem1.SubItems.Add("DAC %");
            listViewItem1.SubItems.Add("E-DAC %");
            listViewItem1.SubItems.Add("Damaged");
            listView_0.Items.Add(listViewItem1);
            this.gclass0_0.method_594(listView_0, "");
            List<ClassComponent> list1 = this.ClassComponents.Values.OrderBy<ClassComponent, int>(gclass228_0 => gclass228_0.ChanceToHit)
                .ToList<ClassComponent>();
            int num1 = 0;
            int num2 = 0;
            foreach (ClassComponent gclass228 in list1)
            {
                gclass228.decimal_6 = 0M;
                gclass228.decimal_7 = 0M;
                gclass228.decimal_6 = (gclass228.ChanceToHit - num1) / (Decimal)this.MaxDACRoll;
                num1 = gclass228.ChanceToHit;
                if (gclass228.Component.bool_5)
                {
                    gclass228.decimal_7 = (gclass228.ElectronicCTH - num2) / (Decimal)this.ESMaxDACRoll;
                    num2 = gclass228.ElectronicCTH;
                }
            }

            List<ClassComponent> list2 = this.ClassComponents.Values
                .OrderByDescending<ClassComponent, Decimal>(gclass228_0 => gclass228_0.decimal_6).ToList<ClassComponent>();
            listViewItem1.UseItemStyleForSubItems = false;
            foreach (ClassComponent gclass228 in list2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                ShipClass.Class780 class780 = new ShipClass.Class780();
                // ISSUE: reference to a compiler-generated field
                class780.gclass228_0 = gclass228;
                // ISSUE: reference to a compiler-generated field
                ListViewItem listViewItem2 = new ListViewItem(class780.gclass228_0.Component.Name);
                // ISSUE: reference to a compiler-generated field
                listViewItem2.SubItems.Add(AuroraUtils.FormatNumberToDigits(class780.gclass228_0.NumComponent, 2).ToString());
                // ISSUE: reference to a compiler-generated field
                listViewItem2.SubItems.Add(AuroraUtils.FormatNumberToDigits(class780.gclass228_0.Component.decimal_2, 2)
                    .ToString());
                // ISSUE: reference to a compiler-generated field
                if (class780.gclass228_0.decimal_6 > 0M)
                {
                    // ISSUE: reference to a compiler-generated field
                    listViewItem2.SubItems.Add(
                        string.Format("{0}%",
                            AuroraUtils.FormatNumberToDigits(class780.gclass228_0.decimal_6 * 100M, 1)));
                }
                else
                    listViewItem2.SubItems.Add("-");

                // ISSUE: reference to a compiler-generated field
                if (class780.gclass228_0.decimal_7 > 0M)
                {
                    // ISSUE: reference to a compiler-generated field
                    listViewItem2.SubItems.Add(
                        string.Format("{0}%",
                            AuroraUtils.FormatNumberToDigits(class780.gclass228_0.decimal_7 * 100M, 1)));
                }
                else
                    listViewItem2.SubItems.Add("-");

                // ISSUE: reference to a compiler-generated method
                int num3 = gclass40_0.ComponentDamages.Where<ComponentDamage>(class780.method_0)
                    .Select<ComponentDamage, int>(gclass178_0 => gclass178_0.Number).FirstOrDefault<int>();
                if (num3 > 0)
                {
                    listViewItem2.SubItems.Add(num3.ToString());
                    listViewItem2.SubItems[5].ForeColor = Color.Red;
                }
                else
                    listViewItem2.SubItems.Add("-");

                // ISSUE: reference to a compiler-generated field
                listViewItem2.Tag = class780.gclass228_0;
                listView_0.Items.Add(listViewItem2);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2880);
        }
    }

    public void method_66(ListBox listBox_0)
    {
        try
        {
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.Class == this)
                .OrderBy<ShipData, string>(gclass40_0 => gclass40_0.ShipName).ToList<ShipData>();
            listBox_0.DataSource = list;
            listBox_0.DisplayMember = "ShipName";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2881);
        }
    }

    public void method_67(ComboBox comboBox_0)
    {
        try
        {
            List<ShipClass> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.Class.ParasiteCapacity > this.Size)
                .Where<ShipData>(gclass40_0 => gclass40_0.method_125() > this.Size)
                .Select<ShipData, ShipClass>(gclass40_0 => gclass40_0.Class).Distinct<ShipClass>()
                .OrderBy<ShipClass, string>(gclass22_0 => gclass22_0.ClassName).ToList<ShipClass>();
            comboBox_0.DataSource = list;
            comboBox_0.DisplayMember = "ClassName";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3364);
        }
    }

    public void method_68(ComboBox comboBox_0)
    {
        try
        {
            List<FCTSquadronData70> list = this.gclass0_0.Ships.Values
                .SelectMany<ShipData, FCTSquadronData70>(gclass40_0 => gclass40_0.ChildSquadronDictionary.Values)
                .Distinct<FCTSquadronData70>().OrderBy<FCTSquadronData70, string>(gclass70_0 => gclass70_0.SquadronName)
                .ToList<FCTSquadronData70>();
            comboBox_0.DataSource = list;
            comboBox_0.DisplayMember = "SquadronName";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3574);
        }
    }

    public void method_69(ListView listView_0, GEnum18 genum18_0)
    {
        try
        {
            listView_0.Items.Clear();
            List<ShipData> source = this.method_36();
            List<ShipData> gclass40List = new List<ShipData>();
            listView_0.Items.Add(new ListViewItem("Ship Name")
            {
                SubItems =
                {
                    "Fleet",
                    "System",
                    "Launch Date",
                    "Fuel",
                    "Ammo",
                    "MSP",
                    "Maint Clock",
                    "Crew Clock"
                }
            });
            switch (genum18_0)
            {
                case GEnum18.const_5:
                    gclass40List = source.OrderBy<ShipData, string>(gclass40_0 => gclass40_0.ShipName)
                        .ToList<ShipData>();
                    break;
                case GEnum18.const_6:
                    gclass40List = source.OrderBy<ShipData, string>(gclass40_0 => gclass40_0.gclass85_0.FleetName)
                        .ToList<ShipData>();
                    break;
                case GEnum18.const_7:
                    gclass40List = source
                        .OrderBy<ShipData, string>(gclass40_0 => gclass40_0.gclass85_0.System.Name)
                        .ToList<ShipData>();
                    break;
                case GEnum18.const_8:
                    gclass40List = source.OrderBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_1)
                        .ToList<ShipData>();
                    break;
                case GEnum18.const_9:
                    gclass40List = source.OrderBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_6)
                        .ToList<ShipData>();
                    break;
                case GEnum18.const_10:
                    gclass40List = source.OrderBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_7)
                        .ToList<ShipData>();
                    break;
                case GEnum18.const_11:
                    gclass40List = source.OrderBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_14)
                        .ToList<ShipData>();
                    break;
            }

            foreach (ShipData gclass40 in gclass40List)
            {
                ListViewItem listViewItem = new ListViewItem(gclass40.method_187());
                listViewItem.SubItems.Add(gclass40.gclass85_0.FleetName);
                listViewItem.SubItems.Add(gclass40.gclass85_0.System.Name);
                listViewItem.SubItems.Add(this.gclass0_0.method_583((double)gclass40.decimal_1));
                if (this.FuelCapacity > 0)
                    listViewItem.SubItems.Add(
                        string.Format("{0}%", AuroraUtils.smethod_39(gclass40.decimal_14 / this.FuelCapacity * 100M)));
                else
                    listViewItem.SubItems.Add("N/A");
                if (this.MagazineCapacity + this.DecoyCapacity > 0M)
                    listViewItem.SubItems.Add(string.Format("{0}%", AuroraUtils.smethod_38(gclass40.method_212())));
                else
                    listViewItem.SubItems.Add("N/A");
                if (this.MaintSupplies > 0)
                    listViewItem.SubItems.Add(
                        string.Format("{0}%", AuroraUtils.smethod_38(gclass40.decimal_4 / this.MaintSupplies * 100M)));
                else
                    listViewItem.SubItems.Add("NA");
                listViewItem.SubItems.Add(AuroraUtils
                    .FormatNumberToDigits((this.gclass0_0.GameTime - gclass40.decimal_6) / AuroraUtils.decimal_29, 2)
                    .ToString());
                listViewItem.SubItems.Add(AuroraUtils
                    .FormatNumberToDigits((this.gclass0_0.GameTime - gclass40.decimal_7) / AuroraUtils.decimal_29, 2)
                    .ToString());
                listViewItem.Tag = gclass40;
                listView_0.Items.Add(listViewItem);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2882);
        }
    }

    public void method_70(ListBox listBox_0)
    {
        try
        {
            List<ClassComponent> list = this.ClassComponents.Values
                .OrderBy<ClassComponent, string>(gclass228_0 => gclass228_0.Component.Name).ToList<ClassComponent>();
            foreach (ClassComponent gclass228 in list)
                gclass228.Description =
                    string.Format("{0}x {1}", Math.Round(gclass228.NumComponent, 1).ToString(),
                        gclass228.Component.Name);
            listBox_0.DataSource = list;
            listBox_0.DisplayMember = "Description";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2883);
        }
    }

    public void method_71(TreeView treeView_0)
    {
        try
        {
            treeView_0.Nodes.Clear();
            foreach (ClassSummaryType gclass232 in this.ClassComponents.Values
                         .Select<ClassComponent, ComponentTypeData>(gclass228_0 => gclass228_0.Component.Data)
                         .Distinct<ComponentTypeData>().ToList<ComponentTypeData>()
                         .Select<ComponentTypeData, ClassSummaryType>(gclass231_0 => gclass231_0.ClassSummaryType).Distinct<ClassSummaryType>()
                         .OrderBy<ClassSummaryType, string>(gclass232_0 => gclass232_0.string_0).ToList<ClassSummaryType>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                ShipClass.Class781 class781 = new ShipClass.Class781();
                // ISSUE: reference to a compiler-generated field
                class781.gclass232_0 = gclass232;
                TreeNode node1 = new TreeNode();
                // ISSUE: reference to a compiler-generated field
                node1.Text = class781.gclass232_0.string_0;
                // ISSUE: reference to a compiler-generated field
                node1.Tag = class781.gclass232_0;
                // ISSUE: reference to a compiler-generated method
                foreach (ClassComponent gclass228 in this.ClassComponents.Values.Where<ClassComponent>(class781.method_0)
                             .ToList<ClassComponent>()
                             .OrderBy<ClassComponent, string>(gclass228_0 => gclass228_0.Component.Name)
                             .ToList<ClassComponent>())
                {
                    TreeNode node2 = new TreeNode();
                    gclass228.Description =
                        string.Format("{0}x {1}", Math.Round(gclass228.NumComponent, 1).ToString(),
                            gclass228.Component.method_0());
                    node2.Text = gclass228.Description;
                    node2.Tag = gclass228;
                    if (!gclass228.Component.gclass164_0.dictionary_0.ContainsKey(this.Race.RaceID))
                        node2.ForeColor = Color.Red;
                    else if (gclass228.Component.gclass164_0.dictionary_0[this.Race.RaceID].Obsolete)
                        node2.ForeColor = Color.Orange;
                    else if (gclass228.Component.Data.ComponentTypeID == AuroraComponentType.Armour &&
                             gclass228.Component.int_0 != 65275 && this.Race.method_387(TechType.Armour) !=
                             gclass228.Component.gclass164_0)
                        node2.ForeColor = Color.Orange;
                    node1.Nodes.Add(node2);
                }

                treeView_0.Nodes.Add(node1);
                // ISSUE: reference to a compiler-generated field
                if (class781.gclass232_0.bool_1)
                    node1.Expand();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2884);
        }
    }

    public Decimal method_72(AuroraComponentType auroraComponentType_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class782 class782 = new ShipClass.Class782();
        // ISSUE: reference to a compiler-generated field
        class782.auroraComponentType_0 = auroraComponentType_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.ClassComponents.Values.Where<ClassComponent>(class782.method_0).Sum<ClassComponent>(gclass228_0 =>
                gclass228_0.Component.decimal_3 * gclass228_0.NumComponent);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2885);
            return 0M;
        }
    }

    public Decimal method_73(AuroraComponentType auroraComponentType_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class783 class783 = new ShipClass.Class783();
        // ISSUE: reference to a compiler-generated field
        class783.auroraComponentType_0 = auroraComponentType_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.ClassComponents.Values.Where<ClassComponent>(class783.method_0)
                .Sum<ClassComponent>(gclass228_0 => gclass228_0.NumComponent);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2886);
            return 0M;
        }
    }

    public List<ClassComponent> method_74(AuroraComponentType auroraComponentType_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class784 class784 = new ShipClass.Class784();
        // ISSUE: reference to a compiler-generated field
        class784.auroraComponentType_0 = auroraComponentType_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.ClassComponents.Values.Where<ClassComponent>(class784.method_0).ToList<ClassComponent>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2887);
            return null;
        }
    }

    public void method_75(AuroraComponentType auroraComponentType_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShipClass.Class785 class785 = new ShipClass.Class785();
        // ISSUE: reference to a compiler-generated field
        class785.auroraComponentType_0 = auroraComponentType_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (int key in this.ClassComponents.Where<KeyValuePair<int, ClassComponent>>(class785.method_0)
                         .Select<KeyValuePair<int, ClassComponent>, int>(keyValuePair_0 => keyValuePair_0.Key).ToList<int>())
                this.ClassComponents.Remove(key);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2888);
        }
    }

    public ClassComponent method_76()
    {
        try
        {
            List<ClassComponent> gclass228List = this.method_74(AuroraComponentType.Armour);
            return gclass228List.Count > 0 ? gclass228List[0] : null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2889);
            return null;
        }
    }

    public ClassComponent method_77()
    {
        try
        {
            List<ClassComponent> gclass228List = this.method_74(AuroraComponentType.Shields);
            return gclass228List.Count > 0 ? gclass228List[0] : null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2890);
            return null;
        }
    }

    public int method_78()
    {
        try
        {
            int num = 0;
            foreach (ShipComponent gclass230 in this.ClassComponents.Values
                         .Where<ClassComponent>(gclass228_0 =>
                             gclass228_0.Component.Data.ComponentTypeID ==
                             AuroraComponentType.CrewQuarters)
                         .Select<ClassComponent, ShipComponent>(gclass228_0 => gclass228_0.Component).ToList<ShipComponent>())
                num += (int)gclass230.decimal_3;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2891);
            return 0;
        }
    }

    public void method_79(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            Decimal decimal_73_1 = AuroraUtils.smethod_62(this.PlannedDeployment, 1.0 / 3.0) * this.CrewDesignEfficiency;
            if (decimal_73_1 == 0M)
                return;
            Decimal decimal_73_2 = AuroraUtils.decimal_17 / decimal_73_1;
            Decimal decimal_73_3 = this.Crew / decimal_73_2;
            Decimal decimal_73_4 = this.int_59 / AuroraUtils.decimal_17;
            Decimal decimal_73_5 = Math.Floor((decimal_73_4 - decimal_73_3) * AuroraUtils.decimal_17 / decimal_73_1);
            Decimal decimal_73_6 = this.ClassComponents.Values
                .Where<ClassComponent>(gclass228_0 =>
                    gclass228_0.Component.Data.ComponentTypeID ==
                    AuroraComponentType.ColonistTransport && gclass228_0.Component.genum87_0 == GEnum87.const_0)
                .Sum<ClassComponent>(gclass228_0 => gclass228_0.Component.decimal_3 * gclass228_0.NumComponent);
            Decimal decimal_73_7 = this.ClassComponents.Values
                .Where<ClassComponent>(gclass228_0 =>
                    gclass228_0.Component.Data.ComponentTypeID ==
                    AuroraComponentType.ColonistTransport && gclass228_0.Component.genum87_0 == GEnum87.const_7)
                .Sum<ClassComponent>(gclass228_0 => gclass228_0.Component.decimal_3 * gclass228_0.NumComponent);
            this.gclass0_0.method_597(listView_0, "Crew Quarter Design Efficiency",
                string.Format("{0}%", AuroraUtils.FormatNumberToDigits((1M - this.CrewDesignEfficiency) * 100M, 0)));
            this.gclass0_0.method_597(listView_0, "Crew Quarter Tons per Man", AuroraUtils.FormatNumberToDigits(decimal_73_1, 2));
            this.gclass0_0.method_597(listView_0, "Crew Capacity per Crew Quarter HS",
                AuroraUtils.FormatNumberToDigits(decimal_73_2, 2));
            this.gclass0_0.method_597(listView_0, "Total Crew HS Required", AuroraUtils.FormatNumberToDigits(decimal_73_3, 2));
            this.gclass0_0.method_597(listView_0, "Crew HS Available", AuroraUtils.FormatNumberToDigits(decimal_73_4, 2));
            this.gclass0_0.method_597(listView_0, "Crew Berths", AuroraUtils.smethod_37(this.Crew));
            this.gclass0_0.method_597(listView_0, "Spare Berths", AuroraUtils.smethod_38(decimal_73_5));
            this.gclass0_0.method_597(listView_0, "Cryogenic Berths", AuroraUtils.smethod_38(decimal_73_6));
            this.gclass0_0.method_597(listView_0, "Colonist Berths", AuroraUtils.smethod_38(decimal_73_7));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2892);
        }
    }

    public Decimal method_80(int int_69)
    {
        try
        {
            return (Decimal)(int_69 * Math.Pow((double)this.PlannedDeployment, 1.0 / 3.0)) * this.CrewDesignEfficiency;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2893);
            return 0M;
        }
    }

    public void method_81()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            ShipClass.Class786 class786 = new ShipClass.Class786();
            this.int_59 = 0;
            if (this.Crew == 0)
                this.Crew = 1;
            this.int_60 = (int)this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 =>
                    gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.HangarDeck ||
                    gclass228_0.Component.Data.ComponentTypeID ==
                    AuroraComponentType.CommercialHangarDeck)
                .Sum<ClassComponent>(gclass228_0 => gclass228_0.Component.decimal_3 * gclass228_0.NumComponent);
            int int_69 = this.Crew + this.int_60;
            Decimal num1 = this.method_80(int_69);
            if (num1 < 1M)
                num1 = 1M;
            if (this.PlannedDeployment < 3M)
                num1 = (Decimal)(int_69 * Math.Pow(3.0, 1.0 / 3.0)) * this.Race.CrewDesignEfficiency;
            // ISSUE: reference to a compiler-generated field
            class786.int_0 = 1;
            if (num1 < 5M)
            {
                // ISSUE: reference to a compiler-generated field
                class786.int_0 = 0;
            }

            // ISSUE: reference to a compiler-generated method
            List<ShipComponent> list = this.gclass0_0.ComponentDataDictionary.Values.Where<ShipComponent>(class786.method_0)
                .ToList<ShipComponent>().OrderByDescending<ShipComponent, Decimal>(gclass230_0 => gclass230_0.decimal_3)
                .ToList<ShipComponent>();
            this.method_75(AuroraComponentType.CrewQuarters);
            int num2 = 0;
            foreach (ShipComponent gclass230 in list)
            {
                ++num2;
                int num3 = (int)(num1 / gclass230.decimal_3);
                if (num2 == list.Count && num3 * gclass230.decimal_3 < num1)
                    ++num3;
                if (num3 > 0)
                {
                    ClassComponent gclass228 = new ClassComponent();
                    gclass228.Component = gclass230;
                    gclass228.NumComponent = num3;
                    gclass228.ComponentID = gclass230.int_0;
                    gclass228.ClassID = this.ShipClassID;
                    this.ClassComponents.Add(gclass228.ComponentID, gclass228);
                    this.int_59 += (int)(num3 * gclass230.decimal_3);
                    num1 -= (int)(num3 * gclass230.decimal_3);
                    if (num1 == 0M)
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2894);
        }
    }

    public void method_82()
    {
        try
        {
            this.Crew = 0;
            this.Size = 0M;
            this.Cost = 0M;
            this.int_26 = 0;
            foreach (ClassComponent gclass228 in this.ClassComponents.Values)
            {
                this.Size += gclass228.Component.decimal_1 * gclass228.NumComponent;
                this.Cost += gclass228.Component.decimal_2 * gclass228.NumComponent;
                this.Crew += (int)(gclass228.Component.int_1 * gclass228.NumComponent);
                this.int_26 += (int)(gclass228.Component.int_4 * gclass228.NumComponent);
                if (gclass228.Component.decimal_2 > this.decimal_7 &&
                    gclass228.Component.Data.ComponentTypeID != AuroraComponentType.Armour)
                    this.decimal_7 = gclass228.Component.decimal_2;
            }

            if (this.PlannedDeployment < 3M)
                this.Crew = (int)Math.Floor(this.Crew *
                                              (Math.Pow((double)this.PlannedDeployment, 1.0 / 3.0) / Math.Pow(3.0, 1.0 / 3.0)));
            if (this.Crew >= 1)
                return;
            this.Crew = 1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2895);
        }
    }

    public void method_83()
    {
        try
        {
            if (this.NoArmour == 1)
            {
                foreach (ClassComponent gclass228 in this.method_74(AuroraComponentType.Armour))
                    this.ClassComponents.Remove(gclass228.ComponentID);
                foreach (ClassComponent gclass228 in this.method_74(AuroraComponentType.Engine))
                    this.ClassComponents.Remove(gclass228.ComponentID);
                foreach (ClassComponent gclass228 in this.ClassComponents.Values
                             .Where<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_1).ToList<ClassComponent>())
                    this.ClassComponents.Remove(gclass228.ComponentID);
                this.ArmourThickness = 1;
            }
            else
            {
                foreach (ClassComponent gclass228 in this.ClassComponents.Values
                             .Where<ClassComponent>(gclass228_0 => gclass228_0.Component.int_0 == 65275)
                             .ToList<ClassComponent>())
                    this.ClassComponents.Remove(gclass228.ComponentID);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2896);
        }
    }

    public void method_84()
    {
        try
        {
            if (this.ArmourThickness < 1)
                this.ArmourThickness = 1;
            double num = this.ArmourThickness * (Math.Pow(Math.Pow((double)this.Size * 0.75 / Math.PI, 1.0 / 3.0), 2.0) *
                4.0 * Math.PI / 4.0);
            this.ArmourWidth = (int)(num / this.ArmourThickness);
            if (this.ArmourWidth < 1)
                this.ArmourWidth = 1;
            ClassComponent gclass228 = this.method_76();
            int decimal3;
            if (gclass228 != null)
            {
                decimal3 = (int)gclass228.Component.decimal_3;
            }
            else
            {
                ShipComponent gclass230 = this.NoArmour != 1
                    ? this.Race.method_386()
                    : this.gclass0_0.method_717(GEnum118.const_56);
                decimal3 = (int)gclass230.decimal_3;
                gclass228 = new ClassComponent();
                gclass228.Component = gclass230;
                gclass228.ComponentID = gclass230.int_0;
                gclass228.ClassID = this.ShipClassID;
                this.ClassComponents.Add(gclass228.ComponentID, gclass228);
            }

            gclass228.NumComponent = (Decimal)(num / decimal3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2897);
        }
    }

    public void method_85(int int_69, int int_70, string string_8)
    {
        try
        {
            this.method_86(int_69, int_70, string_8, null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2898);
        }
    }

    public void method_86(int int_69, int int_70, string string_8, TreeNode treeNode_0)
    {
        try
        {
            CommanderLevel genum15_0 = CommanderLevel.LVL1;
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string str8 = "";
            string str9 = "";
            string str10 = "";
            string str11 = "";
            string str12 = "";
            string str13 = "";
            string str14 = "";
            string str15 = "";
            string str16 = "";
            string str17 = "";
            string str18 = "";
            bool flag1 = false;
            bool flag2 = true;
            bool flag3 = false;
            bool flag4 = true;
            bool flag5 = false;
            bool flag6 = false;
            bool flag7 = false;
            bool flag8 = false;
            Decimal num1 = 0M;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            this.gclass163_0 = null;
            this.RacialRankTheme = this.Race.GetHighestRankThemeForCommanderType(AuroraCommanderType.Naval);
            this.FighterClass = false;
            this.Commercial = true;
            this.MilitaryEngines = false;
            this.bool_6 = false;
            this.CommercialHangar = false;
            this.MoraleCheckRequired = false;
            this.RecreationalModule = false;
            this.ArkShip = false;
            this.FlagBridge = false;
            this.FuelCapacity = 0;
            this.BioEnergyCapacity = 0;
            this.CargoCapacity = 0;
            this.MagazineCapacity = 0M;
            this.DecoyCapacity = 0M;
            this.GravSurvey = 0;
            this.GeoSurvey = 0M;
            this.PassiveSensorStrength = 0;
            this.ControlRating = 0;
            this.CargoShuttleStrength = 0;
            this.RequiredPower = 0M;
            this.CommercialJumpDrive = 0;
            this.OrdnanceTransferHub = 0;
            this.ActiveJammerStrength = 0M;
            this.SensorReduction = 1M;
            this.int_61 = 0;
            this.MaxSpeed = 1;
            this.EnginePower = 0M;
            this.ProtectionValue = 0M;
            this.DCRating = 0;
            this.ReactorPower = 0M;
            this.int_67 = 0;
            this.TroopCapacity = 0;
            this.ParasiteCapacity = 0M;
            this.ColonistCapacity = 0;
            this.ELINTRating = 0;
            this.DiplomacyRating = 0;
            this.RepairYardCapacity = 0;
            this.EMSensorStrength = 0;
            this.Harvesters = 0;
            this.ActiveSensorStrength = 0;
            this.JGConstructionTime = 0;
            this.MaintModules = 0;
            this.MiningModules = 0;
            this.SalvageRate = 0;
            this.ShieldStrength = 0;
            this.RefuellingRate = 0;
            this.OrdnanceTransferRate = 0;
            this.MaintSupplies = 0;
            this.STSTractor = 0;
            this.Terraformers = 0;
            this.FireControlJammerStrength = 0M;
            this.WorkerCapacity = 0;
            this.ClassThermal = 0M;
            this.FuelEfficiency = 0M;
            this.decimal_7 = 0M;
            this.int_66 = 0;
            this.JumpDistance = 0;
            this.JumpRating = 0;
            this.MissileJammerStrength = 0M;
            this.string_2 = "";
            this.ClassMaterials.ResetToZero();
            this.method_83();
            this.method_82();
            if (this.PlannedDeployment < 3M)
                this.Commercial = false;
            if (this.ClassComponents.Values.Where<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_1)
                    .ToList<ClassComponent>().Count > 0)
            {
                this.Commercial = false;
                this.MoraleCheckRequired = true;
            }

            if (this.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                this.method_81();
            if (this.Size > 22M && !this.ClassComponents.ContainsKey(18))
                this.method_51(this.gclass0_0.ComponentDataDictionary[18], 1);
            this.method_82();
            int num5 = this.ArmourThickness * 3;
            if (num5 < 10)
                num5 = 10;
            for (int index = 1; index < num5; ++index)
            {
                this.method_84();
                this.method_82();
            }

            if (this.Size <= 10M)
                this.FighterClass = true;
            this.BaseFailureChance = this.Size * 10M;
            string str19 =
                string.Format("MSP 0    AFR {0}%    IFR {1}%", ((int)this.BaseFailureChance).ToString(),
                    Math.Round(this.BaseFailureChance / 72M, 1).ToString());
            foreach (ClassComponent gclass228 in this.ClassComponents.Values)
            {
                this.ClassMaterials.method_35(gclass228.Component, gclass228.NumComponent);
                // Decimal num6; //unused, IDK why
                switch (gclass228.Component.Data.ComponentTypeID)
                {
                    case AuroraComponentType.Engine:
                        this.EnginePower += gclass228.method_0();
                        this.MaxSpeed = (int)(this.EnginePower / this.Size * 1000M);
                        if (this.MaxSpeed > 270000)
                            this.MaxSpeed = 270000;
                        this.ClassThermal = this.EnginePower * gclass228.Component.decimal_9;
                        this.FuelEfficiency = gclass228.Component.decimal_8;
                        this.MilitaryEngines = gclass228.Component.bool_1;
                        str1 = gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.FuelStorage:
                        this.FuelCapacity += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.CargoHold:
                        this.CargoCapacity += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.Magazine:
                        this.MagazineCapacity += gclass228.method_0();
                        continue;
                    case AuroraComponentType.GravitationalSurveySensors:
                        this.GravSurvey += (int)gclass228.method_0();
                        if (genum15_0 < CommanderLevel.LVL2)
                            genum15_0 = CommanderLevel.LVL2;
                        str2 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        this.MoraleCheckRequired = true;
                        continue;
                    case AuroraComponentType.GeologicalSurveySensors:
                        this.GeoSurvey += gclass228.method_0();
                        if (genum15_0 < CommanderLevel.LVL2)
                            genum15_0 = CommanderLevel.LVL2;
                        str2 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        this.MoraleCheckRequired = true;
                        continue;
                    case AuroraComponentType.ThermalSensors:
                        if (gclass228.Component.decimal_3 > this.PassiveSensorStrength)
                            this.PassiveSensorStrength = (int)gclass228.Component.decimal_3;
                        this.int_67 += (int)gclass228.Component.decimal_1;
                        if (gclass228.Component.decimal_1 > 1M)
                            this.Commercial = false;
                        str3 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.CommandAndControl:
                        this.ControlRating += (int)gclass228.Component.decimal_3;
                        continue;
                    case AuroraComponentType.Shields:
                        this.ShieldStrength = (int)gclass228.method_0();
                        str5 = gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        int num7 = (int)(gclass228.Component.decimal_7 * gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.CargoShuttleBay:
                        this.CargoShuttleStrength += (int)gclass228.method_0() * this.Race.CargoShuttleLoadModifier;
                        continue;
                    case AuroraComponentType.Laser:
                    case AuroraComponentType.ParticleBeam:
                    case AuroraComponentType.MesonCannon:
                    case AuroraComponentType.Railgun:
                    case AuroraComponentType.Carronade:
                    case AuroraComponentType.HighPowerMicrowave:
                    case AuroraComponentType.GaussCannon:
                        this.RequiredPower += gclass228.Component.decimal_4 * gclass228.NumComponent;
                        this.ProtectionValue += gclass228.Component.decimal_1 * gclass228.NumComponent;
                        flag1 = true;
                        if (gclass228.Component.decimal_0 > gclass228.Component.decimal_4 * 2M)
                        {
                            flag2 = false;
                            continue;
                        }

                        continue;
                    case AuroraComponentType.JumpDrive:
                        if (genum15_0 < CommanderLevel.LVL2)
                            genum15_0 = CommanderLevel.LVL2;
                        this.JumpRating = gclass228.Component.int_10;
                        this.JumpDistance = gclass228.Component.int_9;
                        if (gclass228.Component.genum87_0 == GEnum87.const_2)
                            this.CommercialJumpDrive = 1;
                        if (gclass228.Component.decimal_3 < this.Size)
                            this.string_2 =
                                string.Format("{0}Jump engine is too small for this design{1}", this.string_2,
                                    Environment.NewLine);
                        str6 = gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.ColonistTransport:
                        this.ColonistCapacity += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.PowerPlant:
                        this.ReactorPower += gclass228.method_0();
                        str7 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.BeamFireControl:
                        str8 += gclass228.Component.method_17(int_70, int_69, gclass228.NumComponent);
                        int decimal3 = (int)gclass228.Component.decimal_3;
                        if (decimal3 > this.int_66)
                            this.int_66 = decimal3;
                        flag3 = true;
                        if (gclass228.Component.genum87_0 == GEnum87.const_0)
                        {
                            flag4 = false;
                            continue;
                        }

                        continue;
                    case AuroraComponentType.ElectronicWarfareSystems:
                        if (gclass228.Component.gclass164_0.gclass163_0.TechType == TechType.SensorJammer)
                        {
                            if (this.ActiveJammerStrength < gclass228.Component.decimal_3)
                                this.ActiveJammerStrength = (int)gclass228.Component.decimal_3;
                        }
                        else if (gclass228.Component.gclass164_0.gclass163_0.TechType ==
                                 TechType.FireControlJammer && this.FireControlJammerStrength < gclass228.Component.decimal_3)
                            this.FireControlJammerStrength = (int)gclass228.Component.decimal_3;

                        if (gclass228.Component.gclass164_0.gclass163_0.TechType == TechType.MissileJammer &&
                            this.MissileJammerStrength < gclass228.Component.decimal_3)
                        {
                            this.MissileJammerStrength = (int)gclass228.Component.decimal_3;
                            continue;
                        }

                        continue;
                    case AuroraComponentType.MissileLauncher:
                    case AuroraComponentType.FighterPodBay:
                        this.MagazineCapacity += gclass228.method_0();
                        this.ProtectionValue += gclass228.Component.decimal_1 * gclass228.NumComponent;
                        if (gclass228.Component.decimal_1 > 1M)
                            flag2 = false;
                        str10 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        if (gclass228.Component.Data.ComponentTypeID ==
                            AuroraComponentType.MissileLauncher)
                        {
                            flag5 = true;
                            continue;
                        }

                        continue;
                    case AuroraComponentType.ActiveSearchSensors:
                        if (this.ActiveSensorStrength < gclass228.Component.decimal_3)
                            this.ActiveSensorStrength = (int)gclass228.Component.decimal_3;
                        this.int_67 += (int)gclass228.Component.decimal_1;
                        if (gclass228.Component.decimal_1 > 1M)
                            this.Commercial = false;
                        str11 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.MissileFireControl:
                        if (gclass228.Component.Resolution > 1M)
                            flag4 = false;
                        flag6 = true;
                        str13 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.DamageControl:
                        this.DCRating += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.TroopTransport:
                        if (this.gclass163_0 != gclass228.Component.gclass164_0.gclass163_0 &&
                            this.gclass163_0 != null)
                        {
                            this.string_2 =
                                string.Format(
                                    "{0}Different types of troop transport modules cannot be added to the same ship class{1}",
                                    this.string_2, Environment.NewLine);
                            continue;
                        }

                        this.TroopCapacity += (int)gclass228.method_0();
                        this.gclass163_0 = gclass228.Component.gclass164_0.gclass163_0;
                        continue;
                    case AuroraComponentType.JumpPointStabilisation:
                        this.JGConstructionTime = (int)gclass228.Component.decimal_3;
                        continue;
                    case AuroraComponentType.Engineering:
                        num1 += gclass228.method_0();
                        this.DCRating += (int)gclass228.method_0();
                        Decimal num8 = this.Size * AuroraUtils.decimal_21 / num1;
                        this.BaseFailureChance = this.Size / 2M * num8;
                        num4 = (int)(1M / num8 * (this.Cost / 2M));
                        this.MaintSupplies = num4 + num3;
                        if (this.Commercial && num1 > 0M)
                        {
                            str19 = string.Format("MSP {0}", AuroraUtils.smethod_37(this.MaintSupplies));
                            continue;
                        }

                        var out1 = Math.Round(this.BaseFailureChance);
                        var out2 = Math.Round(this.BaseFailureChance / 72M, 1);
                        str19 = string.Format("MSP {0}   AFR {1}%   AFR {2}%", AuroraUtils.smethod_37(MaintSupplies),
                            out1, out2);
                        continue;
                    case AuroraComponentType.SoriumHarvester:
                        this.Harvesters = (int)gclass228.NumComponent;
                        continue;
                    case AuroraComponentType.TerraformingModule:
                        this.Terraformers = (int)gclass228.NumComponent;
                        continue;
                    case AuroraComponentType.TractorBeam:
                        if (gclass228.NumComponent > 1M)
                            this.string_2 =
                                string.Format("{0}Only one tractor beam per ship is allowed{1}", this.string_2,
                                    Environment.NewLine);
                        this.STSTractor = 1;
                        continue;
                    case AuroraComponentType.OrbitalMiningModule:
                        this.MiningModules = (int)gclass228.NumComponent;
                        continue;
                    case AuroraComponentType.SalvageModule:
                        num2 = (int)gclass228.NumComponent;
                        this.SalvageRate = (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.EMSensors:
                        if (gclass228.Component.decimal_3 > this.EMSensorStrength)
                            this.EMSensorStrength = (int)gclass228.Component.decimal_3;
                        this.int_67 += (int)gclass228.Component.decimal_1;
                        if (gclass228.Component.decimal_1 > 1M)
                            this.Commercial = false;
                        str3 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.HangarDeck:
                        this.ParasiteCapacity += gclass228.method_0();
                        if (genum15_0 < CommanderLevel.LVL2)
                        {
                            genum15_0 = CommanderLevel.LVL2;
                            continue;
                        }

                        continue;
                    case AuroraComponentType.CloakingDevice:
                        if (gclass228.Component.decimal_3 >= this.Size)
                        {
                            this.SensorReduction = gclass228.Component.decimal_10;
                            continue;
                        }

                        this.string_2 =
                            string.Format("{0}Cloaking Device Ship Size is too small for this design{1}", this.string_2,
                                Environment.NewLine);
                        continue;
                    case AuroraComponentType.MaintenanceStorage:
                        num3 += (int)gclass228.method_0();
                        this.MaintSupplies = num4 + num3;
                        if (this.Commercial && num1 > 0M)
                        {
                            str19 = string.Format("MSP {0}", AuroraUtils.smethod_37(this.MaintSupplies));
                            continue;
                        }

                        str19 = string.Format("MSP {0}   AFR {1}%   AFR {2}%", AuroraUtils.smethod_37(MaintSupplies),
                            Math.Round(this.BaseFailureChance), Math.Round(this.BaseFailureChance / 72M, 1));
                        continue;
                    case AuroraComponentType.MaintenanceModule:
                        this.MaintModules = (int)gclass228.NumComponent;
                        continue;
                    case AuroraComponentType.PassengerModule:
                        this.int_61 += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.RecreationalModule:
                        this.RecreationalModule = true;
                        continue;
                    case AuroraComponentType.CommercialHangarDeck:
                        this.ParasiteCapacity += gclass228.method_0();
                        this.CommercialHangar = true;
                        continue;
                    case AuroraComponentType.CommercialDamageControl:
                        this.DCRating += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.RefuellingSystem:
                        this.RefuellingRate = (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.OrdnanceTransferSystem:
                        this.OrdnanceTransferRate = (int)gclass228.Component.decimal_3;
                        continue;
                    case AuroraComponentType.OrdnanceTransferHub:
                        this.OrdnanceTransferHub = (int)gclass228.NumComponent;
                        if (this.OrdnanceTransferHub > 1)
                        {
                            this.OrdnanceTransferHub = 1;
                            continue;
                        }

                        continue;
                    case AuroraComponentType.ELINTModule:
                        this.ELINTRating = (int)gclass228.method_0();
                        str4 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    case AuroraComponentType.DiplomacyModule:
                        this.DiplomacyRating = (int)gclass228.Component.decimal_3;
                        continue;
                    case AuroraComponentType.BioEnergyStorage:
                        this.BioEnergyCapacity += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.MiscellaneousComponent:
                        if (gclass228.NumComponent > 1M)
                        {
                            str12 = string.Format("{0}{1}x {2}    ", str12, gclass228.NumComponent.ToString(),
                                gclass228.Component.Name);
                            continue;
                        }

                        str12 = string.Format("{0}{1}    ", str12, gclass228.Component.Name);
                        continue;
                    case AuroraComponentType.MobileRepairBay:
                        this.RepairYardCapacity += (int)gclass228.method_0();
                        continue;
                    case AuroraComponentType.DecoyMissileLauncher:
                        this.DecoyCapacity += gclass228.method_0();
                        str10 += gclass228.Component.GetComponentSpecLine(gclass228.NumComponent);
                        continue;
                    default:
                        continue;
                }
            }

            this.ClassCrossSection = this.Size * this.SensorReduction;
            if (this.ClassCrossSection < (Decimal)AuroraUtils.double_20)
                this.ClassCrossSection = (Decimal)AuroraUtils.double_20;
            if (this.RequiredPower > this.ReactorPower)
                this.string_2 =
                    string.Format("{0}Reactors are generating insufficient power for the weapons ({1}/{2}){3}",
                        this.string_2, this.ReactorPower.ToString(), this.RequiredPower.ToString(),
                        Environment.NewLine);
            if (flag2 && flag4)
                this.bool_6 = true;
            int int_25 = (int)this.Race.method_388(this.gclass0_0.TechTypeDataDictionary[TechType.FireControlSpeedRating])
                .decimal_0;
            if (this.MaxSpeed > int_25)
                int_25 = this.MaxSpeed;
            foreach (ClassComponent gclass228 in this.ClassComponents.Values
                         .Where<ClassComponent>(gclass228_0 =>
                             gclass228_0.Component.bool_4 ||
                             gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.CIWS)
                         .OrderByDescending<ClassComponent, int>(gclass228_0 => gclass228_0.Component.method_5(1000))
                         .ToList<ClassComponent>())
                str9 += gclass228.Component.method_8(gclass228.NumComponent, this.int_66, int_25, int_70, this.int_49);
            this.method_90();
            this.method_91();
            if (!this.Commercial)
                this.method_89();
            if (this.Commercial && num1 < 1M)
            {
                this.string_2 =
                    string.Format("{0}Commercial designs require at least one HS (50 tons) of Engineering{1}",
                        this.string_2, Environment.NewLine);
                this.Commercial = false;
            }

            if (flag3 && !flag1)
                this.string_2 = string.Format("{0}Ship has beam fire control but no beam weapons{1}", this.string_2,
                    Environment.NewLine);
            if (!flag3 && flag1)
                this.string_2 = string.Format("{0}Ship has beam weapons but no beam fire control{1}", this.string_2,
                    Environment.NewLine);
            if (flag6 && !flag5)
                this.string_2 =
                    string.Format("{0}Ship has missile fire control weapons but no missile launchers{1}", this.string_2,
                        Environment.NewLine);
            if (!flag6 && flag5)
                this.string_2 =
                    string.Format("{0}Ship has missile launchers but no missile fire control{1}", this.string_2,
                        Environment.NewLine);
            if (!this.ClassComponents.ContainsKey(18) && this.Size > 20M)
                this.string_2 = string.Format("{0}Ship has no bridge{1}", this.string_2, Environment.NewLine);
            if (this.FuelTanker == 1 && this.MinimumFuel == 0 && this.EnginePower > 0M)
                this.string_2 = string.Format("{0}Minimum fuel set to zero{1}", this.string_2, Environment.NewLine);
            if (this.RefuellingRate > 0 && this.RefuellingRate < 20000 && this.Size > 20M)
            {
                this.RefuellingRate = 0;
                this.string_2 =
                    string.Format("{0}Small Craft Refuelling System can only be used on ships of 1000 tons or less{1}",
                        this.string_2, Environment.NewLine);
            }

            Decimal num9 = 0M;
            foreach (ShipOrdnance gclass130 in this.OrdnanceTemplate)
            {
                str14 += gclass130.method_1();
                if (gclass130.RaceMissile.ShipDecoy == 0)
                    num9 += gclass130.RaceMissile.Size * gclass130.Amount;
            }

            if (num9 > this.MagazineCapacity)
                this.string_2 += "Total ordnance exceeds magazine capacity";
            foreach (ClassFighterTemplate gclass74 in this.FighterClassTemplates)
                str15 += gclass74.method_0();
            if (str15 != "")
                flag7 = true;
            List<ClassGroundTemplate> list = this.GroundUnitTemplates.OrderBy<ClassGroundTemplate, string>(gclass75_0 => gclass75_0.GroundUnitTemplate.Name)
                .ToList<ClassGroundTemplate>();
            if (list.Count > 0)
                flag8 = true;
            foreach (ClassGroundTemplate gclass75 in list)
                str15 = string.Format("{0}{1}x {2}{3}", str15, gclass75.Number.ToString(), gclass75.GroundUnitTemplate.Name,
                    Environment.NewLine);
            string str20;
            if (this.Race.BioShips)
            {
                this.Crew = 0;
                str20 = string.Format("{0}Biological Organism - No Crew, Maintenance or Fuel Required    ", str16);
            }
            else
                str20 = !(this.PlannedDeployment >= 1M)
                    ? string.Format("{0}Intended Deployment Time: {1} days    ", str16,
                        AuroraUtils.FormatNumberToDigits(this.PlannedDeployment * 30M, 1))
                    : string.Format("{0}Intended Deployment Time: {1} months    ", str16,
                        this.PlannedDeployment.ToString());

            if (this.int_60 > 0)
                str20 = string.Format("{0}Flight Crew Berths {1}    ", str20, AuroraUtils.smethod_37(this.int_60));
            if (this.CrewDesignEfficiency < 1M)
                str20 = string.Format("{0}CDE {1}%    ", str20,
                    AuroraUtils.FormatNumberToDigits((1M - this.CrewDesignEfficiency) * 100M, 0));
            if (this.MoraleCheckRequired && this.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                str20 += "Morale Check Required    ";
            if (this.Size <= 20M && this.ControlRating == 0)
                this.ControlRating = 1;
            string str21 = string.Format("Control Rating {0}   ", this.ControlRating.ToString());
            if (this.ClassComponents.ContainsKey(18))
                str21 += "BRG   ";
            if (this.ProtectionValue > 0M)
                genum15_0 = CommanderLevel.LVL2;
            if (this.Size <= 20M)
                genum15_0 = CommanderLevel.LVL1;
            if (this.ClassComponents.ContainsKey(65736))
            {
                str21 += "AUX   ";
                if (genum15_0 < CommanderLevel.LVL2)
                    genum15_0 = CommanderLevel.LVL2;
            }

            if (this.ClassComponents.ContainsKey(65737))
            {
                str21 += "ENG   ";
                if (genum15_0 < CommanderLevel.LVL3)
                    genum15_0 = CommanderLevel.LVL3;
            }

            if (this.ClassComponents.ContainsKey(65738))
            {
                str21 += "CIC   ";
                if (genum15_0 < CommanderLevel.LVL3)
                    genum15_0 = CommanderLevel.LVL3;
            }

            if (this.ClassComponents.ContainsKey(65739))
            {
                str21 += "SCI   ";
                if (genum15_0 < CommanderLevel.LVL2)
                    genum15_0 = CommanderLevel.LVL2;
            }

            if (this.ClassComponents.ContainsKey(225))
            {
                str21 += "FLG   ";
                this.FlagBridge = true;
                if (genum15_0 < CommanderLevel.LVL3)
                    genum15_0 = CommanderLevel.LVL3;
            }

            if (this.ClassComponents.ContainsKey(65740))
            {
                str21 += "PFC   ";
                if (genum15_0 < CommanderLevel.LVL2)
                    genum15_0 = CommanderLevel.LVL2;
            }

            if (this.ClassComponents.ContainsKey(65902))
            {
                str21 += "DIP   ";
                if (genum15_0 < CommanderLevel.LVL3)
                    genum15_0 = CommanderLevel.LVL3;
            }

            if (this.SeniorCO == 1)
                ++genum15_0;
            this.RacialRankTheme = this.Race.GetRankThemeForCommanderLevel(genum15_0, AuroraCommanderType.Naval);
            string str22 = string.Format("{0}    {1}", this.RacialRankTheme.RankName, str21);
            if (this.ParasiteCapacity > 0M)
                str17 = string.Format("{0}Hangar Deck Capacity {1} tons     ", str17,
                    AuroraUtils.smethod_38(this.ParasiteCapacity * 50M));
            if (this.TroopCapacity > 0)
                str17 = string.Format("{0}Troop Capacity {1} tons     ", str17,
                    AuroraUtils.smethod_37(this.TroopCapacity));
            if (this.gclass163_0 != null)
            {
                if (this.gclass163_0.TechType == TechType.TroopTransportDropshipEquipped)
                    str17 += "Drop Capable    ";
                if (this.gclass163_0.TechType == TechType.TroopTransportBoardingEquipped)
                    str17 += "Boarding Capable    ";
            }

            if (this.MagazineCapacity > 0M || this.DecoyCapacity > 0M)
                str17 =
                    string.Format("{0}Magazine {1} / {2}    ", str17,
                        AuroraUtils.FormatNumberToDigits(this.MagazineCapacity, 2),
                        AuroraUtils.FormatNumberToDigits(this.DecoyCapacity, 2));
            if (this.CargoCapacity > 0)
                str17 = string.Format("{0}Cargo {1}    ", str17, AuroraUtils.smethod_37(this.CargoCapacity));
            if (this.ColonistCapacity > 0)
            {
                Decimal decimal_73 = this.ClassComponents.Values
                    .Where<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.Data.ComponentTypeID ==
                        AuroraComponentType.ColonistTransport && gclass228_0.Component.genum87_0 == GEnum87.const_7)
                    .Sum<ClassComponent>(gclass228_0 => gclass228_0.Component.decimal_3 * gclass228_0.NumComponent);
                if (decimal_73 > 0M)
                    this.ArkShip = true;
                str17 = !(decimal_73 == 0M)
                    ? (!(decimal_73 == this.ColonistCapacity)
                        ? string.Format("{0}Cryogenic Berths {1}    ",
                            string.Format("{0}Colonist Berths {1}    ", str17, AuroraUtils.smethod_38(decimal_73)),
                            AuroraUtils.smethod_38(this.ColonistCapacity - decimal_73))
                        : string.Format("{0}Colonist Berths {1}    ", str17,
                            AuroraUtils.smethod_37(this.ColonistCapacity)))
                    : string.Format("{0}Cryogenic Berths {1}    ", str17,
                        AuroraUtils.smethod_37(this.ColonistCapacity));
            }

            if (this.WorkerCapacity > 0)
                str17 = string.Format("{0}Habitation Capacity {1}    ", str17,
                    AuroraUtils.smethod_37(this.WorkerCapacity));
            if (this.int_61 > 0)
                str17 = string.Format("{0}Passengers {1}    ", str17, this.int_61.ToString());
            if (this.CargoShuttleStrength > 0)
                str17 = string.Format("{0}Cargo Shuttle Multiplier {1}    ", str17,
                    this.CargoShuttleStrength.ToString());
            if (this.STSTractor > 0)
                str17 += "Tractor Beam     ";
            if (str17 != "")
                str17 += Environment.NewLine;
            if (this.ShipHull == null)
                str18 = this.ClassName;
            string str23 = AuroraUtils.smethod_38(Math.Ceiling(this.Size * AuroraUtils.decimal_17));
            string str24;
            if (string_8 == "")
            {
                string str25 = string.Format("{0} class {1}", this.ClassName, this.ShipHull.Description);
                if (this.method_28())
                {
                    str25 += " (P)";
                    if (treeNode_0 != null)
                        treeNode_0.Text = string.Format("{0} (P)", this.ClassName);
                }
                else if (treeNode_0 != null)
                    treeNode_0.Text = this.ClassName;

                str24 =
                    string.Format("{0}      {1} tons       {2} Crew       {3} BP       TCS {4}    TH {5}    EM {6}{7}",
                        str25, str23, AuroraUtils.smethod_37(this.Crew), AuroraUtils.FormatNumberToDigits(this.Cost, 1),
                        AuroraUtils.smethod_38(this.ClassCrossSection), AuroraUtils.smethod_38(this.ClassThermal),
                        AuroraUtils.smethod_38(this.ShieldStrength * AuroraUtils.decimal_27), Environment.NewLine);
            }
            else
                str24 =
                    string.Format(
                        "{0}  ({1} class {2})      {3} tons       {4} Crew       {5} BP       TCS {6}    TH {7}    EM {8}{9}",
                        string_8, this.ClassName, this.ShipHull.Description, str23, AuroraUtils.smethod_37(this.Crew),
                        AuroraUtils.FormatNumberToDigits(this.Cost, 1), AuroraUtils.smethod_38(this.ClassCrossSection),
                        AuroraUtils.smethod_38(this.ClassThermal),
                        AuroraUtils.smethod_38(this.ShieldStrength * AuroraUtils.decimal_27), Environment.NewLine);

            string str26 = string.Format("{0}{1} km/s", str24, this.MaxSpeed.ToString());
            if (this.JumpRating > 0)
                str26 = string.Format("{0}    JR {1}-{2}", str26, this.JumpRating.ToString(),
                    this.JumpDistance.ToString());
            if (this.CommercialJumpDrive == 1)
                str26 += "(C)";
            Decimal num10 = 0M;
            ClassComponent gclass228_1 = this.method_77();
            if (gclass228_1 != null)
                num10 = gclass228_1.Component.decimal_4;
            string str27;
            if (this.NoArmour == 1)
                str27 = string.Format("{0}      No Armour       Shields {1}-{2}     ", str26,
                    this.ShieldStrength.ToString(), num10.ToString());
            else
                str27 =
                    string.Format("{0}      Armour {1}-{2}       Shields {3}-{4}       ", str26,
                        this.ArmourThickness.ToString(), this.ArmourWidth.ToString(), this.ShieldStrength.ToString(),
                        num10.ToString());
            if (this.ELINTRating > this.EMSensorStrength)
                this.EMSensorStrength = this.ELINTRating;
            string str28 =
                string.Format("{0}HTK {1}      Sensors {2}/{3}/{4}/{5}", str27, this.int_26.ToString(),
                    this.PassiveSensorStrength.ToString(), this.EMSensorStrength.ToString(), this.GravSurvey.ToString(),
                    this.GeoSurvey.ToString());
            int num11 = this.method_27();
            string str29 =
                string.Format("{0}      DCR {1}-{2}      PPV {3}{4}", str28, this.DCRating.ToString(), num11.ToString(),
                    AuroraUtils.FormatNumberToDigits(this.ProtectionValue, 2), Environment.NewLine);
            if (this.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
            {
                if (this.Commercial)
                {
                    str29 =
                        string.Format("{0}{1}    Max Repair {2} MSP{3}", str29, str19,
                            AuroraUtils.FormatNumberToDigits(this.decimal_7, 1), Environment.NewLine);
                }
                else
                {
                    Decimal decimal_73 = this.BaseFailureChance / 100M * this.decimal_23;
                    str29 =
                        string.Format("{0}Maint Life {1} Years     {2}    1YR {3}    5YR {4}    Max Repair {5} MSP{6}",
                            str29, this.decimal_22.ToString(), str19, AuroraUtils.smethod_38(decimal_73),
                            AuroraUtils.smethod_38(decimal_73 * 15M),
                            AuroraUtils.FormatNumberToDigits(this.decimal_7, 1), Environment.NewLine);
                }
            }

            string str30 = str29 + str17;
            if (this.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                str30 = str30 + str22 + Environment.NewLine;
            string str31 = str30 + str20 + Environment.NewLine;
            if (this.JGConstructionTime > 0)
                str31 = string.Format("{0}Jump Point Stabilisation: {1} days{2}", str31,
                    this.JGConstructionTime.ToString(), Environment.NewLine);
            if (this.RepairYardCapacity > 0)
                str31 = string.Format("{0}Repair Capacity: {1} tons{2}", str31, this.RepairYardCapacity.ToString(),
                    Environment.NewLine);
            if (this.RecreationalModule)
                str31 = string.Format("{0}Recreational Facilities{1}", str31, Environment.NewLine);
            if (this.Harvesters > 0)
                str31 =
                    string.Format("{0}Fuel Harvester: {1} modules producing {2} litres per annum{3}", str31,
                        this.Harvesters.ToString(), AuroraUtils.smethod_38(this.Race.FuelProduction * this.Harvesters),
                        Environment.NewLine);
            if (this.Terraformers > 0)
                str31 =
                    string.Format("{0}Terraformer: {1} modules producing {2} atm per annum{3}", str31,
                        this.Terraformers.ToString(),
                        AuroraUtils.FormatNumberToDigits(this.Race.TerraformingRate * this.Terraformers, 4),
                        Environment.NewLine);
            if (this.MiningModules > 0)
                str31 =
                    string.Format("{0}Orbital Miner: {1} modules producing {2} tons per mineral per annum{3}", str31,
                        this.MiningModules.ToString(),
                        AuroraUtils.smethod_38(this.Race.MineProduction * this.MiningModules), Environment.NewLine);
            if (this.MaintModules > 0)
                str31 =
                    string.Format("{0}Maintenance Modules: {1} module(s) capable of supporting ships of {2} tons{3}",
                        str31, this.MaintModules.ToString(),
                        AuroraUtils.smethod_38(this.Race.MaintenanceCapacity * this.MaintModules), Environment.NewLine);
            if (num2 > 0)
                str31 =
                    string.Format("{0}Salvager: {1} module(s) capable of salvaging {2} tons per day{3}", str31,
                        num2.ToString(), this.SalvageRate.ToString(), Environment.NewLine);
            if (this.OrdnanceTransferHub > 0)
                str31 =
                    string.Format(
                        "{0}Ordnance Transfer Hub - Capable of transferring ordnance to multiple ships simultaneously{1}",
                        str31, Environment.NewLine);
            if (this.BioEnergyCapacity > 0)
                str31 =
                    string.Format("{0}Bio-Energy Capacity {1} Bio-Joules{2}", str31,
                        AuroraUtils.smethod_37(this.BioEnergyCapacity), Environment.NewLine);
            if (str12 != "")
                str31 = str31 + str12 + Environment.NewLine;
            string str32 = str31 + Environment.NewLine;
            if (str6 != "")
                str32 += str6;
            string str33 = str32 + str1;
            if (this.FuelCapacity > 0)
                str33 += this.method_88();
            if (this.RefuellingRate > 1000)
            {
                string str34 = string.Format("{0}Refuelling Capability: {1} litres per hour", str33,
                    AuroraUtils.smethod_37(this.RefuellingRate));
                if (this.FuelCapacity > 0)
                    str34 = string.Format("{0}     Complete Refuel {1} hours", str34,
                        AuroraUtils.FormatNumberToDigits(this.FuelCapacity / this.RefuellingRate, 1));
                str33 = str34 + Environment.NewLine;
            }

            string str35 = str33 + str5 + Environment.NewLine + str9 + str8 + str7;
            if (str8 != "")
                str35 += Environment.NewLine;
            string str36 = str35 + str10 + str13 + str14;
            if (this.OrdnanceTransferRate > 10)
            {
                string str37 = string.Format("{0}Ordnance Transfer Rate: {1} MSP per hour", str36,
                    AuroraUtils.smethod_37(this.OrdnanceTransferRate));
                if (this.MagazineCapacity > 0M)
                    str37 =
                        string.Format("{0}     Complete Transfer {1} hours", str37,
                            AuroraUtils.FormatNumberToDigits(this.MagazineCapacity / this.OrdnanceTransferRate, 1));
                str36 = str37 + Environment.NewLine;
            }

            if (str14 != "" || str10 != "" || str13 != "")
                str36 += Environment.NewLine;
            string str38 = str36 + str11 + str3 + str2 + str4;
            if (this.SensorReduction < 1M)
                str38 =
                    string.Format("{0}Cloaking Device: Class cross-section reduced to {1}% of normal{2}", str38,
                        (this.SensorReduction * 100M).ToString(), Environment.NewLine);
            if (str3 != "" || str11 != "" || str2 != "" || str4 != "")
                str38 += Environment.NewLine;
            string str39 = "";
            if (this.ActiveJammerStrength > 0M)
                str39 = string.Format("{0}Sensor {1}    ", str39, this.ActiveJammerStrength.ToString());
            if (this.FireControlJammerStrength > 0M)
                str39 = string.Format("{0}Fire Control {1}    ", str39, this.FireControlJammerStrength.ToString());
            if (this.MissileJammerStrength > 0M)
                str39 = string.Format("{0}Missile {1}    ", str39, this.MissileJammerStrength.ToString());
            if (str39 != "")
                str38 = string.Format("{0}Electronic Warfare Jammers:   {1}{2}{3}", str38, str39, Environment.NewLine,
                    Environment.NewLine);
            if (flag7 && flag8)
                str38 = string.Format("{0}Strike Group / Ground Forces{1}{2}{3}", str38, Environment.NewLine, str15,
                    Environment.NewLine);
            else if (flag7)
                str38 = string.Format("{0}Strike Group{1}{2}{3}", str38, Environment.NewLine, str15,
                    Environment.NewLine);
            else if (flag8)
                str38 = string.Format("{0}Ground Forces{1}{2}{3}", str38, Environment.NewLine, str15,
                    Environment.NewLine);
            if (str14 != "")
                str38 =
                    string.Format(
                        "{0}Missile to hit values are target speeds in km/s for 100% / 50% / 25% chance to hit{1}{2}",
                        str38, Environment.NewLine, Environment.NewLine);
            this.string_0 = str38 + this.method_87();
            this.ColonistCapacity += this.int_61;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2899);
        }
    }

    public string method_87()
    {
        try
        {
            string str;
            if (this.Commercial)
            {
                str = string.Format("This design is classed as a Commercial Vessel for maintenance purposes{0}",
                    Environment.NewLine);
                if (this.NoArmour == 1)
                    str =
                        string.Format("{0}This design is classed as a Space Station for construction purposes{1}", str,
                            Environment.NewLine);
            }
            else
                str = !this.FighterClass
                    ? string.Format("This design is classed as a Military Vessel for maintenance purposes{0}",
                        Environment.NewLine)
                    : string.Format(
                        "This design is classed as a Fighter for production, combat and planetary interaction{0}",
                        Environment.NewLine);

            return
                string.Format("{0}This design is classed as a {1} for auto-assignment purposes{2}", str,
                    AuroraUtils.smethod_82(this.MainFunction), Environment.NewLine);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2900);
            return "";
        }
    }

    public string method_88()
    {
        try
        {
            if (!(this.EnginePower > 0M))
                return string.Format("Fuel Capacity {0} Litres    Range N/A{1}",
                    AuroraUtils.smethod_37(this.FuelCapacity), Environment.NewLine);
            Decimal num = this.FuelCapacity / (this.EnginePower * this.FuelEfficiency);
            Decimal decimal_73 = num * (this.MaxSpeed * 3600) / 1000000000M;
            return (int)(num / 24M) < 3
                ? string.Format("Fuel Capacity {0} Litres    Range {1} billion km ({2} hours at full power){3}",
                    AuroraUtils.smethod_37(this.FuelCapacity), AuroraUtils.FormatNumberToDigits(decimal_73, 2),
                    ((int)num).ToString(), Environment.NewLine)
                : string.Format("Fuel Capacity {0} Litres    Range {1} billion km ({2} days at full power){3}",
                    AuroraUtils.smethod_37(this.FuelCapacity), AuroraUtils.FormatNumberToDigits(decimal_73, 1),
                    ((int)(num / 24M)).ToString(), Environment.NewLine);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2901);
            return "";
        }
    }

    public Decimal method_89()
    {
        try
        {
            int num1 = 0;
            Decimal num2 = 0M;
            this.decimal_22 = 0M;
            this.decimal_23 = 0M;
            foreach (ClassComponent gclass228 in this.ClassComponents.Values
                         .OrderBy<ClassComponent, int>(gclass228_0 => gclass228_0.ChanceToHit).ToList<ClassComponent>())
            {
                int num3 = gclass228.ChanceToHit - num1;
                num1 = gclass228.ChanceToHit;
                this.decimal_23 += gclass228.Component.decimal_2 * (num3 / (Decimal)this.MaxDACRoll);
            }

            for (int index = 1; index < 201; ++index)
            {
                Decimal num4 = this.decimal_23 * (this.BaseFailureChance * index / 100M);
                if (!(num2 + num4 > this.MaintSupplies))
                {
                    num2 += num4;
                }
                else
                {
                    Decimal num5 = (this.MaintSupplies - num2) / num4;
                    this.decimal_22 = Math.Round(index - 1 + num5, 2);
                    break;
                }
            }

            return this.decimal_22;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2902);
            return 0M;
        }
    }

    public void method_90()
    {
        try
        {
            this.MainFunction = AuroraClassMainFunction.None;
            if (this.ProtectionValue > 0M)
            {
                Decimal num1 = this.ClassComponents.Values
                    .Where<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.Data.ComponentTypeID == AuroraComponentType.HangarDeck)
                    .Sum<ClassComponent>(gclass228_0 => gclass228_0.Component.decimal_1 * gclass228_0.NumComponent);
                Decimal num2 = this.ClassComponents.Values
                    .Where<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.Data.ComponentTypeID ==
                        AuroraComponentType.GeologicalSurveySensors).Sum<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.decimal_1 * gclass228_0.NumComponent);
                Decimal num3 = this.ClassComponents.Values
                    .Where<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.Data.ComponentTypeID ==
                        AuroraComponentType.GravitationalSurveySensors).Sum<ClassComponent>(gclass228_0 =>
                        gclass228_0.Component.decimal_1 * gclass228_0.NumComponent);
                if (num3 > this.ProtectionValue && num3 >= num2)
                    this.MainFunction = AuroraClassMainFunction.GravSurvey;
                else if (num2 > this.ProtectionValue)
                    this.MainFunction = AuroraClassMainFunction.GeoSurvey;
                else if (num1 > this.ProtectionValue)
                    this.MainFunction = AuroraClassMainFunction.Carrier;
                else if (this.Size > 20M)
                    this.MainFunction = AuroraClassMainFunction.Warship;
                else if (this.Size > 10M)
                {
                    this.MainFunction = AuroraClassMainFunction.FAC;
                }
                else
                {
                    Decimal num4 = this.ClassComponents.Values
                        .Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.Data.ComponentTypeID ==
                            AuroraComponentType.MissileLauncher).Sum<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.decimal_1 * gclass228_0.NumComponent);
                    Decimal num5 = this.ClassComponents.Values
                        .Where<ClassComponent>(gclass228_0 => gclass228_0.Component.bool_4).Sum<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.decimal_1 * gclass228_0.NumComponent);
                    Decimal num6 = this.ClassComponents.Values
                        .Where<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.Data.ComponentTypeID ==
                            AuroraComponentType.FighterPodBay).Sum<ClassComponent>(gclass228_0 =>
                            gclass228_0.Component.decimal_1 * gclass228_0.NumComponent);
                    if (num6 > num4 && num6 > num5)
                        this.MainFunction = AuroraClassMainFunction.GroundSupportFighter;
                    else
                        this.MainFunction = AuroraClassMainFunction.Fighter;
                }
            }
            else if (this.ParasiteCapacity > 20M)
                this.MainFunction = AuroraClassMainFunction.Carrier;
            else if (this.GravSurvey > 0)
                this.MainFunction = AuroraClassMainFunction.GravSurvey;
            else if (this.GeoSurvey > 0M)
                this.MainFunction = AuroraClassMainFunction.GeoSurvey;
            else if (this.TroopCapacity > 0)
                this.MainFunction = AuroraClassMainFunction.TroopTransport;
            else if (this.JGConstructionTime > 0)
                this.MainFunction = AuroraClassMainFunction.ConstructionShip;
            else if (this.Harvesters > 0)
                this.MainFunction = AuroraClassMainFunction.FuelHarvester;
            else if (this.Terraformers > 0)
                this.MainFunction = AuroraClassMainFunction.Terraformer;
            else if (this.MiningModules > 0)
                this.MainFunction = AuroraClassMainFunction.OrbitalMiner;
            else if (this.SalvageRate > 0)
                this.MainFunction = AuroraClassMainFunction.Salvager;
            else if (this.DiplomacyRating > 0)
                this.MainFunction = AuroraClassMainFunction.Diplomacy;
            else if (this.ELINTRating > 0)
                this.MainFunction = AuroraClassMainFunction.IntelligenceShip;
            else if (this.ColonistCapacity > 0)
                this.MainFunction = AuroraClassMainFunction.ColonyShip;
            else if (this.CargoCapacity > 0)
                this.MainFunction = AuroraClassMainFunction.Freighter;
            else if (this.int_61 > 0)
                this.MainFunction = AuroraClassMainFunction.Liner;
            else if (this.RecreationalModule)
                this.MainFunction = AuroraClassMainFunction.RecShip;
            else if (this.MaintModules > 0)
                this.MainFunction = AuroraClassMainFunction.MaintenanceShip;
            else if (this.WorkerCapacity > 0)
                this.MainFunction = AuroraClassMainFunction.OrbitalHabitat;
            else if (this.NoArmour == 1)
                this.MainFunction = AuroraClassMainFunction.SpaceStation;
            else if (this.int_67 > 5)
            {
                this.MainFunction = AuroraClassMainFunction.Scout;
            }
            else
            {
                if (this.STSTractor <= 0)
                    return;
                this.MainFunction = AuroraClassMainFunction.Tug;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2903);
        }
    }

    public void method_91()
    {
        try
        {
            int num1 = 0;
            int num2 = 0;
            foreach (ClassComponent gclass228 in this.ClassComponents.Values)
            {
                if (gclass228.Component.Data.ComponentTypeID != AuroraComponentType.Armour)
                {
                    num1 += (int)Math.Ceiling(gclass228.Component.decimal_1 * gclass228.NumComponent);
                    gclass228.ChanceToHit = num1;
                    if (gclass228.Component.bool_5)
                    {
                        num2 += (int)Math.Ceiling(gclass228.Component.decimal_1 * gclass228.NumComponent);
                        gclass228.ElectronicCTH = num2;
                    }
                }
            }

            this.MaxDACRoll = num1;
            this.ESMaxDACRoll = num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2904);
        }
    }

    public Decimal method_92()
    {
        try
        {
            return this.Cost /
                   ((1M + ((!this.Commercial
                        ? this.Size / AuroraUtils.int_20
                        : this.Size * AuroraUtils.decimal_22 / AuroraUtils.int_20) - 1M) / 2M) *
                    this.Race.ShipBuilding);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2905);
            return 0M;
        }
    }

    public int method_93()
    {
        try
        {
            int num = (int)((int)(this.CargoCapacity * AuroraUtils.decimal_23) + this.ColonistCapacity * AuroraUtils.decimal_24);
            if (this.TroopCapacity > 0)
                num += this.TroopCapacity * (int)AuroraUtils.decimal_25;
            if (this.CargoShuttleStrength > 0)
                num /= this.CargoShuttleStrength * this.Race.CargoShuttleLoadModifier;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2906);
            return 0;
        }
    }
}