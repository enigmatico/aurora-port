// Decompiled with JetBrains decompiler
// Type: GClass103
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GroundUnitFormationData
{
    private sealed class Class1041
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.GroundUnitClass == this.gclass39_0.GroundUnitClass;
        }
    }


    private sealed class Class1042
    {
        public int int_0;

        internal bool method_0(RankThemeEntry gclass61_0)
        {
            return gclass61_0.CommanderType == AuroraCommanderType.GroundForce &&
                   gclass61_0.RankNum == this.int_0;
        }
    }


    private sealed class Class1043
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.GroundUnitClass == this.gclass39_0.GroundUnitClass;
        }
    }


    private sealed class Class1044
    {
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationElement gclass39_1)
        {
            return gclass39_1.GroundUnitClass == this.gclass39_0.GroundUnitClass;
        }
    }


    private sealed class Class1045
    {
        public FCTShipData40 gclass40_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass40_0 == this.gclass40_0;
        }
    }


    private sealed class Class1046
    {
        public GroundUnitFormationData gclass103_0;
        public GroundUnitFormationData gclass103_1;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.GroundUnitClass.method_1() > 0 && this.gclass103_0.PopulationData != null;
        }

        internal bool method_1(GroundUnitFormationElement gclass39_0)
        {
            return this.gclass103_0.PopulationData == this.gclass103_1.PopulationData;
        }

        internal bool method_2(GroundUnitFormationElement gclass39_0)
        {
            return gclass39_0.GroundUnitClass.method_1() > 0 &&
                   gclass39_0.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_6 &&
                   this.gclass103_0.PopulationData != null;
        }

        internal bool method_3(GroundUnitFormationElement gclass39_0)
        {
            return this.gclass103_0.PopulationData == this.gclass103_1.PopulationData;
        }
    }


    private sealed class Class1047
    {
        public GroundUnitFormationData gclass103_0;
        public PopulationData gclass146_0;
        public FCTShipData40 gclass40_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0 && gclass103_1.PopulationData == this.gclass146_0;
        }

        internal bool method_1(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0 && gclass103_1.ShipData == this.gclass40_0;
        }

        internal bool method_2(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }


    private sealed class Class1048
    {
        public GroundUnitFormationData gclass103_0;
        public GroundUnitFormationData gclass103_1;

        internal bool method_0(GroundUnitFormationData gclass103_2)
        {
            return gclass103_2.ParentFormationData == this.gclass103_0;
        }

        internal bool method_1(GroundUnitFormationData gclass103_2)
        {
            return gclass103_2.OriginalTemplateData == this.gclass103_1.OriginalTemplateData &&
                   gclass103_2.PopulationData == this.gclass103_1.PopulationData && gclass103_2.PopulationData != null;
        }
    }

    private GClass0 gclass0_0;
    public FCTRaceRecordC21 RaceData;
    public RankThemeEntry RequiredRankData;
    public PopulationData PopulationData;
    public FCTShipData40 ShipData;
    public GClass55 gclass55_0;
    public GroundUnitFormationData ParentFormationData;
    public GroundUnitFormationData AssignedFormationData;
    public GroundUnitFormationData gclass103_2;
    public GroundUnitFormationTemplateData OriginalTemplateData;
    public GroundUnitFormationTemplateData ReplacementTemplateData;
    public List<GroundUnitFormationElement> ElementList = new List<GroundUnitFormationElement>();
    public List<GroundUnitFormationElement> list_1 = new List<GroundUnitFormationElement>();
    public Dictionary<GroundUnitClass101, int> dictionary_0 = new Dictionary<GroundUnitClass101, int>();
    public Dictionary<GroundUnitClass101, int> dictionary_1 = new Dictionary<GroundUnitClass101, int>();
    public AuroraGroundFormationFieldPosition FieldPosition;
    public GUBoardingStatus BoardingStatus;
    public int FormationID;
    public int int_1;
    public int ParentFormationID;
    public int AssignedFormationID;
    public int ReplacementPriority = 10;
    public int OrgLinkID;
    public int bDoNotRecover;
    public bool bool_0;
    public bool bool_1;
    public bool bActiveSensorsOn;
    public bool bCivilian;
    public bool bUseForReplacements;
    public string Abbreviation;
    private AllMineralsValue gclass123_0;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public Decimal decimal_5;
    public Decimal decimal_6;
    public Decimal decimal_7;
    public Decimal decimal_8;
    public Decimal decimal_9;
    public Decimal decimal_10;
    public Decimal decimal_11;
    public Decimal decimal_12;
    public Decimal decimal_13;
    public Decimal decimal_14;
    public Decimal decimal_15;
    public Decimal decimal_16;
    public Decimal decimal_17;
    private string string_2 = "";
    public string string_3 = "";
    public string string_4 = "Unknown";
    public bool bool_5;
    public int int_7;
    public int int_8;
    public List<FCTShipData40> list_2 = new List<FCTShipData40>();
    public long long_0;
    public long long_1;
    public int int_9;
    public Decimal decimal_18 = 1M;
    public Decimal decimal_19 = 1M;
    public Decimal decimal_20 = 1M;
    public Decimal decimal_21 = 1M;
    public Decimal decimal_22 = 1M;
    public Decimal decimal_23 = 1M;
    public Decimal decimal_24;
    public Decimal decimal_25;
    public bool bool_6;
    public int int_10;

    public string Name { get; set; }

    public GroundUnitFormationData(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public Decimal method_0(CommanderBonusType genum121_0)
    {
        try
        {
            return this.ParentFormationData == null || this.ParentFormationData.PopulationData == null ||
                   this.ParentFormationData.PopulationData != this.PopulationData || this.ParentFormationData.gclass55_0 == null
                ? 1M
                : (1M + (this.ParentFormationData.gclass55_0.method_5(genum121_0) - 1M) * AuroraUtils.decimal_7 *
                    this.ParentFormationData.gclass55_0.decimal_3) * this.ParentFormationData.method_0(genum121_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3705);
            return 0M;
        }
    }

    public int method_1(GroundUnitFormationElement gclass39_0, int int_11)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitFormationData.Class1043 class1043 = new GroundUnitFormationData.Class1043();
        // ISSUE: reference to a compiler-generated field
        class1043.gclass39_0 = gclass39_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (class1043.gclass39_0.UnitCount < int_11)
            {
                // ISSUE: reference to a compiler-generated field
                int_11 = class1043.gclass39_0.UnitCount;
            }

            // ISSUE: reference to a compiler-generated method
            GroundUnitFormationElement gclass39 = this.ElementList.FirstOrDefault<GroundUnitFormationElement>(class1043.method_0);
            if (gclass39 != null)
            {
                // ISSUE: reference to a compiler-generated field
                gclass39.Morale =
                    Math.Floor((gclass39.Morale * gclass39.UnitCount + class1043.gclass39_0.Morale * int_11) /
                               (gclass39.UnitCount + int_11));
                // ISSUE: reference to a compiler-generated field
                double d = (gclass39.CurrentSupply * gclass39.UnitCount + class1043.gclass39_0.CurrentSupply * int_11) /
                           (double)(gclass39.UnitCount + int_11);
                gclass39.CurrentSupply = (int)Math.Floor(d);
                gclass39.UnitCount += int_11;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.ElementList.Add(new GroundUnitFormationElement(this.gclass0_0)
                {
                    ElementID = this.gclass0_0.method_26(GEnum0.const_44),
                    GroundUnitClass = class1043.gclass39_0.GroundUnitClass,
                    Formation = this,
                    RaceData = class1043.gclass39_0.RaceData,
                    UnitCount = int_11,
                    CurrentSupply = class1043.gclass39_0.CurrentSupply,
                    Morale = class1043.gclass39_0.Morale,
                    FortificationLevel = class1043.gclass39_0.FortificationLevel
                });
            }

            // ISSUE: reference to a compiler-generated field
            if (int_11 == class1043.gclass39_0.UnitCount)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1043.gclass39_0.Formation.ElementList.Remove(class1043.gclass39_0);
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1043.gclass39_0.UnitCount -= int_11;
            }

            return int_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3360);
            return 0;
        }
    }

    public bool method_2(GroundUnitFormationData gclass103_3)
    {
        try
        {
            return (this.PopulationData == null || gclass103_3.PopulationData == this.PopulationData) &&
                   (this.ShipData == null || gclass103_3.ShipData == this.ShipData);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3229);
            return false;
        }
    }

    public List<GClass65> method_3()
    {
        try
        {
            return this.gclass0_0.dictionary_28.Values.Where<GClass65>(gclass65_0 =>
                    gclass65_0.auroraContactType_0 == AuroraContactType.GroundUnit && gclass65_0.int_1 == this.FormationID)
                .ToList<GClass65>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1759);
            return null;
        }
    }

    public void method_4(PopulationData gclass146_1, List<RankThemeEntry> list_3, bool bool_7)
    {
        try
        {
            if (this.gclass55_0 != null)
                this.gclass55_0.method_40(true);
            this.RaceData = gclass146_1.RaceData;
            this.PopulationData = gclass146_1;
            this.RequiredRankData = list_3.FirstOrDefault<RankThemeEntry>(gclass61_1 => gclass61_1.RankNum == this.RequiredRankData.RankNum);
            this.AssignedFormationData = null;
            this.gclass103_2 = null;
            this.OriginalTemplateData = null;
            this.ReplacementTemplateData = null;
            foreach (GClass65 gclass65 in this.method_3())
                this.gclass0_0.dictionary_28.Remove(gclass65.int_0);
            if (!bool_7)
                return;
            foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values
                         .Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.ParentFormationData == this).ToList<GroundUnitFormationData>())
                gclass103.method_4(gclass146_1, list_3, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1760);
        }
    }

    public void method_5(Decimal decimal_26)
    {
        try
        {
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
            {
                int num = (int)Math.Floor(gclass39.UnitCount * decimal_26);
                if (num != 0)
                {
                    gclass39.UnitCount -= num;
                    this.gclass0_0.gclass92_0.method_2(EventType.const_61,
                        $"Due to external damage during boarding combat, {num.ToString()}x {gclass39.GroundUnitClass.ClassName} from {this.Name} have been lost",
                        this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                        this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord,
                        AuroraEventCategory.Ship);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1761);
        }
    }

    public void method_6(GroundUnitFormationData gclass103_3)
    {
        try
        {
            foreach (GroundUnitFormationElement gclass39_1 in gclass103_3.ElementList)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GroundUnitFormationData.Class1044 class1044 = new GroundUnitFormationData.Class1044();
                // ISSUE: reference to a compiler-generated field
                class1044.gclass39_0 = gclass39_1;
                // ISSUE: reference to a compiler-generated method
                GroundUnitFormationElement gclass39_2 = this.ElementList.FirstOrDefault<GroundUnitFormationElement>(class1044.method_0);
                if (gclass39_2 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass39_2.Morale =
                        Math.Floor((gclass39_2.Morale * gclass39_2.UnitCount +
                                    class1044.gclass39_0.Morale * class1044.gclass39_0.UnitCount) /
                                   (gclass39_2.UnitCount + class1044.gclass39_0.UnitCount));
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    double d = (gclass39_2.CurrentSupply * gclass39_2.UnitCount +
                                class1044.gclass39_0.CurrentSupply * class1044.gclass39_0.UnitCount) /
                               (double)(gclass39_2.UnitCount + class1044.gclass39_0.UnitCount);
                    gclass39_2.CurrentSupply = (int)Math.Floor(d);
                    // ISSUE: reference to a compiler-generated field
                    gclass39_2.UnitCount += class1044.gclass39_0.UnitCount;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.ElementList.Add(new GroundUnitFormationElement(this.gclass0_0)
                    {
                        ElementID = this.gclass0_0.method_26(GEnum0.const_44),
                        GroundUnitClass = class1044.gclass39_0.GroundUnitClass,
                        Formation = this,
                        RaceData = class1044.gclass39_0.RaceData,
                        UnitCount = class1044.gclass39_0.UnitCount,
                        CurrentSupply = class1044.gclass39_0.CurrentSupply,
                        Morale = class1044.gclass39_0.Morale,
                        FortificationLevel = class1044.gclass39_0.FortificationLevel
                    });
                }
            }

            this.gclass0_0.FormationDictionary.Remove(gclass103_3.FormationID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1762);
        }
    }

    public void method_7(GroundUnitClass101 gclass101_0, int int_11)
    {
        try
        {
            if (this.dictionary_0.ContainsKey(gclass101_0))
                this.dictionary_0[gclass101_0] = this.dictionary_0[gclass101_0] + int_11;
            else
                this.dictionary_0.Add(gclass101_0, int_11);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1763);
        }
    }

    public void method_8(GroundUnitClass101 gclass101_0, int int_11)
    {
        try
        {
            if (this.dictionary_1.ContainsKey(gclass101_0))
                this.dictionary_1[gclass101_0] = this.dictionary_1[gclass101_0] + int_11;
            else
                this.dictionary_1.Add(gclass101_0, int_11);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1764);
        }
    }

    public void method_9(
        AuroraMeasurementType auroraMeasurementType_0,
        Decimal decimal_26,
        bool bool_7)
    {
        try
        {
            if (this.gclass55_0 == null)
                return;
            this.gclass55_0.method_1(auroraMeasurementType_0, decimal_26);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1765);
        }
    }

    public bool method_10(MoveOrder gclass139_0)
    {
        try
        {
            if (!this.gclass0_0.dictionary_28.ContainsKey(gclass139_0.DestinationID))
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_120,
                    $"{this.Name} (FLT: {this.ShipData.gclass85_0.FleetName}) was unable to launch a boarding attempt as the target ship does not exist",
                    this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                    this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord, AuroraEventCategory.Ship);
                return false;
            }

            FCTShipData40 gclass400 = this.gclass0_0.dictionary_28[gclass139_0.DestinationID].gclass40_0;
            if (gclass400 != null)
                return this.method_11(gclass400);
            this.gclass0_0.gclass92_0.method_2(EventType.const_120,
                $"{this.Name} (FLT: {this.ShipData.gclass85_0.FleetName}) was unable to launch a boarding attempt as the target contact is not a ship",
                this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord, AuroraEventCategory.Ship);
            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1766);
            return false;
        }
    }

    public bool method_11(FCTShipData40 gclass40_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitFormationData.Class1045 class1045 = new GroundUnitFormationData.Class1045();
        // ISSUE: reference to a compiler-generated field
        class1045.gclass40_0 = gclass40_1;
        try
        {
            // ISSUE: reference to a compiler-generated field
            if (class1045.gclass40_0.gclass85_0.Speed > this.ShipData.gclass85_0.Speed)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_120,
                    $"{this.Name} (FLT: {this.ShipData.gclass85_0.FleetName}) was unable to launch a boarding attempt as the target ship is moving faster than the ship from which the formation is making the boarding attempt",
                    this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                    this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord, AuroraEventCategory.Ship);
                return false;
            }

            if (this.ElementList.Count<GroundUnitFormationElement>(gclass39_0 => gclass39_0.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 != 0) > 0)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_120,
                    $"{this.Name} (FLT: {this.ShipData.gclass85_0.FleetName}) was unable to launch a boarding attempt as it contains non-infantry elements",
                    this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                    this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord, AuroraEventCategory.Ship);
                return false;
            }

            // ISSUE: reference to a compiler-generated method
            GClass117 gclass117 = this.RaceData.dictionary_12.Values.FirstOrDefault<GClass117>(class1045.method_0);
            // ISSUE: reference to a compiler-generated field
            double num1 = 100.0 * (this.ShipData.gclass85_0.Speed / (double)class1045.gclass40_0.gclass85_0.Speed);
            foreach (GroundUnitFormationElement gclass39 in this.ElementList.ToList<GroundUnitFormationElement>())
            {
                int num2 = 0;
                double num3 = num1;
                if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_1))
                    num3 *= 2.0;
                if (num3 < 1000.0)
                {
                    for (int index = 1; index <= gclass39.UnitCount; ++index)
                    {
                        if (AuroraUtils.GetRandomInteger(1000) > num3)
                            ++num2;
                    }

                    if (num2 != 0)
                    {
                        if (gclass39.GroundUnitClass.int_6 > 0)
                        {
                            GClass55 gclass550 = this.gclass55_0;
                            if (gclass550 != null && AuroraUtils.GetRandomInteger(gclass39.UnitCount) <= num2)
                            {
                                this.gclass0_0.gclass92_0.method_2(EventType.const_63,
                                    $"{gclass550.string_0}( {gclass550.method_17(false)}) has been killed during a boarding attempt on {gclass117.method_11()}",
                                    this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                                    this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord,
                                    AuroraEventCategory.Ship);
                                gclass550.method_46("Killed during a boarding attempt on " + gclass117.method_11(),
                                    GEnum28.const_0);
                                gclass550.method_42(AuroraRetirementStatus.KilledBoarding);
                            }
                        }

                        if (num2 == gclass39.UnitCount)
                        {
                            this.ElementList.Remove(gclass39);
                            this.gclass0_0.gclass92_0.method_2(EventType.const_120,
                                $"{num2.ToString()}x {gclass39.GroundUnitClass.ClassName} were lost in the boarding attempt by {this.Name} (FLT: {this.ShipData.gclass85_0.FleetName}). No more units of this type remain within the formation",
                                this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                                this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord,
                                AuroraEventCategory.Ship);
                            this.ShipData = null;
                        }
                        else
                        {
                            gclass39.UnitCount -= num2;
                            this.gclass0_0.gclass92_0.method_2(EventType.const_120,
                                $"{num2.ToString()}x {gclass39.GroundUnitClass.ClassName} were lost in the boarding attempt by {this.Name} (FLT: {this.ShipData.gclass85_0.FleetName}). {gclass39.UnitCount.ToString()} of this type remain within the formation",
                                this.RaceData, this.ShipData.gclass85_0.System.ActualSystemData,
                                this.ShipData.gclass85_0.XCoord, this.ShipData.gclass85_0.YCoord,
                                AuroraEventCategory.Ship);
                        }
                    }
                }
            }

            if (this.ElementList.Count == 0)
                return true;
            this.BoardingStatus = GUBoardingStatus.const_1;
            // ISSUE: reference to a compiler-generated field
            this.ShipData = class1045.gclass40_0;
            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1767);
            return false;
        }
    }

    public bool method_12()
    {
        try
        {
            return this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.AssignedFormationData == this)
                .Count<GroundUnitFormationData>() > 0 || this.gclass0_0.FCTShipDataDictionary.Values
                .Where<FCTShipData40>(gclass40_1 => gclass40_1.gclass103_0 == this).Count<FCTShipData40>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1768);
            return false;
        }
    }

    public bool method_13()
    {
        try
        {
            return this.ElementList.SelectMany<GroundUnitFormationElement, GroundComponentTypeDefinition>(gclass39_0 => gclass39_0.GroundUnitClass.GroundUnitComponentList)
                .Count<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey > 0M) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1769);
            return false;
        }
    }

    public GEnum55 method_14()
    {
        try
        {
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            Decimal num3 = 0M;
            Decimal num4 = 0M;
            Decimal num5 = 0M;
            Decimal num6 = 0M;
            Decimal num7 = 0M;
            Decimal num8 = 0M;
            Decimal num9 = 0M;
            Decimal num10 = 0M;
            Decimal num11 = 0M;
            this.decimal_0 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
            {
                this.decimal_0 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_5)
                    num4 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                else if (gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_0)
                    num2 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                else if (gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_1)
                    num3 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.LogisticsPoint > 0)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num1 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.BombardmentWeaponClass != 0)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num5 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.AAWeaponClass != 0)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num6 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Construction > 0M)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num7 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey > 0M)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num8 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Xenoarchaeology > 0M)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num9 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Decontamination > 0M)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num11 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Where<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.STO > 0)
                        .Count<GroundComponentTypeDefinition>() > 0)
                    num10 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
            }

            Decimal num12 = this.decimal_0 - num1;
            if (num1 > num12 * 2M)
                return GEnum55.const_9;
            if (num5 > num12 * 0.4M)
                return GEnum55.const_2;
            if (num6 > num12 * 0.4M)
                return GEnum55.const_3;
            if (this.decimal_7 > num12 * 0.4M)
                return GEnum55.const_5;
            if (num8 > num12 * 0.4M)
                return GEnum55.const_6;
            if (num9 > num12 * 0.4M)
                return GEnum55.const_8;
            if (num11 > num12 * 0.4M)
                return GEnum55.const_10;
            if (num10 > num12 * 0.4M)
                return GEnum55.const_7;
            if (num3 > num12 * 0.6M)
                return GEnum55.const_1;
            return num4 > num4 * 0.6M ? GEnum55.const_4 : GEnum55.const_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1770);
            return GEnum55.const_0;
        }
    }

    public TreeNode method_15(TreeView treeView_0, CheckState checkState_0, CheckState checkState_1)
    {
        try
        {
            TreeNode node = new TreeNode();
            node.Text = this.method_25(checkState_0, checkState_1);
            node.Tag = this;
            if (this.AssignedFormationData != null && checkState_1 == CheckState.Checked)
                node.ForeColor = AuroraUtils.color_0;
            if (this.bool_5 && checkState_1 == CheckState.Checked)
                node.ForeColor = AuroraUtils.color_1;
            treeView_0.Nodes.Add(node);
            return node;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1771);
            return null;
        }
    }

    public TreeNode method_16(TreeNode treeNode_0, CheckState checkState_0, CheckState checkState_1)
    {
        try
        {
            TreeNode node = new TreeNode();
            node.Text = this.method_25(checkState_0, checkState_1);
            node.Tag = this;
            if (this.AssignedFormationData != null && checkState_1 == CheckState.Checked)
                node.ForeColor = AuroraUtils.color_0;
            if (this.bool_5 && checkState_1 == CheckState.Checked)
                node.ForeColor = AuroraUtils.color_1;
            treeNode_0.Nodes.Add(node);
            return node;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1772);
            return null;
        }
    }

    public void method_17(TreeNode treeNode_0)
    {
        try
        {
            this.ElementList = this.ElementList.OrderByDescending<GroundUnitFormationElement, int>(gclass39_0 => gclass39_0.UnitCount)
                .ToList<GroundUnitFormationElement>();
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                treeNode_0.Nodes.Add(new TreeNode()
                {
                    Text = $"{gclass39.UnitCount.ToString()}x {gclass39.GroundUnitClass.ClassName}",
                    Tag = gclass39
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1773);
        }
    }

    public bool method_18(GroundUnitFormationData gclass103_3_1)
    {
        try
        {
            if (this.PopulationData.SystemBodyData != gclass103_3_1.PopulationData.SystemBodyData)
            {
                int num = (int)MessageBox.Show(
                    "Support can only be provided when the supporting formation is on the same system body as the supported formation",
                    "Support Not Possible");
                return false;
            }

            List<GroundUnitFormationData> list_3 = new List<GroundUnitFormationData>();
            List<GroundUnitFormationData> gclass103List = gclass103_3_1.method_19(list_3);
            if (gclass103List == null)
                return false;
            bool flag = false;
            if (gclass103List.Contains(this))
                flag = true;
            else if (this.ParentFormationData != null && gclass103List.Contains(this.ParentFormationData) && this.gclass0_0
                         .FormationDictionary.Values.Where<GroundUnitFormationData>(gclass103_3_2 => gclass103_3_2.ParentFormationData == this)
                         .Count<GroundUnitFormationData>() == 0)
                flag = true;
            if (flag)
                return true;
            int num1 = (int)MessageBox.Show(
                "Support can only be provided when the supporting formation is a superior formation in the hierarchy of the supported formation, or is directly subordinate to a superior formation in the hierarchy of the supported formation and does not itself have any subordinate formations (an independent artillery formation for example)",
                "Support Not Possible");
            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1774);
            return false;
        }
    }

    public List<GroundUnitFormationData> method_19(List<GroundUnitFormationData> list_3)
    {
        try
        {
            if (this.ParentFormationData == null)
                return null;
            list_3.Add(this.ParentFormationData);
            this.ParentFormationData.method_19(list_3);
            return list_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1775);
            return null;
        }
    }

    public bool method_20(Decimal decimal_26, GroundUnitFormationData gclass103_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitFormationData.Class1046 class1046 = new GroundUnitFormationData.Class1046();
        // ISSUE: reference to a compiler-generated field
        class1046.gclass103_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1046.gclass103_1 = gclass103_3;
        try
        {
            if (decimal_26 <= 0M)
                return true;
            bool flag = false;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<GroundUnitFormationElement> gclass39List = class1046.gclass103_1 != this
                ? this.ElementList.Where<GroundUnitFormationElement>(class1046.method_2).Where<GroundUnitFormationElement>(class1046.method_3)
                    .OrderByDescending<GroundUnitFormationElement, int>(gclass39_0 => gclass39_0.UnitCount).ToList<GroundUnitFormationElement>()
                : this.ElementList.Where<GroundUnitFormationElement>(class1046.method_0).Where<GroundUnitFormationElement>(class1046.method_1)
                    .OrderByDescending<GroundUnitFormationElement, int>(gclass39_0 => gclass39_0.UnitCount).ToList<GroundUnitFormationElement>();
            if (gclass39List.Count == 0)
                return false;
            foreach (GroundUnitFormationElement gclass39 in gclass39List)
            {
                Decimal num1 = gclass39.GroundUnitClass.method_1();
                if (!(decimal_26 > num1 * gclass39.UnitCount))
                {
                    if (decimal_26 > num1)
                    {
                        int num2 = (int)Math.Floor(decimal_26 / num1);
                        decimal_26 -= num2 * num1;
                        gclass39.UnitCount -= num2;
                    }

                    Decimal num3 = decimal_26 / num1 * 1000M;
                    if (AuroraUtils.GetRandomInteger(1000) <= num3)
                        --gclass39.UnitCount;
                    flag = true;
                }
            }

            this.ElementList = this.ElementList.Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.UnitCount > 0).ToList<GroundUnitFormationElement>();
            return flag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1776);
            return false;
        }
    }

    public void method_21(List<GroundUnitFormationData> list_3, int int_11)
    {
        try
        {
            if (this.ParentFormationData == null)
                return;
            this.ParentFormationData.int_10 = int_11;
            list_3.Add(this.ParentFormationData);
            ++int_11;
            this.ParentFormationData.method_21(list_3, int_11);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1777);
        }
    }

    public List<GroundUnitFormationData> method_22(PopulationData gclass146_1, FCTShipData40 gclass40_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitFormationData.Class1047 class1047 = new GroundUnitFormationData.Class1047();
        // ISSUE: reference to a compiler-generated field
        class1047.gclass103_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1047.gclass146_0 = gclass146_1;
        // ISSUE: reference to a compiler-generated field
        class1047.gclass40_0 = gclass40_1;
        try
        {
            List<GroundUnitFormationData> gclass103List1 = new List<GroundUnitFormationData>();
            List<GroundUnitFormationData> gclass103List2 = new List<GroundUnitFormationData>();
            // ISSUE: reference to a compiler-generated field
            if (class1047.gclass146_0 != null)
            {
                // ISSUE: reference to a compiler-generated method
                gclass103List1 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1047.method_0)
                    .ToList<GroundUnitFormationData>();
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (GroundUnitFormationData gclass103 in class1047.gclass40_0 == null
                         ? this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1047.method_2).ToList<GroundUnitFormationData>()
                         : this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1047.method_1).ToList<GroundUnitFormationData>())
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass103List2.AddRange(gclass103.method_22(class1047.gclass146_0, class1047.gclass40_0));
            }

            gclass103List2.Add(this);
            return gclass103List2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1778);
            return null;
        }
    }

    public int method_23()
    {
        try
        {
            Decimal d = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
            {
                d += AuroraUtils.smethod_35(gclass39.GroundUnitClass.decimal_2) * gclass39.UnitCount * gclass39.Morale /
                     10000M;
                if (this.gclass55_0 != null)
                    d *= this.gclass55_0.method_5(CommanderBonusType.GroundCombatOccupation);
            }

            return (int)Math.Round(d);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1779);
            return 0;
        }
    }

    public void method_24(
        AuroraGroundFormationFieldPosition auroraGroundFormationFieldPosition_1,
        bool bool_7,
        bool bool_8,
        GroundUnitFormationData gclass103_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitFormationData.Class1048 class1048 = new GroundUnitFormationData.Class1048();
        // ISSUE: reference to a compiler-generated field
        class1048.gclass103_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1048.gclass103_1 = gclass103_3;
        try
        {
            if (!bool_8)
                this.FieldPosition = auroraGroundFormationFieldPosition_1;
            if (this.FieldPosition == AuroraGroundFormationFieldPosition.FrontlineAttack)
            {
                foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                    gclass39.FortificationLevel = 1M;
            }

            if (bool_7 || bool_8)
            {
                // ISSUE: reference to a compiler-generated method
                foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1048.method_0)
                             .ToList<GroundUnitFormationData>())
                    gclass103.method_24(auroraGroundFormationFieldPosition_1, true, false, null);
            }

            // ISSUE: reference to a compiler-generated field
            if (class1048.gclass103_1 == null)
                return;
            // ISSUE: reference to a compiler-generated method
            foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1048.method_1)
                         .ToList<GroundUnitFormationData>())
                gclass103.method_24(auroraGroundFormationFieldPosition_1, false, false, null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1780);
        }
    }

    public string method_25(CheckState checkState_0, CheckState checkState_1)
    {
        try
        {
            string str =
                checkState_0 == CheckState.Unchecked || this.FieldPosition ==
                AuroraGroundFormationFieldPosition.FrontlineDefence
                    ? $"{this.Abbreviation} {this.Name}"
                    : (this.FieldPosition != AuroraGroundFormationFieldPosition.FrontlineAttack
                        ? (this.FieldPosition != AuroraGroundFormationFieldPosition.Support
                            ? (this.FieldPosition !=
                               AuroraGroundFormationFieldPosition.RearEchelon
                                ? $"{this.Abbreviation} {this.Name}"
                                : $"{this.Abbreviation} {this.Name}  (RE)")
                            : $"{this.Abbreviation} {this.Name}  (SP)")
                        : $"{this.Abbreviation} {this.Name}  (FA)");
            if (this.bActiveSensorsOn)
                str += " (A)";
            if (this.bDoNotRecover == 1)
                str += " (DNR)";
            if (checkState_1 == CheckState.Checked && this.AssignedFormationData != null)
                str = $"{str} ---> {this.AssignedFormationData.Abbreviation} {this.AssignedFormationData.Name}";
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1781);
            return "error";
        }
    }

    public void method_26(bool bool_7, bool bool_8)
    {
        try
        {
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            Decimal num3 = 0M;
            Decimal num4 = 0M;
            this.decimal_0 = 0M;
            this.decimal_1 = 0M;
            this.decimal_2 = 0M;
            this.decimal_3 = 0M;
            this.decimal_4 = 0M;
            this.decimal_5 = 0M;
            this.decimal_6 = 0M;
            this.decimal_7 = 0M;
            this.decimal_8 = 0M;
            this.decimal_9 = 0M;
            this.int_1 = 0;
            this.decimal_13 = 0M;
            this.decimal_14 = 0M;
            this.decimal_15 = 0M;
            this.decimal_17 = 0M;
            this.decimal_10 = 0M;
            this.decimal_11 = 0M;
            this.decimal_16 = 1M;
            this.string_2 = "";
            this.gclass123_0 = new AllMineralsValue(this.gclass0_0);
            this.list_1 = this.ElementList.ToList<GroundUnitFormationElement>();
            if (bool_7)
                this.method_27();
            if (bool_8)
            {
                List<GroundUnitFormationElement> list1 = this.list_1
                    .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.Formation.PopulationData != null)
                    .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.Formation.PopulationData == this.PopulationData)
                    .ToList<GroundUnitFormationElement>();
                List<GroundUnitFormationElement> list2 = this.list_1
                    .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.Formation.ShipData != null)
                    .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.Formation.ShipData == this.ShipData)
                    .ToList<GroundUnitFormationElement>();
                this.list_1 = list1.ToList<GroundUnitFormationElement>();
                this.list_1.AddRange(list2.ToList<GroundUnitFormationElement>());
            }

            foreach (GroundUnitFormationElement gclass39 in this.list_1)
            {
                this.decimal_3 += gclass39.UnitCount;
                this.decimal_0 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                this.decimal_1 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                this.decimal_2 += gclass39.GroundUnitClass.method_8() * gclass39.UnitCount;
                this.decimal_4 += gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Shots) *
                                  gclass39.UnitCount;
                this.decimal_13 += gclass39.GroundUnitClass.decimal_4 * gclass39.UnitCount;
                num3 += gclass39.Morale * gclass39.UnitCount * gclass39.GroundUnitClass.decimal_2;
                num4 += gclass39.FortificationLevel * gclass39.UnitCount * gclass39.GroundUnitClass.decimal_2;
                if (gclass39.GroundUnitClass.decimal_4 > 0M)
                {
                    num1 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                    num2 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount * (gclass39.CurrentSupply / 10M);
                }

                if (gclass39.GroundUnitClass.int_6 > this.int_1)
                    this.int_1 = gclass39.GroundUnitClass.int_6;
                this.decimal_7 += gclass39.UnitCount * gclass39.GroundUnitClass.decimal_6;
                this.decimal_10 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey);
                this.decimal_11 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Xenoarchaeology);
                this.decimal_12 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Decontamination);
                this.decimal_9 += gclass39.UnitCount *
                                  gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.FireDirection);
                this.decimal_6 += gclass39.UnitCount *
                                  gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.STO);
                this.decimal_5 += gclass39.UnitCount *
                                  gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.int_1);
                this.decimal_17 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.LogisticsPoint);
            }

            if (this.decimal_0 == 0M)
            {
                this.decimal_15 = 0M;
                this.decimal_16 = 1M;
            }
            else
            {
                this.decimal_15 = num3 / this.decimal_0;
                this.decimal_16 = num4 / this.decimal_0;
            }

            if (num1 > 0M)
                this.decimal_14 = num2 / num1;
            string str = AuroraUtils.smethod_10(this.int_1);
            if (str != "-")
                this.string_2 = $"{this.string_2}HQ{str}  ";
            if (this.decimal_6 > 0M)
                this.string_2 = $"{this.string_2}ST{this.decimal_6.ToString()}  ";
            if (this.decimal_5 > 0M)
                this.string_2 = $"{this.string_2}CW{this.decimal_5.ToString()}  ";
            if (this.decimal_9 > 0M)
                this.string_2 = $"{this.string_2}FD{this.decimal_9.ToString()}  ";
            if (this.decimal_7 > 0M)
                this.string_2 = $"{this.string_2}CN{this.decimal_7.ToString()}  ";
            if (this.decimal_10 > 0M)
                this.string_2 = $"{this.string_2}GE{this.decimal_10.ToString()}  ";
            if (this.decimal_11 > 0M)
                this.string_2 = $"{this.string_2}XN{this.decimal_11.ToString()}  ";
            if (this.decimal_12 > 0M)
                this.string_2 = $"{this.string_2}DC{this.decimal_12.ToString()}  ";
            if (!(this.decimal_17 > 0M))
                return;
            this.string_2 = $"{this.string_2}LG{Math.Round(this.decimal_17 / 1000M).ToString()}  ";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1782);
        }
    }

    public void method_27()
    {
        try
        {
            this.list_1.Clear();
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                this.list_1.Add(gclass39);
            foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values
                         .Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.ParentFormationData == this).ToList<GroundUnitFormationData>())
            {
                gclass103.method_27();
                foreach (GroundUnitFormationElement gclass39 in gclass103.list_1)
                    this.list_1.Add(gclass39);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1783);
        }
    }

    public Decimal method_28()
    {
        try
        {
            Decimal int7 = this.int_7;
            foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values
                         .Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.ParentFormationData == this).ToList<GroundUnitFormationData>())
                int7 += gclass103.method_28();
            return int7;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3704);
            return 0M;
        }
    }

    public void method_29()
    {
        try
        {
            List<GroundUnitFormationElement> gclass39List = new List<GroundUnitFormationElement>();
            foreach (GroundUnitFormationElement gclass39_1 in this.list_1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GroundUnitFormationData.Class1041 class1041 = new GroundUnitFormationData.Class1041();
                // ISSUE: reference to a compiler-generated field
                class1041.gclass39_0 = gclass39_1;
                // ISSUE: reference to a compiler-generated method
                GroundUnitFormationElement gclass39_2 = gclass39List.FirstOrDefault<GroundUnitFormationElement>(class1041.method_0);
                if (gclass39_2 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class1041.gclass39_0.Morale != gclass39_2.Morale)
                    {
                        Decimal num1 = gclass39_2.GroundUnitClass.decimal_2 * gclass39_2.UnitCount;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        Decimal num2 = class1041.gclass39_0.GroundUnitClass.decimal_2 * class1041.gclass39_0.UnitCount;
                        Decimal num3 = num1 + num2;
                        // ISSUE: reference to a compiler-generated field
                        Decimal num4 = num1 * gclass39_2.Morale + num2 * class1041.gclass39_0.Morale;
                        gclass39_2.Morale = num4 / num3;
                    }

                    // ISSUE: reference to a compiler-generated field
                    gclass39_2.UnitCount += class1041.gclass39_0.UnitCount;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    GroundUnitFormationElement gclass39_3 = class1041.gclass39_0.method_14();
                    gclass39List.Add(gclass39_3);
                }
            }

            this.list_1 = this.RaceData.method_161(gclass39List);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1784);
        }
    }

    public void method_30(
        ListView listView_0,
        TextBox textBox_0,
        TextBox textBox_1,
        TextBox textBox_2,
        TextBox textBox_3,
        CheckBox checkBox_0,
        bool bool_7)
    {
        try
        {
            string string_21_1 = "-";
            if (this.gclass55_0 == null)
            {
                textBox_0.Text = "No commander assigned";
            }
            else
            {
                textBox_0.Text = $"{this.gclass55_0.method_36()}    {this.gclass55_0.method_29(true)}";
                string_21_1 = this.gclass55_0.gclass61_0.method_0();
            }

            if (this.ShipData != null)
                textBox_1.Text = this.ShipData.method_187();
            else if (this.PopulationData != null)
                textBox_1.Text = $"{this.PopulationData.PopName}  ({this.PopulationData.gclass202_0.Name})";
            else
                textBox_1.Text = "Location Unknown";
            textBox_2.Text = "None";
            if (this.ReplacementTemplateData != null)
                textBox_2.Text = this.ReplacementTemplateData.Name;
            textBox_3.Text = this.ReplacementPriority.ToString();
            checkBox_0.CheckState = AuroraUtils.smethod_28(this.bUseForReplacements);
            listView_0.Items.Clear();
            this.gclass0_0.method_624(listView_0, "Abbr", "Name", "Units", "Supply", "Morale", "Fort", "Size", "Cost",
                "HP", "GSP", "Formation Attributes", "AR", "RR", null);
            this.gclass0_0.method_594(listView_0, "");
            List<GroundUnitFormationData> list = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.ParentFormationData == this).ToList<GroundUnitFormationData>();
            if (bool_7 && this.PopulationData != null)
                list = list.Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.PopulationData == this.PopulationData)
                    .ToList<GroundUnitFormationData>();
            if (bool_7 && this.ShipData != null)
                list = list.Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.ShipData == this.ShipData)
                    .ToList<GroundUnitFormationData>();
            if (list.Count > 0)
                this.gclass0_0.method_599(listView_0, "", "Formation and Direct Attachments", AuroraUtils.color_2,
                    null);
            this.method_26(false, false);
            string string_13_1 = "-";
            if (this.decimal_13 > 0M)
                string_13_1 = AuroraUtils.smethod_39(this.decimal_14 * 100M) + "%";
            this.gclass0_0.method_624(listView_0, this.Abbreviation, this.Name, AuroraUtils.smethod_38(this.decimal_3),
                string_13_1, AuroraUtils.smethod_38(this.decimal_15), AuroraUtils.FormatNumberToDigits(this.decimal_16, 2),
                AuroraUtils.smethod_38(this.decimal_0), AuroraUtils.smethod_38(this.decimal_1),
                AuroraUtils.smethod_38(this.decimal_2), AuroraUtils.smethod_38(this.decimal_13), this.string_2,
                string_21_1, this.method_32().method_0(), this);
            if (list.Count > 0)
            {
                foreach (GroundUnitFormationData object_1 in list)
                {
                    string string_21_2 = object_1.gclass55_0 != null ? object_1.gclass55_0.gclass61_0.method_0() : "-";
                    object_1.method_26(true, bool_7);
                    string string_13_2 = "-";
                    if (object_1.decimal_13 > 0M)
                        string_13_2 = AuroraUtils.smethod_39(object_1.decimal_14 * 100M) + "%";
                    this.gclass0_0.method_624(listView_0, object_1.Abbreviation, "      " + object_1.Name,
                        AuroraUtils.smethod_38(object_1.decimal_3), string_13_2,
                        AuroraUtils.smethod_38(object_1.decimal_15), AuroraUtils.FormatNumberToDigits(object_1.decimal_16, 2),
                        AuroraUtils.smethod_38(object_1.decimal_0), AuroraUtils.smethod_38(object_1.decimal_1),
                        AuroraUtils.smethod_38(object_1.decimal_2), AuroraUtils.smethod_38(object_1.decimal_13),
                        object_1.string_2, string_21_2, object_1.method_32().method_0(), object_1);
                }

                this.method_26(true, bool_7);
                string string_13_3 = "-";
                if (this.decimal_13 > 0M)
                    string_13_3 = AuroraUtils.smethod_39(this.decimal_14 * 100M) + "%";
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_620(listView_0, "", "Total Organization", AuroraUtils.smethod_38(this.decimal_3),
                    string_13_3, AuroraUtils.smethod_38(this.decimal_15), AuroraUtils.FormatNumberToDigits(this.decimal_16, 2),
                    AuroraUtils.smethod_38(this.decimal_0), AuroraUtils.smethod_38(this.decimal_1),
                    AuroraUtils.smethod_38(this.decimal_2), AuroraUtils.smethod_38(this.decimal_13), this.string_2,
                    this);
            }

            this.gclass0_0.method_594(listView_0, "");
            this.gclass0_0.method_599(listView_0, "", "Formation Unit List", AuroraUtils.color_2, null);
            this.ElementList = this.RaceData.method_161(this.ElementList);
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                gclass39.method_15(listView_0);
            if (list.Count <= 0)
                return;
            this.gclass0_0.method_594(listView_0, "");
            this.gclass0_0.method_599(listView_0, "", "Complete Organization Unit List", AuroraUtils.color_2, null);
            this.method_27();
            this.method_29();
            foreach (GroundUnitFormationElement gclass39 in this.list_1)
                gclass39.method_15(listView_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1785);
        }
    }

    public int method_31()
    {
        try
        {
            if (this.RequiredRankData != null)
                return this.RequiredRankData.RankNum;
            int int_57 = this.method_33();
            this.decimal_0 = this.method_34();
            RankThemeEntry gclass61 = this.RaceData.method_156((int)this.decimal_0, int_57);
            foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values
                         .Where<GroundUnitFormationData>(gclass103_3 => gclass103_3.ParentFormationData == this).ToList<GroundUnitFormationData>())
            {
                if (gclass103.gclass55_0 != null && gclass103.gclass55_0.gclass61_0.RankNum <= gclass61.RankNum)
                    gclass61 = gclass103.gclass55_0.gclass61_0.method_1();
            }

            return gclass61 != null ? gclass61.RankNum : 1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1786);
            return 1;
        }
    }

    public RankThemeEntry method_32()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            return this.RaceData.RacialRankDictionary.Values.Where<RankThemeEntry>(new GroundUnitFormationData.Class1042()
            {
                int_0 = this.method_31()
            }.method_0).FirstOrDefault<RankThemeEntry>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1787);
            return null;
        }
    }

    public int method_33()
    {
        try
        {
            return this.ElementList.Count == 0 ? 0 : this.ElementList.Max<GroundUnitFormationElement>(gclass39_0 => gclass39_0.GroundUnitClass.int_6);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1788);
            return 0;
        }
    }

    public Decimal method_34()
    {
        try
        {
            this.decimal_0 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                this.decimal_0 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
            return this.decimal_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1789);
            return 0M;
        }
    }

    public Decimal method_35(FCTRaceRecordC21 gclass21_1)
    {
        try
        {
            this.decimal_0 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
            {
                if (gclass39.DetectingRaceList.Contains(gclass21_1))
                    this.decimal_0 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
            }

            return this.decimal_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1790);
            return 0M;
        }
    }

    public Decimal method_36()
    {
        try
        {
            if (this.PopulationData == null)
                return 0M;
            this.decimal_0 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                this.decimal_0 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount /
                                  (gclass39.FortificationLevel * this.PopulationData.SystemBodyData.DominantTerrain.FortificationModifier);
            return this.decimal_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1791 /*0x06FF*/);
            return 0M;
        }
    }

    public Decimal method_37()
    {
        try
        {
            Decimal num = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                num += gclass39.GroundUnitClass.decimal_2 * gclass39.int_2 * (100M / gclass39.Morale);
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1792 /*0x0700*/);
            return 0M;
        }
    }

    public Decimal method_38()
    {
        try
        {
            if (this.FieldPosition == AuroraGroundFormationFieldPosition.Support ||
                this.FieldPosition == AuroraGroundFormationFieldPosition.RearEchelon)
                return 0M;
            Decimal num1 = 0M;
            Decimal num2 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
            {
                num2 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 != GroundUnitBaseType.const_5)
                {
                    Decimal num3 = 1M;
                    if (gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_0)
                        num3 = 0.5M;
                    num1 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount * (gclass39.Morale / 100M) * num3;
                }
            }

            if (num2 == 0M)
                return 0M;
            if (this.FieldPosition == AuroraGroundFormationFieldPosition.FrontlineAttack)
                num1 *= 2M;
            return num1 / num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1793);
            return 0M;
        }
    }

    public int method_39()
    {
        try
        {
            this.decimal_0 = this.method_34();
            if (this.FieldPosition == AuroraGroundFormationFieldPosition.FrontlineDefence ||
                this.FieldPosition == AuroraGroundFormationFieldPosition.FrontlineAttack)
                return (int)Math.Round(this.decimal_0);
            if (this.FieldPosition == AuroraGroundFormationFieldPosition.Support)
                return (int)Math.Round(this.decimal_0 / 4M);
            return this.FieldPosition == AuroraGroundFormationFieldPosition.RearEchelon
                ? (int)Math.Round(this.decimal_0 / 20M)
                : (int)Math.Round(this.decimal_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1794);
            return 0;
        }
    }

    public Decimal method_40(bool bool_7)
    {
        try
        {
            this.decimal_7 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
            {
                if (!gclass39.bool_4 || !bool_7)
                    this.decimal_7 += gclass39.UnitCount * gclass39.GroundUnitClass.decimal_6;
            }

            if (this.decimal_7 == 0M)
                return 0M;
            if (this.gclass55_0 != null)
                this.decimal_7 *= this.gclass55_0.method_3(CommanderBonusType.Production);
            return this.decimal_7;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1795);
            return 0M;
        }
    }

    public Decimal method_41()
    {
        try
        {
            this.decimal_10 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                this.decimal_10 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey);
            if (this.gclass55_0 != null)
                this.decimal_10 *= this.gclass55_0.method_3(CommanderBonusType.Survey);
            return this.decimal_10;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1796);
            return 0M;
        }
    }

    public Decimal method_42()
    {
        try
        {
            this.decimal_11 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                this.decimal_11 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Xenoarchaeology);
            if (this.gclass55_0 != null)
                this.decimal_11 *= this.gclass55_0.method_3(CommanderBonusType.Xenoarchaeology);
            return this.decimal_11;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1797);
            return 0M;
        }
    }

    public Decimal method_43()
    {
        try
        {
            this.decimal_12 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                this.decimal_12 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Decontamination);
            if (this.gclass55_0 != null)
                this.decimal_12 *= this.gclass55_0.method_3(CommanderBonusType.Decontamination);
            return this.decimal_12;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1797);
            return 0M;
        }
    }

    public Decimal method_44()
    {
        try
        {
            this.decimal_1 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.ElementList)
                this.decimal_1 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
            return this.decimal_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1798);
            return 0M;
        }
    }

    public string method_45()
    {
        try
        {
            return $"{this.Abbreviation} {this.Name}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1799);
            return "Error";
        }
    }

    public string method_46()
    {
        try
        {
            if (this.PopulationData != null)
                return this.PopulationData.PopName;
            return this.ShipData != null ? this.ShipData.method_187() : "Unknown";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1800);
            return "Error";
        }
    }

    public void method_47()
    {
        try
        {
            this.string_3 = "";
            if (this.gclass55_0 != null)
                this.string_3 =
                    $"{this.gclass55_0.gclass61_0.RankAbbreviation} {this.gclass55_0.string_0}   {this.gclass55_0.method_29(true)}";
            this.string_4 = "Unknown";
            if (this.PopulationData != null)
                this.string_4 = this.PopulationData.PopName;
            if (this.ShipData == null)
                return;
            this.string_4 = this.ShipData.method_187();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1802);
        }
    }
}