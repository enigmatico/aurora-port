// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraPointDefenceConcentration
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraPointDefenceConcentration
{
  [Description("Shots Per Target: 1")] OneShot = 1,
  [Description("Shots Per Target: 2")] TwoShots = 2,
  [Description("Shots Per Target: 3")] ThreeShots = 3,
  [Description("Shots Per Target: 4")] FourShots = 4,
  [Description("Shots Per Target: 5")] FiveShots = 5,
  [Description("Shots Per Target: 6")] SixShots = 6,
  [Description("Shots Per Target: 8")] EightShots = 8,
  [Description("Shots Per Target: 10")] TenShots = 10, // 0x0000000A
  [Description("Shots Per Target: 12")] TwelveShots = 12, // 0x0000000C
  [Description("Shots Per Target: Unlimited")] UnlimitedShots = 1000, // 0x000003E8
}
