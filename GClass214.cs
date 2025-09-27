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
public class GClass214
{
    private GClass0 gclass0_0;
    public SystemData200 gclass200_0;
    public SystemBodyData gclass1_0;
    public JumpPoint120 gclass120_0;
    public FCTRaceRecordC21 gclass21_0;
    public WayPointType wayPointType_0;
    public int int_0;
    public int int_1;
    public int int_2;
    public int int_3;
    public bool bool_0;
    public Decimal decimal_0;
    public double double_0;
    public double double_1;

    public string Name { get; set; }

    public GClass214(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public int method_0()
    {
        try
        {
            return this.gclass120_0 == null ? 0 : this.gclass120_0.WarpPointID;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3000);
            return 0;
        }
    }

    public bool method_1(double double_2, List<GClass214> list_0)
    {
        try
        {
            foreach (GClass214 gclass214 in list_0)
            {
                if (gclass214 != this && this.gclass0_0.GetDistanceToNearestGClass212(this.gclass200_0, gclass214.double_0,
                        gclass214.double_1, this.double_0, this.double_1) < double_2)
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
            if (this.wayPointType_0 == WayPointType.POI)
                str1 = "Point of Interest #";
            else if (this.wayPointType_0 == WayPointType.UrgentPOI)
                str1 = "Urgent POI #";
            else if (this.wayPointType_0 == WayPointType.TransitPOI)
                str1 = "Transit POI #";
            else if (this.wayPointType_0 == WayPointType.FleetTraining)
                str1 = "Training Waypoint #";
            else if (this.wayPointType_0 == WayPointType.Rendezvous)
                str1 = "Rendezvous Waypoint #";
            else if (this.wayPointType_0 == WayPointType.Temporary)
                str1 = "Temporary #";
            string str2 = str1 + this.int_3.ToString();
            if (bool_1 && this.gclass1_0 != null)
                str2 = $"{str2}  ({this.gclass1_0.method_78(this.gclass21_0)})";
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