// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraSystemBodyTypeAbbrev
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraSystemBodyTypeAbbrev
{
    [Description("None")] None = 0,
    [Description("A")] Asteroid = 1,
    [Description("T")] Terrestrial = 2,
    [Description("D")] DwarfPlanet = 3,
    [Description("GG")] GasGiant = 4,
    [Description("SJ")] Superjovian = 5,
    [Description("MS")] SmallMoon = 7,
    [Description("M")] Moon = 8,
    [Description("ML")] LargeMoon = 9,
    [Description("MST")] SmallTerrestrial = 10, // 0x0000000A
    [Description("MT")] TerrestrialMoon = 11, // 0x0000000B
    [Description("C")] Comet = 14, // 0x0000000E
}