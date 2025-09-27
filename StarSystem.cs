// Decompiled with JetBrains decompiler
// Type: GClass200
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
public class StarSystem
{
    [CompilerGenerated]
    private sealed class Class1168
    {
        public RacialSystemSurvey gclass202_0;
        public StarSystem gclass200_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass202_0.Race;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.StartSystem == this.gclass202_0 &&
                   gclass139_0.MoveActionType.MoveActionType == MoveActionType.SalvageWreck;
        }

        internal bool method_2(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Wrecks.ContainsKey(gclass139_0.DestinationID);
        }

        internal Wreck method_3(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Wrecks[gclass139_0.DestinationID];
        }

        internal bool method_4(Wreck gclass233_0)
        {
            return gclass233_0.System == this.gclass200_0;
        }

        internal double method_5(Wreck gclass233_0)
        {
            return this.gclass200_0.method_3(this.double_0, this.double_1, gclass233_0.Xcor, gclass233_0.Ycor);
        }
    }

    [CompilerGenerated]
    private sealed class Class1169
    {
        public RacialSystemSurvey gclass202_0;
        public StarSystem gclass200_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass202_0.Race;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.StartSystem == this.gclass202_0 &&
                   gclass139_0.MoveActionType.MoveActionType == MoveActionType.SalvageInstallations;
        }

        internal bool method_2(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Populations.ContainsKey(gclass139_0.DestinationID);
        }

        internal PopulationData method_3(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Populations[gclass139_0.DestinationID];
        }

        internal bool method_4(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem == this.gclass200_0 && gclass146_0.dictionary_0.Count > 0;
        }

        internal double method_5(PopulationData gclass146_0)
        {
            return this.gclass200_0.method_3(this.double_0, this.double_1, gclass146_0.method_87(),
                gclass146_0.method_88());
        }
    }

    [CompilerGenerated]
    private sealed class Class1170
    {
        public RacialSystemSurvey gclass202_0;
        public StarSystem gclass200_0;
        public AuroraContactStatus auroraContactStatus_0;
        public AuroraContactType auroraContactType_0;
        public bool bool_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass202_0.Race;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.StartSystem == this.gclass202_0 &&
                   gclass139_0.MoveActionType.MoveActionType == MoveActionType.FollowTarget && gclass139_0.DestinationType == DestinationType.const_4;
        }

        internal bool method_2(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Contacts.ContainsKey(gclass139_0.DestinationID);
        }

        internal Contact method_3(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Contacts[gclass139_0.DestinationID];
        }

        internal bool method_4(Contact gclass65_0)
        {
            if (gclass65_0.System != this.gclass200_0 || gclass65_0.method_5() > this.auroraContactStatus_0 ||
                gclass65_0.ContactType != this.auroraContactType_0)
                return false;
            return !this.bool_0 || gclass65_0.ContactMethod == ContactDetectMethod.const_0;
        }

        internal double method_5(Contact gclass65_0)
        {
            return this.gclass200_0.method_3(this.double_0, this.double_1, gclass65_0.Xcor, gclass65_0.Ycor);
        }
    }

    [CompilerGenerated]
    private sealed class Class1171
    {
        public RacialSystemSurvey gclass202_0;
        public StarSystem gclass200_0;
        public WayPointType wayPointType_0;
        public int int_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass202_0.Race;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.StartSystem == this.gclass202_0 &&
                   gclass139_0.MoveActionType.MoveActionType == MoveActionType.MoveTo && gclass139_0.DestinationType == DestinationType.const_3;
        }

        internal bool method_2(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Waypoints.ContainsKey(gclass139_0.DestinationID);
        }

        internal Waypoint method_3(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.Waypoints[gclass139_0.DestinationID];
        }

        internal bool method_4(Waypoint gclass214_0)
        {
            return gclass214_0.System == this.gclass200_0 && gclass214_0.WaypointType == this.wayPointType_0 &&
                   gclass214_0.Race == this.gclass202_0.Race && gclass214_0.FleetID == this.int_0;
        }

        internal double method_5(Waypoint gclass214_0)
        {
            return this.gclass200_0.method_3(this.double_0, this.double_1, gclass214_0.Xcor, gclass214_0.Ycor);
        }
    }

    [CompilerGenerated]
    private sealed class Class1172
    {
        public RacialSystemSurvey gclass202_0;
        public StarSystem gclass200_0;
        public double double_0;
        public double double_1;

        internal bool method_0(FleetData gclass85_0)
        {
            return gclass85_0.Race == this.gclass202_0.Race;
        }

        internal bool method_1(MoveOrder gclass139_0)
        {
            return gclass139_0.StartSystem == this.gclass202_0 &&
                   gclass139_0.MoveActionType.MoveActionType == MoveActionType.RescueSurvivors;
        }

        internal bool method_2(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.dictionary_30.ContainsKey(gclass139_0.DestinationID);
        }

        internal GClass59 method_3(MoveOrder gclass139_0)
        {
            return this.gclass200_0.gclass0_0.dictionary_30[gclass139_0.DestinationID];
        }

        internal bool method_4(GClass59 gclass59_0)
        {
            return gclass59_0.gclass200_0 == this.gclass200_0;
        }

        internal double method_5(GClass59 gclass59_0)
        {
            return this.gclass200_0.method_3(this.double_0, this.double_1, gclass59_0.double_0, gclass59_0.double_1);
        }
    }

    [CompilerGenerated]
    private sealed class Class1173
    {
        public StarSystem gclass200_0;
        public double double_0;
        public GameRace gclass21_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_77(this.gclass21_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1174
    {
        public TechSystem gclass164_0;
        public StarSystem.Class1173 class1173_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.Radius * 2.0 < (double)this.gclass164_0.decimal_0 &&
                   gclass1_0.XCoordinate < this.class1173_0.double_0 &&
                   gclass1_0.YCoordinate < this.class1173_0.double_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1175
    {
        public GameRace gclass21_0;
        public StarSystem gclass200_0;
        public Decimal decimal_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.Race == this.gclass21_0 &&
                   gclass146_0.gclass202_0.ActualSystem == this.gclass200_0 && gclass146_0.decimal_30 >= this.decimal_0;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.SystemData == this.gclass200_0;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.method_77(this.gclass21_0);
        }
    }

    [CompilerGenerated]
    private sealed class Class1176
    {
        public JumpPoint gclass120_0;

        internal bool method_0(JumpPoint gclass120_1)
        {
            return gclass120_1.LinkedJumpPoint == this.gclass120_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1177
    {
        public StarSystem gclass200_0;
        public GameRace gclass21_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.SystemData == this.gclass200_0 &&
                   gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_1(JumpPoint gclass120_0)
        {
            return gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].Explored == 1 && gclass120_0.LinkedJumpPoint != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class1178
    {
        public GameRace gclass21_0;

        internal bool method_0(JumpPoint gclass120_0)
        {
            return gclass120_0.RacialJumpPointSurveys.ContainsKey(this.gclass21_0.RaceID);
        }

        internal bool method_1(JumpPoint gclass120_0)
        {
            return gclass120_0.RacialJumpPointSurveys[this.gclass21_0.RaceID].Explored == 1 && gclass120_0.LinkedJumpPoint != null;
        }
    }

    [CompilerGenerated]
    private sealed class Class1179
    {
        public StarSystem gclass200_0;
        public GameRace gclass21_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.gclass202_0.ActualSystem == this.gclass200_0 && gclass146_0.Race == this.gclass21_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1180
    {
        public Star197 gclass197_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.SystemBodyData.BodyClass == PlanetBodyClass.Asteroid &&
                   gclass146_0.SystemBodyData.StarData == this.gclass197_0 && gclass146_0.SystemBodyData.IsFixedBody;
        }
    }

    private GClass0 gclass0_0;
    public Dictionary<int, SurveyLocation> SurveyLocationDictionary = new Dictionary<int, SurveyLocation>();
    public Dictionary<int, JumpPoint> dictionary_1 = new Dictionary<int, JumpPoint>();
    public Dictionary<int, JumpPoint> dictionary_2 = new Dictionary<int, JumpPoint>();
    public List<Star197> list_0 = new List<Star197>();
    public DIMKnownSystemsData198 KnownSystemData;
    public int SystemID;
    public int SystemNumber;
    public int AbundanceModifier;
    public int Stars;
    public int JumpPointSurveyPoints;
    public int SystemTypeID;
    public int DustDensity;
    public int NoSensorChecks;
    public int int_8;
    public int int_9;
    public int int_10;
    public double Age;
    public double SupernovaForce;
    public double SupernovaElapsedTime;
    public double double_3;
    public double double_4;
    public double double_5;
    public double double_6;
    public bool IsSolSystem;
    public StarSystem gclass200_0;
    public StarSystem gclass200_1;
    public JumpPoint gclass120_0;
    public int int_11;
    public double double_7;
    public int int_12;
    public bool bool_1;
    public int int_13;

    public StarSystem(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0()
    {
        try
        {
            int num = 1;
            foreach (SystemBodyData gclass1 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(gclass1_0 =>
                             gclass1_0.SystemData == this && gclass1_0.BodyClass == PlanetBodyClass.Asteroid)
                         .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.StarData.Component)
                         .ThenBy<SystemBodyData, double>(gclass1_0 => gclass1_0.OrbitalDistance)
                         .ToList<SystemBodyData>())
            {
                gclass1.Name = "Asteroid #" + num.ToString();
                gclass1.OrbitNumber = num;
                gclass1.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.ExtendedUpdate;
                ++num;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3955);
        }
    }

    public void method_1(double double_8)
    {
        try
        {
            this.gclass0_0.method_545(this, true);
            this.SupernovaElapsedTime = 1.0;
            this.SupernovaForce = double_8;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3586);
        }
    }

    public GClass210 method_2()
    {
        try
        {
            return this.gclass0_0.dictionary_16.Values.FirstOrDefault<GClass210>(gclass210_0 =>
                gclass210_0.gclass200_0 == this);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3414);
            return null;
        }
    }

    public double method_3(double double_8, double double_9, double double_10, double double_11)
    {
        try
        {
            double num1 = this.gclass0_0.GetDistanceBetween(double_8, double_9, double_10, double_11);
            List<LagrangePoint> list = this.gclass0_0.LagrangePoints.Values
                .Where<LagrangePoint>(gclass212_0 => gclass212_0.System == this).ToList<LagrangePoint>();
            if (list.Count < 2)
                return num1;
            List<LagrangePoint> gclass212List = new List<LagrangePoint>(list);
            foreach (LagrangePoint gclass212_1 in list)
            {
                double num2 = this.gclass0_0.GetDistanceBetween(double_8, double_9, gclass212_1.XCor, gclass212_1.Ycor);
                if (num2 < num1)
                {
                    foreach (LagrangePoint gclass212_2 in gclass212List)
                    {
                        if (gclass212_2 != gclass212_1)
                        {
                            double num3 = this.gclass0_0.GetDistanceBetween(gclass212_2.XCor, gclass212_2.Ycor,
                                double_10, double_11);
                            if (num2 + num3 < num1)
                                num1 = num2 + num3;
                        }
                    }
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2959);
            return 0.0;
        }
    }

    public JumpPoint method_4()
    {
        try
        {
            return this.dictionary_1
                .OrderByDescending<KeyValuePair<int, JumpPoint>, int>(keyValuePair_0 => keyValuePair_0.Key)
                .Select<KeyValuePair<int, JumpPoint>, JumpPoint>(keyValuePair_0 => keyValuePair_0.Value)
                .FirstOrDefault<JumpPoint>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2960);
            return null;
        }
    }

    public Wreck method_5(double double_8, double double_9, RacialSystemSurvey gclass202_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1168 class1168 = new StarSystem.Class1168();
        // ISSUE: reference to a compiler-generated field
        class1168.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class1168.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1168.double_0 = double_8;
        // ISSUE: reference to a compiler-generated field
        class1168.double_1 = double_9;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<Wreck> list = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1168.method_0)
                .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .Where<MoveOrder>(class1168.method_1).Where<MoveOrder>(class1168.method_2)
                .Select<MoveOrder, Wreck>(class1168.method_3).ToList<Wreck>();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.Wrecks.Values.Where<Wreck>(class1168.method_4).Except<Wreck>(list)
                .OrderBy<Wreck, double>(class1168.method_5).FirstOrDefault<Wreck>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2961);
            return null;
        }
    }

    public PopulationData method_6(double double_8, double double_9, RacialSystemSurvey gclass202_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1169 class1169 = new StarSystem.Class1169();
        // ISSUE: reference to a compiler-generated field
        class1169.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class1169.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1169.double_0 = double_8;
        // ISSUE: reference to a compiler-generated field
        class1169.double_1 = double_9;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<PopulationData> list = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1169.method_0)
                .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .Where<MoveOrder>(class1169.method_1).Where<MoveOrder>(class1169.method_2)
                .Select<MoveOrder, PopulationData>(class1169.method_3).ToList<PopulationData>();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.Populations.Values.Where<PopulationData>(class1169.method_4).Except<PopulationData>(list)
                .OrderBy<PopulationData, double>(class1169.method_5).FirstOrDefault<PopulationData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2962);
            return null;
        }
    }

    public Contact method_7(
        double double_8,
        double double_9,
        RacialSystemSurvey gclass202_0,
        AuroraContactStatus auroraContactStatus_0,
        AuroraContactType auroraContactType_0,
        bool bool_2,
        bool bool_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1170 class1170 = new StarSystem.Class1170();
        // ISSUE: reference to a compiler-generated field
        class1170.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class1170.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1170.auroraContactStatus_0 = auroraContactStatus_0;
        // ISSUE: reference to a compiler-generated field
        class1170.auroraContactType_0 = auroraContactType_0;
        // ISSUE: reference to a compiler-generated field
        class1170.bool_0 = bool_2;
        // ISSUE: reference to a compiler-generated field
        class1170.double_0 = double_8;
        // ISSUE: reference to a compiler-generated field
        class1170.double_1 = double_9;
        try
        {
            List<Contact> second = new List<Contact>();
            if (!bool_3)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                second = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1170.method_0)
                    .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                    .Where<MoveOrder>(class1170.method_1).Where<MoveOrder>(class1170.method_2)
                    .Select<MoveOrder, Contact>(class1170.method_3).ToList<Contact>();
            }

            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.Contacts.Values.Where<Contact>(class1170.method_4).Except<Contact>(second)
                .OrderBy<Contact, double>(class1170.method_5).FirstOrDefault<Contact>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2963);
            return null;
        }
    }

    public Waypoint method_8(
        double double_8,
        double double_9,
        RacialSystemSurvey gclass202_0,
        WayPointType wayPointType_0,
        int int_14)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1171 class1171 = new StarSystem.Class1171();
        // ISSUE: reference to a compiler-generated field
        class1171.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class1171.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1171.wayPointType_0 = wayPointType_0;
        // ISSUE: reference to a compiler-generated field
        class1171.int_0 = int_14;
        // ISSUE: reference to a compiler-generated field
        class1171.double_0 = double_8;
        // ISSUE: reference to a compiler-generated field
        class1171.double_1 = double_9;
        try
        {
            List<Waypoint> second = new List<Waypoint>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class1171.wayPointType_0 == WayPointType.POI || class1171.wayPointType_0 == WayPointType.UrgentPOI ||
                class1171.wayPointType_0 == WayPointType.TransitPOI)
            {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                second = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1171.method_0)
                    .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                    .Where<MoveOrder>(class1171.method_1).Where<MoveOrder>(class1171.method_2)
                    .Select<MoveOrder, Waypoint>(class1171.method_3).ToList<Waypoint>();
            }

            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.Waypoints.Values.Where<Waypoint>(class1171.method_4).Except<Waypoint>(second)
                .OrderBy<Waypoint, double>(class1171.method_5).FirstOrDefault<Waypoint>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2964);
            return null;
        }
    }

    public GClass59 method_9(double double_8, double double_9, RacialSystemSurvey gclass202_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1172 class1172 = new StarSystem.Class1172();
        // ISSUE: reference to a compiler-generated field
        class1172.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class1172.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1172.double_0 = double_8;
        // ISSUE: reference to a compiler-generated field
        class1172.double_1 = double_9;
        try
        {
            List<GClass59> gclass59List = new List<GClass59>();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<GClass59> list = this.gclass0_0.FleetDictionary.Values.Where<FleetData>(class1172.method_0)
                .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                .Where<MoveOrder>(class1172.method_1).Where<MoveOrder>(class1172.method_2)
                .Select<MoveOrder, GClass59>(class1172.method_3).ToList<GClass59>();
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.dictionary_30.Values.Where<GClass59>(class1172.method_4).Except<GClass59>(list)
                .OrderBy<GClass59, double>(class1172.method_5).FirstOrDefault<GClass59>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2964);
            return null;
        }
    }

    public SystemBodyData method_10(double double_8, GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1173 class1173 = new StarSystem.Class1173();
        // ISSUE: reference to a compiler-generated field
        class1173.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1173.double_0 = double_8;
        // ISSUE: reference to a compiler-generated field
        class1173.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            StarSystem.Class1174 class1174 = new StarSystem.Class1174()
            {
                class1173_0 = class1173
            };
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class1174.gclass164_0 = class1174.class1173_0.gclass21_0.method_387(TechType.MaximumOrbitalMiningDiameter);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list = this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(class1174.class1173_0.method_0)
                .Where<SystemBodyData>(class1174.method_0)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.MineralDeposits.ContainsKey(AuroraElement.Duranium))
                .Where<SystemBodyData>(class1174.class1173_0.method_1).ToList<SystemBodyData>();
            return list.Count == 0
                ? null
                : list.OrderByDescending<SystemBodyData, Decimal>(gclass1_0 =>
                        gclass1_0.MineralDeposits.Values.Sum<MineralDeposit>(gclass124_0 => gclass124_0.Accessibility))
                    .FirstOrDefault<SystemBodyData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2965);
            return null;
        }
    }

    public SystemBodyData method_11(GameRace gclass21_0, Decimal decimal_0, bool bool_2)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1175 class1175 = new StarSystem.Class1175();
        // ISSUE: reference to a compiler-generated field
        class1175.gclass21_0 = gclass21_0;
        // ISSUE: reference to a compiler-generated field
        class1175.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1175.decimal_0 = decimal_0;
        try
        {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            if (class1175.decimal_0 > 0M && this.gclass0_0.Populations.Values.Where<PopulationData>(class1175.method_0)
                    .Sum<PopulationData>(gclass146_0 => gclass146_0.decimal_30) < 10M)
                return null;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            List<SystemBodyData> list = this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(class1175.method_1)
                .Where<SystemBodyData>(gclass1_0 =>
                    gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                    gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.MineralDeposits.ContainsKey(AuroraElement.Sorium))
                .Where<SystemBodyData>(class1175.method_2).ToList<SystemBodyData>();
            if (list.Count == 0)
                return null;
            if (bool_2)
            {
                // ISSUE: reference to a compiler-generated field
                list = list.Except<SystemBodyData>(class1175.gclass21_0.BannedSystemBodies)
                    .ToList<SystemBodyData>();
                if (list.Count == 0)
                    return null;
            }

            return list.OrderByDescending<SystemBodyData, Decimal>(gclass1_0 =>
                gclass1_0.MineralDeposits[AuroraElement.Sorium].Accessibility).FirstOrDefault<SystemBodyData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2966);
            return null;
        }
    }

    public double method_12()
    {
        try
        {
            return this.double_6 <= 1.0 ? Math.Sqrt(this.double_6) : Math.Pow(this.double_6, 1.0 / 3.0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3573);
            return 1.0;
        }
    }

    public void method_13()
    {
        try
        {
            foreach (SystemBodyData gclass1_1 in this.method_20())
            {
                gclass1_1.MineralDeposits.Clear();
                if (gclass1_1.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                    gclass1_1.BodyTypeId != AuroraSystemBodyType.Superjovian)
                {
                    if (gclass1_1.BodyTypeId == AuroraSystemBodyType.Comet)
                        this.gclass0_0.method_670(gclass1_1);
                    else
                        this.gclass0_0.method_672(gclass1_1, null);
                }
                else
                    this.gclass0_0.method_669(gclass1_1, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2967);
        }
    }

    public JumpPoint method_14(bool bool_2)
    {
        try
        {
            JumpPoint gclass120_2 = new JumpPoint(this.gclass0_0);
            JumpPoint gclass120_0_1 = new JumpPoint(this.gclass0_0);
            gclass120_0_1.WarpPointID = this.gclass0_0.method_26(GEnum0.const_8);
            gclass120_0_1.SystemData = this;
            double num1 = this.method_12();
            gclass120_0_1.Bearing = AuroraUtils.GetRandomInteger(360);
            gclass120_0_1.Distance = AuroraUtils.GetRandomInteger(4000) / 100.0 * num1;
            if (bool_2 && gclass120_0_1.Distance > 30.0)
                gclass120_0_1.Distance = AuroraUtils.GetRandomInteger(4000) / 100.0 * num1;
            GClass221 gclass221 = this.gclass0_0.method_592(0.0, 0.0, gclass120_0_1.Distance * AuroraUtils.double_14,
                gclass120_0_1.Bearing);
            gclass120_0_1.XCoord = gclass221.double_0;
            gclass120_0_1.YCoord = gclass221.double_1;
            if (this.gclass0_0.AutoJumpGates == 1)
                gclass120_0_1.JumpGateStrength = 1000;
            this.gclass0_0.JumpPointDictionary.Add(gclass120_0_1.WarpPointID, gclass120_0_1);
            int num2 = 1;
            foreach (JumpPoint gclass120_3 in this.gclass0_0.JumpPointDictionary.Values
                         .Where<JumpPoint>(gclass120_1 => gclass120_1.SystemData == this)
                         .OrderBy<JumpPoint, double>(gclass120_0 => gclass120_0.Distance).ToList<JumpPoint>())
            {
                gclass120_3.NumJumpPointsInSameSystem = num2;
                ++num2;
            }

            foreach (GameRace gclass21 in this.gclass0_0.GameRaces.Values
                         .SelectMany<GameRace, RacialSystemSurvey>(gclass21_0 => gclass21_0.RacialSystemDictionary.Values)
                         .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.ActualSystem == this)
                         .Select<RacialSystemSurvey, GameRace>(gclass202_0 => gclass202_0.Race)
                         .ToList<GameRace>())
                gclass21.method_264(gclass120_0_1, 0, 0);
            return gclass120_0_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2968);
            return null;
        }
    }

    public void method_15(JumpPoint gclass120_1)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1176 class1176 = new StarSystem.Class1176();
        // ISSUE: reference to a compiler-generated field
        class1176.gclass120_0 = gclass120_1;
        try
        {
            // ISSUE: reference to a compiler-generated method
            JumpPoint gclass120 = this.gclass0_0.JumpPointDictionary.Values.Where<JumpPoint>(class1176.method_0)
                .FirstOrDefault<JumpPoint>();
            if (gclass120 != null)
            {
                gclass120.LinkedJumpPoint = null;
                gclass120.LinkedWarpPointID = 0;
                foreach (RaceJumpPointSurvey gclass203 in gclass120.RacialJumpPointSurveys.Values)
                    gclass203.Explored = 0;
            }

            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.JumpPointDictionary.Remove(class1176.gclass120_0.WarpPointID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2969);
        }
    }

    public List<StarSystem> method_16(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1177 class1177 = new StarSystem.Class1177();
        // ISSUE: reference to a compiler-generated field
        class1177.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1177.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.JumpPointDictionary.Values.Where<JumpPoint>(class1177.method_0)
                .Where<JumpPoint>(class1177.method_1)
                .Select<JumpPoint, StarSystem>(gclass120_0 => gclass120_0.LinkedJumpPoint.SystemData)
                .ToList<StarSystem>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2970);
            return null;
        }
    }

    public List<StarSystem> method_17()
    {
        try
        {
            return this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint>(gclass120_1 =>
                    gclass120_1.SystemData == this && gclass120_1.LinkedJumpPoint != null)
                .Select<JumpPoint, StarSystem>(gclass120_0 => gclass120_0.LinkedJumpPoint.SystemData)
                .ToList<StarSystem>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2971);
            return null;
        }
    }

    public List<JumpPoint> method_18(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1178 class1178 = new StarSystem.Class1178();
        // ISSUE: reference to a compiler-generated field
        class1178.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.JumpPointDictionary.Values.Where<JumpPoint>(class1178.method_0)
                .Where<JumpPoint>(class1178.method_1)
                .OrderBy<JumpPoint, double>(gclass120_0 => gclass120_0.Distance).ToList<JumpPoint>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2972);
            return null;
        }
    }

    public Dictionary<int, SystemBodyData> method_19()
    {
        try
        {
            return this.gclass0_0.SystemBodyRecordDic
                .Where<KeyValuePair<int, SystemBodyData>>(keyValuePair_0 => keyValuePair_0.Key == this.SystemID)
                .ToDictionary<KeyValuePair<int, SystemBodyData>, int, SystemBodyData>(
                    keyValuePair_0 => keyValuePair_0.Key, keyValuePair_0 => keyValuePair_0.Value);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2973);
            return new Dictionary<int, SystemBodyData>();
        }
    }

    public List<SystemBodyData> method_20()
    {
        try
        {
            return this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.SystemData == this)
                .ToList<SystemBodyData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2974);
            return new List<SystemBodyData>();
        }
    }

    public int method_21()
    {
        try
        {
            return this.gclass0_0.SystemBodyRecordDic.Values.Count<SystemBodyData>(gclass1_0 =>
                gclass1_0.SystemData == this && gclass1_0.BodyClass != PlanetBodyClass.Comet);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2975);
            return 0;
        }
    }

    public string method_22(double double_8, double double_9, RacialSystemSurvey gclass202_0)
    {
        try
        {
            double num1 = -1.0;
            double num2 = -1.0;
            SystemBodyData gclass1 = this.method_23(double_8, double_9);
            Star197 gclass197 = this.method_24(double_8, double_9);
            JumpPoint gclass120 = this.method_25(double_8, double_9, gclass202_0.Race);
            if (gclass1 != null)
                num1 = Math.Sqrt(Math.Pow(gclass1.XCoordinate - double_8, 2.0) +
                                 Math.Pow(gclass1.YCoordinate - double_9, 2.0));
            if (gclass120 != null)
                num2 = Math.Sqrt(
                    Math.Pow(gclass120.XCoord - double_8, 2.0) + Math.Pow(gclass120.YCoord - double_9, 2.0));
            double num3 = Math.Sqrt(Math.Pow(gclass197.XCoord - double_8, 2.0) +
                                    Math.Pow(gclass197.YCoord - double_9, 2.0));
            if (num1 > -1.0 && (num1 <= num2 || num2 == -1.0) && num1 <= num3)
            {
                Decimal num4 = (Decimal)Math.Round(this.gclass0_0.method_591(double_8, double_9, gclass1.XCoordinate,
                    gclass1.YCoordinate));
                return num1 < 10000000.0
                    ? $"{Math.Round(num1 / 1000000.0, 1).ToString()}m km from {gclass1.method_78(gclass202_0.Race)} at bearing {num4.ToString()}°"
                    : $"{Math.Round(num1 / 1000000.0).ToString()}m km from {gclass1.method_78(gclass202_0.Race)} at bearing {num4.ToString()}°";
            }

            if (num2 > -1.0 && (num2 <= num1 || num1 == -1.0) && num2 <= num3)
            {
                Decimal num5 =
                    (Decimal)Math.Round(this.gclass0_0.method_591(double_8, double_9, gclass120.XCoord,
                        gclass120.YCoord));
                return num1 < 10000000.0
                    ? $"{Math.Round(num2 / 1000000.0, 1).ToString()}m km from {gclass120.method_8(gclass202_0)} at bearing {num5.ToString()}°"
                    : $"{Math.Round(num2 / 1000000.0).ToString()}m km from {gclass120.method_8(gclass202_0)} at bearing {num5.ToString()}°";
            }

            Decimal num6 =
                (Decimal)Math.Round(this.gclass0_0.method_591(double_8, double_9, gclass197.XCoord, gclass197.YCoord));
            return num1 < 10000000.0
                ? $"{Math.Round(num3 / 1000000.0, 1).ToString()}m km from {gclass197.method_18(gclass202_0.Race)} at bearing {num6.ToString()}°"
                : $"{Math.Round(num3 / 1000000.0).ToString()}m km from {gclass197.method_18(gclass202_0.Race)} at bearing {num6.ToString()}°";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2976);
            return "";
        }
    }

    public SystemBodyData method_23(double double_8, double double_9)
    {
        try
        {
            SystemBodyData gclass1_1 = null;
            double num1 = -1.0;
            foreach (SystemBodyData gclass1_2 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(gclass1_0 =>
                             gclass1_0.SystemData == this && gclass1_0.BodyClass == PlanetBodyClass.Planet)
                         .ToList<SystemBodyData>())
            {
                double num2 = Math.Sqrt(Math.Pow(gclass1_2.XCoordinate - double_8, 2.0) +
                                        Math.Pow(gclass1_2.YCoordinate - double_9, 2.0));
                if (num1 == -1.0 || num2 < num1)
                {
                    num1 = num2;
                    gclass1_1 = gclass1_2;
                }
            }

            return gclass1_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2977);
            return null;
        }
    }

    public Star197 method_24(double double_8, double double_9)
    {
        try
        {
            Star197 gclass197_1 = null;
            double num1 = -1.0;
            foreach (Star197 gclass197_2 in this.method_26())
            {
                double num2 = Math.Sqrt(Math.Pow(gclass197_2.XCoord - double_8, 2.0) +
                                        Math.Pow(gclass197_2.YCoord - double_9, 2.0));
                if (num1 == -1.0 || num2 < num1)
                {
                    num1 = num2;
                    gclass197_1 = gclass197_2;
                }
            }

            return gclass197_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2978);
            return null;
        }
    }

    public JumpPoint method_25(double double_8, double double_9, GameRace gclass21_0)
    {
        try
        {
            JumpPoint gclass120_1 = null;
            double num1 = -1.0;
            foreach (JumpPoint gclass120_2 in this.method_27())
            {
                if (gclass120_2.RacialJumpPointSurveys.ContainsKey(gclass21_0.RaceID) &&
                    gclass120_2.RacialJumpPointSurveys[gclass21_0.RaceID].Charted == 1)
                {
                    double num2 = Math.Sqrt(Math.Pow(gclass120_2.XCoord - double_8, 2.0) +
                                            Math.Pow(gclass120_2.YCoord - double_9, 2.0));
                    if (num1 == -1.0 || num2 < num1)
                    {
                        num1 = num2;
                        gclass120_1 = gclass120_2;
                    }
                }
            }

            return gclass120_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2979);
            return null;
        }
    }

    public List<Star197> method_26()
    {
        try
        {
            return this.gclass0_0.StarDictionary.Values.Where<Star197>(gclass197_0 => gclass197_0.SystemData == this)
                .OrderBy<Star197, int>(gclass197_0 => gclass197_0.Component).ToList<Star197>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2980);
            return new List<Star197>();
        }
    }

    public List<JumpPoint> method_27()
    {
        try
        {
            return this.gclass0_0.JumpPointDictionary.Values
                .Where<JumpPoint>(gclass120_1 => gclass120_1.SystemData == this)
                .OrderBy<JumpPoint, double>(gclass120_0 => gclass120_0.Distance).ToList<JumpPoint>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2981);
            return new List<JumpPoint>();
        }
    }

    public void method_28()
    {
        try
        {
            int num = 1;
            foreach (LagrangePoint gclass212 in this.gclass0_0.LagrangePoints.Values
                         .Where<LagrangePoint>(gclass212_0 => gclass212_0.Star.SystemData == this)
                         .OrderBy<LagrangePoint, int>(gclass212_0 => gclass212_0.Star.Component)
                         .ThenBy<LagrangePoint, double>(gclass212_0 => gclass212_0.Distance).ToList<LagrangePoint>())
            {
                gclass212.int_1 = num;
                ++num;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2982);
        }
    }

    public List<LagrangePoint> method_29()
    {
        try
        {
            int num = 1;
            List<LagrangePoint> list = this.gclass0_0.LagrangePoints.Values
                .Where<LagrangePoint>(gclass212_0 => gclass212_0.Star.SystemData == this)
                .OrderBy<LagrangePoint, int>(gclass212_0 => gclass212_0.Star.Component)
                .ThenBy<LagrangePoint, double>(gclass212_0 => gclass212_0.Distance).ToList<LagrangePoint>();
            foreach (LagrangePoint gclass212 in list)
            {
                gclass212.int_1 = num;
                ++num;
            }

            return list;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2983);
            return null;
        }
    }

    public List<FleetData> method_30()
    {
        try
        {
            return this.gclass0_0.FleetDictionary.Values
                .Where<FleetData>(gclass85_0 => gclass85_0.System.ActualSystem == this)
                .OrderBy<FleetData, string>(gclass85_0 => gclass85_0.FleetName).ToList<FleetData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2984);
            return new List<FleetData>();
        }
    }

    public List<MissileSalvo> method_31()
    {
        try
        {
            return this.gclass0_0.MissileSalvoes.Values.Where<MissileSalvo>(gclass132_0 => gclass132_0.System == this)
                .OrderBy<MissileSalvo, string>(gclass132_0 => gclass132_0.string_0).ToList<MissileSalvo>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2985);
            return new List<MissileSalvo>();
        }
    }

    public List<PopulationData> method_32()
    {
        try
        {
            return this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.gclass202_0.ActualSystem == this)
                .OrderBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName).ToList<PopulationData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2986);
            return new List<PopulationData>();
        }
    }

    public List<PopulationData> method_33(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        StarSystem.Class1179 class1179 = new StarSystem.Class1179();
        // ISSUE: reference to a compiler-generated field
        class1179.gclass200_0 = this;
        // ISSUE: reference to a compiler-generated field
        class1179.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.Populations.Values.Where<PopulationData>(class1179.method_0)
                .OrderBy<PopulationData, string>(gclass146_0 => gclass146_0.PopName).ToList<PopulationData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2987);
            return new List<PopulationData>();
        }
    }

    public List<Contact> method_34()
    {
        try
        {
            return this.gclass0_0.Contacts.Values.Where<Contact>(gclass65_0 => gclass65_0.System == this)
                .OrderBy<Contact, string>(gclass65_0 => gclass65_0.ContactName).ToList<Contact>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2988);
            return new List<Contact>();
        }
    }

    public List<Wreck> method_35()
    {
        try
        {
            return this.gclass0_0.Wrecks.Values.Where<Wreck>(gclass233_0 => gclass233_0.System == this)
                .OrderBy<Wreck, string>(gclass233_0 => gclass233_0.ViewingName).ToList<Wreck>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2989);
            return new List<Wreck>();
        }
    }

    public List<GClass59> method_36()
    {
        try
        {
            return this.gclass0_0.dictionary_30.Values.Where<GClass59>(gclass59_0 => gclass59_0.gclass200_0 == this)
                .OrderBy<GClass59, string>(gclass59_0 => gclass59_0.string_0).ToList<GClass59>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2990);
            return new List<GClass59>();
        }
    }

    public int GetNumberOfJumpPoints()
    {
        try
        {
            return this.gclass0_0.JumpPointDictionary.Values.Count<JumpPoint>(gclass120_1 =>
                gclass120_1.SystemData == this);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2991);
            return 0;
        }
    }

    public TreeNode method_38(RacialSystemSurvey gclass202_0)
    {
        try
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = gclass202_0.Name;
            treeNode.Tag = this;
            treeNode.Expand();
            List<Star197> gclass197List = this.method_26();
            foreach (Star197 gclass197 in gclass197List)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                StarSystem.Class1180 class1180 = new StarSystem.Class1180();
                // ISSUE: reference to a compiler-generated field
                class1180.gclass197_0 = gclass197;
                TreeNode node1 = new TreeNode();
                if (gclass197List.Count > 1)
                {
                    // ISSUE: reference to a compiler-generated field
                    node1.Text = class1180.gclass197_0.method_18(gclass202_0.Race);
                    // ISSUE: reference to a compiler-generated field
                    node1.Tag = class1180.gclass197_0;
                    node1.Expand();
                }
                else
                    node1 = treeNode;

                // ISSUE: reference to a compiler-generated method
                foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class1180.method_0)
                             .ToList<PopulationData>())
                    node1.Nodes.Add(new TreeNode()
                    {
                        Text = gclass146.PopName,
                        Tag = gclass146.SystemBodyData
                    });
                // ISSUE: reference to a compiler-generated field
                foreach (SystemBodyData gclass1_1 in class1180.gclass197_0.method_15())
                {
                    TreeNode node2 = new TreeNode();
                    node2.Text = gclass1_1.method_78(gclass202_0.Race);
                    node2.Tag = gclass1_1;
                    foreach (SystemBodyData gclass1_2 in gclass1_1.method_82())
                        node2.Nodes.Add(new TreeNode()
                        {
                            Text = gclass1_2.method_78(gclass202_0.Race),
                            Tag = gclass1_2
                        });
                    node1.Nodes.Add(node2);
                }

                // ISSUE: reference to a compiler-generated field
                List<SystemBodyData> gclass1List1 = class1180.gclass197_0.method_16(gclass202_0.Race);
                if (gclass1List1.Count > 0)
                {
                    TreeNode node3 = new TreeNode();
                    node3.Text = "Asteroids";
                    foreach (SystemBodyData gclass1 in gclass1List1)
                        node3.Nodes.Add(new TreeNode()
                        {
                            Text = gclass1.method_78(gclass202_0.Race),
                            Tag = gclass1
                        });
                    node1.Nodes.Add(node3);
                }

                // ISSUE: reference to a compiler-generated field
                List<SystemBodyData> gclass1List2 = class1180.gclass197_0.method_17(gclass202_0.Race);
                if (gclass1List2.Count > 0)
                {
                    TreeNode node4 = new TreeNode();
                    node4.Text = "Comets";
                    foreach (SystemBodyData gclass1 in gclass1List2)
                        node4.Nodes.Add(new TreeNode()
                        {
                            Text = gclass1.method_78(gclass202_0.Race),
                            Tag = gclass1
                        });
                    node1.Nodes.Add(node4);
                }

                if (gclass197List.Count > 1)
                    treeNode.Nodes.Add(node1);
            }

            return treeNode;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2992);
            return null;
        }
    }

    public double method_39()
    {
        try
        {
            double num = 0.0;
            foreach (Star197 gclass197 in this.method_26())
            {
                if (gclass197.OrbitalDistance > num)
                    num = gclass197.OrbitalDistance;
            }

            foreach (SystemBodyData gclass1 in this.method_20())
            {
                if (gclass1.ParentBodyType == ParentBodyType.EnumVal0 && gclass1.OrbitalDistance > num)
                    num = gclass1.OrbitalDistance;
            }

            foreach (JumpPoint gclass120 in this.method_27())
            {
                if (gclass120.Distance > num)
                    num = gclass120.Distance;
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2993);
            return 1.0;
        }
    }
}