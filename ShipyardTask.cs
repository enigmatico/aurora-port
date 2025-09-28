// Decompiled with JetBrains decompiler
// Type: GClass192
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class ShipyardTask
{
    public GameRace gclass21_0;
    public PopulationData gclass146_0;
    public Shipyard gclass193_0;
    public ShipData gclass40_0;
    public NavalAdminCommand gclass83_0;
    public ShipClass gclass22_0;
    public ShipClass gclass22_1;
    public FleetData gclass85_0;
    public AllMineralsValue gclass123_0;
    public AuroraSYTaskType auroraSYTaskType_0;
    public int int_0;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public string string_0;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;

    public string method_0()
    {
        try
        {
            switch (this.auroraSYTaskType_0)
            {
                case AuroraSYTaskType.Construction:
                    return string.Format("Build {0} {1}", this.gclass22_0.ShipHull.Abbreviation,
                        this.gclass22_0.ClassName);
                case AuroraSYTaskType.Repair:
                    return "Repair";
                case AuroraSYTaskType.Refit:
                    return string.Format("Refit {0} to {1}", this.gclass22_0.ClassName, this.gclass22_1.ClassName);
                case AuroraSYTaskType.Scrap:
                    return "Scrap";
                case AuroraSYTaskType.AutoRefit:
                    return string.Format("Auto Refit {0} to {1}", this.gclass22_0.ClassName, this.gclass22_1.ClassName);
                default:
                    return "No Task Found";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2921);
            return "Error";
        }
    }

    public void method_1(Decimal decimal_5)
    {
        try
        {
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Duranium, this.gclass123_0.Duranium * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Neutronium,
                this.gclass123_0.Neutronium * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Corbomite,
                this.gclass123_0.Corbomite * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Tritanium,
                this.gclass123_0.Tritanium * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Boronide, this.gclass123_0.Boronide * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Mercassium,
                this.gclass123_0.Mercassium * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Vendarite,
                this.gclass123_0.Vendarite * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Sorium, this.gclass123_0.Sorium * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Uridium, this.gclass123_0.Uridium * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Corundium,
                this.gclass123_0.Corundium * decimal_5);
            this.gclass146_0.method_21(MineralUsageType.const_5, AuroraElement.Gallicite,
                this.gclass123_0.Gallicite * decimal_5);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3937);
        }
    }
}