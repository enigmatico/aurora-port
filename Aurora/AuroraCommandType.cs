// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraCommandType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraCommandType
{
  None = 0,
  [Description("Commanding Officer")] Ship = 1,
  [Description("Colony Governor")] Colony = 3,
  [Description("Sector Governor")] Sector = 4,
  [Description("Ground Force Commander")] GroundFormation = 5,
  [Description("Research Project Leader")] ResearchProject = 7,
  [Description("Executive Officer")] ExecutiveOfficer = 8,
  [Description("Chief Engineer")] ChiefEngineer = 9,
  [Description("Science Officer")] ScienceOfficer = 10, // 0x0000000A
  [Description("Tactical Officer")] TacticalOfficer = 11, // 0x0000000B
  [Description("Naval Admin Commander")] NavalAdminCommand = 12, // 0x0000000C
  [Description("Strike Group Commander")] CAG = 15, // 0x0000000F
  [Description("Academy Commandant")] AcademyCommandant = 17, // 0x00000011
}
