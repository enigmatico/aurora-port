// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraShipyardUpgradeType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraShipyardUpgradeType
{
    [Description("No Activity")] None,
    [Description("Add Slipway")] AddSlipway,
    [Description("Add 500 ton Capacity")] Add500,
    [Description("Add 1000 ton Capacity")] Add1000,
    [Description("Add 2000 ton Capacity")] Add2000,
    [Description("Add 5000 ton Capacity")] Add5000,

    [Description("Add 10,000 ton Capacity")]
    Add10000,
    Retool,

    [Description("Continual Capacity Upgrade")]
    Continual,

    [Description("Spacemaster Modification")]
    SMModify,
}