// Decompiled with JetBrains decompiler
// Type: GClass92
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass92
{
    public Dictionary<int, GClass91> dictionary_0 = new Dictionary<int, GClass91>();
    private GClass0 gclass0_0;
    public GClass91 gclass91_0;

    public GClass92(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public GClass91 method_0()
    {
        try
        {
            GClass91 gclass91_1 = new GClass91();
            gclass91_1.decimal_0 = this.gclass0_0.decimal_0;
            gclass91_1.int_1 = this.gclass0_0.int_131;
            gclass91_1.int_0 = this.gclass0_0.method_26(GEnum0.const_6);
            if (this.gclass0_0.int_133 == 0)
                this.method_1(gclass91_1);
            else if (gclass91_1.int_1 / this.gclass0_0.int_133 > 500)
                this.method_1(gclass91_1);
            if (this.gclass0_0.int_132 > gclass91_1.int_1)
                this.gclass0_0.int_132 = gclass91_1.int_1;
            this.dictionary_0.Add(gclass91_1.int_0, gclass91_1);
            this.gclass91_0 = gclass91_1;
            return gclass91_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1714);
            return null;
        }
    }

    public void method_1(GClass91 gclass91_1)
    {
        this.gclass0_0.int_132 = gclass91_1.int_1 >= 61
            ? (gclass91_1.int_1 >= 201
                ? (gclass91_1.int_1 >= 401
                    ? (gclass91_1.int_1 >= 1201
                        ? (gclass91_1.int_1 >= 3601
                            ? (gclass91_1.int_1 >= 10801
                                ? (gclass91_1.int_1 >= 28801
                                    ? (gclass91_1.int_1 >= 86401 ? (gclass91_1.int_1 >= 432001 ? 21600 : 7200) : 1800)
                                    : 900)
                                : 360)
                            : 120)
                        : 60)
                    : 20)
                : 10)
            : 5;
        gclass91_1.int_1 = (int)Math.Floor(gclass91_1.int_1 / (double)this.gclass0_0.int_132) * this.gclass0_0.int_132;
    }

    public void method_2(
        EventType genum126_0,
        string string_0,
        FCTRaceRecordC21 gclass21_0,
        SystemData200 gclass200_0,
        double double_0,
        double double_1,
        AuroraEventCategory auroraEventCategory_0)
    {
        this.method_4(genum126_0, string_0, gclass21_0, gclass200_0, null, double_0, double_1, auroraEventCategory_0,
            false, false, null);
    }

    public void method_3(
        EventType genum126_0,
        string string_0,
        FCTRaceRecordC21 gclass21_0,
        SystemData200 gclass200_0,
        PopulationData gclass146_0,
        double double_0,
        double double_1,
        AuroraEventCategory auroraEventCategory_0)
    {
        this.method_4(genum126_0, string_0, gclass21_0, gclass200_0, gclass146_0, double_0, double_1,
            auroraEventCategory_0, false, false, null);
    }

    public void method_4(
        EventType genum126_0,
        string string_0,
        FCTRaceRecordC21 gclass21_0,
        SystemData200 gclass200_0,
        PopulationData gclass146_0,
        double double_0,
        double double_1,
        AuroraEventCategory auroraEventCategory_0,
        bool bool_0,
        bool bool_1,
        FCTRaceRecordC21 gclass21_1)
    {
        try
        {
            GClass87 gclass87 = new GClass87();
            if (this.gclass91_0 == null)
                this.gclass91_0 = this.dictionary_0.Values
                    .OrderByDescending<GClass91, Decimal>(gclass91_0 => gclass91_0.decimal_0)
                    .FirstOrDefault<GClass91>();
            if (!this.gclass0_0.DIMEventTypeDictionary.ContainsKey(genum126_0))
                return;
            gclass87.gclass91_0 = this.gclass91_0;
            gclass87.gclass88_0 = this.gclass0_0.DIMEventTypeDictionary[genum126_0];
            gclass87.auroraEventCategory_0 = auroraEventCategory_0;
            gclass87.gclass21_0 = gclass21_0;
            gclass87.decimal_0 = this.gclass0_0.decimal_0;
            gclass87.double_0 = double_0;
            gclass87.double_1 = double_1;
            gclass87.bool_0 = bool_1;
            gclass87.string_0 = string_0;
            gclass87.gclass146_0 = gclass146_0;
            if (gclass200_0 != null)
                gclass87.gclass200_0 = gclass200_0;
            this.gclass91_0.list_0.Add(gclass87);
            if (gclass21_0.IsNPR)
            {
                if (gclass87.gclass88_0.AIInterrupt)
                {
                    this.gclass0_0.bool_0 = true;
                }
                else
                {
                    if (gclass21_1 == null || !gclass21_1.IsNPR)
                        return;
                    this.gclass0_0.bool_0 = true;
                }
            }
            else
            {
                if (!gclass87.gclass88_0.PlayerInterrupt)
                    return;
                this.gclass0_0.bool_0 = true;
                this.gclass0_0.bool_1 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1715);
        }
    }
}