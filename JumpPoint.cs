// Decompiled with JetBrains decompiler
// Type: GClass120
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class JumpPoint
{
    private sealed class Class1072
    {
        public GameRace gclass21_0;
        public JumpPoint gclass120_0;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass21_0;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.MoveActionType.MoveActionType == MoveActionType.StabilizeJumpPoint &&
                   gclass139_0.DestinationID == this.gclass120_0.WarpPointID;
        }
    }

    private sealed class Class1073
    {
        public RacialSystemSurvey gclass202_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass202_0.ActualSystem &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass202_0.Race.RaceID);
        }

        internal bool method_1(JumpPoint gclass120_0)
        {
            return gclass120_0.RacialJumpPointSurveys[this.gclass202_0.Race.RaceID].Charted == 1;
        }
    }

    public Dictionary<int, RaceJumpPointSurvey> RacialJumpPointSurveys = new Dictionary<int, RaceJumpPointSurvey>();
    public StarSystem SystemData;
    public JumpPoint LinkedJumpPoint;
    public int WarpPointID;
    public int Bearing;
    public int JumpGateStrength;
    public int JumpGateRaceID;
    public int LinkedWarpPointID;
    public int NumJumpPointsInSameSystem;
    public double Distance;
    public double XCoord;
    public double YCoord;
    public double double_3;
    public bool bool_0;
    private GClass0 gclass0_0;

    public JumpPoint(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public bool method_0(GameRace gclass21_0)
    {
        try
        {
            return this.RacialJumpPointSurveys.ContainsKey(gclass21_0.RaceID) && this.RacialJumpPointSurveys[gclass21_0.RaceID].Explored == 1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1958);
            return false;
        }
    }

    public bool method_1(GameRace gclass21_0)
    {
        try
        {
            return this.RacialJumpPointSurveys.ContainsKey(gclass21_0.RaceID) && this.RacialJumpPointSurveys[gclass21_0.RaceID].Charted == 1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1959);
            return false;
        }
    }

    public bool method_2(GameRace gclass21_0)
    {
        try
        {
            return this.RacialJumpPointSurveys.ContainsKey(gclass21_0.RaceID) &&
                   this.RacialJumpPointSurveys[gclass21_0.RaceID].Charted == 1 && this.RacialJumpPointSurveys[gclass21_0.RaceID].Explored == 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1960);
            return false;
        }
    }

    public bool method_3(GameRace gclass21_0)
    {
        try
        {
            return this.RacialJumpPointSurveys.ContainsKey(gclass21_0.RaceID) &&
                   this.RacialJumpPointSurveys[gclass21_0.RaceID].Charted == 1 && this.JumpGateStrength == 0 &&
                   !this.method_5(gclass21_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1961);
            return false;
        }
    }

    public bool method_4(GameRace gclass21_0)
    {
        try
        {
            return this.RacialJumpPointSurveys.ContainsKey(gclass21_0.RaceID) &&
                   this.RacialJumpPointSurveys[gclass21_0.RaceID].Explored == 1 && this.JumpGateStrength == 0 &&
                   !this.method_5(gclass21_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1962);
            return false;
        }
    }

    public bool method_5(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        JumpPoint.Class1072 class1072 = new JumpPoint.Class1072();
        // ISSUE: reference to a compiler-generated field
        class1072.gclass21_0 = gclass21_0;
        // ISSUE: reference to a compiler-generated field
        class1072.gclass120_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1072.method_0)
                .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .FirstOrDefault<MoveOrder>(class1072.method_1) != null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1963);
            return false;
        }
    }

    public void method_6(
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
            string str = this.method_7(gclass202_0);
            double x1 = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y1 = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            graphics_0.FillEllipse(solidBrush, (float)x1, (float)y1, AuroraUtils.int_61, AuroraUtils.int_61);
            if (this.JumpGateStrength > 0)
            {
                double x2 = gclass222_0.double_2 - AuroraUtils.int_64 / 2;
                double y2 = gclass222_0.double_3 - AuroraUtils.int_64 / 2;
                if (this.JumpGateRaceID == gclass202_0.Race.RaceID)
                {
                    Pen pen = new Pen(Color.Orange);
                    graphics_0.DrawRectangle(pen, (float)x2, (float)y2, AuroraUtils.int_64, AuroraUtils.int_64);
                }
                else
                {
                    Pen pen = new Pen(Color.Red);
                    graphics_0.DrawRectangle(pen, (float)x2, (float)y2, AuroraUtils.int_64, AuroraUtils.int_64);
                }
            }

            GClass221 gclass221 = new GClass221();
            double num = graphics_0.MeasureString(str, font_0).Width / 2.0;
            gclass221.double_0 = gclass222_0.double_2 - num;
            gclass221.double_1 = gclass222_0.double_3 + (AuroraUtils.int_61 + 2);
            graphics_0.DrawString(str, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1964);
        }
    }

    public string method_7(RacialSystemSurvey gclass202_0)
    {
        try
        {
            string str1 = $"JP{this.method_9(gclass202_0).ToString()}: ";
            string str2 = "Unex";
            return this.RacialJumpPointSurveys[gclass202_0.Race.RaceID].Explored == 1 &&
                   gclass202_0.Race.RacialSystemDictionary.ContainsKey(this.LinkedJumpPoint.SystemData.SystemID)
                ? str1 + gclass202_0.Race.RacialSystemDictionary[this.LinkedJumpPoint.SystemData.SystemID].Name
                : str1 + str2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1965);
            return "";
        }
    }

    public string method_8(RacialSystemSurvey gclass202_0)
    {
        try
        {
            string str1 = $"JP{this.method_9(gclass202_0).ToString()} (";
            string str2 = "Unex)";
            return this.RacialJumpPointSurveys[gclass202_0.Race.RaceID].Explored == 1 &&
                   gclass202_0.Race.RacialSystemDictionary.ContainsKey(this.LinkedJumpPoint.SystemData.SystemID)
                ? $"{str1}{gclass202_0.Race.RacialSystemDictionary[this.LinkedJumpPoint.SystemData.SystemID].Name})"
                : str1 + str2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1966);
            return "";
        }
    }

    public int method_9(RacialSystemSurvey gclass202_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        JumpPoint.Class1073 class1073 = new JumpPoint.Class1073();
        // ISSUE: reference to a compiler-generated field
        class1073.gclass202_0 = gclass202_0;
        try
        {
            int num = 1;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            foreach (JumpPoint gclass120 in this.gclass0_0.JumpPointDictionary.Values
                         .Where<JumpPoint>(class1073.method_0).Where<JumpPoint>(class1073.method_1)
                         .OrderBy<JumpPoint, double>(gclass120_0 => gclass120_0.Distance).ToList<JumpPoint>())
            {
                if (gclass120 == this)
                    return num;
                ++num;
            }

            return 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1967);
            return 0;
        }
    }

    public GClass221 method_10(GameRace gclass21_0)
    {
        try
        {
            return this.LinkedJumpPoint != null && this.RacialJumpPointSurveys.ContainsKey(gclass21_0.RaceID) &&
                   this.RacialJumpPointSurveys[gclass21_0.RaceID].Explored == 1
                ? new GClass221(this.LinkedJumpPoint.XCoord, this.LinkedJumpPoint.YCoord)
                : null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1968);
            return null;
        }
    }
}