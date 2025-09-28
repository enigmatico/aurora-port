// Decompiled with JetBrains decompiler
// Type: GClass197
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using aurora;
using Aurora;

#nullable disable
public class Star197
{
    private sealed class Class1163
    {
        public SystemBodyData gclass1_0;

        internal bool method_0(SystemBodyData gclass1_1)
        {
            return gclass1_1.ParentBodyData == this.gclass1_0 && gclass1_1.BodyClass == PlanetBodyClass.Moon;
        }
    }


    private sealed class Class1164
    {
        public Star197 gclass197_0;
        public int int_0;

        internal bool method_0(LagrangePoint gclass212_0)
        {
            return gclass212_0.System == this.gclass197_0.SystemData &&
                   gclass212_0.Star.OrbitingComponent == 0 && gclass212_0.Planet.double_28 < this.int_0;
        }

        internal bool method_1(LagrangePoint gclass212_0)
        {
            return gclass212_0.Star == this.gclass197_0 && gclass212_0.Planet.double_28 < this.int_0;
        }

        internal bool method_2(LagrangePoint gclass212_0)
        {
            return (gclass212_0.Star == this.gclass197_0 ||
                    gclass212_0.Star == this.gclass197_0.OrbitingStar) &&
                   gclass212_0.Planet.double_28 < this.int_0;
        }
    }


    private sealed class Class1165
    {
        public int int_0;

        internal bool method_0(SystemAbundance gclass199_0)
        {
            return gclass199_0.MaxChance >= this.int_0;
        }
    }


    private sealed class Class1166
    {
        public Star197 gclass197_0;
        public GameRace gclass21_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.BodyClass == PlanetBodyClass.Asteroid && gclass1_0.StarData == this.gclass197_0 &&
                   !gclass1_0.IsFixedBody;
        }

        internal string method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_78(this.gclass21_0);
        }
    }


    private sealed class Class1167
    {
        public Star197 gclass197_0;
        public GameRace gclass21_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.BodyClass == PlanetBodyClass.Comet && gclass1_0.StarData == this.gclass197_0;
        }

        internal string method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_78(this.gclass21_0);
        }
    }

    public StarSystem SystemData;
    public Star197 OrbitingStar;
    public StellarType StellarType;
    public GClass0 gclass0_0;
    public GEnum30 genum30_0;
    public int StarID;
    public int SystemID;
    public int ProtoStar;
    public int Component;
    public int OrbitingComponent;
    public string Name;
    public double XCoord;
    public double YCoord;
    public double OrbitalDistance;
    public double Bearing;
    public double Luminosity;
    public double OrbitalPeriod;
    public double double_6;
    public double Eccentricity;
    public double EccentricityDirection;
    public double double_9;
    public double double_10;
    public double double_11;
    public double CurrentOrbitalSpeed;
    public double MeanOrbitalSpeed;
    public double double_14;
    public double double_15;
    public double DistanceToOrbitCentre;
    public double DistanceToParent;
    public bool bool_0;
    public bool bool_1;
    public int int_5;
    public int int_6;
    public Decimal decimal_0;
    public Decimal decimal_1;
    public Decimal decimal_2;
    public Decimal decimal_3;

    public Star197(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            this.MeanOrbitalSpeed = Math.Sqrt(2.0 / this.OrbitalDistance - 1.0 / this.OrbitalDistance);
            this.CurrentOrbitalSpeed = this.MeanOrbitalSpeed;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3441);
        }
    }

    public void method_1()
    {
        try
        {
            if (this.Bearing != 0.0 && this.Bearing != 180.0)
            {
                if (this.Bearing != 90.0 && this.Bearing != 270.0)
                {
                    double num = 360.0 - this.Bearing + 90.0;
                    if (num < 0.0)
                        num += 360.0;
                    if (num >= 360.0)
                        num -= 360.0;
                    this.DistanceToOrbitCentre = this.OrbitalDistance * this.double_9 /
                                                 Math.Sqrt(Math.Pow(this.double_9 * Math.Cos(num * Math.PI / 180.0),
                                                     2.0) + Math.Pow(
                                                     this.OrbitalDistance * Math.Sin(num * Math.PI / 180.0), 2.0));
                }
                else
                    this.DistanceToOrbitCentre = this.OrbitalDistance;
            }
            else
                this.DistanceToOrbitCentre = this.double_9;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3439);
        }
    }

    public void method_2()
    {
        try
        {
            this.CurrentOrbitalSpeed = Math.Sqrt(2.0 / this.DistanceToParent - 1.0 / this.OrbitalDistance);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3438);
        }
    }

    public void method_3(
        StellarType gclass217_1,
        double double_18,
        double double_19,
        int int_7,
        double double_20,
        double double_21)
    {
        try
        {
            this.StellarType = gclass217_1;
            this.OrbitingComponent = int_7;
            this.OrbitalDistance = double_18;
            this.Eccentricity = double_20;
            this.EccentricityDirection = double_21;
            this.Luminosity = this.StellarType.Luminosity;
            this.double_10 = this.OrbitalDistance * (1.0 - this.Eccentricity);
            this.double_11 = this.OrbitalDistance * (1.0 + this.Eccentricity);
            this.double_9 = this.OrbitalDistance * Math.Sqrt(1.0 - this.Eccentricity * this.Eccentricity);
            this.method_0();
            if (double_19 < 0.0 || double_19 > 360.0)
                double_19 = 0.0;
            this.Bearing = double_19;
            if (this.OrbitingComponent > 0)
            {
                this.OrbitingStar = this.gclass0_0.StarDictionary.Values.FirstOrDefault<Star197>(gclass197_1 =>
                    gclass197_1.SystemData == this.SystemData && gclass197_1.Component == this.OrbitingComponent);
                this.OrbitalPeriod =
                    Math.Pow(
                        Math.Pow(this.OrbitalDistance, 3.0) /
                        (this.StellarType.Mass + this.OrbitingStar.StellarType.Mass), 0.5);
            }

            foreach (SystemBodyData gclass1 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(gclass1_0 => gclass1_0.StarData == this)
                         .ToList<SystemBodyData>())
                gclass1.method_8(false);
            this.gclass0_0.method_414(60.0, this.SystemData, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2933);
        }
    }

    public void method_4()
    {
        try
        {
            int num1 = 1;
            foreach (SystemBodyData gclass1_1 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(gclass1_0 =>
                             gclass1_0.StarData == this && gclass1_0.BodyClass == PlanetBodyClass.Planet)
                         .OrderBy<SystemBodyData, double>(gclass1_0 => gclass1_0.OrbitalDistance)
                         .ToList<SystemBodyData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Star197.Class1163 class1163 = new Star197.Class1163()
                {
                    gclass1_0 = gclass1_1
                };
                // ISSUE: reference to a compiler-generated field
                class1163.gclass1_0.PlanetNumber = num1;
                int num2 = 1;
                // ISSUE: reference to a compiler-generated method
                foreach (SystemBodyData gclass1_2 in this.gclass0_0.SystemBodyRecordDic.Values
                             .Where<SystemBodyData>(class1163.method_0)
                             .OrderBy<SystemBodyData, double>(gclass1_0 => gclass1_0.OrbitalDistance)
                             .ToList<SystemBodyData>())
                {
                    // ISSUE: reference to a compiler-generated field
                    gclass1_2.PlanetNumber = class1163.gclass1_0.PlanetNumber;
                    gclass1_2.OrbitNumber = num2;
                    ++num2;
                }

                ++num1;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2934);
        }
    }

    public void method_5(Graphics graphics_0, GClass222 gclass222_0, RacialSystemSurvey gclass202_0)
    {
        try
        {
            if (gclass202_0.Race.chkStarOrbits == CheckState.Unchecked || this.OrbitingComponent == 0)
                return;
            if (this.gclass0_0.StarEccentricity == 0)
            {
                GClass221 gclass221_1 = new GClass221();
                double num = this.OrbitalDistance * AuroraUtils.double_14 / gclass202_0.KmPerPixel;
                if (num < AuroraUtils.int_61)
                    return;
                GClass221 gclass221_2 = this.OrbitingStar.method_20(gclass202_0);
                if (gclass221_2.double_0 < 0.0 || gclass221_2.double_0 > this.gclass0_0.double_0 ||
                    gclass221_2.double_1 < 0.0 || gclass221_2.double_1 > this.gclass0_0.double_1)
                    return;
                double x = gclass221_2.double_0 - num;
                double y = gclass221_2.double_1 - num;
                Pen pen = new Pen(AuroraUtils.color_5);
                graphics_0.DrawEllipse(pen, (int)x, (int)y, (int)(num * 2.0), (int)(num * 2.0));
                pen.Dispose();
            }
            else
            {
                GClass221 gclass221 = this.OrbitingStar.method_20(gclass202_0);
                if (gclass221.double_0 < 0.0 || gclass221.double_0 > this.gclass0_0.double_0 ||
                    gclass221.double_1 < 0.0 || gclass221.double_1 > this.gclass0_0.double_1)
                    return;
                float width = (float)(this.OrbitalDistance * AuroraUtils.double_14 * 2.0 / gclass202_0.KmPerPixel);
                if (width < (double)AuroraUtils.int_61)
                    return;
                float height = (float)(this.double_9 * AuroraUtils.double_14 * 2.0 / gclass202_0.KmPerPixel);
                float num = (float)(this.double_10 * AuroraUtils.double_14 / gclass202_0.KmPerPixel);
                float x = (float)gclass221.double_0 - num;
                float y = (float)(gclass221.double_1 - height / 2.0);
                Matrix matrix = new Matrix();
                matrix.RotateAt((float)this.EccentricityDirection,
                    new PointF((float)gclass221.double_0, (float)gclass221.double_1));
                graphics_0.Transform = matrix;
                RectangleF rect = new RectangleF(x, y, width, height);
                Pen pen = new Pen(AuroraUtils.color_5);
                graphics_0.DrawEllipse(pen, rect);
                graphics_0.ResetTransform();
                pen.Dispose();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2935);
        }
    }

    public bool method_6(int int_7)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Star197.Class1164 class1164 = new Star197.Class1164();
        // ISSUE: reference to a compiler-generated field
        class1164.gclass197_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1164.int_0 = int_7;
        try
        {
            if (this.Component == 1)
                return true;
            // ISSUE: reference to a compiler-generated method
            int num = this.gclass0_0.LagrangePoints.Values.Where<LagrangePoint>(class1164.method_0).Count<LagrangePoint>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            return this.OrbitingComponent == 1
                ? this.double_11 < class1164.int_0 || num > 0 && this.gclass0_0.LagrangePoints.Values
                    .Where<LagrangePoint>(class1164.method_1).Count<LagrangePoint>() > 0
                : this.OrbitingStar.double_11 < class1164.int_0 || num > 0 && this.gclass0_0.LagrangePoints.Values
                    .Where<LagrangePoint>(class1164.method_2).Count<LagrangePoint>() > 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2936);
            return false;
        }
    }

    public void method_7(double double_18)
    {
        try
        {
            if (this.genum30_0 == GEnum30.const_0)
                return;
            double num = this.Luminosity / 100.0 * double_18;
            if (this.genum30_0 == GEnum30.const_1)
                this.Luminosity += num;
            else if (this.genum30_0 == GEnum30.const_2)
                this.Luminosity += num * 2.0;
            else if (this.genum30_0 == GEnum30.const_3)
                this.Luminosity += num * 3.0;
            if (this.genum30_0 == GEnum30.const_4)
                this.Luminosity -= num;
            else if (this.genum30_0 == GEnum30.const_5)
                this.Luminosity -= num * 2.0;
            else if (this.genum30_0 == GEnum30.const_6)
                this.Luminosity -= num * 3.0;
            this.method_8();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2937);
        }
    }

    public void method_8()
    {
        try
        {
            foreach (SystemBodyData gclass1 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(gclass1_0 =>
                             gclass1_0.StarData == this && gclass1_0.BodyClass != PlanetBodyClass.Moon)
                         .ToList<SystemBodyData>())
            {
                gclass1.BaseTemp = byte.MaxValue /
                                   Math.Pow(gclass1.DistanceToParent / Math.Pow(gclass1.StarData.Luminosity, 0.5), 0.5);
                if (gclass1.BaseTemp < 4.0)
                    gclass1.BaseTemp = 4.0;
                gclass1.method_27();
                gclass1.method_35();
                gclass1.method_32();
            }

            foreach (SystemBodyData gclass1 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(gclass1_0 =>
                             gclass1_0.StarData == this && gclass1_0.BodyClass == PlanetBodyClass.Moon)
                         .ToList<SystemBodyData>())
            {
                gclass1.BaseTemp = gclass1.ParentBodyData.BaseTemp;
                gclass1.method_27();
                gclass1.method_35();
                gclass1.method_32();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2938);
        }
    }

    public void method_9()
    {
        try
        {
            if (this.OrbitalDistance == 0.0)
                this.OrbitalDistance = 0.1;
            this.OrbitalPeriod =
                Math.Pow(
                    Math.Pow(this.OrbitalDistance, 3.0) /
                    (this.StellarType.Mass + this.OrbitingStar.StellarType.Mass), 0.5);
            this.Bearing = AuroraUtils.GetRandomInteger(360);
            GClass221 gclass221 = this.gclass0_0.method_592(this.OrbitingStar.XCoord, this.OrbitingStar.YCoord,
                this.OrbitalDistance * AuroraUtils.double_14, this.Bearing);
            this.XCoord = gclass221.double_0;
            this.YCoord = gclass221.double_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2939);
        }
    }

    public void method_10(double double_18)
    {
        try
        {
            this.OrbitalPeriod =
                Math.Pow(
                    Math.Pow(this.OrbitalDistance, 3.0) /
                    (this.StellarType.Mass + this.OrbitingStar.StellarType.Mass), 0.5);
            GClass221 gclass221 = this.gclass0_0.method_592(this.OrbitingStar.XCoord, this.OrbitingStar.YCoord,
                this.OrbitalDistance * AuroraUtils.double_14, double_18);
            this.XCoord = gclass221.double_0;
            this.YCoord = gclass221.double_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2940);
        }
    }

    public void method_11()
    {
        try
        {
            if (this.StellarType.AgeRangeID > SystemAgeID.const_11)
                return;
            if (!this.gclass0_0.SystemAgeDictionary.ContainsKey(this.StellarType.AgeRangeID))
            {
                var formatText = UITextHelper.GetLocalizedStringFor(LocalizedText.StarTypeRangeIDNotFoundErrMsg);
                int num1 = (int)MessageBox.Show(
                    string.Format(formatText, AuroraUtils.smethod_82(this.StellarType.AgeRangeID)));
            }
            else
            {
                int key = 1;
                foreach (double num2 in this.gclass0_0.SystemAgeDictionary[this.StellarType.AgeRangeID].AgeDic
                             .OrderBy<KeyValuePair<int, double>, int>(keyValuePair_0 => keyValuePair_0.Key)
                             .ToDictionary<KeyValuePair<int, double>, int, double>(keyValuePair_0 => keyValuePair_0.Key,
                                 keyValuePair_0 => keyValuePair_0.Value).Values)
                {
                    if (num2 < this.SystemData.Age)
                        ++key;
                    else
                        break;
                }

                if (key > 10)
                {
                    var formatText = UITextHelper.GetLocalizedStringFor(LocalizedText.LuminosityKeyCountErrMsg);
                    int num3 = (int)MessageBox.Show(string.Format(formatText, key));
                    key = 10;
                }

                this.Luminosity *= this.gclass0_0.SystemAgeDictionary[this.StellarType.AgeRangeID].LuminosityDic[key];
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2941);
        }
    }

    public void method_12()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Star197.Class1165 class1165 = new Star197.Class1165();
            // ISSUE: reference to a compiler-generated field
            class1165.int_0 = 0;
            switch (this.StellarType.AgeRangeID)
            {
                case SystemAgeID.const_0:
                    this.SystemData.Age = 0.1;
                    break;
                case SystemAgeID.const_12:
                    this.SystemData.Age = this.gclass0_0.SystemAgeDictionary[
                        this.gclass0_0.StarTypeDictionary.Values
                            .Where<StellarType>(gclass217_1 =>
                                gclass217_1.SizeID == 5 && gclass217_1.Mass <= this.StellarType.Mass)
                            .OrderByDescending<StellarType, double>(gclass217_0 => gclass217_0.Mass)
                            .FirstOrDefault<StellarType>().AgeRangeID].TotalLife * 1.1;
                    break;
                case SystemAgeID.const_13:
                    this.SystemData.Age = this.gclass0_0.SystemAgeDictionary[
                        this.gclass0_0.StarTypeDictionary.Values
                            .Where<StellarType>(gclass217_1 =>
                                gclass217_1.SizeID == 5 && gclass217_1.Mass <= this.StellarType.Mass)
                            .OrderByDescending<StellarType, double>(gclass217_0 => gclass217_0.Mass)
                            .FirstOrDefault<StellarType>().AgeRangeID].TotalLife * 1.2;
                    break;
                case SystemAgeID.const_14:
                    this.SystemData.Age = 0.05;
                    break;
                default:
                    // ISSUE: reference to a compiler-generated field
                    class1165.int_0 = AuroraUtils.GetRandomInteger(10);
                    // ISSUE: reference to a compiler-generated field
                    this.SystemData.Age = this.gclass0_0.SystemAgeDictionary[this.StellarType.AgeRangeID]
                        .AgeDic[class1165.int_0];
                    // ISSUE: reference to a compiler-generated field
                    this.Luminosity *= this.gclass0_0.SystemAgeDictionary[this.StellarType.AgeRangeID]
                        .LuminosityDic[class1165.int_0];
                    break;
            }

            // ISSUE: reference to a compiler-generated field
            class1165.int_0 = AuroraUtils.GetRandomInteger(10) + AuroraUtils.GetRandomInteger(10) +
                              (int)Math.Round(this.SystemData.Age);
            // ISSUE: reference to a compiler-generated method
            this.SystemData.AbundanceModifier = this.gclass0_0.SystemAbundanceDictionary.Values.Where<SystemAbundance>(class1165.method_0)
                .OrderBy<SystemAbundance, int>(gclass199_0 => gclass199_0.MaxChance).FirstOrDefault<SystemAbundance>().Modifier;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2942);
        }
    }

    public void method_13(double double_18)
    {
        try
        {
            this.method_1();
            double_18 -= 90.0;
            if (double_18 < 0.0)
                double_18 += 360.0;
            if (this.Eccentricity == 0.0)
            {
                double num = double_18 * (Math.PI / 180.0);
                this.XCoord = this.OrbitingStar.XCoord + this.OrbitalDistance * AuroraUtils.double_14 * Math.Cos(num);
                this.YCoord = this.OrbitingStar.YCoord + this.OrbitalDistance * AuroraUtils.double_14 * Math.Sin(num);
            }
            else if (this.EccentricityDirection == 0.0)
            {
                double num1 = double_18 * (Math.PI / 180.0);
                double num2 = this.OrbitingStar.XCoord +
                              (this.OrbitalDistance - this.double_10) * AuroraUtils.double_14;
                double double1 = this.OrbitingStar.YCoord;
                this.XCoord = num2 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Cos(num1);
                this.YCoord = double1 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Sin(num1);
            }
            else
            {
                this.method_14();
                double_18 += this.EccentricityDirection;
                if (double_18 >= 360.0)
                    double_18 -= 360.0;
                double num = double_18 * (Math.PI / 180.0);
                this.XCoord = this.double_14 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Cos(num);
                this.YCoord = this.double_15 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Sin(num);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2943);
        }
    }

    public void method_14()
    {
        try
        {
            double double8 = this.EccentricityDirection;
            if (double8 < 0.0)
                double8 += 360.0;
            double num1 = double8 * (Math.PI / 180.0);
            double num2 = (this.double_11 - this.double_10) / 2.0;
            this.double_14 = this.OrbitingStar.XCoord + num2 * AuroraUtils.double_14 * Math.Cos(num1);
            this.double_15 = this.OrbitingStar.YCoord + num2 * AuroraUtils.double_14 * Math.Sin(num1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2943);
        }
    }

    public List<SystemBodyData> method_15()
    {
        try
        {
            return this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(gclass1_0 =>
                    gclass1_0.BodyClass == PlanetBodyClass.Planet && gclass1_0.StarData == this &&
                    !gclass1_0.IsFixedBody).ToList<SystemBodyData>()
                .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.PlanetNumber)
                .ToList<SystemBodyData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2944);
            return new List<SystemBodyData>();
        }
    }

    public List<SystemBodyData> method_16(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Star197.Class1166 class1166 = new Star197.Class1166();
        // ISSUE: reference to a compiler-generated field
        class1166.gclass197_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1166.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.SystemBodyRecordDic.Values.Where<SystemBodyData>(class1166.method_0)
                .ToList<SystemBodyData>().OrderBy<SystemBodyData, string>(class1166.method_1)
                .ToList<SystemBodyData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2945);
            return new List<SystemBodyData>();
        }
    }

    public List<SystemBodyData> method_17(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Star197.Class1167 class1167 = new Star197.Class1167();
        // ISSUE: reference to a compiler-generated field
        class1167.gclass197_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1167.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.SystemBodyRecordDic.Values.Where<SystemBodyData>(class1167.method_0)
                .ToList<SystemBodyData>().OrderBy<SystemBodyData, string>(class1167.method_1)
                .ToList<SystemBodyData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2946);
            return new List<SystemBodyData>();
        }
    }

    public string method_18(GameRace gclass21_0)
    {
        try
        {
            if (!gclass21_0.RacialSystemDictionary.ContainsKey(this.SystemID))
                return "System Not Found";
            return this.SystemData.Stars == 1
                ? gclass21_0.RacialSystemDictionary[this.SystemID].Name
                : string.Format("{0}-{1}", gclass21_0.RacialSystemDictionary[this.SystemID].Name, this.method_19());
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2947);
            return "";
        }
    }

    public string method_19()
    {
        try
        {
            return ((char)(this.Component + 64 /*0x40*/)).ToString();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2948);
            return "";
        }
    }

    public GClass221 method_20(RacialSystemSurvey gclass202_0)
    {
        try
        {
            return new GClass221()
            {
                double_0 = (this.XCoord + gclass202_0.double_3) / gclass202_0.KmPerPixel + this.gclass0_0.double_4,
                double_1 = (this.YCoord + gclass202_0.double_4) / gclass202_0.KmPerPixel + this.gclass0_0.double_5
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2949);
            return new GClass221(0.0, 0.0);
        }
    }

    public void method_21(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0)
    {
        try
        {
            int int6 = this.StellarType.Red;
            int int7 = this.StellarType.Green;
            int int8 = this.StellarType.Blue;
            int green = int7;
            int blue = int8;
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(int6, green, blue));
            GClass221 gclass221 = new GClass221();
            string str = string.Format("{0} {1}", this.method_18(gclass202_0.Race),
                this.StellarType.StellarDescription);
            int num1 = AuroraUtils.int_61;
            int num2 = (int)(AuroraUtils.double_31 * this.StellarType.Radius / gclass202_0.KmPerPixel);
            if (num2 > num1)
                num1 = num2;
            double x = gclass222_0.double_2 - num1 / 2.0;
            double y = gclass222_0.double_3 - num1 / 2.0;
            graphics_0.FillEllipse(solidBrush, (float)x, (float)y, num1, num1);
            if (gclass202_0.Race.chkStarNames == CheckState.Unchecked)
                return;
            solidBrush.Color = Color.LimeGreen;
            double num3 = graphics_0.MeasureString(str, font_0).Width / 2.0;
            gclass221.double_0 = gclass222_0.double_2 - num3;
            gclass221.double_1 = gclass222_0.double_3 + AuroraUtils.int_61;
            graphics_0.DrawString(str, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2950);
        }
    }
}