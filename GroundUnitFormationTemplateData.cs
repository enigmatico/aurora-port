// Decompiled with JetBrains decompiler
// Type: GClass102
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GroundUnitFormationTemplateData
{
    private GClass0 gclass0_0;
    public GameRace RaceData;
    public RacialRank RequiredRacialRankData;
    public List<GroundUnitFormationElement> FormationElementList = new List<GroundUnitFormationElement>();
    public AutomatedGroundTemplateDesignType AutomatedTemplateType;
    public int TemplateID;
    public int FormationTrained;
    public int Obsolete;
    public string Abbreviation;
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
    public string string_2 = "None";

    public string Name { get; set; }

    public GroundUnitFormationTemplateData(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public string method_0()
    {
        try
        {
            ++this.FormationTrained;
            return string.Format("{0} {1}", AuroraUtils.smethod_80(this.FormationTrained), this.Name);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3615);
            return "Error";
        }
    }

    public void method_1(TreeNode treeNode_0)
    {
        try
        {
            this.FormationElementList = this.FormationElementList.OrderByDescending<GroundUnitFormationElement, int>(gclass39_0 => gclass39_0.UnitCount)
                .ToList<GroundUnitFormationElement>();
            foreach (GroundUnitFormationElement gclass39 in this.FormationElementList)
                treeNode_0.Nodes.Add(new TreeNode()
                {
                    Text = string.Format("{0}x {1}", gclass39.UnitCount.ToString(), gclass39.GroundUnitClass.ClassName),
                    Tag = gclass39
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3607);
        }
    }

    public bool method_2()
    {
        try
        {
            return this.gclass0_0.Populations.Values
                .SelectMany<PopulationData, GroundUnitTraining>(gclass146_0 => gclass146_0.dictionary_3.Values)
                .Count<GroundUnitTraining>(gclass106_0 => gclass106_0.gclass102_0 == this) > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3256);
            return false;
        }
    }

    public Decimal method_3(PopulationData gclass146_0)
    {
        try
        {
            Decimal num = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.FormationElementList)
            {
                Decimal decimal3 = gclass39.GroundUnitClass.decimal_3;
                if (gclass146_0 != null && gclass39.GroundUnitClass.dictionary_0.Count > 0)
                {
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_2) &&
                        gclass146_0.SystemBodyData.Gravity > gclass146_0.Species.double_8)
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_2].CostMultiplier;
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_3) &&
                        gclass146_0.SystemBodyData.Gravity < gclass146_0.Species.double_7)
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_3].CostMultiplier;
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_8) &&
                        gclass146_0.SystemBodyData.AtmospherePressure > gclass146_0.Species.double_2)
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_8].CostMultiplier;
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_4) &&
                        (gclass146_0.SystemBodyData.SurfaceTemp > gclass146_0.Species.double_11 ||
                         gclass146_0.SystemBodyData.SurfaceTemp < gclass146_0.Species.double_12))
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_4].CostMultiplier;
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_5) &&
                        gclass146_0.SystemBodyData.DominantTerrain.BaseTerrainType == PlanetDominantTerrain.const_2)
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_5].CostMultiplier;
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_9) &&
                        gclass146_0.SystemBodyData.DominantTerrain.BaseTerrainType == PlanetDominantTerrain.const_12)
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_9].CostMultiplier;
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_7) &&
                        gclass146_0.SystemBodyData.DominantTerrain.IsDesertTerrain)
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_7].CostMultiplier;
                    if (gclass39.GroundUnitClass.dictionary_0.ContainsKey(GroundUnitCapability.const_6) &&
                        gclass146_0.SystemBodyData.DominantTerrain.IsJungleTerrain)
                        decimal3 /= this.gclass0_0.GroundUnitCapabilityDictionary[GroundUnitCapability.const_6].CostMultiplier;
                }

                num += decimal3 * gclass39.UnitCount;
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1749);
            return 0M;
        }
    }

    public AllMineralsValue method_4()
    {
        try
        {
            AllMineralsValue gclass123 = new AllMineralsValue(this.gclass0_0);
            foreach (GroundUnitFormationElement gclass39 in this.FormationElementList)
                gclass123.method_11(gclass39.GroundUnitClass.gclass123_0, gclass39.UnitCount);
            return gclass123;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1750);
            return null;
        }
    }

    public void method_5()
    {
        try
        {
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
            this.decimal_10 = 0M;
            this.decimal_11 = 0M;
            this.decimal_12 = 0M;
            this.string_2 = "-";
            foreach (GroundUnitFormationElement gclass39 in this.FormationElementList.OrderBy<GroundUnitFormationElement, int>(gclass39_0 => gclass39_0.GroundUnitClass.int_6)
                         .ToList<GroundUnitFormationElement>())
            {
                this.decimal_2 += gclass39.UnitCount;
                this.decimal_0 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
                this.decimal_1 += gclass39.GroundUnitClass.method_8() * gclass39.UnitCount;
                this.decimal_3 += gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Shots) *
                                  gclass39.UnitCount;
                this.decimal_11 += gclass39.GroundUnitClass.decimal_4 * gclass39.UnitCount;
                this.string_2 = AuroraUtils.smethod_10(gclass39.GroundUnitClass.int_6);
                this.decimal_6 += gclass39.UnitCount * gclass39.GroundUnitClass.decimal_6;
                this.decimal_8 += gclass39.UnitCount *
                                  gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.FireDirection);
                this.decimal_5 += gclass39.UnitCount *
                                  gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.STO);
                this.decimal_4 += gclass39.UnitCount *
                                  gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.int_1);
                this.decimal_9 += gclass39.UnitCount *
                                  gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey);
                this.decimal_10 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Xenoarchaeology);
                this.decimal_13 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Decontamination);
                this.decimal_12 += gclass39.UnitCount *
                                   gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.LogisticsPoint);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1751);
        }
    }

    public void method_6(ListView listView_0, PopulationData gclass146_0)
    {
        try
        {
            RacialRank gclass61 = this.method_7();
            this.method_5();
            string string_17 = "";
            if (this.string_2 != "-")
                string_17 = string.Format("{0}HQ{1}  ", string_17, this.string_2);
            if (this.decimal_5 > 0M)
                string_17 = string.Format("{0}ST{1}   ", string_17, this.decimal_5.ToString());
            if (this.decimal_4 > 0M)
                string_17 = string.Format("{0}CW{1}  ", string_17, this.decimal_4.ToString());
            if (this.decimal_8 > 0M)
                string_17 = string.Format("{0}FD{1}  ", string_17, this.decimal_8.ToString());
            if (this.decimal_6 > 0M)
                string_17 = string.Format("{0}CN{1}  ", string_17, this.decimal_6.ToString());
            if (this.decimal_9 > 0M)
                string_17 = string.Format("{0}GE{1}  ", string_17, this.decimal_9.ToString());
            if (this.decimal_10 > 0M)
                string_17 = string.Format("{0}XN{1}  ", string_17, this.decimal_10.ToString());
            if (this.decimal_13 > 0M)
                string_17 = string.Format("{0}DC{1}  ", string_17, this.decimal_13.ToString());
            if (this.decimal_12 > 0M)
                string_17 = string.Format("{0}LG{1}  ", string_17, Math.Round(this.decimal_12 / 1000M).ToString());
            Color color_0 = AuroraUtils.color_16;
            if (this.Obsolete == 1)
                color_0 = Color.Orange;
            this.gclass0_0.method_616(listView_0, this.Abbreviation, this.Name, this.decimal_2.ToString(),
                AuroraUtils.smethod_38(this.decimal_0), AuroraUtils.smethod_38(this.method_3(gclass146_0)),
                AuroraUtils.smethod_38(this.decimal_1), AuroraUtils.smethod_38(this.decimal_11), string_17,
                gclass61.method_0(), color_0, this);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1752);
        }
    }

    public RacialRank method_7()
    {
        try
        {
            if (this.RequiredRacialRankData != null)
                return this.RequiredRacialRankData;
            int int_57 = this.method_8();
            this.decimal_0 = this.method_9();
            return this.RaceData.method_156((int)this.decimal_0, int_57);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1753);
            return null;
        }
    }

    public int method_8()
    {
        try
        {
            return this.FormationElementList.Count == 0 ? 0 : this.FormationElementList.Max<GroundUnitFormationElement>(gclass39_0 => gclass39_0.GroundUnitClass.int_6);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1754);
            return 0;
        }
    }

    public Decimal method_9()
    {
        try
        {
            this.decimal_0 = 0M;
            foreach (GroundUnitFormationElement gclass39 in this.FormationElementList)
                this.decimal_0 += gclass39.GroundUnitClass.decimal_2 * gclass39.UnitCount;
            return this.decimal_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1755);
            return 0M;
        }
    }

    public void method_10(ListView listView_0)
    {
        try
        {
            listView_0.Items.Clear();
            this.gclass0_0.method_613(listView_0, "Name", "Units", "Size", "Cost", "HP", "GSP", "Element Attributes",
                null);
            this.FormationElementList = this.FormationElementList
                .OrderByDescending<GroundUnitFormationElement, Decimal>(gclass39_0 => gclass39_0.GroundUnitClass.decimal_2 * gclass39_0.UnitCount)
                .ToList<GroundUnitFormationElement>();
            foreach (GroundUnitFormationElement object_1 in this.FormationElementList)
            {
                string str = AuroraUtils.smethod_10(object_1.GroundUnitClass.int_6);
                int num1 = object_1.UnitCount *
                           object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.FireDirection);
                Decimal num2 = object_1.UnitCount *
                               object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Construction);
                Decimal num3 = object_1.UnitCount *
                               object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey);
                Decimal num4 = object_1.UnitCount *
                               object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Xenoarchaeology);
                Decimal num5 = object_1.UnitCount *
                               object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Decontamination);
                Decimal decimal_73 = object_1.UnitCount *
                                     object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.LogisticsPoint);
                string string_16 = "";
                for (int index = 0; index < object_1.GroundUnitClass.GroundUnitComponentList.Count; ++index)
                {
                    if (object_1.GroundUnitClass.GroundUnitComponentList[index].GroundWeapon)
                        string_16 = string.Format("{0}{1}  ", string_16,
                            object_1.GroundUnitClass.GroundUnitComponentList[index].Abbreviation);
                }

                if (str != "-")
                    string_16 = string.Format("{0}HQ {1}  ", string_16, str);
                if (object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.STO) > 0)
                    string_16 += "ST  ";
                if (object_1.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.int_1) > 0)
                    string_16 += "CW  ";
                if (num1 > 0)
                    string_16 = string.Format("{0}FD {1}  ", string_16, num1.ToString());
                if (num2 > 0M)
                    string_16 = string.Format("{0}CN {1}  ", string_16, num2.ToString());
                if (num3 > 0M)
                    string_16 = string.Format("{0}GE {1}  ", string_16, num3.ToString());
                if (num4 > 0M)
                    string_16 = string.Format("{0}XN {1}  ", string_16, num4.ToString());
                if (num5 > 0M)
                    string_16 = string.Format("{0}DC {1}  ", string_16, num5.ToString());
                if (decimal_73 > 0M)
                    string_16 = string.Format("{0}GSP {1}  ", string_16, AuroraUtils.smethod_38(decimal_73));
                this.gclass0_0.method_613(listView_0, object_1.GroundUnitClass.ClassName, object_1.UnitCount.ToString(),
                    AuroraUtils.smethod_38(object_1.GroundUnitClass.decimal_2 * object_1.UnitCount),
                    AuroraUtils.smethod_45(object_1.GroundUnitClass.decimal_3 * object_1.UnitCount, 1),
                    (object_1.GroundUnitClass.method_8() * object_1.UnitCount).ToString(),
                    AuroraUtils.smethod_38(object_1.GroundUnitClass.decimal_4 * object_1.UnitCount), string_16, object_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1756);
        }
    }

    public string method_11()
    {
        try
        {
            string str =
                string.Format("{0}Build Cost: {1} BP{2}",
                    string.Format("{0}Transport Size: {1} tons{2}", this.Name + Environment.NewLine,
                        AuroraUtils.smethod_39(this.method_9()), Environment.NewLine),
                    AuroraUtils.FormatNumberToDigits(this.method_3(null), 1), Environment.NewLine);
            foreach (GroundUnitFormationElement gclass39 in this.FormationElementList)
                str = string.Format("{0}{1}x {2}{3}", str, gclass39.UnitCount.ToString(),
                    gclass39.GroundUnitClass.ClassName, Environment.NewLine);
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1757);
            return "error";
        }
    }

    public void method_12(GroundUnitClass101 gclass101_0, int int_3)
    {
        try
        {
            this.FormationElementList.Add(new GroundUnitFormationElement(this.gclass0_0)
            {
                FormationTemplate = this,
                GroundUnitClass = gclass101_0,
                UnitCount = int_3
            });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1758);
        }
    }
}