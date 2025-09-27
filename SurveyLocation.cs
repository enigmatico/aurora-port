// Decompiled with JetBrains decompiler
// Type: GClass213
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class SurveyLocation
{
    /// <summary>
    /// Contains Race IDs as raw but meaning is not sure
    /// </summary>
    public List<int> RaceIDs = new List<int>();
    public int SurveyLocationID;
    public int SystemID;
    public int LocationNumber;
    public double XCoord;
    public double YCoord;

    public void method_0(GameRace gclass21_0)
    {
        try
        {
            if (this.RaceIDs.Contains(gclass21_0.RaceID))
                return;
            this.RaceIDs.Add(gclass21_0.RaceID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2998);
        }
    }

    public void method_1(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0)
    {
        try
        {
            if (gclass202_0.Race.chkHideSL == CheckState.Checked &&
                this.RaceIDs.Contains(gclass202_0.Race.RaceID))
                return;
            SolidBrush solidBrush = new SolidBrush(Color.Wheat);
            Pen pen = new Pen(solidBrush);
            GClass221 gclass221 = new GClass221();
            string str = "SL " + this.LocationNumber.ToString();
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2.0;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2.0;
            if (this.RaceIDs.Contains(gclass202_0.Race.RaceID))
                graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_61 * 0.8f,
                    AuroraUtils.int_61 * 0.8f);
            else
                graphics_0.DrawEllipse(pen, (float)x, (float)y, AuroraUtils.int_61 * 0.8f, AuroraUtils.int_61 * 0.8f);
            solidBrush.Color = Color.LimeGreen;
            double num = graphics_0.MeasureString(str, font_0).Width / 2.0;
            gclass221.double_0 = gclass222_0.double_2 - num;
            gclass221.double_1 = gclass222_0.double_3 + AuroraUtils.int_61;
            graphics_0.DrawString(str, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2999);
        }
    }
}