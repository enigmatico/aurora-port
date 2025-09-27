// Decompiled with JetBrains decompiler
// Type: GEnum122
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
public enum TechType
{
    None = 0,

    [Description("Capacitor Recharge Rate")]
    CapacitorRechargeRate = 1,
    [Description("Electronic Warfare")] ElectronicWarfare = 2,
    [Description("Laser Wavelength")] LaserWavelength = 3,

    [Description("Beam Fire Control Distance Rating")]
    BeamFireControlDistanceRating = 4,

    [Description("Fire Control Speed Rating")]
    FireControlSpeedRating = 5,

    [Description("Max Squadron Jump Radius")]
    MaxSquadronJumpRadius = 6,

    [Description("Max Jump Squadron Size")]
    MaxJumpSquadronSize = 7,
    [Description("Jump Drive Efficiency")] JumpDriveEfficiency = 8,
    [Description("Missile Launcher Size")] MissileLauncherSize = 10, // 0x0000000A

    [Description("Missile Warhead Strength")]
    MissileWarheadStrength = 12, // 0x0000000C

    [Description("Missile Launcher Reload Rate")]
    MissileLauncherReloadRate = 13, // 0x0000000D

    [Description("Shield Regeneration Rate")]
    ShieldRegenerationRate = 14, // 0x0000000E
    [Description("Laser Focal Size")] LaserFocalSize = 15, // 0x0000000F
    [Description("Shield Type")] ShieldType = 16, // 0x00000010

    [Description("Fire Control Size vs Range")]
    FireControlSizevsRange = 17, // 0x00000011

    [Description("Fire Control Size vs Tracking Speed")]
    FireControlSizevsTrackingSpeed = 18, // 0x00000012

    [Description("Thermal Sensor Sensitivity")]
    ThermalSensorSensitivity = 19, // 0x00000013

    [Description("Active Sensor Strength")]
    ActiveSensorStrength = 20, // 0x00000014

    [Description("Improved Construction Rate")]
    ImprovedConstructionRate = 25, // 0x00000019

    [Description("Improved Mining Production")]
    ImprovedMiningProduction = 26, // 0x0000001A

    [Description("Improved Ordnance Production")]
    ImprovedOrdnanceProduction = 27, // 0x0000001B

    [Description("Improved Planetary Sensor Strength")]
    ImprovedPlanetarySensorStrength = 28, // 0x0000001C

    [Description("Improved Research Rate")]
    ImprovedResearchRate = 29, // 0x0000001D

    [Description("Improved Shipbuilding Rate")]
    ImprovedShipbuildingRate = 30, // 0x0000001E

    [Description("Improved Fighter Production")]
    ImprovedFighterProduction = 31, // 0x0000001F

    [Description("Improved Fuel Production")]
    ImprovedFuelProduction = 32, // 0x00000020
    [Description("Engine Technology")] EngineTechnology = 40, // 0x00000028

    [Description("Power Plant Technology")]
    PowerPlantTechnology = 41, // 0x00000029
    [Description("Power vs Efficiency")] PowervsEfficiency = 42, // 0x0000002A
    [Description("Ground Unit Strength")] GroundUnitStrength = 50, // 0x00000032

    [Description("Jump Point Stabilisation Module")]
    JumpPointStabilisationModule = 56, // 0x00000038
    [Description("Terraforming Rate")] TerraformingRate = 57, // 0x00000039

    [Description("Particle Beam Strength")]
    ParticleBeamStrength = 60, // 0x0000003C

    [Description("Maximum Particle Beam Range")]
    MaximumParticleBeamRange = 61, // 0x0000003D

    [Description("Colonization Cost Reduction")]
    ColonizationCostReduction = 64, // 0x00000040
    [Description("Fuel Consumption")] FuelConsumption = 65, // 0x00000041
    [Description("Engineering")] Engineering = 66, // 0x00000042
    [Description("Sorium Harvester")] SoriumHarvester = 67, // 0x00000043
    [Description("Terraforming Module")] TerraformingModule = 68, // 0x00000044

    [Description("Hyper Drive Efficiency")]
    HyperDriveEfficiency = 69, // 0x00000045
    [Description("Meson Focal Size")] MesonFocalSize = 72, // 0x00000048
    [Description("Meson Focusing")] MesonFocusing = 73, // 0x00000049
    [Description("STS Tractor Beam")] STSTractorBeam = 74, // 0x0000004A
    [Description("Turret Rotation Gear")] TurretRotationGear = 75, // 0x0000004B
    [Description("Railgun Type")] RailgunType = 76, // 0x0000004C
    [Description("Railgun Velocity")] RailgunVelocity = 77, // 0x0000004D
    [Description("Carronade Calibre")] CarronadeCalibre = 78, // 0x0000004E

    [Description("Asteroid Mining Module")]
    AsteroidMiningModule = 79, // 0x0000004F
    [Description("Cargo Hold")] CargoHold = 80, // 0x00000050
    [Description("Sensor Jammer")] SensorJammer = 82, // 0x00000052
    [Description("ECCM")] ECCM = 83, // 0x00000053
    [Description("Armour")] Armour = 84, // 0x00000054
    [Description("Jump Point Theory")] JumpPointTheory = 85, // 0x00000055
    [Description("Magazine")] Magazine = 86, // 0x00000056
    [Description("Command and Control")] CommandandControl = 87, // 0x00000057
    [Description("Grav Survey Sensors")] GravSurveySensors = 88, // 0x00000058
    [Description("Geo Survey Sensors")] GeoSurveySensors = 89, // 0x00000059
    [Description("Troop Transport Bay")] TroopTransportBay = 91, // 0x0000005B
    [Description("Damage Control")] DamageControl = 92, // 0x0000005C
    [Description("Fuel Storage")] FuelStorage = 94, // 0x0000005E
    [Description("Cryogenic Transport")] CryogenicTransport = 97, // 0x00000061
    [Description("Crew Quarters")] CrewQuarters = 99, // 0x00000063
    [Description("Salvage Module")] SalvageModule = 100, // 0x00000064

    [Description("Racial Wealth Creation")]
    RacialWealthCreation = 103, // 0x00000067
    [Description("Platform Type")] PlatformType = 104, // 0x00000068
    [Description("Race-Designed Laser")] RaceDesignedLaser = 106, // 0x0000006A
    [Description("RD Meson Cannon")] RDMesonCannon = 107, // 0x0000006B

    [Description("RD Missile Fire Control")]
    RDMissileFireControl = 108, // 0x0000006C
    [Description("RD Missile Launcher")] RDMissileLauncher = 109, // 0x0000006D
    [Description("RD Railgun")] RDRailgun = 110, // 0x0000006E
    [Description("RD Reactor")] RDReactor = 111, // 0x0000006F
    [Description("RD Passive")] RDPassive = 112, // 0x00000070
    [Description("RD Active")] RDActive = 113, // 0x00000071
    [Description("RD Shields")] RDShields = 114, // 0x00000072
    [Description("RD Particle Beam")] RDParticleBeam = 116, // 0x00000074
    [Description("RD Jump Drive")] RDJumpDrive = 117, // 0x00000075
    [Description("RD Carronade")] RDCarronade = 118, // 0x00000076
    [Description("RD Engine")] RDEngine = 119, // 0x00000077
    [Description("RD Beam Fire Control")] RDBeamFireControl = 120, // 0x00000078
    [Description("RD Missile")] RDMissile = 122, // 0x0000007A
    [Description("RD Energy Turret")] RDEnergyTurret = 124, // 0x0000007C
    [Description("EM Sensor Sensitivity")] EMSensorSensitivity = 125, // 0x0000007D
    [Description("RD EM")] RDEM = 126, // 0x0000007E
    [Description("Thermal Reduction")] ThermalReduction = 127, // 0x0000007F
    [Description("X-Ray Laser Warhead")] XRayLaserWarhead = 128, // 0x00000080

    [Description("Reduced Size Launchers")]
    ReducedSizeLaunchers = 129, // 0x00000081

    [Description("Max Engine Thrust Modifier")]
    MaxEngineThrustModifier = 130, // 0x00000082
    [Description("Hangar Deck")] HangarDeck = 131, // 0x00000083
    [Description("Sector Command")] SectorCommand = 132, // 0x00000084
    [Description("Microwave Focal Size")] MicrowaveFocalSize = 136, // 0x00000088
    [Description("Microwave Focusing")] MicrowaveFocusing = 137, // 0x00000089
    [Description("RD HPM")] RDHPM = 138, // 0x0000008A
    [Description("Hardening")] Hardening = 139, // 0x0000008B
    [Description("Reduced Size Lasers")] ReducedSizeLasers = 140, // 0x0000008C

    [Description("Gauss Cannon Rate of Fire")]
    GaussCannonRateofFire = 141, // 0x0000008D
    [Description("Ship Type Limitations")] ShipTypeLimitations = 142, // 0x0000008E

    [Description("Gauss Cannon Size vs Accuracy")]
    GaussCannonSizevsAccuracy = 143, // 0x0000008F
    [Description("Gauss Cannon Velocity")] GaussCannonVelocity = 144, // 0x00000090
    [Description("RD Gauss Cannon")] RDGaussCannon = 145, // 0x00000091
    [Description("Advanced Laser")] AdvancedLaser = 148, // 0x00000094
    [Description("Advanced Carronade")] AdvancedCarronade = 149, // 0x00000095
    [Description("Advanced Railgun")] AdvancedRailgun = 150, // 0x00000096

    [Description("Advanced Particle Beam")]
    AdvancedParticleBeam = 151, // 0x00000097
    [Description("Active Sensor Type")] ActiveSensorType = 152, // 0x00000098
    [Description("Cloaking Efficiency")] CloakingEfficiency = 153, // 0x00000099

    [Description("Cloaking Sensor Reduction")]
    CloakingSensorReduction = 154, // 0x0000009A
    [Description("Minimum Cloak Size")] MinimumCloakSize = 155, // 0x0000009B
    [Description("RD Cloak")] RDCloak = 156, // 0x0000009C
    [Description("Cloaking Theory")] CloakingTheory = 157, // 0x0000009D
    [Description("Shipyard Operations")] ShipyardOperations = 158, // 0x0000009E
    [Description("Maintenance Storage")] MaintenanceStorage = 161, // 0x000000A1

    [Description("Background TNC Knowledge")]
    BackgroundTNCKnowledge = 162, // 0x000000A2

    [Description("Enhanced Radiation Warhead")]
    EnhancedRadiationWarhead = 163, // 0x000000A3
    [Description("Maintenance Module")] MaintenanceModule = 164, // 0x000000A4

    [Description("Max Tracking Time Bonus")]
    MaxTrackingTimeBonus = 165, // 0x000000A5

    [Description("Magazine Neutralization System")]
    MagazineNeutralizationSystem = 167, // 0x000000A7

    [Description("Magazine Feed System Efficiency")]
    MagazineFeedSystemEfficiency = 168, // 0x000000A8
    [Description("Jump Drive Type")] JumpDriveType = 169, // 0x000000A9

    [Description("Troop Transport - Dropship Equipped")]
    TroopTransportDropshipEquipped = 170, // 0x000000AA

    [Description("Passenger Accomodation")]
    PassengerAccomodation = 171, // 0x000000AB
    [Description("RD CIWS")] RDCIWS = 172, // 0x000000AC
    [Description("Genetics")] Genetics = 178, // 0x000000B2
    [Description("Temperature Range")] TemperatureRange = 179, // 0x000000B3
    [Description("Base Temperature")] BaseTemperature = 180, // 0x000000B4
    [Description("Base Oxygen Level")] BaseOxygenLevel = 181, // 0x000000B5
    [Description("Base Gravity")] BaseGravity = 182, // 0x000000B6
    [Description("RD Species")] RDSpecies = 189, // 0x000000BD
    [Description("Worker Hab")] WorkerHab = 190, // 0x000000BE
    [Description("Sensor Band Type")] SensorBandType = 191, // 0x000000BF
    [Description("Missile Jammer")] MissileJammer = 192, // 0x000000C0
    [Description("Fire Control Jammer")] FireControlJammer = 194, // 0x000000C2
    [Description("Alien Autopsy")] AlienAutopsy = 197, // 0x000000C5

    [Description("Min Engine Thrust Modifier")]
    MinEngineThrustModifier = 198, // 0x000000C6
    [Description("Recreational Centre")] RecreationalCentre = 199, // 0x000000C7
    [Description("Energy Weapon Mount")] EnergyWeaponMount = 200, // 0x000000C8
    [Description("Excavation Technology")] ExcavationTechnology = 201, // 0x000000C9
    [Description("Commercial Magazine")] CommercialMagazine = 202, // 0x000000CA
    [Description("Commercial Hangar")] CommercialHangar = 203, // 0x000000CB

    [Description("Commercial Damage Control")]
    CommercialDamageControl = 204, // 0x000000CC

    [Description("Troop Transport - Boarding Equipped")]
    TroopTransportBoardingEquipped = 207, // 0x000000CF
    [Description("Particle Lance")] ParticleLance = 208, // 0x000000D0
    [Description("MSP Production Rate")] MSPProductionRate = 209, // 0x000000D1

    [Description("Maintenance Capacity Per Facility")]
    MaintenanceCapacityPerFacility = 210, // 0x000000D2
    [Description("Refuelling System")] RefuellingSystem = 211, // 0x000000D3

    [Description("Underway Replenishment")]
    UnderwayReplenishment = 212, // 0x000000D4
    [Description("Maximum Engine Size")] MaximumEngineSize = 214, // 0x000000D6

    [Description("Maximum Shield Generator Size")]
    MaximumShieldGeneratorSize = 215, // 0x000000D7

    [Description("Box Launcher Explosion Chance")]
    BoxLauncherExplosionChance = 216, // 0x000000D8

    [Description("Ordnance Transfer System")]
    OrdnanceTransferSystem = 217, // 0x000000D9
    [Description("Ordnance Transfer Hub")] OrdnanceTransferHub = 218, // 0x000000DA
    [Description("Vehicle Armour Type")] VehicleArmourType = 219, // 0x000000DB
    [Description("Anti-Infantry Weapon")] AntiInfantryWeapon = 220, // 0x000000DC
    [Description("Ground Unit Class")] GroundUnitClass = 221, // 0x000000DD
    [Description("Ground Base Type")] GroundBaseType = 222, // 0x000000DE

    [Description("Ground Unit Capability")]
    GroundUnitCapability = 223, // 0x000000DF
    [Description("Cargo Shuttle Type")] CargoShuttleType = 225, // 0x000000E1

    [Description("Ground Formation Construction Rate")]
    GroundFormationConstructionRate = 226, // 0x000000E2
    [Description("Fighter Pod Bay")] FighterPodBay = 227, // 0x000000E3

    [Description("Fighter Pod Capability")]
    FighterPodCapability = 228, // 0x000000E4
    [Description("RD Fighter Pod Bay")] RDFighterPodBay = 229, // 0x000000E5
    [Description("Infantry Armour Type")] InfantryArmourType = 230, // 0x000000E6
    [Description("Static Armour Type")] StaticArmourType = 231, // 0x000000E7
    [Description("Anti-Vehicle Weapon")] AntiVehicleWeapon = 232, // 0x000000E8
    [Description("Bombardment Weapon")] BombardmentWeapon = 233, // 0x000000E9
    [Description("Anti-Air Weapon")] AntiAirWeapon = 234, // 0x000000EA
    [Description("Autocannon Weapon")] AutocannonWeapon = 235, // 0x000000EB

    [Description("Surface-To_Orbit Weapon")]
    SurfaceToOrbitWeapon = 237, // 0x000000ED
    [Description("Ground Headquarters")] GroundHeadquarters = 238, // 0x000000EE

    [Description("Forward Fire Direction")]
    ForwardFireDirection = 239, // 0x000000EF
    [Description("Ground Construction")] GroundConstruction = 240, // 0x000000F0
    [Description("Ground Geosurvey")] GroundGeosurvey = 241, // 0x000000F1
    [Description("ELINT Module")] ELINTModule = 242, // 0x000000F2
    [Description("Diplomacy Module")] DiplomacyModule = 243, // 0x000000F3

    [Description("Ground Force Logistics")]
    GroundForceLogistics = 244, // 0x000000F4

    [Description("Maximum Orbital Mining Diameter")]
    MaximumOrbitalMiningDiameter = 245, // 0x000000F5

    [Description("Ground Xenoarchaeological Survey")]
    GroundXenoarchaeologicalSurvey = 246, // 0x000000F6

    [Description("Meson Armour Retardation")]
    MesonArmourRetardation = 247, // 0x000000F7
    [Description("Bio-Energy Storage")] BioEnergyStorage = 248, // 0x000000F8
    [Description("Swarm Ground Weapons")] SwarmGroundWeapons = 249, // 0x000000F9
    [Description("Genetic Enhancements")] GeneticEnhancements = 250, // 0x000000FA

    [Description("Missile Engine Display Power Modifier")]
    MissileEngineDisplayPowerModifier = 251, // 0x000000FB

    [Description("Engine Display Power Modifier")]
    EngineDisplayPowerModifier = 252, // 0x000000FC
    [Description("New Species")] NewSpecies = 253, // 0x000000FD
    [Description("Sensor Resolution")] SensorResolution = 254, // 0x000000FE
    [Description("Power Plant Size")] PowerPlantSize = 256, // 0x00000100
    [Description("Fighter Pod Bay Size")] FighterPodBaySize = 257, // 0x00000101
    [Description("Shield Generator Size")] ShieldGeneratorSize = 258, // 0x00000102

    [Description("Missile Engine Display Size")]
    MissileEngineDisplaySize = 259, // 0x00000103
    [Description("Engine Display Size")] EngineDisplaySize = 260, // 0x00000104

    [Description("Missile Launcher Display Size")]
    MissileLauncherDisplaySize = 261, // 0x00000105
    [Description("Magazine Size")] MagazineSize = 262, // 0x00000106
    [Description("Magazine HTK")] MagazineHTK = 263, // 0x00000107
    [Description("Cloaking Device Size")] CloakingDeviceSize = 264, // 0x00000108
    [Description("Sensor Size")] SensorSize = 265, // 0x00000109
    [Description("Jump Engine Target HS")] JumpEngineTargetHS = 266, // 0x0000010A
    [Description("Railgun Shots")] RailgunShots = 267, // 0x0000010B

    [Description("Single Weapon Fire Control")]
    SingleWeaponFireControl = 268, // 0x0000010C

    [Description("Miscellaneous Components")]
    MiscellaneousComponents = 269, // 0x0000010D

    [Description("Small Refuelling System")]
    SmallRefuellingSystem = 270, // 0x0000010E
    [Description("Mobile Repair Bay")] MobileRepairBay = 271, // 0x0000010F
    [Description("RD Kinetic Turret")] RDKineticTurret = 272, // 0x00000110

    [Description("Decontamination Equipment")]
    DecontaminationEquipment = 273, // 0x00000111

    [Description("Laser Warhead Damage Efficiency")]
    LaserWarheadDamageEfficiency = 274, // 0x00000112

    [Description("Active Terminal Guidance")]
    ActiveTerminalGuidance = 275, // 0x00000113
    [Description("Missile Retargeting")] MissileRetargeting = 276, // 0x00000114
    [Description("Laser Warhead Focus")] LaserWarheadFocus = 277, // 0x00000115
    [Description("Missile ECM")] MissileECM = 279, // 0x00000117
    [Description("Multiple Warheads")] MultipleWarheads = 280, // 0x00000118
    [Description("Ship Decoy")] ShipDecoy = 281, // 0x00000119
    [Description("RD Decoy Launcher")] RDDecoyLauncher = 282, // 0x0000011A

    [Description("Decoy Launcher Display Size")]
    DecoyLauncherDisplaySize = 283, // 0x0000011B

    [Description("Genetic Conversion Rate")]
    GeneticConversionRate = 284, // 0x0000011C
    [Description("Crew Quarter Design")] CrewQuarterDesign = 285, // 0x0000011D
}