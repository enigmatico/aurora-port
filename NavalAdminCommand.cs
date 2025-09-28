// Decompiled with JetBrains decompiler
// Type: GClass83
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class NavalAdminCommand
{
    private Dictionary<int, RacialSystemSurvey> dictionary_0 = new Dictionary<int, RacialSystemSurvey>();
    private GClass0 gclass0_0;
    public GameRace Race;
    public NavalAdminCommand ParentAdminCommand;
    public GClass55 gclass55_0;
    public PopulationData gclass146_0;
    public ShipData gclass40_0;
    public NavalAdminCommandType gclass79_0;
    public CommanderBonusType genum121_0 = CommanderBonusType.PopulationGrowth;
    public CommanderBonusType genum121_1 = CommanderBonusType.WealthCreation;
    public CommanderBonusType genum121_2 = CommanderBonusType.Mining;
    public int int_0;
    public int int_1;
    public int int_2 = 5;
    public int int_3 = 10;
    public int int_4;
    public bool bool_0 = true;
    public bool bool_1;
    public RankThemeEntry gclass61_0;
    public bool bool_2;

    public string AdminCommandName { get; set; }

    public NavalAdminCommand(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(bool bool_3)
    {
        try
        {
            RankThemeEntry gclass61 = null;
            if (bool_3)
                Race.method_255(false);
            List<GClass55> list = gclass0_0.dictionary_42.Values.Where(gclass55_1 =>
                    gclass55_1.auroraCommanderType_0 == AuroraCommanderType.Naval &&
                    gclass55_1.gclass21_0 == Race &&
                    gclass55_1.gclass59_0 == null && !gclass55_1.bool_4 &&
                    gclass55_1.auroraCommandType_0 == AuroraCommandType.None && gclass55_1.gclass61_0 == gclass61_0)
                .Where(gclass55_1 => gclass55_1.dictionary_0.ContainsKey(genum121_0)).ToList();
            if (list.Count == 0)
            {
                gclass61 = gclass61_0.method_3();
                if (gclass61 == null)
                    return;
                list = gclass0_0.dictionary_42.Values.Where(v =>
                    this.gclass0_0.GameTime - v.decimal_0 > AuroraUtils.decimal_29 && !v.bool_0 &&
                    v.gclass61_0 == gclass61).ToList();
                if (list.Count == 0)
                    return;
            }

            GClass55 gclass55_1_1 = list
                .OrderByDescending(gclass55_1 =>
                    gclass55_1.method_5(genum121_0) + gclass55_1.method_5(CommanderBonusType.PoliticalReliability))
                .ThenByDescending(gclass55_1 => gclass55_1.method_5(genum121_1))
                .ThenByDescending(gclass55_1 => gclass55_1.method_5(genum121_2)).FirstOrDefault();
            // ISSUE: reference to a compiler-generated field
            if (gclass61 != null)
                Race.method_250(gclass55_1_1, true);
            gclass55_1_1.method_40(false);
            if (gclass55_0 != null)
                gclass55_0.method_40(true);
            gclass55_1_1.gclass83_0 = this;
            gclass55_1_1.auroraCommandType_0 = AuroraCommandType.NavalAdminCommand;
            gclass55_1_1.decimal_1 = gclass0_0.GameTime;
            gclass55_0 = gclass55_1_1;
            if (gclass146_0 != null)
            {
                gclass55_1_1.gclass146_0 = gclass146_0;
                gclass55_1_1.gclass40_0 = null;
                gclass0_0.gclass92_0.method_2(EventType.const_78,
                    $"{gclass55_1_1.method_36()} assigned as commander of {AdminCommandName}", gclass55_1_1.gclass21_0,
                    gclass146_0.gclass202_0.ActualSystem, gclass146_0.method_87(), gclass146_0.method_88(),
                    AuroraEventCategory.Commander);
            }
            else if (gclass40_0 != null)
            {
                gclass55_1_1.gclass146_0 = null;
                gclass55_1_1.gclass40_0 = gclass40_0;
                gclass0_0.gclass92_0.method_2(EventType.const_78,
                    $"{gclass55_1_1.method_36()} assigned as commander of {AdminCommandName}", gclass55_1_1.gclass21_0,
                    gclass40_0.gclass85_0.System.ActualSystem, gclass40_0.gclass85_0.XCoord,
                    gclass40_0.gclass85_0.YCoord, AuroraEventCategory.Commander);
            }

            gclass55_1_1.method_46($"Assigned to {AdminCommandName}", GEnum28.const_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3485);
        }
    }

    public List<ShipData> method_1()
    {
        try
        {
            var list = this.method_12();
            list.AddRange(this.method_2());
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.Ships.Values.Where<ShipData>(v => list.Contains(v.gclass85_0))
                .ToList<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 753);
            return null;
        }
    }

    public List<FleetData> method_2()
    {
        try
        {
            List<FleetData> gclass85List = new List<FleetData>();
            foreach (NavalAdminCommand gclass83 in this.gclass0_0.NavalAdminCommands.Values
                         .Where<NavalAdminCommand>(gclass83_1 => gclass83_1.ParentAdminCommand == this).ToList<NavalAdminCommand>())
            {
                gclass85List.AddRange(gclass83.method_12());
                gclass85List.AddRange(gclass83.method_2());
            }

            return gclass85List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 754);
            return null;
        }
    }

    public void method_3()
    {
        try
        {
            PopulationData gclass146 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_1 =>
                    gclass146_1.Race == this.Race &&
                    gclass146_1.method_62(AuroraProductionCategory.NavalHeadquarters) > 0M)
                .OrderByDescending<PopulationData, Decimal>(gclass146_0 =>
                    gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters)).FirstOrDefault<PopulationData>();
            if (gclass146 != null)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_154,
                    $"Due to the destruction of its current headquarters on {this.gclass146_0.PopName}, {this.AdminCommandName} has been moved to {gclass146.PopName}",
                    this.Race, gclass146.gclass202_0.ActualSystem, gclass146.method_87(), gclass146.method_88(),
                    AuroraEventCategory.PopSummary);
                this.gclass146_0 = gclass146;
            }
            else
                this.gclass0_0.gclass92_0.method_2(EventType.const_154,
                    $"{this.AdminCommandName} is currently ineffective due to the destruction of its current headquarters. No other headquarters facilities are currently available",
                    this.Race, this.gclass146_0.gclass202_0.ActualSystem, this.gclass146_0.method_87(),
                    this.gclass146_0.method_88(), AuroraEventCategory.PopSummary);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 755);
        }
    }

    public string method_4()
    {
        try
        {
            return this.gclass55_0 == null
                ? "No Fleet Commander"
                : $"{this.gclass55_0.method_36()}   {this.gclass55_0.method_29(false)}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 756);
            return "error";
        }
    }

    public Decimal method_5(int int_5, CommanderBonusType genum121_3)
    {
        try
        {
            Decimal num = 1M;
            if (!this.dictionary_0.ContainsKey(int_5) || this.gclass55_0 == null || !this.bool_2)
                return 1M;
            switch (genum121_3)
            {
                case CommanderBonusType.CrewTraining:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.CrewTraining) - 1M) * this.gclass79_0.CrewTraining;
                    break;
                case CommanderBonusType.Survey:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Survey) - 1M) * this.gclass79_0.Survey;
                    break;
                case CommanderBonusType.Production:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Production) - 1M) * this.gclass79_0.Industrial;
                    break;
                case CommanderBonusType.Mining:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Mining) - 1M) * this.gclass79_0.Industrial;
                    break;
                case CommanderBonusType.Terraforming:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Terraforming) - 1M) * this.gclass79_0.Industrial;
                    break;
                case CommanderBonusType.Reaction:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Reaction) - 1M) * this.gclass79_0.Reaction;
                    break;
                case CommanderBonusType.Tactical:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Tactical) - 1M) * this.gclass79_0.Tactical;
                    break;
                case CommanderBonusType.Logistics:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Logistics) - 1M) * this.gclass79_0.Logistics;
                    break;
                case CommanderBonusType.Engineering:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.Engineering) - 1M) * this.gclass79_0.Engineering;
                    break;
                case CommanderBonusType.FleetTraining:
                    num = 1M + (this.gclass55_0.method_5(CommanderBonusType.CrewTraining) - 1M) * this.gclass79_0.FleetTraining;
                    break;
            }

            if (this.ParentAdminCommand != null)
            {
                if (this.gclass146_0 != null)
                    num *= this.ParentAdminCommand.method_5(this.gclass146_0.gclass202_0.ActualSystem.SystemID, genum121_3);
                else if (this.gclass40_0 != null)
                    num *= this.ParentAdminCommand.method_5(this.gclass40_0.gclass85_0.System.ActualSystem.SystemID,
                        genum121_3);
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 758);
            return 1M;
        }
    }

    public string method_6()
    {
        try
        {
            return this.gclass40_0 != null
                ? $"{this.gclass79_0.Abbrev} {this.AdminCommandName}  ({this.gclass61_0.RankAbbreviation})  -  {this.gclass40_0.method_187()}"
                : (this.gclass146_0 == null
                    ? $"{this.gclass79_0.Abbrev} {this.AdminCommandName}  ({this.gclass61_0.RankAbbreviation})"
                    : $"{this.gclass79_0.Abbrev} {this.AdminCommandName}  ({this.gclass61_0.RankAbbreviation})  -  {this.gclass146_0.PopName}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 759);
            return "Error";
        }
    }

    public int method_7()
    {
        try
        {
            return this.gclass146_0 == null
                ? 0
                : (int)(this.gclass0_0.method_589(
                            (int)this.gclass146_0.method_62(AuroraProductionCategory.NavalHeadquarters)) *
                        this.gclass79_0.Radius);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 760);
            return 0;
        }
    }

    public void method_8()
    {
        try
        {
            this.dictionary_0.Clear();
            if (this.gclass40_0 != null)
            {
                this.dictionary_0.Add(this.gclass40_0.gclass85_0.System.ActualSystem.SystemID,
                    this.gclass40_0.gclass85_0.System);
            }
            else
            {
                if (this.gclass146_0 == null)
                    return;
                this.dictionary_0 =
                    this.gclass0_0.method_32(this.Race, this.gclass146_0.gclass202_0, this.method_7());
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 761);
        }
    }

    public void method_9(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            this.gclass0_0.method_601(listView_0, "Systems Within Range", "Range", "NHQ Level");
            this.gclass0_0.method_594(listView_0, "");
            this.method_8();
            this.dictionary_0 = this.dictionary_0
                .OrderBy<KeyValuePair<int, RacialSystemSurvey>, int>(keyValuePair_0 => keyValuePair_0.Value.int_10)
                .ThenBy<KeyValuePair<int, RacialSystemSurvey>, string>(keyValuePair_0 => keyValuePair_0.Value.Name)
                .ToDictionary<KeyValuePair<int, RacialSystemSurvey>, int, RacialSystemSurvey>(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
            foreach (RacialSystemSurvey object_1 in this.dictionary_0.Values)
            {
                int num = object_1.method_35();
                string string_12 = "-";
                if (num > 0)
                    string_12 = num.ToString();
                this.gclass0_0.method_602(listView_0, object_1.Name, object_1.int_10.ToString(), string_12, object_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 762);
        }
    }

    public void method_10()
    {
        try
        {
            RankThemeEntry gclass61_1 = this.method_13();
            if (gclass61_1 == null)
            {
                this.gclass61_0 = this.Race.GetRankThemeForCommanderLevel(CommanderLevel.LVL2, AuroraCommanderType.Naval);
            }
            else
            {
                RankThemeEntry gclass61_2 = gclass61_1.method_1();
                if (gclass61_2 == null)
                    this.gclass61_0 = gclass61_1;
                else
                    this.gclass61_0 = gclass61_2;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 763);
        }
    }

    public bool method_11()
    {
        try
        {
            RankThemeEntry gclass61_1 = this.method_14();
            if (gclass61_1 == null || gclass61_1.RankNum > this.gclass61_0.RankNum)
                return false;
            RankThemeEntry gclass61_2 = gclass61_1.method_1();
            if (gclass61_2 == null)
            {
                if (gclass61_1 == this.gclass61_0)
                    return false;
                this.gclass61_0 = gclass61_1;
                return true;
            }

            this.gclass61_0 = gclass61_2;
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 764);
            return false;
        }
    }

    public List<FleetData> method_12()
    {
        try
        {
            return this.gclass0_0.FleetDictionary.Values.Where<FleetData>(gclass85_0 => gclass85_0.ParentNavalCommand == this)
                .ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 766);
            return null;
        }
    }

    public RankThemeEntry method_13()
    {
        try
        {
            List<GClass55> list = this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 => gclass85_0.ParentNavalCommand == this)
                .Select<FleetData, GClass55>(gclass85_0 => gclass85_0.method_162())
                .Where<GClass55>(gclass55_0 => gclass55_0 != null).ToList<GClass55>();
            return list.Count == 0
                ? this.Race.GetRankThemeForCommanderLevel(CommanderLevel.LVL1, AuroraCommanderType.Naval)
                : list.Select<GClass55, RankThemeEntry>(gclass55_0 => gclass55_0.gclass61_0)
                    .OrderBy<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).FirstOrDefault<RankThemeEntry>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 767 /*0x02FF*/);
            return null;
        }
    }

    public RankThemeEntry method_14()
    {
        try
        {
            List<NavalAdminCommand> list = this.gclass0_0.NavalAdminCommands.Values
                .Where<NavalAdminCommand>(gclass83_1 => gclass83_1.ParentAdminCommand == this).ToList<NavalAdminCommand>();
            if (list.Count == 0)
                return null;
            RankThemeEntry gclass61_1 = list.Select<NavalAdminCommand, RankThemeEntry>(gclass83_0 => gclass83_0.gclass61_0)
                .OrderBy<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).FirstOrDefault<RankThemeEntry>();
            RankThemeEntry gclass61_2 = list.Select<NavalAdminCommand, GClass55>(gclass83_0 => gclass83_0.gclass55_0)
                .Where<GClass55>(gclass55_0 => gclass55_0 != null)
                .Select<GClass55, RankThemeEntry>(gclass55_0 => gclass55_0.gclass61_0)
                .OrderBy<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).FirstOrDefault<RankThemeEntry>();
            return gclass61_2 == null || gclass61_2.RankNum >= gclass61_1.RankNum ? gclass61_1 : gclass61_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 768 /*0x0300*/);
            return null;
        }
    }
}