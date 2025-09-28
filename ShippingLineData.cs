// Decompiled with JetBrains decompiler
// Type: GClass187
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class ShippingLineData
{
    private sealed class Class1156
    {
        public ShipData gclass40_0;
        public ShippingLineData gclass187_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData == this.gclass40_0.gclass85_0.OrbitingBody &&
                   gclass146_0.Race == this.gclass187_0.gclass21_0;
        }
    }


    private sealed class Class1157
    {
        public List<PopulationData> list_0;

        internal bool method_0(GClass193 gclass193_0)
        {
            return this.list_0.Contains(gclass193_0.gclass146_0);
        }
    }


    private sealed class Class1158
    {
        public ShippingLineData gclass187_0;
        public AutomatedClassDesign gclass14_0;

        internal bool method_0(ShipClass gclass22_0)
        {
            return gclass22_0.gclass187_0 == this.gclass187_0 && gclass22_0.Obsolete == 0 &&
                   gclass22_0.AutomatedClassDesign == this.gclass14_0;
        }
    }


    private sealed class Class1159
    {
        public List<StarSystem> list_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return this.list_0.Contains(gclass1_0.SystemData);
        }
    }


    private sealed class Class1160
    {
        public ShippingLineData gclass187_0;
        public ShipClass gclass22_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return gclass40_0.gclass187_0 == this.gclass187_0 &&
                   gclass40_0.gclass22_0.MainFunction == this.gclass22_0.MainFunction &&
                   gclass40_0.decimal_1 < this.gclass187_0.gclass0_0.GameTime - AuroraUtils.decimal_29 * 10M;
        }
    }


    private sealed class Class1161
    {
        public CommanderNameThemeData gclass58_0;

        internal bool method_0(CommanderNameDefinition gclass57_0)
        {
            return gclass57_0.CommanderNameTheme == this.gclass58_0 && gclass57_0.AllowedForLastName;
        }
    }

    public List<ShippingWealthData> WealthDataList = new List<ShippingWealthData>();
    private GClass0 gclass0_0;
    public GameRace gclass21_0;
    public ShipComponent gclass230_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public bool bool_0;
    public string string_0;
    public string string_1;
    public int int_3;
    public int int_4;
    public int int_5;
    public int int_6;
    public int int_7;
    public int int_8;
    public int int_9;
    public int int_10;

    public ShippingLineData(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            foreach (ShipData gclass40 in this.gclass0_0.Ships.Values
                         .Where<ShipData>(gclass40_0 => gclass40_0.gclass187_0 == this)
                         .Where<ShipData>(gclass40_0 =>
                             gclass40_0.dictionary_5.Count > 0 || gclass40_0.list_12.Count > 0).ToList<ShipData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                ShippingLineData.Class1156 class1156 = new ShippingLineData.Class1156();
                // ISSUE: reference to a compiler-generated field
                class1156.gclass187_0 = this;
                // ISSUE: reference to a compiler-generated field
                class1156.gclass40_0 = gclass40;
                // ISSUE: reference to a compiler-generated field
                if (class1156.gclass40_0.gclass85_0.OrbitingBody != null)
                {
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: reference to a compiler-generated method
                    if (this.gclass0_0.dictionary_31.Values.Count<GClass193>(new ShippingLineData.Class1157()
                        {
                            list_0 = this.gclass0_0.Populations.Values.Where<PopulationData>(class1156.method_0)
                                .ToList<PopulationData>()
                        }.method_0) > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1156.gclass40_0.list_12.Clear();
                        // ISSUE: reference to a compiler-generated field
                        class1156.gclass40_0.dictionary_5.Clear();
                        continue;
                    }
                }

                // ISSUE: reference to a compiler-generated field
                if (class1156.gclass40_0.method_171(true) < 2M)
                {
                    // ISSUE: reference to a compiler-generated field
                    class1156.gclass40_0.gclass187_0 = null;
                    // ISSUE: reference to a compiler-generated field
                    class1156.gclass40_0.gclass85_0.ShippingLine = null;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.gclass92_0.method_2(EventType.const_83,
                        $"{this.string_0} is unable to repair {class1156.gclass40_0.method_187()} so they have transferred it to our control.",
                        this.gclass21_0, class1156.gclass40_0.gclass85_0.System.ActualSystem,
                        class1156.gclass40_0.gclass85_0.XCoord, class1156.gclass40_0.gclass85_0.YCoord,
                        AuroraEventCategory.Ship);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3585);
        }
    }

    public void method_1(ListView listView_0, ListView listView_1)
    {
        try
        {
            listView_0.Items.Clear();
            listView_1.Items.Clear();
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass187_0 == this).ToList<ShipData>();
            Decimal decimal_73_1 = list.Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size) *
                                   AuroraUtils.decimal_17;
            Decimal decimal_73_2 = this.WealthDataList
                .Where<ShippingWealthData>(gclass188_0 =>
                    gclass188_0.TradeTime > this.gclass0_0.GameTime - AuroraUtils.decimal_29)
                .Sum<ShippingWealthData>(gclass188_0 => gclass188_0.Amount);
            string string_11 = "No Dividend Paid";
            if (this.decimal_2 > 0M)
                string_11 = this.gclass0_0.method_584(this.decimal_2);
            this.gclass0_0.method_601(listView_0, "Total Ships", AuroraUtils.smethod_37(list.Count), null);
            this.gclass0_0.method_601(listView_0, "Total Tonnage", AuroraUtils.smethod_39(decimal_73_1), null);
            this.gclass0_0.method_601(listView_0, "Last Year Income", AuroraUtils.smethod_39(decimal_73_2), null);
            this.gclass0_0.method_601(listView_0, "Last Dividend Time", string_11, null);
            this.gclass0_0.method_601(listView_0, "Last Dividend Amount", AuroraUtils.smethod_39(this.decimal_1), null);
            this.gclass0_0.method_601(listView_0, "Current Wealth", AuroraUtils.smethod_39(this.decimal_0), null);
            this.gclass0_0.method_594(listView_0, "");
            foreach (IGrouping<ShipClass, ShipData> source in list
                         .GroupBy<ShipData, ShipClass>(gclass40_0 => gclass40_0.gclass22_0)
                         .OrderBy<IGrouping<ShipClass, ShipData>, string>(igrouping_0 => igrouping_0.Key.ClassName))
            {
                int int_72 = source.Count<ShipData>();
                this.gclass0_0.method_601(listView_0, source.Key.ClassName, AuroraUtils.smethod_37(int_72), null);
            }

            this.gclass0_0.method_611(listView_1, "Date", "Ship", "Trade Good", "Origin", "Destination", null);
            this.WealthDataList = this.WealthDataList.OrderByDescending<ShippingWealthData, Decimal>(gclass188_0 => gclass188_0.TradeTime)
                .ToList<ShippingWealthData>();
            foreach (ShippingWealthData gclass188 in this.WealthDataList)
            {
                if (gclass188.Ship != null)
                {
                    if (gclass188.Colonist)
                        this.gclass0_0.method_612(listView_1, this.gclass0_0.method_584(gclass188.TradeTime),
                            gclass188.Ship.method_187(), "Colonists", gclass188.OriginPop.PopName,
                            gclass188.DestinationPop.PopName, AuroraUtils.FormatNumberToDigits(gclass188.Amount, 1), null);
                    else if (gclass188.TradeGood == null)
                        this.gclass0_0.method_612(listView_1, this.gclass0_0.method_584(gclass188.TradeTime),
                            gclass188.Ship.method_187(), "Trade Goods", gclass188.OriginPop.PopName,
                            gclass188.DestinationPop.PopName, AuroraUtils.FormatNumberToDigits(gclass188.Amount, 1), null);
                    else
                        this.gclass0_0.method_612(listView_1, this.gclass0_0.method_584(gclass188.TradeTime),
                            gclass188.Ship.method_187(), gclass188.TradeGood.string_0,
                            gclass188.OriginPop.PopName, gclass188.DestinationPop.PopName,
                            AuroraUtils.FormatNumberToDigits(gclass188.Amount, 1), null);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2907);
        }
    }

    public ShipClass method_2(AutomatedClassDesign gclass14_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShippingLineData.Class1158 class1158 = new ShippingLineData.Class1158();
        // ISSUE: reference to a compiler-generated field
        class1158.gclass187_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1158.gclass14_0 = gclass14_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.ShipClasses.Values.FirstOrDefault<ShipClass>(class1158.method_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2908);
            return null;
        }
    }

    public int method_3()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass187_0 == this).Count<ShipData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2909);
            return 0;
        }
    }

    public Decimal method_4()
    {
        try
        {
            return this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass187_0 == this)
                .Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Cost);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2910);
            return 0M;
        }
    }

    public void method_5()
    {
        try
        {
            this.int_3 = 0;
            this.int_4 = 0;
            this.int_5 = 0;
            this.int_6 = 0;
            this.int_8 = 0;
            this.int_9 = 0;
            this.int_10 = 0;
            List<ShipData> list = this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass187_0 == this).ToList<ShipData>();
            this.int_7 = list.Count;
            foreach (ShipData gclass40 in list)
            {
                if (gclass40.gclass22_0.MainFunction == AuroraClassMainFunction.Freighter)
                {
                    ++this.int_3;
                    if (gclass40.gclass85_0.MoveOrderDictionary.Count > 0)
                        ++this.int_8;
                }
                else if (gclass40.gclass22_0.MainFunction == AuroraClassMainFunction.ColonyShip)
                {
                    ++this.int_4;
                    if (gclass40.gclass85_0.MoveOrderDictionary.Count > 0)
                        ++this.int_9;
                }
                else if (gclass40.gclass22_0.MainFunction == AuroraClassMainFunction.Liner)
                {
                    ++this.int_6;
                    if (gclass40.gclass85_0.MoveOrderDictionary.Count > 0)
                        ++this.int_10;
                }
                else if (gclass40.gclass22_0.MainFunction == AuroraClassMainFunction.FuelHarvester)
                    ++this.int_5;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2911);
        }
    }

    public Decimal method_6()
    {
        try
        {
            Decimal num1 = this.method_4();
            if (num1 == 0M)
                return 0M;
            Decimal num2 = (num1 + this.decimal_0) / 10M;
            if (num2 > this.decimal_0 - 1000M)
                num2 = this.decimal_0 - 1000M;
            if (num2 < 0M)
                num2 = 0M;
            return num2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2912);
            return 0M;
        }
    }

    public void method_7()
    {
        try
        {
            Decimal num1 = this.method_6();
            if (this.gclass0_0.GameTime - this.decimal_2 > AuroraUtils.decimal_29)
            {
                this.decimal_0 -= num1;
                this.decimal_1 = num1;
                this.decimal_2 = this.gclass0_0.GameTime;
            }

            if (this.decimal_0 < num1 + 500M)
                return;
            int num2 = this.gclass0_0.Populations.Values.Where<PopulationData>(gclass146_0 =>
                gclass146_0.Population > 0M && gclass146_0.Race == this.gclass21_0).Count<PopulationData>();
            int num3 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(
                    gclass146_0 => gclass146_0.Population > 0M && gclass146_0.Race == this.gclass21_0)
                .Select<PopulationData, RacialSystemSurvey>(gclass146_0 => gclass146_0.gclass202_0).Distinct<RacialSystemSurvey>()
                .Count<RacialSystemSurvey>();
            if (num2 < 2)
                return;
            if (this.decimal_0 < 25000M)
            {
                Decimal num4 = 1M;
                if (this.decimal_0 > 6000M)
                    num4 = (int)(this.decimal_0 - 5000M) / 1000M;
                if (AuroraUtils.GetRandomInteger(16 /*0x10*/) > num4)
                    return;
            }

            this.method_5();
            PopulationData gclass146_1 = this.gclass0_0.Populations.Values.FirstOrDefault<PopulationData>(gclass146_0 =>
                gclass146_0.bIsCapital && gclass146_0.Race == this.gclass21_0);
            if (gclass146_1 == null)
                return;
            AuroraClassMainFunction classMainFunction;
            if (this.int_7 < 6)
                classMainFunction = this.method_8();
            else if (this.int_8 == this.int_3 && this.int_9 == this.int_4)
                classMainFunction = this.method_8();
            else if (this.int_8 == this.int_3)
                classMainFunction = AuroraClassMainFunction.Freighter;
            else if (this.int_9 == this.int_4)
                classMainFunction = AuroraClassMainFunction.ColonyShip;
            else if (this.int_10 == this.int_6 && num3 > 1)
            {
                classMainFunction = AuroraClassMainFunction.Liner;
            }
            else
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                SystemBodyData gclass1 = this.gclass0_0.SystemBodyRecordDic.Values
                    .Where<SystemBodyData>(gclass1_0 =>
                        gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                        gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian).Where<SystemBodyData>(
                        new ShippingLineData.Class1159()
                        {
                            list_0 = this.gclass0_0.Populations.Values
                                .Where<PopulationData>(gclass146_0 =>
                                    gclass146_0.decimal_30 > 10M && gclass146_0.Race == this.gclass21_0)
                                .Select<PopulationData, StarSystem>(gclass146_0 => gclass146_0.gclass202_0.ActualSystem)
                                .ToList<StarSystem>()
                        }.method_0).Where<SystemBodyData>(gclass1_0 => gclass1_0.method_77(this.gclass21_0))
                    .FirstOrDefault<SystemBodyData>(gclass1_0 =>
                        gclass1_0.MineralDeposits.ContainsKey(AuroraElement.Sorium));
                bool flag = false;
                if (this.gclass0_0.TechDataDictionary[25148].dictionary_0.ContainsKey(this.gclass21_0.RaceID))
                    flag = true;
                int num5;
                do
                {
                    num5 = AuroraUtils.GetRandomInteger(5);
                    if (this.gclass21_0.NPR)
                        goto label_29;
                    label_23:
                    if (num5 >= 3)
                    {
                        if (num5 != 3)
                        {
                            if (num5 != 4 || num3 <= 1)
                                continue;
                            goto label_34;
                        }

                        goto label_33;
                    }

                    goto label_32;
                    label_29:
                    num5 = AuroraUtils.GetRandomInteger(4);
                    goto label_23;
                } while (num5 != 5 || gclass1 == null || this.gclass0_0.AllowCivilianHarvesters != 1 || !flag);

                goto label_35;
                label_32:
                classMainFunction = AuroraClassMainFunction.Freighter;
                goto label_36;
                label_33:
                classMainFunction = AuroraClassMainFunction.ColonyShip;
                goto label_36;
                label_34:
                classMainFunction = AuroraClassMainFunction.Liner;
                goto label_36;
                label_35:
                classMainFunction = AuroraClassMainFunction.FuelHarvester;
            }

            label_36:
            ShipClass gclass22 = null;
            AutomatedClassDesign gclass14_0 = null;
            Decimal num6 = this.decimal_0 - num1;
            for (int index = 1; index < 4; ++index)
            {
                if (this.int_3 == 0 && this.int_4 == 0)
                    index = 3;
                switch (classMainFunction)
                {
                    case AuroraClassMainFunction.Freighter:
                        if (index == 1 && this.int_3 > 5)
                        {
                            gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.HugeFreighter];
                            break;
                        }

                        if (index == 2 && this.int_3 > 3)
                        {
                            gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.LargeFreighter];
                            break;
                        }

                        if (index == 3)
                        {
                            gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.SmallFreighter];
                            break;
                        }

                        break;
                    case AuroraClassMainFunction.ColonyShip:
                        if (index == 1 && this.int_4 > 5)
                        {
                            gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.HugeColony];
                            break;
                        }

                        if (index == 2 && this.int_4 > 3)
                        {
                            gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.LargeColony];
                            break;
                        }

                        if (index == 3)
                        {
                            gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.SmallColony];
                            break;
                        }

                        break;
                    case AuroraClassMainFunction.FuelHarvester:
                        if (index == 1)
                        {
                            gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Harvester];
                            break;
                        }

                        break;
                    case AuroraClassMainFunction.Liner:
                        switch (index)
                        {
                            case 1:
                                gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.LargeLiner];
                                break;
                            case 2:
                                gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.Liner];
                                break;
                        }

                        break;
                }

                if (gclass14_0 != null)
                {
                    gclass22 = this.method_2(gclass14_0) ?? this.gclass21_0.method_6(this, gclass14_0);
                    if (!(gclass22.Cost < this.decimal_0 - num1) && (this.int_7 <= 20 || index != 1) &&
                        (this.int_7 <= 10 || index != 2))
                    {
                        gclass22 = null;
                        gclass14_0 = null;
                    }
                    else
                        break;
                }
            }

            if (gclass22 == null)
                return;
            int num7 = this.method_3();
            string string_10 = $"{gclass22.ClassName} {AuroraUtils.smethod_33(num7 + 1)}";
            ShipData gclass40 = this.gclass21_0.method_304(gclass146_1, null, null, gclass22, null, null,
                this.gclass21_0.method_164(), null, this, string_10, 0M, true, true, GEnum20.const_2);
            this.gclass0_0.gclass92_0.method_2(EventType.const_79,
                $"{this.string_0} has launched a new {gclass22.ClassName} class {gclass22.ShipHull.Description}",
                this.gclass21_0, gclass40.gclass85_0.System.ActualSystem, gclass40.gclass85_0.XCoord,
                gclass40.gclass85_0.YCoord, AuroraEventCategory.Ship);
            this.decimal_0 -= gclass22.Cost;
            this.method_10(gclass22);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2913);
        }
    }

    public AuroraClassMainFunction method_8()
    {
        try
        {
            return this.int_3 <= this.int_4
                ? (this.int_4 <= this.int_3
                    ? (!AuroraUtils.smethod_23()
                        ? AuroraClassMainFunction.Freighter
                        : AuroraClassMainFunction.ColonyShip)
                    : AuroraClassMainFunction.Freighter)
                : AuroraClassMainFunction.ColonyShip;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3777);
            return AuroraClassMainFunction.Freighter;
        }
    }

    public void method_9(PopulationData gclass146_0, AutomatedClassDesignType genum120_0)
    {
        try
        {
            if (!this.gclass0_0.AutomatedClassDesignDictionary.ContainsKey(genum120_0))
                return;
            AutomatedClassDesign gclass14_0 = this.gclass0_0.AutomatedClassDesignDictionary[genum120_0];
            ShipClass gclass22_1 = this.method_2(gclass14_0) ?? this.gclass21_0.method_6(this, gclass14_0);
            if (gclass22_1 == null)
                return;
            int num = this.method_3();
            string string_10 = $"{gclass22_1.ClassName} {AuroraUtils.smethod_33(num + 1)}";
            this.gclass21_0.method_304(gclass146_0, null, null, gclass22_1, null, null, gclass146_0.Species, null,
                this, string_10, 0M, true, true, GEnum20.const_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2914);
        }
    }

    public void method_10(ShipClass gclass22_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ShippingLineData.Class1160 class1160 = new ShippingLineData.Class1160();
        // ISSUE: reference to a compiler-generated field
        class1160.gclass187_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1160.gclass22_0 = gclass22_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            ShipData gclass40_1 = this.gclass0_0.Ships.Values
                .Where<ShipData>(class1160.method_0)
                .OrderBy<ShipData, Decimal>(gclass40_0 => gclass40_0.decimal_1).FirstOrDefault<ShipData>();
            if (gclass40_1 == null)
                return;
            if (gclass40_1.gclass85_0.MoveOrderDictionary.Count == 0)
            {
                this.gclass0_0.gclass92_0.method_2(EventType.const_218,
                    $"{this.string_0} has scrapped the {gclass40_1.ShipName} due to its replacement by a newer vessel",
                    gclass40_1.gclass21_0, gclass40_1.gclass85_0.System.ActualSystem,
                    gclass40_1.gclass85_0.XCoord, gclass40_1.gclass85_0.YCoord, AuroraEventCategory.Ship);
                gclass40_1.gclass21_0.method_303(gclass40_1, GEnum22.const_3);
            }
            else
                gclass40_1.bool_13 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2915);
        }
    }

    public void method_11()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            List<CommanderNameDefinition> list = this.gclass0_0.CommanderNameList.Where<CommanderNameDefinition>(new ShippingLineData.Class1161()
            {
                gclass58_0 = this.gclass21_0.method_116()
            }.method_0).ToList<CommanderNameDefinition>();
            if (list.Count == 0)
                list = this.gclass0_0.CommanderNameList.Where<CommanderNameDefinition>(gclass57_0 =>
                        gclass57_0.CommanderNameTheme == this.gclass0_0.NameThemeDictionary[3] && gclass57_0.AllowedForLastName)
                    .ToList<CommanderNameDefinition>();
            this.string_1 = this.gclass0_0.method_534(list).Name;
            this.string_0 =
                $"{this.string_1} {this.gclass0_0.LineNameList.ElementAt<string>(AuroraUtils.GetRandomInteger(this.gclass0_0.LineNameList.Count) - 1)}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2916);
        }
    }

    public void method_12(
        PopulationData gclass146_0,
        PopulationData gclass146_1,
        ShipData gclass40_0,
        Decimal decimal_3,
        bool bool_1,
        bool bool_2,
        bool bool_3,
        TradeGood gclass189_0)
    {
        try
        {
            this.WealthDataList.Add(new ShippingWealthData()
            {
                Ship = gclass40_0,
                ShippingLine = gclass40_0.gclass187_0,
                TradeGood = gclass189_0,
                OriginPop = gclass146_0,
                DestinationPop = gclass146_1,
                TradeTime = this.gclass0_0.GameTime,
                Amount = decimal_3,
                Contract = bool_1,
                Fuel = bool_2,
                Colonist = bool_3
            });
            this.decimal_0 += decimal_3;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2917);
        }
    }

    public void method_13(TechSystem gclass164_0)
    {
        try
        {
            if (gclass164_0.gclass163_0.TechType != TechType.EngineTechnology)
                return;
            this.gclass230_0 = null;
            this.int_2 = 0;
            foreach (ShipClass gclass22 in this.gclass0_0.ShipClasses.Values
                         .Where<ShipClass>(gclass22_0 => gclass22_0.gclass187_0 == this).ToList<ShipClass>())
                gclass22.Obsolete = 1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2918);
        }
    }
}