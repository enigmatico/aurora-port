// Decompiled with JetBrains decompiler
// Type: GClass39
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
public class GroundUnitFormationElement
{
    #region CompilerGenerated

    [CompilerGenerated]
    private sealed class Class794
    {
        public GroundUnitFormationData gclass103_0;
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0 && gclass103_1 != this.gclass39_0.Formation;
        }
    }

    [CompilerGenerated]
    private sealed class Class795
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class796
    {
        public GroundUnitFormationData gclass103_0;
        public GroundUnitFormationElement gclass39_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0 && gclass103_1 != this.gclass39_0.Formation;
        }
    }

    [CompilerGenerated]
    private sealed class Class797
    {
        public GroundUnitFormationData gclass103_0;

        internal bool method_0(GroundUnitFormationData gclass103_1)
        {
            return gclass103_1.ParentFormationData == this.gclass103_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class798
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class799
    {
        public int int_0;

        internal bool method_0(GroundUnitFormationElement gclass39_0)
        {
            return this.int_0 >= gclass39_0.long_0 && this.int_0 <= gclass39_0.long_1;
        }
    }

    [CompilerGenerated]
    private sealed class Class800
    {
        public int int_0;

        internal bool method_0(GClass183 gclass183_0)
        {
            return gclass183_0.int_0 == this.int_0;
        }
    }

    #endregion

    public Dictionary<GroundUnitClass101, GClass104> dictionary_0 = new Dictionary<GroundUnitClass101, GClass104>();
    public List<int> list_0 = new List<int>();
    public List<GameRace> DetectingRaceList = new List<GameRace>();
    public GClass0 gclass0_0;
    public GroundUnitClass101 GroundUnitClass;
    public GroundUnitFormationData Formation;
    public GroundUnitFormationTemplateData FormationTemplate;
    public Species RaceData;
    public AuroraTargetSelection TargetSelectionType = AuroraTargetSelection.RandomShip;
    public int ElementID;
    public int UnitCount;
    public int int_2;
    public int int_3;
    public int int_4;
    public int CurrentSupply = 10;
    public int FiringDistribution;
    public Decimal Morale = 100M;
    public Decimal FortificationLevel = 1M;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public long long_0;
    public long long_1;
    public int int_7;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public bool bool_4;
    public bool bool_5;
    public int int_8;

    public double method_0(int int_9)
    {
        try
        {
            if (int_9 == 0)
                return 1.0;
            int_9 -= this.GroundUnitClass.int_7;
            return int_9 <= 0 ? 1.0 : Math.Pow(0.75, int_9);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 322);
            return 0.0;
        }
    }

    public double method_1(
        double double_0,
        double double_1,
        double double_2,
        bool bool_6,
        Decimal decimal_5)
    {
        try
        {
            double num1 = (1.0 - double_0 / this.GroundUnitClass.int_2) * 100.0;
            int num2 = (int)Math.Round(this.GroundUnitClass.int_4 * decimal_5);
            if (double_1 > num2)
                num1 *= num2 / double_1;
            if (num1 < 0.0)
                num1 = 0.0;
            double num3 = num1 * double_2;
            if (num3 <= 0.0)
                return 0.0;
            if (!bool_6)
                return num3;
            if (this.Formation.gclass55_0 != null)
                num3 *= (double)this.Formation.gclass55_0.method_5(CommanderBonusType.GroundCombatOffence);
            return num3 * (double)(this.Morale / 100M);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 323);
            return 0.0;
        }
    }

    public void method_2()
    {
        try
        {
            int num1 = this.UnitCount - this.list_0.Count;
            if (num1 <= 0)
                return;
            if (this.TargetSelectionType != AuroraTargetSelection.RandomShip &&
                this.TargetSelectionType != AuroraTargetSelection.Fastest &&
                this.TargetSelectionType != AuroraTargetSelection.SlowestShip &&
                this.TargetSelectionType != AuroraTargetSelection.LargestShip &&
                this.TargetSelectionType != AuroraTargetSelection.SmallestShip &&
                this.TargetSelectionType != AuroraTargetSelection.HighestToHit)
            {
                if (this.TargetSelectionType != AuroraTargetSelection.Shipyards &&
                    this.TargetSelectionType != AuroraTargetSelection.Population &&
                    this.TargetSelectionType != AuroraTargetSelection.GroundForces)
                    return;
                PopulationData gclass146 = null;
                AuroraContactType auroraContactType_0 = AuroraContactType.Population;
                if (this.TargetSelectionType == AuroraTargetSelection.Population)
                    gclass146 = this.gclass0_0.Contacts.Values
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.System == this.Formation.PopulationData.gclass202_0.ActualSystem &&
                            gclass65_0.DetectRace == this.Formation.RaceData &&
                            gclass65_0.ContactType == AuroraContactType.Population)
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.TargetPopulation.SystemBodyData !=
                            this.Formation.PopulationData.SystemBodyData)
                        .Where<Contact>(gclass65_0 =>
                            this.gclass0_0.GetDistanceBetween(gclass65_0.Xcor, gclass65_0.Ycor,
                                this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88()) <=
                            this.GroundUnitClass.int_1)
                        .OrderByDescending<Contact, Decimal>(gclass65_0 => gclass65_0.ContactStrength)
                        .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation).FirstOrDefault<PopulationData>();
                else if (this.TargetSelectionType == AuroraTargetSelection.Shipyards)
                {
                    auroraContactType_0 = AuroraContactType.Shipyard;
                    gclass146 = this.gclass0_0.Contacts.Values
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.System == this.Formation.PopulationData.gclass202_0.ActualSystem &&
                            gclass65_0.DetectRace == this.Formation.RaceData &&
                            gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                            gclass65_0.ContactType == AuroraContactType.Shipyard)
                        .Where<Contact>(gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile)
                        .Where<Contact>(gclass65_0 =>
                            this.gclass0_0.GetDistanceBetween(gclass65_0.Xcor, gclass65_0.Ycor,
                                this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88()) <=
                            this.GroundUnitClass.int_1)
                        .OrderByDescending<Contact, Decimal>(gclass65_0 => gclass65_0.ContactStrength)
                        .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation).FirstOrDefault<PopulationData>();
                }
                else if (this.TargetSelectionType == AuroraTargetSelection.GroundForces)
                {
                    auroraContactType_0 = AuroraContactType.GroundUnit;
                    gclass146 = this.gclass0_0.Contacts.Values
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.System == this.Formation.PopulationData.gclass202_0.ActualSystem &&
                            gclass65_0.DetectRace == this.Formation.RaceData &&
                            gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                            gclass65_0.ContactType == AuroraContactType.GroundUnit)
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.TargetPopulation.SystemBodyData !=
                            this.Formation.PopulationData.SystemBodyData)
                        .Where<Contact>(gclass65_0 =>
                            this.gclass0_0.GetDistanceBetween(gclass65_0.Xcor, gclass65_0.Ycor,
                                this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88()) <=
                            this.GroundUnitClass.int_1)
                        .OrderByDescending<Contact, Decimal>(gclass65_0 => gclass65_0.ContactStrength)
                        .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation).FirstOrDefault<PopulationData>();
                }
                else if (this.TargetSelectionType == AuroraTargetSelection.STOGroundForces)
                {
                    auroraContactType_0 = AuroraContactType.STOGroundUnit;
                    gclass146 = this.gclass0_0.Contacts.Values
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.System == this.Formation.PopulationData.gclass202_0.ActualSystem &&
                            gclass65_0.DetectRace == this.Formation.RaceData &&
                            gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                            gclass65_0.ContactType == AuroraContactType.STOGroundUnit)
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.method_5() == AuroraContactStatus.Hostile && gclass65_0.TargetPopulation.SystemBodyData !=
                            this.Formation.PopulationData.SystemBodyData)
                        .Where<Contact>(gclass65_0 =>
                            this.gclass0_0.GetDistanceBetween(gclass65_0.Xcor, gclass65_0.Ycor,
                                this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88()) <=
                            this.GroundUnitClass.int_1)
                        .OrderByDescending<Contact, Decimal>(gclass65_0 => gclass65_0.ContactStrength)
                        .Select<Contact, PopulationData>(gclass65_0 => gclass65_0.TargetPopulation).FirstOrDefault<PopulationData>();
                }

                if (gclass146 == null)
                    return;
                this.bool_1 = true;
                double num2 = this.gclass0_0.GetDistanceBetween(gclass146.method_87(), gclass146.method_88(),
                    this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88());
                double double_9 = this.method_1(num2, 0.0, 1.0, true, 1M);
                int decimal_13 = this.GroundUnitClass.gclass230_0.method_5((int)num2);
                int num3 = 0;
                int int_137 = 0;
                for (int index1 = 1; index1 <= num1; ++index1)
                {
                    this.list_0.Add(this.GroundUnitClass.int_5);
                    for (int index2 = 1; index2 <= this.GroundUnitClass.gclass230_0.int_7; ++index2)
                    {
                        if (AuroraUtils.GetRandomInteger(100) <= double_9)
                            ++num3;
                    }

                    int_137 += this.GroundUnitClass.gclass230_0.int_7;
                }

                string string0 = this.Formation.RaceData.dictionary_13[gclass146.PopulationID].string_0;
                this.gclass0_0.method_1(this.Formation.RaceData, null, this.GroundUnitClass.gclass230_0, null, this,
                    auroraContactType_0, gclass146.PopulationID, int_137, num3, 0, 0, 0, decimal_13, 0M, num2, double_9,
                    string0, gclass146.Race, false, false, false, false, false, GEnum62.const_0);
                this.gclass0_0.method_19(AuroraContactType.EWImpact, decimal_13, num3,
                    this.Formation.PopulationData.gclass202_0.ActualSystem, gclass146.method_87(), gclass146.method_88(),
                    false);
            }
            else
            {
                List<ShipData> list1 = this.gclass0_0.FleetDictionary.Values
                    .Where<FleetData>(gclass85_0 => gclass85_0.OrbitingBody != null && gclass85_0.method_35())
                    .SelectMany<FleetData, ShipData>(gclass85_0 => gclass85_0.method_176()).ToList<ShipData>();
                List<ShipData> list2 = this.gclass0_0.Contacts.Values
                    .Where<Contact>(gclass65_0 =>
                        gclass65_0.System == this.Formation.PopulationData.gclass202_0.ActualSystem &&
                        gclass65_0.DetectRace == this.Formation.RaceData &&
                        gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                        gclass65_0.ContactType == AuroraContactType.Ship && gclass65_0.TargetShip != null &&
                        gclass65_0.LastUpdate == this.gclass0_0.GameTime)
                    .Where<Contact>(gclass65_0 =>
                        gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                        gclass65_0.TargetShip.gclass40_0 == null).Where<Contact>(gclass65_0 =>
                        this.gclass0_0.GetDistanceBetween(gclass65_0.Xcor, gclass65_0.Ycor,
                            this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88()) <=
                        this.GroundUnitClass.int_1).Select<Contact, ShipData>(gclass65_0 => gclass65_0.TargetShip)
                    .Except<ShipData>(list1).ToList<ShipData>();
                if (list2.Count == 0)
                    return;
                foreach (ShipData gclass40 in list2)
                    gclass40.method_55(this.Formation.RaceData);
                this.bool_1 = true;
                if (list2.Count > 1)
                {
                    if (!this.Formation.RaceData.NPR)
                    {
                        if (this.TargetSelectionType == AuroraTargetSelection.LargestShip)
                            list2 = list2
                                .OrderByDescending<ShipData, Decimal>(gclass40_0 =>
                                    gclass40_0.gclass22_0.Size).ToList<ShipData>();
                        else if (this.TargetSelectionType == AuroraTargetSelection.SmallestShip)
                            list2 = list2
                                .OrderBy<ShipData, Decimal>(gclass40_0 => gclass40_0.gclass22_0.Size)
                                .ToList<ShipData>();
                        else if (this.TargetSelectionType == AuroraTargetSelection.Fastest)
                            list2 = list2.OrderByDescending<ShipData, int>(gclass40_0 => gclass40_0.int_35)
                                .ToList<ShipData>();
                        else if (this.TargetSelectionType == AuroraTargetSelection.SlowestShip)
                            list2 = list2.OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_35)
                                .ToList<ShipData>();
                        else if (this.TargetSelectionType == AuroraTargetSelection.RandomShip)
                        {
                            foreach (ShipData gclass40 in list2)
                                gclass40.int_36 = AuroraUtils.GetRandomInteger(1000);
                            list2 = list2.OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_36)
                                .ToList<ShipData>();
                        }
                        else if (this.TargetSelectionType == AuroraTargetSelection.HighestToHit)
                        {
                            foreach (ShipData gclass40 in list2)
                            {
                                double double_2 = this.method_0((int)gclass40.method_156(AuroraJammerType.FireControl));
                                double double_0 = this.gclass0_0.GetDistanceBetween(gclass40.gclass85_0.XCoord,
                                    gclass40.gclass85_0.YCoord, this.Formation.PopulationData.method_87(),
                                    this.Formation.PopulationData.method_88());
                                gclass40.double_1 = this.method_1(double_0, gclass40.gclass85_0.Speed, double_2, false,
                                    1M);
                            }

                            list2 = list2.OrderByDescending<ShipData, double>(gclass40_0 => gclass40_0.double_1)
                                .ToList<ShipData>();
                        }
                    }
                    else
                    {
                        foreach (ShipData gclass40 in list2)
                        {
                            gclass40.int_36 = AuroraUtils.GetRandomInteger(1000);
                            double num4 = this.gclass0_0.GetDistanceBetween(gclass40.gclass85_0.XCoord,
                                gclass40.gclass85_0.YCoord, this.Formation.PopulationData.method_87(),
                                this.Formation.PopulationData.method_88()) / 1000.0;
                            if (num4 < 1.0)
                                num4 = 1.0;
                            gclass40.double_3 /= num4;
                        }

                        list2 = list2.OrderByDescending<ShipData, double>(gclass40_0 => gclass40_0.double_3)
                            .ThenBy<ShipData, int>(gclass40_0 => gclass40_0.int_36).ToList<ShipData>();
                    }
                }

                int num5 = this.FiringDistribution;
                if (this.FiringDistribution == 0)
                    num5 = num1;
                if (this.Formation.RaceData.NPR)
                {
                    if (list2[0].gclass22_0.Size < 10M)
                        num5 = 1;
                    else if (list2[0].gclass22_0.Size < 20M)
                        num5 = 2;
                }

                int num6 = 0;
                label_87:
                using (List<ShipData>.Enumerator enumerator = list2.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ShipData current = enumerator.Current;
                        double num7 = this.gclass0_0.GetDistanceBetween(current.gclass85_0.XCoord, current.gclass85_0.YCoord,
                            this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88());
                        if (num7 > this.GroundUnitClass.int_1)
                            return;
                        double double_2 = this.method_0((int)current.method_156(AuroraJammerType.FireControl));
                        double double_9 = this.method_1(num7, current.gclass85_0.Speed, double_2, true, 1M);
                        int decimal_13 = this.GroundUnitClass.gclass230_0.method_5((int)num7);
                        int num8 = 0;
                        int int_137 = 0;
                        for (int index3 = 1; index3 <= num5; ++index3)
                        {
                            this.list_0.Add(this.GroundUnitClass.int_5);
                            for (int index4 = 1; index4 <= this.GroundUnitClass.gclass230_0.int_7; ++index4)
                            {
                                if (AuroraUtils.GetRandomInteger(100) <= double_9)
                                    ++num8;
                            }

                            int_137 += this.GroundUnitClass.gclass230_0.int_7;
                            ++num6;
                            if (num6 >= num1)
                                break;
                        }

                        string string_10 = this.Formation.RaceData.dictionary_12[current.int_8].method_11();
                        this.gclass0_0.method_1(this.Formation.RaceData, null, this.GroundUnitClass.gclass230_0, null,
                            this, AuroraContactType.Ship, current.int_8, int_137, num8, 0, 0, 0, decimal_13, 0M, num7,
                            double_9, string_10, current.gclass21_0, false, false, false, false, false,
                            GEnum62.const_0);
                        this.gclass0_0.method_19(AuroraContactType.EWImpact, decimal_13, num8,
                            this.Formation.PopulationData.gclass202_0.ActualSystem, current.gclass85_0.XCoord,
                            current.gclass85_0.YCoord, false);
                        if (num6 >= num1)
                            return;
                    }

                    goto label_87;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 325);
        }
    }

    public GroundUnitFormationElement(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public GroundUnitFormationElement method_3(GameRace gclass21_0, GroundUnitFormationData gclass103_1, GroundUnitFormationTemplateData gclass102_1)
    {
        try
        {
            GroundUnitFormationElement gclass39_1 = new GroundUnitFormationElement(this.gclass0_0);
            GroundUnitFormationElement gclass39_2 = (GroundUnitFormationElement)this.MemberwiseClone();
            gclass39_2.ElementID = this.gclass0_0.method_26(GEnum0.const_44);
            gclass39_2.Formation = gclass103_1;
            gclass39_2.FormationTemplate = gclass102_1;
            gclass39_2.dictionary_0.Clear();
            gclass39_2.list_0.Clear();
            gclass39_2.DetectingRaceList.Clear();
            return gclass39_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1803);
            return null;
        }
    }

    public Decimal method_4()
    {
        try
        {
            return this.Formation.PopulationData == null
                ? 0M
                : this.GroundUnitClass.decimal_2 * this.UnitCount /
                  (this.FortificationLevel * this.Formation.PopulationData.SystemBodyData.DominantTerrain.FortificationModifier);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1804);
            return 0M;
        }
    }

    public void method_5(
        SystemBodyData gclass1_0,
        ShipData gclass40_0,
        GroundUnitClass101 gclass101_1,
        int int_9,
        int int_10,
        int int_11,
        int int_12)
    {
        try
        {
            if (this.dictionary_0.ContainsKey(gclass101_1))
            {
                this.dictionary_0[gclass101_1].int_0 += int_9;
                this.dictionary_0[gclass101_1].int_1 += int_10;
                this.dictionary_0[gclass101_1].int_2 += int_11;
                this.dictionary_0[gclass101_1].int_3 += int_12;
            }
            else
            {
                GClass104 gclass104 = new GClass104()
                {
                    gclass1_0 = gclass1_0,
                    gclass40_0 = gclass40_0,
                    gclass101_0 = gclass101_1
                };
                gclass104.string_0 = this.Formation.RaceData.method_323(gclass104.gclass101_0);
                gclass104.int_0 = int_9;
                gclass104.int_1 = int_10;
                gclass104.int_2 = int_11;
                gclass104.int_3 = int_12;
                this.dictionary_0.Add(gclass101_1, gclass104);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1805);
        }
    }

    public Decimal method_6(
        GroundUnitFormationElement gclass39_0_1,
        ShipData gclass40_0,
        SystemBodyData gclass1_0,
        ShipData gclass40_1,
        Decimal decimal_5,
        Decimal decimal_6,
        bool bool_6)
    {
        try
        {
            ++this.int_3;
            gclass39_0_1?.method_5(gclass1_0, gclass40_1, this.GroundUnitClass, 0, 1, 0, 0);
            gclass40_0?.method_58(this.GroundUnitClass, 0, 1, 0, 0);
            Decimal num1 = this.GroundUnitClass.method_7();
            Decimal num2 = this.UnitCount * this.GroundUnitClass.decimal_2;
            if (num1 > decimal_5)
            {
                Decimal num3 = AuroraUtils.smethod_64(decimal_5 / num1, 2);
                if (AuroraUtils.GetRandomInteger(100) > num3 * 100M)
                    return 0M;
            }

            ++this.int_4;
            gclass39_0_1?.method_5(gclass1_0, gclass40_1, this.GroundUnitClass, 0, 0, 1, 0);
            gclass40_0?.method_58(this.GroundUnitClass, 0, 0, 1, 0);
            Decimal num4 = this.GroundUnitClass.method_8();
            if (num4 > decimal_6)
            {
                Decimal num5 = AuroraUtils.smethod_64(decimal_6 / num4, 2);
                if (AuroraUtils.GetRandomInteger(100) > num5 * 100M)
                    return 0M;
            }

            ++this.int_2;
            gclass39_0_1?.method_5(gclass1_0, gclass40_1, this.GroundUnitClass, 0, 0, 0, 1);
            gclass40_0?.method_58(this.GroundUnitClass, 0, 0, 0, 1);
            if (this.Formation.FieldPosition ==
                AuroraGroundFormationFieldPosition.FrontlineAttack && bool_6)
            {
                if (this.Formation.RaceData.SpecialNPRID != SpecialNPRIDs.Precursor)
                    this.decimal_3 -= this.Morale / this.UnitCount / 2M;
                if (gclass39_0_1 != null)
                    gclass39_0_1.decimal_3 += this.GroundUnitClass.decimal_2 / num2 / 5M;
            }
            else
            {
                if (this.Formation.RaceData.SpecialNPRID != SpecialNPRIDs.Precursor)
                    this.decimal_3 -= this.Morale / this.UnitCount / 4M;
                if (gclass39_0_1 != null)
                    gclass39_0_1.decimal_3 += this.GroundUnitClass.decimal_2 / num2 / 10M;
            }

            int num6 = this.GroundUnitClass.method_6();
            if (num6 > 0)
            {
                GClass55 gclass550 = this.Formation.gclass55_0;
                if (gclass550 != null)
                {
                    double num7 = this.Formation.ElementList.Sum<GroundUnitFormationElement>(gclass39_0_2 =>
                        gclass39_0_2.UnitCount * gclass39_0_2.GroundUnitClass.method_6());
                    double num8 = num6 / num7 * 0.25;
                    if (AuroraUtils.GetRandomInteger(1000) < num8 * 1000.0)
                    {
                        if (this.Formation.PopulationData != null)
                        {
                            this.gclass0_0.gclass92_0.method_2(EventType.const_63,
                                $"{gclass550.method_17(false)} has been killed due to the destruction of {this.GroundUnitClass.ClassName} on {this.Formation.PopulationData.PopName}",
                                this.Formation.RaceData, this.Formation.PopulationData.gclass202_0.ActualSystem,
                                this.Formation.PopulationData.method_87(), this.Formation.PopulationData.method_88(),
                                AuroraEventCategory.Combat);
                            gclass550.method_46(
                                $"Killed due to the destruction of {this.GroundUnitClass.ClassName} on {this.Formation.PopulationData.PopName}",
                                GEnum28.const_0);
                        }
                        else if (this.Formation.ShipData != null)
                        {
                            this.gclass0_0.gclass92_0.method_2(EventType.const_63,
                                $"{gclass550.method_17(false)} has been killed due to the destruction of {this.GroundUnitClass.ClassName} on {gclass550.gclass21_0.method_267(this.Formation.ShipData).string_0}",
                                this.Formation.RaceData,
                                this.Formation.ShipData.gclass85_0.System.ActualSystem,
                                this.Formation.ShipData.gclass85_0.XCoord,
                                this.Formation.ShipData.gclass85_0.YCoord, AuroraEventCategory.Combat);
                            gclass550.method_46(
                                $"Killed due to the destruction of {this.GroundUnitClass.ClassName} on {gclass550.gclass21_0.method_267(this.Formation.ShipData).string_0}",
                                GEnum28.const_0);
                        }

                        gclass550.method_42(AuroraRetirementStatus.KilledGround);
                    }
                }
            }

            return this.GroundUnitClass.decimal_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1806);
            return 0M;
        }
    }

    public bool method_7()
    {
        try
        {
            if (this.GroundUnitClass.decimal_4 == 0M)
                return true;
            if (this.Formation.decimal_20 > 1M)
            {
                int num = (int)((this.Formation.decimal_20 - 1M) * 100M);
                if (AuroraUtils.GetRandomInteger(100) <= num)
                    return true;
            }

            bool flag = false;
            Decimal decimal_26_1 = this.GroundUnitClass.decimal_4 * this.UnitCount * 0.1M;
            List<GroundUnitFormationData> list = this.method_9().OrderByDescending<GroundUnitFormationData, int>(gclass103_0 => gclass103_0.int_10)
                .ToList<GroundUnitFormationData>();
            foreach (GroundUnitFormationData gclass103_2 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GroundUnitFormationElement.Class794 class794 = new GroundUnitFormationElement.Class794();
                // ISSUE: reference to a compiler-generated field
                class794.gclass39_0 = this;
                // ISSUE: reference to a compiler-generated field
                class794.gclass103_0 = gclass103_2;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                foreach (GroundUnitFormationData gclass103_3 in this.gclass0_0.FormationDictionary.Values
                             .Where<GroundUnitFormationData>(class794.method_0)
                             .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_14() == GEnum55.const_9)
                             .Where<GroundUnitFormationData>(gclass103_1 => this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(
                                 new GroundUnitFormationElement.Class795()
                                 {
                                     gclass103_0 = gclass103_1
                                 }.method_0).Count<GroundUnitFormationData>() == 0).ToList<GroundUnitFormationData>())
                {
                    if (flag = gclass103_3.method_20(decimal_26_1, this.Formation))
                        break;
                }

                // ISSUE: reference to a compiler-generated field
                if (flag = class794.gclass103_0.method_20(decimal_26_1, this.Formation))
                    break;
            }

            if (!flag && this.CurrentSupply > 0)
            {
                flag = true;
                --this.CurrentSupply;
            }

            if (flag && this.CurrentSupply < 10)
            {
                Decimal decimal_26_2 = this.GroundUnitClass.decimal_4 * this.UnitCount * ((10 - this.CurrentSupply) * 0.1M);
                foreach (GroundUnitFormationData gclass103 in list)
                {
                    if (gclass103.method_20(decimal_26_2, this.Formation))
                    {
                        this.CurrentSupply = 10;
                        break;
                    }
                }
            }

            return flag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1807);
            return false;
        }
    }

    public bool method_8()
    {
        try
        {
            if (this.GroundUnitClass.decimal_4 == 0M)
                return true;
            bool flag = false;
            Decimal decimal_26 = this.GroundUnitClass.decimal_4 * this.UnitCount * ((10 - this.CurrentSupply) * 0.1M);
            if (this.Formation.gclass55_0 != null)
            {
                Decimal num = this.Formation.gclass55_0.method_5(CommanderBonusType.Logistics) - 2M;
                decimal_26 = Math.Round(decimal_26 * num, 1);
            }

            foreach (GroundUnitFormationData gclass103_2 in this.method_9()
                         .OrderByDescending<GroundUnitFormationData, int>(gclass103_0 => gclass103_0.int_10).ToList<GroundUnitFormationData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GroundUnitFormationElement.Class796 class796 = new GroundUnitFormationElement.Class796();
                // ISSUE: reference to a compiler-generated field
                class796.gclass39_0 = this;
                // ISSUE: reference to a compiler-generated field
                class796.gclass103_0 = gclass103_2;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                foreach (GroundUnitFormationData gclass103_3 in this.gclass0_0.FormationDictionary.Values
                             .Where<GroundUnitFormationData>(class796.method_0)
                             .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.method_14() == GEnum55.const_9)
                             .Where<GroundUnitFormationData>(gclass103_1 => this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(
                                 new GroundUnitFormationElement.Class797()
                                 {
                                     gclass103_0 = gclass103_1
                                 }.method_0).Count<GroundUnitFormationData>() == 0).ToList<GroundUnitFormationData>())
                {
                    if (flag = gclass103_3.method_20(decimal_26, this.Formation))
                    {
                        this.CurrentSupply = 10;
                        break;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                if (flag = class796.gclass103_0.method_20(decimal_26, this.Formation))
                {
                    this.CurrentSupply = 10;
                    break;
                }
            }

            return flag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3543);
            return false;
        }
    }

    public List<GroundUnitFormationData> method_9()
    {
        try
        {
            List<GroundUnitFormationData> list_3 = new List<GroundUnitFormationData>();
            this.Formation.int_10 = 1;
            list_3.Add(this.Formation);
            this.Formation.method_21(list_3, 2);
            return list_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1808);
            return null;
        }
    }

    public double method_10(ShipData gclass40_0, List<GroundUnitFormationElement> list_2, int int_9, int int_10)
    {
        try
        {
            Decimal num1 = this.UnitCount * this.GroundUnitClass.decimal_2;
            double num2 = 0.0;
            Decimal decimal_26 = 0M;
            for (int index1 = 1; index1 <= this.UnitCount; ++index1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                GroundUnitFormationElement gclass39 = list_2.FirstOrDefault<GroundUnitFormationElement>(new GroundUnitFormationElement.Class798()
                {
                    int_0 = AuroraUtils.GetRandomInteger(int_9)
                }.method_0);
                Decimal num3 = AuroraUtils.int_41 * (this.Morale / 100M) * this.Formation.decimal_19;
                if (this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_1))
                    num3 *= 2M;
                if (this.GroundUnitClass.bool_0)
                    num3 /= 5M;
                Decimal num4 = int_10 * gclass39.Formation.decimal_18;
                Decimal num5 = num3 / num4;
                foreach (GroundComponentTypeDefinition gclass100 in this.GroundUnitClass.GroundUnitComponentList)
                {
                    if (gclass100.method_1(this.GroundUnitClass.decimal_1) > 0M)
                    {
                        Decimal decimal_6 = gclass100.method_2(this.GroundUnitClass.decimal_1);
                        this.method_5(null, gclass40_0, gclass39.GroundUnitClass, gclass100.Shots, 0, 0, 0);
                        for (int index2 = 1; index2 <= gclass100.Shots; ++index2)
                        {
                            num2 += Math.Pow((double)gclass100.Damage, 3.0);
                            if (!(AuroraUtils.GetRandomInteger(10000) > num5))
                                decimal_26 += gclass39.method_6(this, null, null, gclass40_0,
                                    gclass100.method_1(this.GroundUnitClass.decimal_1), decimal_6, true);
                        }
                    }
                }
            }

            if (decimal_26 > 0M)
                this.Formation.method_9(AuroraMeasurementType.GroundForcesDestroyed, decimal_26, true);
            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1809);
            return 0.0;
        }
    }

    public void method_11(
        GroundUnitFormationData gclass103_1,
        GroundUnitFormationElement gclass39_0,
        SystemBodyData gclass1_0,
        bool bool_6)
    {
        try
        {
            Decimal num1 = this.UnitCount * this.GroundUnitClass.decimal_2;
            Decimal decimal_26 = 0M;
            Decimal num2 = 1M;
            if (gclass1_0.Gravity < this.RaceData.double_7 &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_3))
                num2 *= 2M;
            if (gclass1_0.Gravity > this.RaceData.double_8 &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_2))
                num2 *= 2M;
            if (gclass1_0.AtmospherePressure > this.RaceData.double_2 &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_8))
                num2 *= 2M;
            if ((gclass1_0.SurfaceTemp > this.RaceData.double_11 ||
                 gclass1_0.SurfaceTemp < this.RaceData.double_12) &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_4))
                num2 *= 2M;
            if (gclass1_0.DominantTerrain.IsDesertTerrain && this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_7))
                num2 /= 2M;
            if (gclass1_0.DominantTerrain.IsJungleTerrain && this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_6))
                num2 /= 2M;
            if (gclass1_0.DominantTerrain.BaseTerrainType != PlanetDominantTerrain.const_0 &&
                this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_5))
                num2 /= 2M;
            int num3 = this.method_7() ? 1 : 0;
            int num4 = this.UnitCount;
            if (num3 == 0)
                num4 = (int)Math.Floor(this.UnitCount / 4.0);
            for (int index1 = 1; index1 <= num4; ++index1)
            {
                GroundUnitFormationElement gclass39 = gclass39_0;
                if (gclass39 == null)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    gclass39 = gclass103_1.ElementList.FirstOrDefault<GroundUnitFormationElement>(new GroundUnitFormationElement.Class799()
                    {
                        int_0 = AuroraUtils.GetRandomInteger(gclass103_1.int_9)
                    }.method_0);
                }

                Decimal num5;
                Decimal num6;
                if (gclass39.FortificationLevel == 1M)
                {
                    num5 = AuroraUtils.int_41 * gclass1_0.DominantTerrain.ToHitModifier *
                           gclass39.GroundUnitClass.GroundUnitBaseTypeData.decimal_3 * (this.Morale / 100M);
                    num6 = 1M;
                }
                else
                {
                    num5 = AuroraUtils.int_41 * gclass1_0.DominantTerrain.ToHitModifier * (this.Morale / 100M);
                    num6 = gclass1_0.DominantTerrain.FortificationModifier * gclass39.FortificationLevel * gclass39.Formation.decimal_18;
                }

                if (this.GroundUnitClass.bool_0)
                    num5 /= 5M;
                Decimal num7 = num6 * num2;
                Decimal num8 = num5 / num7;
                foreach (GroundComponentTypeDefinition gclass100 in this.GroundUnitClass.GroundUnitComponentList)
                {
                    if (gclass100.method_1(this.GroundUnitClass.decimal_1) > 0M &&
                        (!bool_6 || gclass100.BombardmentWeaponClass != BombardmentWeaponClass.const_0))
                    {
                        Decimal decimal_6 = gclass100.method_2(this.GroundUnitClass.decimal_1);
                        this.method_5(gclass1_0, null, gclass39.GroundUnitClass, gclass100.Shots, 0, 0, 0);
                        for (int index2 = 1; index2 <= gclass100.Shots; ++index2)
                        {
                            gclass39.Formation.PopulationData.method_38(this.Formation.RaceData,
                                Math.Pow((double)gclass100.Damage, 3.0));
                            if (gclass100.BombardmentWeaponClass == BombardmentWeaponClass.const_0)
                                num8 *= this.Formation.decimal_19;
                            else
                                num8 *= this.Formation.decimal_22;
                            if (!(AuroraUtils.GetRandomInteger(10000) > num8))
                            {
                                decimal_26 += gclass39.method_6(this, null, gclass1_0, null,
                                    gclass100.method_1(this.GroundUnitClass.decimal_1), decimal_6, true);
                                gclass39.Formation.RaceData.method_22(this.Formation.RaceData,
                                    -(decimal_26 / 100M), true);
                            }
                        }
                    }
                }
            }

            if (!(decimal_26 > 0M))
                return;
            this.Formation.method_9(AuroraMeasurementType.GroundForcesDestroyed, decimal_26, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1810);
        }
    }

    public void method_12(List<ShipData> list_2, SystemBodyData gclass1_0, AntiAirWeaponClass genum54_0)
    {
        try
        {
            int num1 = this.method_7() ? 1 : 0;
            Decimal num2 = 1M;
            if (gclass1_0.Gravity < this.RaceData.double_7 &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_3))
                num2 *= 2M;
            if (gclass1_0.Gravity > this.RaceData.double_8 &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_2))
                num2 *= 2M;
            if (gclass1_0.AtmospherePressure > this.RaceData.double_2 &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_8))
                num2 *= 2M;
            if ((gclass1_0.SurfaceTemp > this.RaceData.double_11 ||
                 gclass1_0.SurfaceTemp < this.RaceData.double_12) &&
                !this.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_4))
                num2 *= 2M;
            if (num1 == 0)
                Math.Floor(this.UnitCount / 4.0);
            for (int index = 1; index <= this.UnitCount; ++index)
            {
                ShipData gclass40 =
                    list_2.ElementAt<ShipData>(AuroraUtils.GetRandomInteger(list_2.Count) - 1);
                Decimal num3 = this.GroundUnitClass.int_4 / gclass40.method_171(true);
                if (num3 > 1M)
                    num3 = 1M;
                Decimal num4 = AuroraUtils.int_42 * num3 * (this.Morale / 100M) * this.Formation.decimal_23 / num2;
                foreach (GroundComponentTypeDefinition gclass100 in this.GroundUnitClass.GroundUnitComponentList)
                {
                    if (gclass100.AAWeaponClass >= genum54_0)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GroundUnitFormationElement.Class800 class800 = new GroundUnitFormationElement.Class800();
                        if (!(AuroraUtils.GetRandomInteger(10000) > num4))
                        {
                            // ISSUE: reference to a compiler-generated field
                            class800.int_0 = gclass100.method_0(this.GroundUnitClass.decimal_1);
                            // ISSUE: reference to a compiler-generated field
                            if (class800.int_0 != 0)
                            {
                                // ISSUE: reference to a compiler-generated method
                                GClass183 gclass183_1 = gclass40.list_19.FirstOrDefault<GClass183>(class800.method_0);
                                if (gclass183_1 == null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    GClass183 gclass183_2 = new GClass183(class800.int_0, 1);
                                    gclass40.list_19.Add(gclass183_2);
                                }
                                else
                                    ++gclass183_1.int_1;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1811);
        }
    }

    public Decimal method_13()
    {
        try
        {
            this.decimal_2 = this.UnitCount * this.GroundUnitClass.decimal_6;
            if (this.Formation.gclass55_0 != null)
                this.decimal_2 *= this.Formation.gclass55_0.method_5(CommanderBonusType.Production);
            return this.decimal_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1812);
            return 0M;
        }
    }

    public GroundUnitFormationElement method_14()
    {
        GroundUnitFormationElement gclass39 = new GroundUnitFormationElement(this.gclass0_0);
        return (GroundUnitFormationElement)this.MemberwiseClone();
    }

    public void method_15(ListView listView_0)
    {
        try
        {
            string string_13 = "-";
            string str = AuroraUtils.smethod_10(this.GroundUnitClass.int_6);
            int num1 = this.UnitCount * this.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.FireDirection);
            Decimal num2 = this.UnitCount * this.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Construction);
            Decimal num3 = this.UnitCount * this.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey);
            Decimal num4 = this.UnitCount * this.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.LogisticsPoint);
            string string_20 = "";
            if (str != "-")
                string_20 = $"{string_20}HQ{str}  ";
            if (this.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.STO) > 0)
                string_20 += "ST  ";
            if (this.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.int_1) > 0)
                string_20 += "CW  ";
            if (num1 > 0)
                string_20 = $"{string_20}FD{num1.ToString()}  ";
            if (num2 > 0M)
            {
                Decimal d = num2 * this.Formation.RaceData.ConstructionProduction * 100M;
                if (this.Formation.gclass55_0 != null)
                    d *= this.Formation.gclass55_0.method_5(CommanderBonusType.Production);
                string_20 = $"{string_20}CN{num2.ToString()}  FC{Math.Round(d).ToString()}";
            }

            if (num3 > 0M)
                string_20 = $"{string_20}GE{num3.ToString()}  ";
            if (num4 > 0M)
                string_20 = $"{string_20}LG{Math.Round(num4 / 1000M).ToString()}  ";
            if (this.GroundUnitClass.decimal_4 > 0M)
                string_13 = AuroraUtils.smethod_37(this.CurrentSupply * 10) + "%";
            this.gclass0_0.method_620(listView_0, this.GroundUnitClass.GroundUnitBaseTypeData.string_0, this.GroundUnitClass.ClassName,
                AuroraUtils.smethod_37(this.UnitCount), string_13, AuroraUtils.smethod_38(this.Morale),
                AuroraUtils.FormatNumberToDigits(this.FortificationLevel, 2),
                AuroraUtils.smethod_38(this.GroundUnitClass.decimal_2 * this.UnitCount),
                AuroraUtils.smethod_38(this.GroundUnitClass.decimal_3 * this.UnitCount),
                AuroraUtils.smethod_38(this.GroundUnitClass.method_8() * this.UnitCount),
                AuroraUtils.smethod_38(this.GroundUnitClass.decimal_4 * this.UnitCount), string_20, this);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1813);
        }
    }
}