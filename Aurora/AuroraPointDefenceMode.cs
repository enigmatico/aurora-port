// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraPointDefenceMode
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraPointDefenceMode
{
    [Description("None")] None,
    [Description("Area Defence")] AreaDefence,
    [Description("Ranged Defensive Fire")] RangedDefensiveFire,

    [Description("Point Blank Defensive Fire")]
    PointBlankDefensiveFire,

    [Description("Point Blank Defensive Fire (Self Only)")]
    PointBlankDefensiveFireSelf,

    [Description("Missiles Per Target: 1")]
    OneMissilePerTarget,

    [Description("Missiles Per Target: 2")]
    TwoMissilesPerTarget,

    [Description("Missiles Per Target: 3")]
    ThreeMissilesPerTarget,

    [Description("Missiles Per Target: 4")]
    FourMissilesPerTarget,

    [Description("Missiles Per Target: 5")]
    FiveMissilesPerTarget,
}