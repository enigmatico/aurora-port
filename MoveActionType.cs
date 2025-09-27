// Decompiled with JetBrains decompiler
// Type: GEnum123
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
public enum MoveActionType
{
    [Description("Standard Transit")] StandardTransit = 1,
    [Description("Move to")] MoveTo = 2,
    [Description("Join Fleet")] JoinFleet = 3,
    [Description("Load Colonists")] LoadColonists = 4,

    [Description("Join & Refuel Target Fleet")]
    JoinAndRefuelTargetFleet = 5,
    [Description("Unload Colonists")] UnloadColonists = 6,
    [Description("Refuel from Colony")] RefuelFromColony = 7,

    [Description("Divide Fleet into Single Ships")]
    DivideFleetIntoSingleShips = 8,
    [Description("Geological Survey")] GeologicalSurvey = 9,

    [Description("Join Fleet and Begin Overhaul")]
    JoinAndBeginOverhaul = 10, // 0x0000000A
    [Description("Gravitational Survey")] GravitationalSurvey = 12, // 0x0000000C

    [Description("Refuel from own Tankers")]
    RefuelFromOwnTankers = 30, // 0x0000001E

    [Description("Load Ordnance from Colony")]
    LoadOrdnanceFromColony = 33, // 0x00000021
    [Description("Squadron Transit")] SquadronTransit = 37, // 0x00000025

    [Description("Land on Assigned Mothership")]
    LandOnAssignedMothership = 38, // 0x00000026
    [Description("Follow")] FollowTarget = 39, // 0x00000027
    [Description("Load All Minerals")] LoadAllMinerals = 62, // 0x0000003E
    [Description("Unload All Minerals")] UnloadAllMinerals = 63, // 0x0000003F
    [Description("Stabilise Jump Point")] StabilizeJumpPoint = 64, // 0x00000040

    [Description("Transfer Fuel to Colony")]
    TransferFuelToColony = 67, // 0x00000043
    [Description("Activate Shields")] ActivateShields = 69, // 0x00000045
    [Description("Deactivate Shields")] DeactivateShields = 70, // 0x00000046
    [Description("Drop Off Commander")] DropOffCommander = 85, // 0x00000055

    [Description("Load Ground Unit into Transport Bay")]
    LoadGroundUnitIntoTransportBay = 86, // 0x00000056

    [Description("Unload Ground Unit from Transport Bay")]
    UnloadGroundUnitFromTransportBay = 87, // 0x00000057

    [Description("Unload All Ground Units from Transport Bay")]
    UnloadAllGroundUnitsFromTransportBay = 88, // 0x00000058
    [Description("Enter Hyper Speed")] EnterHyperSpeed = 89, // 0x00000059
    [Description("Leave Hyper Speed")] LeaveHyperSpeed = 90, // 0x0000005A

    [Description("Equalise Maintenance Supplies")]
    EqualizeMaintenanceSupplies = 92, // 0x0000005C

    [Description("Transit and Divide Fleet")]
    TransitAndDivideFleet = 94, // 0x0000005E

    [Description("Detach Non-Survey Ships")]
    DetachNonSurveyShips = 95, // 0x0000005F

    [Description("Unload All Installations")]
    UnloadAllInstallations = 96, // 0x00000060
    [Description("Rescue Survivors")] RescueSurvivors = 97, // 0x00000061
    [Description("Unload Survivors")] UnloadSurvivors = 98, // 0x00000062
    [Description("Deploy Escorts")] DeployEscorts = 99, // 0x00000063
    [Description("Detach Tankers")] DetachTankers = 100, // 0x00000064
    [Description("Detach Colliers")] DetachColliers = 101, // 0x00000065
    [Description("Active Sensors On")] ActiveSensorsOn = 102, // 0x00000066
    [Description("Active Sensors Off")] ActiveSensorsOff = 103, // 0x00000067
    [Description("Salvage")] SalvageWreck = 107, // 0x0000006B
    [Description("Salvage Intact Ship")] SalvageIntactShip = 108, // 0x0000006C
    [Description("Send Message")] SendMessage = 112, // 0x00000070

    [Description("Begin Overhaul (rewind clock)")]
    BeginOverhaul = 118, // 0x00000076
    [Description("Absorb")] AbsorbTargetFleet = 121, // 0x00000079

    [Description("Activate Transponder - Friendly")]
    ActivateFriendlyTransponder = 122, // 0x0000007A

    [Description("Deactivate Transponder")]
    DeactivateTransponder = 123, // 0x0000007B
    [Description("Intra-system Jump")] IntraSystemJump = 124, // 0x0000007C
    [Description("Resupply from Colony")] ResupplyFromColony = 125, // 0x0000007D

    [Description("Resupply from own Supply Ships")]
    ResupplyFromOwnSupplyShips = 128, // 0x00000080

    [Description("Transfer Maint Supplies to Colony")]
    TransferMaintenanceSuppliesToColony = 129, // 0x00000081
    [Description("Extended Orbit")] ExtendedOrbit = 132, // 0x00000084
    [Description("Launch Missiles at")] LaunchMissilesAt = 133, // 0x00000085
    [Description("Load Trade Goods")] LoadTradeGoods = 136, // 0x00000088
    [Description("Unload Trade Goods")] UnloadTradeGoods = 137, // 0x00000089
    [Description("Picket (Speed 1km/s)")] Picket = 139, // 0x0000008B
    [Description("Load Ship Component")] LoadShipComponent = 140, // 0x0000008C
    [Description("Unload Ship Component")] UnloadShipComponent = 141, // 0x0000008D

    [Description("Attempt Boarding Action All Formations")]
    AttemptBoardingActionAllFormations = 145, // 0x00000091

    [Description("Attempt Boarding Action")]
    AttemptBoardingAction = 146, // 0x00000092
    [Description("Move To Wreck")] MoveToWreck = 151, // 0x00000097
    [Description("Move to Mineral Site")] MoveToMineralSite = 152, // 0x00000098
    [Description("Receive Cargo")] ReceiveCargo = 155, // 0x0000009B

    [Description("Unload Ordnance to Colony")]
    UnloadOrdnanceToColony = 156, // 0x0000009C

    [Description("Land on Specified Mothership (No Assign)")]
    LandOnSpecifiedMothershipWithoutAssignment = 157, // 0x0000009D

    [Description("Land on Specified Mothership (+ Assign)")]
    LandOnSpecifiedMothershipAndAssignIt = 158, // 0x0000009E

    [Description("Tractor Specified Ship")]
    TractorSpecifiedShip = 159, // 0x0000009F

    [Description("Tractor Specified Shipyard")]
    TractorSpecifiedShipyard = 160, // 0x000000A0

    [Description("Release Tractored Ships")]
    ReleaseTractoredShips = 161, // 0x000000A1

    [Description("Release Tractored Shipyards")]
    ReleaseTractoredShipyards = 162, // 0x000000A2

    [Description("Load/Unload Minerals to Reserve Level")]
    LoadUnloadMineralsToReserveLevel = 165, // 0x000000A5
    [Description("Add Replacement Crew")] AddReplacementCrew = 168, // 0x000000A8
    [Description("Load Installation")] LoadInstallation = 176, // 0x000000B0
    [Description("Unload Installation")] UnloadInstallation = 177, // 0x000000B1
    [Description("Load Mineral Type")] LoadMineralType = 178, // 0x000000B2
    [Description("Unload Mineral Type")] UnloadMineralType = 179, // 0x000000B3

    [Description("Load Mineral When X Available")]
    LoadMineralWhenXAvailable = 180, // 0x000000B4
    [Description("Join As Sub-Fleet")] JoinAsSubFleet = 182, // 0x000000B6
    [Description("Transit by Sub-Fleet")] TransitBySubFleet = 183, // 0x000000B7

    [Description("Join & Refuel Target Sub-Fleet")]
    JoinAndRefuelTargetSubFleet = 184, // 0x000000B8
    [Description("Join Sub-Fleet")] JoinSubFleet = 185, // 0x000000B9
    [Description("Detach Supply Ships")] DetachSupplyShips = 188, // 0x000000BC

    [Description("Unload All Ship Components")]
    UnloadAllShipComponents = 189, // 0x000000BD

    [Description("Load from Ordnance Transfer Hub")]
    LoadFromOrdnanceTransferHub = 191, // 0x000000BF

    [Description("Unload To Ordnance Transfer Hub")]
    UnloadToOrdnanceTransferHub = 192, // 0x000000C0

    [Description("Replace Ordnance At Colony")]
    ReplaceOrdnanceAtColony = 193, // 0x000000C1

    [Description("Replace At Ordnance Transfer Hub")]
    ReplaceOrdnanceAtTransferHub = 194, // 0x000000C2

    [Description("Join and Add Ordnance to Fleet")]
    JoinAndAddOrdnanceToFleet = 195, // 0x000000C3

    [Description("Join and Add Ordnance to Sub-Fleet")]
    JoinAndAddOrdnanceToSubFleet = 196, // 0x000000C4

    [Description("Join and Replace Ordnance in Fleet")]
    JoinAndReplaceOrdnanceInFleet = 197, // 0x000000C5

    [Description("Join and Replace Ordnance in Sub-Fleet")]
    JoinAndReplaceOrdnanceInSubFleet = 198, // 0x000000C6

    [Description("Join and Remove Ordnance from Fleet")]
    JoinAndRemoveOrdnanceFromFleet = 199, // 0x000000C7

    [Description("Join and Remove Ordnance from Sub-Fleet")]
    JoinAndRemoveOrdnanceFromSubFleet = 200, // 0x000000C8

    [Description("Orbital Drop Ground Unit")]
    OrbitalDropGroundUnit = 201, // 0x000000C9

    [Description("Orbital Drop All Ground Units")]
    OrbitalDropAllGroundUnits = 203, // 0x000000CB

    [Description("Join & Resupply Target Fleet")]
    JoinAndResupplyTargetFleet = 204, // 0x000000CC

    [Description("Join & Resupply Target Sub-Fleet")]
    JoinAndResupplyTargetSubFleet = 205, // 0x000000CD

    [Description("Refuel & Resupply from Colony")]
    RefuelAndResupplyFromColony = 206, // 0x000000CE

    [Description("Refuel Resupply and Load Ordnance from Colony")]
    RefuelResupplyAndLoadOrdnanceFromColony = 207, // 0x000000CF

    [Description("Join, Refuel and Resupply Target Fleet")]
    JoinRefuelAndResupplyTargetFleet = 208, // 0x000000D0

    [Description("Join, Refuel, Resupply, Add Ordnance to Target Fleet")]
    RefuelResupplyAndAddOrdnanceToTargetFleet = 209, // 0x000000D1

    [Description("Refuel from Stationary Tankers")]
    RefuelFromStationaryTankers = 210, // 0x000000D2

    [Description("Provide Ground Support")]
    ProvideGroundSupport = 211, // 0x000000D3
    [Description("Provide Ground CAP")] ProvideGroundCap = 212, // 0x000000D4

    [Description("Planetary Search and Destroy")]
    PlanetarySearchAndDestroy = 213, // 0x000000D5

    [Description("Planetary Flak Suppression")]
    PlanetaryFlakSuppression = 214, // 0x000000D6

    [Description("Provide Orbital Bombardment Support")]
    ProvideOrbitalBombardmentSupport = 215, // 0x000000D7
    [Description("Attempt to Ram")] RamTargetShip = 216, // 0x000000D8

    [Description("Stabilise New Lagrange Point")]
    StabilizeNewLagrangePoint = 217, // 0x000000D9

    [Description("Load Ground Unit from Stationary Fleet")]
    LoadGroundUnitFromStationaryFleet = 218, // 0x000000DA
    [Description("Salvage Installations")] SalvageInstallations = 219, // 0x000000DB

    [Description("Tractor Any Ship in Fleet")]
    TractorAnyShipInFleet = 220, // 0x000000DC

    [Description("Activate Transponder - All")]
    ActivateTransponderForAll = 221, // 0x000000DD

    [Description("Land on Assigned Mothership as Sub-Fleet")]
    LandOnAssignedMothershipAsSubFleet = 222, // 0x000000DE

    [Description("Load All Minerals Until Full")]
    LoadAllMineralsUntilFull = 223, // 0x000000DF

    [Description("Resupply from Stationary Supply Ship")]
    ResupplyFromStationarySupplyShip = 224, // 0x000000E0

    [Description("Transfer All Installations")]
    TransferAllInstallations = 225, // 0x000000E1
    [Description("Transfer All Minerals")] TransferAllMinerals = 226, // 0x000000E2
    [Description("Transfer Installation")] TransferInstallation = 227, // 0x000000E3

    [Description("Land on Specified Mothership as Squadron")]
    LandOnSpecifiedMothershipAsSquadron = 228, // 0x000000E4

    [Description("Land and Join Specified Squadron")]
    LandAndJoinSpecifiedSquadron = 229, // 0x000000E5

    [Description("Refuel Stationary Fleet")]
    RefuelStationaryFleet = 230, // 0x000000E6

    [Description("Resupply Stationary Fleet")]
    ResupplyStationaryFleet = 231, // 0x000000E7

    [Description("Load Assigned Ground Templates")]
    LoadAssignedGroundTemplates = 232, // 0x000000E8

    [Description("Refuel Stationary Fleet to Minimum")]
    RefuelStationaryFleetToMinimum = 233, // 0x000000E9

    [Description("Refuel to Minimum from Stationary Tankers")]
    RefuelToMinimumFromStationaryTankers = 234, // 0x000000EA

    [Description("Transfer Prisoners to Ship")]
    TransferPrisonersToShip = 235, // 0x000000EB
    [Description("Create Fleet Waypoint")] CreateFleetWaypoint = 236, // 0x000000EC
}