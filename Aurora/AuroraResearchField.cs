// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraResearchField
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraResearchField
{
  [Description("Power and Propulsion")] PowerAndPropulsion = 1,
  [Description("Sensors and Control Systems")] SensorsAndControlSystems = 2,
  [Description("Energy Weapons")] EnergyWeapons = 3,
  [Description("Missiles and Kinetic")] MissilesKinetic = 4,
  [Description("Construction and Production")] ConstructionProduction = 5,
  Logistics = 6,
  [Description("Defensive Systems")] DefensiveSystems = 7,
  [Description("Biology and Genetics")] BiologyGenetics = 8,
  [Description("Ground Combat")] GroundCombat = 9,
}
