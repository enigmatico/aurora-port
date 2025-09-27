// Decompiled with JetBrains decompiler
// Type: GClass6
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public partial class GClass6
{
    private GClass0 gclass0_0;
    private PopulationData gclass146_0;
    public List<GroundUnitFormationData> list_0 = new List<GroundUnitFormationData>();
    public Dictionary<RaceMissile, GClass130> dictionary_0 = new Dictionary<RaceMissile, GClass130>();
    public GEnum97 genum97_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public double double_0;
    public double double_1;
    public double double_2;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public bool bool_0;
    public bool bool_1;

    public GClass6(GClass0 gclass0_1, PopulationData gclass146_1)
    {
        this.gclass0_0 = gclass0_1;
        this.gclass146_0 = gclass146_1;
    }

    public void method_0()
    {
        try
        {
            this.method_23();
            this.method_7();
            if (this.gclass146_0.RaceData.DesignDoctrine.bOrdnanceFactories)
                this.method_15();
            if (this.gclass146_0.RaceData.DesignDoctrine.bFighterFactories)
                this.method_16();
            if (this.gclass146_0.RaceData.WealthPoints < 2500M || this.gclass146_0.Efficiency < 1M)
                return;
            if (this.gclass146_0.dictionary_2.Values.Where<GClass156>(gclass156_0 =>
                    gclass156_0.auroraProductionType_0 != AuroraProductionType.Ordnance &&
                    gclass156_0.auroraProductionType_0 != AuroraProductionType.Fighter).Count<GClass156>() == 0 &&
                !this.method_22())
                this.method_18();
            if (this.gclass146_0.method_73(AuroraInstallationType.GFCC) > 0 && this.gclass146_0.dictionary_3.Count == 0)
                this.method_4(1);
            this.method_13();
            this.method_14();
            this.method_10();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 114);
        }
    }

    public void method_1()
    {
        try
        {
            this.method_23();
            this.method_7();
            if (this.gclass146_0.RaceData.WealthPoints < 1000M || this.gclass146_0.Efficiency < 1M)
                return;
            if (this.gclass146_0.dictionary_2.Values.Where<GClass156>(gclass156_0 =>
                    gclass156_0.auroraProductionType_0 != AuroraProductionType.Ordnance &&
                    gclass156_0.auroraProductionType_0 != AuroraProductionType.Fighter).Count<GClass156>() == 0)
                this.method_17();
            if (this.gclass146_0.method_73(AuroraInstallationType.GFCC) <= 0 ||
                this.gclass146_0.dictionary_3.Count != 0)
                return;
            this.method_4(1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3951);
        }
    }

    public void method_2()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass6.Class480 class480 = new GClass6.Class480();
            // ISSUE: reference to a compiler-generated field
            class480.gclass6_0 = this;
            List<GroundUnitFormationData> list1 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData == this.gclass146_0).ToList<GroundUnitFormationData>();
            if (list1.Count == 0)
                return;
            bool flag = false;
            
            // ISSUE: reference to a compiler-generated field
            class480.list_0 = this.gclass0_0.PopulationDataDictionary.Values
                .Where<PopulationData>(gclass146_1 =>
                    gclass146_1.SystemBodyData == this.gclass146_0.SystemBodyData && gclass146_1 != this.gclass146_0)
                .Where<PopulationData>(gclass146_1 =>
                    this.gclass146_0.RaceData.PerceivedAliens.ContainsKey(gclass146_1.RaceData.RaceID))
                .Where<PopulationData>(gclass146_1 =>
                    this.gclass146_0.RaceData.PerceivedAliens[gclass146_1.RaceData.RaceID].ContactStatus ==
                    AuroraContactStatus.Hostile).ToList<PopulationData>();
            // ISSUE: reference to a compiler-generated method
            List<GroundUnitFormationData> list2 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class480.method_0)
                .ToList<GroundUnitFormationData>();
            foreach (GroundUnitFormationData gclass103 in list1)
            {
                gclass103.ParentFormationData = null;
                gclass103.AssignedFormationData = null;
                gclass103.bool_6 = false;
                if (this.gclass0_0.AutoGroundTemplateDesignsDictionary.ContainsKey(gclass103.OriginalTemplateData.AutomatedTemplateType))
                {
                    gclass103.FieldPosition = this.gclass0_0
                        .AutoGroundTemplateDesignsDictionary[gclass103.OriginalTemplateData.AutomatedTemplateType].GroundFormationFieldPosition;
                    if (this.gclass0_0.AutoGroundTemplateDesignsDictionary[gclass103.OriginalTemplateData.AutomatedTemplateType].PrimaryFunction == GUAutoTemplatePrimaryFunction.const_3)
                    {
                        if (gclass103.ElementList.Select<GroundUnitFormationElement, GroundUnitClass101>(gclass39_0 => gclass39_0.GroundUnitClass)
                                .SelectMany<GroundUnitClass101, GroundComponentTypeDefinition>(gclass101_0 => gclass101_0.GroundUnitComponentList)
                                .Count<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.STO > 0) == 0)
                            gclass103.FieldPosition =
                                AuroraGroundFormationFieldPosition.FrontlineDefence;
                    }
                    else if (this.gclass0_0.AutoGroundTemplateDesignsDictionary[gclass103.OriginalTemplateData.AutomatedTemplateType].PrimaryFunction ==
                             GUAutoTemplatePrimaryFunction.const_2 && gclass103.method_33() == 0)
                        gclass103.bool_6 = true;
                }
                else
                    gclass103.FieldPosition =
                        AuroraGroundFormationFieldPosition.FrontlineDefence;
            }

            if (list2.Count != 0)
            {
                if (list2.Count<GroundUnitFormationData>(gclass103_0 =>
                        gclass103_0.FieldPosition !=
                        AuroraGroundFormationFieldPosition.FrontlineDefence &&
                        gclass103_0.FieldPosition !=
                        AuroraGroundFormationFieldPosition.FrontlineAttack) == list2.Count)
                {
                    Decimal num1 = 0M;
                    Decimal num2 = 0M;
                    Decimal num3 = 0M;
                    Decimal num4 = 0M;
                    Decimal num5 = 0M;
                    foreach (GroundUnitFormationData gclass103 in list1)
                    {
                        foreach (GroundUnitFormationElement gclass39 in gclass103.ElementList)
                        {
                            if (gclass103.FieldPosition ==
                                AuroraGroundFormationFieldPosition.FrontlineDefence ||
                                gclass103.FieldPosition ==
                                AuroraGroundFormationFieldPosition.FrontlineAttack)
                            {
                                foreach (GroundComponentTypeDefinition gclass100 in gclass39.GroundUnitClass.GroundUnitComponentList)
                                {
                                    if (gclass100.Shots != 0)
                                        num3 += gclass39.UnitCount * gclass100.Shots *
                                                gclass100.method_1(gclass39.GroundUnitClass.decimal_1) *
                                                gclass100.method_2(gclass39.GroundUnitClass.decimal_1) *
                                                this.gclass146_0.SystemBodyData.DominantTerrain.ToHitModifier;
                                }
                            }

                            if (gclass103.FieldPosition ==
                                AuroraGroundFormationFieldPosition.FrontlineDefence)
                            {
                                num4 += gclass39.UnitCount * gclass39.GroundUnitClass.method_7() *
                                        gclass39.GroundUnitClass.method_8() * gclass39.FortificationLevel *
                                        this.gclass146_0.SystemBodyData.DominantTerrain.FortificationModifier;
                                num5 += gclass39.UnitCount * gclass39.GroundUnitClass.method_7() *
                                        gclass39.GroundUnitClass.method_8() *
                                        (1M / gclass39.GroundUnitClass.GroundUnitBaseTypeData.decimal_3);
                            }
                            else if (gclass103.FieldPosition ==
                                     AuroraGroundFormationFieldPosition.FrontlineAttack)
                            {
                                num4 += gclass39.UnitCount * gclass39.GroundUnitClass.method_7() *
                                        gclass39.GroundUnitClass.method_8() *
                                        (1M / gclass39.GroundUnitClass.GroundUnitBaseTypeData.decimal_3);
                                num5 += gclass39.UnitCount * gclass39.GroundUnitClass.method_7() *
                                        gclass39.GroundUnitClass.method_8() *
                                        (1M / gclass39.GroundUnitClass.GroundUnitBaseTypeData.decimal_3);
                            }
                            else
                                num4 += gclass39.UnitCount * gclass39.GroundUnitClass.method_7() *
                                        gclass39.GroundUnitClass.method_8() * gclass39.FortificationLevel *
                                        this.gclass146_0.SystemBodyData.DominantTerrain.FortificationModifier;
                        }
                    }

                    foreach (GroundUnitFormationData gclass103 in list2)
                    {
                        foreach (GroundUnitFormationElement gclass39 in gclass103.ElementList)
                        {
                            // ISSUE: object of a compiler-generated type is created
                            // ISSUE: variable of a compiler-generated type
                            GClass6.Class481 class481 = new GClass6.Class481();
                            // ISSUE: reference to a compiler-generated field
                            class481.gclass39_0 = gclass39;
                            Decimal num6 = 10M;
                            Decimal num7 = 10M;
                            // ISSUE: reference to a compiler-generated method
                            GClass114 gclass114 =
                                this.gclass146_0.RaceData.dictionary_14.Values.FirstOrDefault<GClass114>(
                                    class481.method_0);
                            if (gclass114 != null)
                            {
                                if (gclass114.int_2 >= 20)
                                    num6 = gclass114.gclass101_0.method_7();
                                if (gclass114.int_3 >= 20)
                                    num7 = gclass114.gclass101_0.method_8();
                                if (gclass114.bool_0)
                                {
                                    foreach (GroundComponentTypeDefinition gclass100 in gclass114.gclass101_0.GroundUnitComponentList)
                                    {
                                        if (gclass100.Shots != 0)
                                        {
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            // ISSUE: reference to a compiler-generated field
                                            num1 += class481.gclass39_0.UnitCount * gclass100.Shots *
                                                    gclass100.method_1(class481.gclass39_0.GroundUnitClass.decimal_1) *
                                                    gclass100.method_2(class481.gclass39_0.GroundUnitClass.decimal_1) *
                                                    this.gclass146_0.SystemBodyData.DominantTerrain.ToHitModifier;
                                        }
                                    }
                                }
                                else
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    num1 += class481.gclass39_0.UnitCount * 100 *
                                            this.gclass146_0.SystemBodyData.DominantTerrain.ToHitModifier;
                                }
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                num1 += class481.gclass39_0.UnitCount * 100 *
                                        this.gclass146_0.SystemBodyData.DominantTerrain.ToHitModifier;
                            }

                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            num2 += class481.gclass39_0.UnitCount * num6 * num7 * class481.gclass39_0.FortificationLevel *
                                    this.gclass146_0.SystemBodyData.DominantTerrain.FortificationModifier;
                        }
                    }

                    if (num5 > 0M)
                    {
                        Decimal num8 = num3 / num2;
                        Decimal num9 = num1 / num5;
                        if (num8 > num9)
                        {
                            if (num8 / num9 < 2M)
                            {
                                if (num4 / num5 < 3M)
                                    flag = true;
                            }
                            else
                                flag = true;
                        }

                        if (flag)
                        {
                            foreach (GroundUnitFormationData gclass103 in list1)
                            {
                                if (gclass103.FieldPosition ==
                                    AuroraGroundFormationFieldPosition.FrontlineDefence)
                                    gclass103.FieldPosition =
                                        AuroraGroundFormationFieldPosition.FrontlineAttack;
                            }
                        }
                    }
                }
            }

            if (list1.Count<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.FieldPosition ==
                    AuroraGroundFormationFieldPosition.FrontlineAttack ||
                    gclass103_0.FieldPosition ==
                    AuroraGroundFormationFieldPosition.FrontlineDefence) == 0)
            {
                foreach (GroundUnitFormationData gclass103 in list1)
                    gclass103.FieldPosition =
                        AuroraGroundFormationFieldPosition.FrontlineDefence;
            }

            foreach (GroundUnitFormationData gclass103_1 in list1.Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.bool_6)
                         .ToList<GroundUnitFormationData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass6.Class482 class482 = new GClass6.Class482();
                // ISSUE: reference to a compiler-generated field
                class482.class480_0 = class480;
                // ISSUE: reference to a compiler-generated field
                class482.gclass103_0 = gclass103_1;
                // ISSUE: reference to a compiler-generated method
                GroundUnitFormationData gclass103_2 = list1.FirstOrDefault<GroundUnitFormationData>(class482.method_0);
                if (gclass103_2 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass103_2.method_6(class482.gclass103_0);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    list1.Where<GroundUnitFormationData>(gclass103_0 =>
                            this.gclass0_0.AutoGroundTemplateDesignsDictionary[gclass103_0.OriginalTemplateData.AutomatedTemplateType].PrimaryFunction ==
                            GUAutoTemplatePrimaryFunction.const_0 ||
                            this.gclass0_0.AutoGroundTemplateDesignsDictionary[gclass103_0.OriginalTemplateData.AutomatedTemplateType].PrimaryFunction ==
                            GUAutoTemplatePrimaryFunction.const_1)
                        .OrderBy<GroundUnitFormationData, GUAutoTemplatePrimaryFunction>(gclass103_0 =>
                            this.gclass0_0.AutoGroundTemplateDesignsDictionary[gclass103_0.OriginalTemplateData.AutomatedTemplateType].PrimaryFunction)
                        .FirstOrDefault<GroundUnitFormationData>()?.method_6(class482.gclass103_0);
                }
            }

            if (this.gclass146_0.RaceData.SpecialNPRID == SpecialNPRIDs.Precursor)
            {
                this.gclass0_0.method_540(this.gclass146_0, AutomatedGroundTemplateDesignType.PrecursorPlanetaryHQ, AutomatedGroundTemplateDesignType.PrecursorMechBattalion);
                this.gclass0_0.method_540(this.gclass146_0, AutomatedGroundTemplateDesignType.PrecursorPlanetaryHQ, AutomatedGroundTemplateDesignType.PrecursorDefenceRegiment);
            }
            else
            {
                this.gclass0_0.method_540(this.gclass146_0, AutomatedGroundTemplateDesignType.InfantryBrigadeHQ, AutomatedGroundTemplateDesignType.InfantryRegiment);
                this.gclass0_0.method_540(this.gclass146_0, AutomatedGroundTemplateDesignType.InfantryBrigadeHQ, AutomatedGroundTemplateDesignType.Garrison);
                this.gclass0_0.method_540(this.gclass146_0, AutomatedGroundTemplateDesignType.InfantryBrigadeHQ, AutomatedGroundTemplateDesignType.PlanetaryDefenceRegiment);
                this.gclass0_0.method_540(this.gclass146_0, AutomatedGroundTemplateDesignType.ArmourBrigadeHQ, AutomatedGroundTemplateDesignType.ArmourRegiment);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 115);
        }
    }

    public void method_3(PopulationData gclass146_1)
    {
        try
        {
            if (gclass146_1 == null || !this.gclass146_0.CurrentMinerals.HasAnyPositiveMineralValue() ||
                this.gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.ConstructionFactory) ||
                this.gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.OrdnanceFactory) ||
                this.gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.FighterFactory) ||
                this.gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.GFCC) ||
                this.gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.ConventionalIndustry) ||
                this.gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.MaintenanceFacility) ||
                this.gclass146_0.method_85().Count > 0)
                return;
            Decimal num = 0M;
            if (this.gclass146_0.dictionary_0.ContainsKey(AuroraInstallationType.FuelRefinery))
            {
                num = this.gclass146_0.CurrentMinerals.Sorium;
                this.gclass146_0.CurrentMinerals.Sorium = 0M;
            }

            gclass146_1.CurrentMinerals.AddMineralsFrom(this.gclass146_0.CurrentMinerals);
            this.gclass146_0.CurrentMinerals.ResetToZero();
            this.gclass146_0.CurrentMinerals.Sorium += num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 116);
        }
    }

    public void method_4(int int_3)
    {
        try
        {
            Dictionary<AutomatedGroundTemplateDesignType, GClass18> dictionary = new Dictionary<AutomatedGroundTemplateDesignType, GClass18>();
            List<PopulationData> list1 = this.gclass0_0.PopulationDataDictionary.Values
                .Where<PopulationData>(gclass146_1 => gclass146_1.RaceData == this.gclass146_0.RaceData)
                .ToList<PopulationData>();
            List<GroundUnitFormationData> list2 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.RaceData == this.gclass146_0.RaceData)
                .ToList<GroundUnitFormationData>();
            foreach (PopulationData gclass146 in list1)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass6.Class483 class483 = new GClass6.Class483();
                // ISSUE: reference to a compiler-generated field
                class483.gclass146_0 = gclass146;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                foreach (GClass16 gclass16 in class483.gclass146_0.RaceData.DesignDoctrine.NameList_0
                             .Where<GClass16>(class483.method_0).ToList<GClass16>())
                {
                    if (dictionary.ContainsKey(gclass16.genum116_0))
                    {
                        dictionary[gclass16.genum116_0].int_1 += gclass16.int_0;
                    }
                    else
                    {
                        GClass18 gclass18 = new GClass18();
                        gclass18.genum116_0 = gclass16.genum116_0;
                        gclass18.int_2 = gclass16.int_2;
                        gclass18.int_1 = gclass16.int_0;
                        dictionary.Add(gclass18.genum116_0, gclass18);
                    }
                }
            }

            foreach (GClass18 gclass18 in dictionary.Values)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass6.Class484 class484 = new GClass6.Class484()
                {
                    gclass18_0 = gclass18
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class484.gclass18_0.int_0 = list2.Where<GroundUnitFormationData>(class484.method_0).Count<GroundUnitFormationData>();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class484.gclass18_0.int_0 += list1
                    .SelectMany<PopulationData, GClass106>(gclass146_0 => gclass146_0.dictionary_3.Values)
                    .Count<GClass106>(class484.method_1);
            }

            List<GClass18> list3 = dictionary.Values.OrderBy<GClass18, int>(gclass18_0 => gclass18_0.int_2)
                .ToList<GClass18>();
            foreach (GClass18 gclass18 in list3)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass6.Class485 class485 = new GClass6.Class485()
                {
                    gclass6_0 = this,
                    gclass18_0 = gclass18
                };
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class485.gclass18_0.int_3 = class485.gclass18_0.int_1 - class485.gclass18_0.int_0;
                // ISSUE: reference to a compiler-generated field
                if (class485.gclass18_0.int_3 > 0)
                {
                    // ISSUE: reference to a compiler-generated field
                    for (int index = 0; index < class485.gclass18_0.int_3; ++index)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        GroundUnitFormationTemplateData gclass102_0 =
                            this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(
                                class485.func_0 ?? (class485.func_0 = class485.method_0));
                        if (this.gclass146_0.CurrentMinerals.method_39(gclass102_0.method_4()))
                        {
                            string string_6 = $"{AuroraUtils.smethod_80(gclass102_0.FormationTrained + 1)} {gclass102_0.Name}";
                            this.gclass146_0.method_122(gclass102_0, string_6, 100M,
                                AuroraGroundFormationFieldPosition.FrontlineDefence, 0, 0);
                            ++gclass102_0.FormationTrained;
                            --int_3;
                            if (int_3 == 0)
                                return;
                        }
                        else
                            break;
                    }
                }
            }

            foreach (GClass18 gclass18 in list3.Where<GClass18>(gclass18_0 => gclass18_0.int_0 < gclass18_0.int_1 * 2)
                         .OrderByDescending<GClass18, int>(gclass18_0 => gclass18_0.int_3).ToList<GClass18>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                GroundUnitFormationTemplateData gclass102_0 = this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(
                    new GClass6.Class486()
                    {
                        gclass6_0 = this,
                        gclass18_0 = gclass18
                    }.method_0);
                string string_6 = $"{AuroraUtils.smethod_80(gclass102_0.FormationTrained + 1)} {gclass102_0.Name}";
                this.gclass146_0.method_122(gclass102_0, string_6, 100M,
                    AuroraGroundFormationFieldPosition.FrontlineDefence, 0, 0);
                ++gclass102_0.FormationTrained;
                --int_3;
                if (int_3 == 0)
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 117);
        }
    }

    public void method_5(List<GClass130> list_1)
    {
        try
        {
            foreach (GClass130 gclass130 in list_1)
            {
                if (this.gclass146_0.gclass6_0.dictionary_0.ContainsKey(gclass130.gclass129_0))
                {
                    this.gclass146_0.gclass6_0.dictionary_0[gclass130.gclass129_0].int_0 -= gclass130.int_0;
                    if (this.gclass146_0.gclass6_0.dictionary_0[gclass130.gclass129_0].int_0 < 0)
                        this.gclass146_0.gclass6_0.dictionary_0[gclass130.gclass129_0].int_0 = 0;
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 118);
        }
    }

    public void method_6()
    {
        try
        {
            this.list_0 = this.gclass0_0.FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.PopulationData == this.gclass146_0).ToList<GroundUnitFormationData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 119);
        }
    }

    public void method_7()
    {
        try
        {
            if (this.gclass146_0.bIsCapital)
            {
                this.genum97_0 = GEnum97.const_5;
            }
            else
            {
                if (this.gclass146_0.gclass202_0.gclass3_0.genum95_0 == GEnum95.const_0)
                {
                    this.genum97_0 = GEnum97.const_0;
                    this.gclass146_0.ColonistDestinationSetting = PopColonistSetting.Source;
                }

                if (this.gclass146_0.SystemBodyData.RuinID > 0 &&
                    this.gclass146_0.RaceData.SpecialNPRID == SpecialNPRIDs.Precursor)
                {
                    this.genum97_0 = GEnum97.const_4;
                }
                else
                {
                    this.gclass146_0.SystemBodyData.method_58(this.gclass146_0.RaceData, this.gclass146_0.SpeciesData,
                        true);
                    if (this.gclass146_0.SystemBodyData.ColonyCost < 0M)
                    {
                        this.genum97_0 = GEnum97.const_0;
                    }
                    else
                    {
                        this.double_0 = !(this.gclass146_0.SystemBodyData.MaxColonyCost > 0M)
                            ? 0.0
                            : this.method_9(this.gclass146_0.SystemBodyData);
                        this.double_1 = !this.gclass146_0.SystemBodyData.method_77(this.gclass146_0.RaceData)
                            ? 0.0
                            : this.gclass146_0.RaceData.UnknownNprClass.method_62(this.gclass146_0.SystemBodyData, false);
                        this.gclass146_0.ColonistDestinationSetting = !(this.gclass146_0.decimal_30 < 25M)
                            ? (!(this.gclass146_0.decimal_30 < 100M) ? PopColonistSetting.Source : PopColonistSetting.Stable)
                            : PopColonistSetting.Destination;
                        if (this.gclass146_0.SystemBodyData.MaxColonyCost < 2M &&
                            this.gclass146_0.RaceData.SpecialNPRID == SpecialNPRIDs.const_0 &&
                            this.gclass146_0.decimal_30 == 0M && this.gclass146_0.SystemBodyData.RadiationLevel == 0M &&
                            this.gclass146_0.SystemBodyData.DustLevel == 0M)
                        {
                            this.gclass146_0.method_25(0.0001M);
                            if (this.gclass146_0.SystemBodyData.Gravity < this.gclass146_0.SpeciesData.double_7)
                                this.gclass146_0.method_60(
                                    this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.Infrastructure], 50, false);
                            else
                                this.gclass146_0.method_60(
                                    this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.Infrastructure], 100, false);
                        }

                        this.int_0 = this.gclass146_0.method_73(AuroraInstallationType.Mine) +
                                     this.gclass146_0.method_73(AuroraInstallationType.AutomatedMine) +
                                     this.gclass146_0.method_73(AuroraInstallationType.CivilianMiningComplex) * 10;
                        this.int_2 = this.gclass146_0.method_73(AuroraInstallationType.ResearchLab);
                        this.double_2 = this.gclass146_0.method_73(AuroraInstallationType.Spaceport) * 5 +
                                        this.gclass146_0.method_73(AuroraInstallationType.RefuellingStation) +
                                        this.gclass146_0.method_73(AuroraInstallationType.OrdnanceTransferStation) +
                                        this.gclass146_0.method_73(AuroraInstallationType.MaintenanceFacility) / 10.0;
                        this.genum97_0 =
                            this.gclass146_0.decimal_30 > 200M || this.int_0 > 400 ||
                            this.gclass146_0.SystemBodyData.RuinID > 8 || this.int_2 > 25
                                ? GEnum97.const_4
                                : (this.gclass146_0.decimal_30 > 50M || this.int_0 > 100 || this.double_2 > 4.0 ||
                                   this.gclass146_0.SystemBodyData.RuinID > 6 || this.int_2 > 5
                                    ? GEnum97.const_3
                                    : (this.gclass146_0.decimal_30 > 10M || this.int_0 > 20 || this.double_2 > 1.0 ||
                                       this.gclass146_0.SystemBodyData.RuinID > 4 ||
                                       this.gclass146_0.gclass6_0.double_0 > 0.0 &&
                                       this.gclass146_0.gclass6_0.double_0 < 0.1 || this.int_2 > 1
                                        ? GEnum97.const_2
                                        : (this.gclass146_0.decimal_30 > 0.5M || this.int_0 > 0 ||
                                           this.double_2 > 0.0 || this.gclass146_0.SystemBodyData.RuinID > 2
                                            ? GEnum97.const_1
                                            : GEnum97.const_0)));
                        if (this.genum97_0 <= GEnum97.const_1 || !(this.gclass146_0.decimal_30 == 0M) ||
                            this.gclass146_0.RaceData.SpecialNPRID != SpecialNPRIDs.const_0)
                            return;
                        if (this.gclass146_0.SystemBodyData.MaxColonyCost >= 0M && this.gclass146_0.SystemBodyData.MaxColonyCost < 2.5M &&
                            this.gclass146_0.SystemBodyData.Gravity >= this.gclass146_0.SpeciesData.double_7 &&
                            this.gclass146_0.SystemBodyData.Gravity <= this.gclass146_0.SpeciesData.double_8)
                        {
                            this.gclass146_0.method_60(
                                this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.Infrastructure], 50, false);
                            this.gclass146_0.method_25(0.0001M);
                        }

                        if (!(this.gclass146_0.SystemBodyData.MaxColonyCost >= 0M) ||
                            !(this.gclass146_0.SystemBodyData.MaxColonyCost < 2M) || this.gclass146_0.SystemBodyData.Gravity >=
                            this.gclass146_0.SpeciesData.double_7)
                            return;
                        this.gclass146_0.method_60(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.Infrastructure],
                            100, false);
                        this.gclass146_0.method_25(0.0001M);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 120);
        }
    }

    public void method_8()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass6.Class487 class487 = new GClass6.Class487();
            SystemBodyData gclass10 = this.gclass146_0.SystemBodyData;
            // ISSUE: reference to a compiler-generated field
            class487.gclass194_0 = this.gclass146_0.SpeciesData;
            // ISSUE: reference to a compiler-generated method
            GClass224 gclass224_1 = gclass10.list_0.Where<GClass224>(class487.method_0)
                .OrderBy<GClass224, double>(gclass224_0 => gclass224_0.double_1).FirstOrDefault<GClass224>();
            if (gclass224_1 != null)
            {
                this.gclass146_0.TerraformingTargetGas = gclass224_1.gclass223_0;
                this.gclass146_0.TerraformStatus = TerraformStatus.No;
            }
            else
            {
                double num1 =
                    this.gclass146_0.SystemBodyData.method_45(
                        this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.Oxygen]);
                // ISSUE: reference to a compiler-generated field
                if (num1 < class487.gclass194_0.double_9)
                {
                    this.gclass146_0.TerraformingTargetGas = this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.Oxygen];
                    this.gclass146_0.TerraformStatus = TerraformStatus.Yes;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (num1 > class487.gclass194_0.double_10)
                    {
                        this.gclass146_0.TerraformingTargetGas = this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.Oxygen];
                        this.gclass146_0.TerraformStatus = TerraformStatus.No;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (gclass10.SurfaceTemp < class487.gclass194_0.double_12)
                        {
                            this.gclass146_0.TerraformingTargetGas =
                                this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.const_20];
                            this.gclass146_0.TerraformStatus = TerraformStatus.Yes;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (gclass10.SurfaceTemp > class487.gclass194_0.double_11)
                            {
                                GClass224 gclass224_2 = gclass10.list_0
                                    .Where<GClass224>(gclass224_0 => gclass224_0.gclass223_0.GHGas)
                                    .OrderBy<GClass224, double>(gclass224_0 => gclass224_0.double_1)
                                    .FirstOrDefault<GClass224>();
                                this.gclass146_0.TerraformingTargetGas = gclass224_2 == null
                                    ? this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.const_20]
                                    : gclass224_2.gclass223_0;
                                this.gclass146_0.TerraformStatus = TerraformStatus.No;
                            }
                            else
                            {
                                double num2 = 0.0;
                                foreach (GClass224 gclass224_3 in gclass10.list_0)
                                {
                                    if (!gclass224_3.bool_0)
                                    {
                                        if (gclass224_3.gclass223_0.GHGas)
                                            num2 += gclass224_3.double_1;
                                        if (gclass224_3.gclass223_0.AntiGHGas)
                                            num2 -= gclass224_3.double_1;
                                    }
                                }

                                if (num1 / gclass10.AtmospherePressure > 0.3)
                                {
                                    this.gclass146_0.TerraformingTargetGas =
                                        this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.Nitrogen];
                                    this.gclass146_0.TerraformStatus = TerraformStatus.Yes;
                                }
                                else
                                {
                                    if (gclass10.HydroExtent >= 20.0)
                                        return;
                                    this.gclass146_0.TerraformingTargetGas =
                                        this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.const_5];
                                    this.gclass146_0.TerraformStatus = TerraformStatus.Yes;
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 121);
        }
    }

    public double method_9(SystemBodyData gclass1_0)
    {
        try
        {
            if (gclass1_0.Gravity < this.gclass146_0.SpeciesData.double_7 || gclass1_0.Gravity < 0.1)
                return 0.0;
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = gclass1_0.method_45(this.gclass0_0.AtmosphericGasDictionary[AtmosphericGas.Oxygen]);
            if (num4 < this.gclass146_0.SpeciesData.double_9)
            {
                num1 = this.gclass146_0.SpeciesData.double_9 - num4;
                num2 = this.gclass146_0.SpeciesData.double_9;
                num3 = num1;
            }
            else if (num4 > this.gclass146_0.SpeciesData.double_10)
            {
                num1 = num4 - this.gclass146_0.SpeciesData.double_10;
                num2 = this.gclass146_0.SpeciesData.double_10;
                num3 = -num1;
            }

            double num5 = 0.0;
            double num6 = 0.0;
            foreach (GClass224 gclass224 in gclass1_0.list_0)
            {
                if (!gclass224.bool_0)
                {
                    if (gclass224.gclass223_0.GHGas)
                        num5 += gclass224.double_1;
                    if (gclass224.gclass223_0.AntiGHGas)
                        num6 += gclass224.double_1;
                }
            }

            double num7 = gclass1_0.AtmospherePressure + num3;
            double num8 = 1.0 + num7 / 10.0 + num5;
            if (num8 > 3.0)
                num8 = 3.0;
            double num9 = 1.0 + (double)gclass1_0.DustLevel / 20000.0 + num6;
            if (num9 > 3.0)
                num9 = 3.0;
            double num10 = gclass1_0.BaseTemp * num8 * gclass1_0.Albedo / num9;
            if (num10 < this.gclass146_0.SpeciesData.double_12)
            {
                double num11 = this.gclass146_0.SpeciesData.double_12 / (gclass1_0.BaseTemp * gclass1_0.Albedo) - num8;
                num1 += num11;
                num7 += num11;
            }
            else if (num10 > this.gclass146_0.SpeciesData.double_11)
            {
                double num12 = num10 / this.gclass146_0.SpeciesData.double_11 - 1.0;
                num1 += num12;
                num7 += num12;
            }

            if (num2 / num7 > 0.3)
            {
                double num13 = num2 * 3.334;
                num1 += num13 - num7;
            }

            foreach (GClass224 gclass224 in gclass1_0.list_0.Where<GClass224>(gclass224_0 =>
                         gclass224_0.gclass223_0.Dangerous > 0 &&
                         gclass224_0.gclass223_0 != this.gclass146_0.SpeciesData.gclass223_0).ToList<GClass224>())
                num1 += gclass224.double_1;
            if (gclass1_0.HydroExtent < 20.0)
            {
                double num14 = (20.0 - gclass1_0.HydroExtent) / 40.0;
                num1 += num14;
            }

            double num15 = 4.0 * AuroraUtils.PI_Apprx * Math.Pow(gclass1_0.Radius, 2.0);
            return num1 * (num15 / (double)AuroraUtils.decimal_15);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 122);
            return 0.0;
        }
    }

    public void method_10()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass6.Class488 class488 = new GClass6.Class488();
            List<GClass193> list1 = this.gclass0_0.dictionary_31.Values.Where<GClass193>(gclass193_0 =>
                gclass193_0.gclass146_0 == this.gclass146_0 && gclass193_0.gclass22_0 != null).ToList<GClass193>();
            // ISSUE: reference to a compiler-generated field
            class488.list_0 = this.gclass0_0.dictionary_32.Values
                .Where<GClass192>(gclass192_0 =>
                    gclass192_0.gclass40_0 != null && gclass192_0.gclass21_0 == this.gclass146_0.RaceData)
                .Select<GClass192, FCTShipData40>(gclass192_0 => gclass192_0.gclass40_0).ToList<FCTShipData40>();
            // ISSUE: reference to a compiler-generated method
            List<FCTShipData40> list2 = this.gclass0_0.FCTShipDataDictionary.Values
                .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass146_0.RaceData)
                .Where<FCTShipData40>(gclass40_0 => gclass40_0.dictionary_5.Count > 0 || gclass40_0.list_12.Count > 0)
                .Where<FCTShipData40>(class488.method_0).ToList<FCTShipData40>();
            foreach (GClass193 gclass193_0 in list1)
            {
                int int_3 = gclass193_0.method_1();
                int num1 = gclass193_0.int_1 - int_3;
                if (num1 > 0)
                {
                    if (list2.Count > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        FCTShipData40 gclass40_3 =
                            this.method_11(this.gclass146_0, gclass193_0, class488.list_0, list2);
                        if (gclass40_3 != null)
                        {
                            AllMineralsValue gclass123_1 = gclass40_3.method_207();
                            gclass193_0.method_3(AuroraSYTaskType.Repair, gclass40_3, gclass40_3.gclass22_0, null,
                                gclass40_3.gclass85_0, gclass123_1, gclass40_3.method_206(), gclass40_3.ShipName);
                            // ISSUE: reference to a compiler-generated field
                            class488.list_0.Add(gclass40_3);
                            list2.Remove(gclass40_3);
                            continue;
                        }
                    }

                    int num2 = this.method_12(gclass193_0.gclass22_0, int_3);
                    if (num2 != 0)
                    {
                        int num3 = this.gclass146_0.CurrentMinerals.method_0(gclass193_0.gclass22_0.gclass123_0);
                        if (num3 != 0)
                        {
                            if (num3 > num1)
                                num3 = num1;
                            if (num3 > num2)
                                num3 = num2;
                            for (int index = 1; index <= num3; ++index)
                                gclass193_0.method_2();
                            break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 123);
        }
    }

    public FCTShipData40 method_11(
        PopulationData gclass146_1,
        GClass193 gclass193_0,
        List<FCTShipData40> list_1,
        List<FCTShipData40> list_2)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass6.Class489 class489 = new GClass6.Class489();
        // ISSUE: reference to a compiler-generated field
        class489.list_0 = list_1;
        // ISSUE: reference to a compiler-generated field
        class489.gclass146_0 = gclass146_1;
        // ISSUE: reference to a compiler-generated field
        class489.gclass193_0 = gclass193_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass6.Class490 class490 = new GClass6.Class490()
            {
                class489_0 = class489
            };
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class490.double_0 = class490.class489_0.gclass146_0.method_87();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class490.double_1 = class490.class489_0.gclass146_0.method_88();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            return list_2.Where<FCTShipData40>(class490.method_0).Where<FCTShipData40>(class490.class489_0.method_0)
                .OrderByDescending<FCTShipData40, Decimal>(gclass40_0 => gclass40_0.gclass22_0.decimal_14)
                .FirstOrDefault<FCTShipData40>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 124);
            return null;
        }
    }

    public int method_12(GClass22 gclass22_0, int int_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass6.Class491 class491 = new GClass6.Class491();
        // ISSUE: reference to a compiler-generated field
        class491.gclass22_0 = gclass22_0;
        // ISSUE: reference to a compiler-generated field
        class491.gclass6_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            int num1 = this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(class491.method_0)
                .Where<FCTShipData40>(class491.method_1).Count<FCTShipData40>();
            // ISSUE: reference to a compiler-generated field
            if (class491.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.Geosurvey)
                return num1 + int_3 >= this.gclass146_0.RaceData.DesignDoctrine.MaxGeo
                    ? 0
                    : this.gclass146_0.RaceData.DesignDoctrine.MaxGeo - (num1 + int_3);
            // ISSUE: reference to a compiler-generated field
            if (class491.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.Gravsurvey)
                return num1 + int_3 >= this.gclass146_0.RaceData.DesignDoctrine.MaxGrav
                    ? 0
                    : this.gclass146_0.RaceData.DesignDoctrine.MaxGrav - (num1 + int_3);
            // ISSUE: reference to a compiler-generated field
            if (class491.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.Scout)
                return num1 + int_3 >= this.gclass146_0.RaceData.DesignDoctrine.MaxScout
                    ? 0
                    : this.gclass146_0.RaceData.DesignDoctrine.MaxScout - (num1 + int_3);
            // ISSUE: reference to a compiler-generated field
            if (class491.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.DiplomaticShip)
                return num1 + int_3 >= this.gclass146_0.RaceData.DesignDoctrine.MaxDiplomatic
                    ? 0
                    : this.gclass146_0.RaceData.DesignDoctrine.MaxDiplomatic - (num1 + int_3);
            // ISSUE: reference to a compiler-generated field
            if (class491.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.ConstructionShip)
                return num1 + int_3 >= this.gclass146_0.RaceData.DesignDoctrine.MaxStabilisation
                    ? 0
                    : this.gclass146_0.RaceData.DesignDoctrine.MaxStabilisation - (num1 + int_3);
            // ISSUE: reference to a compiler-generated field
            if (class491.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.Salvager)
                return num1 + int_3 >= this.gclass146_0.RaceData.DesignDoctrine.MaxSalvage
                    ? 0
                    : this.gclass146_0.RaceData.DesignDoctrine.MaxSalvage - (num1 + int_3);
            // ISSUE: reference to a compiler-generated field
            if (class491.gclass22_0.gclass14_0.AutomatedClassDesignTypeID == AutomatedClassDesignType.Tanker)
                return num1 + int_3 >= this.gclass146_0.RaceData.DesignDoctrine.MaxTanker
                    ? 0
                    : this.gclass146_0.RaceData.DesignDoctrine.MaxTanker - (num1 + int_3);
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            int num2 = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class491.method_2)
                .Where<FleetData>(gclass85_0 => gclass85_0.NPROperationGroup.genum105_0 == OperationalGroup.ReinforcementGroup)
                .SelectMany<FleetData, FCTShipData40>(gclass85_0 => gclass85_0.method_176())
                .Where<FCTShipData40>(class491.method_3).Count<FCTShipData40>();
            return num2 >= 3 ? 0 : 3 - num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 125);
            return 0;
        }
    }

    public void method_13()
    {
        try
        {
            List<GClass193> list1 = this.gclass0_0.dictionary_31.Values.Where<GClass193>(gclass193_0 =>
                gclass193_0.gclass146_0 == this.gclass146_0 &&
                gclass193_0.auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.None).ToList<GClass193>();
            if (list1.Count == 0)
                return;
            foreach (GClass193 gclass193 in list1)
                gclass193.bool_1 = false;
            List<GClass193> list2 = this.gclass0_0.dictionary_31.Values
                .Where<GClass193>(gclass193_0 => gclass193_0.gclass21_0 == this.gclass146_0.RaceData)
                .ToList<GClass193>();
            foreach (GClass193 gclass193 in list1.Where<GClass193>(gclass193_0 => gclass193_0.gclass22_0 == null)
                         .OrderByDescending<GClass193, Decimal>(gclass193_0 => gclass193_0.decimal_0)
                         .ToList<GClass193>())
                gclass193.bool_1 = true;
            List<GClass22> list3 = list2.Where<GClass193>(gclass193_0 => gclass193_0.gclass22_0 != null)
                .Select<GClass193, GClass22>(gclass193_0 => gclass193_0.gclass22_0).ToList<GClass22>();
            List<GClass22> list4 = this.gclass0_0.dictionary_3.Values
                .Where<GClass22>(gclass22_0 =>
                    gclass22_0.gclass21_0 == this.gclass146_0.RaceData && gclass22_0.int_38 == 0 &&
                    gclass22_0.gclass187_0 == null).Except<GClass22>(list3)
                .OrderByDescending<GClass22, Decimal>(gclass22_0 => gclass22_0.decimal_14).ToList<GClass22>();
            List<GClass22> source = new List<GClass22>();
            foreach (GClass22 gclass22_0 in list4)
            {
                if (this.method_12(gclass22_0, 0) > 0)
                    source.Add(gclass22_0);
            }

            foreach (GClass193 gclass193 in list1.Where<GClass193>(gclass193_0 => gclass193_0.gclass22_0 != null)
                         .ToList<GClass193>())
            {
                if (this.method_12(gclass193.gclass22_0, gclass193.method_1()) == 0)
                    gclass193.bool_1 = true;
            }

            List<GClass193> list5 = list1.Where<GClass193>(gclass193_0 =>
                gclass193_0.bool_1 && gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval).ToList<GClass193>();
            List<GClass22> list6 = source.Where<GClass22>(gclass22_0 => !gclass22_0.bool_2).ToList<GClass22>();
            foreach (GClass193 gclass193 in list5)
            {
                foreach (GClass22 gclass22 in list6
                             .OrderByDescending<GClass22, Decimal>(gclass22_0 => gclass22_0.decimal_14)
                             .ToList<GClass22>())
                {
                    if (gclass22.decimal_14 * AuroraUtils.decimal_17 <= gclass193.decimal_0)
                    {
                        gclass193.gclass22_0 = gclass22;
                        list6.Remove(gclass22);
                        break;
                    }
                }
            }

            List<GClass193> list7 = list1.Where<GClass193>(gclass193_0 =>
                    gclass193_0.bool_1 && gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Commercial)
                .ToList<GClass193>();
            List<GClass22> list8 = source.Where<GClass22>(gclass22_0 => gclass22_0.bool_2).ToList<GClass22>();
            foreach (GClass193 gclass193 in list7)
            {
                foreach (GClass22 gclass22 in list8
                             .OrderByDescending<GClass22, Decimal>(gclass22_0 => gclass22_0.decimal_14)
                             .ToList<GClass22>())
                {
                    if (gclass22.decimal_14 * AuroraUtils.decimal_17 <= gclass193.decimal_0)
                    {
                        gclass193.gclass22_0 = gclass22;
                        list8.Remove(gclass22);
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 126);
        }
    }

    public void method_14()
    {
        try
        {
            if (this.gclass146_0.CurrentMinerals.Duranium < 1000M || this.gclass146_0.CurrentMinerals.Neutronium < 1000M)
                return;
            GClass193 gclass193_0_1 = this.gclass0_0.dictionary_31.Values
                .Where<GClass193>(gclass193_0 =>
                    gclass193_0.gclass146_0 == this.gclass146_0 && gclass193_0.gclass22_0 == null &&
                    gclass193_0.auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.None)
                .OrderByDescending<GClass193, Decimal>(gclass193_0 => gclass193_0.decimal_0)
                .FirstOrDefault<GClass193>();
            if (gclass193_0_1 != null)
            {
                if (gclass193_0_1.auroraShipyardType_0 == AuroraShipyardType.Naval)
                {
                    if (gclass193_0_1.decimal_0 < 5000M)
                        this.gclass146_0.method_124(gclass193_0_1, AuroraShipyardUpgradeType.Add500, null, 0);
                    else
                        this.gclass146_0.method_124(gclass193_0_1, AuroraShipyardUpgradeType.Add1000, null, 0);
                }
                else
                    this.gclass146_0.method_124(gclass193_0_1, AuroraShipyardUpgradeType.Add5000, null, 0);
            }
            else
            {
                GClass193 gclass193_0_2 = this.gclass0_0.dictionary_31.Values
                    .Where<GClass193>(gclass193_0 =>
                        gclass193_0.gclass146_0 == this.gclass146_0 && gclass193_0.gclass22_0 != null &&
                        gclass193_0.auroraShipyardUpgradeType_0 == AuroraShipyardUpgradeType.None)
                    .OrderBy<GClass193, int>(gclass193_0 => gclass193_0.int_1)
                    .ThenByDescending<GClass193, Decimal>(gclass193_0 => gclass193_0.decimal_0)
                    .FirstOrDefault<GClass193>();
                if (gclass193_0_2 == null)
                    return;
                if (AuroraUtils.smethod_23())
                    this.gclass146_0.method_124(gclass193_0_2, AuroraShipyardUpgradeType.AddSlipway, null, 0);
                else if (gclass193_0_2.auroraShipyardType_0 == AuroraShipyardType.Naval)
                    this.gclass146_0.method_124(gclass193_0_2, AuroraShipyardUpgradeType.Add1000, null, 0);
                else
                    this.gclass146_0.method_124(gclass193_0_2, AuroraShipyardUpgradeType.Add10000, null, 0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, sbyte.MaxValue);
        }
    }

    public void method_15()
    {
        try
        {
            if (this.gclass146_0.method_73(AuroraInstallationType.OrdnanceFactory) == 0 || this.gclass146_0.dictionary_2
                    .Values.Where<GClass156>(gclass156_0 =>
                        gclass156_0.auroraProductionType_0 == AuroraProductionType.Ordnance).Count<GClass156>() > 0)
                return;
            List<GClass7> source = new List<GClass7>();
            List<RaceMissile> list = this.gclass0_0.FCTShipDataDictionary.Values
                .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass146_0.RaceData)
                .SelectMany<FCTShipData40, GClass130>(gclass40_0 => gclass40_0.gclass22_0.list_0)
                .Select<GClass130, RaceMissile>(gclass130_0 => gclass130_0.gclass129_0).Distinct<RaceMissile>()
                .ToList<RaceMissile>();
            if (list.Count == 0)
                return;
            foreach (RaceMissile gclass129 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass6.Class492 class492 = new GClass6.Class492();
                // ISSUE: reference to a compiler-generated field
                class492.gclass129_0 = gclass129;
                // ISSUE: reference to a compiler-generated method
                int num1 = this.gclass0_0.FCTShipDataDictionary.Values
                    .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass146_0.RaceData)
                    .SelectMany<FCTShipData40, GClass130>(gclass40_0 => gclass40_0.gclass22_0.list_0)
                    .Where<GClass130>(class492.method_0).Sum<GClass130>(gclass130_0 => gclass130_0.int_0);
                // ISSUE: reference to a compiler-generated method
                int num2 = this.gclass0_0.FCTShipDataDictionary.Values
                    .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass146_0.RaceData)
                    .SelectMany<FCTShipData40, GClass130>(gclass40_0 => gclass40_0.list_10)
                    .Where<GClass130>(class492.method_1).Sum<GClass130>(gclass130_0 => gclass130_0.int_0);
                // ISSUE: reference to a compiler-generated method
                int num3 = this.gclass0_0.PopulationDataDictionary.Values
                    .Where<PopulationData>(gclass146_1 => gclass146_1.RaceData == this.gclass146_0.RaceData)
                    .SelectMany<PopulationData, GClass130>(gclass146_0 => gclass146_0.list_1)
                    .Where<GClass130>(class492.method_2).Sum<GClass130>(gclass130_0 => gclass130_0.int_0);
                // ISSUE: reference to a compiler-generated field
                GClass7 gclass7 = new GClass7()
                {
                    gclass129_0 = class492.gclass129_0,
                    int_0 = num1,
                    int_1 = num2 + num3
                };
                gclass7.decimal_0 = gclass7.int_1 / (Decimal)gclass7.int_0;
                source.Add(gclass7);
            }

            foreach (GClass7 gclass7 in source.OrderBy<GClass7, Decimal>(gclass7_0 => gclass7_0.decimal_0)
                         .ToList<GClass7>())
            {
                int int_3 = (int)Math.Floor(this.gclass146_0.decimal_59 / gclass7.gclass129_0.decimal_3 / 4M);
                if (this.method_25(gclass7.gclass129_0, int_3) > 0)
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 128 /*0x80*/);
        }
    }

    public void method_16()
    {
        try
        {
            if (this.gclass146_0.method_73(AuroraInstallationType.FighterFactory) == 0 || this.gclass146_0.dictionary_2
                    .Values.Where<GClass156>(gclass156_0 =>
                        gclass156_0.auroraProductionType_0 == AuroraProductionType.Fighter).Count<GClass156>() > 0)
                return;
            List<GClass8> source = new List<GClass8>();
            List<GClass22> list = this.gclass0_0.FCTShipDataDictionary.Values
                .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass146_0.RaceData)
                .SelectMany<FCTShipData40, GClass74>(gclass40_0 => gclass40_0.gclass22_0.list_1)
                .Select<GClass74, GClass22>(gclass74_0 => gclass74_0.gclass22_0).Distinct<GClass22>()
                .ToList<GClass22>();
            if (list.Count == 0)
                return;
            foreach (GClass22 gclass22 in list)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass6.Class493 class493 = new GClass6.Class493();
                // ISSUE: reference to a compiler-generated field
                class493.gclass22_0 = gclass22;
                // ISSUE: reference to a compiler-generated method
                int num1 = this.gclass0_0.FCTShipDataDictionary.Values
                    .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass146_0.RaceData)
                    .SelectMany<FCTShipData40, GClass74>(gclass40_0 => gclass40_0.gclass22_0.list_1)
                    .Where<GClass74>(class493.method_0).Sum<GClass74>(gclass74_0 => gclass74_0.int_0);
                // ISSUE: reference to a compiler-generated method
                int num2 = this.gclass0_0.FCTShipDataDictionary.Values.Count<FCTShipData40>(class493.method_1);
                // ISSUE: reference to a compiler-generated field
                GClass8 gclass8 = new GClass8()
                {
                    gclass22_0 = class493.gclass22_0,
                    int_0 = num1,
                    int_1 = num2
                };
                gclass8.decimal_0 = gclass8.int_1 / (Decimal)gclass8.int_0;
                source.Add(gclass8);
            }

            foreach (GClass8 gclass8 in source.OrderBy<GClass8, Decimal>(gclass8_0 => gclass8_0.decimal_0)
                         .ToList<GClass8>())
            {
                int int_3 = (int)Math.Floor(this.gclass146_0.decimal_60 / gclass8.gclass22_0.decimal_4 / 4M);
                if (this.method_26(gclass8.gclass22_0, int_3) > 0)
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3864);
        }
    }

    public void method_17()
    {
        try
        {
            int int_3 = this.gclass146_0.method_73(AuroraInstallationType.ConventionalIndustry);
            if (int_3 == 0 ||
                this.method_21(AuroraInstallationType.TrackingStation,
                    (int)Math.Ceiling(Math.Pow((double)this.gclass146_0.decimal_30, 0.333)), 3) ||
                this.method_20(AuroraInstallationType.GFCC, int_3, 125M, 1))
                return;
            this.gclass146_0.SystemBodyData.method_58(this.gclass146_0.RaceData, this.gclass146_0.SpeciesData, true);
            if (this.gclass146_0.SystemBodyData.MaxColonyCost > 0M &&
                this.method_20(AuroraInstallationType.TerraformingInstallation, int_3, 50M, 1) ||
                this.gclass146_0.method_73(AuroraInstallationType.Infrastructure) < 100 &&
                this.method_20(AuroraInstallationType.Infrastructure, int_3, 1M, 50) ||
                this.method_20(AuroraInstallationType.MilitaryAcademy, int_3, 200M, 1))
                return;
            this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConventionalIndustry], 10);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3952);
        }
    }

    public void method_18()
    {
        try
        {
            int int_3_1 = this.gclass146_0.method_73(AuroraInstallationType.ConstructionFactory) +
                          this.gclass146_0.method_73(AuroraInstallationType.ConventionalIndustry);
            if (int_3_1 == 0)
                return;
            GClass124 gclass124_1 = this.gclass146_0.SystemBodyData.method_19(AuroraElement.Duranium);
            GClass124 gclass124_2 = this.gclass146_0.SystemBodyData.method_19(AuroraElement.Gallicite);
            if (gclass124_1 != null || gclass124_2 != null)
            {
                Decimal num1 = 0M;
                Decimal num2 = 0M;
                Decimal num3 = 0M;
                Decimal num4 = 0M;
                if (gclass124_1 != null)
                {
                    num2 = gclass124_1.decimal_1;
                    num4 = gclass124_1.decimal_0;
                }

                if (gclass124_2 != null)
                {
                    num1 = gclass124_2.decimal_1;
                    num3 = gclass124_2.decimal_0;
                }

                if (num4 > 10000M && num2 > 0.4M || num3 > 10000M && num1 > 0.4M)
                {
                    int num5 = this.gclass146_0.method_73(AuroraInstallationType.Mine) +
                               this.gclass146_0.method_73(AuroraInstallationType.AutomatedMine);
                    if ((num5 * num2 < int_3_1 * 1.2M || num5 * num1 < int_3_1 * 1.2M) && AuroraUtils.smethod_23() &&
                        this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.Mine], 10) > 0)
                        return;
                }
            }

            List<GClass148> list1 = this.gclass0_0.PopulationDataDictionary.Values
                .Where<PopulationData>(gclass146_1 => gclass146_1.RaceData == this.gclass146_0.RaceData)
                .SelectMany<PopulationData, GClass148>(gclass146_0 => gclass146_0.dictionary_5.Values)
                .Where<GClass148>(gclass148_0 => !gclass148_0.bool_1).ToList<GClass148>();
            List<GClass148> list2 = list1.Where<GClass148>(gclass148_0 => !gclass148_0.bool_0).ToList<GClass148>();
            if (list2.Count > 0)
            {
                List<GClass148> list3 = list1.Where<GClass148>(gclass148_0 => gclass148_0.bool_0).ToList<GClass148>();
                List<PlanetaryInstallationType> list4 = list2.Select<GClass148, PlanetaryInstallationType>(gclass148_0 => gclass148_0.gclass157_0)
                    .Distinct<PlanetaryInstallationType>().ToList<PlanetaryInstallationType>();
                foreach (PlanetaryInstallationType gclass157 in list4)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GClass6.Class494 class494 = new GClass6.Class494();
                    // ISSUE: reference to a compiler-generated field
                    class494.gclass157_0 = gclass157;
                    Decimal num6 = 0M;
                    Decimal num7 = 0M;
                    // ISSUE: reference to a compiler-generated method
                    List<GClass148> list5 = list2.Where<GClass148>(class494.method_0).ToList<GClass148>();
                    // ISSUE: reference to a compiler-generated method
                    List<GClass148> list6 = list3.Where<GClass148>(class494.method_1).ToList<GClass148>();
                    if (list5.Count > 0)
                        num6 = list5.Sum<GClass148>(gclass148_0 => gclass148_0.decimal_0);
                    if (list6.Count > 0)
                        num7 = list6.Sum<GClass148>(gclass148_0 => gclass148_0.decimal_0);
                    // ISSUE: reference to a compiler-generated field
                    class494.gclass157_0.decimal_25 = num6 - num7;
                }

                PlanetaryInstallationType gclass157_0_1 = list4
                    .OrderByDescending<PlanetaryInstallationType, Decimal>(gclass157_0 => gclass157_0.decimal_25 * gclass157_0.CargoPoints)
                    .FirstOrDefault<PlanetaryInstallationType>();
                if (gclass157_0_1.decimal_25 > 0M)
                {
                    if (gclass157_0_1.Cost * gclass157_0_1.decimal_25 < 2400M)
                    {
                        this.method_24(gclass157_0_1, (int)gclass157_0_1.decimal_25);
                        return;
                    }

                    if (gclass157_0_1.Cost >= 2400M)
                    {
                        this.method_24(gclass157_0_1, 1);
                        return;
                    }

                    int int_3_2 = (int)Math.Floor(2400M / gclass157_0_1.Cost);
                    this.method_24(gclass157_0_1, int_3_2);
                    return;
                }
            }

            if (this.method_21(AuroraInstallationType.TrackingStation,
                    (int)Math.Ceiling(Math.Pow((double)this.gclass146_0.decimal_30, 0.333)), 3) ||
                int_3_1 < 100 &&
                this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConstructionFactory], 10) > 0 ||
                this.gclass146_0.RaceData.DesignDoctrine.bOrdnanceFactories &&
                this.method_20(AuroraInstallationType.OrdnanceFactory, int_3_1, 3M, 10) ||
                this.gclass146_0.RaceData.DesignDoctrine.bFighterFactories &&
                this.method_20(AuroraInstallationType.FighterFactory, int_3_1, 3M, 10) ||
                this.method_20(AuroraInstallationType.ResearchLab, int_3_1, 20M, 1) ||
                this.method_20(AuroraInstallationType.GFCC, int_3_1, 125M, 1))
                return;
            if (int_3_1 > 200)
            {
                int num8 = this.gclass146_0.method_73(AuroraInstallationType.RefuellingStation);
                int num9 = this.gclass146_0.method_73(AuroraInstallationType.Spaceport);
                if (num8 == 0 && num9 == 0 && this.gclass146_0.FuelStockpile > 1000000M &&
                    this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.RefuellingStation], 1) > 0)
                    return;
            }

            if (int_3_1 > 200)
            {
                int num10 = this.gclass146_0.method_73(AuroraInstallationType.OrdnanceTransferStation);
                int num11 = this.gclass146_0.method_73(AuroraInstallationType.Spaceport);
                if (num10 == 0 && num11 == 0 &&
                    this.gclass146_0.method_73(AuroraInstallationType.OrdnanceFactory) > 10 &&
                    this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConstructionFactory], 1) > 0)
                    return;
            }

            if (this.method_20(AuroraInstallationType.AutomatedMine, int_3_1, 10M, 5))
                return;
            if (int_3_1 > 300)
            {
                AuroraInstallationType key = this.method_19();
                if (key != AuroraInstallationType.NoType && this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[key], 1) > 0)
                    return;
            }

            this.gclass146_0.SystemBodyData.method_58(this.gclass146_0.RaceData, this.gclass146_0.SpeciesData, true);
            if (this.gclass146_0.SystemBodyData.MaxColonyCost > 0M &&
                this.method_20(AuroraInstallationType.TerraformingInstallation, int_3_1, 50M, 1) ||
                this.method_20(AuroraInstallationType.MilitaryAcademy, int_3_1, 200M, 1) ||
                this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConstructionFactory], 10) > 0)
                return;
            this.method_20(AuroraInstallationType.FinancialCentre, int_3_1, 5M, 10);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 129);
        }
    }

    public AuroraInstallationType method_19()
    {
        try
        {
            int num1 = this.gclass0_0.dictionary_3.Values.Count<GClass22>(gclass22_0 =>
                gclass22_0.gclass21_0 == this.gclass146_0.RaceData && gclass22_0.int_38 == 0 && !gclass22_0.bool_2);
            int num2 = this.gclass0_0.dictionary_3.Values.Count<GClass22>(gclass22_0 =>
                gclass22_0.gclass21_0 == this.gclass146_0.RaceData && gclass22_0.int_38 == 0 && gclass22_0.bool_2 &&
                gclass22_0.gclass187_0 == null);
            int num3 = this.gclass0_0.dictionary_31.Values.Count<GClass193>(gclass193_0 =>
                gclass193_0.gclass21_0 == this.gclass146_0.RaceData &&
                gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval);
            int num4 = this.gclass0_0.dictionary_31.Values.Count<GClass193>(gclass193_0 =>
                gclass193_0.gclass21_0 == this.gclass146_0.RaceData &&
                gclass193_0.auroraShipyardType_0 == AuroraShipyardType.Naval);
            int num5 = this.gclass0_0.PopulationDataDictionary.Values
                .Where<PopulationData>(gclass146_1 => gclass146_1.RaceData == this.gclass146_0.RaceData)
                .SelectMany<PopulationData, GClass156>(gclass146_0 => gclass146_0.dictionary_2.Values)
                .Where<GClass156>(gclass156_0 => gclass156_0.gclass157_0 != null).Where<GClass156>(gclass156_0 =>
                    gclass156_0.gclass157_0.InstallationType == AuroraInstallationType.NavalShipyard)
                .Count<GClass156>();
            int num6 = this.gclass0_0.PopulationDataDictionary.Values
                .Where<PopulationData>(gclass146_1 => gclass146_1.RaceData == this.gclass146_0.RaceData)
                .SelectMany<PopulationData, GClass156>(gclass146_0 => gclass146_0.dictionary_2.Values)
                .Where<GClass156>(gclass156_0 => gclass156_0.gclass157_0 != null).Where<GClass156>(gclass156_0 =>
                    gclass156_0.gclass157_0.InstallationType == AuroraInstallationType.CommercialShipyard)
                .Count<GClass156>();
            int num7 = num5;
            if (num3 + num7 < num1)
                return AuroraInstallationType.NavalShipyard;
            return num4 + num6 < num2 ? AuroraInstallationType.CommercialShipyard : AuroraInstallationType.NoType;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 130);
            return AuroraInstallationType.NoType;
        }
    }

    public bool method_20(
        AuroraInstallationType auroraInstallationType_0,
        int int_3,
        Decimal decimal_2,
        int int_4)
    {
        try
        {
            return this.gclass146_0.method_73(auroraInstallationType_0) < int_3 / decimal_2 &&
                   this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[auroraInstallationType_0], int_4) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 131);
            return false;
        }
    }

    public bool method_21(AuroraInstallationType auroraInstallationType_0, int int_3, int int_4)
    {
        try
        {
            int num = this.gclass146_0.method_73(auroraInstallationType_0);
            if (num < int_3)
            {
                int int_3_1 = int_3 - num;
                if (int_3_1 > int_4)
                    int_3_1 = int_4;
                if (this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[auroraInstallationType_0], int_3_1) > 0)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 132);
            return false;
        }
    }

    public bool method_22()
    {
        try
        {
            if (this.gclass146_0.method_73(AuroraInstallationType.ConventionalIndustry) == 0 ||
                !this.gclass146_0.RaceData.method_394(GEnum118.const_45) ||
                !(this.gclass146_0.method_62(AuroraProductionCategory.Construction) > 0M))
                return false;
            int num = this.gclass146_0.method_73(AuroraInstallationType.ConstructionFactory);
            return this.gclass146_0.method_73(AuroraInstallationType.FuelRefinery) < num / 5.0 &&
                   this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConvertCItoRefinery], 5) > 0 ||
                   this.gclass146_0.RaceData.DesignDoctrine.bOrdnanceFactories &&
                   this.gclass146_0.method_73(AuroraInstallationType.OrdnanceFactory) < num / 5.0 &&
                   this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConvertCItoOrdnance], 5) > 0 ||
                   this.gclass146_0.method_73(AuroraInstallationType.Mine) < num &&
                   this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConvertCItoMine], 10) > 0 ||
                   this.method_24(this.gclass0_0.PlanetaryInstallationDictionary[AuroraInstallationType.ConvertCItoCF], 10) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 133);
            return false;
        }
    }

    public void method_23()
    {
        try
        {
            if (this.gclass146_0.method_62(AuroraProductionCategory.Refinery) > 0M &&
                this.gclass146_0.CurrentMinerals.Sorium > 5000M)
                this.gclass146_0.bFuelProdStatus = true;
            else
                this.gclass146_0.bFuelProdStatus = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 134);
        }
    }

    public int method_24(PlanetaryInstallationType gclass157_0, int int_3)
    {
        try
        {
            int num = this.gclass146_0.CurrentMinerals.method_0(gclass157_0.MineralCost);
            if (num < 1)
                return 0;
            if (num < int_3)
                int_3 = num;
            this.gclass146_0.gclass123_5 = gclass157_0.MineralCost;
            this.gclass146_0.decimal_81 = gclass157_0.Cost;
            this.gclass146_0.auroraProductionType_0 = AuroraProductionType.Construction;
            this.gclass146_0.decimal_82 = 0M;
            this.gclass146_0.object_0 = gclass157_0;
            this.gclass146_0.method_143(int_3, 100M);
            return int_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 135);
            return 0;
        }
    }

    public int method_25(RaceMissile gclass129_0, int int_3)
    {
        try
        {
            int num = this.gclass146_0.CurrentMinerals.method_0(gclass129_0.gclass123_0);
            if (num < 1)
                return 0;
            if (num < int_3)
                int_3 = num;
            this.gclass146_0.gclass123_5 = gclass129_0.gclass123_0;
            this.gclass146_0.decimal_81 = gclass129_0.decimal_3;
            this.gclass146_0.auroraProductionType_0 = AuroraProductionType.Ordnance;
            this.gclass146_0.decimal_82 = gclass129_0.int_4;
            this.gclass146_0.object_0 = gclass129_0;
            this.gclass146_0.method_143(int_3, 100M);
            return int_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 136);
            return 0;
        }
    }

    public int method_26(GClass22 gclass22_0, int int_3)
    {
        try
        {
            int num = this.gclass146_0.CurrentMinerals.method_0(gclass22_0.gclass123_0);
            if (num < 1)
                return 0;
            if (num < int_3)
                int_3 = num;
            this.gclass146_0.gclass123_5 = gclass22_0.gclass123_0;
            this.gclass146_0.decimal_81 = gclass22_0.decimal_4;
            this.gclass146_0.auroraProductionType_0 = AuroraProductionType.Fighter;
            this.gclass146_0.decimal_82 = gclass22_0.int_63;
            this.gclass146_0.object_0 = gclass22_0;
            this.gclass146_0.method_143(int_3, 100M);
            return int_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3865);
            return 0;
        }
    }
}