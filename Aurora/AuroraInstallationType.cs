// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraInstallationType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraInstallationType
{
  NoType = 0,
  [Description("Fuel Refinery")] FuelRefinery = 3,
  [Description("Naval Shipyard Complex")] NavalShipyard = 4,
  [Description("Construction Factory")] ConstructionFactory = 5,
  [Description("Terraforming Installation")] TerraformingInstallation = 6,
  Mine = 7,
  [Description("Research Lab")] ResearchLab = 8,
  Infrastructure = 9,
  [Description("Deep Space Tracking Station")] TrackingStation = 11, // 0x0000000B
  [Description("Automated Mine")] AutomatedMine = 12, // 0x0000000C
  [Description("Military Academy")] MilitaryAcademy = 14, // 0x0000000E
  [Description("Ground Force Construction Complex")] GFCC = 17, // 0x00000011
  [Description("Convert Mine to Automated")] ConvertMineToAutomated = 18, // 0x00000012
  [Description("Sector Command")] SectorCommand = 20, // 0x00000014
  [Description("Maintenance Facility")] MaintenanceFacility = 21, // 0x00000015
  [Description("Mass Driver")] MassDriver = 24, // 0x00000018
  [Description("Financial Centre")] FinancialCentre = 25, // 0x00000019
  [Description("Convert CI to Construction Factory")] ConvertCItoCF = 27, // 0x0000001B
  [Description("Convert CI to Mine")] ConvertCItoMine = 28, // 0x0000001C
  [Description("Convert CI to Fuel Refinery")] ConvertCItoRefinery = 30, // 0x0000001E
  [Description("Commercial Shipyard Complex")] CommercialShipyard = 32, // 0x00000020
  Spaceport = 33, // 0x00000021
  [Description("Ordnance Factory")] OrdnanceFactory = 34, // 0x00000022
  [Description("Fighter Factory")] FighterFactory = 35, // 0x00000023
  [Description("Convert CI to Ordnance Factory")] ConvertCItoOrdnance = 36, // 0x00000024
  [Description("Convert CI to Fighter Factory")] ConvertCItoFighter = 37, // 0x00000025
  [Description("Conventional Industry")] ConventionalIndustry = 38, // 0x00000026
  [Description("Civilian Mining Complex")] CivilianMiningComplex = 39, // 0x00000027
  [Description("Genetic Modification Centre")] GeneticModificationCentre = 40, // 0x00000028
  [Description("Refuelling Station")] RefuellingStation = 43, // 0x0000002B
  [Description("Naval Headquarters")] NavalHeadquarters = 44, // 0x0000002C
  [Description("Ordnance Transfer Station")] OrdnanceTransferStation = 45, // 0x0000002D
  [Description("Cargo Shuttle Station")] CargoShuttleStation = 46, // 0x0000002E
  [Description("Forced Labour Construction Camp")] ForcedLabourConstructionCamp = 47, // 0x0000002F
  [Description("Forced Labour Mining Camp")] ForcedLabourMiningCamp = 48, // 0x00000030
  [Description("Convert CI to Financial Centre")] ConvertCItoFC = 50, // 0x00000032
  [Description("Repair Yard")] RepairYard = 51, // 0x00000033
  [Description("Ex-Civilian Mining Complex")] ExCivilianMiningComplex = 52, // 0x00000034
}
