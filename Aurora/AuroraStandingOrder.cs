// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraStandingOrder
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraStandingOrder
{
  [Description("No Order")] NoOrder = 0,
  [Description("Survey Nearest Asteroid")] SurveyNearestAsteroid = 1,
  [Description("Survey Nearest Moon")] SurveyNearestMoon = 2,
  [Description("Survey Nearest Planet")] SurveyNearestPlanet = 3,
  [Description("Survey Nearest Body")] SurveyNearestBody = 4,
  [Description("Survey Nearest Survey Location")] SurveyNearestSurveyLocation = 5,
  [Description("Move to System Requiring Geosurvey")] MoveToSystemRequiringGeosurvey = 6,
  [Description("Move to Entry Jump Point")] MovetoEntryJumpPoint = 7,
  [Description("Survey Nearest Planet or Moon")] SurveyNearestPlanetorMoon = 9,
  [Description("Move to System Requiring Gravsurvey")] MoveToSystemRequiringGravsurvey = 10, // 0x0000000A
  [Description("Survey Next Five System Bodies")] SurveyNextFiveSystemBodies = 13, // 0x0000000D
  [Description("Survey Next Three System Locations")] SurveyNextThreeSystemLocations = 14, // 0x0000000E
  [Description("Load Colonists from Colonist Source")] LoadColonistsFromColonistSource = 15, // 0x0000000F
  [Description("Load Colonists at Capital")] LoadColonistsatCapital = 16, // 0x00000010
  [Description("Unload Colonists")] UnloadColonists = 17, // 0x00000011
  [Description("Stabilise Nearest Jump Point")] StabiliseNearestJumpPoint = 20, // 0x00000014
  [Description("Load Automated Mine from Population")] LoadAutomatedMineFromPopulatedColony = 21, // 0x00000015
  [Description("Deliver automated mine to mining colony")] DeliverAutomatedMineToMiningColony = 22, // 0x00000016
  [Description("Move to Nearest Trade Location")] MovetoNearestTradeLocation = 23, // 0x00000017
  [Description("Unload Passengers")] UnloadPassengers = 24, // 0x00000018
  [Description("Move to Gas Giant with Sorium")] MovetoGasGiantwithSorium = 26, // 0x0000001A
  [Description("Salvage Nearest Wreck")] SalvageNearestWreck = 27, // 0x0000001B
  [Description("Terraform Colony")] TerraformColony = 28, // 0x0000001C
  [Description("Load Passengers")] LoadPassengers = 29, // 0x0000001D
  [Description("Move to Gas Giant with Sorium and 10m Pop")] MovetoGasGiantwithSorium10mPop = 30, // 0x0000001E
  [Description("Land on Mothership")] LandOnMothership = 31, // 0x0000001F
  [Description("Transfer Fuel to Colony")] TransferFuelToColony = 32, // 0x00000020
  [Description("Refuel at Colony")] RefuelatColony = 33, // 0x00000021
  [Description("Activate Shields")] ActivateShields = 35, // 0x00000023
  [Description("Deactivate Shields")] DeactivateShields = 36, // 0x00000024
  [Description("Clear Order List")] ClearOrderList = 37, // 0x00000025
  [Description("Change to Maximum Speed")] ChangetoMaximumSpeed = 38, // 0x00000026
  [Description("Active Sensors On")] ActiveSensorsOn = 39, // 0x00000027
  [Description("Overhaul at Colony")] OverhaulatColony = 41, // 0x00000029
  [Description("Unload Fuel at Colony and Return")] UnloadFuelatColonyandReturn = 42, // 0x0000002A
  [Description("Resupply at Colony")] ResupplyatColony = 43, // 0x0000002B
  [Description("Investigate Closest Point of Interest")] InvestigatePOI = 46, // 0x0000002E
  [Description("Move to Closest Rendezvous Point")] MoveToRendezvousPoint = 47, // 0x0000002F
  [Description("Join Operational Group")] JoinOperationalGroup = 48, // 0x00000030
  [Description("Survey Next Thirty System Bodies")] SurveyNextThirtySystemBodies = 49, // 0x00000031
  [Description("Pickup Nearest Lifepod")] PickupNearestLifepod = 50, // 0x00000032
  [Description("LG: Replenish Overhaul")] ReplenishOverhaul = 51, // 0x00000033
  [Description("Survey Next Three System Bodies or Locations")] SurveyNextThreeSystemBodiesOrLocations = 52, // 0x00000034
  [Description("LG: Replenish at Colony")] ReplenishAtColony = 53, // 0x00000035
  [Description("MV: Fleet Waypoint")] MoveToFleetWaypoint = 54, // 0x00000036
  [Description("LG: Refuel from Tanker")] RefuelFromTanker = 55, // 0x00000037
  [Description("LG: Replenish from Ship")] ReplenishFromShip = 56, // 0x00000038
}
