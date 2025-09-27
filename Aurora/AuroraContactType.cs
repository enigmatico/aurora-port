// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraContactType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraContactType
{
    None = 0,
    Ship = 1,
    Salvo = 3,
    Population = 4,
    Packet = 9,
    [Description("Ground Forces")] GroundUnit = 12, // 0x0000000C
    [Description("STO Ground Forces")] STOGroundUnit = 14, // 0x0000000E
    Shipyard = 16, // 0x00000010
    Explosion = 17, // 0x00000011
    [Description("Energy Weapon Impact")] EWImpact = 18, // 0x00000012

    [Description("Secondary Power Explosion")]
    SecondaryPower = 19, // 0x00000013

    [Description("Secondary Magazine Explosion")]
    SecondaryMg = 20, // 0x00000014
    WayPoint = 22, // 0x00000016
}