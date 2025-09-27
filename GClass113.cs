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
public class GClass113
{
    private GClass0 gclass0_0;
    public AlienRaceInfo gclass110_0;
    public PopulationData gclass146_0;
    public GameRace gclass21_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public bool bool_4;
    public bool bool_5;
    public double double_0;
    public double double_1;
    public double double_2;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public string string_0;

    public GClass113(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public GClass113 method_0(GameRace gclass21_1, List<AlienRaceInfo> list_0)
    {
        try
        {
            GClass113 gclass113_1 = new GClass113(this.gclass0_0);
            GClass113 gclass113_2 = (GClass113)this.MemberwiseClone();
            gclass113_2.gclass21_0 = gclass21_1;
            gclass113_2.gclass110_0 =
                list_0.FirstOrDefault<AlienRaceInfo>(gclass110_1 => gclass110_1.ActualAlienRace == this.gclass110_0.ActualAlienRace);
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
            if (this.double_0 > 100.0)
            {
                this.decimal_1 = this.gclass146_0.decimal_30;
                this.int_0 = (int)this.gclass146_0.dictionary_0.Values
                    .Where<GClass158>(gclass158_0 => gclass158_0.gclass157_0.Cost > 6M)
                    .Sum<GClass158>(gclass158_0 => gclass158_0.decimal_0);
                if (this.double_2 < 100.0)
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has a population of {AuroraUtils.FormatNumberToDigits(this.decimal_1, 1)}m and {this.int_0.ToString()} installations",
                        this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                        this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
            }

            if (this.double_0 > 200.0)
            {
                this.int_2 = this.gclass146_0.method_73(AuroraInstallationType.ConstructionFactory) +
                             this.gclass146_0.method_73(AuroraInstallationType.OrdnanceFactory) +
                             this.gclass146_0.method_73(AuroraInstallationType.FighterFactory);
                this.int_1 = this.gclass146_0.method_73(AuroraInstallationType.Mine) +
                             this.gclass146_0.method_73(AuroraInstallationType.AutomatedMine) +
                             this.gclass146_0.method_73(AuroraInstallationType.CivilianMiningComplex);
                if (this.gclass146_0.method_73(AuroraInstallationType.Spaceport) > 0)
                    this.bool_0 = true;
                if (this.gclass146_0.method_73(AuroraInstallationType.CargoShuttleStation) > 0)
                    this.bool_5 = true;
                if (this.double_2 < 200.0)
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has {this.int_2.ToString()} factories and {this.int_1.ToString()} mines",
                        this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                        this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
                    if (this.bool_0)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has a spaceport",
                            this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                            this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
                    if (this.bool_5)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has a cargo shuttle station",
                            this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                            this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
                }
            }

            if (this.double_0 > 300.0)
            {
                this.int_3 = this.gclass146_0.method_73(AuroraInstallationType.FuelRefinery);
                this.int_5 = this.gclass146_0.method_73(AuroraInstallationType.MaintenanceFacility);
                if (this.gclass146_0.method_73(AuroraInstallationType.OrdnanceTransferStation) > 0)
                    this.bool_4 = true;
                if (this.gclass146_0.method_73(AuroraInstallationType.RefuellingStation) > 0)
                    this.bool_3 = true;
                if (this.double_2 < 300.0)
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                        $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has {this.int_3.ToString()} refineries and {this.int_5.ToString()} maintenance facilities",
                        this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                        this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
                    if (this.bool_4)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has an ordnance transfer station",
                            this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                            this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
                    if (this.bool_3)
                        this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                            $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has a refuelling station",
                            this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                            this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
                }
            }

            if (this.double_0 <= 500.0)
                return;
            this.int_4 = this.gclass146_0.method_73(AuroraInstallationType.ResearchLab);
            this.int_6 = this.gclass146_0.method_73(AuroraInstallationType.GFCC);
            if (this.gclass146_0.method_73(AuroraInstallationType.NavalHeadquarters) > 0)
                this.bool_1 = true;
            if (this.gclass146_0.method_73(AuroraInstallationType.SectorCommand) > 0)
                this.bool_2 = true;
            if (this.double_2 >= 500.0)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has {this.int_4.ToString()} research facilities and {this.int_6.ToString()} ground force construction complexes",
                this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
            if (this.bool_1)
                this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                    $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has an naval headquarters",
                    this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                    this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
            if (!this.bool_2)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                $"Analysis of emissions from the {this.gclass110_0.AlienRaceName} colony on {this.string_0} reveals it has a sector command",
                this.gclass21_0, this.gclass146_0.gclass202_0.ActualSystemData, this.gclass146_0.method_87(),
                this.gclass146_0.method_88(), AuroraEventCategory.Intelligence);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1895);
        }
    }
}