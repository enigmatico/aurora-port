// Decompiled with JetBrains decompiler
// Type: GClass156
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class IndustrialProjects
{
    public GameRace Race;
    public PopulationData Population;
    public Species Species;
    public AllMineralsValue MineralCost;
    public WealthUsageData WealthUsage;
    public ShipClass ShipClass;
    public ShipClass RefitClass;
    public PlanetaryInstallationType InstallationType;
    public RaceMissile RaceMissile;
    public ShipComponent Component;
    private GClass0 gclass0_0;
    public AuroraProductionType ProductionType;
    public AuroraProductionCategory ProductionCategory;
    public int ProjectID;
    public int FuelRequired;
    public int Queue;
    public Decimal Amount;
    public Decimal PartialCompletion;
    public Decimal ProdPerUnit;
    public Decimal Percentage;
    public bool Pause;
    public string Description;

    public IndustrialProjects(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(Decimal decimal_4)
    {
        try
        {
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Duranium,
                this.MineralCost.Duranium * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Neutronium,
                this.MineralCost.Neutronium * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Corbomite,
                this.MineralCost.Corbomite * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Tritanium,
                this.MineralCost.Tritanium * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Boronide,
                this.MineralCost.Boronide * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Mercassium,
                this.MineralCost.Mercassium * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Vendarite,
                this.MineralCost.Vendarite * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Sorium,
                this.MineralCost.Sorium * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Uridium,
                this.MineralCost.Uridium * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Corundium,
                this.MineralCost.Corundium * decimal_4);
            this.Population.method_21((MineralUsageType)this.WealthUsage.WealthUsageType, AuroraElement.Gallicite,
                this.MineralCost.Gallicite * decimal_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3936);
        }
    }
}