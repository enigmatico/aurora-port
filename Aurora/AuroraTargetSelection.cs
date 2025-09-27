// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraTargetSelection
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraTargetSelection
{
    [Description("Do Not Fire")] DoNotFire,
    [Description("Target Random Ship")] RandomShip,
    [Description("Target Largest Ship")] LargestShip,
    [Description("Target Smallest Ship")] SmallestShip,
    [Description("Target Slowest Ship")] SlowestShip,
    [Description("Target Fastest Ship")] Fastest,
    [Description("Target Easiest Ship")] HighestToHit,
    [Description("Target Shipyards")] Shipyards,
    [Description("Area Point Defence")] AreaDefence,
    [Description("Ranged Defensive Fire")] RangedDefensiveFire,

    [Description("Point Blank Defensive Fire")]
    PointBlankDefensiveFire,

    [Description("Point Blank Defensive Fire (Self)")]
    PointBlankDefensiveFireSelf,
    [Description("Target Population")] Population,
    [Description("Target Ground Forces")] GroundForces,

    [Description("Target STO Ground Forces")]
    STOGroundForces,
}