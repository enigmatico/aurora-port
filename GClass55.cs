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
public class GClass55
{
    #region CompilerGenerated

    [CompilerGenerated]
    private sealed class Class908
    {
        public GClass55 gclass55_0;
        public AuroraMeasurementType auroraMeasurementType_0;

        internal bool method_0(GClass44 gclass44_0)
        {
            return gclass44_0.gclass42_0.Race == this.gclass55_0.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class909
    {
        public Decimal decimal_0;
        public GClass55.Class908 class908_0;

        internal bool method_0(GClass44 gclass44_0)
        {
            return gclass44_0.gclass43_0.MeasurementType == this.class908_0.auroraMeasurementType_0 &&
                   gclass44_0.gclass43_0.AmountRequired <= this.class908_0.gclass55_0
                       .dictionary_2[this.class908_0.auroraMeasurementType_0].decimal_0 &&
                   gclass44_0.gclass43_0.AmountRequired > this.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class910
    {
        public FCTRaceMedalRecord gclass42_0;

        internal bool method_0(GClass53 gclass53_0)
        {
            return gclass53_0.gclass42_0 == this.gclass42_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class911
    {
        public GClass55 gclass55_0;
        public CheckBox checkBox_0;
        public CheckBox checkBox_1;
        public AssignmentTypeFilter gclass49_0;

        internal bool method_0(GClass62 gclass62_0)
        {
            return gclass62_0.int_1 <= this.gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_1(GClass62 gclass62_0)
        {
            return gclass62_0.gclass55_0 == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_2(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass55_0.gclass21_0 && gclass146_0.genum64_0 != GEnum64.const_2;
        }

        internal bool method_3(PopulationData gclass146_0)
        {
            return gclass146_0.int_17 <= this.gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration) ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_4(PopulationData gclass146_0)
        {
            return gclass146_0.gclass55_0 == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_5(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.gclass55_0.gclass21_0 &&
                   gclass146_0.method_73(AuroraInstallationType.MilitaryAcademy) > 0;
        }

        internal bool method_6(PopulationData gclass146_0)
        {
            return gclass146_0.method_82() == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_7(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.gclass61_0.RankNum >= this.gclass55_0.gclass61_0.RankNum ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_8(FCTShipData40 gclass40_0)
        {
            return gclass40_0.method_192(this.gclass49_0.ShipboardPosition) == null ||
                   this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_9(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.gclass61_0.RankNum + this.gclass49_0.RankPriorityModifier == this.gclass55_0.gclass61_0.RankNum;
        }

        internal bool method_10(FCTShipData40 gclass40_0)
        {
            return gclass40_0.method_192(this.gclass49_0.ShipboardPosition) == null ||
                   this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_11(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.method_35(GEnum118.const_58) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.ExecutiveOfficer;
        }

        internal bool method_12(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.method_35(GEnum118.const_59) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.ChiefEngineer;
        }

        internal bool method_13(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.method_35(GEnum118.const_62) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.CAG;
        }

        internal bool method_14(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.method_35(GEnum118.const_61) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.ScienceOfficer;
        }

        internal bool method_15(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0.method_35(GEnum118.const_60) ||
                   this.gclass49_0.ShipboardPosition != AuroraCommandType.TacticalOfficer;
        }

        internal bool method_16(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.RaceData == this.gclass55_0.gclass21_0;
        }

        internal bool method_17(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.method_31() >= this.gclass55_0.gclass61_0.RankNum ||
                   this.checkBox_0.CheckState == CheckState.Unchecked;
        }

        internal bool method_18(GroundUnitFormationData gclass103_0)
        {
            return gclass103_0.gclass55_0 == null || this.checkBox_1.CheckState == CheckState.Unchecked;
        }

        internal bool method_19(NavalAdminCommand gclass83_0)
        {
            return gclass83_0.gclass61_0.RankNum >= this.gclass55_0.gclass61_0.RankNum ||
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
        public GClass55.Class911 class911_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass21_0 == this.class911_0.gclass55_0.gclass21_0 &&
                   gclass40_0.gclass22_0.bool_1 == this.class911_0.gclass49_0.IsForFighter &&
                   gclass40_0.gclass22_0.bool_2 == this.class911_0.gclass49_0.IsForFreighters &&
                   (gclass40_0.gclass22_0.decimal_10 > 0M || !this.class911_0.gclass49_0.IsForArmedShip) &&
                   gclass40_0.gclass187_0 == null && gclass40_0.gclass22_0.int_15 == 0 &&
                   gclass40_0.gclass22_0.gclass61_0.RankNum <= this.int_0 - this.class911_0.gclass49_0.RankPriorityModifier;
        }
    }

    #endregion

    private GClass0 gclass0_0;
    public FCTRaceRecordC21 gclass21_0;
    public FCTRaceRecordC21 gclass21_1;
    public GClass194 gclass194_0;
    public RankThemeEntry gclass61_0;
    public PopulationData gclass146_0;
    public PopulationData gclass146_1;
    public PopulationData gclass146_2;
    public PopulationData gclass146_3;
    public SystemBodyData gclass1_0;
    public FCTShipData40 gclass40_0;
    public FCTShipData40 gclass40_1;
    public FCTShipData40 gclass40_2;
    public FCTShipData40 gclass40_3;
    public FCTShipData40 gclass40_4;
    public FCTShipData40 gclass40_5;
    public FCTShipData40 gclass40_6;
    public GClass62 gclass62_0;
    public GClass161 gclass161_0;
    public GroundUnitFormationData gclass103_0;
    public ResearchFieldData gclass162_0;
    public NavalAdminCommand gclass83_0;
    public GClass59 gclass59_0;
    public AuroraCommanderType auroraCommanderType_0;
    public AuroraCommandType auroraCommandType_0;
    public AuroraRetirementStatus auroraRetirementStatus_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public int int_7;
    public int int_8;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3 = 1M;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public bool bool_4;
    public bool bool_5;
    public string string_0;
    public string string_1;
    public string string_2;
    public string string_3;
    public Dictionary<CommanderBonusType, GClass52> dictionary_0 = new Dictionary<CommanderBonusType, GClass52>();
    public Dictionary<int, GClass53> dictionary_1 = new Dictionary<int, GClass53>();
    public Dictionary<AuroraMeasurementType, GClass54> dictionary_2 = new Dictionary<AuroraMeasurementType, GClass54>();
    public List<GClass177> list_0 = new List<GClass177>();
    public List<int> list_1 = new List<int>();
    private List<GClass56> list_2 = new List<GClass56>();
    public int int_9;
    public AlienRaceInfo gclass110_0;
    public int int_10;

    public GClass55(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public int method_0()
    {
        try
        {
            List<RankThemeEntry> list = this.gclass21_0.RacialRankDictionary.Values
                .Where<RankThemeEntry>(
                    gclass61_1 => gclass61_1.CommanderType == this.gclass61_0.CommanderType)
                .OrderByDescending<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).ToList<RankThemeEntry>();
            int num = 1;
            foreach (RankThemeEntry gclass61 in list)
            {
                if (gclass61 == this.gclass61_0)
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
        GClass55.Class908 class908 = new GClass55.Class908();
        // ISSUE: reference to a compiler-generated field
        class908.gclass55_0 = this;
        // ISSUE: reference to a compiler-generated field
        class908.auroraMeasurementType_0 = auroraMeasurementType_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass55.Class909 class909 = new GClass55.Class909();
            // ISSUE: reference to a compiler-generated field
            class909.class908_0 = class908;
            if (this.gclass21_0.IsNPR)
                return;
            // ISSUE: reference to a compiler-generated field
            class909.decimal_0 = 0M;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (this.dictionary_2.ContainsKey(class909.class908_0.auroraMeasurementType_0))
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class909.decimal_0 = this.dictionary_2[class909.class908_0.auroraMeasurementType_0].decimal_0;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.dictionary_2[class909.class908_0.auroraMeasurementType_0].decimal_0 += decimal_4;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.dictionary_2.Add(class909.class908_0.auroraMeasurementType_0, new GClass54()
                {
                    auroraMeasurementType_0 = class909.class908_0.auroraMeasurementType_0,
                    decimal_0 = decimal_4
                });
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (GClass44 gclass44 in this.gclass0_0.list_1.Where<GClass44>(class909.class908_0.method_0)
                         .Where<GClass44>(class909.method_0).ToList<GClass44>())
                this.method_2(gclass44.gclass42_0, gclass44.gclass43_0, "");
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
        GClass55.Class910 class910 = new GClass55.Class910();
        // ISSUE: reference to a compiler-generated field
        class910.gclass42_0 = gclass42_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            GClass53 gclass53 = this.dictionary_1.Values.FirstOrDefault<GClass53>(class910.method_0);
            if (gclass53 != null)
            {
                if (!gclass53.gclass42_0.AllowMultipleAward)
                    return;
                gclass53.int_0 = 2;
            }
            else
            {
                gclass53 = new GClass53();
                // ISSUE: reference to a compiler-generated field
                gclass53.gclass42_0 = class910.gclass42_0;
                gclass53.int_0 = 1;
                this.dictionary_1.Add(gclass53.gclass42_0.MedalID, gclass53);
            }

            string string_0 = $"{this.method_36()} awarded the {gclass53.gclass42_0.MedalName}";
            string string_4_1 = "Awarded the " + gclass53.gclass42_0.MedalName;
            if (gclass43_0 != null)
            {
                string_0 = $"{string_0} based on the condition: {gclass43_0.Description}";
                string_4_1 = $"{string_4_1}: {gclass43_0.Description}";
                gclass53.string_0 = gclass43_0.Description;
            }
            else if (string_4 != "")
            {
                gclass53.string_0 = string_4;
                string_4_1 = $"{string_4_1}. Citation: {string_4}";
                string_0 = $"{string_0}. Citation: {string_4}";
            }

            if (gclass53.int_0 > 1)
            {
                string_4_1 = $"{string_4_1}. This is the {AuroraUtils.smethod_80(gclass53.int_0)} award of this medal";
                string_0 = $"{string_0}. This is the {AuroraUtils.smethod_80(gclass53.int_0)} award of this medal";
            }

            this.method_46(string_4_1, GEnum28.const_0);
            this.method_45(" awarded the " + gclass53.gclass42_0.MedalName);
            this.gclass0_0.gclass92_0.method_2(EventType.const_164, string_0, this.gclass21_0, null, 0.0, 0.0,
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
            return num * this.gclass103_0.method_0(genum121_0);
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
            if (this.gclass103_0 == null)
                return 0M;
            int num1 = this.gclass103_0.method_33();
            Decimal num2 = 1M;
            if (this.gclass103_0.int_8 > num1)
                num2 = num1 / this.gclass103_0.int_8;
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
            if (this.dictionary_0.ContainsKey(genum121_0))
                return this.dictionary_0[genum121_0].decimal_0;
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
                ? AuroraUtils.FormatNumberToDigits((decimal_73 - 1M) * 100M, 0) + "% "
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
            return !this.dictionary_0.ContainsKey(genum121_0)
                ? 1M
                : 1M + (this.dictionary_0[genum121_0].decimal_0 - 1M) / 2M;
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
            return !this.dictionary_0.ContainsKey(genum121_0)
                ? 1M
                : 1M + (this.dictionary_0[genum121_0].decimal_0 - 1M) / 4M;
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
            if (this.dictionary_0.ContainsKey(genum121_0))
                return;
            this.dictionary_0.Add(genum121_0, new GClass52()
            {
                gclass50_0 = this.gclass0_0.CommanderBonusDictionary[genum121_0],
                decimal_0 = decimal_4
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
            if (!this.dictionary_0.ContainsKey(genum121_0))
            {
                Decimal decimal_4_1 = !this.gclass0_0.CommanderBonusDictionary[genum121_0].Percentage ? 0M : 1M;
                this.method_9(genum121_0, decimal_4_1);
            }

            if (this.dictionary_0[genum121_0].decimal_0 == this.gclass0_0.CommanderBonusDictionary[genum121_0].MaximumBonus)
                return;
            this.dictionary_0[genum121_0].decimal_0 += decimal_4;
            if (this.dictionary_0[genum121_0].decimal_0 > this.gclass0_0.CommanderBonusDictionary[genum121_0].MaximumBonus)
                this.dictionary_0[genum121_0].decimal_0 = this.gclass0_0.CommanderBonusDictionary[genum121_0].MaximumBonus;
            if (!bool_6)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_148,
                $"The {this.gclass0_0.CommanderBonusDictionary[genum121_0].Description} bonus of {this.method_38()} has increased to {this.method_6(genum121_0)}   Current Bonuses:  {this.method_29(false)}   Current Assignment:  {this.method_17(false)}",
                this.gclass21_0, null, 0.0, 0.0, AuroraEventCategory.Commander);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 377);
        }
    }

    public void method_11(GClass22 gclass22_0, Decimal decimal_4)
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
                    if (gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.IntelligenceShip)
                    {
                        this.method_10(CommanderBonusType.Intelligence, decimal_4, true);
                        break;
                    }

                    if (gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.OrbitalMiner &&
                        gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.FuelHarvester)
                    {
                        if (gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.ColonyShip &&
                            gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.Freighter &&
                            gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.Liner &&
                            gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.TroopTransport)
                        {
                            if (gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.Terraformer)
                            {
                                this.method_10(CommanderBonusType.Terraforming, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.Carrier)
                            {
                                this.method_10(CommanderBonusType.CarrierOperations, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.Fighter)
                            {
                                this.method_10(CommanderBonusType.FighterCombat, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.auroraClassMainFunction_0 == AuroraClassMainFunction.GroundSupportFighter)
                            {
                                this.method_10(CommanderBonusType.GroundSupport, decimal_4, true);
                                break;
                            }

                            if (gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.ConstructionShip &&
                                gclass22_0.auroraClassMainFunction_0 != AuroraClassMainFunction.Salvager)
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
            if (this.gclass103_0.PopulationData != null &&
                this.gclass103_0.PopulationData.PopulationPoliticalStatus.PoliticalStatusType != PopPoliticalStatusType.ImperialPopulation)
            {
                this.method_10(CommanderBonusType.GroundCombatOccupation, decimal_4, true);
            }
            else
            {
                switch (this.gclass103_0.method_14())
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
        return (int)Math.Floor((this.gclass0_0.decimal_0 - this.decimal_2) / AuroraUtils.decimal_29) +
               this.gclass194_0.int_11;
    }

    public int method_14()
    {
        return (int)Math.Floor((this.gclass0_0.decimal_0 - this.decimal_2) / AuroraUtils.decimal_29);
    }

    public string method_15()
    {
        try
        {
            int num1 = this.method_13();
            int num2 = 0;
            if (num1 > 61)
                num2 = (int)((num1 - 60) / 2.0);
            int num3 = num2 + this.int_6;
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
            if (this.gclass59_0 != null)
                return AuroraUtils.color_11;
            if (this.bool_4)
                return Color.Magenta;
            int num1 = this.method_13();
            int num2 = 0;
            if (num1 > 61)
                num2 = (int)((num1 - 60) / 2.0);
            int num3 = num2 + this.int_6;
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
            if (this.auroraRetirementStatus_0 != AuroraRetirementStatus.Active)
                return AuroraUtils.smethod_82(this.auroraRetirementStatus_0);
            switch (this.auroraCommandType_0)
            {
                case AuroraCommandType.None:
                    str = "Unassigned";
                    break;
                case AuroraCommandType.Ship:
                    if (this.gclass40_1.gclass85_0.method_179() == 1)
                    {
                        str = "C.O. " + this.gclass40_1.method_187();
                        if (bool_6)
                        {
                            str = "CO " + this.gclass40_1.method_187();
                            break;
                        }

                        break;
                    }

                    if (this.gclass40_1.gclass85_0.method_162() == this)
                    {
                        str = "Fleet Commander:  " + this.gclass40_1.gclass85_0.FleetName;
                        if (bool_6)
                        {
                            str = "FCO " + this.gclass40_1.gclass85_0.FleetName;
                            break;
                        }

                        break;
                    }

                    str = "C.O. " + this.gclass40_1.method_187();
                    if (bool_6)
                    {
                        str = "CO " + this.gclass40_1.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.Colony:
                    str = "Planetary Governor:  " + this.gclass146_1.PopName;
                    if (bool_6)
                    {
                        str = "GOV " + this.gclass146_1.PopName;
                        break;
                    }

                    break;
                case AuroraCommandType.Sector:
                    str = "Sector Commander:  " + this.gclass62_0.SectorName;
                    if (bool_6)
                    {
                        str = "SEC " + this.gclass62_0.SectorName;
                        break;
                    }

                    break;
                case AuroraCommandType.GroundFormation:
                    str = "C.O. " + this.gclass103_0.method_45();
                    if (bool_6)
                    {
                        str = "CO " + this.gclass103_0.method_45();
                        break;
                    }

                    break;
                case AuroraCommandType.ResearchProject:
                    str = "Research Project:  " + this.gclass161_0.gclass164_0.Name;
                    if (bool_6)
                    {
                        str = "RES " + this.gclass161_0.gclass164_0.Name;
                        break;
                    }

                    break;
                case AuroraCommandType.ExecutiveOfficer:
                    str = "Executive Officer " + this.gclass40_2.method_187();
                    if (bool_6)
                    {
                        str = "XO " + this.gclass40_2.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.ChiefEngineer:
                    str = "Chief Engineer " + this.gclass40_3.method_187();
                    if (bool_6)
                    {
                        str = "ENG " + this.gclass40_3.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.ScienceOfficer:
                    str = "Science Officer " + this.gclass40_4.method_187();
                    if (bool_6)
                    {
                        str = "SCI " + this.gclass40_4.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.TacticalOfficer:
                    str = "Tactical Officer " + this.gclass40_5.method_187();
                    if (bool_6)
                    {
                        str = "TAC " + this.gclass40_5.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.NavalAdminCommand:
                    str = "Administrative Command:  " + this.gclass83_0.AdminCommandName;
                    if (bool_6)
                    {
                        str = "NAC " + this.gclass83_0.AdminCommandName;
                        break;
                    }

                    break;
                case AuroraCommandType.CAG:
                    str = "Commander, Air Group " + this.gclass40_6.method_187();
                    if (bool_6)
                    {
                        str = "CAG " + this.gclass40_6.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.AcademyCommandant:
                    str = "Academy Commandant:  " + this.gclass146_3.PopName;
                    if (bool_6)
                    {
                        str = "ACM " + this.gclass146_3.PopName;
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
            switch (this.auroraCommandType_0)
            {
                case AuroraCommandType.None:
                    str = "N/A";
                    break;
                case AuroraCommandType.Ship:
                    str = this.gclass40_1.method_187();
                    break;
                case AuroraCommandType.Colony:
                    str = this.gclass146_1.PopName;
                    break;
                case AuroraCommandType.Sector:
                    str = this.gclass62_0.gclass146_0.PopName;
                    break;
                case AuroraCommandType.GroundFormation:
                    str = this.gclass103_0.method_46();
                    break;
                case AuroraCommandType.ResearchProject:
                    str = this.gclass161_0.gclass146_0.PopName;
                    break;
                case AuroraCommandType.ExecutiveOfficer:
                    str = this.gclass40_2.method_187();
                    break;
                case AuroraCommandType.ChiefEngineer:
                    str = this.gclass40_3.method_187();
                    break;
                case AuroraCommandType.ScienceOfficer:
                    str = this.gclass40_4.method_187();
                    break;
                case AuroraCommandType.TacticalOfficer:
                    str = this.gclass40_5.method_187();
                    break;
                case AuroraCommandType.NavalAdminCommand:
                    if (this.gclass83_0.gclass146_0 != null)
                    {
                        str = this.gclass83_0.gclass146_0.PopName;
                        break;
                    }

                    if (this.gclass83_0.gclass40_0 != null)
                    {
                        str = this.gclass83_0.gclass40_0.method_187();
                        break;
                    }

                    break;
                case AuroraCommandType.CAG:
                    str = this.gclass40_6.method_187();
                    break;
                case AuroraCommandType.AcademyCommandant:
                    str = this.gclass146_3.PopName;
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
        GClass55 gclass55_0,
        FlowLayoutPanel flowLayoutPanel_0,
        CheckBox checkBox_2,
        CheckBox checkBox_3)
    {
        try
        {
            listView_0.Items.Clear();
            this.method_27();
            label_0.Text = this.method_36();
            label_1.Text = "    " + this.method_17(false);
            string string_11 = "Unknown";
            if (this.gclass146_2 != null)
            {
                string_11 = this.gclass146_2.PopName;
                if (this.gclass146_2.AcademyName != "")
                    string_11 = this.gclass146_2.AcademyName;
            }

            checkBox_2.CheckState = AuroraUtils.smethod_28(this.bool_0);
            checkBox_2.CheckState = AuroraUtils.smethod_28(this.bool_0);
            this.gclass0_0.method_597(listView_0, "Homeworld", this.gclass1_0.method_78(this.gclass21_0));
            if (this.auroraCommanderType_0 != AuroraCommanderType.Naval &&
                this.auroraCommanderType_0 != AuroraCommanderType.GroundForce)
            {
                this.gclass0_0.method_597(listView_0, "University", string_11);
                this.gclass0_0.method_597(listView_0, "Age and Health",
                    $"{this.method_13().ToString()} / {this.method_15()}");
                this.gclass0_0.method_597(listView_0, "Career Start Date",
                    this.gclass0_0.method_583((double)this.decimal_2));
            }
            else
            {
                this.gclass0_0.method_597(listView_0, "Military Academy", string_11);
                this.gclass0_0.method_597(listView_0, "Age and Health",
                    $"{this.method_13().ToString()} / {this.method_15()}");
                this.gclass0_0.method_597(listView_0, "Date of Commission",
                    this.gclass0_0.method_583((double)this.decimal_2));
                this.gclass0_0.method_597(listView_0, "Promotion Score", AuroraUtils.smethod_37(this.int_1));
            }

            this.gclass0_0.method_594(listView_0, "");
            this.method_20(listView_0);
            this.method_30(listView_1, true);
            this.gclass0_0.method_594(listView_1, "");
            foreach (int num in this.list_1)
                this.gclass0_0.method_595(listView_1, this.gclass0_0.TraitNameDictionary[num], num);
            this.method_47(listView_2);
            if (gclass55_0 == null)
                this.gclass0_0.method_510(comboBox_0, this.auroraCommanderType_0);
            else if (gclass55_0.auroraCommanderType_0 == this.auroraCommanderType_0)
                this.method_25((AssignmentTypeFilter)comboBox_0.SelectedValue, listView_3, checkBox_0, checkBox_1);
            else
                this.gclass0_0.method_510(comboBox_0, this.auroraCommanderType_0);
            checkBox_3.CheckState = !this.bool_2 ? CheckState.Unchecked : CheckState.Checked;
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
            foreach (GClass54 gclass54 in this.dictionary_2.Values
                         .OrderBy<GClass54, string>(gclass54_0 =>
                             AuroraUtils.smethod_82(gclass54_0.auroraMeasurementType_0)).ToList<GClass54>())
                this.gclass0_0.method_601(listView_0, AuroraUtils.smethod_82(gclass54.auroraMeasurementType_0),
                    AuroraUtils.smethod_38(gclass54.decimal_0), null);
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
            foreach (GClass53 gclass53 in this.dictionary_1.Values
                         .OrderByDescending<GClass53, int>(gclass53_0 => gclass53_0.gclass42_0.MedalPoints)
                         .ToList<GClass53>())
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

    public void method_22(FCTShipData40 gclass40_7, AuroraCommandType auroraCommandType_1)
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
                    this.gclass40_1 = gclass40_7;
                    this.auroraCommandType_0 = AuroraCommandType.Ship;
                    str = "Commanding Officer";
                    this.gclass40_1.dictionary_1.Remove(AuroraCommandType.Ship);
                    this.gclass40_1.dictionary_1.Add(AuroraCommandType.Ship, this);
                    break;
                case AuroraCommandType.ExecutiveOfficer:
                    this.gclass40_2 = gclass40_7;
                    this.auroraCommandType_0 = AuroraCommandType.ExecutiveOfficer;
                    str = "Executive Officer";
                    this.gclass40_2.dictionary_1.Remove(AuroraCommandType.ExecutiveOfficer);
                    this.gclass40_2.dictionary_1.Add(AuroraCommandType.ExecutiveOfficer, this);
                    break;
                case AuroraCommandType.ChiefEngineer:
                    this.gclass40_3 = gclass40_7;
                    this.auroraCommandType_0 = AuroraCommandType.ChiefEngineer;
                    str = "Chief Engineer ";
                    this.gclass40_3.dictionary_1.Remove(AuroraCommandType.ChiefEngineer);
                    this.gclass40_3.dictionary_1.Add(AuroraCommandType.ChiefEngineer, this);
                    break;
                case AuroraCommandType.ScienceOfficer:
                    this.gclass40_4 = gclass40_7;
                    this.auroraCommandType_0 = AuroraCommandType.ScienceOfficer;
                    str = "Science Officer";
                    this.gclass40_4.dictionary_1.Remove(AuroraCommandType.ScienceOfficer);
                    this.gclass40_4.dictionary_1.Add(AuroraCommandType.ScienceOfficer, this);
                    break;
                case AuroraCommandType.TacticalOfficer:
                    this.gclass40_5 = gclass40_7;
                    this.auroraCommandType_0 = AuroraCommandType.TacticalOfficer;
                    str = "Tactical Officer";
                    this.gclass40_5.dictionary_1.Remove(AuroraCommandType.TacticalOfficer);
                    this.gclass40_5.dictionary_1.Add(AuroraCommandType.TacticalOfficer, this);
                    break;
                case AuroraCommandType.CAG:
                    this.gclass40_6 = gclass40_7;
                    this.auroraCommandType_0 = AuroraCommandType.CAG;
                    str = "Commander, Air Group";
                    this.gclass40_6.dictionary_1.Remove(AuroraCommandType.CAG);
                    this.gclass40_6.dictionary_1.Add(AuroraCommandType.CAG, this);
                    break;
            }

            this.gclass40_0 = gclass40_7;
            this.decimal_1 = this.gclass0_0.decimal_0;
            this.method_46($"Assigned as {str} of {gclass40_7.method_187()}", GEnum28.const_1);
            gclass40_7.method_204($"{this.method_36()} assigned as {str}");
            this.gclass0_0.gclass92_0.method_2(EventType.const_78,
                $"{this.method_36()} assigned as {str} of {gclass40_7.method_187()}", this.gclass21_0,
                gclass40_7.gclass85_0.System.ActualSystemData, gclass40_7.gclass85_0.XCoord,
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
            if (gclass103_1.gclass55_0 != null)
                gclass103_1.gclass55_0.method_40(true);
            this.gclass103_0 = gclass103_1;
            this.auroraCommandType_0 = AuroraCommandType.GroundFormation;
            this.method_46("Assigned as Commanding Officer of " + gclass103_1.method_45(), GEnum28.const_1);
            this.gclass0_0.gclass92_0.method_2(EventType.const_78,
                $"{this.method_36()} assigned as Commanding Officer of {gclass103_1.method_45()}", this.gclass21_0,
                null, 0.0, 0.0, AuroraEventCategory.Commander);
            this.gclass40_0 = gclass103_1.ShipData;
            this.gclass146_0 = gclass103_1.PopulationData;
            gclass103_1.gclass55_0 = this;
            this.decimal_1 = this.gclass0_0.decimal_0;
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
                GClass62 tag = (GClass62)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    if (this.method_5(CommanderBonusType.ColonyAdmnistration) < tag.int_1)
                    {
                        int num = (int)MessageBox.Show(
                            $"The Admin Rating of {this.string_0} is too low for this assignment");
                        return;
                    }

                    if (tag.gclass55_0 == this)
                    {
                        int num = (int)MessageBox.Show(this.string_0 + " is already assigned to this role");
                        return;
                    }

                    this.method_40(false);
                    if (tag.gclass55_0 != null)
                        tag.gclass55_0.method_40(true);
                    this.gclass62_0 = tag;
                    this.auroraCommandType_0 = AuroraCommandType.Sector;
                    this.gclass146_0 = tag.gclass146_0;
                    this.decimal_1 = this.gclass0_0.decimal_0;
                    tag.gclass55_0 = this;
                    this.method_46("Assigned to " + tag.SectorName, GEnum28.const_1);
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
                            $"The Admin Rating of {this.string_0} is too low for this assignment");
                        return;
                    }

                    if (tag.gclass55_0 == this)
                    {
                        int num = (int)MessageBox.Show(this.string_0 + " is already assigned to this role");
                        return;
                    }

                    this.method_40(false);
                    if (tag.gclass55_0 != null)
                        tag.gclass55_0.method_40(true);
                    this.gclass146_1 = tag;
                    this.auroraCommandType_0 = AuroraCommandType.Colony;
                    this.gclass146_0 = tag;
                    this.decimal_1 = this.gclass0_0.decimal_0;
                    tag.gclass55_0 = this;
                    this.method_46("Assigned to " + tag.PopName, GEnum28.const_1);
                }
            }

            if (gclass49_0.IsForAcademy)
            {
                PopulationData tag = (PopulationData)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    GClass55 gclass55 = tag.method_82();
                    if (gclass55 == this)
                    {
                        int num = (int)MessageBox.Show(this.string_0 + " is already assigned to this role");
                        return;
                    }

                    this.method_40(false);
                    gclass55?.method_40(true);
                    this.gclass146_3 = tag;
                    this.auroraCommandType_0 = AuroraCommandType.AcademyCommandant;
                    this.gclass146_0 = tag;
                    this.decimal_1 = this.gclass0_0.decimal_0;
                    this.method_46("Assigned as Academy Commandant on " + tag.PopName, GEnum28.const_1);
                }
            }

            if (gclass49_0.IsForShip)
            {
                FCTShipData40 tag = (FCTShipData40)listView_0.SelectedItems[0].Tag;
                if (tag != null)
                {
                    if (gclass49_0.ShipboardPosition == AuroraCommandType.Ship &&
                        this.gclass61_0.RankNum > tag.gclass22_0.gclass61_0.RankNum)
                    {
                        int num = (int)MessageBox.Show(this.string_0 + " is too junior for this assignment");
                        return;
                    }

                    if (gclass49_0.ShipboardPosition != AuroraCommandType.Ship && this.gclass61_0.RankNum !=
                        tag.gclass22_0.gclass61_0.RankNum + gclass49_0.RankPriorityModifier)
                    {
                        int num = (int)MessageBox.Show(this.string_0 + " is not the required rank for this assignment");
                        return;
                    }

                    if (tag.method_192(gclass49_0.ShipboardPosition) == this)
                    {
                        int num = (int)MessageBox.Show(this.string_0 + " is already assigned to this role");
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
                    if (this.gclass61_0.RankNum > tag.method_31())
                    {
                        int num = (int)MessageBox.Show($"The rank of {this.string_0} is too low for this assignment");
                        return;
                    }

                    if (tag.gclass55_0 == this)
                    {
                        int num = (int)MessageBox.Show(this.string_0 + " is already assigned to this role");
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
            if (this.gclass61_0.RankNum > tag1.gclass61_0.RankNum)
            {
                int num1 = (int)MessageBox.Show($"The rank of {this.string_0} is too low for this assignment");
            }
            else if (tag1.gclass55_0 == this)
            {
                int num2 = (int)MessageBox.Show(this.string_0 + " is already assigned to this role");
            }
            else
            {
                this.method_40(false);
                if (tag1.gclass55_0 != null)
                    tag1.gclass55_0.method_40(true);
                this.gclass83_0 = tag1;
                this.auroraCommandType_0 = AuroraCommandType.NavalAdminCommand;
                this.gclass146_0 = tag1.gclass146_0;
                this.gclass40_0 = tag1.gclass40_0;
                this.decimal_1 = this.gclass0_0.decimal_0;
                tag1.gclass55_0 = this;
                this.method_46("Assigned to " + tag1.AdminCommandName, GEnum28.const_1);
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
        GClass55.Class911 class911 = new GClass55.Class911();
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
                foreach (GClass62 gclass62 in this.gclass21_0.dictionary_2.Values)
                    gclass62.method_3();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                foreach (GClass62 object_1 in this.gclass21_0.dictionary_2.Values.Where<GClass62>(class911.method_0)
                             .Where<GClass62>(class911.method_1)
                             .OrderByDescending<GClass62, int>(gclass62_0 => gclass62_0.int_1)
                             .ThenBy<GClass62, string>(gclass62_0 => gclass62_0.SectorName).ToList<GClass62>())
                    this.gclass0_0.method_599(listView_0, "A" + object_1.int_1.ToString(), object_1.SectorName,
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
                List<PopulationData> list = this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class911.method_2)
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
                    if (object_1.gclass55_0 == null)
                        this.gclass0_0.method_598(listView_0, "A" + object_1.int_17.ToString(), object_1.PopName,
                            object_1);
                    else
                        this.gclass0_0.method_599(listView_0, "A" + object_1.int_17.ToString(), object_1.PopName,
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
                foreach (PopulationData object_1 in this.gclass0_0.PopulationDataDictionary.Values.Where<PopulationData>(class911.method_5)
                             .Where<PopulationData>(class911.method_6)
                             .OrderByDescending<PopulationData, int>(gclass146_0 =>
                                 gclass146_0.method_73(AuroraInstallationType.MilitaryAcademy))
                             .ThenBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName).ToList<PopulationData>())
                {
                    GClass55 gclass55 = object_1.method_82();
                    int genum15_0 = object_1.method_73(AuroraInstallationType.MilitaryAcademy);
                    if (this.auroraCommanderType_0 == AuroraCommanderType.Administrator)
                    {
                        if (this.method_5(CommanderBonusType.ColonyAdmnistration) >= genum15_0)
                        {
                            if (gclass55 == null)
                                this.gclass0_0.method_598(listView_0, "A" + genum15_0.ToString(), object_1.PopName,
                                    object_1);
                            else
                                this.gclass0_0.method_599(listView_0, "A" + genum15_0.ToString(), object_1.PopName,
                                    Color.LightGray, object_1);
                        }
                    }
                    else if (this.auroraCommanderType_0 == AuroraCommanderType.Scientist)
                    {
                        Decimal num = 5M;
                        if (this.gclass0_0.int_114 == 1)
                            num = 1M;
                        if (this.method_5(CommanderBonusType.ResearchAdmin) / num >= genum15_0)
                        {
                            if (gclass55 == null)
                                this.gclass0_0.method_598(listView_0, "RA" + genum15_0.ToString(), object_1.PopName,
                                    object_1);
                            else
                                this.gclass0_0.method_599(listView_0, "RA" + genum15_0.ToString(), object_1.PopName,
                                    Color.LightGray, object_1);
                        }
                    }
                    else if (this.auroraCommanderType_0 == AuroraCommanderType.Naval)
                    {
                        RankThemeEntry gclass61 = this.gclass21_0.method_253((GEnum15)genum15_0, AuroraCommanderType.Naval);
                        if (gclass61 != null && this.gclass61_0.RankNum <= gclass61.RankNum)
                        {
                            if (gclass55 == null)
                                this.gclass0_0.method_598(listView_0, gclass61.RankAbbreviation, object_1.PopName, object_1);
                            else
                                this.gclass0_0.method_599(listView_0, gclass61.RankAbbreviation, object_1.PopName,
                                    Color.LightGray, object_1);
                        }
                    }
                    else if (this.auroraCommanderType_0 == AuroraCommanderType.GroundForce)
                    {
                        RankThemeEntry gclass61 =
                            this.gclass21_0.method_253((GEnum15)genum15_0, AuroraCommanderType.GroundForce);
                        if (gclass61 != null && this.gclass61_0.RankNum <= gclass61.RankNum)
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
                GClass55.Class912 class912 = new GClass55.Class912();
                // ISSUE: reference to a compiler-generated field
                class912.class911_0 = class911;
                listView_0.Columns[0].Width = 45;
                listView_0.Columns[1].Width = 185;
                listView_0.Columns[2].Width = 150;
                listView_0.Columns[3].Width = 40;
                // ISSUE: reference to a compiler-generated field
                class912.int_0 = this.gclass21_0.method_232();
                // ISSUE: reference to a compiler-generated method
                List<FCTShipData40> list = this.gclass0_0.FCTShipDataDictionary.Values
                    .Where<FCTShipData40>(class912.method_0).ToList<FCTShipData40>();
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
                foreach (FCTShipData40 object_1 in
                         class912.class911_0.gclass49_0.ShipboardPosition != AuroraCommandType.Ship
                             ? list.Where<FCTShipData40>(class912.class911_0.method_9)
                                 .Where<FCTShipData40>(class912.class911_0.method_10)
                                 .Where<FCTShipData40>(class912.class911_0.method_11)
                                 .Where<FCTShipData40>(class912.class911_0.method_12)
                                 .Where<FCTShipData40>(class912.class911_0.method_13)
                                 .Where<FCTShipData40>(class912.class911_0.method_14)
                                 .Where<FCTShipData40>(class912.class911_0.method_15)
                                 .OrderBy<FCTShipData40, int>(gclass40_0 => gclass40_0.gclass22_0.gclass61_0.RankNum)
                                 .ThenByDescending<FCTShipData40,
                                     Decimal>(gclass40_0 => gclass40_0.gclass22_0.decimal_14)
                                 .ThenBy<FCTShipData40, string>(gclass40_0 => gclass40_0.gclass22_0.ClassName)
                                 .ThenBy<FCTShipData40, string>(gclass40_0 => gclass40_0.ShipName)
                                 .ToList<FCTShipData40>()
                             : list.Where<FCTShipData40>(class912.class911_0.method_7)
                                 .Where<FCTShipData40>(class912.class911_0.method_8)
                                 .OrderBy<FCTShipData40, int>(gclass40_0 => gclass40_0.gclass22_0.gclass61_0.RankNum)
                                 .ThenByDescending<FCTShipData40,
                                     Decimal>(gclass40_0 => gclass40_0.gclass22_0.decimal_14)
                                 .ThenBy<FCTShipData40, string>(gclass40_0 => gclass40_0.gclass22_0.ClassName)
                                 .ThenBy<FCTShipData40, string>(gclass40_0 => gclass40_0.ShipName)
                                 .ToList<FCTShipData40>())
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    RankThemeEntry gclass61 = object_1.gclass22_0.gclass61_0.method_2(class912.class911_0.gclass49_0.RankPriorityModifier);
                    if (gclass61 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (object_1.method_192(class912.class911_0.gclass49_0.ShipboardPosition) == null)
                            this.gclass0_0.method_604(listView_0, gclass61.RankAbbreviation, object_1.gclass22_0.method_34(),
                                object_1.ShipName, AuroraUtils.smethod_38(object_1.method_189()) + "%", object_1);
                        else
                            this.gclass0_0.method_605(listView_0, gclass61.RankAbbreviation, object_1.gclass22_0.method_34(),
                                object_1.ShipName, AuroraUtils.smethod_38(object_1.method_189()) + "%", Color.LightGray,
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
                    if (object_1.gclass55_0 == null)
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
            foreach (NavalAdminCommand object_1 in this.gclass21_0.method_255(false).Where<NavalAdminCommand>(class911.method_19)
                         .Where<NavalAdminCommand>(class911.method_20)
                         .OrderBy<NavalAdminCommand, int>(gclass83_0 => gclass83_0.gclass61_0.RankNum)
                         .ThenBy<NavalAdminCommand, string>(gclass83_0 => gclass83_0.AdminCommandName).ToList<NavalAdminCommand>())
            {
                if (object_1.gclass55_0 == null)
                    this.gclass0_0.method_598(listView_0, object_1.gclass61_0.RankAbbreviation, object_1.AdminCommandName,
                        object_1);
                else if (object_1.gclass55_0.gclass61_0.RankNum > object_1.gclass61_0.RankNum)
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
            string str = this.string_0;
            if (this.auroraCommanderType_0 == AuroraCommanderType.Scientist)
                str = $"{this.string_0}  {AuroraUtils.FormatNumberToDigits((this.method_5(CommanderBonusType.Research) - 1M) * 100M, 0)}%";
            if (this.auroraRetirementStatus_0 != AuroraRetirementStatus.Active && !this.bool_3)
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
            this.int_1 = (int)(Math.Pow((double)(this.method_5(CommanderBonusType.PoliticalReliability) - 1M) * 100.0, 2.0) +
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
            Decimal num = 25M * ((this.gclass0_0.decimal_0 - this.decimal_0) / AuroraUtils.decimal_29);
            if (num > 100M)
                num = 100M;
            this.int_1 += (int)num;
            if (this.auroraCommandType_0 != AuroraCommandType.None)
                this.int_1 += 25;
            this.int_1 +=
                this.dictionary_1.Values.Sum<GClass53>(gclass53_0 =>
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
                } while (this.list_1.Contains(num2));

                this.list_1.Add(num2);
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
            foreach (GClass52 gclass52 in this.dictionary_0.Values
                         .OrderBy<GClass52, int>(gclass52_0 => gclass52_0.gclass50_0.DisplayOrder).ToList<GClass52>())
            {
                string str = !bool_6 ? gclass52.gclass50_0.Description : gclass52.gclass50_0.BonusAbbrev;
                if (gclass52.gclass50_0.Percentage)
                    string_2 = $"{string_2}{str} {AuroraUtils.smethod_38((gclass52.decimal_0 - 1M) * 100M)}%    ";
                else
                    string_2 = $"{string_2}{str} {AuroraUtils.smethod_38(gclass52.decimal_0)}    ";
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
            foreach (GClass52 gclass52 in this.dictionary_0.Values
                         .OrderBy<GClass52, int>(gclass52_0 => gclass52_0.gclass50_0.DisplayOrder).ToList<GClass52>())
            {
                if (gclass52.gclass50_0.Percentage)
                    this.gclass0_0.method_597(listView_0, gclass52.gclass50_0.Description,
                        AuroraUtils.smethod_38((gclass52.decimal_0 - 1M) * 100M) + "%");
                else
                    this.gclass0_0.method_597(listView_0, gclass52.gclass50_0.Description,
                        AuroraUtils.smethod_38(gclass52.decimal_0));
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
        GClass55 gclass55_0)
    {
        try
        {
            if (this.auroraCommanderType_0 != auroraCommanderType_1 && auroraCommanderType_1 != AuroraCommanderType.All)
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
                this.int_6 = 1;
            else if (num <= 95)
                this.int_6 = 2;
            else if (num <= 99)
                this.int_6 = 3;
            else
                this.int_6 = 5;
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
            if (this.gclass0_0.int_114 == 1)
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
            if (this.gclass61_0 != null)
                return $"{this.gclass61_0.RankName} {this.string_0}";
            if (this.auroraCommanderType_0 == AuroraCommanderType.Scientist)
                return $"{this.gclass21_0.RankScientist} {this.string_0}";
            return this.auroraCommanderType_0 == AuroraCommanderType.Administrator
                ? $"{this.gclass21_0.RankAdministrator} {this.string_0}"
                : this.string_0;
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
            foreach (GClass53 gclass53 in this.dictionary_1.Values
                         .OrderByDescending<GClass53, int>(gclass53_0 => gclass53_0.gclass42_0.MedalPoints)
                         .ToList<GClass53>())
            {
                if (!(gclass53.gclass42_0.Abbreviation == ""))
                {
                    if (gclass53.int_0 == 1)
                        str = $"{str}{gclass53.gclass42_0.Abbreviation} ";
                    else
                        str = $"{str}{gclass53.int_0.ToString()}x {gclass53.gclass42_0.Abbreviation} ";
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
            if (this.gclass61_0 != null)
                str = this.gclass61_0.method_0();
            else if (this.auroraCommanderType_0 == AuroraCommanderType.Administrator)
                str = "CIV";
            else if (this.auroraCommanderType_0 == AuroraCommanderType.Scientist)
                str = "SCI";
            return $"{str} {this.string_0}";
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
            if (this.gclass146_3 != null && bool_8)
                str = "elieved as Academy Commandant on " + this.gclass146_3.PopName;
            if (this.gclass161_0 != null)
                str = $"elieved from leadership of {this.gclass161_0.gclass164_0.Name} research project";
            else if (this.gclass103_0 != null)
            {
                str = "elieved from command of " + this.gclass103_0.method_45();
                this.gclass103_0.gclass55_0 = null;
            }
            else if (this.gclass146_1 != null)
            {
                str = "elieved from command of " + this.gclass146_1.PopName;
                this.gclass146_1.gclass55_0 = null;
            }
            else if (this.gclass62_0 != null)
            {
                str = "elieved from command of " + this.gclass62_0.SectorName;
                this.gclass62_0.gclass55_0 = null;
            }
            else if (this.gclass83_0 != null)
            {
                str = "elieved from command of " + this.gclass83_0.AdminCommandName;
                this.gclass83_0.gclass55_0 = null;
            }
            else if (this.gclass40_1 != null)
            {
                str = "elieved from command of " + this.gclass40_1.method_187();
                this.gclass40_1.dictionary_1.Remove(AuroraCommandType.Ship);
            }
            else if (this.gclass40_2 != null)
            {
                str = "elieved as executive officer of " + this.gclass40_2.method_187();
                this.gclass40_2.dictionary_1.Remove(AuroraCommandType.ExecutiveOfficer);
            }
            else if (this.gclass40_3 != null)
            {
                str = "elieved as Chief Engineer of " + this.gclass40_3.method_187();
                this.gclass40_3.dictionary_1.Remove(AuroraCommandType.ChiefEngineer);
            }
            else if (this.gclass40_4 != null)
            {
                str = "elieved as Science Officer of " + this.gclass40_4.method_187();
                this.gclass40_4.dictionary_1.Remove(AuroraCommandType.ScienceOfficer);
            }
            else if (this.gclass40_5 != null)
            {
                str = "elieved as Tactical Officer of " + this.gclass40_5.method_187();
                this.gclass40_5.dictionary_1.Remove(AuroraCommandType.TacticalOfficer);
            }
            else if (this.gclass40_6 != null)
            {
                str = "elieved as Commander, Air Group on " + this.gclass40_6.method_187();
                this.gclass40_6.dictionary_1.Remove(AuroraCommandType.CAG);
            }

            if (bool_6 && str != "")
                this.method_46("R" + str, GEnum28.const_2);
            if (bool_7 && str != "")
                this.gclass0_0.gclass92_0.method_2(EventType.const_78,
                    $"As a result of promotion, {this.string_0} was r{str}", this.gclass21_0, null, 0.0, 0.0,
                    AuroraEventCategory.Commander);
            if (this.gclass161_0 != null)
                this.gclass161_0.method_0();
            this.auroraCommandType_0 = AuroraCommandType.None;
            this.gclass146_1 = null;
            this.gclass146_3 = null;
            this.gclass103_0 = null;
            this.gclass40_1 = null;
            this.gclass83_0 = null;
            this.gclass62_0 = null;
            this.gclass161_0 = null;
            this.gclass40_2 = null;
            this.gclass40_3 = null;
            this.gclass40_4 = null;
            this.gclass40_5 = null;
            this.gclass40_6 = null;
            this.gclass146_0 = null;
            this.gclass40_0 = null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 407);
        }
    }

    public void method_42(AuroraRetirementStatus auroraRetirementStatus_1)
    {
        try
        {
            this.auroraRetirementStatus_0 = auroraRetirementStatus_1;
            this.method_40(true);
            if (!this.gclass0_0.dictionary_43.ContainsKey(this.int_0))
                this.gclass0_0.dictionary_43.Add(this.int_0, this);
            this.gclass0_0.dictionary_42.Remove(this.int_0);
            if (this.gclass61_0 == null)
                return;
            this.gclass21_0.method_249(this.gclass61_0);
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
            if (this.auroraCommandType_0 == AuroraCommandType.Ship ||
                this.auroraCommandType_0 == AuroraCommandType.ExecutiveOfficer ||
                this.auroraCommandType_0 == AuroraCommandType.ScienceOfficer ||
                this.auroraCommandType_0 == AuroraCommandType.TacticalOfficer ||
                this.auroraCommandType_0 == AuroraCommandType.ChiefEngineer ||
                this.auroraCommandType_0 == AuroraCommandType.CAG)
                str = AuroraUtils.smethod_82(this.auroraCommandType_0);
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3670);
            return "";
        }
    }

    public FCTShipData40 method_44()
    {
        try
        {
            if (this.auroraCommandType_0 == AuroraCommandType.Ship)
                return this.gclass40_1;
            if (this.auroraCommandType_0 == AuroraCommandType.ExecutiveOfficer)
                return this.gclass40_2;
            if (this.auroraCommandType_0 == AuroraCommandType.ScienceOfficer)
                return this.gclass40_4;
            if (this.auroraCommandType_0 == AuroraCommandType.TacticalOfficer)
                return this.gclass40_5;
            if (this.auroraCommandType_0 == AuroraCommandType.ChiefEngineer)
                return this.gclass40_3;
            return this.auroraCommandType_0 == AuroraCommandType.CAG ? this.gclass40_6 : null;
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
            FCTShipData40 gclass40 = this.method_44();
            if (gclass40 != null)
                return;
            string str = this.method_43();
            if (!(str != ""))
                return;
            gclass40.method_204($"{str} {this.method_36()} {string_4}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3672);
        }
    }

    public void method_46(string string_4, GEnum28 genum28_0)
    {
        try
        {
            if (genum28_0 == GEnum28.const_1)
            {
                foreach (GClass177 gclass177 in this.list_0.Where<GClass177>(gclass177_0 =>
                             gclass177_0.genum28_0 == GEnum28.const_2 &&
                             gclass177_0.decimal_0 == this.gclass0_0.decimal_0).ToList<GClass177>())
                    this.list_0.Remove(gclass177);
            }

            this.list_0.Add(new GClass177()
            {
                decimal_0 = this.gclass0_0.decimal_0,
                Description = string_4,
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
            this.list_0 = this.list_0.OrderByDescending<GClass177, Decimal>(gclass177_0 => gclass177_0.decimal_0)
                .ToList<GClass177>();
            foreach (GClass177 object_1 in this.list_0)
                this.gclass0_0.method_598(listView_0, this.gclass0_0.method_583((double)object_1.decimal_0),
                    object_1.Description, object_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 410);
        }
    }
}