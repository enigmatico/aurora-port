// Decompiled with JetBrains decompiler
// Type: GClass233
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
public class GClass233
{
    [CompilerGenerated]
    private bool method_3(GClass115 gclass115_0)
    {
        return gclass115_0.gclass22_0.int_0 == this.gclass22_0.int_0;
    }

    [CompilerGenerated]
    private sealed class Class1215
    {
        public TechData164 gclass164_0;

        internal bool method_0(TechData164 gclass164_1)
        {
            return gclass164_1.int_0 == this.gclass164_0.int_2;
        }
    }

    public List<GClass234> list_0 = new List<GClass234>();
    public List<GClass235> list_1 = new List<GClass235>();
    public GClass0 gclass0_0;
    public FCTRaceRecordC21 gclass21_0;
    public SystemData200 gclass200_0;
    public SystemBodyData gclass1_0;
    public GClass22 gclass22_0;
    public AllMineralsValue gclass123_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public int int_4;
    public Decimal decimal_0;
    public double double_0;
    public double double_1;

    public string ViewingName { get; set; }

    public GClass233(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            if (AuroraUtils.GetRandomInteger(200) > this.gclass22_0.decimal_14)
                return;
            int num = 128 /*0x80*/;
            for (int index = 1; index < num; index = AuroraUtils.GetRandomInteger(128 /*0x80*/))
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GClass233.Class1215 class1215 = new GClass233.Class1215();
                ShipComponent gclass230 = this.gclass22_0.method_38();
                if (gclass230 == null)
                    break;
                // ISSUE: reference to a compiler-generated field
                class1215.gclass164_0 = gclass230.method_6();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1215.gclass164_0 == null && class1215.gclass164_0.bool_4)
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class1215.gclass164_0 =
                        this.gclass0_0.TechDataDictionary.Values.FirstOrDefault<TechData164>(class1215.method_0);
                }

                // ISSUE: reference to a compiler-generated field
                if (class1215.gclass164_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    this.list_0.Add(new GClass234()
                    {
                        decimal_0 = AuroraUtils.GetRandomInteger(20),
                        gclass164_0 = class1215.gclass164_0
                    });
                }

                num /= 2;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3185);
        }
    }

    public string method_1(FCTRaceRecordC21 gclass21_1, bool bool_0)
    {
        try
        {
            string str1 = "";
            string str2;
            if (this.gclass21_0 == gclass21_1)
            {
                str2 = this.gclass22_0.ClassName;
            }
            else
            {
                GClass115 gclass115 = gclass21_1.dictionary_11.Values.FirstOrDefault<GClass115>(gclass115_0 =>
                    gclass115_0.gclass22_0.int_0 == this.gclass22_0.int_0);
                if (gclass115 != null)
                {
                    str2 = gclass115.ClassName;
                    str1 = $"[{gclass21_1.PerceivedAliens[this.gclass21_0.RaceID].Abbreviation}]";
                }
                else
                    str2 = "Unknown";
            }

            return bool_0
                ? $"Wreck of {str2} class {str1} #{this.int_0.ToString()}: {AuroraUtils.smethod_39(this.decimal_0 * 50M)} tons)"
                : $"Wreck of {str2} class {str1}: {AuroraUtils.smethod_39(this.decimal_0 * 50M)} tons)";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3186);
            return "";
        }
    }

    public void method_2(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_5,
        int int_6)
    {
        try
        {
            SolidBrush solidBrush = new SolidBrush(AuroraUtils.color_10);
            Pen pen = new Pen(AuroraUtils.color_10, 3f);
            double x1 = gclass222_0.double_2 - AuroraUtils.int_63 / 2;
            double num = gclass222_0.double_3 - AuroraUtils.int_63 / 2;
            if (int_5 == 0)
            {
                graphics_0.DrawLine(pen, (float)x1, (float)num, (float)x1 + AuroraUtils.int_63,
                    (float)num + AuroraUtils.int_63);
                graphics_0.DrawLine(pen, (float)x1, (float)num + AuroraUtils.int_63, (float)x1 + AuroraUtils.int_63,
                    (float)num);
            }

            string s;
            if (int_6 > 1)
            {
                string str = this.method_1(gclass202_0.Race, false);
                s = $"{AuroraUtils.smethod_37(int_6)}x {str}";
            }
            else
                s = this.method_1(gclass202_0.Race, true);

            GClass221 gclass221 = new GClass221();
            gclass221.double_0 = x1 + AuroraUtils.int_61 + 5.0;
            gclass221.double_1 = num - 3.0 - int_5 * 15;
            graphics_0.DrawString(s, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3187);
        }
    }
}