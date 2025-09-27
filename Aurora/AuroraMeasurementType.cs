// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraMeasurementType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraMeasurementType
{
    None,

    [Description("Star Systems Discovered")]
    StarSystemsExplored,
    [Description("Ruins Discovered")] RuinsDiscovered,

    [Description("Ship Destruction Survived")]
    ShipDestructionSurvived,

    [Description("Hostile Ships Destroyed")]
    HostileShipsDestroyed,

    [Description("Commercial Tonnage Destroyed")]
    CommercialShippingDestroyed,

    [Description("Hostile Missiles Destroyed")]
    HostileOrdnanceDestroyed,

    [Description("Military Tonnage Destroyed")]
    MilitaryShippingDestroyed,
    [Description("Armour Damage Taken")] ArmourDamageTaken,
    [Description("Internal Damage Taken")] InternalDamageTaken,

    [Description("Ground Tonnage Destroyed")]
    GroundForcesDestroyed,

    [Description("Bodies With Minerals Discovered")]
    BodiesWithMineralsDiscovered,

    [Description("Jump Points Discovered")]
    JumpPointsDiscovered,

    [Description("Research Points Generated")]
    ResearchPointsGenerated,

    [Description("Research Projects Completed")]
    ResearchProjectsCompleted,
    [Description("Length of Service")] LengthOfService,

    [Description("Successful Boarding Combat")]
    SuccessfulBoardingCombat,

    [Description("Habitable World Discovered")]
    HabitableWorldDiscovered,

    [Description("Combat Drop - Formation")]
    CombatDropFormation,

    [Description("Combat Drop - Transport")]
    CombatDropTransport,
    [Description("Recover Installation")] RecoverInstallation,
    [Description("Tons Salvaged")] TonsSalvaged,

    [Description("JP Stablisations Completed")]
    JPStablisationsCompleted,

    [Description("Ancient Constructs Discovered")]
    AncientConstructsDiscovered,

    [Description("LP Stablisations Completed")]
    LPStablisationsCompleted,
}