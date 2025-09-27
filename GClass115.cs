// Decompiled with JetBrains decompiler
// Type: GClass115
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass115
{
    private sealed class Class1068
    {
        public List<int> list_0;

        internal bool method_0(TechSystem gclass164_0)
        {
            return this.list_0.Contains(gclass164_0.TechSystemID);
        }
    }


    private sealed class Class1069
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass118 gclass118_0)
        {
            return gclass118_0.gclass230_0 == this.gclass230_0;
        }
    }


    private sealed class Class1070
    {
        public ShipComponent gclass230_0;

        internal bool method_0(GClass119 gclass119_0)
        {
            return gclass119_0.gclass230_0 == this.gclass230_0;
        }
    }

    private GClass0 gclass0_0;
    public List<GClass118> list_0 = new List<GClass118>();
    public List<GClass119> list_1 = new List<GClass119>();
    public List<TechSystem> list_2 = new List<TechSystem>();
    public AlienRaceInfo gclass110_0;
    public GClass22 gclass22_0;
    public GameRace gclass21_0;
    public GameRace gclass21_1;
    public ShipHull gclass76_0;
    public GEnum57 genum57_0;
    public EngineDesignType genum70_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;
    public Decimal decimal_4;
    public Decimal decimal_5;
    public Decimal decimal_6;
    public Decimal decimal_7;
    public bool bool_0;
    public bool bool_1;
    public string string_0;
    public string string_1 = "No Class Summary Available";
    public int int_5;
    public int int_6;
    public int int_7;

    public string ClassName { get; set; }

    public GClass115(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(GClass235 gclass235_0)
    {
        try
        {
            if (gclass235_0.gclass230_0.bool_11)
                this.method_11(null, gclass235_0.gclass230_0, 0.0, gclass235_0.int_0);
            else if (gclass235_0.gclass230_0.gclass231_0.ComponentTypeID ==
                     AuroraComponentType.ActiveSearchSensors ||
                     gclass235_0.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.EMSensors ||
                     gclass235_0.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.ThermalSensors)
                this.list_0.Add(this.gclass21_1.method_41(gclass235_0.gclass230_0, this.gclass110_0));
            this.method_1(gclass235_0.gclass230_0.int_16);
            this.method_1(gclass235_0.gclass230_0.int_17);
            this.method_1(gclass235_0.gclass230_0.int_18);
            this.method_1(gclass235_0.gclass230_0.int_19);
            this.method_1(gclass235_0.gclass230_0.int_20);
            this.method_1(gclass235_0.gclass230_0.int_21);
            this.method_1(gclass235_0.gclass230_0.int_22);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3708);
        }
    }

    public void method_1(int int_8)
    {
        try
        {
            if (int_8 <= 0 || !this.gclass0_0.TechDataDictionary.ContainsKey(int_8) ||
                this.list_2.Contains(this.gclass0_0.TechDataDictionary[int_8]))
                return;
            this.list_2.Add(this.gclass0_0.TechDataDictionary[int_8]);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3709);
        }
    }

    public Decimal method_2(RacialSystemSurvey gclass202_0)
    {
        try
        {
            Decimal num = this.decimal_3 * AuroraUtils.decimal_17;
            if (this.bool_1 && this.list_1.Count == 0 && gclass202_0.gclass3_0.int_3 < 1 &&
                (gclass202_0.gclass3_0.genum95_0 < GEnum95.const_5 || this.gclass21_1.RacialSystemDictionary.Count == 1))
            {
                num -= 10000M;
                ++gclass202_0.gclass3_0.int_3;
            }

            if (num < 0M)
                return 0M;
            return this.genum70_0 == EngineDesignType.const_1 || this.list_1.Count > 0 ? num : num * 0.1M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1899);
            return 0M;
        }
    }

    public string method_3()
    {
        try
        {
            if (this.genum70_0 == EngineDesignType.const_1)
                return "Military";
            return this.genum70_0 == EngineDesignType.const_2 ? "Commercial" : "Unknown";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1900);
            return "";
        }
    }

    public string method_4()
    {
        try
        {
            if (this.genum70_0 == EngineDesignType.const_1)
                return "M";
            return this.genum70_0 == EngineDesignType.const_2 ? "C" : "";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1901);
            return "";
        }
    }

    public int method_5()
    {
        try
        {
            return this.gclass21_1.dictionary_12.Values.Count<GClass117>(gclass117_0 =>
                gclass117_0.gclass115_0 == this && !gclass117_0.bool_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1902);
            return 0;
        }
    }

    public GClass115 method_6(GameRace gclass21_2, List<AlienRaceInfo> list_3)
    {
        try
        {
            GClass115 gclass115_1 = new GClass115(this.gclass0_0);
            GClass115 gclass115_2 = (GClass115)this.MemberwiseClone();
            gclass115_2.int_0 = this.gclass0_0.method_26(GEnum0.const_39);
            gclass115_2.gclass21_1 = gclass21_2;
            gclass115_2.gclass110_0 =
                list_3.FirstOrDefault<AlienRaceInfo>(gclass110_1 => gclass110_1.ActualAlienRace == this.gclass21_0);
            gclass115_2.list_2 = new List<TechSystem>();
            gclass115_2.list_1 = new List<GClass119>();
            gclass115_2.list_0 = new List<GClass118>();
            foreach (TechSystem gclass164 in this.list_2)
                gclass115_2.list_2.Add(gclass164);
            foreach (GClass119 gclass119_1 in this.list_1)
            {
                GClass119 gclass119_2 = gclass119_1.method_0();
                gclass115_2.list_1.Add(gclass119_2);
            }

            foreach (GClass118 gclass118_1 in this.list_0)
            {
                GClass118 gclass118_2 = gclass118_1.method_2(gclass21_2);
                gclass115_2.list_0.Add(gclass118_2);
            }

            return gclass115_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1903);
            return null;
        }
    }

    public double method_7()
    {
        try
        {
            List<GClass119> list = this.list_1.Where<GClass119>(gclass119_0 => gclass119_0.gclass230_0.bool_4)
                .ToList<GClass119>();
            return list.Count == 0 ? 0.0 : list.Max<GClass119>(gclass119_0 => gclass119_0.double_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1904);
            return 0.0;
        }
    }

    public void method_8()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass115.Class1068 class1068 = new GClass115.Class1068();
            if (!this.gclass21_1.NPR && this.gclass21_0.NPR)
                this.gclass22_0.ClassName = this.ClassName;
            this.int_1 = this.gclass22_0.int_2;
            this.int_2 = this.gclass22_0.int_32;
            this.int_3 = this.gclass22_0.int_28;
            this.decimal_5 = this.gclass22_0.decimal_18;
            this.decimal_6 = this.gclass22_0.decimal_19;
            this.decimal_7 = this.gclass22_0.decimal_20;
            this.decimal_4 = this.gclass22_0.int_42;
            this.decimal_0 = this.gclass22_0.int_40;
            this.ClassName = this.gclass22_0.ClassName;
            this.list_0.Clear();
            foreach (ShipComponent gclass230 in this.gclass22_0.dictionary_0.Values
                         .Where<GClass228>(gclass228_0 =>
                             gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                             AuroraComponentType.ActiveSearchSensors)
                         .Select<GClass228, ShipComponent>(gclass228_0 => gclass228_0.gclass230_0).Distinct<ShipComponent>()
                         .ToList<ShipComponent>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass115.Class1069 class1069 = new GClass115.Class1069();
                // ISSUE: reference to a compiler-generated field
                class1069.gclass230_0 = gclass230;
                // ISSUE: reference to a compiler-generated method
                GClass118 gclass118 =
                    this.gclass110_0.dictionary_2.Values.FirstOrDefault<GClass118>(class1069.method_0);
                if (gclass118 == null)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    gclass118 = new GClass118()
                    {
                        int_0 = this.gclass0_0.method_26(GEnum0.const_43),
                        decimal_1 = class1069.gclass230_0.decimal_3,
                        int_1 = (int)class1069.gclass230_0.decimal_6,
                        double_0 = class1069.gclass230_0.double_0,
                        double_1 = 500.0,
                        gclass230_0 = class1069.gclass230_0,
                        gclass21_1 = this.gclass22_0.gclass21_0,
                        gclass21_0 = this.gclass21_1
                    };
                    gclass118.string_0 = "AS " + gclass118.int_0.ToString();
                    this.gclass110_0.dictionary_2.Add(gclass118.int_0, gclass118);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass118.decimal_1 = class1069.gclass230_0.decimal_3;
                    // ISSUE: reference to a compiler-generated field
                    gclass118.int_1 = (int)class1069.gclass230_0.decimal_6;
                    // ISSUE: reference to a compiler-generated field
                    gclass118.double_0 = class1069.gclass230_0.double_0;
                    gclass118.double_1 = 500.0;
                }

                if (!this.list_0.Contains(gclass118))
                    this.list_0.Add(gclass118);
            }

            this.list_1.Clear();
            foreach (GClass228 gclass228 in this.gclass22_0.dictionary_0.Values.Where<GClass228>(gclass228_0 =>
                         gclass228_0.gclass230_0.bool_4 || gclass228_0.gclass230_0.gclass231_0.ComponentTypeID ==
                         AuroraComponentType.MissileLauncher).ToList<GClass228>())
                this.list_1.Add(new GClass119()
                {
                    gclass230_0 = gclass228.gclass230_0,
                    double_0 = gclass228.gclass230_0.method_4(),
                    int_1 = (int)gclass228.decimal_0,
                    decimal_0 = this.gclass0_0.GameTime,
                    int_0 = 0
                });
            // ISSUE: reference to a compiler-generated field
            class1068.list_0 = this.gclass22_0.dictionary_0.Values
                .Select<GClass228, int>(gclass228_0 => gclass228_0.gclass230_0.int_16).Where<int>(int_0 => int_0 > 0)
                .ToList<int>();
            // ISSUE: reference to a compiler-generated field
            class1068.list_0.AddRange(this.gclass22_0.dictionary_0.Values
                .Select<GClass228, int>(gclass228_0 => gclass228_0.gclass230_0.int_17).Where<int>(int_0 => int_0 > 0)
                .ToList<int>());
            // ISSUE: reference to a compiler-generated field
            class1068.list_0.AddRange(this.gclass22_0.dictionary_0.Values
                .Select<GClass228, int>(gclass228_0 => gclass228_0.gclass230_0.int_18).Where<int>(int_0 => int_0 > 0)
                .ToList<int>());
            // ISSUE: reference to a compiler-generated field
            class1068.list_0.AddRange(this.gclass22_0.dictionary_0.Values
                .Select<GClass228, int>(gclass228_0 => gclass228_0.gclass230_0.int_19).Where<int>(int_0 => int_0 > 0)
                .ToList<int>());
            // ISSUE: reference to a compiler-generated field
            class1068.list_0.AddRange(this.gclass22_0.dictionary_0.Values
                .Select<GClass228, int>(gclass228_0 => gclass228_0.gclass230_0.int_20).Where<int>(int_0 => int_0 > 0)
                .ToList<int>());
            // ISSUE: reference to a compiler-generated field
            class1068.list_0.AddRange(this.gclass22_0.dictionary_0.Values
                .Select<GClass228, int>(gclass228_0 => gclass228_0.gclass230_0.int_21).Where<int>(int_0 => int_0 > 0)
                .ToList<int>());
            // ISSUE: reference to a compiler-generated field
            class1068.list_0.AddRange(this.gclass22_0.dictionary_0.Values
                .Select<GClass228, int>(gclass228_0 => gclass228_0.gclass230_0.int_22).Where<int>(int_0 => int_0 > 0)
                .ToList<int>());
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1068.list_0 = class1068.list_0.Distinct<int>().ToList<int>();
            // ISSUE: reference to a compiler-generated method
            List<TechSystem> list = this.gclass0_0.TechDataDictionary.Values.Where<TechSystem>(class1068.method_0)
                .ToList<TechSystem>();
            this.list_2.Clear();
            foreach (TechSystem gclass164 in list)
                this.list_2.Add(gclass164);
            this.gclass22_0.method_85(0, 0, "");
            this.string_1 = this.gclass22_0.string_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1905);
        }
    }

    public int method_9()
    {
        try
        {
            List<GClass117> list = this.gclass21_1.dictionary_12.Values
                .Where<GClass117>(gclass117_0 => gclass117_0.gclass115_0 == this).ToList<GClass117>();
            return list.Count == 0 ? 0 : (int)(list.Sum<GClass117>(gclass117_0 => gclass117_0.decimal_6) / list.Count);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1906);
            return 0;
        }
    }

    public double method_10()
    {
        try
        {
            List<GClass117> list = this.gclass21_1.dictionary_12.Values
                .Where<GClass117>(gclass117_0 => gclass117_0.gclass115_0 == this).ToList<GClass117>();
            return list.Count == 0
                ? 0.0
                : list.Sum<GClass117>(gclass117_0 => gclass117_0.int_3) /
                  (double)list.Sum<GClass117>(gclass117_0 => gclass117_0.decimal_6);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1907);
            return 0.0;
        }
    }

    public void method_11(GClass117 gclass117_0, ShipComponent gclass230_0, double double_0, int int_8)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass115.Class1070 class1070 = new GClass115.Class1070();
        // ISSUE: reference to a compiler-generated field
        class1070.gclass230_0 = gclass230_0;
        try
        {
            bool flag = false;
            // ISSUE: reference to a compiler-generated method
            GClass119 gclass119 = this.list_1.FirstOrDefault<GClass119>(class1070.method_0);
            if (gclass119 == null)
            {
                // ISSUE: reference to a compiler-generated field
                this.list_1.Add(new GClass119()
                {
                    gclass230_0 = class1070.gclass230_0,
                    double_0 = double_0,
                    int_1 = int_8,
                    decimal_0 = this.gclass0_0.GameTime,
                    int_0 = 0
                });
                flag = true;
                // ISSUE: reference to a compiler-generated field
                if (class1070.gclass230_0.gclass231_0.ComponentTypeID == AuroraComponentType.MissileLauncher)
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class1070.gclass230_0.decimal_1 >= AuroraUtils.int_53)
                        this.genum57_0 = GEnum57.const_1;
                    else if (this.genum57_0 == GEnum57.const_0)
                        this.genum57_0 = GEnum57.const_2;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (class1070.gclass230_0.bool_4)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (class1070.gclass230_0.decimal_0 > class1070.gclass230_0.decimal_4 * 2M)
                            this.genum57_0 = GEnum57.const_3;
                        else if (this.genum57_0 == GEnum57.const_0)
                            this.genum57_0 = GEnum57.const_4;
                    }
                }
            }
            else
            {
                if (double_0 > gclass119.double_0)
                {
                    gclass119.double_0 = double_0;
                    flag = true;
                }

                if (int_8 > gclass119.int_1)
                {
                    gclass119.int_1 = int_8;
                    flag = true;
                }

                if ((this.gclass0_0.GameTime - gclass119.decimal_0 < gclass119.int_0 || gclass119.int_0 == 0) &&
                    this.gclass0_0.GameTime != gclass119.decimal_0)
                {
                    gclass119.int_0 = (int)(this.gclass0_0.GameTime - gclass119.decimal_0);
                    flag = true;
                }
            }

            if (!flag || gclass117_0 == null || gclass117_0.gclass40_0 == null)
                return;
            this.gclass0_0.gclass92_0.method_2(EventType.const_66,
                $"Based on observation of {gclass117_0.string_0}, intelligence on the weapons of the {this.method_13()} class has been updated: ",
                this.gclass21_1, gclass117_0.gclass40_0.gclass85_0.System.ActualSystemData,
                gclass117_0.gclass40_0.gclass85_0.XCoord, gclass117_0.gclass40_0.gclass85_0.YCoord,
                AuroraEventCategory.Intelligence);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1908);
        }
    }

    public void method_12(int int_8)
    {
        try
        {
            if (this.int_1 >= int_8)
                return;
            this.int_1 = int_8;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1909);
        }
    }

    public string method_13()
    {
        try
        {
            return $"{this.gclass76_0.Abbreviation} {this.ClassName}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1910);
            return "error";
        }
    }

    public void method_14(GClass65 gclass65_0)
    {
        try
        {
            if (gclass65_0.genum10_0 == GEnum10.const_0)
            {
                if (gclass65_0.decimal_0 > this.decimal_3)
                    this.decimal_3 = gclass65_0.decimal_0;
            }
            else if (gclass65_0.genum10_0 == GEnum10.const_1)
            {
                if (gclass65_0.decimal_0 > this.decimal_0)
                    this.decimal_0 = gclass65_0.decimal_0;
                if (gclass65_0.int_5 > 1 && this.genum70_0 == EngineDesignType.const_0)
                    this.genum70_0 = !gclass65_0.gclass40_0.gclass22_0.bool_8 ? EngineDesignType.const_2 : EngineDesignType.const_1;
            }
            else if (gclass65_0.genum10_0 == GEnum10.const_3 && gclass65_0.decimal_0 > this.decimal_4 * 30M)
                this.decimal_4 = gclass65_0.decimal_0 / 30M;

            if (gclass65_0.int_5 <= this.int_2)
                return;
            this.int_2 = gclass65_0.int_5;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1911);
        }
    }
}