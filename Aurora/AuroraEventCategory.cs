// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraEventCategory
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraEventCategory
{
  [Description("All Event Categories")] All = 0,
  [Description("Population Production Events")] PopProduction = 1,
  Commander = 2,
  [Description("Population Mining Events")] PopMining = 3,
  [Description("Population Environment Events")] PopEnvironment = 4,
  [Description("Population Shipbuiding Events")] PopShipbuiding = 5,
  [Description("Population Ground Units Events")] PopGroundUnits = 6,
  [Description("Population Research Events")] PopResearch = 7,
  [Description("Combat Results Events")] CombatResults = 8,
  [Description("Ship-based Events")] Ship = 9,
  [Description("Fleet-based Events")] Fleet = 10, // 0x0000000A
  [Description("Jump Point Events")] JumpPoint = 11, // 0x0000000B
  [Description("System Events")] System = 12, // 0x0000000C
  [Description("Population Summary Events")] PopSummary = 14, // 0x0000000E
  [Description("Intelligence")] Intelligence = 15, // 0x0000000F
  MissileSalvo = 16, // 0x00000010
  Combat = 17, // 0x00000011
  SYUpgrade = 18, // 0x00000012
  Diplomacy = 19, // 0x00000013
}
