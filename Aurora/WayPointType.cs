// Decompiled with JetBrains decompiler
// Type: Aurora.WayPointType
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum WayPointType
{
    Normal,
    [Description("Point of Interest")] POI,
    [Description("Urgent POI")] UrgentPOI,
    [Description("Transit POI")] TransitPOI,
    MarkedForDeletion,
    [Description("Fleet Training")] FleetTraining,
    Rendezvous,
    Named,
    Temporary,
    [Description("Deep Space Location")] DeepSpaceLocation,
    [Description("Fleet Waypoint")] FleetWaypoint,
}