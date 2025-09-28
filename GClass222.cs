// Decompiled with JetBrains decompiler
// Type: GClass222
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass222
{
    public Dictionary<double, int> dictionary_0 = new Dictionary<double, int>();
    public List<Star197> list_0 = new List<Star197>();
    public List<SystemBodyData> list_1 = new List<SystemBodyData>();
    public List<JumpPoint> list_2 = new List<JumpPoint>();
    public List<Waypoint> list_3 = new List<Waypoint>();
    public List<FleetData> list_4 = new List<FleetData>();
    public List<MissileSalvo> list_5 = new List<MissileSalvo>();
    public List<Wreck> list_6 = new List<Wreck>();
    public List<GClass59> list_7 = new List<GClass59>();
    public List<Contact> list_8 = new List<Contact>();
    public List<ShipData> list_9 = new List<ShipData>();
    public List<MissileSalvo> list_10 = new List<MissileSalvo>();
    public List<PopulationData> list_11 = new List<PopulationData>();
    public List<LagrangePoint> list_12 = new List<LagrangePoint>();
    public List<SurveyLocation> list_13 = new List<SurveyLocation>();
    public List<FCTMassDriverPacket126> list_14 = new List<FCTMassDriverPacket126>();
    public List<PopulationData> list_15 = new List<PopulationData>();
    public GClass211 gclass211_0;
    public double double_0;
    public double double_1;
    public double double_2;
    public double double_3;
    public int int_0;
    public int int_1;
    public bool bool_0;
    public bool bool_1;

    public object method_0()
    {
        try
        {
            if (this.list_4.Count > 0)
                return this.list_4.OrderByDescending<FleetData, Decimal>(gclass85_0 =>
                        gclass85_0.method_176().Sum<ShipData>(gclass40_0 => gclass40_0.gclass22_0.Size))
                    .FirstOrDefault<FleetData>();
            if (this.list_1.Count > 0)
                return this.list_1.OrderByDescending<SystemBodyData, double>(gclass1_0 => gclass1_0.Mass)
                    .FirstOrDefault<SystemBodyData>();
            return this.list_5.Count > 0
                ? this.list_5.OrderByDescending<MissileSalvo, Decimal>(gclass132_0 => gclass132_0.RaceMissile.Size)
                    .FirstOrDefault<MissileSalvo>()
                : (object)null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3063);
            return "error";
        }
    }

    public SystemBodyData method_1()
    {
        try
        {
            return this.list_1.Count > 0
                ? this.list_1.OrderByDescending<SystemBodyData, double>(gclass1_0 => gclass1_0.Mass)
                    .FirstOrDefault<SystemBodyData>()
                : null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3453);
            return null;
        }
    }
}