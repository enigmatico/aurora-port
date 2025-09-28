using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aurora;

#nullable disable
public partial class GClass0
{
        public void method_1(
        GameRace gclass21_2,
        ShipData gclass40_0,
        ShipComponent gclass230_2,
        RaceMissile gclass129_1,
        GroundUnitFormationElement gclass39_0,
        AuroraContactType auroraContactType_0,
        int int_136,
        int int_137,
        int int_138,
        int int_139,
        int int_140,
        int int_141,
        Decimal decimal_13,
        Decimal decimal_14,
        double double_8,
        double double_9,
        string string_10,
        GameRace gclass21_3,
        bool bool_25,
        bool bool_26,
        bool bool_27,
        bool bool_28,
        bool bool_29,
        GEnum62 genum62_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class71 class71 = new GClass0.Class71();
        // ISSUE: reference to a compiler-generated field
        class71.gclass40_0 = gclass40_0;
        // ISSUE: reference to a compiler-generated field
        class71.gclass230_0 = gclass230_2;
        // ISSUE: reference to a compiler-generated field
        class71.gclass39_0 = gclass39_0;
        // ISSUE: reference to a compiler-generated field
        class71.string_0 = string_10;
        // ISSUE: reference to a compiler-generated field
        class71.decimal_0 = decimal_13;
        // ISSUE: reference to a compiler-generated field
        class71.decimal_1 = decimal_14;
        // ISSUE: reference to a compiler-generated field
        class71.gclass129_0 = gclass129_1;
        // ISSUE: reference to a compiler-generated field
        class71.double_0 = double_9;
        // ISSUE: reference to a compiler-generated field
        class71.double_1 = double_8;
        // ISSUE: reference to a compiler-generated field
        class71.bool_0 = bool_25;
        // ISSUE: reference to a compiler-generated field
        class71.bool_1 = bool_28;
        // ISSUE: reference to a compiler-generated field
        class71.bool_2 = bool_29;
        // ISSUE: reference to a compiler-generated field
        class71.genum62_0 = genum62_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            GClass37 gclass37_1 = this.list_22.FirstOrDefault<GClass37>(class71.method_0);
            if (gclass37_1 != null)
            {
                gclass37_1.int_1 += int_137;
                gclass37_1.int_2 += int_138;
                gclass37_1.int_6 += int_139;
                gclass37_1.int_7 += int_140;
                gclass37_1.int_8 += int_141;
            }
            else
            {
                GClass37 gclass37_2 = new GClass37();
                gclass37_2.gclass21_1 = gclass21_2;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.gclass40_0 = class71.gclass40_0;
                gclass37_2.gclass21_0 = gclass21_3;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.gclass230_0 = class71.gclass230_0;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.gclass129_0 = class71.gclass129_0;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.gclass39_0 = class71.gclass39_0;
                gclass37_2.int_1 = int_137;
                gclass37_2.int_2 = int_138;
                gclass37_2.int_6 = int_139;
                gclass37_2.int_7 = int_140;
                gclass37_2.int_8 += int_141;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.decimal_0 = class71.decimal_0;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.decimal_1 = class71.decimal_1;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.string_0 = class71.string_0;
                gclass37_2.int_0 = int_136;
                gclass37_2.auroraContactType_0 = auroraContactType_0;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.double_0 = class71.double_0;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.double_1 = class71.double_1;
                gclass37_2.bool_3 = bool_27;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.bool_2 = class71.bool_0;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.bool_4 = class71.bool_1;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.bool_5 = class71.bool_2;
                gclass37_2.bool_0 = bool_26;
                // ISSUE: reference to a compiler-generated field
                gclass37_2.genum62_0 = class71.genum62_0;
                this.list_22.Add(gclass37_2);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 301);
        }
    }

    public void method_2(int int_136)
    {
        try
        {
            foreach (ShipData gclass40 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             (gclass40_0.int_13 > 0 || gclass40_0.int_15 > 0) && !gclass40_0.bool_17)
                         .ToList<ShipData>())
            {
                gclass40.int_13 -= int_136;
                gclass40.int_15 -= int_136;
                if (gclass40.int_13 < 0)
                    gclass40.int_13 = 0;
                if (gclass40.int_15 < 0)
                    gclass40.int_15 = 0;
            }

            foreach (ShipData gclass40 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.bool_17).ToList<ShipData>())
                gclass40.bool_17 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 302);
        }
    }

    public void method_3()
    {
        try
        {
            List<Contact> list = this.Contacts.Values.Where<Contact>(gclass65_0 =>
                gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                gclass65_0.ContactType == AuroraContactType.GroundUnit &&
                gclass65_0.LastUpdate == this.GameTime).ToList<Contact>();
            foreach (GroundUnitFormationElement gclass39 in this.FormationDictionary.Values
                         .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData != null)
                         .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                         .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.bool_1).ToList<GroundUnitFormationElement>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class86 class86 = new GClass0.Class86()
                {
                    gclass39_0 = gclass39
                };
                // ISSUE: reference to a compiler-generated field
                class86.gclass39_0.bool_1 = false;
                // ISSUE: reference to a compiler-generated field
                if (class86.gclass39_0.Formation.PopulationData != null)
                {
                    // ISSUE: reference to a compiler-generated method
                    list.Where<Contact>(class86.method_0).ToList<Contact>();
                    foreach (Contact gclass65 in list)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (!class86.gclass39_0.DetectingRaceList.Contains(gclass65.DetectRace))
                        {
                            // ISSUE: reference to a compiler-generated field
                            class86.gclass39_0.DetectingRaceList.Add(gclass65.DetectRace);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 303);
        }
    }

    public void method_4()
    {
        try
        {
            foreach (FireControlAssignment gclass36 in this.Ships.Values
                         .SelectMany<ShipData, FireControlAssignment>(gclass40_0 => gclass40_0.list_4)
                         .Where<FireControlAssignment>(gclass36_0 => gclass36_0.HasFiredThisPhase).ToList<FireControlAssignment>())
                gclass36.HasFiredThisPhase = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 303);
        }
    }

    public void method_5(int int_136)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass0.Class207 class207 = new GClass0.Class207();
            this.list_22.Clear();
            this.list_5.Clear();
            if (this.bool_24)
            {
                foreach (FireControlAssignment gclass36 in this.Ships.Values
                             .Where<ShipData>(gclass40_0 => gclass40_0.gclass21_0.NPR)
                             .SelectMany<ShipData, FireControlAssignment>(gclass40_0 => gclass40_0.list_4)
                             .Where<FireControlAssignment>(gclass36_0 => gclass36_0.IsOpeningFire).ToList<FireControlAssignment>())
                    gclass36.IsOpeningFire = false;
                foreach (GameRace gclass21 in this.GameRaces.Values)
                {
                    if (gclass21.NPR)
                        gclass21.UnknownNprClass.method_14();
                }
            }

            List<GroundUnitFormationElement> source = new List<GroundUnitFormationElement>();
            foreach (GameRace gclass21 in this.GameRaces.Values)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class208 class208 = new GClass0.Class208();
                // ISSUE: reference to a compiler-generated field
                class208.gclass21_0 = gclass21;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class209 class209 = new GClass0.Class209();
                List<GroundUnitFormationElement> list1 = this.FormationDictionary.Values
                    .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData != null)
                    .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).Where<GroundUnitFormationElement>(gclass39_0 =>
                        gclass39_0.GroundUnitClass.gclass230_0 != null &&
                        gclass39_0.TargetSelectionType != AuroraTargetSelection.DoNotFire &&
                        gclass39_0.UnitCount > gclass39_0.list_0.Count).ToList<GroundUnitFormationElement>();
                if (list1.Count != 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class209.list_0 = this.Contacts.Values.Where<Contact>(class208.method_0)
                        .Where<Contact>(gclass65_0 =>
                            gclass65_0.method_5() == AuroraContactStatus.Hostile &&
                            this.GameTime - gclass65_0.LastUpdate == 0M)
                        .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct<StarSystem>()
                        .ToList<StarSystem>();
                    // ISSUE: reference to a compiler-generated method
                    List<GroundUnitFormationElement> list2 = list1.Where<GroundUnitFormationElement>(class209.method_0).ToList<GroundUnitFormationElement>();
                    if (list2.Count != 0)
                        source.AddRange(list2);
                }
            }

            foreach (ShipData gclass40 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_0 == null && gclass40_0.int_13 > 0)
                         .Where<ShipData>(gclass40_0 => gclass40_0.method_18(false)).ToList<ShipData>())
                this.gclass92_0.method_2(EventType.const_72,
                    gclass40.ShipName + " is preparing for offensive fire but her weapons are not yet ready.",
                    gclass40.gclass21_0, gclass40.gclass85_0.System.ActualSystem, gclass40.gclass85_0.XCoord,
                    gclass40.gclass85_0.YCoord, AuroraEventCategory.Ship);
            List<ShipData> list3 = this.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_0 == null && gclass40_0.int_13 == 0)
                .Where<ShipData>(gclass40_0 => gclass40_0.method_18(true)).ToList<ShipData>();
            List<ShipData> list4 = this.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass40_0 == null && gclass40_0.int_15 == 0)
                .Where<ShipData>(gclass40_0 => gclass40_0.method_18(true)).ToList<ShipData>();
            if (list3.Count == 0 && list4.Count == 0 && source.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class207.list_0 = list3
                .Select<ShipData, StarSystem>(gclass40_0 => gclass40_0.gclass85_0.System.ActualSystem)
                .Distinct<StarSystem>().ToList<StarSystem>();
            // ISSUE: reference to a compiler-generated field
            class207.list_0.AddRange(list4
                .Select<ShipData, StarSystem>(gclass40_0 => gclass40_0.gclass85_0.System.ActualSystem)
                .Distinct<StarSystem>().ToList<StarSystem>());
            // ISSUE: reference to a compiler-generated field
            class207.list_0.AddRange(source
                .Select<GroundUnitFormationElement, StarSystem>(gclass39_0 =>
                    gclass39_0.Formation.PopulationData.gclass202_0.ActualSystem).Distinct<StarSystem>()
                .ToList<StarSystem>());
            // ISSUE: reference to a compiler-generated method
            foreach (ShipData gclass40 in this.Ships.Values.Where<ShipData>(class207.method_0)
                         .ToList<ShipData>())
            {
                gclass40.method_104();
                gclass40.method_105();
            }

            List<Contact> list5 = this.Contacts.Values.Where<Contact>(gclass65_0 =>
                gclass65_0.ContactMethod == ContactDetectMethod.const_0 && gclass65_0.ContactType == AuroraContactType.Salvo &&
                gclass65_0.LastUpdate == this.GameTime).ToList<Contact>();
            List<StarSystem> list6 = list5
                .Where<Contact>(gclass65_0 => gclass65_0.method_5() < AuroraContactStatus.Neutral)
                .Select<Contact, StarSystem>(gclass65_0 => gclass65_0.System).Distinct<StarSystem>()
                .ToList<StarSystem>();
            if (list6.Count > 0)
            {
                this.method_18(list6, list4);
                this.method_17(list6, list5, list4);
            }

            this.method_16(list3);
            this.method_15(list3);
            foreach (ShipData gclass40 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.bool_6).ToList<ShipData>())
            {
                this.gclass92_0.method_2(EventType.const_181,
                    gclass40.ShipName +
                    " has an active target that cannot be attacked. It may be an invalid target or out of range of the assigned fire control or weapons",
                    gclass40.gclass21_0, gclass40.gclass85_0.System.ActualSystem, gclass40.gclass85_0.XCoord,
                    gclass40.gclass85_0.YCoord, AuroraEventCategory.Ship);
                gclass40.bool_6 = false;
            }

            foreach (GroundUnitFormationElement gclass39 in source)
                gclass39.method_2();
            this.method_6();
            if (this.list_22.Count > 0)
            {
                this.method_8(0);
                if (this.list_22.Count<GClass37>(gclass37_0 =>
                        gclass37_0.auroraContactType_0 == AuroraContactType.GroundUnit) > 0)
                {
                    foreach (GroundUnitFormationElement gclass39 in this.FormationDictionary.Values
                                 .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).ToList<GroundUnitFormationElement>())
                    {
                        gclass39.int_2 = 0;
                        gclass39.decimal_3 = 0M;
                    }
                }

                this.method_14(false);
                this.method_504();
            }

            this.method_168();
            this.method_7();
            this.method_166();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 304);
        }
    }

    public void method_6()
    {
        try
        {
            foreach (ShipData gclass40 in this.AcidAttackList
                         .Select<AcidAttack, ShipData>(gclass25_0 => gclass25_0.TargetShip).Distinct<ShipData>()
                         .ToList<ShipData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class210 class210 = new GClass0.Class210();
                // ISSUE: reference to a compiler-generated field
                class210.gclass40_0 = gclass40;
                // ISSUE: reference to a compiler-generated method
                List<AcidAttack> list = this.AcidAttackList.Where<AcidAttack>(class210.method_0).ToList<AcidAttack>();
                int decimal_13 = 0;
                int num = 0;
                foreach (AcidAttack gclass25 in list)
                {
                    if (!(this.GameTime - gclass25.LastDamageTime < gclass25.PointOfDamageTime))
                    {
                        gclass25.LastDamageTime = this.GameTime;
                        if (gclass25.ArmourColumn == 0)
                        {
                            ++decimal_13;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class210.gclass40_0.dictionary_5.ContainsKey(gclass25.ArmourColumn))
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class210.gclass40_0.dictionary_5[gclass25.ArmourColumn] >=
                                    class210.gclass40_0.gclass22_0.ArmourThickness)
                                {
                                    gclass25.ArmourColumn = 0;
                                    ++decimal_13;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class210.gclass40_0.dictionary_5[gclass25.ArmourColumn]++;
                                    ++num;
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                class210.gclass40_0.dictionary_5.Add(gclass25.ArmourColumn, 1);
                            }
                        }

                        if (gclass25.RemainingDamage == 1)
                            this.AcidAttackList.Remove(gclass25);
                        else
                            --gclass25.RemainingDamage;
                    }
                }

                if (num > 0 || decimal_13 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(null, null, null, null, null, AuroraContactType.Ship, class210.gclass40_0.int_8, 1, 1,
                        0, 0, 0, decimal_13, 0M, 0.0, 100.0, class210.gclass40_0.ShipName,
                        class210.gclass40_0.gclass21_0, false, false, false, false, true, GEnum62.const_0);
                }

                if (num > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass92_0.method_2(EventType.const_162,
                        $"{class210.gclass40_0.method_187()} has suffered {num.ToString()} armour damage as a result of previous attacks from acid-based weapons.",
                        class210.gclass40_0.gclass21_0, class210.gclass40_0.gclass85_0.System.ActualSystem,
                        class210.gclass40_0.gclass85_0.XCoord, class210.gclass40_0.gclass85_0.YCoord,
                        AuroraEventCategory.Ship);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 305);
        }
    }

    public void method_7()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass0.Class211 class211 = new GClass0.Class211();
            // ISSUE: reference to a compiler-generated field
            class211.gclass0_0 = this;
            // ISSUE: reference to a compiler-generated field
            class211.list_0 = this.MissileSalvoes.Values
                .Where<MissileSalvo>(gclass132_0 =>
                    gclass132_0.decimal_0 == this.GameTime && gclass132_0.Ship != null).ToList<MissileSalvo>();
            // ISSUE: reference to a compiler-generated field
            if (class211.list_0.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            List<Contact> list1 = this.Contacts.Values.Where<Contact>(class211.method_0).ToList<Contact>();
            if (list1.Count == 0)
                return;
            List<GameRace> list2 = list1.Select<Contact, GameRace>(gclass65_0 => gclass65_0.DetectRace)
                .Distinct<GameRace>().ToList<GameRace>();
            // ISSUE: reference to a compiler-generated field
            List<ShipData> list3 = class211.list_0
                .Select<MissileSalvo, ShipData>(gclass132_0 => gclass132_0.Ship).ToList<ShipData>();
            foreach (GameRace gclass21 in list2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class212 class212 = new GClass0.Class212();
                // ISSUE: reference to a compiler-generated field
                class212.gclass21_0 = gclass21;
                foreach (ShipData gclass40 in list3)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.Class213 class213 = new GClass0.Class213()
                    {
                        class212_0 = class212,
                        gclass40_0 = gclass40
                    };
                    // ISSUE: reference to a compiler-generated field
                    class213.gclass40_0.decimal_13 = this.GameTime;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    GClass117 gclass117_0 =
                        class213.class212_0.gclass21_0.dictionary_12.Values
                            .FirstOrDefault<GClass117>(class213.method_0);
                    if (gclass117_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated method
                        List<MissileSalvo> list4 = list1.Where<Contact>(class213.method_1)
                            .Select<Contact, MissileSalvo>(gclass65_0 => gclass65_0.TargetSalvo).ToList<MissileSalvo>();
                        if (list4.Count != 0)
                        {
                            foreach (Decimal num in list4
                                         .Select<MissileSalvo, Decimal>(gclass132_0 => gclass132_0.RaceMissile.Size)
                                         .Distinct<Decimal>().ToList<Decimal>())
                            {
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: variable of a compiler-generated type
                                GClass0.Class214 class214 = new GClass0.Class214();
                                // ISSUE: reference to a compiler-generated field
                                class214.int_0 = (int)num;
                                // ISSUE: reference to a compiler-generated method
                                int int_8 = list4.Where<MissileSalvo>(class214.method_0)
                                    .Sum<MissileSalvo>(gclass132_0 => gclass132_0.RemainingDecoys.Count);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                ShipComponent gclass230_0 = class213.gclass40_0.gclass22_0
                                    .method_74(AuroraComponentType.MissileLauncher)
                                    .Select<GClass228, ShipComponent>(gclass228_0 => gclass228_0.gclass230_0)
                                    .FirstOrDefault<ShipComponent>(class214.method_1);
                                if (gclass230_0 != null)
                                    gclass117_0.gclass115_0.method_11(gclass117_0, gclass230_0, 0.0, int_8);
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 306);
        }
    }

    public void method_8(int int_136)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class261 class261 = new GClass0.Class261();
        // ISSUE: reference to a compiler-generated field
        class261.gclass0_0 = this;
        // ISSUE: reference to a compiler-generated field
        class261.int_0 = int_136;
        try
        {
            List<GClass37> list = this.list_22.Where<GClass37>(gclass37_0 => gclass37_0.gclass230_0 != null)
                .Where<GClass37>(gclass37_0 => gclass37_0.gclass230_0.bool_4).ToList<GClass37>();
            List<GClass38> source = new List<GClass38>();
            foreach (GClass37 gclass37 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class262 class262 = new GClass0.Class262();
                // ISSUE: reference to a compiler-generated field
                class262.gclass37_0 = gclass37;
                // ISSUE: reference to a compiler-generated method
                GClass38 gclass38 = source.FirstOrDefault<GClass38>(class262.method_0);
                if (gclass38 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass38.int_0 += class262.gclass37_0.int_1;
                    // ISSUE: reference to a compiler-generated field
                    gclass38.int_1 += class262.gclass37_0.int_2;
                    // ISSUE: reference to a compiler-generated field
                    if (class262.gclass37_0.double_1 > gclass38.double_0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass38.double_0 = class262.gclass37_0.double_1;
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class262.gclass37_0.decimal_0 > gclass38.decimal_0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass38.decimal_0 = class262.gclass37_0.decimal_0;
                    }
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    source.Add(new GClass38()
                    {
                        gclass40_0 = class262.gclass37_0.gclass40_0,
                        gclass230_0 = class262.gclass37_0.gclass230_0,
                        auroraContactType_0 = class262.gclass37_0.auroraContactType_0,
                        int_0 = class262.gclass37_0.int_1,
                        int_1 = class262.gclass37_0.int_2,
                        double_0 = class262.gclass37_0.double_1,
                        decimal_0 = class262.gclass37_0.decimal_0
                    });
                }
            }

            foreach (GClass38 gclass38 in source)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class263 class263 = new GClass0.Class263();
                // ISSUE: reference to a compiler-generated field
                class263.class261_0 = class261;
                // ISSUE: reference to a compiler-generated field
                class263.gclass38_0 = gclass38;
                // ISSUE: reference to a compiler-generated field
                if (class263.gclass38_0.gclass40_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class263.gclass38_0.gclass40_0.decimal_13 = this.GameTime;
                    // ISSUE: reference to a compiler-generated method
                    foreach (Contact gclass65 in this.Contacts.Values.Where<Contact>(class263.method_0)
                                 .ToList<Contact>())
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class264 class264 = new GClass0.Class264();
                        // ISSUE: reference to a compiler-generated field
                        class264.gclass65_0 = gclass65;
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class265 class265 = new GClass0.Class265();
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        class265.gclass117_0 =
                            class264.gclass65_0.DetectRace.dictionary_12.Values.FirstOrDefault<GClass117>(
                                class264.method_0);
                        // ISSUE: reference to a compiler-generated field
                        if (class265.gclass117_0 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            int int_8 = class263.gclass38_0.int_0 / class263.gclass38_0.gclass230_0.int_7;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class265.gclass117_0.gclass115_0.method_11(class265.gclass117_0,
                                class263.gclass38_0.gclass230_0, class263.gclass38_0.double_0, int_8);
                            // ISSUE: reference to a compiler-generated field
                            if (class263.gclass38_0.auroraContactType_0 == AuroraContactType.Salvo)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class265.gclass117_0.decimal_8 < this.GameTime)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class265.gclass117_0.int_4 = class263.gclass38_0.int_0;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class265.gclass117_0.int_4 += class263.gclass38_0.int_0;
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class265.gclass117_0.gclass115_0.int_6 += class263.gclass38_0.int_0;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class265.gclass117_0.gclass115_0.int_7 += class263.gclass38_0.int_1;
                                // ISSUE: reference to a compiler-generated field
                                class265.gclass117_0.gclass115_0.bool_0 = true;
                                // ISSUE: reference to a compiler-generated field
                                class265.gclass117_0.decimal_8 = this.GameTime;
                                // ISSUE: reference to a compiler-generated field
                                if (class265.gclass117_0.gclass40_0 != null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    foreach (GClass115 gclass115 in class264.gclass65_0.DetectRace.dictionary_12.Values
                                                 .Where<GClass117>(gclass117_0 => gclass117_0.gclass40_0 != null)
                                                 .Where<GClass117>(class265.method_0)
                                                 .Select<GClass117, GClass115>(gclass117_0 => gclass117_0.gclass115_0)
                                                 .Distinct<GClass115>().ToList<GClass115>())
                                        gclass115.bool_0 = true;
                                }
                            }
                        }
                    }
                }
            }

            // ISSUE: reference to a compiler-generated method
            foreach (GClass117 gclass117 in this.GameRaces.Values
                         .SelectMany<GameRace, GClass117>(gclass21_0 => gclass21_0.dictionary_12.Values)
                         .Where<GClass117>(class261.method_0).ToList<GClass117>())
            {
                if (gclass117.gclass115_0.int_5 < gclass117.int_4)
                    gclass117.gclass115_0.int_5 = gclass117.int_4;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 307);
        }
    }

    public void method_9(ShipData gclass40_0, GClass37 gclass37_0)
    {
        try
        {
            if (gclass37_0.gclass40_0 != null)
            {
                string str = gclass37_0.gclass40_0.gclass21_0.method_283(gclass40_0);
                gclass37_0.gclass40_0.method_204(
                    $"Destroyed {str} ({AuroraUtils.smethod_38(gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17)} tons) in {gclass37_0.gclass40_0.gclass85_0.System.Name}");
                gclass37_0.gclass40_0.method_192(AuroraCommandType.Ship)?.method_46(
                    $"Destroyed {str} ({AuroraUtils.smethod_38(gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17)} tons) while in command of {gclass37_0.gclass40_0.method_187()}",
                    GEnum28.const_0);
                GClass117 gclass117 = gclass37_0.gclass40_0.gclass21_0.method_267(gclass40_0);
                if (gclass117 != null)
                {
                    gclass117.bool_0 = true;
                    gclass117.decimal_2 = this.GameTime;
                }

                gclass37_0.gclass40_0.method_72(AuroraMeasurementType.HostileShipsDestroyed, 1M);
                if (gclass40_0.gclass22_0.Commercial)
                    gclass37_0.gclass40_0.method_72(AuroraMeasurementType.CommercialShippingDestroyed,
                        gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17);
                else
                    gclass37_0.gclass40_0.method_72(AuroraMeasurementType.MilitaryShippingDestroyed,
                        gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17);
            }
            else
            {
                if (gclass37_0.gclass39_0 == null)
                    return;
                string str = gclass37_0.gclass39_0.Formation.RaceData.method_283(gclass40_0);
                GClass55 gclass550 = gclass37_0.gclass39_0.Formation.gclass55_0;
                if (gclass550 != null)
                {
                    gclass550.method_46(
                        $"Destroyed {str} ({AuroraUtils.smethod_38(gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17)} tons) while in command of {gclass37_0.gclass39_0.Formation.Name}",
                        GEnum28.const_0);
                    if (gclass40_0.gclass22_0.Commercial)
                        gclass550.method_1(AuroraMeasurementType.CommercialShippingDestroyed,
                            gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17);
                    else
                        gclass550.method_1(AuroraMeasurementType.MilitaryShippingDestroyed,
                            gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17);
                }

                GClass117 gclass117 = gclass37_0.gclass39_0.Formation.RaceData.method_267(gclass40_0);
                if (gclass117 == null)
                    return;
                gclass117.bool_0 = true;
                gclass117.decimal_2 = this.GameTime;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 308);
        }
    }

    public void method_10(ShipData gclass40_0, int int_136, bool bool_25)
    {
        try
        {
            if (gclass40_0 == null)
                return;
            if (bool_25)
                gclass40_0.method_72(AuroraMeasurementType.InternalDamageTaken, int_136);
            else
                gclass40_0.method_72(AuroraMeasurementType.MilitaryShippingDestroyed,
                    gclass40_0.gclass22_0.Size * AuroraUtils.decimal_17);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 309);
        }
    }

    public void method_11(
        ShipData gclass40_0,
        GameRace gclass21_2,
        int int_136,
        int int_137,
        int int_138,
        int int_139,
        int int_140)
    {
        try
        {
            if (!this.Ships.ContainsKey(gclass40_0.int_8))
                return;
            this.Ships[gclass40_0.int_8].int_3 += int_136;
            this.Ships[gclass40_0.int_8].int_4 += int_137;
            this.Ships[gclass40_0.int_8].int_5 += int_138;
            this.Ships[gclass40_0.int_8].int_6 += int_139;
            this.Ships[gclass40_0.int_8].int_7 += int_140;
            if (gclass21_2 == null || this.Ships[gclass40_0.int_8].list_20.Contains(gclass21_2))
                return;
            this.Ships[gclass40_0.int_8].list_20.Add(gclass21_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 310);
        }
    }

    public void method_12()
    {
        try
        {
            List<GClass37> list1 = this.list_22.Where<GClass37>(gclass37_0 =>
                gclass37_0.auroraContactType_0 == AuroraContactType.Salvo && gclass37_0.gclass230_0 != null &&
                gclass37_0.gclass40_0 != null).ToList<GClass37>();
            foreach (FleetData gclass85 in list1
                         .Select<GClass37, FleetData>(gclass37_0 => gclass37_0.gclass40_0.gclass85_0)
                         .Distinct<FleetData>().OrderBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName)
                         .ToList<FleetData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class44 class44 = new GClass0.Class44();
                // ISSUE: reference to a compiler-generated field
                class44.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass92_0.method_2(EventType.const_217, class44.gclass85_0.FleetName,
                    class44.gclass85_0.Race, class44.gclass85_0.System.ActualSystem,
                    class44.gclass85_0.XCoord, class44.gclass85_0.YCoord, AuroraEventCategory.CombatResults);
                // ISSUE: reference to a compiler-generated method
                foreach (ShipComponent gclass230 in list1.Where<GClass37>(class44.method_0)
                             .Select<GClass37, ShipComponent>(gclass37_0 => gclass37_0.gclass230_0).Distinct<ShipComponent>()
                             .OrderBy<ShipComponent, string>(gclass230_0 => gclass230_0.Name).ToList<ShipComponent>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.Class45 class45 = new GClass0.Class45();
                    // ISSUE: reference to a compiler-generated field
                    class45.class44_0 = class44;
                    // ISSUE: reference to a compiler-generated field
                    class45.gclass230_0 = gclass230;
                    // ISSUE: reference to a compiler-generated method
                    List<GClass37> list2 = list1.Where<GClass37>(class45.method_0).ToList<GClass37>();
                    int num1 = list2.Sum<GClass37>(gclass37_0 => gclass37_0.int_1);
                    int num2 = list2.Sum<GClass37>(gclass37_0 => gclass37_0.int_2);
                    int num3 = list2.Sum<GClass37>(gclass37_0 => gclass37_0.int_6);
                    int num4 = list2.Sum<GClass37>(gclass37_0 => gclass37_0.int_8);
                    string str1 = AuroraUtils.FormatDoubleToPrecision(list2.Average<GClass37>(gclass37_0 => gclass37_0.double_0), 1);
                    string str2 = AuroraUtils.FormatDoubleToPrecision((num2 + num3) * 100 / (double)num1, 1);
                    string str3 = AuroraUtils.FormatDoubleToPrecision(num2 * 100 / (double)num1, 1);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass92_0.method_2(EventType.const_223,
                        $"{class45.gclass230_0.Name}:    Shots {num1.ToString()}    Missile Kills {num2.ToString()}    Decoy Hits {num3.ToString()}    Overkill {num4.ToString()}    Avg CTH {str1}%    Hit {str2}%    Kill {str3}%",
                        class45.class44_0.gclass85_0.Race, class45.class44_0.gclass85_0.System.ActualSystem,
                        class45.class44_0.gclass85_0.XCoord, class45.class44_0.gclass85_0.YCoord,
                        AuroraEventCategory.CombatResults);
                }
            }

            List<GClass37> list3 = this.list_22.Where<GClass37>(gclass37_0 =>
                gclass37_0.auroraContactType_0 == AuroraContactType.Salvo && gclass37_0.gclass230_0 != null &&
                gclass37_0.gclass39_0 != null).ToList<GClass37>();
            foreach (PopulationData gclass146 in list3
                         .Select<GClass37, PopulationData>(gclass37_0 => gclass37_0.gclass39_0.Formation.PopulationData)
                         .Distinct<PopulationData>().OrderBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName)
                         .ToList<PopulationData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class46 class46 = new GClass0.Class46();
                // ISSUE: reference to a compiler-generated field
                class46.gclass146_0 = gclass146;
                // ISSUE: reference to a compiler-generated field
                double double_0 = class46.gclass146_0.method_87();
                // ISSUE: reference to a compiler-generated field
                double double_1 = class46.gclass146_0.method_88();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.gclass92_0.method_2(EventType.const_222, class46.gclass146_0.PopName,
                    class46.gclass146_0.Race, class46.gclass146_0.gclass202_0.ActualSystem, double_0, double_1,
                    AuroraEventCategory.CombatResults);
                // ISSUE: reference to a compiler-generated method
                foreach (ShipComponent gclass230 in list3.Where<GClass37>(class46.method_0)
                             .Select<GClass37, ShipComponent>(gclass37_0 => gclass37_0.gclass230_0).Distinct<ShipComponent>()
                             .OrderBy<ShipComponent, string>(gclass230_0 => gclass230_0.Name).ToList<ShipComponent>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.Class47 class47 = new GClass0.Class47();
                    // ISSUE: reference to a compiler-generated field
                    class47.class46_0 = class46;
                    // ISSUE: reference to a compiler-generated field
                    class47.gclass230_0 = gclass230;
                    // ISSUE: reference to a compiler-generated method
                    List<GClass37> list4 = list3.Where<GClass37>(class47.method_0).ToList<GClass37>();
                    int num5 = list4.Sum<GClass37>(gclass37_0 => gclass37_0.int_1);
                    int num6 = list4.Sum<GClass37>(gclass37_0 => gclass37_0.int_2);
                    int num7 = list4.Sum<GClass37>(gclass37_0 => gclass37_0.int_6);
                    int num8 = list4.Sum<GClass37>(gclass37_0 => gclass37_0.int_8);
                    string str4 = AuroraUtils.FormatDoubleToPrecision(list4.Average<GClass37>(gclass37_0 => gclass37_0.double_0), 1);
                    string str5 = AuroraUtils.FormatDoubleToPrecision((num6 + num7) * 100 / (double)num5, 1);
                    string str6 = AuroraUtils.FormatDoubleToPrecision(num6 * 100 / (double)num5, 1);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass92_0.method_2(EventType.const_223,
                        $"{class47.gclass230_0.Name}:    Shots {num5.ToString()}    Missile Kills {num6.ToString()}    Decoy Hits {num7.ToString()}    Overkill {num8.ToString()}    Avg CTH {str4}%    Hit {str5}%    Kill {str6}%",
                        class47.class46_0.gclass146_0.Race, class47.class46_0.gclass146_0.gclass202_0.ActualSystem,
                        double_0, double_1, AuroraEventCategory.CombatResults);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3562);
        }
    }

    public void method_13()
    {
        try
        {
            foreach (ShipData gclass40_0_1 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.list_12.Count > 0 && this.GameTime - gclass40_0.decimal_18 < 90000M)
                         .ToList<ShipData>())
            {
                List<ShipData> source = gclass40_0_1.gclass85_0.method_178();
                if (source.Count >= 2)
                {
                    Decimal num1 = gclass40_0_1.method_171(true);
                    if (!(num1 == gclass40_0_1.gclass22_0.MaxSpeed))
                    {
                        Decimal num2 = source.Max<ShipData>(gclass40_0 => gclass40_0.method_171(true));
                        if (num1 < num2 * 0.9M)
                            gclass40_0_1.gclass85_0.method_75(gclass40_0_1, OperationalGroupID.ReinforcementGroup, true);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3860);
        }
    }

    public void method_14(bool bool_25)
    {
        try
        {
            foreach (GClass37 gclass37 in this.list_22)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class48 class48 = new GClass0.Class48();
                // ISSUE: reference to a compiler-generated field
                class48.gclass37_0 = gclass37;
                RacialSystemSurvey gclass202 = null;
                Decimal num1 = 0M;
                this.list_22.Sum<GClass37>(gclass37_0 => gclass37_0.int_1);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class48.gclass37_0.gclass129_0 != null && class48.gclass37_0.bool_2)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass92_0.method_2(EventType.const_11,
                        $"{class48.gclass37_0.gclass40_0.method_187()} has launched {class48.gclass37_0.int_1.ToString()}x {class48.gclass37_0.gclass129_0.Name} from {class48.gclass37_0.gclass230_0.Name} targeted on {class48.gclass37_0.string_0}.   Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km   Estimated Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%",
                        class48.gclass37_0.gclass40_0.gclass21_0,
                        class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                        class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                        class48.gclass37_0.gclass40_0.gclass85_0.YCoord, AuroraEventCategory.CombatResults);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class48.gclass37_0.auroraContactType_0 == AuroraContactType.Salvo &&
                        class48.gclass37_0.gclass230_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (!class48.gclass37_0.bool_0 && this.MissileSalvoes.ContainsKey(class48.gclass37_0.int_0))
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (this.MissileSalvoes[class48.gclass37_0.int_0].RemainingDecoys.Count <=
                                class48.gclass37_0.int_2)
                            {
                                // ISSUE: reference to a compiler-generated field
                                this.MissileSalvoes[class48.gclass37_0.int_0].method_6();
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.MissileSalvoes[class48.gclass37_0.int_0].method_5(class48.gclass37_0.int_2);
                            }
                        }

                        // ISSUE: reference to a compiler-generated field
                        if (class48.gclass37_0.gclass40_0 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            string string_0 =
                                $"{class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0} with {class48.gclass37_0.gclass230_0.Name}.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%    Shots {class48.gclass37_0.int_1.ToString()}   Missiles Destroyed {class48.gclass37_0.int_2.ToString()}";
                            // ISSUE: reference to a compiler-generated field
                            if (class48.gclass37_0.int_6 > 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                string_0 = $"{string_0}   Decoys Destroyed {class48.gclass37_0.int_6.ToString()}";
                            }

                            // ISSUE: reference to a compiler-generated field
                            if (class48.gclass37_0.gclass40_0.gclass22_0.Size <= 10M)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass92_0.method_2(EventType.const_214, string_0,
                                    class48.gclass37_0.gclass40_0.gclass21_0,
                                    class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                    class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                    class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                    AuroraEventCategory.CombatResults);
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass92_0.method_2(EventType.const_199, string_0,
                                    class48.gclass37_0.gclass40_0.gclass21_0,
                                    class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                    class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                    class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                    AuroraEventCategory.CombatResults);
                            }
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class48.gclass37_0.gclass39_0 != null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                string string_0 =
                                    $"{class48.gclass37_0.gclass39_0.UnitCount.ToString()}x {class48.gclass37_0.gclass39_0.GroundUnitClass.ClassName} of {class48.gclass37_0.gclass39_0.Formation.Name} attacked {class48.gclass37_0.string_0}.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%    Shots {class48.gclass37_0.int_1.ToString()}   Missiles Destroyed {class48.gclass37_0.int_2.ToString()}";
                                // ISSUE: reference to a compiler-generated field
                                if (class48.gclass37_0.int_6 > 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    string_0 = $"{string_0}   Decoys Destroyed {class48.gclass37_0.int_6.ToString()}";
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass92_0.method_2(EventType.const_200, string_0,
                                    class48.gclass37_0.gclass39_0.Formation.RaceData,
                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.gclass202_0.ActualSystem,
                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.method_87(),
                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.method_88(),
                                    AuroraEventCategory.CombatResults);
                            }
                        }
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class48.gclass37_0.auroraContactType_0 == AuroraContactType.Salvo &&
                            class48.gclass37_0.gclass129_0 != null)
                        {
                            string str = "";
                            // ISSUE: reference to a compiler-generated field
                            int num2 = class48.gclass37_0.int_1;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class48.gclass37_0.gclass129_0 != null && class48.gclass37_0.gclass129_0.MultipleWarheads > 1)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                num2 = class48.gclass37_0.int_1 / class48.gclass37_0.gclass129_0.MultipleWarheads;
                                // ISSUE: reference to a compiler-generated field
                                str = "    Warheads " + class48.gclass37_0.int_1.ToString();
                            }

                            // ISSUE: reference to a compiler-generated field
                            if (class48.gclass37_0.gclass40_0 != null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                string string_0 =
                                    $"{num2.ToString()}x {class48.gclass37_0.gclass129_0.Name} from {class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0}.    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%{str}   Missiles Hit {class48.gclass37_0.int_2.ToString()}   Missiles Destroyed {class48.gclass37_0.int_7.ToString()}";
                                // ISSUE: reference to a compiler-generated field
                                if (class48.gclass37_0.int_6 > 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    string_0 = $"{string_0}   Decoys Destroyed {class48.gclass37_0.int_6.ToString()}";
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass92_0.method_2(EventType.const_201, string_0,
                                    class48.gclass37_0.gclass40_0.gclass21_0,
                                    class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                    class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                    class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                    AuroraEventCategory.CombatResults);
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class48.gclass37_0.gclass40_0.method_72(AuroraMeasurementType.HostileOrdnanceDestroyed,
                                    class48.gclass37_0.int_2);
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class48.gclass37_0.gclass129_0 != null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    string string_0 =
                                        $"{num2.ToString()}x {class48.gclass37_0.gclass129_0.Name} attacked {class48.gclass37_0.string_0}.    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%{str}   Missiles Hit {class48.gclass37_0.int_2.ToString()}   Missiles Destroyed {class48.gclass37_0.int_7.ToString()}";
                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.int_6 > 0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        string_0 =
                                            $"{string_0}   Decoys Destroyed {class48.gclass37_0.int_6.ToString()}";
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    this.gclass92_0.method_2(EventType.const_201, string_0,
                                        class48.gclass37_0.gclass21_1, gclass202.ActualSystem, 0.0, 0.0,
                                        AuroraEventCategory.CombatResults);
                                }
                            }
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class48.gclass37_0.auroraContactType_0 == AuroraContactType.Ship &&
                                (class48.gclass37_0.gclass230_0 != null || class48.gclass37_0.gclass129_0 != null ||
                                 class48.gclass37_0.bool_3 || class48.gclass37_0.bool_4 || class48.gclass37_0.bool_5 ||
                                 class48.gclass37_0.genum62_0 == GEnum62.const_2 ||
                                 class48.gclass37_0.genum62_0 == GEnum62.const_1))
                            {
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: variable of a compiler-generated type
                                GClass0.Class49 class49 = new GClass0.Class49();
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                class49.gclass40_0 =
                                    this.Ships.Values.FirstOrDefault<ShipData>(class48.method_0);
                                // ISSUE: reference to a compiler-generated field
                                if (class49.gclass40_0 != null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class49.gclass40_0.gclass21_0.NPR && class48.gclass37_0.int_2 > 0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        class49.gclass40_0.method_46();
                                        // ISSUE: reference to a compiler-generated field
                                        if (class48.gclass37_0.gclass230_0 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class49.gclass40_0.decimal_20 = this.GameTime;
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass129_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class49.gclass40_0.decimal_19 = this.GameTime;
                                            }
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        if (class49.gclass40_0.gclass21_0.SpecialNPRID == SpecialNPRIDs.Precursor &&
                                            this.EnhancedPrecursors == 1)
                                        {
                                            // ISSUE: reference to a compiler-generated method
                                            foreach (GClass172 gclass172 in this.list_8
                                                         .Where<GClass172>(class49.method_0).ToList<GClass172>())
                                                gclass172.decimal_1 = this.GameTime;
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    class49.gclass117_0 = null;
                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.gclass21_1 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class49.gclass117_0 =
                                            class48.gclass37_0.gclass21_1.method_267(class49.gclass40_0);
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    gclass202 = class49.gclass40_0.gclass85_0.System;
                                    // ISSUE: reference to a compiler-generated field
                                    for (int index = 1; index <= class48.gclass37_0.int_2; ++index)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        switch (class49.gclass40_0.method_0(class48.gclass37_0.gclass230_0,
                                                    class48.gclass37_0.gclass129_0, class48.gclass37_0.decimal_0, false,
                                                    class49.gclass117_0, class48.gclass37_0.bool_4,
                                                    class48.gclass37_0.bool_5, class48.gclass37_0))
                                        {
                                            case GEnum51.const_1:
                                                // ISSUE: reference to a compiler-generated field
                                                ++class48.gclass37_0.int_3;
                                                break;
                                            case GEnum51.const_2:
                                                // ISSUE: reference to a compiler-generated field
                                                ++class48.gclass37_0.int_4;
                                                break;
                                            case GEnum51.const_3:
                                                // ISSUE: reference to a compiler-generated field
                                                ++class48.gclass37_0.int_5;
                                                // ISSUE: reference to a compiler-generated field
                                                if (class49.gclass40_0.gclass21_0.NPR)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class49.gclass40_0.decimal_21 = this.GameTime;
                                                    break;
                                                }

                                                break;
                                            case GEnum51.const_4:
                                                // ISSUE: reference to a compiler-generated field
                                                class48.gclass37_0.bool_1 = true;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_9(class49.gclass40_0, class48.gclass37_0);
                                                goto label_54;
                                        }
                                    }

                                    label_54:
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    num1 += class48.gclass37_0.int_2 * class48.gclass37_0.decimal_0;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.gclass21_0 != null && class48.gclass37_0.gclass21_1 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class48.gclass37_0.gclass21_0.method_23(class48.gclass37_0, class49.gclass40_0);
                                    }

                                    string str1 = "";
                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.bool_1)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        str1 =
                                            $"{str1}    The target was destroyed by {class48.gclass37_0.int_2.ToString()} hits";
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (class48.gclass37_0.int_2 == 0)
                                        {
                                            str1 += "    No hits";
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.int_3 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                str1 = $"{str1}    Shield Hits {class48.gclass37_0.int_3.ToString()}";
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.int_4 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                str1 = $"{str1}    Armour Hits {class48.gclass37_0.int_4.ToString()}";
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class49.gclass40_0.method_72(AuroraMeasurementType.ArmourDamageTaken,
                                                    class48.gclass37_0.int_4 * class48.gclass37_0.decimal_0);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.int_5 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                str1 =
                                                    $"{str1}    Penetrating Hits {class48.gclass37_0.int_5.ToString()}";
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class49.gclass40_0.method_72(AuroraMeasurementType.InternalDamageTaken,
                                                    class48.gclass37_0.int_4 * class48.gclass37_0.decimal_0);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class49.gclass40_0.method_204(
                                                    $"{(class48.gclass37_0.int_4 * class48.gclass37_0.decimal_0).ToString()} internal damage suffered during engagement in {class49.gclass40_0.gclass85_0.System.Name}");
                                            }
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.int_6 > 0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        str1 = $"{str1}    Ship Decoy Hits {class48.gclass37_0.int_6.ToString()}";
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    if (class49.gclass40_0.gclass40_3 == null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num3 = class49.gclass40_0.method_171(true);
                                        // ISSUE: reference to a compiler-generated field
                                        if (num3 < class49.gclass40_0.gclass85_0.Speed)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class49.gclass40_0.gclass85_0.method_179() > 1 &&
                                                !class48.gclass37_0.bool_1)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class49.gclass40_0.gclass85_0.method_75(class49.gclass40_0,
                                                    OperationalGroupID.ReinforcementGroup, true);
                                                // ISSUE: reference to a compiler-generated field
                                                class49.gclass40_0.bool_5 = true;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class49.gclass40_0.gclass85_0.Speed = (int)num3;
                                            }
                                        }

                                        if (num3 < 1M)
                                            ;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    this.method_11(class49.gclass40_0, class48.gclass37_0.gclass21_1,
                                        class48.gclass37_0.int_2, class48.gclass37_0.int_3, class48.gclass37_0.int_4,
                                        class48.gclass37_0.int_5, class48.gclass37_0.int_6);
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.gclass230_0 != null && class48.gclass37_0.gclass40_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        string string_0 =
                                            $"{class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0} with {class48.gclass37_0.gclass230_0.Name}.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%    Shots {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}    New Target Speed {AuroraUtils.smethod_39(class49.gclass40_0.gclass85_0.Speed)} km/s";
                                        // ISSUE: reference to a compiler-generated field
                                        if (class48.gclass37_0.gclass40_0.gclass22_0.Size <= 10M)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_215, string_0,
                                                class48.gclass37_0.gclass21_1,
                                                class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                                class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                AuroraEventCategory.CombatResults);
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_202, string_0,
                                                class48.gclass37_0.gclass21_1,
                                                class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                                class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                AuroraEventCategory.CombatResults);
                                        }
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class48.gclass37_0.gclass129_0 != null &&
                                            class48.gclass37_0.gclass40_0 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            string string_0 =
                                                $"{class48.gclass37_0.int_1.ToString()}x {class48.gclass37_0.gclass129_0.Name} from {class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0}.    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%     Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}    New Target Speed {AuroraUtils.smethod_39(class49.gclass40_0.gclass85_0.Speed)} km/s";
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass40_0.gclass22_0.Size <= 10M)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_216, string_0,
                                                    class48.gclass37_0.gclass21_1,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_203, string_0,
                                                    class48.gclass37_0.gclass21_1,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                    AuroraEventCategory.CombatResults);
                                            }
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null &&
                                                class48.gclass37_0.gclass39_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_204,
                                                    $"{class48.gclass37_0.gclass39_0.Formation.Name} attacked {class48.gclass37_0.string_0} with {class48.gclass37_0.gclass230_0.Name}.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%    Shots {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}    New Target Speed {AuroraUtils.smethod_39(class49.gclass40_0.gclass85_0.Speed)} km/s",
                                                    class48.gclass37_0.gclass21_1,
                                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.gclass202_0
                                                        .ActualSystem,
                                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.method_87(),
                                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.method_88(),
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass129_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_205,
                                                        $"{class48.gclass37_0.int_1.ToString()}x {class48.gclass37_0.gclass129_0.Name} attacked {class48.gclass37_0.string_0}.    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%     Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}    New Target Speed {AuroraUtils.smethod_39(class49.gclass40_0.gclass85_0.Speed)} km/s",
                                                        class48.gclass37_0.gclass21_1, gclass202.ActualSystem,
                                                        class49.gclass40_0.gclass85_0.XCoord,
                                                        class49.gclass40_0.gclass85_0.YCoord,
                                                        AuroraEventCategory.CombatResults);
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.genum62_0 == GEnum62.const_1 &&
                                                        class48.gclass37_0.gclass40_0 != null)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_233,
                                                            $"{class48.gclass37_0.gclass40_0.method_187()} rammed {class48.gclass37_0.string_0}.    Chance to Hit {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_0)}%     Damage Caused {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}    New Target Speed {AuroraUtils.smethod_39(class49.gclass40_0.gclass85_0.Speed)} km/s",
                                                            class48.gclass37_0.gclass21_1, gclass202.ActualSystem,
                                                            class49.gclass40_0.gclass85_0.XCoord,
                                                            class49.gclass40_0.gclass85_0.YCoord,
                                                            AuroraEventCategory.CombatResults);
                                                    }
                                                    else
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        if (class48.gclass37_0.genum62_0 == GEnum62.const_2 &&
                                                            class48.gclass37_0.gclass40_0 != null)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            this.gclass92_0.method_2(EventType.const_234,
                                                                $"{class48.gclass37_0.gclass40_0.method_187()} was rammed by {class48.gclass37_0.string_0}. Damage caused to Ramming Ship {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}    New Target Speed {AuroraUtils.smethod_39(class49.gclass40_0.gclass85_0.Speed)} km/s",
                                                                class48.gclass37_0.gclass21_1, gclass202.ActualSystem,
                                                                class49.gclass40_0.gclass85_0.XCoord,
                                                                class49.gclass40_0.gclass85_0.YCoord,
                                                                AuroraEventCategory.CombatResults);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.gclass129_0 != null &&
                                        class48.gclass37_0.gclass21_1 != null && class49.gclass117_0 != null &&
                                        class49.gclass117_0.gclass40_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        foreach (GClass115 gclass115 in class48.gclass37_0.gclass21_1.dictionary_12
                                                     .Values
                                                     .Where<GClass117>(gclass117_0 => gclass117_0.gclass40_0 != null)
                                                     .Where<GClass117>(class49.method_1)
                                                     .Select<GClass117, GClass115>(gclass117_0 =>
                                                         gclass117_0.gclass115_0).Distinct<GClass115>()
                                                     .ToList<GClass115>())
                                            gclass115.bool_0 = true;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    if (class48.gclass37_0.gclass21_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (class48.gclass37_0.gclass39_0 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            string str2 =
                                                class48.gclass37_0.gclass39_0.Formation.PopulationData.SystemBodyData
                                                    .method_78(class48.gclass37_0.gclass21_0);
                                            if (str2 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_206,
                                                    $"{class49.gclass40_0.method_187()} attacked by surface-based energy weapons based on {str2}.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Shots {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}",
                                                    class49.gclass40_0.gclass21_0,
                                                    class49.gclass40_0.gclass85_0.System.ActualSystem,
                                                    class49.gclass40_0.gclass85_0.XCoord,
                                                    class49.gclass40_0.gclass85_0.YCoord,
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_207,
                                                    $"{class49.gclass40_0.method_187()} attacked by unknown energy weapons.   Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}",
                                                    class49.gclass40_0.gclass21_0,
                                                    class49.gclass40_0.gclass85_0.System.ActualSystem,
                                                    class49.gclass40_0.gclass85_0.XCoord,
                                                    class49.gclass40_0.gclass85_0.YCoord,
                                                    AuroraEventCategory.CombatResults);
                                            }
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null)
                                            {
                                                string str3 = "";
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass230_0.bool_10)
                                                    str3 = " (Electronic Damage)";
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                GClass117 gclass117 =
                                                    class48.gclass37_0.gclass21_0.method_267(class48.gclass37_0
                                                        .gclass40_0);
                                                string string_0;
                                                if (gclass117 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    string_0 =
                                                        $"{class49.gclass40_0.method_187()} attacked by {gclass117.method_11()} using energy weapons.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Shots {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str3}{str1}";
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    string_0 =
                                                        $"{class49.gclass40_0.method_187()} attacked by unknown energy weapons.   Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str3}{str1}";
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_207, string_0,
                                                    class49.gclass40_0.gclass21_0,
                                                    class49.gclass40_0.gclass85_0.System.ActualSystem,
                                                    class49.gclass40_0.gclass85_0.XCoord,
                                                    class49.gclass40_0.gclass85_0.YCoord,
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass129_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_208,
                                                        $"{class49.gclass40_0.method_187()} attacked by missiles.   Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}",
                                                        class49.gclass40_0.gclass21_0,
                                                        class49.gclass40_0.gclass85_0.System.ActualSystem,
                                                        class49.gclass40_0.gclass85_0.XCoord,
                                                        class49.gclass40_0.gclass85_0.YCoord,
                                                        AuroraEventCategory.CombatResults);
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.genum62_0 == GEnum62.const_1)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        GClass117 gclass117 =
                                                            class48.gclass37_0.gclass21_0.method_267(class48.gclass37_0
                                                                .gclass40_0);
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_234,
                                                            $"{class49.gclass40_0.method_187()} rammed by {gclass117.method_11()}    Damage caused {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}",
                                                            class49.gclass40_0.gclass21_0,
                                                            class49.gclass40_0.gclass85_0.System.ActualSystem,
                                                            class49.gclass40_0.gclass85_0.XCoord,
                                                            class49.gclass40_0.gclass85_0.YCoord,
                                                            AuroraEventCategory.CombatResults);
                                                    }
                                                    else
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        if (class48.gclass37_0.genum62_0 == GEnum62.const_2)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            GClass117 gclass117 =
                                                                class48.gclass37_0.gclass21_0.method_267(
                                                                    class48.gclass37_0.gclass40_0);
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            this.gclass92_0.method_2(EventType.const_234,
                                                                $"{class49.gclass40_0.method_187()} rammed {gclass117.method_11()} receiving {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)} damage as a result.{str1}",
                                                                class49.gclass40_0.gclass21_0,
                                                                class49.gclass40_0.gclass85_0.System.ActualSystem,
                                                                class49.gclass40_0.gclass85_0.XCoord,
                                                                class49.gclass40_0.gclass85_0.YCoord,
                                                                AuroraEventCategory.CombatResults);
                                                        }
                                                        else
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (class48.gclass37_0.bool_3)
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                this.gclass92_0.method_2(EventType.const_209,
                                                                    $"{class49.gclass40_0.method_187()} was attacked by AA fire.   Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str1}",
                                                                    class49.gclass40_0.gclass21_0,
                                                                    class49.gclass40_0.gclass85_0.System
                                                                        .ActualSystem,
                                                                    class49.gclass40_0.gclass85_0.XCoord,
                                                                    class49.gclass40_0.gclass85_0.YCoord,
                                                                    AuroraEventCategory.CombatResults);
                                                            }
                                                            else
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                if (class48.gclass37_0.bool_4)
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    this.gclass92_0.method_2(EventType.const_210,
                                                                        $"{class49.gclass40_0.method_187()} suffered collateral damage as a result of boarding combat.   Total Damage {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}",
                                                                        class49.gclass40_0.gclass21_0,
                                                                        class49.gclass40_0.gclass85_0.System
                                                                            .ActualSystem,
                                                                        class49.gclass40_0.gclass85_0.XCoord,
                                                                        class49.gclass40_0.gclass85_0.YCoord,
                                                                        AuroraEventCategory.CombatResults);
                                                                }
                                                                else
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    if (class48.gclass37_0.bool_5)
                                                                    {
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        this.gclass92_0.method_2(EventType.const_162,
                                                                            $"{class49.gclass40_0.method_187()} suffered internal damage as a result of previous acid-based attacks.   Total Damage {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}",
                                                                            class49.gclass40_0.gclass21_0,
                                                                            class49.gclass40_0.gclass85_0.System
                                                                                .ActualSystem,
                                                                            class49.gclass40_0.gclass85_0.XCoord,
                                                                            class49.gclass40_0.gclass85_0.YCoord,
                                                                            AuroraEventCategory.CombatResults);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                    continue;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class48.gclass37_0.auroraContactType_0 == AuroraContactType.Shipyard &&
                                    (class48.gclass37_0.gclass230_0 != null || class48.gclass37_0.gclass129_0 != null))
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    GClass0.Class50 class50 = new GClass0.Class50();
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    class50.gclass146_0 =
                                        this.Populations.Values.FirstOrDefault<PopulationData>(class48.method_1);
                                    // ISSUE: reference to a compiler-generated field
                                    if (class50.gclass146_0 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class50.gclass146_0.Race.NPR && class48.gclass37_0.int_2 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class50.gclass146_0.decimal_78 = this.GameTime;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class50.gclass146_0.decimal_80 = this.GameTime;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass129_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class50.gclass146_0.decimal_79 = this.GameTime;
                                                }
                                            }
                                        }

                                        // ISSUE: reference to a compiler-generated method
                                        List<GClass193> list1 = this.dictionary_31.Values
                                            .Where<GClass193>(class50.method_0).ToList<GClass193>();
                                        if (list1.Count != 0)
                                        {
                                            int index1 = AuroraUtils.GetRandomInteger(list1.Count) - 1;
                                            // ISSUE: reference to a compiler-generated field
                                            class50.gclass193_0 = list1[index1];
                                            // ISSUE: reference to a compiler-generated field
                                            int int1 = class50.gclass193_0.int_1;
                                            // ISSUE: reference to a compiler-generated field
                                            Decimal decimal0 = class50.gclass193_0.decimal_0;
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class50.gclass193_0.auroraShipyardType_0 ==
                                                AuroraShipyardType.Commercial ||
                                                class50.gclass193_0.auroraShipyardType_0 ==
                                                AuroraShipyardType.RepairYard)
                                                decimal0 /= 10M;
                                            // ISSUE: reference to a compiler-generated field
                                            int num4 = (int)(class48.gclass37_0.decimal_0 / decimal0 * 10000M);
                                            if (num4 < 1)
                                                num4 = 1;
                                            // ISSUE: reference to a compiler-generated field
                                            for (int index2 = 1; index2 <= class48.gclass37_0.int_2; ++index2)
                                            {
                                                if (AuroraUtils.GetRandomInteger(100) <= num4)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    --class50.gclass193_0.int_1;
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            string str = class50.gclass193_0.int_1 <= 0
                                                ? "    Shipyard Destroyed"
                                                : "    Slipways Destroyed: " +
                                                  (int1 - class50.gclass193_0.int_1).ToString();
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass21_0 != null &&
                                                class48.gclass37_0.gclass21_1 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class48.gclass37_0.gclass21_0.method_24(class48.gclass37_0);
                                            }

                                            // ISSUE: reference to a compiler-generated method
                                            List<GClass192> list2 = this.dictionary_32.Values
                                                .Where<GClass192>(class50.method_1)
                                                .OrderBy<GClass192, Decimal>(gclass192_0 => gclass192_0.decimal_1)
                                                .ToList<GClass192>();
                                            // ISSUE: reference to a compiler-generated field
                                            if (list2.Count > class50.gclass193_0.int_1)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                int num5 = list2.Count - class50.gclass193_0.int_1;
                                                foreach (GClass192 gclass192 in list2)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_185,
                                                        $"Due to the destruction of a slipway at the {class50.gclass193_0.string_0} in orbit of {class50.gclass146_0.PopName}, the shipyard task to {gclass192.method_0()} has been abandoned.",
                                                        class50.gclass146_0.Race,
                                                        class50.gclass146_0.gclass202_0.ActualSystem,
                                                        class50.gclass146_0.method_87(),
                                                        class50.gclass146_0.method_88(),
                                                        AuroraEventCategory.PopSummary);
                                                    this.dictionary_32.Remove(gclass192.int_0);
                                                    --num5;
                                                    if (num5 == 0)
                                                        break;
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_202,
                                                    $"{class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0} with {class48.gclass37_0.gclass230_0.Name}.    Shots {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str}",
                                                    class48.gclass37_0.gclass21_1,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.System.ActualSystem,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                    class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass129_0 != null &&
                                                    class48.gclass37_0.gclass40_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_203,
                                                        $"{class48.gclass37_0.int_1.ToString()}x {class48.gclass37_0.gclass129_0.Name} from {class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0}.    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str}",
                                                        class48.gclass37_0.gclass21_1,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.System
                                                            .ActualSystem,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                        AuroraEventCategory.CombatResults);
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.gclass129_0 != null)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_205,
                                                            $"{class48.gclass37_0.int_1.ToString()}x {class48.gclass37_0.gclass129_0.Name} attacked {class48.gclass37_0.string_0}.    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str}",
                                                            class48.gclass37_0.gclass21_1,
                                                            class50.gclass146_0.gclass202_0.ActualSystem,
                                                            class50.gclass146_0.method_87(),
                                                            class50.gclass146_0.method_88(),
                                                            AuroraEventCategory.CombatResults);
                                                    }
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null &&
                                                class48.gclass37_0.gclass21_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                GClass117 gclass117 =
                                                    class48.gclass37_0.gclass21_0.method_267(class48.gclass37_0
                                                        .gclass40_0);
                                                string string_0;
                                                if (gclass117 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    string_0 =
                                                        $"{class50.gclass193_0.string_0} attacked by {gclass117.method_11()} using energy weapons.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Hits {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str}";
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    string_0 =
                                                        $"{class50.gclass193_0.string_0} attacked by unknown ship using energy weapons.   Hits {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str}";
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_207, string_0,
                                                    class50.gclass146_0.Race,
                                                    class50.gclass146_0.gclass202_0.ActualSystem,
                                                    class50.gclass146_0.method_87(), class50.gclass146_0.method_88(),
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass129_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_208,
                                                        $"{class50.gclass193_0.string_0} attacked by missiles.   Hits {class48.gclass37_0.int_2.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str}",
                                                        class50.gclass146_0.Race,
                                                        class50.gclass146_0.gclass202_0.ActualSystem,
                                                        class50.gclass146_0.method_87(),
                                                        class50.gclass146_0.method_88(),
                                                        AuroraEventCategory.CombatResults);
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            if (class50.gclass193_0.int_1 <= 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_518(class50.gclass193_0);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            num1 += class48.gclass37_0.int_2 * class48.gclass37_0.decimal_0;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass21_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class48.gclass37_0.gclass21_0.method_22(class48.gclass37_0.gclass21_1,
                                                    -num1, true);
                                            }
                                        }
                                        else
                                            continue;
                                    }
                                    else
                                        continue;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if ((class48.gclass37_0.auroraContactType_0 == AuroraContactType.Population ||
                                         class48.gclass37_0.auroraContactType_0 == AuroraContactType.GroundUnit ||
                                         class48.gclass37_0.auroraContactType_0 == AuroraContactType.STOGroundUnit) &&
                                        (class48.gclass37_0.gclass230_0 != null ||
                                         class48.gclass37_0.gclass129_0 != null || class48.gclass37_0.bool_4))
                                    {
                                        // ISSUE: object of a compiler-generated type is created
                                        // ISSUE: variable of a compiler-generated type
                                        GClass0.Class51 class51 = new GClass0.Class51();
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        class51.gclass146_0 =
                                            this.Populations.Values.FirstOrDefault<PopulationData>(class48.method_2);
                                        // ISSUE: reference to a compiler-generated field
                                        if (class51.gclass146_0 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class51.gclass146_0.Race.NPR && class48.gclass37_0.int_2 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class51.gclass146_0.decimal_78 = this.GameTime;
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass230_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class51.gclass146_0.decimal_80 = this.GameTime;
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.gclass129_0 != null)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        class51.gclass146_0.decimal_79 = this.GameTime;
                                                    }
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            num1 += class48.gclass37_0.int_2 * class48.gclass37_0.decimal_0;
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass21_0 != null &&
                                                class48.gclass37_0.gclass21_1 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class48.gclass37_0.gclass21_0.method_24(class48.gclass37_0);
                                            }

                                            int num6 = 0;
                                            int int_72_1 = 0;
                                            int int_72_2 = 0;
                                            // ISSUE: reference to a compiler-generated field
                                            if (!class48.gclass37_0.bool_4)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.auroraContactType_0 !=
                                                    AuroraContactType.GroundUnit &&
                                                    class48.gclass37_0.auroraContactType_0 !=
                                                    AuroraContactType.STOGroundUnit)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.auroraContactType_0 ==
                                                        AuroraContactType.Population)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        for (int index = 1; index <= class48.gclass37_0.int_2; ++index)
                                                        {
                                                            if (AuroraUtils.GetRandomInteger(3) == 2)
                                                                ++num6;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    num6 = class48.gclass37_0.int_1;
                                                }
                                            }

                                            Decimal num7 = 0M;
                                            if (num6 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated method
                                                List<GroundUnitFormationData> list = this.FormationDictionary.Values
                                                    .Where<GroundUnitFormationData>(class51.method_0).ToList<GroundUnitFormationData>();
                                                if (list.Count > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.auroraContactType_0 ==
                                                        AuroraContactType.STOGroundUnit)
                                                    {
                                                        // ISSUE: reference to a compiler-generated method
                                                        list = list
                                                            .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 =>
                                                                gclass103_0.ElementList).Where<GroundUnitFormationElement>(class48.method_3)
                                                            .Select<GroundUnitFormationElement, GroundUnitFormationData>(gclass39_0 =>
                                                                gclass39_0.Formation).Distinct<GroundUnitFormationData>()
                                                            .ToList<GroundUnitFormationData>();
                                                    }

                                                    if (list.Count > 0)
                                                    {
                                                        // ISSUE: object of a compiler-generated type is created
                                                        // ISSUE: variable of a compiler-generated type
                                                        GClass0.Class52 class52 = new GClass0.Class52();
                                                        long long_5_1 = 0;
                                                        foreach (GroundUnitFormationData gclass103 in list)
                                                        {
                                                            int num8 = (int)gclass103.method_34();
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (class48.gclass37_0.auroraContactType_0 ==
                                                                AuroraContactType.STOGroundUnit)
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                num8 = (int)gclass103.method_35(class48.gclass37_0
                                                                    .gclass21_1);
                                                            }

                                                            gclass103.long_0 = long_5_1 + 1L;
                                                            long_5_1 += num8;
                                                            gclass103.long_1 = long_5_1;
                                                            gclass103.decimal_18 = 1M;
                                                            if (gclass103.gclass55_0 != null)
                                                                gclass103.decimal_18 =
                                                                    gclass103.gclass55_0.method_3(CommanderBonusType.GroundCombatDefence);
                                                        }

                                                        // ISSUE: reference to a compiler-generated field
                                                        class52.long_0 = AuroraUtils.smethod_16(long_5_1);
                                                        // ISSUE: reference to a compiler-generated method
                                                        GroundUnitFormationData gclass103_1 =
                                                            list.FirstOrDefault<GroundUnitFormationData>(class52.method_0);
                                                        long long_5_2 = 0;
                                                        foreach (GroundUnitFormationElement gclass39 in gclass103_1.ElementList)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (class48.gclass37_0.auroraContactType_0 !=
                                                                AuroraContactType.STOGroundUnit ||
                                                                gclass39.DetectingRaceList.Contains(class48.gclass37_0.gclass21_1))
                                                            {
                                                                int num9 = (int)(gclass39.UnitCount *
                                                                    gclass39.GroundUnitClass.decimal_2);
                                                                gclass39.long_0 = long_5_2 + 1L;
                                                                long_5_2 += num9;
                                                                gclass39.long_1 = long_5_2;
                                                            }
                                                        }

                                                        bool flag = false;
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        if (class48.gclass37_0.gclass129_0 != null &&
                                                            class48.gclass37_0.gclass129_0.LaserWarhead > 0M)
                                                            flag = true;
                                                        // ISSUE: reference to a compiler-generated field
                                                        if (class48.gclass37_0.gclass230_0 == null && !flag)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (class48.gclass37_0.gclass129_0 != null)
                                                            {
                                                                Decimal decimal_42 = 0M;
                                                                for (int index3 = 1; index3 <= num6; ++index3)
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    Decimal decimal0 = class48.gclass37_0.decimal_0;
                                                                    int num10 = 1;
                                                                    do
                                                                    {
                                                                        Decimal decimal_6 =
                                                                            (Decimal)Math.Floor(20.0 *
                                                                                Math.Sqrt((double)decimal0));
                                                                        Decimal decimal_5 = decimal_6 / 2M;
                                                                        for (int index4 = 1; index4 <= num10; ++index4)
                                                                        {
                                                                            // ISSUE: object of a compiler-generated type is created
                                                                            // ISSUE: reference to a compiler-generated method
                                                                            GroundUnitFormationElement gclass39 =
                                                                                gclass103_1.ElementList
                                                                                    .FirstOrDefault<GroundUnitFormationElement>(
                                                                                        new GClass0.Class54()
                                                                                        {
                                                                                            long_0 = AuroraUtils
                                                                                                .smethod_16(long_5_2)
                                                                                        }.method_0);
                                                                            Decimal num11;
                                                                            Decimal num12;
                                                                            if (gclass39.FortificationLevel == 1M)
                                                                            {
                                                                                // ISSUE: reference to a compiler-generated field
                                                                                num11 = class51.gclass146_0.SystemBodyData
                                                                                        .DominantTerrain.ToHitModifier *
                                                                                    gclass39.GroundUnitClass.GroundUnitBaseTypeData
                                                                                        .decimal_3 *
                                                                                    (gclass39.Morale / 100M);
                                                                                num12 = 1M;
                                                                            }
                                                                            else
                                                                            {
                                                                                // ISSUE: reference to a compiler-generated field
                                                                                num11 = class51.gclass146_0.SystemBodyData
                                                                                        .DominantTerrain.ToHitModifier *
                                                                                    (gclass39.Morale / 100M);
                                                                                // ISSUE: reference to a compiler-generated field
                                                                                num12 = class51.gclass146_0.SystemBodyData
                                                                                        .DominantTerrain.FortificationModifier *
                                                                                    gclass39.FortificationLevel *
                                                                                    gclass103_1.decimal_18;
                                                                            }

                                                                            num7 = num11 / num12 * 10000M;
                                                                            int num13 = (int)Math.Floor(50M /
                                                                                gclass39.GroundUnitClass.decimal_2);
                                                                            if (num13 < 1)
                                                                                num13 = 1;
                                                                            if (num13 > gclass39.UnitCount - gclass39.int_2)
                                                                                num13 = gclass39.UnitCount - gclass39.int_2;
                                                                            for (int index5 = 1;
                                                                             index5 <= num13;
                                                                             ++index5)
                                                                            {
                                                                                if (!(AuroraUtils.GetRandomInteger(
                                                                                        10000) > num7))
                                                                                {
                                                                                    // ISSUE: reference to a compiler-generated field
                                                                                    // ISSUE: reference to a compiler-generated field
                                                                                    decimal_42 +=
                                                                                        gclass39.method_6(null,
                                                                                            class48.gclass37_0
                                                                                                .gclass40_0,
                                                                                            class51.gclass146_0
                                                                                                .SystemBodyData, null,
                                                                                            decimal_5, decimal_6,
                                                                                            false);
                                                                                    ++int_72_2;
                                                                                    if (decimal_42 > 0M)
                                                                                        ++int_72_1;
                                                                                }
                                                                            }
                                                                        }

                                                                        num10 *= 2;
                                                                        decimal0 /= num10;
                                                                    } while (!(decimal0 < 1M));
                                                                }

                                                                // ISSUE: reference to a compiler-generated field
                                                                if (decimal_42 > 0M &&
                                                                    class48.gclass37_0.gclass40_0 != null)
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    class48.gclass37_0.gclass40_0.method_72(
                                                                        AuroraMeasurementType.GroundForcesDestroyed,
                                                                        decimal_42);
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Decimal decimal_42 = 0M;
                                                            // ISSUE: reference to a compiler-generated field
                                                            Decimal decimal_6 =
                                                                (Decimal)Math.Floor(20.0 *
                                                                    Math.Sqrt((double)class48.gclass37_0.decimal_0));
                                                            Decimal decimal_5 = Math.Floor(decimal_6 / 2M);
                                                            for (int index = 1; index <= num6; ++index)
                                                            {
                                                                // ISSUE: object of a compiler-generated type is created
                                                                // ISSUE: variable of a compiler-generated type
                                                                GClass0.Class53 class53 = new GClass0.Class53();
                                                                // ISSUE: reference to a compiler-generated field
                                                                class53.long_0 = AuroraUtils.smethod_16(long_5_2);
                                                                Decimal num14 = 0.33M;
                                                                // ISSUE: reference to a compiler-generated field
                                                                if (class48.gclass37_0.auroraContactType_0 ==
                                                                    AuroraContactType.STOGroundUnit)
                                                                    num14 = 1M;
                                                                // ISSUE: reference to a compiler-generated method
                                                                GroundUnitFormationElement gclass39 =
                                                                    gclass103_1.ElementList.FirstOrDefault<GroundUnitFormationElement>(
                                                                        class53.method_0);
                                                                Decimal num15;
                                                                Decimal num16;
                                                                if (gclass39.FortificationLevel == 1M)
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    num15 = AuroraUtils.int_41 *
                                                                            class51.gclass146_0.SystemBodyData.DominantTerrain
                                                                                .ToHitModifier *
                                                                            gclass39.GroundUnitClass.GroundUnitBaseTypeData.decimal_3 *
                                                                            (gclass39.Morale / 100M) * 0.33M;
                                                                    num16 = 1M;
                                                                }
                                                                else
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    num15 = AuroraUtils.int_41 *
                                                                            class51.gclass146_0.SystemBodyData.DominantTerrain
                                                                                .ToHitModifier *
                                                                            (gclass39.Morale / 100M) * num14;
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    num16 = class51.gclass146_0.SystemBodyData.DominantTerrain
                                                                                .FortificationModifier * gclass39.FortificationLevel *
                                                                            gclass103_1.decimal_18;
                                                                }

                                                                num7 = num15 / num16;
                                                                // ISSUE: reference to a compiler-generated field
                                                                if (class48.gclass37_0.gclass40_0 != null)
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    num7 *= (Decimal)class48.gclass37_0.gclass40_0
                                                                        .double_0;
                                                                }

                                                                if (!(AuroraUtils.GetRandomInteger(10000) > num7))
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    decimal_42 +=
                                                                        gclass39.method_6(class48.gclass37_0.gclass39_0,
                                                                            class48.gclass37_0.gclass40_0,
                                                                            class51.gclass146_0.SystemBodyData, null,
                                                                            decimal_5, decimal_6, false);
                                                                    ++int_72_2;
                                                                    if (decimal_42 > 0M)
                                                                        ++int_72_1;
                                                                }
                                                            }

                                                            // ISSUE: reference to a compiler-generated field
                                                            if (decimal_42 > 0M &&
                                                                class48.gclass37_0.gclass40_0 != null)
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                class48.gclass37_0.gclass40_0.method_72(
                                                                    AuroraMeasurementType.GroundForcesDestroyed,
                                                                    decimal_42);
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            Decimal decimal0_1 = class48.gclass37_0.decimal_0;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass129_0 != null)
                                                decimal0_1 *= 20M;
                                            int num17 = 0;
                                            Decimal num18 = 1M;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.auroraContactType_0 == AuroraContactType.Population)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num17 = class48.gclass37_0.int_2;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.auroraContactType_0 ==
                                                    AuroraContactType.GroundUnit ||
                                                    class48.gclass37_0.auroraContactType_0 ==
                                                    AuroraContactType.STOGroundUnit)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    for (int index = 1; index <= class48.gclass37_0.int_2; ++index)
                                                    {
                                                        if (AuroraUtils.GetRandomInteger(3) == 2)
                                                            ++num17;
                                                    }

                                                    if (num17 > 0)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        num18 = num17 / (Decimal)class48.gclass37_0.int_2;
                                                    }
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            if (class51.gclass146_0.dictionary_0.Count > 0 && num17 > 0)
                                            {
                                                int num19 = 0;
                                                // ISSUE: reference to a compiler-generated field
                                                foreach (PopulationInstallation gclass158 in class51.gclass146_0.dictionary_0.Values)
                                                {
                                                    gclass158.decimal_1 = 0M;
                                                    num19 += (int)(gclass158.InstallationType.TargetSize *
                                                                   Math.Ceiling(gclass158.Amount));
                                                    gclass158.int_0 = num19;
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                List<PopulationInstallation> list = class51.gclass146_0.dictionary_0.Values
                                                    .OrderBy<PopulationInstallation, int>(gclass158_0 => gclass158_0.int_0)
                                                    .ToList<PopulationInstallation>();
                                                int int_72_3 = list.Max<PopulationInstallation>(gclass158_0 => gclass158_0.int_0);
                                                for (int index = 1; index <= num17; ++index)
                                                {
                                                    Decimal num20 = decimal0_1;
                                                    PopulationInstallation gclass158;
                                                    // ISSUE: reference to a compiler-generated field
                                                    do
                                                    {
                                                        // ISSUE: object of a compiler-generated type is created
                                                        // ISSUE: reference to a compiler-generated method
                                                        IEnumerable<PopulationInstallation> source = list.Where<PopulationInstallation>(
                                                            new GClass0.Class55()
                                                            {
                                                                int_0 = AuroraUtils.GetRandomInteger(int_72_3)
                                                            }.method_0);
                                                        // ISSUE: reference to a compiler-generated field
                                                        System.Func<PopulationInstallation, int> func =
                                                            GClass0.staticCompGen.staticCompMem__14_25;
                                                        if (func == null)
                                                            goto label_265;
                                                        goto label_408;
                                                        label_263:
                                                        System.Func<PopulationInstallation, int> keySelector;
                                                        gclass158 = source.OrderBy<PopulationInstallation, int>(keySelector)
                                                            .FirstOrDefault<PopulationInstallation>();
                                                        if (num20 >= gclass158.InstallationType.TargetSize)
                                                        {
                                                            ++gclass158.decimal_1;
                                                            num20 -= gclass158.InstallationType.TargetSize;
                                                            continue;
                                                        }

                                                        goto label_266;
                                                        label_408:
                                                        keySelector = func;
                                                        goto label_263;
                                                        label_265:
                                                        // ISSUE: reference to a compiler-generated field
                                                        GClass0.staticCompGen.staticCompMem__14_25 =
                                                            keySelector = gclass158_0 => gclass158_0.int_0;
                                                        goto label_263;
                                                    } while (class48.gclass37_0.gclass129_0 != null && !(num20 <= 0M));

                                                    continue;
                                                    label_266:
                                                    Decimal num21 = num20 / gclass158.InstallationType.TargetSize * 10000M;
                                                    if (AuroraUtils.GetRandomInteger(10000) < num21)
                                                        ++gclass158.decimal_1;
                                                }
                                            }

                                            Decimal num22;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass129_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class51.gclass146_0.SystemBodyData.DustLevel += num1;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class51.gclass146_0.SystemBodyData.RadiationLevel += class48.gclass37_0.int_2 *
                                                    class48.gclass37_0.decimal_1;
                                                num22 = num1 / 10M;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class51.gclass146_0.SystemBodyData.DustLevel += num1 / 20M;
                                                num22 = num1 / 500M;
                                            }

                                            Decimal num23 = num22 * num18;
                                            Decimal num24;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class51.gclass146_0.Population > num23)
                                            {
                                                num24 = num23;
                                                // ISSUE: reference to a compiler-generated field
                                                Decimal num25 = num24 / class51.gclass146_0.Population;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class51.gclass146_0.method_25(class51.gclass146_0.Population - num23);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                num24 = class51.gclass146_0.Population;
                                                // ISSUE: reference to a compiler-generated field
                                                class51.gclass146_0.method_25(0M);
                                            }

                                            string str4 = "";
                                            string str5 = "";
                                            if (int_72_2 > 0)
                                            {
                                                str5 =
                                                    $"{str5}    Chance to Hit: {AuroraUtils.FormatNumberToDigits(num7 / 100M, 1)}%    Ground Units Hit {AuroraUtils.smethod_37(int_72_2)}";
                                                str4 =
                                                    $"{str4}    Ground Units Hit  {AuroraUtils.smethod_37(int_72_2)}";
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.auroraContactType_0 ==
                                                    AuroraContactType.GroundUnit ||
                                                    class48.gclass37_0.auroraContactType_0 ==
                                                    AuroraContactType.STOGroundUnit)
                                                    str5 =
                                                        $"{str5}    Chance to Hit: {AuroraUtils.FormatNumberToDigits(num7 / 100M, 1)}%    No Ground Units Hit";
                                            }

                                            if (int_72_1 > 0)
                                            {
                                                str5 =
                                                    $"{str5}    Ground Units Destroyed {AuroraUtils.smethod_37(int_72_1)}";
                                                str4 =
                                                    $"{str4}    Ground Units Destroyed {AuroraUtils.smethod_37(int_72_1)}";
                                            }

                                            if (num24 > 0M)
                                            {
                                                str4 =
                                                    $"{str4}    Civilian deaths {AuroraUtils.smethod_39(num24 * 1000000M)}";
                                                str5 =
                                                    $"{str5}    Estimated Civilian deaths {AuroraUtils.FormatNumberToDigits(num24, 3)}m";
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_503(class48.gclass37_0.gclass21_1, class51.gclass146_0,
                                                    num24, 0);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            int num26 = (int)class51.gclass146_0.dictionary_0.Values.Sum<PopulationInstallation>(
                                                gclass158_0 => gclass158_0.decimal_1);
                                            if (num26 > 0)
                                            {
                                                str4 += "    Destroyed Installations:";
                                                str5 =
                                                    $"{str5}    Destroyed Installations: {AuroraUtils.smethod_39(num26)}";
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_503(class48.gclass37_0.gclass21_1, class51.gclass146_0, 0M,
                                                    num26);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            foreach (PopulationInstallation gclass158 in class51.gclass146_0.dictionary_0.Values
                                                         .Where<PopulationInstallation>(gclass158_0 => gclass158_0.decimal_1 > 0M)
                                                         .ToList<PopulationInstallation>())
                                            {
                                                Decimal num27;
                                                if (gclass158.Amount > gclass158.decimal_1)
                                                {
                                                    num27 = gclass158.decimal_1;
                                                    gclass158.Amount -= gclass158.decimal_1;
                                                }
                                                else
                                                {
                                                    num27 = gclass158.Amount;
                                                    gclass158.Amount = 0M;
                                                    if (gclass158.InstallationType.InstallationType ==
                                                        AuroraInstallationType.NavalHeadquarters)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated method
                                                        foreach (NavalAdminCommand gclass83 in this.NavalAdminCommands.Values
                                                                     .Where<NavalAdminCommand>(class51.func_0 ??
                                                                         (class51.func_0 = class51.method_1))
                                                                     .ToList<NavalAdminCommand>())
                                                            gclass83.method_3();
                                                    }
                                                    else if (gclass158.InstallationType.InstallationType ==
                                                             AuroraInstallationType.SectorCommand)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated method
                                                        foreach (GClass62 gclass62_0 in class51.gclass146_0.Race
                                                                     .dictionary_2.Values
                                                                     .Where<GClass62>(class51.func_1 ??
                                                                         (class51.func_1 = class51.method_2))
                                                                     .ToList<GClass62>())
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            class51.gclass146_0.Race.method_124(gclass62_0);
                                                        }
                                                    }
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                if (gclass158.InstallationType.InstallationType ==
                                                    AuroraInstallationType.GFCC &&
                                                    class51.gclass146_0.dictionary_3.Count > gclass158.Amount)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    int num28 = class51.gclass146_0.dictionary_3.Count -
                                                                (int)Math.Floor(gclass158.Amount);
                                                    // ISSUE: reference to a compiler-generated field
                                                    foreach (GClass106 gclass106 in class51.gclass146_0.dictionary_3
                                                                 .Values.OrderBy<GClass106, Decimal>(gclass106_0 =>
                                                                     gclass106_0.decimal_1).ToList<GClass106>())
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_155,
                                                            $"Due to the destruction of a ground unit training facility {class51.gclass146_0.PopName}, the training of {gclass106.string_0} has been abandoned.",
                                                            class51.gclass146_0.Race,
                                                            class51.gclass146_0.gclass202_0.ActualSystem,
                                                            class51.gclass146_0.method_87(),
                                                            class51.gclass146_0.method_88(),
                                                            AuroraEventCategory.PopSummary);
                                                        // ISSUE: reference to a compiler-generated field
                                                        class51.gclass146_0.dictionary_3.Remove(gclass106.int_0);
                                                        --num28;
                                                        if (num28 == 0)
                                                            break;
                                                    }
                                                }

                                                str4 = $"{str4}    {gclass158.InstallationType.Name} {num27.ToString()}";
                                                if (gclass158.Amount == 0M)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class51.gclass146_0.dictionary_0.Remove(gclass158.InstallationType
                                                        .InstallationType);
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null &&
                                                class48.gclass37_0.gclass40_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                string string_0 =
                                                    $"{class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0} with {class48.gclass37_0.gclass230_0.Name}.    Shots {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str5}";
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass40_0.gclass22_0.Size <= 10M)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_215, string_0,
                                                        class48.gclass37_0.gclass21_1,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.System
                                                            .ActualSystem,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                        AuroraEventCategory.CombatResults);
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_202, string_0,
                                                        class48.gclass37_0.gclass21_1,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.System
                                                            .ActualSystem,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                        class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                        AuroraEventCategory.CombatResults);
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null &&
                                                class48.gclass37_0.gclass39_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_204,
                                                    $"{class48.gclass37_0.gclass39_0.Formation.Name} attacked {class48.gclass37_0.string_0} with {class48.gclass37_0.gclass230_0.Name}.    Shots {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str5}",
                                                    class48.gclass37_0.gclass21_1,
                                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.gclass202_0
                                                        .ActualSystem,
                                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.method_87(),
                                                    class48.gclass37_0.gclass39_0.Formation.PopulationData.method_88(),
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass129_0 != null &&
                                                    class48.gclass37_0.gclass40_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    string string_0 =
                                                        $"{class48.gclass37_0.int_1.ToString()}x {class48.gclass37_0.gclass129_0.Name} from {class48.gclass37_0.gclass40_0.method_187()} attacked {class48.gclass37_0.string_0}.    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str5}";
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.gclass40_0.gclass22_0.Size <= 10M)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_216, string_0,
                                                            class48.gclass37_0.gclass21_1,
                                                            class48.gclass37_0.gclass40_0.gclass85_0.System
                                                                .ActualSystem,
                                                            class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                            class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                            AuroraEventCategory.CombatResults);
                                                    }
                                                    else
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_203, string_0,
                                                            class48.gclass37_0.gclass21_1,
                                                            class48.gclass37_0.gclass40_0.gclass85_0.System
                                                                .ActualSystem,
                                                            class48.gclass37_0.gclass40_0.gclass85_0.XCoord,
                                                            class48.gclass37_0.gclass40_0.gclass85_0.YCoord,
                                                            AuroraEventCategory.CombatResults);
                                                    }
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.gclass129_0 != null)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_205,
                                                            $"{class48.gclass37_0.int_1.ToString()}x {class48.gclass37_0.gclass129_0.Name} attacked {class48.gclass37_0.string_0}.    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str5}",
                                                            class48.gclass37_0.gclass21_1,
                                                            class51.gclass146_0.gclass202_0.ActualSystem,
                                                            class51.gclass146_0.method_87(),
                                                            class51.gclass146_0.method_88(),
                                                            AuroraEventCategory.CombatResults);
                                                    }
                                                }
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class48.gclass37_0.gclass230_0 != null &&
                                                class48.gclass37_0.gclass21_0 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                GClass117 gclass117 =
                                                    class48.gclass37_0.gclass21_0.method_267(class48.gclass37_0
                                                        .gclass40_0);
                                                string string_0;
                                                if (gclass117 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    string_0 =
                                                        $"{class51.gclass146_0.PopName} attacked by {gclass117.method_11()} using energy weapons.    Range {AuroraUtils.smethod_39((Decimal)class48.gclass37_0.double_1)} km    Hits {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str4}";
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    string_0 =
                                                        $"{class51.gclass146_0.PopName} attacked by unknown ship using energy weapons.   Hits {class48.gclass37_0.int_1.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str4}";
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_207, string_0,
                                                    class51.gclass146_0.Race,
                                                    class51.gclass146_0.gclass202_0.ActualSystem,
                                                    class51.gclass146_0.method_87(), class51.gclass146_0.method_88(),
                                                    AuroraEventCategory.CombatResults);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (class48.gclass37_0.gclass129_0 != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_208,
                                                        $"{class51.gclass146_0.PopName} attacked by missiles.   Hits {class48.gclass37_0.int_2.ToString()}    Damage per Hit {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.decimal_0, 3)}{str4}",
                                                        class51.gclass146_0.Race,
                                                        class51.gclass146_0.gclass202_0.ActualSystem,
                                                        class51.gclass146_0.method_87(),
                                                        class51.gclass146_0.method_88(),
                                                        AuroraEventCategory.CombatResults);
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class48.gclass37_0.bool_4)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_212,
                                                            $"{class51.gclass146_0.PopName} suffered collateral damage.   Total Damage {AuroraUtils.FormatNumberToDigits(class48.gclass37_0.int_2 * class48.gclass37_0.decimal_0, 3)}{str4}",
                                                            class51.gclass146_0.Race,
                                                            class51.gclass146_0.gclass202_0.ActualSystem,
                                                            class51.gclass146_0.method_87(),
                                                            class51.gclass146_0.method_88(),
                                                            AuroraEventCategory.CombatResults);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                            continue;
                                    }
                                }
                            }
                        }
                    }
                }

                if (gclass202 != null)
                    gclass202.DangerRating += (int)num1;
            }

            this.method_12();
            List<ShipData> list3 = this.Ships.Values.Where<ShipData>(gclass40_0 =>
                gclass40_0.dictionary_6.Count > 0 || gclass40_0.int_0 > 0 || gclass40_0.decimal_0 > 0M ||
                gclass40_0.int_2 != 0).ToList<ShipData>();
            list3.AddRange(this.list_23);
            foreach (ShipData gclass40_1 in list3)
            {
                if (gclass40_1.gclass21_0.NPR)
                    gclass40_1.gclass85_0.NPRSomething.method_3();
                string str6 = gclass40_1.method_187() + " Damage Report:";
                string str7 = "";
                if (gclass40_1.int_3 > 0)
                {
                    str6 = $"{str6}    Total Hits {gclass40_1.int_3.ToString()}";
                    str7 = $"{str7}    Total Hits {gclass40_1.int_3.ToString()}";
                }

                if (gclass40_1.int_4 > 0)
                {
                    str6 = $"{str6}    Shield Hits {gclass40_1.int_4.ToString()}";
                    str7 = $"{str7}    Shield Hits {gclass40_1.int_4.ToString()}";
                }

                if (gclass40_1.int_5 > 0)
                {
                    str6 = $"{str6}    Armour Hits {gclass40_1.int_5.ToString()}";
                    str7 = $"{str7}    Armour Hits {gclass40_1.int_5.ToString()}";
                }

                if (gclass40_1.int_6 > 0)
                {
                    str6 = $"{str6}    Penetrating Hits {gclass40_1.int_6.ToString()}";
                    str7 = $"{str7}    Penetrating Hits {gclass40_1.int_6.ToString()}";
                }

                if (gclass40_1.int_7 > 0)
                {
                    str6 = $"{str6}    Decoy Hits {gclass40_1.int_7.ToString()}";
                    str7 = $"{str7}    Decoy Hits {gclass40_1.int_7.ToString()}";
                }

                foreach (GameRace gclass21_0 in gclass40_1.list_20)
                {
                    GClass117 gclass117 = gclass21_0.method_267(gclass40_1);
                    if (gclass117 != null)
                    {
                        string string_0 = $"{gclass117.method_11()} Attack Report:{str7}";
                        if (gclass40_1.bool_9)
                            string_0 += "   Target Destroyed";
                        this.gclass92_0.method_2(EventType.const_21, string_0, gclass21_0,
                            gclass40_1.gclass85_0.System.ActualSystem, gclass40_1.gclass85_0.XCoord,
                            gclass40_1.gclass85_0.YCoord, AuroraEventCategory.Combat);
                    }
                }

                string string_0_1;
                if (!gclass40_1.bool_9)
                {
                    if (gclass40_1.decimal_0 > 0M)
                        str6 = $"{str6}    Shield Damage {AuroraUtils.FormatNumberToDigits(gclass40_1.decimal_0, 2)}";
                    if (gclass40_1.int_0 > 0)
                        str6 = $"{str6}    Armour Damage {gclass40_1.int_0.ToString()}";
                    int num29 = gclass40_1.dictionary_6.Values.Sum<GClass178>(gclass178_0 => gclass178_0.int_0) +
                                gclass40_1.int_2;
                    if (num29 > 0)
                        str6 = $"{str6}    Components Hit {num29.ToString()}";
                    if (gclass40_1.dictionary_6.Count > 0)
                    {
                        if (gclass40_1.dictionary_6.Count > 0)
                            str6 += "     Components Destroyed:";
                        foreach (GClass178 gclass178 in gclass40_1.dictionary_6.Values)
                            str6 = $"{str6}    {gclass178.int_0.ToString()}x {gclass178.gclass230_0.Name}";
                        if (gclass40_1.bool_1)
                        {
                            Decimal decimal_73 = gclass40_1.method_10();
                            if (decimal_73 > 0M)
                                str6 = $"{str6}    {AuroraUtils.smethod_39(decimal_73)} Colonists";
                        }

                        if (gclass40_1.bool_4)
                        {
                            Decimal decimal_73 = gclass40_1.method_9();
                            if (decimal_73 > 0M)
                                str6 = $"{str6}    {AuroraUtils.smethod_39(decimal_73)} Shield Capacity";
                        }

                        if (gclass40_1.bool_0)
                        {
                            Decimal decimal_73 = gclass40_1.method_8();
                            if (decimal_73 > 0M)
                                str6 = $"{str6}    {AuroraUtils.smethod_39(decimal_73)} Fuel";
                        }

                        if (gclass40_1.bool_2 && !bool_25)
                        {
                            string str8 = gclass40_1.method_7();
                            if (str8 != "")
                                str6 = $"{str6}    {str8}";
                        }

                        if (gclass40_1.bool_3)
                        {
                            string str9 = gclass40_1.method_5();
                            if (str9 != "")
                                str6 = $"{str6}    {str9}";
                        }
                    }

                    if (gclass40_1.int_1 > 0)
                        str6 = $"{str6}   Crew Casualties {gclass40_1.int_1.ToString()}";
                    if (gclass40_1.gclass22_0.ShieldStrength > 0)
                    {
                        if (gclass40_1.decimal_3 > gclass40_1.gclass22_0.ShieldStrength)
                            gclass40_1.decimal_3 = gclass40_1.gclass22_0.ShieldStrength;
                        Decimal num30 = gclass40_1.decimal_3 / gclass40_1.gclass22_0.ShieldStrength;
                        str6 = $"{str6}    Current Shields {AuroraUtils.smethod_39(num30 * 100M)}%";
                    }

                    int num31 = gclass40_1.gclass22_0.ArmourThickness * gclass40_1.gclass22_0.ArmourWidth;
                    int num32 = gclass40_1.dictionary_5.Sum<KeyValuePair<int, int>>(keyValuePair_0 =>
                        keyValuePair_0.Value);
                    Decimal num33 = (num31 - num32) / (Decimal)num31;
                    string_0_1 =
                        $"{$"{str6}    Current Armour {AuroraUtils.smethod_39(num33 * 100M)}%"}    Maximum Speed {AuroraUtils.smethod_39(gclass40_1.method_171(true))} km/s";
                    if (gclass40_1.bool_5)
                        string_0_1 += "  (Detached from parent fleet due to damage)";
                }
                else
                    string_0_1 = str6 + "   Ship Destroyed";

                this.gclass92_0.method_2(EventType.const_21, string_0_1, gclass40_1.gclass21_0,
                    gclass40_1.gclass85_0.System.ActualSystem, gclass40_1.gclass85_0.XCoord,
                    gclass40_1.gclass85_0.YCoord, AuroraEventCategory.Ship);
            }

            this.list_23.Clear();
            this.method_430();
            foreach (MissileSalvo gclass132_0 in this.MissileSalvoes.Values
                         .Where<MissileSalvo>(gclass132_0 => gclass132_0.RemainingDecoys.Count == 0).ToList<MissileSalvo>())
                gclass132_0.Race.method_130(gclass132_0);
            this.method_13();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 311);
        }
    }

    public void method_15(List<ShipData> list_33)
    {
        try
        {
            foreach (ShipData gclass40 in list_33)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class56 class56 = new GClass0.Class56()
                {
                    gclass40_0 = gclass40
                };
                // ISSUE: reference to a compiler-generated field
                class56.gclass40_0.bool_21 = false;
                // ISSUE: reference to a compiler-generated field
                List<FireControlAssignment> list1 = class56.gclass40_0.list_4.Where<FireControlAssignment>(gclass36_0 =>
                    gclass36_0.FCComponent.gclass231_0.ComponentTypeID == AuroraComponentType.BeamFireControl &&
                    !gclass36_0.HasFiredThisPhase && gclass36_0.IsOpeningFire && gclass36_0.TargetID > 0).ToList<FireControlAssignment>();
                if (list1.Count != 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class56.gclass40_0.int_17 == 1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        List<ShipData> list2 = class56.gclass40_0.gclass85_0.method_176()
                            .Where<ShipData>(class56.method_0).ToList<ShipData>();
                        if (list2.Count > 0 && list2.Max<ShipData>(gclass40_0 => gclass40_0.int_13) > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass92_0.method_2(EventType.const_72,
                                class56.gclass40_0.ShipName +
                                " is waiting for other ships in the same fleet to confirm their readiness before firing.",
                                class56.gclass40_0.gclass21_0, class56.gclass40_0.gclass85_0.System.ActualSystem,
                                class56.gclass40_0.gclass85_0.XCoord, class56.gclass40_0.gclass85_0.YCoord,
                                AuroraEventCategory.Ship);
                            continue;
                        }
                    }

                    double num1 = 0.0;
                    double double_8 = 0.0;
                    double double_9 = 0.0;
                    double double_6 = 1.0;
                    double double_5 = 0.0;
                    string string_10 = "Target";
                    GameRace gclass21_3 = null;
                    foreach (FireControlAssignment gclass36 in list1)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class57 class57 = new GClass0.Class57();
                        // ISSUE: reference to a compiler-generated field
                        class57.gclass36_0 = gclass36;
                        // ISSUE: reference to a compiler-generated field
                        int decimal3 = (int)class57.gclass36_0.FCComponent.decimal_3;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        List<WeaponFireControlAssignment> list3 = class56.gclass40_0.list_2.Where<WeaponFireControlAssignment>(class57.method_0)
                            .OrderByDescending<WeaponFireControlAssignment, int>(gclass31_0 => gclass31_0.WeaponComponent.method_18())
                            .ToList<WeaponFireControlAssignment>();
                        if (list3.Count != 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            List<WeaponFireControlAssignment> gclass31List = class56.gclass40_0.method_20(list3);
                            if (gclass31List.Count != 0)
                            {
                                int num2 = gclass31List[0].WeaponComponent.method_18();
                                if (decimal3 < num2)
                                    ;
                                Decimal decimal_42 = 1M;
                                // ISSUE: reference to a compiler-generated field
                                if (class57.gclass36_0.TargetContactType == AuroraContactType.Ship)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    ShipData gclass40_1 = class56.gclass40_0.method_17(class57.gclass36_0.TargetID);
                                    if (gclass40_1 != null)
                                    {
                                        int num3 = (int)gclass40_1.method_156(AuroraJammerType.FireControl);
                                        if (num3 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class56.gclass40_0.gclass21_0.method_35(gclass40_1,
                                                AuroraJammerType.FireControl, num3);
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        double_6 = class57.gclass36_0.method_6(class56.gclass40_0, num3,
                                            class57.gclass36_0.FCComponent);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = this.GetDistanceBetween(class56.gclass40_0.gclass85_0.XCoord,
                                            class56.gclass40_0.gclass85_0.YCoord, gclass40_1.gclass85_0.XCoord,
                                            gclass40_1.gclass85_0.YCoord);
                                        if (gclass40_1.genum29_0 == GEnum29.const_0)
                                            double_5 = gclass40_1.int_35;
                                        gclass21_3 = gclass40_1.gclass21_0;
                                        double_8 = gclass40_1.gclass85_0.XCoord;
                                        double_9 = gclass40_1.gclass85_0.YCoord;
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class56.gclass40_0.gclass21_0.dictionary_12.ContainsKey(class57.gclass36_0
                                                .TargetID))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            string_10 = class56.gclass40_0.gclass21_0
                                                .dictionary_12[class57.gclass36_0.TargetID].method_11();
                                        }
                                    }
                                    else
                                        continue;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class57.gclass36_0.TargetContactType == AuroraContactType.Salvo)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        MissileSalvo gclass132_0 = class56.gclass40_0.method_14(class57.gclass36_0.TargetID);
                                        if (gclass132_0 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            num1 = this.GetDistanceBetween(class56.gclass40_0.gclass85_0.XCoord,
                                                class56.gclass40_0.gclass85_0.YCoord, gclass132_0.double_0,
                                                gclass132_0.double_1);
                                            double_5 = gclass132_0.double_9;
                                            string_10 = "Salvo ID" + gclass132_0.int_1.ToString();
                                            gclass21_3 = gclass132_0.Race;
                                            double_8 = gclass132_0.double_0;
                                            double_9 = gclass132_0.double_1;
                                            // ISSUE: reference to a compiler-generated field
                                            decimal_42 = class56.gclass40_0.gclass21_0.method_107(gclass132_0);
                                        }
                                        else
                                            continue;
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class57.gclass36_0.TargetContactType == AuroraContactType.Population ||
                                            class57.gclass36_0.TargetContactType == AuroraContactType.Shipyard ||
                                            class57.gclass36_0.TargetContactType == AuroraContactType.GroundUnit ||
                                            class57.gclass36_0.TargetContactType == AuroraContactType.STOGroundUnit)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            PopulationData gclass146_1 = class56.gclass40_0.method_15(
                                                class57.gclass36_0.TargetID, class57.gclass36_0.TargetContactType);
                                            if (gclass146_1 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                num1 = this.GetDistanceBetween(class56.gclass40_0.gclass85_0.XCoord,
                                                    class56.gclass40_0.gclass85_0.YCoord, gclass146_1.method_87(),
                                                    gclass146_1.method_88());
                                                // ISSUE: reference to a compiler-generated field
                                                string_10 = class56.gclass40_0.gclass21_0.method_42(gclass146_1);
                                                double_5 = 0.0;
                                                gclass21_3 = gclass146_1.Race;
                                                double_8 = gclass146_1.method_87();
                                                double_9 = gclass146_1.method_88();
                                                // ISSUE: reference to a compiler-generated field
                                                if (class57.gclass36_0.TargetContactType ==
                                                    AuroraContactType.Shipyard)
                                                    string_10 += " Shipyard";
                                                // ISSUE: reference to a compiler-generated field
                                                if (class57.gclass36_0.TargetContactType ==
                                                    AuroraContactType.GroundUnit)
                                                    string_10 += " Ground Forces";
                                                // ISSUE: reference to a compiler-generated field
                                                if (class57.gclass36_0.TargetContactType ==
                                                    AuroraContactType.STOGroundUnit)
                                                    string_10 += " STO Ground Forces";
                                            }
                                            else
                                                continue;
                                        }
                                    }
                                }

                                foreach (WeaponFireControlAssignment gclass31_0 in gclass31List)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (!gclass31_0.WeaponComponent.bool_10 ||
                                        class57.gclass36_0.TargetContactType == AuroraContactType.Ship ||
                                        class57.gclass36_0.TargetContactType == AuroraContactType.Salvo)
                                    {
                                        int num4 = gclass31_0.WeaponComponent.method_18();
                                        if (decimal3 < num4)
                                            num4 = decimal3;
                                        if (num1 <= num4)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            double num5 = 100.0 * class56.gclass40_0.method_106(gclass31_0,
                                                class57.gclass36_0, num1, (int)double_5, double_6, decimal_42);
                                            if (num5 <= 0.0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class56.gclass40_0.bool_21 = true;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class56.gclass40_0.gclass21_0.SpecialNPRID !=
                                                    SpecialNPRIDs.const_0 || this.NoOverhauls != 0 ||
                                                    !class56.gclass40_0.method_92(gclass31_0))
                                                {
                                                    WeaponComponentRechargeStatus gclass27 = new WeaponComponentRechargeStatus(gclass31_0.WeaponComponent,
                                                        gclass31_0.WeaponNum, gclass31_0.WeaponComponent.decimal_0);
                                                    // ISSUE: reference to a compiler-generated field
                                                    class56.gclass40_0.list_7.Add(gclass27);
                                                    // ISSUE: reference to a compiler-generated field
                                                    class57.gclass36_0.HasFiredThisPhase = true;
                                                    int num6 = 0;
                                                    for (int index = 1; index <= gclass31_0.WeaponComponent.int_7; ++index)
                                                    {
                                                        if (AuroraUtils.GetRandomInteger(10000) <= num5)
                                                            ++num6;
                                                    }

                                                    int decimal_13 = gclass31_0.WeaponComponent.method_5((int)num1);
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.method_1(class56.gclass40_0.gclass21_0, class56.gclass40_0,
                                                        gclass31_0.WeaponComponent, null, null,
                                                        class57.gclass36_0.TargetContactType,
                                                        class57.gclass36_0.TargetID, gclass31_0.WeaponComponent.int_7, num6, 0,
                                                        0, 0, decimal_13, 0M, num1, num5 / 100.0, string_10, gclass21_3,
                                                        false, false, false, false, false, GEnum62.const_0);
                                                    if (num6 > 0)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.method_19(AuroraContactType.EWImpact, decimal_13, num6,
                                                            class56.gclass40_0.gclass85_0.System.ActualSystem,
                                                            double_8, double_9, false);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class56.gclass40_0.bool_6 = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class56.gclass40_0.bool_21)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        this.gclass92_0.method_2(EventType.const_72,
                            class56.gclass40_0.ShipName +
                            " held fire with one or more weapons that were in range as the chance to hit was zero",
                            class56.gclass40_0.gclass21_0, class56.gclass40_0.gclass85_0.System.ActualSystem,
                            class56.gclass40_0.gclass85_0.XCoord, class56.gclass40_0.gclass85_0.YCoord,
                            AuroraEventCategory.Ship);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 312);
        }
    }

    public void method_16(List<ShipData> list_33)
    {
        try
        {
            foreach (ShipData gclass40_1 in list_33)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class58 class58 = new GClass0.Class58();
                // ISSUE: reference to a compiler-generated field
                class58.gclass40_0 = gclass40_1;
                // ISSUE: reference to a compiler-generated field
                List<FireControlAssignment> list1 = class58.gclass40_0.list_4.Where<FireControlAssignment>(gclass36_0 =>
                    gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                    AuroraComponentType.MissileFireControl && !gclass36_0.HasFiredThisPhase && gclass36_0.IsOpeningFire &&
                    gclass36_0.TargetID > 0).ToList<FireControlAssignment>();
                if (list1.Count != 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class58.gclass40_0.int_17 == 1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        List<ShipData> list2 = class58.gclass40_0.gclass85_0.method_176()
                            .Where<ShipData>(class58.method_0)
                            .Where<ShipData>(gclass40_0 => gclass40_0.method_48()).ToList<ShipData>();
                        if (list2.Count > 0)
                        {
                            if (list2.Max<ShipData>(gclass40_0 => gclass40_0.int_13) > 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.gclass92_0.method_2(EventType.const_72,
                                    class58.gclass40_0.ShipName +
                                    " is waiting for other ships in the same fleet to confirm their readiness before firing.",
                                    class58.gclass40_0.gclass21_0,
                                    class58.gclass40_0.gclass85_0.System.ActualSystem,
                                    class58.gclass40_0.gclass85_0.XCoord, class58.gclass40_0.gclass85_0.YCoord,
                                    AuroraEventCategory.Ship);
                                continue;
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class58.gclass40_0.gclass21_0.NPR && (class58.gclass40_0.gclass85_0.int_11 == 1 ||
                                                                        list2.Where<ShipData>(gclass40_0 =>
                                                                                !gclass40_0.bool_16)
                                                                            .SelectMany<ShipData,
                                                                                WeaponComponentRechargeStatus>(gclass40_0 =>
                                                                                gclass40_0.list_7)
                                                                            .Count<WeaponComponentRechargeStatus>(gclass27_0 =>
                                                                                gclass27_0.WeaponComponent.gclass231_0
                                                                                    .ComponentTypeID ==
                                                                                AuroraComponentType.MissileLauncher) >
                                                                        0))
                                continue;
                        }
                    }

                    double double_8 = 0.0;
                    double double_6 = 0.0;
                    string string_10 = "Target";
                    GameRace gclass21_3 = null;
                    foreach (FireControlAssignment gclass36 in list1)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class59 class59 = new GClass0.Class59();
                        // ISSUE: reference to a compiler-generated field
                        class59.gclass36_0 = gclass36;
                        ShipData gclass40_2 = null;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        List<WeaponFireControlAssignment> list3 = class58.gclass40_0.list_2.Where<WeaponFireControlAssignment>(class59.method_0)
                            .ToList<WeaponFireControlAssignment>();
                        if (list3.Count != 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            List<WeaponFireControlAssignment> gclass31List = class58.gclass40_0.method_20(list3);
                            if (gclass31List.Count != 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class59.gclass36_0.TargetContactType == AuroraContactType.Ship)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    gclass40_2 = class58.gclass40_0.method_17(class59.gclass36_0.TargetID);
                                    if (gclass40_2 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        double num = class59.gclass36_0.method_4(class58.gclass40_0, gclass40_2,
                                            class59.gclass36_0.FCComponent);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        double_8 = this.GetDistanceBetween(class58.gclass40_0.gclass85_0.XCoord,
                                            class58.gclass40_0.gclass85_0.YCoord, gclass40_2.gclass85_0.XCoord,
                                            gclass40_2.gclass85_0.YCoord);
                                        if (double_8 > num)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class58.gclass40_0.bool_6 = true;
                                            continue;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class58.gclass40_0.gclass21_0.dictionary_12.ContainsKey(class59.gclass36_0
                                                .TargetID))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            string_10 = class58.gclass40_0.gclass21_0
                                                .dictionary_12[class59.gclass36_0.TargetID].method_11();
                                        }

                                        double_6 = gclass40_2.gclass85_0.Speed;
                                        gclass21_3 = gclass40_2.gclass21_0;
                                    }
                                    else
                                        continue;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class59.gclass36_0.TargetContactType == AuroraContactType.Salvo)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        MissileSalvo gclass132 = class58.gclass40_0.method_14(class59.gclass36_0.TargetID);
                                        if (gclass132 != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            double num = class59.gclass36_0.method_5(class58.gclass40_0,
                                                gclass132.RaceMissile, class59.gclass36_0.FCComponent);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            double_8 = this.GetDistanceBetween(class58.gclass40_0.gclass85_0.XCoord,
                                                class58.gclass40_0.gclass85_0.YCoord, gclass132.double_0,
                                                gclass132.double_1);
                                            if (double_8 > num)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class58.gclass40_0.bool_6 = true;
                                                continue;
                                            }

                                            string_10 = "Salvo ID" + gclass132.int_1.ToString();
                                            double_6 = gclass132.double_9;
                                            gclass21_3 = gclass132.Race;
                                        }
                                        else
                                            continue;
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class59.gclass36_0.TargetContactType != AuroraContactType.Population &&
                                            class59.gclass36_0.TargetContactType != AuroraContactType.Shipyard &&
                                            class59.gclass36_0.TargetContactType != AuroraContactType.GroundUnit &&
                                            class59.gclass36_0.TargetContactType != AuroraContactType.STOGroundUnit)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class59.gclass36_0.TargetContactType == AuroraContactType.WayPoint)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                Waypoint gclass214 =
                                                    class58.gclass40_0.method_16(class59.gclass36_0.TargetID);
                                                if (gclass214 != null)
                                                {
                                                    string_10 = gclass214.method_2(true);
                                                    double_6 = 0.0;
                                                }
                                                else
                                                    continue;
                                            }
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            PopulationData gclass146_1 = class58.gclass40_0.method_15(
                                                class59.gclass36_0.TargetID, class59.gclass36_0.TargetContactType);
                                            if (gclass146_1 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                double_8 = this.GetDistanceBetween(class58.gclass40_0.gclass85_0.XCoord,
                                                    class58.gclass40_0.gclass85_0.YCoord, gclass146_1.method_87(),
                                                    gclass146_1.method_88());
                                                // ISSUE: reference to a compiler-generated field
                                                if (double_8 > class59.gclass36_0.FCComponent.double_0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class58.gclass40_0.bool_6 = true;
                                                    continue;
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                string_10 = class58.gclass40_0.gclass21_0.method_42(gclass146_1);
                                                double_6 = 0.0;
                                                gclass21_3 = gclass146_1.Race;
                                            }
                                            else
                                                continue;
                                        }
                                    }
                                }

                                foreach (WeaponFireControlAssignment gclass31 in gclass31List)
                                {
                                    // ISSUE: object of a compiler-generated type is created
                                    // ISSUE: variable of a compiler-generated type
                                    GClass0.Class60 class60 = new GClass0.Class60();
                                    // ISSUE: reference to a compiler-generated field
                                    class60.gclass31_0 = gclass31;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    MissileAssignment gclass30_0 =
                                        class58.gclass40_0.FiredMissiles.FirstOrDefault<MissileAssignment>(class60.method_0);
                                    if (gclass30_0 != null)
                                    {
                                        if (double_8 > gclass30_0.Missile.CombinatedMaxRange)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class58.gclass40_0.bool_6 = true;
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (!class58.gclass40_0.method_103(gclass30_0.Missile))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_12,
                                                    $"{class58.gclass40_0.ShipName} cannot lauch a {gclass30_0.Missile.Name} as no missiles of the required type are available in the ship's magazines.",
                                                    class58.gclass40_0.gclass21_0,
                                                    class58.gclass40_0.gclass85_0.System.ActualSystem,
                                                    class58.gclass40_0.gclass85_0.XCoord,
                                                    class58.gclass40_0.gclass85_0.YCoord, AuroraEventCategory.Ship);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (gclass30_0.Missile.Size >
                                                    class60.gclass31_0.WeaponComponent.decimal_3)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    this.gclass92_0.method_2(EventType.const_194,
                                                        $"{class58.gclass40_0.ShipName} cannot lauch a {gclass30_0.Missile.Name} as the ordnance is too large for the launcher.",
                                                        class58.gclass40_0.gclass21_0,
                                                        class58.gclass40_0.gclass85_0.System.ActualSystem,
                                                        class58.gclass40_0.gclass85_0.XCoord,
                                                        class58.gclass40_0.gclass85_0.YCoord,
                                                        AuroraEventCategory.Ship);
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class58.gclass40_0.gclass21_0.SpecialNPRID !=
                                                        SpecialNPRIDs.const_0 || this.NoOverhauls != 0 ||
                                                        !class58.gclass40_0.method_92(class60.gclass31_0))
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        WeaponComponentRechargeStatus gclass27 = new WeaponComponentRechargeStatus(class60.gclass31_0.WeaponComponent,
                                                            class60.gclass31_0.WeaponNum,
                                                            class60.gclass31_0.WeaponComponent.int_11);
                                                        // ISSUE: reference to a compiler-generated field
                                                        class58.gclass40_0.list_7.Add(gclass27);
                                                        // ISSUE: reference to a compiler-generated field
                                                        class59.gclass36_0.HasFiredThisPhase = true;
                                                        // ISSUE: reference to a compiler-generated field
                                                        class58.gclass40_0.bool_16 = true;
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        MissileSalvo gclass132 =
                                                            class58.gclass40_0.method_101(class59.gclass36_0,
                                                                gclass30_0, class59.gclass36_0.TargetID,
                                                                class59.gclass36_0.TargetContactType);
                                                        double double_7 = 1.0;
                                                        if (gclass40_2 != null)
                                                            double_7 = gclass132.RaceMissile.method_3(gclass40_2);
                                                        // ISSUE: reference to a compiler-generated field
                                                        double double_9 = gclass132.RaceMissile.method_0((int)double_6,
                                                            double_7, class58.gclass40_0.double_0);
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.method_1(class58.gclass40_0.gclass21_0, class58.gclass40_0,
                                                            class60.gclass31_0.WeaponComponent, gclass30_0.Missile,
                                                            null, class59.gclass36_0.TargetContactType,
                                                            class59.gclass36_0.TargetID,
                                                            class60.gclass31_0.WeaponComponent.int_7, 0, 0, 0, 0, 0M, 0M,
                                                            double_8, double_9, string_10, gclass21_3, true, false,
                                                            false, false, false, GEnum62.const_0);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 313);
        }
    }

    public void method_17(List<StarSystem> list_33, List<Contact> list_34, List<ShipData> list_35)
    {
        try
        {
            foreach (StarSystem gclass200 in list_33)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class61 class61 = new GClass0.Class61();
                // ISSUE: reference to a compiler-generated field
                class61.gclass0_0 = this;
                // ISSUE: reference to a compiler-generated field
                class61.gclass200_0 = gclass200;
                // ISSUE: reference to a compiler-generated method
                foreach (GameRace gclass21 in list_34.Where<Contact>(class61.method_0)
                             .Where<Contact>(gclass65_0 =>
                                 gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                                 gclass65_0.ContactType == AuroraContactType.Salvo &&
                                 gclass65_0.method_5() < AuroraContactStatus.Neutral &&
                                 gclass65_0.LastUpdate == this.GameTime)
                             .Select<Contact, GameRace>(gclass65_0 => gclass65_0.DetectRace)
                             .Distinct<GameRace>().ToList<GameRace>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.Class62 class62 = new GClass0.Class62();
                    // ISSUE: reference to a compiler-generated field
                    class62.class61_0 = class61;
                    // ISSUE: reference to a compiler-generated field
                    class62.gclass21_0 = gclass21;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    List<MissileSalvo> list1 = list_34
                        .Where<Contact>(class62.class61_0.func_0 ??
                                         (class62.class61_0.func_0 = class62.class61_0.method_1))
                        .Where<Contact>(class62.method_0)
                        .Select<Contact, MissileSalvo>(gclass65_0 => gclass65_0.TargetSalvo).ToList<MissileSalvo>();
                    List<GClass29> source = new List<GClass29>();
                    foreach (MissileSalvo gclass132 in list1)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class63 class63 = new GClass0.Class63();
                        // ISSUE: reference to a compiler-generated field
                        class63.gclass132_0 = gclass132;
                        // ISSUE: reference to a compiler-generated method
                        int num = this.MissileSalvoes.Values.Count<MissileSalvo>(class63.method_0);
                        // ISSUE: reference to a compiler-generated field
                        class63.gclass132_0.bool_3 = false;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class63.gclass132_0.double_11 = class63.gclass132_0.RemainingDecoys.Count * 3 - num;
                        // ISSUE: reference to a compiler-generated field
                        if (class62.gclass21_0.NPR)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass0.Class64 class64 = new GClass0.Class64();
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class64.gclass221_0 = class63.gclass132_0.method_10();
                            // ISSUE: reference to a compiler-generated method
                            GClass29 gclass29_1 = source.FirstOrDefault<GClass29>(class64.method_0);
                            if (gclass29_1 != null)
                            {
                                // ISSUE: reference to a compiler-generated field
                                gclass29_1.list_0.Add(class63.gclass132_0);
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                GClass29 gclass29_2 = new GClass29(this, class64.gclass221_0, class62.gclass21_0,
                                    class62.class61_0.gclass200_0, class63.gclass132_0);
                                source.Add(gclass29_2);
                            }
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class62.gclass21_0.NPR)
                    {
                        foreach (GClass29 gclass29 in source)
                            gclass29.method_0();
                        list1 = list1.Where<MissileSalvo>(gclass132_0 => !gclass132_0.bool_3).ToList<MissileSalvo>();
                        if (list1.Count == 0)
                            continue;
                    }

                    // ISSUE: reference to a compiler-generated method
                    foreach (ShipData gclass40 in list_35.Where<ShipData>(class62.method_1)
                                 .ToList<ShipData>())
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class65 class65 = new GClass0.Class65();
                        // ISSUE: reference to a compiler-generated field
                        class65.class62_0 = class62;
                        // ISSUE: reference to a compiler-generated field
                        class65.gclass40_0 = gclass40;
                        // ISSUE: reference to a compiler-generated field
                        foreach (FireControlAssignment gclass36 in class65.gclass40_0.list_4.Where<FireControlAssignment>(gclass36_0 =>
                                         gclass36_0.FCComponent.gclass231_0.ComponentTypeID ==
                                         AuroraComponentType.MissileFireControl &&
                                         gclass36_0.PointDefenceMode >
                                         AuroraPointDefenceMode.PointBlankDefensiveFireSelf && !gclass36_0.HasFiredThisPhase)
                                     .ToList<FireControlAssignment>())
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass0.Class66 class66 = new GClass0.Class66();
                            // ISSUE: reference to a compiler-generated field
                            class66.gclass36_0 = gclass36;
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            List<WeaponFireControlAssignment> list2 = class65.gclass40_0.list_2.Where<WeaponFireControlAssignment>(class66.method_0)
                                .ToList<WeaponFireControlAssignment>();
                            if (list2.Count != 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                List<WeaponFireControlAssignment> gclass31List = class65.gclass40_0.method_20(list2);
                                if (gclass31List.Count != 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated method
                                    foreach (MissileSalvo gclass132_0 in list1
                                                 .OrderByDescending<MissileSalvo, double>(gclass132_0 =>
                                                     gclass132_0.double_11)
                                                 .ThenBy<MissileSalvo, double>(class65.func_0 ??
                                                                            (class65.func_0 = class65.method_0))
                                                 .ToList<MissileSalvo>())
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        int num1 = class66.gclass36_0.method_7(class65.gclass40_0.gclass21_0,
                                            gclass132_0);
                                        if (num1 != 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            double double_8 = this.GetDistanceBetween(class65.gclass40_0.gclass85_0.XCoord,
                                                class65.gclass40_0.gclass85_0.YCoord, gclass132_0.double_0,
                                                gclass132_0.double_1);
                                            // ISSUE: reference to a compiler-generated field
                                            if (double_8 >= class66.gclass36_0.MinimumAMMRange)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                double num2 = class66.gclass36_0.method_5(class65.gclass40_0,
                                                    gclass132_0.RaceMissile, class66.gclass36_0.FCComponent);
                                                if (double_8 <= num2)
                                                {
                                                    foreach (WeaponFireControlAssignment gclass31 in gclass31List)
                                                    {
                                                        // ISSUE: object of a compiler-generated type is created
                                                        // ISSUE: variable of a compiler-generated type
                                                        GClass0.Class67 class67 = new GClass0.Class67();
                                                        // ISSUE: reference to a compiler-generated field
                                                        class67.gclass31_0 = gclass31;
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated method
                                                        MissileAssignment gclass30_0 =
                                                            class65.gclass40_0.FiredMissiles.FirstOrDefault<MissileAssignment>(
                                                                class67.method_0);
                                                        if (gclass30_0 != null &&
                                                            double_8 <= gclass30_0.Missile.CombinatedMaxRange)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (!class65.gclass40_0.method_103(gclass30_0.Missile))
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                this.gclass92_0.method_2(EventType.const_12,
                                                                    $"{class65.gclass40_0.ShipName} cannot lauch a {gclass30_0.Missile.Name} as no missiles of the required type are available in the ship's magazines.",
                                                                    class65.gclass40_0.gclass21_0,
                                                                    class65.gclass40_0.gclass85_0.System
                                                                        .ActualSystem,
                                                                    class65.gclass40_0.gclass85_0.XCoord,
                                                                    class65.gclass40_0.gclass85_0.YCoord,
                                                                    AuroraEventCategory.Ship);
                                                            }
                                                            else
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                if (gclass30_0.Missile.Size >
                                                                    class67.gclass31_0.WeaponComponent.decimal_3)
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    this.gclass92_0.method_2(EventType.const_194,
                                                                        $"{class65.gclass40_0.ShipName} cannot lauch a {gclass30_0.Missile.Name} as the ordnance is too large for the launcher.",
                                                                        class65.gclass40_0.gclass21_0,
                                                                        class65.gclass40_0.gclass85_0.System
                                                                            .ActualSystem,
                                                                        class65.gclass40_0.gclass85_0.XCoord,
                                                                        class65.gclass40_0.gclass85_0.YCoord,
                                                                        AuroraEventCategory.Ship);
                                                                }
                                                                else
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    if (class65.gclass40_0.gclass21_0.SpecialNPRID !=
                                                                        SpecialNPRIDs.const_0 || this.NoOverhauls != 0 ||
                                                                        !class65.gclass40_0.method_92(
                                                                            class67.gclass31_0))
                                                                    {
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        double double_9 =
                                                                            gclass30_0.Missile.method_0(
                                                                                gclass132_0.double_9, 1.0,
                                                                                class65.gclass40_0.double_0);
                                                                        if (double_9 <= 0.0)
                                                                        {
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            this.gclass92_0.method_2(EventType.const_11,
                                                                                $"{class65.gclass40_0.ShipName} did not launch {gclass30_0.Missile.Name} as there was no chance to hit the target",
                                                                                class65.gclass40_0.gclass21_0,
                                                                                class65.gclass40_0.gclass85_0
                                                                                    .System.ActualSystem,
                                                                                class65.gclass40_0.gclass85_0.XCoord,
                                                                                class65.gclass40_0.gclass85_0.YCoord,
                                                                                AuroraEventCategory.Ship);
                                                                        }
                                                                        else
                                                                        {
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            WeaponComponentRechargeStatus gclass27 =
                                                                                new WeaponComponentRechargeStatus(
                                                                                    class67.gclass31_0.WeaponComponent,
                                                                                    class67.gclass31_0.WeaponNum,
                                                                                    class67.gclass31_0.WeaponComponent
                                                                                        .int_11);
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            class65.gclass40_0.list_7.Add(gclass27);
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            class66.gclass36_0.HasFiredThisPhase = true;
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            class65.gclass40_0.method_101(
                                                                                class66.gclass36_0, gclass30_0,
                                                                                gclass132_0.int_1,
                                                                                AuroraContactType.Salvo);
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            // ISSUE: reference to a compiler-generated field
                                                                            this.method_1(class65.gclass40_0.gclass21_0,
                                                                                class65.gclass40_0,
                                                                                class67.gclass31_0.WeaponComponent,
                                                                                gclass30_0.Missile, null,
                                                                                class66.gclass36_0.TargetContactType,
                                                                                class66.gclass36_0.TargetID,
                                                                                class67.gclass31_0.WeaponComponent.int_7, 0,
                                                                                0, 0, 0, 0M, 0M, double_8, double_9,
                                                                                "Salvo ID " +
                                                                                gclass132_0.int_1.ToString(),
                                                                                gclass132_0.Race, true, false,
                                                                                false, false, false, GEnum62.const_0);
                                                                            --num1;
                                                                            if (num1 == 0)
                                                                                break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }

                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class66.gclass36_0.HasFiredThisPhase)
                                                        break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 314);
        }
    }

    public void method_18(List<StarSystem> list_33, List<ShipData> list_34)
    {
        try
        {
            foreach (StarSystem gclass200 in list_33)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                List<MissileSalvo> list = this.Contacts.Values.Where<Contact>(new GClass0.Class68()
                    {
                        gclass200_0 = gclass200
                    }.method_0).Where<Contact>(gclass65_0 =>
                        gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                        gclass65_0.ContactType == AuroraContactType.Salvo &&
                        gclass65_0.method_5() < AuroraContactStatus.Neutral && gclass65_0.LastUpdate == this.GameTime)
                    .Select<Contact, MissileSalvo>(gclass65_0 => gclass65_0.TargetSalvo).ToList<MissileSalvo>();
                this.method_43(list, true);
                this.method_44(list);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 315);
        }
    }

    public void method_19(
        AuroraContactType auroraContactType_0,
        Decimal decimal_13,
        int int_136,
        StarSystem gclass200_0,
        double double_8,
        double double_9,
        bool bool_25)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class69 class69 = new GClass0.Class69();
        // ISSUE: reference to a compiler-generated field
        class69.gclass200_0 = gclass200_0;
        // ISSUE: reference to a compiler-generated field
        class69.auroraContactType_0 = auroraContactType_0;
        // ISSUE: reference to a compiler-generated field
        class69.decimal_0 = decimal_13;
        // ISSUE: reference to a compiler-generated field
        class69.double_0 = double_8;
        // ISSUE: reference to a compiler-generated field
        class69.double_1 = double_9;
        try
        {
            if (int_136 == 0)
                return;
            // ISSUE: reference to a compiler-generated method
            foreach (GameRace gclass21 in this.GameRaces.Values.Where<GameRace>(class69.method_0)
                         .ToList<GameRace>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class70 class70 = new GClass0.Class70();
                // ISSUE: reference to a compiler-generated field
                class70.class69_0 = class69;
                // ISSUE: reference to a compiler-generated field
                class70.gclass21_0 = gclass21;
                // ISSUE: reference to a compiler-generated method
                Contact gclass65_1 = this.Contacts.Values.FirstOrDefault<Contact>(class70.method_0);
                if (gclass65_1 != null)
                {
                    gclass65_1.ContactNumber += int_136;
                }
                else
                {
                    Contact gclass65_2 = new Contact(this);
                    gclass65_2.UniqueID = this.method_26(GEnum0.const_36);
                    gclass65_2.ContactRace = null;
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.DetectRace = class70.gclass21_0;
                    gclass65_2.ContactID = 1;
                    gclass65_2.ContactMethod = ContactDetectMethod.const_5;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.ContactType = class70.class69_0.auroraContactType_0;
                    gclass65_2.CreationTime = this.GameTime;
                    gclass65_2.LastUpdate = this.GameTime;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.System = class70.class69_0.gclass200_0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.Xcor = class70.class69_0.double_0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.Ycor = class70.class69_0.double_1;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.LastXcor = class70.class69_0.double_0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.LastYcor = class70.class69_0.double_1;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.IncrementStartX = class70.class69_0.double_0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.IncrementStartY = class70.class69_0.double_1;
                    gclass65_2.Speed = 0;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass65_2.ContactStrength = class70.class69_0.decimal_0;
                    gclass65_2.Resolution = 0;
                    gclass65_2.ContactNumber = int_136;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class70.class69_0.auroraContactType_0 == AuroraContactType.Explosion)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        gclass65_2.ContactName = !bool_25
                            ? "Nuclear Detonation: Strength " + AuroraUtils.FormatNumberToDigits(class70.class69_0.decimal_0, 3)
                            : "Surface Nuclear Detonation: Strength " +
                              AuroraUtils.FormatNumberToDigits(class70.class69_0.decimal_0, 3);
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class70.class69_0.auroraContactType_0 == AuroraContactType.SecondaryPower)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            gclass65_2.ContactName = "Secondary Power System Explosion: Strength " +
                                                  AuroraUtils.smethod_39(class70.class69_0.decimal_0);
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class70.class69_0.auroraContactType_0 == AuroraContactType.SecondaryMg)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                gclass65_2.ContactName = "Secondary Magazine Explosion: Strength " +
                                                      AuroraUtils.FormatNumberToDigits(class70.class69_0.decimal_0, 3);
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class70.class69_0.auroraContactType_0 == AuroraContactType.EWImpact)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    gclass65_2.ContactName = !bool_25
                                        ? "Energy Weapon Impact: Strength " +
                                          AuroraUtils.FormatNumberToDigits(class70.class69_0.decimal_0, 3)
                                        : "Surface Energy Weapon Impact: Strength " +
                                          AuroraUtils.FormatNumberToDigits(class70.class69_0.decimal_0, 3);
                                }
                            }
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class70.gclass21_0.NPR && !class70.gclass21_0.method_91(gclass65_2.Xcor,
                            gclass65_2.Ycor, gclass65_2.System, AuroraUtils.double_11))
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class70.gclass21_0.method_188(gclass65_2.System, null, null, WayPointType.POI,
                            class70.class69_0.double_0, class70.class69_0.double_1, "", 0);
                    }

                    this.Contacts.Add(gclass65_2.UniqueID, gclass65_2);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 316);
        }
    }

    public void method_20(int int_136)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class72 class72 = new GClass0.Class72();
        // ISSUE: reference to a compiler-generated field
        class72.int_0 = int_136;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass0.Class73 class73 = new GClass0.Class73();
            foreach (FleetData gclass85 in this.FleetDictionary.Values)
                gclass85.int_11 = 0;
            List<ShipData> list1 = this.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.list_7.Count > 0).ToList<ShipData>();
            List<ShipData> list2 = this.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.list_8.Count > 0).ToList<ShipData>();
            List<GroundUnitFormationElement> list3 = this.FormationDictionary.Values
                .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                .Where<GroundUnitFormationElement>(gclass39_0 => gclass39_0.list_0.Count > 0).ToList<GroundUnitFormationElement>();
            if (list1.Count == 0 && list3.Count == 0 && list2.Count == 0)
                return;
            foreach (ShipData gclass40 in list2)
                gclass40.list_8.Clear();
            foreach (GroundUnitFormationElement gclass39 in list3)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                gclass39.list_0 = gclass39.list_0.Where<int>(class72.func_0 ?? (class72.func_0 = class72.method_0))
                    .Select<int, int>(class72.func_1 ?? (class72.func_1 = class72.method_1)).ToList<int>();
            }

            if (list1.Count == 0)
                return;
            List<PopulationData> list4 = this.Populations.Values.Where<PopulationData>(gclass146_0 =>
                gclass146_0.method_62(AuroraProductionCategory.OrdnanceTransferPoint) > 0M).ToList<PopulationData>();
            List<FleetData> list5 = this.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.method_159(GEnum118.const_63))
                .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).ToList<FleetData>();
            foreach (ShipData gclass40 in list1)
            {
                // ISSUE: reference to a compiler-generated field
                gclass40.method_43(class72.int_0, list4, list5);
            }

            // ISSUE: reference to a compiler-generated field
            class73.list_1 = this.FleetDictionary.Values.Where<FleetData>(gclass85_0 => gclass85_0.int_11 == 1)
                .ToList<FleetData>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class73.list_0 = class73.list_1.Select<FleetData, RacialSystemSurvey>(gclass85_0 => gclass85_0.System)
                .Distinct<RacialSystemSurvey>().ToList<RacialSystemSurvey>();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (FleetData gclass85_1 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass21_0.NPR)
                         .Where<ShipData>(class73.method_0)
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass22_0.AutomatedClassDesign.MissileDesignType == MissileDesignType.const_3)
                         .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0)
                         .Where<FleetData>(class73.method_1).ToList<FleetData>())
            {
                // ISSUE: reference to a compiler-generated field
                foreach (FleetData gclass85_2 in class73.list_1)
                {
                    if (gclass85_1.XCoord == gclass85_2.XCoord && gclass85_1.YCoord == gclass85_2.YCoord &&
                        gclass85_1.System == gclass85_2.System &&
                        gclass85_1.Race == gclass85_2.Race)
                        gclass85_1.int_11 = 1;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 317);
        }
    }

    public void method_21(int int_136)
    {
        try
        {
            List<ShipData> list = this.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.bool_10 && gclass40_0.genum29_0 == GEnum29.const_0)
                .Where<ShipData>(gclass40_0 =>
                    gclass40_0.decimal_3 < gclass40_0.method_157(AuroraComponentType.Shields, false))
                .ToList<ShipData>();
            if (list.Count == 0)
                return;
            foreach (ShipData gclass40 in list)
                gclass40.method_40(int_136);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 318);
        }
    }

    public void method_22(int int_136)
    {
        try
        {
            List<FleetData> list = this.FleetDictionary.Values.Where<FleetData>(gclass85_0 => gclass85_0.EscapeTimeRemaining > 0.0)
                .ToList<FleetData>();
            if (list.Count == 0)
                return;
            foreach (FleetData gclass85 in list)
            {
                gclass85.EscapeTimeRemaining -= int_136;
                if (gclass85.EscapeTimeRemaining < 0.0)
                    gclass85.EscapeTimeRemaining = 0.0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3706);
        }
    }

    public void method_23(int int_136)
    {
        try
        {
            List<ShipData> list = this.Ships.Values.Where<ShipData>(gclass40_0 =>
                gclass40_0.dictionary_5.Count > 0 && gclass40_0.gclass21_0.SpecialNPRID == SpecialNPRIDs.StarSwarm &&
                gclass40_0.gclass22_0.OtherRaceClassID == 0).ToList<ShipData>();
            if (list.Count == 0)
                return;
            foreach (ShipData gclass40 in list)
                gclass40.method_41(int_136);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 319);
        }
    }
    
        public void method_38()
    {
        try
        {
            foreach (Contact gclass65 in this.Contacts.Values.Where<Contact>(gclass65_0 =>
                         gclass65_0.ContactType == AuroraContactType.Explosion ||
                         gclass65_0.ContactType == AuroraContactType.EWImpact ||
                         gclass65_0.ContactType == AuroraContactType.SecondaryMg ||
                         gclass65_0.ContactType == AuroraContactType.SecondaryPower).ToList<Contact>())
                this.Contacts.Remove(gclass65.UniqueID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3561);
        }
    }

    public void method_39(Decimal decimal_13, int int_136)
    {
        try
        {
            this.method_419(this.SubPulseLength);
            foreach (FleetData gclass85 in this.Ships.Values.Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass22_0.FuelTanker == 1 &&
                             gclass40_0.auroraRefuelStatus_0 != AuroraRefuelStatus.None &&
                             gclass40_0.decimal_14 > gclass40_0.gclass22_0.MinimumFuel &&
                             gclass40_0.gclass85_0.MoveOrderDictionary.Count == 0)
                         .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                         .ToList<FleetData>())
                gclass85.method_109(this.SubPulseLength);
            foreach (FleetData gclass85 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass40_0 != null && gclass40_0.decimal_14 < gclass40_0.gclass22_0.FuelCapacity)
                         .Distinct<ShipData>()
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0.MoveOrderDictionary.Count == 0)
                         .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).ToList<FleetData>())
                gclass85.method_110(this.SubPulseLength);
            foreach (FleetData gclass85 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass40_0 != null && gclass40_0.decimal_4 < gclass40_0.gclass22_0.MaintSupplies)
                         .Distinct<ShipData>()
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass85_0.MoveOrderDictionary.Count == 0)
                         .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).ToList<FleetData>())
                gclass85.method_111(this.SubPulseLength);
            foreach (FleetData gclass85 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass22_0.SupplyShip == 1 &&
                             gclass40_0.auroraResupplyStatus_0 != AuroraResupplyStatus.None &&
                             gclass40_0.gclass85_0.MoveOrderDictionary.Count == 0)
                         .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                         .ToList<FleetData>())
                gclass85.method_112(this.SubPulseLength);
            foreach (FleetData gclass85 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.gclass22_0.Collier == 1 &&
                             gclass40_0.auroraOrdnanceTransferStatus_0 != AuroraOrdnanceTransferStatus.None &&
                             gclass40_0.gclass85_0.MoveOrderDictionary.Count == 0)
                         .Select<ShipData, FleetData>(gclass40_0 => gclass40_0.gclass85_0).Distinct<FleetData>()
                         .ToList<FleetData>())
                gclass85.method_121(this.SubPulseLength);
            this.method_40(this.SubPulseLength);
            this.list_22.Clear();
            this.method_47(decimal_13);
            this.method_48(decimal_13);
            this.method_42(true, int_136, decimal_13);
            if (this.list_22.Count > 0)
            {
                this.method_8(int_136);
                this.method_14(false);
            }

            foreach (FleetData gclass85 in this.FleetDictionary.Values)
            {
                gclass85.bool_18 = false;
                gclass85.bool_21 = false;
            }

            foreach (ShipData gclass40 in this.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.decimal_9 < 1M).ToList<ShipData>())
            {
                gclass40.decimal_9 += this.SubPulseLength / AuroraUtils.decimal_31;
                if (gclass40.decimal_9 > 1M)
                    gclass40.decimal_9 = 1M;
            }

            foreach (MissileSalvo gclass132 in this.MissileSalvoes.Values)
                gclass132.bool_0 = false;
            this.method_41();
            foreach (GClass193 gclass193 in this.dictionary_31.Values
                         .Where<GClass193>(gclass193_0 => gclass193_0.gclass40_0 != null).ToList<GClass193>())
            {
                gclass193.double_0 = gclass193.gclass40_0.gclass85_0.XCoord;
                gclass193.double_1 = gclass193.gclass40_0.gclass85_0.YCoord;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1410);
        }
    }

    

    public void method_41()
    {
        try
        {
            foreach (FCTMassDriverPacket126 gclass126 in this.MassDriverPacketsDictionary.Values)
            {
                if (gclass126.gclass146_0 != null && this.Populations.ContainsKey(gclass126.gclass146_0.PopulationID))
                {
                    GClass221 gclass221_1 = this.method_52(DestinationType.const_1, gclass126.gclass146_0.SystemBodyData.SystemBodyID,
                        gclass126.gclass146_0.gclass202_0.ActualSystem, null);
                    if (gclass221_1.double_0 == 0.0 && gclass221_1.double_1 == 0.0)
                    {
                        this.gclass92_0.method_2(EventType.const_24,
                            "Destination of mass driver packet cannot be found", gclass126.Race,
                            gclass126.System, gclass126.XCoord, gclass126.YCoord, AuroraEventCategory.Fleet);
                    }
                    else
                    {
                        double num = this.GetDistanceBetween(gclass126.XCoord, gclass126.YCoord, gclass221_1.double_0,
                            gclass221_1.double_1);
                        double double_12 = (double)(gclass126.Speed * this.SubPulseLength);
                        if (double_12 >= num)
                        {
                            gclass126.gclass146_0.CurrentMinerals.AddMineralsFrom(gclass126.MineralsValue);
                            gclass126.gclass146_0.gclass123_3.AddMineralsFrom(gclass126.MineralsValue);
                            if (!gclass126.gclass146_0.Race.NPR)
                                gclass126.MineralsValue.method_24(gclass126.gclass146_0, MineralUsage.const_13);
                            gclass126.bool_0 = true;
                        }
                        else
                        {
                            GClass221 gclass221_2 = this.method_525(gclass126.XCoord, gclass126.YCoord,
                                gclass221_1.double_0, gclass221_1.double_1, double_12);
                            gclass126.XCoord = gclass221_2.double_0;
                            gclass126.YCoord = gclass221_2.double_1;
                        }
                    }
                }
                else
                    gclass126.bool_0 = true;
            }

            foreach (FCTMassDriverPacket126 gclass126 in this.MassDriverPacketsDictionary.Values.Where<FCTMassDriverPacket126>(gclass126_0 => gclass126_0.bool_0)
                         .ToList<FCTMassDriverPacket126>())
                this.MassDriverPacketsDictionary.Remove(gclass126.PacketID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1412);
        }
    }



    public void method_43(List<MissileSalvo> list_33, bool bool_25)
    {
        var cbool_0 = bool_25;
        try
        {
            if (list_33.Count == list_33.Count<MissileSalvo>(gclass132_0 => gclass132_0.gclass132_0 != null))
                return;
            List<Contact> gclass65List = new List<Contact>();
            List<ShipData> gclass40List1 = new List<ShipData>();
            // ISSUE: reference to a compiler-generated field
            var clist_1 = new List<GameRace>();
            // ISSUE: reference to a compiler-generated field
            var clist_0 = new List<StarSystem>();
            try
            {
                foreach (MissileSalvo gclass132_1 in list_33)
                {
                    gclass132_1.int_4 = 10;
                    gclass132_1.gclass21_1 = null;
                    gclass132_1.dictionary_1.Clear();
                    gclass132_1.list_0.Clear();
                    gclass132_1.dictionary_0.Clear();
                    if (gclass132_1.gclass40_1 != null)
                    {
                        gclass132_1.int_4 = gclass132_1.gclass40_1.gclass22_0.PDProtectionPriority;
                        gclass132_1.gclass21_1 = gclass132_1.gclass40_1.gclass21_0;
                    }
                    else if (gclass132_1.gclass146_0 != null)
                    {
                        gclass132_1.int_4 = gclass132_1.gclass146_0.Importance;
                        gclass132_1.gclass21_1 = gclass132_1.gclass146_0.Race;
                    }

                    foreach (KeyValuePair<int, int> keyValuePair in gclass132_1.RemainingDecoys)
                    {
                        GClass131 gclass131 = new GClass131(this, gclass132_1, keyValuePair.Key);
                        gclass132_1.dictionary_0.Add(keyValuePair.Key, gclass131);
                    }
                }
            }
            catch (Exception ex)
            {
                AuroraUtils.ShowExceptionPopup(ex, 3692);
                return;
            }

            List<ShipData> gclass40List2 = new List<ShipData>();
            List<GameRace> gclass21List1 = new List<GameRace>();
            List<GameRace> gclass21List2 = new List<GameRace>();
            List<ShipData> list1;
            List<Contact> list2;
            try
            {
                foreach (ShipData gclass40 in list_33
                             .Where<MissileSalvo>(gclass132_0 => gclass132_0.gclass40_1 != null)
                             .Select<MissileSalvo, ShipData>(gclass132_0 => gclass132_0.gclass40_1)
                             .Distinct<ShipData>().ToList<ShipData>())
                    gclass40.method_104();
                List<GameRace> list3 = list_33.Where<MissileSalvo>(gclass132_0 => gclass132_0.gclass21_1 != null)
                    .Select<MissileSalvo, GameRace>(gclass132_0 => gclass132_0.gclass21_1)
                    .Distinct<GameRace>().ToList<GameRace>();
                if (list3.Count == 0)
                    return;
                foreach (GameRace gclass21 in list3)
                    gclass21.list_21 = gclass21.PerceivedAliens.Values
                        .Where<AlienRaceInfo>(
                            gclass110_0 => gclass110_0.ContactStatus == AuroraContactStatus.Allied)
                        .Select<AlienRaceInfo, GameRace>(gclass110_0 => gclass110_0.ActualAlienRace)
                        .ToList<GameRace>();
                List<GameRace> list4 = list3
                    .SelectMany<GameRace, GameRace>(gclass21_0 => gclass21_0.list_21)
                    .ToList<GameRace>();
                // ISSUE: reference to a compiler-generated field
                clist_1 = list3.Concat<GameRace>(list4).Distinct<GameRace>().ToList<GameRace>();
                // ISSUE: reference to a compiler-generated field
                if (clist_1.Count == 0)
                    return;
                // ISSUE: reference to a compiler-generated field
                clist_0 = list_33.Select<MissileSalvo, StarSystem>(gclass132_0 => gclass132_0.System)
                    .Distinct<StarSystem>().ToList<StarSystem>();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                list1 = this.Ships.Values
                    .Where<ShipData>(gclass40_0 =>
                        gclass40_0.gclass40_0 == null && gclass40_0.int_15 == 0 && gclass40_0.list_4.Count > 0)
                    .Where<ShipData>(gc40 => clist_0.Contains(gc40.gclass85_0.System.ActualSystem))
                    .Where<ShipData>(gc40 => clist_1.Contains(gc40.gclass21_0))
                    .Where<ShipData>(c40 => c40.method_19(cbool_0)).ToList<ShipData>();
                if (list1.Count == 0)
                    return;
                foreach (ShipData gclass40 in list1)
                    gclass40.method_104();
                // ISSUE: reference to a compiler-generated field
                clist_1 = list1.Select<ShipData, GameRace>(gclass40_0 => gclass40_0.gclass21_0)
                    .Distinct<GameRace>().ToList<GameRace>();
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                list2 = this.Contacts.Values
                    .Where<Contact>(gclass65_0 =>
                        gclass65_0.TargetSalvo != null && gclass65_0.ContactMethod == ContactDetectMethod.const_0)
                    .Where<Contact>(gc65 => clist_0.Contains(gc65.System))
                    .Where<Contact>(gc65 => clist_1.Contains(gc65.DetectRace)).ToList<Contact>();
                if (list2.Count == 0)
                    return;
            }
            catch (Exception ex)
            {
                AuroraUtils.ShowExceptionPopup(ex, 3693);
                return;
            }

            List<FireControlAssignment> gclass36List1 = new List<FireControlAssignment>();
            List<FireControlAssignment> gclass36List2;
            try
            {
                // ISSUE: reference to a compiler-generated field
                foreach (GameRace gclass21 in clist_1)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.Class5 class5 = new GClass0.Class5();
                    // ISSUE: reference to a compiler-generated field
                    class5.gclass21_0 = gclass21;
                    foreach (MissileSalvo gclass132 in list_33)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class6 class6 = new GClass0.Class6();
                        // ISSUE: reference to a compiler-generated field
                        class6.class5_0 = class5;
                        // ISSUE: reference to a compiler-generated field
                        class6.gclass132_0 = gclass132;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        Decimal num = class6.class5_0.gclass21_0.method_107(class6.gclass132_0);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class6.gclass132_0.dictionary_1.Add(class6.class5_0.gclass21_0, num);
                        // ISSUE: reference to a compiler-generated method
                        if (list2.FirstOrDefault<Contact>(class6.method_0) != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class6.gclass132_0.list_0.Add(class6.class5_0.gclass21_0);
                        }
                    }
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                gclass36List2 = cbool_0
                    ? list1.SelectMany<ShipData, FireControlAssignment>(gclass40_0 => gclass40_0.list_4)
                        .Where<
                            FireControlAssignment>(gclass36_0 =>
                            gclass36_0.PointDefenceMode == AuroraPointDefenceMode.AreaDefence)
                        .OrderBy<FireControlAssignment,
                            AuroraPointDefencePriority>(gclass36_0 => gclass36_0.PointDefencePriority)
                        .ToList<FireControlAssignment>()
                    : list1.SelectMany<ShipData, FireControlAssignment>(gclass40_0 => gclass40_0.list_4).Where<FireControlAssignment>(
                            gclass36_0 =>
                                gclass36_0.PointDefenceMode == AuroraPointDefenceMode.RangedDefensiveFire ||
                                gclass36_0.PointDefenceMode == AuroraPointDefenceMode.PointBlankDefensiveFire ||
                                gclass36_0.PointDefenceMode ==
                                AuroraPointDefenceMode.PointBlankDefensiveFireSelf)
                        .OrderBy<FireControlAssignment, AuroraPointDefencePriority>(
                            gclass36_0 => gclass36_0.PointDefencePriority).ToList<FireControlAssignment>();
            }
            catch (Exception ex)
            {
                AuroraUtils.ShowExceptionPopup(ex, 3694);
                return;
            }

            foreach (FireControlAssignment gclass36 in gclass36List2)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class7 class7 = new GClass0.Class7();
                // ISSUE: reference to a compiler-generated field
                class7.gclass36_0 = gclass36;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                List<WeaponFireControlAssignment> list5 = class7.gclass36_0.Ship.list_2.Where<WeaponFireControlAssignment>(class7.method_0)
                    .ToList<WeaponFireControlAssignment>();
                // ISSUE: reference to a compiler-generated field
                List<WeaponFireControlAssignment> source1 = class7.gclass36_0.Ship.method_20(list5);
                if (source1.Count != 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    class7.gclass36_0.int_2 = 0;
                    foreach (WeaponFireControlAssignment gclass31 in source1)
                    {
                        gclass31.bool_0 = false;
                        gclass31.int_2 = gclass31.WeaponComponent.int_7;
                        gclass31.int_3 = gclass31.WeaponComponent.method_4();
                    }

                    // ISSUE: reference to a compiler-generated method
                    List<MissileSalvo> list6 = list_33.Where<MissileSalvo>(class7.method_1).ToList<MissileSalvo>();
                    if (list6.Count != 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class7.gclass36_0.PointDefenceMode ==
                            AuroraPointDefenceMode.PointBlankDefensiveFireSelf)
                        {
                            // ISSUE: reference to a compiler-generated method
                            list6 = list6.Where<MissileSalvo>(class7.method_2).ToList<MissileSalvo>();
                            if (list6.Count == 0)
                                continue;
                        }

                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class8 class8;
                        bool flag;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        do
                        {
                            // ISSUE: object of a compiler-generated type is created
                            class8 = new GClass0.Class8();
                            // ISSUE: reference to a compiler-generated field
                            class8.class7_0 = class7;
                            flag = false;
                            List<WeaponFireControlAssignment> source2 = source1;
                            // ISSUE: reference to a compiler-generated field
                            System.Func<WeaponFireControlAssignment, bool> func = GClass0.staticCompGen.staticCompMem__100_27;
                            if (func == null)
                                goto label_92;
                            goto label_134;
                            label_64:
                            System.Func<WeaponFireControlAssignment, bool> predicate;
                            source1 = source2.Where<WeaponFireControlAssignment>(predicate)
                                .OrderBy<WeaponFireControlAssignment, int>(gclass31_0 => gclass31_0.int_3).ToList<WeaponFireControlAssignment>();
                            if (source1.Count != 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                class8.int_0 = source1.Max<WeaponFireControlAssignment>(gclass31_0 => gclass31_0.int_3);
                                // ISSUE: reference to a compiler-generated method
                                list6 = list6.Where<MissileSalvo>(class8.method_0).ToList<MissileSalvo>();
                                if (list6.Count != 0)
                                {
                                    foreach (WeaponFireControlAssignment gclass31_0 in source1)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated method
                                        foreach (GClass131 gclass131 in list6
                                                     .SelectMany<MissileSalvo,
                                                         GClass131>(gclass132_0 => gclass132_0.dictionary_0.Values)
                                                     .Where<GClass131>(class8.class7_0.func_0 ??
                                                                       (class8.class7_0.func_0 =
                                                                           class8.class7_0.method_3))
                                                     .OrderBy<GClass131, int>(gclass131_0 => gclass131_0.list_0.Count)
                                                     .ThenBy<GClass131, double>(class8.class7_0.func_1 ??
                                                         (class8.class7_0.func_1 = class8.class7_0.method_4))
                                                     .ThenBy<GClass131, int>(gclass131_0 =>
                                                         gclass131_0.gclass132_0.int_4)
                                                     .ThenByDescending<GClass131, Decimal>(gclass131_0 =>
                                                         gclass131_0.gclass132_0.RaceMissile.Size)
                                                     .ToList<GClass131>())
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if ((AuroraPointDefenceConcentration)gclass131.list_0.Count <
                                                class8.class7_0.gclass36_0.PointDefenceConcentration)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                gclass131.gclass132_0.double_10 = this.GetDistanceBetween(
                                                    class8.class7_0.gclass36_0.Ship.gclass85_0.XCoord,
                                                    class8.class7_0.gclass36_0.Ship.gclass85_0.YCoord,
                                                    gclass131.gclass132_0.double_0, gclass131.gclass132_0.double_1);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if ((class8.class7_0.gclass36_0.PointDefenceMode !=
                                                     AuroraPointDefenceMode.PointBlankDefensiveFire &&
                                                     class8.class7_0.gclass36_0.PointDefenceMode !=
                                                     AuroraPointDefenceMode.PointBlankDefensiveFireSelf ||
                                                     gclass131.gclass132_0.double_10 <= AuroraUtils.int_8) &&
                                                    gclass31_0.int_3 >= gclass131.gclass132_0.double_10)
                                                {
                                                    if (gclass131.gclass132_0.double_10 < AuroraUtils.int_8)
                                                        gclass131.gclass132_0.double_10 = AuroraUtils.int_8;
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    double num = 100.0 *
                                                                 class8.class7_0.gclass36_0.Ship.method_106(
                                                                     gclass31_0, class8.class7_0.gclass36_0,
                                                                     gclass131.gclass132_0.double_10,
                                                                     gclass131.gclass132_0.double_9, 1.0,
                                                                     gclass131.gclass132_0.dictionary_1[
                                                                         class8.class7_0.gclass36_0.Ship
                                                                             .gclass21_0]);
                                                    if (num > 0.0)
                                                    {
                                                        if (gclass31_0.WeaponComponent.int_7 == 1 ||
                                                            gclass31_0.WeaponComponent.int_7 > 1 && gclass31_0.int_2 ==
                                                            gclass31_0.WeaponComponent.int_7)
                                                        {
                                                            WeaponComponentRechargeStatus gclass27 = new WeaponComponentRechargeStatus(gclass31_0.WeaponComponent,
                                                                gclass31_0.WeaponNum, gclass31_0.WeaponComponent.decimal_0);
                                                            gclass31_0.Ship.list_7.Add(gclass27);
                                                            if (gclass31_0.Ship.gclass21_0.SpecialNPRID ==
                                                                SpecialNPRIDs.const_0 && this.NoOverhauls == 0 &&
                                                                gclass31_0.Ship.method_92(gclass31_0))
                                                                gclass31_0.int_2 = 0;
                                                        }

                                                        if (gclass31_0.int_2 > 0)
                                                        {
                                                            gclass131.list_0.Add(gclass31_0);
                                                            gclass31_0.double_0 = gclass131.gclass132_0.double_10;
                                                            gclass31_0.double_1 = num;
                                                            --gclass31_0.int_2;
                                                            flag = true;
                                                        }

                                                        if (gclass31_0.int_2 == 0)
                                                        {
                                                            gclass31_0.bool_0 = true;
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            ++class8.class7_0.gclass36_0.int_2;
                                                        }

                                                        if (!gclass31_0.bool_0)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (class8.class7_0.gclass36_0.int_2 == source1.Count)
                                                                break;
                                                        }
                                                        else
                                                            break;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    continue;
                                }

                                break;
                            }

                            break;
                            label_134:
                            predicate = func;
                            goto label_64;
                            label_92:
                            // ISSUE: reference to a compiler-generated field
                            GClass0.staticCompGen.staticCompMem__100_27 = predicate = gclass31_0 => !gclass31_0.bool_0;
                            goto label_64;
                        } while (class8.class7_0.gclass36_0.int_2 != source1.Count && flag);
                    }
                }
            }

            try
            {
                List<GroundUnitFormationElement> gclass39List = new List<GroundUnitFormationElement>();
                foreach (GroundUnitFormationElement gclass39 in cbool_0
                             ? this.FormationDictionary.Values
                                 .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData != null)
                                 .Where<GroundUnitFormationData>(gc103 => clist_0.Contains(gc103.PopulationData.gclass202_0.ActualSystem))
                                 .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList)
                                 .Where<GroundUnitFormationElement>(gclass39_0 =>
                                     gclass39_0.GroundUnitClass.gclass230_0 != null && gclass39_0.TargetSelectionType ==
                                     AuroraTargetSelection.AreaDefence).ToList<GroundUnitFormationElement>()
                             : this.FormationDictionary.Values
                                 .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData != null)
                                 .Where<GroundUnitFormationData>(gc103 => clist_0.Contains(gc103.PopulationData.gclass202_0.ActualSystem))
                                 .SelectMany<GroundUnitFormationData, GroundUnitFormationElement>(gclass103_0 => gclass103_0.ElementList).Where<GroundUnitFormationElement>(
                                     gclass39_0 =>
                                     {
                                         if (gclass39_0.GroundUnitClass.gclass230_0 == null)
                                             return false;
                                         return gclass39_0.TargetSelectionType ==
                                                AuroraTargetSelection.PointBlankDefensiveFireSelf ||
                                                gclass39_0.TargetSelectionType ==
                                                AuroraTargetSelection.PointBlankDefensiveFire ||
                                                gclass39_0.TargetSelectionType ==
                                                AuroraTargetSelection.RangedDefensiveFire;
                                     }).ToList<GroundUnitFormationElement>())
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.Class9 class9 = new GClass0.Class9();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class9.gclass39_0 = gclass39;
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass0.Class10 class10 = new GClass0.Class10();
                    // ISSUE: reference to a compiler-generated field

                    List<GClass34> gclass34List = new List<GClass34>();
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    int num1 = class9.gclass39_0.UnitCount - class9.gclass39_0.list_0.Count;
                    if (num1 > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class10.double_0 = class9.gclass39_0.Formation.PopulationData.method_87();
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class10.double_1 = class9.gclass39_0.Formation.PopulationData.method_88();
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class9.gclass39_0.int_8 = 0;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class10.int_0 = class9.gclass39_0.GroundUnitClass.gclass230_0.method_4();
                        for (int index = 1; index <= num1; ++index)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            GClass34 gclass34 = new GClass34()
                            {
                                gclass39_0 = class9.gclass39_0,
                                gclass230_0 = class9.gclass39_0.GroundUnitClass.gclass230_0,
                                bool_0 = false
                            };
                            gclass34.int_0 = gclass34.gclass230_0.int_7;
                            // ISSUE: reference to a compiler-generated field
                            gclass34.int_1 = class10.int_0;
                            // ISSUE: reference to a compiler-generated field
                            gclass34.double_2 = class10.double_0;
                            // ISSUE: reference to a compiler-generated field
                            gclass34.double_3 = class10.double_1;
                            gclass34List.Add(gclass34);
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        List<MissileSalvo> list7 = list_33.Where<MissileSalvo>(class9.method_0).ToList<MissileSalvo>();
                        if (list7.Count != 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            if (class9.gclass39_0.TargetSelectionType ==
                                AuroraTargetSelection.PointBlankDefensiveFireSelf)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                list7 = list7.Where<MissileSalvo>(class9.method_1).ToList<MissileSalvo>();
                                if (list7.Count == 0)
                                    continue;
                            }

                            // ISSUE: reference to a compiler-generated method
                            List<MissileSalvo> list8 = list7.Where<MissileSalvo>(class10.method_0).ToList<MissileSalvo>();
                            if (list8.Count != 0)
                            {
                                bool flag;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                do
                                {
                                    flag = false;
                                    List<GClass34> source = gclass34List;
                                    // ISSUE: reference to a compiler-generated field
                                    System.Func<GClass34, bool> func = GClass0.staticCompGen.staticCompMem__100_48;
                                    if (func == null)
                                        goto label_129;
                                    goto label_135;
                                    label_107:
                                    System.Func<GClass34, bool> predicate;
                                    gclass34List = source.Where<GClass34>(predicate).ToList<GClass34>();
                                    if (gclass34List.Count != 0)
                                    {
                                        foreach (GClass34 gclass34 in gclass34List)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            foreach (GClass131 gclass131 in list8
                                                         .SelectMany<MissileSalvo,
                                                             GClass131>(gclass132_0 => gclass132_0.dictionary_0.Values)
                                                         .OrderBy<GClass131,
                                                             int>(gclass131_0 =>
                                                             gclass131_0.list_0.Count + gclass131_0.list_1.Count)
                                                         .ThenBy<GClass131,
                                                             double>(class10.func_0 ??
                                                                     (class10.func_0 = class10.method_1))
                                                         .ThenBy<GClass131, int>(gclass131_0 =>
                                                             gclass131_0.gclass132_0.int_4)
                                                         .ThenByDescending<GClass131, Decimal>(gclass131_0 =>
                                                             gclass131_0.gclass132_0.RaceMissile.Size)
                                                         .ToList<GClass131>())
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                gclass131.gclass132_0.double_10 = this.GetDistanceBetween(class10.double_0,
                                                    class10.double_1, gclass131.gclass132_0.double_0,
                                                    gclass131.gclass132_0.double_1);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                if (class9.gclass39_0.TargetSelectionType ==
                                                    AuroraTargetSelection.PointBlankDefensiveFire ||
                                                    class9.gclass39_0.TargetSelectionType ==
                                                    AuroraTargetSelection.PointBlankDefensiveFireSelf)
                                                {
                                                    if (gclass131.gclass132_0.double_10 > AuroraUtils.int_8)
                                                        break;
                                                }

                                                if (gclass131.gclass132_0.double_10 < AuroraUtils.int_8)
                                                    gclass131.gclass132_0.double_10 = AuroraUtils.int_8;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                double num2 = 100.0 * class9.gclass39_0.method_1(
                                                    gclass131.gclass132_0.double_10, gclass131.gclass132_0.double_9,
                                                    1.0, true,
                                                    gclass131.gclass132_0.dictionary_1[
                                                        class9.gclass39_0.Formation.RaceData]);
                                                if (num2 > 0.0)
                                                {
                                                    if (gclass34.gclass230_0.int_7 == 1 ||
                                                        gclass34.gclass230_0.int_7 > 1 &&
                                                        gclass34.int_0 == gclass34.gclass230_0.int_7)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        class9.gclass39_0.list_0.Add(
                                                            class9.gclass39_0.GroundUnitClass.int_5);
                                                    }

                                                    gclass131.list_1.Add(gclass34);
                                                    gclass34.double_0 = gclass131.gclass132_0.double_10;
                                                    gclass34.double_1 = num2;
                                                    --gclass34.int_0;
                                                    flag = true;
                                                    if (gclass34.int_0 == 0)
                                                    {
                                                        gclass34.bool_0 = true;
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        ++class9.gclass39_0.int_8;
                                                    }

                                                    // ISSUE: reference to a compiler-generated field
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class9.gclass39_0.int_8 != gclass34List.Count)
                                                    {
                                                        if (gclass34.bool_0)
                                                            break;
                                                    }
                                                    else
                                                        break;
                                                }
                                            }
                                        }

                                        continue;
                                    }

                                    break;
                                    label_135:
                                    predicate = func;
                                    goto label_107;
                                    label_129:
                                    // ISSUE: reference to a compiler-generated field
                                    GClass0.staticCompGen.staticCompMem__100_48 =
                                        predicate = gclass34_0 => !gclass34_0.bool_0;
                                    goto label_107;
                                } while (class9.gclass39_0.int_8 != gclass34List.Count && flag);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AuroraUtils.ShowExceptionPopup(ex, 3691);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3654);
        }
    }

    public void method_44(List<MissileSalvo> list_33)
    {
        try
        {
            foreach (MissileSalvo gclass132 in list_33)
            {
                foreach (GClass131 gclass131 in gclass132.dictionary_0.Values)
                {
                    if (gclass131.list_2.Count != 0 || gclass131.list_1.Count != 0 || gclass131.list_0.Count != 0)
                    {
                        Dictionary<int, int> source = new Dictionary<int, int>();
                        if (gclass132.RemainingDecoys[gclass131.int_0] > 0)
                        {
                            for (int key = 1; key <= gclass132.RemainingDecoys[gclass131.int_0]; ++key)
                                source.Add(key, 0);
                        }

                        bool flag = false;
                        foreach (WeaponFireControlAssignment gclass31 in gclass131.list_0)
                        {
                            int decimal_13 = gclass31.WeaponComponent.method_5((int)gclass31.double_0);
                            int num = (int)gclass31.FireControlComponent.decimal_13 - gclass132.RaceMissile.MissileECM;
                            if (num < 0)
                                num = 0;
                            if (flag)
                                this.method_1(gclass31.Ship.gclass21_0, gclass31.Ship, gclass31.WeaponComponent,
                                    null, null, AuroraContactType.Salvo, gclass132.int_1, 1, 0, 0, 0, 1, decimal_13, 0M,
                                    gclass31.double_0, gclass31.double_1 / 100.0,
                                    "Salvo ID " + gclass132.int_1.ToString(), gclass132.Race, false, true, false,
                                    false, false, GEnum62.const_0);
                            else if (AuroraUtils.GetRandomInteger(10000) <= gclass31.double_1)
                            {
                                if (gclass132.RemainingDecoys[gclass131.int_0] != 0 && num < 5)
                                {
                                    if (AuroraUtils.GetRandomInteger(5 + (5 - num) *
                                            gclass132.RemainingDecoys[gclass131.int_0]) <= 5)
                                    {
                                        flag = true;
                                    }
                                    else
                                    {
                                        int key = AuroraUtils.GetRandomInteger(gclass132.RemainingDecoys[gclass131.int_0]);
                                        source[key]++;
                                        this.method_1(gclass31.Ship.gclass21_0, gclass31.Ship,
                                            gclass31.WeaponComponent, null, null, AuroraContactType.Salvo, gclass132.int_1,
                                            1, 0, 1, 0, 0, decimal_13, 0M, gclass31.double_0, gclass31.double_1 / 100.0,
                                            "Salvo ID " + gclass132.int_1.ToString(), gclass132.Race, false, true,
                                            false, false, false, GEnum62.const_0);
                                    }
                                }
                                else
                                    flag = true;

                                if (gclass132.RaceMissile.LaserWarhead > 0M)
                                    this.method_19(AuroraContactType.EWImpact, decimal_13, 1,
                                        gclass31.Ship.gclass85_0.System.ActualSystem, gclass132.double_0,
                                        gclass132.double_1, false);
                                else
                                    this.method_19(AuroraContactType.EWImpact, decimal_13, 1,
                                        gclass31.Ship.gclass85_0.System.ActualSystem,
                                        gclass31.Ship.gclass85_0.XCoord,
                                        gclass31.Ship.gclass85_0.YCoord, false);
                                if (flag)
                                {
                                    gclass132.method_4(gclass131.int_0);
                                    this.method_1(gclass31.Ship.gclass21_0, gclass31.Ship,
                                        gclass31.WeaponComponent, null, null, AuroraContactType.Salvo, gclass132.int_1, 1,
                                        1, 0, 1, 0, decimal_13, 0M, gclass31.double_0, gclass31.double_1 / 100.0,
                                        "Salvo ID " + gclass132.int_1.ToString(), gclass132.Race, false, true,
                                        false, false, false, GEnum62.const_0);
                                    gclass31.Ship.method_72(AuroraMeasurementType.HostileOrdnanceDestroyed, 1M);
                                }
                            }
                            else
                                this.method_1(gclass31.Ship.gclass21_0, gclass31.Ship, gclass31.WeaponComponent,
                                    null, null, AuroraContactType.Salvo, gclass132.int_1, 1, 0, 0, 0, 0, decimal_13, 0M,
                                    gclass31.double_0, gclass31.double_1 / 100.0,
                                    "Salvo ID " + gclass132.int_1.ToString(), gclass132.Race, false, true, false,
                                    false, false, GEnum62.const_0);
                        }

                        if (!flag)
                        {
                            foreach (GClass34 gclass34 in gclass131.list_1)
                            {
                                int decimal_13 = gclass34.gclass230_0.method_5((int)gclass34.double_0);
                                int num = (int)gclass34.gclass230_0.decimal_13 - gclass132.RaceMissile.MissileECM;
                                if (num < 0)
                                    num = 0;
                                if (flag)
                                    this.method_1(gclass34.gclass39_0.Formation.RaceData, null,
                                        gclass34.gclass230_0, null, gclass34.gclass39_0, AuroraContactType.Salvo,
                                        gclass132.int_1, 1, 0, 0, 0, 1, decimal_13, 0M, gclass34.double_0,
                                        gclass34.double_1 / 100.0, "Salvo ID " + gclass132.int_1.ToString(),
                                        gclass132.Race, false, true, false, false, false, GEnum62.const_0);
                                else if (AuroraUtils.GetRandomInteger(10000) <= gclass34.double_1)
                                {
                                    if (gclass132.RemainingDecoys[gclass131.int_0] != 0 && num < 5)
                                    {
                                        if (AuroraUtils.GetRandomInteger(5 + (5 - num) *
                                                gclass132.RemainingDecoys[gclass131.int_0]) <= 5)
                                        {
                                            flag = true;
                                        }
                                        else
                                        {
                                            int key = AuroraUtils.GetRandomInteger(
                                                gclass132.RemainingDecoys[gclass131.int_0]);
                                            source[key]++;
                                            this.method_1(gclass34.gclass39_0.Formation.RaceData, null,
                                                gclass34.gclass230_0, null, gclass34.gclass39_0,
                                                AuroraContactType.Salvo, gclass132.int_1, 1, 0, 1, 0, 0, decimal_13, 0M,
                                                gclass34.double_0, gclass34.double_1 / 100.0,
                                                "Salvo ID " + gclass132.int_1.ToString(), gclass132.Race, false,
                                                true, false, false, false, GEnum62.const_0);
                                        }
                                    }
                                    else
                                        flag = true;

                                    if (flag)
                                    {
                                        gclass132.method_4(gclass131.int_0);
                                        this.method_1(gclass34.gclass39_0.Formation.RaceData, null,
                                            gclass34.gclass230_0, null, gclass34.gclass39_0, AuroraContactType.Salvo,
                                            gclass132.int_1, 1, 1, 0, 1, 0, decimal_13, 0M, gclass34.double_0,
                                            gclass34.double_1 / 100.0, "Salvo ID " + gclass132.int_1.ToString(),
                                            gclass132.Race, false, true, false, false, false, GEnum62.const_0);
                                        this.method_19(AuroraContactType.EWImpact, decimal_13, 1,
                                            gclass34.gclass39_0.Formation.PopulationData.gclass202_0.ActualSystem,
                                            gclass34.double_2, gclass34.double_3, false);
                                    }
                                }
                                else
                                    this.method_1(gclass34.gclass39_0.Formation.RaceData, null,
                                        gclass34.gclass230_0, null, gclass34.gclass39_0, AuroraContactType.Salvo,
                                        gclass132.int_1, 1, 0, 0, 0, 0, decimal_13, 0M, gclass34.double_0,
                                        gclass34.double_1 / 100.0, "Salvo ID " + gclass132.int_1.ToString(),
                                        gclass132.Race, false, true, false, false, false, GEnum62.const_0);
                            }

                            int num1 = source.Count<KeyValuePair<int, int>>(keyValuePair_0 => keyValuePair_0.Value > 0);
                            if (num1 > 0 && gclass132.RemainingDecoys.ContainsKey(gclass131.int_0))
                                gclass132.RemainingDecoys[gclass131.int_0] =
                                    gclass132.RemainingDecoys[gclass131.int_0] - num1;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3655);
        }
    }

    public void method_45(List<MissileSalvo> list_33)
    {
        try
        {
            foreach (MissileSalvo gclass132 in list_33.Select<MissileSalvo, MissileSalvo>(gclass132_0 => gclass132_0.gclass132_0)
                         .Distinct<MissileSalvo>().ToList<MissileSalvo>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class21 class21 = new GClass0.Class21();
                // ISSUE: reference to a compiler-generated field
                class21.gclass132_0 = gclass132;
                // ISSUE: reference to a compiler-generated field
                if (class21.gclass132_0.RemainingDecoys.Count != 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    class21.gclass132_0.dictionary_0.Clear();
                    // ISSUE: reference to a compiler-generated field
                    foreach (KeyValuePair<int, int> keyValuePair in class21.gclass132_0.RemainingDecoys)
                    {
                        // ISSUE: reference to a compiler-generated field
                        GClass131 gclass131 = new GClass131(this, class21.gclass132_0, keyValuePair.Key);
                        // ISSUE: reference to a compiler-generated field
                        class21.gclass132_0.dictionary_0.Add(keyValuePair.Key, gclass131);
                    }

                    // ISSUE: reference to a compiler-generated method
                    List<MissileSalvo> list1 = list_33.Where<MissileSalvo>(class21.method_0).ToList<MissileSalvo>();
                    // ISSUE: reference to a compiler-generated field
                    class21.gclass132_0.RemainingDecoys.Keys.ToList<int>();
                    foreach (MissileSalvo gclass132_1 in list1)
                    {
                        gclass132_1.int_5 = 0;
                        int count = gclass132_1.RemainingDecoys.Count;
                        // ISSUE: reference to a compiler-generated field
                        double double_1 = 100.0 * gclass132_1.RaceMissile.method_0(class21.gclass132_0.double_9, 1.0,
                            gclass132_1.double_8);
                        // ISSUE: reference to a compiler-generated field
                        List<GClass131> list2 = class21.gclass132_0.dictionary_0.Values
                            .OrderBy<GClass131, int>(gclass131_0 => gclass131_0.list_2.Count).ToList<GClass131>();
                        if (list2.Count > 0)
                        {
                            do
                            {
                                foreach (GClass131 gclass131 in list2)
                                {
                                    GClass33 gclass33 = new GClass33(gclass132_1, double_1);
                                    // ISSUE: reference to a compiler-generated field
                                    class21.gclass132_0.dictionary_0[gclass131.int_0].list_2.Add(gclass33);
                                    --count;
                                    if (count == 0)
                                        break;
                                }
                            } while (count != 0);
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    foreach (GClass131 gclass131 in class21.gclass132_0.dictionary_0.Values)
                    {
                        Dictionary<int, int> source = new Dictionary<int, int>();
                        // ISSUE: reference to a compiler-generated field
                        if (class21.gclass132_0.RemainingDecoys[gclass131.int_0] > 0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            for (int key = 1; key <= class21.gclass132_0.RemainingDecoys[gclass131.int_0]; ++key)
                                source.Add(key, 0);
                        }

                        bool flag1 = false;
                        bool flag2 = false;
                        foreach (GClass33 gclass33 in gclass131.list_2)
                        {
                            Decimal decimal_13 = gclass33.gclass132_0.RaceMissile.WarheadStrength /
                                                 gclass33.gclass132_0.RaceMissile.MultipleWarheads;
                            // ISSUE: reference to a compiler-generated field
                            int num1 = gclass33.gclass132_0.RaceMissile.ECCM - class21.gclass132_0.RaceMissile.MissileECM;
                            if (num1 < 0)
                                num1 = 0;
                            bool flag3 = false;
                            if (flag1)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                this.method_1(gclass33.gclass132_0.Race, gclass33.gclass132_0.Ship, null,
                                    gclass33.gclass132_0.RaceMissile, null, AuroraContactType.Salvo,
                                    gclass33.gclass132_0.int_0, gclass33.gclass132_0.RaceMissile.MultipleWarheads, 0, 0, 0, 0,
                                    decimal_13, 0M, 0.0, gclass33.double_0 / 100.0,
                                    "Salvo ID" + class21.gclass132_0.int_1.ToString(), class21.gclass132_0.Race,
                                    false, true, false, false, false, GEnum62.const_0);
                            }
                            else
                            {
                                int int_137 = gclass33.gclass132_0.RaceMissile.MultipleWarheads;
                                for (int index = 1; index <= gclass33.gclass132_0.RaceMissile.MultipleWarheads; ++index)
                                {
                                    if (AuroraUtils.GetRandomInteger(10000) <= gclass33.double_0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        if (class21.gclass132_0.RemainingDecoys[gclass131.int_0] != 0 && num1 < 5)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (AuroraUtils.GetRandomInteger(5 + (5 - num1) *
                                                    class21.gclass132_0.RemainingDecoys[gclass131.int_0]) <= 5)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                if (decimal_13 * 20M >= class21.gclass132_0.RaceMissile.Size)
                                                {
                                                    flag2 = true;
                                                }
                                                else
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    int num2 = (int)Math.Floor(decimal_13 * 20M /
                                                        class21.gclass132_0.RaceMissile.Size * 1000M);
                                                    if (AuroraUtils.GetRandomInteger(1000) <= num2)
                                                        flag2 = true;
                                                }
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                int key = AuroraUtils.GetRandomInteger(
                                                    class21.gclass132_0.RemainingDecoys[gclass131.int_0]);
                                                source[key]++;
                                                flag3 = true;
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_1(gclass33.gclass132_0.Race,
                                                    gclass33.gclass132_0.Ship, null,
                                                    gclass33.gclass132_0.RaceMissile, null, AuroraContactType.Salvo,
                                                    gclass33.gclass132_0.int_0, int_137, 0, 1, 0, 0, decimal_13, 0M,
                                                    0.0, gclass33.double_0 / 100.0,
                                                    "Salvo ID" + class21.gclass132_0.int_1.ToString(),
                                                    class21.gclass132_0.Race, false, true, false, false, false,
                                                    GEnum62.const_0);
                                            }
                                        }
                                        else
                                            flag2 = true;

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.method_19(AuroraContactType.Explosion, decimal_13, 1,
                                            gclass33.gclass132_0.Ship.gclass85_0.System.ActualSystem,
                                            class21.gclass132_0.double_0, class21.gclass132_0.double_1, false);
                                        if (flag2)
                                        {
                                            flag3 = true;
                                            // ISSUE: reference to a compiler-generated field
                                            if (gclass33.gclass132_0.RaceMissile.WarheadStrength * 20M >=
                                                class21.gclass132_0.RaceMissile.Size)
                                            {
                                                flag1 = true;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                int num3 = (int)Math.Floor(gclass33.gclass132_0.RaceMissile.WarheadStrength *
                                                    20M / class21.gclass132_0.RaceMissile.Size * 1000M);
                                                if (AuroraUtils.GetRandomInteger(1000) <= num3)
                                                    flag1 = true;
                                            }

                                            if (!flag1)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_1(gclass33.gclass132_0.Race,
                                                    gclass33.gclass132_0.Ship, null,
                                                    gclass33.gclass132_0.RaceMissile, null, AuroraContactType.Salvo,
                                                    gclass33.gclass132_0.int_0, int_137, 1, 0, 0, 0, decimal_13, 0M,
                                                    0.0, gclass33.double_0 / 100.0,
                                                    "Salvo ID" + class21.gclass132_0.int_1.ToString(),
                                                    class21.gclass132_0.Race, false, true, false, false, false,
                                                    GEnum62.const_0);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class21.gclass132_0.method_4(gclass131.int_0);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.method_1(gclass33.gclass132_0.Race,
                                                    gclass33.gclass132_0.Ship, null,
                                                    gclass33.gclass132_0.RaceMissile, null, AuroraContactType.Salvo,
                                                    gclass33.gclass132_0.int_0, int_137, 1, 0, 1, 0, decimal_13, 0M,
                                                    0.0, gclass33.double_0 / 100.0,
                                                    "Salvo ID" + class21.gclass132_0.int_1.ToString(),
                                                    class21.gclass132_0.Race, false, true, false, false, false,
                                                    GEnum62.const_0);
                                                if (gclass33.gclass132_0.Ship != null)
                                                {
                                                    gclass33.gclass132_0.Ship.method_72(
                                                        AuroraMeasurementType.HostileOrdnanceDestroyed, 1M);
                                                    break;
                                                }

                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.method_1(gclass33.gclass132_0.Race, gclass33.gclass132_0.Ship,
                                            null, gclass33.gclass132_0.RaceMissile, null, AuroraContactType.Salvo,
                                            gclass33.gclass132_0.int_0, int_137, 0, 0, 0, 0, decimal_13, 0M, 0.0,
                                            gclass33.double_0 / 100.0,
                                            "Salvo ID" + class21.gclass132_0.int_1.ToString(),
                                            class21.gclass132_0.Race, false, true, false, false, false,
                                            GEnum62.const_0);
                                    }

                                    int_137 = 0;
                                }

                                if (flag3)
                                    ++gclass33.gclass132_0.int_5;
                            }
                        }

                        if (!flag1)
                        {
                            int num = source.Count<KeyValuePair<int, int>>(keyValuePair_0 => keyValuePair_0.Value > 0);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class21.gclass132_0.RemainingDecoys[gclass131.int_0] =
                                class21.gclass132_0.RemainingDecoys[gclass131.int_0] - num;
                        }
                    }
                }
            }

            foreach (MissileSalvo gclass132_0 in list_33)
            {
                if (gclass132_0.RaceMissile.Retargeting == 0)
                    gclass132_0.Race.method_130(gclass132_0);
                else if (gclass132_0.int_5 >= gclass132_0.RemainingDecoys.Count)
                {
                    gclass132_0.Race.method_130(gclass132_0);
                }
                else
                {
                    gclass132_0.method_5(gclass132_0.int_5);
                    gclass132_0.bool_2 = true;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3667);
        }
    }

    public void method_46(MissileSalvo gclass132_0)
    {
        try
        {
            if (gclass132_0.auroraContactType_0 != AuroraContactType.Ship ||
                this.GetDistanceBetween(gclass132_0.gclass40_1.gclass85_0.XCoord, gclass132_0.gclass40_1.gclass85_0.YCoord,
                    gclass132_0.double_0, gclass132_0.double_1) > AuroraUtils.int_8)
                return;
            KeyValuePair<int, int> keyValuePair = gclass132_0.RemainingDecoys.First<KeyValuePair<int, int>>();
            int key = keyValuePair.Key;
            List<GClass228> list = gclass132_0.gclass40_1.gclass22_0.dictionary_0.Values.Where<GClass228>(gclass228_0 =>
                    gclass228_0.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.CIWS)
                .ToList<GClass228>();
            if (list.Count == 0)
                return;
            foreach (GClass228 gclass228 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class26 class26 = new GClass0.Class26();
                // ISSUE: reference to a compiler-generated field
                class26.gclass228_0 = gclass228;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                int num1 = gclass132_0.gclass40_1.method_158(class26.gclass228_0) - gclass132_0.gclass40_1.list_8
                    .Where<GClass28>(class26.method_0).Select<GClass28, int>(gclass28_0 => gclass28_0.int_0)
                    .FirstOrDefault<int>();
                if (num1 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    int num2 = (int)class26.gclass228_0.gclass230_0.decimal_13 - gclass132_0.RaceMissile.MissileECM;
                    // ISSUE: reference to a compiler-generated field
                    double num3 = 100.0 *
                                  gclass132_0.gclass40_1.method_108(class26.gclass228_0.gclass230_0, gclass132_0);
                    int num4 = 0;
                    int int_139 = 0;
                    for (int index1 = 1; index1 <= num1; ++index1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass132_0.gclass40_1.method_100(class26.gclass228_0.gclass230_0);
                        // ISSUE: reference to a compiler-generated field
                        for (int index2 = 1; index2 <= class26.gclass228_0.gclass230_0.decimal_3; ++index2)
                        {
                            if (AuroraUtils.GetRandomInteger(10000) <= num3)
                            {
                                bool flag = false;
                                if (gclass132_0.RemainingDecoys[key] != 0 && num2 < 5)
                                {
                                    if (AuroraUtils.GetRandomInteger(5 + (5 - num2) * gclass132_0.RemainingDecoys[key]) <=
                                        5)
                                    {
                                        flag = true;
                                    }
                                    else
                                    {
                                        ++int_139;
                                        gclass132_0.RemainingDecoys[key]--;
                                    }
                                }
                                else
                                    flag = true;

                                if (flag)
                                {
                                    ++num4;
                                    gclass132_0.method_4(key);
                                    if (gclass132_0.RemainingDecoys.Count != 0)
                                    {
                                        keyValuePair = gclass132_0.RemainingDecoys.First<KeyValuePair<int, int>>();
                                        key = keyValuePair.Key;
                                    }
                                    else
                                        break;
                                }
                            }
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.method_1(gclass132_0.gclass40_1.gclass21_0, gclass132_0.gclass40_1,
                        class26.gclass228_0.gclass230_0, null, null, AuroraContactType.Salvo, gclass132_0.int_1,
                        (int)class26.gclass228_0.gclass230_0.decimal_3, num4, int_139, num4, 0, 1M, 0M, 0.0,
                        num3 / 100.0, "Salvo ID " + gclass132_0.int_1.ToString(), gclass132_0.Race, false, true,
                        false, false, false, GEnum62.const_0);
                    if (num4 > 0)
                    {
                        gclass132_0.gclass40_1.method_72(AuroraMeasurementType.HostileOrdnanceDestroyed, num4);
                        this.method_19(AuroraContactType.EWImpact, 1M, num4,
                            gclass132_0.gclass40_1.gclass85_0.System.ActualSystem,
                            gclass132_0.gclass40_1.gclass85_0.XCoord, gclass132_0.gclass40_1.gclass85_0.YCoord,
                            false);
                    }

                    if (gclass132_0.RemainingDecoys.Count == 0)
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3656);
        }
    }

    public void method_47(Decimal decimal_13)
    {
        try
        {
            List<FleetData> list1 = this.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 => gclass85_0.MoveOrderDictionary.Count > 0 && !gclass85_0.bool_20)
                .Where<FleetData>(gclass85_0 => !gclass85_0.method_45()).ToList<FleetData>();
            if (list1.Count == 0)
                return;
            foreach (FleetData gclass85 in list1)
                gclass85.decimal_2 = 1M - gclass85.method_254();
            foreach (FleetData gclass85_1 in list1.Where<FleetData>(gclass85_0 => gclass85_0.decimal_2 > 0M)
                         .OrderByDescending<FleetData, Decimal>(gclass85_0 => gclass85_0.decimal_2).ToList<FleetData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class27 class27 = new GClass0.Class27();
                // ISSUE: reference to a compiler-generated field
                class27.gclass85_0 = gclass85_1;
                // ISSUE: reference to a compiler-generated field
                if (!class27.gclass85_0.bool_4)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class27.gclass85_0.int_9 > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class27.gclass85_0.int_9 -= this.SubPulseLength;
                    }

                    int num1 = this.SubPulseLength;
                    // ISSUE: reference to a compiler-generated field
                    List<MoveOrder> list2 = class27.gclass85_0.MoveOrderDictionary.Values
                        .OrderBy<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue).ToList<MoveOrder>();
                    // ISSUE: reference to a compiler-generated field
                    if (class27.gclass85_0.bUseMaximumSpeed)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class27.gclass85_0.Speed = class27.gclass85_0.method_195();
                    }

                    foreach (MoveOrder gclass139_1 in list2)
                    {
                        // ISSUE: object of a compiler-generated type is created
                        // ISSUE: variable of a compiler-generated type
                        GClass0.Class28 class28 = new GClass0.Class28();
                        // ISSUE: reference to a compiler-generated field
                        class28.gclass139_0 = gclass139_1;
                        // ISSUE: reference to a compiler-generated field
                        while (!class28.gclass139_0.bool_2)
                        {
                            int num2 = num1;
                            // ISSUE: reference to a compiler-generated field
                            if (class28.gclass139_0.DelayRemaining > 0)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class28.gclass139_0.DelayRemaining <= num1)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num1 -= class28.gclass139_0.DelayRemaining;
                                    // ISSUE: reference to a compiler-generated field
                                    class28.gclass139_0.DelayRemaining = 0;
                                    if (num1 == 0)
                                        break;
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    class28.gclass139_0.DelayRemaining -= num1;
                                    num1 = 0;
                                    break;
                                }
                            }

                            // ISSUE: reference to a compiler-generated field
                            if (class28.gclass139_0.bArrived)
                            {
                                // ISSUE: reference to a compiler-generated field
                                switch (class28.gclass139_0.MoveActionType.MoveActionType)
                                {
                                    case MoveActionType.LoadColonists:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_95(class28.gclass139_0.Population,
                                                class28.gclass139_0.MaxItems);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.UnloadColonists:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_106(class28.gclass139_0.Population);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.RefuelFromColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_117(num1, class28.gclass139_0);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.GeologicalSurvey:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num3 = class27.gclass85_0.ParentNavalCommand.method_5(
                                            class27.gclass85_0.System.ActualSystem.SystemID, CommanderBonusType.Survey);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.decimal_4 =
                                            class27.gclass85_0.method_125(AuroraComponentType.GeologicalSurveySensors) *
                                            num3 * (Decimal)(this.SurveySpeed / 100.0);
                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num4 = class27.gclass85_0.decimal_4 * num1 / 3600M;
                                        // ISSUE: reference to a compiler-generated field
                                        if (class28.gclass139_0.SurveyPointsRequired > num4)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.SurveyPointsRequired -= num4;
                                            num1 = 0;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num5 = (num4 - class28.gclass139_0.SurveyPointsRequired) / num4;
                                        num1 = (int)(num1 * num5);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.SystemBodyRecordDic[class28.gclass139_0.DestinationID]
                                            .method_37(class27.gclass85_0.Race);
                                        string string_10 = "None";
                                        // ISSUE: reference to a compiler-generated field
                                        if (this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].MineralDeposits.Count > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            string_10 = this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].method_26();
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            string str = this.SystemBodyRecordDic[class28.gclass139_0.DestinationID]
                                                .method_78(class27.gclass85_0.Race);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_85,
                                                $"{class27.gclass85_0.method_15()} discovered minerals on {str}:   {string_10}",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_170("Minerals discovered on " + str);
                                            if (AuroraUtils.GetRandomInteger(20) == 10)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_90(GEnum8.const_0);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_16(
                                                AuroraMeasurementType.BodiesWithMineralsDiscovered, 1M);
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].RuinID > 0 &&
                                            this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].AbandonedFactories > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].RuinData == null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].RuinData =
                                                    this.RuinDefinitionDictionary[
                                                        this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].RuinID];
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_26,
                                                $"{class27.gclass85_0.method_15()} discovered {this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].RuinData.Description} on {this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].method_78(class27.gclass85_0.Race)}",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_16(AuroraMeasurementType.RuinsDiscovered, 1M);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_17(AuroraMeasurementType.RuinsDiscovered,
                                                this.SystemBodyRecordDic[class28.gclass139_0.DestinationID], null, "");
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        if (this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].AncientConstruct != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_141,
                                                $"{class27.gclass85_0.method_15()} discovered Ancient Construct on {this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].method_78(class27.gclass85_0.Race)}",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_16(
                                                AuroraMeasurementType.AncientConstructsDiscovered, 1M);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_17(
                                                AuroraMeasurementType.AncientConstructsDiscovered,
                                                this.SystemBodyRecordDic[class28.gclass139_0.DestinationID], null, "");
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        if (this.SystemBodyRecordDic[class28.gclass139_0.DestinationID]
                                                .GroundMineralSurveyState != AuroraGroundMineralSurvey.Completed)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_156,
                                                $"{class27.gclass85_0.method_15()} has conducted an orbital survey of {this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].method_78(class27.gclass85_0.Race)} that revealed the potential for a ground survey is {AuroraUtils.smethod_82(this.SystemBodyRecordDic[class28.gclass139_0.DestinationID].GroundMineralSurveyState)}",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            foreach (TacticalMap tacticalMap in Application.OpenForms
                                                         .OfType<TacticalMap>())
                                                tacticalMap.method_7();
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.Race.method_272(
                                            this.SystemBodyRecordDic[class28.gclass139_0.DestinationID], string_10);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class27.gclass85_0.Race.NPR &&
                                            class27.gclass85_0.Race.SpecialNPRID == SpecialNPRIDs.const_0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.Race.method_274(
                                                this.SystemBodyRecordDic[class28.gclass139_0.DestinationID]);
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        class28.gclass139_0.bool_2 = true;
                                        break;
                                    case MoveActionType.GravitationalSurvey:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num6 = class27.gclass85_0.ParentNavalCommand.method_5(
                                            class27.gclass85_0.System.ActualSystem.SystemID, CommanderBonusType.Survey);
                                        // ISSUE: reference to a compiler-generated field
                                        if (class27.gclass85_0.decimal_5 == 0M)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.decimal_5 =
                                                class27.gclass85_0.method_125(AuroraComponentType
                                                    .GravitationalSurveySensors) * num6 *
                                                (Decimal)(this.SurveySpeed / 100.0);
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num7 = class27.gclass85_0.decimal_5 * num1 / 3600M;
                                        // ISSUE: reference to a compiler-generated field
                                        if (class28.gclass139_0.SurveyPointsRequired > num7)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.SurveyPointsRequired -= num7;
                                            num1 = 0;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        Decimal num8 = (num7 - class28.gclass139_0.SurveyPointsRequired) / num7;
                                        num1 = (int)(num1 * num8);
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.System.ActualSystem
                                            .SurveyLocationDictionary[class28.gclass139_0.DestinationID]
                                            .method_0(class27.gclass85_0.Race);
                                        if (AuroraUtils.GetRandomInteger(20) == 10)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_90(GEnum8.const_0);
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class28.gclass139_0.StartSystem.method_45(class28.gclass139_0.DestinationID, null,
                                                class27.gclass85_0))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_170("Jump Point discovered in " +
                                                                          class27.gclass85_0.System.Name);
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        class28.gclass139_0.StartSystem.method_42();
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.Race.method_273(
                                            class27.gclass85_0.System.ActualSystem,
                                            class27.gclass85_0.System.ActualSystem.SurveyLocationDictionary[
                                                class28.gclass139_0.DestinationID]);
                                        // ISSUE: reference to a compiler-generated field
                                        class28.gclass139_0.bool_2 = true;
                                        break;
                                    case MoveActionType.LoadOrdnanceFromColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_119(num1, class28.gclass139_0,
                                            GEnum43.const_0);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadAllMinerals:
                                    case MoveActionType.LoadMineralType:
                                    case MoveActionType.LoadMineralWhenXAvailable:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class28.gclass139_0.MoveActionType.MoveActionType == MoveActionType.LoadMineralWhenXAvailable &&
                                            class28.gclass139_0.MinQuantity > 0M &&
                                            class28.gclass139_0.Population.CurrentMinerals.GetValueOfElement(
                                                (AuroraElement)class28.gclass139_0.DestinationItemID) <
                                            class28.gclass139_0.MinQuantity)
                                        {
                                            num1 = 0;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_97(class28.gclass139_0.Population,
                                                (AuroraElement)class28.gclass139_0.DestinationItemID, class28.gclass139_0.MinQuantity,
                                                class28.gclass139_0.MaxItems, true);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.UnloadAllMinerals:
                                    case MoveActionType.UnloadMineralType:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_107(class28.gclass139_0.Population,
                                                (AuroraElement)class28.gclass139_0.DestinationItemID,
                                                class28.gclass139_0.MaxItems);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.StabilizeJumpPoint:
                                        // ISSUE: reference to a compiler-generated field
                                        if (class27.gclass85_0.method_176()
                                                .Where<ShipData>(gclass40_0 =>
                                                    gclass40_0.method_167(AuroraComponentType.JumpPointStabilisation) >
                                                    0).ToList<ShipData>().Count == 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_27,
                                                class27.gclass85_0.FleetName +
                                                " cannot complete jump point stabilisation as there are no ships within the fleet that have stabilisation capability",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            num1 = 0;
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_77(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.TransferFuelToColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_122(num1, class28.gclass139_0);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadGroundUnitIntoTransportBay:
                                    case MoveActionType.LoadGroundUnitFromStationaryFleet:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_91(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.UnloadGroundUnitFromTransportBay:
                                    case MoveActionType.UnloadAllGroundUnitsFromTransportBay:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_103(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.UnloadAllInstallations:
                                    case MoveActionType.UnloadInstallation:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_99(class28.gclass139_0.Population,
                                                (AuroraInstallationType)class28.gclass139_0.DestinationItemID,
                                                class28.gclass139_0.MaxItems);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.SalvageWreck:
                                        // ISSUE: reference to a compiler-generated field
                                        if (class27.gclass85_0.method_153() == 0M)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_27,
                                                class27.gclass85_0.FleetName +
                                                " cannot complete salvage as there are no ships within the fleet that have salvage capability",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            num1 = 0;
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_80(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.SalvageIntactShip:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (this.Ships.ContainsKey(class28.gclass139_0.DestinationItemID))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_81(
                                                    this.Ships[class28.gclass139_0.DestinationItemID],
                                                    class27.gclass85_0);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.ResupplyFromColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_118(num1, class28.gclass139_0);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.TransferMaintenanceSuppliesToColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_123(num1, class28.gclass139_0);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadTradeGoods:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_93(class28.gclass139_0.Population,
                                                class28.gclass139_0.DestinationItemID);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.UnloadTradeGoods:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_102(class28.gclass139_0.Population,
                                                class28.gclass139_0.DestinationItemID);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadShipComponent:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (this.ComponentDataDictionary.ContainsKey(class28.gclass139_0.DestinationItemID))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_94(class28.gclass139_0.Population,
                                                    this.ComponentDataDictionary[class28.gclass139_0.DestinationItemID]);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.UnloadShipComponent:
                                    case MoveActionType.UnloadAllShipComponents:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_101(class28.gclass139_0.Population,
                                                class28.gclass139_0.DestinationItemID);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.UnloadOrdnanceToColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_119(num1, class28.gclass139_0,
                                            GEnum43.const_1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadUnloadMineralsToReserveLevel:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_98(class28.gclass139_0.Population);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadInstallation:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_96(class28.gclass139_0.Population,
                                                (AuroraInstallationType)class28.gclass139_0.DestinationItemID,
                                                class28.gclass139_0.MaxItems);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadFromOrdnanceTransferHub:
                                    case MoveActionType.UnloadToOrdnanceTransferHub:
                                    case MoveActionType.ReplaceOrdnanceAtTransferHub:
                                    case MoveActionType.RefuelFromStationaryTankers:
                                    case MoveActionType.ResupplyFromStationarySupplyShip:
                                    case MoveActionType.RefuelStationaryFleet:
                                    case MoveActionType.ResupplyStationaryFleet:
                                    case MoveActionType.RefuelStationaryFleetToMinimum:
                                    case MoveActionType.RefuelToMinimumFromStationaryTankers:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (!class27.gclass85_0.method_54(class28.gclass139_0))
                                        {
                                            num1 = 0;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        if (!this.FleetDictionary.ContainsKey(class28.gclass139_0.DestinationID))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.OrbitingBody =
                                                this.FleetDictionary[class28.gclass139_0.DestinationID].OrbitingBody;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class28.gclass139_0.DestinationType == DestinationType.const_7 &&
                                            this.FleetDictionary.ContainsKey(class28.gclass139_0.DestinationID))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.OrbitingBody =
                                                this.FleetDictionary[class28.gclass139_0.DestinationID].OrbitingBody;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        switch (class28.gclass139_0.MoveActionType.MoveActionType)
                                        {
                                            case MoveActionType.LoadFromOrdnanceTransferHub:
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                num1 = (int)class27.gclass85_0.method_120(num1, class28.gclass139_0,
                                                    GEnum43.const_0);
                                                if (num1 > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class28.gclass139_0.bool_2 = true;
                                                    break;
                                                }

                                                break;
                                            case MoveActionType.UnloadToOrdnanceTransferHub:
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                num1 = (int)class27.gclass85_0.method_120(num1, class28.gclass139_0,
                                                    GEnum43.const_1);
                                                if (num1 > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class28.gclass139_0.bool_2 = true;
                                                    break;
                                                }

                                                break;
                                            case MoveActionType.ReplaceOrdnanceAtTransferHub:
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                num1 = (int)class27.gclass85_0.method_120(num1, class28.gclass139_0,
                                                    GEnum43.const_2);
                                                if (num1 > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class28.gclass139_0.bool_2 = true;
                                                    break;
                                                }

                                                break;
                                            case MoveActionType.RefuelFromStationaryTankers:
                                            case MoveActionType.RefuelStationaryFleet:
                                            case MoveActionType.RefuelStationaryFleetToMinimum:
                                            case MoveActionType.RefuelToMinimumFromStationaryTankers:
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                num1 = (int)class27.gclass85_0.method_113(num1, class28.gclass139_0);
                                                if (num1 > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class28.gclass139_0.bool_2 = true;
                                                    break;
                                                }

                                                break;
                                            case MoveActionType.ResupplyFromStationarySupplyShip:
                                            case MoveActionType.ResupplyStationaryFleet:
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                num1 = (int)class27.gclass85_0.method_114(num1, class28.gclass139_0);
                                                if (num1 > 0)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class28.gclass139_0.bool_2 = true;
                                                    break;
                                                }

                                                break;
                                        }

                                        break;
                                    case MoveActionType.ReplaceOrdnanceAtColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_119(num1, class28.gclass139_0,
                                            GEnum43.const_2);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.OrbitalDropGroundUnit:
                                    case MoveActionType.OrbitalDropAllGroundUnits:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class27.gclass85_0.IncrementStartX == class27.gclass85_0.XCoord &&
                                            class27.gclass85_0.IncrementStartY == class27.gclass85_0.YCoord)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            num1 = class28.gclass139_0.method_0(num1);
                                            if (num1 > 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_103(class28.gclass139_0);
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                                break;
                                            }

                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.bool_20 = true;
                                        num1 = 0;
                                        break;
                                    case MoveActionType.RefuelAndResupplyFromColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_115(num1, class28.gclass139_0);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class27.gclass85_0.Race.NPR)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                using (List<ShipData>.Enumerator enumerator =
                                                       class27.gclass85_0.method_176()
                                                           .Where<ShipData>(gclass40_0 =>
                                                               gclass40_0.gclass22_0.DecoyCapacity > 0M)
                                                           .ToList<ShipData>().GetEnumerator())
                                                {
                                                    while (enumerator.MoveNext())
                                                    {
                                                        ShipData current = enumerator.Current;
                                                        current.gclass22_0.method_44(current);
                                                    }

                                                    break;
                                                }
                                            }

                                            break;
                                        }

                                        break;
                                    case MoveActionType.RefuelResupplyAndLoadOrdnanceFromColony:
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = (int)class27.gclass85_0.method_116(num1, class28.gclass139_0);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.ProvideGroundSupport:
                                    case MoveActionType.ProvideGroundCap:
                                    case MoveActionType.PlanetarySearchAndDestroy:
                                    case MoveActionType.PlanetaryFlakSuppression:
                                    case MoveActionType.ProvideOrbitalBombardmentSupport:
                                        num1 = 0;
                                        break;
                                    case MoveActionType.StabilizeNewLagrangePoint:
                                        // ISSUE: reference to a compiler-generated field
                                        if (class27.gclass85_0.method_176()
                                                .Where<ShipData>(gclass40_0 =>
                                                    gclass40_0.method_167(AuroraComponentType.JumpPointStabilisation) >
                                                    0).ToList<ShipData>().Count == 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_27,
                                                class27.gclass85_0.FleetName +
                                                " cannot complete jump point stabilisation as there are no ships within the fleet that have stabilisation capability",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            num1 = 0;
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (this.SystemBodyRecordDic.ContainsKey(class28.gclass139_0.DestinationID))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                this.ModifyForJupiter(
                                                    this.SystemBodyRecordDic[class28.gclass139_0.DestinationID], true);
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_16(
                                                    AuroraMeasurementType.LPStablisationsCompleted, 1M);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_17(
                                                    AuroraMeasurementType.LPStablisationsCompleted,
                                                    this.SystemBodyRecordDic[class28.gclass139_0.DestinationID], null, "");
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.SalvageInstallations:
                                        // ISSUE: reference to a compiler-generated field
                                        if (!this.Populations.ContainsKey(class28.gclass139_0.Population.PopulationID))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class27.gclass85_0.method_82(class28.gclass139_0.Population,
                                            class27.gclass85_0, num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadAllMineralsUntilFull:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_97(class28.gclass139_0.Population,
                                                (AuroraElement)class28.gclass139_0.DestinationItemID, class28.gclass139_0.MinQuantity,
                                                class28.gclass139_0.MaxItems, false);
                                            // ISSUE: reference to a compiler-generated field
                                            if (class27.gclass85_0.method_147() == 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                                break;
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.TimeRequired =
                                                class27.gclass85_0.method_87(class28.gclass139_0);
                                            num1 = 0;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.TransferAllInstallations:
                                    case MoveActionType.TransferInstallation:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (!this.FleetDictionary.ContainsKey(class28.gclass139_0.DestinationID))
                                            {
                                                num1 = 0;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_100(
                                                    this.FleetDictionary[class28.gclass139_0.DestinationID],
                                                    (AuroraInstallationType)class28.gclass139_0.DestinationItemID,
                                                    class28.gclass139_0.MaxItems);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.TransferAllMinerals:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (!this.FleetDictionary.ContainsKey(class28.gclass139_0.DestinationID))
                                            {
                                                num1 = 0;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_108(
                                                    this.FleetDictionary[class28.gclass139_0.DestinationID],
                                                    (AuroraElement)class28.gclass139_0.DestinationItemID,
                                                    class28.gclass139_0.MaxItems);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                    case MoveActionType.LoadAssignedGroundTemplates:
                                        // ISSUE: reference to a compiler-generated field
                                        num1 = class28.gclass139_0.method_0(num1);
                                        if (num1 > 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_92(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        }

                                        break;
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.method_6();
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.OrbitingBody = null;
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.bool_21 = true;
                                // ISSUE: reference to a compiler-generated field
                                if (class28.gclass139_0.DestinationType == DestinationType.const_7)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (!this.FleetDictionary.ContainsKey(class28.gclass139_0.DestinationID))
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.gclass92_0.method_2(EventType.const_24,
                                            $"Destination fleet of {class27.gclass85_0.FleetName} cannot be found. Please issue new orders",
                                            class27.gclass85_0.Race, class27.gclass85_0.System.ActualSystem,
                                            class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                            AuroraEventCategory.Fleet);
                                        num1 = 0;
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.method_263();
                                        // ISSUE: reference to a compiler-generated field
                                        class28.gclass139_0.bool_2 = true;
                                        continue;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (this.FleetDictionary[class28.gclass139_0.DestinationID].System.ActualSystem !=
                                        class27.gclass85_0.System.ActualSystem)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.gclass92_0.method_2(EventType.const_24,
                                            $"Destination fleet of {class27.gclass85_0.FleetName} is in a different system. Please issue new orders",
                                            class27.gclass85_0.Race, class27.gclass85_0.System.ActualSystem,
                                            class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                            AuroraEventCategory.Fleet);
                                        num1 = 0;
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.method_263();
                                        // ISSUE: reference to a compiler-generated field
                                        class28.gclass139_0.bool_2 = true;
                                        continue;
                                    }
                                }

                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.bool_19 = false;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                GClass221 gclass221_0_1 = this.method_53(class28.gclass139_0.DestinationType,
                                    class28.gclass139_0.DestinationID, class28.gclass139_0.StartSystem.ActualSystem, null,
                                    class27.gclass85_0, class28.gclass139_0.MinDistance, decimal_13);
                                if (gclass221_0_1.double_0 == 0.0 && gclass221_0_1.double_1 == 0.0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    this.gclass92_0.method_2(EventType.const_24,
                                        $"Destination of {class27.gclass85_0.FleetName} cannot be found. Please issue new orders",
                                        class27.gclass85_0.Race, class27.gclass85_0.System.ActualSystem,
                                        class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                        AuroraEventCategory.Fleet);
                                    num1 = 0;
                                    // ISSUE: reference to a compiler-generated field
                                    class27.gclass85_0.method_263();
                                    // ISSUE: reference to a compiler-generated field
                                    class28.gclass139_0.bool_2 = true;
                                    continue;
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (!class27.gclass85_0.bool_19 && class28.gclass139_0.MinDistance > 0.0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (gclass221_0_1.double_0 == class27.gclass85_0.XCoord &&
                                        gclass221_0_1.double_1 == class27.gclass85_0.YCoord)
                                    {
                                        gclass221_0_1.double_0 += 100.0;
                                        gclass221_0_1.double_1 += 100.0;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    gclass221_0_1 =
                                        class27.gclass85_0.method_252(gclass221_0_1, class28.gclass139_0.MinDistance);
                                }

                                // ISSUE: reference to a compiler-generated field
                                if (class28.gclass139_0.MoveActionType.MoveActionType == MoveActionType.ExtendedOrbit)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    gclass221_0_1.double_1 -= class28.gclass139_0.OrbDistance;
                                }

                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                Decimal num9 = (Decimal)this.GetDistanceBetween(class27.gclass85_0.XCoord,
                                    class27.gclass85_0.YCoord, gclass221_0_1.double_0, gclass221_0_1.double_1);
                                if (num9 < 1M)
                                    num9 = 0M;
                                // ISSUE: reference to a compiler-generated field
                                if (class27.gclass85_0.System.ActualSystem.DustDensity > 0)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    Decimal num10 = class27.gclass85_0.method_251() * (AuroraUtils.decimal_16 /
                                        class27.gclass85_0.System.ActualSystem.DustDensity);
                                    // ISSUE: reference to a compiler-generated field
                                    if (num10 < class27.gclass85_0.Speed)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.Speed = (int)num10;
                                    }
                                }

                                // ISSUE: reference to a compiler-generated field
                                Decimal num11 = class27.gclass85_0.Speed * num1;
                                Decimal num12 = num11;
                                Decimal decimal_9 = num1;
                                if (num11 >= num9)
                                {
                                    num12 = num9;
                                    decimal_9 *= num9 / num11;
                                }

                                Decimal num13 = decimal_9;
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class27.gclass85_0.ShippingLine == null &&
                                    class27.gclass85_0.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num13 = class27.gclass85_0.method_250(decimal_9);
                                }

                                if (num13 < decimal_9)
                                {
                                    num12 *= num13 / decimal_9;
                                    // ISSUE: reference to a compiler-generated field
                                    GClass221 gclass221_0_2 =
                                        class27.gclass85_0.method_252(gclass221_0_1, (double)(num9 - num12));
                                    // ISSUE: reference to a compiler-generated field
                                    class27.gclass85_0.method_249(gclass221_0_2);
                                    // ISSUE: reference to a compiler-generated field
                                    if (!class27.gclass85_0.Race.NPR)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        this.gclass92_0.method_2(EventType.const_44,
                                            class27.gclass85_0.FleetName +
                                            " cannot complete its current order due to a fuel shortage",
                                            class27.gclass85_0.Race, class27.gclass85_0.System.ActualSystem,
                                            class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                            AuroraEventCategory.Fleet);
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    class27.gclass85_0.bool_20 = true;
                                    num1 = 0;
                                }
                                else if (num12 < num9)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    GClass221 gclass221_0_3 =
                                        class27.gclass85_0.method_252(gclass221_0_1, (double)(num9 - num12));
                                    // ISSUE: reference to a compiler-generated field
                                    class27.gclass85_0.method_249(gclass221_0_3);
                                    num1 = 0;
                                }
                                else
                                {
                                    Decimal num14 = num1 * (num12 / num11);
                                    num1 -= (int)num14;
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (class28.gclass139_0.DestinationType == DestinationType.const_3 &&
                                        (this.Waypoints[class28.gclass139_0.DestinationID].WaypointType ==
                                         WayPointType.POI ||
                                         this.Waypoints[class28.gclass139_0.DestinationID].WaypointType ==
                                         WayPointType.UrgentPOI ||
                                         this.Waypoints[class28.gclass139_0.DestinationID].WaypointType ==
                                         WayPointType.FleetTraining ||
                                         this.Waypoints[class28.gclass139_0.DestinationID].WaypointType ==
                                         WayPointType.Temporary ||
                                         this.Waypoints[class28.gclass139_0.DestinationID].WaypointType ==
                                         WayPointType.FleetWaypoint &&
                                         this.Waypoints[class28.gclass139_0.DestinationID].FleetID ==
                                         class27.gclass85_0.FleetID))
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        this.Waypoints[class28.gclass139_0.DestinationID].WaypointType =
                                            WayPointType.MarkedForDeletion;
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if ((class28.gclass139_0.DestinationType == DestinationType.const_1 ||
                                         class28.gclass139_0.DestinationType == DestinationType.const_10) &&
                                        class28.gclass139_0.MinDistance == 0.0)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.OrbitingBody =
                                            this.SystemBodyRecordDic[class28.gclass139_0.DestinationID];
                                        // ISSUE: reference to a compiler-generated field
                                        if (class28.gclass139_0.Population != null)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.AssignedPopulation = class28.gclass139_0.Population;
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    if (class28.gclass139_0.MoveActionType.MoveActionType == MoveActionType.TransitBySubFleet)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        class27.gclass85_0.bool_20 = true;
                                        // ISSUE: reference to a compiler-generated field
                                        class28.gclass139_0.bool_2 = true;
                                        num1 = 0;
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        foreach (FleetData gclass85_2 in class27.gclass85_0.method_246(
                                                     this.JumpPointDictionary[class28.gclass139_0.DestinationID]))
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            gclass85_2.method_62(class28.gclass139_0);
                                        }

                                        // ISSUE: reference to a compiler-generated field
                                        if (class27.gclass85_0.method_179() == 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.Race.method_302(class27.gclass85_0, false);
                                        }
                                    }
                                    else
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        if (class28.gclass139_0.MoveActionType.MoveActionType != MoveActionType.StandardTransit &&
                                            class28.gclass139_0.MoveActionType.MoveActionType != MoveActionType.SquadronTransit &&
                                            class28.gclass139_0.MoveActionType.MoveActionType != MoveActionType.TransitAndDivideFleet)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.MoveActionType.MoveActionType == MoveActionType.IntraSystemJump)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                LagrangePoint gclass212_0 = this.LagrangePoints[class28.gclass139_0.DestinationItemID];
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_61(gclass212_0);
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_249(gclass221_0_1);
                                            }
                                        }
                                        else
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.DestinationType == DestinationType.const_9 &&
                                                class27.gclass85_0.Race.SpecialNPRID == SpecialNPRIDs.Eldar)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_64(
                                                    this.dictionary_16[class28.gclass139_0.DestinationID], true);
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                bool flag = class27.gclass85_0.method_62(class28.gclass139_0);
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated method
                                                if (class27.gclass85_0.Race.NPR && flag &&
                                                    this.FleetDictionary.Values.FirstOrDefault<FleetData>(class27.func_0 ??
                                                        (class27.func_0 = class27.method_0)) != null)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class27.gclass85_0.list_3.Count == 1)
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        ShipComponent gclass230 = class27.gclass85_0.list_3[0]
                                                            .method_148(false);
                                                        if (gclass230 != null)
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            class27.gclass85_0.method_63(gclass230.int_9 * 1000);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        // ISSUE: reference to a compiler-generated field
                                                        List<FleetData> source = class27.gclass85_0.method_247();
                                                        try
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (class27.gclass85_0.list_3.Count == 0 &&
                                                                source.Count > 0)
                                                            {
                                                                // ISSUE: object of a compiler-generated type is created
                                                                // ISSUE: variable of a compiler-generated type
                                                                GClass0.Class29 class29 = new GClass0.Class29();
                                                                // ISSUE: reference to a compiler-generated field
                                                                class29.gclass85_0 = source[0];
                                                                // ISSUE: reference to a compiler-generated field
                                                                foreach (ShipData gclass40 in class29.gclass85_0
                                                                             .list_3.ToList<ShipData>())
                                                                {
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    gclass40.method_185(class27.gclass85_0, false,
                                                                        false, false, false);
                                                                }

                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                class27.gclass85_0.method_63(
                                                                    class29.gclass85_0.decimal_6 * 1000M);
                                                                // ISSUE: reference to a compiler-generated method
                                                                source = source.Where<FleetData>(class29.method_0)
                                                                    .ToList<FleetData>();
                                                            }
                                                            else
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                if (class27.gclass85_0.list_3.Count > 0 &&
                                                                    source.Count > 0 &&
                                                                    this.JumpPointDictionary[class28.gclass139_0.DestinationID]
                                                                        .JumpGateStrength == 0)
                                                                {
                                                                    // ISSUE: object of a compiler-generated type is created
                                                                    // ISSUE: variable of a compiler-generated type
                                                                    GClass0.Class30 class30 = new GClass0.Class30();
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    class30.gclass85_0 = source[0];
                                                                    // ISSUE: reference to a compiler-generated field
                                                                    foreach (ShipData gclass40 in class30
                                                                                 .gclass85_0.list_3
                                                                                 .ToList<ShipData>())
                                                                    {
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        gclass40.method_185(class27.gclass85_0, false,
                                                                            false, false, false);
                                                                    }

                                                                    // ISSUE: reference to a compiler-generated method
                                                                    source = source.Where<FleetData>(class30.method_0)
                                                                        .ToList<FleetData>();
                                                                }
                                                            }

                                                            foreach (FleetData gclass85_3 in source)
                                                                gclass85_3.method_63(gclass85_3.decimal_6 * 1000M);
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            AuroraUtils.ShowExceptionPopup(ex, 3971);
                                                            return;
                                                        }
                                                    }
                                                }

                                                if (!flag)
                                                {
                                                    // ISSUE: reference to a compiler-generated field
                                                    class27.gclass85_0.method_249(gclass221_0_1);
                                                    // ISSUE: reference to a compiler-generated field
                                                    class27.gclass85_0.bool_20 = true;
                                                    num1 = 0;
                                                    // ISSUE: reference to a compiler-generated field
                                                    if (class27.gclass85_0.Race.NPR)
                                                    {
                                                        foreach (MoveOrder gclass139_2 in list2)
                                                            gclass139_2.bool_2 = true;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    // ISSUE: reference to a compiler-generated field
                                    switch (class28.gclass139_0.MoveActionType.MoveActionType)
                                    {
                                        case MoveActionType.MoveTo:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_242(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.JoinFleet:
                                        case MoveActionType.JoinAndRefuelTargetFleet:
                                        case MoveActionType.JoinAndBeginOverhaul:
                                        case MoveActionType.JoinAsSubFleet:
                                        case MoveActionType.JoinAndRefuelTargetSubFleet:
                                        case MoveActionType.JoinSubFleet:
                                        case MoveActionType.JoinAndAddOrdnanceToFleet:
                                        case MoveActionType.JoinAndAddOrdnanceToSubFleet:
                                        case MoveActionType.JoinAndReplaceOrdnanceInFleet:
                                        case MoveActionType.JoinAndReplaceOrdnanceInSubFleet:
                                        case MoveActionType.JoinAndRemoveOrdnanceFromFleet:
                                        case MoveActionType.JoinAndRemoveOrdnanceFromSubFleet:
                                        case MoveActionType.JoinAndResupplyTargetFleet:
                                        case MoveActionType.JoinAndResupplyTargetSubFleet:
                                        case MoveActionType.JoinRefuelAndResupplyTargetFleet:
                                        case MoveActionType.RefuelResupplyAndAddOrdnanceToTargetFleet:
                                            // ISSUE: reference to a compiler-generated field
                                            FleetData gclass85_1_1 = this.FleetDictionary[class28.gclass139_0.DestinationID];
                                            // ISSUE: reference to a compiler-generated field
                                            if (gclass85_1_1 == class27.gclass85_0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_84,
                                                    class27.gclass85_0.FleetName +
                                                    " has an order to join with itself. While it would be entertaining to watch the attempt, this is not actually possible",
                                                    class27.gclass85_0.Race,
                                                    class27.gclass85_0.System.ActualSystem,
                                                    class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                                    AuroraEventCategory.Fleet);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                List<ShipData> list_22 = class27.gclass85_0.method_176();
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.gclass85_2 = gclass85_1_1;
                                                // ISSUE: reference to a compiler-generated field
                                                switch (class28.gclass139_0.MoveActionType.MoveActionType)
                                                {
                                                    case MoveActionType.JoinAndRefuelTargetFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_38(AuroraRefuelStatus.Fleet);
                                                        break;
                                                    case MoveActionType.JoinAndBeginOverhaul:
                                                        if (gclass85_1_1.AssignedPopulation != null)
                                                        {
                                                            if (gclass85_1_1.AssignedPopulation.method_62(
                                                                    AuroraProductionCategory.MaintenanceFacility) < 1M)
                                                            {
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                // ISSUE: reference to a compiler-generated field
                                                                this.gclass92_0.method_2(EventType.const_84,
                                                                    $"{class27.gclass85_0.FleetName} has an order to begin an overhaul after joining {gclass85_1_1.FleetName}, but the target fleet is not in a location with maintenance facilities",
                                                                    class27.gclass85_0.Race,
                                                                    class27.gclass85_0.System.ActualSystem,
                                                                    class27.gclass85_0.XCoord,
                                                                    class27.gclass85_0.YCoord,
                                                                    AuroraEventCategory.Fleet);
                                                                break;
                                                            }

                                                            // ISSUE: reference to a compiler-generated field
                                                            class27.gclass85_0.method_68();
                                                            break;
                                                        }

                                                        break;
                                                    case MoveActionType.JoinAsSubFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        SubFleet gclass84 =
                                                            gclass85_1_1.method_89(class27.gclass85_0.FleetName);
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass84.AnchorFleet = class27.gclass85_0.AnchorFleet;
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass84.gclass117_0 = class27.gclass85_0.gclass117_0;
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass84.AnchorFleetBearingOffset = class27.gclass85_0.AnchorFleetBearingOffset;
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass84.AnchorFleetDistance = class27.gclass85_0.AnchorFleetDistance;
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass84.bGuardNearestHostileContact = class27.gclass85_0.bGuardNearestHostileContact;
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass84.bGuardNearestKnownWarship = class27.gclass85_0.bGuardNearestKnownWarship;
                                                        // ISSUE: reference to a compiler-generated field
                                                        gclass84.bUseAnchorDestination = class27.gclass85_0.bUseAnchorDestination;
                                                        // ISSUE: reference to a compiler-generated field
                                                        foreach (ShipData gclass40 in class27.gclass85_0
                                                                     .method_176()
                                                                     .Where<ShipData>(gclass40_0 =>
                                                                         gclass40_0.gclass84_0 == null)
                                                                     .ToList<ShipData>())
                                                            gclass40.gclass84_0 = gclass84;
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated method
                                                        using (List<SubFleet>.Enumerator enumerator =
                                                               this.SubFleetDictionary.Values
                                                                   .Where<SubFleet>(class27.func_1 ??
                                                                       (class27.func_1 = class27.method_1))
                                                                   .ToList<SubFleet>().GetEnumerator())
                                                        {
                                                            while (enumerator.MoveNext())
                                                            {
                                                                SubFleet current = enumerator.Current;
                                                                current.ParentFleet = gclass85_1_1;
                                                                if (current.ParentSubFleet == null)
                                                                    current.ParentSubFleet = gclass84;
                                                            }

                                                            break;
                                                        }
                                                    case MoveActionType.JoinAndRefuelTargetSubFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_38(AuroraRefuelStatus.Subfleet);
                                                        break;
                                                    case MoveActionType.JoinSubFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        if (this.SubFleetDictionary.ContainsKey(class28.gclass139_0.DestinationItemID))
                                                        {
                                                            // ISSUE: reference to a compiler-generated field
                                                            if (this.SubFleetDictionary[class28.gclass139_0.DestinationItemID]
                                                                    .ParentFleet == gclass85_1_1)
                                                            {
                                                                using (List<ShipData>.Enumerator enumerator =
                                                                       list_22.GetEnumerator())
                                                                {
                                                                    while (enumerator.MoveNext())
                                                                    {
                                                                        // ISSUE: reference to a compiler-generated field
                                                                        enumerator.Current.gclass84_0 =
                                                                            this.SubFleetDictionary[
                                                                                class28.gclass139_0.DestinationItemID];
                                                                    }

                                                                    break;
                                                                }
                                                            }

                                                            break;
                                                        }

                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated field
                                                        this.gclass92_0.method_2(EventType.const_84,
                                                            class27.gclass85_0.FleetName +
                                                            " has an order to join a sub-fleet that no longer exists. Therefore, the fleet will join with the original parent fleet of the sub-fleet",
                                                            class27.gclass85_0.Race,
                                                            class27.gclass85_0.System.ActualSystem,
                                                            class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                                            AuroraEventCategory.Fleet);
                                                        break;
                                                    case MoveActionType.JoinAndAddOrdnanceToFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_40(AuroraOrdnanceTransferStatus
                                                            .LoadFleet);
                                                        break;
                                                    case MoveActionType.JoinAndAddOrdnanceToSubFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_40(AuroraOrdnanceTransferStatus
                                                            .LoadSubFleet);
                                                        break;
                                                    case MoveActionType.JoinAndReplaceOrdnanceInFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_40(AuroraOrdnanceTransferStatus
                                                            .ReplaceFleet);
                                                        break;
                                                    case MoveActionType.JoinAndReplaceOrdnanceInSubFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_40(AuroraOrdnanceTransferStatus
                                                            .ReplaceSubFleet);
                                                        break;
                                                    case MoveActionType.JoinAndRemoveOrdnanceFromFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_40(AuroraOrdnanceTransferStatus
                                                            .RemoveFleet);
                                                        break;
                                                    case MoveActionType.JoinAndRemoveOrdnanceFromSubFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_40(AuroraOrdnanceTransferStatus
                                                            .RemoveSubFleet);
                                                        break;
                                                    case MoveActionType.JoinAndResupplyTargetFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_39(AuroraResupplyStatus.Fleet);
                                                        break;
                                                    case MoveActionType.JoinAndResupplyTargetSubFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_39(AuroraResupplyStatus.Subfleet);
                                                        break;
                                                    case MoveActionType.JoinRefuelAndResupplyTargetFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_38(AuroraRefuelStatus.Fleet);
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_39(AuroraResupplyStatus.Fleet);
                                                        break;
                                                    case MoveActionType.RefuelResupplyAndAddOrdnanceToTargetFleet:
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_38(AuroraRefuelStatus.Fleet);
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_39(AuroraResupplyStatus.Fleet);
                                                        // ISSUE: reference to a compiler-generated field
                                                        class27.gclass85_0.method_40(AuroraOrdnanceTransferStatus
                                                            .LoadFleet);
                                                        break;
                                                }

                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.Race.method_270(list_22, class27.gclass85_0,
                                                    gclass85_1_1, true, false);
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.bool_4 = true;
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            num1 = 0;
                                            break;
                                        case MoveActionType.LoadColonists:
                                        case MoveActionType.LoadAllMinerals:
                                        case MoveActionType.LoadGroundUnitIntoTransportBay:
                                        case MoveActionType.LoadTradeGoods:
                                        case MoveActionType.LoadShipComponent:
                                        case MoveActionType.LoadUnloadMineralsToReserveLevel:
                                        case MoveActionType.LoadInstallation:
                                        case MoveActionType.LoadMineralType:
                                        case MoveActionType.LoadMineralWhenXAvailable:
                                        case MoveActionType.LoadGroundUnitFromStationaryFleet:
                                        case MoveActionType.LoadAllMineralsUntilFull:
                                        case MoveActionType.LoadAssignedGroundTemplates:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_242(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.TimeRequired =
                                                class27.gclass85_0.method_87(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            break;
                                        case MoveActionType.UnloadColonists:
                                        case MoveActionType.UnloadAllMinerals:
                                        case MoveActionType.UnloadGroundUnitFromTransportBay:
                                        case MoveActionType.UnloadAllGroundUnitsFromTransportBay:
                                        case MoveActionType.UnloadAllInstallations:
                                        case MoveActionType.UnloadTradeGoods:
                                        case MoveActionType.UnloadShipComponent:
                                        case MoveActionType.UnloadInstallation:
                                        case MoveActionType.UnloadMineralType:
                                        case MoveActionType.UnloadAllShipComponents:
                                        case MoveActionType.OrbitalDropGroundUnit:
                                        case MoveActionType.OrbitalDropAllGroundUnits:
                                        case MoveActionType.TransferAllInstallations:
                                        case MoveActionType.TransferAllMinerals:
                                        case MoveActionType.TransferInstallation:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_242(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.TimeRequired =
                                                class27.gclass85_0.method_88(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            break;
                                        case MoveActionType.RefuelFromColony:
                                        case MoveActionType.GeologicalSurvey:
                                        case MoveActionType.GravitationalSurvey:
                                        case MoveActionType.LoadOrdnanceFromColony:
                                        case MoveActionType.TransferFuelToColony:
                                        case MoveActionType.ResupplyFromColony:
                                        case MoveActionType.TransferMaintenanceSuppliesToColony:
                                        case MoveActionType.UnloadOrdnanceToColony:
                                        case MoveActionType.LoadFromOrdnanceTransferHub:
                                        case MoveActionType.UnloadToOrdnanceTransferHub:
                                        case MoveActionType.ReplaceOrdnanceAtColony:
                                        case MoveActionType.RefuelAndResupplyFromColony:
                                        case MoveActionType.RefuelResupplyAndLoadOrdnanceFromColony:
                                        case MoveActionType.RefuelFromStationaryTankers:
                                        case MoveActionType.SalvageInstallations:
                                        case MoveActionType.ResupplyFromStationarySupplyShip:
                                        case MoveActionType.RefuelStationaryFleet:
                                        case MoveActionType.ResupplyStationaryFleet:
                                        case MoveActionType.RefuelStationaryFleetToMinimum:
                                        case MoveActionType.RefuelToMinimumFromStationaryTankers:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_242(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            break;
                                        case MoveActionType.DivideFleetIntoSingleShips:
                                        case MoveActionType.TransitAndDivideFleet:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_66();
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.bool_4 = true;
                                            num1 = 0;
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_27,
                                                class27.gclass85_0.FleetName +
                                                " has carried out orders to divide into single ships",
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            break;
                                        case MoveActionType.RefuelFromOwnTankers:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            foreach (ShipData gclass40 in this.Ships.Values
                                                         .Where<ShipData>(class27.func_2 ??
                                                                               (class27.func_2 = class27.method_2))
                                                         .ToList<ShipData>())
                                                gclass40.auroraRefuelStatus_0 = AuroraRefuelStatus.Fleet;
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.LandOnAssignedMothership:
                                        case MoveActionType.LandOnAssignedMothershipAsSubFleet:
                                            bool bool_25 = false;
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.MoveActionType.MoveActionType == MoveActionType.LandOnAssignedMothershipAsSubFleet)
                                                bool_25 = true;
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.bool_4 =
                                                class27.gclass85_0.method_67(class28.gclass139_0, bool_25);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            num1 = 0;
                                            break;
                                        case MoveActionType.FollowTarget:
                                            num1 = 0;
                                            break;
                                        case MoveActionType.StabilizeJumpPoint:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.TimeRequired = class27.gclass85_0.method_83();
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.TimeRequired == 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_27,
                                                    class27.gclass85_0.FleetName +
                                                    " cannot stabilise a jump point as no ships within the fleet have stabilisation capability",
                                                    class27.gclass85_0.Race,
                                                    class27.gclass85_0.System.ActualSystem,
                                                    class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                                    AuroraEventCategory.Fleet);
                                                num1 = 0;
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                                break;
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            break;
                                        case MoveActionType.ActivateShields:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_57(true);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.DeactivateShields:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_57(false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.DropOffCommander:
                                            // ISSUE: reference to a compiler-generated field
                                            if (this.dictionary_42.ContainsKey(class28.gclass139_0.DestinationItemID))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                this.dictionary_42[class28.gclass139_0.DestinationItemID].method_40(false);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.DetachNonSurveyShips:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_74(GEnum110.const_3, 0, false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.RescueSurvivors:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_56(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.UnloadSurvivors:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_58(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.DetachTankers:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_74(GEnum110.const_0, 1, false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.DetachColliers:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_74(GEnum110.const_1, 1, false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.ActiveSensorsOn:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_60(true);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.ActiveSensorsOff:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_60(false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.SalvageWreck:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.TimeRequired =
                                                class27.gclass85_0.method_85(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.TimeRequired == 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_27,
                                                    class27.gclass85_0.FleetName +
                                                    " cannot salvage the target wreck as no ships within the fleet have salvage capability",
                                                    class27.gclass85_0.Race,
                                                    class27.gclass85_0.System.ActualSystem,
                                                    class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                                    AuroraEventCategory.Fleet);
                                                num1 = 0;
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                                break;
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            Wreck gclass233 =
                                                this.Wrecks.Values.FirstOrDefault<Wreck>(class28.func_0 ??
                                                    (class28.func_0 = class28.method_0));
                                            if (gclass233 != null)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.OrbitingBody = gclass233.OrbitingBody;
                                                break;
                                            }

                                            break;
                                        case MoveActionType.SalvageIntactShip:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.TimeRequired =
                                                class27.gclass85_0.method_86(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.TimeRequired == 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_27,
                                                    class27.gclass85_0.FleetName +
                                                    " cannot salvage the target ship as no ships within the fleet have salvage capability",
                                                    class27.gclass85_0.Race,
                                                    class27.gclass85_0.System.ActualSystem,
                                                    class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                                    AuroraEventCategory.Fleet);
                                                num1 = 0;
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                                break;
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            break;
                                        case MoveActionType.SendMessage:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            this.gclass92_0.method_2(EventType.const_67, class28.gclass139_0.MessageText,
                                                class27.gclass85_0.Race,
                                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.BeginOverhaul:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_242(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_68();
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            num1 = 0;
                                            break;
                                        case MoveActionType.AbsorbTargetFleet:
                                            // ISSUE: reference to a compiler-generated field
                                            if (this.FleetDictionary.ContainsKey(class28.gclass139_0.DestinationID))
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_73(
                                                    this.FleetDictionary[class28.gclass139_0.DestinationID], null);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.ActivateFriendlyTransponder:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_59(GEnum78.const_1);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.DeactivateTransponder:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_59(GEnum78.const_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.ResupplyFromOwnSupplyShips:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated method
                                            foreach (ShipData gclass40 in this.Ships.Values
                                                         .Where<ShipData>(class27.func_3 ??
                                                                               (class27.func_3 = class27.method_3))
                                                         .ToList<ShipData>())
                                                gclass40.auroraResupplyStatus_0 = AuroraResupplyStatus.Fleet;
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.LaunchMissilesAt:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_11();
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.Picket:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.Speed = 1;
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.AttemptBoardingActionAllFormations:
                                        case MoveActionType.AttemptBoardingAction:
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.Race.SpecialNPRID == SpecialNPRIDs.StarSwarm)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_104(class28.gclass139_0);
                                            }
                                            else
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                class27.gclass85_0.method_103(class28.gclass139_0);
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.LandOnSpecifiedMothershipWithoutAssignment:
                                        case MoveActionType.LandOnSpecifiedMothershipAndAssignIt:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.bool_4 =
                                                class27.gclass85_0.method_69(class28.gclass139_0, false, false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            num1 = 0;
                                            break;
                                        case MoveActionType.TractorSpecifiedShip:
                                        case MoveActionType.TractorAnyShipInFleet:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_50(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.TractorSpecifiedShipyard:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_51(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.ReleaseTractoredShips:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_242(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_48(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.ReleaseTractoredShipyards:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_49(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.AddReplacementCrew:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_105();
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.DetachSupplyShips:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_74(GEnum110.const_2, 1, false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.ProvideGroundSupport:
                                        case MoveActionType.ProvideGroundCap:
                                        case MoveActionType.PlanetarySearchAndDestroy:
                                        case MoveActionType.PlanetaryFlakSuppression:
                                        case MoveActionType.ProvideOrbitalBombardmentSupport:
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            num1 = 0;
                                            break;
                                        case MoveActionType.RamTargetShip:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_14(this.FleetDictionary[class28.gclass139_0.DestinationID]);
                                            num1 = 0;
                                            break;
                                        case MoveActionType.StabilizeNewLagrangePoint:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.TimeRequired =
                                                class27.gclass85_0.method_84(
                                                    this.SystemBodyRecordDic[class28.gclass139_0.DestinationID], true);
                                            // ISSUE: reference to a compiler-generated field
                                            if (class28.gclass139_0.TimeRequired == 0)
                                            {
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                // ISSUE: reference to a compiler-generated field
                                                this.gclass92_0.method_2(EventType.const_27,
                                                    class27.gclass85_0.FleetName +
                                                    " cannot stabilise a new lagrange point as no ships within the fleet have stabilisation capability",
                                                    class27.gclass85_0.Race,
                                                    class27.gclass85_0.System.ActualSystem,
                                                    class27.gclass85_0.XCoord, class27.gclass85_0.YCoord,
                                                    AuroraEventCategory.Fleet);
                                                num1 = 0;
                                                // ISSUE: reference to a compiler-generated field
                                                class28.gclass139_0.bool_2 = true;
                                                break;
                                            }

                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bArrived = true;
                                            break;
                                        case MoveActionType.ActivateTransponderForAll:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_59(GEnum78.const_2);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.LandOnSpecifiedMothershipAsSquadron:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.bool_4 =
                                                class27.gclass85_0.method_69(class28.gclass139_0, true, false);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            num1 = 0;
                                            break;
                                        case MoveActionType.LandAndJoinSpecifiedSquadron:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.bool_4 =
                                                class27.gclass85_0.method_69(class28.gclass139_0, false, true);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            num1 = 0;
                                            break;
                                        case MoveActionType.TransferPrisonersToShip:
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_55(class28.gclass139_0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                        case MoveActionType.CreateFleetWaypoint:
                                            // ISSUE: reference to a compiler-generated field
                                            class27.gclass85_0.method_0(true, null, null, 0.0, 0.0);
                                            // ISSUE: reference to a compiler-generated field
                                            class28.gclass139_0.bool_2 = true;
                                            break;
                                    }
                                }

                                // ISSUE: reference to a compiler-generated field
                                foreach (ShipData gclass40 in class27.gclass85_0.method_177())
                                    gclass40.decimal_10 += num12;
                                if (this.bool_0)
                                    num1 = 0;
                            }

                            // ISSUE: reference to a compiler-generated field
                            if (class28.gclass139_0.bool_2)
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.method_170(class28.gclass139_0.Description);
                                // ISSUE: reference to a compiler-generated field
                                if (class27.gclass85_0.checkState_0 == CheckState.Checked)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    class27.gclass85_0.method_33(class28.gclass139_0);
                                }
                            }

                            // ISSUE: reference to a compiler-generated field
                            if (!class27.gclass85_0.bool_4)
                            {
                                int decimal_9 = num2 - num1;
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.method_109(decimal_9);
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.method_110(decimal_9);
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.method_112(decimal_9);
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.method_111(decimal_9);
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.method_121(decimal_9);
                            }

                            if (num1 == 0)
                                break;
                        }

                        if (num1 == 0)
                            break;
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class27.gclass85_0.MoveOrderDictionary = class27.gclass85_0.MoveOrderDictionary
                        .Where<KeyValuePair<int, MoveOrder>>(keyValuePair_0 => !keyValuePair_0.Value.bool_2)
                        .ToDictionary<KeyValuePair<int, MoveOrder>, int, MoveOrder>(
                            keyValuePair_0 => keyValuePair_0.Key, keyValuePair_0 => keyValuePair_0.Value);
                    // ISSUE: reference to a compiler-generated field
                    class27.gclass85_0.bool_18 = true;
                    // ISSUE: reference to a compiler-generated field
                    if (class27.gclass85_0.MoveOrderDictionary.Count == 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class27.gclass85_0.genum48_0 = GEnum48.const_0;
                        // ISSUE: reference to a compiler-generated field
                        if (class27.gclass85_0.NPRSomething != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class27.gclass85_0.NPRSomething.bRedeployOrderGiven = false;
                            // ISSUE: reference to a compiler-generated field
                            class27.gclass85_0.NPRSomething.gclass202_0 = null;
                            // ISSUE: reference to a compiler-generated field
                            if (!class27.gclass85_0.System.bool_6)
                            {
                                // ISSUE: reference to a compiler-generated field
                                class27.gclass85_0.NPRSomething.bool_3 = false;
                            }
                        }

                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if ((class27.gclass85_0.StandingOrdersDictionary.Count == 0 ||
                             class27.gclass85_0.StandingOrdersDictionary.Count > 0 && class27.gclass85_0.bIgnoreStanding) &&
                            class27.gclass85_0.ShippingLine == null && !class27.gclass85_0.Race.NPR)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            string string_0 =
                                $"{class27.gclass85_0.FleetName} has completed orders. {class27.gclass85_0.method_165()}";
                            // ISSUE: reference to a compiler-generated field
                            if (class27.gclass85_0.bool_4)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (class27.gclass85_0.gclass85_2 != null)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    string_0 =
                                        $"{class27.gclass85_0.FleetName} has completed orders and joined {class27.gclass85_0.gclass85_2.FleetName}. {class27.gclass85_0.gclass85_2.method_165()}";
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (class27.gclass85_0.gclass85_3 != null)
                                    {
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        // ISSUE: reference to a compiler-generated field
                                        string_0 =
                                            $"{class27.gclass85_0.FleetName} has completed orders and landed on mothership(s) within {class27.gclass85_0.gclass85_3.FleetName}. {class27.gclass85_0.gclass85_3.method_165()}";
                                    }
                                }
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass92_0.method_2(EventType.const_27, string_0, class27.gclass85_0.Race,
                                class27.gclass85_0.System.ActualSystem, class27.gclass85_0.XCoord,
                                class27.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                        }
                    }
                }
            }

            try
            {
                this.FleetDictionary = this.FleetDictionary
                    .Where<KeyValuePair<int, FleetData>>(keyValuePair_0 => !keyValuePair_0.Value.bool_4)
                    .ToDictionary<KeyValuePair<int, FleetData>, int, FleetData>(keyValuePair_0 => keyValuePair_0.Key,
                        keyValuePair_0 => keyValuePair_0.Value);
                if (this.FleetDictionary.Values
                        .Where<FleetData>(gclass85_0 => gclass85_0.Race.NPR && gclass85_0.list_3.Count == 0)
                        .ToList<FleetData>().Count <= 0)
                    return;
                this.FleetDictionary = this.FleetDictionary
                    .Where<KeyValuePair<int, FleetData>>(keyValuePair_0 =>
                        !keyValuePair_0.Value.Race.NPR || keyValuePair_0.Value.list_3.Count > 0)
                    .ToDictionary<KeyValuePair<int, FleetData>, int, FleetData>(keyValuePair_0 => keyValuePair_0.Key,
                        keyValuePair_0 => keyValuePair_0.Value);
            }
            catch (Exception ex)
            {
                AuroraUtils.ShowExceptionPopup(ex, 3970);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1414);
        }
    }

    public void method_48(Decimal decimal_13)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class31 class31 = new GClass0.Class31();
        // ISSUE: reference to a compiler-generated field
        class31.decimal_0 = decimal_13;
        // ISSUE: reference to a compiler-generated field
        class31.gclass0_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            List<FleetData> list = this.FleetDictionary.Values.Where<FleetData>(class31.method_0).ToList<FleetData>();
            foreach (FleetData gclass85 in list)
            {
                if (!this.FleetDictionary.Values.Contains<FleetData>(gclass85.AnchorFleet))
                    gclass85.AnchorFleet = null;
                if (gclass85.gclass117_0 != null &&
                    !gclass85.Race.dictionary_12.Values.Contains<GClass117>(gclass85.gclass117_0))
                    gclass85.gclass117_0 = null;
            }

            foreach (FleetData gclass85 in list.Where<FleetData>(gclass85_0 => gclass85_0.AnchorFleet != null)
                         .ToList<FleetData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class32 class32 = new GClass0.Class32();
                // ISSUE: reference to a compiler-generated field
                class32.class31_0 = class31;
                // ISSUE: reference to a compiler-generated field
                class32.gclass85_0 = gclass85;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class32.gclass85_0.System == class32.gclass85_0.AnchorFleet.System)
                {
                    GClass221 gclass221_0_1 = new GClass221(0.0, 0.0);
                    GClass221 gclass221 = new GClass221(0.0, 0.0);
                    bool flag = false;
                    // ISSUE: reference to a compiler-generated field
                    if (class32.gclass85_0.gclass117_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated method
                        Contact gclass65 = this.Contacts.Values.FirstOrDefault<Contact>(class32.method_0);
                        if (gclass65 != null)
                        {
                            flag = true;
                            gclass221.double_0 = gclass65.Xcor;
                            gclass221.double_1 = gclass65.Ycor;
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (!flag && class32.gclass85_0.bGuardNearestKnownWarship)
                    {
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        Contact gclass65 = this.Contacts.Values.Where<Contact>(class32.method_1)
                            .Where<Contact>(gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile)
                            .Where<Contact>(class32.method_2).OrderBy<Contact, double>(class32.method_3)
                            .FirstOrDefault<Contact>();
                        if (gclass65 != null)
                        {
                            flag = true;
                            gclass221.double_0 = gclass65.Xcor;
                            gclass221.double_1 = gclass65.Ycor;
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (!flag && class32.gclass85_0.bGuardNearestHostileContact)
                    {
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        Contact gclass65 = this.Contacts.Values.Where<Contact>(class32.method_4)
                            .Where<Contact>(gclass65_0 => gclass65_0.method_5() == AuroraContactStatus.Hostile)
                            .OrderBy<Contact, double>(class32.method_5).FirstOrDefault<Contact>();
                        if (gclass65 != null)
                        {
                            flag = true;
                            gclass221.double_0 = gclass65.Xcor;
                            gclass221.double_1 = gclass65.Ycor;
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (!flag && class32.gclass85_0.bUseAnchorDestination)
                    {
                        // ISSUE: reference to a compiler-generated field
                        MoveOrder gclass139 = class32.gclass85_0.AnchorFleet.MoveOrderDictionary.Values
                            .OrderBy<MoveOrder, int>(gclass139_0 => gclass139_0.OrderValue).FirstOrDefault<MoveOrder>();
                        if (gclass139 != null)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            gclass221 = this.method_53(gclass139.DestinationType, gclass139.DestinationID,
                                gclass139.StartSystem.ActualSystem, null, class32.gclass85_0, gclass139.MinDistance,
                                class32.class31_0.decimal_0);
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    double num1 = this.method_591(class32.gclass85_0.AnchorFleet.XCoord,
                        class32.gclass85_0.AnchorFleet.YCoord, gclass221.double_0, gclass221.double_1) - 180.0;
                    if (num1 < 0.0)
                        num1 += 360.0;
                    // ISSUE: reference to a compiler-generated field
                    double double_11 = num1 + class32.gclass85_0.AnchorFleetBearingOffset;
                    if (double_11 >= 360.0)
                        double_11 -= 360.0;
                    if (double_11 < 0.0)
                        double_11 += 360.0;
                    if (gclass221.double_0 == 0.0 && gclass221.double_1 == 0.0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass221_0_1.double_0 = class32.gclass85_0.AnchorFleet.XCoord;
                        // ISSUE: reference to a compiler-generated field
                        gclass221_0_1.double_1 = class32.gclass85_0.AnchorFleet.YCoord;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        gclass221_0_1 = this.method_592(class32.gclass85_0.AnchorFleet.XCoord,
                            class32.gclass85_0.AnchorFleet.YCoord, class32.gclass85_0.AnchorFleetDistance, double_11);
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class32.gclass85_0.bUseMaximumSpeed)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.Speed = class32.gclass85_0.method_195();
                    }

                    // ISSUE: reference to a compiler-generated field
                    class32.gclass85_0.method_6();
                    // ISSUE: reference to a compiler-generated field
                    class32.gclass85_0.OrbitingBody = null;
                    // ISSUE: reference to a compiler-generated field
                    class32.gclass85_0.bool_21 = true;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    Decimal num2 = (Decimal)this.GetDistanceBetween(class32.gclass85_0.XCoord, class32.gclass85_0.YCoord,
                        gclass221_0_1.double_0, gclass221_0_1.double_1);
                    if (num2 < 1M)
                        num2 = 0M;
                    // ISSUE: reference to a compiler-generated field
                    if (class32.gclass85_0.System.ActualSystem.DustDensity > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        Decimal num3 = class32.gclass85_0.method_251() * (AuroraUtils.decimal_16 /
                                                                          class32.gclass85_0.System.ActualSystem
                                                                              .DustDensity);
                        // ISSUE: reference to a compiler-generated field
                        if (num3 < class32.gclass85_0.Speed)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class32.gclass85_0.Speed = (int)num3;
                        }
                    }

                    // ISSUE: reference to a compiler-generated field
                    Decimal num4 = class32.gclass85_0.Speed * this.SubPulseLength;
                    Decimal num5 = num4;
                    Decimal int132 = this.SubPulseLength;
                    if (num4 >= num2)
                    {
                        num5 = num2;
                        int132 *= num2 / num4;
                    }

                    Decimal num6 = int132;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class32.gclass85_0.ShippingLine == null &&
                        class32.gclass85_0.Race.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                    {
                        // ISSUE: reference to a compiler-generated field
                        num6 = class32.gclass85_0.method_250(int132);
                    }

                    if (num6 < int132)
                    {
                        num5 *= num6 / int132;
                        // ISSUE: reference to a compiler-generated field
                        GClass221 gclass221_0_2 = class32.gclass85_0.method_252(gclass221_0_1, (double)(num2 - num5));
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_249(gclass221_0_2);
                        // ISSUE: reference to a compiler-generated field
                        if (!class32.gclass85_0.Race.NPR)
                        {
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            this.gclass92_0.method_2(EventType.const_44,
                                class32.gclass85_0.FleetName +
                                " cannot complete its current order due to a fuel shortage",
                                class32.gclass85_0.Race, class32.gclass85_0.System.ActualSystem,
                                class32.gclass85_0.XCoord, class32.gclass85_0.YCoord, AuroraEventCategory.Fleet);
                        }

                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.bool_20 = true;
                    }
                    else if (num5 < num2)
                    {
                        // ISSUE: reference to a compiler-generated field
                        GClass221 gclass221_0_3 = class32.gclass85_0.method_252(gclass221_0_1, (double)(num2 - num5));
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_249(gclass221_0_3);
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_249(gclass221_0_1);
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_109(this.SubPulseLength);
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_110(this.SubPulseLength);
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_112(this.SubPulseLength);
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_111(this.SubPulseLength);
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.method_121(this.SubPulseLength);
                    }

                    // ISSUE: reference to a compiler-generated field
                    foreach (ShipData gclass40 in class32.gclass85_0.method_177())
                        gclass40.decimal_10 += num5;
                    // ISSUE: reference to a compiler-generated field
                    class32.gclass85_0.genum48_0 = GEnum48.const_0;
                    // ISSUE: reference to a compiler-generated field
                    if (class32.gclass85_0.NPRSomething != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.NPRSomething.bRedeployOrderGiven = false;
                        // ISSUE: reference to a compiler-generated field
                        class32.gclass85_0.NPRSomething.gclass202_0 = null;
                        // ISSUE: reference to a compiler-generated field
                        if (!class32.gclass85_0.System.bool_6)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class32.gclass85_0.NPRSomething.bool_3 = false;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3335);
        }
    }

    public void method_49(FleetData gclass85_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class33 class33 = new GClass0.Class33();
        // ISSUE: reference to a compiler-generated field
        class33.gclass85_0 = gclass85_1;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (Contact gclass65 in this.Contacts.Values
                         .Where<Contact>(gclass65_0 =>
                             gclass65_0.ContactType == AuroraContactType.Ship && gclass65_0.TargetShip != null)
                         .Where<Contact>(class33.method_0).ToList<Contact>())
            {
                // ISSUE: reference to a compiler-generated field
                gclass65.IncrementStartX = class33.gclass85_0.XCoord;
                // ISSUE: reference to a compiler-generated field
                gclass65.IncrementStartY = class33.gclass85_0.YCoord;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1415);
        }
    }
    
        public void method_54(
        int int_136,
        int int_137,
        int int_138,
        Decimal decimal_13,
        double double_8,
        double double_9,
        CheckState checkState_3,
        int int_139,
        int int_140,
        int int_141,
        CheckState checkState_4,
        int int_142,
        int int_143,
        int int_144,
        int int_145)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass0.Class34 class34 = new GClass0.Class34();
            Cursor.Current = Cursors.WaitCursor;
            if (double_8 < 0.0)
                double_8 = 0.0;
            if (double_9 < 5.0 && this.UseKnownStars == 1)
            {
                int num = (int)MessageBox.Show(
                    "The Max NPR distance was set to an invalid number, so it has been changed to 25");
                double_9 = 25.0;
            }

            this.gclass92_0 = new GClass92(this);
            this.RaiderSystems = int_139;
            this.SwarmSystems = int_140;
            this.InvaderSystems = int_141;
            this.MinimumSwarmRP = int_145;
            this.method_635();
            this.AddRandomBlackHoleSystemsToDB();
            this.gclass92_0.method_0();
            // ISSUE: reference to a compiler-generated field
            class34.gclass200_0 = this.method_643(null, GEnum94.const_0, 0, null, true, int_138, decimal_13,
                AuroraUtils.smethod_27(checkState_3), false, true);
            // ISSUE: reference to a compiler-generated method
            SystemBodyData gclass1_1 =
                this.SystemBodyRecordDic.Values.FirstOrDefault<SystemBodyData>(class34.method_0);
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list1 = this.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(class34.method_1).ToList<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            this.method_414(10000.0, class34.gclass200_0, null, true);
            Star197 gclass197 =
                this.StarDictionary.Values.FirstOrDefault<Star197>(gclass197_0 => gclass197_0.SystemData.IsSolSystem);
            if (gclass197 != null)
            {
                gclass197.method_8();
                // ISSUE: reference to a compiler-generated field
                if (class34.gclass200_0.KnownSystemData == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class34.gclass200_0.KnownSystemData = this.KnownSystemDataDictionary[0];
                }

                gclass197.genum30_0 =
                    this.SolDisaster == GEnum30.const_4 || this.SolDisaster == GEnum30.const_5 ||
                    this.SolDisaster == GEnum30.const_6 || this.SolDisaster == GEnum30.const_1 ||
                    this.SolDisaster == GEnum30.const_2 || this.SolDisaster == GEnum30.const_3
                        ? this.tacticalMap_0.gclass0_1.SolDisaster
                        : GEnum30.const_0;
            }

            int num1 = 0;
            for (int index = 1; index <= int_136; ++index)
            {
                GameRace gclass21 = this.method_536(gclass1_1, 0, GEnum82.const_0, true, false, false, true,
                    SpecialNPRIDs.const_0, 0, false, null, 0);
                if (gclass21 != null)
                {
                    ++num1;
                    foreach (SystemBodyData gclass1 in list1)
                    {
                        if (!gclass1.dictionary_1.ContainsKey(gclass21.RaceID))
                            gclass1.dictionary_1.Add(gclass21.RaceID, new RaceSystemBodyName()
                            {
                                Race = gclass21,
                                Name = gclass1.Name,
                                SystemBodyID = gclass1.SystemBodyID
                            });
                    }
                }
            }

            if (num1 == 0)
                return;
            for (int index = 1; index <= int_137; ++index)
            {
                // ISSUE: reference to a compiler-generated field
                GameRace gclass21_2 = this.method_60(class34.gclass200_0, double_8, double_9,
                    SpecialNPRIDs.const_0, checkState_4, 0);
                if (gclass21_2 != null)
                {
                    int int_136_1 = this.NPRBaseTransits + AuroraUtils.GetRandomInteger(this.NPRRandomTransits);
                    int int_137_1 = this.NPRMaxSystems;
                    if (gclass21_2.gclass143_0 != null)
                    {
                        if (gclass21_2.gclass143_0.int_8 > 0 || gclass21_2.gclass143_0.int_9 > 0)
                            int_136_1 = gclass21_2.gclass143_0.int_8 +
                                        AuroraUtils.GetRandomInteger(gclass21_2.gclass143_0.int_9);
                        if (gclass21_2.gclass143_0.int_10 > 0)
                            int_137_1 = gclass21_2.gclass143_0.int_10;
                    }

                    if (int_136_1 != 0)
                    {
                        List<StarSystem> list2 = this.StarSystemDictionary.Values.ToList<StarSystem>();
                        this.method_443(gclass21_2, gclass21_2.gclass194_0, gclass21_2.gclass146_0.SystemBodyData, list2,
                            int_136_1, int_137_1);
                    }
                }
            }

            // ISSUE: reference to a compiler-generated field
            this.method_60(class34.gclass200_0, double_8, double_9, SpecialNPRIDs.Eldar, CheckState.Unchecked,
                int_144);
            this.method_536(gclass1_1, 1, GEnum82.const_0, false, true, true, false, SpecialNPRIDs.Precursor, 0, false,
                null, int_142);
            this.method_536(gclass1_1, 1, GEnum82.const_0, false, true, true, false, SpecialNPRIDs.const_3, 0, false,
                null, int_143);
            this.method_63();
            Cursor.Current = Cursors.Default;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1419);
        }
    }
    
        public void method_58(
        GameRace gclass21_2,
        Species gclass194_1,
        RacialSystemSurvey gclass202_0,
        List<ShipClass> list_33,
        OperationalGroup gclass9_0,
        double double_8,
        double double_9,
        NavalAdminCommand gclass83_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class38 class38 = new GClass0.Class38();
        // ISSUE: reference to a compiler-generated field
        class38.gclass21_0 = gclass21_2;
        // ISSUE: reference to a compiler-generated field
        class38.gclass9_0 = gclass9_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            int int_72 = this.FleetDictionary.Values.Where<FleetData>(class38.method_0).Count<FleetData>() + 1;
            // ISSUE: reference to a compiler-generated field
            string string_10 = $"{class38.gclass9_0.string_0} {AuroraUtils.smethod_33(int_72)}";
            int num = int_72 + 1;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            FleetData gclass85_0 = class38.gclass21_0.method_308(string_10, gclass83_0, gclass202_0, double_8, double_9,
                null, class38.gclass9_0.OperationalGroupId);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            foreach (RaceOperationalGroupElement gclass11 in class38.gclass9_0.method_0(class38.gclass21_0))
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass0.Class39 class39 = new GClass0.Class39();
                // ISSUE: reference to a compiler-generated field
                class39.gclass11_0 = gclass11;
                // ISSUE: reference to a compiler-generated method
                ShipClass gclass22_1 = list_33.Where<ShipClass>(gclass22_0 => gclass22_0.Obsolete == 0)
                    .FirstOrDefault<ShipClass>(class39.method_0);
                if (gclass22_1 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    int int0 = class39.gclass11_0.NumShips;
                    for (int index = 1; index <= int0; ++index)
                    {
                        // ISSUE: reference to a compiler-generated field
                        ShipData gclass40 = class38.gclass21_0.method_304(null, null, null, gclass22_1, gclass85_0,
                            null, gclass194_1, null, null, "", 100M, true, true, GEnum20.const_2);
                        // ISSUE: reference to a compiler-generated field
                        if (class39.gclass11_0.AutomatedClassDesign.AutomatedClassDesignTypeID == AutomatedClassDesignType.MilitaryTanker)
                            gclass40.auroraRefuelStatus_0 = AuroraRefuelStatus.Fleet;
                    }

                    List<ShipData> gclass40List = gclass85_0.method_176();
                    if (gclass40List.Count == 1)
                        gclass85_0.FleetName = gclass40List[0].method_187();
                    gclass85_0.StandingOrdersDictionary.Clear();
                    // ISSUE: reference to a compiler-generated field
                    gclass85_0.method_1(1, class38.gclass9_0.gclass136_0);
                    // ISSUE: reference to a compiler-generated field
                    gclass85_0.method_1(2, class38.gclass9_0.gclass136_1);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1420);
        }
    }

    public void method_59(SystemBodyData gclass1_1)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass0.Class40 class40 = new GClass0.Class40();
            SystemBodyData gclass1_1_1 = this.Populations.Values
                .OrderByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.decimal_30)
                .Select<PopulationData, SystemBodyData>(gclass146_0 => gclass146_0.SystemBodyData)
                .FirstOrDefault<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            class40.gclass21_0 = this.method_536(gclass1_1_1, 1, GEnum82.const_0, false, true, true, false,
                SpecialNPRIDs.StarSwarm, 0, false, null, this.MinimumSwarmRP);
            // ISSUE: reference to a compiler-generated field
            Species gclass194_1 = class40.gclass21_0.method_164();
            // ISSUE: reference to a compiler-generated field
            class40.gclass21_0.BioShips = true;
            // ISSUE: reference to a compiler-generated field
            RacialSystemSurvey gclass202_0 = class40.gclass21_0.method_263(gclass1_1.SystemData, null, "", true);
            // ISSUE: reference to a compiler-generated field
            class40.gclass21_0.method_262(gclass1_1.SystemData, 0);
            int num = AuroraUtils.GetRandomInteger(400) + this.DifficultyModifier +
                      (int)((this.GameTime - this.StartTimeSwarm) / AuroraUtils.decimal_29 * 5M);
            // ISSUE: reference to a compiler-generated method
            NavalAdminCommand gclass83_0 = this.NavalAdminCommands.Values.FirstOrDefault<NavalAdminCommand>(class40.method_0);
            // ISSUE: reference to a compiler-generated method
            List<ShipClass> list = this.ShipClasses.Values.Where<ShipClass>(class40.method_1).ToList<ShipClass>();
            int int_136_1 = 0;
            int int_136_2 = 0;
            int int_136_3 = 0;
            OperationalGroup gclass9_0;
            int int_136_4;
            int int_136_5;
            int int_136_6;
            int int_136_7;
            int int_136_8;
            int int_136_9;
            if (num < 200)
            {
                gclass9_0 = this.OperationalGroupDictionary[OperationalGroupID.MediumHiveFleet];
                int_136_4 = 1;
                int_136_5 = 1;
                int_136_6 = 1;
                int_136_7 = 1;
                int_136_8 = 1;
                int_136_9 = 1;
                if (AuroraUtils.GetRandomInteger(4) == 4)
                    int_136_1 = 1;
            }
            else if (num < 400)
            {
                gclass9_0 = this.OperationalGroupDictionary[OperationalGroupID.LargeHiveFleet];
                int_136_4 = AuroraUtils.GetRandomInteger(2);
                int_136_5 = AuroraUtils.GetRandomInteger(2);
                int_136_6 = AuroraUtils.GetRandomInteger(2);
                int_136_7 = AuroraUtils.GetRandomInteger(2);
                int_136_8 = AuroraUtils.GetRandomInteger(2);
                int_136_9 = AuroraUtils.GetRandomInteger(2);
                if (AuroraUtils.GetRandomInteger(3) < 3)
                    int_136_1 = 1;
                if (AuroraUtils.smethod_23())
                    int_136_2 = 1;
                int_136_3 = 1;
            }
            else if (num < 600)
            {
                gclass9_0 = this.OperationalGroupDictionary[OperationalGroupID.VeryLargeHiveFleet];
                int_136_4 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_5 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_6 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_7 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_8 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_9 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_1 = AuroraUtils.GetRandomInteger(2);
                int_136_2 = AuroraUtils.GetRandomInteger(2);
                int_136_3 = AuroraUtils.GetRandomInteger(2);
            }
            else
            {
                gclass9_0 = this.OperationalGroupDictionary[OperationalGroupID.SwarmAssaultSquadron];
                int_136_4 = 1 + AuroraUtils.GetRandomInteger(3);
                int_136_5 = 1 + AuroraUtils.GetRandomInteger(3);
                int_136_6 = 1 + AuroraUtils.GetRandomInteger(3);
                int_136_1 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_7 = 2 + AuroraUtils.GetRandomInteger(2);
                int_136_8 = 2 + AuroraUtils.GetRandomInteger(2);
                int_136_9 = 2 + AuroraUtils.GetRandomInteger(2);
                int_136_2 = 1 + AuroraUtils.GetRandomInteger(2);
                int_136_3 = 1 + AuroraUtils.GetRandomInteger(2);
            }

            // ISSUE: reference to a compiler-generated field
            this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0, gclass9_0, list, 1,
                false);
            if (int_136_4 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.SwamGravitationalSurvey], list, int_136_4, false);
            }

            if (int_136_5 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.StarSwarmCapturedShip], list, int_136_5, false);
            }

            if (int_136_6 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.SwarmExtractionSquadron], list, int_136_6, false);
            }

            if (int_136_7 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.SmallHiveFleet], list, int_136_7, false);
            }

            if (int_136_8 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.SwarmCruiserSquadron], list, int_136_8, false);
            }

            if (int_136_9 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.SwarmSalvageSquadron], list, int_136_9, false);
            }

            if (int_136_1 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.SwarmBoardingFleet], list, int_136_1, false);
            }

            if (int_136_2 > 0)
            {
                // ISSUE: reference to a compiler-generated field
                this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                    this.OperationalGroupDictionary[OperationalGroupID.SwarmAttackSquadron], list, int_136_2, false);
            }

            if (int_136_3 <= 0)
                return;
            // ISSUE: reference to a compiler-generated field
            this.method_57(class40.gclass21_0, gclass194_1, gclass202_0, gclass1_1, gclass83_0,
                this.OperationalGroupDictionary[OperationalGroupID.SwarmGeologicalSurvey], list, int_136_3, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1421);
        }
    }
    
    public void method_61(StarSystem gclass200_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass0.Class42 class42 = new GClass0.Class42();
        // ISSUE: reference to a compiler-generated field
        class42.gclass200_0 = gclass200_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (SystemBodyData gclass1 in this.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(class42.method_0).ToList<SystemBodyData>())
                this.SystemBodyRecordDic.Remove(gclass1.SystemBodyID);
            // ISSUE: reference to a compiler-generated method
            foreach (Star197 gclass197 in this.StarDictionary.Values.Where<Star197>(class42.method_1).ToList<Star197>())
                this.StarDictionary.Remove(gclass197.StarID);
            // ISSUE: reference to a compiler-generated method
            foreach (JumpPoint gclass120 in this.JumpPointDictionary.Values.Where<JumpPoint>(class42.method_2)
                         .ToList<JumpPoint>())
                this.JumpPointDictionary.Remove(gclass120.WarpPointID);
            // ISSUE: reference to a compiler-generated method
            foreach (LagrangePoint gclass212 in this.LagrangePoints.Values.Where<LagrangePoint>(class42.method_3)
                         .ToList<LagrangePoint>())
                this.LagrangePoints.Remove(gclass212.LaGrangePointID);
            // ISSUE: reference to a compiler-generated field
            this.StarSystemDictionary.Remove(class42.gclass200_0.SystemID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1423);
        }
    }
}