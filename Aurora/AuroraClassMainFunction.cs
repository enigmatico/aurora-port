// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraClassMainFunction
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraClassMainFunction
{
  None,
  Carrier,
  Warship,
  FAC,
  Fighter,
  Scout,
  [Description("Survey Ship")] GravSurvey,
  [Description("Survey Ship")] GeoSurvey,
  Freighter,
  [Description("Colony Ship")] ColonyShip,
  [Description("Troop Transport")] TroopTransport,
  [Description("Stabilisation Ship")] ConstructionShip,
  [Description("Fuel Harvester")] FuelHarvester,
  Terraformer,
  [Description("Orbital Miner")] OrbitalMiner,
  Salvager,
  Liner,
  [Description("Supply Ship")] SupplyShip,
  [Description("Maintenance Ship")] MaintenanceShip,
  Tanker,
  [Description("Orbital Habitat")] OrbitalHabitat,
  Worker,
  [Description("Recreational Ship")] RecShip,
  [Description("Space Station")] SpaceStation,
  [Description("Intelligence Ship")] IntelligenceShip,
  [Description("Ground Support Fighter")] GroundSupportFighter,
  [Description("Diplomatic Ship")] Diplomacy,
  Tug,
}
