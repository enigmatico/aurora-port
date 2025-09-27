// Decompiled with JetBrains decompiler
// Type: GClass132
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass132
{
    private sealed class Class1085
    {
        public GClass132 gclass132_0;
        public Decimal decimal_0;
        public int int_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return this.gclass132_0.gclass0_0.GetDistanceBetween(this.gclass132_0.double_0, this.gclass132_0.double_1,
                gclass40_0.gclass85_0.XCoord, gclass40_0.gclass85_0.YCoord) < (double)this.decimal_0;
        }

        internal bool method_1(FCTShipData40 gclass40_0)
        {
            return gclass40_0.int_38 >= this.int_0;
        }
    }

    private sealed class Class1086
    {
        public GClass132 gclass132_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass132_0.gclass200_0 &&
                   gclass1_0.XCoordinate == this.gclass132_0.double_0 &&
                   gclass1_0.YCoordinate == this.gclass132_0.double_1;
        }
    }

    private GClass0 gclass0_0;
    public Dictionary<int, GClass131> dictionary_0 = new Dictionary<int, GClass131>();
    public Dictionary<GameRace, Decimal> dictionary_1 = new Dictionary<GameRace, Decimal>();
    public Dictionary<int, int> dictionary_2 = new Dictionary<int, int>();
    public List<GameRace> list_0 = new List<GameRace>();
    public FCTShipData40 gclass40_0;
    public GameRace gclass21_0;
    public SystemData200 gclass200_0;
    public RaceMissile gclass129_0;
    public ShipComponent gclass230_0;
    public SystemBodyData gclass1_0;
    public FCTShipData40 gclass40_1;
    public GClass132 gclass132_0;
    public PopulationData gclass146_0;
    public GClass214 gclass214_0;
    public AuroraContactType auroraContactType_0;
    public GEnum58 genum58_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public double double_0;
    public double double_1;
    public double double_2;
    public double double_3;
    public double double_4;
    public double double_5;
    public double double_6;
    public double double_7;
    public double double_8;
    public double double_9;
    public string string_0;
    public string string_1 = "";
    public int int_3;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public GameRace gclass21_1;
    public GEnum40 genum40_0;
    public int int_4;
    public int int_5;
    public double double_10;
    public GClass221 gclass221_0 = new GClass221();
    public double double_11;
    public bool bool_3;
    public string string_2 = "";
    public GClass221 gclass221_1;
    public AuroraContactStatus auroraContactStatus_0 = AuroraContactStatus.None;

    public GClass132(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public GClass221 method_0(GClass221 gclass221_2, double double_12)
    {
        try
        {
            GClass221 gclass221 = new GClass221(gclass221_2.double_0, gclass221_2.double_1);
            double num1 = this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1, gclass221_2.double_0,
                gclass221_2.double_1);
            double num2 = double_12 / num1;
            double num3 = Math.Abs(gclass221_2.double_0 - this.double_0) * num2;
            double num4 = Math.Abs(gclass221_2.double_1 - this.double_1) * num2;
            gclass221.double_0 = gclass221_2.double_0 >= this.double_0
                ? gclass221_2.double_0 - num3
                : gclass221_2.double_0 + num3;
            gclass221.double_1 = gclass221_2.double_1 >= this.double_1
                ? gclass221_2.double_1 - num4
                : gclass221_2.double_1 + num4;
            return gclass221;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3781);
            return gclass221_2;
        }
    }

    public string method_1()
    {
        try
        {
            foreach (PopulationData gclass146 in this.gclass200_0.method_33(this.gclass21_0))
            {
                if (this.gclass0_0.method_520(this.double_0, gclass146.method_87(), this.double_1,
                        gclass146.method_88()))
                    return gclass146.PopName;
            }

            foreach (JumpPoint120 gclass120 in this.gclass200_0.method_27())
            {
                if (gclass120.RacialJumpPointSurveys.ContainsKey(this.gclass21_0.RaceID) &&
                    gclass120.RacialJumpPointSurveys[this.gclass21_0.RaceID].Charted == 1 &&
                    this.gclass0_0.method_520(this.double_0, gclass120.XCoord, this.double_1, gclass120.YCoord))
                {
                    RacialSystemSurvey gclass202_0 = this.gclass21_0.method_128(this.gclass200_0);
                    return gclass120.method_8(gclass202_0);
                }
            }

            foreach (SurveyLocation213 gclass213 in this.gclass200_0.SurveyLocationDictionary.Values)
            {
                if (this.gclass0_0.method_520(this.double_0, gclass213.XCoord, this.double_1, gclass213.YCoord))
                    return "Survey Location #" + gclass213.LocationNumber.ToString();
            }

            foreach (SystemBodyData gclass1 in this.gclass200_0.method_20())
            {
                if (this.gclass0_0.method_520(this.double_0, gclass1.XCoordinate, this.double_1, gclass1.YCoordinate))
                    return gclass1.method_78(this.gclass21_0);
            }

            return this.gclass200_0.method_22(this.double_0, this.double_1,
                this.gclass21_0.method_128(this.gclass200_0));
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3779);
            return "error";
        }
    }

    public string method_2()
    {
        try
        {
            string str = "";
            if (this.gclass40_1 != null)
                str = "  " + this.gclass21_0.method_32(this.gclass40_1);
            else if (this.gclass132_0 != null)
                str = "  SalvoID " + this.gclass132_0.int_1.ToString();
            else if (this.gclass214_0 != null)
                str = "  " + this.gclass214_0.method_2(true);
            else if (this.gclass146_0 != null)
            {
                if (this.auroraContactType_0 == AuroraContactType.Population)
                    str = "  " + this.gclass21_0.method_42(this.gclass146_0);
                else if (this.auroraContactType_0 == AuroraContactType.GroundUnit)
                    str = $"  {this.gclass21_0.method_42(this.gclass146_0)} Ground Forces";
                else if (this.auroraContactType_0 == AuroraContactType.STOGroundUnit)
                    str = $"  {this.gclass21_0.method_42(this.gclass146_0)} STO Ground Forces";
                else if (this.auroraContactType_0 == AuroraContactType.Shipyard)
                    str = $"  {this.gclass21_0.method_42(this.gclass146_0)} Shipyards";
            }

            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3745);
            return "-";
        }
    }

    public int method_3(double double_12)
    {
        try
        {
            int num = 0;
            foreach (int key in this.dictionary_2.Keys.ToList<int>())
            {
                bool flag = false;
                for (int index = 1; index <= this.gclass129_0.int_13; ++index)
                {
                    if (AuroraUtils.GetRandomInteger(100) <= double_12)
                    {
                        flag = true;
                        ++num;
                    }
                }

                if (flag)
                    this.dictionary_2.Remove(key);
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3666);
            return 0;
        }
    }

    public int method_4(int int_6)
    {
        try
        {
            this.dictionary_2.Remove(int_6);
            return this.dictionary_2.Count;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3665);
            return 0;
        }
    }

    public void method_5(int int_6)
    {
        try
        {
            this.dictionary_2 = this.dictionary_2.Take<KeyValuePair<int, int>>(this.dictionary_2.Count - int_6)
                .ToDictionary<KeyValuePair<int, int>, int, int>(keyValuePair_0 => keyValuePair_0.Key,
                    keyValuePair_0 => keyValuePair_0.Value);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3668);
        }
    }

    public void method_6()
    {
        try
        {
            this.dictionary_2.Clear();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3665);
        }
    }

    public void method_7()
    {
        try
        {
            this.dictionary_2.Add(
                this.dictionary_2.Max<KeyValuePair<int, int>>(keyValuePair_0 => keyValuePair_0.Key) + 1,
                this.gclass129_0.int_7);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3662);
        }
    }

    public void method_8()
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass132.Class1085 class1085 = new GClass132.Class1085();
        // ISSUE: reference to a compiler-generated field
        class1085.gclass132_0 = this;
        try
        {
            if (!this.method_13(false))
                return;
            List<FCTShipData40> source = this.method_14();
            if (source.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class1085.decimal_0 = this.gclass129_0.decimal_5 * this.decimal_1;
            // ISSUE: reference to a compiler-generated field
            if (class1085.decimal_0 == 0M)
                return;
            int int_72 = 0;
            // ISSUE: reference to a compiler-generated method
            List<FCTShipData40> list1 = source.Where<FCTShipData40>(class1085.method_0).ToList<FCTShipData40>();
            foreach (FCTShipData40 gclass40_1 in list1)
            {
                Decimal num1 = gclass40_1.gclass22_0.int_32 * this.decimal_1;
                // ISSUE: reference to a compiler-generated field
                Decimal num2 = class1085.decimal_0 - num1;
                Decimal num3 = (Decimal)this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1,
                    gclass40_1.gclass85_0.XCoord, gclass40_1.gclass85_0.YCoord);
                Decimal num4 = num3;
                if (num2 > num4)
                {
                    if (num3 < 10000M)
                        num3 = 10000M;
                    Decimal num5 = 1M;
                    GClass117 gclass117 = this.gclass21_0.method_267(gclass40_1);
                    if (gclass117 != null && gclass117.gclass115_0.genum70_0 == EngineDesignType.const_2)
                        num5 = 0.1M;
                    gclass40_1.int_37 = (int)Math.Floor(gclass40_1.gclass22_0.decimal_14 / num3 * 10000000M * num5);
                    if (gclass40_1.int_37 < 1)
                        gclass40_1.int_37 = 1;
                }
                else
                    gclass40_1.int_37 = 0;

                int_72 += gclass40_1.int_37;
                gclass40_1.int_38 = int_72;
            }

            List<FCTShipData40> list2 = list1.Where<FCTShipData40>(gclass40_0 => gclass40_0.int_37 > 0)
                .ToList<FCTShipData40>();
            // ISSUE: reference to a compiler-generated field
            class1085.int_0 = AuroraUtils.GetRandomInteger(int_72);
            // ISSUE: reference to a compiler-generated method
            this.int_0 = list2.Where<FCTShipData40>(class1085.method_1)
                .OrderBy<FCTShipData40, int>(gclass40_0 => gclass40_0.int_38).FirstOrDefault<FCTShipData40>().int_8;
            this.auroraContactType_0 = AuroraContactType.Ship;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3380);
        }
    }

    public void method_9(
        Graphics graphics_0,
        SolidBrush solidBrush_0,
        Pen pen_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        double double_12,
        int int_6,
        string string_3)
    {
        try
        {
            pen_0.DashStyle = DashStyle.Dash;
            pen_0.DashPattern = new float[2] { 12f, 4f };
            pen_0.Color = Color.LightCoral;
            solidBrush_0.Color = Color.LightCoral;
            switch (string_3)
            {
                case "EM":
                    pen_0.Color = Color.Thistle;
                    solidBrush_0.Color = Color.Thistle;
                    break;
                case "ELINT":
                    pen_0.Color = Color.AliceBlue;
                    solidBrush_0.Color = Color.AliceBlue;
                    break;
            }

            double num1 = Math.Sqrt(double_12 * int_6) * AuroraUtils.double_18;
            double key = num1 / gclass202_0.KmPerPixel;
            if (key < 1.0)
                return;
            graphics_0.DrawEllipse(pen_0, (float)(gclass222_0.double_2 - key), (float)(gclass222_0.double_3 - key),
                (float)key * 2f, (float)key * 2f);
            string str1 = num1 <= 10000000.0
                ? AuroraUtils.smethod_44(num1 / 1000000.0, 1)
                : AuroraUtils.smethod_44(num1 / 1000000.0, 0);
            string str2 = $"{this.string_0} vs {string_3} Signature-{int_6.ToString()}   {str1}m";
            float num2 = graphics_0.MeasureString(str2, font_0).Width / 2f;
            if (gclass222_0.dictionary_0.ContainsKey(key))
                gclass222_0.dictionary_0[key]++;
            else
                gclass222_0.dictionary_0.Add(key, 1);
            graphics_0.DrawString(str2, font_0, solidBrush_0, (float)gclass222_0.double_2 - num2,
                (float)(gclass222_0.double_3 - key - 5.0) - 15 * gclass222_0.dictionary_0[key]);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 915);
        }
    }

    public GClass221 method_10()
    {
        try
        {
            this.gclass221_0 = new GClass221(0.0, 0.0);
            if (this.int_0 == 0)
                return this.gclass221_0;
            if (this.auroraContactType_0 == AuroraContactType.Ship)
            {
                if (this.gclass40_1 != null)
                {
                    this.gclass221_0.double_0 = this.gclass40_1.gclass85_0.XCoord;
                    this.gclass221_0.double_1 = this.gclass40_1.gclass85_0.YCoord;
                }
            }
            else if (this.auroraContactType_0 == AuroraContactType.Salvo)
            {
                if (this.gclass132_0 != null)
                {
                    this.gclass221_0.double_0 = this.gclass132_0.double_0;
                    this.gclass221_0.double_1 = this.gclass132_0.double_1;
                }
            }
            else if (this.auroraContactType_0 != AuroraContactType.Population &&
                     this.auroraContactType_0 != AuroraContactType.Shipyard &&
                     this.auroraContactType_0 != AuroraContactType.GroundUnit &&
                     this.auroraContactType_0 != AuroraContactType.STOGroundUnit)
            {
                if (this.auroraContactType_0 == AuroraContactType.WayPoint && this.gclass214_0 != null)
                {
                    this.gclass221_0.double_0 = this.gclass214_0.double_0;
                    this.gclass221_0.double_1 = this.gclass214_0.double_1;
                }
            }
            else if (this.gclass146_0 != null)
            {
                this.gclass221_0.double_0 = this.gclass146_0.method_87();
                this.gclass221_0.double_1 = this.gclass146_0.method_88();
            }

            return this.gclass221_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2057);
            return new GClass221(0.0, 0.0);
        }
    }

    public bool method_11(List<GClass65> list_1)
    {
        try
        {
            if (this.genum58_0 != GEnum58.const_0 && this.genum58_0 != GEnum58.const_1)
            {
                if (this.genum58_0 == GEnum58.const_2)
                {
                    if (list_1.Count<GClass65>(gclass65_0 => gclass65_0.genum10_0 == GEnum10.const_1) > 0)
                        return true;
                }
                else if (this.genum58_0 == GEnum58.const_3 && list_1.Count<GClass65>(gclass65_0 =>
                             gclass65_0.genum10_0 == GEnum10.const_3 || gclass65_0.genum10_0 == GEnum10.const_2) > 0)
                    return true;
            }
            else if (list_1.Count<GClass65>(gclass65_0 => gclass65_0.genum10_0 == GEnum10.const_0) > 0)
                return true;

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2058);
            return false;
        }
    }

    public void method_12()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GClass132.Class1086 class1086 = new GClass132.Class1086();
            if (this.gclass129_0.gclass129_0 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0 = (GClass132)this.MemberwiseClone();
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.int_1 = this.gclass0_0.method_26(GEnum0.const_38);
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.gclass129_0 = this.gclass129_0.gclass129_0;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.decimal_0 = this.gclass0_0.GameTime;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.string_0 = class1086.gclass132_0.gclass129_0.Name;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.double_9 = (double)class1086.gclass132_0.gclass129_0.decimal_5;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.decimal_1 = class1086.gclass132_0.gclass129_0.decimal_21;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.double_0 = this.double_0;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.double_1 = this.double_1;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.double_2 = this.double_0;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.double_3 = this.double_1;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.double_8 = this.double_8;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.gclass230_0 = this.gclass230_0;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.int_2 = this.int_2;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.dictionary_2 = new Dictionary<int, int>();
            int num = this.dictionary_2.Count * this.gclass129_0.int_16;
            for (int key = 1; key <= num; ++key)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.dictionary_2.Add(key, class1086.gclass132_0.gclass129_0.int_7);
            }

            if (this.gclass230_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.int_0 = this.int_0;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.auroraContactType_0 = this.auroraContactType_0;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.method_8();
            }

            // ISSUE: reference to a compiler-generated field
            if (class1086.gclass132_0.gclass129_0.decimal_5 == 0M)
            {
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.int_0 = 0;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.auroraContactType_0 = AuroraContactType.None;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.gclass40_1 = null;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.gclass146_0 = null;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.gclass132_0 = null;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.gclass214_0 = null;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class1086.gclass132_0.gclass1_0 =
                    this.gclass0_0.SystemBodyRecordDic.Values
                        .FirstOrDefault<SystemBodyData>(class1086.method_0);
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.dictionary_6.Add(class1086.gclass132_0.int_1, class1086.gclass132_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2059);
        }
    }

    public bool method_13(bool bool_4)
    {
        try
        {
            return this.gclass129_0.double_2 != 0.0 || this.gclass129_0.double_1 != 0.0 ||
                   this.gclass129_0.double_0 != 0.0 || bool_4 && this.gclass129_0.decimal_16 > 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2060);
            return false;
        }
    }

    public List<FCTShipData40> method_14()
    {
        try
        {
            List<FCTShipData40> source = new List<FCTShipData40>();
            if (this.gclass129_0.double_0 > 0.0)
            {
                foreach (GClass65 gclass65 in this.gclass0_0.dictionary_28.Values
                             .Where<GClass65>(gclass65_0 =>
                                 gclass65_0.gclass21_1 == this.gclass21_0 &&
                                 gclass65_0.gclass200_0 == this.gclass200_0 &&
                                 gclass65_0.genum10_0 == GEnum10.const_0 &&
                                 gclass65_0.auroraContactType_0 == AuroraContactType.Ship)
                             .OrderBy<GClass65, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.double_0,
                                 this.double_1, gclass65_0.double_0, gclass65_0.double_1)).ToList<GClass65>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1, gclass65.double_0,
                        gclass65.double_1);
                    double int6 = this.gclass129_0.int_6;
                    if (num <= int6)
                    {
                        if (gclass65.gclass40_0.method_51() < this.gclass129_0.int_5)
                            int6 *= (double)AuroraUtils.smethod_64(
                                gclass65.gclass40_0.method_51() / this.gclass129_0.int_5, 2);
                        if (num <= int6)
                            source.Add(gclass65.gclass40_0);
                    }
                    else
                        break;
                }
            }

            if (this.gclass129_0.double_1 > 0.0)
            {
                foreach (GClass65 gclass65 in this.gclass0_0.dictionary_28.Values
                             .Where<GClass65>(gclass65_0 =>
                                 gclass65_0.gclass21_1 == this.gclass21_0 &&
                                 gclass65_0.gclass200_0 == this.gclass200_0 &&
                                 gclass65_0.genum10_0 == GEnum10.const_1 &&
                                 gclass65_0.auroraContactType_0 == AuroraContactType.Ship)
                             .OrderBy<GClass65, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.double_0,
                                 this.double_1, gclass65_0.double_0, gclass65_0.double_1)).ToList<GClass65>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1, gclass65.double_0,
                        gclass65.double_1);
                    if (Math.Sqrt(this.gclass129_0.double_1 * (double)gclass65.decimal_0) * AuroraUtils.double_18 >=
                        num)
                        source.Add(gclass65.gclass40_0);
                }
            }

            if (this.gclass129_0.double_2 > 0.0)
            {
                foreach (GClass65 gclass65 in this.gclass0_0.dictionary_28.Values
                             .Where<GClass65>(gclass65_0 => gclass65_0.gclass21_1 == this.gclass21_0 &&
                                                            gclass65_0.gclass200_0 == this.gclass200_0 &&
                                                            (gclass65_0.genum10_0 == GEnum10.const_3 ||
                                                             gclass65_0.genum10_0 == GEnum10.const_2) &&
                                                            gclass65_0.auroraContactType_0 == AuroraContactType.Ship)
                             .OrderBy<GClass65, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.double_0,
                                 this.double_1, gclass65_0.double_0, gclass65_0.double_1)).ToList<GClass65>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1, gclass65.double_0,
                        gclass65.double_1);
                    if (Math.Sqrt(this.gclass129_0.double_2 * (double)gclass65.decimal_0) * AuroraUtils.double_18 >=
                        num)
                        source.Add(gclass65.gclass40_0);
                }
            }

            return source.Distinct<FCTShipData40>().ToList<FCTShipData40>().Except<FCTShipData40>(this.gclass0_0
                .FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ShipData != null)
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData.gclass21_0 != this.gclass21_0)
                .Select<GroundUnitFormationData, FCTShipData40>(gclass103_0 => gclass103_0.ShipData).Distinct<FCTShipData40>()
                .ToList<FCTShipData40>()).ToList<FCTShipData40>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3379);
            return null;
        }
    }

    public bool method_15()
    {
        try
        {
            if (this.gclass129_0.double_0 > 0.0)
            {
                foreach (GClass65 gclass65 in this.gclass0_0.dictionary_28.Values
                             .Where<GClass65>(gclass65_0 =>
                                 gclass65_0.gclass21_1 == this.gclass21_0 &&
                                 gclass65_0.gclass200_0 == this.gclass200_0 &&
                                 gclass65_0.genum10_0 == GEnum10.const_0 &&
                                 gclass65_0.auroraContactType_0 == AuroraContactType.Ship)
                             .OrderBy<GClass65, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.double_0,
                                 this.double_1, gclass65_0.double_0, gclass65_0.double_1)).ToList<GClass65>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1, gclass65.double_0,
                        gclass65.double_1);
                    double int6 = this.gclass129_0.int_6;
                    if (num <= int6)
                    {
                        if (gclass65.gclass40_0.method_51() < this.gclass129_0.int_5)
                            int6 *= (double)AuroraUtils.smethod_64(
                                gclass65.gclass40_0.method_51() / this.gclass129_0.int_5, 2);
                        if (num <= int6)
                        {
                            this.auroraContactType_0 = AuroraContactType.Ship;
                            this.int_0 = gclass65.int_1;
                            this.gclass40_1 = gclass65.gclass40_0;
                            this.genum58_0 = GEnum58.const_1;
                            return true;
                        }
                    }
                    else
                        break;
                }
            }

            if (this.gclass129_0.double_1 > 0.0)
            {
                foreach (GClass65 gclass65 in this.gclass0_0.dictionary_28.Values
                             .Where<GClass65>(gclass65_0 =>
                                 gclass65_0.gclass21_1 == this.gclass21_0 &&
                                 gclass65_0.gclass200_0 == this.gclass200_0 &&
                                 gclass65_0.genum10_0 == GEnum10.const_1 &&
                                 gclass65_0.auroraContactType_0 == AuroraContactType.Ship)
                             .OrderBy<GClass65, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.double_0,
                                 this.double_1, gclass65_0.double_0, gclass65_0.double_1)).ToList<GClass65>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1, gclass65.double_0,
                        gclass65.double_1);
                    if (Math.Sqrt(this.gclass129_0.double_1 * (double)gclass65.decimal_0) * AuroraUtils.double_18 >=
                        num)
                    {
                        this.auroraContactType_0 = AuroraContactType.Ship;
                        this.int_0 = gclass65.int_1;
                        this.gclass40_1 = gclass65.gclass40_0;
                        this.genum58_0 = GEnum58.const_2;
                        return true;
                    }
                }
            }

            if (this.gclass129_0.double_2 > 0.0)
            {
                foreach (GClass65 gclass65 in this.gclass0_0.dictionary_28.Values
                             .Where<GClass65>(gclass65_0 => gclass65_0.gclass21_1 == this.gclass21_0 &&
                                                            gclass65_0.gclass200_0 == this.gclass200_0 &&
                                                            (gclass65_0.genum10_0 == GEnum10.const_3 ||
                                                             gclass65_0.genum10_0 == GEnum10.const_2) &&
                                                            gclass65_0.auroraContactType_0 == AuroraContactType.Ship)
                             .OrderBy<GClass65, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.double_0,
                                 this.double_1, gclass65_0.double_0, gclass65_0.double_1)).ToList<GClass65>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.double_0, this.double_1, gclass65.double_0,
                        gclass65.double_1);
                    if (Math.Sqrt(this.gclass129_0.double_2 * (double)gclass65.decimal_0) * AuroraUtils.double_18 >=
                        num)
                    {
                        this.auroraContactType_0 = AuroraContactType.Ship;
                        this.int_0 = gclass65.int_1;
                        this.gclass40_1 = gclass65.gclass40_0;
                        this.genum58_0 = GEnum58.const_3;
                        return true;
                    }
                }
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2061);
            return false;
        }
    }

    public void method_16()
    {
        try
        {
            foreach (GClass65 gclass65 in this.gclass0_0.dictionary_28.Values.Where<GClass65>(gclass65_0 =>
                             gclass65_0.auroraContactType_0 == AuroraContactType.Salvo &&
                             gclass65_0.int_1 == this.int_1)
                         .ToList<GClass65>())
                this.gclass0_0.dictionary_28.Remove(gclass65.int_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2063);
        }
    }

    public void method_17()
    {
        try
        {
            if (this.gclass129_0.double_2 == 0.0 && this.gclass129_0.double_1 == 0.0 &&
                this.gclass129_0.double_0 == 0.0)
            {
                this.gclass0_0.dictionary_6.Remove(this.int_1);
            }
            else
            {
                this.gclass230_0 = null;
                this.int_2 = 0;
                this.int_0 = 0;
                this.auroraContactType_0 = AuroraContactType.None;
                this.gclass40_1 = null;
                this.gclass146_0 = null;
                this.gclass132_0 = null;
                this.gclass40_0 = null;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2064);
        }
    }

    public string method_18(GameRace gclass21_2, bool bool_4)
    {
        try
        {
            bool flag = false;
            this.int_3 = 0;
            string str1 = "";
            GClass65 gclass65_1 =
                this.gclass0_0.method_556(gclass21_2, GEnum10.const_0, AuroraContactType.Salvo, this.int_1, 0);
            if (gclass65_1 != null && gclass65_1.decimal_0 > 0M)
            {
                if (bool_4)
                    str1 =
                        $"Size {AuroraUtils.smethod_38(gclass65_1.decimal_0)} Missile x{gclass65_1.int_2.ToString()}  ({gclass65_1.string_0})";
                else
                    str1 = $"Size {AuroraUtils.smethod_38(gclass65_1.decimal_0)} Missile";
                this.int_3 = gclass65_1.int_0;
                flag = true;
            }

            GClass65 gclass65_2 =
                this.gclass0_0.method_556(gclass21_2, GEnum10.const_1, AuroraContactType.Salvo, this.int_1, 0);
            if (gclass65_2 != null)
            {
                if (gclass65_2.decimal_0 > 0M)
                {
                    str1 = flag
                        ? $"{str1}  Thermal {AuroraUtils.smethod_38(gclass65_2.decimal_0)}"
                        : (!bool_4
                            ? " Thermal " + AuroraUtils.smethod_38(gclass65_2.decimal_0)
                            : $"{gclass65_2.int_2.ToString()}x Thermal {AuroraUtils.smethod_38(gclass65_2.decimal_0)}");
                    flag = true;
                }

                if (this.int_3 == 0)
                    this.int_3 = gclass65_2.int_0;
            }

            GClass65 gclass65_3 =
                this.gclass0_0.method_556(gclass21_2, GEnum10.const_2, AuroraContactType.Salvo, this.int_1, 0);
            if (gclass65_3 != null)
            {
                if (gclass65_3.decimal_0 > 0M)
                    str1 = flag
                        ? $"{str1}  {gclass65_3.string_0}"
                        : (!bool_4
                            ? " " + gclass65_3.string_0
                            : $"{gclass65_3.int_2.ToString()}x {gclass65_3.string_0}");
                if (this.int_3 == 0)
                    this.int_3 = gclass65_3.int_0;
            }

            string str2 =
                $"{$"[{gclass21_2.PerceivedAliens[this.gclass21_0.RaceID].Abbreviation}] {str1}"}  {AuroraUtils.smethod_43(this.double_9)} km/s";
            this.string_1 = str2;
            return str2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2065);
            return "error";
        }
    }

    public bool method_19(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_6)
    {
        try
        {
            AuroraContactStatus auroraContactStatus0 =
                gclass202_0.Race.PerceivedAliens[this.gclass21_0.RaceID].ContactStatus;
            if (!gclass202_0.Race.method_319(auroraContactStatus0))
                return false;
            Decimal num1 = this.method_24(gclass202_0.Race, GEnum10.const_0);
            if (gclass202_0.Race.chkActiveOnly == CheckState.Checked && num1 == 0M)
                return false;
            string s = this.method_18(gclass202_0.Race, true);
            if (gclass202_0.Race.chkTracking == CheckState.Checked)
            {
                Decimal num2 = gclass202_0.Race.method_107(this);
                s = $"{s}  TB {AuroraUtils.FormatNumberToDigits((num2 - 1M) * 100M, 1)}%";
            }

            if (gclass202_0.Race.chkShowDist == CheckState.Checked && (gclass202_0.gclass221_0.double_0 != 0.0 ||
                                                                             gclass202_0.gclass221_0.double_1 != 0.0))
            {
                double num3 = this.gclass0_0.GetDistanceBetween(gclass202_0.gclass221_0.double_0,
                    gclass202_0.gclass221_0.double_1, this.double_0, this.double_1);
                s = $"{s}  {AuroraUtils.smethod_50(num3 / 1000000.0)}m";
            }

            SolidBrush solidBrush = new SolidBrush(AuroraUtils.color_6);
            Pen pen = new Pen(AuroraUtils.color_6);
            solidBrush.Color = AuroraUtils.smethod_81(auroraContactStatus0);
            pen.Color = solidBrush.Color;
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            GClass221 gclass221_1 = this.method_25(gclass202_0.Race);
            if (gclass221_1.double_0 != 0.0 || gclass221_1.double_1 != 0.0)
            {
                GClass221 gclass221_2 = new GClass221();
                GClass221 gclass221_3 = gclass202_0.method_47(gclass221_1.double_0, gclass221_1.double_1);
                graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3,
                    (float)gclass221_3.double_0, (float)gclass221_3.double_1);
            }

            if (int_6 == 0)
                graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            GClass221 gclass221_4 = new GClass221();
            gclass221_4.double_0 = x + AuroraUtils.int_61 + 5.0;
            gclass221_4.double_1 = y - 3.0 - int_6 * 15;
            graphics_0.DrawString(s, font_0, solidBrush, (float)gclass221_4.double_0, (float)gclass221_4.double_1);
            this.string_1 = s;
            gclass202_0.list_3.Add(this);
            pen.Dispose();
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2066);
            return false;
        }
    }

    public string method_20(RacialSystemSurvey gclass202_0, int int_6, bool bool_4)
    {
        try
        {
            if (!gclass202_0.Race.PerceivedAliens.ContainsKey(this.gclass21_0.RaceID))
                return "";
            AuroraContactStatus auroraContactStatus0 =
                gclass202_0.Race.PerceivedAliens[this.gclass21_0.RaceID].ContactStatus;
            if (!gclass202_0.Race.method_319(auroraContactStatus0) ||
                this.method_24(gclass202_0.Race, GEnum10.const_0) == 0M &&
                gclass202_0.Race.chkActiveOnly == CheckState.Checked)
                return "";
            string str = this.method_18(gclass202_0.Race, bool_4);
            string string0 = gclass202_0.Race.PerceivedAliens[this.gclass21_0.RaceID].Abbreviation;
            if (gclass202_0.Race.chkShowDist == CheckState.Checked && (gclass202_0.gclass221_0.double_0 != 0.0 ||
                                                                             gclass202_0.gclass221_0.double_1 != 0.0))
            {
                double num = this.gclass0_0.GetDistanceBetween(gclass202_0.gclass221_0.double_0,
                    gclass202_0.gclass221_0.double_1, this.double_0, this.double_1);
                str = $"{str}  {AuroraUtils.smethod_50(num / 1000000.0)}m";
            }

            return $"[{string0}]  {str}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3788);
            return "";
        }
    }

    public void method_21(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_6)
    {
        try
        {
            this.string_0 = $"{this.dictionary_2.Count.ToString()}x {this.gclass129_0.Name}";
            if (this.gclass129_0.int_7 > 0)
                this.string_0 =
                    $"{this.string_0} ({this.dictionary_2.Values.Sum<int>(int_0 => int_0).ToString()} Decoys)";
            string str1 = "";
            if (this.gclass129_0.decimal_5 > 0M)
                str1 = $"  {this.gclass129_0.decimal_5.ToString()} km/s";
            string str2 = "";
            string str3 = "";
            SolidBrush solidBrush_0 = new SolidBrush(AuroraUtils.color_12);
            Pen pen = new Pen(AuroraUtils.color_12);
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            GClass221 gclass221_1 = new GClass221();
            GClass221 gclass221_2 = gclass202_0.method_47(this.double_6, this.double_7);
            graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3,
                (float)gclass221_2.double_0, (float)gclass221_2.double_1);
            if (int_6 == 0)
                graphics_0.FillEllipse(solidBrush_0, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            if (gclass202_0.Race.chkSalvoOrigin == CheckState.Checked && this.gclass40_0 != null)
                str2 = $" ({this.gclass40_0.method_187()})";
            if (gclass202_0.Race.chkSalvoTarget == CheckState.Checked)
                str3 = this.method_2();
            GClass221 gclass221_3 = new GClass221();
            gclass221_3.double_0 = x + AuroraUtils.int_61 + 5.0;
            gclass221_3.double_1 = y - 3.0 - int_6 * 15;
            graphics_0.DrawString(this.string_0 + str3 + str1 + str2, font_0, solidBrush_0, (float)gclass221_3.double_0,
                (float)gclass221_3.double_1);
            if (gclass202_0.Race.chkActiveSensors == CheckState.Checked && this.gclass129_0.double_0 > 0.0)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 15f, 5f };
                pen.Color = Color.FromArgb(176 /*0xB0*/, 226, byte.MaxValue);
                solidBrush_0.Color = Color.FromArgb(176 /*0xB0*/, 226, byte.MaxValue);
                double num1 = this.gclass129_0.int_6 / gclass202_0.KmPerPixel;
                if (num1 > 1.0)
                    graphics_0.DrawEllipse(pen, (float)(gclass222_0.double_2 - num1),
                        (float)(gclass222_0.double_3 - num1), (float)num1 * 2f, (float)num1 * 2f);
                string str4 =
                    $"Active: {(this.gclass129_0.int_6 <= 10000000 ? AuroraUtils.smethod_44(this.gclass129_0.int_6 / 1000000, 1) : AuroraUtils.smethod_44(this.gclass129_0.int_6 / 1000000, 0))}m  R{this.gclass129_0.int_5.ToString()}";
                int num2 = (int)graphics_0.MeasureString(str4, font_0).Width / 2;
                graphics_0.DrawString(str4, font_0, solidBrush_0, (float)gclass222_0.double_2 - num2,
                    (float)(gclass222_0.double_3 - num1 - 20.0));
            }

            if (this.gclass21_0.chkPassive10 == CheckState.Checked ||
                this.gclass21_0.chkPassive100 == CheckState.Checked ||
                this.gclass21_0.chkPassive1000 == CheckState.Checked ||
                this.gclass21_0.chkPassive10000 == CheckState.Checked)
            {
                if (this.gclass129_0.double_1 > 0.0)
                {
                    if (this.gclass21_0.chkPassive10 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_1, 10, "Thermal");
                    if (this.gclass21_0.chkPassive100 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_1, 100, "Thermal");
                    if (this.gclass21_0.chkPassive1000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_1, 1000, "Thermal");
                    if (this.gclass21_0.chkPassive10000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_1, 10000, "Thermal");
                }

                if (this.gclass129_0.double_2 > 0.0)
                {
                    if (this.gclass21_0.chkPassive10 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_2, 10, "EM");
                    if (this.gclass21_0.chkPassive100 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_2, 100, "EM");
                    if (this.gclass21_0.chkPassive1000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_2, 1000, "EM");
                    if (this.gclass21_0.chkPassive10000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.gclass129_0.double_2, 10000, "EM");
                }
            }

            pen.Dispose();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2067);
        }
    }

    public List<GClass65> method_22()
    {
        return this.gclass0_0.dictionary_28.Values.Where<GClass65>(gclass65_0 =>
                gclass65_0.auroraContactType_0 == AuroraContactType.Salvo && gclass65_0.int_1 == this.int_1)
            .ToList<GClass65>();
    }

    public bool method_23(GameRace gclass21_2)
    {
        try
        {
            foreach (GClass65 gclass65 in this.method_22())
            {
                if (gclass65.gclass21_1 == gclass21_2 && this.gclass0_0.GameTime == gclass65.decimal_3)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2068);
            return false;
        }
    }

    public Decimal method_24(GameRace gclass21_2, GEnum10 genum10_0)
    {
        try
        {
            foreach (GClass65 gclass65 in this.method_22())
            {
                if (gclass65.gclass21_1 == gclass21_2 && this.gclass0_0.GameTime == gclass65.decimal_3 &&
                    gclass65.genum10_0 == genum10_0)
                    return gclass65.decimal_0;
            }

            return 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2069);
            return 0M;
        }
    }

    public GClass221 method_25(GameRace gclass21_2)
    {
        try
        {
            GClass221 gclass221 = new GClass221();
            foreach (GClass65 gclass65 in this.method_22())
            {
                if (gclass65.gclass21_1 == gclass21_2 && this.gclass0_0.GameTime == gclass65.decimal_3)
                {
                    gclass221.double_0 = gclass65.double_4;
                    gclass221.double_1 = gclass65.double_5;
                    break;
                }
            }

            return gclass221;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2070);
            return null;
        }
    }

    public Decimal method_26()
    {
        try
        {
            return this.gclass129_0.gclass230_0 == null
                ? this.gclass129_0.decimal_4 / 400M
                : this.gclass129_0.gclass230_0.decimal_3 * this.gclass129_0.int_9;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2071);
            return 0M;
        }
    }
}