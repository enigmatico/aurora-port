// Decompiled with JetBrains decompiler
// Type: GClass113
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class AlienPopulationIntel
{
    private GClass0 gclass0_0;
    public AlienRaceIntel RaceIntel;
    public PopulationData Population;
    public GameRace ViewingRace;
    public int Installations;
    public int Mines;
    public int Factories;
    public int Refineries;
    public int ResearchFacilities;
    public int MaintenanceFacilities;
    public int GFTF;
    public bool Spaceport;
    public bool NavalHeadquarters;
    public bool SectorCommand;
    public bool RefuellingStation;
    public bool OrdnanceTransfer;
    public bool CargoStation;
    public double AlienPopulationIntelligencePoints;
    public double MaxIntelligence;
    public double PreviousMaxIntelligence;
    public Decimal decimal_0;
    public Decimal PopulationAmount;
    public Decimal EMSignature;
    public Decimal ThermalSignature;
    public string PopulationName;

    public AlienPopulationIntel(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public AlienPopulationIntel method_0(GameRace gclass21_1, List<AlienRaceIntel> list_0)
    {
        try
        {
            AlienPopulationIntel gclass113_1 = new AlienPopulationIntel(this.gclass0_0);
            AlienPopulationIntel gclass113_2 = (AlienPopulationIntel)this.MemberwiseClone();
            gclass113_2.ViewingRace = gclass21_1;
            gclass113_2.RaceIntel =
                list_0.FirstOrDefault<AlienRaceIntel>(gclass110_1 => gclass110_1.ActualAlienRace == this.RaceIntel.ActualAlienRace);
            return gclass113_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1894);
            return null;
        }
    }

    public void method_1()
    {
        try
        {
            if (this.AlienPopulationIntelligencePoints > 100.0)
            {
                this.PopulationAmount = this.Population.decimal_30;
                this.Installations = (int)this.Population.dictionary_0.Values
                    .Where<PopulationInstallation>(gclass158_0 => gclass158_0.InstallationType.Cost > 6M)
                    .Sum<PopulationInstallation>(gclass158_0 => gclass158_0.Amount);
                if (this.PreviousMaxIntelligence < 100.0)
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        string.Format(
                            "Analysis of emissions from the {0} colony on {1} reveals it has a population of {2}m and {3} installations",
                            this.RaceIntel.AlienRaceName, this.PopulationName,
                            AuroraUtils.FormatNumberToDigits(this.PopulationAmount, 1), this.Installations.ToString()),
                        this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                        this.Population.method_88(), AuroraEventCategory.Intelligence);
            }

            if (this.AlienPopulationIntelligencePoints > 200.0)
            {
                this.Factories = this.Population.method_73(AuroraInstallationType.ConstructionFactory) +
                             this.Population.method_73(AuroraInstallationType.OrdnanceFactory) +
                             this.Population.method_73(AuroraInstallationType.FighterFactory);
                this.Mines = this.Population.method_73(AuroraInstallationType.Mine) +
                             this.Population.method_73(AuroraInstallationType.AutomatedMine) +
                             this.Population.method_73(AuroraInstallationType.CivilianMiningComplex);
                if (this.Population.method_73(AuroraInstallationType.Spaceport) > 0)
                    this.Spaceport = true;
                if (this.Population.method_73(AuroraInstallationType.CargoShuttleStation) > 0)
                    this.CargoStation = true;
                if (this.PreviousMaxIntelligence < 200.0)
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        string.Format(
                            "Analysis of emissions from the {0} colony on {1} reveals it has {2} factories and {3} mines",
                            this.RaceIntel.AlienRaceName, this.PopulationName, this.Factories.ToString(),
                            this.Mines.ToString()),
                        this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                        this.Population.method_88(), AuroraEventCategory.Intelligence);
                    if (this.Spaceport)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            string.Format("Analysis of emissions from the {0} colony on {1} reveals it has a spaceport",
                                this.RaceIntel.AlienRaceName, this.PopulationName),
                            this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                            this.Population.method_88(), AuroraEventCategory.Intelligence);
                    if (this.CargoStation)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            string.Format(
                                "Analysis of emissions from the {0} colony on {1} reveals it has a cargo shuttle station",
                                this.RaceIntel.AlienRaceName, this.PopulationName),
                            this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                            this.Population.method_88(), AuroraEventCategory.Intelligence);
                }
            }

            if (this.AlienPopulationIntelligencePoints > 300.0)
            {
                this.Refineries = this.Population.method_73(AuroraInstallationType.FuelRefinery);
                this.MaintenanceFacilities = this.Population.method_73(AuroraInstallationType.MaintenanceFacility);
                if (this.Population.method_73(AuroraInstallationType.OrdnanceTransferStation) > 0)
                    this.OrdnanceTransfer = true;
                if (this.Population.method_73(AuroraInstallationType.RefuellingStation) > 0)
                    this.RefuellingStation = true;
                if (this.PreviousMaxIntelligence < 300.0)
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        string.Format(
                            "Analysis of emissions from the {0} colony on {1} reveals it has {2} refineries and {3} maintenance facilities",
                            this.RaceIntel.AlienRaceName, this.PopulationName, this.Refineries.ToString(),
                            this.MaintenanceFacilities.ToString()),
                        this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                        this.Population.method_88(), AuroraEventCategory.Intelligence);
                    if (this.OrdnanceTransfer)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            string.Format(
                                "Analysis of emissions from the {0} colony on {1} reveals it has an ordnance transfer station",
                                this.RaceIntel.AlienRaceName, this.PopulationName),
                            this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                            this.Population.method_88(), AuroraEventCategory.Intelligence);
                    if (this.RefuellingStation)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            string.Format(
                                "Analysis of emissions from the {0} colony on {1} reveals it has a refuelling station",
                                this.RaceIntel.AlienRaceName, this.PopulationName),
                            this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                            this.Population.method_88(), AuroraEventCategory.Intelligence);
                }
            }

            if (this.AlienPopulationIntelligencePoints <= 500.0)
                return;
            this.ResearchFacilities = this.Population.method_73(AuroraInstallationType.ResearchLab);
            this.GFTF = this.Population.method_73(AuroraInstallationType.GFCC);
            if (this.Population.method_73(AuroraInstallationType.NavalHeadquarters) > 0)
                this.NavalHeadquarters = true;
            if (this.Population.method_73(AuroraInstallationType.SectorCommand) > 0)
                this.SectorCommand = true;
            if (this.PreviousMaxIntelligence >= 500.0)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                string.Format(
                    "Analysis of emissions from the {0} colony on {1} reveals it has {2} research facilities and {3} ground force construction complexes",
                    this.RaceIntel.AlienRaceName, this.PopulationName, this.ResearchFacilities.ToString(), this.GFTF.ToString()),
                this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                this.Population.method_88(), AuroraEventCategory.Intelligence);
            if (this.NavalHeadquarters)
                this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                    string.Format(
                        "Analysis of emissions from the {0} colony on {1} reveals it has an naval headquarters",
                        this.RaceIntel.AlienRaceName, this.PopulationName),
                    this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                    this.Population.method_88(), AuroraEventCategory.Intelligence);
            if (!this.SectorCommand)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                string.Format("Analysis of emissions from the {0} colony on {1} reveals it has a sector command",
                    this.RaceIntel.AlienRaceName, this.PopulationName),
                this.ViewingRace, this.Population.gclass202_0.ActualSystem, this.Population.method_87(),
                this.Population.method_88(), AuroraEventCategory.Intelligence);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1895);
        }
    }
}