// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraSystemBodyType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraSystemBodyType
{
  [Description("None")] None = 0,
  [Description("Asteroid")] Asteroid = 1,
  [Description("Planet - Terrestrial")] Terrestrial = 2,
  [Description("Planet - Dwarf")] DwarfPlanet = 3,
  [Description("Planet - Gas Giant")] GasGiant = 4,
  [Description("Planet - Super Jovian")] Superjovian = 5,
  [Description("Moon - Small")] SmallMoon = 7,
  [Description("Moon")] Moon = 8,
  [Description("Moon - Large")] LargeMoon = 9,
  [Description("Moon - Small Terrestrial")] SmallTerrestrial = 10, // 0x0000000A
  [Description("Moon - Terrestrial")] TerrestrialMoon = 11, // 0x0000000B
  [Description("Comet")] Comet = 14, // 0x0000000E
}
