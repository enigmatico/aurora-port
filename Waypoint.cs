// Decompiled with JetBrains decompiler
// Type: GClass214
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class Waypoint
{
    private GClass0 gclass0_0;
    public StarSystem System;
    public SystemBodyData OrbitBody;
    public JumpPoint JumpPoint;
    public GameRace Race;
    public WayPointType WaypointType;
    public int WaypointID;
    public int OrbitBodyID;
    public int FleetID;
    public int Number;
    public bool bool_0;
    public Decimal CreationTime;
    public double Xcor;
    public double Ycor;

    public string Name { get; set; }

    public Waypoint(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public int method_0()
    {
        try
        {
            return this.JumpPoint == null ? 0 : this.JumpPoint.WarpPointID;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3000);
            return 0;
        }
    }

    public bool method_1(double double_2, List<Waypoint> list_0)
    {
        try
        {
            foreach (Waypoint gclass214 in list_0)
            {
                if (gclass214 != this && this.gclass0_0.GetDistanceToNearestGClass212(this.System, gclass214.Xcor,
                        gclass214.Ycor, this.Xcor, this.Ycor) < double_2)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3001);
            return false;
        }
    }

    public string method_2(bool bool_1)
    {
        try
        {
            if (this.Name != "")
                return this.Name;
            string str1 = "Waypoint #";
            if (this.WaypointType == WayPointType.POI)
                str1 = "Point of Interest #";
            else if (this.WaypointType == WayPointType.UrgentPOI)
                str1 = "Urgent POI #";
            else if (this.WaypointType == WayPointType.TransitPOI)
                str1 = "Transit POI #";
            else if (this.WaypointType == WayPointType.FleetTraining)
                str1 = "Training Waypoint #";
            else if (this.WaypointType == WayPointType.Rendezvous)
                str1 = "Rendezvous Waypoint #";
            else if (this.WaypointType == WayPointType.Temporary)
                str1 = "Temporary #";
            string str2 = str1 + this.Number.ToString();
            if (bool_1 && this.OrbitBody != null)
                str2 = string.Format((string)"{0}  ({1})", (object)str2, (object)this.OrbitBody.method_78(this.Race));
            return str2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3002);
            return "error";
        }
    }

    public void method_3(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_4)
    {
        try
        {
            if (gclass202_0.Race.chkWaypoint == CheckState.Unchecked)
                return;
            SolidBrush solidBrush = new SolidBrush(Color.Violet);
            string s = this.method_2(false);
            double x = gclass222_0.double_2 - AuroraUtils.int_60 / 2.0;
            double y = gclass222_0.double_3 - AuroraUtils.int_60 / 2.0;
            if (int_4 == 0)
                graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_60, AuroraUtils.int_60);
            GClass221 gclass221 = new GClass221();
            gclass221.double_0 = x + AuroraUtils.int_60 + 5.0;
            gclass221.double_1 = y - 3.0 - int_4 * 15;
            graphics_0.DrawString(s, font_0, solidBrush, (float)gclass221.double_0, (float)gclass221.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3003);
        }
    }
}