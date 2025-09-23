// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraComponentType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraComponentType
{
  NoType = 0,
  Engine = 1,
  [Description("Crew Quarters")] CrewQuarters = 2,
  [Description("Fuel Storage")] FuelStorage = 3,
  [Description("Cargo Hold")] CargoHold = 4,
  Magazine = 5,
  [Description("Gravitational Survey Sensors")] GravitationalSurveySensors = 6,
  [Description("Geological Survey Sensors")] GeologicalSurveySensors = 7,
  [Description("Thermal Sensors")] ThermalSensors = 8,
  [Description("Command and Control")] CommandAndControl = 10, // 0x0000000A
  Armour = 11, // 0x0000000B
  Shields = 12, // 0x0000000C
  [Description("Cargo Shuttle Bay")] CargoShuttleBay = 14, // 0x0000000E
  Laser = 15, // 0x0000000F
  [Description("Jump Drive")] JumpDrive = 16, // 0x00000010
  [Description("Colonist Transport")] ColonistTransport = 17, // 0x00000011
  [Description("Power Plant")] PowerPlant = 18, // 0x00000012
  [Description("Beam Fire Control")] BeamFireControl = 19, // 0x00000013
  [Description("Electronic Warfare Systems")] ElectronicWarfareSystems = 20, // 0x00000014
  [Description("Missile Launcher")] MissileLauncher = 22, // 0x00000016
  [Description("Active Search Sensors")] ActiveSearchSensors = 24, // 0x00000018
  [Description("Missile Fire Control")] MissileFireControl = 25, // 0x00000019
  [Description("Damage Control")] DamageControl = 26, // 0x0000001A
  [Description("Troop Transport")] TroopTransport = 27, // 0x0000001B
  [Description("Jump Point Stabilisation")] JumpPointStabilisation = 29, // 0x0000001D
  [Description("Particle Beam")] ParticleBeam = 30, // 0x0000001E
  Engineering = 31, // 0x0000001F
  [Description("Sorium Harvester")] SoriumHarvester = 32, // 0x00000020
  [Description("Terraforming Module")] TerraformingModule = 33, // 0x00000021
  [Description("Meson Cannon")] MesonCannon = 34, // 0x00000022
  Railgun = 35, // 0x00000023
  Carronade = 36, // 0x00000024
  [Description("Tractor Beam")] TractorBeam = 37, // 0x00000025
  [Description("Orbital Mining Module")] OrbitalMiningModule = 38, // 0x00000026
  [Description("Salvage Module")] SalvageModule = 39, // 0x00000027
  [Description("EM Sensors")] EMSensors = 41, // 0x00000029
  [Description("Hangar Deck")] HangarDeck = 43, // 0x0000002B
  [Description("High Power Microwave")] HighPowerMicrowave = 44, // 0x0000002C
  [Description("Gauss Cannon")] GaussCannon = 45, // 0x0000002D
  [Description("Cloaking Device")] CloakingDevice = 46, // 0x0000002E
  [Description("Maintenance Storage")] MaintenanceStorage = 47, // 0x0000002F
  [Description("Maintenance Module")] MaintenanceModule = 48, // 0x00000030
  [Description("Passenger Module")] PassengerModule = 50, // 0x00000032
  CIWS = 51, // 0x00000033
  [Description("Missile Engine")] MissileEngine = 56, // 0x00000038
  [Description("Recreational Module")] RecreationalModule = 57, // 0x00000039
  [Description("Commercial Hangar Deck")] CommercialHangarDeck = 58, // 0x0000003A
  [Description("Commercial Damage Control")] CommercialDamageControl = 59, // 0x0000003B
  [Description("Refuelling System")] RefuellingSystem = 61, // 0x0000003D
  [Description("Multiple Refuelling Stations")] OrdnanceTransferSystem = 63, // 0x0000003F
  [Description("Ordnance Transfer Hub")] OrdnanceTransferHub = 64, // 0x00000040
  [Description("Fighter Pod Bay")] FighterPodBay = 65, // 0x00000041
  [Description("ELINT Module")] ELINTModule = 66, // 0x00000042
  [Description("Diplomacy Module")] DiplomacyModule = 67, // 0x00000043
  [Description("BioEnergy Storage")] BioEnergyStorage = 68, // 0x00000044
  [Description("Miscellaneous Component")] MiscellaneousComponent = 69, // 0x00000045
  [Description("Mobile Repair Bay")] MobileRepairBay = 70, // 0x00000046
  [Description("Decoy Missile Launcher")] DecoyMissileLauncher = 71, // 0x00000047
}
