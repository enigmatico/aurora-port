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
public class MissileSalvo
{
    private sealed class Class1085
    {
        public MissileSalvo gclass132_0;
        public Decimal decimal_0;
        public int int_0;

        internal bool method_0(ShipData gclass40_0)
        {
            return this.gclass132_0.gclass0_0.GetDistanceBetween(this.gclass132_0.Xcor, this.gclass132_0.Ycor,
                gclass40_0.gclass85_0.XCoord, gclass40_0.gclass85_0.YCoord) < (double)this.decimal_0;
        }

        internal bool method_1(ShipData gclass40_0)
        {
            return gclass40_0.int_38 >= this.int_0;
        }
    }

    private sealed class Class1086
    {
        public MissileSalvo gclass132_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass132_0.System &&
                   gclass1_0.XCoordinate == this.gclass132_0.Xcor &&
                   gclass1_0.YCoordinate == this.gclass132_0.Ycor;
        }
    }

    private GClass0 gclass0_0;
    public Dictionary<int, GClass131> dictionary_0 = new Dictionary<int, GClass131>();
    public Dictionary<GameRace, Decimal> dictionary_1 = new Dictionary<GameRace, Decimal>();
    public Dictionary<int, int> RemainingDecoys = new Dictionary<int, int>();
    public List<GameRace> list_0 = new List<GameRace>();
    /// <summary>
    /// Launching Ship
    /// </summary>
    public ShipData Ship;
    public GameRace Race;
    public StarSystem System;
    public RaceMissile RaceMissile;
    public ShipComponent FireControl;
    public SystemBodyData OrbitBody;
    public ShipData TargetShip;
    public MissileSalvo TargetSalvo;
    public PopulationData TargetPopulation;
    public Waypoint TargetWaypoint;
    public AuroraContactType TargetType;
    public HomingMethod HomingMethod;
    public int TargetID;
    public int MissileSalvoID;
    public int FCNum;
    public Decimal LaunchTime;
    public Decimal Endurance;
    public Decimal CurrentDetonationRange;
    public double Xcor;
    public double Ycor;
    public double LastXcor;
    public double LastYcor;
    public double LastTargetX;
    public double LastTargetY;
    public double IncrementStartX;
    public double IncrementStartY;
    public double ModifierToHit;
    public double MissileSpeed;
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

    public MissileSalvo(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public GClass221 method_0(GClass221 gclass221_2, double double_12)
    {
        try
        {
            GClass221 gclass221 = new GClass221(gclass221_2.double_0, gclass221_2.double_1);
            double num1 = this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor, gclass221_2.double_0,
                gclass221_2.double_1);
            double num2 = double_12 / num1;
            double num3 = Math.Abs(gclass221_2.double_0 - this.Xcor) * num2;
            double num4 = Math.Abs(gclass221_2.double_1 - this.Ycor) * num2;
            gclass221.double_0 = gclass221_2.double_0 >= this.Xcor
                ? gclass221_2.double_0 - num3
                : gclass221_2.double_0 + num3;
            gclass221.double_1 = gclass221_2.double_1 >= this.Ycor
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
            foreach (PopulationData gclass146 in this.System.method_33(this.Race))
            {
                if (this.gclass0_0.method_520(this.Xcor, gclass146.method_87(), this.Ycor,
                        gclass146.method_88()))
                    return gclass146.PopName;
            }

            foreach (JumpPoint gclass120 in this.System.method_27())
            {
                if (gclass120.RacialJumpPointSurveys.ContainsKey(this.Race.RaceID) &&
                    gclass120.RacialJumpPointSurveys[this.Race.RaceID].Charted == 1 &&
                    this.gclass0_0.method_520(this.Xcor, gclass120.XCoord, this.Ycor, gclass120.YCoord))
                {
                    RacialSystemSurvey gclass202_0 = this.Race.method_128(this.System);
                    return gclass120.method_8(gclass202_0);
                }
            }

            foreach (SurveyLocation gclass213 in this.System.SurveyLocationDictionary.Values)
            {
                if (this.gclass0_0.method_520(this.Xcor, gclass213.XCoord, this.Ycor, gclass213.YCoord))
                    return string.Format((string)"Survey Location #{0}", (object)gclass213.LocationNumber);
            }

            foreach (SystemBodyData gclass1 in this.System.method_20())
            {
                if (this.gclass0_0.method_520(this.Xcor, gclass1.XCoordinate, this.Ycor, gclass1.YCoordinate))
                    return gclass1.method_78(this.Race);
            }

            return this.System.method_22(this.Xcor, this.Ycor,
                this.Race.method_128(this.System));
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
            if (this.TargetShip != null)
                str = string.Format((string)"  {0}", (object)this.Race.method_32(this.TargetShip));
            else if (this.TargetSalvo != null)
                str = string.Format((string)"  SalvoID {0}", (object)this.TargetSalvo.MissileSalvoID);
            else if (this.TargetWaypoint != null)
                str = string.Format((string)"  {0}", (object)this.TargetWaypoint.method_2(true));
            else if (this.TargetPopulation != null)
            {
                if (this.TargetType == AuroraContactType.Population)
                    str = string.Format((string)"  {0}", (object)this.Race.method_42(this.TargetPopulation));
                else if (this.TargetType == AuroraContactType.GroundUnit)
                    str = string.Format((string)"  {0} Ground Forces", (object)this.Race.method_42(this.TargetPopulation));
                else if (this.TargetType == AuroraContactType.STOGroundUnit)
                    str = string.Format((string)"  {0} STO Ground Forces",
                        (object)this.Race.method_42(this.TargetPopulation));
                else if (this.TargetType == AuroraContactType.Shipyard)
                    str = string.Format((string)"  {0} Shipyards", (object)this.Race.method_42(this.TargetPopulation));
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
            foreach (int key in this.RemainingDecoys.Keys.ToList<int>())
            {
                bool flag = false;
                for (int index = 1; index <= this.RaceMissile.MultipleWarheads; ++index)
                {
                    if (AuroraUtils.GetRandomInteger(100) <= double_12)
                    {
                        flag = true;
                        ++num;
                    }
                }

                if (flag)
                    this.RemainingDecoys.Remove(key);
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
            this.RemainingDecoys.Remove(int_6);
            return this.RemainingDecoys.Count;
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
            this.RemainingDecoys = this.RemainingDecoys.Take<KeyValuePair<int, int>>(this.RemainingDecoys.Count - int_6)
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
            this.RemainingDecoys.Clear();
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
            this.RemainingDecoys.Add(
                this.RemainingDecoys.Max<KeyValuePair<int, int>>(keyValuePair_0 => keyValuePair_0.Key) + 1,
                this.RaceMissile.NumDecoys);
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
        MissileSalvo.Class1085 class1085 = new MissileSalvo.Class1085();
        // ISSUE: reference to a compiler-generated field
        class1085.gclass132_0 = this;
        try
        {
            if (!this.method_13(false))
                return;
            List<ShipData> source = this.method_14();
            if (source.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class1085.decimal_0 = this.RaceMissile.Speed * this.Endurance;
            // ISSUE: reference to a compiler-generated field
            if (class1085.decimal_0 == 0M)
                return;
            int int_72 = 0;
            // ISSUE: reference to a compiler-generated method
            List<ShipData> list1 = source.Where<ShipData>(class1085.method_0).ToList<ShipData>();
            foreach (ShipData gclass40_1 in list1)
            {
                Decimal num1 = gclass40_1.Class.MaxSpeed * this.Endurance;
                // ISSUE: reference to a compiler-generated field
                Decimal num2 = class1085.decimal_0 - num1;
                Decimal num3 = (Decimal)this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor,
                    gclass40_1.gclass85_0.XCoord, gclass40_1.gclass85_0.YCoord);
                Decimal num4 = num3;
                if (num2 > num4)
                {
                    if (num3 < 10000M)
                        num3 = 10000M;
                    Decimal num5 = 1M;
                    AlienShipIntel gclass117 = this.Race.method_267(gclass40_1);
                    if (gclass117 != null && gclass117.gclass115_0.genum70_0 == EngineDesignType.const_2)
                        num5 = 0.1M;
                    gclass40_1.int_37 = (int)Math.Floor(gclass40_1.Class.Size / num3 * 10000000M * num5);
                    if (gclass40_1.int_37 < 1)
                        gclass40_1.int_37 = 1;
                }
                else
                    gclass40_1.int_37 = 0;

                int_72 += gclass40_1.int_37;
                gclass40_1.int_38 = int_72;
            }

            List<ShipData> list2 = list1.Where<ShipData>(gclass40_0 => gclass40_0.int_37 > 0)
                .ToList<ShipData>();
            // ISSUE: reference to a compiler-generated field
            class1085.int_0 = AuroraUtils.GetRandomInteger(int_72);
            // ISSUE: reference to a compiler-generated method
            this.TargetID = list2.Where<ShipData>(class1085.method_1)
                .OrderBy<ShipData, int>(gclass40_0 => gclass40_0.int_38).FirstOrDefault<ShipData>().int_8;
            this.TargetType = AuroraContactType.Ship;
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
                ? AuroraUtils.FormatDoubleToPrecision(num1 / 1000000.0, 1)
                : AuroraUtils.FormatDoubleToPrecision(num1 / 1000000.0, 0);
            string str2 = string.Format((string)"{0} vs {1} Signature-{2}   {3}m", new[] { this.string_0 }, string_3,
                int_6.ToString(), str1);
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
            if (this.TargetID == 0)
                return this.gclass221_0;
            if (this.TargetType == AuroraContactType.Ship)
            {
                if (this.TargetShip != null)
                {
                    this.gclass221_0.double_0 = this.TargetShip.gclass85_0.XCoord;
                    this.gclass221_0.double_1 = this.TargetShip.gclass85_0.YCoord;
                }
            }
            else if (this.TargetType == AuroraContactType.Salvo)
            {
                if (this.TargetSalvo != null)
                {
                    this.gclass221_0.double_0 = this.TargetSalvo.Xcor;
                    this.gclass221_0.double_1 = this.TargetSalvo.Ycor;
                }
            }
            else if (this.TargetType != AuroraContactType.Population &&
                     this.TargetType != AuroraContactType.Shipyard &&
                     this.TargetType != AuroraContactType.GroundUnit &&
                     this.TargetType != AuroraContactType.STOGroundUnit)
            {
                if (this.TargetType == AuroraContactType.WayPoint && this.TargetWaypoint != null)
                {
                    this.gclass221_0.double_0 = this.TargetWaypoint.Xcor;
                    this.gclass221_0.double_1 = this.TargetWaypoint.Ycor;
                }
            }
            else if (this.TargetPopulation != null)
            {
                this.gclass221_0.double_0 = this.TargetPopulation.method_87();
                this.gclass221_0.double_1 = this.TargetPopulation.method_88();
            }

            return this.gclass221_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2057);
            return new GClass221(0.0, 0.0);
        }
    }

    public bool method_11(List<Contact> list_1)
    {
        try
        {
            if (this.HomingMethod != HomingMethod.const_0 && this.HomingMethod != HomingMethod.const_1)
            {
                if (this.HomingMethod == HomingMethod.const_2)
                {
                    if (list_1.Count<Contact>(gclass65_0 => gclass65_0.ContactMethod == ContactDetectMethod.const_1) > 0)
                        return true;
                }
                else if (this.HomingMethod == HomingMethod.const_3 && list_1.Count<Contact>(gclass65_0 =>
                             gclass65_0.ContactMethod == ContactDetectMethod.const_3 || gclass65_0.ContactMethod == ContactDetectMethod.const_2) > 0)
                    return true;
            }
            else if (list_1.Count<Contact>(gclass65_0 => gclass65_0.ContactMethod == ContactDetectMethod.const_0) > 0)
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
            MissileSalvo.Class1086 class1086 = new MissileSalvo.Class1086();
            if (this.RaceMissile.SecondStageMissile == null)
                return;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0 = (MissileSalvo)this.MemberwiseClone();
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.MissileSalvoID = this.gclass0_0.method_26(GEnum0.const_38);
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.RaceMissile = this.RaceMissile.SecondStageMissile;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.LaunchTime = this.gclass0_0.GameTime;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.string_0 = class1086.gclass132_0.RaceMissile.Name;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.MissileSpeed = (double)class1086.gclass132_0.RaceMissile.Speed;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.Endurance = class1086.gclass132_0.RaceMissile.Endurance;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.Xcor = this.Xcor;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.Ycor = this.Ycor;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.LastXcor = this.Xcor;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.LastYcor = this.Ycor;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.ModifierToHit = this.ModifierToHit;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.FireControl = this.FireControl;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.FCNum = this.FCNum;
            // ISSUE: reference to a compiler-generated field
            class1086.gclass132_0.RemainingDecoys = new Dictionary<int, int>();
            int num = this.RemainingDecoys.Count * this.RaceMissile.NumSS;
            for (int key = 1; key <= num; ++key)
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.RemainingDecoys.Add(key, class1086.gclass132_0.RaceMissile.NumDecoys);
            }

            if (this.FireControl != null)
            {
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetID = this.TargetID;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetType = this.TargetType;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.method_8();
            }

            // ISSUE: reference to a compiler-generated field
            if (class1086.gclass132_0.RaceMissile.Speed == 0M)
            {
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetID = 0;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetType = AuroraContactType.None;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetShip = null;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetPopulation = null;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetSalvo = null;
                // ISSUE: reference to a compiler-generated field
                class1086.gclass132_0.TargetWaypoint = null;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                class1086.gclass132_0.OrbitBody =
                    this.gclass0_0.SystemBodyRecordDic.Values
                        .FirstOrDefault<SystemBodyData>(class1086.method_0);
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.MissileSalvoes.Add(class1086.gclass132_0.MissileSalvoID, class1086.gclass132_0);
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
            return this.RaceMissile.EMStrength != 0.0 || this.RaceMissile.ThermalStrength != 0.0 ||
                   this.RaceMissile.SensorStrength != 0.0 || bool_4 && this.RaceMissile.GeoStrength > 0M;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2060);
            return false;
        }
    }

    public List<ShipData> method_14()
    {
        try
        {
            List<ShipData> source = new List<ShipData>();
            if (this.RaceMissile.SensorStrength > 0.0)
            {
                foreach (Contact gclass65 in this.gclass0_0.Contacts.Values
                             .Where<Contact>(gclass65_0 =>
                                 gclass65_0.DetectRace == this.Race &&
                                 gclass65_0.System == this.System &&
                                 gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                                 gclass65_0.ContactType == AuroraContactType.Ship)
                             .OrderBy<Contact, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.Xcor,
                                 this.Ycor, gclass65_0.Xcor, gclass65_0.Ycor)).ToList<Contact>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor, gclass65.Xcor,
                        gclass65.Ycor);
                    double int6 = this.RaceMissile.SensorRange;
                    if (num <= int6)
                    {
                        if (gclass65.TargetShip.method_51() < this.RaceMissile.SensorResolution)
                            int6 *= (double)AuroraUtils.smethod_64(
                                gclass65.TargetShip.method_51() / this.RaceMissile.SensorResolution, 2);
                        if (num <= int6)
                            source.Add(gclass65.TargetShip);
                    }
                    else
                        break;
                }
            }

            if (this.RaceMissile.ThermalStrength > 0.0)
            {
                foreach (Contact gclass65 in this.gclass0_0.Contacts.Values
                             .Where<Contact>(gclass65_0 =>
                                 gclass65_0.DetectRace == this.Race &&
                                 gclass65_0.System == this.System &&
                                 gclass65_0.ContactMethod == ContactDetectMethod.const_1 &&
                                 gclass65_0.ContactType == AuroraContactType.Ship)
                             .OrderBy<Contact, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.Xcor,
                                 this.Ycor, gclass65_0.Xcor, gclass65_0.Ycor)).ToList<Contact>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor, gclass65.Xcor,
                        gclass65.Ycor);
                    if (Math.Sqrt(this.RaceMissile.ThermalStrength * (double)gclass65.ContactStrength) * AuroraUtils.double_18 >=
                        num)
                        source.Add(gclass65.TargetShip);
                }
            }

            if (this.RaceMissile.EMStrength > 0.0)
            {
                foreach (Contact gclass65 in this.gclass0_0.Contacts.Values
                             .Where<Contact>(gclass65_0 => gclass65_0.DetectRace == this.Race &&
                                                            gclass65_0.System == this.System &&
                                                            (gclass65_0.ContactMethod == ContactDetectMethod.const_3 ||
                                                             gclass65_0.ContactMethod == ContactDetectMethod.const_2) &&
                                                            gclass65_0.ContactType == AuroraContactType.Ship)
                             .OrderBy<Contact, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.Xcor,
                                 this.Ycor, gclass65_0.Xcor, gclass65_0.Ycor)).ToList<Contact>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor, gclass65.Xcor,
                        gclass65.Ycor);
                    if (Math.Sqrt(this.RaceMissile.EMStrength * (double)gclass65.ContactStrength) * AuroraUtils.double_18 >=
                        num)
                        source.Add(gclass65.TargetShip);
                }
            }

            return source.Distinct<ShipData>().ToList<ShipData>().Except<ShipData>(this.gclass0_0
                .FormationDictionary.Values
                .Where<GroundUnitFormationData>(gclass103_0 =>
                    gclass103_0.RaceData == this.Race && gclass103_0.ShipData != null)
                .Where<GroundUnitFormationData>(gclass103_0 => gclass103_0.ShipData.Race != this.Race)
                .Select<GroundUnitFormationData, ShipData>(gclass103_0 => gclass103_0.ShipData).Distinct<ShipData>()
                .ToList<ShipData>()).ToList<ShipData>();
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
            if (this.RaceMissile.SensorStrength > 0.0)
            {
                foreach (Contact gclass65 in this.gclass0_0.Contacts.Values
                             .Where<Contact>(gclass65_0 =>
                                 gclass65_0.DetectRace == this.Race &&
                                 gclass65_0.System == this.System &&
                                 gclass65_0.ContactMethod == ContactDetectMethod.const_0 &&
                                 gclass65_0.ContactType == AuroraContactType.Ship)
                             .OrderBy<Contact, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.Xcor,
                                 this.Ycor, gclass65_0.Xcor, gclass65_0.Ycor)).ToList<Contact>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor, gclass65.Xcor,
                        gclass65.Ycor);
                    double int6 = this.RaceMissile.SensorRange;
                    if (num <= int6)
                    {
                        if (gclass65.TargetShip.method_51() < this.RaceMissile.SensorResolution)
                            int6 *= (double)AuroraUtils.smethod_64(
                                gclass65.TargetShip.method_51() / this.RaceMissile.SensorResolution, 2);
                        if (num <= int6)
                        {
                            this.TargetType = AuroraContactType.Ship;
                            this.TargetID = gclass65.ContactID;
                            this.TargetShip = gclass65.TargetShip;
                            this.HomingMethod = HomingMethod.const_1;
                            return true;
                        }
                    }
                    else
                        break;
                }
            }

            if (this.RaceMissile.ThermalStrength > 0.0)
            {
                foreach (Contact gclass65 in this.gclass0_0.Contacts.Values
                             .Where<Contact>(gclass65_0 =>
                                 gclass65_0.DetectRace == this.Race &&
                                 gclass65_0.System == this.System &&
                                 gclass65_0.ContactMethod == ContactDetectMethod.const_1 &&
                                 gclass65_0.ContactType == AuroraContactType.Ship)
                             .OrderBy<Contact, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.Xcor,
                                 this.Ycor, gclass65_0.Xcor, gclass65_0.Ycor)).ToList<Contact>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor, gclass65.Xcor,
                        gclass65.Ycor);
                    if (Math.Sqrt(this.RaceMissile.ThermalStrength * (double)gclass65.ContactStrength) * AuroraUtils.double_18 >=
                        num)
                    {
                        this.TargetType = AuroraContactType.Ship;
                        this.TargetID = gclass65.ContactID;
                        this.TargetShip = gclass65.TargetShip;
                        this.HomingMethod = HomingMethod.const_2;
                        return true;
                    }
                }
            }

            if (this.RaceMissile.EMStrength > 0.0)
            {
                foreach (Contact gclass65 in this.gclass0_0.Contacts.Values
                             .Where<Contact>(gclass65_0 => gclass65_0.DetectRace == this.Race &&
                                                            gclass65_0.System == this.System &&
                                                            (gclass65_0.ContactMethod == ContactDetectMethod.const_3 ||
                                                             gclass65_0.ContactMethod == ContactDetectMethod.const_2) &&
                                                            gclass65_0.ContactType == AuroraContactType.Ship)
                             .OrderBy<Contact, double>(gclass65_0 => this.gclass0_0.GetDistanceBetween(this.Xcor,
                                 this.Ycor, gclass65_0.Xcor, gclass65_0.Ycor)).ToList<Contact>())
                {
                    double num = this.gclass0_0.GetDistanceBetween(this.Xcor, this.Ycor, gclass65.Xcor,
                        gclass65.Ycor);
                    if (Math.Sqrt(this.RaceMissile.EMStrength * (double)gclass65.ContactStrength) * AuroraUtils.double_18 >=
                        num)
                    {
                        this.TargetType = AuroraContactType.Ship;
                        this.TargetID = gclass65.ContactID;
                        this.TargetShip = gclass65.TargetShip;
                        this.HomingMethod = HomingMethod.const_3;
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
            foreach (Contact gclass65 in this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                             gclass65_0.ContactType == AuroraContactType.Salvo &&
                             gclass65_0.ContactID == this.MissileSalvoID)
                         .ToList<Contact>())
                this.gclass0_0.Contacts.Remove(gclass65.UniqueID);
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
            if (this.RaceMissile.EMStrength == 0.0 && this.RaceMissile.ThermalStrength == 0.0 &&
                this.RaceMissile.SensorStrength == 0.0)
            {
                this.gclass0_0.MissileSalvoes.Remove(this.MissileSalvoID);
            }
            else
            {
                this.FireControl = null;
                this.FCNum = 0;
                this.TargetID = 0;
                this.TargetType = AuroraContactType.None;
                this.TargetShip = null;
                this.TargetPopulation = null;
                this.TargetSalvo = null;
                this.Ship = null;
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
            Contact gclass65_1 =
                this.gclass0_0.method_556(gclass21_2, ContactDetectMethod.const_0, AuroraContactType.Salvo, this.MissileSalvoID, 0);
            if (gclass65_1 != null && gclass65_1.ContactStrength > 0M)
            {
                if (bool_4)
                    str1 =
                        string.Format((string)"Size {0} Missile x{1}  ({2})",
                            (object)AuroraUtils.smethod_38(gclass65_1.ContactStrength),
                            (object)gclass65_1.ContactNumber.ToString(), (object)gclass65_1.ContactName);
                else
                    str1 = string.Format((string)"Size {0} Missile",
                        (object)AuroraUtils.smethod_38(gclass65_1.ContactStrength));
                this.int_3 = gclass65_1.UniqueID;
                flag = true;
            }

            Contact gclass65_2 =
                this.gclass0_0.method_556(gclass21_2, ContactDetectMethod.const_1, AuroraContactType.Salvo, this.MissileSalvoID, 0);
            if (gclass65_2 != null)
            {
                if (gclass65_2.ContactStrength > 0M)
                {
                    str1 = flag
                        ? string.Format((string)"{0}  Thermal {1}", (object)str1,
                            (object)AuroraUtils.smethod_38(gclass65_2.ContactStrength))
                        : (!bool_4
                            ? string.Format((string)" Thermal {0}",
                                (object)AuroraUtils.smethod_38(gclass65_2.ContactStrength))
                            : string.Format((string)"{0}x Thermal {1}", (object)gclass65_2.ContactNumber.ToString(),
                                (object)AuroraUtils.smethod_38(gclass65_2.ContactStrength)));
                    flag = true;
                }

                if (this.int_3 == 0)
                    this.int_3 = gclass65_2.UniqueID;
            }

            Contact gclass65_3 =
                this.gclass0_0.method_556(gclass21_2, ContactDetectMethod.const_2, AuroraContactType.Salvo, this.MissileSalvoID, 0);
            if (gclass65_3 != null)
            {
                if (gclass65_3.ContactStrength > 0M)
                    str1 = flag
                        ? string.Format((string)"{0}  {1}", (object)str1, (object)gclass65_3.ContactName)
                        : (!bool_4
                            ? string.Format((string)" {0}", (object)gclass65_3.ContactName)
                            : string.Format((string)"{0}x {1}", (object)gclass65_3.ContactNumber.ToString(),
                                (object)gclass65_3.ContactName));
                if (this.int_3 == 0)
                    this.int_3 = gclass65_3.UniqueID;
            }

            string str2 =
                string.Format((string)"{0}  {1} km/s",
                    (object)string.Format((string)"[{0}] {1}",
                        (object)gclass21_2.AlienRaceIntels[this.Race.RaceID].Abbreviation, (object)str1),
                    (object)AuroraUtils.smethod_43(this.MissileSpeed));
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
                gclass202_0.Race.AlienRaceIntels[this.Race.RaceID].ContactStatus;
            if (!gclass202_0.Race.method_319(auroraContactStatus0))
                return false;
            Decimal num1 = this.method_24(gclass202_0.Race, ContactDetectMethod.const_0);
            if (gclass202_0.Race.chkActiveOnly == CheckState.Checked && num1 == 0M)
                return false;
            string s = this.method_18(gclass202_0.Race, true);
            if (gclass202_0.Race.chkTracking == CheckState.Checked)
            {
                Decimal num2 = gclass202_0.Race.method_107(this);
                s = string.Format((string)"{0}  TB {1}%", (object)s,
                    (object)AuroraUtils.FormatNumberToDigits((num2 - 1M) * 100M, 1));
            }

            if (gclass202_0.Race.chkShowDist == CheckState.Checked && (gclass202_0.gclass221_0.double_0 != 0.0 ||
                                                                             gclass202_0.gclass221_0.double_1 != 0.0))
            {
                double num3 = this.gclass0_0.GetDistanceBetween(gclass202_0.gclass221_0.double_0,
                    gclass202_0.gclass221_0.double_1, this.Xcor, this.Ycor);
                s = string.Format((string)"{0}  {1}m", (object)s, (object)AuroraUtils.smethod_50(num3 / 1000000.0));
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
            if (!gclass202_0.Race.AlienRaceIntels.ContainsKey(this.Race.RaceID))
                return "";
            AuroraContactStatus auroraContactStatus0 =
                gclass202_0.Race.AlienRaceIntels[this.Race.RaceID].ContactStatus;
            if (!gclass202_0.Race.method_319(auroraContactStatus0) ||
                this.method_24(gclass202_0.Race, ContactDetectMethod.const_0) == 0M &&
                gclass202_0.Race.chkActiveOnly == CheckState.Checked)
                return "";
            string str = this.method_18(gclass202_0.Race, bool_4);
            string string0 = gclass202_0.Race.AlienRaceIntels[this.Race.RaceID].Abbreviation;
            if (gclass202_0.Race.chkShowDist == CheckState.Checked && (gclass202_0.gclass221_0.double_0 != 0.0 ||
                                                                             gclass202_0.gclass221_0.double_1 != 0.0))
            {
                double num = this.gclass0_0.GetDistanceBetween(gclass202_0.gclass221_0.double_0,
                    gclass202_0.gclass221_0.double_1, this.Xcor, this.Ycor);
                str = string.Format((string)"{0}  {1}m", (object)str, (object)AuroraUtils.smethod_50(num / 1000000.0));
            }

            return string.Format((string)"[{0}]  {1}", (object)string0, (object)str);
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
            this.string_0 = string.Format((string)"{0}x {1}", (object)this.RemainingDecoys.Count.ToString(),
                (object)this.RaceMissile.Name);
            if (this.RaceMissile.NumDecoys > 0)
                this.string_0 =
                    string.Format((string)"{0} ({1} Decoys)", (object)this.string_0,
                        (object)this.RemainingDecoys.Values.Sum<int>(int_0 => int_0).ToString());
            string str1 = "";
            if (this.RaceMissile.Speed > 0M)
                str1 = string.Format((string)"  {0} km/s", (object)this.RaceMissile.Speed.ToString());
            string str2 = "";
            string str3 = "";
            SolidBrush solidBrush_0 = new SolidBrush(AuroraUtils.color_12);
            Pen pen = new Pen(AuroraUtils.color_12);
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            GClass221 gclass221_1 = new GClass221();
            GClass221 gclass221_2 = gclass202_0.method_47(this.IncrementStartX, this.IncrementStartY);
            graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3,
                (float)gclass221_2.double_0, (float)gclass221_2.double_1);
            if (int_6 == 0)
                graphics_0.FillEllipse(solidBrush_0, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            if (gclass202_0.Race.chkSalvoOrigin == CheckState.Checked && this.Ship != null)
                str2 = string.Format((string)" ({0})", (object)this.Ship.method_187());
            if (gclass202_0.Race.chkSalvoTarget == CheckState.Checked)
                str3 = this.method_2();
            GClass221 gclass221_3 = new GClass221();
            gclass221_3.double_0 = x + AuroraUtils.int_61 + 5.0;
            gclass221_3.double_1 = y - 3.0 - int_6 * 15;
            graphics_0.DrawString(this.string_0 + str3 + str1 + str2, font_0, solidBrush_0, (float)gclass221_3.double_0,
                (float)gclass221_3.double_1);
            if (gclass202_0.Race.chkActiveSensors == CheckState.Checked && this.RaceMissile.SensorStrength > 0.0)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 15f, 5f };
                pen.Color = Color.FromArgb(176 /*0xB0*/, 226, byte.MaxValue);
                solidBrush_0.Color = Color.FromArgb(176 /*0xB0*/, 226, byte.MaxValue);
                double num1 = this.RaceMissile.SensorRange / gclass202_0.KmPerPixel;
                if (num1 > 1.0)
                    graphics_0.DrawEllipse(pen, (float)(gclass222_0.double_2 - num1),
                        (float)(gclass222_0.double_3 - num1), (float)num1 * 2f, (float)num1 * 2f);
                string str4 =
                    string.Format((string)"Active: {0}m  R{1}",
                        (object)(this.RaceMissile.SensorRange <= 10000000
                            ? AuroraUtils.FormatDoubleToPrecision(this.RaceMissile.SensorRange / 1000000, 1)
                            : AuroraUtils.FormatDoubleToPrecision(this.RaceMissile.SensorRange / 1000000, 0)),
                        (object)this.RaceMissile.SensorResolution.ToString());
                int num2 = (int)graphics_0.MeasureString(str4, font_0).Width / 2;
                graphics_0.DrawString(str4, font_0, solidBrush_0, (float)gclass222_0.double_2 - num2,
                    (float)(gclass222_0.double_3 - num1 - 20.0));
            }

            if (this.Race.chkPassive10 == CheckState.Checked ||
                this.Race.chkPassive100 == CheckState.Checked ||
                this.Race.chkPassive1000 == CheckState.Checked ||
                this.Race.chkPassive10000 == CheckState.Checked)
            {
                if (this.RaceMissile.ThermalStrength > 0.0)
                {
                    if (this.Race.chkPassive10 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.ThermalStrength, 10, "Thermal");
                    if (this.Race.chkPassive100 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.ThermalStrength, 100, "Thermal");
                    if (this.Race.chkPassive1000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.ThermalStrength, 1000, "Thermal");
                    if (this.Race.chkPassive10000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.ThermalStrength, 10000, "Thermal");
                }

                if (this.RaceMissile.EMStrength > 0.0)
                {
                    if (this.Race.chkPassive10 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.EMStrength, 10, "EM");
                    if (this.Race.chkPassive100 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.EMStrength, 100, "EM");
                    if (this.Race.chkPassive1000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.EMStrength, 1000, "EM");
                    if (this.Race.chkPassive10000 == CheckState.Checked)
                        this.method_9(graphics_0, solidBrush_0, pen, font_0, gclass222_0, gclass202_0,
                            this.RaceMissile.EMStrength, 10000, "EM");
                }
            }

            pen.Dispose();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2067);
        }
    }

    public List<Contact> method_22()
    {
        return this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 =>
                gclass65_0.ContactType == AuroraContactType.Salvo && gclass65_0.ContactID == this.MissileSalvoID)
            .ToList<Contact>();
    }

    public bool method_23(GameRace gclass21_2)
    {
        try
        {
            foreach (Contact gclass65 in this.method_22())
            {
                if (gclass65.DetectRace == gclass21_2 && this.gclass0_0.GameTime == gclass65.LastUpdate)
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

    public Decimal method_24(GameRace gclass21_2, ContactDetectMethod genum10_0)
    {
        try
        {
            foreach (Contact gclass65 in this.method_22())
            {
                if (gclass65.DetectRace == gclass21_2 && this.gclass0_0.GameTime == gclass65.LastUpdate &&
                    gclass65.ContactMethod == genum10_0)
                    return gclass65.ContactStrength;
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
            foreach (Contact gclass65 in this.method_22())
            {
                if (gclass65.DetectRace == gclass21_2 && this.gclass0_0.GameTime == gclass65.LastUpdate)
                {
                    gclass221.double_0 = gclass65.IncrementStartX;
                    gclass221.double_1 = gclass65.IncrementStartY;
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
            return this.RaceMissile.EngineComponent == null
                ? this.RaceMissile.Size / 400M
                : this.RaceMissile.EngineComponent.decimal_3 * this.RaceMissile.NumEngines;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2071);
            return 0M;
        }
    }
}