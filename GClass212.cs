// Decompiled with JetBrains decompiler
// Type: GClass212
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
// TODO : This one is almost certainly lagrange point
public class GClass212
{
    private GClass0 gclass0_0;
    public SystemData200 gclass200_0;
    public Star197 gclass197_0;
    public SystemBodyData gclass1_0;
    public int int_0;
    public int int_1;
    public double double_0;
    public double double_1;
    public double double_2;
    public double double_3;
    public double double_4;
    public double double_5;

    public GClass212(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            if (this.double_3 != 0.0 && this.double_3 != 180.0)
            {
                if (this.double_3 != 90.0 && this.double_3 != 270.0)
                {
                    double num = 360.0 - this.double_3 + 90.0;
                    if (num < 0.0)
                        num += 360.0;
                    if (num == 360.0)
                        num = 0.0;
                    if (num > 360.0)
                        num -= 360.0;
                    this.double_4 = this.gclass1_0.OrbitalDistance * this.gclass1_0.double_26 / Math.Sqrt(
                        Math.Pow(this.gclass1_0.double_26 * Math.Cos(num * Math.PI / 180.0), 2.0) +
                        Math.Pow(this.gclass1_0.OrbitalDistance * Math.Sin(num * Math.PI / 180.0), 2.0));
                }
                else
                    this.double_4 = this.gclass1_0.OrbitalDistance;
            }
            else
                this.double_4 = this.gclass1_0.double_26;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3449);
        }
    }

    public void method_1(double double_6)
    {
        try
        {
            this.method_0();
            double_6 -= 90.0;
            if (double_6 < 0.0)
                double_6 += 360.0;
            if (this.gclass1_0.BodyClass == PlanetBodyClass.Planet)
            {
                if (this.gclass1_0.Eccentricity == 0.0)
                {
                    double num = double_6 * (Math.PI / 180.0);
                    this.double_0 = this.gclass197_0.XCoord +
                                    this.gclass1_0.OrbitalDistance * AuroraUtils.double_14 * Math.Cos(num);
                    this.double_1 = this.gclass197_0.YCoord +
                                    this.gclass1_0.OrbitalDistance * AuroraUtils.double_14 * Math.Sin(num);
                }
                else if (this.gclass1_0.EccentricityDirection == 0.0)
                {
                    double num1 = double_6 * (Math.PI / 180.0);
                    double num2 = this.gclass197_0.XCoord +
                                  (this.gclass1_0.OrbitalDistance - this.gclass1_0.double_27) * AuroraUtils.double_14;
                    double double1 = this.gclass197_0.YCoord;
                    this.double_0 = num2 + this.double_4 * AuroraUtils.double_14 * Math.Cos(num1);
                    this.double_1 = double1 + this.double_4 * AuroraUtils.double_14 * Math.Sin(num1);
                }
                else
                {
                    double_6 += this.gclass1_0.EccentricityDirection;
                    if (double_6 >= 360.0)
                        double_6 -= 360.0;
                    double num = double_6 * (Math.PI / 180.0);
                    this.double_0 = this.gclass1_0.double_29 + this.double_4 * AuroraUtils.double_14 * Math.Cos(num);
                    this.double_1 = this.gclass1_0.double_30 + this.double_4 * AuroraUtils.double_14 * Math.Sin(num);
                }
            }
            else
            {
                if (this.gclass1_0.BodyClass != PlanetBodyClass.Moon)
                    return;
                double num = double_6 * (Math.PI / 180.0);
                this.double_0 = this.gclass1_0.ParentBodyData.XCoordinate + this.gclass1_0.OrbitalDistance * Math.Cos(num);
                this.double_1 = this.gclass1_0.ParentBodyData.YCoordinate + this.gclass1_0.OrbitalDistance * Math.Sin(num);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2994);
        }
    }

    public void method_2(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0)
    {
        try
        {
            if (gclass202_0.Race.chkWP == CheckState.Unchecked)
                return;
            SolidBrush solidBrush = new SolidBrush(Color.Orange);
            string str = "LP" + this.int_1.ToString();
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2.0;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2.0;
            graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            GClass221 gclass221 = new GClass221();
            double num = graphics_0.MeasureString(str, font_0).Width / 2.0;
            gclass221.double_0 = gclass222_0.double_2 - num;
            gclass221.double_1 = gclass222_0.double_3 + (AuroraUtils.int_61 + 2);
            graphics_0.DrawString(str, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2995);
        }
    }

    public string method_3(FCTRaceRecordC21 gclass21_0)
    {
        try
        {
            return $"LP{this.int_1.ToString()}  ({this.gclass1_0.method_78(gclass21_0)})";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2996);
            return "Error";
        }
    }

    public void method_4(ListView listView_0, FCTRaceRecordC21 gclass21_0)
    {
        try
        {
            foreach (GClass212 object_1 in this.gclass200_0.method_29())
            {
                if (object_1 != this)
                    this.gclass0_0.method_598(listView_0,
                        $"LP{object_1.int_1.ToString()}  ({object_1.gclass1_0.method_78(gclass21_0)})", "", object_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2997);
        }
    }
}