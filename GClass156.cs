// Decompiled with JetBrains decompiler
// Type: GClass156
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class GClass156
{
    public GameRace gclass21_0;
    public PopulationData gclass146_0;
    public GClass194 gclass194_0;
    public AllMineralsValue gclass123_0;
    public WealthUsageData gclass150_0;
    public GClass22 gclass22_0;
    public GClass22 gclass22_1;
    public PlanetaryInstallationType gclass157_0;
    public RaceMissile gclass129_0;
    public ShipComponent gclass230_0;
    private GClass0 gclass0_0;
    public AuroraProductionType auroraProductionType_0;
    public AuroraProductionCategory auroraProductionCategory_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public bool bool_0;
    public string string_0;

    public GClass156(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(Decimal decimal_4)
    {
        try
        {
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Duranium,
                this.gclass123_0.Duranium * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Neutronium,
                this.gclass123_0.Neutronium * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Corbomite,
                this.gclass123_0.Corbomite * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Tritanium,
                this.gclass123_0.Tritanium * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Boronide,
                this.gclass123_0.Boronide * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Mercassium,
                this.gclass123_0.Mercassium * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Vendarite,
                this.gclass123_0.Vendarite * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Sorium,
                this.gclass123_0.Sorium * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Uridium,
                this.gclass123_0.Uridium * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Corundium,
                this.gclass123_0.Corundium * decimal_4);
            this.gclass146_0.method_21((MineralUsage)this.gclass150_0.WealthUsage, AuroraElement.Gallicite,
                this.gclass123_0.Gallicite * decimal_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3936);
        }
    }
}