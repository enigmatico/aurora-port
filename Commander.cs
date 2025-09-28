// Decompiled with JetBrains decompiler
// Type: GClass55
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
// probably actual instance of commander?
public class Commander
{
    #region CompilerGenerated

    [CompilerGenerated]
    private sealed class Class908
    {
        public Commander gclass55_0;
        public AuroraMeasurementType auroraMeasurementType_0;

        internal bool method_0(ConditionForMedal gclass44_0)
        {
            return gclass44_0.Medal.Race == this.gclass55_0.Race;
        }
    }

    [CompilerGenerated]
    private sealed class Class909
    {
        public Decimal decimal_0;
        public Commander.Class908 class908_0;

        internal bool method_0(ConditionForMedal gclass44_0)
        {
            return gclass44_0.Condition.MeasurementType == this.class908_0.auroraMeasurementType_0 &&
                   gclass44_0.Condition.AmountRequired <= this.class908_0.gclass55_0
                       .Measurements[this.class908_0.auroraMeasurementType_0].Amount &&
                   gclass44_0.Condition.AmountRequired > this.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class910
    {
        public FCTRaceMedalRecord gclass42_0;

        internal bool method_0(CommanderMedal gclass53_0)
        {
            return gclass53_0.gclass42_0 == this.gclass42_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class911
    {
        public Commander gclass55_0;
        public CheckBox checkBox_0;
        public CheckBox checkBox_1;
        public AssignmentTypeFilter gclass49_0;

        internal bool method_0(Sector gclass62_0)
        {
            return gclass62_0.int_1 <= this.gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_1(Sector gclass62_0)
        {
            return gclass62_0.SectorCommander == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass55_0.Race && gclass146_0.genum64_0 != GEnum64.const_2;
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.int_17 <= this.gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_4(PopulationData gclass146_0)
        {
            return gclass146_0.Governer == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_5(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass55_0.Race &&
                   gclass146_0.method_73(AuroraInstallationType.MilitaryAcademy) > 0;
        }

        internal bool method_6(PopulationData gclass146_0)
        {
            return gclass146_0.method_82() == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_7(ShipData gclass40_0)
        {
            return gclass40_0.Class.RacialRankTheme.RankNum >= this.gclass55_0.RacialRank.RankNum ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_8(ShipData gclass40_0)
        {
            return gclass40_0.method_192(this.gclass49_0.ShipboardPosition) == null ||
                   this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_9(ShipData gclass40_0)
        {
            return gclass40_0.Class.RacialRankTheme.RankNum + this.gclass49_0.RankPriorityModifier == this.gclass55_0.RacialRank.RankNum;
        }

        internal bool method_10(ShipData gclass40_0)
        {
            return gclass40_0.method_192(this.gclass49_0.ShipboardPosition) == null ||
                   this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_11(ShipData gclass40_0)
        {
            return gclass40_0.Class.method_35(GEnum118.const_58) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.ExecutiveOfficer;
        }

        internal bool method_12(ShipData gclass40_0)
        {
            return gclass40_0.Class.method_35(GEnum118.const_59) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.ChiefEngineer;
        }

        internal bool method_13(ShipData gclass40_0)
        {
            return gclass40_0.Class.method_35(GEnum118.const_62) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.CAG;
        }

        internal bool method_14(ShipData gclass40_0)
        {
            return gclass40_0.Class.method_35(GEnum118.const_61) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.ScienceOfficer;
        }

        internal bool method_15(ShipData gclass40_0)
        {
            return gclass40_0.Class.method_35(GEnum118.const_60) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.TacticalOfficer;
        }

        internal bool method_16(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass55_0.Race;
        }

        internal bool method_17(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.method_31() >= this.gclass55_0.RacialRank.RankNum ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_18(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.Commander == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_19(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.gclass61_0.RankNum >= this.gclass55_0.RacialRank.RankNum ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_20(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.gclass55_0 == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }
    }

    [CompilerGenerated]
    private sealed class Class912
    {
        public int int_0;
        public Commander.Class911 class911_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.Race == this.class911_0.gclass55_0.Race &&
                   gclass40_0.Class.FighterClass == this.class911_0.gclass49_0.IsForFighter &&
                   gclass40_0.Class.Commercial == this.class911_0.gclass49_0.IsForFreighters &&
                   (gclass40_0.Class.ProtectionValue > 0M || !this.class911_0.gclass49_0.IsForArmedShip) &&
                   gclass40_0.gclass187_0 == null && gclass40_0.Class.NoOfficers == 0 &&
                   gclass40_0.Class.RacialRankTheme.RankNum <= this.int_0 - this.class911_0.gclass49_0.RankPriorityModifier;
        }
    }

    #endregion

    private GClass0 gclass0_0;
    public GameRace Race;
    public GameRace PrisonedRace;
    public Species Species;
    public RacialRank RacialRank;
    public PopulationData Population;
    public PopulationData GoverningPopulation;
    public PopulationData EducatedColony;
    public PopulationData PopulationAsAcademyCommandant;
    public SystemBodyData HomeworldSystem;
    public ShipData TransportShip;
    public ShipData CommandingShip;
    public ShipData ShipOnboardAsXO;
    public ShipData ShipOnboardAsChiefEngi;
    public ShipData ShipOnboardAsScienceOfficer;
    public ShipData ShipOnboardAsTactician;
    public ShipData ShipOnboardAsCAG;
    public Sector CommandingSector;
    public ResearchProject ResearchingProject;
    public GroundUnitFormationData CommandingFormation;
    public ResearchFieldData ResearchField;
    public NavalAdminCommand CurrentAdmin;
    public LifePod LifePod;
    public AuroraCommanderType CommanderType;
    public AuroraCommandType CommandType;
    public AuroraRetirementStatus RetirementStatus;
    public int CommanderID;
    public int PromotionScore;
    public int PopPromotionScore;
    public int DoNotRelieve;
    public int Seniority;
    public int Loyalty;
    public int HealthRisk;
    public int KillTonnageCommercial;
    public int KillTonnageMilitary;
    public Decimal GameTimePromoted;
    public Decimal GameTimeAssigned;
    public Decimal CareerStart;
    public Decimal decimal_3 = 1M;
    public bool DoNotPromote;
    public bool Female;
    public bool StoryCharacter;
    public bool RetainRetired;
    public bool Prisoner;
    public bool Processed;
    public string Name;
    public string Title;
    public string Orders;
    public string Notes;
    public Dictionary<CommanderBonusType, CommanderBonus> SkillBonuses = new Dictionary<CommanderBonusType, CommanderBonus>();
    public Dictionary<int, CommanderMedal> dictionary_1 = new Dictionary<int, CommanderMedal>();
    public Dictionary<AuroraMeasurementType, Measurement> Measurements = new Dictionary<AuroraMeasurementType, Measurement>();
    public List<HistoryRecord> Histories = new List<HistoryRecord>();
    public List<int> Traits = new List<int>();
    private List<GClass56> list_2 = new List<GClass56>();
    public int int_9;
    public AlienRaceIntel gclass110_0;
    public int int_10;

    public Commander(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public int method_0()
    {
        try
        {
            List<RacialRank> list = this.Race.RacialRankDictionary.Values
                .Where<RacialRank>(
                    gclass61_1 => gclass61_1.CommanderType == this.RacialRank.CommanderType)
                .OrderByDescending<RacialRank, int>(gclass61_0 => gclass61_0.RankNum).ToList<RacialRank>();
            int num = 1;
            foreach (RacialRank gclass61 in list)
            {
                if (gclass61 == this.RacialRank)
                    return num;
                ++num;
            }

            return 1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2422);
            return 1;
        }
    }

    public void method_1(AuroraMeasurementType auroraMeasurementType_0, Decimal decimal_4)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Commander.Class908 class908 = new Commander.Class908();
        // ISSUE: reference to a compiler-generated field
        class908.gclass55_0 = this;
        // ISSUE: reference to a compiler-generated field
        class908.auroraMeasurementType_0 = auroraMeasurementType_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Commander.Class909 class909 = new Commander.Class909();
            // ISSUE: reference to a compiler-generated field
            class909.class908_0 = class908;
            if (this.Race.NPR)
                return;
            // ISSUE: reference to a compiler-generated field
            class909.decimal_0 = 0M;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (this.Measurements.ContainsKey(class909.class908_0.auroraMeasurementType_0))
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class909.decimal_0 = this.Measurements[class909.class908_0.auroraMeasurementType_0].Amount;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.Measurements[class909.class908_0.auroraMeasurementType_0].Amount += decimal_4;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.Measurements.Add(class909.class908_0.auroraMeasurementType_0, new Measurement()
                {
                    MeasurementType = class909.class908_0.auroraMeasurementType_0,
                    Amount = decimal_4
                });
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (ConditionForMedal gclass44 in this.gclass0_0.ConditionForMedals.Where<ConditionForMedal>(class909.class908_0.method_0)
                         .Where<ConditionForMedal>(class909.method_0).ToList<ConditionForMedal>())
                this.method_2(gclass44.Medal, gclass44.Condition, "");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 367);
        }
    }

    public void method_2(FCTRaceMedalRecord gclass42_0, MedalCondition gclass43_0, string string_4)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Commander.Class910 class910 = new Commander.Class910();
        // ISSUE: reference to a compiler-generated field
        class910.gclass42_0 = gclass42_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            CommanderMedal gclass53 = this.dictionary_1.Values.FirstOrDefault<CommanderMedal>(class910.method_0);
            if (gclass53 != null)
            {
                if (!gclass53.gclass42_0.AllowMultipleAward)
                    return;
                gclass53.int_0 = 2;
            }
            else
            {
                gclass53 = new CommanderMedal();
                // ISSUE: reference to a compiler-generated field
                gclass53.gclass42_0 = class910.gclass42_0;
                gclass53.int_0 = 1;
                this.dictionary_1.Add(gclass53.gclass42_0.MedalID, gclass53);
            }

            string string_0 = string.Format("{0} awarded the {1}", this.method_36(), gclass53.gclass42_0.MedalName);
            string string_4_1 = string.Format("Awarded the {0}", gclass53.gclass42_0.MedalName);
            if (gclass43_0 != null)
            {
                string_0 = string.Format("{0} based on the condition: {1}", string_0, gclass43_0.Description);
                string_4_1 = string.Format("{0}: {1}", string_4_1, gclass43_0.Description);
                gclass53.string_0 = gclass43_0.Description;
            }
            else if (string_4 != "")
            {
                gclass53.string_0 = string_4;
                string_4_1 = string.Format("{0}. Citation: {1}", string_4_1, string_4);
                string_0 = string.Format("{0}. Citation: {1}", string_0, string_4);
            }

            if (gclass53.int_0 > 1)
            {
                string_4_1 = string.Format("{0}. This is the {1} award of this medal", string_4_1,
                    AuroraUtils.smethod_80(gclass53.int_0));
                string_0 = string.Format("{0}. This is the {1} award of this medal", string_0,
                    AuroraUtils.smethod_80(gclass53.int_0));
            }

            this.AddHistory(string_4_1, HistoryType.Personal);
            this.method_45(string.Format(" awarded the {0}", gclass53.gclass42_0.MedalName));
            this.gclass0_0.gclass92_0.method_2(EventType.const_164, string_0, this.Race, null, 0.0, 0.0,
                AuroraEventCategory.Commander);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 368);
        }
    }

    public Decimal method_3(CommanderBonusType genum121_0)
    {
        try
        {
            Decimal num = this.method_5(genum121_0);
            if (this.decimal_3 < 1M)
                num = 1M + (num - 1M) * this.decimal_3;
            return num * this.CommandingFormation.method_0(genum121_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 369);
            return 1M;
        }
    }

    public Decimal method_4()
    {
        try
        {
            if (this.CommandingFormation == null)
                return 0M;
            int num1 = this.CommandingFormation.method_33();
            Decimal num2 = 1M;
            if (this.CommandingFormation.int_8 > num1)
                num2 = num1 / this.CommandingFormation.int_8;
            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 370);
            return 1M;
        }
    }

    public Decimal method_5(CommanderBonusType genum121_0)
    {
        try
        {
            if (this.SkillBonuses.ContainsKey(genum121_0))
                return this.SkillBonuses[genum121_0].BonusValue;
            return this.gclass0_0.CommanderBonusDictionary[genum121_0].Percentage ? 1M : 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 371);
            return 0M;
        }
    }

    public string method_6(CommanderBonusType genum121_0)
    {
        try
        {
            Decimal decimal_73 = this.method_5(genum121_0);
            return this.gclass0_0.CommanderBonusDictionary[genum121_0].Percentage
                ? string.Format("{0}% ", AuroraUtils.FormatNumberToDigits((decimal_73 - 1M) * 100M, 0))
                : AuroraUtils.FormatNumberToDigits(decimal_73, 0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 372);
            return "";
        }
    }

    public Decimal method_7(CommanderBonusType genum121_0)
    {
        try
        {
            return !this.SkillBonuses.ContainsKey(genum121_0)
                ? 1M
                : 1M + (this.SkillBonuses[genum121_0].BonusValue - 1M) / 2M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 373);
            return 0M;
        }
    }

    public Decimal method_8(CommanderBonusType genum121_0)
    {
        try
        {
            return !this.SkillBonuses.ContainsKey(genum121_0)
                ? 1M
                : 1M + (this.SkillBonuses[genum121_0].BonusValue - 1M) / 4M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 374);
            return 0M;
        }
    }

    public void method_9(CommanderBonusType genum121_0, Decimal decimal_4)
    {
        try
        {
            if (this.SkillBonuses.ContainsKey(genum121_0))
                return;
            this.SkillBonuses.Add(genum121_0, new CommanderBonus()
            {
                BonusDefinition = this.gclass0_0.CommanderBonusDictionary[genum121_0],
                BonusValue = decimal_4
            });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 375);
        }
    }

    public void method_10(CommanderBonusType genum121_0, Decimal decimal_4, bool bool_6)
    {
        try
        {
            if (!this.SkillBonuses.ContainsKey(genum121_0))
            {
                Decimal decimal_4_1 = !this.gclass0_0.CommanderBonusDictionary[genum121_0].Percentage ? 0M : 1M;
                this.method_9(genum121_0, decimal_4_1);
            }

            if (this.SkillBonuses[genum121_0].BonusValue == this.gclass0_0.CommanderBonusDictionary[genum121_0].MaximumBonus)
                return;
            this.SkillBonuses[genum121_0].BonusValue += decimal_4;
            if (this.SkillBonuses[genum121_0].BonusValue > this.gclass0_0.CommanderBonusDictionary[genum121_0].MaximumBonus)
                this.SkillBonuses[genum121_0].BonusValue = this.gclass0_0.CommanderBonusDictionary[genum121_0].MaximumBonus;
            if (!bool_6)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_148,
                string.Format(
                    "The {0} bonus of {1} has increased to {2}   Current Bonuses:  {3}   Current Assignment:  {4}",
                    this.gclass0_0.CommanderBonusDictionary[genum121_0].Description, this.method_38(),
                    this.method_6(genum121_0), this.method_29(false), this.method_17(false)),
                this.Race, null, 0.0, 0.0, AuroraEventCategory.Commander);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 377);
        }
    }

    public void method_11(ShipClass gclass22_0, Decimal decimal_4)
    {
        try
        {
            switch (AuroraUtils.GetRandomInteger(5))
            {
                case 1:
                    this.method_10(CommanderBonusType.CrewTraining, decimal_4, true);
                    break;
                case 2:
                    this.method_10(CommanderBonusType.Reaction, decimal_4, true);
                    break;
                default:
                    if (gclass22_0.MainFunction == AuroraClassMainFunction.IntelligenceShip)
                    {
                        this.method_10(CommanderBonusType.Intelligence, decimal_4, true);
                        break;
                    }

                    if (gclass22_0.MainFunction != AuroraClassMainFunction.OrbitalMiner &&
                        gclass22_0.MainFunction != AuroraClassMainFunction.FuelHarvester)
                    {
                        if (gclass22_0.MainFunction != AuroraClassMainFunction.ColonyShip &&
                            gclass22_0.MainFunction != AuroraClassMainFunction.Freighter &&
                            gclass22_0.MainFunction != AuroraClassMainFunction.Liner &&
                            gclass22_0.MainFunction != AuroraClassMainFunction.TroopTransport)
                        {
                            if (gclass22_0.MainFunction == AuroraClassMainFunction.Terraformer)
                            {
                                this.method_10(CommanderBonusType.Terraforming, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.MainFunction == AuroraClassMainFunction.Carrier)
                            {
                                this.method_10(CommanderBonusType.CarrierOperations, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.MainFunction == AuroraClassMainFunction.Fighter)
                            {
                                this.method_10(CommanderBonusType.FighterCombat, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.MainFunction == AuroraClassMainFunction.GroundSupportFighter)
                            {
                                this.method_10(CommanderBonusType.GroundSupport, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.MainFunction != AuroraClassMainFunction.ConstructionShip &&
                                gclass22_0.MainFunction != AuroraClassMainFunction.Salvager)
                            {
                                switch (AuroraUtils.GetRandomInteger(5))
                                {
                                    case 1:
                                        this.method_10(CommanderBonusType.Engineering, decimal_4, true);
                                        return;
                                    case 2:
                                        this.method_10(CommanderBonusType.Tactical, decimal_4, true);
                                        return;
                                    default:
                                        this.method_10(CommanderBonusType.CrewTraining, decimal_4, true);
                                        return;
                                }
                            }
                            else
                            {
                                this.method_10(CommanderBonusType.Production, decimal_4, true);
                                break;
                            }
                        }
                        else
                        {
                            this.method_10(CommanderBonusType.Logistics, decimal_4, true);
                            break;
                        }
                    }
                    else
                    {
                        this.method_10(CommanderBonusType.Mining, decimal_4, true);
                        break;
                    }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 378);
        }
    }

    public void method_12(Decimal decimal_4)
    {
        try
        {
            if (this.CommandingFormation.PopulationData != null &&
                this.CommandingFormation.PopulationData.PopulationPoliticalStatus.PoliticalStatusType != PopPoliticalStatusType.ImperialPopulation)
            {
                this.method_10(CommanderBonusType.GroundCombatOccupation, decimal_4, true);
            }
            else
            {
                switch (this.CommandingFormation.method_14())
                {
                    case GEnum55.const_1:
                        int num1 = AuroraUtils.GetRandomInteger(7);
                        if (num1 <= 2)
                        {
                            this.method_10(CommanderBonusType.GroundCombatOffence, decimal_4, true);
                            break;
                        }

                        if (num1 <= 4)
                        {
                            this.method_10(CommanderBonusType.GroundCombatManoeuvre, decimal_4, true);
                            break;
                        }

                        if (num1 <= 6)
                        {
                            this.method_10(CommanderBonusType.GroundCombatTraining, decimal_4, true);
                            break;
                        }

                        if (num1 > 7)
                            break;
                        this.method_10(CommanderBonusType.GroundCombatLogistics, decimal_4, true);
                        break;
                    case GEnum55.const_2:
                        this.method_10(CommanderBonusType.GroundCombatArtillery, decimal_4, true);
                        break;
                    case GEnum55.const_3:
                        this.method_10(CommanderBonusType.GroundCombatAntiAir, decimal_4, true);
                        break;
                    case GEnum55.const_4:
                        int num2 = AuroraUtils.GetRandomInteger(7);
                        if (num2 <= 3)
                        {
                            this.method_10(CommanderBonusType.GroundCombatDefence, decimal_4, true);
                            break;
                        }

                        if (num2 <= 6)
                        {
                            this.method_10(CommanderBonusType.GroundCombatTraining, decimal_4, true);
                            break;
                        }

                        if (num2 > 7)
                            break;
                        this.method_10(CommanderBonusType.GroundCombatLogistics, decimal_4, true);
                        break;
                    case GEnum55.const_5:
                        if (AuroraUtils.GetRandomInteger(3) <= 2)
                        {
                            this.method_10(CommanderBonusType.Production, decimal_4, true);
                            break;
                        }

                        this.method_10(CommanderBonusType.Xenoarchaeology, decimal_4, true);
                        break;
                    case GEnum55.const_6:
                        this.method_10(CommanderBonusType.Survey, decimal_4, true);
                        break;
                    case GEnum55.const_7:
                        this.method_10(CommanderBonusType.Tactical, decimal_4, true);
                        break;
                    case GEnum55.const_8:
                        this.method_10(CommanderBonusType.Xenoarchaeology, decimal_4, true);
                        break;
                    case GEnum55.const_9:
                        this.method_10(CommanderBonusType.GroundCombatLogistics, decimal_4, true);
                        break;
                    case GEnum55.const_10:
                        this.method_10(CommanderBonusType.Decontamination, decimal_4, true);
                        break;
                    default:
                        int num3 = AuroraUtils.GetRandomInteger(7);
                        if (num3 == 1)
                        {
                            this.method_10(CommanderBonusType.GroundCombatOffence, decimal_4, true);
                            break;
                        }

                        if (num3 <= 3)
                        {
                            this.method_10(CommanderBonusType.GroundCombatDefence, decimal_4, true);
                            break;
                        }

                        if (num3 <= 4)
                        {
                            this.method_10(CommanderBonusType.GroundCombatManoeuvre, decimal_4, true);
                            break;
                        }

                        if (num3 <= 6)
                        {
                            this.method_10(CommanderBonusType.GroundCombatTraining, decimal_4, true);
                            break;
                        }

                        if (num3 > 7)
                            break;
                        this.method_10(CommanderBonusType.GroundCombatLogistics, decimal_4, true);
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 379);
        }
    }

    public int method_13()
    {
        return (int)Math.Floor((this.gclass0_0.GameTime - this.CareerStart) / AuroraUtils.decimal_29) +
               this.Species.int_11;
    }

    public int method_14()
    {
        return (int)Math.Floor((this.gclass0_0.GameTime - this.CareerStart) / AuroraUtils.decimal_29);
    }

    public string method_15()
    {
        try
        {
            int num1 = this.method_13();
            int num2 = 0;
            if (num1 > 61)
                num2 = (int)((num1 - 60) / 2.0);
            int num3 = num2 + this.HealthRisk;
            switch (num3)
            {
                case 1:
                    return "Excellent";
                case 2:
                    return "Good";
                default:
                    if (num3 < 5)
                        return "Fair";
                    return num3 < 8 ? "Poor" : "Very Poor";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 380);
            return "error";
        }
    }

    public Color method_16()
    {
        try
        {
            if (this.LifePod != null)
                return AuroraUtils.color_11;
            if (this.Prisoner)
                return Color.Magenta;
            int num1 = this.method_13();
            int num2 = 0;
            if (num1 > 61)
                num2 = (int)((num1 - 60) / 2.0);
            int num3 = num2 + this.HealthRisk;
            if (num3 < 5)
                return AuroraUtils.color_16;
            return num3 < 8 ? Color.Orange : Color.Red;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 381);
            return AuroraUtils.color_16;
        }
    }

    public string method_17(bool bool_6)
    {
        try
        {
            string str = "";
            if (this.RetirementStatus != AuroraRetirementStatus.Active)
                return AuroraUtils.smethod_82(this.RetirementStatus);
            switch (this.CommandType)
            {
                case AuroraCommandType.None:
                    str = "Unassigned";
                    break;
                case AuroraCommandType.Ship:
                    if (this.CommandingShip.gclass85_0.method_179() == 1)
                    {
                        str = string.Format("C.O. {0}", this.CommandingShip.method_187());
                        if (bool_6)
                        {
                            str = string.Format("CO {0}", this.CommandingShip.method_187());
                            break;
                        }

                        break;
                    }

                    if (this.CommandingShip.gclass85_0.method_162() == this)
                    {
                        str = string.Format("Fleet Commander:  {0}", this.CommandingShip.gclass85_0.FleetName);
                        if (bool_6)
                        {
                            str = string.Format("FCO {0}", this.CommandingShip.gclass85_0.FleetName);
                            break;
                        }

                        break;
                    }

                    str = string.Format("C.O. {0}", this.CommandingShip.method_187());
                    if (bool_6)
                    {
                        str = string.Format("CO {0}", this.CommandingShip.method_187());
                        break;
                    }

                    break;
                case AuroraCommandType.Colony:
                    str = string.Format("Planetary Governor:  {0}", this.GoverningPopulation.PopName);
                    if (bool_6)
                    {
                        str = string.Format("GOV {0}", this.GoverningPopulation.PopName);
                        break;
                    }

                    break;
                case AuroraCommandType.Sector:
                    str = string.Format("Sector Commander:  {0}", this.CommandingSector.SectorName);
                    if (bool_6)
                    {
                        str = string.Format("SEC {0}", this.CommandingSector.SectorName);
                        break;
                    }

                    break;
                case AuroraCommandType.GroundFormation:
                    str = string.Format("C.O. {0}", this.CommandingFormation.method_45());
                    if (bool_6)
                    {
                        str = string.Format("CO {0}", this.CommandingFormation.method_45());
                        break;
                    }

                    break;
                case AuroraCommandType.ResearchProject:
                    str = string.Format("Research Project:  {0}", this.ResearchingProject.gclass164_0.Name);
                    if (bool_6)
                    {
                        str = string.Format("RES {0}", this.ResearchingProject.gclass164_0.Name);
                        break;
                    }

                    break;
                case AuroraCommandType.ExecutiveOfficer:
                    str = string.Format("Executive Officer {0}", this.ShipOnboardAsXO.method_187());
                    if (bool_6)
                    {
                        str = string.Format("XO {0}", this.ShipOnboardAsXO.method_187());
                        break;
                    }

                    break;
                case AuroraCommandType.ChiefEngineer:
                    str = string.Format("Chief Engineer {0}", this.ShipOnboardAsChiefEngi.method_187());
                    if (bool_6)
                    {
                        str = string.Format("ENG {0}", this.ShipOnboardAsChiefEngi.method_187());
                        break;
                    }

                    break;
                case AuroraCommandType.ScienceOfficer:
                    str = string.Format("Science Officer {0}", this.ShipOnboardAsScienceOfficer.method_187());
                    if (bool_6)
                    {
                        str = string.Format("SCI {0}", this.ShipOnboardAsScienceOfficer.method_187());
                        break;
                    }

                    break;
                case AuroraCommandType.TacticalOfficer:
                    str = string.Format("Tactical Officer {0}", this.ShipOnboardAsTactician.method_187());
                    if (bool_6)
                    {
                        str = string.Format("TAC {0}", this.ShipOnboardAsTactician.method_187());
                        break;
                    }

                    break;
                case AuroraCommandType.NavalAdminCommand:
                    str = string.Format("Administrative Command:  {0}", this.CurrentAdmin.AdminCommandName);
                    if (bool_6)
                    {
                        str = string.Format("NAC {0}", this.CurrentAdmin.AdminCommandName);
                        break;
                    }

                    break;
                case AuroraCommandType.CAG:
                    str = string.Format("Commander, Air Group {0}", this.ShipOnboardAsCAG.method_187());
                    if (bool_6)
                    {
                        str = string.Format("CAG {0}", this.ShipOnboardAsCAG.method_187());
                        break;
                    }

                    break;
                case AuroraCommandType.AcademyCommandant:
                    str = string.Format("Academy Commandant:  {0}", this.PopulationAsAcademyCommandant.PopName);
                    if (bool_6)
                    {
                        str = string.Format("ACM {0}", this.PopulationAsAcademyCommandant.PopName);
                        break;
                    }

                    break;
            }

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 382);
            return "error";
        }
    }

    public string method_18()
    {
        try
        {
            string str = "";
            switch (this.CommandType)
            {
                case AuroraCommandType.None:
                    str = "N/A";
                    break;
                case AuroraCommandType.Ship:
                    str = this.CommandingShip.method_187();
                    break;
                case AuroraCommandType.Colony:
                    str = this.GoverningPopulation.PopName;
                    break;
                case AuroraCommandType.Sector:
                    str = this.CommandingSector.gclass146_0.PopName;
                    break;
                case AuroraCommandType.GroundFormation:
                    str = this.CommandingFormation.method_46();
                    break;
                case AuroraCommandType.ResearchProject:
                    str = this.ResearchingProject.gclass146_0.PopName;
                    break;
                case AuroraCommandType.ExecutiveOfficer:
                    str = this.ShipOnboardAsXO.method_187();
                    break;
                case AuroraCommandType.ChiefEngineer:
                    str = this.ShipOnboardAsChiefEngi.method_187();
                    break;
                case AuroraCommandType.ScienceOfficer:
                    str = this.ShipOnboardAsScienceOfficer.method_187();
                    break;
                case AuroraCommandType.TacticalOfficer:
                    str = this.ShipOnboardAsTactician.method_187();
                    break;
                case AuroraCommandType.NavalAdminCommand:
                    if (this.CurrentAdmin.Population != null)
                    {
                        str = this.CurrentAdmin.Population.PopName;
                        break;
                    }

                    if (this.CurrentAdmin.gclass40_0 != null)
                    {
                        str = this.CurrentAdmin.gclass40_0.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.CAG:
                    str = this.ShipOnboardAsCAG.method_187();
                    break;
                case AuroraCommandType.AcademyCommandant:
                    str = this.PopulationAsAcademyCommandant.PopName;
                    break;
            }

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 383);
            return "error";
        }
    }

    public void method_19(
        ListView listView_0,
        ListView listView_1,
        ListView listView_2,
        ListView listView_3,
        ComboBox comboBox_0,
        CheckBox checkBox_0,
        CheckBox checkBox_1,
        Label label_0,
        Label label_1,
        Commander gclass55_0,
        FlowLayoutPanel flowLayoutPanel_0,
        CheckBox checkBox_2,
        CheckBox checkBox_3)
    {
        try
        {
            listView_0.Items.Clear();
            this.method_27();
            label_0.Text = this.method_36();
            label_1.Text = string.Format("    {0}", this.method_17(false));
            string string_11 = "Unknown";
            if (this.EducatedColony != null)
            {
                string_11 = this.EducatedColony.PopName;
                if (this.EducatedColony.AcademyName != "")
                    string_11 = this.EducatedColony.AcademyName;
            }

            checkBox_2.CheckState = AuroraUtils.smethod_28(this.DoNotPromote);
            checkBox_2.CheckState = AuroraUtils.smethod_28(this.DoNotPromote);
            this.gclass0_0.method_597(listView_0, "Homeworld", this.HomeworldSystem.method_78(this.Race));
            if (this.CommanderType != AuroraCommanderType.Naval &&
                this.CommanderType != AuroraCommanderType.GroundForce)
            {
                this.gclass0_0.method_597(listView_0, "University", string_11);
                this.gclass0_0.method_597(listView_0, "Age and Health",
                    string.Format("{0} / {1}", this.method_13().ToString(), this.method_15()));
                this.gclass0_0.method_597(listView_0, "Career Start Date",
                    this.gclass0_0.method_583((double)this.CareerStart));
            }
            else
            {
                this.gclass0_0.method_597(listView_0, "Military Academy", string_11);
                this.gclass0_0.method_597(listView_0, "Age and Health",
                    string.Format("{0} / {1}", this.method_13().ToString(), this.method_15()));
                this.gclass0_0.method_597(listView_0, "Date of Commission",
                    this.gclass0_0.method_583((double)this.CareerStart));
                this.gclass0_0.method_597(listView_0, "Promotion Score", AuroraUtils.smethod_37(this.PromotionScore));
            }

            this.gclass0_0.method_594(listView_0, "");
            this.method_20(listView_0);
            this.method_30(listView_1, true);
            this.gclass0_0.method_594(listView_1, "");
            foreach (int num in this.Traits)
                this.gclass0_0.method_595(listView_1, this.gclass0_0.TraitNameDictionary[num], num);
            this.method_47(listView_2);
            if (gclass55_0 == null)
                this.gclass0_0.method_510(comboBox_0, this.CommanderType);
            else if (gclass55_0.CommanderType == this.CommanderType)
                this.method_25((AssignmentTypeFilter)comboBox_0.SelectedValue, listView_3, checkBox_0, checkBox_1);
            else
                this.gclass0_0.method_510(comboBox_0, this.CommanderType);
            checkBox_3.CheckState = !this.StoryCharacter ? CheckState.Unchecked : CheckState.Checked;
            this.method_21(flowLayoutPanel_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 384);
        }
    }

    public void method_20(ListView listView_0)
    {
        try
        {
            foreach (Measurement gclass54 in this.Measurements.Values
                         .OrderBy<Measurement, string>(gclass54_0 =>
                             AuroraUtils.smethod_82(gclass54_0.MeasurementType)).ToList<Measurement>())
                this.gclass0_0.method_601(listView_0, AuroraUtils.smethod_82(gclass54.MeasurementType),
                    AuroraUtils.smethod_38(gclass54.Amount), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 385);
        }
    }

    public void method_21(FlowLayoutPanel flowLayoutPanel_0)
    {
        try
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 20000;
            toolTip.InitialDelay = 250;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            flowLayoutPanel_0.Controls.Clear();
            foreach (CommanderMedal gclass53 in this.dictionary_1.Values
                         .OrderByDescending<CommanderMedal, int>(gclass53_0 => gclass53_0.gclass42_0.MedalPoints)
                         .ToList<CommanderMedal>())
            {
                for (int index = 1; index <= gclass53.int_0; ++index)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = gclass53.gclass42_0.MedalImageLoaded;
                    pictureBox.Margin = new Padding(0, 0, 2, 1);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    flowLayoutPanel_0.Controls.Add(pictureBox);
                    toolTip.SetToolTip(pictureBox, gclass53.string_0);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 386);
        }
    }

    public void method_22(ShipData gclass40_7, AuroraCommandType auroraCommandType_1)
    {
        try
        {
            string str = "";
            if (gclass40_7 == null)
                return;
            this.method_40(false);
            gclass40_7.method_192(auroraCommandType_1)?.method_40(true);
            switch (auroraCommandType_1)
            {
                case AuroraCommandType.Ship:
                    this.CommandingShip = gclass40_7;
                    this.CommandType = AuroraCommandType.Ship;
                    str = "Commanding Officer";
                    this.CommandingShip.Officers.Remove(AuroraCommandType.Ship);
                    this.CommandingShip.Officers.Add(AuroraCommandType.Ship, this);
                    break;
                case AuroraCommandType.ExecutiveOfficer:
                    this.ShipOnboardAsXO = gclass40_7;
                    this.CommandType = AuroraCommandType.ExecutiveOfficer;
                    str = "Executive Officer";
                    this.ShipOnboardAsXO.Officers.Remove(AuroraCommandType.ExecutiveOfficer);
                    this.ShipOnboardAsXO.Officers.Add(AuroraCommandType.ExecutiveOfficer, this);
                    break;
                case AuroraCommandType.ChiefEngineer:
                    this.ShipOnboardAsChiefEngi = gclass40_7;
                    this.CommandType = AuroraCommandType.ChiefEngineer;
                    str = "Chief Engineer ";
                    this.ShipOnboardAsChiefEngi.Officers.Remove(AuroraCommandType.ChiefEngineer);
                    this.ShipOnboardAsChiefEngi.Officers.Add(AuroraCommandType.ChiefEngineer, this);
                    break;
                case AuroraCommandType.ScienceOfficer:
                    this.ShipOnboardAsScienceOfficer = gclass40_7;
                    this.CommandType = AuroraCommandType.ScienceOfficer;
                    str = "Science Officer";
                    this.ShipOnboardAsScienceOfficer.Officers.Remove(AuroraCommandType.ScienceOfficer);
                    this.ShipOnboardAsScienceOfficer.Officers.Add(AuroraCommandType.ScienceOfficer, this);
                    break;
                case AuroraCommandType.TacticalOfficer:
                    this.ShipOnboardAsTactician = gclass40_7;
                    this.CommandType = AuroraCommandType.TacticalOfficer;
                    str = "Tactical Officer";
                    this.ShipOnboardAsTactician.Officers.Remove(AuroraCommandType.TacticalOfficer);
                    this.ShipOnboardAsTactician.Officers.Add(AuroraCommandType.TacticalOfficer, this);
                    break;
                case AuroraCommandType.CAG:
                    this.ShipOnboardAsCAG = gclass40_7;
                    this.CommandType = AuroraCommandType.CAG;
                    str = "Commander, Air Group";
                    this.ShipOnboardAsCAG.Officers.Remove(AuroraCommandType.CAG);
                    this.ShipOnboardAsCAG.Officers.Add(AuroraCommandType.CAG, this);
                    break;
            }

            this.TransportShip = gclass40_7;
            this.GameTimeAssigned = this.gclass0_0.GameTime;
            this.AddHistory(string.Format("Assigned as {0} of {1}", str, gclass40_7.method_187()), HistoryType.ShipRelated);
            gclass40_7.method_204(string.Format("{0} assigned as {1}", this.method_36(), str));
            this.gclass0_0.gclass92_0.method_2(EventType.const_78,
                string.Format("{0} assigned as {1} of {2}", this.method_36(), str, gclass40_7.method_187()), this.Race,
                gclass40_7.gclass85_0.System.ActualSystem, gclass40_7.gclass85_0.XCoord,
                gclass40_7.gclass85_0.YCoord, AuroraEventCategory.Commander);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 388);
        }
    }

    public void method_23(GroundUnitFormationData gclass103_1)
    {
        try
        {
            if (gclass103_1 == null)
                return;
            this.method_40(false);
            if (gclass103_1.Commander != null)
                gclass103_1.Commander.method_40(true);
            this.CommandingFormation = gclass103_1;
            this.CommandType = AuroraCommandType.GroundFormation;
            this.AddHistory(string.Format("Assigned as Commanding Officer of {0}", gclass103_1.method_45()), HistoryType.ShipRelated);
            this.gclass0_0.gclass92_0.method_2(EventType.const_78,
                string.Format("{0} assigned as Commanding Officer of {1}", this.method_36(), gclass103_1.method_45()), this.Race,
                null, 0.0, 0.0, AuroraEventCategory.Commander);
            this.TransportShip = gclass103_1.ShipData;
            this.Population = gclass103_1.PopulationData;
            gclass103_1.Commander = this;
            this.GameTimeAssigned = this.gclass0_0.GameTime;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 389);
        }
    }

    public void method_24(AssignmentTypeFilter gclass49_0, ListView listView_0)
    {
        try
        {
            if (gclass49_0.IsForSector)
            {
                Sector tag = (Sector)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    if (this.method_5(CommanderBonusType.ColonyAdmnistration) < tag.int_1)
                    {
                        int num = (int)MessageBox.Show(
                            string.Format("The Admin Rating of {0} is too low for this assignment", this.Name));
                        return;
                    }

                    if (tag.SectorCommander == this)
                    {
                        int num = (int)MessageBox.Show(string.Format("{0} is already assigned to this role",
                            this.Name));
                        return;
                    }

                    this.method_40(false);
                    if (tag.SectorCommander != null)
                        tag.SectorCommander.method_40(true);
                    this.CommandingSector = tag;
                    this.CommandType = AuroraCommandType.Sector;
                    this.Population = tag.gclass146_0;
                    this.GameTimeAssigned = this.gclass0_0.GameTime;
                    tag.SectorCommander = this;
                    this.AddHistory(string.Format("Assigned to {0}", tag.SectorName), HistoryType.ShipRelated);
                }
            }

            if (gclass49_0.IsForPopulation)
            {
                PopulationData tag = (PopulationData)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    if (this.method_5(CommanderBonusType.ColonyAdmnistration) < tag.int_17)
                    {
                        int num = (int)MessageBox.Show(
                            string.Format("The Admin Rating of {0} is too low for this assignment", this.Name));
                        return;
                    }

                    if (tag.Governer == this)
                    {
                        int num = (int)MessageBox.Show(string.Format("{0} is already assigned to this role",
                            this.Name));
                        return;
                    }

                    this.method_40(false);
                    if (tag.Governer != null)
                        tag.Governer.method_40(true);
                    this.GoverningPopulation = tag;
                    this.CommandType = AuroraCommandType.Colony;
                    this.Population = tag;
                    this.GameTimeAssigned = this.gclass0_0.GameTime;
                    tag.Governer = this;
                    this.AddHistory(string.Format("Assigned to {0}", tag.PopName), HistoryType.ShipRelated);
                }
            }

            if (gclass49_0.IsForAcademy)
            {
                PopulationData tag = (PopulationData)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    Commander gclass55 = tag.method_82();
                    if (gclass55 == this)
                    {
                        int num = (int)MessageBox.Show(string.Format("{0} is already assigned to this role",
                            this.Name));
                        return;
                    }

                    this.method_40(false);
                    gclass55?.method_40(true);
                    this.PopulationAsAcademyCommandant = tag;
                    this.CommandType = AuroraCommandType.AcademyCommandant;
                    this.Population = tag;
                    this.GameTimeAssigned = this.gclass0_0.GameTime;
                    this.AddHistory(string.Format("Assigned as Academy Commandant on {0}", tag.PopName), HistoryType.ShipRelated);
                }
            }

            if (gclass49_0.IsForShip)
            {
                ShipData tag = (ShipData)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    if (gclass49_0.ShipboardPosition == AuroraCommandType.Ship &&
                        this.RacialRank.RankNum > tag.Class.RacialRankTheme.RankNum)
                    {
                        int num = (int)MessageBox.Show(string.Format("{0} is too junior for this assignment",
                            this.Name));
                        return;
                    }

                    if (gclass49_0.ShipboardPosition != AuroraCommandType.Ship && this.RacialRank.RankNum !=
                        tag.Class.RacialRankTheme.RankNum + gclass49_0.RankPriorityModifier)
                    {
                        int num = (int)MessageBox.Show(string.Format("{0} is not the required rank for this assignment",
                            this.Name));
                        return;
                    }

                    if (tag.method_192(gclass49_0.ShipboardPosition) == this)
                    {
                        int num = (int)MessageBox.Show(string.Format("{0} is already assigned to this role",
                            this.Name));
                        return;
                    }

                    this.method_22(tag, gclass49_0.ShipboardPosition);
                }
            }

            if (gclass49_0.IsForGround)
            {
                GroundUnitFormationData tag = (GroundUnitFormationData)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    if (this.RacialRank.RankNum > tag.method_31())
                    {
                        int num = (int)MessageBox.Show(string.Format("The rank of {0} is too low for this assignment",
                            this.Name));
                        return;
                    }

                    if (tag.Commander == this)
                    {
                        int num = (int)MessageBox.Show(string.Format("{0} is already assigned to this role",
                            this.Name));
                        return;
                    }

                    this.method_23(tag);
                }
            }

            if (!gclass49_0.IsForNavalAdmin)
                return;
            NavalAdminCommand tag1 = (NavalAdminCommand)listView_0.SelectedItems[0].Tag;
            if (tag1 == null)
                return;
            if (this.RacialRank.RankNum > tag1.gclass61_0.RankNum)
            {
                int num1 = (int)MessageBox.Show(string.Format("The rank of {0} is too low for this assignment",
                    this.Name));
            }
            else if (tag1.gclass55_0 == this)
            {
                int num2 = (int)MessageBox.Show(string.Format("{0} is already assigned to this role", this.Name));
            }
            else
            {
                this.method_40(false);
                if (tag1.gclass55_0 != null)
                    tag1.gclass55_0.method_40(true);
                this.CurrentAdmin = tag1;
                this.CommandType = AuroraCommandType.NavalAdminCommand;
                this.Population = tag1.Population;
                this.TransportShip = tag1.gclass40_0;
                this.GameTimeAssigned = this.gclass0_0.GameTime;
                tag1.gclass55_0 = this;
                this.AddHistory(string.Format("Assigned to {0}", tag1.AdminCommandName), HistoryType.ShipRelated);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 390);
        }
    }

    public void method_25(
        AssignmentTypeFilter gclass49_0,
        ListView listView_0,
        CheckBox checkBox_0,
        CheckBox checkBox_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Commander.Class911 class911 = new Commander.Class911();
        // ISSUE: reference to a compiler-generated field
        class911.gclass55_0 = this;
        // ISSUE: reference to a compiler-generated field
        class911.checkBox_0 = checkBox_0;
        // ISSUE: reference to a compiler-generated field
        class911.checkBox_1 = checkBox_1;
        // ISSUE: reference to a compiler-generated field
        class911.gclass49_0 = gclass49_0;
        try
        {
            listView_0.Items.Clear();
            // ISSUE: reference to a compiler-generated field
            if (class911.gclass49_0.IsForSector)
            {
                listView_0.Columns[0].Width = 40;
                listView_0.Columns[1].Width = 380;
                listView_0.Columns[2].Width = 0;
                listView_0.Columns[3].Width = 0;
                foreach (Sector gclass62 in this.Race.Sectors.Values)
                    gclass62.method_3();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                foreach (Sector object_1 in this.Race.Sectors.Values.Where<Sector>(class911.method_0)
                             .Where<Sector>(class911.method_1)
                             .OrderByDescending<Sector, int>(gclass62_0 => gclass62_0.int_1)
                             .ThenBy<Sector, string>(gclass62_0 => gclass62_0.SectorName).ToList<Sector>())
                    this.gclass0_0.method_599(listView_0, string.Format("A{0}", object_1.int_1), object_1.SectorName,
                        AuroraUtils.color_2, object_1);
            }

            // ISSUE: reference to a compiler-generated field
            if (class911.gclass49_0.IsForPopulation)
            {
                listView_0.Columns[0].Width = 40;
                listView_0.Columns[1].Width = 380;
                listView_0.Columns[2].Width = 0;
                listView_0.Columns[3].Width = 0;
                // ISSUE: reference to a compiler-generated method
                List<PopulationData> list = this.gclass0_0.Populations.Values.Where<PopulationData>(class911.method_2)
                    .ToList<PopulationData>();
                foreach (PopulationData gclass146 in list)
                    gclass146.method_152();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                foreach (PopulationData object_1 in list.Where<PopulationData>(class911.method_3)
                             .Where<PopulationData>(class911.method_4)
                             .OrderByDescending<PopulationData, int>(gclass146_0 => gclass146_0.int_17)
                             .ThenBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName).ToList<PopulationData>())
                {
                    if (object_1.Governer == null)
                        this.gclass0_0.method_598(listView_0, string.Format("A{0}", object_1.int_17), object_1.PopName,
                            object_1);
                    else
                        this.gclass0_0.method_599(listView_0, string.Format("A{0}", object_1.int_17), object_1.PopName,
                            Color.LightGray, object_1);
                }
            }

            // ISSUE: reference to a compiler-generated field
            if (class911.gclass49_0.IsForAcademy)
            {
                listView_0.Columns[0].Width = 40;
                listView_0.Columns[1].Width = 380;
                listView_0.Columns[2].Width = 0;
                listView_0.Columns[3].Width = 0;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                foreach (PopulationData object_1 in this.gclass0_0.Populations.Values.Where<PopulationData>(class911.method_5)
                             .Where<PopulationData>(class911.method_6)
                             .OrderByDescending<PopulationData, int>(gclass146_0 =>
                                 gclass146_0.method_73(AuroraInstallationType.MilitaryAcademy))
                             .ThenBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName).ToList<PopulationData>())
                {
                    Commander gclass55 = object_1.method_82();
                    int genum15_0 = object_1.method_73(AuroraInstallationType.MilitaryAcademy);
                    if (this.CommanderType == AuroraCommanderType.Administrator)
                    {
                        if (this.method_5(CommanderBonusType.ColonyAdmnistration) >= genum15_0)
                        {
                            if (gclass55 == null)
                                this.gclass0_0.method_598(listView_0, string.Format("A{0}", genum15_0), object_1.PopName,
                                    object_1);
                            else
                                this.gclass0_0.method_599(listView_0, string.Format("A{0}", genum15_0), object_1.PopName,
                                    Color.LightGray, object_1);
                        }
                    }
                    else if (this.CommanderType == AuroraCommanderType.Scientist)
                    {
                        Decimal num = 5M;
                        if (this.gclass0_0.LimitedLabs == 1)
                            num = 1M;
                        if (this.method_5(CommanderBonusType.ResearchAdmin) / num >= genum15_0)
                        {
                            if (gclass55 == null)
                                this.gclass0_0.method_598(listView_0, string.Format("RA{0}", genum15_0), object_1.PopName,
                                    object_1);
                            else
                                this.gclass0_0.method_599(listView_0, string.Format("RA{0}", genum15_0), object_1.PopName,
                                    Color.LightGray, object_1);
                        }
                    }
                    else if (this.CommanderType == AuroraCommanderType.Naval)
                    {
                        RacialRank gclass61 = this.Race.GetRankThemeForCommanderLevel((CommanderLevel)genum15_0, AuroraCommanderType.Naval);
                        if (gclass61 != null && this.RacialRank.RankNum <= gclass61.RankNum)
                        {
                            if (gclass55 == null)
                                this.gclass0_0.method_598(listView_0, gclass61.RankAbbreviation, object_1.PopName, object_1);
                            else
                                this.gclass0_0.method_599(listView_0, gclass61.RankAbbreviation, object_1.PopName,
                                    Color.LightGray, object_1);
                        }
                    }
                    else if (this.CommanderType == AuroraCommanderType.GroundForce)
                    {
                        RacialRank gclass61 =
                            this.Race.GetRankThemeForCommanderLevel((CommanderLevel)genum15_0, AuroraCommanderType.GroundForce);
                        if (gclass61 != null && this.RacialRank.RankNum <= gclass61.RankNum)
                        {
                            if (gclass55 == null)
                                this.gclass0_0.method_598(listView_0, gclass61.RankAbbreviation, object_1.PopName, object_1);
                            else
                                this.gclass0_0.method_599(listView_0, gclass61.RankAbbreviation, object_1.PopName,
                                    Color.LightGray, object_1);
                        }
                    }
                }
            }

            // ISSUE: reference to a compiler-generated field
            if (class911.gclass49_0.IsForShip)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Commander.Class912 class912 = new Commander.Class912();
                // ISSUE: reference to a compiler-generated field
                class912.class911_0 = class911;
                listView_0.Columns[0].Width = 45;
                listView_0.Columns[1].Width = 185;
                listView_0.Columns[2].Width = 150;
                listView_0.Columns[3].Width = 40;
                // ISSUE: reference to a compiler-generated field
                class912.int_0 = this.Race.method_232();
                // ISSUE: reference to a compiler-generated method
                List<ShipData> list = this.gclass0_0.Ships.Values
                    .Where<ShipData>(class912.method_0).ToList<ShipData>();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                foreach (ShipData object_1 in
                         class912.class911_0.gclass49_0.ShipboardPosition != AuroraCommandType.Ship
                             ? list.Where<ShipData>(class912.class911_0.method_9)
                                 .Where<ShipData>(class912.class911_0.method_10)
                                 .Where<ShipData>(class912.class911_0.method_11)
                                 .Where<ShipData>(class912.class911_0.method_12)
                                 .Where<ShipData>(class912.class911_0.method_13)
                                 .Where<ShipData>(class912.class911_0.method_14)
                                 .Where<ShipData>(class912.class911_0.method_15)
                                 .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.Class.RacialRankTheme.RankNum)
                                 .ThenByDescending<ShipData,
                                     Decimal>(gclass40_0 => gclass40_0.Class.Size)
                                 .ThenBy<ShipData, string>(gclass40_0 => gclass40_0.Class.ClassName)
                                 .ThenBy<ShipData, string>(gclass40_0 => gclass40_0.ShipName)
                                 .ToList<ShipData>()
                             : list.Where<ShipData>(class912.class911_0.method_7)
                                 .Where<ShipData>(class912.class911_0.method_8)
                                 .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.Class.RacialRankTheme.RankNum)
                                 .ThenByDescending<ShipData,
                                     Decimal>(gclass40_0 => gclass40_0.Class.Size)
                                 .ThenBy<ShipData, string>(gclass40_0 => gclass40_0.Class.ClassName)
                                 .ThenBy<ShipData, string>(gclass40_0 => gclass40_0.ShipName)
                                 .ToList<ShipData>())
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    RacialRank gclass61 = object_1.Class.RacialRankTheme.method_2(class912.class911_0.gclass49_0.RankPriorityModifier);
                    if (gclass61 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (object_1.method_192(class912.class911_0.gclass49_0.ShipboardPosition) == null)
                            this.gclass0_0.method_604(listView_0, gclass61.RankAbbreviation, object_1.Class.method_34(),
                                object_1.ShipName, string.Format("{0}%", AuroraUtils.smethod_38(object_1.method_189())), object_1);
                        else
                            this.gclass0_0.method_605(listView_0, gclass61.RankAbbreviation, object_1.Class.method_34(),
                                object_1.ShipName, string.Format("{0}%", AuroraUtils.smethod_38(object_1.method_189())), Color.LightGray,
                                object_1);
                    }
                }
            }

            // ISSUE: reference to a compiler-generated field
            if (class911.gclass49_0.IsForGround)
            {
                listView_0.Columns[0].Width = 45;
                listView_0.Columns[1].Width = 45;
                listView_0.Columns[2].Width = 330;
                listView_0.Columns[3].Width = 0;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                foreach (GroundUnitFormationData object_1 in this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class911.method_16)
                             .Where<GroundUnitFormationData>(class911.method_17).Where<GroundUnitFormationData>(class911.method_18)
                             .OrderByDescending<GroundUnitFormationData, int>(gclass103_0 => gclass103_0.method_33())
                             .ThenByDescending<GroundUnitFormationData, Decimal>(gclass103_0 => gclass103_0.method_44())
                             .ThenBy<GroundUnitFormationData, string>(gclass103_0 => gclass103_0.Name).ToList<GroundUnitFormationData>())
                {
                    if (object_1.Commander == null)
                        this.gclass0_0.method_602(listView_0, object_1.method_32().RankAbbreviation, object_1.Abbreviation,
                            object_1.Name, object_1);
                    else
                        this.gclass0_0.method_605(listView_0, object_1.method_32().RankAbbreviation, object_1.Abbreviation,
                            object_1.Name, "", Color.LightGray, object_1);
                }
            }

            // ISSUE: reference to a compiler-generated field
            if (!class911.gclass49_0.IsForNavalAdmin)
                return;
            listView_0.Columns[0].Width = 45;
            listView_0.Columns[1].Width = 375;
            listView_0.Columns[2].Width = 0;
            listView_0.Columns[3].Width = 0;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (NavalAdminCommand object_1 in this.Race.method_255(false).Where<NavalAdminCommand>(class911.method_19)
                         .Where<NavalAdminCommand>(class911.method_20)
                         .OrderBy<NavalAdminCommand, int>(gclass83_0 => gclass83_0.gclass61_0.RankNum)
                         .ThenBy<NavalAdminCommand, string>(gclass83_0 => gclass83_0.AdminCommandName).ToList<NavalAdminCommand>())
            {
                if (object_1.gclass55_0 == null)
                    this.gclass0_0.method_598(listView_0, object_1.gclass61_0.RankAbbreviation, object_1.AdminCommandName,
                        object_1);
                else if (object_1.gclass55_0.RacialRank.RankNum > object_1.gclass61_0.RankNum)
                    this.gclass0_0.method_599(listView_0, object_1.gclass61_0.RankAbbreviation, object_1.AdminCommandName,
                        Color.OrangeRed, object_1);
                else
                    this.gclass0_0.method_599(listView_0, object_1.gclass61_0.RankAbbreviation, object_1.AdminCommandName,
                        Color.LightGray, object_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 391);
        }
    }

    public string method_26()
    {
        try
        {
            string str = this.Name;
            if (this.CommanderType == AuroraCommanderType.Scientist)
                str = string.Format("{0}  {1}%", this.Name,
                    AuroraUtils.FormatNumberToDigits((this.method_5(CommanderBonusType.Research) - 1M) * 100M, 0));
            if (this.RetirementStatus != AuroraRetirementStatus.Active && !this.RetainRetired)
                str += " (DNR)";
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 392);
            return "error";
        }
    }

    public void method_27()
    {
        try
        {
            this.PromotionScore = (int)(Math.Pow((double)(this.method_5(CommanderBonusType.PoliticalReliability) - 1M) * 100.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.CrewTraining) - 1M) * 100.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Reaction) - 1M) * 75.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Survey) - 1M) * 75.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Engineering) - 1M) * 75.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Tactical) - 1M) * 75.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.CarrierOperations) - 1M) * 75.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.FighterCombat) - 1M) * 50.0, 1.75) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundSupport) - 1M) * 50.0, 1.75) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Production) - 1M) * 100.0, 1.5) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Mining) - 1M) * 100.0, 1.5) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Intelligence) - 1M) * 50.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Logistics) - 1M) * 50.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundCombatOccupation) - 1M) * 100.0, 1.75) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundCombatDefence) - 1M) * 100.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundCombatOffence) - 1M) * 100.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundCombatArtillery) - 1M) * 100.0, 1.75) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.Engineering) - 1M) * 100.0, 1.75) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundCombatManoeuvre) - 1M) * 100.0, 2.0) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundCombatLogistics) - 1M) * 100.0, 1.75) +
                               Math.Pow((double)(this.method_5(CommanderBonusType.GroundCombatTraining) - 1M) * 100.0, 2.0));
            Decimal num = 25M * ((this.gclass0_0.GameTime - this.GameTimePromoted) / AuroraUtils.decimal_29);
            if (num > 100M)
                num = 100M;
            this.PromotionScore += (int)num;
            if (this.CommandType != AuroraCommandType.None)
                this.PromotionScore += 25;
            this.PromotionScore +=
                this.dictionary_1.Values.Sum<CommanderMedal>(gclass53_0 =>
                    gclass53_0.int_0 * gclass53_0.gclass42_0.MedalPoints);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 393);
        }
    }

    public void method_28()
    {
        try
        {
            int num1 = AuroraUtils.GetRandomInteger(3) + 1;
            foreach (TraitGroup gclass48 in this.gclass0_0.TraitGroupDictionary.Values)
                gclass48.bool_0 = true;
            for (int index = 1; index <= num1; ++index)
            {
                int key;
                do
                {
                    key = AuroraUtils.GetRandomInteger(6);
                } while (!this.gclass0_0.TraitGroupDictionary[key].bool_0);

                if (this.gclass0_0.TraitGroupDictionary[key].Opposite1ID > 0)
                    this.gclass0_0.TraitGroupDictionary[this.gclass0_0.TraitGroupDictionary[key].Opposite1ID].bool_0 = false;
                if (this.gclass0_0.TraitGroupDictionary[key].OppositeID2 > 0)
                    this.gclass0_0.TraitGroupDictionary[this.gclass0_0.TraitGroupDictionary[key].OppositeID2].bool_0 = false;
                int num2;
                do
                {
                    num2 = this.gclass0_0.TraitGroupDictionary[key].TraitList
                        .ElementAt<int>(
                            AuroraUtils.GetRandomInteger(this.gclass0_0.TraitGroupDictionary[key].TraitList.Count) - 1);
                } while (this.Traits.Contains(num2));

                this.Traits.Add(num2);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 394);
        }
    }

    public string method_29(bool bool_6)
    {
        try
        {
            string string_2 = "";
            foreach (CommanderBonus gclass52 in this.SkillBonuses.Values
                         .OrderBy<CommanderBonus, int>(gclass52_0 => gclass52_0.BonusDefinition.DisplayOrder).ToList<CommanderBonus>())
            {
                string str = !bool_6 ? gclass52.BonusDefinition.Description : gclass52.BonusDefinition.BonusAbbrev;
                if (gclass52.BonusDefinition.Percentage)
                    string_2 = string.Format("{0}{1} {2}%    ", string_2, str,
                        AuroraUtils.smethod_38((gclass52.BonusValue - 1M) * 100M));
                else
                    string_2 = string.Format("{0}{1} {2}    ", string_2, str,
                        AuroraUtils.smethod_38(gclass52.BonusValue));
            }

            return string_2.Length > 0 ? AuroraUtils.smethod_25(string_2, string_2.Length - 2) : "";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 395);
            return "error";
        }
    }

    public void method_30(ListView listView_0, bool bool_6)
    {
        try
        {
            if (bool_6)
                listView_0.Items.Clear();
            foreach (CommanderBonus gclass52 in this.SkillBonuses.Values
                         .OrderBy<CommanderBonus, int>(gclass52_0 => gclass52_0.BonusDefinition.DisplayOrder).ToList<CommanderBonus>())
            {
                if (gclass52.BonusDefinition.Percentage)
                    this.gclass0_0.method_597(listView_0, gclass52.BonusDefinition.Description,
                        string.Format("{0}%", AuroraUtils.smethod_38((gclass52.BonusValue - 1M) * 100M)));
                else
                    this.gclass0_0.method_597(listView_0, gclass52.BonusDefinition.Description,
                        AuroraUtils.smethod_38(gclass52.BonusValue));
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 396);
        }
    }

    public int method_31(int int_11)
    {
        int num = AuroraUtils.GetRandomInteger(100);
        return num > int_11 ? num : int_11;
    }

    public void method_32(
        AuroraCommanderType auroraCommanderType_1,
        CommanderBonusType genum121_0,
        int int_11,
        int int_12,
        int int_13,
        int int_14,
        int int_15,
        int int_16,
        Commander gclass55_0)
    {
        try
        {
            if (this.CommanderType != auroraCommanderType_1 && auroraCommanderType_1 != AuroraCommanderType.All)
                return;
            int int_11_1 = AuroraUtils.GetRandomInteger(100);
            if (gclass55_0 != null && gclass55_0.method_5(genum121_0) >= 1.2M)
                int_11_1 = this.method_31(int_11_1);
            Decimal decimal_4 = 1M;
            if (int_11_1 <= int_11)
                return;
            decimal_4 = int_11_1 > int_12
                ? (int_11_1 > int_13
                    ? (int_11_1 > int_14 ? (int_11_1 > int_15 ? (int_11_1 > int_16 ? 1.3M : 1.25M) : 1.2M) : 1.15M)
                    : 1.1M)
                : 1.05M;
            this.method_9(genum121_0, decimal_4);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 397);
        }
    }

    public void method_33()
    {
        try
        {
            int num = AuroraUtils.GetRandomInteger(100);
            if (num <= 80 /*0x50*/)
                this.HealthRisk = 1;
            else if (num <= 95)
                this.HealthRisk = 2;
            else if (num <= 99)
                this.HealthRisk = 3;
            else
                this.HealthRisk = 5;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 400);
        }
    }

    public void method_34()
    {
        try
        {
            int num = AuroraUtils.GetRandomInteger(100);
            if (num <= 20)
                this.method_9(CommanderBonusType.ColonyAdmnistration, 1M);
            else if (num <= 40)
                this.method_9(CommanderBonusType.ColonyAdmnistration, 2M);
            else if (num <= 60)
                this.method_9(CommanderBonusType.ColonyAdmnistration, 3M);
            else if (num <= 80 /*0x50*/)
                this.method_9(CommanderBonusType.ColonyAdmnistration, 4M);
            else if (num <= 90)
                this.method_9(CommanderBonusType.ColonyAdmnistration, 5M);
            else
                this.method_9(CommanderBonusType.ColonyAdmnistration, 6M);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 401);
        }
    }

    public void method_35()
    {
        try
        {
            int num1 = AuroraUtils.GetRandomInteger(100);
            Decimal num2 = 1M;
            Decimal num3 = 0M;
            if (this.gclass0_0.LimitedLabs == 1)
            {
                num2 = 5M;
                num3 = 1M;
            }

            if (num1 <= 20)
                this.method_9(CommanderBonusType.ResearchAdmin, 5M / num2 + num3);
            else if (num1 <= 50)
                this.method_9(CommanderBonusType.ResearchAdmin, 10M / num2 + num3);
            else if (num1 <= 70)
                this.method_9(CommanderBonusType.ResearchAdmin, 15M / num2 + num3);
            else if (num1 <= 85)
                this.method_9(CommanderBonusType.ResearchAdmin, 20M / num2 + num3);
            else if (num1 <= 95)
                this.method_9(CommanderBonusType.ResearchAdmin, 25M / num2 + num3);
            else
                this.method_9(CommanderBonusType.ResearchAdmin, 30M / num2 + num3);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 402);
        }
    }

    public string method_36()
    {
        try
        {
            if (this.RacialRank != null)
                return string.Format("{0} {1}", this.RacialRank.RankName, this.Name);
            if (this.CommanderType == AuroraCommanderType.Scientist)
                return string.Format("{0} {1}", this.Race.RankScientist, this.Name);
            return this.CommanderType == AuroraCommanderType.Administrator
                ? string.Format("{0} {1}", this.Race.RankAdministrator, this.Name)
                : this.Name;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 403);
            return "error";
        }
    }

    public string method_37()
    {
        try
        {
            string str = "";
            foreach (CommanderMedal gclass53 in this.dictionary_1.Values
                         .OrderByDescending<CommanderMedal, int>(gclass53_0 => gclass53_0.gclass42_0.MedalPoints)
                         .ToList<CommanderMedal>())
            {
                if (!(gclass53.gclass42_0.Abbreviation == ""))
                {
                    if (gclass53.int_0 == 1)
                        str = string.Format("{0}{1} ", str, gclass53.gclass42_0.Abbreviation);
                    else
                        str = string.Format("{0}{1}x {2} ", str, gclass53.int_0.ToString(),
                            gclass53.gclass42_0.Abbreviation);
                }
            }

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 404);
            return "error";
        }
    }

    public string method_38()
    {
        try
        {
            string str = "";
            if (this.RacialRank != null)
                str = this.RacialRank.method_0();
            else if (this.CommanderType == AuroraCommanderType.Administrator)
                str = "CIV";
            else if (this.CommanderType == AuroraCommanderType.Scientist)
                str = "SCI";
            return string.Format("{0} {1}", str, this.Name);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 405);
            return "Error";
        }
    }

    public void method_39(bool bool_6)
    {
        try
        {
            this.method_41(bool_6, true, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 406);
        }
    }

    public void method_40(bool bool_6)
    {
        try
        {
            this.method_41(bool_6, false, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3241);
        }
    }

    public void method_41(bool bool_6, bool bool_7, bool bool_8)
    {
        try
        {
            string str = "";
            if (this.PopulationAsAcademyCommandant != null && bool_8)
                str = string.Format("elieved as Academy Commandant on {0}", this.PopulationAsAcademyCommandant.PopName);
            if (this.ResearchingProject != null)
                str = string.Format("elieved from leadership of {0} research project",
                    this.ResearchingProject.gclass164_0.Name);
            else if (this.CommandingFormation != null)
            {
                str = string.Format("elieved from command of {0}", this.CommandingFormation.method_45());
                this.CommandingFormation.Commander = null;
            }
            else if (this.GoverningPopulation != null)
            {
                str = string.Format("elieved from command of {0}", this.GoverningPopulation.PopName);
                this.GoverningPopulation.Governer = null;
            }
            else if (this.CommandingSector != null)
            {
                str = string.Format("elieved from command of {0}", this.CommandingSector.SectorName);
                this.CommandingSector.SectorCommander = null;
            }
            else if (this.CurrentAdmin != null)
            {
                str = string.Format("elieved from command of {0}", this.CurrentAdmin.AdminCommandName);
                this.CurrentAdmin.gclass55_0 = null;
            }
            else if (this.CommandingShip != null)
            {
                str = string.Format("elieved from command of {0}", this.CommandingShip.method_187());
                this.CommandingShip.Officers.Remove(AuroraCommandType.Ship);
            }
            else if (this.ShipOnboardAsXO != null)
            {
                str = string.Format("elieved as executive officer of {0}", this.ShipOnboardAsXO.method_187());
                this.ShipOnboardAsXO.Officers.Remove(AuroraCommandType.ExecutiveOfficer);
            }
            else if (this.ShipOnboardAsChiefEngi != null)
            {
                str = string.Format("elieved as Chief Engineer of {0}", this.ShipOnboardAsChiefEngi.method_187());
                this.ShipOnboardAsChiefEngi.Officers.Remove(AuroraCommandType.ChiefEngineer);
            }
            else if (this.ShipOnboardAsScienceOfficer != null)
            {
                str = string.Format("elieved as Science Officer of {0}", this.ShipOnboardAsScienceOfficer.method_187());
                this.ShipOnboardAsScienceOfficer.Officers.Remove(AuroraCommandType.ScienceOfficer);
            }
            else if (this.ShipOnboardAsTactician != null)
            {
                str = string.Format("elieved as Tactical Officer of {0}", this.ShipOnboardAsTactician.method_187());
                this.ShipOnboardAsTactician.Officers.Remove(AuroraCommandType.TacticalOfficer);
            }
            else if (this.ShipOnboardAsCAG != null)
            {
                str = string.Format("elieved as Commander, Air Group on {0}", this.ShipOnboardAsCAG.method_187());
                this.ShipOnboardAsCAG.Officers.Remove(AuroraCommandType.CAG);
            }

            if (bool_6 && str != "")
                this.AddHistory(string.Format("R{0}", str), HistoryType.AlienRelated);
            if (bool_7 && str != "")
                this.gclass0_0.gclass92_0.method_2(EventType.const_78,
                    string.Format("As a result of promotion, {0} was r{1}", this.Name, str), this.Race, null, 0.0, 0.0,
                    AuroraEventCategory.Commander);
            if (this.ResearchingProject != null)
                this.ResearchingProject.method_0();
            this.CommandType = AuroraCommandType.None;
            this.GoverningPopulation = null;
            this.PopulationAsAcademyCommandant = null;
            this.CommandingFormation = null;
            this.CommandingShip = null;
            this.CurrentAdmin = null;
            this.CommandingSector = null;
            this.ResearchingProject = null;
            this.ShipOnboardAsXO = null;
            this.ShipOnboardAsChiefEngi = null;
            this.ShipOnboardAsScienceOfficer = null;
            this.ShipOnboardAsTactician = null;
            this.ShipOnboardAsCAG = null;
            this.Population = null;
            this.TransportShip = null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 407);
        }
    }

    public void SetToRetired(AuroraRetirementStatus auroraRetirementStatus_1)
    {
        try
        {
            this.RetirementStatus = auroraRetirementStatus_1;
            this.method_40(true);
            if (!this.gclass0_0.RetiredCommanders.ContainsKey(this.CommanderID))
                this.gclass0_0.RetiredCommanders.Add(this.CommanderID, this);
            this.gclass0_0.ActiveCommanders.Remove(this.CommanderID);
            if (this.RacialRank == null)
                return;
            this.Race.method_249(this.RacialRank);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 408);
        }
    }

    public string method_43()
    {
        try
        {
            string str = "";
            if (this.CommandType == AuroraCommandType.Ship ||
                this.CommandType == AuroraCommandType.ExecutiveOfficer ||
                this.CommandType == AuroraCommandType.ScienceOfficer ||
                this.CommandType == AuroraCommandType.TacticalOfficer ||
                this.CommandType == AuroraCommandType.ChiefEngineer ||
                this.CommandType == AuroraCommandType.CAG)
                str = AuroraUtils.smethod_82(this.CommandType);
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3670);
            return "";
        }
    }

    public ShipData method_44()
    {
        try
        {
            if (this.CommandType == AuroraCommandType.Ship)
                return this.CommandingShip;
            if (this.CommandType == AuroraCommandType.ExecutiveOfficer)
                return this.ShipOnboardAsXO;
            if (this.CommandType == AuroraCommandType.ScienceOfficer)
                return this.ShipOnboardAsScienceOfficer;
            if (this.CommandType == AuroraCommandType.TacticalOfficer)
                return this.ShipOnboardAsTactician;
            if (this.CommandType == AuroraCommandType.ChiefEngineer)
                return this.ShipOnboardAsChiefEngi;
            return this.CommandType == AuroraCommandType.CAG ? this.ShipOnboardAsCAG : null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3671);
            return null;
        }
    }

    public void method_45(string string_4)
    {
        try
        {
            ShipData gclass40 = this.method_44();
            if (gclass40 != null)
                return;
            string str = this.method_43();
            if (!(str != ""))
                return;
            gclass40.method_204(string.Format("{0} {1} {2}", str, this.method_36(), string_4));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3672);
        }
    }

    public void AddHistory(string description, HistoryType genum28_0)
    {
        try
        {
            if (genum28_0 == HistoryType.ShipRelated)
            {
                foreach (HistoryRecord gclass177 in this.Histories.Where<HistoryRecord>(gclass177_0 =>
                             gclass177_0.genum28_0 == HistoryType.AlienRelated &&
                             gclass177_0.GameTime == this.gclass0_0.GameTime).ToList<HistoryRecord>())
                    this.Histories.Remove(gclass177);
            }

            this.Histories.Add(new HistoryRecord()
            {
                GameTime = this.gclass0_0.GameTime,
                Description = description,
                genum28_0 = genum28_0
            });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 409);
        }
    }

    public void method_47(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            this.Histories = this.Histories.OrderByDescending<HistoryRecord, Decimal>(gclass177_0 => gclass177_0.GameTime)
                .ToList<HistoryRecord>();
            foreach (HistoryRecord object_1 in this.Histories)
                this.gclass0_0.method_598(listView_0, this.gclass0_0.method_583((double)object_1.GameTime),
                    object_1.Description, object_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 410);
        }
    }
}