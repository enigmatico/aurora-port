// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraFleetCondition
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraFleetCondition
{
  [Description("No Condition")] NoCondition = 0,
  [Description("Fuel Tanks Full")] FuelTanksFull = 1,
  [Description("Fuel: 20% or Less")] FuelLessThan20 = 2,
  [Description("Fuel: 10% or Less")] FuelLessThan10 = 3,
  [Description("Current Speed not equal to Max")] CurrentSpeedNotEqualtoMax = 6,
  [Description("MSP: 20% or Less")] SupplyPointsLessThan20 = 7,
  [Description("MSP: 10% or Less")] SupplyPointsLessThan10 = 8,
  [Description("Hostile Active Ship Contact in System")] HostileActiveShipContactinSystem = 9,
  [Description("Fuel: 30% or Less")] FuelLessThan30 = 10, // 0x0000000A
  [Description("Fuel: 40% or Less")] FuelLessThan40 = 11, // 0x0000000B
  [Description("Fuel: 50% or Less")] FuelLessThan50 = 12, // 0x0000000C
  [Description("Deployment Exceeded")] DeploymentExceeded = 13, // 0x0000000D
  [Description("MSP: 30% or Less")] SupplyPointsLessThan30 = 14, // 0x0000000E
}
