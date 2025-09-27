// Decompiled with JetBrains decompiler
// Type: GClass20
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class DesignDoctrine
{
    private GClass0 gclass0_0;
    public List<GClass16> NameList_0 = new List<GClass16>();
    public List<DIMDesignPhilosophyTechProgression> list_1 = new List<DIMDesignPhilosophyTechProgression>();
    public List<TechProgressionCategoryType> list_2 = new List<TechProgressionCategoryType>();
    public List<GClass12> NameList_3 = new List<GClass12>();
    public OperationGroupProgressionType OperationGroupProgressionType;
    public FCTRaceRecordC21 Race;
    public ShipComponent ActiveAntiMissile;
    public ShipComponent ActiveAntiMissileSmall;
    public ShipComponent ActiveAntiFAC;
    public ShipComponent ActiveAntiFighter;
    public ShipComponent ActiveLarge;
    public ShipComponent ActiveVeryLarge;
    public ShipComponent ActiveStandard;
    public ShipComponent ActiveSmall;
    public ShipComponent ActiveNavigation;
    public ShipComponent ActiveFighterMissile;
    public ShipComponent ActiveFighterBeam;
    public ShipComponent FCSAntiMissile;
    public ShipComponent FCSAntiFAC;
    public ShipComponent FCSAntiFighter;
    public ShipComponent FCSStandardMissile;
    public ShipComponent FCSFastAttackCraftMissile;
    public ShipComponent BeamFCSRange;
    public ShipComponent BeamFCSSpeed;
    public ShipComponent BeamFCSShortRange;
    public ShipComponent FCSFighterMissile;
    public ShipComponent BeamFCSFighter;
    public ShipComponent JumpDriveDreadnought;
    public ShipComponent JumpDriveBattlecruiser;
    public ShipComponent JumpDriveCruiser;
    public ShipComponent JumpDriveDestroyer;
    public ShipComponent JumpDriveSurvey;
    public ShipComponent JumpDriveMediumHive;
    public ShipComponent JumpDriveLargeHive;
    public ShipComponent JumpDriveVeryLargeHive;
    public ShipComponent PointDefenceWeapon;
    public ShipComponent Carronade;
    public ShipComponent CIWS;
    public ShipComponent Gauss;
    public ShipComponent Meson;
    public ShipComponent MesonPointDefence;
    public ShipComponent LaserLarge;
    public ShipComponent LaserPointDefence;
    public ShipComponent LaserSpinal;
    public ShipComponent ParticleBeam;
    public ShipComponent Railgun;
    public ShipComponent RailgunPointDefence;
    public ShipComponent HighPowerMicrowaveLarge;
    public ShipComponent HighPowerMicrowaveSmall;
    public ShipComponent FighterBeamWeapon;
    public ShipComponent LauncherFAC;
    public ShipComponent LauncherStandard;
    public ShipComponent LauncherMine;
    public ShipComponent LauncherPointDefence;
    public ShipComponent LauncherDecoy;
    public ShipComponent EngineCommercial;
    public ShipComponent EngineMilitary;
    public ShipComponent EngineFAC;
    public ShipComponent EngineFighter;
    public ShipComponent EngineSurvey;
    public ShipComponent CloakDD;
    public ShipComponent CloakCA;
    public ShipComponent CloakBC;
    public ShipComponent EMSensorSize1;
    public ShipComponent EMSensorSize2;
    public ShipComponent EMSensorSize3;
    public ShipComponent EMSensorSize6;
    public ShipComponent ThermalSensorSize1;
    public ShipComponent ThermalSensorSize2;
    public ShipComponent ThermalSensorSize3;
    public ShipComponent ThermalSensorSize6;
    public TechData164 gclass164_0;
    public RaceMissile MissileFAC;
    public RaceMissile MissileCaptorMine;
    public RaceMissile MissileMineSecondStage;
    public RaceMissile MissilePointDefence;
    public RaceMissile MissileStandard;
    public RaceMissile DecoyMissile;
    public BeamWeaponPreference PrimaryBeamPreference;
    public BeamWeaponPreference AlternativeBeamPreference;
    public BeamWeaponPreference PointDefencePreference;
    public NPRMissileStrategy NPRMissileStrategy;
    public int NumCommercialEngines;
    public int EngineSizeMilitary;
    public int EngineSizeCommercial;
    public int LauncherSize;
    public int LauncherDecoySize;
    public int NumSalvos;
    public int NumSalvosAMM;
    public int WarshipArmour;
    public int WarshipEngineering;
    public int WarshipEngineProportion;
    public int WarshipHullSize;
    public int ActiveResolution;
    public int NumWarshipEngines;
    public int SurveySensors = 2;
    public int TerraformModules = 1;
    public int HarvesterModule = 20;
    public int MiningModules = 10;
    public Decimal SurveyEngineBoost = 0.7M;
    public Decimal MilitaryEngineBoost = 1M;
    public Decimal LauncherAMMSize = 1M;
    public Decimal FighterEngineSize = 2M;
    public double ShieldProportion;
    public double ArmourMultiplier = 1.0;
    public int MaxGeo;
    public int MaxGrav;
    public int MaxScout;
    public int MaxDiplomatic;
    public int MaxStabilisation;
    public int MaxSalvage;
    public int MaxTanker;
    public int GroundForceDeploymentThemeID = 1;
    public bool bFighterFactories;
    public bool bOrdnanceFactories;
    public bool bUseJumpDrive;
    public bool bHybridCarriers;

    public DesignDoctrine(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(FCTRaceRecordC21 gclass21_1)
    {
        try
        {
            foreach (GClass9 gclass9 in this.NameList_3.Select<GClass12, GClass9>(gclass12_0 => gclass12_0.gclass9_0)
                         .Distinct<GClass9>().ToList<GClass9>())
            {
                foreach (OperationalGroupElement gclass10 in gclass9.OperationalGroupElementList)
                {
                    if (AuroraUtils.GetRandomInteger(100) <= gclass10.ChanceOfElement)
                    {
                        GClass11 gclass11 = new GClass11();
                        gclass11.gclass9_0 = gclass9;
                        gclass11.gclass14_0 = gclass10.AutomatedClassDesign;
                        gclass11.bool_0 = gclass10.KeyElement;
                        gclass11.int_0 = gclass10.NumShips + AuroraUtils.GetRandomInteger(gclass10.RandomNumShips);
                        if (gclass11.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.CarrierEnergy && this.bHybridCarriers)
                            gclass11.gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.CarrierBattle];
                        gclass21_1.list_0.Add(gclass11);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3295);
        }
    }

    public void method_1()
    {
        try
        {
            this.list_1 = this.gclass0_0.DesignPhilosophyTechProgressionsDictionary
                .Where<DIMDesignPhilosophyTechProgression>(gclass19_0 => this.list_2.Contains(gclass19_0.TechProgressionCategoryID))
                .OrderBy<DIMDesignPhilosophyTechProgression, int>(gclass19_0 => gclass19_0.ProgressionOrder)
                .ToList<DIMDesignPhilosophyTechProgression>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3296);
        }
    }
}