// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraRetirementStatus
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraRetirementStatus
{
    Active,

    [Description("Killed in Naval Combat")]
    KilledNaval,

    [Description("Retired due to Old Age")]
    RetiredOldAge,

    [Description("Retired due to a Medical Condition")]
    RetiredMedical,

    [Description("Retired when Ship Decomissioned")]
    ScrappedWithShip,

    [Description("Retired by Order of High Command")]
    RetiredByOrder,
    Captured,
    [Description("Honourable Discharge")] RetiredCareer,
    [Description("Killed in an Accident")] KilledByAccident,

    [Description("Died of Natural Causes")]
    DiedNaturalCauses,

    [Description("Died due to Life Support Failure")]
    DiedLifeSupportFailure,

    [Description("Killed in Ground Combat")]
    KilledGround,
    [Description("Died in a Life Pod")] DiedInLifePod,

    [Description("Killed during Boarding Combat")]
    KilledBoarding,
    Executed,
}